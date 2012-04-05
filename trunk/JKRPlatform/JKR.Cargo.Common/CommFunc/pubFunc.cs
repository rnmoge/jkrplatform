using System;
using System.Collections.Generic;
using System.Text;
using JKR.GUI.LogixConnector;
using JKR.Cargo.PubFunction;

namespace JKR.Cargo.Common.CommFunc
{
    public class pubFunc
    {
        // Fields
        private const string ALL_PRIVILEGE_SUFFIX = ".A";
        private const string GROUP_PRIVILEGE_SUFFIX = ".G";
        private static UIProxy m_uip;


        public static int GetStrLength(string str)
        {
            string sql = " SELECT LENGTHB('" + str + "') from dual ";
            return Convert.ToInt32(m_uip.GetSingleValBySQL(sql));
        }

        public static decimal Round(decimal dblInput, int intDecimals)
        {
            return FormatUtil.Round(dblInput, intDecimals);
        }


        public static string GetSqlFromTo(string FieldName, string ValueFrom, string ValueTo="" , bool bDateField=false)
        {
            string str2 = "";
            if (ValueTo != "")
            {
                if (bDateField)
                {
                    str2 = str2 + " AND TO_CHAR(" + FieldName + ",'YYYY-MM-DD') <= '" + ValueTo + "'";
                }
                else
                {
                    str2 = str2 + " AND " + FieldName + " <=  '" + ValueTo.Replace("'", "''") + "'";
                }
                if (ValueFrom.Trim() == "")
                {
                    return str2;
                }
                if (bDateField)
                {
                    return (str2 + " AND TO_CHAR(" + FieldName + ",'YYYY-MM-DD')>= '" + ValueFrom + "'");
                }
                return (str2 + " AND " + FieldName + " >=  '" + ValueFrom.Trim().Replace("'", "''") + "'");
            }
            if (ValueFrom.Trim() == "")
            {
                return str2;
            }
            if (bDateField)
            {
                return (str2 + " AND  TO_CHAR(" + FieldName + ",'YYYY-MM-DD') >='" + ValueFrom + "'");
            }
            return (str2 + " AND " + FieldName + " = '" + ValueFrom.Trim().Replace("'", "''") + "'");
        }

    }
}
