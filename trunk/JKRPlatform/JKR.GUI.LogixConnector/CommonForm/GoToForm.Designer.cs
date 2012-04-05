namespace JKR.GUI.LogixConnector.CommonForm
{
    partial class GoToForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GoToForm));
            this.lbNo = new System.Windows.Forms.Label();
            this.edtNo = new Telerik.WinControls.UI.RadTextBox();
            this.btnOK = new Telerik.WinControls.UI.RadButton();
            this.btnCancel = new Telerik.WinControls.UI.RadButton();
            this.ImageCommonList = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.edtNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).BeginInit();
            this.SuspendLayout();
            // 
            // lbNo
            // 
            resources.ApplyResources(this.lbNo, "lbNo");
            this.lbNo.Name = "lbNo";
            // 
            // edtNo
            // 
            resources.ApplyResources(this.edtNo, "edtNo");
            this.edtNo.Name = "edtNo";
            this.edtNo.TabStop = false;
            this.edtNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.edtNo_KeyDown);
            // 
            // btnOK
            // 
            resources.ApplyResources(this.btnOK, "btnOK");
            this.btnOK.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnOK.Name = "btnOK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCancel.Name = "btnCancel";
            // 
            // ImageCommonList
            // 
            this.ImageCommonList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            resources.ApplyResources(this.ImageCommonList, "ImageCommonList");
            this.ImageCommonList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // GoToForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.edtNo);
            this.Controls.Add(this.lbNo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GoToForm";
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.GoToForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.edtNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label lbNo;
        internal Telerik.WinControls.UI.RadTextBox edtNo;
        internal Telerik.WinControls.UI.RadButton btnOK;
        internal Telerik.WinControls.UI.RadButton btnCancel;
        protected System.Windows.Forms.ImageList ImageCommonList;
    }
}