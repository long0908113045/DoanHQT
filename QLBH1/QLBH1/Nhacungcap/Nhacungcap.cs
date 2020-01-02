using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH1.Nhacungcap
{
    class Nhacungcap
    {
        My_DB mydb = new My_DB();
        public bool themNhaCungCap(string MaNCC, string TenNCC, string DiaChi, string SDT, string Email, string Website)
        {
            SqlCommand command = new SqlCommand("SPInsertNhaCungCap", mydb.getConnection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@MaNCC", MaNCC));
            command.Parameters.Add(new SqlParameter("@TenNCC", TenNCC));
            command.Parameters.Add(new SqlParameter("@DiaChi", DiaChi));
            command.Parameters.Add(new SqlParameter("@SDT", SDT));
            command.Parameters.Add(new SqlParameter("@Email", Email));
            command.Parameters.Add(new SqlParameter("@Website", Website));
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
        public DataTable getNhaCungCap()
        {
            SqlCommand command = new SqlCommand("SPGetAllNhaCungCap", mydb.getConnection);
            command.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public bool xoaNhaCungCap(string MaNCC)
        {
            SqlCommand command = new SqlCommand("SPDeleteNhaCungCap", mydb.getConnection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@MaNCC", MaNCC));
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
        public bool capnhatNhaCungCap(string MaNCC, string TenNCC, string DiaChi, string SDT, string Email, string Website)
        {
            SqlCommand command = new SqlCommand("SPUpdateNhaCungCap", mydb.getConnection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@MaNCC", MaNCC));
            command.Parameters.Add(new SqlParameter("@TenNCC", TenNCC));
            command.Parameters.Add(new SqlParameter("@DiaChi", DiaChi));
            command.Parameters.Add(new SqlParameter("@SDT", SDT));
            command.Parameters.Add(new SqlParameter("@Email", Email));
            command.Parameters.Add(new SqlParameter("@Website", Website));
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
