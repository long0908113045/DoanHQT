using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using QLBH1.HoaDon1;

namespace QLBH1.HoaDon1
{
    class HoaDonMod
    {
        My_DB mydb = new My_DB();
        SqlCommand cmd = new SqlCommand();


        public DataTable GetData()
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "Select * from HoaDon";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = mydb.getConnection;

            try
            {
                mydb.openConnection();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                mydb.closeConnection();
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                mydb.closeConnection();
            }

                return dt;
        }
        public bool AddData(HoaDonObj hdobj)
        {
            cmd.CommandText = "Insert into HoaDon values ('"+hdobj.MaHD+"',CONVERT(DATE,'" + hdobj.NgayLap.ToShortDateString()+"',103),'" + hdobj.TongTien+ "','" + hdobj.TinhTrang+ "','" + hdobj.MaNV+ "','" + hdobj.MaKH+"')";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = mydb.getConnection;

            try
            {
                mydb.openConnection();
                cmd.ExecuteNonQuery();
                mydb.closeConnection();
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                mydb.closeConnection();
            }
            return false;
        }
        public bool UpdateData(HoaDonObj hdobj)
        {
            cmd.CommandText = "Update HoaDon set NgayLap = CONVERT(DATE,'" + hdobj.NgayLap.ToShortDateString() + "',103),TongTien = '" + hdobj.TongTien + "',TinhTrang = '" + hdobj.TinhTrang + "',MaNV ='" + hdobj.MaNV + "',MaKH = '" + hdobj.MaKH + "')";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = mydb.getConnection;

            try
            {
                mydb.openConnection();
                cmd.ExecuteNonQuery();
                mydb.closeConnection();
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                mydb.closeConnection();
            }
            return false;
        }
        //public bool DeleteData(HoaDonObj hdobj) //https://www.youtube.com/watch?v=vQAktMh958I
    }
}
