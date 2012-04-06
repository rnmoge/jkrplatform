using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using JKR.GUI.LogixConnector;
using JKR.Cargo.Common;
using JKR.Cargo.PubFunction;
using JKR.GUI.BaseForm;
using Telerik.WinControls.UI;
using JKR.Cargo.Common.SelectForm;
using JKR.Cargo.Sales;

namespace JKRPlatform.BizSeaExport
{
    public partial class ExpensesInfor :Form //BasePopupEditForm
    {
        private DataSet m_ds;
        private UIProxy m_Uip = UIProxy.GetInstance();

        public ExpensesInfor()
        {
            InitializeComponent();
           
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.BindingContext[m_ds.Tables[0]].EndCurrentEdit();
            this.BindingContext[m_ds.Tables[1]].EndCurrentEdit();

            if (edtSCHEDULE_CODE.Text.Trim() == "")
            {
                m_Uip.ShowAlarmMsg(MessageInfo.SCHEDULE_CODE_EMPTY);
                edtSCHEDULE_CODE.Focus();
                return;
            }

            if (m_ds.HasErrors)
            {
                m_Uip.ShowErrorMsg("列表中存在错误！");
                return;
            }

            //check the schedule_code is in data
            if (m_ds.Tables["IFM_FREIGHT_SCHEDULE"].Rows[0].RowState == DataRowState.Added)
            {
                string str=m_Uip.GetSingleValBySQL("SELECT COUNT(SCHEDULE_CODE) FROM IFM_FREIGHT_SCHEDULE WHERE SCHEDULE_CODE='" + edtSCHEDULE_CODE.Text.Trim() + "'");
                if (int.Parse(str) >= 1)
                {
                    m_Uip.ShowErrorMsg(MessageInfo.SCHEDULECODEISEXIST);
                    return;
                }
            }

            if (edtJOB_TYPE.Text.Trim() == "")
            {
                m_Uip.ShowAlarmMsg(MessageInfo.JOB_TYPE_CODE_EMPTY);
                edtJOB_TYPE.Focus();
                return;
            }

            try
            {
                //xtz 09.03.12 更新人 更新时间
                m_ds.Tables["IFM_FREIGHT_SCHEDULE"].Rows[0]["UPDATE_BY"] = UIProxy.m_CurrentUserInformation.UserCode;
                m_ds.Tables["IFM_FREIGHT_SCHEDULE"].Rows[0]["UPDATE_DATE"] = DateTime.Now;
                m_Uip.ExecFunctionByName("SLS_FREIGHTSCHEDULE_GETLIST", "SaveData", new object[] { m_ds });

                DialogResult = DialogResult.OK;
            }
            catch (Exception)
            {
                m_Uip.ShowMessage(HintMessageType.MSG_SAVE_FAILURE);
            }
        }

        private void ExpensesInfor_Load(object sender, EventArgs e)
        {
            this.SetLookupData();
            this.SetJobTypeValue();
            this.CheckPrivilege();
            this.m_ds.Tables["IFM_FREIGHT_ITEM"].ColumnChanged += new DataColumnChangeEventHandler(this.FREIGHTITEMCellChange);

        }

        #region 自定义事件
        private void SetLookupData()
        {
            //LookupData.SetOrganizationLookup(this.edtOFFICE_CODE, this.m_Uip, "");
            //LookupData.SetChargeTypeLookup2(this.RepositoryItemLookUpEditChargeCode, this.m_Uip, "");
            LookupData.SetJobTypeImageCombobox(this.edtJOB_TYPE, this.m_Uip);
            //LookupData.SetCurrencyCombobox2(this.RepositoryItemComboBoxCurrency, this.m_Uip);
            //LookupData.SetContainerComboboxOrUnitType(this.RepositoryItemComboBoxUnitType, this.m_Uip, "");
            //LookupData.SetSysCodeCombobox2(this.RepositoryItemComboBoxCARGO_PROPERTY, this.m_Uip, "9006");
        }

        private void SetJobTypeValue()
        {
            if ((this.m_ds != null) && (this.m_ds.Tables[0].Rows.Count > 0))
            {
                this.edtJOB_TYPE.Text = this.m_ds.Tables[0].Rows[0]["JOB_TYPE"].ToString(); ;
            }
        }

        public void CheckPrivilege()
        {
            if (!this.m_Uip.CheckPrivilege(PrivilegeItem.SALES_FREIGHTSCHEDULE_SIGN))
            {
                this.edtB_ACTIVE.Enabled = false;
            }
            else
            {
                this.edtB_ACTIVE.Enabled = true;
            }
        }

        public void NewData(string job_type)
        {
            this.m_ds = this.m_Uip.GetDataSetByFunctionName("SLS_FREIGHTSCHEDULE_GETLIST", "NewData", new object[] { UIProxy.m_CurrentUserInformation.UserCode, job_type });
            this.m_ds.Tables[0].Rows[0]["OFFICE_CODE"] = UIProxy.m_CurrentUserInformation.OfficeCode;
            //this.edtSCHEDULE_CODE.Properties.ReadOnly = false;
            //this.BindAllFields();
        }

        public void EditData(string id)
        {
            this.m_ds = this.m_Uip.GetDataSetByFunctionName("SLS_FREIGHTSCHEDULE_GETLIST", "GetData", new object[] { id });
            this.edtSCHEDULE_CODE.ReadOnly = true;
            this.BindAllFields();
        }

        private void BindAllFields()
        {
            try
            {
                //this.BindFields(this.gbxGeneral, this.m_ds);
                this.grdItems.DataSource = this.m_ds.Tables["IFM_FREIGHT_ITEM"];
            }
            catch (Exception exception1)
            {

                Exception ex = exception1;

            }
        }

        private void LoadChargeTypes(string job_type)
        {
            string sFilter = string.Empty;
            switch (job_type)
            {
                case "AE":
                    sFilter = sFilter + "B_AIR_EXPORT=1";
                    break;

                case "AI":
                    sFilter = sFilter + "B_AIR_IMPORT=1";
                    break;

                case "SE":
                    sFilter = sFilter + "B_SEA_EXPORT=1";
                    break;

                case "SI":
                    sFilter = sFilter + "B_SEA_IMPORT=1";
                    break;
            }
            //LookupData.SetChargeTypeLookup2(this.grdItems.CurrentCell., this.m_Uip, sFilter);
        }

 


        #endregion

        private void edtCUSTOMER_CODE_Click(object sender, EventArgs e)
        {
            string s;
            if(this.edtCUSTOMER_CODE.RootElement.ToolTipText=="")
            {
                s="1=1";
            }       
            else
            {
                s = this.edtCUSTOMER_CODE.RootElement.ToolTipText;
                //s = ((ButtonEdit)sender).ToolTip;
            }

            SelectCustomerForm frm = new SelectCustomerForm(s, "");
           
            if (frm.ShowDialog() == DialogResult.OK)
            {
                this.edtCUSTOMER_CODE.Text = frm.Customer_Code;
                //((ButtonEdit)sender).Text = frm.Customer_Code;
            }
            frm.Dispose();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.BindingContext[this.m_ds.Tables["IFM_FREIGHT_ITEM"]].EndCurrentEdit();
            DataRow Row = this.m_ds.Tables["IFM_FREIGHT_ITEM"].NewRow();
            Row["FREIGHT_SCHEDULE_ID"] =this.m_ds.Tables["IFM_FREIGHT_SCHEDULE"].Rows[0]["FREIGHT_SCHEDULE_ID"];
            Row["FREIGHT_ITEM_ID"] = this.m_Uip.GetMasterSeqId();
            Row["CREATE_BY"] = UIProxy.m_CurrentUserInformation.UserCode;
            Row["CREATE_DATE"] = UIProxy.m_CurrDateTime;
            Row["ACCOUNTS_TYPE"] = "CU";
            Row["UNIT_TYPE"] = "JOB";
            Row["PRICE"] = 0;
            Row["CURRENCY_CODE"] = UIProxy.m_CurrentUserInformation.LocalCurrency;
            Row["PP_CC"] = "C";
            this.m_ds.Tables["IFM_FREIGHT_ITEM"].Rows.Add(Row);

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            Common.GetSelectedDataRow(this.grdItems).Delete();           
        }

        private void RepositoryItemButtonEditAccountsCode_ButtonClick(object sender, GridViewCollectionChangingEventArgs e)
        {
            SelectCustomerForm frm = new SelectCustomerForm("1=1", "");
            frm.Customer_Code =((RadMultiColumnComboBox)sender).Text.Trim();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                ((RadMultiColumnComboBox)sender).Text = frm.Customer_Code;
            }
        }


        private void FREIGHTITEMCellChange(object sender, DataColumnChangeEventArgs e)
        {
            if (e.Column.ColumnName.ToUpper() == "AR_AP")
            {
                if (e.Row["AR_AP"].Equals(0))
                {
                    if (!this.m_Uip.CheckPrivilege(PrivilegeItem.SALES_FREIGHTSCHEDULE_ITEM_AR))
                    {
                        e.Row.SetColumnError("AR_AP", MessageInfo.MSG_NO_PRIVILEGE);
                        this.m_Uip.ShowErrorMsg(HintMessageType.MSG_NO_PRIVILEGE);
                    }
                    else
                    {
                        e.Row.SetColumnError("AR_AP", "");
                    }
                }
                else if (e.Row["AR_AP"].Equals(1))
                {
                    if (!this.m_Uip.CheckPrivilege(PrivilegeItem.SALES_FREIGHTSCHEDULE_ITEM_AP))
                    {
                        e.Row.SetColumnError("AR_AP", MessageInfo.MSG_NO_PRIVILEGE);
                        this.m_Uip.ShowErrorMsg(HintMessageType.MSG_NO_PRIVILEGE);
                    }
                    else
                    {
                        e.Row.SetColumnError("AR_AP", "");
                    }
                }
            }
        }

        private void edtJOB_TYPE_SelectedValueChanged(object sender, EventArgs e)
        {
            if ((this.edtJOB_TYPE.SelectedValue.ToString().Trim() != "") & (this.edtJOB_TYPE.SelectedValue.ToString().Trim().Trim() != "(All)"))
            {
                this.LoadChargeTypes(this.edtJOB_TYPE.SelectedValue.ToString().Trim());
            }

        }

        private void edtJOB_TYPE_EditValueChanged1(object sender, EventArgs e)
        {
            if (this.edtJOB_TYPE.SelectedValue.ToString().Trim() != string.Empty)
            {
                //LookupData.SetContainerComboboxOrUnitType(this.RadMultiColumnComboBox, this.m_Uip, this.edtJOB_TYPE.SelectedValue.ToString().Trim());
            }
        }

        private void edtPort_Click(object sender, EventArgs e)
        {
            SelectPortForm frm = new SelectPortForm();
            frm.KeyWord = this.edtPort.Text.Trim();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                this.edtPort.Text = frm.PortCode.ToString(); ;
            }

        }

        private void RepositoryItemButtonEditCALC_REMARK_ButtonClick(object sender, GridViewCollectionChangingEventArgs e)
        {
            string jobType = this.m_ds.Tables["IFM_FREIGHT_SCHEDULE"].Rows[0]["JOB_TYPE"].ToString();
            CaleRemarkForm frm = new CaleRemarkForm();
            frm.GetCale_Remark = ((RadMultiColumnComboBox)sender).Text.Trim();
            if (frm.ShowDialog() == DialogResult.Yes)
            {
                ((RadMultiColumnComboBox)sender).Text = frm.GetCale_Remark;
            }
        }

        private void edtCarrier_SelectedValueChanged(object sender, EventArgs e)
        {
            //LookupData.SetAccCodeLookUp(edtCarrier, m_Uip, "B_CARRIER='1'", "B_SEA_EXPORT='1'");
        }

    }
}
