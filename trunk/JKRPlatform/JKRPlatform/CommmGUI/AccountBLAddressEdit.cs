using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox.TextEdit;

namespace JKRPlatform.CommmGUI
{
    public partial class AccountBLAddressEdit : Form
    {
        private IContainer components;
        private DataTable m_dtDetail;
        //private UIProxy m_uip;


        public AccountBLAddressEdit()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            this.AddNew();
        }

        private void AddNew()
        {
            this.SetEditReadStatus(false);
            this.BindingContext[this.m_dtDetail].EndCurrentEdit();
            this.BindingContext[this.m_dtDetail].AddNew();
            ((DataRowView)this.BindingContext[this.m_dtDetail].Current)["ADDRESS_ID"] = this.m_uip.GetMasterSeqId();
            ((DataRowView)this.BindingContext[this.m_dtDetail].Current)["ACCOUNTS_ID"] = this._accountId;
            this.BindingContext[this.m_dtDetail].EndCurrentEdit();
        }

        private void SetEditReadStatus(bool readOnly)
        {
            //IEnumerator VB$t_ref$L0;
            try
            {
                //VB$t_ref$L0 = this.Controls.GetEnumerator();
                //while (VB$t_ref$L0.MoveNext())
                //{
                //    Control ctl = (Control) VB$t_ref$L0.Current;
                //    if (ctl is TextEdit)
                //    {
                //        if (readOnly)
                //        {
                //            ((TextEdit) ctl).set_StyleController(this.get_StyleControllerReadOnly());
                //        }
                //        else
                //        {
                //            ((TextEdit) ctl).set_StyleController(this.get_StyleControllerEnabled());
                //        }
                //    }
                //}
            }
            finally
            {
                //if (VB$t_ref$L0 is IDisposable)
                //{
                //    (VB$t_ref$L0 as IDisposable).Dispose();
                //}
            }
            this.btnDelete.Enabled = !readOnly;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.Delete();
        }
        private void Delete()
        {
            if (MessageBox.Show("确定删除选定的提单记录?", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //ColumnView cv = this.grdBLADDRESS.get_DefaultView();
                //this.m_dtDetail.Rows[cv.get_FocusedRowHandle()].Delete();
            }
        }

        private void btnEsc_Click(object sender, EventArgs e)
        {
            this.BindingContext[this.m_dtDetail].EndCurrentEdit();
            if (!this.IsALLExistValue())
            {
                //this.m_uip.ShowAlarmMsg(MessageInfo.MSG_MUST_INPUT_BL_ADDRESS);
            }
            else
            {
                this.DialogResult = DialogResult.OK;
            }

        }

        private bool IsALLExistValue()
        {
            //IEnumerator VB$t_ref$L0;
            try
            {
                //VB$t_ref$L0 = this.m_dtDetail.Rows.GetEnumerator();
                //while (VB$t_ref$L0.MoveNext())
                //{
                //    DataRow dr = (DataRow) VB$t_ref$L0.Current;
                //    if (dr.RowState != DataRowState.Deleted)
                //    {
                //        bool hasEmpty = false;
                //        int index = 1;
                //        do
                //        {
                //            hasEmpty |= !dr["BL_ADDRESS_LINE" + index.ToString()].ToString().Equals(string.Empty);
                //            index++;
                //        }
                //        while (index <= 6);
                //        if (!hasEmpty && dr["BL_ADDRESS"].ToString().Equals(string.Empty))
                //        {
                //            return false;
                //        }
                //    }
                //}
            }
            finally
            {
                //if (VB$t_ref$L0 is IDisposable)
                //{
                //    (VB$t_ref$L0 as IDisposable).Dispose();
                //}
            }
            return true;
        }

        private void OnColumnChanged(object sender, DataColumnChangeEventArgs e)
        {
            if (e.Column.ColumnName.ToUpper() == "BL_ADDRESS_LINE1")
            {
                this.m_dtDetail.ColumnChanged -= new DataColumnChangeEventHandler(this.OnColumnChanged);
                this.BindingContext[this.m_dtDetail].EndCurrentEdit();
                this.m_dtDetail.ColumnChanged += new DataColumnChangeEventHandler(this.OnColumnChanged);
            }
        }

        private void AccountBLAddressEdit_Load(object sender, EventArgs e)
        {
            this.Initializers();
        }


        private void Initializers()
        {
            //DataProcess.BindFields(this, this.m_dtDetail.DataSet);
            this.grdBLADDRESS.set_DataSource(this.m_dtDetail);
            if (this.m_dtDetail.Rows.Count > 0)
            {
                this.BindingContext[this.m_dtDetail].Position = 0;
            }
            else
            {
                this.SetEditReadStatus(true);
            }
            this.m_dtDetail.ColumnChanged += new DataColumnChangeEventHandler(this.OnColumnChanged);
            this.m_dtDetail.RowDeleted += new DataRowChangeEventHandler(this.OnRowDeleted);
        }

        private void OnRowDeleted(object sender, DataRowChangeEventArgs e)
        {
            //ColumnView cv = this.grdBLADDRESS.get_DefaultView();
            //if (cv.get_RowCount() == 0)
            //{
            this.SetEditReadStatus(true);
            //}
        }

        public string AccountID
        {
            set
            {
                this._accountId = value;
            }
        }
        private string _accountId;
        public DataTable AddressDataTable
        {
            get
            {
                return this.m_dtDetail;
            }
            set
            {
                this.m_dtDetail = value;
            }
        }
    }
}
