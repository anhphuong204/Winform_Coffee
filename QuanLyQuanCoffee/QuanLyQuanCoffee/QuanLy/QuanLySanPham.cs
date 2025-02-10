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

namespace QuanLyQuanCoffee.QuanLy
{
    public partial class QuanLySanPham : Form
    {
		// Khai báo biến ControlResizer
		private ControlResizer controlResizer;
		public QuanLySanPham()
        {
            InitializeComponent();
			// Khởi tạo ControlResizer và áp dụng cho form này
			controlResizer = new ControlResizer(this);
		}

        private void btn_Them_Click(object sender, EventArgs e)
        {
            try
            {
                string masp = txt_MaSP.Text;
                string tensp = txt_TenSP.Text;

                string ghichu = txt_Ghichu.Text;
				string gia = txt_Gia.Text;

				// Kiểm tra tính hợp lệ của đầu vào
				string validationMessage = ValidateProductInput(masp, tensp,ghichu, gia);
				if (!string.IsNullOrEmpty(validationMessage))
				{
					MessageBox.Show(validationMessage, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				// Kiểm tra mã hàng đã tồn tại hay chưa
				if (IsMaHangExists(masp))
				{
					MessageBox.Show("Mã hàng đã tồn tại, vui long nhập mã khác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				string query = "INSERT INTO Hang(Mahang, Tenhang, Ghichu , Gia) " +
							  "VALUES( @Mahang , @Tenhang , @Ghichu , @Gia )";

				object[] parameters = { masp, tensp, ghichu, gia };

				int result = DataProvider.Instance.ExcuteNonQuery(query, parameters);

                if (result > 0)
                {
                    MessageBox.Show("Thêm SP thành công");
                    LoadListSP();
                }
                else
                {
                    MessageBox.Show("Thêm SP thất bại");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void QuanLySanPham_Load(object sender, EventArgs e)
        {
            LoadListSP();
        }

        void LoadListSP()
        {
            string query = "select * from Hang";
            dgv_ListSP.DataSource = DataProvider.Instance.ExcuteQuery(query);
        }
		private string ValidateProductInput(string masp, string tensp, string ghichu, string gia)
		{
			// Kiểm tra mã sản phẩm không được để trống và phải có tối đa 5 ký tự
			if (string.IsNullOrEmpty(masp))
				return "Mã sản phẩm không được để trống.";

			if (masp.Length > 5) // Tối đa 5 ký tự
				return "Mã sản phẩm không được nhập quá 5 ký tự.";

			if (!IsAlphaNumeric(masp)) // Kiểm tra không chứa ký tự đặc biệt 
				return "Mã sản phẩm không được chứa ký tự đặc biệt.";

			// Kiểm tra tên sản phẩm không được để trống
			if (string.IsNullOrEmpty(tensp))
				return "Tên sản phẩm không được để trống.";

			// Kiểm tra giá không được để trống
			if (string.IsNullOrEmpty(gia))
				return "Giá không được để trống.";

			// Kiểm tra giá phải là số hợp lệ
			if (!decimal.TryParse(gia, out _))
				return "Giá phải là số hợp lệ.";


			return string.Empty; // Không có lỗi
		}

		private bool IsMaHangExists(string masp)
		{
			string query = "SELECT COUNT(*) FROM Hang WHERE Mahang = @Mahang";
			object result = DataProvider.Instance.ExcuteScalar(query, new object[] { masp });

			return Convert.ToInt32(result) > 0;
		}
		// Phương thức kiểm tra ký tự không dấu
		private bool IsAlphaNumeric(string input)
		{
			return input.All(c => char.IsLetterOrDigit(c));
		}
		

		private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string masp = txt_MaSP.Text;
            string query = "delete from Hang where MaHang = @Mahang";
            object[] parameters = { masp };
            int result = DataProvider.Instance.ExcuteNonQuery(query, parameters);
            if (result > 0)
            {
                MessageBox.Show("Xóa SP thành công");
                LoadListSP();
            }
            else
            {
                MessageBox.Show("Xóa SP thất bại");
            }
        }

		private void btn_CapNhat_Click(object sender, EventArgs e)
		{
			try
			{
				string masp = txt_MaSP.Text;
				string tensp = txt_TenSP.Text;
				string ghichu = txt_Ghichu.Text;
				string gia = txt_Gia.Text;

				// Kiểm tra tính hợp lệ của đầu vào
				string validationMessage = ValidateProductInput(masp, tensp, ghichu, gia);
				if (!string.IsNullOrEmpty(validationMessage))
				{
					MessageBox.Show(validationMessage, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				// Kiểm tra mã hàng đã tồn tại hay chưa
				if (!IsMaHangExists(masp))
				{
					MessageBox.Show("Mã hàng không tồn tại , vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				// Cập nhật sản phẩm
				string query = "UPDATE Hang SET Tenhang = @Tenhang, Ghichu = @Ghichu, Gia = @Gia WHERE Mahang = @Mahang";

				// Sử dụng chuỗi kết nối chính xác thay vì "str"
				string connectionString ="Data Source=LAPTOP-UHDF2OIP\\NHAPHUONG;Persist Security Info=True;User ID=sa;Password=2902; database=QuanLyQuanCaFe";

				// Sử dụng SqlCommand để tránh lỗi tham số
				using (SqlConnection connection = new SqlConnection(connectionString))
				{
					using (SqlCommand command = new SqlCommand(query, connection))
					{
						// Thêm các tham số cho câu truy vấn
						command.Parameters.AddWithValue("@Tenhang", tensp);
						command.Parameters.AddWithValue("@Ghichu", ghichu);
						command.Parameters.AddWithValue("@Gia", float.Parse(gia)); // Đảm bảo giá trị float đúng
						command.Parameters.AddWithValue("@Mahang", masp);

						// Mở kết nối và thực thi câu lệnh
						connection.Open();
						int result = command.ExecuteNonQuery();

						if (result > 0)
						{
							MessageBox.Show("Cập nhật sản phẩm thành công");
							LoadListSP();
						}
						else
						{
							MessageBox.Show("Cập nhật sản phẩm thất bại");
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi: " + ex.Message);
			}
		}



		private void btn_QuayVe_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            this.Close();
            admin.Show();
        }

       
        private void dgv_ListSP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgv_ListSP.Rows.Count)
            {
                try
                {
                    int rowIndex = e.RowIndex;
                    txt_MaSP.Text = dgv_ListSP.Rows[rowIndex].Cells[0].Value?.ToString();
                    txt_TenSP.Text = dgv_ListSP.Rows[rowIndex].Cells[1].Value?.ToString();
					txt_Ghichu.Text = dgv_ListSP.Rows[rowIndex].Cells[2].Value?.ToString(); // Chỉnh lại để lấy ghi chú đúng cột
					txt_Gia.Text = dgv_ListSP.Rows[rowIndex].Cells[3].Value?.ToString();   // Cột đúng cho giá

				}
				catch (Exception ex)
                {
                    return;
                    //MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

		private void label4_Click(object sender, EventArgs e)
		{

		}
	}
}
