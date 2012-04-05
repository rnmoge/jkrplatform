namespace JKRPlatform.CommmGUI
{
    partial class ExchangeRateCopyForm
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
            this.chkOnlySelected = new Telerik.WinControls.UI.RadRadioButton();
            this.chkAll = new Telerik.WinControls.UI.RadRadioButton();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.edtPARENT_COMPANY_CODE = new Telerik.WinControls.UI.RadDropDownList();
            this.chkSubOfficeToo = new Telerik.WinControls.UI.RadCheckBox();
            this.btnOK = new Telerik.WinControls.UI.RadButton();
            this.btnCancel = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.chkOnlySelected)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtPARENT_COMPANY_CODE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSubOfficeToo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).BeginInit();
            this.SuspendLayout();
            // 
            // chkOnlySelected
            // 
            this.chkOnlySelected.Location = new System.Drawing.Point(13, 13);
            this.chkOnlySelected.Name = "chkOnlySelected";
            this.chkOnlySelected.Size = new System.Drawing.Size(110, 18);
            this.chkOnlySelected.TabIndex = 0;
            this.chkOnlySelected.Text = "仅选定汇率";
            this.chkOnlySelected.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            // 
            // chkAll
            // 
            this.chkAll.Location = new System.Drawing.Point(13, 37);
            this.chkAll.Name = "chkAll";
            this.chkAll.Size = new System.Drawing.Size(156, 18);
            this.chkAll.TabIndex = 1;
            this.chkAll.Text = "选定分公司所有有效汇率";
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(13, 62);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(44, 17);
            this.radLabel1.TabIndex = 2;
            this.radLabel1.Text = "复制到";
            // 
            // edtPARENT_COMPANY_CODE
            // 
            this.edtPARENT_COMPANY_CODE.FilterExpression = null;
            this.edtPARENT_COMPANY_CODE.Location = new System.Drawing.Point(99, 59);
            this.edtPARENT_COMPANY_CODE.Name = "edtPARENT_COMPANY_CODE";
            this.edtPARENT_COMPANY_CODE.Size = new System.Drawing.Size(164, 20);
            this.edtPARENT_COMPANY_CODE.TabIndex = 3;
            // 
            // chkSubOfficeToo
            // 
            this.chkSubOfficeToo.Location = new System.Drawing.Point(13, 86);
            this.chkSubOfficeToo.Name = "chkSubOfficeToo";
            this.chkSubOfficeToo.Size = new System.Drawing.Size(120, 18);
            this.chkSubOfficeToo.TabIndex = 4;
            this.chkSubOfficeToo.Text = "生成到下属分公司";
            this.chkSubOfficeToo.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(96, 132);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(89, 24);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "确定(&O)";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(191, 132);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(89, 24);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "取消(&C)";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ExchangeRateCopyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 163);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.chkSubOfficeToo);
            this.Controls.Add(this.edtPARENT_COMPANY_CODE);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.chkAll);
            this.Controls.Add(this.chkOnlySelected);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ExchangeRateCopyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "复制汇率";
            ((System.ComponentModel.ISupportInitialize)(this.chkOnlySelected)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtPARENT_COMPANY_CODE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSubOfficeToo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadRadioButton chkOnlySelected;
        private Telerik.WinControls.UI.RadRadioButton chkAll;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadDropDownList edtPARENT_COMPANY_CODE;
        private Telerik.WinControls.UI.RadCheckBox chkSubOfficeToo;
        private Telerik.WinControls.UI.RadButton btnOK;
        private Telerik.WinControls.UI.RadButton btnCancel;
    }
}