using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH1.Sanpham
{
    class Loaisanpham
    {
        My_DB mydb = new My_DB();
        public bool themLoaiSanPham(string MaLSP, string TenLSP)
        {
            SqlCommand command = new SqlCommand("SPInsertLoaiSanPham", mydb.getConnection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@MaLSP", MaLSP));
            command.Parameters.Add(new SqlParameter("@TenLSP", TenLSP));          

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
        public DataTable getLoaiSanPham()
        {
            SqlCommand command = new SqlCommand("SPGetAllLoaiSanPham", mydb.getConnection);
            command.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public bool xoaLoaiSanPham(string MaLSP)
        {
            SqlCommand command = new SqlCommand("SPDeleteLoaiSanPham", mydb.getConnection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@MaLSP", MaLSP));
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
        public bool capnhatLoaiSanPham(string MaLSP, string TenLSP)
        {
            SqlCommand command = new SqlCommand("SPUpdateLoaiSanPham", mydb.getConnection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@MaLSP", MaLSP));
            command.Parameters.Add(new SqlParameter("@TenLSP", TenLSP));

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
