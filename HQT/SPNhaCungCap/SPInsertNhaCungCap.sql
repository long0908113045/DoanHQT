use QLBH1
go
create or alter procedure SPInsertNhaCungCap
@MaNCC nvarchar(50),
@TenNCC nvarchar(50),
@DiaChi nvarchar(50),
@SDT nvarchar(50),
@Email nvarchar(50),
@Website nvarchar(50)
as
begin
if exists (select * from NhaCungCap where MaNCC= @MaNCC)
THROW 50001, 'Ma Nha Cung Cap Da ton tai!', 1;
if @MaNCC=''or @MaNCC is null
THROW 50001, 'Ma nha cung cap Khong duoc de trong',1;
if @TenNCC=''or @TenNCC is null
THROW 50001, 'Ten nha cung cap Khong duoc de trong',1;
BEGIN TRANSACTION
	BEGIN TRY
	insert NhaCungCap values(@MaNCC,@TenNCC,@DiaChi,@SDT,@Email,@Website)
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

Exec SPInsertNhaCungCap'HN','Công ty H&M Ent','44 Nguy?n Thông, qu?n 3','0772294488','hm@gmail.com','hm.com'

