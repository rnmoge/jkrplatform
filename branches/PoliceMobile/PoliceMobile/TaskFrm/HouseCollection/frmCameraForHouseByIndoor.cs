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

namespace PoliceMobile.TaskFrm.HouseCollection
{
    public partial class frmCameraForHouseByIndoor : Form
    {
        public frmCameraForHouseByIndoor()
        {
            InitializeComponent();
            ucControlManager1.pIn.BackColor = Color.White;
        }

        private void btnCamera_Click(object sender, EventArgs e)
        {
            string imgGuid = Guid.NewGuid().ToString();
            string sPictureName = imgGuid  + ".jpg";
            string ImageForderPath = ToolsHelper.sPath + @"\" + ToolsHelper.sHouseGuid;
            if (!Directory.Exists(ImageForderPath))
            {
                Directory.CreateDirectory(ImageForderPath);
            }
            Boolean isCamera = ToolsHelper.sCapture(ImageForderPath + @"\" + sPictureName);
            if (isCamera == true)
            {
                System.IO.File.Move(ImageForderPath + @"\" + sPictureName, ToolsHelper.sPath + @"\House\" + ToolsHelper.sHouseGuid + @"\pic\" + sPictureName);

                ToolsHelper.BindPic(pbShow, ToolsHelper.sPath + @"\House\" + ToolsHelper.sHouseGuid + @"\pic\" + sPictureName);
            }
            this.WindowState = FormWindowState.Maximized;
            if (!this.checkBox3.Checked)
            {
                ToolsHelper.SaveHouseImage(ToolsHelper.sHouseGuid, pbShow, "image", this.txtCardId.Text, imgGuid, "2", "室内");
            }
            else
            {
                ToolsHelper.SaveHouseImage(ToolsHelper.sHouseGuid, pbShow, "image", this.txtCardId.Text, imgGuid, "3", "户型图");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string sPicName = Convert.ToString(pbShow.Tag);
            ToolsHelper.DelHouseImage( ToolsHelper.sHouseGuid,pbShow);
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            ToolsHelper.PreHouseImage(ToolsHelper.sHouseGuid, pbShow);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            ToolsHelper.NextHouseImage(ToolsHelper.sHouseGuid, pbShow);
        }

        private void label1_ParentChanged(object sender, EventArgs e)
        {

        }
    }
}