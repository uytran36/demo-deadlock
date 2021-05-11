using SQL.cn.baiDang;
using SQL.cn.khachHang;
using SQL.cn.nhanVien;
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

namespace SQL.cn.chuNha
{
    public partial class ctietChuNha : Form
    {
        String maChuNha;
        public ctietChuNha(String maChuNha, String hoTen, String sdt, String diaChi, String maCN, String maNV)
        {
            InitializeComponent();
            tbTen.Text = hoTen;
            tbSDT.Text = sdt;
            tbDiaChi.Text = diaChi;
            tbMaChiNhanh.Text = maCN;
            tbMaNhanVien.Text = maNV;
            this.maChuNha = maChuNha;
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

        private void btnHopDong_Click(object sender, EventArgs e)
        {
            var frm_hopDong = new dsHopDong();
            frm_hopDong.Location = this.Location;
            frm_hopDong.StartPosition = FormStartPosition.Manual;
            frm_hopDong.FormClosing += delegate { this.Show(); };
            frm_hopDong.Show();
            this.Hide();
        }

        private void btnLichSuDang_Click(object sender, EventArgs e)
        {
            var frm_lsDang = new dsLichSuDang();
            frm_lsDang.Location = this.Location;
            frm_lsDang.StartPosition = FormStartPosition.Manual;
            frm_lsDang.FormClosing += delegate { this.Show(); };
            frm_lsDang.Show();
            this.Hide();
        }

        private void btnLichSuBan_Click(object sender, EventArgs e)
        {
            var frm_lsBan = new dsLichSuBan();
            frm_lsBan.Location = this.Location;
            frm_lsBan.StartPosition = FormStartPosition.Manual;
            frm_lsBan.FormClosing += delegate { this.Show(); };
            frm_lsBan.Show();
            this.Hide();
        }

        private void btnDSN_Click(object sender, EventArgs e)
        {
            String tc = this.maChuNha;
            var frm_dsBDTT = new dsNhaSoHuu(tc);
            frm_dsBDTT.Location = this.Location;
            frm_dsBDTT.StartPosition = FormStartPosition.Manual;
            frm_dsBDTT.FormClosing += delegate { this.Show(); };
            frm_dsBDTT.Show();
            this.Hide();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string cnstr = @"Data Source =.; Initial Catalog = qlnd; Integrated Security = True";
            SqlConnection cn = new SqlConnection(cnstr);

            SqlCommand cmd = new SqlCommand("sp_unrepeatableRead_sdt2", cn);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Clear();
            cmd.Parameters.Add("@maChuNha", SqlDbType.NChar).Value = this.maChuNha;
            cmd.Parameters.Add("@sdt", SqlDbType.NChar).Value = tbSDT.Text;
            cn.Open();

            int i = cmd.ExecuteNonQuery();

            cn.Close();

            cmd = new SqlCommand("sp_lostUpdate_sdt", cn);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Clear();
            cmd.Parameters.Add("@maChuNha", SqlDbType.NChar).Value = this.maChuNha;
            cmd.Parameters.Add("@sdt", SqlDbType.NChar).Value = tbSDT.Text;
            cn.Open();

            i = cmd.ExecuteNonQuery();

            cn.Close();
            MessageBox.Show("Lưu thành công");

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
