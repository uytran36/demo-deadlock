using SQL.nv.chuNha;
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

namespace SQL.nv.baiDang
{
    public partial class themChiTietNhanXet : Form
    {
        public themChiTietNhanXet()
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

        private void btnOwner_Click(object sender, EventArgs e)
        {
            var frm_ChuNha = new dsChuNha();
            frm_ChuNha.Location = this.Location;
            frm_ChuNha.StartPosition = FormStartPosition.Manual;
            frm_ChuNha.FormClosing += delegate { this.Show(); };
            frm_ChuNha.Show();
            this.Hide();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string cnstr = @"Data Source =.; Initial Catalog = qlnd; Integrated Security = True"; ;
            SqlConnection cn = new SqlConnection(cnstr);
            SqlCommand cmd;

            if (tbIDMaNha.Text == "" || tbIDNhanXet.Text == "" || tbKhachHang.Text == "" || tbNoiDung.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else
            {
                cn.Open();
                cmd = new SqlCommand("sp_phantom_nhanXet2", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@maNha", SqlDbType.NChar).Value = tbIDMaNha.Text;
                cmd.Parameters.Add("@maNX", SqlDbType.NChar).Value = tbIDNhanXet.Text;
                cmd.Parameters.Add("@maKH", SqlDbType.NChar).Value = tbKhachHang.Text;
                cmd.Parameters.Add("@noidung", SqlDbType.NVarChar).Value = tbNoiDung.Text;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm thành công");
                this.Close();
                cn.Close();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
