using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data;
using Telerik.WinControls.UI;

namespace JKR.GUI.Controls
{
    public class TelerikControls
    {
        private const string AddControlSetting = "方案设置";
        private const string ControlSetting = "方案应用";


        public static void SetGridStyle(RadGridView grd, DataTable dt)
        {
            if (dt != null)
            {
                GridViewInfo view = (GridViewInfo)grd.ViewDefinition;
                DataView dv = new DataView(dt);
                dv.RowFilter = "1=1";
                dv.Sort = " Visible desc,VisibleIndex asc";
                for (int i = 0; i <= dv.Count; i++)
                {

                    GridViewDataColumn[] col = view.ViewTemplate.Columns.GetColumnByFieldName(dv[i]["ColumnField"].ToString());

                    if (col != null)
                    {
                        if (dv[i]["Visible"].Equals("1"))
                        {
                           
                            //col.IsVisible = Convert.ToInt32(dv[i]["VisibleIndex"]);
                            //col.Width = Convert.ToInt32(dv[i]["Width"]);
                        }
                        else
                        {

                            //col.VisibleIndex = -1;
                            //col.Width = Convert.ToInt32(dv[i]["Width"]);
                        }
                    }
                }

            }

        }



        #region set

        //public static void SetReadOnlyByStyleController(Control ctl, TickStyle StyleControllerReadonly)
        //{

        //    foreach (Control c in ctl.Controls)
        //    {
        //        if ((c is BaseEdit) && (((BaseEdit)c).StyleController == StyleControllerReadonly))
        //        {
        //            if (c is ButtonEdit)
        //            {
        //                ((ButtonEdit)c).Properties.ReadOnly = true;
        //                ((ButtonEdit)c).Properties.Buttons[0].Visible = false;
        //            }
        //            else if (c is CheckEdit)
        //            {
        //                ((CheckEdit)c).Properties.ReadOnly = true;
        //            }
        //            else if (c is DateEdit)
        //            {
        //                ((DateEdit)c).Properties.ReadOnly = true;
        //                ((DateEdit)c).Properties.Buttons[0].Visible = false;
        //            }
        //            else if (c is LookUpEdit)
        //            {
        //                ((LookUpEdit)c).Properties.ReadOnly = true;
        //                ((LookUpEdit)c).Properties.Buttons[0].Visible = false;
        //            }
        //            else if (c is ComboBoxEdit)
        //            {
        //                ((ComboBoxEdit)c).Properties.ReadOnly = true;
        //                ((ComboBoxEdit)c).Properties.Buttons[0].Visible = false;
        //            }
        //            else if (c is ImageComboBoxEdit)
        //            {
        //                ((ImageComboBoxEdit)c).Properties.ReadOnly = true;
        //                ((ImageComboBoxEdit)c).Properties.Buttons[0].Visible = false;
        //            }
        //            else if (c is TextEdit)
        //            {
        //                ((TextEdit)c).Properties.ReadOnly = true;
        //            }
        //        }
        //        SetReadOnlyByStyleController(c, StyleControllerReadonly);

        //    }
        //}

        #endregion

        #region Language
        private static Language m_language;

        public enum Language
        {
            English,
            Chinese
        }

        public static Language SetLanguage
        {
            get
            {
                return m_language;
            }
            set
            {
                m_language = value;
            }
        }

        #endregion
    }
}
