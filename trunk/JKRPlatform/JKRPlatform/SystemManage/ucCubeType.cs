using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace JKRPlatform.SystemManage
{
    public partial class ucCubeType : UserControl
    {
        public ucCubeType()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 新建数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radButton2_Click(object sender, EventArgs e)
        {
            this.radButton1.Enabled = true;
        }

        /// <summary>
        /// 编辑数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radButton4_Click(object sender, EventArgs e)
        {
            this.radButton1.Enabled = true;
        }

        /// <summary>
        /// 保存数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radButton1_Click(object sender, EventArgs e)
        {
            this.radButton1.Enabled = false;
        }

        /// <summary>
        /// 删除数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radButton3_Click(object sender, EventArgs e)
        {
            this.radButton1.Enabled = false;
        }
    }
}
