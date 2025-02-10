using QuanLyQuanCoffee.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCoffee.QuanLy
{
    public partial class BanHang : Form
    {
        public BanHang()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void BanHang_Load(object sender, EventArgs e)
        {
            LoadBanHang();
            HienThiMaHang();
            HienThiMaBan();
            txt_Ma.ReadOnly = true;
            txt_ThanhTien.ReadOnly = true;
        }
        void LoadBanHang()
        {
            string query = "select * from BanHang";
            dgv_BanHang.DataSource = DataProvider.Instance.ExcuteQuery(query);
        }
        void HienThiMaHang()
        {
            string query = "SELECT * FROM Hang";

            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            cmb_MaHang.Items.Clear();

            foreach (DataRow row in data.Rows)
            {
                string maHang = row["Mahang"].ToString();
                string tenHang = row["Tenhang"].ToString();
                cmb_MaHang.Items.Add($"{maHang}-{tenHang}");
            }

        }
        void HienThiMaBan()
        {
            string query = "select * from Ban";

            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            cmb_MaBan.Items.Clear();

            foreach (DataRow row in data.Rows)
            {
                string maBan = row["Maban"].ToString();
                string tenBan = row["Tenban"].ToString();
                cmb_MaBan.Items.Add(maBan + "-" + tenBan);
            }
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {

            this.Close();

        }


        private void dgv_BanHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgv_BanHang.Rows.Count)
            {
                try
                {
                    int rowIndex = e.RowIndex;

                    txt_Ma.Text = dgv_BanHang.Rows[rowIndex].Cells[0].Value?.ToString();
                    cmb_MaHang.Text = dgv_BanHang.Rows[rowIndex].Cells[1].Value?.ToString();
                    cmb_MaBan.Text = dgv_BanHang.Rows[rowIndex].Cells[2].Value?.ToString(); 

                    txt_MaNV.Text = dgv_BanHang.Rows[rowIndex].Cells[3].Value?.ToString();
                    txt_GiaSP.Text = dgv_BanHang.Rows[rowIndex].Cells[4].Value?.ToString();
                    cmb_SoLuong.Text = dgv_BanHang.Rows[rowIndex].Cells[5].Value?.ToString();
                    txt_ThanhTien.Text = dgv_BanHang.Rows[rowIndex].Cells[6].Value?.ToString();
                    dtp_Ngay.Value = Convert.ToDateTime(dgv_BanHang.Rows[rowIndex].Cells[7].Value);
                }
                catch (Exception ex)
                {
                    return;
                    //MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string maBH = txt_Ma.Text;
            string query = "delete from BanHang where MaBH = @MaBH ";
            object[] parameters = { maBH };
            int result = DataProvider.Instance.ExcuteNonQuery(query, parameters);
            if (result > 0)
            {
                MessageBox.Show("Xóa thành công");
                LoadBanHang();
            }
            else
            {
                MessageBox.Show("Xóa thất bại");
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            try
            {

                string maHang = cmb_MaHang.Text.Split('-')[0].Trim(); // Lấy MaHang từ ComboBox
                string maBan = cmb_MaBan.Text.Split('-')[0].Trim(); // Lấy MaBan từ ComboBox
                string maNV = txt_MaNV.Text;
                decimal giaSP = decimal.Parse(txt_GiaSP.Text); // Chuyển đổi giá sản phẩm thành kiểu decimal
                int soLuong = int.Parse(cmb_SoLuong.Text); // Chuyển đổi số lượng thành kiểu int
                decimal thanhTien = giaSP * soLuong;
                DateTime ngay = dtp_Ngay.Value;

                string query = "INSERT INTO BanHang( Mahang, Maban, MaNV, GiaSP, SoLuong, ThanhTien, NgayTT) " +
                               "VALUES(  @MaHang , @MaBan , @MaNV , @GiaSP , @SoLuong , @ThanhTien , @NgayTT )";

                object[] parameters = {  maHang, maBan, maNV, giaSP, soLuong, thanhTien, ngay };

                int result = DataProvider.Instance.ExcuteNonQuery(query, parameters);

                if (result > 0)
                {
                    MessageBox.Show("Thêm hóa đơn bán hàng thành công");
                    LoadBanHang();
                }
                else
                {
                    MessageBox.Show("Thêm hóa đơn bán hàng thất bại");
                }
                txt_Ma.ReadOnly = true;
                txt_ThanhTien.ReadOnly = true;
            }
            catch (Exception ex)
            {
               MessageBox.Show(ex.Message);
            }
        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra xem đã chọn một hàng từ DataGridView chưa
                if (!string.IsNullOrEmpty(txt_Ma.Text))
                {
                    string maBH = txt_Ma.Text;
                    string maHang = cmb_MaHang.Text.Split('-')[0].Trim(); // Lấy MaHang từ ComboBox
                    string maBan = cmb_MaBan.Text.Split('-')[0].Trim(); // Lấy MaBan từ ComboBox
                    string maNV = txt_MaNV.Text;
                    decimal giaSP = decimal.Parse(txt_GiaSP.Text); // Chuyển đổi giá sản phẩm thành kiểu decimal
                    int soLuong = int.Parse(cmb_SoLuong.Text); // Chuyển đổi số lượng thành kiểu int
                    decimal thanhTien = giaSP * soLuong;
                    DateTime ngay = dtp_Ngay.Value;
                    string query = "UPDATE BanHang SET Mahang = @Mahang , Maban = @MaBan , MaNV = @MaNV , GiaSP = @GiaSP , SoLuong = @SoLuong , ThanhTien = @ThanhTien , NgayTT = @NgayTT WHERE MaBH = @MaBH ";

                    object[] parameters = {maHang,maBan,maNV,giaSP,soLuong,thanhTien,ngay, maBH };

                    int result = DataProvider.Instance.ExcuteNonQuery(query, parameters);

                    if (result > 0)
                    {
                        MessageBox.Show("Cập nhật dữ liệu thành công");
                        LoadBanHang();
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật dữ liệu không thành công");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một hóa đơn bán hàng để cập nhật.");
                }
                txt_Ma.ReadOnly = true;
                txt_ThanhTien.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật dữ liệu: " + ex.Message);
            }
        }
        private void CapNhatGiaTriThanhTien()
        {
            try
            {
                decimal giaSP = decimal.Parse(txt_GiaSP.Text);
                int soLuong = int.Parse(cmb_SoLuong.Text);
                decimal thanhTien = giaSP * soLuong;
                txt_ThanhTien.Text = thanhTien.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật giá trị Thành tiền: " + ex.Message);
            }
        }

        private void cmb_SoLuong_SelectedIndexChanged(object sender, EventArgs e)
        {
            CapNhatGiaTriThanhTien();
        }

        private void btn_In_Click(object sender, EventArgs e)
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += PrintDocument_PrintPage;

            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                // In hóa đơn
                printDocument.Print();

                // Xuất hóa đơn ra file văn bản
                XuatHoaDonRaFile(txt_Ma.Text);
            }
        }
        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Lấy thông tin từ cơ sở dữ liệu hoặc các trường thông tin khác
            string maBH = txt_Ma.Text;
            string maHang = cmb_MaHang.Text.Split('-')[0].Trim();
            string maBan = cmb_MaBan.Text.Split('-')[0].Trim();
            string maNV = txt_MaNV.Text;
            float giaSP = float.Parse(txt_GiaSP.Text);
            int soLuong = int.Parse(cmb_SoLuong.Text);
            float thanhTien = giaSP * soLuong;
            DateTime ngay = dtp_Ngay.Value;

            // Chuẩn bị nội dung để in
            string content = $"Thông tin hóa đơn bán hàng\n" +
                             $"Mã hóa đơn: {maBH}\n" +
                             $"Mã hàng: {maHang}\n" +
                             $"Mã bàn: {maBan}\n" +
                             $"Mã nhân viên: {maNV}\n" +
                             $"Giá sản phẩm: {giaSP}\n" +
                             $"Số lượng: {soLuong}\n" +
                             $"Thành tiền: {thanhTien}\n" +
                             $"Ngày thanh toán: {ngay}\n";

            // Vẽ nội dung lên trang in
            Font font = new Font("Arial", 12);
            float yPos = 0;
            int count = 0;
            float leftMargin = e.MarginBounds.Left;
            float topMargin = e.MarginBounds.Top;

            while (count < content.Length)
            {
                yPos = topMargin + (count * font.GetHeight(e.Graphics));
                e.Graphics.DrawString(content.Substring(count, content.Length - count > 30 ? 30 : content.Length - count), font, Brushes.Black, leftMargin, yPos, new StringFormat());
                count += 30;
            }
        }
        private void XuatHoaDonRaFile(string maHoaDon)
        {
            try
            {
                string fileName = $"HoaDon_{maHoaDon}.txt";
                string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), fileName);

                using (StreamWriter sw = new StreamWriter(filePath))
                {
                    // Lấy thông tin từ cơ sở dữ liệu hoặc các trường thông tin khác
                    string maBH = txt_Ma.Text;
                    string maHang = cmb_MaHang.Text.Split('-')[0].Trim();
                    string maBan = cmb_MaBan.Text.Split('-')[0].Trim();
                    string maNV = txt_MaNV.Text;
                    decimal giaSP = decimal.Parse(txt_GiaSP.Text);
                    int soLuong = int.Parse(cmb_SoLuong.Text);
                    decimal thanhTien = giaSP * soLuong;
                    DateTime ngay = dtp_Ngay.Value;

                    // Chuẩn bị nội dung để xuất ra file
                    string content = $"Thông tin hóa đơn bán hàng\r\n" +  // Use \r\n for new line in text file
                                     $"Mã hóa đơn: {maBH}\r\n" +
                                     $"Mã hàng: {maHang}\r\n" +
                                     $"Mã bàn: {maBan}\r\n" +
                                     $"Mã nhân viên: {maNV}\r\n" +
                                     $"Giá sản phẩm: {giaSP}\r\n" +
                                     $"Số lượng: {soLuong}\r\n" +
                                     $"Thành tiền: {thanhTien}\r\n" +
                                     $"Ngày thanh toán: {ngay}\r\n";

                    // Xuất nội dung ra file
                    sw.Write(content);
                }

                MessageBox.Show($"Hóa đơn đã được xuất ra file: {fileName}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xuất hóa đơn ra file: {ex.Message}");
            }
        }

        // ... (các phần code khác)
    }
}

