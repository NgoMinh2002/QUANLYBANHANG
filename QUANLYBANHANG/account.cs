using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYBANHANG
{
    internal class account
    {
        public static int loainguoidung;
        public static string tennguoidung;
        public static string strconaccount = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Thự tập tốt nghiệp- Ngô Minh Anh - 202190495\QL_BanHang\QUANLYBANHANG\QUANLYBANHANG\QL_hanghoa.mdf"";Integrated Security=True;Connect Timeout=30";
        public static SqlConnection con;
    } 
    
}
