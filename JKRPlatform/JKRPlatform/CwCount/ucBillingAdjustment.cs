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
    public partial class ucBillingAdjustment : UserControl
    {
        public ucBillingAdjustment()
        {
            InitializeComponent();
        }

        private void radButton11_Click(object sender, EventArgs e)
        {
            ucBillAdjustmentSearch a = new ucBillAdjustmentSearch();
            a.BorderStyle = BorderStyle.None;
            a.Dock = DockStyle.Fill;
            this.radPanel1.Controls.Clear();
            this.radPanel1.Controls.Add(a);
            a.Show();
        }

        private void radButton2_Click(object sender, EventArgs e)
        {
            ucBillAdjustmentDetail a = new ucBillAdjustmentDetail();
            a.BorderStyle = BorderStyle.None;
            a.Dock = DockStyle.Fill;
            this.radPanel1.Controls.Clear();
            this.radPanel1.Controls.Add(a);
            a.Show();
        }
    }
}
