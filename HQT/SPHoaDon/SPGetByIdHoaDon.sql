use QLBH1
go
create or alter procedure SPGetByIdHoaDon
@MaHD nvarchar(50)
as

begin
	Select * from HoaDon where MaHD = @MaHD
end
go

Exec SPGetByIdHoaDon 'HD08'

