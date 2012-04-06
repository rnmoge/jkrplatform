using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using JKR.GUI.LogixConnector;

namespace JKR.Cargo.Common.SelectForm
{
    public partial class SelectCustomerForm : Form
    {
        private UIProxy m_uip;

        public string Customer_CName;
        public string Customer_Code;
        public string Customer_EName;
        public string Customer_Name;

        private bool m_IsAllowSelectBlack;
        public bool IsAllowSelectBlack
        {
            get
            {
                return this.m_IsAllowSelectBlack;
            }
            set
            {
                if (this.m_IsAllowSelectBlack != value)
                {
                    this.m_IsAllowSelectBlack = value;
                }
            }
        }

        public bool ActiveAccounts
        {
            set
            {
                //this.chkActive.Checked = value;
                //this.chkActive.Visible = !value;
            }
        }
 
        private string sJobType;
        public string JobType
        {
            set
            {
                this.sJobType = value;
            }
        }
        private string sLimit;


        public SelectCustomerForm()
        {
            InitializeComponent();
        }

        public SelectCustomerForm(string sTypeLimit, string jobType)
        {
            InitializeComponent();
            sLimit = sTypeLimit;
            sJobType = jobType;
        }
    }
}
