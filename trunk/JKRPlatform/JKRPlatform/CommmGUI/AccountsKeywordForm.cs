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
    public partial class AccountsKeywordForm : Form
    {
        private IContainer components;
        private DataSet m_ds;
        private string m_sKeyword;
        private UIProxy m_uip;


        public AccountsKeywordForm()
        {
            InitializeComponent();
            this.grdData.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
        }

        private void AccountsKeywordForm_Load(object sender, EventArgs e)
        {
            this.m_ds = this.m_uip.GetDataSetByFunctionName("ADMIN_ACCCODE_GETDATA", "GetKeyWord", new object[0]);
            if ((this.m_ds != null) && (this.m_ds.Tables[0].Rows.Count != 0))
            {
                this.SetDataGridCheck(this.m_sKeyword);
                //this.edtKeyWord.set_EditValue(this.m_sKeyword);
                this.grdData.set_DataSource(this.m_ds.Tables[0]);
            }

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.m_sKeyword = this.edtKeyWord.get_EditValue().ToString().Trim();
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public string SelKeyword
        {
            get
            {
                return this.m_sKeyword;
            }
            set
            {
                this.m_sKeyword = value;
            }
        }

        private void SetDataGridCheck(string str)
        {
            if ((((this.m_ds != null) && (this.m_ds.Tables[0].Rows.Count != 0)) && (str != null)) && (str.Trim().Length != 0))
            {
                //IEnumerator VB$t_ref$L0;
                try
                {
                    //VB$t_ref$L0 = this.m_ds.Tables[0].Rows.GetEnumerator();
                    //while (VB$t_ref$L0.MoveNext())
                    //{
                    //    DataRow row = (DataRow) VB$t_ref$L0.Current;
                    //    if (str.IndexOf(row["CODE_VALUE"].ToString().Trim()) != -1)
                    //    {
                    //        row.BeginEdit();
                    //        row["SELECTED"] = 1;
                    //        row.EndEdit();
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
}
