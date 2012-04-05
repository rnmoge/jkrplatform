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
    public partial class ucBillApproveAdd : UserControl
    {
        public ucBillApproveAdd()
        {
            InitializeComponent();
        }

        private void radButton23_Click(object sender, EventArgs e)
        {
            ProgramCosts p = new ProgramCosts();
            p.ShowDialog();
        }
    }
}
