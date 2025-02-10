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


		private string ValidateEmployeeInput(string maNV, string tenNV, string diaChi, string sdt, string matKhau, bool? isAdmin)
		{
			// Kiểm tra mã nhân viên không được để trống và phải có tối đa 5 ký tự, không dấu
			if (string.IsNullOrEmpty(maNV))
				return "Mã nhân viên không được để trống.";

			if (maNV.Length > 5) // Tối đa 5 ký tự
				return "Mã nhân viên không được nhập quá 5 ký tự.";

			if (!IsAlphaNumeric(maNV)) // Kiểm tra không chứa ký tự đặc biệt 
				return "Mã nhân viên không được chứa ký tự đặc biệt";

			// Kiểm tra tên nhân viên không được để trống
			if (string.IsNullOrEmpty(tenNV))
				return "Tên nhân viên không được để trống.";

			// Kiểm tra địa chỉ không được để trống
			if (string.IsNullOrEmpty(diaChi))
				return "Địa chỉ không được để trống.";

			// Kiểm tra số điện thoại
			if (string.IsNullOrEmpty(sdt))
				return "Số điện thoại không được để trống.";

			if (!sdt.StartsWith("0"))
				return "Số điện thoại phải bắt đầu bằng số 0.";

			if (sdt.Length != 10)
				return "Số điện thoại phải có đủ 10 chữ số.";

			if (!sdt.All(char.IsDigit))
				return "Số điện thoại chỉ được chứa các chữ số.";

			// Kiểm tra mật khẩu không được để trống
			if (string.IsNullOrEmpty(matKhau))
				return "Mật khẩu không được để trống.";

			// Kiểm tra isAdmin phải được chọn
			if (isAdmin == null)
				return "Phải chọn một trong hai quyền: Yes hoặc No.";


			return string.Empty; // Không có lỗi
		}

		// Phương thức kiểm tra ký tự không dấu
		private bool IsAlphaNumeric(string input)
		{
			return input.All(c => char.IsLetterOrDigit(c));
		}
		private bool IsMaNVExists(string maNV)
		{
			string query = "SELECT COUNT(*) FROM NhanVien WHERE MaNV = @MaNV";
			object result = DataProvider.Instance.ExcuteScalar(query, new object[] { maNV });

			return Convert.ToInt32(result) > 0;
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

				// Kiểm tra isAdmin (cần phải chọn một trong hai radio button)
				bool? isAdmin = rbtn_Yes.Checked ? true : rbtn_No.Checked ? (bool?)false : null;

				// Kiểm tra tính hợp lệ của đầu vào
				string validationMessage = ValidateEmployeeInput(maNV, tenNV, diaChi, sdt, matKhau, isAdmin);
				if (!string.IsNullOrEmpty(validationMessage))
				{
					MessageBox.Show(validationMessage, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				// Kiểm tra mã nhân viên đã tồn tại hay chưa
				if (IsMaNVExists(maNV))
				{
					MessageBox.Show("Mã nhân viên đã tồn tại, vui lòng nhập mã khác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

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
			DateTime ngaySinh = dtp_NgaySinh.Value;
			string diaChi = txt_DiaChi.Text;
			string sdt = txt_SDT.Text;
			string matKhau = txt_MatKhau.Text;

			// Kiểm tra isAdmin (cần phải chọn một trong hai radio button)
			bool? isAdmin = rbtn_Yes.Checked ? (bool?)true : rbtn_No.Checked ? (bool?)false : null;

			// Kiểm tra tính hợp lệ của đầu vào
			string validationMessage = ValidateEmployeeInput(maNV, tenNV, diaChi, sdt, matKhau, isAdmin);
			if (!string.IsNullOrEmpty(validationMessage))
			{
				MessageBox.Show(validationMessage, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			// Kiểm tra mã nhân viên đã tồn tại trước khi cập nhật
			if (!IsMaNVExists(maNV))
			{
				MessageBox.Show("Mã nhân viên không tồn tại, không thể cập nhật.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}


			string query = "UPDATE NhanVien SET TenNV = @TenNV , NgaySinh = @NgaySinh  , DiaChi = @DiaChi , DienThoai = @DienThoai , IsAdmin = @IsAdmin , MatKhau = @MatKhau  WHERE MaNV = @MaNV";
			object[] parameters = { tenNV, ngaySinh, diaChi, sdt, isAdmin, matKhau, maNV };

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