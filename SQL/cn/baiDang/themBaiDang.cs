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
using SQL.cn.khachHang;
using System.Data.SqlClient;
using System.Globalization;

namespace SQL.cn.baiDang
{
    public partial class themBaiDang : Form
    {
        public themBaiDang()
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
        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string cnstr = @"Data Source =.; Initial Catalog = qlnd; Integrated Security = True"; ;
            SqlConnection cn = new SqlConnection(cnstr);
            SqlCommand cmd;
            if (tbMaChiNhanh.Text == "" || tbBaiDang.Text == "" || tbDuong.Text == "" || tbQuan.Text == "" || tbThanhPho.Text == ""
                || tbKhuVuc.Text == "" || tbIDChuNha.Text == "" || tbSoPhong.Text == "" || tbLoaiNha.Text == "" || tbND.Text == ""
                || tbSLX.Text == "" || tbTinhTrang.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else
            {
                cn.Open();
                cmd = new SqlCommand("addBD", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@add1", SqlDbType.NChar).Value = tbBaiDang.Text;
                cmd.Parameters.Add("@add2", SqlDbType.NVarChar).Value = tbDuong.Text;
                cmd.Parameters.Add("@add3", SqlDbType.NVarChar).Value = tbQuan.Text;
                cmd.Parameters.Add("@add4", SqlDbType.NVarChar).Value = tbKhuVuc.Text;
                cmd.Parameters.Add("@add5", SqlDbType.NVarChar).Value = tbThanhPho.Text;
                cmd.Parameters.Add("@add6", SqlDbType.Int).Value = (int)Convert.ToInt32(tbSLX.Text);
                cmd.Parameters.Add("@add7", SqlDbType.Int).Value = (int)Convert.ToInt32(tbTinhTrang.Text);
                cmd.Parameters.Add("@add8", SqlDbType.Int).Value = (int)Convert.ToInt32(tbSoPhong.Text);
                cmd.Parameters.Add("@add9", SqlDbType.DateTime).Value = Convert.ToDateTime(Convert.ToString(tbND.Text));
                cmd.Parameters.Add("@add10", SqlDbType.DateTime).Value = Convert.ToDateTime(Convert.ToString(tbNHH.Text));
                cmd.Parameters.Add("@add11", SqlDbType.Int).Value = (int)Convert.ToInt32(tbGiaThue.Text);
                cmd.Parameters.Add("@add12", SqlDbType.Int).Value = (int)Convert.ToInt32(tbGiaBan.Text);
                cmd.Parameters.Add("@add13", SqlDbType.NChar).Value = tbMaChiNhanh.Text;
                cmd.Parameters.Add("@add14", SqlDbType.NChar).Value = tbIDChuNha.Text;
                cmd.Parameters.Add("@add15", SqlDbType.NChar).Value = tbLoaiNha.Text;
                cmd.Parameters.Add("@add16", SqlDbType.Int).Value = 0;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm thành công");
                this.Close();
                cn.Close();
            }

            cn.Open();
            cmd = new SqlCommand("sp_phantom_dsNha2", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@maNha", SqlDbType.NChar).Value = tbBaiDang.Text;
            cmd.Parameters.Add("@duong", SqlDbType.NVarChar).Value = tbDuong.Text;
            cmd.Parameters.Add("@quan", SqlDbType.NVarChar).Value = tbQuan.Text;
            cmd.Parameters.Add("@khuVuc", SqlDbType.NVarChar).Value = tbKhuVuc.Text;
            cmd.Parameters.Add("@tp", SqlDbType.NVarChar).Value = tbThanhPho.Text;
            cmd.Parameters.Add("@slx", SqlDbType.Int).Value = (int)Convert.ToInt32(tbSLX.Text);
            cmd.Parameters.Add("@tt", SqlDbType.Int).Value = (int)Convert.ToInt32(tbTinhTrang.Text);
            cmd.Parameters.Add("@sp", SqlDbType.Int).Value = (int)Convert.ToInt32(tbSoPhong.Text);
            cmd.Parameters.Add("@ngDang", SqlDbType.DateTime).Value = Convert.ToDateTime(Convert.ToString(tbND.Text));
            cmd.Parameters.Add("@ngHetHan", SqlDbType.DateTime).Value = Convert.ToDateTime(Convert.ToString(tbNHH.Text));
            cmd.Parameters.Add("@giaCT", SqlDbType.Int).Value = (int)Convert.ToInt32(tbGiaThue.Text);
            cmd.Parameters.Add("@giaBan", SqlDbType.Int).Value = (int)Convert.ToInt32(tbGiaBan.Text);
            cmd.Parameters.Add("@maChiNhanh", SqlDbType.NChar).Value = tbMaChiNhanh.Text;
            cmd.Parameters.Add("@maChuNha", SqlDbType.NChar).Value = tbIDChuNha.Text;
            cmd.Parameters.Add("@maLoaiNha", SqlDbType.NChar).Value = tbLoaiNha.Text;
            cmd.Parameters.Add("@daXoa", SqlDbType.Int).Value = 0;

            cn.Close();
            MessageBox.Show("Thêm thành công");
        }
    }
}
