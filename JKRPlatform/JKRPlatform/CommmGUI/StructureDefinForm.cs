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
    public partial class StructureDefinForm : Form
    {
        public StructureDefinForm()
        {
            InitializeComponent();
        }

        private void radButton13_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("数据没有保存，是否确定关闭？", "组织架构定义", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.Close();
            }
        }

        //private void A031_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    if (MessageBox.Show("数据没有保存，是否确定关闭？", "组织架构定义", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
        //    {
        //        this.Close();
        //    }
        //    else
        //    {
        //        e.Cancel = true;
        //    }
        //}
    }
}
