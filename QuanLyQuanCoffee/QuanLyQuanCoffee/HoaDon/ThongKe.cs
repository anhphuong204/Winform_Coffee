using QuanLyQuanCoffee.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCoffee.HoaDon
{
    public partial class ThongKe : Form
    {
		// Khai báo biến ControlResizer
		private ControlResizer controlResizer;
		public ThongKe()
        {
            InitializeComponent();
			// Khởi tạo ControlResizer và áp dụng cho form này
			controlResizer = new ControlResizer(this);
		}

        private void ThongKe_Load(object sender, EventArgs e)
        {
            LoadThongKe();
        }
        void LoadThongKe()
        {
            string query = "select count(MaBH) as SoHoaDon , count(Mahang) as SoLoaiHang , sum(ThanhTien)  as TongTien  from BanHang ";
            dgv_ThongKe.DataSource = DataProvider.Instance.ExcuteQuery(query);
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private int fileCounter = 1;
        private void btn_In_Click(object sender, EventArgs e)
        {
            // Specify the file path where you want to save the data
            string filePath = "C:\\ThongKe\\Thongke.txt";

            try
            {
                // Open a StreamWriter to write to the file
                using (StreamWriter sw = new StreamWriter(filePath))
                {
                    // Write the column headers
                    for (int i = 0; i < dgv_ThongKe.Columns.Count; i++)
                    {
                        sw.Write(dgv_ThongKe.Columns[i].HeaderText);
                        if (i < dgv_ThongKe.Columns.Count - 1)
                            sw.Write("\t");
                    }
                    sw.WriteLine();

                    // Write the data rows
                    foreach (DataGridViewRow row in dgv_ThongKe.Rows)
                    {
                        for (int i = 0; i < dgv_ThongKe.Columns.Count; i++)
                        {
                            sw.Write(row.Cells[i].Value);
                            if (i < dgv_ThongKe.Columns.Count - 1)
                                sw.Write("\t\t");
                        }
                        sw.WriteLine();
                    }
                }

                MessageBox.Show("Data saved to file successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                fileCounter++;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
