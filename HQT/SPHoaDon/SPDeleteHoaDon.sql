use QLBH1
go
create or alter procedure SPdeleteHoaDon
@MaHD nvarchar(50)
as
if exists (select * from ChiTietHoaDon where MaHD = @MaHD)
THROW 50001,'Hoa Don Con Su dung Khong the Xoa',1;
begin
	Delete HoaDon where MaHD =@MaHD
end
go

Exec SPdeleteHoaDon 'HD10'

