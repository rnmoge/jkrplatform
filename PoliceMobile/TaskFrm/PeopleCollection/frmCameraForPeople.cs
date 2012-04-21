using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PoliceMobile.CLS;
using System.IO;

namespace PoliceMobile.TaskFrm.PeopleCollection
{
    public partial class frmCameraForPeople : Form
    {
        public frmCameraForPeople()
        {
            InitializeComponent();
        }

        private void btnCamera_Click(object sender, EventArgs e)
        {
            string sPictureName = Guid.NewGuid() + ".jpg";
            string ImageForderPath = ToolsHelper.sPath + @"\" + ToolsHelper.sHouseGuid;
            if (!Directory.Exists(ImageForderPath))
            {
                Directory.CreateDirectory(ImageForderPath);
            }
            Boolean isCamera = ToolsHelper.sCapture(ImageForderPath + @"\" + sPictureName);
            if (isCamera == true)
            {
                ToolsHelper.BindPic(pbShow, ImageForderPath  + @"\" + sPictureName);
            }
            this.WindowState = FormWindowState.Maximized;
            ToolsHelper.SaveHouseImage(ToolsHelper.sHouseGuid,pbShow, "Camera_In");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string sPicName = Convert.ToString(pbShow.Tag);
            ToolsHelper.DelHouseImage( ToolsHelper.sHouseGuid,pbShow, "Camera_In");
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            ToolsHelper.PreHouseImage(ToolsHelper.sHouseGuid, pbShow, "Camera_In");
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            ToolsHelper.NextHouseImage(ToolsHelper.sHouseGuid, pbShow, "Camera_In");
        }
    }
}