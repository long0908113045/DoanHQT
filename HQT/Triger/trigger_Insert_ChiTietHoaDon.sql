IF OBJECT_ID ('trigger_Insert_ChiTietHoaDon') IS NOT NULL
DROP TRIGGER trigger_Insert_ChiTietHoaDon;
GO
CREATE TRIGGER trigger_Insert_ChiTietHoaDon
ON	ChiTietHoaDon
FOR insert
AS
--Update viện phí cho từng bệnh nhân có chi tiết toa thuốc tương ứng
BEGIN
	DECLARE @SoLuong int;
	set @SoLuong =(Select SoLuong from inserted)
	DECLARE @DonGia int;
	SET @DonGia = ( Select DonGia from inserted)
	DECLARE @ThanhGia int ;
	Set @ThanhGia = @SoLuong*@DonGia
	DECLARE @MaHD nvarchar(50) ;
	Set @MaHD = (Select MaHD from inserted)
	Update HoaDon set TongTien = TongTien+@ThanhGia where MaHD = @MaHD		
END
exec SPInsertChiTietHoaDon'HD01','AB02','2','380000'