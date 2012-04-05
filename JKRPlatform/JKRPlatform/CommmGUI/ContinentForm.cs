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
    public partial class ContinentForm : Form
    {
        private IContainer components;
        private DataRelation dataRela;
        private DataTable detdt;
        private const string detTableName = "D_SUB_CONTINENT";
        private DataSet ds;
        private GridStyle grdDetailStyle;
        private GridStyle grdMasterStyle;
        private DataTable masdt;
        private const string masTableName = "D_CONTINENT";


        public ContinentForm()
        {
            InitializeComponent();
            this.radGridView1.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.radGridView2.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (this.masdt != null)
            {
                DataProcess.PostEdit(this, this.masdt);
                DataRow row = this.masdt.NewRow();
                row["create_by"] = UIProxy.m_CurrentUserInformation.get_UserCode();
                row["create_date"] = UIProxy.m_CurrDateTime;
                this.masdt.Rows.Add(row);
                ((GridView)this.grdMaster.get_MainView()).get_OptionsBehavior().set_Editable(true);
                this.grdMasterCONTINENT_CODE.set_Options(0x19f);
                this.btnEdit.Enabled = false;
                this.btnSave.Enabled = true;
                this.grdMaster.Focus();
            }
        }

        private void btnSubAdd_Click(object sender, EventArgs e)
        {
            if ((this.masdt.Rows.Count > 0) && (DataProcess.GetDataRow(this, this.masdt)["CONTINENT_CODE"].ToString().Trim() != ""))
            {
                this.PostDetail();
                DataRow row = this.detdt.NewRow();
                row["CONTINENT_CODE"] = RuntimeHelpers.GetObjectValue(DataProcess.GetDataRow(this, this.masdt)["CONTINENT_CODE"]);
                row["create_by"] = UIProxy.m_CurrentUserInformation.get_UserCode();
                row["create_date"] = UIProxy.m_CurrDateTime;
                this.detdt.Rows.Add(row);
                this.grdDetail.Select();
                ((ColumnView)this.grdDetail.get_MainView()).set_FocusedColumn(((ColumnView)this.grdDetail.get_MainView()).get_Columns().get_Item("SUB_CONTINENT_CODE"));
            }

        }

        private void btnSubDel_Click(object sender, EventArgs e)
        {
            if (this.masdt.Rows.Count != 0)
            {
                DataRow[] rows = DataProcess.GetDataRow(this, this.masdt).GetChildRows(this.dataRela);
                if ((rows.Length > 0) && this.IsSureDelete())
                {
                    int Position = this.BindingContext[this.ds, this.masdt.TableName + "." + this.dataRela.RelationName].Position;
                    rows[Position].Delete();
                    this.btnSave.Enabled = true;
                }
            }
        }

        private void bntExport_Click(object sender, EventArgs e)
        {

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
            try
            {
                if (this.masdt.Rows.Count != 0)
                {
                    this.PostDetail();
                    this.PostMaster();
                    if (this.ds.HasErrors)
                    {
                        if (UIProxy.get_Language() == 1)
                        {
                            Interaction.MsgBox("列表中存在错误! 请检查!", (MsgBoxStyle)Conversions.ToInteger("信息"), null);
                        }
                        else
                        {
                            Interaction.MsgBox("Has error! Please check!", (MsgBoxStyle)Conversions.ToInteger("Informtaion"), null);
                        }
                    }
                    else
                    {
                        DataSet dsChanges = this.ds.GetChanges();
                        if (dsChanges != null)
                        {
                            if (base.m_uip.UpdateSynchDataSet(dsChanges))
                            {
                                this.masdt.RowChanged -= new DataRowChangeEventHandler(this.masRowchanged);
                                this.masdt.RowChanging -= new DataRowChangeEventHandler(this.masRowchanging);
                                this.detdt.RowChanged -= new DataRowChangeEventHandler(this.detRowchanged);
                                this.detdt.RowChanging -= new DataRowChangeEventHandler(this.detRowchanging);
                                this.BindingContext[this.ds, this.masdt.TableName].PositionChanged -= new EventHandler(this.masDt_PositionChanged);
                                try
                                {
                                    this.ds.AcceptChanges();
                                    this.btnEdit.Enabled = true;
                                }
                                finally
                                {
                                    this.masdt.RowChanged += new DataRowChangeEventHandler(this.masRowchanged);
                                    this.masdt.RowChanging += new DataRowChangeEventHandler(this.masRowchanging);
                                    this.detdt.RowChanged += new DataRowChangeEventHandler(this.detRowchanged);
                                    this.detdt.RowChanging += new DataRowChangeEventHandler(this.detRowchanging);
                                    this.BindingContext[this.ds, this.masdt.TableName].PositionChanged += new EventHandler(this.masDt_PositionChanged);
                                }
                            }
                            else
                            {
                                base.m_uip.ShowMessage(0x2bd);
                            }
                        }
                    }
                }
            }
            finally
            {
                this.SetState();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }



    }
}
