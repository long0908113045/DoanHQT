using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH1.Khachhang
{
    class Khachhang
    {
        My_DB mydb = new My_DB();
        public bool themKhachHang(string MaKH, string TenKH, string DiaChi, string SDT)
        {
            SqlCommand command = new SqlCommand("SPInsertKhachHang", mydb.getConnection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@MaKH", MaKH));
            command.Parameters.Add(new SqlParameter("@tenkh",TenKH));            
            command.Parameters.Add(new SqlParameter("@diachi",DiaChi));
            command.Parameters.Add(new SqlParameter ("@sdt",SDT));
            mydb.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }
        public DataTable getKhachHang()
        {
            SqlCommand command = new SqlCommand("SPGetAllKhachHang", mydb.getConnection);
            command.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public bool xoaKhachHang(string MaKH)
        {
            SqlCommand command = new SqlCommand("SPDeleteKhachHang", mydb.getConnection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@MaKH", MaKH));
            mydb.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }
        public bool capnhatKhachHang(string MaKH, string TenKH, string DiaChi, string SDT)
        {
            SqlCommand command = new SqlCommand("SPUpdateKhachHang", mydb.getConnection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@MaKH", MaKH));
            command.Parameters.Add(new SqlParameter("@tenkh", TenKH));
            command.Parameters.Add(new SqlParameter("@diachi", DiaChi));
            command.Parameters.Add(new SqlParameter("@sdt", SDT));
            mydb.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }
    }
}
