namespace PoliceMobile.TaskFrm.HouseCollection
{
    partial class frmCameraForHouseByIndoor
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu1;

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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCameraForHouseByIndoor));
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.mainMenu2 = new System.Windows.Forms.MainMenu();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnNext = new System.Windows.Forms.PictureBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnPrevious = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnCamera = new System.Windows.Forms.PictureBox();
            this.btnDelete = new System.Windows.Forms.PictureBox();
            this.pbShow = new System.Windows.Forms.PictureBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.ucControlManager1 = new PoliceMobile.LIB.ucControlManager();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(512, 30);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(326, 70);
            // 
            // btnNext
            // 
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.Location = new System.Drawing.Point(278, 5);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(187, 44);
            this.btnNext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(148)))), ((int)(((byte)(156)))));
            this.panel7.Controls.Add(this.pictureBox4);
            this.panel7.Controls.Add(this.btnPrevious);
            this.panel7.Controls.Add(this.btnNext);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(0, 463);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(480, 55);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Image = ((System.Drawing.Image)(resources.GetObject("btnPrevious.Image")));
            this.btnPrevious.Location = new System.Drawing.Point(17, 5);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(187, 44);
            this.btnPrevious.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 528);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(480, 60);
            // 
            // btnCamera
            // 
            this.btnCamera.Image = ((System.Drawing.Image)(resources.GetObject("btnCamera.Image")));
            this.btnCamera.Location = new System.Drawing.Point(17, 166);
            this.btnCamera.Name = "btnCamera";
            this.btnCamera.Size = new System.Drawing.Size(172, 56);
            this.btnCamera.Click += new System.EventHandler(this.btnCamera_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(296, 166);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(170, 53);
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // pbShow
            // 
            this.pbShow.BackColor = System.Drawing.Color.Lavender;
            this.pbShow.Location = new System.Drawing.Point(19, 239);
            this.pbShow.Name = "pbShow";
            this.pbShow.Size = new System.Drawing.Size(446, 323);
            this.pbShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            // 
            // checkBox3
            // 
            this.checkBox3.Checked = true;
            this.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox3.Font = new System.Drawing.Font("Tahoma", 6F, System.Drawing.FontStyle.Bold);
            this.checkBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.checkBox3.Location = new System.Drawing.Point(361, 568);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(112, 40);
            this.checkBox3.TabIndex = 37;
            this.checkBox3.Text = "户型图";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 518);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(480, 10);
            // 
            // lblAddress
            // 
            this.lblAddress.Font = new System.Drawing.Font("Tahoma", 6F, System.Drawing.FontStyle.Bold);
            this.lblAddress.ForeColor = System.Drawing.Color.Gray;
            this.lblAddress.Location = new System.Drawing.Point(20, 81);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(417, 27);
            this.lblAddress.Tag = ".//Residential_housing/streetaddress";
            this.lblAddress.Text = "选择dddd";
            // 
            // txtTitle
            // 
            this.txtTitle.BackColor = System.Drawing.Color.White;
            this.txtTitle.Font = new System.Drawing.Font("Tahoma", 6F, System.Drawing.FontStyle.Regular);
            this.txtTitle.Location = new System.Drawing.Point(120, 116);
            this.txtTitle.Multiline = true;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(326, 31);
            this.txtTitle.TabIndex = 55;
            this.txtTitle.Tag = "";
            // 
            // label18
            // 
            this.label18.Font = new System.Drawing.Font("Tahoma", 6F, System.Drawing.FontStyle.Bold);
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.label18.Location = new System.Drawing.Point(29, 122);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(85, 18);
            this.label18.Text = "图片标题";
            // 
            // ucControlManager1
            // 
            this.ucControlManager1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucControlManager1.Location = new System.Drawing.Point(0, 0);
            this.ucControlManager1.Name = "ucControlManager1";
            this.ucControlManager1.Size = new System.Drawing.Size(480, 67);
            this.ucControlManager1.TabIndex = 48;
            // 
            // frmCameraForHouseByIndoor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(480, 588);
            this.Controls.Add(this.ucControlManager1);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.pbShow);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCamera);
            this.Location = new System.Drawing.Point(0, 0);
            this.Menu = this.mainMenu1;
            this.Name = "frmCameraForHouseByIndoor";
            this.Text = "frmCameraForHouseByIndoor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MainMenu mainMenu2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox btnNext;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.PictureBox btnPrevious;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox btnCamera;
        private System.Windows.Forms.PictureBox btnDelete;
        private System.Windows.Forms.PictureBox pbShow;
        private System.Windows.Forms.CheckBox checkBox3;
        private PoliceMobile.LIB.ucControlManager ucControlManager1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label18;


    }
}