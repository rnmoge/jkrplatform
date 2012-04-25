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

namespace PoliceMobile.TaskFrm.HouseCollection
{
    public partial class frmHourseManager : Form
    {
        public frmHourseManager()
        {
            InitializeComponent();
            ucControlManager1.pControl.BackColor = Color.White;
            //init();
        }

        private void init()
        {
             
            DataTable dt = ToolsHelper.GetConfigXmlbyHouse();

            //ControlCollection cc = bgPanel.Controls;

            Control[] sP = new Control[] { pBack1, pBack2, pBack3, pBack4, pBack5, pBack6, pBack7};
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
                        if (cli.Name.IndexOf("lblSteet") > -1)
                        {
                            cli.Text = dt.Rows[i]["steetaddress"].ToString();
                            continue;
                        }

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
                            cli.Tag = dt.Rows[i]["Guid"].ToString();
                            continue;
                        }

                        if (cli.Name.IndexOf("pUpLoad") > -1)
                        {
                            cli.Tag = dt.Rows[i]["Guid"].ToString();
                            continue;
                        }
                        if (cli.Name.IndexOf("pDel") > -1)
                        {
                            cli.Tag = dt.Rows[i]["Guid"].ToString();
                            continue;
                        }
                    }
                }
            }
            catch
            {
            }
        }

        private void p6_GotFocus(object sender, EventArgs e)
        {

        }

        private void p10_GotFocus(object sender, EventArgs e)
        {

        }

        private void frmHouseManager_Activated(object sender, EventArgs e)
        {
            init();
        }

        private void pbIn_Click(object sender, EventArgs e)
        {
            Control c = (Control)sender;
            string sGuid = Convert.ToString(c.Tag);
            ToolsHelper.sHouseGuid = sGuid;
            
            FrmManager.showWindowFor_frmInfoForStreet(this,true);
        }

        private void pbDel_Click(object sender, EventArgs e)
        {
            Control c = (Control)sender;
            string sGuid = Convert.ToString(c.Tag);
            ToolsHelper.sHouseGuid = sGuid;

            ToolsHelper.DelHouseProject(sGuid);
            ToolsHelper.DelDirectory(sGuid);
            init();
           // FrmManager.showWindowFor_frmInfoForStreet(this);
        }

        private void pbUpload_Click(object sender, EventArgs e)
        {
             Control c = (Control)sender;
            string sGuid = Convert.ToString(c.Tag);
            ToolsHelper.sHouseGuid = sGuid;

            string spath = ToolsHelper.sPath + "//Upload//" + sGuid + ".zip";
            string serverPaht= sGuid + ".zip";
            //打包
            string p = ToolsHelper.sPath + "/house/" +sGuid;
            IList<string> list = new List<string>();
            SharpZipHelper.GetFileInfo(p, p, list);
           // SharpZipHelper.ZipFile(p, list.ToArray(), ToolsHelper.sPath + "/Upload/" + sGuid+ ".zip", 8, null, null);
            SharpZipHelper.ZipFile(p, list.ToArray(), ToolsHelper.sPath + "/Upload/" + sGuid + ".zip", 8, null, null);
            //上传
            ToolsHelper.Upload_Request("http://218.28.80.155:8080/FileUpload/UpFiles.jsp", spath, serverPaht, "1");
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ToolsHelper.sHouseGuid = Guid.NewGuid().ToString();
            FrmManager.showWindowFor_frmInfoForStreet(this, false);
        }

        private void pBUploadAll_Click(object sender, EventArgs e)
        {
            string sUrl = "http://218.28.80.155:8080/FileUpload/UpFiles.jsp";
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
                    ToolsHelper.Upload_Request(sUrl, sFile, xnlPic_In[j].InnerText,"1");
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

        private void pictureBox21_Click(object sender, EventArgs e)
        {

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            FrmManager.showWindowFor_FrmDesktop(this);
        }

        private void frmHourseManager_Load(object sender, EventArgs e)
        {

        }
    }
}