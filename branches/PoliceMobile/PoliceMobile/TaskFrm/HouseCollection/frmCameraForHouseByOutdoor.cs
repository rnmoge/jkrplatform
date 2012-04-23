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
    public partial class frmCameraForHouseByOutdoor : Form
    {
        public frmCameraForHouseByOutdoor()
        {
            InitializeComponent();
            ucControlManager1.pOut.BackColor = Color.White;
        }

        private void btnCamera_Click(object sender, EventArgs e)
        {

            string imgGuid = Guid.NewGuid().ToString();
            string sPictureName = imgGuid + ".jpg";
            string ImageForderPath = ToolsHelper.sPath + @"\tempImage";
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
            ToolsHelper.SaveHouseImage(ToolsHelper.sHouseGuid, pbShow, "Images", this.txtCardId.Text, imgGuid,"1"," “Õ‚");


            //¡¨–¯≈ƒ’’  3  guid  string[] =3
            //save £®3,"images","title"£©
            //imageflord   copy to  guid/pic
            //delete all imageflord
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

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}