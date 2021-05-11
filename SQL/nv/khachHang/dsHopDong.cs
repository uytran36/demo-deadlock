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
    public partial class dsHopDong : Form
    {
        public dsHopDong()
        {
            InitializeComponent();
        }
        private void dsHopDong_load(object sender, EventArgs e)
        {
            string cnstr = @"Data Source =.; Initial Catalog = qlnd; Integrated Security = True";
            SqlConnection cn = new SqlConnection(cnstr);

            SqlCommand cmd = new SqlCommand("sp_xemhd", cn);
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var f = new themHopDong();
            f.Location = this.Location;
            f.StartPosition = FormStartPosition.Manual;
            f.FormClosing += delegate { this.Show(); };
            f.Show();
            this.Hide();
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridView1.CurrentRow.Selected = true;
                String benA, benB, maNha, ngayLap, thoiHan, nhanVien, maHopDong, trangThaiHieuLuc;
              
                benA = dataGridView1.Rows[e.RowIndex].Cells["MaChuNha"].FormattedValue.ToString();
                benB = dataGridView1.Rows[e.RowIndex].Cells["MaKhachHang"].FormattedValue.ToString();
                maNha = dataGridView1.Rows[e.RowIndex].Cells["MaNha"].FormattedValue.ToString();
                ngayLap = dataGridView1.Rows[e.RowIndex].Cells["NgayLap"].FormattedValue.ToString();
                thoiHan = dataGridView1.Rows[e.RowIndex].Cells["ThoiHan"].FormattedValue.ToString();
                nhanVien = dataGridView1.Rows[e.RowIndex].Cells["MaNhanVien"].FormattedValue.ToString();
                maHopDong = dataGridView1.Rows[e.RowIndex].Cells["MaHopDong"].FormattedValue.ToString();
                trangThaiHieuLuc = dataGridView1.Rows[e.RowIndex].Cells["TrangThaiHieuLuc"].FormattedValue.ToString();
               

                var frm_chiTietKhachHang = new ctietHopDong(benA, benB, maNha, ngayLap, thoiHan, nhanVien, maHopDong, trangThaiHieuLuc);
                frm_chiTietKhachHang.Location = this.Location;
                frm_chiTietKhachHang.StartPosition = FormStartPosition.Manual;
                frm_chiTietKhachHang.FormClosing += delegate { this.Show(); };
                frm_chiTietKhachHang.Show();
                this.Hide();
            }
            dsHopDong_load(sender, e);
        }
    }
}
