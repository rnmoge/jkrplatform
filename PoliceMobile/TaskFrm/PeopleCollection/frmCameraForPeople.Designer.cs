namespace PoliceMobile.TaskFrm.PeopleCollection
{
    partial class frmCameraForPeople
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCameraForPeople));
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
            this.ucControlManager1 = new PoliceMobile.LIB.ucControlManager();
            this.pbSpecial = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblBirth = new System.Windows.Forms.Label();
            this.lblSex = new System.Windows.Forms.Label();
            this.lblCardId = new System.Windows.Forms.Label();
            this.lblNation = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
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
            this.panel7.Location = new System.Drawing.Point(0, 625);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(481, 55);
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
            this.btnCamera.Location = new System.Drawing.Point(17, 207);
            this.btnCamera.Name = "btnCamera";
            this.btnCamera.Size = new System.Drawing.Size(172, 56);
            this.btnCamera.Click += new System.EventHandler(this.btnCamera_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(300, 207);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(173, 53);
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // pbShow
            // 
            this.pbShow.Location = new System.Drawing.Point(19, 294);
            this.pbShow.Name = "pbShow";
            this.pbShow.Size = new System.Drawing.Size(446, 209);
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
            // ucControlManager1
            // 
            this.ucControlManager1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucControlManager1.Location = new System.Drawing.Point(0, 0);
            this.ucControlManager1.Name = "ucControlManager1";
            this.ucControlManager1.Size = new System.Drawing.Size(480, 67);
            this.ucControlManager1.TabIndex = 48;
            // 
            // pbSpecial
            // 
            this.pbSpecial.Image = ((System.Drawing.Image)(resources.GetObject("pbSpecial.Image")));
            this.pbSpecial.Location = new System.Drawing.Point(355, 76);
            this.pbSpecial.Name = "pbSpecial";
            this.pbSpecial.Size = new System.Drawing.Size(110, 32);
            this.pbSpecial.Visible = false;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Tahoma", 6F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.label6.Location = new System.Drawing.Point(17, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(177, 18);
            this.label6.Text = "常住户口所在地地址:";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Tahoma", 6F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.label5.Location = new System.Drawing.Point(17, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 18);
            this.label5.Text = "身份证号码:";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Tahoma", 6F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.label4.Location = new System.Drawing.Point(220, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 18);
            this.label4.Text = "出生:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 6F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.label3.Location = new System.Drawing.Point(17, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 18);
            this.label3.Text = "民族:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 6F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.label2.Location = new System.Drawing.Point(220, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.Text = "性别:";
            // 
            // lblAddress
            // 
            this.lblAddress.Font = new System.Drawing.Font("Tahoma", 6F, System.Drawing.FontStyle.Bold);
            this.lblAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.lblAddress.Location = new System.Drawing.Point(200, 162);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(265, 20);
            // 
            // lblBirth
            // 
            this.lblBirth.Font = new System.Drawing.Font("Tahoma", 6F, System.Drawing.FontStyle.Bold);
            this.lblBirth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.lblBirth.Location = new System.Drawing.Point(275, 111);
            this.lblBirth.Name = "lblBirth";
            this.lblBirth.Size = new System.Drawing.Size(142, 20);
            // 
            // lblSex
            // 
            this.lblSex.Font = new System.Drawing.Font("Tahoma", 6F, System.Drawing.FontStyle.Bold);
            this.lblSex.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.lblSex.Location = new System.Drawing.Point(275, 82);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(49, 20);
            // 
            // lblCardId
            // 
            this.lblCardId.Font = new System.Drawing.Font("Tahoma", 6F, System.Drawing.FontStyle.Bold);
            this.lblCardId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.lblCardId.Location = new System.Drawing.Point(127, 135);
            this.lblCardId.Name = "lblCardId";
            this.lblCardId.Size = new System.Drawing.Size(338, 20);
            // 
            // lblNation
            // 
            this.lblNation.Font = new System.Drawing.Font("Tahoma", 6F, System.Drawing.FontStyle.Bold);
            this.lblNation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.lblNation.Location = new System.Drawing.Point(72, 109);
            this.lblNation.Name = "lblNation";
            this.lblNation.Size = new System.Drawing.Size(49, 20);
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Tahoma", 6F, System.Drawing.FontStyle.Bold);
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.lblName.Location = new System.Drawing.Point(72, 82);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(142, 20);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 6F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.label1.Location = new System.Drawing.Point(17, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.Text = "姓名:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(196, 207);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(97, 53);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(-1, 192);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(481, 5);
            // 
            // frmCameraForPeople
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(480, 588);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pbSpecial);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblBirth);
            this.Controls.Add(this.lblSex);
            this.Controls.Add(this.lblCardId);
            this.Controls.Add(this.lblNation);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ucControlManager1);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.pbShow);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCamera);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel7);
            this.Location = new System.Drawing.Point(0, 0);
            this.Menu = this.mainMenu1;
            this.Name = "frmCameraForPeople";
            this.Text = "frmCameraForPeople";
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
        private System.Windows.Forms.PictureBox pbSpecial;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblBirth;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.Label lblCardId;
        private System.Windows.Forms.Label lblNation;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox7;


    }
}