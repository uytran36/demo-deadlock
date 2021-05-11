using SQL.cn.baiDang;
using SQL.cn.chuNha;
using SQL.cn.khachHang;
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

namespace SQL.cn.nhanVien
{
    public partial class chiTietNhanVien : Form
    {
        public chiTietNhanVien(string manv, string tennv, string ns, string gt,
               string duong, string quan, string thanhpho, string khuvuc, string sdt, string mcn)
        {
            InitializeComponent();
            tbIDNhanVien.Text = manv;
            tbName.Text = tennv;
            tbNgaySinh.Text = ns;
            tbGioiTinh.Text = gt;
            tbDuong.Text = duong;
            tbQuan.Text = quan;
            tbThanhPho.Text = thanhpho;
            tbKhuVuc.Text = khuvuc;
            tbSdt.Text = sdt;
            tbIDChiNhanh.Text = mcn;
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

        private void btnHopDong_Click(object sender, EventArgs e)
        {
            var frm_HopDong = new dsHopDong();
            frm_HopDong.Location = this.Location;
            frm_HopDong.StartPosition = FormStartPosition.Manual;
            frm_HopDong.FormClosing += delegate { this.Show(); };
            frm_HopDong.Show();
            this.Hide();
        }

        private void btnLSThue_Click(object sender, EventArgs e)
        {
            var frm_LSThue = new dsLichSuThue();
            frm_LSThue.Location = this.Location;
            frm_LSThue.StartPosition = FormStartPosition.Manual;
            frm_LSThue.FormClosing += delegate { this.Show(); };
            frm_LSThue.Show();
            this.Hide();
        }

        private void btnLSXN_Click(object sender, EventArgs e)
        {
            var frm_LSXem = new dsLichSuXem();
            frm_LSXem.Location = this.Location;
            frm_LSXem.StartPosition = FormStartPosition.Manual;
            frm_LSXem.FormClosing += delegate { this.Show(); };
            frm_LSXem.Show();
            this.Hide();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string cnstr = @"Data Source =.; Initial Catalog = qlnd; Integrated Security = True";
            SqlConnection cn = new SqlConnection(cnstr);

            SqlCommand cmd = new SqlCommand("sp_updatenv", cn);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Clear();
            cmd.Parameters.Add("@add1", SqlDbType.NChar).Value = tbIDNhanVien.Text;
            cmd.Parameters.Add("@add2", SqlDbType.NVarChar).Value = tbName.Text;
            cmd.Parameters.Add("@add3", SqlDbType.Date).Value = tbNgaySinh.Text;
            cmd.Parameters.Add("@add4", SqlDbType.NVarChar).Value = tbGioiTinh.Text;
            cmd.Parameters.Add("@add5", SqlDbType.NVarChar).Value = tbDuong.Text;
            cmd.Parameters.Add("@add6", SqlDbType.NVarChar).Value = tbQuan.Text;
            cmd.Parameters.Add("@add7", SqlDbType.NVarChar).Value = tbThanhPho.Text;
            cmd.Parameters.Add("@add8", SqlDbType.NVarChar).Value = tbKhuVuc.Text;
            cmd.Parameters.Add("@add9", SqlDbType.NChar).Value = tbSdt.Text;
            cmd.Parameters.Add("@add10", SqlDbType.NChar).Value = tbIDChiNhanh.Text;
            cmd.Parameters.Add("@add11", SqlDbType.Int).Value = 0;
            cn.Open();

            int i = cmd.ExecuteNonQuery();

            cn.Close();
            MessageBox.Show("Cập nhập thành công");
        }
    }
}
