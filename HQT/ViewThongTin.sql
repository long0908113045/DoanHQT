use QLBH1
go
create view View_thongtinkhachmuahang
as
select Kh.TenKH,kh.SDT,KH.DiaChi,HD.MaHD,HD.NgayLap,HD.TinhTrang,HD.TongTien,CT.MaSP,CT.SoLuong,CT.DonGia,CT.ThanhTien from KhachHang KH LEFT JOIN HoaDon HD on KH.MaKH = hd.MaKH
join  ChiTietHoaDon CT on HD.MaHD = CT.MaHD
go
select * from View_thongtinkhachmuahang