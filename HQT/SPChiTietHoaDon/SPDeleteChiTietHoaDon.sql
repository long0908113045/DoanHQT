use QLBH1
go
create or alter procedure SPDeleteChiTietHoaDon
@MaHD nvarchar(50),
@MaSP nvarchar(50)
as
begin
	Delete ChiTietHoaDon where MaHD = @MaHD and MaSP = @MaSP	
end
go

Exec SPDeleteChiTietHoaDon 'HD02','AB01'

