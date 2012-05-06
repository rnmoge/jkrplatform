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
            ucControlRsidentManager1.pExtendedInfo.BackColor = Color.White;
            //init();
            if (OpenDevice(0) != 1) MessageBox.Show("OpenDevice error");

            ToolsHelper.AutoLoadConfigForPeople(tabPage1, ToolsHelper.sCardId);

            ToolsHelper.BindDataForComboBox("RoomaterelationType", cbx1_Relation, "0");
            ToolsHelper.BindDataForComboBox("RoomaterelationType", cbx2_Relation, "0");
        }

        public static void Wait(int ms)
        {
            int start = Environment.TickCount;
            while (Environment.TickCount - start < ms)
            {
                Application.DoEvents();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (pBack1.Visible == false)
            {

                lbl1_Name1.Text = this.txt1_Name.Text;
                lbl1_CardId1.Text = txt1_CardId.Text;
                lbl1_Relation1.Text = cbx1_Relation.Text;
                lbl1_Link1.Text = txt1_Link.Text;
                lbl1_Address1.Text = txt1_Address.Text;

                pBack1.Visible = true;
                return;
            }

            if (pBack2.Visible == false)
            {
                lbl1_Name2.Text = txt1_Name.Text;
                lbl1_CardId2.Text = txt1_CardId.Text;
                lbl1_Relation2.Text = cbx1_Relation.Text;
                lbl1_Link2.Text = txt1_Link.Text;
                lbl1_Address2.Text = txt1_Address.Text;

                pBack2.Visible = true;
                return;
            }

            if (pBack3.Visible == false)
            {
                lbl1_Name3.Text = txt1_Name.Text;
                lbl1_CardId3.Text = txt1_CardId.Text;
                lbl1_Relation3.Text = cbx1_Relation.Text;
                lbl1_Link3.Text = txt1_Link.Text;
                lbl1_Address3.Text = txt1_Address.Text;

                pBack3.Visible = true;
                return;
            }

            if (pBack4.Visible == false)
            {
                lbl1_Name4.Text = txt1_Name.Text;
                lbl1_CardId4.Text = txt1_CardId.Text;
                lbl1_Relation4.Text = cbx1_Relation.Text;
                lbl1_Link4.Text = txt1_Link.Text;
                lbl1_Address4.Text = txt1_Address.Text;

                pBack4.Visible = true;
                return;
            }

            if (pBack5.Visible == false)
            {
                lbl1_Name5.Text = txt1_Name.Text;
                lbl1_CardId5.Text = txt1_CardId.Text;
                lbl1_Relation5.Text = cbx1_Relation.Text;
                lbl1_Link5.Text = txt1_Link.Text;
                lbl1_Address5.Text = txt1_Address.Text;

                pBack5.Visible = true;
                return;
            }
        }

        private void btnAdd2_Click(object sender, EventArgs e)
        {
            if (pBBack1.Visible == false)
            {

                
                lbl2_Name1.Text = this.txt2_Name.Text;
                lbl2_CardID1.Text = txt2_CardID.Text;
                lbl2_Relation1.Text = cbx2_Relation.Text;
                lbl2_Link1.Text = txt2_Link.Text;
                lbl2_Address1.Text = txt2_Address.Text;

                pBBack1.Visible = true;
                return;
            }

            if (pBBack2.Visible == false)
            {
                lbl2_Name2.Text = txt2_Name.Text;
                lbl2_CardID2.Text = txt2_CardID.Text;
                lbl2_Relation2.Text = cbx2_Relation.Text;
                lbl2_Link2.Text = txt2_Link.Text;
                lbl2_Address2.Text = txt2_Address.Text;

                pBBack2.Visible = true;
                return;
            }

            if (pBBack3.Visible == false)
            {
                lbl2_Name3.Text = txt2_Name.Text;
                lbl2_CardID3.Text = txt2_CardID.Text;
                lbl2_Relation3.Text = cbx2_Relation.Text;
                lbl2_Link3.Text = txt2_Link.Text;
                lbl2_Address3.Text = txt2_Address.Text;

                pBBack3.Visible = true;
                return;
            }

            if (pBBack4.Visible == false)
            {
                lbl2_Name4.Text = txt2_Name.Text;
                lbl2_CardID4.Text = txt2_CardID.Text;
                lbl2_Relation4.Text = cbx2_Relation.Text;
                lbl2_Link4.Text = txt2_Link.Text;
                lbl2_Address4.Text = txt2_Address.Text;

                pBBack4.Visible = true;
                return;
            }

            if (pBBack5.Visible == false)
            {
                lbl2_Name5.Text = txt2_Name.Text;
                lbl2_CardID5.Text = txt2_CardID.Text;
                lbl2_Relation5.Text = cbx2_Relation.Text;
                lbl2_Link5.Text = txt2_Link.Text;
                lbl2_Address5.Text = txt2_Address.Text;

                pBBack5.Visible = true;
                return;
            }
        }

        private void btnAdd3_Click(object sender, EventArgs e)
        {

            if (pBBBack1.Visible == false)
            {
                lbl3_FreeData1.Text = txt3_FreeData.Text;
                lbl3_Address1.Text = txt3_Address.Text;
                lbl3_Remark1.Text = txt3_Remark.Text;
                pBBBack1.Visible = true;
                return;
            }

            if (pBBBack2.Visible == false)
            {
                lbl3_FreeData2.Text = txt3_FreeData.Text;
                lbl3_Address2.Text = txt3_Address.Text;
                lbl3_Remark2.Text = txt3_Remark.Text;
                pBBBack2.Visible = true;
                return;
            }

            if (pBBBack3.Visible == false)
            {
                lbl3_FreeData3.Text = txt3_FreeData.Text;
                lbl3_Address3.Text = txt3_Address.Text;
                lbl3_Remark3.Text = txt3_Remark.Text;
                pBBBack3.Visible = true;
                return;
            }

            if (pBBBack4.Visible == false)
            {
                lbl3_FreeData4.Text = txt3_FreeData.Text;
                lbl3_Address4.Text = txt3_Address.Text;
                lbl3_Remark4.Text = txt3_Remark.Text;
                pBBBack4.Visible = true;
                return;
            }

            if (pBBBack5.Visible == false)
            {
                lbl3_FreeData5.Text = txt3_FreeData.Text;
                lbl3_Address5.Text = txt3_Address.Text;
                lbl3_Remark5.Text = txt3_Remark.Text;
                pBBBack5.Visible = true;
                return;
            }
            
        }

        private void btnDel3_Click(object sender, EventArgs e)
        {
            ((Button)sender).Parent.Visible = false;
        }

        private void btnDel2_Click(object sender, EventArgs e)
        {
            ((Button)sender).Parent.Visible = false;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            ((Button)sender).Parent.Visible = false;
        }

        private void pSave_Click(object sender, EventArgs e)
        {
            ToolsHelper.AutoSaveConfigForPeople(tabPage1, ToolsHelper.sCardId);

            ToolsHelper.AutoSaveConfigForPeople(pBBBack1, ToolsHelper.sCardId);
            ToolsHelper.AutoSaveConfigForPeople(pBBBack2, ToolsHelper.sCardId);
            ToolsHelper.AutoSaveConfigForPeople(pBBBack3, ToolsHelper.sCardId);
            ToolsHelper.AutoSaveConfigForPeople(pBBBack4, ToolsHelper.sCardId);
            ToolsHelper.AutoSaveConfigForPeople(pBBBack5, ToolsHelper.sCardId);

            ToolsHelper.AutoSaveConfigForPeople(pBBack1, ToolsHelper.sCardId);
            ToolsHelper.AutoSaveConfigForPeople(pBBack2, ToolsHelper.sCardId);
            ToolsHelper.AutoSaveConfigForPeople(pBBack3, ToolsHelper.sCardId);
            ToolsHelper.AutoSaveConfigForPeople(pBBack4, ToolsHelper.sCardId);
            ToolsHelper.AutoSaveConfigForPeople(pBBack5, ToolsHelper.sCardId);

            ToolsHelper.AutoSaveConfigForPeople(pBack1, ToolsHelper.sCardId);
            ToolsHelper.AutoSaveConfigForPeople(pBack2, ToolsHelper.sCardId);
            ToolsHelper.AutoSaveConfigForPeople(pBack3, ToolsHelper.sCardId);
            ToolsHelper.AutoSaveConfigForPeople(pBack4, ToolsHelper.sCardId);
            ToolsHelper.AutoSaveConfigForPeople(pBack5, ToolsHelper.sCardId);

            FrmManager.showWindowFor_frmCameraForPeople(this);
        }

    }
}