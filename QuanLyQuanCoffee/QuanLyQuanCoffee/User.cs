using QuanLyQuanCoffee.Class;
using QuanLyQuanCoffee.HeThong;
using QuanLyQuanCoffee.HoaDon;
using QuanLyQuanCoffee.QuanLy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace QuanLyQuanCoffee
{
    public partial class User : Form
    {
		// Khai báo biến ControlResizer
		private ControlResizer controlResizer;
		string str = "Data Source=LAPTOP-UHDF2OIP\\NHAPHUONG;Persist Security Info=True;User ID=sa;Password=2902; database=QuanLyQuanCaFe";
		private string manv;
        public User(string user)
        {
            this.manv = user;
            InitializeComponent();
			// Khởi tạo ControlResizer và áp dụng cho form này
			controlResizer = new ControlResizer(this);
		}

        private void msi_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Bạn có muốn đăng xuất tài khoản không?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(DialogResult == DialogResult.Yes)
            {
                Login login = new Login();
                this.Close();
                login.Show();
            }
        }

        private void msi_ThongTinTaiKhoan_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT * FROM NhanVien WHERE MaNV = @MaNV ";

                using (SqlConnection connection = new SqlConnection(str))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MaNV", manv);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string maNV = reader["MaNV"].ToString();
                                string tenNV = reader["TenNV"].ToString();
                                
                                string ngaySinh = reader["NgaySinh"].ToString();
                                string diaChi = reader["Diachi"].ToString();
                                string soDienThoai = reader["DienThoai"].ToString();
                                string isadmin =  (bool)reader["IsAdmin"] ? "Admin" : "User";
                                string matkhau = reader["Matkhau"].ToString();

                                // Hiển thị thông tin người dùng
                                MessageBox.Show($"Thông tin tài khoản:\n" +
                                                $"Mã NV: {maNV}\n" +
                                                $"Tên NV: {tenNV}\n" +

                                                $"Ngày sinh: {ngaySinh}\n" +
                                                $"Địa chỉ: {diaChi}\n" +
                                                $"Số điện thoại: {soDienThoai}\n" +
                                                $"Status: {isadmin}\n" +
                                                $"Mật khẩu:{matkhau}");
                            }
                            else
                            {
                                MessageBox.Show("Không tìm thấy thông tin người dùng.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        
        private void msi_BanHang_Click(object sender, EventArgs e)
        {
            
            BanHang bh = new BanHang();
            this.Hide();
            bh.Show();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePassWord c = new ChangePassWord();
            this.Close();
            c.Show();
        }

       

        private void quảnLýHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XemHoaDon hd = new XemHoaDon();
            this.Hide();
            hd.Show();
        }

        private void thoátChươngTrìnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Bạn có muốn đóng chương trình không ?", "Đóng chương trình", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (DialogResult == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
