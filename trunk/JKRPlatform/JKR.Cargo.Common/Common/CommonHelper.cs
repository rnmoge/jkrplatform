using System;
using System.Collections.Generic;
using System.Text;
using JKR.GUI.LogixConnector;
using System.Windows.Forms;
using System.Threading;
using System.Data;

namespace JKR.Cargo.Common
{
   public class CommonHelper
    {
        // Fields
        private static Thread _t;
        public static UIProxy proxy;
        private static ToolTip tip;

        public static DataSet GetDataSetByFunctionName(string functionCode, string functionName, object[] args)
        {
            return proxy.GetDataSetByFunctionName(functionCode, functionName, args);
        }
    }
}
