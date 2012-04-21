using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PoliceMobile.TaskFrm.HouseCollection;
using System.Xml;
using PoliceMobile.LIB;
using PoliceMobile.CLS;
using PoliceMobile.CLS.DeviceID;

namespace PoliceMobile
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string sUserName = txtLoginName.Text;
            string sPassWord = txtPassWord.Text;

            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(ToolsHelper.sPath + "/config.xml");

            XmlNode xnLogin = xDoc.SelectSingleNode("Config/Users/User[@name='" + sUserName + "' and @password='" + sPassWord + "']");

            DeviceID di = new DeviceID();
            string sDi = di.ToString();
            xDoc.SelectSingleNode("Config/Dev/device_code").InnerText = sDi;

            xDoc.Save(ToolsHelper.sPath + "/config.xml");

            if (xnLogin == null)
            {
                MessageBox.Show("登陆失败");
                return;
            }

            string sNickName = xnLogin.InnerText;

            ToolsHelper.sLoginNickName = sNickName;

            //MessageBox.Show("登陆成功");

            FrmManager.showWindowFor_FrmDesktop(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sZipFile = "123.zip";
            string[] sFileName = {"1.xml","2.xml","3.xml"};
            ToolsHelper.ZipHelper(sFileName, ToolsHelper.sPath + "/Test/", sZipFile);
        }
    }
}