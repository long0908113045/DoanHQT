use QLBH1
go
create or alter procedure SPDeleteNhanVien
@MaNV nvarchar(50)
as
If exists (select * from HoaDon where MaNV = @MaNV)
THROW 50001,'Nhan vien Con Hoa Don',1;
begin
Delete NhanVien where MaNV = @MaNV
end
go

Exec SPDeleteNhanVien'NV07'

