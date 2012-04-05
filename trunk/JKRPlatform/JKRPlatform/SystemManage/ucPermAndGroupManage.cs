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
    public partial class ucPermAndGroupManage : UserControl
    {
        public ucPermAndGroupManage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 新增角色
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radButton1_Click(object sender, EventArgs e)
        {
            RoleDefinForm a05101 = new RoleDefinForm();
            a05101.ShowDialog();
        }

        /// <summary>
        /// 编辑角色
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radButton2_Click(object sender, EventArgs e)
        {
            RoleDefinForm a05101 = new RoleDefinForm();
            a05101.ShowDialog();
        }

        /// <summary>
        /// 新增组
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radButton4_Click(object sender, EventArgs e)
        {
            UserGropForm a05102 = new UserGropForm();
            a05102.ShowDialog();
        }

        /// <summary>
        /// 编辑组
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radButton5_Click(object sender, EventArgs e)
        {
            UserGropForm a05102 = new UserGropForm();
            a05102.ShowDialog();
        }
    }
}
