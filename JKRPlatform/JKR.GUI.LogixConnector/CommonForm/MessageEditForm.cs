using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JKR.GUI.LogixConnector.CommonForm
{
    public partial class MessageEditForm : Form
    {
        public string m_CurrentID;
        private DataSet m_DataMain;
        private UIProxy m_uip;
        private string sMessageContent;
        private string sMessageReceiver;
        private string sMessageTitle;
        private string sMessageType;
        private string sRefNo;
        private string sRefType;

        #region property

        public string RefNo
        {
            set
            {
                this.sRefNo = value;
            }
        }

        public string RefType
        {
            set
            {
                this.sRefType = value;
            }
        }

        public string MessageType
        {
            set
            {
                this.sMessageType = value;
            }
        }
 
        public string MessageTitle
        {
            set
            {
                this.sMessageTitle = value;
            }
        }

        public string MessageText
        {
            set
            {
                this.sMessageContent = value;
            }
        }

        public string MessageReceiver
        {
            set
            {
                this.sMessageReceiver = value;
            }
        }

        #endregion

        public MessageEditForm()
        {
            InitializeComponent();
        }
    }
}
