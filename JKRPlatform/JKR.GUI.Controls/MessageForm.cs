using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JKR.GUI.Controls
{
    public partial class MessageForm : Form
    {
        public MessageForm()
        {
            InitializeComponent();
        }

        #region Form
        private void MessageForm_Load(object sender, EventArgs e)
        {
            this.Size = new Size(this.Width, this.Size.Height - 80);
            if (!string.IsNullOrEmpty(MessageDemo))
            {
                this.btnExpend.Visible = true;
            }
        }

        private void btnExpend_Click(object sender, EventArgs e)
        {
            if (edtDemo.Visible == false)
            {
                this.btnExpend.Text = "▲";
                this.btnExpend.Visible = true;
                this.edtDemo.Visible = true;
                this.Size = new Size(this.Size.Width, this.Size.Height + 80);
            }
            else
            {
                this.btnExpend.Text = "▼";
                this.btnExpend.Visible = false;
                this.edtDemo.Visible = false;
                this.Size = new Size(this.Size.Width, this.Size.Height - 80);
            }
        }

        #endregion

        #region public

        #region Property

        private static string _MessageDemo;

        public static string MessageDemo
        {
            get
            {
                return _MessageDemo;
            }
            set
            {
                _MessageDemo = Convert.ToString(value);
            }
        }
 

 

        #endregion

        #region ShowMessage text

        /// <summary>
        /// 显示信息
        /// </summary>
        /// <param name="text">信息内容</param>
        /// <returns></returns>
        public static DialogResult ShowMessage(string text)
        {
            return ShowMessage(text, string.Empty);
        }

        public static DialogResult ShowMessage(string text, string caption)
        {
            return ShowMessage(text, caption, MessageBoxButtons.OK);
        }

        public static DialogResult ShowMessage(string text, string caption, MessageBoxButtons buttons)
        {
            return ShowMessage(text, caption, buttons, MessageBoxIcon.None);
        }

        public static DialogResult ShowMessage(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            return ShowMessage(text, caption, buttons, MessageBoxIcon.None, MessageBoxDefaultButton.Button1);
        }

        public static DialogResult ShowMessage(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon, MessageBoxDefaultButton defaultButton)
        {
            return ShowMessage(text, caption, buttons, MessageBoxIcon.None, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
        }

        public static DialogResult ShowMessage(string text,string caption,MessageBoxButtons buttons,MessageBoxIcon icon,MessageBoxDefaultButton defaultButton, MessageBoxOptions option)
        {
            if (string.IsNullOrEmpty(caption))
            {
                caption = "JKR C6";
            }

            MessageForm frm = new MessageForm();
            frm.msgContent.Text = text;
            frm.Text = caption;

            //MessageBoxButtons
            switch (buttons)
            {
                case MessageBoxButtons.AbortRetryIgnore:
                    break;
                case MessageBoxButtons.OK:
                    break;
                case MessageBoxButtons.OKCancel:
                    break;
                case MessageBoxButtons.RetryCancel:
                    break;
                case MessageBoxButtons.YesNo:
                    break;
                case MessageBoxButtons.YesNoCancel:
                    break;
                   
            }

            //MessageBoxIcon
            frm.picIco.Image = frm.imgIcons.Images[5];
            
            //MessageBoxOptions
            switch (option)
            {
                case MessageBoxOptions.DefaultDesktopOnly:
                    break;
                case MessageBoxOptions.RightAlign:
                    break;
                case MessageBoxOptions.RtlReading:
                    break;
                case MessageBoxOptions.ServiceNotification:
                    break;
            }

            return frm.ShowDialog();
        }

        #endregion

        #region Show messageType

        public static DialogResult ShowMessage(MessageType messageType)
        {
            return ShowMessage(messageType, string.Empty);
        }

        public static DialogResult ShowMessage(MessageType messageType, string caption)
        {
            return ShowMessage(messageType, caption, MessageBoxButtons.OK);
        }

        public static DialogResult ShowMessage(MessageType messageType, string caption, MessageBoxButtons buttons)
        {
            return ShowMessage(messageType, caption, buttons, MessageBoxIcon.None);
        }

        public static DialogResult ShowMessage(MessageType messageType, string caption, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
             return ShowMessage(messageType, caption, buttons, MessageBoxIcon.None, MessageBoxDefaultButton.Button1);
        }

        public static DialogResult ShowMessage(MessageType messageType, string caption, MessageBoxButtons buttons, MessageBoxIcon icon, MessageBoxDefaultButton defaultButton)
        {
            return ShowMessage(messageType, caption, buttons, MessageBoxIcon.None, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
        }

        public static DialogResult ShowMessage(MessageType messageType, string caption, MessageBoxButtons buttons, MessageBoxIcon icon, MessageBoxDefaultButton defaultButton, MessageBoxOptions options)
        {
            MessageForm frm = new MessageForm();
            return frm.ShowDialog();
        }

        public enum MessageType
        {
            AEError
        }

        #endregion

        #endregion


    }
}
