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
            Form f = new dsKhachHang();
            f.Show();
        }

        private void btnOwner_Click(object sender, EventArgs e)
        {
            Form f = new dsChuNha();
            f.Show();
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            Form f = new dsNhanVien();
            f.Show();
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
            Form f = new themBaiDang();
            f.Show();
        }
    }
}
