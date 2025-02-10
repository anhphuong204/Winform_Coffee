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
    public partial class ChiTietPhieuNhap : Form
    {
        public ChiTietPhieuNhap()
        {
            InitializeComponent();
        }
        void LoadCTPN()
        {
            string query = "select * from ChiTietPhieuNhap";
            dgv_CTPN.DataSource = DataProvider.Instance.ExcuteQuery(query);
        }
        private void btn_ThemCTPN_Click(object sender, EventArgs e)
        {

            try
            {
                string spnct = txt_SoPNCT.Text;
                string mahang = txt_MaHang.Text;

                string soluong = txt_SoLuong.Text;
                string gianhap = txt_GiaNhap.Text;

                string query = "INSERT INTO ChiTietPhieuNhap(SoPhieuNhap, Mahang, SoLuong, GiaNhap) " +
                               "VALUES( @SoPhieuNhap , " + "( select Mahang from Hang Where Mahang = @Mahang ) , @SoLuong ,  @GiaNhap )";

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
                    txt_SoPNCT.Text = dgv_CTPN.Rows[rowIndex].Cells[0].Value?.ToString();
                    txt_MaHang.Text = dgv_CTPN.Rows[rowIndex].Cells[1].Value?.ToString();
                    txt_SoLuong.Text = dgv_CTPN.Rows[rowIndex].Cells[2].Value?.ToString();
                    txt_GiaNhap.Text = dgv_CTPN.Rows[rowIndex].Cells[3].Value?.ToString();

                }
                catch (Exception ex)
                {
                    return;
                    //MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btn_XoaCTPN_Click(object sender, EventArgs e)
        {

            string spnct = txt_SoPNCT.Text;
            string query = "delete from ChiTietPhieuNhap where SoPhieuNhap = @SoPhieuNhap ";
            object[] parameters = { spnct };
            int result = DataProvider.Instance.ExcuteNonQuery(query, parameters);
            if (result > 0)
            {
                MessageBox.Show("Xóa CTPN thành công");
                LoadCTPN();
            }
            else
            {
                MessageBox.Show("Xóa CTPN thất bại");
            }
        }

        private void btn_CapNhatCTPN_Click(object sender, EventArgs e)
        {
            string spnct = txt_SoPNCT.Text;
            string mahang = txt_MaHang.Text;
            string soluong = txt_SoLuong.Text;
            string gianhap = txt_GiaNhap.Text;
            string query = "UPDATE PhieuNhap SET Mahang = @Mahang , SoLuong = @SoLuong , GiaNHap = @GiaNhap  WHERE SoPhieuNhap = @SoPhieuNhap ";
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
    }
}
