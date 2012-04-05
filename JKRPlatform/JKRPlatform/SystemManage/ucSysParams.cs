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
    public partial class ucSysParams : UserControl
    {
        public ucSysParams()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 维护数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radButton2_Click(object sender, EventArgs e)
        {
            SysParamForm a071 = new SysParamForm();
            a071.ShowDialog();
        }
    }
}
