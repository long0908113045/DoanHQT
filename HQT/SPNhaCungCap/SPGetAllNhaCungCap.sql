use QLBH1
go
create or alter procedure SPGetAllNhaCungCap
as
begin
Select * from NhaCungCap
end
go

Exec SPGetAllNhaCungCap

