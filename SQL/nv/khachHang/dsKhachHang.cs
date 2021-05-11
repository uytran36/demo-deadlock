using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using SQL.nv.baiDang;
using SQL.nv.chuNha;

namespace SQL.nv.khachHang
{
    public partial class dsKhachHang : Form
    {
        public dsKhachHang()
        {
            InitializeComponent();
        }

        private void labelHello_Click(object sender, EventArgs e)
        {

        }
        private void dsKhachHang_load(object sender, EventArgs e)
        {
            string cnstr = @"Data Source =.; Initial Catalog = qlnd; Integrated Security = True";
            SqlConnection cn = new SqlConnection(cnstr);

            SqlCommand cmd = new SqlCommand("sp_xemkh", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cn.Open();
            int i = cmd.ExecuteNonQuery();

            cn.Close();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            cn.Close();
            dataGridView1.ClearSelection();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Selected = true;
            }
        }

        private void btnCus_Click(object sender, EventArgs e)
        {
            //var frm_KhachHang = new dsKhachHang();
            //frm_KhachHang.Location = this.Location;
            //frm_KhachHang.StartPosition = FormStartPosition.Manual;
            //frm_KhachHang.FormClosing += delegate { this.Show(); };
            //frm_KhachHang.Show();
            //this.Hide();
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

        private void btnUser_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridView1.CurrentRow.Selected = true;
                String hoTen, sdt, diaChi, duong, quan, thanhPho, khuVuc, maCN, maNV, thongTinLN, tieuChi;
                hoTen = dataGridView1.Rows[e.RowIndex].Cells["TenKhachHang"].FormattedValue.ToString();
                sdt = dataGridView1.Rows[e.RowIndex].Cells["SoDienThoai"].FormattedValue.ToString();
                duong = dataGridView1.Rows[e.RowIndex].Cells["Duong"].FormattedValue.ToString();
                quan = dataGridView1.Rows[e.RowIndex].Cells["Quan"].FormattedValue.ToString();
                thanhPho = dataGridView1.Rows[e.RowIndex].Cells["ThanhPho"].FormattedValue.ToString();
                khuVuc = dataGridView1.Rows[e.RowIndex].Cells["KhuVuc"].FormattedValue.ToString();
                diaChi = duong + ", " + quan + ", " + thanhPho + ", " + khuVuc;
                maCN = dataGridView1.Rows[e.RowIndex].Cells["MaChiNhanh"].FormattedValue.ToString();
                maNV = dataGridView1.Rows[e.RowIndex].Cells["MaNhanVien"].FormattedValue.ToString();
                thongTinLN = dataGridView1.Rows[e.RowIndex].Cells["ThongTinNhaYeuCau"].FormattedValue.ToString();
                tieuChi = dataGridView1.Rows[e.RowIndex].Cells["TieuChi"].FormattedValue.ToString();

                var frm_chiTietKhachHang = new ctietKhachHang(hoTen, sdt, diaChi, maCN, maNV, thongTinLN, tieuChi);
                frm_chiTietKhachHang.Location = this.Location;
                frm_chiTietKhachHang.StartPosition = FormStartPosition.Manual;
                frm_chiTietKhachHang.FormClosing += delegate { this.Show(); };
                frm_chiTietKhachHang.Show();
                this.Hide();
            }
        }
    }
}
