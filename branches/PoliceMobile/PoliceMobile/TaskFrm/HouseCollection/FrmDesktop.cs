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
    public partial class FrmDesktop : Form
    {
        public FrmDesktop()
        {
            InitializeComponent();

            lblLoginNickName.Text = ToolsHelper.sLoginNickName;
        }

        private void pbHouse_Click(object sender, EventArgs e)
        {
            FrmManager.showWindowFor_frmInfoForStreet(this, false);
        }

        private void pbSearch_Click(object sender, EventArgs e)
        {
            FrmManager.showWindowFor_frmSearchPeople(this);
        }

        private void pbCollectionPeople_Click(object sender, EventArgs e)
        {
            FrmManager.showWindowFor_frmInfoForPeople(this);
        }

        private void pQuit_Click(object sender, EventArgs e)
        {
            FrmManager.showWindowFor_frmLogin(this);
        }
    }
}