use QLBH1
go
create or alter procedure SPDeleteSanPham
@MaSP nvarchar(50)
as
if exists (select * from ChiTietHoaDon where MaSP = @MaSP)
THROW 50001,'San Pham con su dung chua duoc xoa',1;
begin
Delete SanPham where MaSP = @MaSP
end
go

Exec SPDeleteSanPham 'AB06'

