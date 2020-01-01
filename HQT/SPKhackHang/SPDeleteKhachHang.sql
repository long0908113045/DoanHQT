use QLBH1
go
create or alter procedure SPDeleteKhachHang
@MaKH nvarchar(50)
as
if exists (select * from HoaDon where MaKH = @MaKH)
Throw 50001,'Khach Hang Con Hoa Don',1;
begin
		delete KhachHang  where MaKH = @MaKH	
		
end
go
Exec SPDeleteKhachHang'KH05'
