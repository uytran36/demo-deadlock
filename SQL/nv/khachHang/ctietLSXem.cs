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
    public partial class ctietLSXem : Form
    {
        String maXem;
        public ctietLSXem(String maXem, String maKH, String maNha, String ngayXem)
        {
            InitializeComponent();
            tbMaKH.Text = maKH;
            tbMaNha.Text = maNha;
            tbNgayXem.Text = ngayXem;
            this.maXem = maXem;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string cnstr = @"Data Source =.; Initial Catalog = qlnd; Integrated Security = True";
            SqlConnection cn = new SqlConnection(cnstr);

            SqlCommand cmd = new SqlCommand("sp_dirtyRead_lichSuXem", cn);

            cmd.CommandType = CommandType.StoredProcedure;
            
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@maXem", SqlDbType.NChar).Value = this.maXem;
            cmd.Parameters.Add("@maKH", SqlDbType.NChar).Value = tbMaKH.Text;
            cmd.Parameters.Add("@maNha", SqlDbType.NChar).Value = tbMaNha.Text;
            cmd.Parameters.Add("@ngayXem", SqlDbType.DateTime).Value = DateTime.Parse(tbNgayXem.Text);
            cn.Open();

            int i = cmd.ExecuteNonQuery();

            cn.Close();

            
        }
    }
}
