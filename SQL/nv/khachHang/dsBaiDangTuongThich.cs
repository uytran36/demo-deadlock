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
    public partial class dsBaiDangTuongThich : Form
    {
        String tieuChi;
        public dsBaiDangTuongThich(String tieuChi)
        {
            InitializeComponent();
            this.tieuChi = tieuChi;
        }

        private void dsBaiDangTuongThich_load(object sender, EventArgs e)
        {
            string cnstr = @"Data Source =.; Initial Catalog = qlnd; Integrated Security = True";
            SqlConnection cn = new SqlConnection(cnstr);

            SqlCommand cmd = new SqlCommand("select * from Nha where Duong like '%" + this.tieuChi + "%'", cn);
            cmd.CommandType = CommandType.Text;

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
