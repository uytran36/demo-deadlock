using SQL.cn.chuNha;
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

namespace SQL.cn.baiDang
{
    public partial class chiTietBaiDang : Form
    {
        public chiTietBaiDang(string bd, string duong, string quan, string khuvuc, string thanhpho, string slx,
            string tt, string sophong, string nd, string nhh, string giathue, string giaban, string mcn, string idchunha,
            string loainha)
        {
            InitializeComponent();
            tbBaiDang.Text = bd;
            tbDuong.Text = duong;
            tbQuan.Text = quan;
            tbKhuVuc.Text = khuvuc;
            tbThanhPho.Text = thanhpho;
            tbSLX.Text = slx;
            tbTinhTrang.Text = tt;
            tbSoPhong.Text = sophong;
            tbND.Text = nd;
            tbNHH.Text = nhh;
            tbGiaThue.Text = giathue;
            tbGiaBan.Text = giaban;
            tbMaChiNhanh.Text = mcn;
            tbIDChuNha.Text = idchunha;
            tbLoaiNha.Text = loainha;
        }

        private void btnUpdateSLX_Click(object sender, EventArgs e)
        {
            string cnstr = @"Data Source =.; Initial Catalog = qlnd; Integrated Security = True";
            SqlConnection cn = new SqlConnection(cnstr);
            cn.Open();
            SqlCommand cmd = new SqlCommand("sp_lostUpdate_luotXem_fixed", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@manha", SqlDbType.NChar).Value = tbBaiDang.Text;
            cmd.ExecuteNonQuery();
            cn.Close();
            MessageBox.Show("Cập nhật thành công");
            tbSLX.Text = (Convert.ToInt32(tbSLX.Text) + 1).ToString();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string cnstr = @"Data Source =.; Initial Catalog = qlnd; Integrated Security = True";
            SqlConnection cn = new SqlConnection(cnstr);

            SqlCommand cmd = new SqlCommand("sp_unrepeatableRead_tinhTrang2", cn);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Clear();
            cmd.Parameters.Add("@maNha", SqlDbType.NChar).Value = tbBaiDang.Text;
            cmd.Parameters.Add("@tt", SqlDbType.Int).Value = Convert.ToInt32(tbTinhTrang.Text);
            cn.Open();
            
            int i = cmd.ExecuteNonQuery();

            cn.Close();

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

        private void btnNhanXet_Click(object sender, EventArgs e)
        {
            var frm_NhanXet = new dsNhanXet(tbBaiDang.Text);
            frm_NhanXet.Location = this.Location;
            frm_NhanXet.StartPosition = FormStartPosition.Manual;
            frm_NhanXet.FormClosing += delegate { this.Show(); };
            frm_NhanXet.Show();
            this.Hide();
        }
    }
}
