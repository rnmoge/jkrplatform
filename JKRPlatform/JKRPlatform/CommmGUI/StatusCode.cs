using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace JKRPlatform.CommmGUI
{
    public partial class StatusCode : Form
    {
        public StatusCode()
        {
            InitializeComponent();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            this.btnSave.Enabled = true;
            this.radGridView1.ReadOnly = false;
            int number = this.radGridView1.ColumnCount - 2;
            for (int i = 0; i < number; i++)
            {
                this.radGridView1.MasterGridViewInfo.CurrentRow.Cells[i].ReadOnly = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int number = this.radGridView1.Rows.Count;
            for (int i = 0; i < number; i++)
            {
                if (this.radGridView1.Rows[i].IsSelected == true)
                {
                    int num = this.radGridView1.ColumnCount;
                    for (int j = 0; j < num; j++)
                    {
                        string name = this.radGridView1.MasterGridViewInfo.CurrentRow.Cells[j].Value.ToString();
                        return;
                    }
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radGridView1_CurrentColumnChanged(object sender, Telerik.WinControls.UI.CurrentColumnChangedEventArgs e)
        {
            int number = this.radGridView1.ColumnCount - 2;
            for (int i = 0; i < number; i++)
            {
                this.radGridView1.MasterGridViewInfo.CurrentRow.Cells[i].ReadOnly = true;
            }
        }

        private void radGridView1_CurrentRowChanged(object sender, Telerik.WinControls.UI.CurrentRowChangedEventArgs e)
        {
            int number = this.radGridView1.ColumnCount - 2;
            for (int i = 0; i < number; i++)
            {
                this.radGridView1.MasterGridViewInfo.CurrentRow.Cells[i].ReadOnly = true;
            }
        }
    }
}
