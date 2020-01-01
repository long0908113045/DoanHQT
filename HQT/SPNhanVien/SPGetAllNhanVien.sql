use QLBH1
go
create or alter procedure SPGetAllNhanVien
as
begin
Select * from NhanVien
end
go

Exec SPGetAllNhanVien

