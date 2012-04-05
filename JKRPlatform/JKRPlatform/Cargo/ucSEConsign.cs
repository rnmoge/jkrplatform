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
    public partial class ucSEConsign : UserControl
    {
        public ucSEConsign()
        {
            InitializeComponent();
          
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
        //    string sJobId;
            //AEShipmentJobModeForm frm = new AEShipmentJobModeForm();
            PackingForm frm = new PackingForm();
            frm.ShowDialog();
        }

        private void btnSESearch_Click(object sender, EventArgs e)
        {

            ucSEConsignDetail uc = new ucSEConsignDetail();
            uc.BorderStyle = BorderStyle.None;
            uc.Dock = DockStyle.Fill;
            this.radPanel1.Controls.Clear();
            this.radPanel1.Controls.Add(uc);
            uc.Show();
            
        }

        private void radButton9_Click(object sender, EventArgs e)
        {

            PriceByCheckForm ra = new PriceByCheckForm();
            ra.ShowDialog();
        }

        private void radButton3_Click(object sender, EventArgs e)
        {
            ucSEConsignSave b = new ucSEConsignSave();
            b.BorderStyle = BorderStyle.None;
            b.Dock = DockStyle.Fill;
            this.radPanel1.Controls.Clear();
            this.radPanel1.Controls.Add(b);
            b.Show();
        }

        private void radButton7_Click(object sender, EventArgs e)
        {
            NotesForm nf = new NotesForm();
            nf.ShowDialog();
        }

        private void radButton6_Click(object sender, EventArgs e)
        {
            eFileForm ef = new eFileForm();
            ef.ShowDialog();
        }

    }
}
