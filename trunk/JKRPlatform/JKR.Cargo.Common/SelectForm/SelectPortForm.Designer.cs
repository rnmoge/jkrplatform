namespace JKR.Cargo.Common.SelectForm
{
    partial class SelectPortForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectPortForm));
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn16 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn17 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn18 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            this.rgSelect = new Telerik.WinControls.UI.RadRadioButton();
            this.rgSelect1 = new Telerik.WinControls.UI.RadRadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.edtKeyWord = new Telerik.WinControls.UI.RadTextBox();
            this.btnSESearch = new Telerik.WinControls.UI.RadButton();
            this.grdMain = new Telerik.WinControls.UI.RadGridView();
            this.btnOK = new Telerik.WinControls.UI.RadButton();
            this.btnCancel = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.rgSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgSelect1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtKeyWord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSESearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).BeginInit();
            this.SuspendLayout();
            // 
            // rgSelect
            // 
            this.rgSelect.BackColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.rgSelect, "rgSelect");
            this.rgSelect.ForeColor = System.Drawing.SystemColors.WindowText;
            this.rgSelect.Name = "rgSelect";
            // 
            // 
            // 
            this.rgSelect.RootElement.ForeColor = System.Drawing.SystemColors.WindowText;
            this.rgSelect.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            // 
            // rgSelect1
            // 
            this.rgSelect1.BackColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.rgSelect1, "rgSelect1");
            this.rgSelect1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.rgSelect1.Name = "rgSelect1";
            // 
            // 
            // 
            this.rgSelect1.RootElement.Alignment = ((System.Drawing.ContentAlignment)(resources.GetObject("radRadioButton2.RootElement.Alignment")));
            this.rgSelect1.RootElement.AngleTransform = ((float)(resources.GetObject("radRadioButton2.RootElement.AngleTransform")));
            this.rgSelect1.RootElement.FlipText = ((bool)(resources.GetObject("radRadioButton2.RootElement.FlipText")));
            this.rgSelect1.RootElement.ForeColor = System.Drawing.SystemColors.WindowText;
            this.rgSelect1.RootElement.Margin = ((System.Windows.Forms.Padding)(resources.GetObject("radRadioButton2.RootElement.Margin")));
            this.rgSelect1.RootElement.Padding = ((System.Windows.Forms.Padding)(resources.GetObject("radRadioButton2.RootElement.Padding")));
            this.rgSelect1.RootElement.Text = resources.GetString("radRadioButton2.RootElement.Text");
            this.rgSelect1.RootElement.TextOrientation = ((System.Windows.Forms.Orientation)(resources.GetObject("radRadioButton2.RootElement.TextOrientation")));
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // edtKeyWord
            // 
            this.edtKeyWord.BackColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.edtKeyWord, "edtKeyWord");
            this.edtKeyWord.ForeColor = System.Drawing.SystemColors.WindowText;
            this.edtKeyWord.Name = "edtKeyWord";
            // 
            // 
            // 
            this.edtKeyWord.RootElement.ForeColor = System.Drawing.SystemColors.WindowText;
            this.edtKeyWord.TabStop = false;
            this.edtKeyWord.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.edtKeyWord_KeyPress);
            // 
            // btnSESearch
            // 
            resources.ApplyResources(this.btnSESearch, "btnSESearch");
            this.btnSESearch.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSESearch.Name = "btnSESearch";
            this.btnSESearch.Click += new System.EventHandler(this.btnSESearch_Click);
            // 
            // grdMain
            // 
            resources.ApplyResources(this.grdMain, "grdMain");
            // 
            // grdMain
            // 
            this.grdMain.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            resources.ApplyResources(gridViewTextBoxColumn16, "gridViewTextBoxColumn16");
            gridViewTextBoxColumn16.Name = "column1";
            gridViewTextBoxColumn16.Width = 133;
            resources.ApplyResources(gridViewTextBoxColumn17, "gridViewTextBoxColumn17");
            gridViewTextBoxColumn17.Name = "column2";
            gridViewTextBoxColumn17.Width = 133;
            resources.ApplyResources(gridViewTextBoxColumn18, "gridViewTextBoxColumn18");
            gridViewTextBoxColumn18.Name = "column3";
            gridViewTextBoxColumn18.Width = 132;
            this.grdMain.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn16,
            gridViewTextBoxColumn17,
            gridViewTextBoxColumn18});
            this.grdMain.Name = "grdMain";
            // 
            // 
            // 
            this.grdMain.RootElement.Alignment = ((System.Drawing.ContentAlignment)(resources.GetObject("radGridView1.RootElement.Alignment")));
            this.grdMain.RootElement.AngleTransform = ((float)(resources.GetObject("radGridView1.RootElement.AngleTransform")));
            this.grdMain.RootElement.FlipText = ((bool)(resources.GetObject("radGridView1.RootElement.FlipText")));
            this.grdMain.RootElement.Margin = ((System.Windows.Forms.Padding)(resources.GetObject("radGridView1.RootElement.Margin")));
            this.grdMain.RootElement.Padding = ((System.Windows.Forms.Padding)(resources.GetObject("radGridView1.RootElement.Padding")));
            this.grdMain.RootElement.Text = resources.GetString("radGridView1.RootElement.Text");
            this.grdMain.RootElement.TextOrientation = ((System.Windows.Forms.Orientation)(resources.GetObject("radGridView1.RootElement.TextOrientation")));
            this.grdMain.DoubleClick += new System.EventHandler(this.grdMain_DoubleClick);
            // 
            // btnOK
            // 
            resources.ApplyResources(this.btnOK, "btnOK");
            this.btnOK.Name = "btnOK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // SelectPortForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.CancelButton = this.btnCancel;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.grdMain);
            this.Controls.Add(this.btnSESearch);
            this.Controls.Add(this.edtKeyWord);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rgSelect1);
            this.Controls.Add(this.rgSelect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectPortForm";
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.SelectPortForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rgSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgSelect1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtKeyWord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSESearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadRadioButton rgSelect;
        private Telerik.WinControls.UI.RadRadioButton rgSelect1;
        private Telerik.WinControls.UI.RadTextBox edtKeyWord;
        private Telerik.WinControls.UI.RadGridView grdMain;
        internal Telerik.WinControls.UI.RadButton btnOK;
        internal Telerik.WinControls.UI.RadButton btnCancel;
        internal System.Windows.Forms.Label label1;
        internal Telerik.WinControls.UI.RadButton btnSESearch;

    }
}