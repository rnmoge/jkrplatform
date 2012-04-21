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
    public partial class frmSpecialResident : Form
    {
        [DllImport("SPID.dll", EntryPoint = "SDT_OpenDevice")]
        private static extern int OpenDevice(int mode);
        [DllImport("SPID.dll", EntryPoint = "SDT_CloseDevice")]
        private static extern int CloseDevice(int mode);
        [DllImport("SPID.dll", EntryPoint = "SDT_ReadBaseMsg")]
        private static extern int ReadBaseMsg(byte[] pucCHMsg, ref uint puiCHMsgLen, byte[] pucPHMsg,
                                              ref uint puiPHMsgLen, int iIfOpen);

        public frmSpecialResident()
        {
            InitializeComponent();
            init();
            if (OpenDevice(0) != 1) MessageBox.Show("OpenDevice error");
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
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete311_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd31_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete322_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd32_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete331_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd33_Click(object sender, EventArgs e)
        {

        }

 
        
    }
}