using System.Data.SqlClient;

namespace QUANLYBANHANG
{
    public class connectBase
    {
        public void Command(Hanghoas hanghoas, string qurey)
        {
            connect.Open();
            SqlCommand = new SqlCommand(qurey, connect.sqlcon);
            SqlCommand.Parameters.Add("@MaHang", hanghoas.Mahang);
            SqlCommand.Parameters.Add("@TenHang", hanghoas.Tenhang);
            SqlCommand.Parameters.Add("@Maloai", hanghoas.Maloai);
            SqlCommand.Parameters.Add("@MaNCC", hanghoas.Mancc);
            SqlCommand.Parameters.Add("@Soluong", hanghoas.Soluong);
            SqlCommand.Parameters.Add("@Dongianhap", hanghoas.Dongia);
            SqlCommand.Parameters.Add("@Dongiaban", hanghoas.Dongiaban);
            SqlCommand.Parameters.Add("@Hinhanh", hanghoas.Anh);
            SqlCommand.ExecuteNonQuery();


        }
    }
}