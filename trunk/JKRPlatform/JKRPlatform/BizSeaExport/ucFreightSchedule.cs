using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using JKR.GUI.LogixConnector;
using JKR.Cargo.PubFunction;
using JKR.Cargo.Common.CommFunc;
using JKR.Util;
using Telerik.WinControls.UI;
using JKR.Cargo.Common;
using JKRPlatform.Cargo;
using JKR.Cargo.Common.SelectForm;
using JKR.GUI.BaseForm;

namespace JKRPlatform.BizSeaExport
{
    public partial class ucFreightSchedule :UserControl 
    {
        #region 变量

        private DataTable m_DataTable;
        private DataSet m_DsDetail;
        private DataSet m_DsList;
        private UIProxy m_uip = UIProxy.GetInstance();

        #endregion

        #region 常量

        private class FunctionCode
        {
            // Fields
            public const string DeleteData = "AE_FREIGHTRATE_DELETEDATA";
            public const string LoadData = "AE_FREIGHTRATE_GETDATA";
            public const string LoadList = "AE_FREIGHTRATE_GETLIST";
            public const string NewData = "AE_FREIGHTRATE_NEWDATA";
            public const string SaveData = "AE_FREIGHTRATE_SAVEDATA";

        }

        #endregion

        public ucFreightSchedule()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            if (this.m_uip.CheckPrivilege(PrivilegeItem.SALES_FREIGHTSCHEDULE_ADD))
            {
                ExpensesInfor frm = new ExpensesInfor();
                frm.NewData(this.cbxJobType.Text);
                frm.ShowDialog();
                frm.Close();
            }
            else
            {
                this.m_uip.ShowErrorMsg(HintMessageType.MSG_NO_PRIVILEGE);
            }
        }

        private bool SetFormsAfterSearch()
        {
            if (this.m_DsList.Tables[0].Rows.Count == 0)
            {
                return false;
            }
            //this.JumpToPage(this.cpgList);
            return true;
        }

        private bool LoadList()
        {
            bool LoadList;
            try
            {
                string sql = "SELECT * FROM IFM_FREIGHT_SCHEDULE WHERE 1=1 ";
                string quotationNo = pubFunc.GetSqlFromTo("SCHEDULE_CODE", this.edtScheduleCode.Text.Trim(), this.edtScheduleCodeTo.Text.Trim(), false);
                if (quotationNo != string.Empty)
                {
                    sql = sql + quotationNo;
                }
                if ((this.cbxJobType.Text.Trim() != string.Empty) & (this.cbxJobType.Text.ToString() != "(ALL)"))
                {
                    sql = sql + " AND JOB_TYPE = '" + this.cbxJobType.Text.Trim() + "'";
                }
                if (this.edtCUSTOMER_CODE.Text.Trim() != string.Empty)
                {
                    sql = sql + " AND CUSTOMER_CODE = '" + this.edtCUSTOMER_CODE.Text.Trim() + "'";
                }
                if (this.edtShipper.Text.Trim() != string.Empty)
                {
                    sql = sql + " AND SHIPPER_CODE = '" + this.edtShipper.Text.Trim() + "'";
                }
                if (this.edtConsignee.Text.Trim() != string.Empty)
                {
                    sql = sql + " AND CONSIGNEE_CODE = '" + this.edtConsignee.Text.Trim() + "'";
                }
                if (this.edtAgent.Text.Trim() != string.Empty)
                {
                    sql = sql + " AND Agent_CODE ='" + this.edtAgent.Text.Trim() + "'";
                }
                if (this.edtPort.Text.Trim() != string.Empty)
                {
                    sql = sql + " AND PORT_CODE = '" + this.edtPort.Text.Trim() + "'";
                }
                sql = sql + pubFunc.GetSqlFromTo("EXPIRE_DATE", this.edtExpireDate_S.Text, this.edtExpireDate_E.Text, true);
                if (this.m_uip.CheckPrivilege("9121.1.0"))
                {
                    sql = sql + " AND CREATE_BY = '" + UIProxy.m_CurrentUserInformation.UserCode + "'";
                }
                else
                {
                    sql = sql + " AND 1=0 ";
                }
                this.m_DsList = Common.GetDataSet("AE_FREIGHTRATE_GETLIST", sql);
                this.grdFreightSchedule.DataSource = this.m_DsList.Tables[0];
                LoadList = true;
            }
            catch (Exception ex)
            {
                LoadList = false;

                return LoadList;
            }
            return LoadList;

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (this.LoadList())
            {
                if (this.SetFormsAfterSearch())
                {
                    this.m_uip.ShowNormalMsg(HintMessageType.MSG_RESULT_FOUNDED_FIELD, this.m_DsList.Tables[0].Rows.Count);
                }
                else
                {
                    this.m_uip.ShowMessage(HintMessageType.MSG_NOTIFY_SURE_FIELD);
                }
            }
            else
            {
                this.m_uip.ShowMessage(HintMessageType.MSG_NOTIFY_SURE_FIELD);
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (this.m_uip.CheckPrivilege(PrivilegeItem.SALES_FREIGHTSCHEDULE_EDIT))
            {

                GridViewDataRowInfo row = this.grdFreightSchedule.CurrentRow as GridViewDataRowInfo;
                if (row != null)
                {
                    string id = row["FREIGHT_SCHEDULE_ID"].ToString();
                    if (id != "")
                    {
                        ExpensesInfor frm = new ExpensesInfor();
                        frm.EditData(id);
                        if (frm.ShowDialog() == DialogResult.OK)
                        {
                            this.LoadList();
                        }
                        frm.Close();
                    }
                }
            }
            else
            {
                this.m_uip.ShowErrorMsg(HintMessageType.MSG_NO_PRIVILEGE);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.m_uip.CheckPrivilege(PrivilegeItem.SALES_FREIGHTSCHEDULE_DELETE))
            {
                GridViewDataRowInfo row = this.grdFreightSchedule.CurrentRow as GridViewDataRowInfo;
                if ((row != null) && ShowMessage.IsSureDelete(this))
                {
                    string id = row["FREIGHT_SCHEDULE_ID"].ToString();
                    if (id != "")
                    {
                        try
                        {
                            this.m_uip.ExecFunctionByName("SLS_FREIGHTSCHEDULE_GETLIST", "DeleteData", new object[] { id });
                            row.Delete();
                            this.m_uip.ShowMessage(HintMessageType.MSG_DELETE_SUCCESS);
                        }
                        catch (Exception ex)
                        {

                            this.m_uip.ShowMessage(HintMessageType.MSG_DELETE_FAILURE);

                        }
                    }
                }
            }
            else
            {
                this.m_uip.ShowErrorMsg(HintMessageType.MSG_NO_PRIVILEGE);
            }

        }

        private void btnReSet_Click(object sender, EventArgs e)
        {
            this.edtScheduleCode.Text = null;
            this.edtScheduleCodeTo.Text = null;
            this.edtShipper.Text = null;
            this.edtConsignee.Text = null;
            this.edtCUSTOMER_CODE.Text = null;
            this.edtPort.Text = null;
            this.edtAgent.Text = null;
            this.cbxJobType.SelectedIndex = 0;
            this.edtExpireDate_S.Text = DBNull.Value.ToString();
            this.edtExpireDate_E.Text = DBNull.Value.ToString(); ;
        }

        private void ucFreightSchedule_Load(object sender, EventArgs e)
        {
            //this.InitialGrid(this.grdFreightSchedule, false, false);
            LookupData.SetJobTypeImageCombobox(this.cbxJobType, this.m_uip);
            this.btnReSet_Click(null, null);
        }

        private void grdFreightSchedule_DoubleClick(object sender, EventArgs e)
        {
            this.btnEdit_Click(null, null);
        }

        private void edtCUSTOMER_CODE_Click(object sender, EventArgs e)
        {
            string s;
            if (((RadMultiColumnComboBox)sender).RootElement.ToolTipText == "")
            {
                s = "1=1";
            }
            else
            {
                s = ((RadMultiColumnComboBox)sender).RootElement.ToolTipText;
            }
            SelectCustomerForm frm = new SelectCustomerForm(s,"");
            //AccountsListForm frm = new AccountsListForm();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                ((RadMultiColumnComboBox)sender).Text = frm.Customer_Code;
            }
            frm.Dispose();
        }

        private void edtPort_Click(object sender, EventArgs e)
        {
            SelectPortForm frm = new SelectPortForm();
            frm.KeyWord = this.edtPort.Text.Trim();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                this.edtPort.Text = frm.PortCode.ToString();
            }
        }

    }
}
