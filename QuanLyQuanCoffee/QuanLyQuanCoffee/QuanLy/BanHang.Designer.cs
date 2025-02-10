namespace QuanLyQuanCoffee.QuanLy
{
    partial class BanHang
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BanHang));
			this.btn_Quaylai = new System.Windows.Forms.Button();
			this.btn_In = new System.Windows.Forms.Button();
			this.btn_CapNhat = new System.Windows.Forms.Button();
			this.btn_Xoa = new System.Windows.Forms.Button();
			this.btn_Them = new System.Windows.Forms.Button();
			this.dgv_BanHang = new System.Windows.Forms.DataGridView();
			this.cmb_SoLuong = new System.Windows.Forms.ComboBox();
			this.cmb_MaBan = new System.Windows.Forms.ComboBox();
			this.cmb_MaHang = new System.Windows.Forms.ComboBox();
			this.txt_ThanhTien = new System.Windows.Forms.TextBox();
			this.txt_GiaSP = new System.Windows.Forms.TextBox();
			this.txt_MaNV = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.a = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.l = new System.Windows.Forms.Label();
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.dtp_Ngay = new System.Windows.Forms.DateTimePicker();
			this.label2 = new System.Windows.Forms.Label();
			this.txt_MaBanHang = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dgv_BanHang)).BeginInit();
			this.SuspendLayout();
			// 
			// btn_Quaylai
			// 
			this.btn_Quaylai.BackColor = System.Drawing.Color.White;
			this.btn_Quaylai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Quaylai.Location = new System.Drawing.Point(1106, 825);
			this.btn_Quaylai.Name = "btn_Quaylai";
			this.btn_Quaylai.Size = new System.Drawing.Size(177, 72);
			this.btn_Quaylai.TabIndex = 0;
			this.btn_Quaylai.Text = "Quay lại";
			this.btn_Quaylai.UseVisualStyleBackColor = false;
			this.btn_Quaylai.Click += new System.EventHandler(this.btn_Quaylai_Click);
			// 
			// btn_In
			// 
			this.btn_In.BackColor = System.Drawing.Color.White;
			this.btn_In.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_In.Location = new System.Drawing.Point(912, 825);
			this.btn_In.Name = "btn_In";
			this.btn_In.Size = new System.Drawing.Size(135, 72);
			this.btn_In.TabIndex = 0;
			this.btn_In.Text = "In";
			this.btn_In.UseVisualStyleBackColor = false;
			this.btn_In.Click += new System.EventHandler(this.btn_In_Click);
			// 
			// btn_CapNhat
			// 
			this.btn_CapNhat.BackColor = System.Drawing.Color.White;
			this.btn_CapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_CapNhat.Location = new System.Drawing.Point(670, 825);
			this.btn_CapNhat.Name = "btn_CapNhat";
			this.btn_CapNhat.Size = new System.Drawing.Size(172, 72);
			this.btn_CapNhat.TabIndex = 0;
			this.btn_CapNhat.Text = "Cập nhật";
			this.btn_CapNhat.UseVisualStyleBackColor = false;
			this.btn_CapNhat.Click += new System.EventHandler(this.btn_CapNhat_Click);
			// 
			// btn_Xoa
			// 
			this.btn_Xoa.BackColor = System.Drawing.Color.White;
			this.btn_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Xoa.Location = new System.Drawing.Point(454, 825);
			this.btn_Xoa.Name = "btn_Xoa";
			this.btn_Xoa.Size = new System.Drawing.Size(152, 72);
			this.btn_Xoa.TabIndex = 0;
			this.btn_Xoa.Text = "Xóa";
			this.btn_Xoa.UseVisualStyleBackColor = false;
			this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
			// 
			// btn_Them
			// 
			this.btn_Them.BackColor = System.Drawing.Color.White;
			this.btn_Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Them.Location = new System.Drawing.Point(230, 825);
			this.btn_Them.Name = "btn_Them";
			this.btn_Them.Size = new System.Drawing.Size(152, 72);
			this.btn_Them.TabIndex = 0;
			this.btn_Them.Text = "Thêm";
			this.btn_Them.UseVisualStyleBackColor = false;
			this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
			// 
			// dgv_BanHang
			// 
			this.dgv_BanHang.BackgroundColor = System.Drawing.Color.White;
			this.dgv_BanHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_BanHang.Location = new System.Drawing.Point(198, 167);
			this.dgv_BanHang.Name = "dgv_BanHang";
			this.dgv_BanHang.RowHeadersWidth = 82;
			this.dgv_BanHang.RowTemplate.Height = 33;
			this.dgv_BanHang.Size = new System.Drawing.Size(1129, 634);
			this.dgv_BanHang.TabIndex = 0;
			this.dgv_BanHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_BanHang_CellClick);
			// 
			// cmb_SoLuong
			// 
			this.cmb_SoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.cmb_SoLuong.FormattingEnabled = true;
			this.cmb_SoLuong.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
			this.cmb_SoLuong.Location = new System.Drawing.Point(1590, 650);
			this.cmb_SoLuong.Name = "cmb_SoLuong";
			this.cmb_SoLuong.Size = new System.Drawing.Size(306, 54);
			this.cmb_SoLuong.TabIndex = 4;
			this.cmb_SoLuong.SelectedIndexChanged += new System.EventHandler(this.cmb_SoLuong_SelectedIndexChanged);
			// 
			// cmb_MaBan
			// 
			this.cmb_MaBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.cmb_MaBan.FormattingEnabled = true;
			this.cmb_MaBan.Location = new System.Drawing.Point(1591, 363);
			this.cmb_MaBan.Name = "cmb_MaBan";
			this.cmb_MaBan.Size = new System.Drawing.Size(306, 54);
			this.cmb_MaBan.TabIndex = 2;
			// 
			// cmb_MaHang
			// 
			this.cmb_MaHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.cmb_MaHang.FormattingEnabled = true;
			this.cmb_MaHang.Location = new System.Drawing.Point(1591, 266);
			this.cmb_MaHang.Name = "cmb_MaHang";
			this.cmb_MaHang.Size = new System.Drawing.Size(306, 54);
			this.cmb_MaHang.TabIndex = 2;
			// 
			// txt_ThanhTien
			// 
			this.txt_ThanhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.txt_ThanhTien.Location = new System.Drawing.Point(1591, 742);
			this.txt_ThanhTien.Multiline = true;
			this.txt_ThanhTien.Name = "txt_ThanhTien";
			this.txt_ThanhTien.Size = new System.Drawing.Size(306, 57);
			this.txt_ThanhTien.TabIndex = 1;
			// 
			// txt_GiaSP
			// 
			this.txt_GiaSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.txt_GiaSP.Location = new System.Drawing.Point(1589, 551);
			this.txt_GiaSP.Multiline = true;
			this.txt_GiaSP.Name = "txt_GiaSP";
			this.txt_GiaSP.Size = new System.Drawing.Size(306, 56);
			this.txt_GiaSP.TabIndex = 1;
			// 
			// txt_MaNV
			// 
			this.txt_MaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.txt_MaNV.Location = new System.Drawing.Point(1591, 455);
			this.txt_MaNV.Multiline = true;
			this.txt_MaNV.Name = "txt_MaNV";
			this.txt_MaNV.Size = new System.Drawing.Size(306, 57);
			this.txt_MaNV.TabIndex = 1;
			// 
			// label8
			// 
			this.label8.BackColor = System.Drawing.Color.Transparent;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(1376, 747);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(178, 50);
			this.label8.TabIndex = 0;
			this.label8.Text = "Thành tiền";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(1376, 647);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(156, 61);
			this.label7.TabIndex = 0;
			this.label7.Text = "Số lượng";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(1375, 551);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(156, 61);
			this.label6.TabIndex = 0;
			this.label6.Text = "Giá SP";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(1377, 454);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(156, 61);
			this.label5.TabIndex = 0;
			this.label5.Text = "Mã NV";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// a
			// 
			this.a.BackColor = System.Drawing.Color.Transparent;
			this.a.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.a.Location = new System.Drawing.Point(1377, 360);
			this.a.Name = "a";
			this.a.Size = new System.Drawing.Size(156, 61);
			this.a.TabIndex = 0;
			this.a.Text = "Mã bàn";
			this.a.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(1377, 266);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(156, 61);
			this.label3.TabIndex = 0;
			this.label3.Text = "Mã hàng";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// l
			// 
			this.l.BackColor = System.Drawing.Color.Transparent;
			this.l.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.l.Location = new System.Drawing.Point(1377, 175);
			this.l.Name = "l";
			this.l.Size = new System.Drawing.Size(156, 50);
			this.l.TabIndex = 0;
			this.l.Text = "Mã bán";
			this.l.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// dtp_Ngay
			// 
			this.dtp_Ngay.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtp_Ngay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.dtp_Ngay.Location = new System.Drawing.Point(1600, 840);
			this.dtp_Ngay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.dtp_Ngay.Name = "dtp_Ngay";
			this.dtp_Ngay.Size = new System.Drawing.Size(298, 44);
			this.dtp_Ngay.TabIndex = 5;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(1336, 838);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(256, 50);
			this.label2.TabIndex = 6;
			this.label2.Text = "Ngày thanh toán";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txt_MaBanHang
			// 
			this.txt_MaBanHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.txt_MaBanHang.Location = new System.Drawing.Point(1591, 175);
			this.txt_MaBanHang.Multiline = true;
			this.txt_MaBanHang.Name = "txt_MaBanHang";
			this.txt_MaBanHang.Size = new System.Drawing.Size(306, 51);
			this.txt_MaBanHang.TabIndex = 7;
			// 
			// BanHang
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(2118, 1055);
			this.Controls.Add(this.txt_MaBanHang);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.dtp_Ngay);
			this.Controls.Add(this.cmb_SoLuong);
			this.Controls.Add(this.btn_Quaylai);
			this.Controls.Add(this.dgv_BanHang);
			this.Controls.Add(this.cmb_MaBan);
			this.Controls.Add(this.btn_In);
			this.Controls.Add(this.cmb_MaHang);
			this.Controls.Add(this.btn_CapNhat);
			this.Controls.Add(this.txt_ThanhTien);
			this.Controls.Add(this.btn_Xoa);
			this.Controls.Add(this.txt_GiaSP);
			this.Controls.Add(this.txt_MaNV);
			this.Controls.Add(this.btn_Them);
			this.Controls.Add(this.l);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.a);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label6);
			this.Name = "BanHang";
			this.Text = "BanHang";
			this.Load += new System.EventHandler(this.BanHang_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgv_BanHang)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Quaylai;
        private System.Windows.Forms.Button btn_In;
        private System.Windows.Forms.Button btn_CapNhat;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.DataGridView dgv_BanHang;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label a;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label l;
        private System.Windows.Forms.TextBox txt_ThanhTien;
        private System.Windows.Forms.TextBox txt_GiaSP;
        private System.Windows.Forms.TextBox txt_MaNV;
        private System.Windows.Forms.ComboBox cmb_MaBan;
        private System.Windows.Forms.ComboBox cmb_MaHang;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox cmb_SoLuong;
        private System.Windows.Forms.DateTimePicker dtp_Ngay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_MaBanHang;
    }
}