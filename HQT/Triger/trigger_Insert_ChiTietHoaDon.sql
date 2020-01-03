USE [QLBH1]
GO
/****** Object:  Trigger [dbo].[trigger_Insert_ChiTietHoaDon]    Script Date: 1/3/2020 6:05:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
alter TRIGGER [dbo].[trigger_Insert_ChiTietHoaDon]
ON	[dbo].[ChiTietHoaDon]
FOR insert
AS
--Update viện phí cho từng bệnh nhân có chi tiết toa thuốc tương ứng
BEGIN
	begin transaction
	DECLARE @MaSp Nvarchar(50);
	set @MaSp =(Select MaSP from inserted)
	DECLARE @SoLuong int;
	set @SoLuong =(Select SoLuong from inserted)
	DECLARE @DonGia int;
	SET @DonGia = ( Select DonGia from inserted)
	DECLARE @ThanhGia int ;
	Set @ThanhGia = @SoLuong*@DonGia
	DECLARE @MaHD nvarchar(50) ;
	Set @MaHD = (Select MaHD from inserted)
	Update HoaDon set TongTien = TongTien+@ThanhGia where MaHD = @MaHD	
	Update SanPham set SoLuong = SoLuong-@SoLuong where MaSP = @MaSp
	if exists (select * from SanPham where MaSP = @MaSp and SoLuong<0)
	begin
	rollback transaction;
	THROW 50001,' hang trong kho khong du so luong ',1;
	end
	commit	
END

exec SPInsertChiTietHoaDon 'HD01','LS01',10,380000