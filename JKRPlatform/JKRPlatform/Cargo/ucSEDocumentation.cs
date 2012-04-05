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
    public partial class ucSEDocumentation : UserControl
    {
        public ucSEDocumentation()
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

        private void radButton11_Click(object sender, EventArgs e)
        {
            ucDocumentationdetail uc = new ucDocumentationdetail();
            uc.BorderStyle = BorderStyle.None;
            uc.Dock = DockStyle.Fill;
            this.radPanel1.Controls.Clear();
            this.radPanel1.Controls.Add(uc);
            uc.Show();
        }

        private void radButton14_Click(object sender, EventArgs e)
        {
            SeparateSheetForm fk = new SeparateSheetForm();
            fk.ShowDialog();
        }

        private void radButton10_Click(object sender, EventArgs e)
        {
            CostDetailForm fy = new CostDetailForm();
            fy.ShowDialog();
        }

        private void radButton15_Click(object sender, EventArgs e)
        {
            BillsheetForm bf = new BillsheetForm();
            bf.ShowDialog();
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            DocumentationDetail  uc=new DocumentationDetail();
            uc.BorderStyle = BorderStyle.None;
            uc.Dock = DockStyle.Fill;
            this.radPanel1.Controls.Clear();
            this.radPanel1.Controls.Add(uc);
            uc.Show();
        }

        private void radButton2_Click(object sender, EventArgs e)
        {
            JobNumForm frm = new JobNumForm();
            frm.ShowDialog();
        }
    }
}
