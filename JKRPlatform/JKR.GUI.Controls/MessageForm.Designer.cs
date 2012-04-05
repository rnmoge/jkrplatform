namespace JKR.GUI.Controls
{
    partial class MessageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageForm));
            this.picIco = new System.Windows.Forms.PictureBox();
            this.msgContent = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnNo = new Telerik.WinControls.UI.RadButton();
            this.btnYes = new Telerik.WinControls.UI.RadButton();
            this.btnExpend = new Telerik.WinControls.UI.RadButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.imgIcons = new System.Windows.Forms.ImageList(this.components);
            this.edtDemo = new Telerik.WinControls.UI.RadTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picIco)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnYes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExpend)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edtDemo)).BeginInit();
            this.SuspendLayout();
            // 
            // picIco
            // 
            resources.ApplyResources(this.picIco, "picIco");
            this.picIco.Name = "picIco";
            this.picIco.TabStop = false;
            // 
            // msgContent
            // 
            resources.ApplyResources(this.msgContent, "msgContent");
            this.msgContent.Name = "msgContent";
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnNo);
            this.panel3.Controls.Add(this.btnYes);
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Controls.Add(this.btnExpend);
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // btnNo
            // 
            resources.ApplyResources(this.btnNo, "btnNo");
            this.btnNo.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btnNo.Name = "btnNo";
            // 
            // 
            // 
            this.btnNo.RootElement.Alignment = ((System.Drawing.ContentAlignment)(resources.GetObject("btnNo.RootElement.Alignment")));
            this.btnNo.RootElement.AngleTransform = ((float)(resources.GetObject("btnNo.RootElement.AngleTransform")));
            this.btnNo.RootElement.FlipText = ((bool)(resources.GetObject("btnNo.RootElement.FlipText")));
            this.btnNo.RootElement.Margin = ((System.Windows.Forms.Padding)(resources.GetObject("btnNo.RootElement.Margin")));
            this.btnNo.RootElement.Padding = ((System.Windows.Forms.Padding)(resources.GetObject("btnNo.RootElement.Padding")));
            this.btnNo.RootElement.Text = resources.GetString("btnNo.RootElement.Text");
            this.btnNo.RootElement.TextOrientation = ((System.Windows.Forms.Orientation)(resources.GetObject("btnNo.RootElement.TextOrientation")));
            // 
            // btnYes
            // 
            resources.ApplyResources(this.btnYes, "btnYes");
            this.btnYes.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnYes.Name = "btnYes";
            // 
            // btnExpend
            // 
            resources.ApplyResources(this.btnExpend, "btnExpend");
            this.btnExpend.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnExpend.Name = "btnExpend";
            this.btnExpend.Click += new System.EventHandler(this.btnExpend_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.picIco);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // imgIcons
            // 
            this.imgIcons.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            resources.ApplyResources(this.imgIcons, "imgIcons");
            this.imgIcons.TransparentColor = System.Drawing.SystemColors.ActiveBorder;     
            // 
            // edtDemo
            // 
            this.edtDemo.BackColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.edtDemo, "edtDemo");
            this.edtDemo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.edtDemo.Name = "edtDemo";
            // 
            // 
            // 
            this.edtDemo.RootElement.Alignment = ((System.Drawing.ContentAlignment)(resources.GetObject("radTextBox1.RootElement.Alignment")));
            this.edtDemo.RootElement.AngleTransform = ((float)(resources.GetObject("radTextBox1.RootElement.AngleTransform")));
            this.edtDemo.RootElement.FlipText = ((bool)(resources.GetObject("radTextBox1.RootElement.FlipText")));
            this.edtDemo.RootElement.ForeColor = System.Drawing.SystemColors.WindowText;
            this.edtDemo.RootElement.Margin = ((System.Windows.Forms.Padding)(resources.GetObject("radTextBox1.RootElement.Margin")));
            this.edtDemo.RootElement.Padding = ((System.Windows.Forms.Padding)(resources.GetObject("radTextBox1.RootElement.Padding")));
            this.edtDemo.RootElement.Text = resources.GetString("radTextBox1.RootElement.Text");
            this.edtDemo.RootElement.TextOrientation = ((System.Windows.Forms.Orientation)(resources.GetObject("radTextBox1.RootElement.TextOrientation")));
            this.edtDemo.TabStop = false;
            // 
            // MessageForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            resources.ApplyResources(this, "$this");
            this.ControlBox = false;
            this.Controls.Add(this.edtDemo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.msgContent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MessageForm";
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.MessageForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picIco)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnYes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExpend)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.edtDemo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.PictureBox picIco;
        internal System.Windows.Forms.Label msgContent;
        internal System.Windows.Forms.GroupBox groupBox1;
        internal System.Windows.Forms.Panel panel3;
        internal Telerik.WinControls.UI.RadButton btnNo;
        internal Telerik.WinControls.UI.RadButton btnYes;
        internal Telerik.WinControls.UI.RadButton btnExpend;
        internal System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.ImageList imgIcons;
        internal Telerik.WinControls.UI.RadTextBox edtDemo;
    }
}