using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using JKR.GUI.LogixConnector;

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
            iPortSEA,
            iPortAIR
        }

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
                    //this.edtKeyWord.Text = string.Empty;
                }
                else
                {
                    //this.edtKeyWord.Text = value.ToString();
                    //this.SearchPort();
                }
            }
        }

        public object PortCode
        {
            get
            {
                //DataRow selectedDataRow = this.GetSelectedDataRow(this.grdMain);
                //if (selectedDataRow == null)
                //{
                //    return DBNull.Value;
                //}
                //return selectedDataRow["PORT_CODE"].ToString();
                return null;
            }
        }
 

 

    }
}
