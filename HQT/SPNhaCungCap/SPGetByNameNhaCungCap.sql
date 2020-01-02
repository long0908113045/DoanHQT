use QLBH1
go
create or alter procedure SPGetByNameNhaCungCap
@TenNCC nvarchar(50)
as
begin
Select* From NhaCungCap  where TenNCC like N'' + @TenNCC  +'%'
end
go

Exec SPGetByNameNhaCungCap 'Công ty H&M Ent'

