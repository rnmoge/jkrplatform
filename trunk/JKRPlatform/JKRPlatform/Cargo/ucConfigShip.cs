using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace JKRPlatform.Cargo
{
    public partial class ucConfigShip : UserControl
    {
        public ucConfigShip()
        {
            InitializeComponent();
        }

        private void radButton10_Click(object sender, EventArgs e)
        {
            MBLForm uc = new MBLForm();
            //uc.FormBorderStyle = FormBorderStyle.None;
            //uc.Dock = DockStyle.Fill;
            //this.radPanel1.Controls.Clear();
            //this.radPanel1.Controls.Add(uc);
            uc.Show();
        }

        private void radButton13_Click(object sender, EventArgs e)
        {
            ucConfigShipDetail uc = new ucConfigShipDetail();
            uc.BorderStyle = BorderStyle.None;
            uc.Dock = DockStyle.Fill;
            this.radPanel1.Controls.Clear();
            this.radPanel1.Controls.Add(uc);
            uc.Show();
        }
    }
}
