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
    public partial class ReturnFileSettingImport : Form
    {
        private Splitter _Splitter1;
        private IContainer components;
        private DataSet m_Ds;
        private ReturnFileType m_Type;
        private UIProxy m_UIP;

        public ReturnFileSettingImport()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                this.BindingContext[this.m_Ds.Tables["D_TRADE_STYLE"]].EndCurrentEdit();
                CommonHelper.SetUpdateInfo(this.m_Ds);
                this.BindingContext[this.m_Ds.Tables["D_SYS_CODE"]].EndCurrentEdit();
                if (Conversions.ToBoolean(this.m_UIP.ExecFunctionByName("ADMIN_MASTER_DATA", "SaveData", new object[] { this.m_Ds })))
                {
                    this.m_UIP.ShowNormalMsg(0xc9);
                }
                else
                {
                    this.m_UIP.ShowErrorMsg(0xca);
                }
            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                Exception ex = exception1;
                ProjectData.ClearProjectError();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
