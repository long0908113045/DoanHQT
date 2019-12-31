use QLBH1
go
create or alter procedure SPGetByIdNhanVien
@MaNv nvarchar(50)
as
begin
Select * from NhanVien where MaNV = @MaNv
end
go

Exec SPGetByIdNhanVien'NV06'

