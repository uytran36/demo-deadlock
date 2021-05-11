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
    public partial class dsNhanVien : Form
    {
        public dsNhanVien()
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var frm_ThemNV = new themNhanVien();
            frm_ThemNV.Location = this.Location;
            frm_ThemNV.StartPosition = FormStartPosition.Manual;
            frm_ThemNV.FormClosing += delegate { this.Show(); };
            frm_ThemNV.Show();
            this.Hide();
        }

        private void dsNhanVien_Load(object sender, EventArgs e)
        {
            string cnstr = @"Data Source =.; Initial Catalog = qlnd; Integrated Security = True";
            SqlConnection cn = new SqlConnection(cnstr);
            cn.Open();
            SqlCommand cmd = new SqlCommand("sp_xemnv", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridViewNhanVien.DataSource = dt;
            dataGridViewNhanVien.Columns.Remove("daXoa");
            dataGridViewNhanVien.ReadOnly = true;
            cn.Close();
        }

        private void dataGridViewNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string manhanvien = dataGridViewNhanVien.Rows[e.RowIndex].Cells["MaNhanVien"].FormattedValue.ToString();
            string tennhanvien = dataGridViewNhanVien.Rows[e.RowIndex].Cells["TenNhanVien"].FormattedValue.ToString();
            string ngaysinh = dataGridViewNhanVien.Rows[e.RowIndex].Cells["NgaySinh"].FormattedValue.ToString();
            string gioitinh = dataGridViewNhanVien.Rows[e.RowIndex].Cells["GioiTinh"].FormattedValue.ToString();
            string duong = dataGridViewNhanVien.Rows[e.RowIndex].Cells["Duong"].FormattedValue.ToString();
            string quan = dataGridViewNhanVien.Rows[e.RowIndex].Cells["Quan"].FormattedValue.ToString();
            string thanhpho = dataGridViewNhanVien.Rows[e.RowIndex].Cells["ThanhPho"].FormattedValue.ToString();
            string khuvuc = dataGridViewNhanVien.Rows[e.RowIndex].Cells["KhuVuc"].FormattedValue.ToString();
            string sodienthoai = dataGridViewNhanVien.Rows[e.RowIndex].Cells["SoDienThoai"].FormattedValue.ToString();
            string machinhanh = dataGridViewNhanVien.Rows[e.RowIndex].Cells["MaChiNhanh"].FormattedValue.ToString();

            var frm_chiTietBD = new chiTietNhanVien(manhanvien, tennhanvien, ngaysinh, gioitinh,
                                        duong, quan, thanhpho, khuvuc, sodienthoai, machinhanh);
            frm_chiTietBD.Location = this.Location;
            frm_chiTietBD.StartPosition = FormStartPosition.Manual;
            frm_chiTietBD.FormClosing += delegate { this.Show(); this.dsNhanVien_Load(null, null); };
            frm_chiTietBD.Show();

            this.Hide();
        }
    }
}
