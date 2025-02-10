namespace QuanLyQuanCoffee
{
    partial class Admin
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.msi_QuanLyNV = new System.Windows.Forms.ToolStripMenuItem();
			this.msi_DoiMK = new System.Windows.Forms.ToolStripMenuItem();
			this.msi_Exit = new System.Windows.Forms.ToolStripMenuItem();
			this.quảnLýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.msi_QuanLySP = new System.Windows.Forms.ToolStripMenuItem();
			this.msi_QuanLyBan = new System.Windows.Forms.ToolStripMenuItem();
			this.bánHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.quảnLýHóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.xemHóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.thốngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.Color.White;
			this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.quảnLýToolStripMenuItem,
            this.bánHàngToolStripMenuItem,
            this.quảnLýHóaĐơnToolStripMenuItem,
            this.thoátToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1296, 40);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// hệThốngToolStripMenuItem
			// 
			this.hệThốngToolStripMenuItem.BackColor = System.Drawing.Color.White;
			this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msi_QuanLyNV,
            this.msi_DoiMK,
            this.msi_Exit});
			this.hệThốngToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
			this.hệThốngToolStripMenuItem.Image = global::QuanLyQuanCoffee.Properties.Resources._9218716;
			this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
			this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(172, 36);
			this.hệThốngToolStripMenuItem.Text = "Hệ Thống";
			// 
			// msi_QuanLyNV
			// 
			this.msi_QuanLyNV.BackColor = System.Drawing.Color.White;
			this.msi_QuanLyNV.Image = global::QuanLyQuanCoffee.Properties.Resources.edit_user_xxl;
			this.msi_QuanLyNV.Name = "msi_QuanLyNV";
			this.msi_QuanLyNV.Size = new System.Drawing.Size(343, 44);
			this.msi_QuanLyNV.Text = "Quản lý nhân viên";
			this.msi_QuanLyNV.Click += new System.EventHandler(this.msi_QuanLyNV_Click);
			// 
			// msi_DoiMK
			// 
			this.msi_DoiMK.BackColor = System.Drawing.Color.White;
			this.msi_DoiMK.Image = global::QuanLyQuanCoffee.Properties.Resources.ChangePass;
			this.msi_DoiMK.Name = "msi_DoiMK";
			this.msi_DoiMK.Size = new System.Drawing.Size(343, 44);
			this.msi_DoiMK.Text = "Đổi mật khẩu";
			this.msi_DoiMK.Click += new System.EventHandler(this.msi_DoiMK_Click);
			// 
			// msi_Exit
			// 
			this.msi_Exit.BackColor = System.Drawing.Color.White;
			this.msi_Exit.Image = global::QuanLyQuanCoffee.Properties.Resources.Logout;
			this.msi_Exit.Name = "msi_Exit";
			this.msi_Exit.Size = new System.Drawing.Size(343, 44);
			this.msi_Exit.Text = "Đăng xuất";
			this.msi_Exit.Click += new System.EventHandler(this.msi_Exit_Click);
			// 
			// quảnLýToolStripMenuItem
			// 
			this.quảnLýToolStripMenuItem.BackColor = System.Drawing.Color.White;
			this.quảnLýToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msi_QuanLySP,
            this.msi_QuanLyBan});
			this.quảnLýToolStripMenuItem.Image = global::QuanLyQuanCoffee.Properties.Resources.User_manager;
			this.quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
			this.quảnLýToolStripMenuItem.Size = new System.Drawing.Size(153, 36);
			this.quảnLýToolStripMenuItem.Text = "Quản Lý";
			// 
			// msi_QuanLySP
			// 
			this.msi_QuanLySP.BackColor = System.Drawing.Color.White;
			this.msi_QuanLySP.Image = global::QuanLyQuanCoffee.Properties.Resources.Product;
			this.msi_QuanLySP.Name = "msi_QuanLySP";
			this.msi_QuanLySP.Size = new System.Drawing.Size(359, 44);
			this.msi_QuanLySP.Text = "Quản lý sản phẩm";
			this.msi_QuanLySP.Click += new System.EventHandler(this.msi_QuanLySP_Click);
			// 
			// msi_QuanLyBan
			// 
			this.msi_QuanLyBan.BackColor = System.Drawing.Color.White;
			this.msi_QuanLyBan.Image = global::QuanLyQuanCoffee.Properties.Resources.QLBan;
			this.msi_QuanLyBan.Name = "msi_QuanLyBan";
			this.msi_QuanLyBan.Size = new System.Drawing.Size(359, 44);
			this.msi_QuanLyBan.Text = "Quản lý bàn";
			this.msi_QuanLyBan.Click += new System.EventHandler(this.msi_QuanLyBan_Click);
			// 
			// bánHàngToolStripMenuItem
			// 
			this.bánHàngToolStripMenuItem.BackColor = System.Drawing.Color.White;
			this.bánHàngToolStripMenuItem.Image = global::QuanLyQuanCoffee.Properties.Resources.Cart;
			this.bánHàngToolStripMenuItem.Name = "bánHàngToolStripMenuItem";
			this.bánHàngToolStripMenuItem.Size = new System.Drawing.Size(170, 36);
			this.bánHàngToolStripMenuItem.Text = "Bán Hàng";
			this.bánHàngToolStripMenuItem.Click += new System.EventHandler(this.bánHàngToolStripMenuItem_Click);
			// 
			// quảnLýHóaĐơnToolStripMenuItem
			// 
			this.quảnLýHóaĐơnToolStripMenuItem.BackColor = System.Drawing.Color.White;
			this.quảnLýHóaĐơnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xemHóaĐơnToolStripMenuItem,
            this.thốngKêToolStripMenuItem});
			this.quảnLýHóaĐơnToolStripMenuItem.Image = global::QuanLyQuanCoffee.Properties.Resources.Order;
			this.quảnLýHóaĐơnToolStripMenuItem.Name = "quảnLýHóaĐơnToolStripMenuItem";
			this.quảnLýHóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(255, 36);
			this.quảnLýHóaĐơnToolStripMenuItem.Text = "Quản Lý Hóa Đơn";
			// 
			// xemHóaĐơnToolStripMenuItem
			// 
			this.xemHóaĐơnToolStripMenuItem.BackColor = System.Drawing.Color.White;
			this.xemHóaĐơnToolStripMenuItem.Image = global::QuanLyQuanCoffee.Properties.Resources.Order;
			this.xemHóaĐơnToolStripMenuItem.Name = "xemHóaĐơnToolStripMenuItem";
			this.xemHóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(291, 44);
			this.xemHóaĐơnToolStripMenuItem.Text = "Xem hóa đơn";
			this.xemHóaĐơnToolStripMenuItem.Click += new System.EventHandler(this.xemHóaĐơnToolStripMenuItem_Click);
			// 
			// thốngKêToolStripMenuItem
			// 
			this.thốngKêToolStripMenuItem.BackColor = System.Drawing.Color.White;
			this.thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
			this.thốngKêToolStripMenuItem.Size = new System.Drawing.Size(291, 44);
			this.thốngKêToolStripMenuItem.Text = "Thống kê";
			this.thốngKêToolStripMenuItem.Click += new System.EventHandler(this.thốngKêToolStripMenuItem_Click);
			// 
			// thoátToolStripMenuItem
			// 
			this.thoátToolStripMenuItem.Image = global::QuanLyQuanCoffee.Properties.Resources.pnghq_com_turn_off_icon_png_see_thr_1;
			this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
			this.thoátToolStripMenuItem.Size = new System.Drawing.Size(279, 36);
			this.thoátToolStripMenuItem.Text = " Thoát chương trình";
			this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
			// 
			// Admin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1296, 852);
			this.Controls.Add(this.menuStrip1);
			this.ForeColor = System.Drawing.Color.Black;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Admin";
			this.Text = "Admin";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem msi_QuanLyNV;
        private System.Windows.Forms.ToolStripMenuItem msi_DoiMK;
        private System.Windows.Forms.ToolStripMenuItem msi_Exit;
        private System.Windows.Forms.ToolStripMenuItem quảnLýToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem msi_QuanLySP;
        private System.Windows.Forms.ToolStripMenuItem msi_QuanLyBan;
        private System.Windows.Forms.ToolStripMenuItem quảnLýHóaĐơnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xemHóaĐơnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bánHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
    }
}