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
    public partial class HsCode : Form
    {
        private DataSet ds;
        //private GridStyle grdMasterStyle;
        private const string masTableName = "D_HS_CODE";


        public HsCode()
        {
            InitializeComponent();
            this.radGridView1.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string strlimit = " 1=1 ";
            if (this.edtHSCode.get_Text().Trim() != string.Empty)
            {
                strlimit = strlimit + " AND HS_CODE LIKE '" + this.edtHSCode.get_Text().ToString().Trim() + "%'";
            }
            if (this.edtCargoName.get_Text().Trim() != string.Empty)
            {
                strlimit = strlimit + " AND CARGO_TYPE LIKE '" + this.edtCargoName.get_Text().ToString().Trim() + "%'";
            }
            this.ds = base.m_uip.GetSynchDataSet("D_HS_CODE", "HS_CODE", new string[0], strlimit);
            this.grdMaster.set_DataSource(this.ds);
            this.grdMaster.set_DataMember(this.ds.Tables[0].TableName);
            this.ds.Tables[0].RowChanged += new DataRowChangeEventHandler(this.masRowchanged);
            this.ds.Tables[0].RowChanging += new DataRowChangeEventHandler(this.masRowchanging);
            this.BindingContext[this.ds, this.ds.Tables[0].TableName].PositionChanged += new EventHandler(this.masDt_PositionChanged);
            this.SetState();
            this.ds.Tables["D_HS_CODE"].ColumnChanged += new DataColumnChangeEventHandler(this.dtHsCodeChanged);

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
    }
}
