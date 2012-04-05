namespace JKRPlatform.CommmGUI
{
    partial class FileProject
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn26 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn21 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn22 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn23 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn24 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn27 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn28 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn29 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewComboBoxColumn gridViewComboBoxColumn6 = new Telerik.WinControls.UI.GridViewComboBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn30 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSubDel = new Telerik.WinControls.UI.RadButton();
            this.btnSubAdd = new Telerik.WinControls.UI.RadButton();
            this.radGridView2 = new Telerik.WinControls.UI.RadGridView();
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            this.btnClose = new Telerik.WinControls.UI.RadButton();
            this.btnSave = new Telerik.WinControls.UI.RadButton();
            this.btnDelete = new Telerik.WinControls.UI.RadButton();
            this.btnAdd = new Telerik.WinControls.UI.RadButton();
            this.btnEdit = new Telerik.WinControls.UI.RadButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSubDel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSubAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSubDel);
            this.groupBox1.Controls.Add(this.btnSubAdd);
            this.groupBox1.Controls.Add(this.radGridView2);
            this.groupBox1.Location = new System.Drawing.Point(12, 172);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(628, 159);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "文件方案明细";
            // 
            // btnSubDel
            // 
            this.btnSubDel.Enabled = false;
            this.btnSubDel.Location = new System.Drawing.Point(537, 46);
            this.btnSubDel.Name = "btnSubDel";
            this.btnSubDel.Size = new System.Drawing.Size(80, 20);
            this.btnSubDel.TabIndex = 2;
            this.btnSubDel.Text = "删除";
            this.btnSubDel.Click += new System.EventHandler(this.btnSubDel_Click);
            // 
            // btnSubAdd
            // 
            this.btnSubAdd.Enabled = false;
            this.btnSubAdd.Location = new System.Drawing.Point(537, 20);
            this.btnSubAdd.Name = "btnSubAdd";
            this.btnSubAdd.Size = new System.Drawing.Size(80, 20);
            this.btnSubAdd.TabIndex = 1;
            this.btnSubAdd.Text = "添加";
            this.btnSubAdd.Click += new System.EventHandler(this.btnSubAdd_Click);
            // 
            // radGridView2
            // 
            this.radGridView2.Location = new System.Drawing.Point(6, 20);
            // 
            // radGridView2
            // 
            this.radGridView2.MasterTemplate.AllowAddNewRow = false;
            gridViewTextBoxColumn26.HeaderText = "文件类型";
            gridViewTextBoxColumn26.Name = "column1";
            gridViewTextBoxColumn26.Width = 100;
            gridViewCheckBoxColumn21.HeaderText = "需要取得";
            gridViewCheckBoxColumn21.Name = "column2";
            gridViewCheckBoxColumn22.HeaderText = "需要送出";
            gridViewCheckBoxColumn22.Name = "column3";
            gridViewCheckBoxColumn23.HeaderText = "需要退回";
            gridViewCheckBoxColumn23.Name = "column7";
            gridViewCheckBoxColumn24.HeaderText = "需要退还";
            gridViewCheckBoxColumn24.Name = "column4";
            gridViewTextBoxColumn27.HeaderText = "附加说明";
            gridViewTextBoxColumn27.Name = "column6";
            gridViewTextBoxColumn27.Width = 100;
            this.radGridView2.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn26,
            gridViewCheckBoxColumn21,
            gridViewCheckBoxColumn22,
            gridViewCheckBoxColumn23,
            gridViewCheckBoxColumn24,
            gridViewTextBoxColumn27});
            this.radGridView2.Name = "radGridView2";
            this.radGridView2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.radGridView2.ReadOnly = true;
            // 
            // 
            // 
            this.radGridView2.RootElement.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.radGridView2.Size = new System.Drawing.Size(525, 128);
            this.radGridView2.TabIndex = 16;
            this.radGridView2.Text = "radGridView2";
            // 
            // radGridView1
            // 
            this.radGridView1.Location = new System.Drawing.Point(12, 17);
            // 
            // radGridView1
            // 
            this.radGridView1.MasterTemplate.AllowAddNewRow = false;
            gridViewTextBoxColumn28.HeaderText = "方案代码";
            gridViewTextBoxColumn28.Name = "column1";
            gridViewTextBoxColumn28.Width = 100;
            gridViewTextBoxColumn29.HeaderText = "方案名称";
            gridViewTextBoxColumn29.Name = "column2";
            gridViewTextBoxColumn29.Width = 350;
            gridViewComboBoxColumn6.DisplayMember = null;
            gridViewComboBoxColumn6.HeaderText = "业务类型";
            gridViewComboBoxColumn6.Name = "column5";
            gridViewComboBoxColumn6.ValueMember = null;
            gridViewTextBoxColumn30.HeaderText = "附加说明";
            gridViewTextBoxColumn30.Name = "column4";
            this.radGridView1.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn28,
            gridViewTextBoxColumn29,
            gridViewComboBoxColumn6,
            gridViewTextBoxColumn30});
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.radGridView1.ReadOnly = true;
            // 
            // 
            // 
            this.radGridView1.RootElement.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.radGridView1.Size = new System.Drawing.Size(628, 149);
            this.radGridView1.TabIndex = 22;
            this.radGridView1.Text = "radGridView1";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(560, 337);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(80, 20);
            this.btnClose.TabIndex = 73;
            this.btnClose.Text = "关闭(&C)";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(474, 337);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 20);
            this.btnSave.TabIndex = 72;
            this.btnSave.Text = "保存(&S)";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(388, 337);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 20);
            this.btnDelete.TabIndex = 71;
            this.btnDelete.Text = "删除(&D)";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(216, 337);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 20);
            this.btnAdd.TabIndex = 69;
            this.btnAdd.Text = "新增(&N)";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(302, 337);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(80, 20);
            this.btnEdit.TabIndex = 70;
            this.btnEdit.Text = "编辑(&E)";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // FileProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 369);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.radGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FileProject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "文件方案-编辑";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnSubDel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSubAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private Telerik.WinControls.UI.RadButton btnSubDel;
        private Telerik.WinControls.UI.RadButton btnSubAdd;
        private Telerik.WinControls.UI.RadGridView radGridView2;
        private Telerik.WinControls.UI.RadGridView radGridView1;
        private Telerik.WinControls.UI.RadButton btnClose;
        private Telerik.WinControls.UI.RadButton btnSave;
        private Telerik.WinControls.UI.RadButton btnDelete;
        private Telerik.WinControls.UI.RadButton btnAdd;
        private Telerik.WinControls.UI.RadButton btnEdit;
    }
}