namespace JKR.GUI.BaseForm
{
    partial class BasePopupEditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BasePopupEditForm));
            this.btnCancel = new Telerik.WinControls.UI.RadButton();
            this.btnOK = new Telerik.WinControls.UI.RadButton();
            this.gbxGeneral = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOK)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.Name = "btnCancel";
            // 
            // btnOK
            // 
            resources.ApplyResources(this.btnOK, "btnOK");
            this.btnOK.Name = "btnOK";
            // 
            // 
            // 
            this.btnOK.RootElement.Alignment = ((System.Drawing.ContentAlignment)(resources.GetObject("radButton2.RootElement.Alignment")));
            this.btnOK.RootElement.AngleTransform = ((float)(resources.GetObject("radButton2.RootElement.AngleTransform")));
            this.btnOK.RootElement.FlipText = ((bool)(resources.GetObject("radButton2.RootElement.FlipText")));
            this.btnOK.RootElement.Margin = ((System.Windows.Forms.Padding)(resources.GetObject("radButton2.RootElement.Margin")));
            this.btnOK.RootElement.Padding = ((System.Windows.Forms.Padding)(resources.GetObject("radButton2.RootElement.Padding")));
            this.btnOK.RootElement.Text = resources.GetString("radButton2.RootElement.Text");
            this.btnOK.RootElement.TextOrientation = ((System.Windows.Forms.Orientation)(resources.GetObject("radButton2.RootElement.TextOrientation")));
            // 
            // gbxGeneral
            // 
            resources.ApplyResources(this.gbxGeneral, "gbxGeneral");
            this.gbxGeneral.Name = "gbxGeneral";
            this.gbxGeneral.TabStop = false;
            // 
            // BasePopupEditForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.gbxGeneral);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BasePopupEditForm";
            this.ShowInTaskbar = false;
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOK)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadButton btnCancel;
        private Telerik.WinControls.UI.RadButton btnOK;
        public System.Windows.Forms.GroupBox gbxGeneral;
    }
}