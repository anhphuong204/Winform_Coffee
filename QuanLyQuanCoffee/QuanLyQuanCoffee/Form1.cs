using QuanLyQuanCoffee.Class;
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

namespace QuanLyQuanCoffee
{
    public partial class Login : Form
    {
		// Khai báo biến ControlResizer
		private ControlResizer controlResizer;
		SqlConnection connection;
        SqlCommand command;
        string str = "Data Source=LAPTOP-UHDF2OIP\\NHAPHUONG;Persist Security Info=True;User ID=sa;Password=2902; database=QuanLyQuanCaFe";
        private void ConnecSQL()
        {
            if (connection == null)
            {
                connection = new SqlConnection(str);
            }
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }
        public Login()
        {
            InitializeComponent();
			// Khởi tạo ControlResizer và áp dụng cho form này
			controlResizer = new ControlResizer(this);
		}
        public string users;
        private void btn_Login_Click(object sender, EventArgs e)
        {
			
			try
			{
				string user = txt_User.Text.Trim();
				string pass = txt_PassWord.Text.Trim();

				// Kiểm tra xem tên đăng nhập hoặc mật khẩu có chứa khoảng trắng hoặc để trống
				if (string.IsNullOrWhiteSpace(user))
				{
					throw new Exception("Tên đăng nhập không được để trống hoặc chứa khoảng trắng.");
				}

				if (string.IsNullOrWhiteSpace(pass))
				{
					throw new Exception("Mật khẩu không được để trống hoặc chứa khoảng trắng.");
				}

				ConnecSQL();

				if (CheckAdmin(user, pass))
				{
					// Lưu thông tin vào Session
					Session.MaNV = user;
					Session.IsAdmin = true;

					Admin admin = new Admin();
					this.Hide();
					admin.Show();
				}
				else if (CheckUser(user, pass))
				{
					// Lưu thông tin vào Session
					Session.MaNV = user;
					Session.IsAdmin = false;

					User user1 = new User(user);
					this.Hide();
					user1.Show();
				}
				else
				{
					MessageBox.Show("Đăng nhập không thành công. Vui lòng kiểm tra lại tên đăng nhập và mật khẩu.");
				}

				users = user;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
        public bool CheckAdmin(string user, string pass)
        {
            ConnecSQL();
            using (SqlConnection connection = new SqlConnection(str))
            {
                connection.Open();

                string query = "SELECT * FROM NhanVien WHERE MaNV = @MaNV AND MatKhau = @MatKhau and IsAdmin = 1";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MaNV", user);
                    command.Parameters.AddWithValue("@MatKhau", pass);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        return reader.Read(); // Nếu có dòng dữ liệu tức là đăng nhập thành công
                    }
                }
            }
        }
        public bool CheckUser(string user, string pass)
        {
            ConnecSQL();
            using (SqlConnection connection = new SqlConnection(str))
            {
                connection.Open();

                string query = "SELECT * FROM NhanVien WHERE MaNV = @MaNV AND MatKhau = @MatKhau and IsAdmin = 0";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MaNV", user);
                    command.Parameters.AddWithValue("@MatKhau", pass);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        return reader.Read(); // Nếu có dòng dữ liệu tức là đăng nhập thành công
                    }
                }
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Bạn có muốn thoát chương trình không ?", "Thoát chương trình", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(DialogResult == DialogResult.OK)
            {
                Application.Exit();
            }
        }

       
        private void label4_Click(object sender, EventArgs e)
        {
            ForgotPass f = new ForgotPass();
            this.Hide();
            f.Show();
        }

    }
}
