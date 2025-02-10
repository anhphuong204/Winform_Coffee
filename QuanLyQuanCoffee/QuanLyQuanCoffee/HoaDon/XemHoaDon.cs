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
    public partial class XemHoaDon : Form
    {
		
		public XemHoaDon()
        {
            InitializeComponent();
			
		}

        private void msi_PhieuNhap_Click(object sender, EventArgs e)
        {
            PhieuNhap pn = new PhieuNhap();
            this.Hide();
            pn.Show();
        }

        private void quayLạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
			
				if (Session.IsAdmin)
				{
					Admin adminForm = new Admin();
					this.Close();
					adminForm.Show();
				}
				else
				{
					User userForm = new User(Session.MaNV);
					this.Close();
					userForm.Show();
				}
			
		}

       

        private void chiTiếtPhiếuNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChiTietPhieuNhap ctpn = new ChiTietPhieuNhap();
            this.Hide();
            ctpn.Show();
        }

        private void phiếuXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PhieuXuat px = new PhieuXuat();
            this.Hide();
            px.Show();
        }

        private void chiTiếtPhiếuXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChiTietPhieuXuat ctpx = new ChiTietPhieuXuat();
            this.Hide();
            ctpx.Show();
        }

		private void phiếuNhậpToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void XemHoaDon_Load(object sender, EventArgs e)
		{

		}
	}
}
