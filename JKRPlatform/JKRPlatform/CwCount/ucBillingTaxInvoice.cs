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
    public partial class ucBillingTaxInvoice : UserControl
    {
        public ucBillingTaxInvoice()
        {
            InitializeComponent();
        }

        private void radButton2_Click(object sender, EventArgs e)
        {
            CreateTaxInvoiceForm uc = new CreateTaxInvoiceForm();
            uc.ShowDialog();
        }

        private void radButton3_Click(object sender, EventArgs e)
        {
            TaxInvoice uc = new TaxInvoice();
            uc.ShowDialog();
        }

        private void radButton11_Click(object sender, EventArgs e)
        {
            ucBillTaxInvoiceDetail uc = new ucBillTaxInvoiceDetail();
            uc.BorderStyle = BorderStyle.None;
            uc.Dock = DockStyle.Fill;
            this.radPanel1.Controls.Clear();
            this.radPanel1.Controls.Add(uc);
            uc.Show();
        } 
    }
}
