use QLBH1
go
create or alter procedure SPGetAllLoaiSanPham
as
begin
Select * From LoaiSanPham
end
go
exec SPGetAllLoaiSanPham
