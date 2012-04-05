using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using JKRPlatform.CommmGUI;

namespace JKRPlatform.SystemManage
{
    public partial class ucMasterData : UserControl
    {
        public ucMasterData()
        {
            InitializeComponent();
            this.radGridView1.DataSource = InitTreeList();
        }


        public enum MasterType
        {
            Yard,
            Port,
            Country,
            Area,
            Continent
            //Line,
            //JobNo,
            //GeneralCode,
            //StatusCode,
            //Currency,
            //ExchangeRate,
            //IATAExchangeRate,
            //Period,
            //VoucherSign,
            //ChargeType,
            //Container,
            //IataArea,
            //CargoType,
            //CargoCriterion,
            //ChargeGroup,
            //PackageType,
            //SyscodeType,
            //SysCode,
            //CreditLevel,
            //AutoCode,           
            //HsCode,
            //AirPalletType,
            //TradeStyle,
            //IncoTerm,
            //SpecialREQ,
            //ConductCompany,
            //FileType,
            //FileProject,
            //ReturnFileSettingExport,
            //ReturnFileSettingImport
        }

        private List<string> InitTreeList()
        {
            List<string> List = new List<string>();
            List.Add("1");
            List.Add("2");
            List.Add("3");
            List.Add("4");
            List.Add("5");
            return List;
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
            //ID = this.tlMasterData.AppendNode(new object[] { null, "", "设备", "基本设备", null, 0 }, -1).Id;
            //this.tlMasterData.AppendNode(new object[] { MasterType.Container, "D_CONTAINER", "箱型", "集装箱类型代码", "0", 1 }, ID);
            //this.tlMasterData.AppendNode(new object[] { MasterType.AirPalletType, "D_AIR_PALLET_TYPE", "板型", "空运集装器代码", "0", 1 }, ID);
            //ID = this.tlMasterData.AppendNode(new object[] { null, "", "结算", "结算财务基础数据", null, 0 }, -1).Id;
            //this.tlMasterData.AppendNode(new object[] { MasterType.Currency, "d_currency", "币种", "币种代码", "0", 1 }, ID);
            //this.tlMasterData.AppendNode(new object[] { MasterType.ChargeType, "d_charge_type", "费用种类", "公司统一标准费用种类代码", "0", 1 }, ID);
            //this.tlMasterData.AppendNode(new object[] { MasterType.ChargeGroup, "d_charge_group", "费用组", "公司多种费用分组方式", "0", 1 }, ID);
            //this.tlMasterData.AppendNode(new object[] { MasterType.ExchangeRate, "D_FIX_EXCHANGE_RATE", "汇率", "基本汇率信息", "0", 1 }, ID);
            //this.tlMasterData.AppendNode(new object[] { MasterType.IATAExchangeRate, "D_IATA_EXCHANGE_RATE", "IATA汇率", "IATA汇率", "0", 1 }, ID);
            //this.tlMasterData.AppendNode(new object[] { MasterType.Period, "D_ACCOUNT_PERIOD", "财务期间", "财务期间", "0", 1 }, ID);
            //this.tlMasterData.AppendNode(new object[] { MasterType.VoucherSign, "D_VOUCHER_SIGN", "凭证字", "财务凭证字", "0", 1 }, ID);

        }

        private void radGridView1_DoubleClick(object sender, EventArgs e)
        {
            Form NewForm = null;
            if (radGridView1.MasterGridViewInfo.CurrentRow != null)
            {
                MasterType Type = (MasterType)Convert.ToInt32(radGridView1.MasterGridViewInfo.CurrentRow.Cells[3].Value.ToString());
                switch (Type)
                {
                    case MasterType.Yard:
                        NewForm = new YardForm();
                        break;

                    case MasterType.Port:
                        NewForm = new PortForm();
                        break;

                    case MasterType.Country:
                        NewForm = new CountryForm();
                        break;

                    case MasterType.Area:
                        NewForm = new AreaForm();
                        break;

                    case MasterType.Continent:
                        NewForm = new ContinentForm();
                        break;
                }
                NewForm.ShowDialog();
            }

        }

    }
}
