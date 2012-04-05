using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using JKR.GUI.LogixConnector;
using System.Data;
using Telerik.WinControls.UI;

namespace JKR.Cargo.Common
{
   public class LookupData
    {
       public LookupData() { }

       public static void SetJobTypeImageCombobox(Control Sender, UIProxy uip)
       {
           if (Sender is RadDropDownList)
           {
               string str2 = "D_JOB_RULE";
               string str = "SELECT RULE_CODE,SHIPMENT_TYPE,RULE_TITLE FROM D_JOB_RULE ORDER BY CREATE_DATE";
               DataView view = new DataView(CommonHelper.GetDataSetByFunctionName("COM_GETLOCALDATASET", "ExecuteQuery", new object[] { str, str2 }).Tables[str2]);
               ((RadDropDownList)Sender).Items.Clear();
               RadListDataItem item = new RadListDataItem();
               item.Text = "(ALL)";
               item.Value = "ALL";
               ((RadDropDownList)Sender).Items.Add(item);
               int num2 = view.Count - 1;
               for (int i = 0; i <= num2; i++)
               {
                   RadListDataItem item2 = new RadListDataItem();
                   item2.Text = view[i]["RULE_TITLE"].ToString();
                   item2.Value = view[i]["SHIPMENT_TYPE"].ToString();
                   ((RadDropDownList)Sender).Items.Add(item2);
               }
               ((RadDropDownList)Sender).SelectedIndex = 0;
           }
       }

       public static void SetChargeTypeLookup2(RadDropDownList Sender, UIProxy uip, string Filter)
       {
           if (UIProxy.Language == UIProxy.LanguageType.English)
           {
               LookupCommonSub2(Sender, uip, "D_CHARGE_TYPE", "CHARGE_CODE", "CHARGE_CODE", new string[,] { { "CHARGE_CODE", "Charge Code", "80" }, { "CHARGE_CNAME", "Charge Cname", "160" } }, Filter);
           }
           else if (UIProxy.Language == UIProxy.LanguageType.Chinese)
           {
               LookupCommonSub2(Sender, uip, "D_CHARGE_TYPE", "CHARGE_CODE", "CHARGE_CODE", new string[,] { { "CHARGE_CODE", "费用代码", "80" }, { "CHARGE_CNAME", "费用名称", "160" } }, Filter);
           }
       }

        #region

        //public static void SetOrganizationLookup(Control Sender, UIProxy uip, string Filter="")
       //{
       //    if (UIProxy.Language == UIProxy.LanguageType.English)
       //    {
       //        LookupCommonSub(Sender, uip, "D_ORGANIZATION", "COMPANY_CODE", "COMPANY_CODE", new string[,] { { "COMPANY_CODE", "Company Code", "80" }, { "COMPANY_NAME", "Company Name", "80" } }, Filter);
       //    }
       //    else if (UIProxy.Language == UIProxy.LanguageType.Chinese)
       //    {
       //        LookupCommonSub(Sender, uip, "D_ORGANIZATION", "COMPANY_CODE", "COMPANY_CODE", new string[,] { { "COMPANY_CODE", "公司代码", "80" }, { "COMPANY_NAME", "公司名称", "80" } }, Filter);
       //    }
       //}

       //public static void SetChargeTypeLookup2(RepositoryItem Sender, UIProxy uip, [Optional, DefaultParameterValue("")] string Filter)
       //{
       //    if (UIProxy.Language == UIProxy.LanguageType.English)
       //    {
       //        LookupCommonSub2(Sender, uip, "D_CHARGE_TYPE", "CHARGE_CODE", "CHARGE_CODE", new string[,] { { "CHARGE_CODE", "Charge Code", "80" }, { "CHARGE_CNAME", "Charge Cname", "160" } }, Filter);
       //    }
       //    else if (UIProxy.Language == UIProxy.LanguageType.Chinese)
       //    {
       //        LookupCommonSub2(Sender, uip, "D_CHARGE_TYPE", "CHARGE_CODE", "CHARGE_CODE", new string[,] { { "CHARGE_CODE", "费用代码", "80" }, { "CHARGE_CNAME", "费用名称", "160" } }, Filter);
       //    }
       //}

       //private static void LookupCommonSub(Control Sender, UIProxy uip, string TableName, string ValueMember, string DisplayMember, string[,] DisplayColumn, string Filter)
       //{
       //    if (Sender is LookUpEdit)
       //    {
       //        DataView view = new DataView(UIProxy.m_LocalDataSet.Tables[TableName]);
       //        if (Filter.Trim() != "")
       //        {
       //            view.RowFilter = Filter;
       //        }
       //        ((LookUpEdit)Sender).Properties.DataSource = view;
       //        ((LookUpEdit)Sender).Properties.DisplayMember = DisplayMember;
       //        ((LookUpEdit)Sender).Properties.ValueMember = ValueMember;
       //        ((LookUpEdit)Sender).Properties.NullText = "";
       //        ((LookUpEdit)Sender).Properties.Columns.Clear();
       //        ((LookUpEdit)Sender).Properties.PopupCellStyle.Font = new Font("Courier New", 8.25f, FontStyle.Regular);
       //        ((LookUpEdit)Sender).Properties.DropDownRows = 12;
       //        int num2 = 0;
       //        int upperBound = DisplayColumn.GetUpperBound(0);
       //        int num4 = upperBound;
       //        for (int i = 0; i <= num4; i++)
       //        {
       //            LookUpColumnInfo column = new LookUpColumnInfo();
       //            column.FieldName = DisplayColumn[i, 0];
       //            column.Caption = DisplayColumn[i, 1];
       //            column.Width = Conversions.ToInteger(DisplayColumn[i, 2]);
       //            ((LookUpEdit)Sender).Properties.Columns.Add(column);
       //            num2 += column.Width;
       //        }
       //        if (num2 == 0)
       //        {
       //            num2 = 150;
       //        }
       //        ((LookUpEdit)Sender).Properties.PopupWidth = num2;
       //    }

       //}

       private static void LookupCommonSub2( RadDropDownList Sender, UIProxy uip, string TableName, string ValueMember, string DisplayMember, string[,] DisplayColumn, string Filter)
       {
           if (Sender is RadDropDownList)
           {
               DataView view = new DataView(UIProxy.m_LocalDataSet.Tables[TableName]);
               if (Filter.Trim() != "")
               {
                   view.RowFilter = Filter;
               }
               ((RadDropDownList)Sender).DataSource = view;
               ((RadDropDownList)Sender).DisplayMember = DisplayMember;
               ((RadDropDownList)Sender).ValueMember = ValueMember;
               ((RadDropDownList)Sender).NullText = "";
               ((RadDropDownList)Sender).Items.Clear();
               ((RadDropDownList)Sender).Style = new Font("Courier New", 8.25f, FontStyle.Regular);
               int num2 = 0;
               int upperBound = DisplayColumn.GetUpperBound(0);
               int num4 = upperBound;
               //for (int i = 0; i <= num4; i++)
               //{
               //    LookUpColumnInfo column = new LookUpColumnInfo();
               //    column.FieldName = DisplayColumn[i, 0];
               //    column.Caption = DisplayColumn[i, 1];
               //    column.Width = Convert.ToInt32(DisplayColumn[i, 2]);
               //    ((RepositoryItemLookUpEdit)Sender).Columns.Add(column);
               //    num2 += column.Width;
               //}
               //if (num2 == 0)
               //{
               //    num2 = 150;
               //}
               //((RepositoryItemLookUpEdit)Sender).PopupWidth = num2;
           }
       }

       #endregion

    }
}
