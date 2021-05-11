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
    public partial class themChuNha : Form
    {
        public themChuNha()
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

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (tbMaCN.Text == "" || tbDuong.Text == "" || tbQuan.Text == "" || tbThanhPho.Text == ""
                || tbKhuVuc.Text == "" || tbTen.Text == "" || tbMaChiNhanh.Text == "" || tbMaNhanVien.Text == "" || tbSDT.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else
            {
                String cnstr = @"Data Source =.; Initial Catalog = qlnd; Integrated Security = True";
                SqlConnection cn = new SqlConnection(cnstr);
                cn.Open();
                SqlCommand cmd = new SqlCommand("sp_insertChuNha", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@machunha", SqlDbType.NChar).Value = tbMaCN.Text;
                cmd.Parameters.Add("@tenchunha", SqlDbType.NVarChar).Value = tbTen.Text;
                cmd.Parameters.Add("@sdt", SqlDbType.NChar).Value = tbMaCN.Text;
                cmd.Parameters.Add("@duong", SqlDbType.NVarChar).Value = tbDuong.Text;
                cmd.Parameters.Add("@quan", SqlDbType.NVarChar).Value = tbQuan.Text;
                cmd.Parameters.Add("@khuvuc", SqlDbType.NVarChar).Value = tbKhuVuc.Text;
                cmd.Parameters.Add("@tp", SqlDbType.NVarChar).Value = tbThanhPho.Text;
                cmd.Parameters.Add("@daxoa", SqlDbType.Int).Value = 0;

                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm thành công");
                this.Close();
                cn.Close();
            }
        }
    }
}
