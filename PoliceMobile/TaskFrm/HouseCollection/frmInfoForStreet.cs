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
using Microsoft.WindowsCE.Forms;
using System.IO;

namespace PoliceMobile.TaskFrm.HouseCollection
{
    public partial class frmInfoForStreet : Form
    {
        Boolean iFlag_Street = false;
        //编辑标志 fales 默认新建   true 编辑模式
        bool _isEdit = false;
        public frmInfoForStreet(bool isEdit)
        {
            InitializeComponent();
            _isEdit = isEdit;
            ucControlManager1.pStreet.BackColor = Color.White;
            init();
            
        }

        private void init()
        {
            //FrmManager.fifs = this;
            ToolsHelper.BindDataForComboBox("HouseType", cbNotHouse, "0");
            ToolsHelper.BindDataForComboBox("HouseTypeBase", cbHouse, "0");

            if (ToolsHelper.sHouseGuid != "" && _isEdit )
            {
                ToolsHelper.AutoLoadConfigForHouse(this, ToolsHelper.sHouseGuid);
                if (txtHouseType.Text == "2")
                {
                    rbPublic.Checked = true;
                }
                else
                {
                    rbPublic.Checked = false;
                }

                if (txtRent.Text == "1")
                {
                    chb_rent.Checked = true;
                }
                else
                {
                    chb_rent.Checked = false;
                }
            }
        }

        private void cbHouse_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbHouse.Text == "非居住房")
            {
                cbNotHouse.Enabled = true;
            }
            else
            {
                cbNotHouse.Enabled = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cbStreet.SelectedIndex == -1 && !_isEdit)
            {
                MessageBox.Show("请重新选择街道");
                return;
            }

            txt_streetAddress.Text = txtStreet.Text + " " + txtDetailAddress.Text;

            string sGuid = ToolsHelper.sHouseGuid;
            if (sGuid == "")
            {
                sGuid = Guid.NewGuid().ToString();
            }

            ToolsHelper.sHouseGuid = sGuid;

            ToolsHelper.iFlag = 1;
            if (!_isEdit)
            {
                if (rbPrivate.Checked == true)
                {
                    ToolsHelper.iHouseType = 1;
                    ToolsHelper.AutoSaveConfigForHouse(this, sGuid, false);
                    ToolsHelper.SetConfigXmlbyHouse(ToolsHelper.iHouseType.ToString(), sGuid);
                    FrmManager.showWindowFor_frmInfoForHousePeopleByPrivate(this);
                }
                else
                {
                    ToolsHelper.iHouseType = 2;
                    ToolsHelper.AutoSaveConfigForPublicHouse(this, sGuid, false);
                    ToolsHelper.SetConfigXmlbyHouse(ToolsHelper.iHouseType.ToString(), sGuid);
                    FrmManager.showWindowFor_frmInfoForHousePeopleByPublic(this);
                }
            }
            else
            {
                if (rbPrivate.Checked == true)
                {
                    ToolsHelper.iHouseType = 1;
                    ToolsHelper.AutoSaveConfigForHouse(this, sGuid, true);
                   
                    FrmManager.showWindowFor_frmInfoForHousePeopleByPrivate(this);
                }
                else
                {
                    ToolsHelper.iHouseType = 2;
                    ToolsHelper.AutoSaveConfigForPublicHouse(this, sGuid, true);
                   
                    FrmManager.showWindowFor_frmInfoForHousePeopleByPublic(this);
                }
            }
        }

        private void btnDesktop_Click(object sender, EventArgs e)
        {
            FrmManager.showWindowFor_FrmDesktop(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClsSqliteExecute ce = new ClsSqliteExecute();
            DataTable dt = ce.ExecuteDataTable("select (CASE WHEN(address_alias ISnull) THEN address ELSE address || ' | ' || address_alias END) as addressEx,address_root_id,has_details from addresses00 where address like '%" + cbStreet.Text + "%' or address_alias like '%" + cbStreet.Text + "%' and active='Y'");

            cbStreet.DisplayMember = "addressEx";
            cbStreet.ValueMember = "address_root_id";

            cbStreet.DataSource = dt;
        }

       
        private void pbReSet_Click(object sender, EventArgs e)
        {
            txtStreet.Text = "";
            txtInfo.Text = "";
            iFlag_Street = true;
        }

        private void txtStreet_TextChanged(object sender, EventArgs e)
        {
            //if (iFlag_Street)
            //{
            //    iFlag_Street = false;
            //    return;
            //}

            //            string sValue = txtStreet.Text;

            //            if (sValue == "")
            //            {
            //                return;
            //            }

            //ClsSqliteExecute ce = new ClsSqliteExecute();

            //string sSql = "select (CASE WHEN(address_alias ISnull) THEN address ELSE address || ' | ' || address_alias END) as addressEx,address_root_id,has_details from addresses00 where (address like '%" + sValue + "%' or address_alias like '%" + sValue + "%') and active='Y'";
            //DataTable dt = ce.ExecuteDataTable(sSql);

            //StreamWriter rw = new StreamWriter(ToolsHelper.sPath + "/cqddtt.txt", true);

            //rw.WriteLine(sSql);

            //rw.Flush();
            //rw.Close();

            //cbStreet.DisplayMember = "addressEx";
            //cbStreet.ValueMember = "address_root_id";
            //iFlag_Street = false;
            //cbStreet.DataSource = dt;
        }

        private void cbStreet_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToBoolean(iFlag_Street) == false)
            {
                iFlag_Street = true;
                return;
            }

            ClsSqliteExecute cse = new ClsSqliteExecute();
            DataTable dtStreet00 = cse.ExecuteDataTable("select * from addresses00 where address_root_id=" + Convert.ToString(cbStreet.SelectedValue));
            string sHas_details = Convert.ToString(dtStreet00.Rows[0]["has_details"]);

            txtDetailAddress.Visible = true;
            cbAddressDetail.Visible = false;
            txtDetailAddress.Enabled = false;

            if (sHas_details == "Y")
            {
                cbAddressDetail.Visible = true;
                txtDetailAddress.Visible = false;


                ClsSqliteExecute ce = new ClsSqliteExecute();
                DataTable dt = ce.ExecuteDataTable("select * from addresses where address_root_id = " + Convert.ToString(cbStreet.SelectedValue) + "");

                DataRow dr = dt.NewRow();
                dr["address_detail"] = "请选择";
                dr["address_id"] = "-1";

                dt.Rows.InsertAt(dr, 0);

                cbAddressDetail.DisplayMember = "address_detail";
                cbAddressDetail.ValueMember = "address_id";
                cbAddressDetail.DataSource = dt;

                txtDetailAddress.Enabled = true;
                cbAddressDetail.Visible = true;
                txtDetailAddress.Visible = false;

            }
            else if (sHas_details == "M")
            {
                txtDetailAddress.Enabled = true;
                txtDetailAddress.Text = "";
                cbAddressDetail.Visible = false;
                txtDetailAddress.Visible = true;
            }


            txtStreet.Text = cbStreet.Text;
        }

        private void cbStreet_GotFocus(object sender, EventArgs e)
        {
            if (txtStreet.Text == "")
            {
                return;
            }
            ClsSqliteExecute ce = new ClsSqliteExecute();
            string sValue = txtStreet.Text;
            DataTable dt = ce.ExecuteDataTable("select (CASE WHEN(address_alias ISnull) THEN address ELSE address || ' | ' || address_alias END) as addressEx,address_root_id,has_details from addresses00 where address like '%" + sValue + "%' or address_alias like '%" + sValue + "%' and active='Y'");

            cbStreet.DisplayMember = "addressEx";
            cbStreet.ValueMember = "address_root_id";
            iFlag_Street = false;
            cbStreet.DataSource = dt;
        }

        private void cbAddressDetail_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtDetailAddress.Text = Convert.ToString(cbAddressDetail.Text);
            txtDetailAddressId.Text = Convert.ToString(cbAddressDetail.SelectedValue);
        }

        private void rbPrivate_CheckedChanged(object sender, EventArgs e)
        {
            txtHouseType.Text = "1";
        }

        private void rbPublic_CheckedChanged(object sender, EventArgs e)
        {
            txtHouseType.Text = "2";
        }

        private void chb_rent_CheckStateChanged(object sender, EventArgs e)
        {
            if (chb_rent.Checked)
            {
                txtRent.Text = "1";
            }
            else
            {
                txtRent.Text = "0";
            }
        }

        private void frmInfoForStreet_Load(object sender, EventArgs e)
        {
            if (_isEdit)
            {
                ToolsHelper.AutoLoadConfigForHouse(this, ToolsHelper.sHouseGuid);
            }
        }
    }
}