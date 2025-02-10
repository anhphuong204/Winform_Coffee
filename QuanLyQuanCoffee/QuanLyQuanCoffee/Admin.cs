using QuanLyQuanCoffee.HeThong;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QuanLyQuanCoffee.QuanLy;
using QuanLyQuanCoffee.HoaDon;
using QuanLyQuanCoffee.Class;


namespace QuanLyQuanCoffee
{
    public partial class Admin : Form
    {
		// Khai báo biến ControlResizer
		private ControlResizer controlResizer;
		public Admin()
        {
            InitializeComponent();
			// Khởi tạo ControlResizer và áp dụng cho form này
			controlResizer = new ControlResizer(this);
		}

        private void msi_QuanLyNV_Click(object sender, EventArgs e)
        {
            QuanLyNhanVien q = new QuanLyNhanVien();
            this.Hide();
            q.Show();
        }

        private void msi_Exit_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Bạn có muốn đăng xuất tài khoản không ?", "Đăng xuất", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (DialogResult == DialogResult.OK)
            {
                Login login = new Login();
                this.Close();
                login.Show();
            }
        }

        private void msi_DoiMK_Click(object sender, EventArgs e)
        {
            ChangePassWord c = new ChangePassWord();
            this.Close();
            c.Show();
        }

        private void msi_QuanLySP_Click(object sender, EventArgs e)
        {
            QuanLySanPham sp = new QuanLySanPham();
            this.Hide();
            sp.Show();
        }

        private void msi_QuanLyBan_Click(object sender, EventArgs e)
        {
            QuanLyBan ban = new QuanLyBan();
            this.Hide();
            ban.Show();
        }

        private void xemHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XemHoaDon hd = new XemHoaDon();
            this.Hide();
            hd.Show();
        }

        private void bánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BanHang bh = new BanHang();
			this.Hide();
			bh.Show();
        }

        private void msi_ThongKe_Click(object sender, EventArgs e)
        {
            ThongKe tk = new ThongKe();
			this.Hide();
			tk.Show();
        }

        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongKe tk = new ThongKe();
			this.Hide();
			tk.Show();
        }

       

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Bạn có muốn đóng chương trình không ?", "Đóng chương trình", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (DialogResult == DialogResult.OK)
            {
                Application.Exit();
            }
        }

	}
}
