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
    public partial class CargoTypeForm : Form
    {
        public CargoTypeForm()
        {
            InitializeComponent();
            DataTable dt = new DataTable();
            dt.Columns.Add("货物类型代码");
            dt.Columns.Add("附加说明");
            string[] name = { "货物类型", "包装类型", "贸易方式", "贸易条款", "信用等级", "货物编码", "工作号状态", "特殊要求", "企业编码", "文件类型", "文件方案", "出口退单文件", "进口退单文件" };
            string[] cont = { "货物基本大类", "货物包装类型", "进出口用到的贸易模式", "贸易条款", "客户信用等级", "海关货物编码", "用于全程跟踪的工作号状态", "公司预置的操作要求", "海关/三检企业编码", "e-File中用到的文件类型", "e-File中用到的文件分组管理方案", "出口报关后退单文件预设", "进口报关后退单文件预设" };
            for (int i = 0; i < 13; i++)
            {
                DataRow dr = dt.NewRow();
                dr["货物类型代码"] = name[i].ToString();
                dr["附加说明"] = cont[i].ToString();
                dt.Rows.Add(dr);
            }
            this.radGridView1.DataSource = dt;
            this.radGridView1.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.radGridView1.Rows.AddNew();
            this.btnSave.Enabled = true;
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
            //this.btnSave.Focus();
            //try
            //{
            //    if (this.m_dt != null)
            //    {
            //        DataProcess.PostEdit(this, this.m_dt);
            //        CommonHelper.SetUpdateInfo(this.m_dt.DataSet);
            //        if (this.m_dt.HasErrors)
            //        {
            //            this.m_uip.ShowMessage(0x2c7);
            //            ((GridView)this.m_grd.get_MainView()).get_OptionsBehavior().set_Editable(true);
            //        }
            //        else
            //        {
            //            DataSet dsChanges = this.m_dt.DataSet.GetChanges();
            //            if ((dsChanges != null) && (this.m_TableName != ""))
            //            {
            //                if (this.m_uip.ExecFunction("COM_UPDATESYNCHDATASET", new object[] { dsChanges }), true, false)
            //                {
            //                    this.m_dt.RowChanged -= new DataRowChangeEventHandler(this.RowChanged);
            //                    this.m_dt.RowDeleted -= new DataRowChangeEventHandler(this.RowDeleted);
            //                    this.m_dt.RowChanging -= new DataRowChangeEventHandler(this.Rowchanging);
            //                    try
            //                    {
            //                        this.Refurbish();
            //                    }
            //                    finally
            //                    {
            //                        this.m_dt.RowChanged += new DataRowChangeEventHandler(this.RowChanged);
            //                        this.m_dt.RowDeleted += new DataRowChangeEventHandler(this.RowDeleted);
            //                        this.m_dt.RowChanging += new DataRowChangeEventHandler(this.Rowchanging);
            //                    }
            //                    this.m_uip.ShowNormalMsg(0x12d);
            //                }
            //                else
            //                {
            //                    this.m_uip.ShowMessage(0x2bd);
            //                }
            //            }
            //        }
            //    }
            //}
            //finally
            //{
            //    this.SetState();
            //}

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
