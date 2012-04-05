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
    public partial class ucBillingReports : UserControl
    {
        public ucBillingReports()
        {
            InitializeComponent();
        }

        private void radButton2_Click(object sender, EventArgs e)
        {
            StatisticalProjectForm a = new StatisticalProjectForm();
            a.ShowDialog();
        }

        private void radButton7_Click(object sender, EventArgs e)
        {
            SchemeBillReports b = new SchemeBillReports();
            b.ShowDialog();
        }
    }
}
