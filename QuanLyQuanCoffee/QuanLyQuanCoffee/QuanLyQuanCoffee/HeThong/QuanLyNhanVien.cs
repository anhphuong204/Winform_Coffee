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
    public partial class QuanLyNhanVien : Form
    {
        public QuanLyNhanVien()
        {
            InitializeComponent();
        }

        
        private void QuanLyNhanVien_Load(object sender, EventArgs e)
        {
            LoadListNV();
        }
        
        void LoadListNV()
        {
            string query = "select * from NhanVien";
            dgv_DanhSachNV.DataSource = DataProvider.Instance.ExcuteQuery(query);
        }

        

        
        private void dgv_DanhSachNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex >= 0 && e.RowIndex < dgv_DanhSachNV.Rows.Count)
            //{
            //    int rowIndex = e.RowIndex;

            //    txt_MaNV.Text = dgv_DanhSachNV.Rows[rowIndex].Cells[0].Value.ToString();
            //    txt_Ten.Text = dgv_DanhSachNV.Rows[rowIndex].Cells[1].Value.ToString();
            //    dtp_NgaySinh.Value = Convert.ToDateTime(dgv_DanhSachNV.Rows[rowIndex].Cells[2].Value);
            //    txt_DiaChi.Text = dgv_DanhSachNV.Rows[rowIndex].Cells[3].Value.ToString();
            //    txt_SDT.Text = dgv_DanhSachNV.Rows[rowIndex].Cells[4].Value.ToString();

            //    object isAdminValue = dgv_DanhSachNV.Rows[rowIndex].Cells[5].Value;
            //    bool isAdmin;

            //    if (isAdminValue != null && bool.TryParse(isAdminValue.ToString(), out isAdmin))
            //    {
            //        rbtn_Yes.Checked = isAdmin;
            //        rbtn_No.Checked = !isAdmin;
            //    }
            //    else
            //    {
            //        // Xử lý trường hợp giá trị là null hoặc không phải là boolean hợp lệ
            //        rbtn_Yes.Checked = false;
            //        rbtn_No.Checked = false;
            //    }

            //    txt_MatKhau.Text = dgv_DanhSachNV.Rows[rowIndex].Cells[6].Value.ToString();
            //}
        }

        

        private void txt_SearchID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Them_Click_1(object sender, EventArgs e)
        {
            try
            {
                string maNV = txt_MaNV.Text;
                string tenNV = txt_Ten.Text;
                DateTime ngaySinh = dtp_NgaySinh.Value;
                string diaChi = txt_DiaChi.Text;
                string sdt = txt_SDT.Text;
                string matKhau = txt_MatKhau.Text;

                bool isAdmin = rbtn_Yes.Checked;

                string query = "INSERT INTO NhanVien(MaNV, TenNV, NgaySinh, DiaChi, DienThoai, IsAdmin, MatKhau) " +
                               "VALUES( @MaNV , @TenNV , @NgaySinh , @DiaChi , @DienThoai , @IsAdmin , @MatKhau )";

                object[] parameters = { maNV, tenNV, ngaySinh, diaChi, sdt, isAdmin, matKhau };

                int result = DataProvider.Instance.ExcuteNonQuery(query, parameters);

                if (result > 0)
                {
                    MessageBox.Show("Thêm nhân viên thành công");
                    LoadListNV();
                }
                else
                {
                    MessageBox.Show("Thêm nhân viên thất bại");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }

        }

        private void btn_Xoa_Click_1(object sender, EventArgs e)
        {
            string maNV = txt_MaNV.Text;
            string query = "delete from NhanVien where MaNV = @MaNV";
            object[] parameters = { maNV };
            int result = DataProvider.Instance.ExcuteNonQuery(query, parameters);
            if (result > 0)
            {
                MessageBox.Show("Xóa nhân viên thành công");
                LoadListNV();
            }
            else
            {
                MessageBox.Show("Xóa nhân viên thất bại");
            }
        }

        private void btn_CapNhat_Click_1(object sender, EventArgs e)
        {
            string maNV = txt_MaNV.Text;
            string tenNV = txt_Ten.Text;
            string ngaySinh = dtp_NgaySinh.Value.ToString("yyyy-MM-dd");
            string diaChi = txt_DiaChi.Text;
            string sdt = txt_SDT.Text;
            int? isadmin = null;
            string matkhau = txt_MatKhau.Text;

            if (rbtn_Yes.Checked)
            {
                isadmin = 1;
            }
            else if (rbtn_No.Checked)
            {
                isadmin = 0;
            }

            string query = "UPDATE NhanVien SET TenNV = @TenNV , NgaySinh = @NgaySinh  , DiaChi = @DiaChi , DienThoai = @DienThoai , IsAdmin = @IsAdmin , MatKhau = @MatKhau  WHERE MaNV = @MaNV ";
            object[] parameters = { tenNV, ngaySinh, diaChi, sdt, isadmin, matkhau, maNV };

            int result = DataProvider.Instance.ExcuteNonQuery(query, parameters);

            if (result > 0)
            {
                MessageBox.Show("Cập nhật nhân viên thành công");
                LoadListNV();
            }
            else
            {
                MessageBox.Show("Cập nhật nhân viên thất bại");
            }
        }

        private void dgv_DanhSachNV_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgv_DanhSachNV.Rows.Count)
            {
                try
                {
                    int rowIndex = e.RowIndex;

                    txt_MaNV.Text = dgv_DanhSachNV.Rows[rowIndex].Cells[0].Value?.ToString();
                    txt_Ten.Text = dgv_DanhSachNV.Rows[rowIndex].Cells[1].Value?.ToString();
                    dtp_NgaySinh.Value = Convert.ToDateTime(dgv_DanhSachNV.Rows[rowIndex].Cells[2].Value);

                    txt_DiaChi.Text = dgv_DanhSachNV.Rows[rowIndex].Cells[3].Value?.ToString();
                    txt_SDT.Text = dgv_DanhSachNV.Rows[rowIndex].Cells[4].Value?.ToString();

                    object isAdminValue = dgv_DanhSachNV.Rows[rowIndex].Cells[5].Value;
                    bool isAdmin;

                    if (isAdminValue != null && bool.TryParse(isAdminValue.ToString(), out isAdmin))
                    {
                        rbtn_Yes.Checked = isAdmin;
                        rbtn_No.Checked = !isAdmin;
                    }
                    else
                    {
                        // Handle the case where the value is null or not a valid boolean
                        rbtn_Yes.Checked = false;
                        rbtn_No.Checked = false;
                    }

                    txt_MatKhau.Text = dgv_DanhSachNV.Rows[rowIndex].Cells[6].Value?.ToString();
                }
                catch (Exception ex)
                {
                    return;
                    //MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btn_Back_Click_1(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            this.Close();
            admin.Show();
        }
    }
}
