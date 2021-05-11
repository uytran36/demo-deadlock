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

namespace SQL.cn.baiDang
{
    public partial class chiTietNhanXet : Form
    {
        public chiTietNhanXet(string manx, string manha, string makh, string nd)
        {
            InitializeComponent();
            tbIDNhanXet.Text = manx;
            tbIDMaNha.Text = manha;
            tbKhachHang.Text = makh;
            tbNoiDung.Text = nd;
            tbIDNhanXet.ReadOnly = true;
            tbIDMaNha.ReadOnly = true;
            tbKhachHang.ReadOnly = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string cnstr = @"Data Source =.; Initial Catalog = qlnd; Integrated Security = True";
            SqlConnection cn = new SqlConnection(cnstr);


            SqlCommand cmd = new SqlCommand("sp_lostUpdate_nhanXet", cn);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Clear();
            cmd.Parameters.Add("@manhanxet", SqlDbType.NChar).Value = tbIDNhanXet.Text;
            cmd.Parameters.Add("@noidungnhanxet", SqlDbType.NVarChar).Value = tbNoiDung.Text;
            cn.Open();

            int i = cmd.ExecuteNonQuery();

            cn.Close();

            MessageBox.Show("Cập nhật thành công");
        }
    }
}
