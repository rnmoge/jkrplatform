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
    public partial class ucBillingInvoice : UserControl
    {
        public ucBillingInvoice()
        {
            InitializeComponent();
        }

        private void radButton11_Click(object sender, EventArgs e)
        {
            //检索
            ucBillInvoiceDetail uc = new ucBillInvoiceDetail();
            uc.BorderStyle = BorderStyle.None;
            uc.Dock = DockStyle.Fill;
            this.radPanel1.Controls.Clear();
            this.radPanel1.Controls.Add(uc);
            uc.Show();
        }

        private void radButton3_Click(object sender, EventArgs e)
        {
            //编辑
            Bill c = new Bill();
            c.ShowDialog();
        }

        private void radButton2_Click(object sender, EventArgs e)
        {
            //新建
            billCreation b = new billCreation();
            b.ShowDialog();
        }
    }
}
