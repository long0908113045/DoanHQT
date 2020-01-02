use QLBH1
go
create or alter procedure SPGetByNameKhachHang
@TenKH nvarchar(50)
as
begin
Select* From KhachHang  where TenKH like N'' + @TenKH  +'%'
end
go
Exec SPGetByNameKhachHang'Ng'
