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
    public partial class themChiTietLSBan : Form
    {
        public themChiTietLSBan()
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

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string cnstr = @"Data Source =.; Initial Catalog = qlnd; Integrated Security = True"; ;
            SqlConnection cn = new SqlConnection(cnstr);
            SqlCommand cmd;

            if (tbIDLSban.Text == "" || tbIDMaKH.Text == "" || tbNha.Text == "" || tbNgban.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else
            {
                cn.Open();
                cmd = new SqlCommand("sp_insertLichSuBan", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@malichsu", SqlDbType.NChar).Value = tbIDLSban.Text;
                cmd.Parameters.Add("@makhachhang", SqlDbType.NChar).Value = tbIDMaKH.Text;
                cmd.Parameters.Add("@manha", SqlDbType.NChar).Value = tbNha.Text;
                cmd.Parameters.Add("@ngayban", SqlDbType.DateTime).Value = tbNgban.Text;
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
