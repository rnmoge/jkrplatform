using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace JKRPlatform.Cargo
{
    public partial class eFileForm : Form
    {
        public eFileForm()
        {
            InitializeComponent();
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            PaperForm pf = new PaperForm();
            pf.ShowDialog();
        }

        private void radButton2_Click(object sender, EventArgs e)
        {
            GiveFileForm gf = new GiveFileForm();
            gf.ShowDialog();
        }

        private void radButton7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
