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

namespace QuanLyQuanCoffee.HoaDon
{
    public partial class ChiTietPhieuXuat : Form
    {
		// Chuỗi kết nối tới cơ sở dữ liệu
		string connectionString = "Data Source=LAPTOP-UHDF2OIP\\NHAPHUONG;Persist Security Info=True;User ID=sa;Password=2902; database=QuanLyQuanCaFe";
		
		public ChiTietPhieuXuat()
        {
            InitializeComponent();
			this.Size = new Size(950, 520);

		}
		void LoadCTPX()
		{
			string query = "SELECT * FROM ChiTietPhieuXuat";
			DataTable data = DataProvider.Instance.ExcuteQuery(query);
			dgv_ChiTietPhieuXuat.DataSource = data;
		}


		private void ChiTietPhieuXuat_Load(object sender, EventArgs e)
		{
			LoadCTPX();
			LoadSoPX();
			LoadMaHang();
		}
		private void LoadSoPX()
		{
			try
			{
				// Câu truy vấn SQL lấy dữ liệu từ bảng PhieuXuat
				string query = "SELECT SoPhieuXuat FROM PhieuXuat";

				// Sử dụng SqlConnection và SqlDataAdapter để lấy dữ liệu từ bảng PhieuXuat
				using (SqlConnection connection = new SqlConnection(connectionString))
				{
					using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
					{
						// Tạo DataTable để chứa dữ liệu lấy về
						DataTable dt = new DataTable();

						// Mở kết nối
						connection.Open();

						// Đổ dữ liệu vào DataTable
						adapter.Fill(dt);

						// Gán dữ liệu vào ComboBox
						cmb_SoPX.DataSource = dt;
						cmb_SoPX.DisplayMember = "SoPhieuXuat"; // Hiển thị SoPhieuXuat
						cmb_SoPX.ValueMember = "SoPhieuXuat";   // Giá trị cũng là SoPhieuXuat

					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi khi tải dữ liệu phiếu xuất: " + ex.Message);
			}
		}
		void LoadMaHang()
		{
			string query = "SELECT MaHang FROM Hang";
			DataTable data = DataProvider.Instance.ExcuteQuery(query);

			cmb_MaHang.DataSource = data;
			cmb_MaHang.DisplayMember = "MaHang";  // Hiển thị MaHang trong ComboBox
			cmb_MaHang.ValueMember = "MaHang";    // Giá trị là MaHang
		}
		private bool KiemTraNhapLieu()
		{
			if (string.IsNullOrEmpty(cmb_SoPX.Text))
			{
				MessageBox.Show("Số phiếu xuất không được bỏ trống.");
				return false;
			}
			if (string.IsNullOrEmpty(cmb_MaHang.Text))
			{
				MessageBox.Show("Mã hàng không được bỏ trống.");
				return false;
			}
			if (string.IsNullOrEmpty(txt_SoLuong.Text))
			{
				MessageBox.Show("Số lượng không được bỏ trống.");
				return false;
			}
			if (string.IsNullOrEmpty(txt_GiaXuat.Text))
			{
				MessageBox.Show("Giá xuất không được bỏ trống.");
				return false;
			}

			return true; // Tất cả các điều kiện hợp lệ
		}
		private void btn_ThemCTPN_Click(object sender, EventArgs e)
		{
			if (!KiemTraNhapLieu())
			{
				return; // Nếu kiểm tra không thành công, thoát ra
			}

			try
			{
				// Kiểm tra xem ComboBox có giá trị hợp lệ hay không
				if (cmb_SoPX.SelectedValue == null)
				{
					MessageBox.Show("Vui lòng chọn số phiếu xuất hợp lệ.");
					return;  // Thoát ra khỏi sự kiện nếu không có giá trị
				}

				// Lấy giá trị từ ComboBox và TextBox
				string soPX = cmb_SoPX.SelectedValue.ToString();
				string maHang = cmb_MaHang.SelectedValue?.ToString() ?? "";      // Lấy mã hàng từ ComboBox, kiểm tra null

				// Kiểm tra nếu maHang rỗng
				if (string.IsNullOrEmpty(maHang))
				{
					MessageBox.Show("Vui lòng chọn mã hàng hợp lệ.");
					return;  // Thoát nếu mã hàng không hợp lệ
				}

				// Chuyển đổi SoLuong và GiaXuat sang kiểu decimal để đảm bảo đúng kiểu dữ liệu
				decimal soLuong = decimal.Parse(txt_SoLuong.Text);
				decimal giaXuat = decimal.Parse(txt_GiaXuat.Text);

				// TraLai là kiểu boolean (bit), nên sử dụng checkbox hoặc dropdown để lấy giá trị true/false
				bool traLai = chk_TraLai.Checked;

				// Kiểm tra xem SoPhieuXuat đã tồn tại trong bảng PhieuXuat hay chưa
				string checkQuery = "SELECT COUNT(*) FROM ChiTietPhieuXuat WHERE SoPhieuXuat = @SoPhieuXuat";

				using (SqlConnection connection = new SqlConnection(connectionString))
				{
					connection.Open();
					using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
					{
						checkCommand.Parameters.AddWithValue("@SoPhieuXuat", soPX);

						int count = (int)checkCommand.ExecuteScalar();

						// Nếu SoPhieuXuat đã tồn tại, hiển thị thông báo
						if (count > 0)
						{
							MessageBox.Show("Số phiếu xuất này đã tồn tại. Vui lòng chọn số phiếu khác.");
						}
						else
						{
							// Câu truy vấn SQL để thêm dữ liệu vào ChiTietPhieuXuat
							string queryCTPX = "INSERT INTO ChiTietPhieuXuat(SoPhieuXuat, MaHang, SoLuong, DonGia, TraLai) " +
											   "VALUES(@SoPhieuXuat, @MaHang, @SoLuong, @GiaXuat, @TraLai)";

							using (SqlCommand insertCommand = new SqlCommand(queryCTPX, connection))
							{
								// Thêm các tham số vào câu lệnh SQL
								insertCommand.Parameters.AddWithValue("@SoPhieuXuat", soPX);
								insertCommand.Parameters.AddWithValue("@MaHang", maHang);
								insertCommand.Parameters.AddWithValue("@SoLuong", soLuong);
								insertCommand.Parameters.AddWithValue("@GiaXuat", giaXuat);
								insertCommand.Parameters.AddWithValue("@TraLai", traLai);

								// Thực thi câu lệnh
								int resultCTPX = insertCommand.ExecuteNonQuery();

								if (resultCTPX > 0)
								{
									MessageBox.Show("Thêm chi tiết phiếu xuất thành công");
									LoadCTPX();  // Nạp lại dữ liệu
								}
								else
								{
									MessageBox.Show("Thêm chi tiết phiếu xuất thất bại");
								}
							}
						}
					}
				}
			}
			catch (FormatException)
			{
				MessageBox.Show("Định dạng đầu vào không đúng. Vui lòng kiểm tra lại các trường số lượng và đơn giá.");
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi: " + ex.Message);
			}
		}




		private void btn_XoaCTPN_Click(object sender, EventArgs e)
		{
			try
			{
				string soPX = cmb_SoPX.SelectedValue.ToString();
				string maHang = cmb_MaHang.SelectedValue.ToString();

				string query = "DELETE FROM ChiTietPhieuXuat WHERE SoPhieuXuat = @SoPhieuXuat AND MaHang = @MaHang";
				object[] parameters = { soPX, maHang };

				int result = DataProvider.Instance.ExcuteNonQuery(query, parameters);

				if (result > 0)
				{
					MessageBox.Show("Xóa chi tiết phiếu xuất thành công");
					LoadCTPX();  // Nạp lại dữ liệu
				}
				else
				{
					MessageBox.Show("Xóa chi tiết phiếu xuất thất bại");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi: " + ex.Message);
			}
		}

		private void btn_CapNhatCTPN_Click(object sender, EventArgs e)
		{
			if (!KiemTraNhapLieu())
			{
				return; // Nếu kiểm tra không thành công, thoát ra
			}

			try
			{
				// Lấy giá trị từ các điều khiển trên form
				string soPX = cmb_SoPX.SelectedValue.ToString();
				string maHang = cmb_MaHang.SelectedValue.ToString();
				int soLuong = int.Parse(txt_SoLuong.Text);
				decimal giaXuat = decimal.Parse(txt_GiaXuat.Text);
				bool traLai = chk_TraLai.Checked;

				// Kiểm tra sự tồn tại của SoPhieuXuat và MaHang trong ChiTietPhieuXuat
				string checkQuery = "SELECT COUNT(*) FROM ChiTietPhieuXuat WHERE SoPhieuXuat = @SoPhieuXuat AND MaHang = @MaHang";

				using (SqlConnection connection = new SqlConnection(connectionString))
				{
					connection.Open();
					using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
					{
						checkCommand.Parameters.AddWithValue("@SoPhieuXuat", soPX);
						checkCommand.Parameters.AddWithValue("@MaHang", maHang);

						int count = (int)checkCommand.ExecuteScalar();

						// Nếu cặp SoPhieuXuat và MaHang tồn tại
						if (count > 0)
						{
							// Câu truy vấn SQL để cập nhật dữ liệu vào ChiTietPhieuXuat
							string updateQuery = "UPDATE ChiTietPhieuXuat SET SoLuong = @SoLuong, DonGia = @GiaXuat, TraLai = @TraLai " +
												 "WHERE SoPhieuXuat = @SoPhieuXuat AND MaHang = @MaHang";

							using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
							{
								// Thêm các tham số vào câu lệnh SQL
								updateCommand.Parameters.AddWithValue("@SoPhieuXuat", soPX);
								updateCommand.Parameters.AddWithValue("@MaHang", maHang);
								updateCommand.Parameters.AddWithValue("@SoLuong", soLuong);
								updateCommand.Parameters.AddWithValue("@GiaXuat", giaXuat);
								updateCommand.Parameters.AddWithValue("@TraLai", traLai);

								// Thực thi câu lệnh
								int result = updateCommand.ExecuteNonQuery();

								if (result > 0)
								{
									MessageBox.Show("Cập nhật chi tiết phiếu xuất thành công");
									LoadCTPX();  // Nạp lại dữ liệu
								}
								else
								{
									MessageBox.Show("Cập nhật chi tiết phiếu xuất thất bại");
								}
							}
						}
						else
						{
							// Thông báo khi không tìm thấy chi tiết phiếu xuất với SoPhieuXuat và MaHang
							MessageBox.Show("Không tồn tại chi tiết phiếu xuất với Số phiếu xuất và Mã hàng này. Vui lòng kiểm tra lại.");
						}
					}
				}
			}
			catch (FormatException)
			{
				MessageBox.Show("Định dạng đầu vào không đúng. Vui lòng kiểm tra lại các trường số lượng và đơn giá.");
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi: " + ex.Message);
			}
		}


		private void btn_QuayVe_Click(object sender, EventArgs e)
		{
			XemHoaDon xhd = new XemHoaDon();
			this.Close();
			xhd.Show();
		}

		private void dgv_ChiTietPhieuXuat_CellClick(object sender, DataGridViewCellEventArgs e)
		{
				try
				{
					// Kiểm tra nếu người dùng chọn một hàng hợp lệ
					if (e.RowIndex >= 0)
					{
						// Lấy hàng hiện tại trong DataGridView
						DataGridViewRow row = dgv_ChiTietPhieuXuat.Rows[e.RowIndex];

						// Điền dữ liệu vào các điều khiển trên form
						cmb_SoPX.SelectedValue = row.Cells["SoPhieuXuat"].Value.ToString(); // Giả sử SoPhieuXuat là cột mã phiếu xuất
						cmb_MaHang.SelectedValue = row.Cells["MaHang"].Value.ToString();
						txt_SoLuong.Text = row.Cells["SoLuong"].Value.ToString();
						txt_GiaXuat.Text = row.Cells["DonGia"].Value.ToString();
						chk_TraLai.Checked = Convert.ToBoolean(row.Cells["TraLai"].Value); // Kiểm tra nếu cột Trả Lại là checkbox
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Lỗi khi chọn hàng: " + ex.Message);
				}

		}
	}
	
}
