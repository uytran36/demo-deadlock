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
    public partial class ctietLSThue : Form
    {
        String maThue;
        public ctietLSThue(String maThue, String maKH, String maNha, String ngayThue)
        {
            InitializeComponent();
            this.maThue = maThue;
            tbMaKH.Text = maKH;
            tbMaNha.Text = maNha;
            tbNgayThue.Text = ngayThue;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
                string cnstr = @"Data Source =.; Initial Catalog = qlnd; Integrated Security = True";
                SqlConnection cn = new SqlConnection(cnstr);

                SqlCommand cmd = new SqlCommand("sp_updateLichSuThue", cn);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Clear();
                cmd.Parameters.Add("@malichsu", SqlDbType.NChar).Value = this.maThue;
                cmd.Parameters.Add("@makhachhang", SqlDbType.NChar).Value = tbMaKH.Text;
                cmd.Parameters.Add("@manha", SqlDbType.NChar).Value = tbMaNha.Text;
                cmd.Parameters.Add("@ngaythue", SqlDbType.DateTime).Value = DateTime.Parse(tbNgayThue.Text);
                cn.Open();

                cmd.ExecuteNonQuery();

                cn.Close();

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đã xóa");
            this.Close();
        }
    }
}
