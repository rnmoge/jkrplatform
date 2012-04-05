namespace JKRPlatform.CommmGUI
{
    partial class AccountBLAddressEdit
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            this.grdBLADDRESS = new Telerik.WinControls.UI.RadGridView();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.btnNew = new Telerik.WinControls.UI.RadButton();
            this.edtBL_ADDRESS_LINE1 = new Telerik.WinControls.UI.RadTextBox();
            this.btnDelete = new Telerik.WinControls.UI.RadButton();
            this.btnEsc = new Telerik.WinControls.UI.RadButton();
            this.edtBL_ADDRESS_LINE2 = new Telerik.WinControls.UI.RadTextBox();
            this.edtBL_ADDRESS_LINE3 = new Telerik.WinControls.UI.RadTextBox();
            this.edtBL_ADDRESS_LINE4 = new Telerik.WinControls.UI.RadTextBox();
            this.edtBL_ADDRESS_LINE5 = new Telerik.WinControls.UI.RadTextBox();
            this.edtBL_ADDRESS_LINE6 = new Telerik.WinControls.UI.RadTextBox();
            this.edtBL_ADDRESS = new Telerik.WinControls.UI.RadTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdBLADDRESS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtBL_ADDRESS_LINE1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEsc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtBL_ADDRESS_LINE2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtBL_ADDRESS_LINE3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtBL_ADDRESS_LINE4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtBL_ADDRESS_LINE5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtBL_ADDRESS_LINE6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtBL_ADDRESS)).BeginInit();
            this.SuspendLayout();
            // 
            // grdBLADDRESS
            // 
            this.grdBLADDRESS.Location = new System.Drawing.Point(13, 13);
            // 
            // grdBLADDRESS
            // 
            this.grdBLADDRESS.MasterTemplate.AllowAddNewRow = false;
            gridViewTextBoxColumn4.HeaderText = "提单地址一";
            gridViewTextBoxColumn4.Name = "column1";
            this.grdBLADDRESS.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn4});
            this.grdBLADDRESS.Name = "grdBLADDRESS";
            this.grdBLADDRESS.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.grdBLADDRESS.ReadOnly = true;
            this.grdBLADDRESS.Size = new System.Drawing.Size(240, 173);
            this.grdBLADDRESS.TabIndex = 0;
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(197, 192);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(56, 17);
            this.radLabel1.TabIndex = 1;
            this.radLabel1.Text = "寄单地址";
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(259, 12);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(56, 17);
            this.radLabel2.TabIndex = 2;
            this.radLabel2.Text = "提单地址";
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(329, 218);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(65, 24);
            this.btnNew.TabIndex = 3;
            this.btnNew.Text = "新增(&N)";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // edtBL_ADDRESS_LINE1
            // 
            this.edtBL_ADDRESS_LINE1.Location = new System.Drawing.Point(259, 36);
            this.edtBL_ADDRESS_LINE1.Name = "edtBL_ADDRESS_LINE1";
            this.edtBL_ADDRESS_LINE1.Size = new System.Drawing.Size(277, 20);
            this.edtBL_ADDRESS_LINE1.TabIndex = 4;
            this.edtBL_ADDRESS_LINE1.TabStop = false;
            this.edtBL_ADDRESS_LINE1.Tag = "D_ACCOUNTS_BL_ADDRESS.BL_ADDRESS_LINE1";
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(400, 218);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(65, 24);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "删除(&D)";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEsc
            // 
            this.btnEsc.Enabled = false;
            this.btnEsc.Location = new System.Drawing.Point(471, 218);
            this.btnEsc.Name = "btnEsc";
            this.btnEsc.Size = new System.Drawing.Size(65, 24);
            this.btnEsc.TabIndex = 6;
            this.btnEsc.Text = "确定(&C)";
            this.btnEsc.Click += new System.EventHandler(this.btnEsc_Click);
            // 
            // edtBL_ADDRESS_LINE2
            // 
            this.edtBL_ADDRESS_LINE2.Location = new System.Drawing.Point(259, 62);
            this.edtBL_ADDRESS_LINE2.Name = "edtBL_ADDRESS_LINE2";
            this.edtBL_ADDRESS_LINE2.Size = new System.Drawing.Size(277, 20);
            this.edtBL_ADDRESS_LINE2.TabIndex = 7;
            this.edtBL_ADDRESS_LINE2.TabStop = false;
            this.edtBL_ADDRESS_LINE2.Tag = "D_ACCOUNTS_BL_ADDRESS.BL_ADDRESS_LINE2";
            // 
            // edtBL_ADDRESS_LINE3
            // 
            this.edtBL_ADDRESS_LINE3.Location = new System.Drawing.Point(259, 88);
            this.edtBL_ADDRESS_LINE3.Name = "edtBL_ADDRESS_LINE3";
            this.edtBL_ADDRESS_LINE3.Size = new System.Drawing.Size(277, 20);
            this.edtBL_ADDRESS_LINE3.TabIndex = 5;
            this.edtBL_ADDRESS_LINE3.TabStop = false;
            this.edtBL_ADDRESS_LINE3.Tag = "D_ACCOUNTS_BL_ADDRESS.BL_ADDRESS_LINE3";
            // 
            // edtBL_ADDRESS_LINE4
            // 
            this.edtBL_ADDRESS_LINE4.Location = new System.Drawing.Point(259, 114);
            this.edtBL_ADDRESS_LINE4.Name = "edtBL_ADDRESS_LINE4";
            this.edtBL_ADDRESS_LINE4.Size = new System.Drawing.Size(277, 20);
            this.edtBL_ADDRESS_LINE4.TabIndex = 5;
            this.edtBL_ADDRESS_LINE4.TabStop = false;
            this.edtBL_ADDRESS_LINE4.Tag = "D_ACCOUNTS_BL_ADDRESS.BL_ADDRESS_LINE4";
            // 
            // edtBL_ADDRESS_LINE5
            // 
            this.edtBL_ADDRESS_LINE5.Location = new System.Drawing.Point(259, 140);
            this.edtBL_ADDRESS_LINE5.Name = "edtBL_ADDRESS_LINE5";
            this.edtBL_ADDRESS_LINE5.Size = new System.Drawing.Size(277, 20);
            this.edtBL_ADDRESS_LINE5.TabIndex = 5;
            this.edtBL_ADDRESS_LINE5.TabStop = false;
            this.edtBL_ADDRESS_LINE5.Tag = "D_ACCOUNTS_BL_ADDRESS.BL_ADDRESS_LINE5";
            // 
            // edtBL_ADDRESS_LINE6
            // 
            this.edtBL_ADDRESS_LINE6.Location = new System.Drawing.Point(259, 166);
            this.edtBL_ADDRESS_LINE6.Name = "edtBL_ADDRESS_LINE6";
            this.edtBL_ADDRESS_LINE6.Size = new System.Drawing.Size(277, 20);
            this.edtBL_ADDRESS_LINE6.TabIndex = 5;
            this.edtBL_ADDRESS_LINE6.TabStop = false;
            this.edtBL_ADDRESS_LINE6.Tag = "D_ACCOUNTS_BL_ADDRESS.BL_ADDRESS_LINE6";
            // 
            // edtBL_ADDRESS
            // 
            this.edtBL_ADDRESS.Location = new System.Drawing.Point(259, 192);
            this.edtBL_ADDRESS.Name = "edtBL_ADDRESS";
            this.edtBL_ADDRESS.Size = new System.Drawing.Size(277, 20);
            this.edtBL_ADDRESS.TabIndex = 5;
            this.edtBL_ADDRESS.TabStop = false;
            this.edtBL_ADDRESS.Tag = "D_ACCOUNTS_BL_ADDRESS.BL_ADDRESS";
            // 
            // AccountBLAddressEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 243);
            this.Controls.Add(this.edtBL_ADDRESS);
            this.Controls.Add(this.edtBL_ADDRESS_LINE6);
            this.Controls.Add(this.edtBL_ADDRESS_LINE5);
            this.Controls.Add(this.edtBL_ADDRESS_LINE4);
            this.Controls.Add(this.edtBL_ADDRESS_LINE3);
            this.Controls.Add(this.edtBL_ADDRESS_LINE2);
            this.Controls.Add(this.btnEsc);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.edtBL_ADDRESS_LINE1);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.grdBLADDRESS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "AccountBLAddressEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "客户提单地址维护";
            ((System.ComponentModel.ISupportInitialize)(this.grdBLADDRESS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtBL_ADDRESS_LINE1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEsc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtBL_ADDRESS_LINE2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtBL_ADDRESS_LINE3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtBL_ADDRESS_LINE4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtBL_ADDRESS_LINE5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtBL_ADDRESS_LINE6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtBL_ADDRESS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView grdBLADDRESS;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadButton btnNew;
        private Telerik.WinControls.UI.RadTextBox edtBL_ADDRESS_LINE1;
        private Telerik.WinControls.UI.RadButton btnDelete;
        private Telerik.WinControls.UI.RadButton btnEsc;
        private Telerik.WinControls.UI.RadTextBox edtBL_ADDRESS_LINE2;
        private Telerik.WinControls.UI.RadTextBox edtBL_ADDRESS_LINE3;
        private Telerik.WinControls.UI.RadTextBox edtBL_ADDRESS_LINE4;
        private Telerik.WinControls.UI.RadTextBox edtBL_ADDRESS_LINE5;
        private Telerik.WinControls.UI.RadTextBox edtBL_ADDRESS_LINE6;
        private Telerik.WinControls.UI.RadTextBox edtBL_ADDRESS;
    }
}