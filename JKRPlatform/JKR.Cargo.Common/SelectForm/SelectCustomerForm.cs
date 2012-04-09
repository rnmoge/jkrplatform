using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using JKR.GUI.LogixConnector;
using JKR.Cargo.Common.CommFunc;
using JKR.Cargo.PubFunction;

namespace JKR.Cargo.Common.SelectForm
{
    public partial class SelectCustomerForm : Form
    {
        private UIProxy m_uip;

        public string Customer_CName;
        public string Customer_Code;
        public string Customer_EName;
        public string Customer_Name;

        private bool m_IsAllowSelectBlack;
        public bool IsAllowSelectBlack
        {
            get
            {
                return this.m_IsAllowSelectBlack;
            }
            set
            {
                if (this.m_IsAllowSelectBlack != value)
                {
                    this.m_IsAllowSelectBlack = value;
                }
            }
        }

        public bool ActiveAccounts
        {
            set
            {
                //this.chkActive.Checked = value;
                //this.chkActive.Visible = !value;
            }
        }

        private string sJobType;
        public string JobType
        {
            set
            {
                this.sJobType = value;
            }
        }
        private string sLimit;


        public SelectCustomerForm()
        {
            InitializeComponent();
        }

        public SelectCustomerForm(string sTypeLimit, string jobType)
        {
            InitializeComponent();
            sLimit = sTypeLimit;
            sJobType = jobType;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string str=string.Empty;
            DataSet dataSetFunction = new DataSet();
            this.GetSql(ref str);
            dataSetFunction = this.m_uip.GetDataSetFunction("COM_EXECUTEQUERY", new object[] { str, "" });
            if ((dataSetFunction != null) && (dataSetFunction.Tables.Count > 0))
            {
                this.tlAccounts.DataSource = dataSetFunction.Tables[0];
                if (dataSetFunction.Tables[0].Rows.Count > 0)
                {
                    this.tlAccounts.Focus();
                }
                else
                {
                    this.edtKeyword.Focus();
                }
            }
        }

        #region 查询条件

        private void GetSql(ref string sSql)
        {
            string sKeyword;
            string sqlOffice= " AND D_ACCOUNTS2COMPANY.office_code='" + UIProxy.m_CurrentUserInformation.OfficeCode + "'";

            sKeyword = "'%" + this.edtKeyword.Text.Trim().Replace("'", "''") + "%'";

            sSql = " SELECT DISTINCT D_ACCOUNTS.ACCOUNTS_ID, PARENT_ID,ACCOUNTS_CODE, ADDITIONAL_NAME, ACCOUNTS_NAME,SHORT_NAME,D_ACCOUNTS2COMPANY.B_BLACK_LIST,D_ACCOUNTS2COMPANY.CREDIT_LEVEL FROM D_ACCOUNTS,D_ACCOUNTS2COMPANY WHERE  D_ACCOUNTS.ACCOUNTS_ID= D_ACCOUNTS2COMPANY.ACCOUNTS_ID  ";

            if (!string.IsNullOrEmpty(sLimit) && sLimit.ToUpper().IndexOf("B_CUSTOMER") > -1)
            {
                if (CommonHelper.ConvertToBool(SystemPara.GetSysPara(this.m_uip, ParaType.PARA_CHECK_ACCOUNT_INFORMATION)))
                {
                    string count=m_uip.GetSingleValBySQL("SELECT COUNT(USER_CODE) FROM D_USER WHERE USER_TYPE LIKE '%S%' AND USER_CODE = '" +UIProxy.m_CurrentUserInformation.UserCode + "'");
                    if (Convert.ToInt32(count) > 0)
                    {
                        sSql = " SELECT DISTINCT D_ACCOUNTS.ACCOUNTS_ID,   	" +
                           "                 PARENT_ID,                " +
                           "                 ACCOUNTS_CODE,            " +
                           "                 ADDITIONAL_NAME,          " +
                           "                 ACCOUNTS_NAME,            " +
                           "                 SHORT_NAME,               " +
                           "                 D_ACCOUNTS2COMPANY.B_BLACK_LIST,    " +
                           "                 D_ACCOUNTS2COMPANY.CREDIT_LEVEL     " +
                           "   FROM D_ACCOUNTS, D_ACCOUNTS2COMPANY, D_ACCOUNTS2COMPANY_DETAIL DETAIL  " +
                           "  WHERE D_ACCOUNTS.ACCOUNTS_ID = D_ACCOUNTS2COMPANY.ACCOUNTS_ID           " +
                           "        AND  D_ACCOUNTS2COMPANY.INTER_ID = DETAIL.INTER_ID  " +
                           "        AND  NVL(DETAIL.SALES,0)<>'0'  ";
                        sSql=sSql+m_uip.GenPrivilegeClause(PrivilegeItem.ADMIN_SALES_VIEWACCOUNT, new string[] {"DETAIL.SALES"});
                    }
                }
            }

            switch (this.sJobType)
            {
                case "SE":
                    sSql = sSql + " AND B_SEA_EXPORT = '1'  ";
                    break;

                case "SI":
                    sSql = sSql + " AND B_SEA_IMPORT = '1'  ";
                    break;

                case "AE":
                    sSql = sSql + " AND B_AIR_EXPORT = '1'  ";
                    break;

                case "AI":
                    sSql = sSql + " AND B_AIR_IMPORT = '1'  ";
                    break;
            }
            if (this.sLimit != string.Empty)
            {
                sSql = sSql + " AND " + this.sLimit;
            }
            sSql = sSql + sqlOffice + " AND (D_ACCOUNTS.ACCOUNTS_CODE LIKE " + sKeyword + " or D_ACCOUNTS.ACCOUNTS_NAME LIKE " + sKeyword + " or D_ACCOUNTS.ADDITIONAL_NAME LIKE " + sKeyword + " or D_ACCOUNTS.SHORT_NAME LIKE " + sKeyword + ")";
            if (this.chkActive.Checked)
            {
                sSql = sSql + " AND D_ACCOUNTS.B_ACTIVE=1 ";
            }

        }

        #endregion

        private void btnOK_Click(object sender, EventArgs e)
        {
            string strSQL=string.Empty;
            DataTable dt = new DataTable();

            if (tlAccounts.SelectedCells != null)
            {
                if (!this.IsAllowSelectBlack && tlAccounts.SelectedCells[4].ToString() == "1")
                {
                    m_uip.ShowErrorMsg(CommonMessageInfo.ACCOUNTINBLACKLISTCANNOTSELECTED);
                }
                else
                {
                    this.m_uip.ShowNormalMsg("");
                    this.Customer_Code = this.tlAccounts.SelectedCells[0].ToString();
                    this.Customer_Name = this.tlAccounts.SelectedCells[1].ToString();
                    this.Customer_EName = this.tlAccounts.SelectedCells[2].ToString();
                    this.Customer_CName = this.tlAccounts.SelectedCells[3].ToString();
                    this.DialogResult = DialogResult.OK;

                }
            }
        }

        private void SelectCustomerForm_Load(object sender, EventArgs e)
        {
            this.m_uip = UIProxy.GetInstance();
            this.edtKeyword.Focus();
            if (this.Customer_Code.Trim() != "")
            {
                this.edtKeyword.Text = this.Customer_Code;
                this.Customer_Code = "";
                this.btnSearch_Click(null, null);
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void edtKeyword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                this.btnSearch_Click(null, null);
            }

        }

        private void tlAccounts_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                this.btnOK_Click(null, null);
            }

        }

        private void tlAccounts_DoubleClick(object sender, EventArgs e)
        {
            this.btnOK_Click(null, null);

        }

        private void SelectCustomerForm_Activated(object sender, EventArgs e)
        {
            if (this.tlAccounts.SelectedCells.Count > 0)
            {
                this.tlAccounts.Focus();
            }
            else
            {
                this.edtKeyword.Focus();
            }

        }

    }
}
