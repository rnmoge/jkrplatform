﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace JKRPlatform.CwCount
{
    public partial class ucBillingCashier : UserControl
    {
        public ucBillingCashier()
        {
            InitializeComponent();
        }

        private void radButton2_Click(object sender, EventArgs e)
        {
            ucBillCashierPractical uc = new ucBillCashierPractical();
            uc.BorderStyle = BorderStyle.None;
            uc.Dock = DockStyle.Fill;
            this.radPanel1.Controls.Clear();
            this.radPanel1.Controls.Add(uc);
            uc.Show();
        }

        private void radButton4_Click(object sender, EventArgs e)
        {
            verificationHistory a = new verificationHistory();
            a.ShowDialog();
        }
    }
}
