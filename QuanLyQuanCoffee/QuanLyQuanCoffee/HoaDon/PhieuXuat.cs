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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLyQuanCoffee.HoaDon
{
	public partial class PhieuXuat : Form
	{
		
		public PhieuXuat()
		{
			InitializeComponent();
			this.Size = new Size(1000, 570);

		}
		// Chuỗi kết nối tới cơ sở dữ liệu
		string connectionString = "Data Source=LAPTOP-UHDF2OIP\\NHAPHUONG;Persist Security Info=True;User ID=sa;Password=2902; database=QuanLyQuanCaFe";

		void LoadPX()
		{
			// Truy vấn dữ liệu từ bảng Phiếu Xuất
			string query = "SELECT * FROM PhieuXuat";
			DataTable data = DataProvider.Instance.ExcuteQuery(query);

			// Đặt DataSource của DataGridView
			dgv_PhieuXuat.DataSource = data;
		}

		void LoadComboBox()
		{
			// Nạp dữ liệu cho ComboBox MaNV
			string queryMaNV = "SELECT MaNV FROM NhanVien";
			DataTable dataMaNV = DataProvider.Instance.ExcuteQuery(queryMaNV);
			cmb_MaNV.DataSource = dataMaNV;
			cmb_MaNV.DisplayMember = "MaNV";
			cmb_MaNV.ValueMember = "MaNV";

			// Nạp dữ liệu cho ComboBox MaBan
			string queryMaBan = "SELECT MaBan FROM Ban";
			DataTable dataMaBan = DataProvider.Instance.ExcuteQuery(queryMaBan);
			cmb_MaBan.DataSource = dataMaBan;
			cmb_MaBan.DisplayMember = "MaBan";
			cmb_MaBan.ValueMember = "MaBan";

			// Nạp dữ liệu cho ComboBox LoaiKhach với cả mã và tên
			string queryLoaiKhach = "SELECT LoaiKH, TenKH FROM LoaiKhach";
			DataTable dataLoaiKhach = DataProvider.Instance.ExcuteQuery(queryLoaiKhach);
			cmb_LoaiKhach.DataSource = dataLoaiKhach;
			cmb_LoaiKhach.DisplayMember = "TenKH"; // Hiển thị tên loại khách
			cmb_LoaiKhach.ValueMember = "LoaiKH"; // Giá trị là mã loại khách
		}

		private void PhieuXuat_Load(object sender, EventArgs e)
		{
			LoadPX();          // Nạp dữ liệu vào DataGridView
			LoadComboBox();    // Nạp dữ liệu vào các ComboBox
			//this.Size = new Size(1000, 570);
		}
		private bool KiemTraNhapLieu()
		{
			// Kiểm tra trường Số Phiếu Xuất
			if (string.IsNullOrEmpty(txt_SoPX.Text))
			{
				MessageBox.Show("Vui lòng nhập Số Phiếu Xuất");
				txt_SoPX.Focus();
				return false;
			}

			// Kiểm tra trường ID
			if (string.IsNullOrEmpty(txt_ID.Text))
			{
				MessageBox.Show("Vui lòng nhập ID");
				txt_ID.Focus();
				return false;
			}

			// Kiểm tra trường Tiền Trả
			if (string.IsNullOrEmpty(txt_TienTra.Text))
			{
				MessageBox.Show("Vui lòng nhập Tiền Trả");
				txt_TienTra.Focus();
				return false;
			}

			// Kiểm tra giá trị của Tiền Trả có phải là số hợp lệ hay không
			decimal tienTra;
			if (!decimal.TryParse(txt_TienTra.Text, out tienTra))
			{
				MessageBox.Show("Tiền Trả phải là số hợp lệ");
				txt_TienTra.Focus();
				return false;
			}

			// Kiểm tra trường Thanh Toán
			if (string.IsNullOrEmpty(txt_ThanhToan.Text))
			{
				MessageBox.Show("Vui lòng nhập số tiền Thanh Toán");
				txt_ThanhToan.Focus();
				return false;
			}

			// Kiểm tra giá trị của Thanh Toán có phải là số hợp lệ hay không
			decimal thanhToan;
			if (!decimal.TryParse(txt_ThanhToan.Text, out thanhToan))
			{
				MessageBox.Show("Số tiền Thanh Toán phải là số hợp lệ");
				txt_ThanhToan.Focus();
				return false;
			}

			// Kiểm tra ComboBox MaNV
			if (cmb_MaNV.SelectedItem == null)
			{
				MessageBox.Show("Vui lòng chọn Mã Nhân Viên");
				cmb_MaNV.Focus();
				return false;
			}

			// Kiểm tra ComboBox LoaiKhach
			if (cmb_LoaiKhach.SelectedItem == null)
			{
				MessageBox.Show("Vui lòng chọn Loại Khách");
				cmb_LoaiKhach.Focus();
				return false;
			}

			// Kiểm tra ComboBox MaBan
			if (cmb_MaBan.SelectedItem == null)
			{
				MessageBox.Show("Vui lòng chọn Mã Bàn");
				cmb_MaBan.Focus();
				return false;
			}

			// Nếu tất cả các trường hợp trên đều hợp lệ
			return true;
		}
		private bool IsSoPhieuXuatExists(string soPX)
		{
			string query = "SELECT COUNT(*) FROM PhieuXuat WHERE SoPhieuXuat = @SoPhieuXuat";
			object result = DataProvider.Instance.ExcuteScalar(query, new object[] { soPX });

			return Convert.ToInt32(result) > 0;
		}

		private void btn_ThemPX_Click(object sender, EventArgs e)
		{
			// Kiểm tra dữ liệu trước khi thêm
			if (!KiemTraNhapLieu())
			{
				return; // Nếu dữ liệu không hợp lệ, dừng thực hiện
			}
			try
			{
				// Lấy dữ liệu từ các trường
				string soPX = txt_SoPX.Text;
				string id = txt_ID.Text;
				DateTime ngayXuat = dtp_NgayXuat.Value;
				string maNV = cmb_MaNV.SelectedValue.ToString();
				string loaiKH = cmb_LoaiKhach.SelectedValue.ToString();
				string maBan = cmb_MaBan.SelectedValue.ToString();
				decimal tienTra = Convert.ToDecimal(txt_TienTra.Text);
				decimal thanhToan = Convert.ToDecimal(txt_ThanhToan.Text);
				decimal tienDu;
				// Kiểm tra số phiếu nhập đã tồn tại
				if (IsSoPhieuXuatExists(soPX))
				{
					MessageBox.Show("Số phiếu xuất đã tồn tại. Vui lòng nhập số khác.");
					txt_SoPX.Focus();
					return;
				}

				// Tính tiền dư theo loại khách
				if (loaiKH == "LK001") // Ví dụ cho "Khách VIP"
				{
					tienDu = tienTra - (thanhToan - (thanhToan * 15 / 100));
					
				}
				else
				{
					tienDu = tienTra - thanhToan;
				}
				txt_TienDu.Text = tienDu.ToString(); // hiển thị tiền dư trên txt_TienDu sau khi Thêm

				string ghiChu = txt_GhiChu.Text;

				// Câu truy vấn SQL để thêm dữ liệu vào PhieuXuat
				string query = "INSERT INTO PhieuXuat (SoPhieuXuat, ID, NgayXuat, MaNV, LoaiKH, MaBan, TienTra, TienDu, GhiChu, ThanhToan) " +
							   "VALUES (@SoPhieuXuat, @ID, @NgayXuat, @MaNV, @LoaiKH, @MaBan, @TienTra, @TienDu, @GhiChu, @ThanhToan)";

				// Sử dụng SqlConnection và SqlCommand
				using (SqlConnection connection = new SqlConnection(connectionString))
				{
					using (SqlCommand command = new SqlCommand(query, connection))
					{
						// Thêm các tham số vào câu lệnh SQL
						command.Parameters.AddWithValue("@SoPhieuXuat", soPX);
						command.Parameters.AddWithValue("@ID", id);
						command.Parameters.AddWithValue("@NgayXuat", ngayXuat);
						command.Parameters.AddWithValue("@MaNV", maNV);
						command.Parameters.AddWithValue("@LoaiKH", loaiKH);
						command.Parameters.AddWithValue("@MaBan", maBan);
						command.Parameters.AddWithValue("@TienTra", tienTra);
						command.Parameters.AddWithValue("@TienDu", tienDu);
						command.Parameters.AddWithValue("@GhiChu", ghiChu);
						command.Parameters.AddWithValue("@ThanhToan", thanhToan);

						// Mở kết nối và thực thi câu lệnh
						connection.Open();
						int result = command.ExecuteNonQuery();

						// Kiểm tra kết quả và thông báo
						if (result > 0)
						{
							MessageBox.Show("Thêm phiếu xuất thành công");
							LoadPX();  // Nạp lại dữ liệu vào DataGridView
						}
						else
						{
							MessageBox.Show("Thêm phiếu xuất thất bại");
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi: " + ex.Message);
			}
		}

		

		private void btn_XoaPX_Click(object sender, EventArgs e)
		{
			try
			{
				string soPX = txt_SoPX.Text;
				string query = "DELETE FROM PhieuXuat WHERE SoPhieuXuat = @SoPhieuXuat";
				object[] parameters = { soPX };
				int result = DataProvider.Instance.ExcuteNonQuery(query, parameters);

				if (result > 0)
				{
					MessageBox.Show("Xóa phiếu xuất thành công");
					LoadPX();  // Nạp lại dữ liệu
				}
				else
				{
					MessageBox.Show("Xóa phiếu xuất thất bại");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi: " + ex.Message);
			}
		}

		private void btn_CapNhatPX_Click(object sender, EventArgs e)
		{
			// Kiểm tra dữ liệu trước khi thêm
			if (!KiemTraNhapLieu())
			{
				return; // Nếu dữ liệu không hợp lệ, dừng thực hiện
			}
			try
			{
				string soPX = txt_SoPX.Text;
				string id = txt_ID.Text;
				DateTime ngayXuat = dtp_NgayXuat.Value;
				string maNV = cmb_MaNV.SelectedValue.ToString();
				string loaiKH = cmb_LoaiKhach.SelectedValue.ToString();
				string maBan = cmb_MaBan.SelectedValue.ToString();
				decimal tienTra = Convert.ToDecimal(txt_TienTra.Text);
				decimal thanhToan = Convert.ToDecimal(txt_ThanhToan.Text);
				decimal tienDu;
				if (!IsSoPhieuXuatExists(soPX))
				{
					MessageBox.Show("Số phiếu xuất không tồn tại. Vui lòng kiểm tra lại.");
					txt_SoPX.Focus();
					return;
				}

				// Tính tiền dư theo điều kiện loại khách
				if (loaiKH == "LK001")
				{
					tienDu = tienTra - (thanhToan - (thanhToan * 15/100));
				}
				else
				{
					tienDu = tienTra - thanhToan;
				}

				string ghiChu = txt_GhiChu.Text;


				string query = "UPDATE PhieuXuat SET ID = @ID, NgayXuat = @NgayXuat, MaNV = @MaNV, LoaiKH = @LoaiKH, MaBan = @MaBan, " +
							   "TienTra = @TienTra, TienDu = @TienDu, GhiChu = @GhiChu, ThanhToan = @ThanhToan " +
							   "WHERE SoPhieuXuat = @SoPhieuXuat";
				// Sử dụng SqlConnection và SqlCommand
				using (SqlConnection connection = new SqlConnection(connectionString))
				{
					using (SqlCommand command = new SqlCommand(query, connection))
					{
						// Thêm các tham số vào câu lệnh SQL
						command.Parameters.AddWithValue("@SoPhieuXuat", soPX);
						command.Parameters.AddWithValue("@ID", id);
						command.Parameters.AddWithValue("@NgayXuat", ngayXuat);
						command.Parameters.AddWithValue("@MaNV", maNV);
						command.Parameters.AddWithValue("@LoaiKH", loaiKH);
						command.Parameters.AddWithValue("@MaBan", maBan);
						command.Parameters.AddWithValue("@TienTra", tienTra);
						command.Parameters.AddWithValue("@TienDu", tienDu);
						command.Parameters.AddWithValue("@GhiChu", ghiChu);
						command.Parameters.AddWithValue("@ThanhToan", thanhToan);

						// Mở kết nối và thực thi câu lệnh
						connection.Open();
						int result = command.ExecuteNonQuery();

						if (result > 0)
						{
							MessageBox.Show("Cập nhật phiếu xuất thành công");
							LoadPX();  // Nạp lại dữ liệu
						}
						else
						{
							MessageBox.Show("Cập nhật phiếu xuất thất bại");
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi: " + ex.Message);
			}
		}

		private void txt_TienTra_TextChanged(object sender, EventArgs e)
		{
			CalculateTienDu();
		}

		private void txt_ThanhToan_TextChanged(object sender, EventArgs e)
		{
			CalculateTienDu();
		}


		private void CalculateTienDu()
		{
			try
			{
				decimal tienTra = Convert.ToDecimal(txt_TienTra.Text);
				decimal thanhToan = Convert.ToDecimal(txt_ThanhToan.Text);
				string loaiKH = cmb_LoaiKhach.SelectedValue.ToString();
				decimal tienDu;

				// Tính tiền dư theo điều kiện loại khách
				if (loaiKH == "LK001")
				{
					tienDu = tienTra - (thanhToan - (thanhToan * 15/100));
				}
				else
				{
					tienDu = tienTra - thanhToan;
				}

				txt_TienDu.Text = tienDu.ToString("N2"); // Hiển thị tiền dư với định dạng số thập phân
			}
			catch
			{
				txt_TienDu.Text = "0"; // Đặt tiền dư thành 0 nếu có lỗi
			}
		}

		private void btn_QuayVe_Click(object sender, EventArgs e)
		{
			XemHoaDon xhd = new XemHoaDon();
			this.Close();
			xhd.Show();
		}

		

		private void dgv_PhieuXuat_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			
				try
				{
					// Kiểm tra nếu người dùng chọn một hàng hợp lệ
					if (e.RowIndex >= 0)
					{
						// Lấy hàng hiện tại trong DataGridView
						DataGridViewRow row = dgv_PhieuXuat.Rows[e.RowIndex];

						// Điền dữ liệu vào các điều khiển trên form
						txt_SoPX.Text = row.Cells["SoPhieuXuat"].Value.ToString();
						txt_ID.Text = row.Cells["ID"].Value.ToString();
						dtp_NgayXuat.Value = Convert.ToDateTime(row.Cells["NgayXuat"].Value);
						cmb_MaNV.SelectedValue = row.Cells["MaNV"].Value.ToString();
						cmb_LoaiKhach.SelectedValue = row.Cells["LoaiKH"].Value.ToString();
						cmb_MaBan.SelectedValue = row.Cells["MaBan"].Value.ToString();
						txt_TienTra.Text = row.Cells["TienTra"].Value.ToString();
						txt_ThanhToan.Text = row.Cells["ThanhToan"].Value.ToString();
						txt_TienDu.Text = row.Cells["TienDu"].Value.ToString();
						txt_GhiChu.Text = row.Cells["GhiChu"].Value?.ToString(); // Xử lý nếu cột ghi chú có thể null
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Lỗi khi chọn hàng: " + ex.Message);
				}
			

		}
	}
}
