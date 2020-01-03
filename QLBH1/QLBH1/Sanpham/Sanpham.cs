using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH1.Sanpham
{
    class Sanpham
    {
        My_DB mydb = new My_DB();
        Loaisanpham loaisanpham = new Loaisanpham();
        QLBH1.Nhacungcap.Nhacungcap nhacungcap = new QLBH1.Nhacungcap.Nhacungcap();
        public bool themSanPham(string MaSP, string TenSP, string DVTinh, int DonGia, int SoLuong, string MaLSP, string MaNCC)
        {
            SqlCommand command = new SqlCommand("SPInsertSanPham", mydb.getConnection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@MaSP", MaSP));
            command.Parameters.Add(new SqlParameter("@TenSP", TenSP));
            command.Parameters.Add(new SqlParameter("@DVTinh", DVTinh));
            command.Parameters.Add(new SqlParameter("@DonGia", DonGia));
            command.Parameters.Add(new SqlParameter("@SoLuong", SoLuong));
            command.Parameters.Add(new SqlParameter("@MaLSP", MaLSP));
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
        public DataTable getSanPham()
        {
            SqlCommand command = new SqlCommand("SPGetAllSanPham", mydb.getConnection);
            command.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable getByIdSanPham(string MaSP)
        {
            SqlCommand command = new SqlCommand("SPGetByIdSanPham", mydb.getConnection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@MaSP", MaSP));
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public bool xoaSanPham(string MaSP)
        {
            SqlCommand command = new SqlCommand("SPDeleteSanPham", mydb.getConnection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@MaSP", MaSP));
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
        public bool capnhatSanPham(string MaSP, string TenSP, string DVTinh, int DonGia, int SoLuong, string MaLSP, string MaNCC)
        {
            SqlCommand command = new SqlCommand("SPUpdateSanPham", mydb.getConnection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@MaSP", MaSP));
            command.Parameters.Add(new SqlParameter("@TenSP", TenSP));
            command.Parameters.Add(new SqlParameter("@DVTinh", DVTinh));
            command.Parameters.Add(new SqlParameter("@DonGia", DonGia));
            command.Parameters.Add(new SqlParameter("@SoLuong", SoLuong));
            command.Parameters.Add(new SqlParameter("@MaLSP", MaLSP));
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
    }
}
