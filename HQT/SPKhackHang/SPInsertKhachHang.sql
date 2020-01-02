use QLBH1
go
create or alter procedure SPInsertKhachHang
@MaKH nvarchar(50),
@TenKH nvarchar(50),
@DiaChi nvarchar(50),
@SDT nvarchar(50)
as
BEGIN
	if exists (select * from KhachHang where MaKH= @MaKH)
	THROW 50001, 'Ma Khach Hang Da ton tai!', 1;
	if @MaKH=''or @MaKH is null
	THROW 50001, 'Ma Khach Hang Khong duoc de trong',1;
	if @TenKH=''or @TenKH is null
	THROW 50001, 'Ten Khach Hang Khong duoc de trong',1;
	if @DiaChi=''or @DiaChi is null
	THROW 50001, 'Dia Chi Khach Hang Khong duoc de trong',1;
	if @SDT=''or @SDT is null
	THROW 50001, 'So Dien Thoai Khach Hang Khong duoc de trong',1;
BEGIN TRANSACTION
	BEGIN TRY
		insert KhachHang values(@MaKH,@TenKH,@DiaChi,@SDT)
		commit
	end try
	BEGIN CATCH
		ROLLBACK TRANSACTION
		DECLARE @ErrorMessage NVARCHAR(2000)
		SELECT @ErrorMessage = 'Error: ' + ERROR_MESSAGE()
		RAISERROR(@ErrorMessage, 16, 1)
	END CATCH
end
go

Exec SPInsertKhachHang'KH05','Nguyễn An Như','11 Lê Đức Thọ, Gò Vấp','0963886666'

