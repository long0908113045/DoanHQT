use QLBH1
go
create or alter procedure SPGetByNameNhanVien
@TenNV nvarchar(50)
as
begin
Select* From NhanVien  where TenNV like N'' + @TenNV  +'%'
end
go

Exec SPGetByNameNhanVien'Ngu'

