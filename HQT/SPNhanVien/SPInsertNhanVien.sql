use QLBH1
go
create or alter procedure SPInsertNhanVien
@MaNv nvarchar(50),
@TenNV nvarchar(50),
@GioiTinh nvarchar(50),
@NgaySinh datetime,
@DiaChi nvarchar(50),
@SDT nvarchar(50)
as
if exists (select * from NhanVien where MaNV= @MaNv)
THROW 50001, 'Ma Nhan Vien Da ton tai!', 1;
if @MaNV=''or @MaNv is null
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
insert NhanVien values(@MaNv,@TenNV,@GioiTinh,@NgaySinh,@DiaChi,@SDT)
end
go

Exec SPInsertNhanVien'NV08','Hoàng Thủy Tiên','Nữ','2020-01-17 00:00:00.000','312 Phan Văn Trị,quận Gò Vấp, HCM','0932569999'

