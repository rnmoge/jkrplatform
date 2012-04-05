using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
//using Crownwood.Magic.Common;
//using Crownwood.Magic.Controls;
using System.Windows.Forms;

namespace JKR.GUI.Command
{
    [ToolboxBitmap(typeof(CommandFrame))]
    [DefaultProperty("Profile")]

    public partial class CommandFrame : UserControl
    {

        protected string _commandCode; //本功能对应的命令代码
        protected string _commandDescription;       //本功能对应的命令描述

        protected CommandPage _selectedPage;

        protected CommandPageCollection _commandPages;

        protected Crownwood.Magic.Controls.TabControl _tabControl;
        protected System.ComponentModel.Container components = null;


        public delegate void CommandFrameHandler(CommandPage wp, CommandFrame wc);


        public CommandFrame()
        {
            InitializeComponent();


            _selectedPage = null;


            _commandPages = new CommandPageCollection();


            _commandPages.Cleared += new Crownwood.Magic.Collections.CollectionClear(OnCommandCleared);
            _commandPages.Inserted += new Crownwood.Magic.Collections.CollectionChange(OnCommandInserted);
            _commandPages.Removed += new Crownwood.Magic.Collections.CollectionChange(OnCommandRemoved);


            ResetCommandDescription();
            ResetCommandCode();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code
        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._tabControl = new Crownwood.Magic.Controls.TabControl();
            this.SuspendLayout();
            // 
            // _tabControl
            // 
            this._tabControl.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(149)), ((System.Byte)(178)), ((System.Byte)(195)));
            this._tabControl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this._tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this._tabControl.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this._tabControl.HideTabsMode = Crownwood.Magic.Controls.TabControl.HideTabsModes.HideAlways;
            this._tabControl.IDEPixelArea = true;
            this._tabControl.Location = new System.Drawing.Point(0, 0);
            this._tabControl.Name = "_tabControl";
            this._tabControl.Size = new System.Drawing.Size(752, 374);
            this._tabControl.TabIndex = 1;
            // 
            // CommandFrame
            // 
            this.Controls.Add(this._tabControl);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.Name = "CommandFrame";
            this.Size = new System.Drawing.Size(752, 374);
            this.ResumeLayout(false);

        }
        #endregion

        [Category("Command")]
        [Description("Collection of Command pages")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public CommandPageCollection CommandPages
        {
            get { return _commandPages; }
        }

        [Category("Command")]
        [Description("Command Code")]
        [Localizable(true)]
        public string CommandCode
        {
            get { return _commandCode; }
            set
            {
                _commandCode = value;
            }
        }


        [Category("Command")]
        [Description("Command Description")]
        [Localizable(true)]
        public string CommandDescription
        {
            get { return _commandDescription; }

            set
            {
                _commandDescription = value;
            }
        }

        public void ResetCommandDescription()
        {
            CommandDescription = "Command Description";
        }

        public void ResetCommandCode()
        {
            CommandDescription = "0000";
        }


        [Category("Command")]
        [Description("Index of currently selected CommandPage")]
        public int SelectedIndex
        {
            get { return _tabControl.SelectedIndex; }
            set { _tabControl.SelectedIndex = value; }
        }

        protected void OnTabSelectionChanged(object sender, EventArgs e)
        {
            if (_tabControl.SelectedIndex != -1)
                _selectedPage = _commandPages[_tabControl.SelectedIndex] as CommandPage;
        }

        protected override void OnResize(EventArgs e)
        {
            this.PerformLayout();
        }

        protected void OnCommandCleared()
        {
            _tabControl.TabPages.Clear();
        }

        protected void OnCommandInserted(int index, object value)
        {
            CommandPage wp = value as CommandPage;

            _tabControl.TabPages.Insert(index, wp);
        }

        protected void OnCommandRemoved(int index, object value)
        {
            CommandPage wp = _tabControl.TabPages[index] as CommandPage;

            //			// Unhook from event handlers

            // Reflect change on underlying tab control
            _tabControl.TabPages.RemoveAt(index);
        }
    }
}
