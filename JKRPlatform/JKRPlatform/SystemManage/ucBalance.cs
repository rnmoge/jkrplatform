using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using JKRPlatform.CommmGUI;

namespace JKRPlatform.SystemManage
{
    public partial class ucBalance : UserControl
    {
        public ucBalance()
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
            string[] name = { "币种", "费用种类", "费用组", "汇率", "IATA汇率","财务期间", "凭证字"};
            string[] cont = { "币种代码", "公司统一标准费用种类代码", "公司多种费用分组方式", "基本汇率信息", "IATA汇率", "财务期间", "财务凭证字"};
            for (int i = 0; i < 7; i++)
            {
                DataRow dr = dt.NewRow();
                dr["代码种类"] = name[i].ToString();
                dr["描述"] = cont[i].ToString();
                dr["记录数"] = i.ToString();
                dt.Rows.Add(dr);
            }
            this.radGridView1.DataSource = dt;
            this.radGridView1.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
        }

        public enum MasterType
        {
            Currency,
            ChargeType,
            ChargeGroup,
            ExchangeRate,
            IATAExchangeRate,
            Period,
            VoucherSign
        }

        private void radGridView1_DoubleClick(object sender, EventArgs e)
        {
            Form NewForm = null;
            string name = this.radGridView1.MasterGridViewInfo.CurrentRow.Cells[0].Value.ToString();
            switch (name)
            {
                case "币种":
                    NewForm = new Currency();
                    break;

                case "费用种类":
                    NewForm = new ChargeType();
                    break;

                case "费用组":
                    NewForm = new ChargeGroup();
                    break;

                case "汇率":
                    NewForm = new ExchangeRate();
                    break;

                case "IATA汇率":
                    NewForm = new IATAExchangeRate();
                    break;
                case "财务期间":
                    NewForm = new Period();
                    break;
                case "凭证字":
                    NewForm = new VoucherSign();
                    break;
            }
            NewForm.ShowDialog();
        }
    }
}
