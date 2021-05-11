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

            SqlCommand cmd = new SqlCommand("Update Xem set NgayXem = '" + tbNgayXem.Text + "', MaKhachHang = '" + 
                tbMaKH.Text + "', MaNha = '" + tbMaNha.Text + "' where MaXem = '" + this.maXem + "'", cn);

            cmd.CommandType = CommandType.Text;
            cn.Open();

            cmd.ExecuteNonQuery();

            cn.Close();

            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đã xóa");
            this.Close();
        }
    }
}
