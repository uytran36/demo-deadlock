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
using SQL.cn.baiDang;
using System.Data.SqlClient;

namespace SQL.cn.khachHang
{
    public partial class dsKhachHang : Form
    {
        public dsKhachHang()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridView1.CurrentRow.Selected = true;
                String maKH, hoTen, sdt, diaChi, duong, quan, thanhPho, khuVuc, maCN, maNV, thongTinLN, tieuChi;
                maKH = dataGridView1.Rows[e.RowIndex].Cells["MaKhachHang"].FormattedValue.ToString();
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

                var frm_chiTietKhachHang = new ctietKhachHang(maKH,hoTen, sdt, diaChi, maCN, maNV, thongTinLN, tieuChi);
                frm_chiTietKhachHang.Location = this.Location;
                frm_chiTietKhachHang.StartPosition = FormStartPosition.Manual;
                frm_chiTietKhachHang.FormClosing += delegate { this.Show(); };
                frm_chiTietKhachHang.Show();
                this.Hide();
            }
        }

        private void dsKhachHang_Load(object sender, EventArgs e)
        {
            string cnstr = @"Data Source =.; Initial Catalog = qlnd; Integrated Security = True";
            SqlConnection cn = new System.Data.SqlClient.SqlConnection(cnstr);

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
            string cnstr = @"Data Source =.; Initial Catalog = qlnd; Integrated Security = True";
            SqlConnection cn = new SqlConnection(cnstr);

            SqlCommand cmd = new SqlCommand("sp_unrepeatableRead_diaChi", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cn.Open();
            int i = cmd.ExecuteNonQuery();

            cn.Close();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            cn.Close();
        }
    }
}
