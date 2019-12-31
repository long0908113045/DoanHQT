use QLBH1
go
create or alter procedure SPUpdatetNhanVien
@MaNv nvarchar(50),
@TenNV nvarchar(50),
@GioiTinh nvarchar(50),
@NgaySinh datetime,
@DiaChi nvarchar(50),
@SDT nvarchar(50)
as
if @MaNv=''or @MaNv is null
THROW 50001, 'Ma Nhan Vien Khong duoc de trong',1;
if @TenNV=''or @TenNV is null
THROW 50001, 'Ten Nhan Vien Khong duoc de trong',1;
if @GioiTinh=''or @GioiTinh is null
THROW 50001, 'Gioi Tinh cap Khong duoc de trong',1;
IF @NgaySinh IS NULL OR @NgaySinh >= GETDATE()
THROW 50001,'Ngày Sinh Không Được Lớn Hơn Ngày Hiện Tại!',1; 
if @DiaChi=''or @DiaChi is null
THROW 50001, 'Dia Chi Nhan Vien Khong duoc de trong',1;
if @SDT=''or @SDT is null
THROW 50001, 'So Dien Thoai Nhan Vien Khong duoc de trong',1;
begin
update NhanVien set TenNV = @TenNV,GioiTinh = @GioiTinh,NgaySinh = @NgaySinh,DiaChi = @DiaChi,SDT = @SDT where MaNV = @MaNv
end
go

Exec SPUpdatetNhanVien 'NV07','Hoàng Thủy Tiên','Nữ','1997-01-17 00:00:00.000','312 Phan Văn Trị,quận Gò Vấp, HCM','0932569999'

