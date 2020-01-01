IF OBJECT_ID ('trigger_Update_ChiTietHoaDon') IS NOT NULL
DROP TRIGGER trigger_Update_ChiTietHoaDon;
GO
CREATE TRIGGER trigger_Update_ChiTietHoaDon
ON	ChiTietHoaDon
FOR Update
AS
BEGIN
	DECLARE @SoLuong int;
	set @SoLuong =(Select SoLuong from inserted)
	DECLARE @DonGia int;
	SET @DonGia = ( Select DonGia from inserted)
	DECLARE @ThanhTien int ;
	Set @ThanhTien = @SoLuong*@DonGia
	DECLARE @MaHD nvarchar(50) ;
	Set @MaHD = (Select MaHD from inserted)
	DECLARE @MaSP nvarchar(50) ;
	Set @MaSP = (Select MaSP from inserted)
	declare @thanhTienTruoc int;
	Set @thanhTienTruoc = (select ThanhTien from ChiTietHoaDon where MaSP =@MaSP and MaHD = @MaHD)
	Set @ThanhTien = @ThanhTien - @thanhTienTruoc
	Update HoaDon set TongTien = TongTien+@ThanhTien where MaHD = @MaHD		
END
go
exec SPUpdateChiTietHoaDon'HD01','AB01','3','380000'