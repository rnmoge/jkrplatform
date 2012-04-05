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
    public partial class CostGroup : Form
    {
        private IContainer components;
    private const string FunctionCode = "ADMIN_CHARGEGROUP_GETDATA";
    private const string FunName_CHECKDUPLICATE = "CheckGroupCodeDuplicate";
    private const string FunName_GETDATA = "GetChargeGroupData";
    private const string FunName_NEWDATA = "NewChargeGroupData";
    private const string FunName_SAVEDATA = "SaveChargeGroupData";
    private DataSet m_dsChargeGroup;
    private DataView m_dvCharges;
    private UIProxy m_uip;
    private string sChargeGroup;



        public CostGroup()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 关闭窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radButton2_Click(object sender, EventArgs e)
        {
                this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (this.CheckValid() && (this.dsChanges() && this.CheckChargeCodeDuplicate()))
    {
        DataRow VB$t_ref$L0 = this.m_dsChargeGroup.Tables[0].Rows[0];
        VB$t_ref$L0["UPDATE_BY"] = UIProxy.m_CurrentUserInformation.get_UserCode();
        VB$t_ref$L0["UPDATE_DATE"] = UIProxy.m_CurrDateTime;
        VB$t_ref$L0 = null;
        if (Conversions.ToBoolean(this.m_uip.ExecFunctionByName("ADMIN_CHARGEGROUP_GETDATA", "SaveChargeGroupData", new object[] { this.m_dsChargeGroup })))
        {
            this.m_dsChargeGroup.AcceptChanges();
            this.m_uip.ShowMessage(0xc9);
            this.DialogResult = DialogResult.OK;
        }
    }

        }
    }
}
