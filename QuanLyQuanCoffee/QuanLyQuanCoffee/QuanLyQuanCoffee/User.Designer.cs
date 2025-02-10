namespace QuanLyQuanCoffee
{
    partial class User
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.msi_BanHang = new System.Windows.Forms.ToolStripMenuItem();
            this.msi_ThongTinTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.msi_Thoat = new System.Windows.Forms.ToolStripMenuItem();
            this.đổiMậtKhẩuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msi_BanHang,
            this.msi_ThongTinTaiKhoan,
            this.đổiMậtKhẩuToolStripMenuItem,
            this.msi_Thoat});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(775, 38);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // msi_BanHang
            // 
            this.msi_BanHang.Image = ((System.Drawing.Image)(resources.GetObject("msi_BanHang.Image")));
            this.msi_BanHang.Name = "msi_BanHang";
            this.msi_BanHang.Size = new System.Drawing.Size(117, 36);
            this.msi_BanHang.Text = "Bán hàng";
            this.msi_BanHang.Click += new System.EventHandler(this.msi_BanHang_Click);
            // 
            // msi_ThongTinTaiKhoan
            // 
            this.msi_ThongTinTaiKhoan.Image = ((System.Drawing.Image)(resources.GetObject("msi_ThongTinTaiKhoan.Image")));
            this.msi_ThongTinTaiKhoan.Name = "msi_ThongTinTaiKhoan";
            this.msi_ThongTinTaiKhoan.Size = new System.Drawing.Size(183, 36);
            this.msi_ThongTinTaiKhoan.Text = "Thông tin tài khoản";
            this.msi_ThongTinTaiKhoan.Click += new System.EventHandler(this.msi_ThongTinTaiKhoan_Click);
            // 
            // msi_Thoat
            // 
            this.msi_Thoat.Image = ((System.Drawing.Image)(resources.GetObject("msi_Thoat.Image")));
            this.msi_Thoat.Name = "msi_Thoat";
            this.msi_Thoat.Size = new System.Drawing.Size(93, 36);
            this.msi_Thoat.Text = "Thoát";
            this.msi_Thoat.Click += new System.EventHandler(this.msi_Thoat_Click);
            // 
            // đổiMậtKhẩuToolStripMenuItem
            // 
            this.đổiMậtKhẩuToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("đổiMậtKhẩuToolStripMenuItem.Image")));
            this.đổiMậtKhẩuToolStripMenuItem.Name = "đổiMậtKhẩuToolStripMenuItem";
            this.đổiMậtKhẩuToolStripMenuItem.Size = new System.Drawing.Size(144, 36);
            this.đổiMậtKhẩuToolStripMenuItem.Text = "Đổi mật khẩu";
            this.đổiMậtKhẩuToolStripMenuItem.Click += new System.EventHandler(this.đổiMậtKhẩuToolStripMenuItem_Click);
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(775, 462);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "User";
            this.Text = "Nhân viên";
            this.Load += new System.EventHandler(this.User_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem msi_BanHang;
        private System.Windows.Forms.ToolStripMenuItem msi_ThongTinTaiKhoan;
        private System.Windows.Forms.ToolStripMenuItem msi_Thoat;
        private System.Windows.Forms.ToolStripMenuItem đổiMậtKhẩuToolStripMenuItem;
    }
}