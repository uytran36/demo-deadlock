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

namespace SQL.nv.khachHang
{
    public partial class dsLichSuThue : Form
    {
        public dsLichSuThue()
        {
            InitializeComponent();
        }
        private void dsLichSuThue_load(object sender, EventArgs e)
        {
            string cnstr = @"Data Source =.; Initial Catalog = qlnd; Integrated Security = True";
            SqlConnection cn = new SqlConnection(cnstr);

            SqlCommand cmd = new SqlCommand("sp_xemlsthue", cn);
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
            var f = new themLSThue();
            f.Location = this.Location;
            f.StartPosition = FormStartPosition.Manual;
            f.FormClosing += delegate { this.Show(); };
            f.Show();
            this.Hide();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridView1.CurrentRow.Selected = true;
                String maThue, maKH, maNha, ngayThue;
                maThue = dataGridView1.Rows[e.RowIndex].Cells["MaLichSuThue"].FormattedValue.ToString();
                maKH = dataGridView1.Rows[e.RowIndex].Cells["MaKhachHang"].FormattedValue.ToString();
                maNha = dataGridView1.Rows[e.RowIndex].Cells["MaNha"].FormattedValue.ToString();
                ngayThue = dataGridView1.Rows[e.RowIndex].Cells["NgayThue"].FormattedValue.ToString();

                var frm_ctLSXem = new ctietLSThue(maThue, maKH, maNha, ngayThue);
                frm_ctLSXem.Location = this.Location;
                frm_ctLSXem.StartPosition = FormStartPosition.Manual;
                frm_ctLSXem.FormClosing += delegate { this.Show(); this.dsLichSuThue_load(null, null); };
                frm_ctLSXem.Show();
                this.Hide();
            }
        }
    }
}
