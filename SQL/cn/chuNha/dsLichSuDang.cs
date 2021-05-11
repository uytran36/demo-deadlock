using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SQL.cn.baiDang;
using SQL.cn.nhanVien;
using SQL.cn.chuNha;
using SQL.cn.khachHang;
using System.Data.SqlClient;

namespace SQL.cn.chuNha
{
    public partial class dsLichSuDang : Form
    {
        public dsLichSuDang()
        {
            InitializeComponent();
        }

        private void btnCus_Click(object sender, EventArgs e)
        {
            var frm_KhachHang = new dsKhachHang();
            frm_KhachHang.Location = this.Location;
            frm_KhachHang.StartPosition = FormStartPosition.Manual;
            frm_KhachHang.FormClosing += delegate { this.Show(); };
            frm_KhachHang.Show();
            this.Hide();
        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            var frm_baiDang = new dsBaiDang();
            frm_baiDang.Location = this.Location;
            frm_baiDang.StartPosition = FormStartPosition.Manual;
            frm_baiDang.FormClosing += delegate { this.Show(); };
            frm_baiDang.Show();
            this.Hide();
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            var frm_NhanVien = new dsNhanVien();
            frm_NhanVien.Location = this.Location;
            frm_NhanVien.StartPosition = FormStartPosition.Manual;
            frm_NhanVien.FormClosing += delegate { this.Show(); };
            frm_NhanVien.Show();
            this.Hide();
        }

        private void dsLichSuDang_Load(object sender, EventArgs e)
        {
            String cnstr = @"Data Source =.; Initial Catalog = qlnd; Integrated Security = True";
            SqlConnection cn = new SqlConnection(cnstr);

            cn.Open();
            SqlCommand cmd = new SqlCommand("sp_xemlsdang", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;
            dataGridView1.ReadOnly = true;

            cn.Close();
        }
    }
}
