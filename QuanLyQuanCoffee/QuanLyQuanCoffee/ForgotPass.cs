using QuanLyQuanCoffee.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCoffee
{
    public partial class ForgotPass : Form
    {
		// Khai báo biến ControlResizer
		private ControlResizer controlResizer;
		public ForgotPass()
        {
            InitializeComponent();
			// Khởi tạo ControlResizer và áp dụng cho form này
			controlResizer = new ControlResizer(this);

		}

        private void button2_Click(object sender, EventArgs e)
        {
           Login d = new Login();
            this.Close();
            d.Show();
           
        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            string maNV = txt_User.Text;
            string SDT = txt_SDT.Text;
            string newPass = txt_NewPass.Text;
            string newPassR = txt_NewPassR.Text;

            // Kiểm tra người dùng và mật khẩu hiện tại
            string queryCheckUser = "SELECT MaNV, DienThoai FROM NhanVien WHERE MaNV = @MaNV AND DienThoai = @DienThoai ";
            object[] parametersCheckUser = { maNV, SDT };
            DataTable resultTable = DataProvider.Instance.ExcuteQuery(queryCheckUser, parametersCheckUser);

            if (resultTable.Rows.Count > 0)
            {
                // Người dùng và mật khẩu hiện tại đúng, kiểm tra mật khẩu mới
                if (!string.IsNullOrEmpty(newPass) && newPass == newPassR)
                {
                    // Cập nhật mật khẩu mới
                    string queryUpdatePass = "UPDATE NhanVien SET Matkhau = @MatkhauMoi WHERE MaNV = @MaNV";
                    object[] parametersUpdatePass = { newPass, maNV };

                    int result = DataProvider.Instance.ExcuteNonQuery(queryUpdatePass, parametersUpdatePass);

                    if (result > 0)
                    {
                        MessageBox.Show("Cập nhật mật khẩu thành công");
                        Login l = new Login();
                        this.Close();
                        l.Show();
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật mật khẩu thất bại");
                    }
                }
                else
                {
                    MessageBox.Show("Mật khẩu mới không hợp lệ hoặc xác nhận mật khẩu không khớp");
                }
            }
            else
            {
                MessageBox.Show("Người dùng hoặc số điện thoại hiện tại không đúng");
            }
        }

    }
}
