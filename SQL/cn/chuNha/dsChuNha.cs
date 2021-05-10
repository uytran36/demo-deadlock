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
            Form f = new dsKhachHang();
            f.Show();
        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            Form f = new dsBaiDang();
            f.Show();
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            Form f = new dsNhanVien();
            f.Show();
        }

      
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form f = new themChuNha();
            f.Show();
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
    }
}
