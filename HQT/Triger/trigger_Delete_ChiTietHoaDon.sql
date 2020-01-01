IF OBJECT_ID ('trigger_Delete_ChiTietHoaDon') IS NOT NULL
DROP TRIGGER trigger_Delete_ChiTietHoaDon;
GO
CREATE TRIGGER trigger_Delete_ChiTietHoaDon
ON	ChiTietHoaDon
FOR Delete
AS
BEGIN
	Declare @MaHD nvarchar(50);
	Set @MaHD = (Select MaHD from deleted)
	DECLARE @ThanhTien int ;	
	Set @ThanhTien = (Select Thanhtien from deleted) 
	Update HoaDon set TongTien = TongTien-@ThanhTien where MaHD = @MaHD		
END
go
exec SPDeleteChiTietHoaDon 'HD01','AB01'