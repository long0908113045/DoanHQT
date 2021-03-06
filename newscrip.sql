USE [QLBH1]
GO
/****** Object:  User [use4]    Script Date: 1/4/2020 1:47:58 AM ******/
CREATE USER [use4] FOR LOGIN [use4] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  UserDefinedFunction [dbo].[TinhTien]    Script Date: 1/4/2020 1:47:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   FUNCTION [dbo].[TinhTien] (@TENTHUOC nvarchar(50))
	RETURNS int
	as
BEGIN

RETURN (SELECT COUNT(*) )		
END;
--Test
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 1/4/2020 1:47:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNV] [nvarchar](50) NOT NULL,
	[TenNV] [nvarchar](50) NOT NULL,
	[GioiTinh] [nvarchar](50) NULL,
	[NgaySinh] [datetime] NULL,
	[DiaChi] [nvarchar](50) NULL,
	[SDT] [nvarchar](50) NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[view_ThongTinNhanVienNam]    Script Date: 1/4/2020 1:47:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[view_ThongTinNhanVienNam] AS

SELECT	MaNV as 'ma nhan vien',TenNV as 'ten nhan vien',GioiTinh as 'gioi tinh',NgaySinh as 'ngay sinh',DiaChi as 'Dia chi',SDT as 'so dien thoai'
FROM NhanVien where GioiTinh = 'Nam'
	
GO
/****** Object:  View [dbo].[view_ThongTinNhanVienNu]    Script Date: 1/4/2020 1:47:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[view_ThongTinNhanVienNu] AS

SELECT	MaNV as 'ma nhan vien',TenNV as 'ten nhan vien',GioiTinh as 'gioi tinh',NgaySinh as 'ngay sinh',DiaChi as 'Dia chi',SDT as 'so dien thoai'
FROM NhanVien where GioiTinh != 'Nam'
	
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 1/4/2020 1:47:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKH] [nvarchar](50) NOT NULL,
	[TenKH] [nvarchar](50) NOT NULL,
	[DiaChi] [nvarchar](50) NULL,
	[SDT] [nvarchar](50) NULL,
 CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChiTietHoaDon]    Script Date: 1/4/2020 1:47:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietHoaDon](
	[MaHD] [nvarchar](50) NOT NULL,
	[MaSP] [nvarchar](50) NOT NULL,
	[SoLuong] [int] NULL,
	[DonGia] [int] NULL,
	[ThanhTien] [int] NULL,
 CONSTRAINT [PK_ChiTietHoaDon] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC,
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 1/4/2020 1:47:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[MaHD] [nvarchar](50) NOT NULL,
	[NgayLap] [datetime] NULL,
	[TongTien] [int] NULL,
	[TinhTrang] [nvarchar](50) NULL,
	[MaNV] [nvarchar](50) NOT NULL,
	[MaKH] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_HoaDon] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[View_thongtinkhachmuahang]    Script Date: 1/4/2020 1:47:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[View_thongtinkhachmuahang]
as
select Kh.TenKH,kh.SDT,KH.DiaChi,HD.MaHD,HD.NgayLap,HD.TinhTrang,HD.TongTien,CT.MaSP,CT.SoLuong,CT.DonGia,CT.ThanhTien from KhachHang KH LEFT JOIN HoaDon HD on KH.MaKH = hd.MaKH
join  ChiTietHoaDon CT on HD.MaHD = CT.MaHD
GO
/****** Object:  Table [dbo].[LoaiSanPham]    Script Date: 1/4/2020 1:47:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiSanPham](
	[MaLSP] [nvarchar](50) NOT NULL,
	[TenLSP] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_LoaiSanPham] PRIMARY KEY CLUSTERED 
(
	[MaLSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhaCungCap]    Script Date: 1/4/2020 1:47:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhaCungCap](
	[MaNCC] [nvarchar](50) NOT NULL,
	[TenNCC] [nvarchar](50) NOT NULL,
	[DiaChi] [nvarchar](50) NULL,
	[SDT] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[Website] [nvarchar](50) NULL,
 CONSTRAINT [PK_NhaCungCap] PRIMARY KEY CLUSTERED 
(
	[MaNCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SanPham]    Script Date: 1/4/2020 1:47:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SanPham](
	[MaSP] [nvarchar](50) NOT NULL,
	[TenSP] [nvarchar](50) NOT NULL,
	[DVTinh] [nvarchar](50) NULL,
	[DonGia] [int] NULL,
	[SoLuong] [int] NULL,
	[MaLSP] [nvarchar](50) NOT NULL,
	[MaNCC] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_SanPham] PRIMARY KEY CLUSTERED 
(
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 1/4/2020 1:47:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[TaiKhoan] [nvarchar](50) NOT NULL,
	[MatKhau] [nvarchar](50) NOT NULL,
	[Quyen] [nvarchar](50) NOT NULL,
	[MaNV] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_TaiKhoan] PRIMARY KEY CLUSTERED 
(
	[TaiKhoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'HD01', N'DO', 2, 380000, 760000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'HD01', N'LS02', 2, 380000, 760000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'HD01', N'LS03', 1, 900000, 900000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'HD01', N'TS01', 2, 380000, 760000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'HD01', N'TS02', 2, 380000, 760000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'HD02', N'AB02', 2, 380000, 760000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'HD02', N'CA02', 1, 50000, 50000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'HD02', N'LS01', 2, 880000, 1760000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'HD03', N'LS01', 1, 880000, 880000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'HD04', N'DO01', 1, 700000, 700000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'HD04', N'TS02', 1, 180000, 180000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'HD05', N'AB01', 1, 380000, 380000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'HD05', N'CA01', 1, 50000, 50000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'HD05', N'CA02', 2, 50000, 100000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'HD05', N'TS01', 1, 200000, 200000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'HD06', N'AB02', 1, 350000, 350000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'HD06', N'DO02', 1, 720000, 720000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'HD07', N'LS03', 1, 900000, 900000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'HD07', N'TS01', 2, 200000, 400000)
INSERT [dbo].[HoaDon] ([MaHD], [NgayLap], [TongTien], [TinhTrang], [MaNV], [MaKH]) VALUES (N'HD01', CAST(N'2019-10-01T00:00:00.000' AS DateTime), 4320000, N'Hoàn tất', N'NV01', N'KH02')
INSERT [dbo].[HoaDon] ([MaHD], [NgayLap], [TongTien], [TinhTrang], [MaNV], [MaKH]) VALUES (N'HD02', CAST(N'2019-10-18T01:56:19.657' AS DateTime), 1810000, N'Hoàn tất', N'NV01', N'KH01')
INSERT [dbo].[HoaDon] ([MaHD], [NgayLap], [TongTien], [TinhTrang], [MaNV], [MaKH]) VALUES (N'HD03', CAST(N'2019-10-01T00:00:00.000' AS DateTime), 880000, N'Hoàn tất', N'NV04', N'KH01')
INSERT [dbo].[HoaDon] ([MaHD], [NgayLap], [TongTien], [TinhTrang], [MaNV], [MaKH]) VALUES (N'HD04', CAST(N'2019-10-19T00:00:00.000' AS DateTime), 880000, N'Hoàn tất', N'NV04', N'KH04')
INSERT [dbo].[HoaDon] ([MaHD], [NgayLap], [TongTien], [TinhTrang], [MaNV], [MaKH]) VALUES (N'HD05', CAST(N'2019-10-01T00:00:00.000' AS DateTime), 730000, N'Đã hủy', N'NV02', N'KH03')
INSERT [dbo].[HoaDon] ([MaHD], [NgayLap], [TongTien], [TinhTrang], [MaNV], [MaKH]) VALUES (N'HD06', CAST(N'2019-10-24T00:00:00.000' AS DateTime), 1070000, N'Hoàn tất', N'NV01', N'KH02')
INSERT [dbo].[HoaDon] ([MaHD], [NgayLap], [TongTien], [TinhTrang], [MaNV], [MaKH]) VALUES (N'HD07', CAST(N'2019-10-24T00:00:00.000' AS DateTime), 1300000, N'Hoàn tất', N'NV02', N'KH01')
INSERT [dbo].[HoaDon] ([MaHD], [NgayLap], [TongTien], [TinhTrang], [MaNV], [MaKH]) VALUES (N'HD08', CAST(N'2019-10-01T00:00:00.000' AS DateTime), 0, N'Hoàn t?t', N'NV01', N'KH02')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DiaChi], [SDT]) VALUES (N'KH01', N'Nguyễn Yến Nhi', N'212 Lý Chính Thắng, quận 3, HCM', N'0585902000')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DiaChi], [SDT]) VALUES (N'KH02', N'Trần Thy Hân', N'150 Nguyễn Hữu Cảnh, quận Bình Thạnh, HCM', N'0965636999')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DiaChi], [SDT]) VALUES (N'KH03', N'Nguyễn Duy Dương', N'123 Võ Văn Ngân, quận Thủ Đức, HCM', N'0963885520')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DiaChi], [SDT]) VALUES (N'KH04', N'Nguyễn An Như', N'11 Lê Đức Thọ, Gò Vấp', N'0963886666')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DiaChi], [SDT]) VALUES (N'KH05', N'Nguyễn Yến Nhi', N'212 Lý Chính Thắng, quận 3, HCM', N'0585902000')
INSERT [dbo].[LoaiSanPham] ([MaLSP], [TenLSP]) VALUES (N'AB', N'ABum')
INSERT [dbo].[LoaiSanPham] ([MaLSP], [TenLSP]) VALUES (N'CA', N'Card')
INSERT [dbo].[LoaiSanPham] ([MaLSP], [TenLSP]) VALUES (N'DO', N'Gấu bông')
INSERT [dbo].[LoaiSanPham] ([MaLSP], [TenLSP]) VALUES (N'HD', N'Hoodie')
INSERT [dbo].[LoaiSanPham] ([MaLSP], [TenLSP]) VALUES (N'LS', N'Lightstick')
INSERT [dbo].[LoaiSanPham] ([MaLSP], [TenLSP]) VALUES (N'TS', N'T-shirt')
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [DiaChi], [SDT], [Email], [Website]) VALUES (N'HM', N'Công ty H&M Ent', N'44 Nguyễn Thông, quận 3', N'0772294488', N'hm@gmail.com', N'hm.com')
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [DiaChi], [SDT], [Email], [Website]) VALUES (N'JYP', N'Công ty JYP', N'279 Nguyễn Tri Phương, quận 10, HCM', N'0772292007', N'jyp@gmail.com', N'jyp.com')
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [DiaChi], [SDT], [Email], [Website]) VALUES (N'SM', N'Công ty SM', N'202 Điện Biên Phủ, quận Bình Thạnh, HCM', N'0969527073', N'smtown@gmail.com', N'smtown.com')
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [DiaChi], [SDT], [Email], [Website]) VALUES (N'YG', N'Công ty YG', N'59 Nguyễn Đình Chiểu, quận 3, HCM', N'0978347731', N'yggoods@gmail.com', N'yggoods.com')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [GioiTinh], [NgaySinh], [DiaChi], [SDT]) VALUES (N'NV01', N'Hoàng Thủy Tiên', N'Nữ', CAST(N'1998-01-17T00:00:00.000' AS DateTime), N'312 Phan Văn Trị, quận Gò Vấp, HCM', N'0932569999')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [GioiTinh], [NgaySinh], [DiaChi], [SDT]) VALUES (N'NV02', N'Nguyễn Lan Ngọc', N'Nữ', CAST(N'1998-11-11T00:00:00.000' AS DateTime), N'81 Nguyễn Cửu Vân, quận Bình Thạnh, HCM', N'0587413698')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [GioiTinh], [NgaySinh], [DiaChi], [SDT]) VALUES (N'NV03', N'Lê Tuyết Nhung', N'Nữ', CAST(N'1996-02-15T00:00:00.000' AS DateTime), N'32 Nguyễn Gia Trí, quận Bình Thạnh, HCM', N'0796852217')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [GioiTinh], [NgaySinh], [DiaChi], [SDT]) VALUES (N'NV04', N'Ngọc Quỳnh', N'Nữ', CAST(N'1998-10-15T17:22:51.000' AS DateTime), N'Bình Thạnh', N'0123456789')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [GioiTinh], [NgaySinh], [DiaChi], [SDT]) VALUES (N'NV05', N'Yến Nhi', N'Nữ', CAST(N'2000-10-15T09:12:39.000' AS DateTime), N'Gò Vấp', N'0123453333')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [GioiTinh], [NgaySinh], [DiaChi], [SDT]) VALUES (N'NV06', N'Nguyễn Đức Trí', N'Nam', CAST(N'1998-11-20T00:00:00.000' AS DateTime), N'10 Thành Thái, quận 10', N'0932566666')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [GioiTinh], [NgaySinh], [DiaChi], [SDT]) VALUES (N'NV07', N'Hoàng Th?y Tiên', N'N?', CAST(N'1998-01-17T00:00:00.000' AS DateTime), N'312 Phan Van Tr?,qu?n Gò V?p,HCM', N'0932569999')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DVTinh], [DonGia], [SoLuong], [MaLSP], [MaNCC]) VALUES (N'AB01', N'Album SNSD', N'cái', 380000, 10, N'AB', N'HM')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DVTinh], [DonGia], [SoLuong], [MaLSP], [MaNCC]) VALUES (N'AB02', N'Album EXID', N'cái', 350000, 7, N'AB', N'JYP')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DVTinh], [DonGia], [SoLuong], [MaLSP], [MaNCC]) VALUES (N'AB03', N'Album BTOB', N'cái', 300000, 7, N'AB', N'HM')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DVTinh], [DonGia], [SoLuong], [MaLSP], [MaNCC]) VALUES (N'CA01', N'Card IZONE', N'cái', 50000, 20, N'CA', N'HM')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DVTinh], [DonGia], [SoLuong], [MaLSP], [MaNCC]) VALUES (N'CA02', N'Card W1', N'cái', 50000, 15, N'CA', N'HM')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DVTinh], [DonGia], [SoLuong], [MaLSP], [MaNCC]) VALUES (N'DO', N'Album', N'cái', 380000, 8, N'DO', N'HM')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DVTinh], [DonGia], [SoLuong], [MaLSP], [MaNCC]) VALUES (N'DO01', N'Gấu bông BAP', N'con', 700000, 3, N'DO', N'YG')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DVTinh], [DonGia], [SoLuong], [MaLSP], [MaNCC]) VALUES (N'DO02', N'Gấu bông IKON', N'con', 720000, 5, N'DO', N'YG')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DVTinh], [DonGia], [SoLuong], [MaLSP], [MaNCC]) VALUES (N'LS01', N'Lightstick Twice', N'cái', 880000, 9, N'LS', N'JYP')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DVTinh], [DonGia], [SoLuong], [MaLSP], [MaNCC]) VALUES (N'LS02', N'Lightstick EXO', N'cái', 1000000, 10, N'LS', N'SM')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DVTinh], [DonGia], [SoLuong], [MaLSP], [MaNCC]) VALUES (N'LS03', N'Lightstick BigBang', N'cái', 900000, 7, N'LS', N'SM')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DVTinh], [DonGia], [SoLuong], [MaLSP], [MaNCC]) VALUES (N'TS01', N'T-shirt NCT', N'cái', 200000, 4, N'TS', N'SM')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DVTinh], [DonGia], [SoLuong], [MaLSP], [MaNCC]) VALUES (N'TS02', N'T-shirt BP', N'cái', 180000, 6, N'TS', N'SM')
INSERT [dbo].[TaiKhoan] ([TaiKhoan], [MatKhau], [Quyen], [MaNV]) VALUES (N'demo', N'1', N'QuanLy', N'NV02')
INSERT [dbo].[TaiKhoan] ([TaiKhoan], [MatKhau], [Quyen], [MaNV]) VALUES (N'use4', N'1', N'Nhan Vien', N'NV01')
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHoaDon_HoaDon] FOREIGN KEY([MaHD])
REFERENCES [dbo].[HoaDon] ([MaHD])
GO
ALTER TABLE [dbo].[ChiTietHoaDon] CHECK CONSTRAINT [FK_ChiTietHoaDon_HoaDon]
GO
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHoaDon_SanPham] FOREIGN KEY([MaSP])
REFERENCES [dbo].[SanPham] ([MaSP])
GO
ALTER TABLE [dbo].[ChiTietHoaDon] CHECK CONSTRAINT [FK_ChiTietHoaDon_SanPham]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_KhachHang] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachHang] ([MaKH])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_KhachHang]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_NhanVien]
GO
ALTER TABLE [dbo].[SanPham]  WITH CHECK ADD  CONSTRAINT [FK_SanPham_LoaiSanPham] FOREIGN KEY([MaLSP])
REFERENCES [dbo].[LoaiSanPham] ([MaLSP])
GO
ALTER TABLE [dbo].[SanPham] CHECK CONSTRAINT [FK_SanPham_LoaiSanPham]
GO
ALTER TABLE [dbo].[SanPham]  WITH CHECK ADD  CONSTRAINT [FK_SanPham_NhaCungCap] FOREIGN KEY([MaNCC])
REFERENCES [dbo].[NhaCungCap] ([MaNCC])
GO
ALTER TABLE [dbo].[SanPham] CHECK CONSTRAINT [FK_SanPham_NhaCungCap]
GO
ALTER TABLE [dbo].[TaiKhoan]  WITH CHECK ADD  CONSTRAINT [FK_TaiKhoan_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[TaiKhoan] CHECK CONSTRAINT [FK_TaiKhoan_NhanVien]
GO
/****** Object:  StoredProcedure [dbo].[SPDeleteChiTietHoaDon]    Script Date: 1/4/2020 1:47:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[SPDeleteChiTietHoaDon]
@MaHD nvarchar(50),
@MaSP nvarchar(50)
as
begin
	Delete ChiTietHoaDon where MaHD = @MaHD and MaSP = @MaSP	
end
GO
/****** Object:  StoredProcedure [dbo].[SPdeleteHoaDon]    Script Date: 1/4/2020 1:47:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[SPdeleteHoaDon]
@MaHD nvarchar(50)
as
if exists (select * from ChiTietHoaDon where MaHD = @MaHD)
THROW 50001,'Hoa Don Con Su dung Khong the Xoa',1;
begin
	Delete HoaDon where MaHD =@MaHD
end
GO
/****** Object:  StoredProcedure [dbo].[SPDeleteKhachHang]    Script Date: 1/4/2020 1:47:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[SPDeleteKhachHang]
@MaKH nvarchar(50)
as
if exists (select * from HoaDon where MaKH = @MaKH)
Throw 50001,'Khach Hang Con Hoa Don',1;
begin
		delete KhachHang  where MaKH = @MaKH	
		
end
GO
/****** Object:  StoredProcedure [dbo].[SPDeleteLoaiSanPham]    Script Date: 1/4/2020 1:47:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[SPDeleteLoaiSanPham]
@MaLSP nvarchar(50)
as
if exists (select * from SanPham where MaLSP = @MaLSP)
THROW 50001, 'Loai San Pham Con Duoc Su Dung',1;
begin
delete LoaiSanPham where MaLSP = @MaLSP
end
GO
/****** Object:  StoredProcedure [dbo].[SPDeleteNhaCungCap]    Script Date: 1/4/2020 1:47:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[SPDeleteNhaCungCap]
@MaNCC nvarchar(50)
as
If exists (select * from SanPham where MaNCC = @MaNCC)
THROW 50001,'Nhan vien Con Hoa Don',1;
begin
delete NhaCungCap where MaNCC = @MaNCC
end
GO
/****** Object:  StoredProcedure [dbo].[SPDeleteNhanVien]    Script Date: 1/4/2020 1:47:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[SPDeleteNhanVien]
@MaNV nvarchar(50)
as
If exists (select * from HoaDon where MaNV = @MaNV)
THROW 50001,'Nhan vien Con Hoa Don',1;
begin
Delete NhanVien where MaNV = @MaNV
end
GO
/****** Object:  StoredProcedure [dbo].[SPDeleteSanPham]    Script Date: 1/4/2020 1:47:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[SPDeleteSanPham]
@MaSP nvarchar(50)
as
if exists (select * from ChiTietHoaDon where MaSP = @MaSP)
THROW 50001,'San Pham con su dung chua duoc xoa',1;
begin
Delete SanPham where MaSP = @MaSP
end
GO
/****** Object:  StoredProcedure [dbo].[SPGetAllHoaDon]    Script Date: 1/4/2020 1:47:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[SPGetAllHoaDon]
as
begin
	Select * from HoaDon 
end
GO
/****** Object:  StoredProcedure [dbo].[SPGetAllKhachHang]    Script Date: 1/4/2020 1:47:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[SPGetAllKhachHang]
as
begin
Select* From KhachHang  
end
GO
/****** Object:  StoredProcedure [dbo].[SPGetAllLoaiSanPham]    Script Date: 1/4/2020 1:47:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[SPGetAllLoaiSanPham]
as
begin
Select * From LoaiSanPham
end
GO
/****** Object:  StoredProcedure [dbo].[SPGetAllNhaCungCap]    Script Date: 1/4/2020 1:47:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[SPGetAllNhaCungCap]
as
begin
Select * from NhaCungCap
end
GO
/****** Object:  StoredProcedure [dbo].[SPGetAllNhanVien]    Script Date: 1/4/2020 1:47:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[SPGetAllNhanVien]
as
begin
Select * from NhanVien
end
GO
/****** Object:  StoredProcedure [dbo].[SPGetAllSanPham]    Script Date: 1/4/2020 1:47:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[SPGetAllSanPham]
as
begin
	select * from SanPham
end
GO
/****** Object:  StoredProcedure [dbo].[SPGetByIdHoaDon]    Script Date: 1/4/2020 1:47:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[SPGetByIdHoaDon]
@MaHD nvarchar(50)
as

begin
	Select * from HoaDon where MaHD = @MaHD
end
GO
/****** Object:  StoredProcedure [dbo].[SPGetByIdKhachHang]    Script Date: 1/4/2020 1:47:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[SPGetByIdKhachHang]
@MaKH nvarchar(50)
as
if @MaKH=''or @MaKH is null
THROW 50001, 'Ma Khach Hang Khong duoc de trong',1;
begin
Select* From KhachHang  where MaKH = @MaKH
end
GO
/****** Object:  StoredProcedure [dbo].[SPGetByIdLoaiSanPham]    Script Date: 1/4/2020 1:47:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[SPGetByIdLoaiSanPham]
@MaLSP nvarchar(50)
as
if @MaLSP = '' or @MaLSP is null
THROW 50001, 'Ma Loai San Pham Khong duoc de trong',1;
begin
Select * From LoaiSanPham where MaLSP = @MaLSP
end
GO
/****** Object:  StoredProcedure [dbo].[SPGetByIdNhaCungCap]    Script Date: 1/4/2020 1:47:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[SPGetByIdNhaCungCap]
@MaNCC nvarchar(50)
as
if exists(select * from SanPham where MaNCC = @MaNCC)
THROW 50001, 'Ma nha cung cap con cung cap san pham',1;
begin
delete NhaCungCap where MaNCC = @MaNCC
end
GO
/****** Object:  StoredProcedure [dbo].[SPGetByIdNhanVien]    Script Date: 1/4/2020 1:47:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[SPGetByIdNhanVien]
@MaNv nvarchar(50)
as
begin
Select * from NhanVien where MaNV = @MaNv
end
GO
/****** Object:  StoredProcedure [dbo].[SPGetByIdSanPham]    Script Date: 1/4/2020 1:47:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[SPGetByIdSanPham]
@MaSP nvarchar(50)
as
begin
	select * from SanPham where MaSP = @MaSP
end
GO
/****** Object:  StoredProcedure [dbo].[SPGetByMaHDChiTietHoaDon]    Script Date: 1/4/2020 1:47:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[SPGetByMaHDChiTietHoaDon]
@MaHD nvarchar(50)
as
begin
	select * from ChiTietHoaDon where MaHD = @MaHD 
end

GO
/****** Object:  StoredProcedure [dbo].[SPGetByNameKhachHang]    Script Date: 1/4/2020 1:47:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[SPGetByNameKhachHang]
@TenKH nvarchar(50)
as
begin
Select* From KhachHang  where TenKH like N'' + @TenKH  +'%'
end
GO
/****** Object:  StoredProcedure [dbo].[SPGetByNameLoaiSanPham]    Script Date: 1/4/2020 1:47:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[SPGetByNameLoaiSanPham]
@TenLSP nvarchar(50)
as
begin
Select* From LoaiSanPham  where TenLSP like N'' + @TenLSP  +'%'
end
GO
/****** Object:  StoredProcedure [dbo].[SPGetByNameNhaCungCap]    Script Date: 1/4/2020 1:47:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[SPGetByNameNhaCungCap]
@TenNCC nvarchar(50)
as
begin
Select* From NhaCungCap  where TenNCC like N'' + @TenNCC  +'%'
end
GO
/****** Object:  StoredProcedure [dbo].[SPGetByNameNhanVien]    Script Date: 1/4/2020 1:47:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[SPGetByNameNhanVien]
@TenNV nvarchar(50)
as
begin
Select* From NhanVien  where TenNV like N'' + @TenNV  +'%'
end
GO
/****** Object:  StoredProcedure [dbo].[SPGetByNameSanPham]    Script Date: 1/4/2020 1:47:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[SPGetByNameSanPham]
@TenSP nvarchar(50)
as
begin
Select* From SanPham  where TenSP like N'' + @TenSP  +'%'
end
GO
/****** Object:  StoredProcedure [dbo].[SPInsertChiTietHoaDon]    Script Date: 1/4/2020 1:47:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[SPInsertChiTietHoaDon]
@MaHD nvarchar(50),
@MaSP nvarchar(50),
@Soluong int,
@Dongia int
as
if exists (select * from ChiTietHoaDon where MaHD = @MaHD and MaSP = @MaSP)
THROW 50001, 'Ma Chi tiet Hoa Don da ton tai',1;
if not exists (select * from HoaDon where MaHD = @MaHD)
Throw 50001, 'Hoa Don Khong ton tai',1;
if not exists (select * from SanPham where MaSP = @MaSP)
Throw 50001, 'San pham Khong ton tai',1;
if @MaHD='' or @MaHD is null
THROW 50001, 'Ma Hoa Don Khong Duoc De Trong',1;
if @MaSP='' or @MaSP is null
THROW 50001, 'Ma San Pham Khong Duoc De Trong',1;
if @Soluong='' or @Soluong is null
THROW 50001, 'So Luong Khong Duoc De Trong',1;
If ISNUMERIC(@Soluong)<0
Throw 50001,'So luong khong duoc am',1;
if @Dongia='' or @Dongia is null
THROW 50001, 'Don Gia Khong Duoc De Trong',1;
if ISNUMERIC(@Dongia)<0
Throw 50001,'Don gia khong duoc am',1;
begin
declare @ThanhTien int;
Set @ThanhTien = @Soluong*@Dongia;	
	insert ChiTietHoaDon values (@MaHD,@MaSP,@Soluong,@Dongia,@ThanhTien)	
end
GO
/****** Object:  StoredProcedure [dbo].[SPInsertHoaDon]    Script Date: 1/4/2020 1:47:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[SPInsertHoaDon]
@MaHD nvarchar(50),
@NgayLap datetime,
@TongTien int,
@TinhTrang nvarchar(50),
@MaNV nvarchar(50),
@MaKH nvarchar(50)

as
if exists (select * from HoaDon where MaHD = @MaHD)
THROW 50001, 'Ma Hoa Don da ton tai',1;
if @MaHD='' or @MaHD is null
THROW 50001, 'Ma Hoa Don Khong Duoc De Trong',1;
if @NgayLap='' or @NgayLap is null or @NgayLap>GETDATE()
THROW 50001, 'Ngay Lap Hoa Don Khong Duoc De Trong Hoac lon hon ngay hien tai',1;
if @TinhTrang='' or @TinhTrang is null
THROW 50001, 'Tinh Trang Hoa Don Khong Duoc De Trong',1;
if @MaNV='' or @MaNV is null
THROW 50001, 'Ma Nhan Vien Khong Duoc De Trong',1;
If not exists (select * from NhanVien where MaNV = @MaNV)
THROW 50001,'Nhan vien Khong ton tai',1;
if @MaKH='' or @MaKH is null
THROW 50001, 'Ma Khach Hang Khong Duoc De Trong',1;
If not exists (select * from KhachHang where MaKH = @MaKH)
THROW 50001,'Khach Hang Khong ton tai',1;
begin
	if @TongTien='' or @TongTien is null
		begin
			set @tongtien = 0;
		end
	insert HoaDon values (@MaHD,@NgayLap,@TongTien,@TinhTrang,@MaNV,@MaKH)	
end
GO
/****** Object:  StoredProcedure [dbo].[SPInsertKhachHang]    Script Date: 1/4/2020 1:47:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[SPInsertKhachHang]
@MaKH nvarchar(50),
@TenKH nvarchar(50),
@DiaChi nvarchar(50),
@SDT nvarchar(50)
as
BEGIN
if exists (select * from KhachHang where MaKH= @MaKH)
THROW 50001, 'Ma Khach Hang Da ton tai!', 1;
if @MaKH=''or @MaKH is null
THROW 50001, 'Ma Khach Hang Khong duoc de trong',1;
if @TenKH=''or @TenKH is null
THROW 50001, 'Ten Khach Hang Khong duoc de trong',1;
if @DiaChi=''or @DiaChi is null
THROW 50001, 'Dia Chi Khach Hang Khong duoc de trong',1;
if @SDT=''or @SDT is null
THROW 50001, 'So Dien Thoai Khach Hang Khong duoc de trong',1;
BEGIN TRANSACTION
	BEGIN TRY
		insert KhachHang values(@MaKH,@TenKH,@DiaChi,@SDT)
		commit
	end try
	BEGIN CATCH
		ROLLBACK TRANSACTION
		DECLARE @ErrorMessage NVARCHAR(2000)
		SELECT @ErrorMessage = 'Error: ' + ERROR_MESSAGE()
		RAISERROR(@ErrorMessage, 16, 1)
	END CATCH

end
GO
/****** Object:  StoredProcedure [dbo].[SPInsertLoaiSanPham]    Script Date: 1/4/2020 1:47:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[SPInsertLoaiSanPham]
@MaLSP nvarchar(50),
@TenLSP nvarchar(50)
as
if exists (select * from LoaiSanPham where MaLSP=@MaLSP)
THROW 50001, 'Ma Loai San Pham Da ton tai!', 1;
if @MaLSP=''or @MaLSP is null
THROW 50001, 'Ma Loai San Pham Khong duoc de trong',1;
if @TenLSP=''or @TenLSP is null
THROW 50001, 'Ten Loai San Pham Khong duoc de trong',1;
begin
insert LoaiSanPham values(@MaLSP,@TenLSP)
end
GO
/****** Object:  StoredProcedure [dbo].[SPInsertNhaCungCap]    Script Date: 1/4/2020 1:47:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[SPInsertNhaCungCap]
@MaNCC nvarchar(50),
@TenNCC nvarchar(50),
@DiaChi nvarchar(50),
@SDT nvarchar(50),
@Email nvarchar(50),
@Website nvarchar(50)
as
begin
if exists (select * from NhaCungCap where MaNCC= @MaNCC)
THROW 50001, 'Ma Nha Cung Cap Da ton tai!', 1;
if @MaNCC=''or @MaNCC is null
THROW 50001, 'Ma nha cung cap Khong duoc de trong',1;
if @TenNCC=''or @TenNCC is null
THROW 50001, 'Ten nha cung cap Khong duoc de trong',1;
BEGIN TRANSACTION
	BEGIN TRY
	insert NhaCungCap values(@MaNCC,@TenNCC,@DiaChi,@SDT,@Email,@Website)
	commit
	end try
	BEGIN CATCH
		ROLLBACK TRANSACTION
		DECLARE @ErrorMessage NVARCHAR(2000)
		SELECT @ErrorMessage = 'Error: ' + ERROR_MESSAGE()
		RAISERROR(@ErrorMessage, 16, 1)
	END CATCH

end
GO
/****** Object:  StoredProcedure [dbo].[SPInsertNhanVien]    Script Date: 1/4/2020 1:47:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   procedure [dbo].[SPInsertNhanVien]
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
IF @NgaySinh IS NULL or DATEDIFF(YYYY,@NgaySinh,GETDATE())<18
THROW 50001,'Ngày Sinh Không Được Lớn Hơn Ngày Hiện Tại!',1; 
if @DiaChi=''or @DiaChi is null
THROW 50001, 'Dia Chi Nhan Vien Khong duoc de trong',1;
if @SDT=''or @SDT is null
THROW 50001, 'So Dien Thoai Nhan Vien Khong duoc de trong',1;
begin
insert NhanVien values(@MaNv,@TenNV,@GioiTinh,@NgaySinh,@DiaChi,@SDT)
end
GO
/****** Object:  StoredProcedure [dbo].[SPInsertSanPham]    Script Date: 1/4/2020 1:47:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[SPInsertSanPham]
@MaSP nvarchar(50),
@TenSP nvarchar(50),
@DVTinh nvarchar(50),
@DonGia int,
@SoLuong int,
@MaLSP nvarchar(50),
@MaNCC nvarchar(50)
as
if exists (select * from SanPham where MaSP = @MaSP)
THROW 50001, 'Ma San Pham da ton tai',1;
if @MaSP=''or @MaSP is null
THROW 50001, 'Ma San Pham Khong duoc de trong',1;
if @TenSP=''or @TenSP is null
THROW 50001, 'Ten San Pham Khong duoc de trong',1;
if @DVTinh=''or @DVTinh is null
THROW 50001, 'DV Tinh San Pham Khong duoc de trong',1;
if @SoLuong=''or @SoLuong is null
THROW 50001, 'So Luong San Pham Khong duoc de trong',1;
if ISNUMERIC(@SoLuong)<0
THROW 50001, 'So Luong San Pham khong duoc am Khong duoc de trong',1;
if @MaLSP=''or @MaLSP is null 
THROW 50001, 'Ma Loai San Pham Khong duoc de trong',1;
if not exists (select * from LoaiSanPham where MaLSP = @MaLSP)
THROW 50001, 'Loai san pham khong ton tai',1;
if @MaNCC=''or @MaNCC is null 
THROW 50001, 'Ma Nha Cung Cap San Pham Khong duoc de trong',1;
if not exists (select * from NhaCungCap where MaNCC = @MaNCC)
THROW 50001, 'Nha cung cap khong ton tai',1;
begin
	insert SanPham values (@MaSP,@TenSP,@DVTinh,@DonGia,@SoLuong,@MaLSP,@MaNCC)	
end
GO
/****** Object:  StoredProcedure [dbo].[SPUpdateChiTietHoaDon]    Script Date: 1/4/2020 1:47:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[SPUpdateChiTietHoaDon]
@MaHD nvarchar(50),
@MaSP nvarchar(50),
@Soluong int,
@Dongia int
as
if not exists (select * from HoaDon where MaHD = @MaHD)
Throw 50001, 'Hoa Don Khong ton tai',1;
if not exists (select * from SanPham where MaSP = @MaSP)
Throw 50001, 'San pham Khong ton tai',1;
if @MaHD='' or @MaHD is null
THROW 50001, 'Ma Hoa Don Khong Duoc De Trong',1;
if @MaSP='' or @MaSP is null
THROW 50001, 'Ma San Pham Khong Duoc De Trong',1;
if @Soluong='' or @Soluong is null
THROW 50001, 'So Luong Khong Duoc De Trong',1;
If ISNUMERIC(@Soluong)<0
Throw 50001,'So luong khong duoc am',1;
if @Dongia='' or @Dongia is null
THROW 50001, 'Don Gia Khong Duoc De Trong',1;
if ISNUMERIC(@Dongia)<0
Throw 50001,'Don gia khong duoc am',1;
begin
declare @ThanhTien int;
Set @ThanhTien = @Soluong*@Dongia;	
	Update ChiTietHoaDon set SoLuong= @Soluong,DonGia = @Dongia,ThanhTien= @ThanhTien where MaHD = @MaHD and MaSP =@MaSP	
end
GO
/****** Object:  StoredProcedure [dbo].[SPUpdateHoaDon]    Script Date: 1/4/2020 1:47:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[SPUpdateHoaDon]
@MaHD nvarchar(50),
@NgayLap datetime,
@TongTien int,
@TinhTrang nvarchar(50),
@MaNV nvarchar(50),
@MaKH nvarchar(50)

as
if @MaHD='' or @MaHD is null
THROW 50001, 'Ma Hoa Don Khong Duoc De Trong',1;
if @NgayLap='' or @NgayLap is null or @NgayLap>GETDATE()
THROW 50001, 'Ngay Lap Hoa Don Khong Duoc De Trong Hoac lon hon ngay hien tai',1;
if @TinhTrang='' or @TinhTrang is null
THROW 50001, 'Tinh Trang Hoa Don Khong Duoc De Trong',1;
if @MaNV='' or @MaNV is null
THROW 50001, 'Ma Nhan Vien Khong Duoc De Trong',1;
If not exists (select * from NhanVien where MaNV = @MaNV)
THROW 50001,'Nhan vien Khong ton tai',1;
if @MaKH='' or @MaKH is null
THROW 50001, 'Ma Khach Hang Khong Duoc De Trong',1;
If not exists (select * from KhachHang where MaKH = @MaKH)
THROW 50001,'Khach Hang Khong ton tai',1;
begin
	if @TongTien='' or @TongTien is null
		begin
			set @tongtien = 0;
		end
	Update HoaDon set NgayLap = @NgayLap,TongTien = @TongTien,TinhTrang = @TinhTrang,MaNV = @MaNV,MaKH = @MaKH where MaHD = @MaHD
end
GO
/****** Object:  StoredProcedure [dbo].[SPUpdateKhachHang]    Script Date: 1/4/2020 1:47:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[SPUpdateKhachHang]
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
GO
/****** Object:  StoredProcedure [dbo].[SPUpdateLoaiSanPham]    Script Date: 1/4/2020 1:47:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[SPUpdateLoaiSanPham]
@MaLSP nvarchar(50),
@TenLSP nvarchar(50)
as
if @MaLSP=''or @MaLSP is null
THROW 50001, 'Ma Loai San Pham Khong duoc de trong',1;
if @TenLSP=''or @TenLSP is null
THROW 50001, 'Ten Loai San Pham Khong duoc de trong',1;
begin
update LoaiSanPham set TenLSP = @TenLSP where MaLSP = @MaLSP
end
GO
/****** Object:  StoredProcedure [dbo].[SPUpdateNhaCungCap]    Script Date: 1/4/2020 1:47:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[SPUpdateNhaCungCap]
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
GO
/****** Object:  StoredProcedure [dbo].[SPUpdateSanPham]    Script Date: 1/4/2020 1:47:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[SPUpdateSanPham]
@MaSP nvarchar(50),
@TenSP nvarchar(50),
@DVTinh nvarchar(50),
@DonGia int,
@SoLuong int,
@MaLSP nvarchar(50),
@MaNCC nvarchar(50)
as
if @MaSP=''or @MaSP is null
THROW 50001, 'Ma San Pham Khong duoc de trong',1;
if @TenSP=''or @TenSP is null
THROW 50001, 'Ten San Pham Khong duoc de trong',1;
if @DVTinh=''or @DVTinh is null
THROW 50001, 'DV Tinh San Pham Khong duoc de trong',1;
if @SoLuong=''or @SoLuong is null
THROW 50001, 'So Luong San Pham Khong duoc de trong',1;
if ISNUMERIC(@SoLuong)<0
THROW 50001, 'So Luong San Pham khong duoc am Khong duoc de trong',1;
if @MaLSP=''or @MaLSP is null 
THROW 50001, 'Ma Loai San Pham Khong duoc de trong',1;
if not exists (select * from LoaiSanPham where MaLSP = @MaLSP)
THROW 50001, 'Loai san pham khong ton tai',1;
if @MaNCC=''or @MaNCC is null 
THROW 50001, 'Ma Nha Cung Cap San Pham Khong duoc de trong',1;
if not exists (select * from NhaCungCap where MaNCC = @MaNCC)
THROW 50001, 'Nha cung cap khong ton tai',1;
begin
	Update SanPham set TenSP = @TenSP,DVTinh = @DVTinh,DonGia = @DonGia,SoLuong = @SoLuong,MaLSP = @MaLSP,MaNCC = @MaNCC	where MaSP = @MaSP
end
GO
/****** Object:  StoredProcedure [dbo].[SPUpdatetNhanVien]    Script Date: 1/4/2020 1:47:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[SPUpdatetNhanVien]
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
IF @NgaySinh IS NULL or DATEDIFF(YYYY,@NgaySinh,GETDATE())<18
THROW 50001,'Ngày Sinh Không Được Lớn Hơn Ngày Hiện Tại!',1; 
if @DiaChi=''or @DiaChi is null
THROW 50001, 'Dia Chi Nhan Vien Khong duoc de trong',1;
if @SDT=''or @SDT is null
THROW 50001, 'So Dien Thoai Nhan Vien Khong duoc de trong',1;
begin
update NhanVien set TenNV = @TenNV,GioiTinh = @GioiTinh,NgaySinh = @NgaySinh,DiaChi = @DiaChi,SDT = @SDT where MaNV = @MaNv
end
GO
