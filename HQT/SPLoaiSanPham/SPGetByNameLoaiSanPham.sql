use QLBH1
go
create or alter procedure SPGetByNameLoaiSanPham
@TenLSP nvarchar(50)
as
begin
Select* From LoaiSanPham  where TenLSP like N'' + @TenLSP  +'%'
end
go
exec SPGetByNameLoaiSanPham'A'
