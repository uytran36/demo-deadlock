using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SQL.nv.baiDang;
using SQL.nv.chuNha;
using SQL.nv.khachHang;

namespace SQL
{
    public partial class ctietKhachHang : Form
    {
        public ctietKhachHang(String hoTen, String sdt, String diaChi, String maCN, String maNV, String thongTinLN, String tieuChi)
        {
            InitializeComponent();
            tbTen.Text = hoTen;
            tbSDT.Text = sdt;
            tbDiaChi.Text = diaChi;
            tbMaChiNhanh.Text = maCN;
            tbMaNhanVien.Text = maNV;
            tbThongTin.Text = thongTinLN;
            tbTieuChi.Text = tieuChi;
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

        private void btnOwner_Click(object sender, EventArgs e)
        {
            var frm_chuNha = new dsChuNha();
            frm_chuNha.Location = this.Location;
            frm_chuNha.StartPosition = FormStartPosition.Manual;
            frm_chuNha.FormClosing += delegate { this.Show(); };
            frm_chuNha.Show();
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

        private void btnLichSuThue_Click(object sender, EventArgs e)
        {
            var frm_lsThue = new dsLichSuThue();
            frm_lsThue.Location = this.Location;
            frm_lsThue.StartPosition = FormStartPosition.Manual;
            frm_lsThue.FormClosing += delegate { this.Show(); };
            frm_lsThue.Show();
            this.Hide();
        }

        private void btnLichSuXem_Click(object sender, EventArgs e)
        {
            var frm_lsXem = new dsLichSuXem();
            frm_lsXem.Location = this.Location;
            frm_lsXem.StartPosition = FormStartPosition.Manual;
            frm_lsXem.FormClosing += delegate { this.Show(); };
            frm_lsXem.Show();
            this.Hide();

        }

        private void btnDanhSachNha_Click(object sender, EventArgs e)
        {
            String tc = tbTieuChi.Text;
            var frm_dsBDTT = new dsBaiDangTuongThich(tc);
            frm_dsBDTT.Location = this.Location;
            frm_dsBDTT.StartPosition = FormStartPosition.Manual;
            frm_dsBDTT.FormClosing += delegate { this.Show(); };
            frm_dsBDTT.Show();
            this.Hide();
        }
    }
}
