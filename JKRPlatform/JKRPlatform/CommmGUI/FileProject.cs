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
    public partial class FileProject : Form
    {
        private DataRelation dataRela;
        private DataTable detdt;
        private const string detTableName = "D_FILES_PROJECT_DETAIL";
        private DataSet ds;
        //private GridStyle grdDetailStyle;
        //private GridStyle grdMasterStyle;
        private const string m_DetTableKeyName = "FILES_PROJECT_DETAIL_ID";
        private const string m_MasTableKeyName = "FILES_PROJECT_ID";
        private DataTable masdt;
        private const string masTableName = "D_FILES_PROJECT";


        public FileProject()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataProcess.PostEdit(this, this.masdt);
            DataRow row = this.masdt.NewRow();
            row["FILES_PROJECT_ID"] = base.m_uip.GetMasterSeqId();
            row["create_by"] = UIProxy.m_CurrentUserInformation.get_UserCode();
            row["create_date"] = UIProxy.m_CurrDateTime;
            this.masdt.Rows.Add(row);
            ((GridView)this.grdMaster.get_MainView()).get_OptionsBehavior().set_Editable(true);
            this.grdMasterFILES_PROJECT_ID.set_Options(0x19f);
            this.btnSave.Enabled = true;
            this.btnSubAdd.Enabled = true;
            this.btnSubDel.Enabled = true;
            this.grdMaster.Focus();
        }

        private void btnSubDel_Click(object sender, EventArgs e)
        {
            ColumnView view = this.grdDetail.get_MainView();
            view.DeleteRow(view.get_FocusedRowHandle());
        }

        private void btnSubAdd_Click(object sender, EventArgs e)
        {
            if ((this.masdt.Rows.Count > 0) && (DataProcess.GetDataRow(this, this.masdt)["FILES_PROJECT_ID"].ToString().Trim() != ""))
            {
                this.BindingContext[this.grdDetail.get_DataSource(), this.grdDetail.get_DataMember()].EndCurrentEdit();
                DataRow row = this.detdt.NewRow();
                row["FILES_PROJECT_DETAIL_ID"] = base.m_uip.GetMasterSeqId();
                row["FILES_PROJECT_ID"] = DataProcess.GetDataRow(this, this.masdt)["FILES_PROJECT_ID"];
                this.detdt.Rows.Add(row);
                this.grdDetail.Select();
                ((ColumnView)this.grdDetail.get_MainView()).set_FocusedColumn(((ColumnView)this.grdDetail.get_MainView()).get_Columns().get_Item("FILE_TYPE"));
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            this.radGridView1.ReadOnly = false;
            this.radGridView2.ReadOnly = false;
            ((GridView)this.grdMaster.get_MainView()).get_OptionsBehavior().set_Editable(true);
            this.btnSave.Enabled = true;
            this.SetGbxDetailState(true);
        }

        private void SetGbxDetailState(bool IsEnable)
        {
            ((GridView)this.grdDetail.get_MainView()).get_OptionsBehavior().set_Editable(IsEnable);
            this.btnSubAdd.Enabled = IsEnable;
            this.btnSubDel.Enabled = IsEnable;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.BindingContext[this.ds, this.masdt.TableName].EndCurrentEdit();
            this.BindingContext[this.ds, this.masdt.TableName + "." + this.dataRela.RelationName].EndCurrentEdit();
            if (this.masdt.Rows.Count > 0)
            {
                if (this.ds.HasChanges())
                {
                    UIProxy.ShowPopupMessage(0xcb);
                }
                else if (this.IsSureDelete())
                {
                    ColumnView View = this.grdMaster.get_MainView();
                    DataRow row = View.GetDataRow(View.get_FocusedRowHandle());
                    DataRow[] rows = row.GetChildRows(this.dataRela);
                    int VB$t_i4$L0 = rows.Length - 1;
                    for (int i = 0; i <= VB$t_i4$L0; i++)
                    {
                        rows[i].Delete();
                    }
                    base.m_uip.UpdateSynchDataSet(this.ds.GetChanges());
                    this.ds.GetChanges();
                    row.Delete();
                    base.m_uip.UpdateSynchDataSet(this.ds.GetChanges());
                    this.ds.AcceptChanges();
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
             try
                {
                  if(this.masdt.Rows.Count != 0)
                  {
            this.BindingContext[RuntimeHelpers.GetObjectValue(this.grdDetail.get_DataSource()), this.grdDetail.get_DataMember()].EndCurrentEdit();
            this.BindingContext[RuntimeHelpers.GetObjectValue(this.grdMaster.get_DataSource()), this.grdMaster.get_DataMember()].EndCurrentEdit();
            if (this.ds.HasErrors)
            {
                if(UIProxy.get_Language() == 1)
                {
                    Interaction.MsgBox("列表中存在错误! 请检查!", MsgBoxStyle.Information, null);
                }
                else
                {
                    Interaction.MsgBox("Has error! Please check!", MsgBoxStyle.Information, null);
                }
            }
            else
            {
                DataSet dsChanges = this.ds.GetChanges();
                if(dsChanges != null)
                {
                    if(base.m_uip.UpdateSynchDataSet(dsChanges))
                    {
                        this.masdt.RowChanged -= new DataRowChangeEventHandler(this.masRowchanged);
                        this.masdt.RowChanging -= new DataRowChangeEventHandler(this.masRowchanging);
                        this.BindingContext[this.ds, this.masdt.TableName].PositionChanged -= new EventHandler(this.masDt_PositionChanged);
                        try
                        {
                            this.ds.AcceptChanges();
                        }
                        finally
                        {
                            this.masdt.RowChanged += new DataRowChangeEventHandler(this.masRowchanged);
                            this.masdt.RowChanging += new DataRowChangeEventHandler(this.masRowchanging);
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