use QLBH1
go
create or alter procedure SPUpdateHoaDon
@MaHD nvarchar(50),
@NgayLap datetime,
@TongTien int,
@TinhTrang nvarchar(50),
@MaNV nvarchar(50),
@MaKH nvarchar(50)

as
if @MaHD='' or @MaHD is null
THROW 50001, 'Ma Hoa Don Khong Duoc De Trong',1;
if @NgayLap='' or @NgayLap is null or @NgayLap>GETDATE()
THROW 50001, 'Ngay Lap Hoa Don Khong Duoc De Trong Hoac lon hon ngay hien tai',1;
if @TinhTrang='' or @TinhTrang is null
THROW 50001, 'Tinh Trang Hoa Don Khong Duoc De Trong',1;
if @MaNV='' or @MaNV is null
THROW 50001, 'Ma Nhan Vien Khong Duoc De Trong',1;
If not exists (select * from NhanVien where MaNV = @MaNV)
THROW 50001,'Nhan vien Khong ton tai',1;
if @MaKH='' or @MaKH is null
THROW 50001, 'Ma Khach Hang Khong Duoc De Trong',1;
If not exists (select * from KhachHang where MaKH = @MaKH)
THROW 50001,'Khach Hang Khong ton tai',1;
begin
	if @TongTien='' or @TongTien is null
		begin
			set @tongtien = 0;
		end
	Update HoaDon set NgayLap = @NgayLap,TongTien = @TongTien,TinhTrang = @TinhTrang,MaNV = @MaNV,MaKH = @MaKH where MaHD = @MaHD
end
go

Exec SPUpdateHoaDon 'HD10','2019/1/1','1000','Hoàn tất','NV01','KH02'

