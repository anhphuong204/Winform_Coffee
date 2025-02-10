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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLyQuanCoffee.HoaDon
{
    public partial class ChiTietPhieuNhap : Form
    {
		
		public ChiTietPhieuNhap()
        {
            InitializeComponent();
			this.Size = new Size(950, 520);
			
		}
		

		void LoadCTPN()
        {
            string query = "select * from ChiTietPhieuNhap";
            dgv_CTPN.DataSource = DataProvider.Instance.ExcuteQuery(query);
        }
		private void ChiTietPhieuNhap_Load(object sender, EventArgs e)
		{
			LoadCTPN();
			LoadMaHang();
			LoadSoPhieuNhap();
		
		}

		void LoadMaHang()
		{
			string query = "SELECT MaHang FROM Hang";
			DataTable data = DataProvider.Instance.ExcuteQuery(query);

			cmb_MaHang.DataSource = data;
			cmb_MaHang.DisplayMember = "MaHang";  // Hiển thị MaHang trong ComboBox
			cmb_MaHang.ValueMember = "MaHang";    // Giá trị là MaHang
		}
		void LoadSoPhieuNhap()
		{
			string query = "SELECT SoPhieuNhap FROM PhieuNhap";
			DataTable data = DataProvider.Instance.ExcuteQuery(query);

			cmb_SoPhieuNhap.DataSource = data;
			cmb_SoPhieuNhap.DisplayMember = "SoPhieuNhap";  // Hiển thị Số Phiếu Nhập trong ComboBox
			cmb_SoPhieuNhap.ValueMember = "SoPhieuNhap";    // Giá trị là Số Phiếu Nhập
		}
		private bool KiemTraNhapLieu()
		{
			if (string.IsNullOrEmpty(cmb_SoPhieuNhap.Text))
			{
				MessageBox.Show("Số phiếu nhập không được bỏ trống.");
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
			if (string.IsNullOrEmpty(txt_GiaNhap.Text))
			{
				MessageBox.Show("Giá nhập không được bỏ trống.");
				return false;
			}

			return true; // Tất cả các điều kiện hợp lệ
		}
		



		private void btn_ThemCTPN_Click(object sender, EventArgs e)
		{
			if (!KiemTraNhapLieu())
			{
				return;  // Nếu không hợp lệ, dừng thao tác thêm
			}

			try
			{
				string spnct = cmb_SoPhieuNhap.SelectedValue.ToString();  // Lấy Số Phiếu Nhập từ ComboBox
				string mahang = cmb_MaHang.SelectedValue.ToString();      // Lấy mã hàng từ ComboBox
				string soluong = txt_SoLuong.Text;
				string gianhap = txt_GiaNhap.Text;
				
				// Kiểm tra xem cặp SoPhieuNhap và MaHang đã tồn tại chưa
				string checkQuery = "SELECT COUNT(*) FROM ChiTietPhieuNhap WHERE SoPhieuNhap = @SoPhieuNhap AND MaHang = @Mahang";
				object[] checkParams = { spnct, mahang };
				int exists = (int)DataProvider.Instance.ExcuteScalar(checkQuery, checkParams);

				if (exists > 0)
				{
					MessageBox.Show("Cặp Số Phiếu Nhập và Mã Hàng đã tồn tại trong chi tiết phiếu nhập. Vui lòng kiểm tra lại.");
					return;  // Nếu tồn tại thì không thực hiện thêm
				}

				// Truy vấn lấy giá sản phẩm từ bảng Hang dựa trên MaHang
				string queryGiaSanPham = "SELECT Gia FROM Hang WHERE MaHang = @Mahang";
				object[] parameterGiaSanPham = { mahang };
				DataTable dt = DataProvider.Instance.ExcuteQuery(queryGiaSanPham, parameterGiaSanPham);

				if (dt.Rows.Count > 0)
				{
					decimal giaSanPham = Convert.ToDecimal(dt.Rows[0]["Gia"]);
					decimal giaNhap = Convert.ToDecimal(gianhap);

					if (giaNhap > giaSanPham)
					{
						MessageBox.Show($"Giá nhập phải nhỏ hơn hoặc bằng giá sản phẩm: {giaSanPham}");
						return;
					}
				}
				else
				{
					MessageBox.Show("Không tìm thấy sản phẩm với mã hàng này.");
					return;
				}

				// Thực hiện thêm nếu giá nhập hợp lệ
				string query = "INSERT INTO ChiTietPhieuNhap(SoPhieuNhap, MaHang, SoLuong, GiaNhap) " +
							   "VALUES( @SoPhieuNhap , @Mahang , @SoLuong ,  @GiaNhap )";

				object[] parameters = { spnct, mahang, soluong, gianhap };

				int result = DataProvider.Instance.ExcuteNonQuery(query, parameters);

				if (result > 0)
				{
					MessageBox.Show("Thêm CTPN thành công");
					LoadCTPN();
				}
				else
				{
					MessageBox.Show("Thêm CTPN thất bại");
				}
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

		private void dgv_CTPN_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0 && e.RowIndex < dgv_CTPN.Rows.Count)
			{
				try
				{
					int rowIndex = e.RowIndex;
					cmb_SoPhieuNhap.SelectedValue = dgv_CTPN.Rows[rowIndex].Cells[0].Value?.ToString();  // Gán giá trị vào ComboBox Số Phiếu Nhập
					cmb_MaHang.SelectedValue = dgv_CTPN.Rows[rowIndex].Cells[1].Value?.ToString();      // Gán giá trị vào ComboBox Mã Hàng
					txt_SoLuong.Text = dgv_CTPN.Rows[rowIndex].Cells[2].Value?.ToString();
					txt_GiaNhap.Text = dgv_CTPN.Rows[rowIndex].Cells[3].Value?.ToString();
				}
				catch (Exception ex)
				{
					MessageBox.Show("Lỗi: " + ex.Message);
				}
			}
		}



		private void btn_XoaCTPN_Click(object sender, EventArgs e)
		{
			try
			{
				// Lấy giá trị Số Phiếu Nhập và Mã Hàng từ ComboBox
				string spnct = cmb_SoPhieuNhap.SelectedValue.ToString();
				string mahang = cmb_MaHang.SelectedValue.ToString();

				// Kiểm tra xem các trường có hợp lệ không
				if (string.IsNullOrEmpty(spnct) || string.IsNullOrEmpty(mahang))
				{
					MessageBox.Show("Số Phiếu Nhập và Mã Hàng không được để trống.");
					return;  // Nếu thiếu thông tin, dừng quá trình xóa
				}

				// Câu truy vấn xoá với điều kiện Số Phiếu Nhập và Mã Hàng
				string query = "DELETE FROM ChiTietPhieuNhap WHERE SoPhieuNhap = @SoPhieuNhap AND MaHang = @MaHang";
				object[] parameters = { spnct, mahang };

				// Thực hiện truy vấn
				int result = DataProvider.Instance.ExcuteNonQuery(query, parameters);

				if (result > 0)
				{
					MessageBox.Show("Xóa CTPN thành công");
					LoadCTPN();  // Cập nhật lại DataGridView sau khi xoá
				}
				else
				{
					MessageBox.Show("Xóa CTPN thất bại. Không tìm thấy dòng cần xóa.");
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
				return;  // Nếu không hợp lệ, dừng thao tác thêm
			}

			try
			{
				string spnct = cmb_SoPhieuNhap.SelectedValue.ToString();  // Lấy Số Phiếu Nhập từ ComboBox
				string mahang = cmb_MaHang.SelectedValue.ToString();      // Lấy mã hàng từ ComboBox
				string soluong = txt_SoLuong.Text;
				string gianhap = txt_GiaNhap.Text;

				// Kiểm tra xem SoPhieuNhap có tồn tại trong ChiTietPhieuNhap hay không
				string checkQuery = "SELECT COUNT(*) FROM ChiTietPhieuNhap WHERE SoPhieuNhap = @SoPhieuNhap";
				object[] checkParams = { spnct };
				int exists = (int)DataProvider.Instance.ExcuteScalar(checkQuery, checkParams);

				if (exists == 0)
				{
					MessageBox.Show("Số Phiếu Nhập không tồn tại. Vui lòng kiểm tra lại.");
					return;  // Nếu không tồn tại thì dừng quá trình cập nhật
				}

				// Truy vấn lấy giá sản phẩm từ bảng Hang dựa trên MaHang
				string queryGiaSanPham = "SELECT Gia FROM Hang WHERE MaHang = @Mahang";
				object[] parameterGiaSanPham = { mahang };
				DataTable dt = DataProvider.Instance.ExcuteQuery(queryGiaSanPham, parameterGiaSanPham);

				if (dt.Rows.Count > 0)
				{
					decimal giaSanPham = Convert.ToDecimal(dt.Rows[0]["Gia"]);
					decimal giaNhap = Convert.ToDecimal(gianhap);

					if (giaNhap > giaSanPham)
					{
						MessageBox.Show($"Giá nhập phải nhỏ hơn hoặc bằng giá sản phẩm: {giaSanPham}");
						return;
					}
				}
				else
				{
					MessageBox.Show("Không tìm thấy sản phẩm với mã hàng này.");
					return;
				}

				// Thực hiện cập nhật nếu giá nhập hợp lệ
				string query = "UPDATE ChiTietPhieuNhap SET MaHang = @Mahang , SoLuong = @SoLuong , GiaNhap = @GiaNhap WHERE SoPhieuNhap = @SoPhieuNhap";
				object[] parameters = { mahang, soluong, gianhap, spnct };

				int result = DataProvider.Instance.ExcuteNonQuery(query, parameters);

				if (result > 0)
				{
					MessageBox.Show("Cập nhật CTPN thành công");
					LoadCTPN();
				}
				else
				{
					MessageBox.Show("Cập nhật CTPN thất bại");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi: " + ex.Message);
			}
		}



	}
}
