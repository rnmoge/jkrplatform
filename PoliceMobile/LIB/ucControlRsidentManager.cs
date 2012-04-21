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
    public partial class ucControlRsidentManager : UserControl
    {
        public ucControlRsidentManager()
        {
            InitializeComponent();
        }

        private void pHorse_Click(object sender, EventArgs e)
        {
            if (ToolsHelper.iFlag == 1)
            {
                //FrmManager.showWindowFor_frmInfoForStreet(this);
                init();
                pStreet.BackColor = Color.White;
                

                this.Refresh();
            }
        }

        private void pPeople_Click(object sender, EventArgs e)
        {
            if (ToolsHelper.iFlag == 1)
            {
                //FrmManager.showWindowFor_frmInfoForHousePeopleByPublic(this);
                init();
                pPeople.BackColor = Color.White;
                this.Refresh();
            }

        }

        private void pIn_Click(object sender, EventArgs e)
        {
            if (ToolsHelper.iFlag == 1)
            {
                //FrmManager.showWindowFor_frmCameraForHouseByIndoor(this);
                init();
                pIn.BackColor = Color.White;
                

                this.Refresh();
            }

        }

        private void pOut_Click(object sender, EventArgs e)
        {
            if (ToolsHelper.iFlag == 1)
            {
                //FrmManager.showWindowFor_frmCameraForHouseByOutdoor(this);
                init();
                pOut.BackColor = Color.White;
                

                this.Refresh();
            }
        }

        private void pControl_Click(object sender, EventArgs e)
        {
            if (ToolsHelper.iFlag == 1)
            {
                //FrmManager.showWindowFor_frmHouseManager(this);
                init();
                pControl.BackColor = Color.White;
                

                this.Refresh();
            }
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
