namespace QuanLyQuanCoffee.HoaDon
{
    partial class PhieuNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhieuNhap));
            this.dgv_PhieuNhap = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtp_NgayNhap = new System.Windows.Forms.DateTimePicker();
            this.txt_GhiChu = new System.Windows.Forms.TextBox();
            this.txt_MaNV = new System.Windows.Forms.TextBox();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.txt_SoPN = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_ThemPN = new System.Windows.Forms.Button();
            this.btn_XoaPN = new System.Windows.Forms.Button();
            this.btn_CapNhatPN = new System.Windows.Forms.Button();
            this.btn_QuayVe = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PhieuNhap)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_PhieuNhap
            // 
            this.dgv_PhieuNhap.BackgroundColor = System.Drawing.Color.White;
            this.dgv_PhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_PhieuNhap.Location = new System.Drawing.Point(3, 19);
            this.dgv_PhieuNhap.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_PhieuNhap.Name = "dgv_PhieuNhap";
            this.dgv_PhieuNhap.RowHeadersWidth = 82;
            this.dgv_PhieuNhap.RowTemplate.Height = 33;
            this.dgv_PhieuNhap.Size = new System.Drawing.Size(666, 438);
            this.dgv_PhieuNhap.TabIndex = 0;
            this.dgv_PhieuNhap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_PhieuNhap_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LavenderBlush;
            this.panel1.Controls.Add(this.dtp_NgayNhap);
            this.panel1.Controls.Add(this.txt_GhiChu);
            this.panel1.Controls.Add(this.txt_MaNV);
            this.panel1.Controls.Add(this.txt_ID);
            this.panel1.Controls.Add(this.txt_SoPN);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_ThemPN);
            this.panel1.Controls.Add(this.btn_XoaPN);
            this.panel1.Controls.Add(this.btn_CapNhatPN);
            this.panel1.Location = new System.Drawing.Point(701, 94);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(462, 438);
            this.panel1.TabIndex = 2;
            // 
            // dtp_NgayNhap
            // 
            this.dtp_NgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_NgayNhap.Location = new System.Drawing.Point(129, 161);
            this.dtp_NgayNhap.Margin = new System.Windows.Forms.Padding(2);
            this.dtp_NgayNhap.Name = "dtp_NgayNhap";
            this.dtp_NgayNhap.Size = new System.Drawing.Size(135, 22);
            this.dtp_NgayNhap.TabIndex = 3;
            // 
            // txt_GhiChu
            // 
            this.txt_GhiChu.Location = new System.Drawing.Point(122, 282);
            this.txt_GhiChu.Margin = new System.Windows.Forms.Padding(2);
            this.txt_GhiChu.Multiline = true;
            this.txt_GhiChu.Name = "txt_GhiChu";
            this.txt_GhiChu.Size = new System.Drawing.Size(289, 35);
            this.txt_GhiChu.TabIndex = 2;
            // 
            // txt_MaNV
            // 
            this.txt_MaNV.Location = new System.Drawing.Point(122, 213);
            this.txt_MaNV.Margin = new System.Windows.Forms.Padding(2);
            this.txt_MaNV.Multiline = true;
            this.txt_MaNV.Name = "txt_MaNV";
            this.txt_MaNV.Size = new System.Drawing.Size(289, 35);
            this.txt_MaNV.TabIndex = 2;
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(122, 89);
            this.txt_ID.Margin = new System.Windows.Forms.Padding(2);
            this.txt_ID.Multiline = true;
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(289, 35);
            this.txt_ID.TabIndex = 2;
            // 
            // txt_SoPN
            // 
            this.txt_SoPN.Location = new System.Drawing.Point(122, 25);
            this.txt_SoPN.Margin = new System.Windows.Forms.Padding(2);
            this.txt_SoPN.Multiline = true;
            this.txt_SoPN.Name = "txt_SoPN";
            this.txt_SoPN.Size = new System.Drawing.Size(289, 35);
            this.txt_SoPN.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 281);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 34);
            this.label5.TabIndex = 1;
            this.label5.Text = "Ghi chú";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 213);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 34);
            this.label4.TabIndex = 1;
            this.label4.Text = "Mã NV";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 153);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 34);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ngày nhập";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "Số PN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_ThemPN
            // 
            this.btn_ThemPN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThemPN.Location = new System.Drawing.Point(23, 332);
            this.btn_ThemPN.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ThemPN.Name = "btn_ThemPN";
            this.btn_ThemPN.Size = new System.Drawing.Size(97, 42);
            this.btn_ThemPN.TabIndex = 0;
            this.btn_ThemPN.Text = "Thêm";
            this.btn_ThemPN.UseVisualStyleBackColor = true;
            this.btn_ThemPN.Click += new System.EventHandler(this.btn_ThemPN_Click);
            // 
            // btn_XoaPN
            // 
            this.btn_XoaPN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XoaPN.Location = new System.Drawing.Point(179, 332);
            this.btn_XoaPN.Margin = new System.Windows.Forms.Padding(2);
            this.btn_XoaPN.Name = "btn_XoaPN";
            this.btn_XoaPN.Size = new System.Drawing.Size(97, 42);
            this.btn_XoaPN.TabIndex = 0;
            this.btn_XoaPN.Text = "Xóa";
            this.btn_XoaPN.UseVisualStyleBackColor = true;
            this.btn_XoaPN.Click += new System.EventHandler(this.btn_XoaPN_Click);
            // 
            // btn_CapNhatPN
            // 
            this.btn_CapNhatPN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CapNhatPN.Location = new System.Drawing.Point(328, 332);
            this.btn_CapNhatPN.Margin = new System.Windows.Forms.Padding(2);
            this.btn_CapNhatPN.Name = "btn_CapNhatPN";
            this.btn_CapNhatPN.Size = new System.Drawing.Size(104, 42);
            this.btn_CapNhatPN.TabIndex = 0;
            this.btn_CapNhatPN.Text = "Cập nhật";
            this.btn_CapNhatPN.UseVisualStyleBackColor = true;
            this.btn_CapNhatPN.Click += new System.EventHandler(this.btn_CapNhatPN_Click);
            // 
            // btn_QuayVe
            // 
            this.btn_QuayVe.BackColor = System.Drawing.Color.White;
            this.btn_QuayVe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QuayVe.ForeColor = System.Drawing.Color.Crimson;
            this.btn_QuayVe.Location = new System.Drawing.Point(26, 17);
            this.btn_QuayVe.Margin = new System.Windows.Forms.Padding(2);
            this.btn_QuayVe.Name = "btn_QuayVe";
            this.btn_QuayVe.Size = new System.Drawing.Size(115, 35);
            this.btn_QuayVe.TabIndex = 4;
            this.btn_QuayVe.Text = "Quay về";
            this.btn_QuayVe.UseVisualStyleBackColor = false;
            this.btn_QuayVe.Click += new System.EventHandler(this.btn_QuayVe_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.dgv_PhieuNhap);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(17, 75);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(671, 461);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phiếu nhập";
            // 
            // PhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1174, 565);
            this.Controls.Add(this.btn_QuayVe);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PhieuNhap";
            this.Text = "PhieuNhap";
            this.Load += new System.EventHandler(this.PhieuNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PhieuNhap)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_ThemPN;
        private System.Windows.Forms.Button btn_XoaPN;
        private System.Windows.Forms.Button btn_CapNhatPN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_GhiChu;
        private System.Windows.Forms.TextBox txt_MaNV;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.TextBox txt_SoPN;
        private System.Windows.Forms.DataGridView dgv_PhieuNhap;
        private System.Windows.Forms.Button btn_QuayVe;
        private System.Windows.Forms.DateTimePicker dtp_NgayNhap;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}