using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using JKRPlatform.Cargo;

namespace JKRPlatform.CwCount
{
    public partial class ucBillingApprove : UserControl
    {
        public ucBillingApprove()
        {
            InitializeComponent();
        }

        private void radButton11_Click(object sender, EventArgs e)
        {
            ucBillApproveSeach uc = new ucBillApproveSeach();
            uc.BorderStyle = BorderStyle.None;
            uc.Dock = DockStyle.Fill;
            this.radPanel1.Controls.Clear();
            this.radPanel1.Controls.Add(uc);
            uc.Show();
        }

        private void radButton2_Click(object sender, EventArgs e)
        {
            ucBillApproveAdd uc = new ucBillApproveAdd();
            uc.BorderStyle = BorderStyle.None;
            uc.Dock = DockStyle.Fill;
            this.radPanel1.Controls.Clear();
            this.radPanel1.Controls.Add(uc);
            uc.Show();
        }

        private void radButton6_Click(object sender, EventArgs e)
        {
            NotesForm nf = new NotesForm();
            nf.ShowDialog();
        }

        private void radButton7_Click(object sender, EventArgs e)
        {
            TicketCheckForm tf = new TicketCheckForm();
            tf.ShowDialog();
        }

        private void radButton5_Click(object sender, EventArgs e)
        {
            CheckHistoryForm cf = new CheckHistoryForm();
            cf.ShowDialog();
        }

        private void radButton8_Click(object sender, EventArgs e)
        {
            ProfitSeachForm lr = new ProfitSeachForm();
            lr.ShowDialog();
        }

    }
}
