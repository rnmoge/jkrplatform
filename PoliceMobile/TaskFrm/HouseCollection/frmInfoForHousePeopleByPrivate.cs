using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using PoliceMobile.CLS;
using PoliceMobile.LIB;

namespace PoliceMobile.TaskFrm.HouseCollection
{
    public partial class frmInfoForHousePeopleByPrivate : Form
    {

        [DllImport("SPID.dll", EntryPoint = "SDT_OpenDevice")]
        private static extern int OpenDevice(int mode);
        [DllImport("SPID.dll", EntryPoint = "SDT_CloseDevice")]
        private static extern int CloseDevice(int mode);
        [DllImport("SPID.dll", EntryPoint = "SDT_ReadBaseMsg")]
        private static extern int ReadBaseMsg(byte[] pucCHMsg, ref uint puiCHMsgLen, byte[] pucPHMsg,
                                              ref uint puiPHMsgLen, int iIfOpen);

        public static void Wait(int ms)
        {
            int start = Environment.TickCount;
            while (Environment.TickCount - start < ms)
            {
                Application.DoEvents();
            }
        }

        public frmInfoForHousePeopleByPrivate()
        {
            InitializeComponent();
            ucControlManager1.pPeople.BackColor = Color.White;
            init();
            try
            {
                if (OpenDevice(0) != 1) MessageBox.Show("OpenDevice error");
            }catch{}
        }

        public void init()
        {
            ToolsHelper.BindDataForComboBox("NationType", cbNation, "0");
            ToolsHelper.BindDataForComboBox("GenderType", cbGender, "0");
            ToolsHelper.AutoLoadConfigForHouse(this, ToolsHelper.sHouseGuid);
        }

        private void btnScanIDCard_Click(object sender, EventArgs e)
        {
            
            int offset = 14;
            byte[] baseMsg = new byte[1024];
            byte[] PIC_Byte = new byte[1024];
            uint textMsgLen = 0, picMsgLen = 0;
            string Name;    //姓名
            string Sex_Code;    //性别代码
            string Sex_CName;    //性别
            string IDC;       //身份证号码
            string NATION_Code;    //民族代码
            string NATION_CName;    //民族
            string BIRTH;      //出生日期
            string ADDRESS;     //住址
            string REGORG;      //签发机关

            DateTime STARTDATE;     //身份证有效起始日期
            DateTime ENDDATE;     //身份证有效截至日期
            int m;

            try
            {
                // this.textBox1.Text = " 正在读身份证信息......";
                for (int i = 0; i < 1024; i++)
                {
                    baseMsg[i] = 0x0;
                    PIC_Byte[i] = 0x0;
                }
                m = ReadBaseMsg(baseMsg, ref textMsgLen, PIC_Byte, ref picMsgLen, 0);
                if (m == 1)
                {

                    Name = System.Text.UnicodeEncoding.Unicode.GetString(baseMsg, offset, 30).Trim();
                    Sex_Code = System.Text.UnicodeEncoding.Unicode.GetString(baseMsg, 30 + offset, 2).Trim();
                    NATION_Code = System.Text.UnicodeEncoding.Unicode.GetString(baseMsg, 32 + offset, 4).Trim();
                    string strBird = System.Text.UnicodeEncoding.Unicode.GetString(baseMsg, 36 + offset, 16).Trim();
                    BIRTH = (strBird.Substring(0, 4) + "-" + strBird.Substring(4, 2) + "-" + strBird.Substring(6) + "");
                    ADDRESS = System.Text.UnicodeEncoding.Unicode.GetString(baseMsg, 52 + offset, 70).Trim();
                    IDC = System.Text.UnicodeEncoding.Unicode.GetString(baseMsg, 122 + offset, 36).Trim();
                    //if (Sex_Code == "1") Sex_Code = "男";
                    //else Sex_Code = "女";
                    //if (NATION_Code == "01") NATION_Code = "汉";
                    //else NATION_Code = "蒙古";
                    //this.textBox1.Text = "姓名  " + Name + "\r\n" + "性别  " + Sex_Code + "  民族  " + NATION_Code + "\r\n" + "出生  " + BIRTH + "\r\n" + "住址  " + ADDRESS + "\r\n" + "公民身份号码  " + IDC;
                    Wait(2000);

                    cbGender.SelectedValue = Sex_Code;

                    cbNation.SelectedValue = NATION_Code;

                    txtName.Text = Name;
                    //txtSex.Text = Sex_Code;
                    //txtNation.Text = NATION_Code;
                    txtBirth.Text = BIRTH;
                    txtCardId.Text = IDC;
                    txtAddress.Text = ADDRESS;

                    //pictureBox1.Image = new Bitmap("\\zp.bmp");
                }
                else if (m == 2)
                {
                    Wait(2000);
                    //pictureBox1.Image = new Bitmap("\\zp.bmp");
                }
                else
                {
                    //this.textBox1.Text = "\r\n";
                    //pictureBox1.Image = new Bitmap("\\xp.bmp");
                    MessageBox.Show(" 读卡错误！");

                }
            }
            catch (Exception ex)
            {
                //this.textBox1.Text = "\r\n";
                //pictureBox1.Image = new Bitmap("\\xp.bmp");
                MessageBox.Show(" 读卡错误！");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string sBirth = txtBirth.Text;
            if (sBirth.Length < 8)
            {
                MessageBox.Show("日期格式不正确");
                return;
            }

            if (sBirth.Length == 8)
            {
                string sYear = sBirth.Substring(0, 4);
                string sMonth = sBirth.Substring(4, 2);
                string sDay = sBirth.Substring(6, 2);

                sBirth = sYear + "-" + sMonth + "-" + sDay;
 
            }

            try
            {
                sBirth = Convert.ToDateTime(sBirth).ToString("yyyy-MM-dd");
            }
            catch (Exception)
            {
                MessageBox.Show("日期格式不正确");
                return;
            }
            txtBirth.Text = sBirth;

            ToolsHelper.iFlag = 2;
            ToolsHelper.AutoSaveConfigForHouse(this, ToolsHelper.sHouseGuid,true);
            ToolsHelper.SetConfigXmlbyHouseInfor(ToolsHelper.sHouseGuid, this.txtAddress.Text, this.txtName.Text);
            FrmManager.showWindowFor_frmCameraForHouseByOutdoor(this);
        }

        private void pbPublic_Click(object sender, EventArgs e)
        {
            FrmManager.showWindowFor_frmInfoForHousePeopleByPublic(Owner);
        }

        private void frmInfoForHousePeopleByPrivate_Load(object sender, EventArgs e)
        {
            ToolsHelper.AutoSaveConfigForHouse(this, ToolsHelper.sHouseGuid, true);
        }
    }
}