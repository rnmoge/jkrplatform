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
    public partial class ucAutoCodeRules : UserControl
    {
        public ucAutoCodeRules()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 编辑数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radButton2_Click(object sender, EventArgs e)
        {
            if (this.panel5.Visible == false)
            {
                this.panel5.Visible = true;
            }
            else
            {
                this.panel5.Visible = false;
            }
        }

        /// <summary>
        /// 保存数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radButton3_Click(object sender, EventArgs e)
        {
            if (this.panel5.Visible == true)
            {
                this.panel5.Visible = false;
            }
            else
            {
                this.panel5.Visible = true;
            }
        }
    }
}
