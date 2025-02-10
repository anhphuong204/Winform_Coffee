namespace QuanLyQuanCoffee.QuanLy
{
    partial class QuanLyBan
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLyBan));
			this.btn_QuayVe = new System.Windows.Forms.Button();
			this.btn_CapNhat = new System.Windows.Forms.Button();
			this.btn_Xoa = new System.Windows.Forms.Button();
			this.btn_Them = new System.Windows.Forms.Button();
			this.dgv_ListBan = new System.Windows.Forms.DataGridView();
			this.txt_KhuVuc = new System.Windows.Forms.TextBox();
			this.txt_TenBan = new System.Windows.Forms.TextBox();
			this.txt_MaBan = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgv_ListBan)).BeginInit();
			this.SuspendLayout();
			// 
			// btn_QuayVe
			// 
			this.btn_QuayVe.BackColor = System.Drawing.Color.Transparent;
			this.btn_QuayVe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_QuayVe.ForeColor = System.Drawing.Color.Crimson;
			this.btn_QuayVe.Location = new System.Drawing.Point(1140, 670);
			this.btn_QuayVe.Name = "btn_QuayVe";
			this.btn_QuayVe.Size = new System.Drawing.Size(267, 72);
			this.btn_QuayVe.TabIndex = 0;
			this.btn_QuayVe.Text = "Quay về";
			this.btn_QuayVe.UseVisualStyleBackColor = false;
			this.btn_QuayVe.Click += new System.EventHandler(this.btn_QuayVe_Click);
			// 
			// btn_CapNhat
			// 
			this.btn_CapNhat.BackColor = System.Drawing.Color.Transparent;
			this.btn_CapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_CapNhat.ForeColor = System.Drawing.Color.Crimson;
			this.btn_CapNhat.Location = new System.Drawing.Point(1140, 547);
			this.btn_CapNhat.Name = "btn_CapNhat";
			this.btn_CapNhat.Size = new System.Drawing.Size(267, 72);
			this.btn_CapNhat.TabIndex = 0;
			this.btn_CapNhat.Text = "Cập nhật";
			this.btn_CapNhat.UseVisualStyleBackColor = false;
			this.btn_CapNhat.Click += new System.EventHandler(this.btn_CapNhat_Click);
			// 
			// btn_Xoa
			// 
			this.btn_Xoa.BackColor = System.Drawing.Color.Transparent;
			this.btn_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Xoa.ForeColor = System.Drawing.Color.Crimson;
			this.btn_Xoa.Location = new System.Drawing.Point(1140, 416);
			this.btn_Xoa.Name = "btn_Xoa";
			this.btn_Xoa.Size = new System.Drawing.Size(267, 72);
			this.btn_Xoa.TabIndex = 0;
			this.btn_Xoa.Text = "Xóa";
			this.btn_Xoa.UseVisualStyleBackColor = false;
			this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
			// 
			// btn_Them
			// 
			this.btn_Them.BackColor = System.Drawing.Color.Transparent;
			this.btn_Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Them.ForeColor = System.Drawing.Color.Crimson;
			this.btn_Them.Location = new System.Drawing.Point(1140, 286);
			this.btn_Them.Name = "btn_Them";
			this.btn_Them.Size = new System.Drawing.Size(267, 72);
			this.btn_Them.TabIndex = 0;
			this.btn_Them.Text = "Thêm";
			this.btn_Them.UseVisualStyleBackColor = false;
			this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
			// 
			// dgv_ListBan
			// 
			this.dgv_ListBan.BackgroundColor = System.Drawing.Color.White;
			this.dgv_ListBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_ListBan.Location = new System.Drawing.Point(153, 242);
			this.dgv_ListBan.Name = "dgv_ListBan";
			this.dgv_ListBan.RowHeadersWidth = 82;
			this.dgv_ListBan.RowTemplate.Height = 33;
			this.dgv_ListBan.Size = new System.Drawing.Size(921, 550);
			this.dgv_ListBan.TabIndex = 0;
			this.dgv_ListBan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ListBan_CellClick);
			// 
			// txt_KhuVuc
			// 
			this.txt_KhuVuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.txt_KhuVuc.Location = new System.Drawing.Point(1101, 128);
			this.txt_KhuVuc.Multiline = true;
			this.txt_KhuVuc.Name = "txt_KhuVuc";
			this.txt_KhuVuc.Size = new System.Drawing.Size(304, 63);
			this.txt_KhuVuc.TabIndex = 2;
			// 
			// txt_TenBan
			// 
			this.txt_TenBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.txt_TenBan.Location = new System.Drawing.Point(614, 127);
			this.txt_TenBan.Multiline = true;
			this.txt_TenBan.Name = "txt_TenBan";
			this.txt_TenBan.Size = new System.Drawing.Size(316, 63);
			this.txt_TenBan.TabIndex = 2;
			// 
			// txt_MaBan
			// 
			this.txt_MaBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.txt_MaBan.Location = new System.Drawing.Point(268, 127);
			this.txt_MaBan.Multiline = true;
			this.txt_MaBan.Name = "txt_MaBan";
			this.txt_MaBan.Size = new System.Drawing.Size(160, 63);
			this.txt_MaBan.TabIndex = 2;
			this.txt_MaBan.Text = "B";
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label4.ForeColor = System.Drawing.Color.Crimson;
			this.label4.Location = new System.Drawing.Point(946, 128);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(148, 62);
			this.label4.TabIndex = 1;
			this.label4.Text = "Khu vực";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label3.ForeColor = System.Drawing.Color.Crimson;
			this.label3.Location = new System.Drawing.Point(460, 127);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(136, 62);
			this.label3.TabIndex = 1;
			this.label3.Text = "Tên bàn";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label2.ForeColor = System.Drawing.Color.Crimson;
			this.label2.Location = new System.Drawing.Point(114, 128);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(136, 62);
			this.label2.TabIndex = 1;
			this.label2.Text = "Mã bàn";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// QuanLyBan
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1586, 934);
			this.Controls.Add(this.txt_KhuVuc);
			this.Controls.Add(this.txt_TenBan);
			this.Controls.Add(this.btn_QuayVe);
			this.Controls.Add(this.txt_MaBan);
			this.Controls.Add(this.dgv_ListBan);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.btn_CapNhat);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.btn_Xoa);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btn_Them);
			this.Name = "QuanLyBan";
			this.Load += new System.EventHandler(this.QuanLyBan_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgv_ListBan)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_ListBan;
        private System.Windows.Forms.Button btn_QuayVe;
        private System.Windows.Forms.Button btn_CapNhat;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.TextBox txt_KhuVuc;
        private System.Windows.Forms.TextBox txt_TenBan;
        private System.Windows.Forms.TextBox txt_MaBan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}