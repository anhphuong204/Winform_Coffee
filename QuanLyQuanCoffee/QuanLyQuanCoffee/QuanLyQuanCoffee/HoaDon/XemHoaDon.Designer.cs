namespace QuanLyQuanCoffee.HoaDon
{
    partial class XemHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XemHoaDon));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.phiếuNhậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msi_PhieuNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.chiTiếtPhiếuNhậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýPhiếuXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(190)))), ((int)(((byte)(224)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.phiếuNhậpToolStripMenuItem,
            this.quảnLýPhiếuXuấtToolStripMenuItem,
            this.toolStripMenuItem5});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(606, 26);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // phiếuNhậpToolStripMenuItem
            // 
            this.phiếuNhậpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msi_PhieuNhap,
            this.chiTiếtPhiếuNhậpToolStripMenuItem});
            this.phiếuNhậpToolStripMenuItem.Name = "phiếuNhậpToolStripMenuItem";
            this.phiếuNhậpToolStripMenuItem.Size = new System.Drawing.Size(151, 24);
            this.phiếuNhậpToolStripMenuItem.Text = "Quản lý phiếu nhập";
            // 
            // msi_PhieuNhap
            // 
            this.msi_PhieuNhap.Name = "msi_PhieuNhap";
            this.msi_PhieuNhap.Size = new System.Drawing.Size(224, 26);
            this.msi_PhieuNhap.Text = "Phiếu nhập";
            this.msi_PhieuNhap.Click += new System.EventHandler(this.msi_PhieuNhap_Click);
            // 
            // chiTiếtPhiếuNhậpToolStripMenuItem
            // 
            this.chiTiếtPhiếuNhậpToolStripMenuItem.Name = "chiTiếtPhiếuNhậpToolStripMenuItem";
            this.chiTiếtPhiếuNhậpToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.chiTiếtPhiếuNhậpToolStripMenuItem.Text = "Chi tiết phiếu nhập";
            this.chiTiếtPhiếuNhậpToolStripMenuItem.Click += new System.EventHandler(this.chiTiếtPhiếuNhậpToolStripMenuItem_Click);
            // 
            // quảnLýPhiếuXuấtToolStripMenuItem
            // 
            this.quảnLýPhiếuXuấtToolStripMenuItem.Name = "quảnLýPhiếuXuấtToolStripMenuItem";
            this.quảnLýPhiếuXuấtToolStripMenuItem.Size = new System.Drawing.Size(146, 24);
            this.quảnLýPhiếuXuấtToolStripMenuItem.Text = "Quản lý phiếu xuất";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(77, 24);
            this.toolStripMenuItem5.Text = "Quay lại";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.quayLạiToolStripMenuItem_Click);
            // 
            // XemHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(606, 400);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "XemHoaDon";
            this.Text = "XemHoaDon";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem phiếuNhậpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem msi_PhieuNhap;
        private System.Windows.Forms.ToolStripMenuItem chiTiếtPhiếuNhậpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýPhiếuXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
    }
}