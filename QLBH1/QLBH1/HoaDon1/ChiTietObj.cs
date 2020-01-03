using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH1.HoaDon1
{
    class ChiTietObj
    {

        private string MaHD;
        private string MaSP;
        private int SoLuong;
        private int DonGia;
        private int ThanhTien;
        public string mahd
        {
            get { return MaHD; }
            set { MaHD = value; }
        }
        public string masp
        {
            get { return MaSP; }
            set { MaSP = value; }
        }
        public int soluong
        {
            get { return SoLuong; }
            set { SoLuong = value; }
        }
        public int thanhtien
        {
            get { return ThanhTien; }
            set { ThanhTien = value; }
        }
        public ChiTietObj() { }
        public ChiTietObj(string MaHD,string MaSP) {
            this.MaHD = MaHD;
            this.MaSP = MaSP;
        }
        public ChiTietObj(string MaHD)
        {
            this.MaHD = MaHD;        
        }
        public ChiTietObj(string MaHD, string MaSP, int SoLuong, int DonGia, int ThanhTien)
        {
            this.MaHD = MaHD;
            this.MaSP = MaSP;
            this.SoLuong = SoLuong;
            this.DonGia = DonGia;
            this.ThanhTien = ThanhTien;
        }
        My_DB mydb = new My_DB();
        public bool themChiTietHoaDon()
        {

            SqlCommand command = new SqlCommand("SPInsertChiTietHoaDon", mydb.getConnection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@MaHD", MaHD));
            command.Parameters.Add(new SqlParameter("@MaSP", MaSP));
            command.Parameters.Add(new SqlParameter("@SoLuong", SoLuong));
            command.Parameters.Add(new SqlParameter("@DonGia", DonGia));
            //command.Parameters.Add(new SqlParameter("@ThanhTien", ThanhTien));
            mydb.openConnection();
            if ((command.ExecuteNonQuery() >= 1))
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
        public DataTable getChiTietHoaDon()
        {
            SqlCommand command = new SqlCommand("SPGetByMaHDChiTietHoaDon", mydb.getConnection);
            command.Parameters.Add(new SqlParameter("@MaHD", MaHD));
            command.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public bool xoaChiTietHoaDon()
        {
            SqlCommand command = new SqlCommand("SPDeleteChiTietHoaDon", mydb.getConnection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@MaHD", MaHD));
            command.Parameters.Add(new SqlParameter("@MaSP", MaSP));
            mydb.openConnection();
            if ((command.ExecuteNonQuery() >= 1))
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
        public bool capnhatChiTietHoaDon()
        {
            SqlCommand command = new SqlCommand("SPUpdateChiTietHoaDon", mydb.getConnection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@MaHD", MaHD));           
            command.Parameters.Add(new SqlParameter("@MaSP", MaSP));
            command.Parameters.Add(new SqlParameter("@SoLuong", SoLuong));
            command.Parameters.Add(new SqlParameter("@DonGia", DonGia));
            command.Parameters.Add(new SqlParameter("@ThanhTien", ThanhTien));
            mydb.openConnection();
            if ((command.ExecuteNonQuery() >= 1))
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
