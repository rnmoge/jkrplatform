using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JKR.GUI.LogixConnector.CommonForm
{
    public partial class GoToForm : Form
    {
        private string sShipmentNo;

        public GoToForm()
        {
            InitializeComponent();
        }

        public string ShipmentNo
        {
            get
            {
                return this.edtNo.Text.Trim();
            }
            set
            {
                this.edtNo.Text = value;
            }
        }

        public string ShipmentType
        {
            set
            {
                this.lbNo.Text = value;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (this.edtNo.Text.Trim() != "")
            {
                this.DialogResult = DialogResult.OK;
            }

        }

        private void GoToForm_Load(object sender, EventArgs e)
        {
            edtNo.Select();
        }

        private void edtNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                this.btnOK.Select();
            }

        }

    }
}
