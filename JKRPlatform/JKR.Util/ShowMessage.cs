using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace JKR.Util
{
    public class ShowMessage
    {
        public ShowMessage()
        {
        }

        public static bool IsSureClose(Form frm)
        {
            string caption = string.Empty;
            if (m_language == Language.Chinese)
            {
                caption = "数据没有保存，是否确定关闭？";
            }
            else
            {
                caption = "The Data havn't save, Are you sure to Close?";
            }
            return (MessageBox.Show(caption, frm.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK);
        }

        public static bool IsSureDelete(Form frm)
        {
            string caption = string.Empty;
            if (m_language == Language.Chinese)
            {
                caption = "确定要删除该条记录？";
            }
            else
            {
                caption = "The Record will be Delete, Are you sure?";
            }
            return (MessageBox.Show(caption, frm.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK);
        }


        public static bool IsSureDelete(UserControl uc)
        {
            string caption = string.Empty;
            if (m_language == Language.Chinese)
            {
                caption = "确定要删除该条记录？";
            }
            else
            {
                caption = "The Record will be Delete, Are you sure?";
            }
            return (MessageBox.Show(caption, uc.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK);
        }

        public static DialogResult QueryMsg(string msg, string caption)
        {
            return MessageBox.Show(msg, caption, MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
        }

        public static void ShowMsg(string msg, string Caption)
        {
            MessageBox.Show(msg, Caption, MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
        }


        public static void ShowNoDataFoundMsg(string Caption)
        {
            string language1 = string.Empty;
            if (m_language == Language.Chinese)
            {
                language1 = "没有任何数据！";
            }
            else
            {
                language1 = "No Data found!";
            }
            ShowMsg(language1, Caption);
        }

        public enum Language
        {
            English,
            Chinese
        }

        private static Language m_language;

        public static Language SetLanguage
        {
            get
            {
                return m_language;
            }
            set
            {
                m_language = value;
            }
        }
    }
}
