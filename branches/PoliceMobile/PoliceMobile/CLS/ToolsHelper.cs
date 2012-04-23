using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Microsoft.WindowsMobile.Forms;
using System.Threading;
using System.Windows.Forms;
using Bouwa.ClassLib;
using System.Xml;
using System.Data;
using System.Drawing;
using System.Net;


namespace PoliceMobile.CLS
{
    public class ToolsHelper
    {
        public static int iHouseType = 1;
        public static int iPeopleType = 1;
        public static int iFlag = 0;
        public static string sHouseGuid = "";
        public static string sPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
        public static string sLoginNickName = "";

        public static string sCardId = "";

        string sdevice_code = "";
        string sdevice_type = "";
        string sregion_code = "";
        string ssubstation_code = "";
        string ssubstation_name = "";
        string susername = "";
        string srealname = "";

        /// <summary>
        /// 抓拍
        /// </summary>
        /// <param name="savePath">保存路径</param>
        public static Boolean sCapture(string savePath)
        {
            string path = savePath.Substring(0, savePath.LastIndexOf("\\"));
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            string fileCameraName = savePath.Substring(savePath.LastIndexOf("\\"));
            object sateObject = new object();
            System.Threading.Timer timer = new System.Threading.Timer(new TimerCallback(ToolLib.FullScreen), sateObject, 0, 500);//定义一个Timer
            CameraCaptureDialog cameraCapture = new CameraCaptureDialog();
            cameraCapture.Mode = CameraCaptureMode.Still;
            cameraCapture.StillQuality = CameraCaptureStillQuality.High;
            cameraCapture.VideoTypes = CameraCaptureVideoTypes.Standard;

            Size szResolution = new Size(640, 480);

            cameraCapture.Resolution = szResolution;
            cameraCapture.InitialDirectory = path;
            cameraCapture.DefaultFileName = fileCameraName;
            if (DialogResult.OK == cameraCapture.ShowDialog())
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Combox绑定数据
        /// </summary>
        public static void BindDataForComboBox(string sTag, ComboBox cb, string sSelectValue)
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(sPath + "/config.xml");

            XmlNode xn = xDoc.SelectSingleNode("Config/System/TypeData/" + sTag);

            XmlNodeList xnlTypes = xn.ChildNodes;

            DataTable dt = new DataTable();
            dt.Columns.Add("id");
            dt.Columns.Add("value");

            for (int i = 0; i < xnlTypes.Count; i++)
            {
                string sId = Convert.ToString(xnlTypes[i].Attributes["id"].Value);
                string sValue = Convert.ToString(xnlTypes[i].InnerText);
                dt.Rows.Add(new string[] { sId, sValue });
            }

            XmlNodeList xnl = xDoc.SelectNodes("Config/System/TypeData/" + sTag + "/Type[@ti='1']");



            cb.DataSource = dt;
            cb.DisplayMember = "value";
            cb.ValueMember = "id";

            if (xnl.Count == 0)
            {
                DataRow dr = dt.NewRow();
                dr["id"] = "-1";
                dr["value"] = "请选择";
                dt.Rows.InsertAt(dr, 0);
            }

            if (sSelectValue == "0")
            {
                string sSelectId = "";
                if (xnl.Count > 0)
                {
                    XmlNode xnDefault = xnl[0];
                    sSelectId = xnDefault.Attributes["id"].InnerText;
                }

                if (sSelectId != "")
                {
                    cb.SelectedValue = sSelectId;
                }
                return;
            }
            else
            {
                cb.SelectedValue = sSelectValue;
            }


        }

        #region  //*** 私产House读写 ***//
        /// <summary>
        /// 自动存档模式
        /// </summary>
        public static void AutoSaveConfigForHouse(Form frm, string sGuid, bool edit)
        {
            System.Windows.Forms.Control.ControlCollection cc = frm.Controls;

            XmlDocument xDoc = new XmlDocument();
            if (edit)
            {
                xDoc.Load(sPath + "/house/" + sGuid + "/" + "House.xml");
            }
            else
            {
                xDoc.Load(sPath + "/Template/House.xml");
            }


            XmlNode xnNode = xDoc.SelectSingleNode("Data");

            for (int i = 0; i < cc.Count; i++)
            {
                Control theControl = cc[i];

                string thePath = Convert.ToString(theControl.Tag);
                if (thePath == "")
                {
                    continue;
                }

                string sValue = "";

                if (theControl.GetType().Name == "ComboBox")
                {
                    if (theControl.Enabled == true)
                    {
                        sValue = Convert.ToString(((ComboBox)theControl).SelectedValue);

                        string sValue1 = Convert.ToString(((ComboBox)theControl).SelectedText);
                        string sValue2 = Convert.ToString(((ComboBox)theControl).SelectedValue);

                        XmlNode xnData_Name = xnNode.SelectSingleNode(thePath + "_name");
                        xnData_Name.InnerText = sValue1;

                        XmlNode xnData_Code = xnNode.SelectSingleNode(thePath + "_code");
                        xnData_Code.InnerText = sValue2;
                    }
                    continue;
                }

                if (theControl.GetType().Name.ToString() == "TextBox")
                {
                    if (theControl.Enabled == true)
                    {
                        sValue = ((TextBox)theControl).Text;
                    }
                }

                if (theControl.GetType().Name.ToString() == "Label")
                {
                    if (theControl.Enabled == true)
                    {
                        sValue = ((Label)theControl).Text;
                    }
                }

                if (theControl.GetType().Name == "RadioButton")
                {
                    if (theControl.Enabled == true)
                    {
                        sValue = ((RadioButton)theControl).Text;
                    }
                }

                XmlNode xnData = xnNode.SelectSingleNode(thePath);
                xnData.InnerText = sValue;
            }
            //建议个GUID的文件夹
            System.IO.Directory.CreateDirectory(sPath + "//house//" + sGuid);
            System.IO.Directory.CreateDirectory(sPath + "//house//" + sGuid + "//pic");
            xDoc.Save(sPath + "//house//" + sGuid + "//House.xml");
        }

        /// <summary>
        /// 自动读取模式
        /// </summary>
        public static bool AutoLoadConfigForHouse(Control frm, string sCardId)
        {
            System.Windows.Forms.Control.ControlCollection cc = frm.Controls;

            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(sPath + "/house/" + sCardId + "/" + "House.xml");

            XmlNode xnNode = xDoc.SelectSingleNode("Data");

            for (int i = 0; i < cc.Count; i++)
            {
                Control theControl = cc[i];

                string thePath = Convert.ToString(theControl.Tag);
                if (thePath == "")
                {
                    continue;
                }

                // string sValue = xnNode.SelectSingleNode(thePath).InnerText;

                if (theControl.GetType().Name == "ComboBox")
                {
                    if (theControl.Enabled == true)
                    {
                        //((ComboBox)theControl).SelectedText = xnNode.SelectSingleNode(thePath + "_name").InnerText;
                        if (xnNode.SelectSingleNode(thePath + "_code").InnerText != "")
                        {
                            ((ComboBox)theControl).SelectedValue = xnNode.SelectSingleNode(thePath + "_code").InnerText;
                        }
                    }
                    continue;
                }

                if (theControl.GetType().Name.ToString() == "TextBox")
                {
                    if (theControl.Enabled == true)
                    {
                        ((TextBox)theControl).Text = xnNode.SelectSingleNode(thePath).InnerText; ;
                    }
                }

                if (theControl.GetType().Name.ToString() == "Label")
                {
                    if (theControl.Enabled == true)
                    {
                        ((Label)theControl).Text = xnNode.SelectSingleNode(thePath).InnerText; ;
                    }
                }
            }
            return true;
        }

        #endregion

        #region  //*** 公产House读写 ***//
        /// <summary>
        /// 自动存档模式
        /// </summary>
        public static void AutoSaveConfigForPublicHouse(Form frm, string sGuid, bool edit)
        {
            System.Windows.Forms.Control.ControlCollection cc = frm.Controls;

            XmlDocument xDoc = new XmlDocument();
            if (edit)
            {
                xDoc.Load(sPath + "/house/" + sGuid + "/" + "House.xml");
            }
            else
            {
                xDoc.Load(sPath + "/Template/PublicHouse.xml");
            }

            XmlNode xnNode = xDoc.SelectSingleNode("Data");

            for (int i = 0; i < cc.Count; i++)
            {
                Control theControl = cc[i];

                string thePath = Convert.ToString(theControl.Tag);
                if (thePath == "")
                {
                    continue;
                }

                string sValue = "";

                if (theControl.GetType().Name == "ComboBox")
                {
                    if (theControl.Enabled == true)
                    {
                        sValue = Convert.ToString(((ComboBox)theControl).SelectedValue);

                        string sValue1 = Convert.ToString(((ComboBox)theControl).SelectedText);
                        string sValue2 = Convert.ToString(((ComboBox)theControl).SelectedValue);

                        XmlNode xnData_Name = xnNode.SelectSingleNode(thePath + "_name");
                        xnData_Name.InnerText = sValue1;

                        XmlNode xnData_Code = xnNode.SelectSingleNode(thePath + "_code");
                        xnData_Code.InnerText = sValue2;
                    }
                    continue;
                }

                if (theControl.GetType().Name.ToString() == "TextBox")
                {
                    if (theControl.Enabled == true)
                    {
                        sValue = ((TextBox)theControl).Text;
                    }
                }

                if (theControl.GetType().Name.ToString() == "Label")
                {
                    if (theControl.Enabled == true)
                    {
                        sValue = ((Label)theControl).Text;
                    }
                }

                if (theControl.GetType().Name == "RadioButton")
                {
                    if (theControl.Enabled == true)
                    {
                        sValue = ((RadioButton)theControl).Text;
                    }
                }

                XmlNode xnData = xnNode.SelectSingleNode(thePath);
                xnData.InnerText = sValue;
            }
            //建议个GUID的文件夹
            System.IO.Directory.CreateDirectory(sPath + "//house//" + sGuid);
            System.IO.Directory.CreateDirectory(sPath + "//house//" + sGuid + "//pic");
            xDoc.Save(sPath + "//house//" + sGuid + "//House.xml");
        }

        /// <summary>
        /// 自动读取模式
        /// </summary>
        public static bool AutoLoadConfigForPublicHouse(Control frm, string sHouseId)
        {
            System.Windows.Forms.Control.ControlCollection cc = frm.Controls;

            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(sPath + "/house/" + sHouseId + "/" + "House.xml");

            XmlNode xnNode = xDoc.SelectSingleNode("Data");

            for (int i = 0; i < cc.Count; i++)
            {
                Control theControl = cc[i];

                string thePath = Convert.ToString(theControl.Tag);
                if (thePath == "")
                {
                    continue;
                }

                // string sValue = xnNode.SelectSingleNode(thePath).InnerText;

                if (theControl.GetType().Name == "ComboBox")
                {
                    if (theControl.Enabled == true)
                    {
                        ((ComboBox)theControl).SelectedText = xnNode.SelectSingleNode(thePath + "_name").InnerText;
                        ((ComboBox)theControl).SelectedValue = xnNode.SelectSingleNode(thePath + "_code").InnerText;
                    }
                    continue;
                }

                if (theControl.GetType().Name.ToString() == "TextBox")
                {
                    if (theControl.Enabled == true)
                    {
                        ((TextBox)theControl).Text = xnNode.SelectSingleNode(thePath).InnerText; ;
                    }
                }

                if (theControl.GetType().Name.ToString() == "Label")
                {
                    if (theControl.Enabled == true)
                    {
                        ((Label)theControl).Text = xnNode.SelectSingleNode(thePath).InnerText; ;
                    }
                }
            }
            return true;
        }

        #endregion

        #region //*** 读、写配置文件 ***//

        /// <summary>
        /// 插入管理文件
        /// </summary>
        /// <param name="type"></param>
        /// <param name="sGuid"></param>
        /// <param name="steetaddress"></param>
        /// <param name="name"></param>
        public static void SetConfigXmlbyHouse(string type, string sGuid)
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(sPath + "/SystemData.xml");

            // XmlNode xnlHouseDatas = xDoc.SelectSingleNode(".//System/HouseDatas");
            XmlNode root = xDoc.SelectSingleNode(".//System/HouseDatas");


            //<House Type="0" Guid="Template" IsUpdate="" CreateTime="" ="未采集" name ="未采集" datetime="" ></House>
            XmlNode xnlHouse = xDoc.SelectSingleNode(".//System/HouseDatas/House[@Guid='Template']");
            XmlNode xnlNew = xnlHouse.CloneNode(true);
            xnlNew.Attributes["Type"].Value = type;
            xnlNew.Attributes["Guid"].Value = sGuid;
            xnlNew.Attributes["IsUpdate"].Value = "0";
            xnlNew.Attributes["CreateTime"].Value = System.DateTime.Now.ToString();
            //xnlNew.Attributes["streetAddress"].Value = steetaddress;
            //xnlNew.Attributes["name"].Value = name;
            xnlNew.Attributes["datetime"].Value = System.DateTime.Now.ToString("MM-dd hh:ss:mm");

            root.AppendChild(xnlNew);
            xDoc.Save(sPath + "/SystemData.xml");
        }

        /// <summary>
        /// 更新配置文件
        /// </summary>
        /// <param name="sGuid"></param>
        /// <param name="steetaddress"></param>
        /// <param name="name"></param>
        public static void SetConfigXmlbyHouseInfor(string sGuid, string steetaddress, string name)
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(sPath + "/SystemData.xml");

            // XmlNode xnlHouseDatas = xDoc.SelectSingleNode(".//System/HouseDatas");
            XmlNode xnlHouse = xDoc.SelectSingleNode("/Data/System/HouseDatas/House[@Guid='" + sGuid + "']");

            xnlHouse.Attributes["streetAddress"].Value = steetaddress;
            xnlHouse.Attributes["name"].Value = name;
            xDoc.Save(sPath + "/SystemData.xml");

        }
        /// <summary>
        /// 更新上传标志
        /// </summary>
        /// <param name="sGuid"></param>
        /// <param name="steetaddress"></param>
        /// <param name="name"></param>
        public static void SetConfigXmlbyHouseUpload(string sGuid)
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(sPath + "/SystemData.xml");

            // XmlNode xnlHouseDatas = xDoc.SelectSingleNode(".//System/HouseDatas");
            XmlNode xnlHouse = xDoc.SelectSingleNode("/Data/System/HouseDatas/House[@Guid='" + sGuid + "']");


            xnlHouse.Attributes["IsUpdate"].Value = "1";
            xDoc.Save(sPath + "/SystemData.xml");

        }



        /// <summary>
        /// 读取管理文件
        /// </summary>
        /// <param name="type"></param>
        /// <param name="sGuid"></param>
        /// <param name="steetaddress"></param>
        /// <param name="name"></param>
        public static DataTable GetConfigXmlbyHouse()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Guid");
            dt.Columns.Add("steetaddress");
            dt.Columns.Add("name");
            dt.Columns.Add("time");

            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(sPath + "/SystemData.xml");

            // XmlNode xnlHouseDatas = xDoc.SelectSingleNode(".//System/HouseDatas");

            //<House Type="0" Guid="Template" IsUpdate="" CreateTime="" ="未采集" name ="未采集" datetime="" ></House>
            XmlNodeList xnlHouse = xDoc.SelectNodes(@".//System/HouseDatas/House[@Guid !='Template']");
            foreach (XmlNode xnlNew in xnlHouse)
            {
                DataRow dr = dt.NewRow();

                dr["Guid"] = xnlNew.Attributes["Guid"].Value;
                dr["steetaddress"] = xnlNew.Attributes["streetAddress"].Value;
                dr["name"] = xnlNew.Attributes["name"].Value;
                dr["time"] = xnlNew.Attributes["datetime"].Value;
                dt.Rows.Add(dr);
            }

            return dt;
        }

        #endregion

        #region //*** 项目节点操作 ***//

        /// <summary>
        /// 删除配置文件中的节点。
        /// </summary>
        /// <param name="sGuid"></param>
        public static void DelHouseProject(string sGuid)
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(sPath + "/SystemData.xml");
            XmlNode xnPicBox = xDoc.SelectSingleNode(@".//System/HouseDatas/House[@Guid ='" + sGuid + "']");
            xnPicBox.RemoveAll();
            xDoc.Save(sPath + "/SystemData.xml");

        }

        #endregion

        #region  //*** 图片节点操作 ***//
        /// <summary>
        /// 删除单个图片
        /// </summary>
        /// <param name="sGuid"></param>
        /// <param name="sTag"></param>
        public static void DelHouseImage(string sGuid, PictureBox pb)
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(sPath + "/house/" + sGuid + "/House.xml");

            string sPicName = Convert.ToString(pb.Tag);

            //XmlNode xnPicBox = xDoc.SelectSingleNode("Data/System/HouseDatas/House[@Guid='" + sGuid + "']/Camera/" + sTag);
            //XmlNode xnPicBox = xDoc.SelectSingleNode(".//residential_housing/images/image[@GUID='"+sTag+"']");

            XmlNode xnPicBox = xDoc.SelectSingleNode(".//residential_housing/images/image[photo[text()=" + sPicName + "]]");
            if (xnPicBox == null)
            {
                MessageBox.Show("删除失败");
                return;
            }
            File.Delete(ToolsHelper.sPath + @"\house\" + ToolsHelper.sHouseGuid + @"\pic\" + sPicName);
            xDoc.RemoveChild(xnPicBox);
            pb.Image = null;
            xDoc.Save(sPath + "/house/" + sGuid + "/House.xml");

            XmlNode xnPicNext = xnPicBox.NextSibling;
            if (xnPicNext != null)
            {
                string sTempPicName = xnPicNext.InnerText;
                string sPicFullName = ToolsHelper.sPath + @"\house\" + ToolsHelper.sHouseGuid + @"\pic\" + sTempPicName;
                BindPic(pb, sPicFullName);
                return;
            }

            XmlNode xnPicPre = xnPicBox.PreviousSibling;
            if (xnPicPre != null)
            {
                string sTempPicName = xnPicPre.InnerText;
                string sPicFullName = ToolsHelper.sPath + @"\house\" + ToolsHelper.sHouseGuid + @"\pic\" + sTempPicName;
                BindPic(pb, sPicFullName);
                return;
            }
        }
        #endregion

        #region //*** I/O操作类 ***//
        /// <summary> 
        /// 删除文件夹（及文件夹下所有子文件夹和文件） 
        /// </summary> 
        /// <param name="directoryPath"></param> 
        public static void DelDirectory(string sGuid)
        {
            string directoryPath = ToolsHelper.sPath + "/house/" + sGuid;

            foreach (string d in Directory.GetFileSystemEntries(directoryPath))
            {
                if (File.Exists(d))
                {
                    FileInfo fi = new FileInfo(d);
                    if (fi.Attributes.ToString().IndexOf("ReadOnly") != -1)
                        fi.Attributes = FileAttributes.Normal;
                    File.Delete(d);     //删除文件    
                }
                else
                    DelDirectory(d);    //删除文件夹 
            }
            Directory.Delete(directoryPath);    //删除空文件夹 
        }


        #endregion


        /// <summary>
        /// 创建一个用户
        /// </summary>
        /// <param name="sIdCode"></param>
        public static void CreatePeople(string sIdCode, string sType)
        {
            Directory.CreateDirectory(sPath + "/Peoples/" + sIdCode + "/");

            string sResident = "ResidentPermanentData.xml";
            if (sType == "0")
            {
                sResident = "ResidentPermanentData.xml";
            }

            if (sType == "1")
            {
                sResident = "ResidentTempData.xml";
            }

            if (sType == "2")
            {
                sResident = "ResidentSpecialData.xml";
            }

            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(sPath + "/Template/" + sResident);

            xDoc.Save(sPath + "/Peoples/" + sIdCode + "/" + "People.xml");
        }

        /// <summary>
        /// 自动存档模式
        /// </summary>
        public static void AutoSaveConfigForPeople(Control frm, string sCardId)
        {
            System.Windows.Forms.Control.ControlCollection cc = frm.Controls;

            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(sPath + "/Peoples/" + sCardId + "/" + "People.xml");

            XmlNode xnNode = xDoc.SelectSingleNode("Data");

            for (int i = 0; i < cc.Count; i++)
            {
                Control theControl = cc[i];

                string thePath = Convert.ToString(theControl.Tag);
                if (thePath == "")
                {
                    continue;
                }

                string sValue = "";

                if (theControl.GetType().Name == "ComboBox")
                {
                    if (theControl.Enabled == true)
                    {
                        sValue = Convert.ToString(((ComboBox)theControl).SelectedValue);

                        string sValue1 = Convert.ToString(((ComboBox)theControl).SelectedText);
                        string sValue2 = Convert.ToString(((ComboBox)theControl).SelectedValue);

                        XmlNode xnData_Name = xnNode.SelectSingleNode(thePath + "_name");
                        xnData_Name.InnerText = sValue1;

                        XmlNode xnData_Code = xnNode.SelectSingleNode(thePath + "_code");
                        xnData_Code.InnerText = sValue2;
                    }
                    continue;
                }

                if (theControl.GetType().Name.ToString() == "TextBox")
                {
                    if (theControl.Enabled == true)
                    {
                        sValue = ((TextBox)theControl).Text;
                    }
                }

                if (theControl.GetType().Name.ToString() == "Label")
                {
                    if (theControl.Enabled == true)
                    {
                        sValue = ((Label)theControl).Text;
                    }
                }

                if (theControl.GetType().Name == "RadioButton")
                {
                    if (theControl.Enabled == true)
                    {
                        sValue = ((RadioButton)theControl).Text;
                    }
                }

                XmlNode xnData = xnNode.SelectSingleNode(thePath);
                xnData.InnerText = sValue;
            }

            xDoc.Save(sPath + "/Peoples/" + sCardId + "/" + "People.xml");
        }

        /// <summary>
        /// 自动存档模式
        /// </summary>
        public static void AutoLoadConfigForPeople(Control frm, string sCardId)
        {
            System.Windows.Forms.Control.ControlCollection cc = frm.Controls;

            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(sPath + "/Peoples/" + sCardId + "/" + "People.xml");

            XmlNode xnNode = xDoc.SelectSingleNode("Data");

            for (int i = 0; i < cc.Count; i++)
            {
                Control theControl = cc[i];

                string thePath = Convert.ToString(theControl.Tag);
                if (thePath == "")
                {
                    continue;
                }

                string sValue = xnNode.SelectSingleNode(thePath).InnerText;

                if (theControl.GetType().Name == "ComboBox")
                {
                    if (theControl.Enabled == true)
                    {
                        ((ComboBox)theControl).SelectedText = xnNode.SelectSingleNode(thePath + "_name").InnerText;
                        ((ComboBox)theControl).SelectedValue = xnNode.SelectSingleNode(thePath + "_code").InnerText;
                    }
                    continue;
                }

                if (theControl.GetType().Name.ToString() == "TextBox")
                {
                    if (theControl.Enabled == true)
                    {
                        ((TextBox)theControl).Text = sValue;
                    }
                }

                if (theControl.GetType().Name.ToString() == "Label")
                {
                    if (theControl.Enabled == true)
                    {
                        ((Label)theControl).Text = sValue;
                    }
                }
            }
        }


        #region //******增加图片*******//
        /// <summary>
        /// 存储图片
        /// </summary>
        /// <param name="sGuid"></param>
        /// <param name="sTag"></param>
        public static void SaveHouseImage(string sGuid, PictureBox pb, string sTag, string title, string imgGuid, string type, string name)
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(sPath + "//house//" + sGuid + "//House.xml");

            string sPicName = Convert.ToString(pb.Tag);

            XmlNode xnPicBox = xDoc.SelectSingleNode(".//residential_housing/images");

            //      <image type="1" name="室外">
            //  <title>大门</title>
            //  <remark>
            //  </remark>
            //  <photo>
            //  </photo>
            //</image>
            XmlAttribute xATime = xDoc.CreateAttribute("type");
            xATime.Value = type;

            XmlAttribute xATimeIn = xDoc.CreateAttribute("name");
            xATimeIn.Value = name;
            XmlAttribute xATimeInGuid = xDoc.CreateAttribute("Guid");
            xATimeInGuid.Value = imgGuid;

            XmlNode xnNewPic = xDoc.CreateElement("image");
            xnNewPic.Attributes.Append(xATime);
            xnNewPic.Attributes.Append(xATimeIn);
            xnNewPic.Attributes.Append(xATimeInGuid);

            XmlNode xnTitle = xDoc.CreateElement("title");
            xnTitle.InnerText = title;
            xnNewPic.AppendChild(xnTitle);

            XmlNode xnRemark = xDoc.CreateElement("remark");
            xnRemark.InnerText = title;
            xnNewPic.AppendChild(xnRemark);


            XmlNode xnPhoto = xDoc.CreateElement("photo");
            xnPhoto.InnerText = sPicName;
            xnNewPic.AppendChild(xnPhoto);

            xnPicBox.AppendChild(xnNewPic);

            //XmlNode xnNewPic = xDoc.CreateElement("PicName");
            //xnNewPic.InnerText = sPicName;

            //XmlAttribute xATime = xDoc.CreateAttribute("CreateTime");
            //xATime.Value = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            //xnNewPic.Attributes.Append(xATime);



            xDoc.Save(sPath + "//house//" + sGuid + "//House.xml");
        }
        #endregion


        /// <summary>
        /// 存储图片
        /// </summary>
        /// <param name="sGuid"></param>
        /// <param name="sTag"></param>
        public static void SaveHouseImage(string sGuid, PictureBox pb, string sTag)
        {
            //XmlDocument xDoc = new XmlDocument();
            //xDoc.Load(sPath + "//house//private//" + sGuid + "//House.xml");

            //string sPicName = Convert.ToString(pb.Tag);

            //XmlNode xnPicBox = xDoc.SelectSingleNode(".//residential_housing/Images/image");

            //XmlNode xnTitle = tilte;
            //xnPicBox.AppendChild(xnTitle);

            //XmlNode xnPhoto = pb.Tag;
            //xnPicBox.AppendChild(xnPhoto);

            ////XmlNode xnNewPic = xDoc.CreateElement("PicName");
            ////xnNewPic.InnerText = sPicName;

            ////XmlAttribute xATime = xDoc.CreateAttribute("CreateTime");
            ////xATime.Value = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            ////xnNewPic.Attributes.Append(xATime);

            //xnPicBox.AppendChild(xnNewPic);

            //xDoc.Save(sPath + "//house//private//" + sGuid + "//House.xml");
        }



        public static void BindPic(PictureBox pb, string sPicFullName)
        {
            try
            {
                string sPictureName = Path.GetFileName(sPicFullName);
                //构造图片
                Bitmap bit = new Bitmap(sPicFullName);
                //设置图片
                pb.Image = Image.FromHbitmap(bit.GetHbitmap());
                pb.Tag = sPictureName;
            }
            catch { }
        }

        /// <summary>
        /// 上一个图片
        /// </summary>
        /// <param name="sGuid"></param>
        /// <param name="pb"></param>
        /// <param name="sTag"></param>
        public static void PreHouseImage(string sGuid, PictureBox pb)
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(sPath + "//house//" + sGuid + "//House.xml");

            string sPictureName = Convert.ToString(pb.Tag);
            string sPicName = "";


            XmlNode xnPicBox = xDoc.SelectSingleNode(".//residential_housing/images/image[photo[text()='" + sPictureName + "']]");

            XmlNode xnNewPicBox;

            if (xnPicBox == null)
            {
                XmlNodeList xnl = xDoc.SelectNodes(".//residential_housing/images/image");
                if (xnl.Count == 0)
                {
                    MessageBox.Show("已经到顶部了。");
                    return;
                }
                xnNewPicBox = xnl[0];
            }
            else
            {
                xnNewPicBox = xnPicBox.PreviousSibling;
                if (xnNewPicBox == null)
                {
                    MessageBox.Show("图片不存在");
                    //NextHouseImage(sGuid, pb, sTag);
                    return;
                }
                XmlNodeList nls = xnNewPicBox.ChildNodes;
                foreach (XmlNode xnl in nls)
                {
                    sPicName = xnl.InnerText;
                }

            }



            // string sPicName = xnNewPicBox.InnerText;
            string ImageForderPath = sPath + @"\house\" + sGuid + @"\pic";

            BindPic(pb, ImageForderPath + @"\" + sPicName);
        }

        /// <summary>
        /// 下一个图片
        /// </summary>
        /// <param name="sGuid"></param>
        /// <param name="pb"></param>
        /// <param name="sTag"></param>
        public static void NextHouseImage(string sGuid, PictureBox pb)
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(sPath + "//house//" + sGuid + "//House.xml");

            string sPictureName = Convert.ToString(pb.Tag);

            string sPicName = "";
            XmlNode xnPicBox = xDoc.SelectSingleNode(".//residential_housing/images/image[photo[text()='" + sPictureName + "']]");

            XmlNode xnNewPicBox;

            if (xnPicBox == null)
            {
                XmlNodeList xnl = xDoc.SelectNodes(".//residential_housing/images/image");
                if (xnl.Count == 0)
                {
                    MessageBox.Show("没有图片");
                    return;
                }
                xnNewPicBox = xnl[0];
            }
            else
            {
                xnNewPicBox = xnPicBox.NextSibling;
                if (xnNewPicBox == null)
                {
                    MessageBox.Show("图片不存在");
                    return;
                }
                XmlNodeList nls = xnNewPicBox.ChildNodes;
                foreach (XmlNode xnl in nls)
                {
                    sPicName = xnl.InnerText;
                }
            }



            // string sPicName = xnNewPicBox.InnerText;
            string ImageForderPath = sPath + @"\house\" + sGuid + @"\pic";

            BindPic(pb, ImageForderPath + @"\" + sPicName);
        }

        /// <summary>
        /// 初始化读取房间图片
        /// </summary>
        /// <param name="sGuid"></param>
        /// <param name="pb"></param>
        /// <param name="sTag"></param>
        public static void initLoadHouseImage(string sGuid, PictureBox pb, string sTag)
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(sPath + "/SystemData.xml");

            string sPictureName = Convert.ToString(pb.Tag);

            XmlNodeList xnl = xDoc.SelectNodes("Data/System/HouseDatas/House[@Guid='" + sGuid + "']/Camera/" + sTag);
            if (xnl.Count == 0)
            {
                //MessageBox.Show("没有图片");
                return;
            }
            XmlNode xnNewPicBox = xnl[0];

            string sPicName = xnNewPicBox.InnerText;
            string ImageForderPath = sPath + @"\" + sGuid;

            BindPic(pb, ImageForderPath + @"\" + sPicName);
        }


        /// <summary> 
        /// 将本地文件上传到指定的服务器(HttpWebRequest方法) 
        /// </summary> 
        /// <param name="address">文件上传到的服务器</param> 
        /// <param name="fileNamePath">要上传的本地文件（全路径）</param> 
        /// <param name="saveName">文件上传后的名称</param> 
        /// <param name="progressBar">上传进度条</param> 
        /// <returns>成功返回1，失败返回0</returns> 
        public static int Upload_Request(string address, string fileNamePath, string saveName)
        {
            int returnValue = 0;
            // 要上传的文件 
            FileStream fs = new FileStream(fileNamePath, FileMode.Open, FileAccess.Read);
            BinaryReader r = new BinaryReader(fs);
            //时间戳 
            string strBoundary = "----------" + DateTime.Now.Ticks.ToString("x");
            byte[] boundaryBytes = Encoding.ASCII.GetBytes("\r\n--" + strBoundary + "\r\n");
            //请求头部信息 
            StringBuilder sb = new StringBuilder();
            sb.Append("--");
            sb.Append(strBoundary);
            sb.Append("\r\n");
            sb.Append("Content-Disposition: form-data; name=\"");
            sb.Append("file");
            sb.Append("\"; filename=\"");
            sb.Append(saveName);
            sb.Append("\"");
            sb.Append("\r\n");
            sb.Append("Content-Type: ");
            sb.Append("application/octet-stream");
            sb.Append("\r\n");
            sb.Append("\r\n");
            string strPostHeader = sb.ToString();
            byte[] postHeaderBytes = Encoding.UTF8.GetBytes(strPostHeader);
            // 根据uri创建HttpWebRequest对象 
            HttpWebRequest httpReq = (HttpWebRequest)WebRequest.Create(new Uri(address));
            httpReq.Method = "POST";
            //对发送的数据不使用缓存 
            httpReq.AllowWriteStreamBuffering = false;
            //设置获得响应的超时时间（300秒） 
            httpReq.Timeout = 300000;
            httpReq.ContentType = "multipart/form-data; boundary=" + strBoundary;
            long length = fs.Length + postHeaderBytes.Length + boundaryBytes.Length;
            long fileLength = fs.Length;
            httpReq.ContentLength = length;
            try
            {
                //progressBar.Maximum = int.MaxValue;
                //progressBar.Minimum = 0;
                //progressBar.Value = 0;
                //每次上传4k 
                int bufferLength = 4096;
                byte[] buffer = new byte[bufferLength];
                //已上传的字节数 
                long offset = 0;
                //开始上传时间 
                DateTime startTime = DateTime.Now;
                int size = r.Read(buffer, 0, bufferLength);
                Stream postStream = httpReq.GetRequestStream();
                //发送请求头部消息 
                postStream.Write(postHeaderBytes, 0, postHeaderBytes.Length);
                while (size > 0)
                {
                    postStream.Write(buffer, 0, size);
                    offset += size;
                    //progressBar.Value = (int)(offset * (int.MaxValue / length));
                    TimeSpan span = DateTime.Now - startTime;
                    double second = span.TotalSeconds;
                    //lblTime.Text = "已用时：" + second.ToString("F2") + "秒";
                    if (second > 0.001)
                    {
                        //lblSpeed.Text = " 平均速度：" + (offset / 1024 / second).ToString("0.00") + "KB/秒";
                    }
                    else
                    {
                        //lblSpeed.Text = " 正在连接…";
                    }
                    //lblState.Text = "已上传：" + (offset * 100.0 / length).ToString("F2") + "%";
                    //lblSize.Text = (offset / 1048576.0).ToString("F2") + "M/" + (fileLength / 1048576.0).ToString("F2") + "M";
                    Application.DoEvents();
                    size = r.Read(buffer, 0, bufferLength);
                }
                //添加尾部的时间戳 
                postStream.Write(boundaryBytes, 0, boundaryBytes.Length);
                postStream.Close();
                //获取服务器端的响应 
                WebResponse webRespon = httpReq.GetResponse();
                Stream s = webRespon.GetResponseStream();
                StreamReader sr = new StreamReader(s);
                //读取服务器端返回的消息 
                String sReturnString = sr.ReadLine();
                s.Close();
                sr.Close();
                if (sReturnString == "Success")
                {
                    returnValue = 1;
                }
                else if (sReturnString == "Error")
                {
                    returnValue = 0;
                }
            }
            catch (Exception ex)
            {
                returnValue = 0;
            }
            finally
            {
                fs.Close();
                r.Close();
            }
            return returnValue;
        }


    }
}

