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

namespace SQL.cn.khachHang
{
    public partial class ctietKhachHang : Form
    {
        String maKH;
        public ctietKhachHang(String maKH, String hoTen, String sdt, String diaChi, String maCN, String maNV, String thongTinLN, String tieuChi)
        {
            InitializeComponent();
            tbTen.Text = hoTen;
            tbSDT.Text = sdt;
            tbDiaChi.Text = diaChi;

            tbMaChiNhanh.Text = maCN;
            tbMaNhanVien.Text = maNV;
            tbThongTin.Text = thongTinLN;
            tbTieuChi.Text = tieuChi;
            this.maKH = maKH;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string cnstr = @"Data Source =.; Initial Catalog = qlnd; Integrated Security = True";
            SqlConnection cn = new SqlConnection(cnstr);
            String diachi = tbDiaChi.Text;
            String[] temp = diachi.Split(',');
            
            SqlCommand cmd = new SqlCommand("sp_unrepeatableRead_diaChi2", cn);

            cmd.CommandType = CommandType.StoredProcedure;
            
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@maKhachHang", SqlDbType.NChar).Value = this.maKH;
            cmd.Parameters.Add("@duong", SqlDbType.NChar).Value = temp[0];
            cn.Open();

            int i = cmd.ExecuteNonQuery();

            cn.Close();
            MessageBox.Show("Lưu thành công");
        }
    }
}
