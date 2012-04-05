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
    public partial class ucSEVessel : UserControl
    {
        public ucSEVessel()
        {
            InitializeComponent();
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            ucSEVesseladd uc = new ucSEVesseladd();
            uc.BorderStyle = BorderStyle.None;
            uc.Dock = DockStyle.Fill;
            this.radPanel1.Controls.Clear();
            this.radPanel1.Controls.Add(uc);
            uc.Show();
        }

        private void radButton11_Click(object sender, EventArgs e)
        {
            ucSEVesselSeach uc = new ucSEVesselSeach();
            uc.BorderStyle = BorderStyle.None;
            uc.Dock = DockStyle.Fill;
            this.radPanel1.Controls.Clear();
            this.radPanel1.Controls.Add(uc);
            uc.Show();
        }
    }
}
