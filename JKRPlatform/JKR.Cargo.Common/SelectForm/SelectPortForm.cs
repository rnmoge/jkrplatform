using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using JKR.GUI.LogixConnector;
using JKR.Cargo.Common.Common;
using Telerik.WinControls.UI;

namespace JKR.Cargo.Common.SelectForm
{
    public partial class SelectPortForm : Form
    {
        private UIProxy m_uip;
        private string port_code;
        private string port_name;
        // Nested Types
        public enum iPortTpe
        {
            iPortSEA = 0,
            iPortAIR = 1
        }

        #region
        public SelectPortForm(EnumCustomsJobType jobType, bool bEnabled)
            : this()
        {
            this.rgSelect.Enabled = bEnabled;
            switch (jobType)
            {
                case EnumCustomsJobType.eAECustoms:
                case EnumCustomsJobType.eAICustoms:
                    this.rgSelect.Focusable = true;
                    break;

                case EnumCustomsJobType.eSECustoms:
                case EnumCustomsJobType.eSICustoms:
                    this.rgSelect1.Focusable = false;
                    break;
            }
        }
        #endregion


        public SelectPortForm()
        {
            InitializeComponent();
        }

        public object KeyWord
        {
            set
            {
                if ((value == null) || (value == DBNull.Value))
                {
                    this.edtKeyWord.Text = string.Empty;
                }
                else
                {
                    this.edtKeyWord.Text = value.ToString();
                    this.SearchPort();
                }
            }
        }

        public object PortCode
        {
            get
            {
                DataRow selectedDataRow = this.GetSelectedDataRow(this.grdMain);
                if (selectedDataRow == null)
                {
                    return DBNull.Value;
                }
                return selectedDataRow["PORT_CODE"].ToString();

            }
        }

        private void SearchPort()
        {
            string str = this.getSql();
            DataSet dataSetFunction = this.m_uip.GetDataSetFunction("COM_EXECUTEQUERY", new object[] { str, "PORT_LIST" });
            if (dataSetFunction != null)
            {
                if (dataSetFunction.Tables[0].Rows.Count == 0)
                {
                    this.m_uip.ShowMessage(HintMessageType.MSG_NOTIFY_SURE_FIELD);
                }
                else
                {
                    this.m_uip.ShowNormalMsg("");
                    this.grdMain.DataSource = dataSetFunction;
                    this.grdMain.DataMember = "PORT_LIST";
                }
            }
        }

        private DataRow GetSelectedDataRow(RadGridView grd)
        {
            DataRow dataRow = null;
            try
            {
                GridViewRowInfo cv = (GridViewRowInfo)grd.ViewDefinition;
                if (cv == null)
                {
                    return null;
                }
                int focusedRowHandle = cv.ViewInfo.CurrentIndex;
                //dataRow = defaultView.GetDataRow(focusedRowHandle);

            }
            catch (Exception exception1)
            {
                return null;
            }
            return dataRow;
        }

        private string getSql()
        {
            string str2 = string.Empty;
            if (this.rgSelect.Focused == true)
            {
                str2 = "SELECT PORT_CODE AS PORT_CODE,PORT_NAME,PORT_CNAME FROM D_PORT WHERE PORT_CODE IS NOT NULL AND (PORT_CODE LIKE '%" + this.edtKeyWord.Text.Trim() + "%' OR PORT_NAME LIKE '%" + this.edtKeyWord.Text.Trim() + "%' OR PORT_CNAME LIKE '%" + this.edtKeyWord.Text.Trim() + "%')";
            }
            if (this.rgSelect1.Focused == true)
            {
                str2 = "SELECT PORT_AIRCODE AS PORT_CODE,PORT_NAME,PORT_CNAME FROM D_PORT WHERE PORT_AIRCODE IS NOT NULL AND (PORT_AIRCODE LIKE '%" + this.edtKeyWord.Text.Trim() + "%' OR PORT_NAME LIKE '%" + this.edtKeyWord.Text.Trim() + "%' OR PORT_CNAME LIKE '%" + this.edtKeyWord.Text.Trim() + "%')";
            }
            return str2;
        }

        private void grdMain_DoubleClick(object sender, EventArgs e)
        {
            DataRow selectedDataRow = this.GetSelectedDataRow(this.grdMain);
            if (selectedDataRow == null)
            {
                this.Close();
            }
            else
            {
                this.port_code = selectedDataRow["PORT_CODE"].ToString();
                this.port_name = selectedDataRow["PORT_NAME"].ToString();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DataRow selectedDataRow = this.GetSelectedDataRow(this.grdMain);
            if (selectedDataRow == null)
            {
                this.Close();
            }
            else
            {
                this.port_code = selectedDataRow["PORT_CODE"].ToString();
                this.port_name = selectedDataRow["PORT_NAME"].ToString();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }

        }

        private void edtKeyWord_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                this.SearchPort();
            }
        }

        private void btnSESearch_Click(object sender, EventArgs e)
        {
            string str = this.getSql();
            DataSet dataSetFunction = this.m_uip.GetDataSetFunction("COM_EXECUTEQUERY", new object[] { str, "PORT_LIST" });
            if (dataSetFunction != null)
            {
                if (dataSetFunction.Tables[0].Rows.Count == 0)
                {
                    this.m_uip.ShowMessage(HintMessageType.MSG_NOTIFY_SURE_FIELD);
                }
                else
                {
                    this.m_uip.ShowNormalMsg("");
                    this.grdMain.DataSource = dataSetFunction;
                    this.grdMain.DataMember = "PORT_LIST";
                }
            }
        }

        private void SelectPortForm_Load(object sender, EventArgs e)
        {
            //this.rgSelect.Properties.Items.Clear();
            if (UIProxy.Language == UIProxy.LanguageType.Chinese)
            {
                //this.rgSelect.Properties.Items.AddRange(new RadioGroupItem[] { new RadioGroupItem("SEA", "海港"), new RadioGroupItem("AIR", "空港") });
            }
            else
            {
                //this.rgSelect.Properties.Items.AddRange(new RadioGroupItem[] { new RadioGroupItem("SEA", "Sea Port"), new RadioGroupItem("AIR", "Air Port") });
            }

        }

    }
}
