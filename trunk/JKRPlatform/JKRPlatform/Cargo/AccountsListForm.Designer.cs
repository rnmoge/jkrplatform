namespace JKRPlatform.Cargo
{
    partial class AccountsListForm
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radButton2 = new Telerik.WinControls.UI.RadButton();
            this.radTextBox1 = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.radButton3 = new Telerik.WinControls.UI.RadButton();
            this.radCheckBox1 = new Telerik.WinControls.UI.RadCheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radButton2);
            this.groupBox1.Controls.Add(this.radTextBox1);
            this.groupBox1.Controls.Add(this.radLabel1);
            this.groupBox1.Location = new System.Drawing.Point(10, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(495, 50);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "检索";
            // 
            // radButton2
            // 
            this.radButton2.Location = new System.Drawing.Point(400, 15);
            this.radButton2.Name = "radButton2";
            this.radButton2.Size = new System.Drawing.Size(80, 24);
            this.radButton2.TabIndex = 2;
            this.radButton2.Text = "检索(&S)";
            // 
            // radTextBox1
            // 
            this.radTextBox1.Location = new System.Drawing.Point(71, 17);
            this.radTextBox1.Name = "radTextBox1";
            this.radTextBox1.Size = new System.Drawing.Size(306, 20);
            this.radTextBox1.TabIndex = 1;
            this.radTextBox1.TabStop = false;
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(7, 21);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(44, 17);
            this.radLabel1.TabIndex = 0;
            this.radLabel1.Text = "关键字";
            // 
            // radGridView1
            // 
            this.radGridView1.AutoScroll = true;
            this.radGridView1.AutoSize = true;
            this.radGridView1.Location = new System.Drawing.Point(13, 64);
            // 
            // radGridView1
            // 
            this.radGridView1.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.HeaderText = "代码";
            gridViewTextBoxColumn1.Name = "column1";
            gridViewTextBoxColumn1.Width = 118;
            gridViewTextBoxColumn2.HeaderText = "简称";
            gridViewTextBoxColumn2.Name = "column2";
            gridViewTextBoxColumn2.Width = 118;
            gridViewTextBoxColumn3.HeaderText = "名称";
            gridViewTextBoxColumn3.Name = "column3";
            gridViewTextBoxColumn3.Width = 118;
            gridViewTextBoxColumn4.HeaderText = "中文名";
            gridViewTextBoxColumn4.Name = "column4";
            gridViewTextBoxColumn4.Width = 119;
            this.radGridView1.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4});
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            // 
            // 
            // 
            this.radGridView1.RootElement.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.radGridView1.Size = new System.Drawing.Size(492, 121);
            this.radGridView1.TabIndex = 3;
            this.radGridView1.Text = "radGridView1";
            // 
            // radButton1
            // 
            this.radButton1.Location = new System.Drawing.Point(425, 202);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(80, 24);
            this.radButton1.TabIndex = 6;
            this.radButton1.Text = "取消(&C)";
            this.radButton1.Click += new System.EventHandler(this.radButton1_Click);
            // 
            // radButton3
            // 
            this.radButton3.Location = new System.Drawing.Point(339, 202);
            this.radButton3.Name = "radButton3";
            this.radButton3.Size = new System.Drawing.Size(80, 24);
            this.radButton3.TabIndex = 5;
            this.radButton3.Text = "确定(&O)";
            // 
            // radCheckBox1
            // 
            this.radCheckBox1.Location = new System.Drawing.Point(13, 208);
            this.radCheckBox1.Name = "radCheckBox1";
            this.radCheckBox1.Size = new System.Drawing.Size(107, 18);
            this.radCheckBox1.TabIndex = 4;
            this.radCheckBox1.Text = "仅显示有效帐户";
            this.radCheckBox1.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            // 
            // AccountsListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 240);
            this.Controls.Add(this.radCheckBox1);
            this.Controls.Add(this.radButton3);
            this.Controls.Add(this.radButton1);
            this.Controls.Add(this.radGridView1);
            this.Controls.Add(this.groupBox1);
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AccountsListForm";
            this.Text = "帐户列表";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private Telerik.WinControls.UI.RadButton radButton2;
        private Telerik.WinControls.UI.RadTextBox radTextBox1;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadGridView radGridView1;
        private Telerik.WinControls.UI.RadButton radButton1;
        private Telerik.WinControls.UI.RadButton radButton3;
        private Telerik.WinControls.UI.RadCheckBox radCheckBox1;
    }
}