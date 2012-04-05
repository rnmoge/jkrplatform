using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace JKRPlatform.CwCount
{
    public partial class ucBillingSettlement : UserControl
    {
        public ucBillingSettlement()
        {
            InitializeComponent();
        }

        private void radButton2_Click(object sender, EventArgs e)
        {
            Verification v = new Verification();
            v.ShowDialog();
        }

        private void radButton5_Click(object sender, EventArgs e)
        {
            AfterVerification a = new AfterVerification();
            a.ShowDialog();
        }
    }
}
