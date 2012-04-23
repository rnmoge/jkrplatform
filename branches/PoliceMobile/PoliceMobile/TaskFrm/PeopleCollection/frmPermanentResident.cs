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
    public partial class frmPermanentResident : Form
    {
        [DllImport("SPID.dll", EntryPoint = "SDT_OpenDevice")]
        private static extern int OpenDevice(int mode);
        [DllImport("SPID.dll", EntryPoint = "SDT_CloseDevice")]
        private static extern int CloseDevice(int mode);
        [DllImport("SPID.dll", EntryPoint = "SDT_ReadBaseMsg")]
        private static extern int ReadBaseMsg(byte[] pucCHMsg, ref uint puiCHMsgLen, byte[] pucPHMsg,
                                              ref uint puiPHMsgLen, int iIfOpen);

        public frmPermanentResident()
        {
            InitializeComponent();
            ucControlRsidentManager1.pID.BackColor = Color.White;
        }

        private void init(){
            ToolsHelper.BindDataForComboBox("RoomaterelationType", cbxRelation, "0");
            ToolsHelper.AutoLoadConfigForPeople(tabPage1, ToolsHelper.sCardId);
        }

        public static void Wait(int ms)
        {
            int start = Environment.TickCount;
            while (Environment.TickCount - start < ms)
            {
                Application.DoEvents();
            }
        }

        private void btn_Copy_address1_Click(object sender, EventArgs e)
        {
            txt_current_address.Text = lblAddress.Text;
        }

        private void btn_Copy_address2_Click(object sender, EventArgs e)
        {
            txt_other_local_address.Text = lblAddress.Text;
        }

        private void pbSave_Click(object sender, EventArgs e)
        {
            ToolsHelper.AutoSaveConfigForPeople(tabPage1, lblCardId.Text);

            if (panel1.Visible == true)
            {
                ToolsHelper.AutoSaveConfigForPeople(panel1, lblCardId.Text);
            }

            if (panel2.Visible == true)
            {
                ToolsHelper.AutoSaveConfigForPeople(panel2, lblCardId.Text);
            }

            if (panel3.Visible == true)
            {
                ToolsHelper.AutoSaveConfigForPeople(panel3, lblCardId.Text);
            }

            if (panel4.Visible == true)
            {
                ToolsHelper.AutoSaveConfigForPeople(panel4, lblCardId.Text);
            }

            if (panel5.Visible == true)
            {
                ToolsHelper.AutoSaveConfigForPeople(panel5, lblCardId.Text);
            }

            FrmManager.showWindowFor_frmCameraForPeople(this);
        }

        private void frmPermanentResident_Load(object sender, EventArgs e)
        {
            init();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (panel1.Visible == false)
            {
                lblDatailName1.Text = txtName.Text;
                lblDetailId1.Text = txtIDCard.Text;
                lblDetailRelation1.Text = cbxRelation.Text;
                lblDetailLink1.Text = txtLink.Text;
                lblDetailAddr1.Text = txtAddress.Text;

                panel1.Visible = true;
                return;
            }

            if (panel2.Visible == false)
            {
                lblDatailName2.Text = txtName.Text;
                lblDetailId2.Text = txtIDCard.Text;
                lblDetailRelation2.Text = cbxRelation.Text;
                lblDetailLink2.Text = txtLink.Text;
                lblDetailAddr2.Text = txtAddress.Text;

                panel2.Visible = true;
                return;
            }

            if (panel3.Visible == false)
            {
                lblDatailName3.Text = txtName.Text;
                lblDetailId3.Text = txtIDCard.Text;
                lblDetailRelation3.Text = cbxRelation.Text;
                lblDetailLink3.Text = txtLink.Text;
                lblDetailAddr3.Text = txtAddress.Text;

                panel3.Visible = true;
                return;
            }

            if (panel4.Visible == false)
            {
                lblDatailName4.Text = txtName.Text;
                lblDetailId4.Text = txtIDCard.Text;
                lblDetailRelation4.Text = cbxRelation.Text;
                lblDetailLink4.Text = txtLink.Text;
                lblDetailAddr4.Text = txtAddress.Text;

                panel4.Visible = true;
                return;
            }

            if (panel5.Visible == false)
            {
                lblDatailName5.Text = txtName.Text;
                lblDetailId5.Text = txtIDCard.Text;
                lblDetailRelation5.Text = cbxRelation.Text;
                lblDetailLink5.Text = txtLink.Text;
                lblDetailAddr5.Text = txtAddress.Text;

                panel5.Visible = true;
                return;
            }
        }

        private void btnDelete1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void btnDelete2_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        private void btnDelete3_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
        }

        private void btnDelete4_Click(object sender, EventArgs e)
        {
            panel4.Visible = false;
        }

        private void btnDelete5_Click(object sender, EventArgs e)
        {
            panel5.Visible = false;
        }
    }
}