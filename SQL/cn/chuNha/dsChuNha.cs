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

namespace SQL.cn.chuNha
{
    public partial class dsChuNha : Form
    {
        public dsChuNha()
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

        private void btnStaff_Click(object sender, EventArgs e)
        {
            var frm_NhanVien = new dsNhanVien();
            frm_NhanVien.Location = this.Location;
            frm_NhanVien.StartPosition = FormStartPosition.Manual;
            frm_NhanVien.FormClosing += delegate { this.Show(); };
            frm_NhanVien.Show();
            this.Hide();
        }

      
        private void btnAdd_Click(object sender, EventArgs e)
        {
            
        }
       
        private void dsChuNha_Load(object sender, EventArgs e)
        {
            String cnstr = @"Data Source =.; Initial Catalog = qlnd; Integrated Security = True";
            SqlConnection cn = new SqlConnection(cnstr);

            cn.Open();
            SqlCommand cmd = new SqlCommand("sp_xemcn", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;
            dataGridView1.Columns.Remove("daXoa");
            dataGridView1.ReadOnly = true;
            cn.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridView1.CurrentRow.Selected = true;
                String maChuNha,hoTen, sdt, diaChi, duong, quan, thanhPho, khuVuc;
                maChuNha = dataGridView1.Rows[e.RowIndex].Cells["MaChuNha"].FormattedValue.ToString();
                hoTen = dataGridView1.Rows[e.RowIndex].Cells["TenChuNha"].FormattedValue.ToString();
                sdt = dataGridView1.Rows[e.RowIndex].Cells["SoDienThoai"].FormattedValue.ToString();
                duong = dataGridView1.Rows[e.RowIndex].Cells["Duong"].FormattedValue.ToString();
                quan = dataGridView1.Rows[e.RowIndex].Cells["Quan"].FormattedValue.ToString();
                thanhPho = dataGridView1.Rows[e.RowIndex].Cells["ThanhPho"].FormattedValue.ToString();
                khuVuc = dataGridView1.Rows[e.RowIndex].Cells["KhuVuc"].FormattedValue.ToString();
                diaChi = duong + ", " + quan + ", " + thanhPho + ", " + khuVuc;
             

                var frm_chiTietChuNha = new ctietChuNha(maChuNha,hoTen, sdt, diaChi, "1", "1");
                frm_chiTietChuNha.Location = this.Location;
                frm_chiTietChuNha.StartPosition = FormStartPosition.Manual;
                frm_chiTietChuNha.FormClosing += delegate { this.Show(); this.dsChuNha_Load(null, null); };
                frm_chiTietChuNha.Show();
                this.Hide();
            }
        }
    }
}
