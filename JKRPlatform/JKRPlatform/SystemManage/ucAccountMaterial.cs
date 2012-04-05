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
    public partial class ucAccountMaterial : UserControl
    {
        public ucAccountMaterial()
        {
            InitializeComponent();
            this.comboBox2.SelectedIndex = 1;
            this.panel4.Visible = false;
        }

        /// <summary>
        /// 弹出模式窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            AccountInfoForm add021 = new AccountInfoForm();
            add021.ShowDialog();
        }

        /// <summary>
        /// 检索数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)
        {
            this.button2.Enabled = true;
            this.button3.Enabled = true;
            if (this.panel4.Visible == false)
            {
                this.panel4.Visible = true;
            }
            else
            {
                this.panel4.Visible = false;
            }
            //if (this.panel3.Visible == false)
            //{
            //    this.panel3.Visible = true;
            //}
            //else
            //{
            //    this.panel3.Visible = false;
            //}
        }

        /// <summary>
        /// 删除数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("删除数据成功!", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AccountInfoForm add021 = new AccountInfoForm();
            add021.ShowDialog();
        }
    }
}
