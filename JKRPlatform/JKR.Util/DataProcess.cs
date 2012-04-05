using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data;

namespace JKR.Util
{
    public class DataProcess
    {
        public DataProcess() { }

        public static void BindFields(Control owner, DataSet dataset)
        {
            string sCtlName=string.Empty;
            try
            {
                
                string sTableName, sFieldName;
                int iPos;

                foreach (Control Ctl in owner.Controls)
                {
                    sCtlName = Ctl.Name;

                    //if (Ctl.Equals(Telerik.WinControls.)&& Ctl.Tag.ToString().Equals(""))
                    if (Ctl.Tag.ToString().Equals(""))
                    {
                        Ctl.DataBindings.Clear();
                        iPos = Ctl.Tag.ToString().IndexOf(".");
                        sTableName = Ctl.Tag.ToString().Substring(1, iPos);
                        sFieldName = Ctl.Tag.ToString().Substring(iPos + 2);
                    }
                }

            }
            catch (Exception)
            {
                MessageBox.Show("控件字段绑定错误:" + sCtlName);

            }

        }


    }
}
