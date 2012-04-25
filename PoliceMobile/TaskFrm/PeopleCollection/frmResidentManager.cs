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
            DataTable dt = ToolsHelper.GetConfigXmlbyPeople();

            //ControlCollection cc = bgPanel.Controls;

            Control[] sP = new Control[] { pBack1, pBack2, pBack3, pBack4, pBack5, pBack6, pBack7,pBack8,pBack9,pBack10 };
            try
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Control cl = sP[i];
                    cl.Visible = true;

                    ControlCollection ccd = cl.Controls;

                    for (int j = 0; j < ccd.Count; j++)
                    {
                        Control cli = ccd[j];

                        if (cli.Name.IndexOf("lblCreate") > -1)
                        {
                            cli.Text = dt.Rows[i]["time"].ToString();
                            continue;
                        }

                        if (cli.Name.IndexOf("lblName") > -1)
                        {
                            cli.Text = dt.Rows[i]["name"].ToString();
                            continue;
                        }

                        if (cli.Name.IndexOf("pIn") > -1)
                        {
                            cli.Tag = dt.Rows[i]["CardId"].ToString();
                            continue;
                        }

                        if (cli.Name.IndexOf("pUpLoad") > -1)
                        {
                            cli.Tag = dt.Rows[i]["CardId"].ToString();
                            continue;
                        }
                        if (cli.Name.IndexOf("pDel") > -1)
                        {
                            cli.Tag = dt.Rows[i]["CardId"].ToString();
                            continue;
                        }
                    }
                }
            }
            catch
            {
            }
        }

        private void frmPeopleManager_Activated(object sender, EventArgs e)
        {
            init();
        }

        private void pbIn_Click(object sender, EventArgs e)
        {
            Control c = (Control)sender;
            string sCardId = Convert.ToString(c.Tag);
            ToolsHelper.sCardId = sCardId;

            FrmManager.showWindowFor_frmInfoForPeople(this);
        }

                private void pbDel_Click(object sender, EventArgs e)
        {
            Control c = (Control)sender;
            string sCardID = Convert.ToString(c.Tag);

            ToolsHelper.DelPeopleProject(sCardID);
            ToolsHelper.DelDirectoryForPeople(sCardID);
            c.Parent.Visible = false;
           // FrmManager.showWindowFor_frmInfoForStreet(this);
        }

        private void pbUpload_Click(object sender, EventArgs e)
        {
             Control c = (Control)sender;
            string sCardId = Convert.ToString(c.Tag);
            ToolsHelper.sHouseGuid = sCardId;

            string spath = ToolsHelper.sPath + "//Upload//" + sCardId + ".zip";
            string serverPaht = sCardId + ".zip";
            //打包
            string p = ToolsHelper.sPath + "/Peoples/" + sCardId;
            IList<string> list = new List<string>();
            SharpZipHelper.GetFileInfo(p, p, list);
            SharpZipHelper.ZipFile(p, list.ToArray(), ToolsHelper.sPath + "/Upload/" + sCardId + ".zip", 8, null, null);
            //上传
            ToolsHelper.Upload_Request("http://60.28.24.210:8081/FileUpload/UpFiles.jsp", spath, serverPaht, "2");
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            FrmManager.showWindowFor_frmInfoForPeople(this);
        }

        private void pBUploadAll_Click(object sender, EventArgs e)
        {
            string sUrl = "http://60.28.24.210:8081/FileUpload/UpFiles.jsp";
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(ToolsHelper.sPath + "/SystemData.xml");

            XmlNodeList xnl = xDoc.SelectNodes("Data/System/Peoples/People[@CardId != 'Template']");
            for (int i = 0; i < xnl.Count; i++)
            {
                string sGuid = xnl[i].Attributes["Guid"].Value;
                string sType = xnl[i].Attributes["Type"].Value;

                XmlNodeList xnlPic_In = xnl[i].SelectNodes("Camera/Camera_In/PicName");
                for (int j = 0; j < xnlPic_In.Count; j++)
                {
                    string sFile = ToolsHelper.sPath + @"/" + sGuid + @"/" + xnlPic_In[j].InnerText;
                    ToolsHelper.Upload_Request(sUrl, sFile, xnlPic_In[j].InnerText, "1");
                }

                XmlNodeList xnlPic_Out = xnl[i].SelectNodes("Camera/Camera_Out/PicName");
                for (int j = 0; j < xnlPic_Out.Count; j++)
                {
                    string sFile = ToolsHelper.sPath + @"/" + sGuid + @"/" + xnlPic_In[j].InnerText;
                    ToolsHelper.Upload_Request(sUrl, sFile, xnlPic_In[j].InnerText, "1");
                }

                XmlNode xnDoc = xDoc.SelectSingleNode("Data/System/HouseDatas/House[@Guid ='" + sGuid + "']").CloneNode(true);

                //string sXmlName = ToolsHelper.sPath + @"/" + sGuid + @"/" + sGuid + ".xml";
                //XmlDocument xNewDoc = new XmlDocument();

                //xNewDoc.AppendChild(xnDoc);
                //xNewDoc.Save(ToolsHelper.sPath + @"/" + sGuid + @"/" + sGuid + ".xml");


                //ToolsHelper.Upload_Request(ToolsHelper.sPath.sPath + "/SystemData.xml", sXmlName, "SystemData.xml");
            }

            MessageBox.Show("上传成功");
        }


    }
}