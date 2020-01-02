use QLBH1
go
create or alter procedure SPGetByNameSanPham
@TenSP nvarchar(50)
as
begin
Select* From SanPham  where TenSP like N'' + @TenSP  +'%'
end
go

Exec SPGetByNameSanPham 'A'

