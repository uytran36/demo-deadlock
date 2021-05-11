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
    public partial class dsLichSuXem : Form
    {
        public dsLichSuXem()
        {
            InitializeComponent();
            string cnstr = @"Data Source =.; Initial Catalog = qlnd; Integrated Security = True";
            SqlConnection cn = new SqlConnection(cnstr);

            SqlCommand cmd = new SqlCommand("sp_dirtyRead_lichSuXem2", cn);
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
        private void dsLichSuXem_load(object sender, EventArgs e)
        {
            string cnstr = @"Data Source =.; Initial Catalog = qlnd; Integrated Security = True";
            SqlConnection cn = new SqlConnection(cnstr);

            SqlCommand cmd = new SqlCommand("sp_xemxn", cn);
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridView1.CurrentRow.Selected = true;
                String maXem, maKH, maNha, ngayXem;
                maXem = dataGridView1.Rows[e.RowIndex].Cells["MaXem"].FormattedValue.ToString();
                maKH = dataGridView1.Rows[e.RowIndex].Cells["MaKhachHang"].FormattedValue.ToString();
                maNha = dataGridView1.Rows[e.RowIndex].Cells["MaNha"].FormattedValue.ToString();
                ngayXem = dataGridView1.Rows[e.RowIndex].Cells["NgayXem"].FormattedValue.ToString();
       
                var frm_ctLSXem = new ctietLSXem(maXem, maKH, maNha, ngayXem);
                frm_ctLSXem.Location = this.Location;
                frm_ctLSXem.StartPosition = FormStartPosition.Manual;
                frm_ctLSXem.FormClosing += delegate { this.Show(); this.dsLichSuXem_load(null, null); };
                frm_ctLSXem.Show();
                this.Hide();
            }
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var frm_ThemLSX = new themLSXem();
            frm_ThemLSX.Location = this.Location;
            frm_ThemLSX.StartPosition = FormStartPosition.Manual;
            frm_ThemLSX.FormClosing += delegate { this.Show(); };
            frm_ThemLSX.Show();
            this.Hide();
        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            string cnstr = @"Data Source =.; Initial Catalog = qlnd; Integrated Security = True";
            SqlConnection cn = new SqlConnection(cnstr);

            SqlCommand cmd = new SqlCommand("sp_dirtyRead_lichSuXem2", cn);
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
