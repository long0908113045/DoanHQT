using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH1.Hoadon
{
    class Hoadon
    {
        My_DB mydb = new My_DB();
        public bool themHoaDon(string MaHD, DateTime NgayLap, int TongTien, string TinhTrang, string MaNV, string MaKH)
        {
            SqlCommand command = new SqlCommand("SPInsertHoaDon", mydb.getConnection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@MaHD", MaHD));
            command.Parameters.Add(new SqlParameter("@NgayLap", NgayLap));
            command.Parameters.Add(new SqlParameter("@TongTien", TongTien));
            command.Parameters.Add(new SqlParameter("@TinhTrang", TinhTrang));
            command.Parameters.Add(new SqlParameter("@MaNV", MaNV));
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
        public bool capnhatHoaDon(string MaHD, DateTime NgayLap, int TongTien, string TinhTrang, string MaNV, string MaKH)
        {
            SqlCommand command = new SqlCommand("SPUpdateHoaDon", mydb.getConnection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@MaHD", MaHD));
            command.Parameters.Add(new SqlParameter("@NgayLap", NgayLap));
            command.Parameters.Add(new SqlParameter("@TongTien", TongTien));
            command.Parameters.Add(new SqlParameter("@TinhTrang", TinhTrang));
            command.Parameters.Add(new SqlParameter("@MaNV", MaNV));
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
        public bool HuyHoaDon(string MaHD)
        {
            SqlCommand command = new SqlCommand("SPDeleteHoaDon", mydb.getConnection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@MaHD", MaHD));            
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
            public DataTable getHoaDon()
        {
            SqlCommand command = new SqlCommand("SPGetAllHoaDon", mydb.getConnection);
            command.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

    }
}
