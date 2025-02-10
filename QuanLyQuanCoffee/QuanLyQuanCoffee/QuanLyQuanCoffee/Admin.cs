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


namespace QuanLyQuanCoffee
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void msi_QuanLyNV_Click(object sender, EventArgs e)
        {
            QuanLyNhanVien q = new QuanLyNhanVien();
            this.Hide();
            q.Show();
        }

        private void msi_Exit_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Bạn có muốn đăng xuất không ?", "Đăng xuất", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
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
            bh.Show();
        }

        private void msi_ThongKe_Click(object sender, EventArgs e)
        {
            ThongKe tk = new ThongKe();
            tk.Show();
        }

        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongKe tk = new ThongKe();
            tk.Show();
        }

        private void thoátChươngTrìnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Bạn có muốn tắt chương trình không ?", "Tắt chương trình", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (DialogResult == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
