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
    public partial class ucBillingChase : UserControl
    {
        public ucBillingChase()
        {
            InitializeComponent();
        }

        private void radButton2_Click(object sender, EventArgs e)
        {
            CostDetailed c = new CostDetailed();
            c.ShowDialog();

        }

        private void radButton3_Click(object sender, EventArgs e)
        {
            PushRecord p = new PushRecord();
            p.ShowDialog();
        }

    }
}
