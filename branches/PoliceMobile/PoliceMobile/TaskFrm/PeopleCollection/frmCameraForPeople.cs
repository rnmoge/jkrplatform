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
            ucControlRsidentManager1.pCamera.BackColor = Color.White;
            ToolsHelper.AutoLoadConfigForPeople(this, ToolsHelper.sCardId);
        }

        private void btnCamera_Click(object sender, EventArgs e)
        {
            string imgGuid = Guid.NewGuid().ToString();
            string sPictureName = imgGuid + ".jpg";
            string ImageForderPath = ToolsHelper.sPath + @"\temp\";
            if (!Directory.Exists(ImageForderPath))
            {
                Directory.CreateDirectory(ImageForderPath);
            }
            Boolean isCamera = ToolsHelper.sCapture(ImageForderPath + @"\" + sPictureName);
            if (isCamera == true)
            {
                System.IO.File.Move(ImageForderPath + @"\" + sPictureName, ToolsHelper.sPath + @"\Peoples\" + ToolsHelper.sCardId + @"\pic\" + sPictureName);

                ToolsHelper.BindPic(pbShow, ToolsHelper.sPath + @"\Peoples\" + ToolsHelper.sCardId + @"\pic\" + sPictureName);
            }

            ToolsHelper.SavePeopleImage(ToolsHelper.sCardId, pbShow, "image", ToolsHelper.sCardId, imgGuid, " ", " ");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string sPicName = Convert.ToString(pbShow.Tag);
            ToolsHelper.DelPeopleImage(ToolsHelper.sHouseGuid,pbShow);
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            ToolsHelper.PrePeopleImage(ToolsHelper.sCardId, pbShow);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            ToolsHelper.NextPeopleImage(ToolsHelper.sCardId, pbShow);
        }
    }
}