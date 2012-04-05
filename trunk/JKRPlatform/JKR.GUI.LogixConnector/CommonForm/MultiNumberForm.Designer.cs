namespace JKR.GUI.LogixConnector.CommonForm
{
    partial class MultiNumberForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MultiNumberForm));
            this.gbxGeneral = new System.Windows.Forms.GroupBox();
            this.edtMultiNumber = new Telerik.WinControls.UI.RadTextBox();
            this.btnLoadFromFile = new Telerik.WinControls.UI.RadButton();
            this.btnOK = new Telerik.WinControls.UI.RadButton();
            this.btnCancel = new Telerik.WinControls.UI.RadButton();
            this.ImageCommonList = new System.Windows.Forms.ImageList(this.components);
            this.gbxGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edtMultiNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLoadFromFile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxGeneral
            // 
            resources.ApplyResources(this.gbxGeneral, "gbxGeneral");
            this.gbxGeneral.Controls.Add(this.edtMultiNumber);
            this.gbxGeneral.Name = "gbxGeneral";
            this.gbxGeneral.TabStop = false;
            // 
            // edtMultiNumber
            // 
            resources.ApplyResources(this.edtMultiNumber, "edtMultiNumber");
            this.edtMultiNumber.BackColor = System.Drawing.SystemColors.Window;
            this.edtMultiNumber.Multiline = true;
            this.edtMultiNumber.Name = "edtMultiNumber";
            // 
            // 
            // 
            this.edtMultiNumber.RootElement.StretchVertically = true;
            this.edtMultiNumber.TabStop = false;
            // 
            // btnLoadFromFile
            // 
            resources.ApplyResources(this.btnLoadFromFile, "btnLoadFromFile");
            this.btnLoadFromFile.Name = "btnLoadFromFile";
            this.btnLoadFromFile.Click += new System.EventHandler(this.btnLoadFromFile_Click);
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
            this.btnCancel.Name = "btnCancel";
            // 
            // 
            // 
            this.btnCancel.RootElement.Alignment = ((System.Drawing.ContentAlignment)(resources.GetObject("radButton3.RootElement.Alignment")));
            this.btnCancel.RootElement.AngleTransform = ((float)(resources.GetObject("radButton3.RootElement.AngleTransform")));
            this.btnCancel.RootElement.FlipText = ((bool)(resources.GetObject("radButton3.RootElement.FlipText")));
            this.btnCancel.RootElement.Margin = ((System.Windows.Forms.Padding)(resources.GetObject("radButton3.RootElement.Margin")));
            this.btnCancel.RootElement.Padding = ((System.Windows.Forms.Padding)(resources.GetObject("radButton3.RootElement.Padding")));
            this.btnCancel.RootElement.Text = resources.GetString("radButton3.RootElement.Text");
            this.btnCancel.RootElement.TextOrientation = ((System.Windows.Forms.Orientation)(resources.GetObject("radButton3.RootElement.TextOrientation")));
            // 
            // ImageCommonList
            // 
            this.ImageCommonList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            resources.ApplyResources(this.ImageCommonList, "ImageCommonList");
            this.ImageCommonList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // MultiNumberForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnLoadFromFile);
            this.Controls.Add(this.gbxGeneral);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MultiNumberForm";
            this.ShowInTaskbar = false;
            this.gbxGeneral.ResumeLayout(false);
            this.gbxGeneral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edtMultiNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLoadFromFile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox gbxGeneral;
        internal Telerik.WinControls.UI.RadButton btnLoadFromFile;
        internal Telerik.WinControls.UI.RadButton btnOK;
        internal Telerik.WinControls.UI.RadTextBox edtMultiNumber;
        internal Telerik.WinControls.UI.RadButton btnCancel;
        protected System.Windows.Forms.ImageList ImageCommonList;
    }
}