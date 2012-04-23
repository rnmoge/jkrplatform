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

namespace PoliceMobile.TaskFrm.HouseCollection
{
    public partial class frmTempResident : Form
    {
        [DllImport("SPID.dll", EntryPoint = "SDT_OpenDevice")]
        private static extern int OpenDevice(int mode);
        [DllImport("SPID.dll", EntryPoint = "SDT_CloseDevice")]
        private static extern int CloseDevice(int mode);
        [DllImport("SPID.dll", EntryPoint = "SDT_ReadBaseMsg")]
        private static extern int ReadBaseMsg(byte[] pucCHMsg, ref uint puiCHMsgLen, byte[] pucPHMsg,
                                              ref uint puiPHMsgLen, int iIfOpen);

        public frmTempResident()
        {
            InitializeComponent();

            ucControlRsidentManager1.pExtendedInfo.BackColor = Color.White;

            
            try
            {
                if (OpenDevice(0) != 1)MessageBox.Show("OpenDevice error");
                
            }catch(Exception ex){
                
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

        private void init()
        {
            //事由
            ToolsHelper.BindDataForComboBox("ReasonstayType", cb_reason, "0");
            //与房东关系
            ToolsHelper.BindDataForComboBox("LandlordrelationType", cb_relation, "0");
        }

        private void pbSave_Click(object sender, EventArgs e)
        {
           //ToolsHelper.AutoSaveConfigForHouse(this,
        }

        private void frmTempResident_Load(object sender, EventArgs e)
        {
            init();
        }
    }
}