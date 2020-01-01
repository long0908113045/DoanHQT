use QLBH1
go
create or alter procedure SPGetByIdSanPham
@MaSP nvarchar(50)
as
begin
	select * from SanPham where MaSP = @MaSP
end
go

Exec SPdeleteSanPham 'AB05'

