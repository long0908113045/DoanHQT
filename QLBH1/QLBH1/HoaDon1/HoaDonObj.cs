using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH1.HoaDon1
{
    public class HoaDonObj
    {
        private string MaHD;
        private DateTime NgayLap;
        private int TongTien;
        private string TinhTrang;
        private string MaNV;
        private string MaKH;
        public string mahd
        {
            get { return MaHD; }
            set { MaHD = value; }
        }
        public DateTime Ngaylap
        {
            get { return NgayLap; }
            set { NgayLap = value; }
        }
        public int Tongtien
        {
            get { return TongTien; }
            set { TongTien = value; }
        }
        public string Tinhtrang
        {
            get { return TinhTrang; }
            set { TinhTrang = value; }
        }
        public string maNV
        {
            get { return MaNV; }
            set { MaNV = value; }
        }
        public string maKH
        {
            get { return MaKH; }
            set { MaKH = value; }
        }
        public HoaDonObj() { }
        public HoaDonObj(string MaHD, DateTime NgayLap, int TongTien, string TinhTrang, string MaNV, string MaKH)
        {
            this.mahd = mahd;
            this.NgayLap = NgayLap;
            this.TongTien = TongTien;
            this.TinhTrang = TinhTrang;
            this.MaNV = MaNV;
            this.MaKH = MaKH;
        }
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
        public DataTable getHoaDon()
        {
            SqlCommand command = new SqlCommand("SPGetAllHoaDon", mydb.getConnection);
            command.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public bool xoaHoaDon(string MaHD)
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
    }
}
