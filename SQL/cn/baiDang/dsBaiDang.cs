using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SQL.cn.khachHang;
using SQL.cn.chuNha;
using SQL.cn.nhanVien;
using System.Data.SqlClient;

namespace SQL.cn.baiDang
{
    public partial class dsBaiDang : Form
    {
        public dsBaiDang()
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

        private void dsBaiDang_Load(object sender, EventArgs e)
        {
            string cnstr = @"Data Source =.; Initial Catalog = qlnd; Integrated Security = True";
            SqlConnection cn = new SqlConnection(cnstr);
            cn.Open();
            SqlCommand cmd = new SqlCommand("sp_xemnha", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridViewBaiDang.DataSource = dt;
            dataGridViewBaiDang.Columns.Remove("daXoa");
            dataGridViewBaiDang.ReadOnly = true;
            cn.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var frm_ThemBD = new themBaiDang();
            frm_ThemBD.Location = this.Location;
            frm_ThemBD.StartPosition = FormStartPosition.Manual;
            frm_ThemBD.FormClosing += delegate { this.Show(); };
            frm_ThemBD.Show();
            this.Hide();
        }

        private void dataGridViewBaiDang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string baidang = dataGridViewBaiDang.Rows[e.RowIndex].Cells["MaNha"].FormattedValue.ToString();
            string duong = dataGridViewBaiDang.Rows[e.RowIndex].Cells["Duong"].FormattedValue.ToString();
            string quan = dataGridViewBaiDang.Rows[e.RowIndex].Cells["Quan"].FormattedValue.ToString();
            string khuvuc = dataGridViewBaiDang.Rows[e.RowIndex].Cells["KhuVuc"].FormattedValue.ToString();
            string thanhpho = dataGridViewBaiDang.Rows[e.RowIndex].Cells["ThanhPho"].FormattedValue.ToString();
            string soluotxem = dataGridViewBaiDang.Rows[e.RowIndex].Cells["SoLuotXem"].FormattedValue.ToString();
            string tinhtrang = dataGridViewBaiDang.Rows[e.RowIndex].Cells["TinhTrang"].FormattedValue.ToString();
            string sophong = dataGridViewBaiDang.Rows[e.RowIndex].Cells["SoPhong"].FormattedValue.ToString();
            string ngaydang = dataGridViewBaiDang.Rows[e.RowIndex].Cells["NgayDang"].FormattedValue.ToString();
            string ngayhethan = dataGridViewBaiDang.Rows[e.RowIndex].Cells["NgayHetHan"].FormattedValue.ToString();
            string giathue = dataGridViewBaiDang.Rows[e.RowIndex].Cells["GiaChoThueMotThang"].FormattedValue.ToString();
            string giaban = dataGridViewBaiDang.Rows[e.RowIndex].Cells["GiaBan"].FormattedValue.ToString();
            string machinhanh = dataGridViewBaiDang.Rows[e.RowIndex].Cells["MaChiNhanh"].FormattedValue.ToString();
            string idchunha = dataGridViewBaiDang.Rows[e.RowIndex].Cells["MaChuNha"].FormattedValue.ToString();
            string loainha = dataGridViewBaiDang.Rows[e.RowIndex].Cells["MaLoaiNha"].FormattedValue.ToString();

            var frm_chiTietBD = new chiTietBaiDang(baidang, duong, quan, khuvuc, thanhpho, soluotxem, tinhtrang, sophong,
                ngaydang, ngayhethan, giathue, giaban, machinhanh, idchunha, loainha);
            frm_chiTietBD.Location = this.Location;
            frm_chiTietBD.StartPosition = FormStartPosition.Manual;
            frm_chiTietBD.FormClosing += delegate { this.Show(); this.dsBaiDang_Load(null, null); };
            frm_chiTietBD.Show();

            this.Hide();
        }
    }
}
