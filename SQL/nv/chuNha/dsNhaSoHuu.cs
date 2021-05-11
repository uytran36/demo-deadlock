using SQL.nv.baiDang;
using SQL.nv.khachHang;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQL.nv.chuNha
{
    public partial class dsNhaSoHuu : Form
    {
        String maChuNha;
        public dsNhaSoHuu(String m)
        {
            InitializeComponent();
            this.maChuNha = m;
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

        private void dsNhaSoHuu_Load(object sender, EventArgs e)
        {
            String cnstr = @"Data Source =.; Initial Catalog = qlnd; Integrated Security = True";
            SqlConnection cn = new SqlConnection(cnstr);

            SqlCommand cmd = new SqlCommand("sp_xemnhaCN", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@maChuNha", SqlDbType.NChar).Value = this.maChuNha;
            cn.Open();
            int i = cmd.ExecuteNonQuery();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;
            dataGridView1.ReadOnly = true;
            cn.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var frm_ThemBD = new themBaiDang();
            frm_ThemBD.Location = this.Location;
            frm_ThemBD.StartPosition = FormStartPosition.Manual;
            frm_ThemBD.FormClosing += delegate { this.Show(); };
            frm_ThemBD.Show();
            this.Hide();
        }
    }
}
