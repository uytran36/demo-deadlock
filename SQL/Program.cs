using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SQL.cn.baiDang;
using SQL.cn.nhanVien;
using SQL.cn.chuNha;
using SQL.cn.khachHang;
/*
using SQL.nv.baiDang;
using SQL.nv.chuNha;
using SQL.nv.khachHang;*/

namespace SQL
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new dsBaiDang());
        }
    }
}
