﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace JKRPlatform.Cargo
{
    public partial class CostDetailForm : Form
    {
        public CostDetailForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 弹出窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radButton5_Click(object sender, EventArgs e)
        {
            CostAllocationForm fyft = new CostAllocationForm();
            fyft.ShowDialog();
        }

        private void radButton16_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
