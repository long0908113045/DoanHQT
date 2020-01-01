use QLBH1
go
create or alter procedure SPGetByIdKhachHang
@MaKH nvarchar(50)
as
if @MaKH=''or @MaKH is null
THROW 50001, 'Ma Khach Hang Khong duoc de trong',1;
begin
Select* From KhachHang  where MaKH = @MaKH
end
go
Exec SPGetByIdKhachHang'KH04'
