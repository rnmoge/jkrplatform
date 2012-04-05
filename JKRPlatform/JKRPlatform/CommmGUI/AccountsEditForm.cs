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
    public partial class AccountsEditForm : Form
    {
        private string _wacoCode;
        private IContainer components;
        private string effect_date;
        private TabCtl evTab;
        private string expire_date;
        private string m_AccountID;
        private DataSet m_detailDataSet;
        private DataSet m_ds;
        private DataView m_dvAirPort;
        private DataView m_dvRelateConsignee;
        private DataView m_dvRelateShipper;
        private DataView m_dvSeaPort;
        private string m_Entry;
        private UIProxy m_uip;


        public AccountsEditForm()
        {
            InitializeComponent();
            this.grdExchangeRate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.grdEvent.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
        }

        internal void NewAccountsCode()
        {
            this.chkB_SOC.set_Checked(false);
            this.m_ds = this.m_uip.GetDataSetFunction("ADMIN_ACCCODE_NEWDATA", new object[] { UIProxy.m_CurrentUserInformation.get_UserCode(), UIProxy.m_CurrentUserInformation.get_OfficeCode() });
            this.m_AccountID = this.m_ds.Tables["D_ACCOUNTS"].Rows[0]["ACCOUNTS_ID"].ToString();
            DataTable dt = this.m_ds.Tables["D_CUSTOMER_INVOICE_ADDRESS"];
            dt.Columns["INVOICE_ADDRESS"].Unique = true;
            this.BindAllFields();
            this.edtACCOUNTS_CODE.get_Properties().set_ReadOnly(false);
            this.edtACCOUNTS_CODE.set_BackColor(SystemColors.Window);
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
            addtion.AccountForm = this;
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
        #region 确定
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
    ((ColumnView) this.grdRequirements.get_MainView()).set_FocusedColumn(((ColumnView) this.grdRequirements.get_MainView()).get_Columns().get_Item("SPECIAL_REQ_CODE"));
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
    }
}
