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

namespace QuanLyQuanCoffee.QuanLy
{
    public partial class QuanLySanPham : Form
    {
        public QuanLySanPham()
        {
            InitializeComponent();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            try
            {
                string masp = txt_MaSP.Text;
                string tensp = txt_TenSP.Text;
                
                string ghichu =txt_GhiChu.Text;
                string gia = txt_Gia.Text;

                string query = "INSERT INTO Hang(Mahang, Tenhang, Ghichu , Gia) " +
                               "VALUES( @Mahang , @Tenhang , @Ghichu , @Gia )";

                object[] parameters = { masp , tensp , ghichu , gia };

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

        private void dgv_ListSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgv_ListSP.Rows.Count)
            {
                try
                {
                    int rowIndex = e.RowIndex;
                    txt_MaSP.Text = dgv_ListSP.Rows[rowIndex].Cells[0].Value?.ToString();
                    txt_TenSP.Text = dgv_ListSP.Rows[rowIndex].Cells[1].Value?.ToString();
                    txt_Gia.Text = dgv_ListSP.Rows[rowIndex].Cells[2].Value?.ToString();
                    txt_GhiChu.Text = dgv_ListSP.Rows[rowIndex].Cells[3].Value?.ToString();   
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
            string masp = txt_MaSP.Text;
            string query = "delete from Hang where Mahang = @Mahang";
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
            string masp = txt_MaSP.Text;
            string tensp = txt_TenSP.Text;
            string gia = txt_Gia.Text;
            string ghichu = txt_GhiChu.Text;
            string query = "UPDATE Hang SET Tenhang = @Tenhang , Ghichu = @Ghichu , Gia = @Gia WHERE Mahang = @Mahang ";
            object[] parameters = { tensp , ghichu , gia ,masp};

            int result = DataProvider.Instance.ExcuteNonQuery(query, parameters);

            if (result > 0)
            {
                MessageBox.Show("Cập nhật SP thành công");
                LoadListSP();
            }
            else
            {
                MessageBox.Show("Cập nhật SP thất bại");
            }
        }

        private void btn_QuayVe_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            this.Close();
            admin.Show();
        }

        
    }
}
