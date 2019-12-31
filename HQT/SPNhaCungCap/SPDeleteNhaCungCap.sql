use QLBH1
go
create or alter procedure SPGetByIdNhaCungCap
@MaNCC nvarchar(50)
as
if @MaNCC=''or @MaNCC is null
THROW 50001, 'Ma nha cung cap Khong duoc de trong',1;
begin
delete NhaCungCap where MaNCC = @MaNCC
end
go

Exec SPDeleteNhaCungCap'HN'

