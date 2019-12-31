use QLBH1
go
create or alter procedure SPInsertLoaiSanPham
@MaLSP nvarchar(50),
@TenLSP nvarchar(50)
as
if exists (select * from LoaiSanPham where MaLSP=@MaLSP)
THROW 50001, 'Ma Loai San Pham Da ton tai!', 1;
if @MaLSP=''or @MaLSP is null
THROW 50001, 'Ma Loai San Pham Khong duoc de trong',1;
if @TenLSP=''or @TenLSP is null
THROW 50001, 'Ten Loai San Pham Khong duoc de trong',1;
begin
insert LoaiSanPham values(@MaLSP,@TenLSP)
end
go

