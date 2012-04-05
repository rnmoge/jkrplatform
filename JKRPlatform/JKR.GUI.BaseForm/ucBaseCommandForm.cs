using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace JKR.GUI.BaseForm
{
    public partial class ucBaseCommandForm : UserControl
    {
        public ucBaseCommandForm()
        {
            InitializeComponent();
        }




        public void InitialGrid(RadGridView grd, bool editable=false, bool show_group=false)
        {
            //GridView tv = (GridView)grd.MainView;
            //tv.BorderStyle = BorderStyles.Style3D;
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
            
            //grd.LookAndFeel.Style = LookAndFeelStyle.Flat;
            //grd.LookAndFeel.UseDefaultLookAndFeel = false;
            //grd.Styles.AddReplace("HeaderPanel", new ViewStyleEx("HeaderPanel", "Grid", new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0), "", true, false, false, HorzAlignment.Near, VertAlignment.Center, null, SystemColors.Control, SystemColors.ControlText, Color.Empty, LinearGradientMode.Horizontal));
            //grd.Styles.AddReplace("FooterPanel", new ViewStyleEx("FooterPanel", "Grid", new Font("Courier New", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0), "", true, false, false, HorzAlignment.Far, VertAlignment.Center, null, SystemColors.Control, SystemColors.ControlText, Color.Empty, LinearGradientMode.Horizontal));
            //grd.Styles.AddReplace("GroupButton", new ViewStyleEx("GroupButton", "Grid", new Font("Courier New", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0), SystemColors.Control, SystemColors.ControlText, Color.Empty, LinearGradientMode.Horizontal));
            //grd.Styles.AddReplace("FilterCloseButton", new ViewStyleEx("FilterCloseButton", "Grid", new Font("Courier New", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0), SystemColors.Control, SystemColors.ControlText, Color.Empty, LinearGradientMode.Horizontal));
            //grd.Styles.AddReplace("EvenRow", new ViewStyleEx("EvenRow", "Grid", new Font("Courier New", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0), StyleOptions.UseBackColor, Color.LightSkyBlue, SystemColors.WindowText, Color.GhostWhite, LinearGradientMode.ForwardDiagonal));
            //grd.Styles.AddReplace("HideSelectionRow", new ViewStyleEx("HideSelectionRow", "Grid", new Font("Courier New", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0), StyleOptions.UseImage | StyleOptions.UseForeColor | StyleOptions.UseFont | StyleOptions.UseDrawFocusRect | StyleOptions.UseBackColor | StyleOptions.StyleEnabled, SystemColors.InactiveCaption, SystemColors.InactiveCaptionText, Color.Empty, LinearGradientMode.Horizontal));
            //grd.Styles.AddReplace("FixedLine", new ViewStyleEx("FixedLine", "Grid", new Font("Courier New", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0), SystemColors.ControlDarkDark, SystemColors.ControlText, Color.Empty, LinearGradientMode.Horizontal));
            //grd.Styles.AddReplace("GroupPanel", new ViewStyleEx("GroupPanel", "Grid", new Font("Courier New", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0), "", true, false, false, HorzAlignment.Near, VertAlignment.Center, null, SystemColors.ControlDark, SystemColors.ControlText, SystemColors.ControlLightLight, LinearGradientMode.Horizontal));
            //grd.Styles.AddReplace("GroupFooter", new ViewStyleEx("GroupFooter", "Grid", new Font("Courier New", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0), "", true, false, false, HorzAlignment.Far, VertAlignment.Center, null, SystemColors.Control, SystemColors.ControlText, Color.Empty, LinearGradientMode.Horizontal));
            //grd.Styles.AddReplace("GroupRow", new ViewStyleEx("GroupRow", "Grid", new Font("Courier New", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0), "", true, false, false, HorzAlignment.Near, VertAlignment.Center, null, SystemColors.Control, SystemColors.ControlText, Color.Empty, LinearGradientMode.Horizontal));
            //grd.Styles.AddReplace("ColumnFilterButton", new ViewStyleEx("ColumnFilterButton", "Grid", new Font("Courier New", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0), SystemColors.Control, SystemColors.ControlDark, Color.Empty, LinearGradientMode.Horizontal));
            //grd.Styles.AddReplace("Empty", new ViewStyleEx("Empty", "Grid", new Font("Courier New", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0), SystemColors.Window, SystemColors.Window, Color.Empty, LinearGradientMode.Horizontal));
            //grd.Styles.AddReplace("HorzLine", new ViewStyleEx("HorzLine", "Grid", new Font("Courier New", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0), SystemColors.ControlDark, SystemColors.ControlDark, Color.Empty, LinearGradientMode.Horizontal));
            //grd.Styles.AddReplace("VertLine", new ViewStyleEx("VertLine", "Grid", new Font("Courier New", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0), "", true, false, false, HorzAlignment.Near, VertAlignment.Center, null, SystemColors.ControlDark, SystemColors.ControlDark, Color.Empty, LinearGradientMode.Horizontal));
            //grd.Styles.AddReplace("Preview", new ViewStyleEx("Preview", "Grid", new Font("Courier New", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0), "", true, true, false, HorzAlignment.Near, VertAlignment.Top, null, SystemColors.Window, Color.Blue, Color.Empty, LinearGradientMode.Horizontal));
            //grd.Styles.AddReplace("FocusedCell", new ViewStyleEx("FocusedCell", "Grid", new Font("Courier New", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0), StyleOptions.UseImage | StyleOptions.UseForeColor | StyleOptions.UseFont | StyleOptions.UseDrawFocusRect | StyleOptions.UseBackColor | StyleOptions.StyleEnabled, SystemColors.Window, SystemColors.WindowText, Color.Empty, LinearGradientMode.Horizontal));
            //grd.Styles.AddReplace("OddRow", new ViewStyleEx("OddRow", "Grid", new Font("Courier New", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0), StyleOptions.UseBackColor, Color.NavajoWhite, SystemColors.WindowText, Color.White, LinearGradientMode.BackwardDiagonal));
            //grd.Styles.AddReplace("SelectedRow", new ViewStyleEx("SelectedRow", "Grid", new Font("Courier New", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0), StyleOptions.UseImage | StyleOptions.UseForeColor | StyleOptions.UseFont | StyleOptions.UseDrawFocusRect | StyleOptions.UseBackColor | StyleOptions.StyleEnabled, SystemColors.Highlight, SystemColors.HighlightText, Color.Empty, LinearGradientMode.Horizontal));
            //grd.Styles.AddReplace("FocusedRow", new ViewStyleEx("FocusedRow", "Grid", new Font("Courier New", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0), StyleOptions.UseImage | StyleOptions.UseForeColor | StyleOptions.UseFont | StyleOptions.UseDrawFocusRect | StyleOptions.UseBackColor | StyleOptions.StyleEnabled, SystemColors.Highlight, SystemColors.HighlightText, SystemColors.InactiveCaption, LinearGradientMode.Horizontal));
            //grd.Styles.AddReplace("Row", new ViewStyleEx("Row", "Grid", new Font("Courier New", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0), StyleOptions.StyleEnabled, SystemColors.Window, SystemColors.WindowText, Color.Empty, LinearGradientMode.Horizontal));
            //grd.Styles.AddReplace("FilterPanel", new ViewStyleEx("FilterPanel", "Grid", new Font("Courier New", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0), "", true, false, false, HorzAlignment.Near, VertAlignment.Center, null, SystemColors.ControlDark, SystemColors.ControlLightLight, SystemColors.ControlLight, LinearGradientMode.ForwardDiagonal));
            //grd.Styles.AddReplace("RowSeparator", new ViewStyleEx("RowSeparator", "Grid", new Font("Courier New", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0), StyleOptions.StyleEnabled, SystemColors.Window, SystemColors.ControlDark, Color.Empty, LinearGradientMode.Horizontal));
            //grd.Styles.AddReplace("ColumnFilterButtonActive", new ViewStyleEx("ColumnFilterButtonActive", "Grid", new Font("Courier New", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0), SystemColors.Control, Color.Blue, SystemColors.ControlLightLight, LinearGradientMode.Horizontal));
            //grd.Styles.AddReplace("DetailTip", new ViewStyleEx("DetailTip", "Grid", new Font("Courier New", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0), SystemColors.Info, SystemColors.InfoText, Color.Empty, LinearGradientMode.Horizontal));
            //base.InitialGridStyle(new object[] { grd });
        }

 

 

    }
}
