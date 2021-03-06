
/****** Object:  Database [QLThuoc]    Script Date: 4/9/2018 4:07:37 PM ******/
CREATE DATABASE [QLThuoc]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QLThuoc', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.NGOCANH\MSSQL\DATA\QLThuoc.mdf' , SIZE = 3264KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QLThuoc_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.NGOCANH\MSSQL\DATA\QLThuoc_log.ldf' , SIZE = 832KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QLThuoc] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLThuoc].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLThuoc] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLThuoc] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLThuoc] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLThuoc] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLThuoc] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLThuoc] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [QLThuoc] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLThuoc] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLThuoc] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLThuoc] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLThuoc] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLThuoc] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLThuoc] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLThuoc] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLThuoc] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QLThuoc] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLThuoc] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLThuoc] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLThuoc] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLThuoc] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLThuoc] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLThuoc] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLThuoc] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QLThuoc] SET  MULTI_USER 
GO
ALTER DATABASE [QLThuoc] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLThuoc] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLThuoc] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLThuoc] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [QLThuoc] SET DELAYED_DURABILITY = DISABLED 
GO
USE [QLThuoc]
GO
/****** Object:  Table [dbo].[ChiTietHoaDonNhap]    Script Date: 4/9/2018 4:07:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ChiTietHoaDonNhap](
	[MaHDN] [varchar](10) NOT NULL,
	[MaThuoc] [varchar](10) NOT NULL,
	[DonViTinh] [nvarchar](50) NULL,
	[Gia] [bigint] NULL,
	[SoLuong] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHDN] ASC,
	[MaThuoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ChiTietHoaDonXuat]    Script Date: 4/9/2018 4:07:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ChiTietHoaDonXuat](
	[MaHDX] [varchar](10) NOT NULL,
	[MaThuoc] [varchar](10) NOT NULL,
	[DonViTinh] [nvarchar](50) NULL,
	[Gia] [bigint] NULL,
	[SoLuong] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHDX] ASC,
	[MaThuoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CoSo]    Script Date: 4/9/2018 4:07:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CoSo](
	[MaCS] [varchar](10) NOT NULL,
	[TenCS] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[SDT] [varchar](11) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaCS] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HoaDonNhap]    Script Date: 4/9/2018 4:07:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HoaDonNhap](
	[MaHoaDon] [varchar](10) NOT NULL,
	[MaNCC] [varchar](10) NULL,
	[NgayNhap] [date] NULL,
	[MaNVNhap] [varchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHoaDon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HoaDonXuat]    Script Date: 4/9/2018 4:07:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HoaDonXuat](
	[MaHoaDon] [varchar](10) NOT NULL,
	[MaKH] [varchar](10) NULL,
	[NgayXuat] [date] NULL,
	[MaNVXuat] [varchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHoaDon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 4/9/2018 4:07:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKH] [varchar](10) NOT NULL,
	[TenKH] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[SDT] [varchar](11) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LoaiThuoc]    Script Date: 4/9/2018 4:07:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LoaiThuoc](
	[MaLoaiThuoc] [varchar](10) NOT NULL,
	[TenLoaiThuoc] [nvarchar](50) NULL,
	[GhiChu] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaLoaiThuoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NhaCungCap]    Script Date: 4/9/2018 4:07:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NhaCungCap](
	[MaNCC] [varchar](10) NOT NULL,
	[TenNCC] [nvarchar](50) NULL,
	[SDT] [varchar](11) NULL,
	[DiaChi] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 4/9/2018 4:07:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNV] [varchar](10) NOT NULL,
	[TenNV] [nvarchar](50) NULL,
	[MaCS] [varchar](10) NULL,
	[GioiTinh] [bit] NULL,
	[NgaySinh] [date] NULL,
	[SDT] [varchar](11) NULL,
	[DiaChi] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Thuoc]    Script Date: 4/9/2018 4:07:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Thuoc](
	[MaThuoc] [varchar](10) NOT NULL,
	[TenThuoc] [nvarchar](50) NULL,
	[MaLoaiThuoc] [varchar](10) NULL,
	[MaDVSX] [varchar](10) NULL,
	[CongDung] [nvarchar](100) NULL,
	[HSD] [nvarchar](50) NULL,
	[SoLuong] [int] NULL,
	[NuocSX] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaThuoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[ChiTietHoaDonNhap] ([MaHDN], [MaThuoc], [DonViTinh], [Gia], [SoLuong]) VALUES (N'HDN01', N'T01', N'Vỉ', 15000, 20)
INSERT [dbo].[ChiTietHoaDonNhap] ([MaHDN], [MaThuoc], [DonViTinh], [Gia], [SoLuong]) VALUES (N'HDN01', N'T02', N'Vỉ', 28000, 30)
INSERT [dbo].[ChiTietHoaDonNhap] ([MaHDN], [MaThuoc], [DonViTinh], [Gia], [SoLuong]) VALUES (N'HDN01', N'T03', N'Vỉ', 35000, 10)
INSERT [dbo].[ChiTietHoaDonNhap] ([MaHDN], [MaThuoc], [DonViTinh], [Gia], [SoLuong]) VALUES (N'HDN01', N'T05', N'Túi', 40000, 20)
INSERT [dbo].[ChiTietHoaDonNhap] ([MaHDN], [MaThuoc], [DonViTinh], [Gia], [SoLuong]) VALUES (N'HDN02', N'T01', N'Vỉ', 16000, 30)
INSERT [dbo].[ChiTietHoaDonNhap] ([MaHDN], [MaThuoc], [DonViTinh], [Gia], [SoLuong]) VALUES (N'HDN02', N'T02', N'Vỉ', 26000, 40)
INSERT [dbo].[ChiTietHoaDonNhap] ([MaHDN], [MaThuoc], [DonViTinh], [Gia], [SoLuong]) VALUES (N'HDN03', N'T05', N'Túi', 45000, 20)
INSERT [dbo].[ChiTietHoaDonNhap] ([MaHDN], [MaThuoc], [DonViTinh], [Gia], [SoLuong]) VALUES (N'HDN04', N'T07', N'Vỉ', 40000, 20)
INSERT [dbo].[ChiTietHoaDonNhap] ([MaHDN], [MaThuoc], [DonViTinh], [Gia], [SoLuong]) VALUES (N'HDN04', N'T08', N'Túi', 50000, 30)
INSERT [dbo].[ChiTietHoaDonXuat] ([MaHDX], [MaThuoc], [DonViTinh], [Gia], [SoLuong]) VALUES (N'HDX01', N'T01', N'Vỉ', 20000, 3)
INSERT [dbo].[ChiTietHoaDonXuat] ([MaHDX], [MaThuoc], [DonViTinh], [Gia], [SoLuong]) VALUES (N'HDX01', N'T02', N'Vỉ', 30000, 4)
INSERT [dbo].[ChiTietHoaDonXuat] ([MaHDX], [MaThuoc], [DonViTinh], [Gia], [SoLuong]) VALUES (N'HDX01', N'T03', N'Vỉ', 40000, 1)
INSERT [dbo].[ChiTietHoaDonXuat] ([MaHDX], [MaThuoc], [DonViTinh], [Gia], [SoLuong]) VALUES (N'HDX01', N'T05', N'Túi', 50000, 1)
INSERT [dbo].[ChiTietHoaDonXuat] ([MaHDX], [MaThuoc], [DonViTinh], [Gia], [SoLuong]) VALUES (N'HDX02', N'T01', N'Vỉ', 20000, 1)
INSERT [dbo].[ChiTietHoaDonXuat] ([MaHDX], [MaThuoc], [DonViTinh], [Gia], [SoLuong]) VALUES (N'HDX02', N'T02', N'Vỉ', 30000, 2)
INSERT [dbo].[ChiTietHoaDonXuat] ([MaHDX], [MaThuoc], [DonViTinh], [Gia], [SoLuong]) VALUES (N'HDX03', N'T01', N'Vỉ', 20000, 2)
INSERT [dbo].[ChiTietHoaDonXuat] ([MaHDX], [MaThuoc], [DonViTinh], [Gia], [SoLuong]) VALUES (N'HDX03', N'T05', N'Túi', 50000, 1)
INSERT [dbo].[ChiTietHoaDonXuat] ([MaHDX], [MaThuoc], [DonViTinh], [Gia], [SoLuong]) VALUES (N'HDX04', N'T02', N'Vỉ', 30000, 3)
INSERT [dbo].[ChiTietHoaDonXuat] ([MaHDX], [MaThuoc], [DonViTinh], [Gia], [SoLuong]) VALUES (N'HDX04', N'T08', N'Túi', 55000, 2)
INSERT [dbo].[CoSo] ([MaCS], [TenCS], [DiaChi], [SDT]) VALUES (N'CS01', N'Bệnh viện E', N'Trần Cung', N'01672340980')
INSERT [dbo].[CoSo] ([MaCS], [TenCS], [DiaChi], [SDT]) VALUES (N'CS02', N'Bệnh viện Bạch Mai', N'Tạ Quang Bửu', N'01658005160')
INSERT [dbo].[CoSo] ([MaCS], [TenCS], [DiaChi], [SDT]) VALUES (N'CS03', N'Bệnh viện Việt Đức', N'Hoàng Quốc Việt', N'01642428979')
INSERT [dbo].[CoSo] ([MaCS], [TenCS], [DiaChi], [SDT]) VALUES (N'CS04', N'Bệnh viện 198', N'Xuân Thủy', N'01653839090')
INSERT [dbo].[CoSo] ([MaCS], [TenCS], [DiaChi], [SDT]) VALUES (N'CS05', N'Bệnh viện 108', N'Láng Hạ', N'01672852098')
INSERT [dbo].[CoSo] ([MaCS], [TenCS], [DiaChi], [SDT]) VALUES (N'CS06', N'Bệnh viện Y học cổ truyền', N'Võ Chí Công', N'0942434044')
INSERT [dbo].[CoSo] ([MaCS], [TenCS], [DiaChi], [SDT]) VALUES (N'CS07', N'Bệnh viện U nang', N'Cầu Giấy', N'0943767922')
INSERT [dbo].[CoSo] ([MaCS], [TenCS], [DiaChi], [SDT]) VALUES (N'CS08', N'Bệnh viện tim mạch', N'Trần Hưng Đạo', N'0972151076')
INSERT [dbo].[CoSo] ([MaCS], [TenCS], [DiaChi], [SDT]) VALUES (N'CS09', N'Bệnh viện nhi', N'Nguyễn Thị Định', N'01674566433')
INSERT [dbo].[CoSo] ([MaCS], [TenCS], [DiaChi], [SDT]) VALUES (N'CS10', N'Bệnh việ Nha khoa', N'Hà Đông', N'01651110609')
INSERT [dbo].[HoaDonNhap] ([MaHoaDon], [MaNCC], [NgayNhap], [MaNVNhap]) VALUES (N'HDN01', N'NCC01', CAST(N'2107-01-04' AS Date), N'NV01')
INSERT [dbo].[HoaDonNhap] ([MaHoaDon], [MaNCC], [NgayNhap], [MaNVNhap]) VALUES (N'HDN02', N'NCC02', CAST(N'2107-01-04' AS Date), N'NV02')
INSERT [dbo].[HoaDonNhap] ([MaHoaDon], [MaNCC], [NgayNhap], [MaNVNhap]) VALUES (N'HDN03', N'NCC03', CAST(N'2107-01-04' AS Date), N'NV03')
INSERT [dbo].[HoaDonNhap] ([MaHoaDon], [MaNCC], [NgayNhap], [MaNVNhap]) VALUES (N'HDN04', N'NCC04', CAST(N'2107-01-04' AS Date), N'NV04')
INSERT [dbo].[HoaDonNhap] ([MaHoaDon], [MaNCC], [NgayNhap], [MaNVNhap]) VALUES (N'HDN05', N'NCC05', CAST(N'2107-01-04' AS Date), N'NV05')
INSERT [dbo].[HoaDonNhap] ([MaHoaDon], [MaNCC], [NgayNhap], [MaNVNhap]) VALUES (N'HDN06', N'NCC06', CAST(N'2107-01-04' AS Date), N'NV06')
INSERT [dbo].[HoaDonNhap] ([MaHoaDon], [MaNCC], [NgayNhap], [MaNVNhap]) VALUES (N'HDN07', N'NCC07', CAST(N'2107-01-04' AS Date), N'NV07')
INSERT [dbo].[HoaDonNhap] ([MaHoaDon], [MaNCC], [NgayNhap], [MaNVNhap]) VALUES (N'HDN08', N'NCC01', CAST(N'2107-01-04' AS Date), N'NV08')
INSERT [dbo].[HoaDonNhap] ([MaHoaDon], [MaNCC], [NgayNhap], [MaNVNhap]) VALUES (N'HDN09', N'NCC09', CAST(N'2107-01-04' AS Date), N'NV09')
INSERT [dbo].[HoaDonNhap] ([MaHoaDon], [MaNCC], [NgayNhap], [MaNVNhap]) VALUES (N'HDN10', N'NCC10', CAST(N'2107-01-04' AS Date), N'NV10')
INSERT [dbo].[HoaDonXuat] ([MaHoaDon], [MaKH], [NgayXuat], [MaNVXuat]) VALUES (N'HDX01', N'KH01', CAST(N'2018-05-05' AS Date), N'NV02')
INSERT [dbo].[HoaDonXuat] ([MaHoaDon], [MaKH], [NgayXuat], [MaNVXuat]) VALUES (N'HDX02', N'KH03', CAST(N'2018-05-05' AS Date), N'NV01')
INSERT [dbo].[HoaDonXuat] ([MaHoaDon], [MaKH], [NgayXuat], [MaNVXuat]) VALUES (N'HDX03', N'KH02', CAST(N'2018-05-05' AS Date), N'NV03')
INSERT [dbo].[HoaDonXuat] ([MaHoaDon], [MaKH], [NgayXuat], [MaNVXuat]) VALUES (N'HDX04', N'KH04', CAST(N'2018-05-05' AS Date), N'NV04')
INSERT [dbo].[HoaDonXuat] ([MaHoaDon], [MaKH], [NgayXuat], [MaNVXuat]) VALUES (N'HDX05', N'KH06', CAST(N'2018-05-05' AS Date), N'NV06')
INSERT [dbo].[HoaDonXuat] ([MaHoaDon], [MaKH], [NgayXuat], [MaNVXuat]) VALUES (N'HDX06', N'KH08', CAST(N'2018-05-05' AS Date), N'NV05')
INSERT [dbo].[HoaDonXuat] ([MaHoaDon], [MaKH], [NgayXuat], [MaNVXuat]) VALUES (N'HDX07', N'KH09', CAST(N'2018-05-05' AS Date), N'NV07')
INSERT [dbo].[HoaDonXuat] ([MaHoaDon], [MaKH], [NgayXuat], [MaNVXuat]) VALUES (N'HDX08', N'KH07', CAST(N'2018-05-05' AS Date), N'NV08')
INSERT [dbo].[HoaDonXuat] ([MaHoaDon], [MaKH], [NgayXuat], [MaNVXuat]) VALUES (N'HDX09', N'KH10', CAST(N'2018-05-05' AS Date), N'NV09')
INSERT [dbo].[HoaDonXuat] ([MaHoaDon], [MaKH], [NgayXuat], [MaNVXuat]) VALUES (N'HDX10', N'KH04', CAST(N'2018-05-05' AS Date), N'NV10')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DiaChi], [SDT]) VALUES (N'KH01', N'Nguyễn Văn Giáp', N'Hà Nội', N'01674540999')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DiaChi], [SDT]) VALUES (N'KH02', N'Bùi Kim Quyên', N'Hà Nội ', N'01673452098')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DiaChi], [SDT]) VALUES (N'KH03', N'Dương Hoài Phương', N'Nam Định', N'01674357766')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DiaChi], [SDT]) VALUES (N'KH04', N'Võ Minh Thư', N'Bắc Ninh', N'01643231110')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DiaChi], [SDT]) VALUES (N'KH05', N'Nguyễn Thế Vinh', N'Đà Lạt', N'0987262321')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DiaChi], [SDT]) VALUES (N'KH06', N'Đào Thanh Tú', N'Đà Nẵng', N'0983617372')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DiaChi], [SDT]) VALUES (N'KH07', N'Hoàng Thị Hằng', N'Bắc Giang', N'01647727264')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DiaChi], [SDT]) VALUES (N'KH08', N'Phan Thị Hạnh', N'Ninh Bình', N'0953725347')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DiaChi], [SDT]) VALUES (N'KH09', N'Trương Bá Quân', N'Vĩnh Phúc', N'0935275127')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DiaChi], [SDT]) VALUES (N'KH10', N'Lê Minh Vương', N'Nha Trang', N'0985362527')
INSERT [dbo].[LoaiThuoc] ([MaLoaiThuoc], [TenLoaiThuoc], [GhiChu]) VALUES (N'LT01', N'Kháng Sinh', N'Dạng Viên')
INSERT [dbo].[LoaiThuoc] ([MaLoaiThuoc], [TenLoaiThuoc], [GhiChu]) VALUES (N'LT02', N'Giảm đau', N'Dạng Viên')
INSERT [dbo].[LoaiThuoc] ([MaLoaiThuoc], [TenLoaiThuoc], [GhiChu]) VALUES (N'LT03', N'Giảm cân', N'Dạng Viên')
INSERT [dbo].[LoaiThuoc] ([MaLoaiThuoc], [TenLoaiThuoc], [GhiChu]) VALUES (N'LT04', N'An Thần', N'Dạng Viên')
INSERT [dbo].[LoaiThuoc] ([MaLoaiThuoc], [TenLoaiThuoc], [GhiChu]) VALUES (N'LT05', N'Virus', N'Dung dịch tiêm')
INSERT [dbo].[LoaiThuoc] ([MaLoaiThuoc], [TenLoaiThuoc], [GhiChu]) VALUES (N'LT06', N'Tim Mạch', N'Dạng Viên')
INSERT [dbo].[LoaiThuoc] ([MaLoaiThuoc], [TenLoaiThuoc], [GhiChu]) VALUES (N'LT07', N'Thuốc ho', N'Dạng Viên')
INSERT [dbo].[LoaiThuoc] ([MaLoaiThuoc], [TenLoaiThuoc], [GhiChu]) VALUES (N'LT08', N'Thuốc co giật', N'Dung dịch tiêm')
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [SDT], [DiaChi]) VALUES (N'NCC01', N'Công Ty An Khang', N'01676517647', N'Hà Nội')
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [SDT], [DiaChi]) VALUES (N'NCC02', N'Công Ty Cổ phần Việt Pháp', N'01658216427', N'Bắc Giang')
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [SDT], [DiaChi]) VALUES (N'NCC03', N'Công Ty Thuốc Tây', N'01672836472', N'Hà Nội')
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [SDT], [DiaChi]) VALUES (N'NCC04', N'Công Ty Thuốc Đông y', N'01679869899', N'Bắc Giang')
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [SDT], [DiaChi]) VALUES (N'NCC05', N'Công ty Thuốc Bắc', N'0878217463', N'Bắc Giang')
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [SDT], [DiaChi]) VALUES (N'NCC06', N'Công ty Zco', N'0986721546', N'Hà Nội')
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [SDT], [DiaChi]) VALUES (N'NCC07', N'Công Ty Nha Khoa', N'0973673422', N'Nha Trang')
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [SDT], [DiaChi]) VALUES (N'NCC08', N'Công ty Phân Phối Dược', N'01677343983', N'Hà Nội')
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [SDT], [DiaChi]) VALUES (N'NCC09', N'Công Ty Thịnh Thế', N'01681263743', N'Băc Ninh')
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [SDT], [DiaChi]) VALUES (N'NCC10', N'Công ty Thuốc ung thư', N'01682364573', N'Hà Nội')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [MaCS], [GioiTinh], [NgaySinh], [SDT], [DiaChi]) VALUES (N'NV01', N'Thạch Thùy Chinh', N'CS01', 0, CAST(N'1997-10-10' AS Date), N'01654005160', N'Hà Nội')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [MaCS], [GioiTinh], [NgaySinh], [SDT], [DiaChi]) VALUES (N'NV02', N'Đỗ Thị Kiều Anh', N'CS02', 0, CAST(N'1997-02-03' AS Date), N'01659274736', N'Nam Định')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [MaCS], [GioiTinh], [NgaySinh], [SDT], [DiaChi]) VALUES (N'NV03', N'Nguyễn Thị Ngọc Ánh', N'CS03', 0, CAST(N'1997-10-03' AS Date), N'01679274782', N'Bắc Giang')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [MaCS], [GioiTinh], [NgaySinh], [SDT], [DiaChi]) VALUES (N'NV04', N'Đặng Lương Hiếu', N'CS04', 1, CAST(N'1997-10-04' AS Date), N'01679247346', N'Nha Trang')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [MaCS], [GioiTinh], [NgaySinh], [SDT], [DiaChi]) VALUES (N'NV05', N'Quách Đức Bình', N'CS05', 1, CAST(N'1997-01-01' AS Date), N'0963716733', N'Hải Dương')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [MaCS], [GioiTinh], [NgaySinh], [SDT], [DiaChi]) VALUES (N'NV06', N'Hà Thị Thu Giang', N'CS06', 0, CAST(N'1997-07-08' AS Date), N'0981876373', N'Quảng Ninh')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [MaCS], [GioiTinh], [NgaySinh], [SDT], [DiaChi]) VALUES (N'NV07', N'Cao Xuân Tuấn', N'CS07', 1, CAST(N'1997-10-06' AS Date), N'0947274627', N'Bắc Ninh')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [MaCS], [GioiTinh], [NgaySinh], [SDT], [DiaChi]) VALUES (N'NV08', N'Phạm Anh Đức', N'CS08', 1, CAST(N'1997-10-07' AS Date), N'01672753725', N'Thanh Hóa')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [MaCS], [GioiTinh], [NgaySinh], [SDT], [DiaChi]) VALUES (N'NV09', N'Vũ Mạnh Tuấn', N'CS09', 1, CAST(N'1997-01-08' AS Date), N'01672736263', N'Phú Thọ')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [MaCS], [GioiTinh], [NgaySinh], [SDT], [DiaChi]) VALUES (N'NV10', N'Vũ Duy Đạt', N'CS10', 1, CAST(N'1997-09-09' AS Date), N'01688626745', NULL)
INSERT [dbo].[Thuoc] ([MaThuoc], [TenThuoc], [MaLoaiThuoc], [MaDVSX], [CongDung], [HSD], [SoLuong], [NuocSX]) VALUES (N'T01', N'Thuốc Xenetix', N'LT01', N'NCC01', N'Trị giảm đau', N'3-3-2030', 2000, N'MỸ')
INSERT [dbo].[Thuoc] ([MaThuoc], [TenThuoc], [MaLoaiThuoc], [MaDVSX], [CongDung], [HSD], [SoLuong], [NuocSX]) VALUES (N'T02', N'Thuốc Tetracyckine', N'LT03', N'NCC02', N'Trị Viêm nang', N'3-3-2030', 2000, N'ANH')
INSERT [dbo].[Thuoc] ([MaThuoc], [TenThuoc], [MaLoaiThuoc], [MaDVSX], [CongDung], [HSD], [SoLuong], [NuocSX]) VALUES (N'T03', N'Thuốc Timilol', N'LT03', N'NCC03', N'Đau Mắt', N'3-3-2030', 2000, N'Hàn Quốc')
INSERT [dbo].[Thuoc] ([MaThuoc], [TenThuoc], [MaLoaiThuoc], [MaDVSX], [CongDung], [HSD], [SoLuong], [NuocSX]) VALUES (N'T04', N'Thuốc Neurontin ', N'LT04', N'NCC04', N'Viêm nang', N'3-3-2030', 2000, N'Việt nam')
INSERT [dbo].[Thuoc] ([MaThuoc], [TenThuoc], [MaLoaiThuoc], [MaDVSX], [CongDung], [HSD], [SoLuong], [NuocSX]) VALUES (N'T05', N'Thuốc Vinsamin ', N'LT02', N'NCC05', N'Viêm nang', N'3-3-2030', 2000, N'Trung Quốc')
INSERT [dbo].[Thuoc] ([MaThuoc], [TenThuoc], [MaLoaiThuoc], [MaDVSX], [CongDung], [HSD], [SoLuong], [NuocSX]) VALUES (N'T06', N'Paladol', N'LT06', N'NCC06', N'Trị đau đầu', N'3-3-2030', 2000, N'Lào')
INSERT [dbo].[Thuoc] ([MaThuoc], [TenThuoc], [MaLoaiThuoc], [MaDVSX], [CongDung], [HSD], [SoLuong], [NuocSX]) VALUES (N'T07', N'Thuốc Oliza', N'LT07', N'NCC07', N'Trị viêm nén', N'3-3-2030', 2000, N'Đức')
INSERT [dbo].[Thuoc] ([MaThuoc], [TenThuoc], [MaLoaiThuoc], [MaDVSX], [CongDung], [HSD], [SoLuong], [NuocSX]) VALUES (N'T08', N'Vitamin D', N'LT08', N'NCC08', N'Bổ sung vitamin D', N'3-3-2030', 2000, N'Hà Lan')
INSERT [dbo].[Thuoc] ([MaThuoc], [TenThuoc], [MaLoaiThuoc], [MaDVSX], [CongDung], [HSD], [SoLuong], [NuocSX]) VALUES (N'T09', N'Tramadol ', N'LT06', N'NCC09', N'Giảm đau', N'3-3-2030', 2000, N'Singabo')
INSERT [dbo].[Thuoc] ([MaThuoc], [TenThuoc], [MaLoaiThuoc], [MaDVSX], [CongDung], [HSD], [SoLuong], [NuocSX]) VALUES (N'T10', N'Cefdinir', N'LT05', N'NCC10', N'Kháng Sinh', N'3-3-2030', 2000, N'Tây Ban Nha')
ALTER TABLE [dbo].[ChiTietHoaDonNhap]  WITH CHECK ADD FOREIGN KEY([MaHDN])
REFERENCES [dbo].[HoaDonNhap] ([MaHoaDon])
GO
ALTER TABLE [dbo].[ChiTietHoaDonNhap]  WITH CHECK ADD FOREIGN KEY([MaThuoc])
REFERENCES [dbo].[Thuoc] ([MaThuoc])
GO
ALTER TABLE [dbo].[ChiTietHoaDonXuat]  WITH CHECK ADD FOREIGN KEY([MaHDX])
REFERENCES [dbo].[HoaDonXuat] ([MaHoaDon])
GO
ALTER TABLE [dbo].[ChiTietHoaDonXuat]  WITH CHECK ADD FOREIGN KEY([MaThuoc])
REFERENCES [dbo].[Thuoc] ([MaThuoc])
GO
ALTER TABLE [dbo].[HoaDonNhap]  WITH CHECK ADD FOREIGN KEY([MaNCC])
REFERENCES [dbo].[NhaCungCap] ([MaNCC])
GO
ALTER TABLE [dbo].[HoaDonNhap]  WITH CHECK ADD FOREIGN KEY([MaNVNhap])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[HoaDonXuat]  WITH CHECK ADD FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachHang] ([MaKH])
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD FOREIGN KEY([MaCS])
REFERENCES [dbo].[CoSo] ([MaCS])
GO
ALTER TABLE [dbo].[Thuoc]  WITH CHECK ADD FOREIGN KEY([MaDVSX])
REFERENCES [dbo].[NhaCungCap] ([MaNCC])
GO
ALTER TABLE [dbo].[Thuoc]  WITH CHECK ADD FOREIGN KEY([MaLoaiThuoc])
REFERENCES [dbo].[LoaiThuoc] ([MaLoaiThuoc])
GO
USE [master]
GO
ALTER DATABASE [QLThuoc] SET  READ_WRITE 
GO
