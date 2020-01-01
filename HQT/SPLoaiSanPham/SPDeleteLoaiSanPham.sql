use QLBH1
go
create or alter procedure SPDeleteLoaiSanPham
@MaLSP nvarchar(50)
as
if exists (select * from SanPham where MaLSP = @MaLSP)
THROW 50001, 'Loai San Pham Con Duoc Su Dung',1;
begin
delete LoaiSanPham where MaLSP = @MaLSP
end
go
exec SPDeleteLoaiSanPham'AB'

