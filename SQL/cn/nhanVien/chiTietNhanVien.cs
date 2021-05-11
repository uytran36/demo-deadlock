using SQL.cn.baiDang;
using SQL.cn.chuNha;
using SQL.cn.khachHang;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    }
}
