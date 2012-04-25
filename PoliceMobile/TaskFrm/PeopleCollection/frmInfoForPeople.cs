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
using System.Runtime.InteropServices;
using System.IO;

namespace PoliceMobile.TaskFrm.HouseCollection
{
    public partial class frmInfoForPeople : Form
    {
        [DllImport("SPID.dll", EntryPoint = "SDT_OpenDevice")]
        private static extern int OpenDevice(int mode);
        [DllImport("SPID.dll", EntryPoint = "SDT_CloseDevice")]
        private static extern int CloseDevice(int mode);
        [DllImport("SPID.dll", EntryPoint = "SDT_ReadBaseMsg")]
        private static extern int ReadBaseMsg(byte[] pucCHMsg, ref uint puiCHMsgLen, byte[] pucPHMsg,
                                              ref uint puiPHMsgLen, int iIfOpen);

        public frmInfoForPeople()
        {
            InitializeComponent();
            ucControlRsidentManager1.pID.BackColor = Color.White;
            init();
            try
            {
                if (OpenDevice(0) != 1) MessageBox.Show("OpenDevice error");
            }
            catch (Exception ex)
            {
                lblCardId.Text = "120103198003063236";
            }
        }

        private void init(){
            ToolsHelper.BindDataForComboBox("PeopleType", cbxPerson, "0");

            if(ToolsHelper.sCardId != ""){
                ToolsHelper.AutoLoadConfigForPeople(this, ToolsHelper.sCardId);

                if (File.Exists(ToolsHelper.sPath + "/Peoples/" + ToolsHelper.sCardId + "/zp.bmp"))
                {
                    pbPic.Image = new Bitmap(ToolsHelper.sPath + "/Peoples/" + ToolsHelper.sCardId + "/zp.bmp");
                }
            }
        }

        public static void Wait(int ms)
        {
            int start = Environment.TickCount;
            while (Environment.TickCount - start < ms)
            {
                Application.DoEvents();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ToolsHelper.CreatePeople(lblCardId.Text, Convert.ToString(cbxPerson.SelectedValue));



            ToolsHelper.AutoSaveConfigForPeople(this, lblCardId.Text);

            ToolsHelper.iFlag = 1;

            ToolsHelper.sCardId = lblCardId.Text;

            ToolsHelper.iPeopleType = Convert.ToInt32(cbxPerson.SelectedValue);

            FrmManager.showWindowFor_frmBaseInfoForPeople(this);
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

            string STARTDATE;     //身份证有效起始日期
            string ENDDATE;     //身份证有效截至日期
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
                    BIRTH = (strBird.Substring(0, 4) + "年" + strBird.Substring(4, 2) + "月" + strBird.Substring(6) + "日");
                    ADDRESS = System.Text.UnicodeEncoding.Unicode.GetString(baseMsg, 52 + offset, 70).Trim();
                    IDC = System.Text.UnicodeEncoding.Unicode.GetString(baseMsg, 122 + offset, 36).Trim();
                    REGORG = System.Text.UnicodeEncoding.Unicode.GetString(baseMsg, 158 + offset, 30).Trim();
                    STARTDATE = System.Text.UnicodeEncoding.Unicode.GetString(baseMsg, 188 + offset, 16).Trim();
                    ENDDATE = System.Text.UnicodeEncoding.Unicode.GetString(baseMsg, 204 + offset, 16).Trim();

                    if (Sex_Code == "1") Sex_Code = "男";
                    else Sex_Code = "女";
                    if (NATION_Code == "01") NATION_Code = "汉";
                    else NATION_Code = "蒙古";
                    //this.textBox1.Text = "姓名  " + Name + "\r\n" + "性别  " + Sex_Code + "  民族  " + NATION_Code + "\r\n" + "出生  " + BIRTH + "\r\n" + "住址  " + ADDRESS + "\r\n" + "公民身份号码  " + IDC;
                    Wait(2000);

                    lblName.Text = Name;
                    lblSex.Text = Sex_Code;
                    lblNation.Text = NATION_Code;
                    lblBirth.Text = BIRTH;
                    lblCardId.Text = IDC;
                    lblAddress.Text = ADDRESS;
                    lbl_REGORG.Text = REGORG;
                    lbl_STARTDATE.Text = STARTDATE;
                    lbl_ENDDATE.Text = ENDDATE;


                    pbSpecial.Visible = false;
                    if (lblCardId_2.Text != "120103198003063236")
                    {
                        pbSpecial.Visible = true;
                    }



                    pbPic.Image = new Bitmap("\\zp.bmp");
                    if (!Directory.Exists( ToolsHelper.sPath + "/Peoples/" + IDC))
                    {
                        Directory.CreateDirectory( ToolsHelper.sPath + "/Peoples/" + IDC);
                    }
                    File.Copy("zp.bmp", ToolsHelper.sPath + "/Peoples/" + IDC + "/zp.bmp", true);

                }
                else if (m == 2)
                {
                    Wait(2000);
                    pbPic.Image = new Bitmap("\\zp.bmp");
                }
                else
                {
                    this.textBox1.Text = "\r\n";
                    pbPic.Image = new Bitmap("\\xp.bmp");
                    MessageBox.Show(" 读卡错误！");

                }
            }
            catch (Exception ex)
            {
                this.textBox1.Text = "\r\n";
                pbPic.Image = new Bitmap("\\xp.bmp");
                MessageBox.Show(" 读卡错误！");
            }
        }

        private void btnDesktop_Click(object sender, EventArgs e)
        {
            FrmManager.showWindowFor_FrmDesktop(this);
        }

        private void lblName_TextChanged(object sender, EventArgs e)
        {
            lblName_2.Text = lblName.Text;

        }

        private void lblSex_TextChanged(object sender, EventArgs e)
        {
            lblSex_2.Text = lblSex.Text;

        }

        private void lblNation_TextChanged(object sender, EventArgs e)
        {
            lblNation_2.Text = lblNation.Text;

        }

        private void lblBirth_TextChanged(object sender, EventArgs e)
        {
            lblBirth_2.Text = lblBirth.Text;

        }

        private void lblCardId_TextChanged(object sender, EventArgs e)
        {
            lblCardId_2.Text = lblCardId.Text;

        }

        private void lblAddress_TextChanged(object sender, EventArgs e)
        {
            lblAddress_2.Text = lblAddress.Text;
        }
    }
}