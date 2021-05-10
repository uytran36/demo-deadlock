using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SQL.cn.nhanVien;
using SQL.cn.chuNha;
using SQL.cn.baiDang;
using SQL.cn.khachHang;

namespace SQL.cn.baiDang
{
    public partial class dsNhanXet : Form
    {
        public dsNhanXet()
        {
            InitializeComponent();
        }

        private void btnCus_Click(object sender, EventArgs e)
        {
            Form f = new dsKhachHang();
            f.Show();
        }

        private void btnOwner_Click(object sender, EventArgs e)
        {
            Form f = new dsChuNha();
            f.Show();
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            Form f = new dsNhanVien();
            f.Show();
        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            Form f = new dsBaiDang();
            f.Show();
        }
    }
}
