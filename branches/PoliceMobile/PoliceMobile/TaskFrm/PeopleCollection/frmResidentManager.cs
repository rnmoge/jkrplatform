using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PoliceMobile.LIB;
using PoliceMobile.CLS;
using System.Xml;
using System.IO;

namespace PoliceMobile.TaskFrm.PeopleCollection
{
    public partial class frmResidentManager : Form
    {
        public frmResidentManager()
        {
            InitializeComponent();
        }

        private void init()
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(ToolsHelper.sPath + "/SystemData.xml");

            XmlNodeList xnl = xDoc.SelectNodes("Data/System/HouseDatas/House[@Guid != 'Template']");

            int iMaxCount = 10;

            if (xnl.Count < 10)
            {
                iMaxCount = xnl.Count;
            }

            ControlCollection cc = bgPanel.Controls;

            Control[] sP = new Control[] { pBack1, pBack2, pBack3, pBack4, pBack5, pBack6, pBack7, pBack8, pBack9, pBack10 };

            for (int i = 0; i < iMaxCount; i++)
            {
                Control cl = sP[i];
                cl.Visible = true;

                ControlCollection ccd = cl.Controls;

                for (int j = 0; j < ccd.Count; j++)
                {
                    Control cli = ccd[j];
                    if (cli.Name.IndexOf("lblSteet") > -1)
                    {
                        cli.Text = xnl[i].SelectSingleNode("Info/Street").InnerText;
                        continue;
                    }

                    if (cli.Name.IndexOf("lblCreate") > -1)
                    {
                        cli.Text = xnl[i].Attributes["CreateTime"].Value;
                        continue;
                    }

                    if (cli.Name.IndexOf("pbIn") > -1)
                    {
                        cli.Tag = xnl[i].Attributes["Guid"].Value;
                        continue;
                    }

                    if (cli.Name.IndexOf("pbUpload") > -1)
                    {
                        cli.Tag = xnl[i].Attributes["Guid"].Value;
                        continue;
                    }
                }
            }
        }

        private void p6_GotFocus(object sender, EventArgs e)
        {

        }

        private void p10_GotFocus(object sender, EventArgs e)
        {

        }

        private void frmPeopleManager_Activated(object sender, EventArgs e)
        {
            init();
        }

        private void pbIn_Click(object sender, EventArgs e)
        {
            Control c = (Control)sender;
            string sGuid = Convert.ToString(c.Tag);
            ToolsHelper.sHouseGuid = sGuid;

            FrmManager.showWindowFor_frmInfoForStreet(this);
        }

        private void pbUpload_Click(object sender, EventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ToolsHelper.sHouseGuid = Guid.NewGuid().ToString();
            FrmManager.showWindowFor_frmInfoForStreet(this);
        }

        private void pBUploadAll_Click(object sender, EventArgs e)
        {
            string sUrl = "http://localhost:1924/WebSite1/Default.aspx";
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(ToolsHelper.sPath + "/SystemData.xml");

            XmlNodeList xnl = xDoc.SelectNodes("Data/System/HouseDatas/House[@Guid != 'Template']");
            for (int i = 0; i < xnl.Count; i++)
            {
                string sGuid = xnl[i].Attributes["Guid"].Value;
                string sType = xnl[i].Attributes["Type"].Value;

                XmlNodeList xnlPic_In = xnl[i].SelectNodes("Camera/Camera_In/PicName");
                for (int j = 0; j < xnlPic_In.Count; j++)
                {
                    string sFile = ToolsHelper.sPath + @"/" + sGuid + @"/" +  xnlPic_In[j].InnerText;
                    ToolsHelper.Upload_Request(sUrl, sFile, xnlPic_In[j].InnerText);
                }

                XmlNodeList xnlPic_Out = xnl[i].SelectNodes("Camera/Camera_Out/PicName");
                for (int j = 0; j < xnlPic_Out.Count; j++)
                {
                    string sFile = ToolsHelper.sPath + @"/" + sGuid + @"/" + xnlPic_In[j].InnerText;
                    ToolsHelper.Upload_Request(sUrl, sFile, xnlPic_In[j].InnerText);
                }
                
                XmlNode xnDoc = xDoc.SelectSingleNode("Data/System/HouseDatas/House[@Guid ='" + sGuid + "']").CloneNode(true);

                //string sXmlName = ToolsHelper.sPath + @"/" + sGuid + @"/" + sGuid + ".xml";
                //XmlDocument xNewDoc = new XmlDocument();
                
                //xNewDoc.AppendChild(xnDoc);
                //xNewDoc.Save(ToolsHelper.sPath + @"/" + sGuid + @"/" + sGuid + ".xml");

                //ToolsHelper.Upload_Request(ToolsPath + "/SystemData.xml", sXmlName, "SystemData.xml");
            }

            MessageBox.Show("上传成功");
        }
    }
}