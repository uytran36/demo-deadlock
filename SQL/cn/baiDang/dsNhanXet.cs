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
using System.Data.SqlClient;

namespace SQL.cn.baiDang
{
    public partial class dsNhanXet : Form
    {
        string manha;
        public dsNhanXet(string manha)
        {
            InitializeComponent();
            this.manha = manha;
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

        private void btnOwner_Click(object sender, EventArgs e)
        {
            var frm_ChuNha = new dsChuNha();
            frm_ChuNha.Location = this.Location;
            frm_ChuNha.StartPosition = FormStartPosition.Manual;
            frm_ChuNha.FormClosing += delegate { this.Show(); };
            frm_ChuNha.Show();
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

        private void btnPost_Click(object sender, EventArgs e)
        {
            var frm_baiDang = new dsBaiDang();
            frm_baiDang.Location = this.Location;
            frm_baiDang.StartPosition = FormStartPosition.Manual;
            frm_baiDang.FormClosing += delegate { this.Show(); };
            frm_baiDang.Show();
            this.Hide();
        }

        private void dsNhanXet_Load(object sender, EventArgs e)
        {
            string cnstr = @"Data Source =.; Initial Catalog = qlnd; Integrated Security = True";
            SqlConnection cn = new SqlConnection(cnstr);
            cn.Open();
            SqlCommand cmd = new SqlCommand("sp_xemctnx", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@manha", SqlDbType.NChar).Value = manha;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;
            dataGridView1.ReadOnly = true;
            cn.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string manhanxet = dataGridView1.Rows[e.RowIndex].Cells["MaNhanXet"].FormattedValue.ToString();
            string manha = dataGridView1.Rows[e.RowIndex].Cells["MaNha"].FormattedValue.ToString();
            string makhachhang = dataGridView1.Rows[e.RowIndex].Cells["MaKhachHang"].FormattedValue.ToString();
            string noidung = dataGridView1.Rows[e.RowIndex].Cells["NoiDung"].FormattedValue.ToString();

            var frm_chiTietNX = new chiTietNhanXet(manhanxet, manha, makhachhang, noidung);
            frm_chiTietNX.Location = this.Location;
            frm_chiTietNX.StartPosition = FormStartPosition.Manual;
            frm_chiTietNX.FormClosing += delegate { this.Show(); this.dsNhanXet_Load(null, null); };
            frm_chiTietNX.Show();

            this.Hide();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            string cnstr = @"Data Source =.; Initial Catalog = qlnd; Integrated Security = True";
            SqlConnection cn = new SqlConnection(cnstr);

            SqlCommand cmd = new SqlCommand("sp_phantom_nhanXet", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cn.Open();
            int i = cmd.ExecuteNonQuery();

            cn.Close();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            cn.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var frm_ThemCTNX = new themChiTietNhanXet();
            frm_ThemCTNX.Location = this.Location;
            frm_ThemCTNX.StartPosition = FormStartPosition.Manual;
            frm_ThemCTNX.FormClosing += delegate { this.Show(); };
            frm_ThemCTNX.Show();
            this.Hide();
        }
    }
}
