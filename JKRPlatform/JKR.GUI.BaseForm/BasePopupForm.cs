using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using JKR.Util;
using Telerik.WinControls.UI;

namespace JKR.GUI.BaseForm
{
    public partial class BasePopupForm : BaseBlankForm
    {
        public BasePopupForm()
        {
            InitializeComponent();
        }

        //绑定数据字段
        public void BindFields(Control owner, DataSet dataset)
        {          
           DataProcess.BindFields(owner, dataset);
        }

        //设置表格风格
        public void InitialGrid( RadGridView grd,  bool editable,  bool show_group)
        {           
            //GridView tv = (GridView)grd.MainView;
            
            //tv.BorderStyle = BorderStyles.Office2003;
            //tv.FocusRectStyle = DrawFocusRectStyle.RowFocus;
            //tv.OptionsBehavior.AutoSelectAllInEditor = false;
            //tv.OptionsCustomization.AllowFilter = false;
            //tv.OptionsNavigation.AutoFocusNewRow = true;
            //tv.OptionsView.ShowFooter = true;
            //tv.OptionsView.ShowIndicator = false;
            //tv.OptionsBehavior.Editable = editable;
            //tv.OptionsNavigation.EnterMoveNextColumn = editable;
            //tv.OptionsNavigation.UseTabKey = !editable;
            //tv.OptionsView.ShowGroupPanel = show_group;
        }



 

    }
}
