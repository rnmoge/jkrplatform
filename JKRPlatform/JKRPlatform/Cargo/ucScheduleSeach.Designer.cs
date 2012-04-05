namespace JKRPlatform.Cargo
{
    partial class ucScheduleSeach
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn8 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn9 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn10 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn11 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn12 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // radGridView1
            // 
            this.radGridView1.AutoSize = true;
            this.radGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGridView1.Location = new System.Drawing.Point(0, 0);
            // 
            // radGridView1
            // 
            this.radGridView1.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.HeaderText = "船公司";
            gridViewTextBoxColumn1.Name = "column5";
            gridViewTextBoxColumn1.Width = 88;
            gridViewTextBoxColumn2.HeaderText = "船名";
            gridViewTextBoxColumn2.Name = "column2";
            gridViewTextBoxColumn2.Width = 88;
            gridViewTextBoxColumn3.HeaderText = "航次";
            gridViewTextBoxColumn3.Name = "column1";
            gridViewTextBoxColumn3.Width = 88;
            gridViewTextBoxColumn4.HeaderText = "开航日期";
            gridViewTextBoxColumn4.Name = "column3";
            gridViewTextBoxColumn4.Width = 88;
            gridViewTextBoxColumn5.HeaderText = "截关日期";
            gridViewTextBoxColumn5.Name = "column4";
            gridViewTextBoxColumn5.Width = 88;
            gridViewTextBoxColumn6.HeaderText = "集港日期";
            gridViewTextBoxColumn6.Name = "column6";
            gridViewTextBoxColumn6.Width = 88;
            gridViewTextBoxColumn7.HeaderText = "公司代码";
            gridViewTextBoxColumn7.Name = "column7";
            gridViewTextBoxColumn7.Width = 88;
            gridViewTextBoxColumn8.HeaderText = "订舱代理";
            gridViewTextBoxColumn8.Name = "column8";
            gridViewTextBoxColumn8.Width = 88;
            gridViewTextBoxColumn9.HeaderText = "录入时间";
            gridViewTextBoxColumn9.Name = "column9";
            gridViewTextBoxColumn9.Width = 42;
            gridViewTextBoxColumn10.HeaderText = "录入人";
            gridViewTextBoxColumn10.Name = "column10";
            gridViewTextBoxColumn10.Width = 41;
            gridViewTextBoxColumn11.HeaderText = "更新人";
            gridViewTextBoxColumn11.Name = "column11";
            gridViewTextBoxColumn11.Width = 43;
            gridViewTextBoxColumn12.HeaderText = "更新时间";
            gridViewTextBoxColumn12.Name = "column12";
            gridViewTextBoxColumn12.Width = 47;
            this.radGridView1.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewTextBoxColumn7,
            gridViewTextBoxColumn8,
            gridViewTextBoxColumn9,
            gridViewTextBoxColumn10,
            gridViewTextBoxColumn11,
            gridViewTextBoxColumn12});
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            // 
            // 
            // 
            this.radGridView1.RootElement.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.radGridView1.Size = new System.Drawing.Size(888, 716);
            this.radGridView1.TabIndex = 1;
            this.radGridView1.Text = "radGridView1";
            // 
            // uc3081Seach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radGridView1);
            this.Name = "uc3081Seach";
            this.Size = new System.Drawing.Size(888, 716);
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView radGridView1;
    }
}
