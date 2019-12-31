use QLBH1
go
create or alter procedure SPUpdateLoaiSanPham
@MaLSP nvarchar(50),
@TenLSP nvarchar(50)
as
if @MaLSP=''or @MaLSP is null
THROW 50001, 'Ma Loai San Pham Khong duoc de trong',1;
if @TenLSP=''or @TenLSP is null
THROW 50001, 'Ten Loai San Pham Khong duoc de trong',1;
begin
update LoaiSanPham set TenLSP = @TenLSP where MaLSP = @MaLSP
end
go
exec SPUpdateLoaiSanPham'AB','ABum'

