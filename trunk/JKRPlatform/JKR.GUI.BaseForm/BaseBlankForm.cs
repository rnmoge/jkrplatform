using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using JKR.GUI.Controls;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace JKR.GUI.BaseForm
{
    public partial class BaseBlankForm : Form
    {
        private Array controlName;
        private object[] gridList;
        private GridStyle GridStyle;
        private Color sourceColor;
        private string SYSTEM_ICON= "";
        private const int VK_RETURN = 13;

        //[DllImport("user32.dll", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vk);
        //[DllImport("user32.dll", EntryPoint = "RegisterHotKey", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
        public static extern bool UnregisterHotKey(IntPtr hWnd, int id);    

        public BaseBlankForm()
        {
            InitializeComponent();
        }

        public void RegisterKey(Control parentControl)
        {
            Control.ControlCollection formControls = parentControl.Controls;
            if (formControls.Count > 0)
            {
                return;
            }
            foreach (Control controlItem in formControls)
            {
                //if (Array.IndexOf(this.controlName, controlItem.GetType().Name) >= 0)
                //{
                //    if (controlItem is  RadComboBox)
                //    {
                //        ((RadComboBox)controlItem).Properties.UseCtrlScroll = true;
                //    }
                //    if (controlItem is rad)
                //    {
                //        ((ImageComboBoxEdit)controlItem).Properties.UseCtrlScroll = true;
                //    }
                //    if (controlItem is DateEdit)
                //    {
                //        if (((DateEdit)controlItem).Properties.DisplayFormat.FormatString == "yyyy-MM-dd")
                //        {
                //            ((DateEdit)controlItem).Properties.MaskData.EditMask = @"\d\d\d\d-\d\d\-\d\d";
                //            ((DateEdit)controlItem).Properties.MaskData.MaskType = MaskType.Regular;
                //        }
                //        if (((DateEdit)controlItem).Properties.DisplayFormat.FormatString == "yyyy-MM-dd HH:mm")
                //        {
                //            ((DateEdit)controlItem).Properties.MaskData.EditMask = @"\d\d\d\d-\d\d\-\d\d \d\d:\d\d";
                //            ((DateEdit)controlItem).Properties.MaskData.MaskType = MaskType.Regular;
                //        }
                //        ((DateEdit)controlItem).Properties.DateOnError = DateOnError.NullDate;
                //    }
                //    if (controlItem is BaseEdit)
                //    {
                //        controlItem.KeyDown -= new KeyEventHandler(this.OnControlItemKeyUp);
                //        controlItem.KeyDown += new KeyEventHandler(this.OnControlItemKeyUp);
                //    }
                //    if (controlItem.GetType().Name != "CheckEdit")
                //    {
                //        controlItem.GotFocus -= new EventHandler(this.OnControlEnter);
                //        controlItem.LostFocus -= new EventHandler(this.OnControlLeave);
                //        controlItem.GotFocus += new EventHandler(this.OnControlEnter);
                //        controlItem.LostFocus += new EventHandler(this.OnControlLeave);
                //    }
                //}
                //this.RegisterKey(controlItem);
            }
        }


        public void InitialCardStyle(RadGridView Card)
        {
            DataTable defaultStyle = SetGridStyleForm1.GetDefaultStyleDataTable(Card);
            if (defaultStyle != null)
            {
                TelerikControls.SetGridStyle(Card, defaultStyle);
            }
        }
        private void BaseBlankForm_Load(object sender, EventArgs e)
        {
                this.Icon = new Icon(this.SYSTEM_ICON);
         
        }
    }
}

