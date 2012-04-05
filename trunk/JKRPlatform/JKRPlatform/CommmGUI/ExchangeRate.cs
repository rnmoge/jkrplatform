using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace JKRPlatform.CommmGUI
{
    public partial class ExchangeRate : Form
    {
        private string effect_date;
        private string expire_date;
        private string m_CompanyCode;
        private string m_CurrencyType;
        private bool m_IsPopupForm;

        public ExchangeRate()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("数据已经改变，请先保存", "汇率", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string sLimit = " 1=1 ";
            if (this.edtPARENT_COMPANY_CODE.get_Text().ToString() != string.Empty)
            {
                sLimit = sLimit + " AND COMPANY_CODE = '" + this.edtPARENT_COMPANY_CODE.get_Text().ToUpper() + "'";
            }
            if (this.chkActive.get_Checked())
            {
                sLimit = sLimit + " AND EFFECT_DATE<=SYSDATE AND (EXPIRE_DATE>SYSDATE OR EXPIRE_DATE IS NULL)";
            }
            this.GetExchangeRate(sLimit);
        }

        private void GetExchangeRate(string sLimit)
        {
            if (!this.m_IsPopupForm)
            {
                base.m_TableName = "D_FIX_EXCHANGE_RATE";
                base.m_KeyName = "FIX_EXCHANGE_RATE_ID";
                base.m_grd = this.grdMaster;
                base.m_dt = base.m_uip.GetSynchDataSet(base.m_TableName, base.m_KeyName, new string[0], sLimit).Tables[0];
                this.grdMaster.set_DataSource(base.m_dt);
                this.grdMaster.set_DataSource(base.m_dt.DataSet);
                this.grdMaster.set_DataMember(base.m_dt.TableName);
                base.m_dt.RowChanged += new DataRowChangeEventHandler(this.RowChanged);
                base.m_dt.RowDeleted += new DataRowChangeEventHandler(this.RowDeleted);
            }
            else
            {
                string sSql = "SELECT * FROM D_FIX_EXCHANGE_RATE WHERE COMPANY_CODE = '" + this.m_CompanyCode + "' AND CURR_SOURCE = '" + this.m_CurrencyType + "'";
                DataSet ds = base.m_uip.GetDataSetFunction("COM_EXECUTEQUERY", new object[] { sSql, "D_FIX_EXCHANGE_RATE" });
                this.grdMaster.set_DataSource(ds);
                this.grdMaster.set_DataMember(ds.Tables[0].TableName);
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
             if (base.m_dt != null)
    {
        if (base.m_dt.DataSet.HasChanges())
        {
            base.m_uip.ShowAlarmMsg(0xcb);
        }
        else
        {
            DataRow[] dr = CommonHelper.GetMultiSelectedDataRow(this.grdMaster);
            if ((dr != null) && (dr.Length != 0))
            {
                ExchangeRateCopyForm frm = new ExchangeRateCopyForm();
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    string sLimit = string.Empty;
                    string bSubOffice = string.Empty;
                    if (frm.chkSubOfficeToo.get_Checked())
                    {
                        bSubOffice = "ALL";
                    }
                    if (frm.chkAll.get_Checked())
                    {
                        sLimit = (" AND company_code='" + dr[0]["company_code"].ToString() + "'") + " AND EFFECT_DATE<=SYSDATE AND (EXPIRE_DATE>SYSDATE OR EXPIRE_DATE IS NULL)";
                    }
                    else
                    {
                        int VB$t_i4$L0 = dr.Length - 1;
                        for (int i = 0; i <= VB$t_i4$L0; i++)
                        {
                            if (i == 0)
                            {
                                sLimit = dr[i]["FIX_EXCHANGE_RATE_ID"].ToString();
                            }
                            else
                            {
                                sLimit = sLimit + "," + dr[i]["FIX_EXCHANGE_RATE_ID"].ToString();
                            }
                        }
                        sLimit = " AND FIX_EXCHANGE_RATE_ID IN (" + sLimit + ")";
                    }
                    if (Conversions.ToBoolean(base.m_uip.ExecFunctionByName("ADMIN_MASTER_DATA", "CopyExchangeRate", new object[] { sLimit, frm.edtPARENT_COMPANY_CODE.get_EditValue().ToString(), bSubOffice })))
                    {
                        base.m_uip.ShowMessage(0xc9);
                    }
                    else
                    {
                        base.m_uip.ShowMessage(0xca);
                    }
                }
            }
        }
    }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
             this.radGridView1.Rows.AddNew();
            this.btnSave.Enabled = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            this.btnSave.Enabled = true;
            this.radGridView1.ReadOnly = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
             if (MessageBox.Show("是否删除？", "系统", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                int number = this.radGridView1.Rows.Count;
                for (int i = 0; i < number; i++)
                {
                    if (this.radGridView1.Rows[i].IsSelected == true)
                    {
                        this.radGridView1.Rows[i].Delete();
                        break;
                    }
                }
                this.btnSave.Enabled = false;                
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
             int number = this.radGridView1.Rows.Count;
            for (int i = 0; i < number; i++)
            {
                if (this.radGridView1.Rows[i].IsSelected == true)
                {
                    int num = this.radGridView1.ColumnCount;
                    for (int j = 0; j < num; j++)
                    {
                        string name = this.radGridView1.MasterGridViewInfo.CurrentRow.Cells[j].Value.ToString();
                        return;
                    }
                }
            }
        }

 

    }
}
