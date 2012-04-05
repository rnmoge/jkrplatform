using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using JKRPlatform.CommmGUI;

namespace JKRPlatform.SystemManage
{
    public partial class ucUserManage : UserControl
    {
        public ucUserManage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 新建数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radButton1_Click(object sender, EventArgs e)
        {
            UserDefinedForm a041 = new UserDefinedForm();
            a041.ShowDialog();
        }

        /// <summary>
        /// 编辑数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radButton2_Click(object sender, EventArgs e)
        {
            UserDefinedForm a04101 = new UserDefinedForm();
            a04101.ShowDialog();
        }

        /// <summary>
        /// 查看权限
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radButton3_Click(object sender, EventArgs e)
        {
            UserQxForm a04102 = new UserQxForm();
            a04102.ShowDialog();
        }

        /// <summary>
        /// 工号设置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radButton4_Click(object sender, EventArgs e)
        {
            WorkNumSetForm a04103 = new WorkNumSetForm();
            a04103.ShowDialog();
        }
    }
}
