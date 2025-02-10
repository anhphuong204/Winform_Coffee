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

namespace QuanLyQuanCoffee.HeThong
{
    public partial class ChangePassWord : Form
    {
        public ChangePassWord()
        {
            InitializeComponent();
        }


        private void btn_UpdatePass_Click(object sender, EventArgs e)
        {
            string maNV = txt_User.Text;
            string matkhau = txt_Pass.Text;
            string newPass = txt_NewPass.Text;
            string newPassR = txt_NewPassR.Text;

            // Kiểm tra người dùng và mật khẩu hiện tại
            string queryCheckUser = "SELECT MaNV, Matkhau FROM NhanVien WHERE MaNV = @MaNV AND Matkhau = @Matkhau";
            object[] parametersCheckUser = { maNV, matkhau };
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
                MessageBox.Show("Người dùng hoặc mật khẩu hiện tại không đúng");
            }
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {

            this.Close();

        }

        private void lbl_FP_Click(object sender, EventArgs e)
        {
            ForgotPass f = new ForgotPass();
            f.Show();
        }
    }
}
