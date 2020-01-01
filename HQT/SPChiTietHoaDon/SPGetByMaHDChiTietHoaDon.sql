use QLBH1
go
create or alter procedure SPGetByMaHDChiTietHoaDon
@MaHD nvarchar(50)
as
begin
	select * from ChiTietHoaDon where MaHD = @MaHD 
end
go

Exec SPGetByMaHDChiTietHoaDon 'HD02'

