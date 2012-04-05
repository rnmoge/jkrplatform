using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace JKRPlatform.Cargo
{
    public partial class SeparateSheetForm : Form
    {
        public SeparateSheetForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 弹出加入的窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radButton1_Click(object sender, EventArgs e)
        {
            JobNumForm add3041 = new JobNumForm();
            add3041.ShowDialog();
        }

        private void radButton8_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
