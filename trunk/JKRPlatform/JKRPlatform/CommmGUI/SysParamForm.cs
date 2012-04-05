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
    public partial class SysParamForm : Form
    {
        public SysParamForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 关闭窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            this.radTextBox1.Text = "TRUE";
        }
    }
}
