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
    public partial class AccountsAdditionForm : Form
    {
        private IContainer components;
        private AccountInfoForm m_AccountForm;
        private DataSet m_DsDetail;
        private DataView m_dvAirPort;
        private DataView m_dvRelateConsignee;
        private DataView m_dvRelateShipper;
        private DataView m_dvSeaPort;
        private UIProxy m_uip;


        public AccountsAdditionForm()
        {
            InitializeComponent();
        }

        public DataSet DsDetail
        {
            get
            {
                return this.m_DsDetail;
            }
            set
            {
                this.m_DsDetail = value;
            }
        }
        public AccountInfoForm AccountForm
        {
            get
            {
                return this.m_AccountForm;
            }
            set
            {
                this.m_AccountForm = value;
            }
        }
        public void BindAllFields()
        {
            this.SetBindFields(this.TabPage103, this.DsDetail.Tables["D_ACCOUNTS"]);
            this.grdBOXUP.set_DataSource(this.DsDetail.Tables["D_ACCOUNTS_BOXUP"]);
            this.grdAdditionalNo.set_DataSource(this.DsDetail.Tables["D_ACCOUNTS_ADD_NO"]);
            this.grdCustomerSellingRate.set_DataSource(this.DsDetail.Tables["IFM_AIR_FREIGHT"]);
            this.grdFreightSchedule.set_DataSource(this.DsDetail.Tables["IFM_FREIGHT_SCHEDULE"]);
            this.SetBindFields(this.TabPage106, this.DsDetail.Tables["D_ACCOUNTS_CUSTOMER"]);
            this.SetBindFields(this.TabPage107, this.DsDetail.Tables["D_ACCOUNTS_EC_SET"]);
            this.grdCustomerOverseaAgent.set_DataSource(this.DsDetail.Tables["D_CUSTOMER2AIRAGENT"]);
            this.grdCustomerCarrier.set_DataSource(this.DsDetail.Tables["D_PREFER_CARRIER"]);
            this.SetBindFields(this.TabPage111, this.DsDetail.Tables["D_ACCOUNTS_CUSTOMER"]);
            this.SetBindFields(this.TabPage200, this.DsDetail.Tables["D_ACCOUNTS_SEA_OSAGENT"]);
            this.SetBindFields(this.TabPage200, this.DsDetail.Tables["D_ACCOUNTS_AIR_OSAGENT"]);
            this.grdAgentAddress.set_DataSource(this.DsDetail.Tables["D_ACCOUNTS_AGENT_ADDRESS"]);
            this.SetBindFields(this.TabPage301, this.DsDetail.Tables["D_ACCOUNTS_AIRWAY"]);
            this.grdSurcharge.set_DataSource(this.DsDetail.Tables["D_AIRLINE_SURCHARGE"]);
            this.grdAirlinePort.set_DataSource(this.DsDetail.Tables["D_AIRLINE_PORT"]);
            this.grdServiceLevel.set_DataSource(this.DsDetail.Tables["D_AIRLINE_SERVICE"]);
            this.grdDataCargo_Group.set_DataSource(this.DsDetail.Tables["D_SHIPLINE_CARGO_GROUP"]);
            this.grdShipport.set_DataSource(this.DsDetail.Tables["D_SHIPLINE_PORT"]);
            this.SetBindFields(this.TabPage403, this.DsDetail.Tables["D_ACCOUNTS_LINEAR"]);
            this.grdData404.set_DataSource(this.DsDetail.Tables["D_SHIPLINE_OVERWEIGHT_ALARM"]);
            this.grdData405.set_DataSource(this.DsDetail.Tables["D_SHIPLINE_OVERTIME_ALARM"]);
            this.grdData406.set_DataSource(this.DsDetail.Tables["D_SHIPLINE_OVEREXEMPT_ALARM"]);
            this.grdData407.set_DataSource(this.DsDetail.Tables["D_SHIPLINE_BOOKING_BY"]);
            this.m_dvRelateConsignee = new DataView(this.DsDetail.Tables["D_ACCOUNTS2ACCOUNTS"]);
            this.grdShipper2Consignee.set_DataSource(this.m_dvRelateConsignee);
            this.m_dvRelateConsignee.RowFilter = "SHIPPER_ID=" + this.DsDetail.Tables["D_ACCOUNTS"].Rows[0]["ACCOUNTS_ID"].ToString();
            this.SetBindFields(this.TabPage502, this.DsDetail.Tables["D_SHIPPER_KC_NO"]);
            this.m_dvRelateShipper = new DataView(this.DsDetail.Tables["D_ACCOUNTS2ACCOUNTS"]);
            this.grdConsignee2Shipper.set_DataSource(this.m_dvRelateShipper);
            this.m_dvRelateShipper.RowFilter = "CONSIGNEE_ID=" + this.DsDetail.Tables["D_ACCOUNTS"].Rows[0]["ACCOUNTS_ID"].ToString();
            if (this.DsDetail.Tables["D_ACCOUNTS_TRUCK"].Rows.Count > 0)
            {
                if (this.DsDetail.Tables["D_ACCOUNTS_TRUCK"].Rows[0]["B_OUR_TRUCK"].ToString() == "0")
                {
                    this.chkB_OUR_TRUCK.set_Checked(false);
                }
                else
                {
                    this.chkB_OUR_TRUCK.set_Checked(true);
                }
            }
            this.SetBindFields(this.TabPage900, this.DsDetail.Tables["D_ACCOUNTS_BROKER"]);
            this.SetBindFields(this.TabPage204, this.DsDetail.Tables["D_ACCOUNTS_AGENT"]);
            this.grdAccountsFiles.set_DataSource(this.DsDetail.Tables["D_ACCOUNTS_FILES"]);
            this.SetBindFields(this.TabPageE00, this.DsDetail.Tables["D_ACCOUNTS_TERMINAL"]);
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



    }
}
