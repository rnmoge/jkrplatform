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
    public partial class PortForm : Form
    {
        private IContainer components;

        public PortForm()
        {
            InitializeComponent();
            this.radGridView1.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string strlimit = "";
            if (this.edtCOUNTRY.get_Text().Trim() != "")
            {
                strlimit = strlimit + " AND COUNTRY_CODE = '" + this.edtCOUNTRY.get_EditValue().ToString().Trim() + "'";
            }
            if (this.edtcode.get_EditValue().ToString() != "")
            {
                strlimit = strlimit + " AND (PORT_CODE LIKE '%" + this.edtcode.get_EditValue().ToString().Trim() + "%'  OR PORT_NAME LIKE '%" + this.edtcode.get_EditValue().ToString().Trim() + "%'  OR PORT_CNAME LIKE '%" + this.edtcode.get_EditValue().ToString().Trim() + "%' )";
            }
            if (this.edtairportcode.get_EditValue().ToString() != "")
            {
                strlimit = strlimit + " AND PORT_AIRCODE = '" + this.edtairportcode.get_EditValue().ToString().Trim() + "'";
            }
            if (this.edtArea.get_EditValue().ToString() != "")
            {
                strlimit = strlimit + " AND AREA_CODE = '" + this.edtArea.get_EditValue().ToString().Trim() + "'";
            }
            base.m_dt = base.m_uip.GetDataSetByFunctionName("ADMIN_ACCCODE_GETDATA", "GetPort", new object[] { strlimit }).Tables[0];
            if (base.m_dt != null)
            {
                this.grdMaster.set_DataSource(base.m_dt);
                this.grdMaster.set_DataSource(base.m_dt.DataSet);
                this.grdMaster.set_DataMember(base.m_dt.TableName);
                base.m_dt.RowChanged += new DataRowChangeEventHandler(this.RowChanged);
                base.m_dt.RowDeleted += new DataRowChangeEventHandler(this.RowDeleted);
            }

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
            int number = this.radGridView1.ColumnCount - 16;
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

        private void btnExport_Click(object sender, EventArgs e)
        {

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
