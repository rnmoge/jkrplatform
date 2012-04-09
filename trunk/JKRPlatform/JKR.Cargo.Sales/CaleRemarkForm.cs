using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using JKR.GUI.LogixConnector;
using Microsoft.JScript;

namespace JKR.Cargo.Sales
{
    public partial class CaleRemarkForm : Form
    {
        private string m_CaleRemark = string.Empty;
        private UIProxy m_Uip = UIProxy.GetInstance();

        #region 自定义属性
        public string GetCale_Remark
        {
            get
            {
                return this.m_CaleRemark;
            }
            set
            {
                this.m_CaleRemark = value;
                this.edtCale_Remark.Text = this.m_CaleRemark;
            }
        }

        #endregion

        public CaleRemarkForm()
        {
            InitializeComponent();
        }

        #region 自定义方法

        private bool B_CaleRemark()
        {
            double QC_reult = 0;
            string m_text = this.edtCale_Remark.Text.Trim();

            m_text = m_text.Replace("[DAYS]", "10");
            m_text = m_text.Replace("[CW]","100");
            m_text = m_text.Replace("[CBM]", "100");

            try
            {
                QC_reult = double.Parse(Eval.JScriptEvaluate(m_text, Microsoft.JScript.Vsa.VsaEngine.CreateEngine()).ToString());
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        #endregion

        //点击免费天数按钮事件
        private void btnFreeDays_Click(object sender, EventArgs e)
        {
            if (this.edtCale_Remark.SelectedText.Length > 0)
            {
                this.edtCale_Remark.SelectedText = this.edtDays.Text;
            }
            else
            {
                this.edtCale_Remark.Text = this.edtCale_Remark.Text + this.edtDays.Text;
            }

        }

        //点击天数按钮事件
        private void btnDays_Click(object sender, EventArgs e)
        {
            if (this.edtCale_Remark.SelectedText.Length > 0)
            {
                this.edtCale_Remark.SelectedText = "[DAYS]";
            }
            else
            {
                this.edtCale_Remark.Text = this.edtCale_Remark.Text + "[DAYS]";
            }

        }

        //点击CHARGEABLE_WEIGHT 按钮事件
        private void btnKgs_Click(object sender, EventArgs e)
        {
            if (this.edtCale_Remark.SelectedText.Length > 0)
            {
                this.edtCale_Remark.SelectedText = "[CW]";
            }
            else
            {
                this.edtCale_Remark.Text = this.edtCale_Remark.Text + "[CW]";
            }

        }

        //txl 2009-04-08 add计费重量按钮事件
        private void btnCBM_Click(object sender, EventArgs e)
        {
            if (this.edtCale_Remark.SelectedText.Length > 0)
            {
                this.edtCale_Remark.SelectedText = "[CBM]";
            }
            else
            {
                this.edtCale_Remark.Text = this.edtCale_Remark.Text + "[CBM]";
            }

        }

        //点击加号按钮事件
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (this.edtCale_Remark.SelectedText.Length > 0)
            {
                this.edtCale_Remark.SelectedText = "+";
            }
            else
            {
                this.edtCale_Remark.Text = this.edtCale_Remark.Text + "+";
            }

        }

        //点击减号按钮事件
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (this.edtCale_Remark.SelectedText.Length > 0)
            {
                this.edtCale_Remark.SelectedText = "-";
            }
            else
            {
                this.edtCale_Remark.Text = this.edtCale_Remark.Text + "-";
            }

        }

        //点击乘号按钮事件
        private void btnCheng_Click(object sender, EventArgs e)
        {
            if (this.edtCale_Remark.SelectedText.Length > 0)
            {
                this.edtCale_Remark.SelectedText = "*";
            }
            else
            {
                this.edtCale_Remark.Text = this.edtCale_Remark.Text + "*";
            }

        }

        //点击除号按钮事件
        private void btnChu_Click(object sender, EventArgs e)
        {
            if (this.edtCale_Remark.SelectedText.Length > 0)
            {
                this.edtCale_Remark.SelectedText = "/";
            }
            else
            {
                this.edtCale_Remark.Text = this.edtCale_Remark.Text + "/";
            }

        }

        //点击左括号按钮事件
        private void btnleft_Click(object sender, EventArgs e)
        {
            if (this.edtCale_Remark.SelectedText.Length > 0)
            {
                this.edtCale_Remark.SelectedText = "(";
            }
            else
            {
                this.edtCale_Remark.Text = this.edtCale_Remark.Text + "(";
            }

        }

        //点击右括号按钮事件
        private void btnRight_Click(object sender, EventArgs e)
        {
            if (this.edtCale_Remark.SelectedText.Length > 0)
            {
                this.edtCale_Remark.SelectedText = ")";
            }
            else
            {
                this.edtCale_Remark.Text = this.edtCale_Remark.Text + ")";
            }

        }

        //点击问号按钮事件
        private void btnQustion_Click(object sender, EventArgs e)
        {
            if (this.edtCale_Remark.SelectedText.Length > 0)
            {
                this.edtCale_Remark.SelectedText = "?";
            }
            else
            {
                this.edtCale_Remark.Text = this.edtCale_Remark.Text + "?";
            }

        }

        //点击冒号按钮事件
        private void btnFen_Click(object sender, EventArgs e)
        {
            if (this.edtCale_Remark.SelectedText.Length > 0)
            {
                this.edtCale_Remark.SelectedText = ":";
            }
            else
            {
                this.edtCale_Remark.Text = this.edtCale_Remark.Text + ":";
            }

        }

        //点击&按钮事件
        private void btnAnd_Click(object sender, EventArgs e)
        {
            if (this.edtCale_Remark.SelectedText.Length > 0)
            {
                this.edtCale_Remark.SelectedText = "&";
            }
            else
            {
                this.edtCale_Remark.Text = this.edtCale_Remark.Text + "&";
            }

        }

        //点击提交按钮事件
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (this.B_CaleRemark())
            {
                this.m_CaleRemark = this.edtCale_Remark.Text.Trim();
                this.DialogResult = DialogResult.Yes;
            }
            else
            {
                this.m_Uip.ShowErrorMsg(MessageInfo.CALEREMARKSERROR);
                this.edtCale_Remark.Focus();
                this.edtCale_Remark.SelectAll();
            }

        }

        //点击取消按钮事件
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }



    }
}
