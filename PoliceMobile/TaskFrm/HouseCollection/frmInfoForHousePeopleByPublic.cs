using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PoliceMobile.CLS;
using PoliceMobile.LIB;

namespace PoliceMobile.TaskFrm.HouseCollection
{
    public partial class frmInfoForHousePeopleByPublic : Form
    {
        public frmInfoForHousePeopleByPublic()
        {
            InitializeComponent();
            ucControlManager1.pPeople.BackColor = Color.White;
            init();
        }

        private void init()
        {
            ToolsHelper.AutoLoadConfigForPublicHouse(this, ToolsHelper.sHouseGuid);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ToolsHelper.iFlag = 2;
            ToolsHelper.SetConfigXmlbyHouseInfor(ToolsHelper.sHouseGuid, this.txtMasterAddress.Text, this.txtName.Text);
            ToolsHelper.AutoSaveConfigForPublicHouse(this, ToolsHelper.sHouseGuid,true);
            FrmManager.showWindowFor_frmCameraForHouseByOutdoor(this);
        }

        private void pbPrivate_Click(object sender, EventArgs e)
        {
            FrmManager.showWindowFor_frmInfoForHousePeopleByPrivate(this);
        }

        private void cbStreet_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_ParentChanged(object sender, EventArgs e)
        {

        }

        private void pbReSet_Click(object sender, EventArgs e)
        {

        }
    }
}