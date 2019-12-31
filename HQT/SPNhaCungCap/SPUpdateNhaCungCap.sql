use QLBH1
go
create or alter procedure SPUpdateNhaCungCap
@MaNCC nvarchar(50),
@TenNCC nvarchar(50),
@DiaChi nvarchar(50),
@SDT nvarchar(50),
@Email nvarchar(50),
@Website nvarchar(50)
as
if @MaNCC=''or @MaNCC is null
THROW 50001, 'Ma nha cung cap Khong duoc de trong',1;
if @TenNCC=''or @TenNCC is null
THROW 50001, 'Ten nha cung cap Khong duoc de trong',1;
begin
update NhaCungCap set TenNCC = @TenNCC,DiaChi = @DiaChi,SDT = @SDT,Email = @Email,Website = @Website where MaNCC = @MaNCC
end
go

Exec SPUpdateNhaCungCap 'HN','Công ty H&M Ent','44 Nguyễn Thông, quận 3','0772294488','hm@gmail.com','hm.com'

