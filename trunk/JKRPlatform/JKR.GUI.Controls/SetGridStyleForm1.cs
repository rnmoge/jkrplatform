using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using System.IO;
using JKR.GUI.LogixConnector;

namespace JKR.GUI.Controls
{
    public partial class SetGridStyleForm1 : Form
    {
        #region Private Const
        //风格列表的DataTable名称,方便检索
        private const string GRID_STYLE_LIST = "GridStyleList";    
        private const string STYLE_FILE_PATH = "GridStyle";
        #endregion


        #region Property
        public static string StyleFileName
        {
            get
            {
                return m_StyleFileName;
            }
            set
            {
                m_StyleFileName = value;
                LoadStyle(value);
            }
        }
 

        #endregion

        private static string m_CurrentStyleName;
        private static DataSet m_DsStyle;
        private DataView m_dv;
        private static string m_StyleFileName;


        public SetGridStyleForm1()
        {
            InitializeComponent();
        }


        public static DataTable GetDefaultStyleDataTable(RadGridView grd)
        {
           
            return GetDefaultStyleDataTable((ColumnView)grd.MainView);
        }

        public static DataTable GetDefaultStyleDataTable(ColumnView view)
        {
            
            StyleFileName = GetStyleFileName(view);
            if ((m_DsStyle != null) && (m_DsStyle.Tables["GridStyleList"] != null))
            {
                foreach (DataRow row in m_DsStyle.Tables["GridStyleList"].Select("", "UPDATEDATE DESC", DataViewRowState.CurrentRows))
                {
                    CurrentStyleName = row["StyleName"].ToString();
                    return m_DsStyle.Tables[m_CurrentStyleName];
                }
            }
            return null;
        }

        private static string GetStyleFileName(ColumnView view)
        {
            StyleFileName = view.GridControl.FindForm().Name + "." + view.GridControl.Name;
            return GetCurrentStyleFileName();
        }

        private static string GetCurrentStyleFileName()
        {
            string pathstr = Path.Combine(UIProxy.GetCurrentUserFolder(), "GridStyle");
            if (!Directory.Exists(pathstr))
            {
                Directory.CreateDirectory(pathstr);
            }
            return Path.Combine(pathstr, StyleFileName);
        }

        private static void LoadStyle(string styleFileName)
        {
            string fileName = styleFileName + ".Style";
            if (File.Exists(fileName))
            {
                m_DsStyle = new DataSet();
                try
                {
                    m_DsStyle.ReadXml(fileName);
                }
                catch (Exception ex)
                {                 
                    try
                    {
                        File.Delete(fileName);
                    }
                    catch (Exception exx)
                    {                      
                     
                    }
                }
            }
            else
            {
                m_DsStyle = null;
            }
        }

    }
}
