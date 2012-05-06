using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using PoliceMobile.TaskFrm.HouseCollection;
using PoliceMobile.TaskFrm.PeopleCollection;
using System.Windows.Forms;

namespace PoliceMobile.LIB
{
    public static class FrmManager
    {   
        /// <summary>
        /// 重点人口
        /// </summary>
        public static void showWindowFor_frmSpecialResident()
        {

            frmSpecialResident frmSP = new frmSpecialResident();

            frmSP.Show();
        }

        /// <summary>
        /// 暂住人口
        /// </summary>
        public static void showWindowFor_frmTempResident()
        {
  
                frmTempResident frmVP = new frmTempResident();

            frmVP.Show();
        }

        /// <summary>
        /// 常住人口
        /// </summary>
        public static void showWindowFor_frmPermanentResident()
        {

                frmPermanentResident frmUR = new frmPermanentResident();

            frmUR.Show();
        }
        ///// <summary>
        ///// 扩展信息
        ///// </summary>
        //public static void showWindowFor_frmExpandInfo()
        //{
        //    if (frmExpand == null)
        //    {
        //        frmExpand = new frmExtendInfo();
        //    }
        //    frmExpand.Show();
        //}

        public static void showWindowFor_frmInfoForStreet(Form theForm,bool isEidt)
        {
            frmInfoForStreet fifs = new frmInfoForStreet(isEidt);
            fifs.Show();
            theForm.Close();
            theForm.Dispose();
            theForm = null;
        }

        public static void showWindowFor_frmInfoForHousePeopleByPublic(Form theForm)
        {
            frmInfoForHousePeopleByPublic fifhpbpc = new frmInfoForHousePeopleByPublic();
                fifhpbpc.Show();
                theForm.Close();
                theForm.Dispose();
                theForm = null;
        }

        public static void showWindowFor_frmInfoForHousePeopleByPrivate(Form theForm)
        {
                frmInfoForHousePeopleByPrivate fifhpbpv = new frmInfoForHousePeopleByPrivate();
                fifhpbpv.Show();
                theForm.Close();
                theForm.Dispose();
                theForm = null;
                return;

        }

        public static void showWindowFor_frmCameraForHouseByIndoor(Form theForm)
        {

                frmCameraForHouseByIndoor fcfhbi = new frmCameraForHouseByIndoor();
                fcfhbi.Show();
                theForm.Close();
                theForm.Dispose();
                theForm = null;
        }

        public static void showWindowFor_frmCameraForHouseByOutdoor(Form theForm)
        {

            frmCameraForHouseByOutdoor fcfhbo = new frmCameraForHouseByOutdoor();

            fcfhbo.Show();
            theForm.Close();
            theForm.Dispose();
            theForm = null;
        }

        public static void showWindowFor_frmHouseManager(Form theForm)
        {

            frmHourseManager fhm = new frmHourseManager();

            fhm.Show();
            theForm.Close();
            theForm.Dispose();
            theForm = null;
        }

        public static void showWindowFor_FrmDesktop(Form theForm)
        {

                FrmDesktop fd = new FrmDesktop();

            fd.Show();
            if (theForm.Name == "frmLogin")
            {
                theForm.Hide();
            }
            else
            {
                theForm.Close();
                theForm.Dispose();
                theForm.Hide();
                theForm = null;
            }

        }

        public static void showWindowFor_frmSearchPeople(Form theForm)
        {

                frmSearchPeople fsp = new frmSearchPeople();

            fsp.Show();
            //theForm.Close();
            //theForm.Dispose();
            theForm = null;
        }

        public static void showWindowFor_frmCameraForPeople(Form theForm)
        {

                frmCameraForPeople fcfp = new frmCameraForPeople();

            fcfp.Show();
            theForm.Close();
            theForm.Dispose();
            theForm = null;
        }

        public static void showWindowFor_frmInfoForPeople(Form theForm)
        {

                frmInfoForPeople fifp = new frmInfoForPeople();
                fifp.Show();
                theForm.Close();
                theForm.Dispose();
                theForm = null;
        }

        public static void showWindowFor_frmBaseInfoForPeople(Form theForm)
        {
            frmBaseInfoForPeople fbifp = new frmBaseInfoForPeople();
            fbifp.Show();
            theForm.Close();
            theForm.Dispose();
            theForm = null;
        }

        public static void showWindowFor_frmPermanentResident(Form theForm)
        {
            frmPermanentResident fpr = new frmPermanentResident();
            fpr.Show();
            theForm.Close();
            theForm.Dispose();
            theForm = null;
        }

        public static void showWindowFor_frmSpecialResident(Form theForm)
        {
            frmSpecialResident fsr = new frmSpecialResident();
            fsr.Show();
            theForm.Close();
            theForm.Dispose();
            theForm = null;
        }

        public static void showWindowFor_frmTempResident(Form theForm)
        {
            frmTempResident fts = new frmTempResident();
            fts.Show();

            theForm.Close();
            theForm.Dispose();
            theForm = null;
        }

        public static void showWindowFor_frmResidentManager(Form theForm)
        {
            frmResidentManager frm = new frmResidentManager();
            frm.Show();

            theForm.Close();
            theForm.Dispose();
            theForm = null;
        }

        public static void showWindowFor_frmLogin(Form theForm)
        {
            frmLogin fl = new frmLogin();
            fl.Show();

            theForm.Close();
            theForm.Dispose();
            theForm = null;
        }
    }
}
