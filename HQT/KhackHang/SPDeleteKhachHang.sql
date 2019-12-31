use QLBH1
go
create or alter procedure SPDeleteKhachHang
@MaKH nvarchar(50)
as
if @MaKH=''or @MaKH is null
THROW 50001, 'Ma Khach Hang Khong duoc de trong',1;
begin
delete KhachHang  where MaKH = @MaKH
end
go

Exec SPDeleteKhachHang'KH05'
