using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PoliceMobile.LIB;
using PoliceMobile.CLS;
using System.Runtime.InteropServices;

namespace PoliceMobile.TaskFrm.PeopleCollection
{
    public partial class frmExtendInfo : Form
    {
        [DllImport("SPID.dll", EntryPoint = "SDT_OpenDevice")]
        private static extern int OpenDevice(int mode);
        [DllImport("SPID.dll", EntryPoint = "SDT_CloseDevice")]
        private static extern int CloseDevice(int mode);
        [DllImport("SPID.dll", EntryPoint = "SDT_ReadBaseMsg")]
        private static extern int ReadBaseMsg(byte[] pucCHMsg, ref uint puiCHMsgLen, byte[] pucPHMsg,
                                              ref uint puiPHMsgLen, int iIfOpen);

        public frmExtendInfo()
        {
            InitializeComponent();
            init();
            if (OpenDevice(0) != 1) MessageBox.Show("OpenDevice error");
        }

        public static void Wait(int ms)
        {
            int start = Environment.TickCount;
            while (Environment.TickCount - start < ms)
            {
                Application.DoEvents();
            }
        }

        private void init()
        {
            //关系            
            ToolsHelper.BindDataForComboBox("ImmediatefamilyType", cbxRelation1, -1);
            ToolsHelper.BindDataForComboBox("ImmediatefamilyType", cbxRelation2, -1);
            ToolsHelper.BindDataForComboBox("RoomaterelationType", cbxRelation21, -1);
            ToolsHelper.BindDataForComboBox("RoomaterelationType", cbxRelation31, -1);
            ToolsHelper.BindDataForComboBox("RoomaterelationType", cbxRelation32, -1);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string sGuid = ToolsHelper.sHouseGuid;
            if (sGuid == "")
            {
                sGuid = Guid.NewGuid().ToString();
            }
            ToolsHelper.AutoSaveConfigForHouse(this, sGuid);
            ToolsHelper.sHouseGuid = sGuid;

            ToolsHelper.iFlag = 1;

            FrmManager.showWindowFor_frmInfoForHousePeopleByPublic();
        }

        #region 常住人口
        /// <summary>
        /// 常住人口增加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd1_Click(object sender, EventArgs e)
        {
            if (txtName1.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("请填写姓名");
                txtName1.Focus();
                return;
            }

            if (lblDatailName11.Text.Trim().Equals(string.Empty))
            {
                lblDatailName11.Text = txtName1.Text;
                lblDetailId11.Text = txtLisence1.Text;
                lblDetailLink11.Text = txtLink1.Text;
                lblDetailAddr11.Text = txtAddress1.Text;
                lblRelation11.Text = cbxRelation1.Text;
                btnDelete11.Visible = true;
            }
            else if (lblDatailName12.Text.Trim().Equals(string.Empty))
            {
                lblDatailName12.Text = txtName1.Text;
                lblDetailId12.Text = txtLisence1.Text;
                lblDetailLink12.Text = txtLink1.Text;
                lblDetailAddr12.Text = txtAddress1.Text;
                lblRelation12.Text = cbxRelation1.Text;
                btnDelete12.Visible = true;
            }
            else if (lblDatailName13.Text.Trim().Equals(string.Empty))
            {
                lblDatailName13.Text = txtName1.Text;
                lblDetailId13.Text = txtLisence1.Text;
                lblDetailLink13.Text = txtLink1.Text;
                lblDetailAddr13.Text = txtAddress1.Text;
                lblRelation13.Text = cbxRelation1.Text;
                btnDelete13.Visible = true;
            }
            else if (lblDatailName14.Text.Trim().Equals(string.Empty))
            {
                lblDatailName14.Text = txtName1.Text;
                lblDetailId14.Text = txtLisence1.Text;
                lblDetailLink14.Text = txtLink1.Text;
                lblDetailAddr14.Text = txtAddress1.Text;
                lblRelation14.Text = cbxRelation1.Text;
                btnDelete14.Visible = true;
            }
            else
            {
                lblDatailName15.Text = txtName1.Text;
                lblDetailId15.Text = txtLisence1.Text;
                lblDetailLink15.Text = txtLink1.Text;
                lblDetailAddr15.Text = txtAddress1.Text;
                lblRelation15.Text = cbxRelation1.Text;
                btnDelete15.Visible = true;
            }
        }

        /// <summary>
        /// 删除直系亲属
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete11_Click(object sender, EventArgs e)
        {
            switch (Convert.ToInt32(((Button)sender).Tag))
            {
                case 0:
                    {
                        lblDatailName11.Text = string.Empty;
                        lblDetailId11.Text = string.Empty;
                        lblDetailLink11.Text = string.Empty;
                        lblDetailAddr11.Text = string.Empty;
                        lblRelation11.Text = string.Empty;
                        btnDelete11.Visible = false;
                        break;
                    }
                case 1:
                    {
                        lblDatailName12.Text = string.Empty;
                        lblDetailId12.Text = string.Empty;
                        lblDetailLink12.Text = string.Empty;
                        lblDetailAddr12.Text = string.Empty;
                        lblRelation12.Text = string.Empty;
                        btnDelete12.Visible = false;
                        break;
                    }
                case 2:
                    {
                        lblDatailName13.Text = string.Empty;
                        lblDetailId13.Text = string.Empty;
                        lblDetailLink13.Text = string.Empty;
                        lblDetailAddr13.Text = string.Empty;
                        lblRelation13.Text = string.Empty;
                        btnDelete13.Visible = false;
                        break;
                    }
                case 3:
                    {
                        lblDatailName14.Text = string.Empty;
                        lblDetailId14.Text = string.Empty;
                        lblDetailLink14.Text = string.Empty;
                        lblDetailAddr14.Text = string.Empty;
                        lblRelation14.Text = string.Empty;
                        btnDelete14.Visible = false;
                        break;
                    }
                case 4:
                    {
                        lblDatailName15.Text = string.Empty;
                        lblDetailId15.Text = string.Empty;
                        lblDetailLink15.Text = string.Empty;
                        lblDetailAddr15.Text = string.Empty;
                        lblRelation15.Text = string.Empty;
                        btnDelete15.Visible = false;
                        break;
                    }
            }
        }
        #endregion

        #region 暂住人口
        private void btnAdd21_Click(object sender, EventArgs e)
        {
            if (txtName2.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("请填写姓名");
                txtName2.Focus();
                return;
            }

            if (lblDatailName21.Text.Trim().Equals(string.Empty))
            {
                lblDatailName21.Text = txtName2.Text;
                lblDetailId21.Text = txtLisence2.Text;
                lblDetailLink21.Text = txtLink2.Text;
                lblDetailAddr21.Text = txtAddress2.Text;
                lblRelation21.Text = cbxRelation2.Text;
                btnDelete21.Visible = true;
            }
            else if (lblDatailName22.Text.Trim().Equals(string.Empty))
            {
                lblDatailName22.Text = txtName2.Text;
                lblDetailId22.Text = txtLisence2.Text;
                lblDetailLink22.Text = txtLink2.Text;
                lblDetailAddr22.Text = txtAddress2.Text;
                lblRelation22.Text = cbxRelation2.Text;
                btnDelete22.Visible = true;
            }
            else if (lblDatailName23.Text.Trim().Equals(string.Empty))
            {
                lblDatailName23.Text = txtName2.Text;
                lblDetailId23.Text = txtLisence2.Text;
                lblDetailLink23.Text = txtLink2.Text;
                lblDetailAddr23.Text = txtAddress2.Text;
                lblRelation23.Text = cbxRelation2.Text;
                btnDelete23.Visible = true;
            }
            else if (lblDatailName24.Text.Trim().Equals(string.Empty))
            {
                lblDatailName24.Text = txtName2.Text;
                lblDetailId24.Text = txtLisence2.Text;
                lblDetailLink24.Text = txtLink2.Text;
                lblDetailAddr24.Text = txtAddress2.Text;
                lblRelation24.Text = cbxRelation2.Text;
                btnDelete24.Visible = true;
            }
            else
            {
                lblDatailName25.Text = txtName2.Text;
                lblDetailId25.Text = txtLisence2.Text;
                lblDetailLink25.Text = txtLink2.Text;
                lblDetailAddr25.Text = txtAddress2.Text;
                lblRelation25.Text = cbxRelation2.Text;
                btnDelete25.Visible = true;
            }
        }

        private void btnDelete21_Click(object sender, EventArgs e)
        {
            switch (Convert.ToInt32(((Button)sender).Tag))
            {
                case 0:
                    {
                        lblDatailName21.Text = string.Empty;
                        lblDetailId21.Text = string.Empty;
                        lblDetailLink21.Text = string.Empty;
                        lblDetailAddr21.Text = string.Empty;
                        lblRelation21.Text = string.Empty;
                        btnDelete21.Visible = false;
                        break;
                    }
                case 1:
                    {
                        lblDatailName22.Text = string.Empty;
                        lblDetailId22.Text = string.Empty;
                        lblDetailLink22.Text = string.Empty;
                        lblDetailAddr22.Text = string.Empty;
                        lblRelation22.Text = string.Empty;
                        btnDelete22.Visible = false;
                        break;
                    }
                case 2:
                    {
                        lblDatailName23.Text = string.Empty;
                        lblDetailId23.Text = string.Empty;
                        lblDetailLink23.Text = string.Empty;
                        lblDetailAddr23.Text = string.Empty;
                        lblRelation23.Text = string.Empty;
                        btnDelete23.Visible = false;
                        break;
                    }
                case 3:
                    {
                        lblDatailName24.Text = string.Empty;
                        lblDetailId24.Text = string.Empty;
                        lblDetailLink24.Text = string.Empty;
                        lblDetailAddr24.Text = string.Empty;
                        lblRelation24.Text = string.Empty;
                        btnDelete24.Visible = false;
                        break;
                    }
                case 4:
                    {
                        lblDatailName25.Text = string.Empty;
                        lblDetailId25.Text = string.Empty;
                        lblDetailLink25.Text = string.Empty;
                        lblDetailAddr25.Text = string.Empty;
                        lblRelation25.Text = string.Empty;
                        btnDelete25.Visible = false;
                        break;
                    }
            }
        }

        private void btnAdd22_Click(object sender, EventArgs e)
        {
            if (txtName21.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("请填写姓名");
                txtName21.Focus();
                return;
            }

            if (lblDatailName211.Text.Trim().Equals(string.Empty))
            {
                lblDatailName211.Text = txtName21.Text;
                lblDetailId211.Text = txtLisence21.Text;
                lblDetailLink211.Text = txtLink21.Text;
                lblDetailAddr211.Text = txtAddress21.Text;
                lblRelation211.Text = cbxRelation21.Text;
                btnDelete211.Visible = true;
            }
            else if (lblDatailName221.Text.Trim().Equals(string.Empty))
            {
                lblDatailName221.Text = txtName21.Text;
                lblDetailId221.Text = txtLisence21.Text;
                lblDetailLink221.Text = txtLink21.Text;
                lblDetailAddr221.Text = txtAddress21.Text;
                lblRelation221.Text = cbxRelation21.Text;
                btnDelete221.Visible = true;
            }
            else if (lblDatailName231.Text.Trim().Equals(string.Empty))
            {
                lblDatailName231.Text = txtName21.Text;
                lblDetailId231.Text = txtLisence21.Text;
                lblDetailLink231.Text = txtLink21.Text;
                lblDetailAddr231.Text = txtAddress21.Text;
                lblRelation231.Text = cbxRelation21.Text;
                btnDelete231.Visible = true;
            }
            else if (lblDatailName241.Text.Trim().Equals(string.Empty))
            {
                lblDatailName241.Text = txtName21.Text;
                lblDetailId241.Text = txtLisence21.Text;
                lblDetailLink241.Text = txtLink21.Text;
                lblDetailAddr241.Text = txtAddress21.Text;
                lblRelation241.Text = cbxRelation21.Text;
                btnDelete241.Visible = true;
            }
            else
            {
                lblDatailName251.Text = txtName21.Text;
                lblDetailId251.Text = txtLisence21.Text;
                lblDetailLink251.Text = txtLink21.Text;
                lblDetailAddr251.Text = txtAddress21.Text;
                lblRelation251.Text = cbxRelation21.Text;
                btnDelete251.Visible = true;
            }
        }

        private void btnDelete211_Click(object sender, EventArgs e)
        {
            switch (Convert.ToInt32((int)((Button)sender).Tag))
            {
                case 0:
                    {
                        lblDatailName211.Text = string.Empty;
                        lblDetailId211.Text = string.Empty;
                        lblDetailLink211.Text = string.Empty;
                        lblDetailAddr211.Text = string.Empty;
                        lblRelation211.Text = string.Empty;
                        btnDelete211.Visible = false;
                        break;
                    }
                case 1:
                    {
                        lblDatailName221.Text = string.Empty;
                        lblDetailId221.Text = string.Empty;
                        lblDetailLink221.Text = string.Empty;
                        lblDetailAddr221.Text = string.Empty;
                        lblRelation221.Text = string.Empty;
                        btnDelete221.Visible = false;
                        break;
                    }
                case 2:
                    {
                        lblDatailName231.Text = string.Empty;
                        lblDetailId231.Text = string.Empty;
                        lblDetailLink231.Text = string.Empty;
                        lblDetailAddr231.Text = string.Empty;
                        lblRelation231.Text = string.Empty;
                        btnDelete231.Visible = false;
                        break;
                    }
                case 3:
                    {
                        lblDatailName241.Text = string.Empty;
                        lblDetailId241.Text = string.Empty;
                        lblDetailLink241.Text = string.Empty;
                        lblDetailAddr241.Text = string.Empty;
                        lblRelation241.Text = string.Empty;
                        btnDelete241.Visible = false;
                        break;
                    }
                case 4:
                    {
                        lblDatailName251.Text = string.Empty;
                        lblDetailId251.Text = string.Empty;
                        lblDetailLink251.Text = string.Empty;
                        lblDetailAddr251.Text = string.Empty;
                        lblRelation251.Text = string.Empty;
                        btnDelete251.Visible = false;
                        break;
                    }
            }
        }
        #endregion

        #region 重点人口
        private void btnAdd31_Click(object sender, EventArgs e)
        {
            if (txtName31.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("请填写姓名");
                txtName31.Focus();
                return;
            }

            if (lblDatailName311.Text.Trim().Equals(string.Empty))
            {
                lblDatailName311.Text = txtName31.Text;
                lblDetailId311.Text = txtLisence31.Text;
                lblDetailLink311.Text = txtLink31.Text;
                lblDetailAddr311.Text = txtAddress31.Text;
                lblRelation311.Text = cbxRelation31.Text;
                btnDelete311.Visible = true;
            }
            else if (lblDatailName312.Text.Trim().Equals(string.Empty))
            {
                lblDatailName312.Text = txtName31.Text;
                lblDetailId312.Text = txtLisence31.Text;
                lblDetailLink312.Text = txtLink31.Text;
                lblDetailAddr312.Text = txtAddress31.Text;
                lblRelation312.Text = cbxRelation31.Text;
                btnDelete312.Visible = true;
            }
            else if (lblDatailName313.Text.Trim().Equals(string.Empty))
            {
                lblDatailName313.Text = txtName31.Text;
                lblDetailId313.Text = txtLisence31.Text;
                lblDetailLink313.Text = txtLink31.Text;
                lblDetailAddr313.Text = txtAddress31.Text;
                lblRelation313.Text = cbxRelation31.Text;
                btnDelete313.Visible = true;
            }
            else if (lblDatailName314.Text.Trim().Equals(string.Empty))
            {
                lblDatailName314.Text = txtName31.Text;
                lblDetailId314.Text = txtLisence31.Text;
                lblDetailLink314.Text = txtLink31.Text;
                lblDetailAddr314.Text = txtAddress31.Text;
                lblRelation314.Text = cbxRelation31.Text;
                btnDelete314.Visible = true;
            }
            else
            {
                lblDatailName315.Text = txtName31.Text;
                lblDetailId315.Text = txtLisence31.Text;
                lblDetailLink315.Text = txtLink31.Text;
                lblDetailAddr315.Text = txtAddress31.Text;
                lblRelation315.Text = cbxRelation31.Text;
                btnDelete315.Visible = true;
            }
        }

        private void btnDelete311_Click(object sender, EventArgs e)
        {
            switch (Convert.ToInt32(((Button)sender).Tag))
            {
                case 0:
                    {
                        lblDatailName311.Text = string.Empty;
                        lblDetailId311.Text = string.Empty;
                        lblDetailLink311.Text = string.Empty;
                        lblDetailAddr311.Text = string.Empty;
                        lblRelation311.Text = string.Empty;
                        btnDelete311.Visible = false;
                        break;
                    }
                case 1:
                    {
                        lblDatailName312.Text = string.Empty;
                        lblDetailId312.Text = string.Empty;
                        lblDetailLink312.Text = string.Empty;
                        lblDetailAddr312.Text = string.Empty;
                        lblRelation312.Text = string.Empty;
                        btnDelete312.Visible = false;
                        break;
                    }
                case 2:
                    {
                        lblDatailName313.Text = string.Empty;
                        lblDetailId313.Text = string.Empty;
                        lblDetailLink313.Text = string.Empty;
                        lblDetailAddr313.Text = string.Empty;
                        lblRelation313.Text = string.Empty;
                        btnDelete313.Visible = false;
                        break;
                    }
                case 3:
                    {
                        lblDatailName314.Text = string.Empty;
                        lblDetailId314.Text = string.Empty;
                        lblDetailLink314.Text = string.Empty;
                        lblDetailAddr314.Text = string.Empty;
                        lblRelation314.Text = string.Empty;
                        btnDelete314.Visible = false;
                        break;
                    }
                case 4:
                    {
                        lblDatailName315.Text = string.Empty;
                        lblDetailId315.Text = string.Empty;
                        lblDetailLink315.Text = string.Empty;
                        lblDetailAddr315.Text = string.Empty;
                        lblRelation315.Text = string.Empty;
                        btnDelete315.Visible = false;
                        break;
                    }
            }
        }

        private void btnAdd32_Click(object sender, EventArgs e)
        {
            if (txtName32.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("请填写姓名");
                txtName32.Focus();
                return;
            }

            if (lblDatailName321.Text.Trim().Equals(string.Empty))
            {
                lblDatailName321.Text = txtName32.Text;
                lblDetailId321.Text = txtLisence32.Text;
                lblDetailLink321.Text = txtLink32.Text;
                lblDetailAddr321.Text = txtAddress32.Text;
                lblRelation321.Text = cbxRelation32.Text;
                btnDelete321.Visible = true;
            }
            else if (lblDatailName322.Text.Trim().Equals(string.Empty))
            {
                lblDatailName322.Text = txtName32.Text;
                lblDetailId322.Text = txtLisence32.Text;
                lblDetailLink322.Text = txtLink32.Text;
                lblDetailAddr322.Text = txtAddress32.Text;
                lblRelation322.Text = cbxRelation32.Text;
                btnDelete322.Visible = true;
            }
            else if (lblDatailName323.Text.Trim().Equals(string.Empty))
            {
                lblDatailName323.Text = txtName32.Text;
                lblDetailId323.Text = txtLisence32.Text;
                lblDetailLink323.Text = txtLink32.Text;
                lblDetailAddr323.Text = txtAddress32.Text;
                lblRelation323.Text = cbxRelation32.Text;
                btnDelete323.Visible = true;
            }
            else if (lblDatailName324.Text.Trim().Equals(string.Empty))
            {
                lblDatailName324.Text = txtName32.Text;
                lblDetailId324.Text = txtLisence32.Text;
                lblDetailLink324.Text = txtLink32.Text;
                lblDetailAddr324.Text = txtAddress32.Text;
                lblRelation324.Text = cbxRelation32.Text;
                btnDelete324.Visible = true;
            }
            else
            {
                lblDatailName325.Text = txtName32.Text;
                lblDetailId325.Text = txtLisence32.Text;
                lblDetailLink325.Text = txtLink32.Text;
                lblDetailAddr325.Text = txtAddress32.Text;
                lblRelation325.Text = cbxRelation32.Text;
                btnDelete325.Visible = true;
            }
        }

        private void btnDelete322_Click(object sender, EventArgs e)
        {
            switch (Convert.ToInt32(((Button)sender).Tag))
            {
                case 0:
                    {
                        lblDatailName321.Text = string.Empty;
                        lblDetailId321.Text = string.Empty;
                        lblDetailLink321.Text = string.Empty;
                        lblDetailAddr321.Text = string.Empty;
                        lblRelation321.Text = string.Empty;
                        btnDelete321.Visible = false;
                        break;
                    }
                case 1:
                    {
                        lblDatailName322.Text = string.Empty;
                        lblDetailId322.Text = string.Empty;
                        lblDetailLink322.Text = string.Empty;
                        lblDetailAddr322.Text = string.Empty;
                        lblRelation322.Text = string.Empty;
                        btnDelete322.Visible = false;
                        break;
                    }
                case 2:
                    {
                        lblDatailName323.Text = string.Empty;
                        lblDetailId323.Text = string.Empty;
                        lblDetailLink323.Text = string.Empty;
                        lblDetailAddr323.Text = string.Empty;
                        lblRelation323.Text = string.Empty;
                        btnDelete323.Visible = false;
                        break;
                    }
                case 3:
                    {
                        lblDatailName324.Text = string.Empty;
                        lblDetailId324.Text = string.Empty;
                        lblDetailLink324.Text = string.Empty;
                        lblDetailAddr324.Text = string.Empty;
                        lblRelation324.Text = string.Empty;
                        btnDelete324.Visible = false;
                        break;
                    }
                case 4:
                    {
                        lblDatailName325.Text = string.Empty;
                        lblDetailId325.Text = string.Empty;
                        lblDetailLink325.Text = string.Empty;
                        lblDetailAddr325.Text = string.Empty;
                        lblRelation325.Text = string.Empty;
                        btnDelete325.Visible = false;
                        break;
                    }
            }
        }

        private void btnAdd33_Click(object sender, EventArgs e)
        {
            if (txtFreeDate.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("请填写释放日期");
                txtFreeDate.Focus();
                return;
            }

            if (lblDate1.Text.Trim().Equals(string.Empty))
            {
                lblDate1.Text = txtFreeDate.Text;
                lblPlace1.Text = txtPlace.Text;
                lblDetail1.Text = txtDetail.Text;
                btnDelete331.Visible = true;
            }
            else if (lblDate2.Text.Trim().Equals(string.Empty))
            {
                lblDate2.Text = txtFreeDate.Text;
                lblPlace2.Text = txtPlace.Text;
                lblDetail2.Text = txtDetail.Text;
                btnDelete332.Visible = true;
            }
            else if (lblDate3.Text.Trim().Equals(string.Empty))
            {
                lblDate3.Text = txtFreeDate.Text;
                lblPlace3.Text = txtPlace.Text;
                lblDetail3.Text = txtDetail.Text;
                btnDelete333.Visible = true;
            }
            else if (lblDate4.Text.Trim().Equals(string.Empty))
            {
                lblDate4.Text = txtFreeDate.Text;
                lblPlace4.Text = txtPlace.Text;
                lblDetail4.Text = txtDetail.Text;
                btnDelete334.Visible = true;
            }
            else
            {
                lblDate5.Text = txtFreeDate.Text;
                lblPlace5.Text = txtPlace.Text;
                lblDetail5.Text = txtDetail.Text;
                btnDelete335.Visible = true;
            }
        }

        private void btnDelete331_Click(object sender, EventArgs e)
        {
            switch (Convert.ToInt32(((Button)sender).Tag))
            {
                case 0:
                    {
                        lblDate1.Text = string.Empty;
                        lblPlace1.Text = string.Empty;
                        lblDetail1.Text = string.Empty;
                        btnDelete331.Visible = false;
                        break;
                    }
                case 1:
                    {
                        lblDate2.Text = string.Empty;
                        lblPlace2.Text = string.Empty;
                        lblDetail2.Text = string.Empty;
                        btnDelete332.Visible = false;
                        break;
                    }
                case 2:
                    {
                        lblDate3.Text = string.Empty;
                        lblPlace3.Text = string.Empty;
                        lblDetail3.Text = string.Empty;
                        btnDelete333.Visible = false;
                        break;
                    }
                case 3:
                    {
                        lblDate4.Text = string.Empty;
                        lblPlace4.Text = string.Empty;
                        lblDetail4.Text = string.Empty;
                        btnDelete334.Visible = false;
                        break;
                    }
                case 4:
                    {
                        lblDate5.Text = string.Empty;
                        lblPlace5.Text = string.Empty;
                        lblDetail5.Text = string.Empty;
                        btnDelete335.Visible = false;
                        break;
                    }
            }

        }
        #endregion

    }
}