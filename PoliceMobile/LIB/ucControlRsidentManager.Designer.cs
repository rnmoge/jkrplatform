namespace PoliceMobile.LIB
{
    partial class ucControlRsidentManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucControlRsidentManager));
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.pCamera = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.pExtendedInfo = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.pBaseInfo = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pID = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pFingerprint = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pControl = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pCamera.SuspendLayout();
            this.pExtendedInfo.SuspendLayout();
            this.pBaseInfo.SuspendLayout();
            this.pID.SuspendLayout();
            this.pFingerprint.SuspendLayout();
            this.pControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 6F, System.Drawing.FontStyle.Regular);
            this.label2.Location = new System.Drawing.Point(5, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 23);
            this.label2.Text = "基本信息";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(480, 49);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Tahoma", 6F, System.Drawing.FontStyle.Regular);
            this.label5.Location = new System.Drawing.Point(6, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 23);
            this.label5.Text = "扩展信息";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Tahoma", 6F, System.Drawing.FontStyle.Regular);
            this.label4.Location = new System.Drawing.Point(3, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 23);
            this.label4.Text = "身份证";
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Tahoma", 6F, System.Drawing.FontStyle.Regular);
            this.label12.Location = new System.Drawing.Point(5, 10);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 23);
            this.label12.Text = "照片";
            // 
            // pCamera
            // 
            this.pCamera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.pCamera.Controls.Add(this.label12);
            this.pCamera.Controls.Add(this.label13);
            this.pCamera.Location = new System.Drawing.Point(268, 18);
            this.pCamera.Name = "pCamera";
            this.pCamera.Size = new System.Drawing.Size(53, 33);
            this.pCamera.Click += new System.EventHandler(this.pCamera_Click);
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Tahoma", 6F, System.Drawing.FontStyle.Regular);
            this.label13.Location = new System.Drawing.Point(12, 80);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(134, 40);
            this.label13.Text = "房屋信息";
            // 
            // pExtendedInfo
            // 
            this.pExtendedInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.pExtendedInfo.Controls.Add(this.label5);
            this.pExtendedInfo.Controls.Add(this.label11);
            this.pExtendedInfo.Location = new System.Drawing.Point(173, 18);
            this.pExtendedInfo.Name = "pExtendedInfo";
            this.pExtendedInfo.Size = new System.Drawing.Size(89, 33);
            this.pExtendedInfo.Click += new System.EventHandler(this.pExtendedInfo_Click);
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Tahoma", 6F, System.Drawing.FontStyle.Regular);
            this.label11.Location = new System.Drawing.Point(12, 80);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(134, 40);
            this.label11.Text = "房屋信息";
            // 
            // pBaseInfo
            // 
            this.pBaseInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.pBaseInfo.Controls.Add(this.label2);
            this.pBaseInfo.Controls.Add(this.label3);
            this.pBaseInfo.Location = new System.Drawing.Point(77, 18);
            this.pBaseInfo.Name = "pBaseInfo";
            this.pBaseInfo.Size = new System.Drawing.Size(91, 33);
            this.pBaseInfo.Click += new System.EventHandler(this.pBaseInfo_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 6F, System.Drawing.FontStyle.Regular);
            this.label3.Location = new System.Drawing.Point(12, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 40);
            this.label3.Text = "房屋信息";
            // 
            // pID
            // 
            this.pID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.pID.Controls.Add(this.label4);
            this.pID.Controls.Add(this.label1);
            this.pID.Location = new System.Drawing.Point(3, 18);
            this.pID.Name = "pID";
            this.pID.Size = new System.Drawing.Size(69, 33);
            this.pID.Click += new System.EventHandler(this.pID_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 6F, System.Drawing.FontStyle.Regular);
            this.label1.Location = new System.Drawing.Point(12, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 40);
            this.label1.Text = "房屋信息";
            // 
            // pFingerprint
            // 
            this.pFingerprint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.pFingerprint.Controls.Add(this.label6);
            this.pFingerprint.Controls.Add(this.label7);
            this.pFingerprint.Location = new System.Drawing.Point(327, 18);
            this.pFingerprint.Name = "pFingerprint";
            this.pFingerprint.Size = new System.Drawing.Size(53, 33);
            this.pFingerprint.Click += new System.EventHandler(this.pFingerprint_Click);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Tahoma", 6F, System.Drawing.FontStyle.Regular);
            this.label6.Location = new System.Drawing.Point(-1, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 23);
            this.label6.Text = " 指纹";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Tahoma", 6F, System.Drawing.FontStyle.Regular);
            this.label7.Location = new System.Drawing.Point(12, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 40);
            this.label7.Text = "房屋信息";
            // 
            // pControl
            // 
            this.pControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.pControl.Controls.Add(this.label8);
            this.pControl.Controls.Add(this.label9);
            this.pControl.Location = new System.Drawing.Point(386, 18);
            this.pControl.Name = "pControl";
            this.pControl.Size = new System.Drawing.Size(91, 33);
            this.pControl.Click += new System.EventHandler(this.pControl_Click);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Tahoma", 6F, System.Drawing.FontStyle.Regular);
            this.label8.Location = new System.Drawing.Point(-1, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 23);
            this.label8.Text = "已采集列表";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Tahoma", 6F, System.Drawing.FontStyle.Regular);
            this.label9.Location = new System.Drawing.Point(12, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 40);
            this.label9.Text = "房屋信息";
            // 
            // ucControlRsidentManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.pFingerprint);
            this.Controls.Add(this.pCamera);
            this.Controls.Add(this.pExtendedInfo);
            this.Controls.Add(this.pControl);
            this.Controls.Add(this.pBaseInfo);
            this.Controls.Add(this.pID);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ucControlRsidentManager";
            this.Size = new System.Drawing.Size(480, 52);
            this.pCamera.ResumeLayout(false);
            this.pExtendedInfo.ResumeLayout(false);
            this.pBaseInfo.ResumeLayout(false);
            this.pID.ResumeLayout(false);
            this.pFingerprint.ResumeLayout(false);
            this.pControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Panel pCamera;
        public System.Windows.Forms.Panel pExtendedInfo;
        public System.Windows.Forms.Panel pBaseInfo;
        public System.Windows.Forms.Panel pID;
        public System.Windows.Forms.Panel pFingerprint;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.Panel pControl;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;

    }
}
