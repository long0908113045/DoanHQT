use QLBH1
go
create or alter procedure SPGetAllSanPham
as
begin
	select * from SanPham
end
go

Exec SPGetAllSanPham 

