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
            Admin admin = new Admin();
            this.Close();
            admin.Show();
        }

       

        private void chiTiếtPhiếuNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChiTietPhieuNhap ctpn = new ChiTietPhieuNhap();
            this.Hide();
            ctpn.Show();
        }
    }
}
