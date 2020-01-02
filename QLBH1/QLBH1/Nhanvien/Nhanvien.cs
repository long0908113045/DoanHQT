using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH1.Nhanvien
{
    class Nhanvien
    {
        My_DB mydb = new My_DB();
        public bool themNhanVien(string MaNV, string TenNV, string Gioitinh, DateTime NgaySinh, string DiaChi, string SDT)
        {
            SqlCommand command = new SqlCommand("SPInsertNhanVien", mydb.getConnection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@MaNV", MaNV));
            command.Parameters.Add(new SqlParameter("@TenNV", TenNV));
            command.Parameters.Add(new SqlParameter("@GioiTinh", Gioitinh));
            command.Parameters.Add(new SqlParameter("@NgaySinh", NgaySinh));
            command.Parameters.Add(new SqlParameter("@DiaChi", DiaChi));
            command.Parameters.Add(new SqlParameter("@SDT", SDT));
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
        public DataTable getNhanVien()
        {
            SqlCommand command = new SqlCommand("SPGetAllNhanVien", mydb.getConnection);
            command.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public bool xoaNhanVien(string MaNV)
        {
            SqlCommand command = new SqlCommand("SPDeleteNhanVien", mydb.getConnection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@MaNV", MaNV));
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
        public bool capnhatNhanVien(string MaNV, string TenNV, string Gioitinh, DateTime NgaySinh, string DiaChi, string SDT)
        {
            SqlCommand command = new SqlCommand("SPUpdatetNhanVien", mydb.getConnection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@MaNV", MaNV));
            command.Parameters.Add(new SqlParameter("@TenNV", TenNV));
            command.Parameters.Add(new SqlParameter("@GioiTinh", Gioitinh));
            command.Parameters.Add(new SqlParameter("@NgaySinh", NgaySinh));
            command.Parameters.Add(new SqlParameter("@DiaChi", DiaChi));
            command.Parameters.Add(new SqlParameter("@SDT", SDT));
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
