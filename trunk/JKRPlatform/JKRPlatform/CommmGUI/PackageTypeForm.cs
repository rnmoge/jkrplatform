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
    public partial class PackageTypeForm : Form
    {
        public PackageTypeForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.radGridView1.Rows.AddNew();
            this.btnSave.Enabled = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            this.btnSave.Enabled = true;
            this.radGridView1.ReadOnly = false;
            //this.radGridView1.MasterGridViewInfo.CurrentRow.Cells[3].ReadOnly = true;
            int number = this.radGridView1.ColumnCount - 1;
            for (int i = 0; i < number; i++)
            {
                this.radGridView1.MasterGridViewInfo.CurrentRow.Cells[i].ReadOnly = true;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否删除？", "系统", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                int number = this.radGridView1.Rows.Count;
                for (int i = 0; i < number; i++)
                {
                    if (this.radGridView1.Rows[i].IsSelected == true)
                    {
                        this.radGridView1.Rows[i].Delete();
                        break;
                    }
                }
                this.btnSave.Enabled = false;
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
            int number = this.radGridView1.ColumnCount - 1;
            for (int i = 0; i < number; i++)
            {
                this.radGridView1.MasterGridViewInfo.CurrentRow.Cells[i].ReadOnly = true;
            }
        }

        private void radGridView1_CurrentRowChanged(object sender, Telerik.WinControls.UI.CurrentRowChangedEventArgs e)
        {
            int number = this.radGridView1.ColumnCount - 1;
            for (int i = 0; i < number; i++)
            {
                this.radGridView1.MasterGridViewInfo.CurrentRow.Cells[i].ReadOnly = true;
            }
        }
    }
}
