namespace JKRPlatform.CommmGUI
{
    partial class ReturnFileSettingImport
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn16 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn17 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn18 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn19 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn19 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn20 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn21 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn22 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn20 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewMultiComboBoxColumn gridViewMultiComboBoxColumn7 = new Telerik.WinControls.UI.GridViewMultiComboBoxColumn();
            Telerik.WinControls.UI.GridViewMultiComboBoxColumn gridViewMultiComboBoxColumn8 = new Telerik.WinControls.UI.GridViewMultiComboBoxColumn();
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn23 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn24 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            this.radGridView2 = new Telerik.WinControls.UI.RadGridView();
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            this.btnCancel = new Telerik.WinControls.UI.RadButton();
            this.btnOK = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOK)).BeginInit();
            this.SuspendLayout();
            // 
            // radGridView2
            // 
            this.radGridView2.Location = new System.Drawing.Point(12, 167);
            // 
            // radGridView2
            // 
            gridViewTextBoxColumn16.HeaderText = "序号";
            gridViewTextBoxColumn16.Name = "column1";
            gridViewTextBoxColumn16.Width = 100;
            gridViewTextBoxColumn17.HeaderText = "代码值";
            gridViewTextBoxColumn17.Name = "column2";
            gridViewTextBoxColumn17.Width = 100;
            gridViewTextBoxColumn18.HeaderText = "说明";
            gridViewTextBoxColumn18.Name = "column3";
            gridViewTextBoxColumn19.HeaderText = "EDI代码";
            gridViewTextBoxColumn19.Name = "column4";
            gridViewCheckBoxColumn19.HeaderText = "是否退单";
            gridViewCheckBoxColumn19.Name = "column9";
            gridViewCheckBoxColumn20.HeaderText = "销保";
            gridViewCheckBoxColumn20.Name = "column10";
            gridViewCheckBoxColumn21.HeaderText = "贴签";
            gridViewCheckBoxColumn21.Name = "column11";
            gridViewCheckBoxColumn22.HeaderText = "是否签单";
            gridViewCheckBoxColumn22.Name = "column12";
            this.radGridView2.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn16,
            gridViewTextBoxColumn17,
            gridViewTextBoxColumn18,
            gridViewTextBoxColumn19,
            gridViewCheckBoxColumn19,
            gridViewCheckBoxColumn20,
            gridViewCheckBoxColumn21,
            gridViewCheckBoxColumn22});
            this.radGridView2.Name = "radGridView2";
            this.radGridView2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            // 
            // 
            // 
            this.radGridView2.RootElement.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.radGridView2.Size = new System.Drawing.Size(628, 162);
            this.radGridView2.TabIndex = 43;
            this.radGridView2.Text = "radGridView2";
            // 
            // radGridView1
            // 
            this.radGridView1.Location = new System.Drawing.Point(12, 12);
            // 
            // radGridView1
            // 
            gridViewTextBoxColumn20.HeaderText = "贸易方式";
            gridViewTextBoxColumn20.Name = "column1";
            gridViewTextBoxColumn20.Width = 100;
            gridViewMultiComboBoxColumn7.DisplayMember = null;
            gridViewMultiComboBoxColumn7.HeaderText = "一次退单";
            gridViewMultiComboBoxColumn7.Name = "column6";
            gridViewMultiComboBoxColumn7.ValueMember = null;
            gridViewMultiComboBoxColumn8.DisplayMember = null;
            gridViewMultiComboBoxColumn8.HeaderText = "二次退单";
            gridViewMultiComboBoxColumn8.Name = "column2";
            gridViewMultiComboBoxColumn8.ValueMember = null;
            gridViewCheckBoxColumn23.HeaderText = "销保";
            gridViewCheckBoxColumn23.Name = "column3";
            gridViewCheckBoxColumn24.HeaderText = "贴签";
            gridViewCheckBoxColumn24.Name = "column4";
            this.radGridView1.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn20,
            gridViewMultiComboBoxColumn7,
            gridViewMultiComboBoxColumn8,
            gridViewCheckBoxColumn23,
            gridViewCheckBoxColumn24});
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            // 
            // 
            // 
            this.radGridView1.RootElement.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.radGridView1.Size = new System.Drawing.Size(628, 149);
            this.radGridView1.TabIndex = 42;
            this.radGridView1.Text = "radGridView1";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(560, 337);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 20);
            this.btnCancel.TabIndex = 45;
            this.btnCancel.Text = "关闭(&C)";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Enabled = false;
            this.btnOK.Location = new System.Drawing.Point(474, 337);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(80, 20);
            this.btnOK.TabIndex = 44;
            this.btnOK.Text = "保存(&S)";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // ReturnFileSettingImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 369);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.radGridView2);
            this.Controls.Add(this.radGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "ReturnFileSettingImport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "进口退单文件-编辑";
            ((System.ComponentModel.ISupportInitialize)(this.radGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOK)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView radGridView2;
        private Telerik.WinControls.UI.RadGridView radGridView1;
        private Telerik.WinControls.UI.RadButton btnCancel;
        private Telerik.WinControls.UI.RadButton btnOK;
    }
}