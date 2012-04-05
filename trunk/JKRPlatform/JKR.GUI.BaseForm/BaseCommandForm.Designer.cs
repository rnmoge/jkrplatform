namespace JKR.GUI.BaseForm
{
    partial class BaseCommandForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseCommandForm));
            this.ImageCommonList = new System.Windows.Forms.ImageList(this.components);
            this.pmGridControl = new System.Windows.Forms.ContextMenu(this.components);
            this.SuspendLayout();
            // 
            // ImageCommonList
            // 
            this.ImageCommonList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            resources.ApplyResources(this.ImageCommonList, "ImageCommonList");
            this.ImageCommonList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pmGridControl
            // 
            this.pmGridControl.Name = "pmGridControl";
            resources.ApplyResources(this.pmGridControl, "pmGridControl");
            // 
            // BaseCommandForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            resources.ApplyResources(this, "$this");
            this.Name = "BaseCommandForm";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel pnlButton;
        public JKR.GUI.Command.CommandFrame cmdMain;
        public System.Windows.Forms.ContextMenu pmGridControl;
        protected System.Windows.Forms.ImageList ImageCommonList;

    }
}