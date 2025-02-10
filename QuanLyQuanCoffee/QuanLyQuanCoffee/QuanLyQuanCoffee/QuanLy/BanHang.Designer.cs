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
            this.btn_Thoat = new System.Windows.Forms.Button();
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
            this.txt_Ma = new System.Windows.Forms.TextBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BanHang)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.BackColor = System.Drawing.Color.White;
            this.btn_Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Thoat.Location = new System.Drawing.Point(737, 528);
            this.btn_Thoat.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(118, 46);
            this.btn_Thoat.TabIndex = 0;
            this.btn_Thoat.Text = "Quay lại";
            this.btn_Thoat.UseVisualStyleBackColor = false;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // btn_In
            // 
            this.btn_In.BackColor = System.Drawing.Color.White;
            this.btn_In.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_In.Location = new System.Drawing.Point(608, 528);
            this.btn_In.Margin = new System.Windows.Forms.Padding(2);
            this.btn_In.Name = "btn_In";
            this.btn_In.Size = new System.Drawing.Size(90, 46);
            this.btn_In.TabIndex = 0;
            this.btn_In.Text = "In";
            this.btn_In.UseVisualStyleBackColor = false;
            this.btn_In.Click += new System.EventHandler(this.btn_In_Click);
            // 
            // btn_CapNhat
            // 
            this.btn_CapNhat.BackColor = System.Drawing.Color.White;
            this.btn_CapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CapNhat.Location = new System.Drawing.Point(447, 528);
            this.btn_CapNhat.Margin = new System.Windows.Forms.Padding(2);
            this.btn_CapNhat.Name = "btn_CapNhat";
            this.btn_CapNhat.Size = new System.Drawing.Size(115, 46);
            this.btn_CapNhat.TabIndex = 0;
            this.btn_CapNhat.Text = "Cập nhật";
            this.btn_CapNhat.UseVisualStyleBackColor = false;
            this.btn_CapNhat.Click += new System.EventHandler(this.btn_CapNhat_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.Color.White;
            this.btn_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.Location = new System.Drawing.Point(303, 528);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(101, 46);
            this.btn_Xoa.TabIndex = 0;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.Color.White;
            this.btn_Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.Location = new System.Drawing.Point(153, 528);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(101, 46);
            this.btn_Them.TabIndex = 0;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // dgv_BanHang
            // 
            this.dgv_BanHang.BackgroundColor = System.Drawing.Color.White;
            this.dgv_BanHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_BanHang.Location = new System.Drawing.Point(132, 92);
            this.dgv_BanHang.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_BanHang.Name = "dgv_BanHang";
            this.dgv_BanHang.RowHeadersWidth = 82;
            this.dgv_BanHang.RowTemplate.Height = 33;
            this.dgv_BanHang.Size = new System.Drawing.Size(751, 406);
            this.dgv_BanHang.TabIndex = 0;
            this.dgv_BanHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_BanHang_CellClick);
            // 
            // cmb_SoLuong
            // 
            this.cmb_SoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
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
            this.cmb_SoLuong.Location = new System.Drawing.Point(1065, 423);
            this.cmb_SoLuong.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_SoLuong.Name = "cmb_SoLuong";
            this.cmb_SoLuong.Size = new System.Drawing.Size(205, 37);
            this.cmb_SoLuong.TabIndex = 4;
            this.cmb_SoLuong.SelectedIndexChanged += new System.EventHandler(this.cmb_SoLuong_SelectedIndexChanged);
            // 
            // cmb_MaBan
            // 
            this.cmb_MaBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cmb_MaBan.FormattingEnabled = true;
            this.cmb_MaBan.Location = new System.Drawing.Point(1065, 219);
            this.cmb_MaBan.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_MaBan.Name = "cmb_MaBan";
            this.cmb_MaBan.Size = new System.Drawing.Size(205, 37);
            this.cmb_MaBan.TabIndex = 2;
            // 
            // cmb_MaHang
            // 
            this.cmb_MaHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cmb_MaHang.FormattingEnabled = true;
            this.cmb_MaHang.Location = new System.Drawing.Point(1065, 155);
            this.cmb_MaHang.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_MaHang.Name = "cmb_MaHang";
            this.cmb_MaHang.Size = new System.Drawing.Size(205, 37);
            this.cmb_MaHang.TabIndex = 2;
            // 
            // txt_ThanhTien
            // 
            this.txt_ThanhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_ThanhTien.Location = new System.Drawing.Point(1066, 490);
            this.txt_ThanhTien.Margin = new System.Windows.Forms.Padding(2);
            this.txt_ThanhTien.Multiline = true;
            this.txt_ThanhTien.Name = "txt_ThanhTien";
            this.txt_ThanhTien.Size = new System.Drawing.Size(205, 38);
            this.txt_ThanhTien.TabIndex = 1;
            this.txt_ThanhTien.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_GiaSP
            // 
            this.txt_GiaSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_GiaSP.Location = new System.Drawing.Point(1065, 352);
            this.txt_GiaSP.Margin = new System.Windows.Forms.Padding(2);
            this.txt_GiaSP.Multiline = true;
            this.txt_GiaSP.Name = "txt_GiaSP";
            this.txt_GiaSP.Size = new System.Drawing.Size(205, 37);
            this.txt_GiaSP.TabIndex = 1;
            this.txt_GiaSP.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_MaNV
            // 
            this.txt_MaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_MaNV.Location = new System.Drawing.Point(1065, 284);
            this.txt_MaNV.Margin = new System.Windows.Forms.Padding(2);
            this.txt_MaNV.Multiline = true;
            this.txt_MaNV.Name = "txt_MaNV";
            this.txt_MaNV.Size = new System.Drawing.Size(205, 38);
            this.txt_MaNV.TabIndex = 1;
            this.txt_MaNV.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_Ma
            // 
            this.txt_Ma.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_Ma.Location = new System.Drawing.Point(1065, 92);
            this.txt_Ma.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Ma.Multiline = true;
            this.txt_Ma.Name = "txt_Ma";
            this.txt_Ma.Size = new System.Drawing.Size(205, 34);
            this.txt_Ma.TabIndex = 1;
            this.txt_Ma.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(923, 491);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 32);
            this.label8.TabIndex = 0;
            this.label8.Text = "Thành tiền";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label8.Click += new System.EventHandler(this.label1_Click);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(923, 421);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 39);
            this.label7.TabIndex = 0;
            this.label7.Text = "Số lượng";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label7.Click += new System.EventHandler(this.label1_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(923, 352);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 39);
            this.label6.TabIndex = 0;
            this.label6.Text = "Giá SP";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.Click += new System.EventHandler(this.label1_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(923, 283);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 39);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mã NV";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Click += new System.EventHandler(this.label1_Click);
            // 
            // a
            // 
            this.a.BackColor = System.Drawing.Color.Transparent;
            this.a.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.a.Location = new System.Drawing.Point(923, 217);
            this.a.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(104, 39);
            this.a.TabIndex = 0;
            this.a.Text = "Mã bàn";
            this.a.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.a.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(923, 150);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 39);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã hàng";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // l
            // 
            this.l.BackColor = System.Drawing.Color.Transparent;
            this.l.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l.Location = new System.Drawing.Point(923, 94);
            this.l.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(104, 32);
            this.l.TabIndex = 0;
            this.l.Text = "Mã";
            this.l.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.l.Click += new System.EventHandler(this.label1_Click);
            // 
            // dtp_Ngay
            // 
            this.dtp_Ngay.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Ngay.Location = new System.Drawing.Point(1070, 559);
            this.dtp_Ngay.Name = "dtp_Ngay";
            this.dtp_Ngay.Size = new System.Drawing.Size(200, 22);
            this.dtp_Ngay.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(894, 553);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 32);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ngày thanh toán";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1412, 675);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtp_Ngay);
            this.Controls.Add(this.cmb_SoLuong);
            this.Controls.Add(this.btn_Thoat);
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
            this.Controls.Add(this.txt_Ma);
            this.Controls.Add(this.l);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.a);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BanHang";
            this.Text = "BanHang";
            this.Load += new System.EventHandler(this.BanHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BanHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Thoat;
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
        private System.Windows.Forms.TextBox txt_Ma;
        private System.Windows.Forms.ComboBox cmb_MaBan;
        private System.Windows.Forms.ComboBox cmb_MaHang;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox cmb_SoLuong;
        private System.Windows.Forms.DateTimePicker dtp_Ngay;
        private System.Windows.Forms.Label label2;
    }
}