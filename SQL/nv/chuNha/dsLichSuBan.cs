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
    public partial class dsLichSuBan : Form
    {
        public dsLichSuBan()
        {
            InitializeComponent();
        }

        private void labelHello_Click(object sender, EventArgs e)
        {

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

        private void dsLichSuBan_Load(object sender, EventArgs e)
        {
            String cnstr = @"Data Source =.; Initial Catalog = qlnd; Integrated Security = True";
            SqlConnection cn = new SqlConnection(cnstr);

            cn.Open();
            SqlCommand cmd = new SqlCommand("sp_xemlsban", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;
            dataGridView1.ReadOnly = true;

            cn.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var frm_themLSB = new themChiTietLSBan();
            frm_themLSB.Location = this.Location;
            frm_themLSB.StartPosition = FormStartPosition.Manual;
            frm_themLSB.FormClosing += delegate { this.Show(); dsLichSuBan_Load(null, null); };
            frm_themLSB.Show();
            this.Hide();
        }
    }
}
