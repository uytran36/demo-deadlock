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
    public partial class ctietHopDong : Form
    {
        String maHopDong;
        String trangThaiHieuLuc;
        public ctietHopDong(String benA, String benB, String maNha, String ngayLap, String thoiHan, String nhanVien, String maHopDong, String trangThaiHieuLuc)
        {
            InitializeComponent();
            this.maHopDong = maHopDong;
            this.trangThaiHieuLuc = trangThaiHieuLuc;
            tbA.Text = benA;
            tbB.Text = benB;
            tbMaNha.Text = maNha;
            tbNgayLap.Text = ngayLap;
            tbThoiHan.Text = thoiHan;
            tbMaNhanVien.Text = nhanVien;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string cnstr = @"Data Source =.; Initial Catalog = qlnd; Integrated Security = True";
            SqlConnection cn = new SqlConnection(cnstr);


            SqlCommand cmd = new SqlCommand("sp_updateHD", cn);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Clear();
            cmd.Parameters.Add("@maHopDong", SqlDbType.NChar).Value = this.maHopDong;
            cmd.Parameters.Add("@maNhanVien", SqlDbType.NChar).Value = tbMaNhanVien.Text;
            cmd.Parameters.Add("@maNha", SqlDbType.NChar).Value = tbMaNha.Text;
            cmd.Parameters.Add("@maChuNha", SqlDbType.NChar).Value = tbA.Text;
            cmd.Parameters.Add("@maKhachHang", SqlDbType.NChar).Value = tbB.Text;
            cmd.Parameters.Add("@ngayLap", SqlDbType.DateTime).Value = DateTime.Parse(tbNgayLap.Text);
            cmd.Parameters.Add("@thoiHan", SqlDbType.Int).Value = Int32.Parse(tbThoiHan.Text);
            cmd.Parameters.Add("@trangThaiHieuLuc", SqlDbType.Int).Value = Int32.Parse(this.trangThaiHieuLuc);

            cn.Open();
            int i = cmd.ExecuteNonQuery();

            cn.Close();
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }
    }
}
