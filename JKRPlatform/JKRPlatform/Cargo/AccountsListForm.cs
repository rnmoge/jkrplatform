using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using JKR.GUI.LogixConnector;

namespace JKRPlatform.Cargo
{
    public partial class AccountsListForm : Form
    {
        public string Customer_CName;
        public string Customer_Code;
        public string Customer_EName;
        public string Customer_Name;
        private bool m_IsAllowSelectBlack;
        private UIProxy m_uip;
        private string sJobType;
        private string sLimit;



        public AccountsListForm()
        {
            InitializeComponent();
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
