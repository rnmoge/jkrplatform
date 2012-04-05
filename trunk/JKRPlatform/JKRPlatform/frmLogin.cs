using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace JKRPlatform
{
    public partial class frmLogin : Telerik.WinControls.UI.RadForm
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new BugTrackerDemo.BugTrackerMain().Show();
        }
    }
}
