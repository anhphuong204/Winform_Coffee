using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCoffee.HeThong
{
    public partial class InforUser : Form
    {
        private DataTable userInfoDataTable;
        public InforUser(DataTable dataTable)
        {
            InitializeComponent();
            userInfoDataTable = dataTable;
        }

        private void InforUser_Load(object sender, EventArgs e)
        {
            dgv_Infor.DataSource = userInfoDataTable;
        }

    }
}
