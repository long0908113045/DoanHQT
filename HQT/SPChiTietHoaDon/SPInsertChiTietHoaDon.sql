use QLBH1
go
create or alter procedure SPInsertChiTietHoaDon
@MaHD nvarchar(50),
@MaSP nvarchar(50),
@Soluong int,
@Dongia int
as
if exists (select * from ChiTietHoaDon where MaHD = @MaHD and MaSP = @MaSP)
THROW 50001, 'Ma Chi tiet Hoa Don da ton tai',1;
if not exists (select * from HoaDon where MaHD = @MaHD)
Throw 50001, 'Hoa Don Khong ton tai',1;
if not exists (select * from SanPham where MaSP = @MaSP)
Throw 50001, 'San pham Khong ton tai',1;
if @MaHD='' or @MaHD is null
THROW 50001, 'Ma Hoa Don Khong Duoc De Trong',1;
if @MaSP='' or @MaSP is null
THROW 50001, 'Ma San Pham Khong Duoc De Trong',1;
if @Soluong='' or @Soluong is null
THROW 50001, 'So Luong Khong Duoc De Trong',1;
If ISNUMERIC(@Soluong)<0
Throw 50001,'So luong khong duoc am',1;
if @Dongia='' or @Dongia is null
THROW 50001, 'Don Gia Khong Duoc De Trong',1;
if ISNUMERIC(@Dongia)<0
Throw 50001,'Don gia khong duoc am',1;
begin
declare @ThanhTien int;
Set @ThanhTien = @Soluong*@Dongia;	
	insert ChiTietHoaDon values (@MaHD,@MaSP,@Soluong,@Dongia,@ThanhTien)	
end
go

Exec SPInsertChiTietHoaDon 'HD02','AB02','2','380000'

