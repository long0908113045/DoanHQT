use QLBH1
go
create or alter procedure SPGetAllHoaDon
as
begin
	Select * from HoaDon 
end
go

Exec SPGetAllHoaDon

