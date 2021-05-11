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
    public partial class chiTietBaiDang : Form
    {
        public chiTietBaiDang(string bd, string duong, string quan, string khuvuc, string thanhpho, string slx,
            string tt, string sophong, string nd, string nhh, string giathue, string giaban, string mcn, string idchunha,
            string loainha)
        {
            InitializeComponent();
            tbBaiDang.Text = bd;
            tbDuong.Text = duong;
            tbQuan.Text = quan;
            tbKhuVuc.Text = khuvuc;
            tbThanhPho.Text = thanhpho;
            tbSLX.Text = slx;
            tbTinhTrang.Text = tt;
            tbSoPhong.Text = sophong;
            tbND.Text = nd;
            tbNHH.Text = nhh;
            tbGiaThue.Text = giathue;
            tbGiaBan.Text = giaban;
            tbMaChiNhanh.Text = mcn;
            tbIDChuNha.Text = idchunha;
            tbLoaiNha.Text = loainha;
        }

        private void btnUpdateSLX_Click(object sender, EventArgs e)
        {
            string cnstr = @"Data Source =.; Initial Catalog = qlnd; Integrated Security = True";
            SqlConnection cn = new SqlConnection(cnstr);
            cn.Open();
            SqlCommand cmd = new SqlCommand("sp_lostUpdate_luotXem_fixed", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@manha", SqlDbType.NChar).Value = tbBaiDang.Text;
            cmd.ExecuteNonQuery();
            cn.Close();
            MessageBox.Show("Cập nhật thành công");
            tbSLX.Text = (Convert.ToInt32(tbSLX.Text) + 1).ToString();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            Form f = new dsBaiDang();
            f.Show();
            this.Close();
        }
    }
}
