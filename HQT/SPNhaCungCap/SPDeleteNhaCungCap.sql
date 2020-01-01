use QLBH1
go
create or alter procedure SPDeleteNhaCungCap
@MaNCC nvarchar(50)
as
If exists (select * from SanPham where MaNCC = @MaNCC)
THROW 50001,'Nhan vien Con Hoa Don',1;
begin
delete NhaCungCap where MaNCC = @MaNCC
end
go

Exec SPDeleteNhaCungCap null

