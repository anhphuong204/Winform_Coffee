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
			this.đổiMậtKhẩuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.quảnLýHóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.msi_Thoat = new System.Windows.Forms.ToolStripMenuItem();
			this.thoátChươngTrìnhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.Color.White;
			this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msi_BanHang,
            this.đổiMậtKhẩuToolStripMenuItem,
            this.quảnLýHóaĐơnToolStripMenuItem,
            this.msi_Thoat,
            this.thoátChươngTrìnhToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1444, 40);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// msi_BanHang
			// 
			this.msi_BanHang.Image = global::QuanLyQuanCoffee.Properties.Resources.Cart;
			this.msi_BanHang.Name = "msi_BanHang";
			this.msi_BanHang.Size = new System.Drawing.Size(167, 36);
			this.msi_BanHang.Text = "Bán hàng";
			this.msi_BanHang.Click += new System.EventHandler(this.msi_BanHang_Click);
			// 
			// đổiMậtKhẩuToolStripMenuItem
			// 
			this.đổiMậtKhẩuToolStripMenuItem.Image = global::QuanLyQuanCoffee.Properties.Resources.ChangePass;
			this.đổiMậtKhẩuToolStripMenuItem.Name = "đổiMậtKhẩuToolStripMenuItem";
			this.đổiMậtKhẩuToolStripMenuItem.Size = new System.Drawing.Size(210, 36);
			this.đổiMậtKhẩuToolStripMenuItem.Text = "Đổi mật khẩu";
			this.đổiMậtKhẩuToolStripMenuItem.Click += new System.EventHandler(this.đổiMậtKhẩuToolStripMenuItem_Click);
			// 
			// quảnLýHóaĐơnToolStripMenuItem
			// 
			this.quảnLýHóaĐơnToolStripMenuItem.Image = global::QuanLyQuanCoffee.Properties.Resources.Order;
			this.quảnLýHóaĐơnToolStripMenuItem.Name = "quảnLýHóaĐơnToolStripMenuItem";
			this.quảnLýHóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(210, 36);
			this.quảnLýHóaĐơnToolStripMenuItem.Text = "Xem hóa đơn";
			this.quảnLýHóaĐơnToolStripMenuItem.Click += new System.EventHandler(this.quảnLýHóaĐơnToolStripMenuItem_Click);
			// 
			// msi_Thoat
			// 
			this.msi_Thoat.Image = global::QuanLyQuanCoffee.Properties.Resources.Logout;
			this.msi_Thoat.Name = "msi_Thoat";
			this.msi_Thoat.Size = new System.Drawing.Size(175, 36);
			this.msi_Thoat.Text = "Đăng xuất";
			this.msi_Thoat.Click += new System.EventHandler(this.msi_Thoat_Click);
			// 
			// thoátChươngTrìnhToolStripMenuItem
			// 
			this.thoátChươngTrìnhToolStripMenuItem.Image = global::QuanLyQuanCoffee.Properties.Resources.pnghq_com_turn_off_icon_png_see_thr_1;
			this.thoátChươngTrìnhToolStripMenuItem.Name = "thoátChươngTrìnhToolStripMenuItem";
			this.thoátChươngTrìnhToolStripMenuItem.Size = new System.Drawing.Size(272, 36);
			this.thoátChươngTrìnhToolStripMenuItem.Text = "Thoát chương trình";
			this.thoátChươngTrìnhToolStripMenuItem.Click += new System.EventHandler(this.thoátChươngTrìnhToolStripMenuItem_Click);
			// 
			// User
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1444, 816);
			this.Controls.Add(this.menuStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "User";
			this.Text = "Nhân viên";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem msi_BanHang;
        private System.Windows.Forms.ToolStripMenuItem msi_Thoat;
        private System.Windows.Forms.ToolStripMenuItem đổiMậtKhẩuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátChươngTrìnhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýHóaĐơnToolStripMenuItem;
    }
}