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

namespace SQL.nv.khachHang
{
    public partial class themLSXem : Form
    {
        public themLSXem()
        {
            InitializeComponent();
            
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string cnstr = @"Data Source =.; Initial Catalog = qlnd; Integrated Security = True"; ;
            SqlConnection cn = new SqlConnection(cnstr);
            SqlCommand cmd;

            if (tbMaKH.Text == "" || tbMaNha.Text == "" || tbNgayXem.Text == "" || tbMaXem.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else
            {
                cn.Open();
                cmd = new SqlCommand("sp_phantom_lsXem2", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@maXem", SqlDbType.NChar).Value = tbMaXem.Text;
                cmd.Parameters.Add("@maKH", SqlDbType.NChar).Value = tbMaKH.Text;
                cmd.Parameters.Add("@maNha", SqlDbType.NChar).Value = tbMaNha.Text;
                cmd.Parameters.Add("@ngayXem", SqlDbType.DateTime).Value = tbNgayXem.Text;
            
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm thành công");
                this.Close();
                cn.Close();
            }
        }
    }
}
