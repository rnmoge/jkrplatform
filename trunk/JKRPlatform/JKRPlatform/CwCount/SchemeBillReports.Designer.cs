namespace JKRPlatform.CwCount
{
    partial class SchemeBillReports
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
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.radButton2 = new Telerik.WinControls.UI.RadButton();
            this.radButton3 = new Telerik.WinControls.UI.RadButton();
            this.radButton4 = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton4)).BeginInit();
            this.SuspendLayout();
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(12, 12);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(254, 17);
            this.radLabel1.TabIndex = 0;
            this.radLabel1.Text = "请选择要导入到数据库中的统计分析报表方案";
            // 
            // radGridView1
            // 
            this.radGridView1.AutoScroll = true;
            this.radGridView1.AutoSize = true;
            this.radGridView1.Location = new System.Drawing.Point(9, 35);
            // 
            // radGridView1
            // 
            this.radGridView1.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.HeaderText = "方案名称";
            gridViewTextBoxColumn1.Name = "column1";
            gridViewTextBoxColumn1.Width = 259;
            gridViewTextBoxColumn2.HeaderText = "文件路径";
            gridViewTextBoxColumn2.Name = "column2";
            gridViewTextBoxColumn2.Width = 259;
            this.radGridView1.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2});
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.radGridView1.Size = new System.Drawing.Size(539, 220);
            this.radGridView1.TabIndex = 1;
            this.radGridView1.Text = "radGridView1";
            // 
            // radButton1
            // 
            this.radButton1.Location = new System.Drawing.Point(9, 261);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(80, 24);
            this.radButton1.TabIndex = 2;
            this.radButton1.Text = "选择文件";
            // 
            // radButton2
            // 
            this.radButton2.Location = new System.Drawing.Point(468, 261);
            this.radButton2.Name = "radButton2";
            this.radButton2.Size = new System.Drawing.Size(80, 24);
            this.radButton2.TabIndex = 3;
            this.radButton2.Text = "退出(&E)";
            // 
            // radButton3
            // 
            this.radButton3.Location = new System.Drawing.Point(382, 261);
            this.radButton3.Name = "radButton3";
            this.radButton3.Size = new System.Drawing.Size(80, 24);
            this.radButton3.TabIndex = 4;
            this.radButton3.Text = "导入(&I)";
            // 
            // radButton4
            // 
            this.radButton4.Location = new System.Drawing.Point(95, 261);
            this.radButton4.Name = "radButton4";
            this.radButton4.Size = new System.Drawing.Size(80, 24);
            this.radButton4.TabIndex = 3;
            this.radButton4.Text = "删除文件";
            // 
            // Scheme6995
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 293);
            this.Controls.Add(this.radButton4);
            this.Controls.Add(this.radButton3);
            this.Controls.Add(this.radButton2);
            this.Controls.Add(this.radButton1);
            this.Controls.Add(this.radGridView1);
            this.Controls.Add(this.radLabel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Scheme6995";
            this.Text = "统计方案导入";
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadGridView radGridView1;
        private Telerik.WinControls.UI.RadButton radButton1;
        private Telerik.WinControls.UI.RadButton radButton2;
        private Telerik.WinControls.UI.RadButton radButton3;
        private Telerik.WinControls.UI.RadButton radButton4;
    }
}