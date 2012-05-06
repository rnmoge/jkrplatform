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
            ToolsHelper.AutoLoadConfigForPeople(tabPage1, ToolsHelper.sCardId);
            //事由,
            ToolsHelper.BindDataForComboBox("ReasonstayType", cb_reason, "0");
            //与房东关系
            ToolsHelper.BindDataForComboBox("LandlordrelationType", cb_relation, "0");
            ToolsHelper.BindDataForComboBox("RoomaterelationType", cbxDRelation, "0");
            ToolsHelper.BindDataForComboBox("RoomaterelationType", cbxDDRelation, "0");
            
        }

        private void pbSave_Click(object sender, EventArgs e)
        {
            ToolsHelper.AutoSaveConfigForPeople(tabPage1, ToolsHelper.sCardId);

            ToolsHelper.AutoSaveConfigForPeople(pBack1, ToolsHelper.sCardId);
            ToolsHelper.AutoSaveConfigForPeople(pBack2, ToolsHelper.sCardId);
            ToolsHelper.AutoSaveConfigForPeople(pBack3, ToolsHelper.sCardId);
            ToolsHelper.AutoSaveConfigForPeople(pBack4, ToolsHelper.sCardId);
            ToolsHelper.AutoSaveConfigForPeople(pBack5, ToolsHelper.sCardId);
            ToolsHelper.AutoSaveConfigForPeople(pBack6, ToolsHelper.sCardId);

            ToolsHelper.AutoSaveConfigForPeople(pBBack1, ToolsHelper.sCardId);
            ToolsHelper.AutoSaveConfigForPeople(pBBack2, ToolsHelper.sCardId);
            ToolsHelper.AutoSaveConfigForPeople(pBBack3, ToolsHelper.sCardId);
            ToolsHelper.AutoSaveConfigForPeople(pBBack4, ToolsHelper.sCardId);
            ToolsHelper.AutoSaveConfigForPeople(pBBack5, ToolsHelper.sCardId);

            FrmManager.showWindowFor_frmCameraForPeople(this);
        }

        private void btnAdd3_Click(object sender, EventArgs e)
        {
            if (pBBack1.Visible == false)
            {
                lblName1.Text = this.txtDDName.Text;
                lblID1.Text = txtDDID.Text;
                lblRelation1.Text = cbxDDRelation.Text;
                lblLink1.Text = txtDDLink.Text;
                lblAddress1.Text = txtDDAddress.Text;

                pBBack1.Visible = true;
                return;
            }

            if (pBBack2.Visible == false)
            {
                lblName2.Text = this.txtDDName.Text;
                lblID2.Text = txtDDID.Text;
                lblRelation2.Text = cbxDDRelation.Text;
                lblLink2.Text = txtDDLink.Text;
                lblAddress2.Text = txtDDAddress.Text;

                pBBack2.Visible = true;
                return;
            }

            if (pBBack3.Visible == false)
            {
                lblName3.Text = this.txtDDName.Text;
                lblID3.Text = txtDDID.Text;
                lblRelation3.Text = cbxDDRelation.Text;
                lblLink3.Text = txtDDLink.Text;
                lblAddress3.Text = txtDDAddress.Text;

                pBBack3.Visible = true;
                return;
            }

            if (pBBack4.Visible == false)
            {
                lblName4.Text = this.txtDDName.Text;
                lblID4.Text = txtDDID.Text;
                lblRelation4.Text = cbxDDRelation.Text;
                lblLink4.Text = txtDDLink.Text;
                lblAddress4.Text = txtDDAddress.Text;

                pBBack4.Visible = true;
                return;
            }

            if (pBBack5.Visible == false)
            {
                lblName5.Text = this.txtDDName.Text;
                lblID5.Text = txtDDID.Text;
                lblRelation5.Text = cbxDDRelation.Text;
                lblLink5.Text = txtDDLink.Text;
                lblAddress5.Text = txtDDAddress.Text;

                pBBack5.Visible = true;
                return;
            }
        }

        private void btnAdd2_Click(object sender, EventArgs e)
        {
            if (pBack1.Visible == false)
            {
                lblDatailName1.Text = this.txtDName.Text;
                lblDetailId1.Text = txtDIDCard.Text;
                lblDetailRelation1.Text = cbxDRelation.Text;
                lblDetailLink1.Text = txtDLink.Text;
                lblDetailAddr1.Text = txtDAddress.Text;

                pBack1.Visible = true;
                return;
            }

            if (pBack2.Visible == false)
            {
                lblDatailName2.Text = txtDName.Text;
                lblDetailId2.Text = txtDIDCard.Text;
                lblDetailRelation2.Text = cbxDRelation.Text;
                lblDetailLink2.Text = txtDLink.Text;
                lblDetailAddr2.Text = txtDAddress.Text;

                pBack2.Visible = true;
                return;
            }

            if (pBack3.Visible == false)
            {
                lblDatailName3.Text = txtDName.Text;
                lblDetailId3.Text = txtDIDCard.Text;
                lblDetailRelation3.Text = cbxDRelation.Text;
                lblDetailLink3.Text = txtDLink.Text;
                lblDetailAddr3.Text = txtDAddress.Text;

                pBack3.Visible = true;
                return;
            }

            if (pBack4.Visible == false)
            {
                lblDatailName4.Text = txtDName.Text;
                lblDetailId4.Text = txtDIDCard.Text;
                lblDetailRelation4.Text = cbxDRelation.Text;
                lblDetailLink4.Text = txtDLink.Text;
                lblDetailAddr4.Text = txtDAddress.Text;

                pBack4.Visible = true;
                return;
            }

            if (pBack5.Visible == false)
            {
                lblDatailName5.Text = txtDName.Text;
                lblDetailId5.Text = txtDIDCard.Text;
                lblDetailRelation5.Text = cbxDRelation.Text;
                lblDetailLink5.Text = txtDLink.Text;
                lblDetailAddr5.Text = txtDAddress.Text;

                pBack5.Visible = true;
                return;
            }

            if (pBack6.Visible == false)
            {
                lblDatailName6.Text = txtDName.Text;
                lblDetailId6.Text = txtDIDCard.Text;
                lblDetailRelation6.Text = cbxDRelation.Text;
                lblDetailLink6.Text = txtDLink.Text;
                lblDetailAddr6.Text = txtDAddress.Text;

                pBack6.Visible = true;
                return;
            }
        }

        private void frmTempResident_Load(object sender, EventArgs e)
        {
            init();
        }

        private void btnDel1_Click(object sender, EventArgs e)
        {
            pBack1.Visible = false;
        }

        private void btnDel2_Click(object sender, EventArgs e)
        {
            pBack2.Visible = false;
        }

        private void btnDel3_Click(object sender, EventArgs e)
        {
            pBack3.Visible = false;
        }

        private void btnDel4_Click(object sender, EventArgs e)
        {
            pBack4.Visible = false;
        }

        private void btnDel5_Click(object sender, EventArgs e)
        {
            pBack5.Visible = false;
        }

        private void btnDel6_Click(object sender, EventArgs e)
        {
            pBack6.Visible = false;
        }

        private void btnDelete11_Click(object sender, EventArgs e)
        {
        pBBack1.Visible = false;
        }

        private void btnDelete12_Click(object sender, EventArgs e)
        {
        pBBack2.Visible = false;
        }

        private void btnDelete13_Click(object sender, EventArgs e)
        {
        pBBack3.Visible = false;
        }

        private void btnDelete14_Click(object sender, EventArgs e)
        {
        pBBack4.Visible = false;
        }

        private void btnDelete15_Click(object sender, EventArgs e)
        {
        pBBack5.Visible = false;
        }
    }
}