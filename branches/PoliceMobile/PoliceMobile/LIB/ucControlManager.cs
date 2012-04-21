using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using PoliceMobile.CLS;

namespace PoliceMobile.LIB
{
    public partial class ucControlManager : UserControl
    {
        private Form theFrm = null;
        public ucControlManager()
        {
            InitializeComponent();
        }

        private void pHorse_Click(object sender, EventArgs e)
        {

           theFrm = ((Form)this.Parent);
           FrmManager.showWindowFor_frmInfoForStreet(theFrm);
        }

        private void pPeople_Click(object sender, EventArgs e)
        {
            if (ToolsHelper.iFlag >0)
            {
                theFrm = ((Form)this.Parent);
                if (ToolsHelper.iHouseType == 0)
                {
                    FrmManager.showWindowFor_frmInfoForHousePeopleByPrivate(theFrm);
                }
                else
                {
                    FrmManager.showWindowFor_frmInfoForHousePeopleByPublic(theFrm);
                }
            }

        }

        private void pIn_Click(object sender, EventArgs e)
        {
            if (ToolsHelper.iFlag ==2)
            {
                theFrm = ((Form)this.Parent);
                FrmManager.showWindowFor_frmCameraForHouseByIndoor(theFrm);
            }

        }

        private void pOut_Click(object sender, EventArgs e)
        {
            if (ToolsHelper.iFlag ==2)
            {
                theFrm = ((Form)this.Parent);
                FrmManager.showWindowFor_frmCameraForHouseByOutdoor(theFrm);
            }
        }

        private void pControl_Click(object sender, EventArgs e)
        {
            theFrm = ((Form)this.Parent);
            FrmManager.showWindowFor_frmHouseManager(theFrm);
        }

        public void initForm(){

        }

        /// <summary>
        /// 
        /// </summary>
        private void init()
        {
            pStreet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            pPeople.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            pOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            pIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            pControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
        }

    }
}
