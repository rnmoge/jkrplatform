using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JKR.Cargo.Sales
{
    public partial class CaleRemarkForm : Form
    {
        public CaleRemarkForm()
        {
            InitializeComponent();
        }


        public string GetCale_Remark
        {
            get
            {
                return this.m_CaleRemark;
            }
            set
            {
                this.m_CaleRemark = value;
                this.edtCale_Remark.Text = this.m_CaleRemark;
            }
        }
 

 

    }
}
