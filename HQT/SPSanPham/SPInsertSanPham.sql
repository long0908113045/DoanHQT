use QLBH1
go
create or alter procedure SPInsertSanPham
@MaSP nvarchar(50),
@TenSP nvarchar(50),
@DVTinh nvarchar(50),
@DonGia int,
@SoLuong int,
@MaLSP nvarchar(50),
@MaNCC nvarchar(50)
as
if exists (select * from SanPham where MaSP = @MaSP)
THROW 50001, 'Ma San Pham da ton tai',1;
if @MaSP=''or @MaSP is null
THROW 50001, 'Ma San Pham Khong duoc de trong',1;
if @TenSP=''or @TenSP is null
THROW 50001, 'Ten San Pham Khong duoc de trong',1;
if @DVTinh=''or @DVTinh is null
THROW 50001, 'DV Tinh San Pham Khong duoc de trong',1;
if @SoLuong=''or @SoLuong is null
THROW 50001, 'So Luong San Pham Khong duoc de trong',1;
if ISNUMERIC(@SoLuong)<0
THROW 50001, 'So Luong San Pham khong duoc am Khong duoc de trong',1;
if @MaLSP=''or @MaLSP is null 
THROW 50001, 'Ma Loai San Pham Khong duoc de trong',1;
if not exists (select * from LoaiSanPham where MaLSP = @MaLSP)
THROW 50001, 'Loai san pham khong ton tai',1;
if @MaNCC=''or @MaNCC is null 
THROW 50001, 'Ma Nha Cung Cap San Pham Khong duoc de trong',1;
if not exists (select * from NhaCungCap where MaNCC = @MaNCC)
THROW 50001, 'Nha cung cap khong ton tai',1;
begin
	insert SanPham values (@MaSP,@TenSP,@DVTinh,@DonGia,@SoLuong,@MaLSP,@MaNCC)	
end
go

Exec SPInsertSanPham 'AB06','Album','cái','380000','10','AB','HM'

