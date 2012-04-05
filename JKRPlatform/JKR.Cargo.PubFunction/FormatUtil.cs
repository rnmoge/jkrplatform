using System;
using System.Collections.Generic;
using System.Text;

namespace JKR.Cargo.PubFunction
{
    public class FormatUtil
    {

        public FormatUtil()
        {
        }

        public static decimal Round(decimal dblInput, int intDecimals)
        {
            decimal Round;
            try
            {
                if (decimal.Compare(dblInput, decimal.Zero) != 0)
                {
                    string strFormatString = "0." + new string('0', intDecimals);
                    return Convert.ToDecimal(strFormatString);
                }
                Round = dblInput;
            }
            catch (Exception ex)
            {
                Round = dblInput;
            }
            return Round;
        }

        public static decimal Round(decimal dblInput, int intDecimals, bool formatZero)
        {
            decimal Round;
            try
            {
                string strFormatString = "0." + new string('0', intDecimals);
                Round = Convert.ToDecimal(strFormatString);
            }
            catch (Exception ex)
            {            
                Round = dblInput;
              
            }
            return Round;
        }


    }
}
