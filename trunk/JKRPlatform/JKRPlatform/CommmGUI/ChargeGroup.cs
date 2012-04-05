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
    public partial class ChargeGroup : Form
    {
        private IContainer components;
        private const string FunctionCode = "ADMIN_CHARGEGROUP_GETDATA";
        private const string FunName_DELETEDATA = "DeleteChargeGroupData";


        public ChargeGroup()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 关闭窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CostGroup s01140401 = new CostGroup();
            s01140401.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ColumnView cv = this.gvMaster;
            DataRow dr = cv.GetDataRow(cv.get_FocusedRowHandle());
            if (dr != null)
            {
                this.EditChargeGroup(dr["GROUP_CODE"].ToString());
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

        private void EditChargeGroup([Optional, DefaultParameterValue("")] string group_code)
        {
            ChargeGroupEditForm frm = new ChargeGroupEditForm();
            frm.ChargeGroup = group_code;
            if ((frm.ShowDialog() == DialogResult.OK) && (group_code == ""))
            {
            }
            base.m_dt.DataSet.AcceptChanges();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radGridView1_DoubleClick(object sender, EventArgs e)
        {
            CostGroup s01140401 = new CostGroup();
            s01140401.ShowDialog();
        }
    }
}
