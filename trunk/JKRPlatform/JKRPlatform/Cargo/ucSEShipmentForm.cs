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
    public partial class ucSEShipmentForm : UserControl
    {
        public ucSEShipmentForm()
        {
            InitializeComponent();
        }

        private void radButton7_Click(object sender, EventArgs e)
        {
            NotesForm nf = new NotesForm();
            nf.ShowDialog();
        }

        private void radButton6_Click(object sender, EventArgs e)
        {
            eFileForm nf = new eFileForm();
            nf.ShowDialog();
        }

        private void radButton1_Click(object sender, EventArgs e)
        {

            CostDetailForm nf = new CostDetailForm();
            nf.ShowDialog();
        }

        private void radButton11_Click(object sender, EventArgs e)
        {
            ucShipmentDetail uc = new ucShipmentDetail();
            uc.BorderStyle = BorderStyle.None;
            uc.Dock = DockStyle.Fill;
            //uc.AutoScroll = true;
            this.radPanel1.Controls.Clear();
            this.radPanel1.Controls.Add(uc);
            uc.Show();
        }

        /// <summary>
        /// 全程状态
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radButton5_Click(object sender, EventArgs e)
        {
            EntireStateForm ef = new EntireStateForm();
            ef.ShowDialog();
        }

        private void radButton3_Click(object sender, EventArgs e)
        {
            ucShipmentView uc = new ucShipmentView();
            uc.BorderStyle = BorderStyle.None;
            uc.Dock = DockStyle.Fill;
            this.radPanel1.Controls.Clear();
            this.radPanel1.Controls.Add(uc);
            uc.Show();
        }
    }
}
