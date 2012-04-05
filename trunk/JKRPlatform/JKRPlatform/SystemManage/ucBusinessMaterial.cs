using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using JKRPlatform.CommmGUI;
using Telerik.WinControls.UI;

namespace JKRPlatform.SystemManage
{
    public partial class ucBusinessMaterial : UserControl
    {
        public ucBusinessMaterial()
        {
            InitializeComponent();
            InitTreeList();
        }

        private void InitTreeList()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("代码种类"); 
            dt.Columns.Add("描述");
            dt.Columns.Add("记录数");
            string[] name = { "货物类型", "包装类型", "贸易方式", "贸易条款", "信用等级", "货物编码", "工作号状态", "特殊要求", "企业编码", "文件类型", "文件方案", "出口退单文件", "进口退单文件" };
            string[] cont = { "货物基本大类", "货物包装类型", "进出口用到的贸易模式", "贸易条款", "客户信用等级", "海关货物编码", "用于全程跟踪的工作号状态", "公司预置的操作要求", "海关/三检企业编码", "e-File中用到的文件类型", "e-File中用到的文件分组管理方案", "出口报关后退单文件预设", "进口报关后退单文件预设" };
            for (int i = 0; i < 13; i++)
            {
                DataRow dr = dt.NewRow();
                dr["代码种类"] = name[i].ToString();
                dr["描述"] = cont[i].ToString();
                dr["记录数"] = i.ToString();
                dt.Rows.Add(dr);
            }
            this.radGridView1.DataSource = dt;
            this.radGridView1.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            //int ID;      
            //ID = this.tlMasterData.AppendNode(new object[] { null, "", "业务", "业务基础数据", null, 0 }, -1).Id;
            //this.tlMasterData.AppendNode(new object[] { MasterType.CargoType, "D_CARGO_TYPE", "货物类型", "货物基本大类", "0", 1 }, ID);
            //this.tlMasterData.AppendNode(new object[] { MasterType.PackageType, "D_PACKAGE_TYPE", "包装类型", "货物包装类型", "0", 1 }, ID);
            //this.tlMasterData.AppendNode(new object[] { MasterType.TradeStyle, "D_TRADE_STYLE", "贸易方式", "进出口用到的贸易模式", "0", 1 }, ID);
            //this.tlMasterData.AppendNode(new object[] { MasterType.IncoTerm, "D_INCO_TERM", "贸易条款", "贸易条款", "0", 1 }, ID);
            //this.tlMasterData.AppendNode(new object[] { MasterType.CreditLevel, "D_CREDIT_LEVEL", "信用等级", "客户信用等级", "0", 1 }, ID);
            //this.tlMasterData.AppendNode(new object[] { MasterType.HsCode, "D_HS_CODE", "货物编码", "海关货物编码", "0", 1 }, ID);
            //this.tlMasterData.AppendNode(new object[] { MasterType.StatusCode, "D_STATUS_CODE", "工作号状态", "用于全程跟踪的工作号状态", "0", 1 }, ID);
            //this.tlMasterData.AppendNode(new object[] { MasterType.SpecialREQ, "D_SPECIAL_REQ", "特殊要求", "公司预置的操作要求", "0", 1 }, ID);
            //this.tlMasterData.AppendNode(new object[] { MasterType.ConductCompany, "D_CONDUCT_COMPANY", "企业编码", "海关/三检企业编码", "0", 1 }, ID);
            //this.tlMasterData.AppendNode(new object[] { MasterType.FileType, "D_FILES_TYPE", "文件类型", "e-File中用到的文件类型", "0", 1 }, ID);
            //this.tlMasterData.AppendNode(new object[] { MasterType.FileProject, "D_FILES_PROJECT", "文件方案", "e-File中用到的文件分组管理方案", "0", 1 }, ID);
            //this.tlMasterData.AppendNode(new object[] { MasterType.ReturnFileSettingExport, "D_TRADE_STYLE", "出口退单文件", "出口报关后退单文件预设", "0", 1 }, ID);
            //this.tlMasterData.AppendNode(new object[] { MasterType.ReturnFileSettingImport, "D_TRADE_STYLE", "进口退单文件", "进口报关后退单文件预设", "0", 1 }, ID);
        }

        public enum MasterType
        {
            CargoType,
            PackageType,
            TradeStyle,
            IncoTerm,
            CreditLevel,
            HsCode,
            StatusCode,
            SpecialREQ,
            ConductCompany,
            FileType,
            FileProject,
            ReturnFileSettingExport,
            ReturnFileSettingImport
        }

        private void radGridView1_DoubleClick(object sender, EventArgs e)
        {
            Form NewForm = null;
            string name = this.radGridView1.MasterGridViewInfo.CurrentRow.Cells[0].Value.ToString();
            switch (name)
            {
                case "货物类型":
                    NewForm = new CargoTypeForm();
                    break;

                case "包装类型":
                    NewForm = new PackageTypeForm();
                    break;

                case "贸易方式":
                    NewForm = new TradeStyle();
                    break;

                case "贸易条款":
                    NewForm = new IncoTerm();
                    break;

                case "信用等级":
                    NewForm = new CreditLevelForm();
                    break;
                case "货物编码":
                    NewForm = new HsCode();
                    break;
                case "工作号状态":
                    NewForm = new StatusCode();
                    break;
                case "特殊要求":
                    NewForm = new SpecialREQ();
                    break;
                case "企业编码":
                    NewForm = new ConductCompany();
                    break;
                case "文件类型":
                    NewForm = new FileType();
                    break;
                case "文件方案":
                    NewForm = new FileProject();
                    break;
                case "出口退单文件":
                    NewForm = new ReturnFileSettingExport();
                    break;
                case "进口退单文件":
                    NewForm = new ReturnFileSettingImport();
                    break;
            }
                NewForm.ShowDialog();
        }
    }
}
