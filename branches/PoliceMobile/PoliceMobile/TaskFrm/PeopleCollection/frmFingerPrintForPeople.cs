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

namespace PoliceMobile.TaskFrm.PeopleCollection
{
    public partial class frmFingerPrintForPeople : Form
    {
        ///指纹扫描

        /// <summary>

        ///指纹扫描模块打开

        /// </summary>

        /// Return:成功返回1，失败返回0.

        [DllImport("FPC1011.dll", EntryPoint = "OpenDevice", SetLastError = true)]
        public static extern int OpenDevice();



        /// <summary>

        ///指纹扫描模块关闭

        /// </summary>

        /// Return:成功返回1，失败返回0.

        [DllImport("FPC1011.dll", EntryPoint = "CloseDevice", SetLastError = true)]
        public static extern int CloseDevice();



        /// <summary>

        ///读指纹信息

        /// </summary>

        /// Databuffer[Out]:指纹信息内存缓冲信息

        /// Length[Out];指纹图象高度内存缓冲信息

        /// Width[Out]:指纹图象宽度内存缓冲信息

        /// iIfOpen:传入参数

        /// Return:成功返回1，失败返回0.

        [DllImport("FPC1011.dll", EntryPoint = "ReadData", SetLastError = true)]
        public static extern int ReadData(string Databuffer, ref int Length, ref int Width, int iIfOpen);



        public frmFingerPrintForPeople()
        {
            InitializeComponent();
            ucControlRsidentManager1.pBaseInfo.BackColor = Color.White;
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
            ToolsHelper.AutoSaveConfigForPeople(this, ToolsHelper.sCardId);

            ToolsHelper.iPeopleFlag = 2; ;

            if (ToolsHelper.iPeopleType == 1)
            {
                FrmManager.showWindowFor_frmPermanentResident();
                return;
            }

            if (ToolsHelper.iPeopleType == 2)
            {
                FrmManager.showWindowFor_frmTempResident();
                return;
            }

            if (ToolsHelper.iPeopleType == 3)
            {
                FrmManager.showWindowFor_frmSpecialResident();
                return;
            }
        }

        private void btnScanIDCard_Click(object sender, EventArgs e)
        {

            
        }

        private void cbxMarriage_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void frmFingerPrintForPeople_Load(object sender, EventArgs e)
        {
            ToolsHelper.AutoLoadConfigForPeople(this, ToolsHelper.sCardId);
        }

        private void btnAddress_Click(object sender, EventArgs e)
        {

        }
    }
}