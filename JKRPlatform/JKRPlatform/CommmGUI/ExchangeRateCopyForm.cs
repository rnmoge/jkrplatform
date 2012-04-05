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
    public partial class ExchangeRateCopyForm : Form
    {
        public ExchangeRateCopyForm()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (this.edtPARENT_COMPANY_CODE.get_EditValue().ToString() == "")
            {
                this.m_uip.ShowMessage(0x2cc);
            }
            else
            {
                this.DialogResult = DialogResult.OK;
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
