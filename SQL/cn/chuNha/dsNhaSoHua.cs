using SQL.cn.baiDang;
using SQL.cn.khachHang;
using SQL.cn.nhanVien;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQL.cn.chuNha
{
    public partial class dsNhaSoHua : Form
    {
        public dsNhaSoHua()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f = new dsKhachHang();
            f.Show();
        }

        private void btnCus_Click(object sender, EventArgs e)
        {
            Form f = new dsBaiDang();
            f.Show();
        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            Form f = new dsNhanVien();
            f.Show();
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            Form f = new themBaiDang();
            f.Show();
        }

        private void dsNhaSoHua_Load(object sender, EventArgs e)
        {

        }
    }
}
