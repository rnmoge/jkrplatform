namespace JKRPlatform.Cargo
{
    partial class BoxForm
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn8 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn9 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn10 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn11 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn12 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn13 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn14 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.radButton2 = new Telerik.WinControls.UI.RadButton();
            this.radButton3 = new Telerik.WinControls.UI.RadButton();
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // radButton1
            // 
            this.radButton1.Location = new System.Drawing.Point(688, 12);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(70, 24);
            this.radButton1.TabIndex = 0;
            this.radButton1.Text = "新增";
            // 
            // radButton2
            // 
            this.radButton2.Location = new System.Drawing.Point(688, 72);
            this.radButton2.Name = "radButton2";
            this.radButton2.Size = new System.Drawing.Size(70, 24);
            this.radButton2.TabIndex = 2;
            this.radButton2.Text = "保存并关闭";
            this.radButton2.Click += new System.EventHandler(this.radButton2_Click);
            // 
            // radButton3
            // 
            this.radButton3.Location = new System.Drawing.Point(688, 42);
            this.radButton3.Name = "radButton3";
            this.radButton3.Size = new System.Drawing.Size(70, 24);
            this.radButton3.TabIndex = 1;
            this.radButton3.Text = "删除";
            // 
            // radGridView1
            // 
            this.radGridView1.AutoSize = true;
            this.radGridView1.Location = new System.Drawing.Point(9, 12);
            // 
            // radGridView1
            // 
            this.radGridView1.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn8.HeaderText = "箱型";
            gridViewTextBoxColumn8.Name = "column1";
            gridViewTextBoxColumn8.Width = 94;
            gridViewTextBoxColumn9.HeaderText = "数量";
            gridViewTextBoxColumn9.Name = "column2";
            gridViewTextBoxColumn9.Width = 94;
            gridViewTextBoxColumn10.HeaderText = "SOC";
            gridViewTextBoxColumn10.Name = "column3";
            gridViewTextBoxColumn10.Width = 94;
            gridViewTextBoxColumn11.HeaderText = "应收海运费单价";
            gridViewTextBoxColumn11.Name = "column4";
            gridViewTextBoxColumn11.Width = 94;
            gridViewTextBoxColumn12.HeaderText = "应付海运费单价";
            gridViewTextBoxColumn12.Name = "column5";
            gridViewTextBoxColumn12.Width = 94;
            gridViewTextBoxColumn13.HeaderText = "应付海运费备注";
            gridViewTextBoxColumn13.Name = "column6";
            gridViewTextBoxColumn13.Width = 94;
            gridViewTextBoxColumn14.HeaderText = "应付变更";
            gridViewTextBoxColumn14.Name = "column7";
            gridViewTextBoxColumn14.Width = 93;
            this.radGridView1.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn8,
            gridViewTextBoxColumn9,
            gridViewTextBoxColumn10,
            gridViewTextBoxColumn11,
            gridViewTextBoxColumn12,
            gridViewTextBoxColumn13,
            gridViewTextBoxColumn14});
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            // 
            // 
            // 
            this.radGridView1.RootElement.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.radGridView1.Size = new System.Drawing.Size(673, 139);
            this.radGridView1.TabIndex = 3;
            this.radGridView1.Text = "radGridView1";
            // 
            // BoxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 163);
            this.Controls.Add(this.radGridView1);
            this.Controls.Add(this.radButton3);
            this.Controls.Add(this.radButton2);
            this.Controls.Add(this.radButton1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BoxForm";
            this.Text = "箱型/箱量";
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadButton radButton1;
        private Telerik.WinControls.UI.RadButton radButton2;
        private Telerik.WinControls.UI.RadButton radButton3;
        private Telerik.WinControls.UI.RadGridView radGridView1;
    }
}