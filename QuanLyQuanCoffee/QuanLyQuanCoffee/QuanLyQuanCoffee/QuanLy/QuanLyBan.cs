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
    public partial class QuanLyBan : Form
    {
        public QuanLyBan()
        {
            InitializeComponent();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            try
            {
                string maban = txt_MaBan.Text;
                string tenban = txt_TenBan.Text;
                string khuvuc = txt_KhuVuc.Text;

                string query = "INSERT INTO Ban(Maban, Tenban, Khuvuc) " +
                               "VALUES( @Maban , @Tenban , @Khuvuc )";

                object[] parameters = { maban, tenban, khuvuc };

                int result = DataProvider.Instance.ExcuteNonQuery(query, parameters);

                if (result > 0)
                {
                    MessageBox.Show("Thêm bàn thành công");
                    LoadListBan();
                }
                else
                {
                    MessageBox.Show("Thêm bàn thất bại");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string maban = txt_MaBan.Text;
            string query = "delete from Ban where Maban = @Maban";
            object[] parameters = { maban };
            int result = DataProvider.Instance.ExcuteNonQuery(query, parameters);
            if (result > 0)
            {
                MessageBox.Show("Xóa bàn thành công");
                LoadListBan();
            }
            else
            {
                MessageBox.Show("Xóa bàn thất bại");
            }
        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            string maban = txt_MaBan.Text;
            string tenban = txt_TenBan.Text;
            string khuvuc = txt_KhuVuc.Text;

            string query = "UPDATE Ban SET Tenban = @Tenban , Khuvuc = @Khuvuc  WHERE Maban = @Maban ";

            object[] parameters = { tenban, khuvuc,maban };

            int result = DataProvider.Instance.ExcuteNonQuery(query, parameters);

            if (result > 0)
            {
                MessageBox.Show("Cập nhật bàn thành công");
                LoadListBan();
            }
            else
            {
                MessageBox.Show("Cập nhật bàn thất bại");
            }
        }

        private void btn_QuayVe_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            this.Close();
            admin.Show();
        }

    

        private void QuanLyBan_Load(object sender, EventArgs e)
        {
            LoadListBan();
        }
        void LoadListBan()
        {
            string query = "select * from Ban";
            dgv_ListBan.DataSource = DataProvider.Instance.ExcuteQuery(query);
        }

        private void dgv_ListBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgv_ListBan.Rows.Count)
            {
                try
                {
                    int rowIndex = e.RowIndex;
                    txt_MaBan.Text = dgv_ListBan.Rows[rowIndex].Cells[0].Value?.ToString();
                    txt_TenBan.Text = dgv_ListBan.Rows[rowIndex].Cells[1].Value?.ToString();
                    txt_KhuVuc.Text = dgv_ListBan.Rows[rowIndex].Cells[2].Value?.ToString();
                }
                catch (Exception ex)
                {
                    return;
                    //MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}
