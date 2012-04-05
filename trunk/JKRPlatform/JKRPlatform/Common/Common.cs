using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JKR.GUI.LogixConnector;
using System.Data;

namespace JKRPlatform
{
    public class Common
    {
        private static UIProxy proxy;

        //public static DataSet GetDataSet(GridControl grd)
        //{
        //    DataSet GetDataSet;
        //    try
        //    {
        //        GetDataSet = (DataSet)grd.DataSource;
        //    }
        //    catch (Exception ex)
        //    {
        //        GetDataSet = null;
             
        //        return GetDataSet;
             
        //    }
        //    return GetDataSet;
        //}

        public static DataSet GetDataSet(string functionCode)
        {
            return proxy.GetDataSetFunction(functionCode, new object[0]);
        }

        public static DataSet GetDataSet(string functionCode, decimal arg)
        {
            return proxy.GetDataSetFunction(functionCode, new object[] { arg });
        }

        public static DataSet GetDataSet(string functionCode, string arg)
        {
            return proxy.GetDataSetFunction(functionCode, new object[] { arg });
        }

        public static DataSet GetDataSet(string functionCode, object[] arg)
        {
            return proxy.GetDataSetFunction(functionCode, arg);
        }

 

 


 


 


 


 

    }
}
