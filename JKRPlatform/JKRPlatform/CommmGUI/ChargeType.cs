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
    public partial class ChargeType : Form
    {
        public ChargeType()
        {
            InitializeComponent();
        }

        private void radButton3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("数据未保存，是否确定退出？", "费用种类", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
              string m_slimit = "";
    object VB$t_ref$L0 = this.edtAr_Ap.get_Value();
    if (Operators.ConditionalCompareObjectEqual(VB$t_ref$L0, 1, false))
    {
        m_slimit = " AND B_AR=1 ";
    }
    else if (Operators.ConditionalCompareObjectEqual(VB$t_ref$L0, 0, false))
    {
        m_slimit = " AND B_AP=1 ";
    }
    if (this.edtcode.get_EditValue().ToString() != "")
    {
        m_slimit = m_slimit + " AND (CHARGE_CODE LIKE '%" + this.edtcode.get_EditValue().ToString().Trim() + "%'  OR CHARGE_NAME LIKE '%" + this.edtcode.get_EditValue().ToString().Trim() + "%' )";
    }
    if (this.edtCharge_Cname.get_EditValue().ToString() != "")
    {
        m_slimit = m_slimit + " AND CHARGE_CNAME LIKE '%" + this.edtCharge_Cname.get_EditValue().ToString().Trim() + "%' ";
    }
    base.m_dt = base.m_uip.GetDataSetByFunctionName("ADMIN_ACCCODE_GETDATA", "GetChargeType", new object[] { m_slimit }).Tables[0];
    if (base.m_dt != null)
    {
        this.grdMaster.set_DataSource(base.m_dt);
        this.grdMaster.set_DataSource(base.m_dt.DataSet);
        this.grdMaster.set_DataMember(base.m_dt.TableName);
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
            int number = this.radGridView1.ColumnCount - 33;
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
            int number = this.radGridView1.ColumnCount - 33;
            for (int i = 0; i < number; i++)
            {
                this.radGridView1.MasterGridViewInfo.CurrentRow.Cells[i].ReadOnly = true;
            }
        }

        private void radGridView1_CurrentRowChanged(object sender, Telerik.WinControls.UI.CurrentRowChangedEventArgs e)
        {
            int number = this.radGridView1.ColumnCount - 33;
            for (int i = 0; i < number; i++)
            {
                this.radGridView1.MasterGridViewInfo.CurrentRow.Cells[i].ReadOnly = true;
            }
        }


    }
}
