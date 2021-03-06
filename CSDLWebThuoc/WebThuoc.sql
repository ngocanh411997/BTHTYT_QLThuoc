USE [master]
GO
/****** Object:  Database [WebThuoc]    Script Date: 6/26/2018 9:15:50 PM ******/
CREATE DATABASE [WebThuoc]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'WebThuoc', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.NGOCANH\MSSQL\DATA\WebThuoc.mdf' , SIZE = 3264KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'WebThuoc_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.NGOCANH\MSSQL\DATA\WebThuoc_log.ldf' , SIZE = 832KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [WebThuoc] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [WebThuoc].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [WebThuoc] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [WebThuoc] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [WebThuoc] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [WebThuoc] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [WebThuoc] SET ARITHABORT OFF 
GO
ALTER DATABASE [WebThuoc] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [WebThuoc] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [WebThuoc] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [WebThuoc] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [WebThuoc] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [WebThuoc] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [WebThuoc] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [WebThuoc] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [WebThuoc] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [WebThuoc] SET  ENABLE_BROKER 
GO
ALTER DATABASE [WebThuoc] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [WebThuoc] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [WebThuoc] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [WebThuoc] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [WebThuoc] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [WebThuoc] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [WebThuoc] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [WebThuoc] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [WebThuoc] SET  MULTI_USER 
GO
ALTER DATABASE [WebThuoc] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [WebThuoc] SET DB_CHAINING OFF 
GO
ALTER DATABASE [WebThuoc] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [WebThuoc] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [WebThuoc] SET DELAYED_DURABILITY = DISABLED 
GO
USE [WebThuoc]
GO
/****** Object:  Table [dbo].[ChiTietDonHang]    Script Date: 6/26/2018 9:15:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietDonHang](
	[MaDonHang] [int] NOT NULL,
	[MaThuoc] [int] NOT NULL,
	[SoLuong] [int] NULL,
	[DonGia] [decimal](18, 0) NULL,
 CONSTRAINT [PK__ChiTietD__062E9BCFD66860A0] PRIMARY KEY CLUSTERED 
(
	[MaDonHang] ASC,
	[MaThuoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DanhMuc]    Script Date: 6/26/2018 9:15:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DanhMuc](
	[MaDM] [int] IDENTITY(1,1) NOT NULL,
	[TenDM] [nvarchar](100) NULL,
 CONSTRAINT [PK__DanhMuc__2725866E2FE26B87] PRIMARY KEY CLUSTERED 
(
	[MaDM] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DonHang]    Script Date: 6/26/2018 9:15:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DonHang](
	[MaDonHang] [int] IDENTITY(1,1) NOT NULL,
	[DaThanhToan] [int] NULL,
	[TinhTrangGiaoHang] [int] NULL,
	[NgayDat] [datetime] NULL,
	[NgayGiao] [datetime] NULL,
	[MaKH] [int] NULL,
 CONSTRAINT [PK__DonHang__129584ADAC106A5E] PRIMARY KEY CLUSTERED 
(
	[MaDonHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 6/26/2018 9:15:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKH] [int] IDENTITY(1,1) NOT NULL,
	[HoTen] [nvarchar](50) NULL,
	[TaiKhoan] [varchar](50) NULL,
	[MatKhau] [nvarchar](50) NULL,
	[Email] [nvarchar](100) NULL,
	[DiaChi] [nvarchar](200) NULL,
	[DienThoai] [varchar](50) NULL,
	[GioiTinh] [nvarchar](3) NULL,
	[NgaySinh] [datetime] NULL,
 CONSTRAINT [PK__KhachHan__2725CF1E8127F341] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 6/26/2018 9:15:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[Username] [varchar](150) NOT NULL,
	[Pass] [varchar](150) NULL,
	[FullName] [nvarchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[Username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Thuoc]    Script Date: 6/26/2018 9:15:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Thuoc](
	[MaThuoc] [int] IDENTITY(1,1) NOT NULL,
	[TenThuoc] [nvarchar](200) NULL,
	[GiaBan] [decimal](18, 0) NULL,
	[MoTa] [nvarchar](max) NULL,
	[AnhBia] [nvarchar](50) NULL,
	[NgayCapNhat] [datetime] NULL,
	[SoLuongTon] [int] NULL,
	[MaTH] [int] NULL,
	[MaDM] [int] NULL,
 CONSTRAINT [PK__Thuoc__4BB1F62001E6CB8D] PRIMARY KEY CLUSTERED 
(
	[MaThuoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ThuongHieu]    Script Date: 6/26/2018 9:15:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThuongHieu](
	[MaTH] [int] IDENTITY(1,1) NOT NULL,
	[TenTH] [nvarchar](100) NULL,
	[DiaChi] [nvarchar](200) NULL,
 CONSTRAINT [PK__ThuongHi__27250075E5A8D990] PRIMARY KEY CLUSTERED 
(
	[MaTH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[DanhMuc] ON 

INSERT [dbo].[DanhMuc] ([MaDM], [TenDM]) VALUES (1, N'Thực phẩm chức năng')
INSERT [dbo].[DanhMuc] ([MaDM], [TenDM]) VALUES (2, N'Tinh dầu')
INSERT [dbo].[DanhMuc] ([MaDM], [TenDM]) VALUES (3, N'Thực phẩm giảm cân, ăn kiêng')
INSERT [dbo].[DanhMuc] ([MaDM], [TenDM]) VALUES (4, N'Hỗ trợ điều trị ung thư, ung bướu')
INSERT [dbo].[DanhMuc] ([MaDM], [TenDM]) VALUES (5, N'Làm đẹp, chống lão hóa')
INSERT [dbo].[DanhMuc] ([MaDM], [TenDM]) VALUES (6, N'Sức khỏe trẻ em')
SET IDENTITY_INSERT [dbo].[DanhMuc] OFF
SET IDENTITY_INSERT [dbo].[KhachHang] ON 

INSERT [dbo].[KhachHang] ([MaKH], [HoTen], [TaiKhoan], [MatKhau], [Email], [DiaChi], [DienThoai], [GioiTinh], [NgaySinh]) VALUES (1, N'Nguyễn Văn Quyết', N'Quyet', N'quyet123', N'Quyet@gmail.com', N'Hà Nội', N'0987348576', N'Nam', CAST(N'1994-03-04 00:00:00.000' AS DateTime))
INSERT [dbo].[KhachHang] ([MaKH], [HoTen], [TaiKhoan], [MatKhau], [Email], [DiaChi], [DienThoai], [GioiTinh], [NgaySinh]) VALUES (2, N'Đào Mạnh Cường', N'Cuong', N'cuong123', N'Cuong@gmail.com', N'Hà Nam', N'0938459234', N'Nam', CAST(N'1996-08-20 00:00:00.000' AS DateTime))
INSERT [dbo].[KhachHang] ([MaKH], [HoTen], [TaiKhoan], [MatKhau], [Email], [DiaChi], [DienThoai], [GioiTinh], [NgaySinh]) VALUES (3, N'Nguyễn Thị Nhung', N'Nhung', N'nhung123', N'Nhung@gmail.com', N'Quảng Ninh', N'0982345876', N'Nữ', CAST(N'1992-03-19 00:00:00.000' AS DateTime))
INSERT [dbo].[KhachHang] ([MaKH], [HoTen], [TaiKhoan], [MatKhau], [Email], [DiaChi], [DienThoai], [GioiTinh], [NgaySinh]) VALUES (4, N'Trần Hồng Hoa', N'Hoa', N'hoa123', N'Hoa@gmail.com', N'Nam Định', N'0923876238', N'Nữ', CAST(N'1996-03-02 00:00:00.000' AS DateTime))
INSERT [dbo].[KhachHang] ([MaKH], [HoTen], [TaiKhoan], [MatKhau], [Email], [DiaChi], [DienThoai], [GioiTinh], [NgaySinh]) VALUES (5, N'Trịnh Văn Minh', N'Minh', N'minh123', N'Minh@gmail.com', N'Phú Thọ', N'0923875294', N'Nam', CAST(N'1998-02-03 00:00:00.000' AS DateTime))
INSERT [dbo].[KhachHang] ([MaKH], [HoTen], [TaiKhoan], [MatKhau], [Email], [DiaChi], [DienThoai], [GioiTinh], [NgaySinh]) VALUES (6, N'Lê Mạnh Đình ', N'Dinh', N'dinh123', N'Dinh@gmail.com', N'Hải Dương', N'0982394329', N'Nam', CAST(N'1992-05-09 00:00:00.000' AS DateTime))
INSERT [dbo].[KhachHang] ([MaKH], [HoTen], [TaiKhoan], [MatKhau], [Email], [DiaChi], [DienThoai], [GioiTinh], [NgaySinh]) VALUES (7, N'Quách Đức Bình', N'Binh', N'binh123', N'Binh@gmail.com', N'Hà Nội', N'0918394384', N'Nam', CAST(N'1997-07-03 00:00:00.000' AS DateTime))
INSERT [dbo].[KhachHang] ([MaKH], [HoTen], [TaiKhoan], [MatKhau], [Email], [DiaChi], [DienThoai], [GioiTinh], [NgaySinh]) VALUES (8, N'Bùi Trung Kiên', N'Kien', N'kien123', N'Kien@gmail.com', N'Hà Nội', N'0982743923', N'Nam', CAST(N'1997-12-08 00:00:00.000' AS DateTime))
INSERT [dbo].[KhachHang] ([MaKH], [HoTen], [TaiKhoan], [MatKhau], [Email], [DiaChi], [DienThoai], [GioiTinh], [NgaySinh]) VALUES (9, N'Nguyễn Thị Ngọc Ánh', N'Anh', N'anh123', N'Anh@gmail.com', N'Hà Nội', N'0982743823', N'Nữ', CAST(N'1997-01-04 00:00:00.000' AS DateTime))
INSERT [dbo].[KhachHang] ([MaKH], [HoTen], [TaiKhoan], [MatKhau], [Email], [DiaChi], [DienThoai], [GioiTinh], [NgaySinh]) VALUES (10, N'Hoàng Thị Hằng', N'Hang', N'hang123', N'Hang@gmail.com', N'Bắc Giang', N'0973923747', N'Nữ', CAST(N'1997-01-11 00:00:00.000' AS DateTime))
INSERT [dbo].[KhachHang] ([MaKH], [HoTen], [TaiKhoan], [MatKhau], [Email], [DiaChi], [DienThoai], [GioiTinh], [NgaySinh]) VALUES (11, N'Thạch Thùy Chinh', N'Chinh', N'chinh123', N'Chinh@gmail.com', N'Hà Nam', N'0982403483', N'Nữ', CAST(N'1997-03-28 00:00:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[KhachHang] OFF
INSERT [dbo].[TaiKhoan] ([Username], [Pass], [FullName]) VALUES (N'admin', N'admin', N'Administrator')
SET IDENTITY_INSERT [dbo].[Thuoc] ON 

INSERT [dbo].[Thuoc] ([MaThuoc], [TenThuoc], [GiaBan], [MoTa], [AnhBia], [NgayCapNhat], [SoLuongTon], [MaTH], [MaDM]) VALUES (1, N'X7-CARE - DINH DƯỠNG ĐẶC BIỆT CHO NGƯỜI MẮC VẤN ĐỀ VỀ ĐĨA ĐỆM', CAST(580000 AS Decimal(18, 0)), N'Tăng cường tái tạo sụn, hỗ trợ sản sinh chất hoạt dịch cho khớp, tăng tổng hợp Canxi cho xương và chống viêm xương khớp. X7-CARE tác động toàn diện trên sức khoẻ xương khớp, ngăn ngừa thoát vị đĩa đệm, hỗ trợ cho người bị các vấn đề về đĩa đệm; giúp tăng tái tạo sụn, tiết dịch khớp, giảm khô khớp, thoái hóa xương khớp, giảm tình trạng viêm, sưng đau các khớp, giúp vận động dễ dàng, linh hoạt.', N'1.jpg', NULL, 100, 1, 1)
INSERT [dbo].[Thuoc] ([MaThuoc], [TenThuoc], [GiaBan], [MoTa], [AnhBia], [NgayCapNhat], [SoLuongTon], [MaTH], [MaDM]) VALUES (2, N'BABY PLEX 45ML - BỔ SUNG VITAMIN TỔNG HỢP CHO TRẺ NHỎ', CAST(390000 AS Decimal(18, 0)), N'Sản phẩm dành cho trẻ từ 0-4 tuổi. Hỗ trợ trẻ ăn ngon, hệ tiêu hóa khoẻ, tăng khả năng hấp thụ, tăng cường sức đề kháng, chống còi xương, chậm lớn. Sản phẩm đạt chuẩn của Cục quản lý Thực phẩm và dược phẩm Hoa Kỳ.', N'2.jpg', NULL, 100, 2, 1)
INSERT [dbo].[Thuoc] ([MaThuoc], [TenThuoc], [GiaBan], [MoTa], [AnhBia], [NgayCapNhat], [SoLuongTon], [MaTH], [MaDM]) VALUES (3, N'F1 CARE COMPLEX- VITAMIN TỔNG HỢP SỐ 1 CHO BÀ BẦU', CAST(350000 AS Decimal(18, 0)), N'F1-CARE COMPLEX là sản phẩm bổ sung các vitamin và các nguyên tố vi lượng cần thiết trong thai kì, giúp mẹ và bé khỏe mạnh, ngăn ngừa dị tật bẩm sinh, kích thích sự phát triển não trẻ. Đồng thời giảm các triệu chứng nghén trong đoạn đầu thai kì, hỗ trợ ngăn ngừa gout và tiểu đường thai kỳ', N'3.jpg', NULL, 200, 1, 1)
INSERT [dbo].[Thuoc] ([MaThuoc], [TenThuoc], [GiaBan], [MoTa], [AnhBia], [NgayCapNhat], [SoLuongTon], [MaTH], [MaDM]) VALUES (4, N'COMBO 2 HỘP F1 CARE COMPLEX- VITAMIN TỔNG HỢP SỐ 1 CHO BÀ BẦU', CAST(700000 AS Decimal(18, 0)), N'F1-CARE COMPLEX là sản phẩm bổ sung các vitamin và các nguyên tố vi lượng cần thiết trong thai kì, giúp mẹ và bé khỏe mạnh, ngăn ngừa dị tật bẩm sinh, kích thích sự phát triển não trẻ. Đồng thời giảm các triệu chứng nghén trong đoạn đầu thai kì, hỗ trợ ngăn ngừa gout và tiểu đường thai kỳ.', N'4.jpg', NULL, 150, 1, 1)
INSERT [dbo].[Thuoc] ([MaThuoc], [TenThuoc], [GiaBan], [MoTa], [AnhBia], [NgayCapNhat], [SoLuongTon], [MaTH], [MaDM]) VALUES (5, N'ALPHA BRAIN - VIÊN UỐNG BỔ NÃO, HỖ TRỢ TUẦN HOÀN NÃO', CAST(390000 AS Decimal(18, 0)), N'Alpha Brain được sản xuất bởi thương hiệu nổi tiếng Olympian Labs của Mỹ có khả năng hỗ trợ tăng cường tuần hoàn não, trung hòa gốc tự do, hỗ trợ đẩy lùi các hiện tượng liên quan đến tiền đình như đau đầu, chóng mặt, hoa mắt; cải thiện trí nhớ, nhận thức và giúp phòng chống teo não, đột quỵ.', N'5.jpg', NULL, 120, 1, 1)
INSERT [dbo].[Thuoc] ([MaThuoc], [TenThuoc], [GiaBan], [MoTa], [AnhBia], [NgayCapNhat], [SoLuongTon], [MaTH], [MaDM]) VALUES (6, N'TINH DẦU CÁ SARDINE NHẬT (300 VIÊN)', CAST(1870000 AS Decimal(18, 0)), N'<p>Chiết xuất 100% từ c&aacute; Sardine ở Nhật, sử dụng quy tr&igrave;nh chiết xuất kh&ocirc;ng gia nhiệt , kh&ocirc;ng chất phụ gia, AOZA gi&uacute;p cung cấp những dưỡng chất kh&ocirc;ng thể thiếu cho một cơ thể khỏe mạnh.</p>', N'6.jpg', NULL, 100, 16, 4)
INSERT [dbo].[Thuoc] ([MaThuoc], [TenThuoc], [GiaBan], [MoTa], [AnhBia], [NgayCapNhat], [SoLuongTon], [MaTH], [MaDM]) VALUES (7, N'PROSPLEX FOR MEN - TIỀN LIỆT TUYẾN', CAST(750000 AS Decimal(18, 0)), N'Prospex for men của Olympian Labs là một trong những sản phẩm được ưa chuộng hàng đầu tại Mỹ và trên toàn thế giới trong việc hỗ trợ phòng ngừa chứng rối loạn cương dương, duy trì sức khỏe tuyến tiền liệt và phòng chống ung thư tiền liệt tuyến, đảm bảo liều lượng kích thích tố sinh dục nam và sức khỏe sinh lý của nam giới.', N'7.jpg', NULL, 160, 1, 1)
INSERT [dbo].[Thuoc] ([MaThuoc], [TenThuoc], [GiaBan], [MoTa], [AnhBia], [NgayCapNhat], [SoLuongTon], [MaTH], [MaDM]) VALUES (8, N'NUTRA - VISION CHO ĐÔI MẮT KHỎE MẠNH 30 VIÊN', CAST(350000 AS Decimal(18, 0)), N'Nutra-Vision là một trong những sản phẩm được ưa chuộng hàng đầu tại Mỹ và trên toàn thế giới trong việc cung cấp các chất dinh dưỡng để duy trì đôi mắt khỏe mạnh. Nutra-Vision là một công thức có chứa các vitamin, các khoáng chất, các thảo dược cơ bản và cần thiết đối với sức khỏe mắt, giúp bạn luôn có đôi mắt khỏe, đẹp tự nhiên.', N'8.jpg', NULL, 100, 1, 1)
INSERT [dbo].[Thuoc] ([MaThuoc], [TenThuoc], [GiaBan], [MoTa], [AnhBia], [NgayCapNhat], [SoLuongTon], [MaTH], [MaDM]) VALUES (9, N'GREEN CALCIUM - BỔ SUNG CANXI HỮU CƠ CHO BÀ BẦU', CAST(450000 AS Decimal(18, 0)), N'Green calcium bổ sung canxi hữu cơ trước và trong thai kỳ và sau sinh. Green calcium chứa calcium gluconate - Loại canxi tốt nhất cho bà bầu, giúp đáp ứng đủ lượng canxi tăng lên cần thiết trong thai kì và phòng tránh loãng xương phụ nữ sau mang thai.', N'9.jpg', NULL, 130, 1, 1)
INSERT [dbo].[Thuoc] ([MaThuoc], [TenThuoc], [GiaBan], [MoTa], [AnhBia], [NgayCapNhat], [SoLuongTon], [MaTH], [MaDM]) VALUES (10, N'LIVER DETOX - GIẢI ĐỘC GAN CHO LÁ GAN KHỎE MẠNH', CAST(390000 AS Decimal(18, 0)), N'LIVER DETOX là sản phẩm chuyên biệt được Olympian Labs nghiên cứu và sản xuất dành cho các đối tượng có các vấn đề về gan. Sản phẩm được sản xuất tại Mỹ, đạt tiêu chuẩn GMP, mang lại hiệu quả cao và an toàn.', N'10.jpg', NULL, 100, 1, 1)
INSERT [dbo].[Thuoc] ([MaThuoc], [TenThuoc], [GiaBan], [MoTa], [AnhBia], [NgayCapNhat], [SoLuongTon], [MaTH], [MaDM]) VALUES (11, N'FISH OIL (SALMON OIL) - 100 VIÊN', CAST(420000 AS Decimal(18, 0)), N'Fish Oil giúp bổ sung DHA cho não, tăng cường sự phát triển của não bộ ở người trẻ tuổi, ngăn chăn sự lão hóa não, cải thiện trí nhớ, tăng thị lực, sáng mắt. Ngoài ra, bổ sung EPA giúp hỗ trợ giảm Cholesterol trong máu, ngăn ngừa tình trạng xơ vữa động mạch, giúp tuần hoàn thông thoáng, giảm nguy cơ nhồi máu cơ tim, xương khớp.', N'11.jpg', NULL, 100, 4, 1)
INSERT [dbo].[Thuoc] ([MaThuoc], [TenThuoc], [GiaBan], [MoTa], [AnhBia], [NgayCapNhat], [SoLuongTon], [MaTH], [MaDM]) VALUES (12, N'BE FOLIC ACID - BỔ SUNG AXIT FOLIC CHO BÀ BẦU', CAST(310000 AS Decimal(18, 0)), N'Be - Folic Acid là sản phẩm dạng viên uống bổ sung Vitamin B9 cho phụ nữ mang thai. Sản phẩm bổ sung đủ lượng axit folic cần thiết cho mẹ bầu phòng tránh tình trạng thiếu máu, ngăn ngừa nguy cơ dị tật bẩm sinh ở thai nhi.', N'12.jpg', NULL, 100, 1, 1)
INSERT [dbo].[Thuoc] ([MaThuoc], [TenThuoc], [GiaBan], [MoTa], [AnhBia], [NgayCapNhat], [SoLuongTon], [MaTH], [MaDM]) VALUES (13, N'DẦU GỪNG THÁI DƯƠNG 24ML', CAST(65000 AS Decimal(18, 0)), N'Theo tài liệu cổ, Gừng có vị cay, tính ôn, có tác dụng phát biểu, tán hàn, ôn trung, làm hết nôn, tiêu đờm, hành thủy, giải độc, dùng để chữa ngoại cảm, biểu chứng, bụng đầy trướng, nôn mửa, ỉa chảy, chân tay lạnh...Trong dân gian, Gừng là vị thuốc nam không thể thiếu để giải cảm, đánh cảm, ngâm chân tay ngừa cảm lạnh, phong thấp...', N'13.jpg', NULL, 100, 5, 1)
INSERT [dbo].[Thuoc] ([MaThuoc], [TenThuoc], [GiaBan], [MoTa], [AnhBia], [NgayCapNhat], [SoLuongTon], [MaTH], [MaDM]) VALUES (14, N'KHỚP VẸM XANH - NZ GREEN MUSSEL', CAST(380000 AS Decimal(18, 0)), N'Sản phẩm hỗ trợ sụn khớp khỏe mạnh, tăng cường chất dịch và tăng cường sản sinh collagen sụn khớp. Với các thành phần chính chiết xuất từ Mussel – green lipped và Glucosamine hydrochloride, viên nén bổ khớp NZ Green Mussel giúp người bệnh giảm các cơn đau do viêm khớp đầu gối, hông, bả vai và lưng gây ra, giảm sự thoái hóa khớp và tăng quá trình sản xuất sụn.', N'14.jpg', NULL, 100, 4, 1)
INSERT [dbo].[Thuoc] ([MaThuoc], [TenThuoc], [GiaBan], [MoTa], [AnhBia], [NgayCapNhat], [SoLuongTon], [MaTH], [MaDM]) VALUES (15, N'AOZA - TINH DẦU CÁ SARDINE NHẬT (30 VIÊN)', CAST(180000 AS Decimal(18, 0)), N'Chiết xuất 100% từ cá Sardine ở Nhật, sử dụng quy trình chiết xuất không gia nhiệt , không chất phụ gia, AOZA giúp cung cấp những dưỡng chất không thể thiếu cho một cơ thể khỏe mạnh. Là sự kết hợp cân đối giữa các thành phần DHA, EPA, CoQ10, bổ sung thêm các thành phần có giá trị khác như vitamin A, vitamin E, AOZA', N'15.jpg', NULL, 100, 3, 1)
INSERT [dbo].[Thuoc] ([MaThuoc], [TenThuoc], [GiaBan], [MoTa], [AnhBia], [NgayCapNhat], [SoLuongTon], [MaTH], [MaDM]) VALUES (16, N'COQ10 - HỖ TRỢ SỨC KHỎE TIM MẠCH', CAST(270000 AS Decimal(18, 0)), N'CoQ10 60mg là công thức kết hợp tối ưu hai thành phần CoQ10 và tinh chất dầu oliu nguyên chất, giúp cải thiện chức năng tuần hoàn máu, tăng cường lưu thông máu, giúp điều hòa huyết áp, giảm mỡ máu, duy trì sức khỏe tim mạch và giúp bạn có một cơ thể khỏe mạnh.', N'16.jpg', NULL, 100, 1, 1)
INSERT [dbo].[Thuoc] ([MaThuoc], [TenThuoc], [GiaBan], [MoTa], [AnhBia], [NgayCapNhat], [SoLuongTon], [MaTH], [MaDM]) VALUES (17, N'TINH DẦU TRÀM 10 ML', CAST(169000 AS Decimal(18, 0)), N'Tinh dầu Tràm nguyên chất có rất nhiều công dụng tới sức khỏe của trẻ như: phòng chống và điều trị các vấn đề liên quan đến đường hô hấp dưới (viêm phế quản, viêm thanh quản, viêm phổi, hen phế quản, thở khò khè, hen suyễn...), Phòng cảm lạnh, cảm gió; Làm hết ngứa các vết muỗi đốt, kiến cắn...', N'17.jpg', NULL, 100, 6, 2)
INSERT [dbo].[Thuoc] ([MaThuoc], [TenThuoc], [GiaBan], [MoTa], [AnhBia], [NgayCapNhat], [SoLuongTon], [MaTH], [MaDM]) VALUES (18, N'TINH DẦU MASSAGE GIẢM BÉO', CAST(199000 AS Decimal(18, 0)), N'Tinh dầu massage giảm béo sự kết hợp hoàn hảo giữa tinh dầu gừng và tinh dầu bưởi chiết xuất 100% từ tự nhiên đạt tiêu chuẩn kiểm nghiệm của Bỉ. Mang lại hiệu quả cao trong quá trình giảm béo. Bạn có thể hoàn toàn yên tâm với phương pháp giảm béo này vì rất an toàn đối với sức khỏe của bạn.', N'18.jpg', NULL, 100, 6, 2)
INSERT [dbo].[Thuoc] ([MaThuoc], [TenThuoc], [GiaBan], [MoTa], [AnhBia], [NgayCapNhat], [SoLuongTon], [MaTH], [MaDM]) VALUES (19, N'TINH DẦU BABY ONE 10ML - TRỊ SỔ MŨI, NGẠT MŨI CHO BÉ', CAST(249000 AS Decimal(18, 0)), N'Baby One được chiết xuất hoàn toàn từ các loại tinh dầu thiên nhiên nguyên chất 100%, là sản phẩm hỗ trợ và điều trị chữa ngạt mũi, sổ mũi được các chuyên gia khuyên là an toàn cho bé.', N'19.jpg', NULL, 100, 6, 2)
INSERT [dbo].[Thuoc] ([MaThuoc], [TenThuoc], [GiaBan], [MoTa], [AnhBia], [NgayCapNhat], [SoLuongTon], [MaTH], [MaDM]) VALUES (20, N'COMBO TINH DẦU CÚC LA MÃ VÀ TINH DẦU BABY ONE', CAST(584000 AS Decimal(18, 0)), N'Sự kết hợp tuyệt vời của tinh dầu Cúc la mã và tinh dầu thiên nhiên Baby One sẽ mang lại những công dụng bất ngờ trong việc hỗ trợ điều trị các chứng sốt, sổ mũi, nghẹt mũi...đảm bảo an toàn trong việc sử dụng.', N'20.jpg', NULL, 100, 6, 2)
INSERT [dbo].[Thuoc] ([MaThuoc], [TenThuoc], [GiaBan], [MoTa], [AnhBia], [NgayCapNhat], [SoLuongTon], [MaTH], [MaDM]) VALUES (21, N'ĐÈN ĐIỆN ĐỐT TINH DẦU HOA ĐÀO', CAST(295000 AS Decimal(18, 0)), N'Sau một ngày học tập và làm việc, thật tuyệt vời khi được trở về căn nhà của mình và tận hưởng cảm giác thư giãn sảng khoái với hương thơm thoang thoảng của các loại tinh dầu. Và mỗi loại tinh dầu lại có một tác dụng khác nhau đối với cơ thể.', N'21.jpg', NULL, 50, 6, 2)
INSERT [dbo].[Thuoc] ([MaThuoc], [TenThuoc], [GiaBan], [MoTa], [AnhBia], [NgayCapNhat], [SoLuongTon], [MaTH], [MaDM]) VALUES (22, N'TINH DẦU MÀNG TANG', CAST(100000 AS Decimal(18, 0)), N'Tinh dầu Màng Tang giúp ngủ ngon, trấn an tinh thần, hỗ trợ điều hòa huyết áp, đuổi muỗi, côn trùng, hơn nữa làm đẹp da hiệu quả.', N'22.jpg', NULL, 100, 7, 2)
INSERT [dbo].[Thuoc] ([MaThuoc], [TenThuoc], [GiaBan], [MoTa], [AnhBia], [NgayCapNhat], [SoLuongTon], [MaTH], [MaDM]) VALUES (23, N'BỘ HAI TINH DẦU NƯỚC HOA ( QUYẾN RŨ, TINH TẾ, THƯ GIÃN)', CAST(195000 AS Decimal(18, 0)), N'Với 3 mùi hương nước hoa khác nhau (quyến rũ, tinh tế, thư giãn) phù hợp với mỗi người để thỏa sức lựa chọn, thể hiện cá tính và thư giãn. Có thể sử dụng trong các vị trí tủ quần áo,ôtô hoặc bàn làm việc.', N'23.jpg', NULL, 100, 7, 2)
INSERT [dbo].[Thuoc] ([MaThuoc], [TenThuoc], [GiaBan], [MoTa], [AnhBia], [NgayCapNhat], [SoLuongTon], [MaTH], [MaDM]) VALUES (24, N'TINH DẦU HỒI', CAST(239000 AS Decimal(18, 0)), N'Tinh dầu hồi có tác dụng chữa ho (đặc biệt là ho khan), hỗ trợ điều trị viêm phế quản, hen suyễn. Tăng sức đề kháng, chống lại bệnh tật. Giúp chữa đau bụng, hết đầy hơi.', N'24.jpg', NULL, 100, 7, 2)
INSERT [dbo].[Thuoc] ([MaThuoc], [TenThuoc], [GiaBan], [MoTa], [AnhBia], [NgayCapNhat], [SoLuongTon], [MaTH], [MaDM]) VALUES (25, N'ĐÈN ĐIỆN ĐỐT TINH DẦU MIỆNG LƯỢN', CAST(295000 AS Decimal(18, 0)), N'Đèn đốt tinh dầu miệng lượn với thiết kế độc đáo giúp căn phòng của bạn luôn tràn ngập hương thơm, tạo cảm giác thư thái thoải mái sau một ngày học tập và làm việc mệt mỏi.', N'25.jpg', NULL, 60, 6, 2)
INSERT [dbo].[Thuoc] ([MaThuoc], [TenThuoc], [GiaBan], [MoTa], [AnhBia], [NgayCapNhat], [SoLuongTon], [MaTH], [MaDM]) VALUES (26, N'ĐÈN ĐIỆN ĐỐT TINH DẦU DÁNG TIM VẼ MÀU', CAST(345000 AS Decimal(18, 0)), N'Đèn đốt tinh dầu dáng tim vẽ màu với thiết kế độc đáo giúp căn phòng của bạn luôn tràn ngập hương thơm, tạo cảm giác thư thái thoải mái sau một ngày học tập và làm việc mệt mỏi.', N'26.jpg', NULL, 60, 6, 2)
INSERT [dbo].[Thuoc] ([MaThuoc], [TenThuoc], [GiaBan], [MoTa], [AnhBia], [NgayCapNhat], [SoLuongTon], [MaTH], [MaDM]) VALUES (27, N'TINH DẦU HƯƠNG THANH KHIẾT – ĐỂ TRONG TỦ QUẦN ÁO', CAST(195000 AS Decimal(18, 0)), N'Tinh dầu hương thanh khiết là sự kết hợp hoàn hảo giữa tinh dầu sả chanh cùng một số loại tinh dầu thiên nhiên khác, được đặc chế dành riêng để tạo mùi thơm lâu và khử mùi hiệu quả cho tủ quần áo.', N'27.jpg', NULL, 60, 6, 2)
INSERT [dbo].[Thuoc] ([MaThuoc], [TenThuoc], [GiaBan], [MoTa], [AnhBia], [NgayCapNhat], [SoLuongTon], [MaTH], [MaDM]) VALUES (28, N'TINH DẦU Ô TÔ – HƯƠNG THƯ GIÃN', CAST(195000 AS Decimal(18, 0)), N'Tinh dầu nước hoa hương thư giãn giúp không gian trong ô tô trở nên thư thái, giảm bớt mùi động cơ, chống say xe, khử mùi hôi hiệu quả.', N'28.jpg', NULL, 60, 6, 2)
INSERT [dbo].[Thuoc] ([MaThuoc], [TenThuoc], [GiaBan], [MoTa], [AnhBia], [NgayCapNhat], [SoLuongTon], [MaTH], [MaDM]) VALUES (29, N'TINH DẦU HƯƠNG QUYẾN RŨ – DÙNG CHO BÀN LÀM VIỆC', CAST(195000 AS Decimal(18, 0)), N'Tinh dầu Ngọc Lan Tây được chọn là tông mùi cơ bản cho dòng sản phẩm tinh dầu hương quyến rũ. Được đặc chế dành riêng cho góc bàn làm việc, chỉ cần một lọ tinh dầu nhỏ xinh trên bàn cũng đủ để giúp một ngày làm việc của bạn trở nên thoải mái, dễ chịu và thư thái hơn.', N'29.jpg', NULL, 60, 6, 2)
INSERT [dbo].[Thuoc] ([MaThuoc], [TenThuoc], [GiaBan], [MoTa], [AnhBia], [NgayCapNhat], [SoLuongTon], [MaTH], [MaDM]) VALUES (30, N'
DẦU XOA BÓP', CAST(275000 AS Decimal(18, 0)), N'Dầu xoa bóp là hỗn hợp từ tinh dầu gừng, quế, hồi và dầu nền có tác dụng giảm nhanh các cơn đau cơ, đau xương do tập thể dục, thể thao, lao động quá sức gây ra; Hỗ trợ điều trị bệnh thấp khớp, viêm khớp, nhức mỏi vai gáy; Phòng và hỗ trợ điều trị đau lưng; Tăng cường tuần hoàn máu...', N'30.jpg', NULL, 56, 6, 2)
INSERT [dbo].[Thuoc] ([MaThuoc], [TenThuoc], [GiaBan], [MoTa], [AnhBia], [NgayCapNhat], [SoLuongTon], [MaTH], [MaDM]) VALUES (31, N'30 NIGHT DIET - HỖ TRỢ GIẢM CÂN BAN ĐÊM', CAST(99000 AS Decimal(18, 0)), N'30 NIGHT DIET của Creative Bioscience - thương hiệu giảm cân số 1 tại Mỹ, là sản phẩm giúp hỗ trợ giảm cân ban đêm tự nhiên và hiệu quả. 30 NIGHT DIET chứa các thành phần đã được chứng minh  hiệu quả lâm sàng cho tác dụng giảm cân.', N'31.jpg', NULL, 45, 8, 3)
INSERT [dbo].[Thuoc] ([MaThuoc], [TenThuoc], [GiaBan], [MoTa], [AnhBia], [NgayCapNhat], [SoLuongTon], [MaTH], [MaDM]) VALUES (32, N'COMBO 2 TINH DẦU MASSAGE GIẢM BÉO', CAST(398000 AS Decimal(18, 0)), N'Tinh dầu giảm béo sự kết hợp hoàn hảo giữa tinh dầu gừng và tinh dầu bưởi chiết xuất 100% từ tự nhiên. Mang lại hiệu quả cao trong quá trình giảm béo. Bạn có thể hoàn toàn yên tâm với phương pháp giảm béo này vì rất an toàn đối với sức khỏe của bạnTinh dầu giảm béo rất phù hợp với người không có nhiều thời gian luyện tập.', N'32.jpg', NULL, 46, 6, 3)
INSERT [dbo].[Thuoc] ([MaThuoc], [TenThuoc], [GiaBan], [MoTa], [AnhBia], [NgayCapNhat], [SoLuongTon], [MaTH], [MaDM]) VALUES (33, N'ĐAI MASSAGE VIBRO SHAPE', CAST(500000 AS Decimal(18, 0)), N'Với đai massage VIBRO SHAPE các bạn sẽ dễ dàng có được thân hình sắn chắc với bụng phẳng, eo thon, mông nâng, thon đùi, cánh tay mà không mất nhiều thời gian, công sức hay tiền bạc.', N'33.jpg', NULL, 45, 8, 3)
INSERT [dbo].[Thuoc] ([MaThuoc], [TenThuoc], [GiaBan], [MoTa], [AnhBia], [NgayCapNhat], [SoLuongTon], [MaTH], [MaDM]) VALUES (34, N'ĐAI MASSAGE VIBROACTION - EO ĐẸP, DÁNG THON', CAST(600000 AS Decimal(18, 0)), N'Đai massage VIBROACTION chính là lựa chọn lý tưởng dành cho những ai muốn tìm lại vóc dáng cân đối, gợi cảm, bụng phẳng, eo thon, mông đùi săn chắc mà không hề tốn kém thời gian, công sức hay tiền bạc.', N'34.jpg', NULL, 34, 6, 3)
INSERT [dbo].[Thuoc] ([MaThuoc], [TenThuoc], [GiaBan], [MoTa], [AnhBia], [NgayCapNhat], [SoLuongTon], [MaTH], [MaDM]) VALUES (35, N'THỰC PHẨM GIẢM CÂN HERBALIFE
', CAST(1100000 AS Decimal(18, 0)), N'Sữa Herbalife giảm cân bổ sung dinh dưỡng lành mạnh, giúp giảm cân cho người thừa cân, lấy lại vóc dáng thon thả. Sữa herbalife giảm cân thích hợp cho cả những người với chế độ ăn kiêng hà khắc, Làm giảm lượng đường cho người tiểu đường. giúp gia tăng sức khỏe - làm đẹp da.', N'35.jpg', NULL, 45, 9, 3)
INSERT [dbo].[Thuoc] ([MaThuoc], [TenThuoc], [GiaBan], [MoTa], [AnhBia], [NgayCapNhat], [SoLuongTon], [MaTH], [MaDM]) VALUES (36, N'OKINAWA FUCOIDAN - HỖ TRỢ ĐIỀU TRỊ UNG THƯ', CAST(2690000 AS Decimal(18, 0)), N'Okinawa Fucoidan là sản phẩm với thành phần chính Fucoidan được chiết xuất từ loại tảo nâu Mozuku ở Nhật Bản, có tác dụng vượt trội trong việc phòng ngừa và hỗ trợ điều trị ung thư', N'36.jpg', NULL, 46, 10, 4)
INSERT [dbo].[Thuoc] ([MaThuoc], [TenThuoc], [GiaBan], [MoTa], [AnhBia], [NgayCapNhat], [SoLuongTon], [MaTH], [MaDM]) VALUES (37, N'PREMIUM FUCOIDAN – HỖ TRỢ ĐIỀU TRỊ UNG THƯ, CHỐNG OXY HÓA', CAST(6500000 AS Decimal(18, 0)), N'Premium Fucoidan là sản phẩm có thành phần chính là tảo nâu Mozuku từ vùng biển Okinawa kết hợp với nấm linh chi cùng nhiều thành phần khác. Premium Fucoidan giúp phòng ngừa và hỗ trợ điều trị ung thư, hỗ trợ chống oxy hóa, hạn chế các gốc tự do, nâng cao thể lực cho người bệnh.', N'37.jpg', NULL, 23, 11, 4)
INSERT [dbo].[Thuoc] ([MaThuoc], [TenThuoc], [GiaBan], [MoTa], [AnhBia], [NgayCapNhat], [SoLuongTon], [MaTH], [MaDM]) VALUES (38, N'NANO FUCOIDAN EXTRACT GRANULE - HỖ TRỢ ĐIỀU TRỊ UNG THƯ', CAST(7950000 AS Decimal(18, 0)), N'Nano Fucoidan Extract Granule là sản phẩm hỗ trợ điều trị ung thư hàng đầu Nhật Bản,sản phẩm được bào chế ĐẶC BIỆT dưới dạng phân tử NANO siêu vi dễ dàng hấp thụ với thời gian ngắn, hiệu quả cao, từ đó mang lại hiệu quả hỗ trợ điều trị ung thư cao nhất. Đặc biệt là đối với bệnh nhân ung thư giai đoạn muộn.', N'38.jpg', NULL, 46, 10, 4)
INSERT [dbo].[Thuoc] ([MaThuoc], [TenThuoc], [GiaBan], [MoTa], [AnhBia], [NgayCapNhat], [SoLuongTon], [MaTH], [MaDM]) VALUES (39, N'COMBO 2 OKINAWA FUCOIDAN - HỖ TRỢ ĐIỀU TRỊ UNG THƯ', CAST(5110000 AS Decimal(18, 0)), N'Okinawa Fucoidan giúp tăng cường hệ miễn dịch cho người đang có sức khỏe yếu, người đang hóa trị và xạ trị, hạn chế sự phát triển và lây lan của các tế bào ung thư sang các tế bào khỏe mạnh, thúc đẩy quá trình tự chết của tế bào ung thư, đồng thời cải thiện thể trạng của người bệnh.', N'39.jpg', NULL, 45, 10, 4)
INSERT [dbo].[Thuoc] ([MaThuoc], [TenThuoc], [GiaBan], [MoTa], [AnhBia], [NgayCapNhat], [SoLuongTon], [MaTH], [MaDM]) VALUES (40, N'EF 2001 BERM KAIN PREMIUM - HỖ TRỢ ĐIỀU TRỊ UNG THƯ', CAST(7950000 AS Decimal(18, 0)), N'EF 2001 - BeRM KAIN Premium với hàm lượng lớn vi khuẩn sinh acid lactic giúp nâng cao miễn dịch, sức đề kháng của cơ thể, đặc biệt hiệu quả trong việc giúp phòng bệnh, hỗ trợ điều trị cũng như nâng cao thể trạng của bệnh nhân ung thư.', N'40.jpg', NULL, 46, 10, 4)
INSERT [dbo].[Thuoc] ([MaThuoc], [TenThuoc], [GiaBan], [MoTa], [AnhBia], [NgayCapNhat], [SoLuongTon], [MaTH], [MaDM]) VALUES (41, N'TINH CHẤT NGHỆ MÙA XUÂN VÀ NẤM AGARICUS', CAST(1250000 AS Decimal(18, 0)), N'Tinh Chất Nghệ Mùa Xuân và Nấm Agaricus là sản phẩm đến từ thương hiệu nổi tiếng của xứ sở hoa Anh đào. Với thành phần chính là tinh chất nghệ tự nhiên Okinawa cùng chiết xuất của nấm Agaricus có công dụng đặc hiệu trong việc ngăn ngừa, hỗ trợ điều trị ung thư đồng thời giúp tăng cường hệ miễn dịch cho cơ thể, hỗ trợ điều trị các bệnh về chuyển hóa.', N'41.jpg', NULL, 46, 10, 4)
INSERT [dbo].[Thuoc] ([MaThuoc], [TenThuoc], [GiaBan], [MoTa], [AnhBia], [NgayCapNhat], [SoLuongTon], [MaTH], [MaDM]) VALUES (42, N'SỮA TẮM TÂY THI - CHO LÀN DA MỊN MÀNG', CAST(50000 AS Decimal(18, 0)), N'Sữa tắm Tây Thi với công thức đột phá chứa tinh chất trầu không (chống viêm, chống ngứa, chống mụn), nghệ tươi (Chống mụn, làm đẹp da), hoa đào (hồng da, chống mụn), nhân sâm (dưỡng da, chống lão hoá da), bí đao (trắng da) đặc biệt tốt cho các trường hợp: ngứa da, sân da, mụn trứng cá lưng, ngực, vai, cánh tay, móng...', N'42.jpg', NULL, 100, 5, 5)
INSERT [dbo].[Thuoc] ([MaThuoc], [TenThuoc], [GiaBan], [MoTa], [AnhBia], [NgayCapNhat], [SoLuongTon], [MaTH], [MaDM]) VALUES (43, N'BIO MARINE COLLAGEN - NGĂN NGỪA LÃO HÓA, GIẢM NẾP NHĂN DA', CAST(1180000 AS Decimal(18, 0)), N'Viên uống Bio Marine Collagen có chứa hợp chất collagen cô đặc, được điều chế 100% từ da cá biển sâu trong lòng đại dương trên toàn nước Úc. Khi sử dụng viên uống Bio Marine Collagen làn da của bạn sẽ được chăm sóc từ sâu bên trong, ngăn ngừa sự hình thành và phát triển các dấu hiệu lão hóa da do tuổi tác, giúp thủy hóa và trẻ hóa làn da, tăng độ đàn hồi độ dẻo dai của làn da, chống chảy xệ, giúp da săn chắc, hồng hào, mịn màng, tươi trẻ.', N'43.jpg', NULL, 46, 4, 5)
INSERT [dbo].[Thuoc] ([MaThuoc], [TenThuoc], [GiaBan], [MoTa], [AnhBia], [NgayCapNhat], [SoLuongTon], [MaTH], [MaDM]) VALUES (44, N'BABY SHEEP ESSENCE CAPSULE- NHAU THAI CỪU 100 VIÊN', CAST(960000 AS Decimal(18, 0)), N'Baby Sheep Essence chứa 33.000 mg tinh chất chiết xuất từ Nhau thai cừu tươi, với nhau thai cừu chứa rất nhiều chất dinh dưỡng, kích thích tố, protein và các hợp chất hóa học khác, vì thế rất tốt cho làn da và sức khỏe, giúp trị nám, xóa mờ vết thâm, đen, cải thiện sức khỏe làn da rất nhanh, an toàn và triệt để.', N'44.jpg', NULL, 67, 4, 5)
INSERT [dbo].[Thuoc] ([MaThuoc], [TenThuoc], [GiaBan], [MoTa], [AnhBia], [NgayCapNhat], [SoLuongTon], [MaTH], [MaDM]) VALUES (45, N'CHANTELLE PLACENTA CREAM - KEM DƯỠNG DA NHAU THAI CỪU', CAST(99000 AS Decimal(18, 0)), N'Chantelle Placenta Cream là một trong những sản phẩm dưỡng ẩm chống nhăn cao cấp đến từ thương hiệu Careline. Với các thành phần chiết xuất từ mỡ cừu, nhau thai cừu, Collagen, Squalene (dầu gan cá mập ở biển sâu) và vitamin E, kem dưỡng ẩm nhau thai cừu Chatelle sẽ giúp bạn lấy lại sự trẻ trung cho làn da, duy trì độ ẩm cho da, xoá nếp nhăn và chống lại các tác nhân gây lão hoá cho làn da của bạn.', N'45.jpg', NULL, 24, 4, 5)
INSERT [dbo].[Thuoc] ([MaThuoc], [TenThuoc], [GiaBan], [MoTa], [AnhBia], [NgayCapNhat], [SoLuongTon], [MaTH], [MaDM]) VALUES (46, N'CHANTELLE BIO PLACENTA - SERUM TINH CHẤT TẾ BÀO GỐC NHAU THAI CỪU', CAST(300000 AS Decimal(18, 0)), N'Chantelle Bio Placenta chứa 100% hoạt chất protein chiết xuất từ nhau thai cừu, giàu chất kích thích sinh học và nguồn dinh dưỡng dồi dào giúp làm giảm những đốm đồi mồi và các đốm da sậm màu do tuổi tác bằng cách ngăn chặn sự sản sinh chất melanin trong da, thúc đẩy sự tái tạo da và làm mờ sẹo nhờ kích hoạt cơ chế sản sinh tế bào mới.', N'46.jpg', NULL, 57, 4, 5)
INSERT [dbo].[Thuoc] ([MaThuoc], [TenThuoc], [GiaBan], [MoTa], [AnhBia], [NgayCapNhat], [SoLuongTon], [MaTH], [MaDM]) VALUES (47, N'CHANTELLE LANOLIN CREAM - KEM DƯỠNG ẨM MỠ CỪU', CAST(99000 AS Decimal(18, 0)), N'Chantelle Lanolin Cream là một sản phẩm cao cấp đến từ thương hiệu Careline, với tinh dầu hạt nho và vitamin E có tác dụng dưỡng ẩm và chống nhăn. Kem dưỡng ẩm mỡ cừu Chantelle có chứa rất nhiều thành phần như: mỡ cừu tinh khiết, squalene (dầu gan cá mập ở biển sâu) và vitamin E, giúp da bạn luôn mềm mịn, tái tạo lại độ săn chắc cho da, chống tại dấu hiệu lão hoá của tuổi tác, làm mờ các nếp nhăn.', N'47.jpg', NULL, 46, 4, 5)
INSERT [dbo].[Thuoc] ([MaThuoc], [TenThuoc], [GiaBan], [MoTa], [AnhBia], [NgayCapNhat], [SoLuongTon], [MaTH], [MaDM]) VALUES (48, N'KEM DƯỠNG ẨM DA HÀNG NGÀY - DAILY MOISTURISER', CAST(260000 AS Decimal(18, 0)), N'Kem dưỡng ẩm CARELINE DAILY MOISTURISER giúp dưỡng ẩm, cải thiện và chăm sóc da hiệu quả.', N'48.jpg', NULL, 46, 4, 5)
INSERT [dbo].[Thuoc] ([MaThuoc], [TenThuoc], [GiaBan], [MoTa], [AnhBia], [NgayCapNhat], [SoLuongTon], [MaTH], [MaDM]) VALUES (49, N'BIOCELL COLLAGEN - COLLAGEN CẢI THIỆN VÀ CHĂM SÓC DA', CAST(620000 AS Decimal(18, 0)), N'BIOCELL COLLAGEN là tổ hợp cân bằng chứa các thành phần Collagen thủy phân phân tử lượng thấp, dễ hấp thu, kết hợp với Chondroitin sulfate và Hyaluronic acid có hoạt tính sinh học cao, theo đúng tỷ lệ đã được đăng ký bản quyền thương hiệu quốc tế, giúp tăng cường trẻ hóa làn da, bổ sung và tăng tổng hợp collagen , giảm nếp nhăn trên da, duy trì dưỡng ẩm, giúp làn da thêm săn chắc, mịn màng.', N'49.jpg', NULL, 67, 1, 5)
INSERT [dbo].[Thuoc] ([MaThuoc], [TenThuoc], [GiaBan], [MoTa], [AnhBia], [NgayCapNhat], [SoLuongTon], [MaTH], [MaDM]) VALUES (50, N'CHANTELLE BOOSTER CUP - KEM BÔI NỞ NGỰC', CAST(300000 AS Decimal(18, 0)), N'Chantelle Booster Cup là sản phẩm giúp tăng kích thước vòng ngực một cách hiệu quả, giúp tăng cường đồng hóa các tế bào tạo mỡ, tăng sinh tổng hợp, biệt hóa mô mỡ, ức chế quá trình phân giải mỡ, làm tăng kích thước vòng ngực một cách tự nhiên, đồng thời còn giúp bề mặt da luôn mịn màng, săn chắc.', N'50.jpg', NULL, 56, 4, 5)
INSERT [dbo].[Thuoc] ([MaThuoc], [TenThuoc], [GiaBan], [MoTa], [AnhBia], [NgayCapNhat], [SoLuongTon], [MaTH], [MaDM]) VALUES (51, N'BABY PLEX - BỔ SUNG VITAMIN TỔNG HỢP CHO TRẺ NHỎ', CAST(390000 AS Decimal(18, 0)), N'Giúp kích thích ăn ngon, hệ tiêu hóa khỏe mạnh, tăng khả năng hấp thụ, cung cấp vitamin tự nhiên và cải thiện hệ tiêu hóa cho bé trong những năm đầu đời khỏe mạnh. Sản phẩm đạt chuẩn của Cục quản lý Thực phẩm và dược phẩm Hoa Kỳ.', N'51.jpg', NULL, 45, 2, 6)
INSERT [dbo].[Thuoc] ([MaThuoc], [TenThuoc], [GiaBan], [MoTa], [AnhBia], [NgayCapNhat], [SoLuongTon], [MaTH], [MaDM]) VALUES (52, N'COMBO TINH DẦU TRÀM + TINH DẦU SẢ CHANH', CAST(338000 AS Decimal(18, 0)), N'Phòng chống và điều trị hiệu quả viêm phế quản, giảm ho, sổ mũi, viêm thanh quản, viêm phổi, hen phế quản, ho, thở khò khè, hen suyễn, trị vết muỗi đốt, đuổi muỗi cho bé khi ở nhà và đi ra ngoài.', N'52.jpg', NULL, 45, 7, 6)
INSERT [dbo].[Thuoc] ([MaThuoc], [TenThuoc], [GiaBan], [MoTa], [AnhBia], [NgayCapNhat], [SoLuongTon], [MaTH], [MaDM]) VALUES (55, N'PEDIAKID IMMUNO- TĂNG CƯỜNG MIỄN DỊCH', CAST(255000 AS Decimal(18, 0)), N'Pediakid Immuno-fortifiant (tăng cường miễn dịch) chai 125ml giúp tăng cường khả năng miễn dịch, tăng đề sức đề kháng cơ thể, phòng chống bệnh, đặc biệt là khi thay đổi mùa. Sản phẩm có hương vị dâu tự nhiên.', N'55.jpg', NULL, 46, 13, 6)
INSERT [dbo].[Thuoc] ([MaThuoc], [TenThuoc], [GiaBan], [MoTa], [AnhBia], [NgayCapNhat], [SoLuongTon], [MaTH], [MaDM]) VALUES (56, N'ODBANKIN- GIẢI PHÁP ENZYM CHO TRẺ BIẾNG ĂN', CAST(80000 AS Decimal(18, 0)), N'Odbankin chứa các loại men tiêu hóa như amylase, protesase, maltase, có tác dụng phân rã thức ăn, giúp tăng hiệu suất chuyển hóa, đồng thời giảm chứng đầy bụng, khó tiêu, nôn trớ, giúp hệ tiêu hóa hoạt động tốt, tăng khả năng hấp thụ dưỡng chất.', N'56.jpg', NULL, 35, 14, 6)
INSERT [dbo].[Thuoc] ([MaThuoc], [TenThuoc], [GiaBan], [MoTa], [AnhBia], [NgayCapNhat], [SoLuongTon], [MaTH], [MaDM]) VALUES (57, N'CỐM BỔ DƯỠNG UPKID- HẾT BIẾNG ĂN, TĂNG ĐỀ KHÁNG', CAST(139000 AS Decimal(18, 0)), N'Cốm bổ dưỡng UpKid giúp chữa bệnh biếng ăn cho trẻ, chậm phát triển, còi xương, suy dinh dưỡng, trẻ có sức đề kháng kém, dễ mắc các bệnh đường hô hấp.', N'57.jpg', NULL, 34, 1, 6)
INSERT [dbo].[Thuoc] ([MaThuoc], [TenThuoc], [GiaBan], [MoTa], [AnhBia], [NgayCapNhat], [SoLuongTon], [MaTH], [MaDM]) VALUES (58, N'CỐM VI SINH + MEN TIÊU HÓA BIOVITAL', CAST(120000 AS Decimal(18, 0)), N'Cốm vi sinh + Men tiêu hóa BIOVITAl giúp cân bằng hệ vi sinh đường ruột, bổ sung men tiêu hóa protein, chất béo, đường và tinh bột, cung cấp vitamin, acid amin và khoáng chất. Rất cần thiết cho trẻ khi tập ăn dặm, ăn từ bột sang cháo, từ cháo sang tập ăn cơm, giúp bé tiêu hóa tốt hấp thu nhiều, không bị đầy bụng khó tiêu, nôn trớ, tiêu chảy, trong các giai đoạn tập ăn.', N'58.jpg', NULL, 45, 15, 6)
INSERT [dbo].[Thuoc] ([MaThuoc], [TenThuoc], [GiaBan], [MoTa], [AnhBia], [NgayCapNhat], [SoLuongTon], [MaTH], [MaDM]) VALUES (59, N'CANASURE - BỔ SUNG VITAMIN', CAST(55000 AS Decimal(18, 0)), N'Giúp Tăng cường phát triển chiều cao, chống suy dinh dưỡng ở trẻ em, chống còi xương, Phát triển trí não, tăng cường trí thông minh, Tăng cường sức đề kháng.', N'59.jpg', NULL, 100, 16, 6)
INSERT [dbo].[Thuoc] ([MaThuoc], [TenThuoc], [GiaBan], [MoTa], [AnhBia], [NgayCapNhat], [SoLuongTon], [MaTH], [MaDM]) VALUES (60, N'BONIKIDDY - NÂNG CAO SỨC ĐỀ KHÁNG CHO BÉ', CAST(200000 AS Decimal(18, 0)), N'Kích thích hệ thống miễn dịch, bồi bổ cơ thể, tăng sức đề kháng cho trẻ em chống lại các tác nhân gây bệnh như vi khuẩn, virus. Giúp phòng tránh các bệnh đường hô hấp như: viêm mũi, viêm họng, viêm phế quản, hen phế quản…Các bệnh do virus gây ra như: cảm cúm, thủy đậu, sốt virus,…', N'60.jpg', NULL, 100, 2, 6)
INSERT [dbo].[Thuoc] ([MaThuoc], [TenThuoc], [GiaBan], [MoTa], [AnhBia], [NgayCapNhat], [SoLuongTon], [MaTH], [MaDM]) VALUES (62, N'HAIR POWER – CHỐNG RỤNG TÓC, KÍCH THÍCH MỌC TÓC', CAST(440000 AS Decimal(18, 0)), N'<p><em><span style="font-family: Roboto; font-size: 13px;">Hair Power l&agrave; sản phẩm c&oacute; chứa Keratin, Biotin, L- Lysine, ZinC AAC&hellip;v&agrave; nhiều th&agrave;nh phần kh&aacute;c gi&uacute;p phục hồi t&oacute;c hư tổn, xơ rối, g&atilde;y rụng, bảo vệ t&oacute;c trước c&aacute;c t&aacute;c động xấu từ m&ocirc;i trường v&agrave; k&iacute;ch th&iacute;ch mọc t&oacute;c hiệu quả.</span></em></p>', N'hair.jpg', NULL, 67, 16, 4)
SET IDENTITY_INSERT [dbo].[Thuoc] OFF
SET IDENTITY_INSERT [dbo].[ThuongHieu] ON 

INSERT [dbo].[ThuongHieu] ([MaTH], [TenTH], [DiaChi]) VALUES (1, N'Olympian Labs - Mỹ', N'Mỹ')
INSERT [dbo].[ThuongHieu] ([MaTH], [TenTH], [DiaChi]) VALUES (2, N'Natures Plus-Mỹ', N'Mỹ')
INSERT [dbo].[ThuongHieu] ([MaTH], [TenTH], [DiaChi]) VALUES (3, N'Dr Smile Ltd', N'Nhật Bản')
INSERT [dbo].[ThuongHieu] ([MaTH], [TenTH], [DiaChi]) VALUES (4, N'Care Line Australia Pty Ltd', N'Australia')
INSERT [dbo].[ThuongHieu] ([MaTH], [TenTH], [DiaChi]) VALUES (5, N'Công ty Cổ phần Sao Thái Dương', N'Việt Nam')
INSERT [dbo].[ThuongHieu] ([MaTH], [TenTH], [DiaChi]) VALUES (6, N'An Organics', NULL)
INSERT [dbo].[ThuongHieu] ([MaTH], [TenTH], [DiaChi]) VALUES (7, N'Công ty Vossen - Bỉ', NULL)
INSERT [dbo].[ThuongHieu] ([MaTH], [TenTH], [DiaChi]) VALUES (8, N'Creative Bioscience', NULL)
INSERT [dbo].[ThuongHieu] ([MaTH], [TenTH], [DiaChi]) VALUES (9, N'Herbalife Mỹ', N'Mỹ')
INSERT [dbo].[ThuongHieu] ([MaTH], [TenTH], [DiaChi]) VALUES (10, N'Kanehide Bio Co.LTD', N'Nhật')
INSERT [dbo].[ThuongHieu] ([MaTH], [TenTH], [DiaChi]) VALUES (11, N'Công ty TNHH Công nghiệp Arutechno', NULL)
INSERT [dbo].[ThuongHieu] ([MaTH], [TenTH], [DiaChi]) VALUES (12, N'Dược phẩm Hoa Sen', NULL)
INSERT [dbo].[ThuongHieu] ([MaTH], [TenTH], [DiaChi]) VALUES (13, N'PFIZER PGM - Pháp', N'Pháp')
INSERT [dbo].[ThuongHieu] ([MaTH], [TenTH], [DiaChi]) VALUES (14, N'Dược phẩm Mê Linh', N'Việt Nam')
INSERT [dbo].[ThuongHieu] ([MaTH], [TenTH], [DiaChi]) VALUES (15, N'Sản Phẩm Thiên Nhiên Vinacom', N'Việt Nam')
INSERT [dbo].[ThuongHieu] ([MaTH], [TenTH], [DiaChi]) VALUES (16, N' Dược VTYT Hải Dương', N'Việt Nam')
SET IDENTITY_INSERT [dbo].[ThuongHieu] OFF
ALTER TABLE [dbo].[ChiTietDonHang]  WITH CHECK ADD  CONSTRAINT [FK__ChiTietDo__MaDon__1CF15040] FOREIGN KEY([MaDonHang])
REFERENCES [dbo].[DonHang] ([MaDonHang])
GO
ALTER TABLE [dbo].[ChiTietDonHang] CHECK CONSTRAINT [FK__ChiTietDo__MaDon__1CF15040]
GO
ALTER TABLE [dbo].[ChiTietDonHang]  WITH CHECK ADD  CONSTRAINT [FK__ChiTietDo__MaThu__1DE57479] FOREIGN KEY([MaThuoc])
REFERENCES [dbo].[Thuoc] ([MaThuoc])
GO
ALTER TABLE [dbo].[ChiTietDonHang] CHECK CONSTRAINT [FK__ChiTietDo__MaThu__1DE57479]
GO
ALTER TABLE [dbo].[DonHang]  WITH CHECK ADD  CONSTRAINT [FK__DonHang__MaKH__1A14E395] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachHang] ([MaKH])
GO
ALTER TABLE [dbo].[DonHang] CHECK CONSTRAINT [FK__DonHang__MaKH__1A14E395]
GO
ALTER TABLE [dbo].[Thuoc]  WITH CHECK ADD  CONSTRAINT [FK__Thuoc__MaDM__173876EA] FOREIGN KEY([MaDM])
REFERENCES [dbo].[DanhMuc] ([MaDM])
GO
ALTER TABLE [dbo].[Thuoc] CHECK CONSTRAINT [FK__Thuoc__MaDM__173876EA]
GO
ALTER TABLE [dbo].[Thuoc]  WITH CHECK ADD  CONSTRAINT [FK__Thuoc__MaTH__164452B1] FOREIGN KEY([MaTH])
REFERENCES [dbo].[ThuongHieu] ([MaTH])
GO
ALTER TABLE [dbo].[Thuoc] CHECK CONSTRAINT [FK__Thuoc__MaTH__164452B1]
GO
USE [master]
GO
ALTER DATABASE [WebThuoc] SET  READ_WRITE 
GO
