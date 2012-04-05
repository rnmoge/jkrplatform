using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.CompilerServices;

namespace JKRPlatform.CommmGUI
{
    public partial class AccountInfoForm : Form
    {
        private string _wacoCode;
        private IContainer components;
        private string effect_date;
        //private TabCtl evTab;
        private string expire_date;
        private string m_AccountID;
        private DataSet m_detailDataSet;
        private DataSet m_ds;
        private DataView m_dvAirPort;
        private DataView m_dvRelateConsignee;
        private DataView m_dvRelateShipper;
        private DataView m_dvSeaPort;
        private string m_Entry;
        //private UIProxy m_uip;


        public AccountInfoForm()
        {
            InitializeComponent();
            this.grdExchangeRate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.grdEvent.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
        }

        internal void NewAccountsCode()
        {
            this.chkB_SOC.set_Checked(false);
            //this.m_ds = this.m_uip.GetDataSetFunction("ADMIN_ACCCODE_NEWDATA", new object[] { UIProxy.m_CurrentUserInformation.get_UserCode(), UIProxy.m_CurrentUserInformation.get_OfficeCode() });
            this.m_AccountID = this.m_ds.Tables["D_ACCOUNTS"].Rows[0]["ACCOUNTS_ID"].ToString();
            DataTable dt = this.m_ds.Tables["D_CUSTOMER_INVOICE_ADDRESS"];
            dt.Columns["INVOICE_ADDRESS"].Unique = true;
            this.BindAllFields();
            //this.edtACCOUNTS_CODE.get_Properties().set_ReadOnly(false);
            this.edtACCOUNTS_CODE.set_BackColor(SystemColors.Window);
        }

        private void SetBindFields(Control Ctls, DataTable dt)
        {
            //IEnumerator VB$t_ref$L0;
            try
            {
                //VB$t_ref$L0 = Ctls.Controls.GetEnumerator();
                //while (VB$t_ref$L0.MoveNext())
                //{
                //    Control Ctl = (Control) VB$t_ref$L0.Current;
                //    if (DataProcess.FindColumn(dt, Strings.Mid(Ctl.Name, 4)))
                //    {
                //        Ctl.DataBindings.Clear();
                //        Ctl.DataBindings.Add(new Binding("EditValue", dt.DataSet, dt.TableName + "." + Strings.Mid(Ctl.Name, 4)));
                //    }
                //}
            }
            finally
            {
                //if (VB$t_ref$L0 is IDisposable)
                //{
                //    (VB$t_ref$L0 as IDisposable).Dispose();
                //}
            }
        }

        internal virtual Panel pnlButtom
        {
            //[DebuggerNonUserCode]
            get
            {
                return this._pnlButtom;
            }
            //[MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                //this._pnlButtom = value;
            }
        }

        private void Accounts_RowChanged(object sender, DataRowChangeEventArgs e)
        {
            DataRow row = e.Row;
            this.m_ds.Tables["D_ACCOUNTS"].RowChanged -= new DataRowChangeEventHandler(this.Accounts_RowChanged);
            try
            {
                if (row.RowState == DataRowState.Added)
                {
                    //row["CREATE_BY"] = UIProxy.m_CurrentUserInformation.get_UserCode();
                    //row["CREATE_DATE"] = UIProxy.m_CurrDateTime.ToString();
                    //row["UPDATE_BY"] = UIProxy.m_CurrentUserInformation.get_UserCode();
                    //row["UPDATE_DATE"] = UIProxy.m_CurrDateTime.ToString();
                }
                if (row.RowState == DataRowState.Modified)
                {
                    //row["UPDATE_BY"] = UIProxy.m_CurrentUserInformation.get_UserCode();
                    //row["UPDATE_DATE"] = UIProxy.m_CurrDateTime.ToString();
                }
            }
            finally
            {
                this.m_ds.Tables["D_ACCOUNTS"].RowChanged += new DataRowChangeEventHandler(this.Accounts_RowChanged);
            }
        }

        private void CONTACT_Rowchanged(object sender, DataRowChangeEventArgs e)
        {
            DataRow row = e.Row;
            this.m_ds.Tables["D_CONTACT"].RowChanged -= new DataRowChangeEventHandler(this.CONTACT_Rowchanged);
            try
            {
                if (row.RowState == DataRowState.Modified)
                {
                    //row["UPDATE_BY"] = UIProxy.m_CurrentUserInformation.get_UserCode();
                    //row["UPDATE_DATE"] = UIProxy.m_CurrDateTime.ToString();
                }
            }
            finally
            {
                this.m_ds.Tables["D_CONTACT"].RowChanged += new DataRowChangeEventHandler(this.CONTACT_Rowchanged);
            }
        }

        private void Contact_Rowchanging(object sender, DataRowChangeEventArgs e)
        {
            //    int VB$ResumeTarget;
            //    try
            //    {
            //        int VB$CurrentStatement;
            //    Label_0000:
            //        ProjectData.ClearProjectError();
            //        int VB$ActiveHandler = -2;
            //    Label_0008:
            //        VB$CurrentStatement = 2;
            //        DataRow row = e.Row;
            //    Label_0011:
            //        VB$CurrentStatement = 3;
            //        if (row.RowState == DataRowState.Detached)
            //        {
            //            goto Label_00EF;
            //        }
            //    Label_001C:
            //        VB$CurrentStatement = 4;
            //        if (row["CONTACT_NAME"].ToString().Trim() != "")
            //        {
            //            goto Label_0055;
            //        }
            //    Label_0041:
            //        VB$CurrentStatement = 5;
            //        row.SetColumnError("CONTACT_NAME", MessageInfo.MSG_DATA_CANNOT_EMPTY);
            //        goto Label_00EF;
            //    Label_0055:
            //        VB$CurrentStatement = 7;
            //    Label_0057:
            //        VB$CurrentStatement = 8;
            //        row.SetColumnError("CONTACT_NAME", "");
            //        goto Label_00EF;
            //    Label_006E:
            //        VB$ResumeTarget = 0;
            //        switch ((VB$ResumeTarget + 1))
            //        {
            //            case 1:
            //                goto Label_0000;

            //            case 2:
            //                goto Label_0008;

            //            case 3:
            //                goto Label_0011;

            //            case 4:
            //                goto Label_001C;

            //            case 5:
            //                goto Label_0041;

            //            case 6:
            //            case 9:
            //            case 10:
            //            case 11:
            //                goto Label_00EF;

            //            case 7:
            //                goto Label_0055;

            //            case 8:
            //                goto Label_0057;

            //            default:
            //                goto Label_00E4;
            //        }
            //    Label_00AA:
            //        VB$ResumeTarget = VB$CurrentStatement;
            //        switch (((VB$ActiveHandler > -2) ? VB$ActiveHandler : 1))
            //        {
            //            case 0:
            //                goto Label_00E4;

            //            case 1:
            //                goto Label_006E;
            //        }
            //    }
            //    catch (object obj1) when (?)
            //    {
            //        ProjectData.SetProjectError((Exception) obj1);
            //        goto Label_00AA;
            //    }
            //Label_00E4:
            //    throw ProjectData.CreateProjectError(-2146828237);
            //Label_00EF:
            //    if (VB$ResumeTarget != 0)
            //    {
            //        ProjectData.ClearProjectError();
            //    }
        }

        private void Customer_Rowchanged(object sender, DataRowChangeEventArgs e)
        {
            DataRow row = e.Row;
            this.m_ds.Tables["D_ACCOUNTS_CUSTOMER"].RowChanged -= new DataRowChangeEventHandler(this.Customer_Rowchanged);
            try
            {
                if (row.RowState == DataRowState.Modified)
                {
                    //row["UPDATE_BY"] = UIProxy.m_CurrentUserInformation.get_UserCode();
                    //row["UPDATE_DATE"] = UIProxy.m_CurrDateTime.ToString();
                }
            }
            finally
            {
                this.m_ds.Tables["D_ACCOUNTS_CUSTOMER"].RowChanged += new DataRowChangeEventHandler(this.Customer_Rowchanged);
            }
        }

        private void CustomerKcNo_Rowchanged(object sender, DataRowChangeEventArgs e)
        {
            DataRow row = e.Row;
            this.m_ds.Tables["D_SHIPPER_KC_NO"].RowChanged -= new DataRowChangeEventHandler(this.CustomerKcNo_Rowchanged);
            try
            {
                if (row.RowState == DataRowState.Modified)
                {
                    //row["UPDATE_BY"] = UIProxy.m_CurrentUserInformation.get_UserCode();
                    //row["UPDATE_DATE"] = UIProxy.m_CurrDateTime.ToString();
                }
            }
            finally
            {
                this.m_ds.Tables["D_SHIPPER_KC_NO"].RowChanged += new DataRowChangeEventHandler(this.CustomerKcNo_Rowchanged);
            }
        }

        private void Nvocc_Rowchanged(object sender, DataRowChangeEventArgs e)
        {
            DataRow row = e.Row;
            this.m_ds.Tables["D_ACCOUNTS_NVOCC"].RowChanged -= new DataRowChangeEventHandler(this.Nvocc_Rowchanged);
            try
            {
                if (row.RowState == DataRowState.Modified)
                {
                    //row["update_by"] = UIProxy.m_CurrentUserInformation.get_UserCode();
                    //row["update_date"] = UIProxy.m_CurrDateTime.ToString();
                }
            }
            finally
            {
                this.m_ds.Tables["D_ACCOUNTS_NVOCC"].RowChanged += new DataRowChangeEventHandler(this.Nvocc_Rowchanged);
            }
        }

        private void Accounts2Company_ROWCHANGED(object SENDER, DataRowChangeEventArgs E)
        {
            this.m_ds.Tables["D_ACCOUNTS2COMPANY"].RowChanged -= new DataRowChangeEventHandler(this.Accounts2Company_ROWCHANGED);
            DataRow ROW = E.Row;
            int m_debitCreditNO_Control = Conversions.ToInteger(SystemPara.GetSysPara(this.m_uip, 0x1b59));
            try
            {
                string accountsID = this.m_ds.Tables["D_ACCOUNTS"].Rows[0]["ACCOUNTS_ID"].ToString();
                string OFFICE_CODE = ROW["OFFICE_CODE"].ToString();
                if (this.CheckRepeat(this.m_ds.Tables["D_ACCOUNTS2COMPANY"], "OFFICE_CODE", OFFICE_CODE))
                {
                    ROW.SetColumnError("OFFICE_CODE", MessageInfo.ACCOUNT_COMPANY_DUPLICATE);
                    return;
                }
                ROW.SetColumnError("OFFICE_CODE", "");
                string m_CREDIT_CODE = ROW["CREDIT_CODE"].ToString();
                if (m_CREDIT_CODE != string.Empty)
                {
                    if (Conversions.ToDouble(this.m_uip.GetSingleValBySQL("SELECT COUNT(CREDIT_CODE) FROM D_ACCOUNTS2COMPANY WHERE OFFICE_CODE ='" + E.Row["OFFICE_CODE"].ToString() + "' AND CREDIT_CODE= '" + m_CREDIT_CODE + "' AND ACCOUNTS_ID <> " + accountsID)) > 0.0)
                    {
                        ROW.SetColumnError("CREDIT_CODE", MessageInfo.MSG_SUPPLIER_CODE_SAME_IN_DIFF_ACCOUNTS);
                        return;
                    }
                    ROW.SetColumnError("CREDIT_CODE", "");
                }
                string m_DEBIT_CODE = ROW["DEBIT_CODE"].ToString();
                if (m_DEBIT_CODE != string.Empty)
                {
                    if (Conversions.ToDouble(this.m_uip.GetSingleValBySQL("SELECT COUNT(DEBIT_CODE) FROM D_ACCOUNTS2COMPANY WHERE OFFICE_CODE ='" + E.Row["OFFICE_CODE"].ToString() + "' AND DEBIT_CODE= '" + m_DEBIT_CODE + "' AND ACCOUNTS_ID <> " + accountsID)) > 0.0)
                    {
                        ROW.SetColumnError("DEBIT_CODE", MessageInfo.MSG_DEBIT_CODE_SAME_IN_DIFF_ACCOUNTS);
                        return;
                    }
                    ROW.SetColumnError("DEBIT_CODE", "");
                }
                switch (m_debitCreditNO_Control)
                {
                    case 1:
                        if (ROW.HasErrors)
                        {
                            goto Label_0364;
                        }
                        if (m_CREDIT_CODE != string.Empty)
                        {
                            if (!this.CheckRepeat(this.m_ds.Tables["D_ACCOUNTS2COMPANY"], "CREDIT_CODE", m_CREDIT_CODE))
                            {
                                break;
                            }
                            this.m_uip.ShowErrorMsg(MessageInfo.MSG_SUPPLIER_CODE_SAME_IN_DIFF_OFFICE);
                        }
                        goto Label_02AA;

                    case 3:
                        if (m_CREDIT_CODE != string.Empty)
                        {
                            if (m_DEBIT_CODE != m_CREDIT_CODE)
                            {
                                ROW.SetColumnError("DEBIT_CODE", MessageInfo.MSG_DEBIT_CODE_SAME_WITH_SUPPLIER_CODE);
                                ROW.SetColumnError("CREDIT_CODE", MessageInfo.MSG_DEBIT_CODE_SAME_WITH_SUPPLIER_CODE);
                                return;
                            }
                            ROW.SetColumnError("DEBIT_CODE", "");
                            ROW.SetColumnError("CREDIT_CODE", "");
                        }
                        goto Label_0364;

                    default:
                        goto Label_0364;
                }
                ROW.SetColumnError("CREDIT_CODE", "");
            Label_02AA:
                if (m_DEBIT_CODE != string.Empty)
                {
                    if (this.CheckRepeat(this.m_ds.Tables["D_ACCOUNTS2COMPANY"], "DEBIT_CODE", m_DEBIT_CODE))
                    {
                        this.m_uip.ShowErrorMsg(MessageInfo.MSG_DEBIT_CODE_SAME_IN_DIFF_OFFICE);
                    }
                    else
                    {
                        ROW.SetColumnError("DEBIT_CODE", "");
                    }
                }
            Label_0364:
                if (ROW.RowState == DataRowState.Modified)
                {
                    ROW["UPDATE_BY"] = UIProxy.m_CurrentUserInformation.get_UserCode();
                    ROW["UPDATE_DATE"] = UIProxy.m_CurrDateTime.ToString();
                }
            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                Exception ex = exception1;
                throw ex;
            }
            finally
            {
                this.m_ds.Tables["D_ACCOUNTS2COMPANY"].RowChanged += new DataRowChangeEventHandler(this.Accounts2Company_ROWCHANGED);
            }
        }

        private void SpecialReq_ROWCHANGED(object SENDER, DataRowChangeEventArgs E)
        {
            DataRow ROW = E.Row;
            this.m_ds.Tables["D_ACCOUNTS_SPECIAL_REQ"].RowChanged -= new DataRowChangeEventHandler(this.SpecialReq_ROWCHANGED);
            try
            {
                if (ROW.RowState == DataRowState.Added)
                {
                    if (ROW["CUSTOMER2SPECIAL_ID"].ToString() == "")
                    {
                        ROW["CUSTOMER2SPECIAL_ID"] = this.m_uip.GetMasterSeqId();
                    }
                    ROW["ACCOUNTS_ID"] = RuntimeHelpers.GetObjectValue(this.m_ds.Tables["D_ACCOUNTS"].Rows[0]["ACCOUNTS_ID"]);
                    ROW["CREATE_BY"] = UIProxy.m_CurrentUserInformation.get_UserCode();
                    ROW["CREATE_DATE"] = UIProxy.m_CurrDateTime.ToString();
                    ROW["UPDATE_BY"] = UIProxy.m_CurrentUserInformation.get_UserCode();
                    ROW["UPDATE_DATE"] = UIProxy.m_CurrDateTime.ToString();
                }
                if (ROW.RowState == DataRowState.Modified)
                {
                    ROW["UPDATE_BY"] = UIProxy.m_CurrentUserInformation.get_UserCode();
                    ROW["UPDATE_DATE"] = UIProxy.m_CurrDateTime.ToString();
                }
            }
            finally
            {
                this.m_ds.Tables["D_ACCOUNTS_SPECIAL_REQ"].RowChanged += new DataRowChangeEventHandler(this.SpecialReq_ROWCHANGED);
            }
        }

        private void airlineSURCHARGE_Rowchanged(object sender, DataRowChangeEventArgs e)
        {
            DataRow row = e.Row;
            this.m_ds.Tables["D_AIRLINE_SURCHARGE"].RowChanged -= new DataRowChangeEventHandler(this.airlineSURCHARGE_Rowchanged);
            try
            {
                if (row.RowState == DataRowState.Modified)
                {
                    row["UPDATE_BY"] = UIProxy.m_CurrentUserInformation.get_UserCode();
                    row["UPDATE_DATE"] = UIProxy.m_CurrDateTime.ToString();
                }
            }
            finally
            {
                this.m_ds.Tables["D_AIRLINE_SURCHARGE"].RowChanged += new DataRowChangeEventHandler(this.airlineSURCHARGE_Rowchanged);
            }
        }

        private void seaosagent_Rowchanged(object sender, DataRowChangeEventArgs e)
        {
            DataRow row = e.Row;
            this.m_ds.Tables["D_ACCOUNTS_SEA_OSAGENT"].RowChanged -= new DataRowChangeEventHandler(this.seaosagent_Rowchanged);
            try
            {
                if (row.RowState == DataRowState.Modified)
                {
                    row["UPDATE_BY"] = UIProxy.m_CurrentUserInformation.get_UserCode();
                    row["UPDATE_DATE"] = UIProxy.m_CurrDateTime.ToString();
                }
            }
            finally
            {
                this.m_ds.Tables["D_ACCOUNTS_SEA_OSAGENT"].RowChanged += new DataRowChangeEventHandler(this.seaosagent_Rowchanged);
            }
        }

        private void airosagent_Rowchanged(object sender, DataRowChangeEventArgs e)
        {
            DataRow row = e.Row;
            this.m_ds.Tables["D_ACCOUNTS_AIR_OSAGENT"].RowChanged -= new DataRowChangeEventHandler(this.airosagent_Rowchanged);
            try
            {
                if (row.RowState == DataRowState.Modified)
                {
                    row["UPDATE_BY"] = UIProxy.m_CurrentUserInformation.get_UserCode();
                    row["UPDATE_DATE"] = UIProxy.m_CurrDateTime.ToString();
                }
            }
            finally
            {
                this.m_ds.Tables["D_ACCOUNTS_AIR_OSAGENT"].RowChanged += new DataRowChangeEventHandler(this.airosagent_Rowchanged);
            }
        }

        private void CUSTOMER2AIRAGENT_ROWCHANGED(object SENDER, DataRowChangeEventArgs E)
        {
            DataRow ROW = E.Row;
            this.m_ds.Tables["D_CUSTOMER2AIRAGENT"].RowChanged -= new DataRowChangeEventHandler(this.CUSTOMER2AIRAGENT_ROWCHANGED);
            try
            {
                if (ROW.RowState == DataRowState.Modified)
                {
                    ROW["UPDATE_BY"] = UIProxy.m_CurrentUserInformation.get_UserCode();
                    ROW["UPDATE_DATE"] = UIProxy.m_CurrDateTime.ToString();
                }
            }
            finally
            {
                this.m_ds.Tables["D_CUSTOMER2AIRAGENT"].RowChanged += new DataRowChangeEventHandler(this.CUSTOMER2AIRAGENT_ROWCHANGED);
            }
        }

        private void ACCOUNTS2PORTS_ROWCHANGED(object SENDER, DataRowChangeEventArgs E)
        {
            DataRow ROW = E.Row;
            this.m_ds.Tables["D_ACCOUNTS2PORTS"].RowChanged -= new DataRowChangeEventHandler(this.ACCOUNTS2PORTS_ROWCHANGED);
            try
            {
                if (ROW.RowState == DataRowState.Modified)
                {
                    ROW["UPDATE_BY"] = UIProxy.m_CurrentUserInformation.get_UserCode();
                    ROW["UPDATE_DATE"] = UIProxy.m_CurrDateTime.ToString();
                }
            }
            finally
            {
                this.m_ds.Tables["D_ACCOUNTS2PORTS"].RowChanged += new DataRowChangeEventHandler(this.ACCOUNTS2PORTS_ROWCHANGED);
            }
        }

        private void PREFERCARRIER_ROWCHANGED(object SENDER, DataRowChangeEventArgs E)
        {
            DataRow ROW = E.Row;
            this.m_ds.Tables["D_PREFER_CARRIER"].RowChanged -= new DataRowChangeEventHandler(this.PREFERCARRIER_ROWCHANGED);
            try
            {
                if (ROW.RowState == DataRowState.Modified)
                {
                    ROW["UPDATE_BY"] = UIProxy.m_CurrentUserInformation.get_UserCode();
                    ROW["UPDATE_DATE"] = UIProxy.m_CurrDateTime.ToString();
                }
            }
            finally
            {
                this.m_ds.Tables["D_PREFER_CARRIER"].RowChanged += new DataRowChangeEventHandler(this.PREFERCARRIER_ROWCHANGED);
            }
        }

        private void AIRLINESERVICE_ROWCHANGED(object SENDER, DataRowChangeEventArgs E)
        {
            DataRow ROW = E.Row;
            this.m_ds.Tables["D_AIRLINE_SERVICE"].RowChanged -= new DataRowChangeEventHandler(this.AIRLINESERVICE_ROWCHANGED);
            try
            {
                if (ROW.RowState == DataRowState.Modified)
                {
                    ROW["UPDATE_BY"] = UIProxy.m_CurrentUserInformation.get_UserCode();
                    ROW["UPDATE_DATE"] = UIProxy.m_CurrDateTime.ToString();
                }
            }
            finally
            {
                this.m_ds.Tables["D_AIRLINE_SERVICE"].RowChanged += new DataRowChangeEventHandler(this.AIRLINESERVICE_ROWCHANGED);
            }
        }

        private void AIRLINEPORT_ROWCHANGED(object SENDER, DataRowChangeEventArgs E)
        {
            DataRow ROW = E.Row;
            this.m_ds.Tables["D_AIRLINE_PORT"].RowChanged -= new DataRowChangeEventHandler(this.AIRLINEPORT_ROWCHANGED);
            try
            {
                if (ROW.RowState == DataRowState.Modified)
                {
                    ROW["UPDATE_BY"] = UIProxy.m_CurrentUserInformation.get_UserCode();
                    ROW["UPDATE_DATE"] = UIProxy.m_CurrDateTime.ToString();
                }
            }
            finally
            {
                this.m_ds.Tables["D_AIRLINE_PORT"].RowChanged += new DataRowChangeEventHandler(this.AIRLINEPORT_ROWCHANGED);
            }
        }

        private void MAILADDRESS_ROWCHANGED(object SENDER, DataRowChangeEventArgs E)
        {
            DataRow ROW = E.Row;
            this.m_ds.Tables["D_PREALERT_MAIL_ADDRESS"].RowChanged -= new DataRowChangeEventHandler(this.MAILADDRESS_ROWCHANGED);
            try
            {
                if (ROW.RowState == DataRowState.Modified)
                {
                    ROW["UPDATE_BY"] = UIProxy.m_CurrentUserInformation.get_UserCode();
                    ROW["UPDATE_DATE"] = UIProxy.m_CurrDateTime.ToString();
                }
            }
            finally
            {
                this.m_ds.Tables["D_PREALERT_MAIL_ADDRESS"].RowChanged += new DataRowChangeEventHandler(this.MAILADDRESS_ROWCHANGED);
            }
        }

        private void EXCHANGERATE_ROWCHANGED(object SENDER, DataRowChangeEventArgs E)
        {
            DataRow ROW = E.Row;
            this.m_ds.Tables["D_ACCOUNTS_EXCHANGE_RATE"].RowChanged -= new DataRowChangeEventHandler(this.EXCHANGERATE_ROWCHANGED);
            try
            {
                if (ROW.RowState == DataRowState.Modified)
                {
                    ROW["UPDATE_BY"] = UIProxy.m_CurrentUserInformation.get_UserCode();
                    ROW["UPDATE_DATE"] = UIProxy.m_CurrDateTime.ToString();
                }
            }
            finally
            {
                this.m_ds.Tables["D_ACCOUNTS_EXCHANGE_RATE"].RowChanged += new DataRowChangeEventHandler(this.EXCHANGERATE_ROWCHANGED);
            }
        }

        private void CARGOGROUP_RowChanged(object sender, DataRowChangeEventArgs e)
        {
            DataRow row = e.Row;
            this.m_ds.Tables["D_SHIPLINE_CARGO_GROUP"].RowChanged -= new DataRowChangeEventHandler(this.CARGOGROUP_RowChanged);
            try
            {
                if (row.RowState == DataRowState.Modified)
                {
                    row["UPDATE_BY"] = UIProxy.m_CurrentUserInformation.get_UserCode();
                    row["UPDATE_DATE"] = UIProxy.m_CurrDateTime.ToString();
                }
            }
            finally
            {
                this.m_ds.Tables["D_SHIPLINE_CARGO_GROUP"].RowChanged += new DataRowChangeEventHandler(this.CARGOGROUP_RowChanged);
            }
        }

        private void INVOICEADDRESS_ROWCHANGED(object SENDER, DataRowChangeEventArgs E)
        {
            DataRow ROW = E.Row;
            this.m_ds.Tables["D_CUSTOMER_INVOICE_ADDRESS"].RowChanged -= new DataRowChangeEventHandler(this.INVOICEADDRESS_ROWCHANGED);
            try
            {
                if (ROW.RowState == DataRowState.Modified)
                {
                    ROW["UPDATE_BY"] = UIProxy.m_CurrentUserInformation.get_UserCode();
                    ROW["UPDATE_DATE"] = UIProxy.m_CurrDateTime.ToString();
                }
            }
            finally
            {
                this.m_ds.Tables["D_CUSTOMER_INVOICE_ADDRESS"].RowChanged += new DataRowChangeEventHandler(this.INVOICEADDRESS_ROWCHANGED);
            }
        }

        private void BILLADDRESS_ROWCHANGED(object SENDER, DataRowChangeEventArgs E)
        {
            DataRow ROW = E.Row;
            this.m_ds.Tables["D_CUSTOMER_BILL_ADDRESS"].RowChanged -= new DataRowChangeEventHandler(this.BILLADDRESS_ROWCHANGED);
            try
            {
                if (ROW.RowState == DataRowState.Modified)
                {
                    ROW["UPDATE_BY"] = UIProxy.m_CurrentUserInformation.get_UserCode();
                    ROW["UPDATE_DATE"] = UIProxy.m_CurrDateTime.ToString();
                }
            }
            finally
            {
                this.m_ds.Tables["D_CUSTOMER_BILL_ADDRESS"].RowChanged += new DataRowChangeEventHandler(this.BILLADDRESS_ROWCHANGED);
            }
        }

        private void shipLINEPORT_ROWCHANGED(object SENDER, DataRowChangeEventArgs E)
        {
            DataRow ROW = E.Row;
            this.m_ds.Tables["D_SHIPLINE_PORT"].RowChanged -= new DataRowChangeEventHandler(this.shipLINEPORT_ROWCHANGED);
            try
            {
                if (ROW.RowState == DataRowState.Modified)
                {
                    ROW["UPDATE_BY"] = UIProxy.m_CurrentUserInformation.get_UserCode();
                    ROW["UPDATE_DATE"] = UIProxy.m_CurrDateTime.ToString();
                }
            }
            finally
            {
                this.m_ds.Tables["D_SHIPLINE_PORT"].RowChanged += new DataRowChangeEventHandler(this.shipLINEPORT_ROWCHANGED);
            }
        }

        private void AdditionalNo_RowChanged(object sender, DataRowChangeEventArgs e)
        {
            DataRow row = e.Row;
            this.m_ds.Tables["D_ACCOUNTS_ADD_NO"].RowChanged -= new DataRowChangeEventHandler(this.AdditionalNo_RowChanged);
            try
            {
                if (row.RowState == DataRowState.Modified)
                {
                    row["UPDATE_BY"] = UIProxy.m_CurrentUserInformation.get_UserCode();
                    row["UPDATE_DATE"] = UIProxy.m_CurrDateTime.ToString();
                }
            }
            finally
            {
                this.m_ds.Tables["D_ACCOUNTS_ADD_NO"].RowChanged += new DataRowChangeEventHandler(this.AdditionalNo_RowChanged);
            }
        }

        private void BindAllFields()
        {
            this.InitSingleRecordTable();
            this.SetBindFields(this.gbxGeneral, this.m_ds.Tables["D_ACCOUNTS"]);
            this.SetBindFields(this.gbxName, this.m_ds.Tables["D_ACCOUNTS"]);
            this.SetBindFields(this.gbxRoles, this.m_ds.Tables["D_ACCOUNTS"]);
            this.SetBindFields(this.gbxAddress, this.m_ds.Tables["D_ACCOUNTS"]);
            this.SetBindFields(this.tabRemark, this.m_ds.Tables["D_ACCOUNTS"]);
            this.SetBindFields(this.pnlButtom, this.m_ds.Tables["D_ACCOUNTS"]);
            this.grdContacts.set_DataSource(this.m_ds.Tables["D_CONTACT"]);
            this.grdAccounts2Company.set_DataSource(this.m_ds);
            this.grdAccounts2Company.set_DataMember("D_ACCOUNTS2COMPANY");
            this.grdAccounts2CompanyDetail.set_DataSource(this.m_ds);
            this.grdAccounts2CompanyDetail.set_DataMember("D_ACCOUNTS2COMPANY.relaCompanyDetail");
            this.grdRequirements.set_DataSource(this.m_ds.Tables["D_ACCOUNTS_SPECIAL_REQ"]);
            this.grdPreAlertAddress.set_DataSource(this.m_ds.Tables["D_PREALERT_MAIL_ADDRESS"]);
            this.grdExchangeRate.set_DataSource(this.m_ds.Tables["D_ACCOUNTS_EXCHANGE_RATE"]);
            this.SetBindFields(this.tabInvoiceAddress, this.m_ds.Tables["D_ACCOUNTS_INVOICE_ADDRESS"]);
            this.grdCUSTOMER_INVOICE_ADDRESS.set_DataSource(this.m_ds.Tables["D_CUSTOMER_INVOICE_ADDRESS"]);
            this.grdCUSTOMER_BILL_ADDRESS.set_DataSource(this.m_ds.Tables["D_CUSTOMER_BILL_ADDRESS"]);
            this.m_dvRelateShipper = new DataView(this.m_ds.Tables["D_ACCOUNTS2ACCOUNTS"]);
            this.m_dvRelateConsignee = new DataView(this.m_ds.Tables["D_ACCOUNTS2ACCOUNTS"]);
            this.m_dvAirPort = new DataView(this.m_ds.Tables["D_ACCOUNTS2PORTS"]);
            this.m_dvSeaPort = new DataView(this.m_ds.Tables["D_ACCOUNTS2PORTS"]);
            this.grdEvent.set_DataSource(this.m_ds.Tables["D_ACCOUNTS2EVENT"]);
            this.m_ds.Tables["D_ACCOUNTS"].RowChanged += new DataRowChangeEventHandler(this.Accounts_RowChanged);
            this.m_ds.Tables["D_CONTACT"].RowChanged += new DataRowChangeEventHandler(this.CONTACT_Rowchanged);
            this.m_ds.Tables["D_CONTACT"].RowChanging += new DataRowChangeEventHandler(this.Contact_Rowchanging);
            this.m_ds.Tables["D_ACCOUNTS_CUSTOMER"].RowChanged += new DataRowChangeEventHandler(this.Customer_Rowchanged);
            this.m_ds.Tables["D_SHIPPER_KC_NO"].RowChanged += new DataRowChangeEventHandler(this.CustomerKcNo_Rowchanged);
            this.m_ds.Tables["D_ACCOUNTS_NVOCC"].RowChanged += new DataRowChangeEventHandler(this.Nvocc_Rowchanged);
            this.m_ds.Tables["D_ACCOUNTS2COMPANY"].RowChanged += new DataRowChangeEventHandler(this.Accounts2Company_ROWCHANGED);
            this.m_ds.Tables["D_ACCOUNTS_SPECIAL_REQ"].RowChanged += new DataRowChangeEventHandler(this.SpecialReq_ROWCHANGED);
            this.m_ds.Tables["D_AIRLINE_SURCHARGE"].RowChanged += new DataRowChangeEventHandler(this.airlineSURCHARGE_Rowchanged);
            this.m_ds.Tables["D_ACCOUNTS_SEA_OSAGENT"].RowChanged += new DataRowChangeEventHandler(this.seaosagent_Rowchanged);
            this.m_ds.Tables["D_ACCOUNTS_AIR_OSAGENT"].RowChanged += new DataRowChangeEventHandler(this.airosagent_Rowchanged);
            this.m_ds.Tables["D_CUSTOMER2AIRAGENT"].RowChanged += new DataRowChangeEventHandler(this.CUSTOMER2AIRAGENT_ROWCHANGED);
            this.m_ds.Tables["D_ACCOUNTS2PORTS"].RowChanged += new DataRowChangeEventHandler(this.ACCOUNTS2PORTS_ROWCHANGED);
            this.m_ds.Tables["D_PREFER_CARRIER"].RowChanged += new DataRowChangeEventHandler(this.PREFERCARRIER_ROWCHANGED);
            this.m_ds.Tables["D_AIRLINE_SERVICE"].RowChanged += new DataRowChangeEventHandler(this.AIRLINESERVICE_ROWCHANGED);
            this.m_ds.Tables["D_AIRLINE_PORT"].RowChanged += new DataRowChangeEventHandler(this.AIRLINEPORT_ROWCHANGED);
            this.m_ds.Tables["D_PREALERT_MAIL_ADDRESS"].RowChanged += new DataRowChangeEventHandler(this.MAILADDRESS_ROWCHANGED);
            this.m_ds.Tables["D_ACCOUNTS_EXCHANGE_RATE"].RowChanged += new DataRowChangeEventHandler(this.EXCHANGERATE_ROWCHANGED);
            this.m_ds.Tables["D_SHIPLINE_CARGO_GROUP"].RowChanged += new DataRowChangeEventHandler(this.CARGOGROUP_RowChanged);
            this.m_ds.Tables["D_CUSTOMER_INVOICE_ADDRESS"].RowChanged += new DataRowChangeEventHandler(this.INVOICEADDRESS_ROWCHANGED);
            this.m_ds.Tables["D_CUSTOMER_INVOICE_ADDRESS"].RowChanged += new DataRowChangeEventHandler(this.BILLADDRESS_ROWCHANGED);
            this.m_ds.Tables["D_SHIPLINE_PORT"].RowChanged += new DataRowChangeEventHandler(this.shipLINEPORT_ROWCHANGED);
            this.m_ds.Tables["D_ACCOUNTS_ADD_NO"].RowChanged += new DataRowChangeEventHandler(this.AdditionalNo_RowChanged);
        }

        private void InitSingleRecordTable()
        {
            string AccountsID = this.m_ds.Tables["D_ACCOUNTS"].Rows[0]["ACCOUNTS_ID"].ToString();
            if (this.m_ds.Tables["D_ACCOUNTS_AIRWAY"].Rows.Count == 0)
            {
                DataRow drAirline = this.m_ds.Tables["D_ACCOUNTS_AIRWAY"].NewRow();
                //DataRow VB$t_ref$L0 = drAirline;
                //VB$t_ref$L0["ACCOUNTS_ID"] = AccountsID;
                //VB$t_ref$L0["MIN_MAWB_NUM"] = 0;
                //VB$t_ref$L0 = null;
                this.m_ds.Tables["D_ACCOUNTS_AIRWAY"].Rows.Add(drAirline);
            }
            if (this.m_ds.Tables["D_ACCOUNTS_CUSTOMER"].Rows.Count == 0)
            {
                DataRow drCustomer = this.m_ds.Tables["D_ACCOUNTS_CUSTOMER"].NewRow();
                //DataRow VB$t_ref$L1 = drCustomer;
                //VB$t_ref$L1["ACCOUNTS_ID"] = AccountsID;
                //VB$t_ref$L1["B_BLACK_LIST"] = 0;
                //VB$t_ref$L1["CREATE_BY"] = UIProxy.m_CurrentUserInformation.get_UserCode();
                //VB$t_ref$L1["CREATE_DATE"] = UIProxy.m_CurrDateTime.ToString();
                //VB$t_ref$L1["UPDATE_BY"] = UIProxy.m_CurrentUserInformation.get_UserCode();
                //VB$t_ref$L1["UPDATE_DATE"] = UIProxy.m_CurrDateTime.ToString();
                //VB$t_ref$L1 = null;
                this.m_ds.Tables["D_ACCOUNTS_CUSTOMER"].Rows.Add(drCustomer);
            }
            if (this.m_ds.Tables["D_SHIPPER_KC_NO"].Rows.Count == 0)
            {
                DataRow drKCNo = this.m_ds.Tables["D_SHIPPER_KC_NO"].NewRow();
                //DataRow VB$t_ref$L2 = drKCNo;
                //VB$t_ref$L2["ACCOUNTS_ID"] = AccountsID;
                //VB$t_ref$L2["CREATE_BY"] = UIProxy.m_CurrentUserInformation.get_UserCode();
                //VB$t_ref$L2["CREATE_DATE"] = UIProxy.m_CurrDateTime.ToString();
                //VB$t_ref$L2["UPDATE_BY"] = UIProxy.m_CurrentUserInformation.get_UserCode();
                //VB$t_ref$L2["UPDATE_DATE"] = UIProxy.m_CurrDateTime.ToString();
                //VB$t_ref$L2 = null;
                this.m_ds.Tables["D_SHIPPER_KC_NO"].Rows.Add(drKCNo);
            }
            if (this.m_ds.Tables["D_ACCOUNTS_NVOCC"].Rows.Count == 0)
            {
                DataRow drNvocc = this.m_ds.Tables["D_ACCOUNTS_NVOCC"].NewRow();
                //DataRow VB$t_ref$L3 = drNvocc;
                //VB$t_ref$L3["ACCOUNTS_ID"] = AccountsID;
                //VB$t_ref$L3["CREATE_BY"] = UIProxy.m_CurrentUserInformation.get_UserCode();
                //VB$t_ref$L3["CREATE_DATE"] = UIProxy.m_CurrDateTime.ToString();
                //VB$t_ref$L3["UPDATE_BY"] = UIProxy.m_CurrentUserInformation.get_UserCode();
                //VB$t_ref$L3["UPDATE_DATE"] = UIProxy.m_CurrDateTime.ToString();
                //VB$t_ref$L3 = null;
                this.m_ds.Tables["D_ACCOUNTS_NVOCC"].Rows.Add(drNvocc);
            }
            if (this.m_ds.Tables["D_ACCOUNTS_AIR_OSAGENT"].Rows.Count == 0)
            {
                DataRow drAirAgent = this.m_ds.Tables["D_ACCOUNTS_AIR_OSAGENT"].NewRow();
                drAirAgent["accounts_id"] = AccountsID;
                //drAirAgent["CREATE_BY"] = UIProxy.m_CurrentUserInformation.get_UserCode();
                //drAirAgent["CREATE_DATE"] = UIProxy.m_CurrDateTime.ToString();
                //drAirAgent["UPDATE_BY"] = UIProxy.m_CurrentUserInformation.get_UserCode();
                //drAirAgent["UPDATE_DATE"] = UIProxy.m_CurrDateTime.ToString();
                this.m_ds.Tables["D_ACCOUNTS_AIR_OSAGENT"].Rows.Add(drAirAgent);
            }
            if (this.m_ds.Tables["D_ACCOUNTS_SEA_OSAGENT"].Rows.Count == 0)
            {
                DataRow drSeaAgent = this.m_ds.Tables["D_ACCOUNTS_SEA_OSAGENT"].NewRow();
                drSeaAgent["accounts_id"] = AccountsID;
                drSeaAgent["Agent_type"] = 0;
                drSeaAgent["B_PROFIT_SHARE"] = 0;
                //drSeaAgent["CREATE_BY"] = UIProxy.m_CurrentUserInformation.get_UserCode();
                //drSeaAgent["CREATE_DATE"] = UIProxy.m_CurrDateTime.ToString();
                //drSeaAgent["UPDATE_BY"] = UIProxy.m_CurrentUserInformation.get_UserCode();
                //drSeaAgent["UPDATE_DATE"] = UIProxy.m_CurrDateTime.ToString();
                this.m_ds.Tables["D_ACCOUNTS_SEA_OSAGENT"].Rows.Add(drSeaAgent);
            }
            if (this.m_ds.Tables["D_ACCOUNTS_EC_SET"].Rows.Count == 0)
            {
                DataRow drEC = this.m_ds.Tables["D_ACCOUNTS_EC_SET"].NewRow();
                drEC["accounts_id"] = AccountsID;
                drEC["B_ENABLE"] = 0;
                //drEC["CREATE_BY"] = UIProxy.m_CurrentUserInformation.get_UserCode();
                //drEC["CREATE_DATE"] = UIProxy.m_CurrDateTime.ToString();
                //drEC["UPDATE_BY"] = UIProxy.m_CurrentUserInformation.get_UserCode();
                //drEC["UPDATE_DATE"] = UIProxy.m_CurrDateTime.ToString();
                this.m_ds.Tables["D_ACCOUNTS_EC_SET"].Rows.Add(drEC);
            }
        }

        public void EditAccountsCode(string AccountsID)
        {
            this.chkB_SOC.set_Checked(false);
            //this.m_ds = this.m_uip.GetDataSetFunction("ADMIN_ACCCODE_GETDATA", new object[] { AccountsID });
            DataTable dt = this.m_ds.Tables["D_CUSTOMER_INVOICE_ADDRESS"];
            dt.Columns["INVOICE_ADDRESS"].Unique = true;
            this.m_ds.AcceptChanges();
            this.BindAllFields();
            //this.edtACCOUNTS_CODE.get_Properties().set_ReadOnly(true);
            this.edtACCOUNTS_CODE.set_BackColor(SystemColors.Control);
        }

        /// <summary>
        /// 基本信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        #region 附加信息
        private void btnAccountAddtion_Click(object sender, EventArgs e)
        {
            AccountsAdditionForm addtion = new AccountsAdditionForm();
            addtion.DsDetail = this.m_ds;
            //addtion.AccountForm = this;
            addtion.BindAllFields();
            addtion.ShowDialog();
        }
        #endregion

        #region 提单地址
        private void btnBLAddressEdit_Click(object sender, EventArgs e)
        {
            AccountBLAddressEdit frm = new AccountBLAddressEdit();
            frm.AccountID = this.m_ds.Tables["D_ACCOUNTS"].Rows[0]["ACCOUNTS_ID"].ToString();
            frm.AddressDataTable = this.m_ds.Tables["D_ACCOUNTS_BL_ADDRESS"];
            if (frm.ShowDialog() == DialogResult.OK)
            {
            }
        }
        #endregion

        #region 提单地址附属
        private void btnBLAddress_Click(object sender, EventArgs e)
        {
            string country_name = this.m_uip.GetSingleValBySQL("SELECT COUNTRY_NAME FROM D_COUNTRY WHERE COUNTRY_CODE= '" + this.edtCOUNTRY_CODE.get_Text().Trim().ToString() + "'");
            string bl_line5 = "";
            if (country_name.Trim() != "")
            {
                bl_line5 = bl_line5 + country_name + ";";
            }
            if (this.edtPOSTALCODE.get_Text().Trim() != "")
            {
                bl_line5 = bl_line5 + this.edtPOSTALCODE.get_Text() + ";";
            }
            if (this.edtCity.get_Text().Trim() != "")
            {
                bl_line5 = bl_line5 + this.edtCity.get_Text() + ";";
            }
            if (this.edtTEL.get_Text().Trim() != "")
            {
                bl_line5 = bl_line5 + "TEL:" + this.edtTEL.get_Text() + ";";
            }
            if (this.edtFAX.get_Text().Trim() != "")
            {
                bl_line5 = bl_line5 + "FAX:" + this.edtFAX.get_Text();
            }
            this.m_ds.Tables["D_ACCOUNTS"].Rows[0].BeginEdit();
            this.m_ds.Tables["D_ACCOUNTS"].Rows[0]["BL_ADDRESS_LINE1"] = this.GenBLAddressPart(this.edtACCOUNTS_NAME.get_Text().ToString());
            if (this.edtACCOUNTS_NAME.get_Text().Trim().Length > 50)
            {
                this.m_ds.Tables["D_ACCOUNTS"].Rows[0]["BL_ADDRESS_LINE2"] = this.edtACCOUNTS_NAME.get_Text().Trim().Substring(50, this.edtACCOUNTS_NAME.get_Text().Trim().Length - 50);
                this.m_ds.Tables["D_ACCOUNTS"].Rows[0]["BL_ADDRESS_LINE3"] = this.GenBLAddressPart(this.edtADDRESS_LINE_1.get_Text().ToString());
                this.m_ds.Tables["D_ACCOUNTS"].Rows[0]["BL_ADDRESS_LINE4"] = this.GenBLAddressPart(this.edtADDRESS_LINE_2.get_Text().ToString());
                this.m_ds.Tables["D_ACCOUNTS"].Rows[0]["BL_ADDRESS_LINE5"] = this.GenBLAddressPart(this.edtADDRESS_LINE_3.get_Text().ToString());
                this.m_ds.Tables["D_ACCOUNTS"].Rows[0]["BL_ADDRESS_LINE6"] = this.GenBLAddressPart(bl_line5.ToString());
            }
            else
            {
                this.m_ds.Tables["D_ACCOUNTS"].Rows[0]["BL_ADDRESS_LINE2"] = this.GenBLAddressPart(this.edtADDRESS_LINE_1.get_Text().ToString());
                this.m_ds.Tables["D_ACCOUNTS"].Rows[0]["BL_ADDRESS_LINE3"] = this.GenBLAddressPart(this.edtADDRESS_LINE_2.get_Text().ToString());
                this.m_ds.Tables["D_ACCOUNTS"].Rows[0]["BL_ADDRESS_LINE4"] = this.GenBLAddressPart(this.edtADDRESS_LINE_3.get_Text().ToString());
                this.m_ds.Tables["D_ACCOUNTS"].Rows[0]["BL_ADDRESS_LINE5"] = this.GenBLAddressPart(bl_line5.ToString());
            }
            this.m_ds.Tables["D_ACCOUNTS"].Rows[0].EndEdit();
        }
        #endregion

        #region 关键字
        private void edtSEARCH_STR_Click(object sender, EventArgs e)
        {
            AccountsKeywordForm frm = new AccountsKeywordForm();
            if (this.edtSEARCH_STR.get_EditValue().ToString().Trim() != "")
            {
                frm.SelKeyword = Conversions.ToString(this.edtSEARCH_STR.get_EditValue());
            }
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                this.edtSEARCH_STR.set_EditValue(frm.SelKeyword);
            }
        }

        private void edtSEARCH_STR_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                AccountsKeywordForm frm = new AccountsKeywordForm();
                if (this.edtSEARCH_STR.get_EditValue().ToString().Trim() != "")
                {
                    frm.SelKeyword = Conversions.ToString(this.edtSEARCH_STR.get_EditValue());
                }
                frm.ShowDialog();
                if (frm.DialogResult == DialogResult.OK)
                {
                    this.edtSEARCH_STR.set_EditValue(frm.SelKeyword);
                }
            }
        }
        #endregion

        /// <summary>
        /// 主窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private bool ChangeContactBy()
        {
            //IEnumerator VB$t_ref$L0;
            this.m_uip.ClearMessage();
            try
            {
                //VB$t_ref$L0 = this.m_ds.Tables["D_CONTACT"].Rows.GetEnumerator();
                //while (VB$t_ref$L0.MoveNext())
                //{
                //    DataRow dr = (DataRow) VB$t_ref$L0.Current;
                //    if ((dr.RowState == DataRowState.Modified) | (dr.RowState == DataRowState.Added))
                //    {
                //        if (dr["CONTACT_NAME"].ToString() == "")
                //        {
                //            this.m_uip.ShowAlarmMsg("联系人信息中的联系人姓名不能为空");
                //            return false;
                //        }
                //        if (((dr["TELE"].ToString() == "") && (dr["TELE"].ToString() == "")) && ((dr["EMAIL"].ToString() == "") && (dr["MSNQQ"].ToString() == "")))
                //        {
                //            this.m_uip.ShowAlarmMsg("联系人信息中的电话、传真、EMAIL、MSNQQ不能都为空,必需填一个!");
                //            return false;
                //        }
                //    }
                //}
            }
            finally
            {
                //if (VB$t_ref$L0 is IDisposable)
                //{
                //    (VB$t_ref$L0 as IDisposable).Dispose();
                //}
            }
            return true;
        }

        #region 确定
        private string SaveAccounts()
        {
            string SaveAccounts;
            try
            {
                //IEnumerator VB$t_ref$L0;
                try
                {
                    //VB$t_ref$L0 = this.m_ds.Tables["D_ACCOUNTS2COMPANY"].Rows.GetEnumerator();
                    //while (VB$t_ref$L0.MoveNext())
                    //{
                    //    DataRow row = (DataRow) VB$t_ref$L0.Current;
                    //    if (row == null)
                    //    {
                    //        return SaveAccounts;
                    //    }
                    //    if (row["OFFICE_CODE"].ToString() == "")
                    //    {
                    //        row.SetColumnError("OFFICE_CODE", MessageInfo.MSG_DATA_CANNOT_EMPTY);
                    //        ((ColumnView) this.grdAccounts2Company.get_MainView()).set_FocusedColumn(((ColumnView) this.grdAccounts2Company.get_MainView()).get_Columns().get_Item("OFFICE_CODE"));
                    //    }
                    //}
                }
                finally
                {
                    //if (VB$t_ref$L0 is IDisposable)
                    //{
                    //    (VB$t_ref$L0 as IDisposable).Dispose();
                    //}
                }
            }
            catch (Exception exception1)
            {
                //ProjectData.SetProjectError(exception1);
                Exception ex = exception1;
                SaveAccounts = ex.Message;
                //ProjectData.ClearProjectError();
                return SaveAccounts;
            }
            try
            {
                if (this.m_ds.Tables["D_ACCOUNTS"].Rows[0]["B_AIR_OSAGENT"].ToString().Equals("1"))
                {
                    string accountsId = this.m_ds.Tables["D_ACCOUNTS"].Rows[0]["ACCOUNTS_ID"].ToString();
                    if (this.m_ds.Tables["D_ACCOUNTS_AIR_OSAGENT"].Select("ACCOUNTS_ID = " + accountsId).Length == 0)
                    {
                        DataRow drD_ACCOUNTS_AIR_OSAGENT = this.m_ds.Tables["D_ACCOUNTS_AIR_OSAGENT"].NewRow();
                        //DataRow VB$t_ref$L1 = drD_ACCOUNTS_AIR_OSAGENT;
                        //VB$t_ref$L1["ACCOUNTS_ID"] = accountsId;
                        //VB$t_ref$L1["B_WACO"] = this._bWaco;
                        //VB$t_ref$L1["WACO_CODE"] = this._wacoCode;
                        //VB$t_ref$L1 = null;
                        this.m_ds.Tables["D_ACCOUNTS_AIR_OSAGENT"].Rows.Add(drD_ACCOUNTS_AIR_OSAGENT);
                    }
                }
            }
            catch (Exception exception2)
            {
                //ProjectData.SetProjectError(exception2);
                Exception ex = exception2;
                SaveAccounts = ex.Message;
                //ProjectData.ClearProjectError();
                return SaveAccounts;
            }
            try
            {
                //IEnumerator VB$t_ref$L2;
                try
                {
                    //VB$t_ref$L2 = this.m_ds.Tables.GetEnumerator();
                    //while (VB$t_ref$L2.MoveNext())
                    //{
                    //    IEnumerator VB$t_ref$L3;
                    //    DataTable dt = (DataTable) VB$t_ref$L2.Current;
                    //    try
                    //    {
                    //        VB$t_ref$L3 = dt.Rows.GetEnumerator();
                    //        while (VB$t_ref$L3.MoveNext())
                    //        {
                    //            ((DataRow) VB$t_ref$L3.Current).EndEdit();
                    //        }
                    //    }
                    //    finally
                    //    {
                    //        if (VB$t_ref$L3 is IDisposable)
                    //        {
                    //            (VB$t_ref$L3 as IDisposable).Dispose();
                    //        }
                    //    }
                    //    this.BindingContext[dt].EndCurrentEdit();
                    //}
                }
                finally
                {
                    //if (VB$t_ref$L2 is IDisposable)
                    //{
                    //    (VB$t_ref$L2 as IDisposable).Dispose();
                    //}
                }
            }
            catch (Exception exception3)
            {
                //ProjectData.SetProjectError(exception3);
                Exception ex = exception3;
                SaveAccounts = ex.Message;
                //ProjectData.ClearProjectError();
                return SaveAccounts;
            }
            if (!this.CheckDataValid())
            {
                return "VALID";
            }
            this.ClearSingleRecordTable();
            if (this.m_ds.HasErrors)
            {
                this.m_uip.ShowErrorMsg(0x2bd);
                return "HASERRORS";
            }
            try
            {
                if (!this.m_ds.HasChanges())
                {
                    return "TRUE";
                }
                DataSet dsUser = new DataSet();
                DataTable dt = new DataTable();
                DataColumn dc = new DataColumn();
                dc.ColumnName = "USER_CODE";
                dt.Columns.Add(dc);
                dsUser.Tables.Add(dt);
                DataRow row = dt.NewRow();
                //row[0] = UIProxy.m_CurrentUserInformation.get_UserCode();
                dt.Rows.Add(row);
                string strbool = Conversions.ToString(this.m_uip.ExecFunction("ADMIN_ACCCODE_SAVEDATA", new object[] { this.m_ds, dsUser }));
                if (strbool.ToUpper() == "TRUE")
                {
                    if (this.chkB_CUSTOMER.get_Checked())
                    {
                        //Conversions.ToBoolean(this.m_uip.ExecFunctionByName("ADMIN_ACCCODE_GETDATA", "BuildData", new object[] { this.m_ds }));
                    }
                    return "TRUE";
                }
                SaveAccounts = strbool;
            }
            catch (Exception exception4)
            {
                //ProjectData.SetProjectError(exception4);
                Exception ex = exception4;
                SaveAccounts = ex.Message;
                //ProjectData.ClearProjectError();
            }
            return SaveAccounts;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.BindingContext[this.m_ds, this.m_ds.Tables["D_CONTACT"].TableName].EndCurrentEdit();
            if (this.ChangeContactBy())
            {
                string sAccountCode = string.Empty;
                string sTele = "";
                if (this.m_ds.Tables["D_CONTACT"].Select("", "", DataViewRowState.CurrentRows).Length > 0)
                {
                    foreach (DataRow row in this.m_ds.Tables["D_CONTACT"].Select("", "", DataViewRowState.CurrentRows))
                    {
                        if (row["TELE"].ToString() != "")
                        {
                            sTele = row["TELE"].ToString();
                            sAccountCode = this.m_uip.GetSingleValBySQL("SELECT B.ACCOUNTS_CODE   FROM D_CONTACT A, D_ACCOUNTS B WHERE A.ACCOUNTS_ID = B.ACCOUNTS_ID(+)    AND A.ACCOUNTS_ID <> '" + this.m_ds.Tables["D_ACCOUNTS"].Rows[0]["ACCOUNTS_ID"].ToString() + "'    AND A.TELE= '" + sTele + "'    AND ROWNUM=1");
                            if (sAccountCode != "")
                            {
                                break;
                            }
                        }
                    }
                    if (!string.IsNullOrEmpty(sAccountCode) && (UIProxy.ShowPopupMessage("联系人电话" + sTele + "已被" + sAccountCode + "使用,是否确定保存?") != DialogResult.Yes))
                    {
                        return;
                    }
                }
                string boolstr = string.Empty;
                boolstr = this.SaveAccounts();
                if (boolstr.ToUpper() == "TRUE")
                {
                    this.edtACCOUNTS_CODE.get_Properties().set_ReadOnly(true);
                    this.edtACCOUNTS_CODE.set_BackColor(SystemColors.Control);
                    this.Closing -= new CancelEventHandler(this.AccountsEditForm_Closing);
                    this.m_uip.ShowMessage(0xc9);
                    this.DialogResult = DialogResult.OK;
                }
                else if (boolstr.ToUpper() != "VALID")
                {
                    if (boolstr.ToUpper() == "HASERRORS")
                    {
                        this.m_uip.ShowErrorMsg(0x2bd);
                    }
                    else if (UIProxy.get_Language() == 1)
                    {
                        MessageBox.Show("保存失败! 错误信息：" + boolstr, "错误", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                    else
                    {
                        MessageBox.Show("Save failure! Error info:" + boolstr, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                }
            }
        }

        private void AccountsEditForm_Closing(object sender, CancelEventArgs e)
        {
            try
            {
                //IEnumerator VB$t_ref$L0;
                try
                {
                    //VB$t_ref$L0 = this.m_ds.Tables.GetEnumerator();
                    //while (VB$t_ref$L0.MoveNext())
                    //{
                    //    IEnumerator VB$t_ref$L1;
                    //    DataTable dt = (DataTable) VB$t_ref$L0.Current;
                    //    try
                    //    {
                    //        VB$t_ref$L1 = dt.Rows.GetEnumerator();
                    //        while (VB$t_ref$L1.MoveNext())
                    //        {
                    //            ((DataRow) VB$t_ref$L1.Current).EndEdit();
                    //        }
                    //    }
                    //    finally
                    //    {
                    //        if (VB$t_ref$L1 is IDisposable)
                    //        {
                    //            (VB$t_ref$L1 as IDisposable).Dispose();
                    //        }
                    //    }
                    //    this.BindingContext[dt].EndCurrentEdit();
                    //}
                }
                finally
                {
                    //if (VB$t_ref$L0 is IDisposable)
                    //{
                    //    (VB$t_ref$L0 as IDisposable).Dispose();
                    //}
                }
            }
            catch (Exception exception1)
            {
                //ProjectData.SetProjectError(exception1);
                Exception ex = exception1;
                //ProjectData.ClearProjectError();
            }
            if (this.m_ds.HasChanges())
            {
                if (!ShowMessage.IsSureClose(this))
                {
                    e.Cancel = true;
                }
            }
            else
            {
                this.DialogResult = DialogResult.Cancel;
            }
        }
        #endregion

        #region 关闭
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        /// <summary>
        /// 联系人
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        #region 联系人新增
        private void BtnNew_Click(object sender, EventArgs e)
        {
            int RowPosition = this.BindingContext[RuntimeHelpers.GetObjectValue(this.grdContacts.get_DataSource()), this.grdContacts.get_DataMember()].Position;
            if (this.m_ds.Tables["D_CONTACT"].Rows.Count > 0)
            {
                this.m_ds.Tables["D_CONTACT"].Rows[RowPosition].EndEdit();
            }
            DataRow dr = this.m_ds.Tables["D_CONTACT"].NewRow();
            dr["INTER_ID"] = this.m_uip.GetMasterSeqId();
            dr["ACCOUNTS_ID"] = RuntimeHelpers.GetObjectValue(this.m_ds.Tables["D_ACCOUNTS"].Rows[0]["ACCOUNTS_ID"]);
            dr["CREATE_BY"] = UIProxy.m_CurrentUserInformation.get_UserCode();
            dr["CREATE_DATE"] = UIProxy.m_CurrDateTime.ToString();
            dr["UPDATE_BY"] = UIProxy.m_CurrentUserInformation.get_UserCode();
            dr["UPDATE_DATE"] = UIProxy.m_CurrDateTime.ToString();
            dr["B_ACCOUNT"] = 0;
            dr["B_OPERATION"] = 0;
            dr["B_SALES"] = 0;
            dr["B_MANAGER"] = 0;
            dr["B_CUSTOMER_SERVICE"] = 0;
            this.m_ds.Tables["D_CONTACT"].Rows.Add(dr);
            this.grdContacts.Select();
            ((ColumnView)this.grdContacts.get_MainView()).set_FocusedColumn(((ColumnView)this.grdContacts.get_MainView()).get_Columns().get_Item(0));

        }
        #endregion

        #region 删除
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (((this.m_ds.Tables["D_CONTACT"] != null) && (this.m_ds.Tables["D_CONTACT"].Rows.Count > 0)) && (this.m_uip.ShowMessage(400) == DialogResult.Yes))
            {
                string currentId = Common.GetValue(this.grdContacts, "INTER_ID");
                ColumnView view = this.grdContacts.get_MainView();
                view.DeleteRow(view.get_FocusedRowHandle());
                this.m_ds.Tables["D_ACCOUNTS"].AcceptChanges();
            }
        }
        #endregion

        /// <summary>
        /// 特殊要求
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        #region 新增
        private void btnNewSpecialReqs_Click(object sender, EventArgs e)
        {
            DataProcess.PostEdit(this, this.m_ds.Tables["D_ACCOUNTS_SPECIAL_REQ"]);
            DataRow row = this.m_ds.Tables["D_ACCOUNTS_SPECIAL_REQ"].NewRow();
            row["CUSTOMER2SPECIAL_ID"] = this.m_uip.GetMasterSeqId();
            row["ACCOUNTS_ID"] = RuntimeHelpers.GetObjectValue(this.m_ds.Tables["D_ACCOUNTS"].Rows[0]["ACCOUNTS_ID"]);
            row["CREATE_BY"] = UIProxy.m_CurrentUserInformation.get_UserCode();
            row["CREATE_DATE"] = UIProxy.m_CurrDateTime.ToString();
            row["UPDATE_BY"] = UIProxy.m_CurrentUserInformation.get_UserCode();
            row["UPDATE_DATE"] = UIProxy.m_CurrDateTime.ToString();
            this.m_ds.Tables["D_ACCOUNTS_SPECIAL_REQ"].Rows.Add(row);
            this.grdRequirements.Focus();
            ((ColumnView)this.grdRequirements.get_MainView()).set_FocusedColumn(((ColumnView)this.grdRequirements.get_MainView()).get_Columns().get_Item("SPECIAL_REQ_CODE"));
        }
        #endregion

        #region 删除
        private void btnDeleteSpecialReqs_Click(object sender, EventArgs e)
        {
            ColumnView view = this.grdRequirements.get_MainView();
            DataRow row = view.GetDataRow(view.get_FocusedRowHandle());
            if ((row != null) && (this.m_uip.ShowMessage(400) == DialogResult.Yes))
            {
                row.Delete();
            }
        }
        #endregion

        /// <summary>
        /// 账户对应分公司信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNewAccounts2Company_Click(object sender, EventArgs e)
        {
            DataProcess.PostEdit(this, this.m_ds.Tables["D_ACCOUNTS2COMPANY"]);
            DataRow row = this.m_ds.Tables["D_ACCOUNTS2COMPANY"].NewRow();
            row["INTER_ID"] = this.m_uip.GetMasterSeqId();
            row["ACCOUNTS_ID"] = RuntimeHelpers.GetObjectValue(this.m_ds.Tables["D_ACCOUNTS"].Rows[0]["ACCOUNTS_ID"]);
            row["B_AIR_EXPORT"] = "1";
            row["B_AIR_IMPORT"] = "1";
            row["B_SEA_EXPORT"] = "1";
            row["B_SEA_IMPORT"] = "1";
            row["CREATE_BY"] = UIProxy.m_CurrentUserInformation.get_UserCode();
            row["CREATE_DATE"] = UIProxy.m_CurrDateTime.ToString();
            row["UPDATE_BY"] = UIProxy.m_CurrentUserInformation.get_UserCode();
            row["UPDATE_DATE"] = UIProxy.m_CurrDateTime.ToString();
            this.m_ds.Tables["D_ACCOUNTS2COMPANY"].Rows.Add(row);
            this.grdAccounts2Company.Focus();
            ((ColumnView)this.grdAccounts2Company.get_MainView()).set_FocusedColumn(((ColumnView)this.grdAccounts2Company.get_MainView()).get_Columns().get_Item("OFFICE_CODE"));
        }

        private void btnDeleteAccounts2Company_Click(object sender, EventArgs e)
        {
            this.m_ds.Tables["D_ACCOUNTS2COMPANY"].RowChanged -= new DataRowChangeEventHandler(this.Accounts2Company_ROWCHANGED);
            ColumnView view = this.grdAccounts2Company.get_MainView();
            DataRow row = view.GetDataRow(view.get_FocusedRowHandle());
            string innerID = row["INTER_ID"].ToString();
            if ((row != null) && (this.m_uip.ShowMessage(400) == DialogResult.Yes))
            {
                if (Operators.ConditionalCompareObjectEqual(this.m_uip.ExecFunctionByName("ADMIN_ACCCODE_SAVEDATA", "Deleted_Accounts2company_Data", new object[] { innerID }), true, false))
                {
                    this.m_uip.ShowMessage(410);
                    foreach (DataRow dr in row.GetChildRows("relaCompanyDetail"))
                    {
                        this.m_ds.Tables["D_ACCOUNTS2COMPANY_DETAIL"].Rows.Remove(dr);
                    }
                    this.m_ds.Tables["D_ACCOUNTS2COMPANY"].Rows.Remove(row);
                }
                else
                {
                    this.m_uip.ShowMessage(420);
                }
            }
            this.m_ds.Tables["D_ACCOUNTS2COMPANY"].RowChanged += new DataRowChangeEventHandler(this.Accounts2Company_ROWCHANGED);
        }

        private void btnNewAccounts2CompanyDetail_Click(object sender, EventArgs e)
        {
            string innerID = this.GetSelectedDataRow(this.grdAccounts2Company)["INTER_ID"].ToString();
            this.BindingContext[RuntimeHelpers.GetObjectValue(this.grdAccounts2CompanyDetail.get_DataSource()), this.grdAccounts2CompanyDetail.get_DataMember()].EndCurrentEdit();
            DataRow row = this.m_ds.Tables["D_ACCOUNTS2COMPANY_DETAIL"].NewRow();
            row["ACCOUNTS2COMPANY_DETAIL_ID"] = this.m_uip.GetMasterSeqId();
            row["INTER_ID"] = innerID;
            row["CREATE_BY"] = UIProxy.m_CurrentUserInformation.get_UserCode();
            row["CREATE_DATE"] = UIProxy.m_CurrDateTime.ToShortDateString();
            this.m_ds.Tables["D_ACCOUNTS2COMPANY_DETAIL"].Rows.Add(row);
        }

        private void btnDeleteAccounts2CompanyDetail_Click(object sender, EventArgs e)
        {
            if (this.m_uip.ShowMessage(400) == DialogResult.Yes)
            {
                DataRow row = this.GetSelectedDataRow(this.grdAccounts2CompanyDetail);
                string PK = row["ACCOUNTS2COMPANY_DETAIL_ID"].ToString();
                if (PK.Trim().Length != 0)
                {
                    if (Operators.ConditionalCompareObjectEqual(this.m_uip.ExecFunctionByName("ADMIN_ACCCODE_SAVEDATA", "Deleted_Accounts2company_DetailData", new object[] { PK }), true, false))
                    {
                        this.m_uip.ShowMessage(410);
                        this.m_ds.Tables["D_ACCOUNTS2COMPANY_DETAIL"].Rows.Remove(row);
                    }
                    else
                    {
                        this.m_uip.ShowMessage(420);
                    }
                }
            }
        }

        private void grdAccounts2Company_GotFocus(object sender, EventArgs e)
        {
            DataRow row = this.gvAccounts2company.GetDataRow(this.gvAccounts2company.get_FocusedRowHandle());
            if (row != null)
            {
                string officeCode = row["OFFICE_CODE"].ToString();
                LookupData.SetSalesLookUp2(this.RI_SALES_DETAIL, this.m_uip, officeCode);
                LookupData.SetCusSrvcLookUp2(this.RI_CUSTOMER_SERVICE_DETAIL, this.m_uip, officeCode);
            }
        }

        /// <summary>
        /// 账单/发票抬头
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGenInvoiceAddress_Click(object sender, EventArgs e)
        {
            string country_name = this.m_uip.GetSingleValBySQL("SELECT COUNTRY_NAME FROM D_COUNTRY WHERE COUNTRY_CODE= '" + this.edtCOUNTRY_CODE.get_Text().Trim().ToString() + "'");
            string bl_line5 = "";
            if (country_name.Trim() != "")
            {
                bl_line5 = bl_line5 + country_name + ";";
            }
            if (this.edtPOSTALCODE.get_Text().Trim() != "")
            {
                bl_line5 = bl_line5 + this.edtPOSTALCODE.get_Text() + ";";
            }
            if (this.edtCity.get_Text().Trim() != "")
            {
                bl_line5 = bl_line5 + this.edtCity.get_Text() + ";";
            }
            if (this.edtTEL.get_Text().Trim() != "")
            {
                bl_line5 = bl_line5 + "TEL:" + this.edtTEL.get_Text() + ";";
            }
            if (this.edtFAX.get_Text().Trim() != "")
            {
                bl_line5 = bl_line5 + "FAX:" + this.edtFAX.get_Text();
            }
            this.m_ds.Tables["D_ACCOUNTS_INVOICE_ADDRESS"].Rows[0].BeginEdit();
            this.m_ds.Tables["D_ACCOUNTS_INVOICE_ADDRESS"].Rows[0]["INVOICE_ADDRESS_LINE1"] = this.GenBLAddressPart(this.edtACCOUNTS_NAME.get_Text().ToString());
            this.m_ds.Tables["D_ACCOUNTS_INVOICE_ADDRESS"].Rows[0]["INVOICE_ADDRESS_LINE2"] = this.GenBLAddressPart(this.edtADDRESS_LINE_1.get_Text().ToString());
            this.m_ds.Tables["D_ACCOUNTS_INVOICE_ADDRESS"].Rows[0]["INVOICE_ADDRESS_LINE3"] = this.GenBLAddressPart(this.edtADDRESS_LINE_2.get_Text().ToString());
            this.m_ds.Tables["D_ACCOUNTS_INVOICE_ADDRESS"].Rows[0]["INVOICE_ADDRESS_LINE4"] = this.GenBLAddressPart(this.edtADDRESS_LINE_3.get_Text().ToString());
            this.m_ds.Tables["D_ACCOUNTS_INVOICE_ADDRESS"].Rows[0]["INVOICE_ADDRESS_LINE5"] = this.GenBLAddressPart(bl_line5.ToString());
            this.m_ds.Tables["D_ACCOUNTS_INVOICE_ADDRESS"].Rows[0].EndEdit();
        }

        private void btnNewInvoice_Adress_Click(object sender, EventArgs e)
        {
            int RowPosition = this.BindingContext[RuntimeHelpers.GetObjectValue(this.grdCUSTOMER_INVOICE_ADDRESS.get_DataSource()), this.grdCUSTOMER_INVOICE_ADDRESS.get_DataMember()].Position;
            if (this.m_ds.Tables["D_CUSTOMER_INVOICE_ADDRESS"].Rows.Count > 0)
            {
                this.m_ds.Tables["D_CUSTOMER_INVOICE_ADDRESS"].Rows[RowPosition].EndEdit();
            }
            DataRow dr = this.m_ds.Tables["D_CUSTOMER_INVOICE_ADDRESS"].NewRow();
            dr["CUSTOMER_INVOICE_ADDRES_ID"] = this.m_uip.GetMasterSeqId();
            dr["ACCOUNTS_ID"] = RuntimeHelpers.GetObjectValue(this.m_ds.Tables["D_ACCOUNTS"].Rows[0]["ACCOUNTS_ID"]);
            dr["CREATE_BY"] = UIProxy.m_CurrentUserInformation.get_UserCode();
            dr["CREATE_DATE"] = UIProxy.m_CurrDateTime.ToString();
            dr["UPDATE_BY"] = UIProxy.m_CurrentUserInformation.get_UserCode();
            dr["UPDATE_DATE"] = UIProxy.m_CurrDateTime.ToString();
            this.m_ds.Tables["D_CUSTOMER_INVOICE_ADDRESS"].Rows.Add(dr);
            this.grdCUSTOMER_INVOICE_ADDRESS.Select();
            ((ColumnView)this.grdCUSTOMER_INVOICE_ADDRESS.get_MainView()).set_FocusedColumn(((ColumnView)this.grdCUSTOMER_INVOICE_ADDRESS.get_MainView()).get_Columns().get_Item(0));
        }

        private void btnDeleteInvoice_Adress_Click(object sender, EventArgs e)
        {
            if (ShowMessage.IsSureDelete(this))
            {
                ColumnView View = this.grdCUSTOMER_INVOICE_ADDRESS.get_MainView();
                DataRow row = View.GetDataRow(View.get_FocusedRowHandle());
                if (row != null)
                {
                    row.Delete();
                }
            }
        }

        private void btnNewBill_Adress_Click(object sender, EventArgs e)
        {
            int RowPosition = this.BindingContext[RuntimeHelpers.GetObjectValue(this.grdCUSTOMER_BILL_ADDRESS.get_DataSource()), this.grdCUSTOMER_BILL_ADDRESS.get_DataMember()].Position;
            if (this.m_ds.Tables["D_CUSTOMER_BILL_ADDRESS"].Rows.Count > 0)
            {
                this.m_ds.Tables["D_CUSTOMER_BILL_ADDRESS"].Rows[RowPosition].EndEdit();
            }
            DataRow dr = this.m_ds.Tables["D_CUSTOMER_BILL_ADDRESS"].NewRow();
            dr["CUSTOMER_BILL_ADDRES_ID"] = this.m_uip.GetMasterSeqId();
            dr["ACCOUNTS_ID"] = RuntimeHelpers.GetObjectValue(this.m_ds.Tables["D_ACCOUNTS"].Rows[0]["ACCOUNTS_ID"]);
            dr["CREATE_BY"] = UIProxy.m_CurrentUserInformation.get_UserCode();
            dr["CREATE_DATE"] = UIProxy.m_CurrDateTime.ToString();
            dr["UPDATE_BY"] = UIProxy.m_CurrentUserInformation.get_UserCode();
            dr["UPDATE_DATE"] = UIProxy.m_CurrDateTime.ToString();
            dr["B_BILL"] = 0;
            this.m_ds.Tables["D_CUSTOMER_BILL_ADDRESS"].Rows.Add(dr);
            this.grdCUSTOMER_BILL_ADDRESS.Select();
            ((ColumnView)this.grdCUSTOMER_BILL_ADDRESS.get_MainView()).set_FocusedColumn(((ColumnView)this.grdCUSTOMER_BILL_ADDRESS.get_MainView()).get_Columns().get_Item(0));

        }

        private void btnDeleteBill_Adress_Click(object sender, EventArgs e)
        {
            if (ShowMessage.IsSureDelete(this))
            {
                ColumnView View = this.grdCUSTOMER_BILL_ADDRESS.get_MainView();
                DataRow row = View.GetDataRow(View.get_FocusedRowHandle());
                if (row != null)
                {
                    row.Delete();
                }
            }
        }

        /// <summary>
        /// 预报地址
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNewPreAlertAddress_Click(object sender, EventArgs e)
        {
            int RowPosition = this.BindingContext[RuntimeHelpers.GetObjectValue(this.grdPreAlertAddress.get_DataSource()), this.grdPreAlertAddress.get_DataMember()].Position;
            if (this.m_ds.Tables["D_PREALERT_MAIL_ADDRESS"].Rows.Count > 0)
            {
                this.m_ds.Tables["D_PREALERT_MAIL_ADDRESS"].Rows[RowPosition].EndEdit();
            }
            DataRow dr = this.m_ds.Tables["D_PREALERT_MAIL_ADDRESS"].NewRow();
            dr["INTER_ID"] = this.m_uip.GetMasterSeqId();
            dr["ACCOUNTS_ID"] = RuntimeHelpers.GetObjectValue(this.m_ds.Tables["D_ACCOUNTS"].Rows[0]["ACCOUNTS_ID"]);
            dr["MAIL_POS"] = "TO";
            dr["CREATE_BY"] = UIProxy.m_CurrentUserInformation.get_UserCode();
            dr["CREATE_DATE"] = UIProxy.m_CurrDateTime.ToString();
            dr["UPDATE_BY"] = UIProxy.m_CurrentUserInformation.get_UserCode();
            dr["UPDATE_DATE"] = UIProxy.m_CurrDateTime.ToString();
            this.m_ds.Tables["D_PREALERT_MAIL_ADDRESS"].Rows.Add(dr);
            this.grdPreAlertAddress.Select();
            ((ColumnView)this.grdPreAlertAddress.get_MainView()).set_FocusedColumn(((ColumnView)this.grdPreAlertAddress.get_MainView()).get_Columns().get_Item(0));
        }

        private void btnDeletePreAlertAddress_Click(object sender, EventArgs e)
        {
            if (((this.m_ds.Tables["D_PREALERT_MAIL_ADDRESS"] != null) && (this.m_ds.Tables["D_PREALERT_MAIL_ADDRESS"].Rows.Count > 0)) && (this.m_uip.ShowMessage(400) == DialogResult.Yes))
            {
                ColumnView view = this.grdPreAlertAddress.get_MainView();
                view.DeleteRow(view.get_FocusedRowHandle());
            }
        }

        /// <summary>
        /// 特殊汇率
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNewExchangeRate_Click(object sender, EventArgs e)
        {
            int RowPosition = this.BindingContext[RuntimeHelpers.GetObjectValue(this.grdExchangeRate.get_DataSource()), this.grdExchangeRate.get_DataMember()].Position;
            if (this.m_ds.Tables["D_ACCOUNTS_EXCHANGE_RATE"].Rows.Count > 0)
            {
                this.m_ds.Tables["D_ACCOUNTS_EXCHANGE_RATE"].Rows[RowPosition].EndEdit();
            }
            DataRow dr = this.m_ds.Tables["D_ACCOUNTS_EXCHANGE_RATE"].NewRow();
            dr["ACCOUNTS_EXCHANGE_RATE_ID"] = this.m_uip.GetMasterSeqId();
            dr["ACCOUNTS_ID"] = RuntimeHelpers.GetObjectValue(this.m_ds.Tables["D_ACCOUNTS"].Rows[0]["ACCOUNTS_ID"]);
            dr["CREATE_BY"] = UIProxy.m_CurrentUserInformation.get_UserCode();
            dr["CREATE_DATE"] = UIProxy.m_CurrDateTime.ToString();
            dr["UPDATE_BY"] = UIProxy.m_CurrentUserInformation.get_UserCode();
            dr["UPDATE_DATE"] = UIProxy.m_CurrDateTime.ToString();
            this.m_ds.Tables["D_ACCOUNTS_EXCHANGE_RATE"].Rows.Add(dr);
            this.grdExchangeRate.Select();
            ((ColumnView)this.grdExchangeRate.get_MainView()).set_FocusedColumn(((ColumnView)this.grdExchangeRate.get_MainView()).get_Columns().get_Item(0));
        }

        private void btnDeleteExchangeRate_Click(object sender, EventArgs e)
        {
            if (((this.m_ds.Tables["D_ACCOUNTS_EXCHANGE_RATE"] != null) && (this.m_ds.Tables["D_ACCOUNTS_EXCHANGE_RATE"].Rows.Count > 0)) && (this.m_uip.ShowMessage(400) == DialogResult.Yes))
            {
                string currentId = Common.GetValue(this.grdExchangeRate, "ACCOUNTS_EXCHANGE_RATE_ID");
                ColumnView view = this.grdExchangeRate.get_MainView();
                view.DeleteRow(view.get_FocusedRowHandle());
            }
        }

        /// <summary>
        /// 重大事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEventAdd_Click(object sender, EventArgs e)
        {
            DataProcess.PostEdit(this, this.m_ds.Tables["D_ACCOUNTS2EVENT"]);
            DataRow row = this.m_ds.Tables["D_ACCOUNTS2EVENT"].NewRow();
            row["INTER_ID"] = this.m_uip.GetMasterSeqId();
            row["ACCOUNTS_ID"] = RuntimeHelpers.GetObjectValue(this.m_ds.Tables["D_ACCOUNTS"].Rows[0]["ACCOUNTS_ID"]);
            row["CREATE_BY"] = UIProxy.m_CurrentUserInformation.get_UserCode();
            row["CREATE_DATE"] = UIProxy.m_CurrDateTime.ToString();
            this.m_ds.Tables["D_ACCOUNTS2EVENT"].Rows.Add(row);
            this.grdEvent.Focus();
            ((ColumnView)this.grdEvent.get_MainView()).set_FocusedColumn(((ColumnView)this.grdAccounts2Company.get_MainView()).get_Columns().get_Item("EVENT_CONTENT"));
        }

        private void btnEventDelete_Click(object sender, EventArgs e)
        {
            if (((this.m_ds.Tables["D_ACCOUNTS2EVENT"] != null) && (this.m_ds.Tables["D_ACCOUNTS2EVENT"].Rows.Count > 0)) && (this.m_uip.ShowMessage(400) == DialogResult.Yes))
            {
                string currentId = Common.GetValue(this.grdEvent, "INTER_ID");
                ColumnView view = this.grdEvent.get_MainView();
                view.DeleteRow(view.get_FocusedRowHandle());
            }
        }

        private string GenBLAddressPart(string s)
        {
            if (s.Length > 50)
            {
                s = s.Substring(0, 50);
            }
            return s;
        }

        public string Account_ID
        {
            get
            {
                return this.m_AccountID;
            }
            set
            {
                this.m_AccountID = value;
            }
        }

        public void EditAccountsCode(string AccountsID)
        {
            this.chkB_SOC.set_Checked(false);
            this.m_ds = this.m_uip.GetDataSetFunction("ADMIN_ACCCODE_GETDATA", new object[] { AccountsID });
            DataTable dt = this.m_ds.Tables["D_CUSTOMER_INVOICE_ADDRESS"];
            dt.Columns["INVOICE_ADDRESS"].Unique = true;
            this.m_ds.AcceptChanges();
            this.BindAllFields();
            this.edtACCOUNTS_CODE.get_Properties().set_ReadOnly(true);
            this.edtACCOUNTS_CODE.set_BackColor(SystemColors.Control);
        }
    }
}
