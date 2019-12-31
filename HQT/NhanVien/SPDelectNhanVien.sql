use QLBH1
go
create or alter procedure SPDeleteNhanVien
@MaNv nvarchar(50)
as
if @MaNv=''or @MaNv is null
THROW 50001, 'Ma Nhan Vien Khong duoc de trong',1;
begin
Delete NhanVien where MaNV = @MaNv
end
go

Exec SPDeleteNhanVien'NV07'

