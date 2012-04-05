using System;
using System.Collections.Generic;
using System.Text;
using Telerik.WinControls.UI;

namespace JKR.Util
{
    public class OracleSqlHelper
    {
        private static string DATE_FORMART_STRING = "yyyy-MM-dd";
        private static string ORACLE_DATE_FORMART_STRING = "yyyy-mm-dd";

        private static string GetDateString(string fieldName)
        {
            return string.Format("TO_CHAR({0},'{1}')", fieldName, ORACLE_DATE_FORMART_STRING);
        }

        private static string GetDateString(DateTime dt)
        {
            return dt.ToString(DATE_FORMART_STRING);
        }

        private static string GetDateString(RadDateTimePicker dateEdit)
        {
            return GetDateString(dateEdit.Text);
        }

        public static string GetSqlFromTo(string fieldName, DateTime dateFrom, DateTime dateTo)
        {
            string sLimit = string.Empty;
            if (DateTime.Compare(dateFrom, DateTime.MinValue) > 0)
            {
                if (DateTime.Compare(dateTo, DateTime.MinValue) > 0)
                {
                    sLimit = sLimit + string.Format("  {0} >= '{1}' ", GetDateString(fieldName), GetDateString(dateFrom)) + string.Format(" AND {0} <= '{1}' ", GetDateString(fieldName), GetDateString(dateTo));
                }
                else
                {
                    sLimit = sLimit + string.Format("  {0} = '{1}' ", GetDateString(fieldName), GetDateString(dateFrom));
                }
            }
            if (sLimit != string.Empty)
            {
                sLimit = " AND ((" + sLimit + ") OR " + fieldName + " IS NULL )";
            }
            return sLimit;
        }

        public static string GetSqlFromTo(string fieldName, DateTime dateFrom)
        {
            return GetSqlFromTo(fieldName, dateFrom, DateTime.MinValue);
        }

        public static string GetSqlFromTo(string fieldName, RadDateTimePicker dateFrom, RadDateTimePicker dateTo)
        {
            return GetSqlFromTo(fieldName, DateTime.Parse(dateFrom.Text), DateTime.Parse(dateTo.Text));
        }

        public static string GetSqlFromTo(string fieldName, RadDateTimePicker dateFrom)
        {
            return GetSqlFromTo(fieldName,DateTime.Parse(dateFrom.Text), DateTime.MinValue);
        }

        public static string GetSqlFromTo(string fieldName, string valueFrom, string valueTo, bool isBlurry)
        {
            string sLimit = "";
            if (valueFrom.Trim() != "")
            {
                if (valueTo.Trim() != "")
                {
                    return (sLimit + string.Format(" AND {0} >=  '{1}'", fieldName, valueFrom.Trim().Replace("'", "''")) + string.Format(" AND {0} <=  '{1}'", fieldName, valueTo.Trim().Replace("'", "''")));
                }
                if (isBlurry && (valueFrom.Trim().Length >= 4))
                {
                    return (sLimit + string.Format(" AND {0} like  '%{1}%'", fieldName, valueFrom.Trim().Replace("'", "''")));
                }
                return (sLimit + string.Format(" AND {0} =  '{1}'", fieldName, valueFrom.Trim().Replace("'", "''")));
            }
            if (valueTo.Trim() == "")
            {
                return sLimit;
            }
            if (isBlurry && (valueTo.Trim().Length >= 4))
            {
                return (sLimit + string.Format(" AND {0} like  '%{1}%'", fieldName, valueTo.Trim().Replace("'", "''")));
            }
            return (sLimit + string.Format(" AND {0} =  '{1}'", fieldName, valueTo.Trim().Replace("'", "''")));
        }

 

 


 


 


 


 


 



 

    }
}
