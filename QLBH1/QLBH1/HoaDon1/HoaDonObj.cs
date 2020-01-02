using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH1.HoaDon1
{
    class HoaDonObj
    {
        string mahd, tinhtrang, manv, makh;
        DateTime ngaylap;
        int tongtien;
        public string MaHD
        {
            get { return mahd; }
            set { mahd = value; }
        }
        public DateTime NgayLap
        {
            get { return ngaylap; }
            set { ngaylap = value; }
        }
        public int TongTien
        {
            get { return tongtien; }
            set { tongtien = value; }
        }
        public string TinhTrang
        {
            get { return tinhtrang; }
            set { tinhtrang = value; }
        }
        public string MaNV
        {
            get { return manv; }
            set { manv = value; }
        }
        public string MaKH
        {
            get { return makh; }
            set { makh = value; }
        }
        public HoaDonObj() {}
        public HoaDonObj(string mahd, DateTime ngaylap, int tongtien, string tinhtrang, string manv, string makh)
        {
            this.mahd = mahd;
            this.ngaylap = ngaylap;
            this.tongtien = tongtien;
            this.tinhtrang = tinhtrang;
            this.manv = manv;
            this.makh = makh;
        }
    }
}
