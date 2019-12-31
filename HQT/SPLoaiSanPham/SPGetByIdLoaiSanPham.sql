use QLBH1
go
create or alter procedure SPGetByIdLoaiSanPham
@MaLSP nvarchar(50)
as
if @MaLSP = '' or @MaLSP is null
THROW 50001, 'Ma Loai San Pham Khong duoc de trong',1;
begin
Select * From LoaiSanPham where MaLSP = @MaLSP
end
go
exec SPGetByIdLoaiSanPham'AB'
