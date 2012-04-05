namespace JKRPlatform.Cargo
{
    partial class ProfitSeachForm
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
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.radDropDownList1 = new Telerik.WinControls.UI.RadDropDownList();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radTextBox1 = new Telerik.WinControls.UI.RadTextBox();
            this.radTextBox2 = new Telerik.WinControls.UI.RadTextBox();
            this.radTextBox3 = new Telerik.WinControls.UI.RadTextBox();
            this.radDropDownList2 = new Telerik.WinControls.UI.RadDropDownList();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel5 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel6 = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownList2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).BeginInit();
            this.SuspendLayout();
            // 
            // radGridView1
            // 
            this.radGridView1.Location = new System.Drawing.Point(12, 12);
            // 
            // radGridView1
            // 
            gridViewTextBoxColumn1.HeaderText = "币种";
            gridViewTextBoxColumn1.Name = "column1";
            gridViewTextBoxColumn1.Width = 113;
            gridViewTextBoxColumn2.HeaderText = "应收";
            gridViewTextBoxColumn2.Name = "column2";
            gridViewTextBoxColumn2.Width = 113;
            gridViewTextBoxColumn3.HeaderText = "应付";
            gridViewTextBoxColumn3.Name = "column3";
            gridViewTextBoxColumn3.Width = 112;
            gridViewTextBoxColumn4.HeaderText = "利润";
            gridViewTextBoxColumn4.Name = "column4";
            gridViewTextBoxColumn4.Width = 112;
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
            this.radGridView1.Size = new System.Drawing.Size(468, 150);
            this.radGridView1.TabIndex = 0;
            this.radGridView1.Text = "radGridView1";
            // 
            // radButton1
            // 
            this.radButton1.Location = new System.Drawing.Point(400, 287);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(80, 20);
            this.radButton1.TabIndex = 6;
            this.radButton1.Text = "关闭(&C)";
            this.radButton1.Click += new System.EventHandler(this.radButton1_Click);
            // 
            // radDropDownList1
            // 
            this.radDropDownList1.FilterExpression = null;
            this.radDropDownList1.Location = new System.Drawing.Point(112, 169);
            this.radDropDownList1.Name = "radDropDownList1";
            this.radDropDownList1.Size = new System.Drawing.Size(106, 20);
            this.radDropDownList1.TabIndex = 1;
            this.radDropDownList1.Text = "radDropDownList1";
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(12, 174);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(31, 17);
            this.radLabel1.TabIndex = 3;
            this.radLabel1.Text = "公司";
            // 
            // radTextBox1
            // 
            this.radTextBox1.Location = new System.Drawing.Point(380, 169);
            this.radTextBox1.Name = "radTextBox1";
            this.radTextBox1.Size = new System.Drawing.Size(100, 20);
            this.radTextBox1.TabIndex = 2;
            this.radTextBox1.Text = "radTextBox1";
            // 
            // radTextBox2
            // 
            this.radTextBox2.Location = new System.Drawing.Point(380, 195);
            this.radTextBox2.Name = "radTextBox2";
            this.radTextBox2.Size = new System.Drawing.Size(100, 20);
            this.radTextBox2.TabIndex = 4;
            this.radTextBox2.Text = "radTextBox2";
            // 
            // radTextBox3
            // 
            this.radTextBox3.Location = new System.Drawing.Point(380, 221);
            this.radTextBox3.Name = "radTextBox3";
            this.radTextBox3.Size = new System.Drawing.Size(100, 20);
            this.radTextBox3.TabIndex = 5;
            this.radTextBox3.Text = "radTextBox3";
            // 
            // radDropDownList2
            // 
            this.radDropDownList2.FilterExpression = null;
            this.radDropDownList2.Location = new System.Drawing.Point(112, 195);
            this.radDropDownList2.Name = "radDropDownList2";
            this.radDropDownList2.Size = new System.Drawing.Size(106, 20);
            this.radDropDownList2.TabIndex = 3;
            this.radDropDownList2.Text = "radDropDownList2";
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(12, 200);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(31, 17);
            this.radLabel2.TabIndex = 4;
            this.radLabel2.Text = "币种";
            // 
            // radLabel4
            // 
            this.radLabel4.Location = new System.Drawing.Point(253, 172);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(44, 17);
            this.radLabel4.TabIndex = 4;
            this.radLabel4.Text = "总应收";
            // 
            // radLabel5
            // 
            this.radLabel5.Location = new System.Drawing.Point(253, 198);
            this.radLabel5.Name = "radLabel5";
            this.radLabel5.Size = new System.Drawing.Size(44, 17);
            this.radLabel5.TabIndex = 4;
            this.radLabel5.Text = "总应付";
            // 
            // radLabel6
            // 
            this.radLabel6.Location = new System.Drawing.Point(253, 224);
            this.radLabel6.Name = "radLabel6";
            this.radLabel6.Size = new System.Drawing.Size(44, 17);
            this.radLabel6.TabIndex = 4;
            this.radLabel6.Text = "总利润";
            // 
            // ProfitSeachForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 319);
            this.Controls.Add(this.radLabel4);
            this.Controls.Add(this.radLabel6);
            this.Controls.Add(this.radLabel5);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.radDropDownList2);
            this.Controls.Add(this.radTextBox3);
            this.Controls.Add(this.radTextBox2);
            this.Controls.Add(this.radTextBox1);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.radDropDownList1);
            this.Controls.Add(this.radButton1);
            this.Controls.Add(this.radGridView1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProfitSeachForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "利润查看";
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownList2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView radGridView1;
        private Telerik.WinControls.UI.RadButton radButton1;
        private Telerik.WinControls.UI.RadDropDownList radDropDownList1;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadTextBox radTextBox1;
        private Telerik.WinControls.UI.RadTextBox radTextBox2;
        private Telerik.WinControls.UI.RadTextBox radTextBox3;
        private Telerik.WinControls.UI.RadDropDownList radDropDownList2;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadLabel radLabel5;
        private Telerik.WinControls.UI.RadLabel radLabel6;
    }
}