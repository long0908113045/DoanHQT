use QLBH1
go
create or alter procedure SPUpdateKhachHang
@MaKH nvarchar(50),
@TenKH nvarchar(50),
@DiaChi nvarchar(50),
@SDT nvarchar(50)
as
if @MaKH=''or @MaKH is null
THROW 50001, 'Ma Khach Hang Khong duoc de trong',1;
if @TenKH=''or @TenKH is null
THROW 50001, 'Ten Khach Hang Khong duoc de trong',1;
if @DiaChi=''or @DiaChi is null
THROW 50001, 'Dia Chi Khach Hang Khong duoc de trong',1;
if @SDT=''or @SDT is null
THROW 50001, 'So Dien Thoai Khach Hang Khong duoc de trong',1;
begin
update KhachHang set TenKH = @TenKH,DiaChi = @DiaChi,SDT = @SDT where MaKH = @MaKH
end
go

Exec SPUpdateKhachHang'KH05','Nguyễn An Như','11 Lê Đức Thọ, Gò Vấp','0963886666'

