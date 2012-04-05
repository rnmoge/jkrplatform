namespace JKRPlatform.CommmGUI
{
    partial class ReturnFileSettingExport
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewMultiComboBoxColumn gridViewMultiComboBoxColumn1 = new Telerik.WinControls.UI.GridViewMultiComboBoxColumn();
            Telerik.WinControls.UI.GridViewMultiComboBoxColumn gridViewMultiComboBoxColumn2 = new Telerik.WinControls.UI.GridViewMultiComboBoxColumn();
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn1 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn2 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn3 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn4 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn5 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn6 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            this.btnCancel = new Telerik.WinControls.UI.RadButton();
            this.btnOK = new Telerik.WinControls.UI.RadButton();
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            this.radGridView2 = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(560, 337);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 20);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "关闭(&C)";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Enabled = false;
            this.btnOK.Location = new System.Drawing.Point(474, 337);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(80, 20);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "保存(&S)";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // radGridView1
            // 
            this.radGridView1.Location = new System.Drawing.Point(12, 14);
            // 
            // radGridView1
            // 
            gridViewTextBoxColumn1.HeaderText = "贸易方式";
            gridViewTextBoxColumn1.Name = "column1";
            gridViewTextBoxColumn1.Width = 100;
            gridViewMultiComboBoxColumn1.DisplayMember = null;
            gridViewMultiComboBoxColumn1.HeaderText = "一次退单";
            gridViewMultiComboBoxColumn1.Name = "column6";
            gridViewMultiComboBoxColumn1.ValueMember = null;
            gridViewMultiComboBoxColumn2.DisplayMember = null;
            gridViewMultiComboBoxColumn2.HeaderText = "二次退单";
            gridViewMultiComboBoxColumn2.Name = "column2";
            gridViewMultiComboBoxColumn2.ValueMember = null;
            gridViewCheckBoxColumn1.HeaderText = "销保";
            gridViewCheckBoxColumn1.Name = "column3";
            gridViewCheckBoxColumn2.HeaderText = "贴签";
            gridViewCheckBoxColumn2.Name = "column4";
            this.radGridView1.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewMultiComboBoxColumn1,
            gridViewMultiComboBoxColumn2,
            gridViewCheckBoxColumn1,
            gridViewCheckBoxColumn2});
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            // 
            // 
            // 
            this.radGridView1.RootElement.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.radGridView1.Size = new System.Drawing.Size(628, 149);
            this.radGridView1.TabIndex = 29;
            this.radGridView1.Text = "radGridView1";
            // 
            // radGridView2
            // 
            this.radGridView2.Location = new System.Drawing.Point(12, 169);
            // 
            // radGridView2
            // 
            gridViewTextBoxColumn2.HeaderText = "序号";
            gridViewTextBoxColumn2.Name = "column1";
            gridViewTextBoxColumn2.Width = 100;
            gridViewTextBoxColumn3.HeaderText = "代码值";
            gridViewTextBoxColumn3.Name = "column2";
            gridViewTextBoxColumn3.Width = 100;
            gridViewTextBoxColumn4.HeaderText = "说明";
            gridViewTextBoxColumn4.Name = "column3";
            gridViewTextBoxColumn5.HeaderText = "EDI代码";
            gridViewTextBoxColumn5.Name = "column4";
            gridViewCheckBoxColumn3.HeaderText = "是否退单";
            gridViewCheckBoxColumn3.Name = "column9";
            gridViewCheckBoxColumn4.HeaderText = "销保";
            gridViewCheckBoxColumn4.Name = "column10";
            gridViewCheckBoxColumn5.HeaderText = "贴签";
            gridViewCheckBoxColumn5.Name = "column11";
            gridViewCheckBoxColumn6.HeaderText = "是否签单";
            gridViewCheckBoxColumn6.Name = "column12";
            this.radGridView2.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewCheckBoxColumn3,
            gridViewCheckBoxColumn4,
            gridViewCheckBoxColumn5,
            gridViewCheckBoxColumn6});
            this.radGridView2.Name = "radGridView2";
            this.radGridView2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            // 
            // 
            // 
            this.radGridView2.RootElement.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.radGridView2.Size = new System.Drawing.Size(628, 162);
            this.radGridView2.TabIndex = 35;
            this.radGridView2.Text = "radGridView2";
            // 
            // ReturnFileSettingExport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 369);
            this.Controls.Add(this.radGridView2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.radGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "ReturnFileSettingExport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "出口退单文件-编辑";
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadButton btnCancel;
        private Telerik.WinControls.UI.RadButton btnOK;
        private Telerik.WinControls.UI.RadGridView radGridView1;
        private Telerik.WinControls.UI.RadGridView radGridView2;
    }
}