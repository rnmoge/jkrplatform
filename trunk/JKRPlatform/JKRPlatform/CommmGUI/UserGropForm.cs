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
    public partial class UserGropForm : Form
    {
        public UserGropForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 关闭窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radButton4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("数据没有保存，是否确定关闭？", "用户组定义", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.Close();
            }
        }

        /// <summary>
        /// 弹出窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radButton1_Click(object sender, EventArgs e)
        {
            UserListForm a0510101 = new UserListForm();
            a0510101.ShowDialog();
        }
    }
}
