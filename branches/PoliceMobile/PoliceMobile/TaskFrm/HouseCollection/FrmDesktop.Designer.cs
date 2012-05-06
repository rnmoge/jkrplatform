namespace PoliceMobile.TaskFrm.HouseCollection
{
    partial class FrmDesktop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDesktop));
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbHouse = new System.Windows.Forms.PictureBox();
            this.pbCollectionPeople = new System.Windows.Forms.PictureBox();
            this.pbSearch = new System.Windows.Forms.PictureBox();
            this.lblLoginNickName = new System.Windows.Forms.Label();
            this.pQuit = new System.Windows.Forms.PictureBox();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(454, 646);
            // 
            // pbHouse
            // 
            this.pbHouse.Image = ((System.Drawing.Image)(resources.GetObject("pbHouse.Image")));
            this.pbHouse.Location = new System.Drawing.Point(59, 97);
            this.pbHouse.Name = "pbHouse";
            this.pbHouse.Size = new System.Drawing.Size(108, 95);
            this.pbHouse.Click += new System.EventHandler(this.pbHouse_Click);
            // 
            // pbCollectionPeople
            // 
            this.pbCollectionPeople.Image = ((System.Drawing.Image)(resources.GetObject("pbCollectionPeople.Image")));
            this.pbCollectionPeople.Location = new System.Drawing.Point(190, 98);
            this.pbCollectionPeople.Name = "pbCollectionPeople";
            this.pbCollectionPeople.Size = new System.Drawing.Size(108, 88);
            this.pbCollectionPeople.Click += new System.EventHandler(this.pbCollectionPeople_Click);
            // 
            // pbSearch
            // 
            this.pbSearch.Image = ((System.Drawing.Image)(resources.GetObject("pbSearch.Image")));
            this.pbSearch.Location = new System.Drawing.Point(322, 97);
            this.pbSearch.Name = "pbSearch";
            this.pbSearch.Size = new System.Drawing.Size(103, 88);
            this.pbSearch.Click += new System.EventHandler(this.pbSearch_Click);
            // 
            // lblLoginNickName
            // 
            this.lblLoginNickName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(128)))));
            this.lblLoginNickName.Font = new System.Drawing.Font("Tahoma", 6F, System.Drawing.FontStyle.Bold);
            this.lblLoginNickName.ForeColor = System.Drawing.Color.White;
            this.lblLoginNickName.Location = new System.Drawing.Point(9, 625);
            this.lblLoginNickName.Name = "lblLoginNickName";
            this.lblLoginNickName.Size = new System.Drawing.Size(133, 21);
            this.lblLoginNickName.Text = "警务室";
            // 
            // pQuit
            // 
            this.pQuit.Image = ((System.Drawing.Image)(resources.GetObject("pQuit.Image")));
            this.pQuit.Location = new System.Drawing.Point(333, 455);
            this.pQuit.Name = "pQuit";
            this.pQuit.Size = new System.Drawing.Size(93, 100);
            this.pQuit.Click += new System.EventHandler(this.pQuit_Click);
            // 
            // FrmDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(480, 588);
            this.Controls.Add(this.pQuit);
            this.Controls.Add(this.lblLoginNickName);
            this.Controls.Add(this.pbSearch);
            this.Controls.Add(this.pbCollectionPeople);
            this.Controls.Add(this.pbHouse);
            this.Controls.Add(this.pictureBox1);
            this.Location = new System.Drawing.Point(0, 0);
            this.Menu = this.mainMenu1;
            this.Name = "FrmDesktop";
            this.Text = "FrmDesktop";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pbHouse;
        private System.Windows.Forms.PictureBox pbCollectionPeople;
        private System.Windows.Forms.PictureBox pbSearch;
        private System.Windows.Forms.Label lblLoginNickName;
        private System.Windows.Forms.PictureBox pQuit;
    }
}