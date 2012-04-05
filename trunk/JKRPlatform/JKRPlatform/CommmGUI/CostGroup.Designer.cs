namespace JKRPlatform.CommmGUI
{
    partial class CostGroup
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
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn1 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            this.edtGROUP_CODE = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.chkShowSelectCharges = new Telerik.WinControls.UI.RadCheckBox();
            this.btnOK = new Telerik.WinControls.UI.RadButton();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.edtGROUP_NAME = new Telerik.WinControls.UI.RadTextBox();
            this.btnCancel = new Telerik.WinControls.UI.RadButton();
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.edtGROUP_CODE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkShowSelectCharges)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtGROUP_NAME)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // edtGROUP_CODE
            // 
            this.edtGROUP_CODE.Location = new System.Drawing.Point(136, 12);
            this.edtGROUP_CODE.Name = "edtGROUP_CODE";
            this.edtGROUP_CODE.Size = new System.Drawing.Size(158, 20);
            this.edtGROUP_CODE.TabIndex = 1;
            this.edtGROUP_CODE.TabStop = false;
            // 
            // radLabel1
            // 
            this.radLabel1.ForeColor = System.Drawing.Color.Blue;
            this.radLabel1.Location = new System.Drawing.Point(12, 15);
            this.radLabel1.Name = "radLabel1";
            // 
            // 
            // 
            this.radLabel1.RootElement.ForeColor = System.Drawing.Color.Blue;
            this.radLabel1.Size = new System.Drawing.Size(44, 17);
            this.radLabel1.TabIndex = 1;
            this.radLabel1.Text = "组代码";
            // 
            // chkShowSelectCharges
            // 
            this.chkShowSelectCharges.Location = new System.Drawing.Point(401, 41);
            this.chkShowSelectCharges.Name = "chkShowSelectCharges";
            this.chkShowSelectCharges.Size = new System.Drawing.Size(145, 18);
            this.chkShowSelectCharges.TabIndex = 3;
            this.chkShowSelectCharges.Text = "仅显示选择的费用种类";
            this.chkShowSelectCharges.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(380, 285);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(80, 20);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "确定(&O)";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // radLabel2
            // 
            this.radLabel2.ForeColor = System.Drawing.Color.Blue;
            this.radLabel2.Location = new System.Drawing.Point(12, 41);
            this.radLabel2.Name = "radLabel2";
            // 
            // 
            // 
            this.radLabel2.RootElement.ForeColor = System.Drawing.Color.Blue;
            this.radLabel2.Size = new System.Drawing.Size(68, 17);
            this.radLabel2.TabIndex = 2;
            this.radLabel2.Text = "费用组描述";
            // 
            // edtGROUP_NAME
            // 
            this.edtGROUP_NAME.Location = new System.Drawing.Point(136, 38);
            this.edtGROUP_NAME.Name = "edtGROUP_NAME";
            this.edtGROUP_NAME.Size = new System.Drawing.Size(255, 20);
            this.edtGROUP_NAME.TabIndex = 2;
            this.edtGROUP_NAME.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(466, 285);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 20);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "取消(&C)";
            this.btnCancel.Click += new System.EventHandler(this.radButton2_Click);
            // 
            // radGridView1
            // 
            this.radGridView1.Location = new System.Drawing.Point(13, 65);
            // 
            // radGridView1
            // 
            this.radGridView1.MasterTemplate.AllowAddNewRow = false;
            gridViewCheckBoxColumn1.HeaderText = "选";
            gridViewCheckBoxColumn1.Name = "column5";
            gridViewTextBoxColumn1.HeaderText = "费用种类";
            gridViewTextBoxColumn1.Name = "column2";
            gridViewTextBoxColumn1.Width = 100;
            gridViewTextBoxColumn2.HeaderText = "费用名称";
            gridViewTextBoxColumn2.Name = "column3";
            gridViewTextBoxColumn2.Width = 100;
            gridViewTextBoxColumn3.HeaderText = "费用中文名";
            gridViewTextBoxColumn3.Name = "column4";
            gridViewTextBoxColumn3.Width = 200;
            this.radGridView1.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewCheckBoxColumn1,
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3});
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.radGridView1.ReadOnly = true;
            // 
            // 
            // 
            this.radGridView1.RootElement.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.radGridView1.Size = new System.Drawing.Size(533, 214);
            this.radGridView1.TabIndex = 5;
            this.radGridView1.Text = "radGridView1";
            // 
            // CostGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 317);
            this.Controls.Add(this.radGridView1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.edtGROUP_NAME);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.chkShowSelectCharges);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.edtGROUP_CODE);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CostGroup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "费用组";
            ((System.ComponentModel.ISupportInitialize)(this.edtGROUP_CODE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkShowSelectCharges)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtGROUP_NAME)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadTextBox edtGROUP_CODE;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadCheckBox chkShowSelectCharges;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadTextBox edtGROUP_NAME;
        private Telerik.WinControls.UI.RadButton btnCancel;
        private Telerik.WinControls.UI.RadGridView radGridView1;
        private Telerik.WinControls.UI.RadButton btnOK;
    }
}