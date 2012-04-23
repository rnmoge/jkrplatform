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
        private Form theFrm = null;
        public ucControlRsidentManager()
        {
            InitializeComponent();
        }

        private void pID_Click(object sender, EventArgs e)
        {
                       theFrm = ((Form)this.Parent);
            FrmManager.showWindowFor_frmInfoForPeople(theFrm);
        }

        private void pBaseInfo_Click(object sender, EventArgs e)
        {
            theFrm = ((Form)this.Parent);
            FrmManager.showWindowFor_frmBaseInfoForPeople(theFrm);
        }

        private void pExtendedInfo_Click(object sender, EventArgs e)
        {
            theFrm = ((Form)this.Parent);
            if (ToolsHelper.iPeopleType == 1)
            {
                FrmManager.showWindowFor_frmPermanentResident(theFrm);
                return;
            }

            if (ToolsHelper.iPeopleType == 2)
            {
                FrmManager.showWindowFor_frmTempResident(theFrm);
                return;
            }

            if (ToolsHelper.iPeopleType == 3)
            {
                FrmManager.showWindowFor_frmSpecialResident(theFrm);
                return;
            }
        }

        private void pCamera_Click(object sender, EventArgs e)
        {
            theFrm = ((Form)this.Parent);
            FrmManager.showWindowFor_frmInfoForPeople(theFrm);
        }

        private void pFingerprint_Click(object sender, EventArgs e)
        {
            theFrm = ((Form)this.Parent);
            FrmManager.showWindowFor_frmInfoForPeople(theFrm);
        }

        private void pControl_Click(object sender, EventArgs e)
        {
            theFrm = ((Form)this.Parent);
            FrmManager.showWindowFor_frmInfoForPeople(theFrm);
        }
    }
}
