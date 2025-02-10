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

namespace QuanLyQuanCoffee.HoaDon
{
    public partial class PhieuNhap : Form
    {
	
		public PhieuNhap()
        {
            InitializeComponent();
			this.Size = new Size(950, 520);

		}

        private void PhieuNhap_Load(object sender, EventArgs e)
        {
            LoadPN();
            LoadMaNV();
			
		}
        void LoadPN()
        {
            string query = "select * from PhieuNhap";
            dgv_PhieuNhap.DataSource = DataProvider.Instance.ExcuteQuery(query);
        }

		void LoadMaNV()
		{
			string query = "SELECT MaNV FROM NhanVien";
			DataTable dt = DataProvider.Instance.ExcuteQuery(query);

			cmb_MaNV.DataSource = dt;
			cmb_MaNV.DisplayMember = "MaNV";  // Hiển thị mã nhân viên trong ComboBox
			cmb_MaNV.ValueMember = "MaNV";    // Giá trị thực sự là mã nhân viên
		}

		private void btn_QuayVe_Click(object sender, EventArgs e)
        {
           XemHoaDon xhd = new XemHoaDon();
            this.Close();
            xhd.Show();
        }
		private bool KiemTraNhapLieu()
		{
			if (string.IsNullOrEmpty(txt_SoPN.Text))
			{
				MessageBox.Show("Số phiếu nhập không được bỏ trống.");
				txt_SoPN.Focus();
				return false;
			}

			if (string.IsNullOrEmpty(txt_ID.Text))
			{
				MessageBox.Show("ID không được bỏ trống.");
				txt_ID.Focus();
				return false;
			}

			if (cmb_MaNV.SelectedValue == null)
			{
				MessageBox.Show("Mã nhân viên không được bỏ trống.");
				cmb_MaNV.Focus();
				return false;
			}

			if (dtp_NgayNhap.Value == null || dtp_NgayNhap.Value > DateTime.Now)
			{
				MessageBox.Show("Ngày nhập không hợp lệ.");
				dtp_NgayNhap.Focus();
				return false;
			}

			return true; // Tất cả các điều kiện hợp lệ
		}
		private bool IsSoPhieuNhapExists(string soPhieuNhap)
		{
			string query = "SELECT COUNT(*) FROM PhieuNhap WHERE SoPhieuNhap = @SoPhieuNhap";
			object result = DataProvider.Instance.ExcuteScalar(query, new object[] { soPhieuNhap });

			return Convert.ToInt32(result) > 0;
		}


		private void btn_ThemPN_Click(object sender, EventArgs e)
        {
			if (!KiemTraNhapLieu())
			{
				return; // Nếu kiểm tra không thành công, thoát ra
			}
			try
            {
                string spn = txt_SoPN.Text;
                string id = txt_ID.Text;
                DateTime ngaynhap = dtp_NgayNhap.Value;
				string manv = cmb_MaNV.SelectedValue.ToString();
				string ghichu = txt_GhiChu.Text;
				// Kiểm tra số phiếu nhập đã tồn tại
				if (IsSoPhieuNhapExists(spn))
				{
					MessageBox.Show("Số phiếu nhập đã tồn tại. Vui lòng nhập số khác.");
					txt_SoPN.Focus();
					return;
				}

				string query = "INSERT INTO PhieuNhap(SoPhieuNhap, ID, NgayNhap, MaNV, GhiChu) " +
                               "VALUES( @SoPhieuNhap , @ID , @NgayNhap ,"+"( select MaNV from NhanVien Where MaNV = @MaNV ) , @GhiChu )";

                object[] parameters = { spn,id ,ngaynhap,manv,ghichu};

                int result = DataProvider.Instance.ExcuteNonQuery(query, parameters);

                if (result > 0)
                {
                    MessageBox.Show("Thêm PN thành công");
                    LoadPN();
                }
                else
                {
                    MessageBox.Show("Thêm PN thất bại");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void dgv_PhieuNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgv_PhieuNhap.Rows.Count)
            {
                try
                {
                    int rowIndex = e.RowIndex;
                    txt_SoPN.Text = dgv_PhieuNhap.Rows[rowIndex].Cells[0].Value?.ToString();
                    txt_ID.Text = dgv_PhieuNhap.Rows[rowIndex].Cells[1].Value?.ToString();
                    dtp_NgayNhap.Text = dgv_PhieuNhap.Rows[rowIndex].Cells[2].Value?.ToString();
					cmb_MaNV.SelectedValue = dgv_PhieuNhap.Rows[rowIndex].Cells[3].Value?.ToString();
					txt_GhiChu.Text = dgv_PhieuNhap.Rows[rowIndex].Cells[4].Value?.ToString();
                }
                catch (Exception ex)
                {
                    return;
                    //MessageBox.Show("Error: " + ex.Message);
                }
            }
        }


        private void btn_XoaPN_Click(object sender, EventArgs e)
        {
            string spn = txt_SoPN.Text;
            string query = "delete from PhieuNhap where SoPhieuNhap = @SoPhieuNhap ";
            object[] parameters = { spn };
            int result = DataProvider.Instance.ExcuteNonQuery(query, parameters);
            if (result > 0)
            {
                MessageBox.Show("Xóa PN thành công");
                LoadPN();
            }
            else
            {
                MessageBox.Show("Xóa PN thất bại");
            }
        }

        private void btn_CapNhatPN_Click(object sender, EventArgs e)
        {
			if (!KiemTraNhapLieu())
			{
				return; // Nếu kiểm tra không thành công, thoát ra
			}
			string spn = txt_SoPN.Text;
            string id = txt_ID.Text;
            string ngaynhap = dtp_NgayNhap.Value.ToString("yyyy-MM-dd");
			string manv = cmb_MaNV.SelectedValue.ToString();
			string ghichu = txt_GhiChu.Text;

			if (!IsSoPhieuNhapExists(spn))
			{
				MessageBox.Show("Số phiếu nhập không tồn tại. Vui lòng kiểm tra lại.");
				txt_SoPN.Focus();
				return;
			}
			string query = "UPDATE PhieuNhap SET ID = @ID , NgayNhap = @NgayNhap , MaNV = @MaNV , GhiChu = @GhiChu WHERE SoPhieuNhap = @SoPhieuNhap";
            object[] parameters = { id,ngaynhap,manv,ghichu,spn};

            int result = DataProvider.Instance.ExcuteNonQuery(query, parameters);

            if (result > 0)
            {
                MessageBox.Show("Cập nhật PN thành công");
                LoadPN();
            }
            else
            {
                MessageBox.Show("Cập nhật PN thất bại");
            }
        }

      
	}
}
