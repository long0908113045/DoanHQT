use QLBH1
go
create or alter procedure SPGetAllKhachHang
as
begin
Select* From KhachHang  
end
go
Exec SPGetAllKhachHang
