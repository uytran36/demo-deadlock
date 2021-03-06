USE [master]
GO
/****** Object:  Database [qlnd]    Script Date: 4/2/2021 8:39:29 PM ******/
CREATE DATABASE [qlnd]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'qlnd', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\qlnd.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'qlnd_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\qlnd_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [qlnd] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [qlnd].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [qlnd] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [qlnd] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [qlnd] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [qlnd] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [qlnd] SET ARITHABORT OFF 
GO
ALTER DATABASE [qlnd] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [qlnd] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [qlnd] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [qlnd] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [qlnd] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [qlnd] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [qlnd] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [qlnd] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [qlnd] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [qlnd] SET  ENABLE_BROKER 
GO
ALTER DATABASE [qlnd] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [qlnd] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [qlnd] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [qlnd] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [qlnd] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [qlnd] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [qlnd] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [qlnd] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [qlnd] SET  MULTI_USER 
GO
ALTER DATABASE [qlnd] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [qlnd] SET DB_CHAINING OFF 
GO
ALTER DATABASE [qlnd] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [qlnd] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [qlnd] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [qlnd] SET QUERY_STORE = OFF
GO
USE [qlnd]
GO
/****** Object:  User [userNV]    Script Date: 4/2/2021 8:39:29 PM ******/
CREATE USER [userNV] FOR LOGIN [nhanvien] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[ChiNhanh]    Script Date: 4/2/2021 8:39:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiNhanh](
	[MaChiNhanh] [nchar](10) NOT NULL,
	[SoDienThoai] [nchar](10) NOT NULL,
	[Duong] [nvarchar](30) NOT NULL,
	[Quan] [nvarchar](30) NOT NULL,
	[KhuVuc] [nvarchar](30) NOT NULL,
	[ThanhPho] [nvarchar](30) NOT NULL,
 CONSTRAINT [PK_ChiNhanh] PRIMARY KEY CLUSTERED 
(
	[MaChiNhanh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChiTietNhanXet]    Script Date: 4/2/2021 8:39:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietNhanXet](
	[MaNhanXet] [nchar](10) NOT NULL,
	[MaNha] [nchar](10) NOT NULL,
	[MaKhachHang] [nchar](10) NOT NULL,
	[NoiDung] [nvarchar](255) NOT NULL,
 CONSTRAINT [PK_ChiTietNhanXet] PRIMARY KEY CLUSTERED 
(
	[MaNhanXet] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChuNha]    Script Date: 4/2/2021 8:39:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChuNha](
	[MaChuNha] [nchar](10) NOT NULL,
	[TenChuNha] [nvarchar](30) NOT NULL,
	[SoDienThoai] [nchar](10) NOT NULL,
	[Duong] [nvarchar](30) NOT NULL,
	[Quan] [nvarchar](30) NOT NULL,
	[ThanhPho] [nvarchar](30) NOT NULL,
	[KhuVuc] [nvarchar](30) NOT NULL,
	[daXoa] [int] NOT NULL,
 CONSTRAINT [PK_ChuNha] PRIMARY KEY CLUSTERED 
(
	[MaChuNha] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HopDong]    Script Date: 4/2/2021 8:39:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HopDong](
	[MaHopDong] [nchar](10) NOT NULL,
	[MaNhanVien] [nchar](10) NOT NULL,
	[MaNha] [nchar](10) NOT NULL,
	[MaChuNha] [nchar](10) NOT NULL,
	[MaKhachHang] [nchar](10) NOT NULL,
	[NgayLap] [datetime] NOT NULL,
	[ThoiHan] [int] NOT NULL,
	[TrangThaiHieuLuc] [int] NOT NULL,
 CONSTRAINT [PK_HopDong] PRIMARY KEY CLUSTERED 
(
	[MaHopDong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 4/2/2021 8:39:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKhachHang] [nchar](10) NOT NULL,
	[TenKhachHang] [nvarchar](30) NOT NULL,
	[Duong] [nvarchar](30) NOT NULL,
	[Quan] [nvarchar](30) NOT NULL,
	[ThanhPho] [nvarchar](30) NOT NULL,
	[KhuVuc] [nvarchar](30) NOT NULL,
	[SoDienThoai] [nchar](10) NOT NULL,
	[ThongTinNhaYeuCau] [nvarchar](30) NULL,
	[TieuChi] [nvarchar](30) NULL,
	[MaChiNhanh] [nchar](10) NOT NULL,
	[MaNhanVien] [nchar](10) NOT NULL,
	[daXoa] [int] NOT NULL,
 CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED 
(
	[MaKhachHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LichSuBan]    Script Date: 4/2/2021 8:39:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LichSuBan](
	[MaLichSuBan] [nchar](10) NOT NULL,
	[MaKhachHang] [nchar](10) NOT NULL,
	[MaNha] [nchar](10) NOT NULL,
	[NgayBan] [datetime] NOT NULL,
 CONSTRAINT [PK_LichSuBan] PRIMARY KEY CLUSTERED 
(
	[MaLichSuBan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LichSuDang]    Script Date: 4/2/2021 8:39:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LichSuDang](
	[MaLichSuDang] [nchar](10) NOT NULL,
	[MaChuNha] [nchar](10) NOT NULL,
	[MaNha] [nchar](10) NOT NULL,
	[NgayDang] [datetime] NOT NULL,
 CONSTRAINT [PK_LichSuDang] PRIMARY KEY CLUSTERED 
(
	[MaLichSuDang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LichSuThue]    Script Date: 4/2/2021 8:39:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LichSuThue](
	[MaLichSuThue] [nchar](10) NOT NULL,
	[MaKhachHang] [nchar](10) NOT NULL,
	[MaNha] [nchar](10) NOT NULL,
	[NgayThue] [datetime] NOT NULL,
 CONSTRAINT [PK_LichSuThue] PRIMARY KEY CLUSTERED 
(
	[MaLichSuThue] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiNha]    Script Date: 4/2/2021 8:39:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiNha](
	[MaLoaiNha] [nchar](10) NOT NULL,
	[TenLoaiNha] [nvarchar](30) NOT NULL,
 CONSTRAINT [PK_LoaiNha] PRIMARY KEY CLUSTERED 
(
	[MaLoaiNha] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Nha]    Script Date: 4/2/2021 8:39:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Nha](
	[MaNha] [nchar](10) NOT NULL,
	[Duong] [nvarchar](30) NOT NULL,
	[Quan] [nvarchar](30) NOT NULL,
	[KhuVuc] [nvarchar](30) NOT NULL,
	[ThanhPho] [nvarchar](30) NOT NULL,
	[SoLuotXem] [int] NOT NULL,
	[TinhTrang] [int] NOT NULL,
	[SoPhong] [int] NOT NULL,
	[NgayDang] [datetime] NOT NULL,
	[NgayHetHan] [datetime] NULL,
	[GiaChoThueMotThang] [int] NULL,
	[GiaBan] [int] NULL,
	[MaChiNhanh] [nchar](10) NOT NULL,
	[MaChuNha] [nchar](10) NOT NULL,
	[MaLoaiNha] [nchar](10) NOT NULL,
	[daXoa] [int] NOT NULL,
 CONSTRAINT [PK_Nha] PRIMARY KEY CLUSTERED 
(
	[MaNha] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 4/2/2021 8:39:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNhanVien] [nchar](10) NOT NULL,
	[TenNhanVien] [nvarchar](30) NOT NULL,
	[NgaySinh] [date] NOT NULL,
	[GioiTinh] [nvarchar](10) NOT NULL,
	[Duong] [nvarchar](30) NOT NULL,
	[Quan] [nvarchar](30) NOT NULL,
	[ThanhPho] [nvarchar](30) NOT NULL,
	[KhuVuc] [nvarchar](30) NOT NULL,
	[SoDienThoai] [nchar](10) NOT NULL,
	[MaChiNhanh] [nchar](10) NOT NULL,
	[daXoa] [int] NOT NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNhanVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Xem]    Script Date: 4/2/2021 8:39:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Xem](
	[MaXem] [nchar](10) NOT NULL,
	[MaKhachHang] [nchar](10) NOT NULL,
	[MaNha] [nchar](10) NOT NULL,
	[NgayXem] [datetime] NOT NULL,
 CONSTRAINT [PK_Xem] PRIMARY KEY CLUSTERED 
(
	[MaXem] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[ChiNhanh] ([MaChiNhanh], [SoDienThoai], [Duong], [Quan], [KhuVuc], [ThanhPho]) VALUES (N'0123456789', N'0987654321', N'Pham Ngu Lao', N'1', N'Nam', N'Ho Chi Minh')
INSERT [dbo].[ChiNhanh] ([MaChiNhanh], [SoDienThoai], [Duong], [Quan], [KhuVuc], [ThanhPho]) VALUES (N'1         ', N'1         ', N'1', N'1', N'1', N'1')
GO
INSERT [dbo].[ChiTietNhanXet] ([MaNhanXet], [MaNha], [MaKhachHang], [NoiDung]) VALUES (N'1         ', N'1         ', N'1         ', N'Update 2')
INSERT [dbo].[ChiTietNhanXet] ([MaNhanXet], [MaNha], [MaKhachHang], [NoiDung]) VALUES (N'3         ', N'1         ', N'1         ', N'Nhan xet 2')
GO
INSERT [dbo].[ChuNha] ([MaChuNha], [TenChuNha], [SoDienThoai], [Duong], [Quan], [ThanhPho], [KhuVuc], [daXoa]) VALUES (N'1         ', N'Tran Van A', N'0987654321', N'Cong Hoa', N'2', N'Ho Chi Minh', N'nam', 0)
GO
INSERT [dbo].[HopDong] ([MaHopDong], [MaNhanVien], [MaNha], [MaChuNha], [MaKhachHang], [NgayLap], [ThoiHan], [TrangThaiHieuLuc]) VALUES (N'1         ', N'1         ', N'1         ', N'1         ', N'1         ', CAST(N'2020-01-01T00:00:00.000' AS DateTime), 3, 0)
GO
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [Duong], [Quan], [ThanhPho], [KhuVuc], [SoDienThoai], [ThongTinNhaYeuCau], [TieuChi], [MaChiNhanh], [MaNhanVien], [daXoa]) VALUES (N'1         ', N'Nguyen Thi B', N'Pasteur', N'1', N'Ho Chi Minh', N'nam', N'0987654321', N'Thong tin 1', N'Tieu chi 1', N'1         ', N'1         ', 0)
GO
INSERT [dbo].[LichSuBan] ([MaLichSuBan], [MaKhachHang], [MaNha], [NgayBan]) VALUES (N'1         ', N'1         ', N'1         ', CAST(N'2018-01-01T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[LichSuDang] ([MaLichSuDang], [MaChuNha], [MaNha], [NgayDang]) VALUES (N'1         ', N'1         ', N'1         ', CAST(N'2010-01-01T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[LichSuThue] ([MaLichSuThue], [MaKhachHang], [MaNha], [NgayThue]) VALUES (N'1         ', N'1         ', N'1         ', CAST(N'2019-01-01T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[LoaiNha] ([MaLoaiNha], [TenLoaiNha]) VALUES (N'1         ', N'1')
GO
INSERT [dbo].[Nha] ([MaNha], [Duong], [Quan], [KhuVuc], [ThanhPho], [SoLuotXem], [TinhTrang], [SoPhong], [NgayDang], [NgayHetHan], [GiaChoThueMotThang], [GiaBan], [MaChiNhanh], [MaChuNha], [MaLoaiNha], [daXoa]) VALUES (N'1         ', N'1', N'1', N'1', N'1', 1, 3, 1, CAST(N'2000-01-01T00:00:00.000' AS DateTime), CAST(N'2001-01-01T00:00:00.000' AS DateTime), 1, 1, N'1         ', N'1         ', N'1         ', 0)
GO
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [NgaySinh], [GioiTinh], [Duong], [Quan], [ThanhPho], [KhuVuc], [SoDienThoai], [MaChiNhanh], [daXoa]) VALUES (N'1         ', N'Trần Uy', CAST(N'2000-01-01' AS Date), N'Nam', N'Pasteur', N'1', N'Ho Chi Minh', N'nam', N'0123456789', N'1         ', 0)
GO
INSERT [dbo].[Xem] ([MaXem], [MaKhachHang], [MaNha], [NgayXem]) VALUES (N'1         ', N'1         ', N'1         ', CAST(N'2019-01-01T00:00:00.000' AS DateTime))
GO
ALTER TABLE [dbo].[ChuNha] ADD  CONSTRAINT [DF_ChuNha_daXoa]  DEFAULT ((0)) FOR [daXoa]
GO
ALTER TABLE [dbo].[KhachHang] ADD  CONSTRAINT [DF_KhachHang_daXoa]  DEFAULT ((0)) FOR [daXoa]
GO
ALTER TABLE [dbo].[Nha] ADD  CONSTRAINT [DF_Nha_daXoa]  DEFAULT ((0)) FOR [daXoa]
GO
ALTER TABLE [dbo].[NhanVien] ADD  CONSTRAINT [DF_NhanVien_daXoa]  DEFAULT ((0)) FOR [daXoa]
GO
ALTER TABLE [dbo].[ChiTietNhanXet]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietNhanXet_KhachHang] FOREIGN KEY([MaKhachHang])
REFERENCES [dbo].[KhachHang] ([MaKhachHang])
GO
ALTER TABLE [dbo].[ChiTietNhanXet] CHECK CONSTRAINT [FK_ChiTietNhanXet_KhachHang]
GO
ALTER TABLE [dbo].[ChiTietNhanXet]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietNhanXet_Nha] FOREIGN KEY([MaNha])
REFERENCES [dbo].[Nha] ([MaNha])
GO
ALTER TABLE [dbo].[ChiTietNhanXet] CHECK CONSTRAINT [FK_ChiTietNhanXet_Nha]
GO
ALTER TABLE [dbo].[HopDong]  WITH CHECK ADD  CONSTRAINT [FK_HopDong_ChuNha] FOREIGN KEY([MaChuNha])
REFERENCES [dbo].[ChuNha] ([MaChuNha])
GO
ALTER TABLE [dbo].[HopDong] CHECK CONSTRAINT [FK_HopDong_ChuNha]
GO
ALTER TABLE [dbo].[HopDong]  WITH CHECK ADD  CONSTRAINT [FK_HopDong_KhachHang] FOREIGN KEY([MaKhachHang])
REFERENCES [dbo].[KhachHang] ([MaKhachHang])
GO
ALTER TABLE [dbo].[HopDong] CHECK CONSTRAINT [FK_HopDong_KhachHang]
GO
ALTER TABLE [dbo].[HopDong]  WITH CHECK ADD  CONSTRAINT [FK_HopDong_Nha] FOREIGN KEY([MaNha])
REFERENCES [dbo].[Nha] ([MaNha])
GO
ALTER TABLE [dbo].[HopDong] CHECK CONSTRAINT [FK_HopDong_Nha]
GO
ALTER TABLE [dbo].[HopDong]  WITH CHECK ADD  CONSTRAINT [FK_HopDong_NhanVien] FOREIGN KEY([MaNhanVien])
REFERENCES [dbo].[NhanVien] ([MaNhanVien])
GO
ALTER TABLE [dbo].[HopDong] CHECK CONSTRAINT [FK_HopDong_NhanVien]
GO
ALTER TABLE [dbo].[KhachHang]  WITH CHECK ADD  CONSTRAINT [FK_KhachHang_ChiNhanh] FOREIGN KEY([MaChiNhanh])
REFERENCES [dbo].[ChiNhanh] ([MaChiNhanh])
GO
ALTER TABLE [dbo].[KhachHang] CHECK CONSTRAINT [FK_KhachHang_ChiNhanh]
GO
ALTER TABLE [dbo].[KhachHang]  WITH CHECK ADD  CONSTRAINT [FK_KhachHang_NhanVien] FOREIGN KEY([MaNhanVien])
REFERENCES [dbo].[NhanVien] ([MaNhanVien])
GO
ALTER TABLE [dbo].[KhachHang] CHECK CONSTRAINT [FK_KhachHang_NhanVien]
GO
ALTER TABLE [dbo].[LichSuBan]  WITH CHECK ADD  CONSTRAINT [FK_LichSuBan_KhachHang] FOREIGN KEY([MaKhachHang])
REFERENCES [dbo].[KhachHang] ([MaKhachHang])
GO
ALTER TABLE [dbo].[LichSuBan] CHECK CONSTRAINT [FK_LichSuBan_KhachHang]
GO
ALTER TABLE [dbo].[LichSuBan]  WITH CHECK ADD  CONSTRAINT [FK_LichSuBan_Nha] FOREIGN KEY([MaNha])
REFERENCES [dbo].[Nha] ([MaNha])
GO
ALTER TABLE [dbo].[LichSuBan] CHECK CONSTRAINT [FK_LichSuBan_Nha]
GO
ALTER TABLE [dbo].[LichSuDang]  WITH CHECK ADD  CONSTRAINT [FK_LichSuDang_ChuNha] FOREIGN KEY([MaChuNha])
REFERENCES [dbo].[ChuNha] ([MaChuNha])
GO
ALTER TABLE [dbo].[LichSuDang] CHECK CONSTRAINT [FK_LichSuDang_ChuNha]
GO
ALTER TABLE [dbo].[LichSuDang]  WITH CHECK ADD  CONSTRAINT [FK_LichSuDang_Nha] FOREIGN KEY([MaNha])
REFERENCES [dbo].[Nha] ([MaNha])
GO
ALTER TABLE [dbo].[LichSuDang] CHECK CONSTRAINT [FK_LichSuDang_Nha]
GO
ALTER TABLE [dbo].[LichSuThue]  WITH CHECK ADD  CONSTRAINT [FK_LichSuThue_KhachHang] FOREIGN KEY([MaKhachHang])
REFERENCES [dbo].[KhachHang] ([MaKhachHang])
GO
ALTER TABLE [dbo].[LichSuThue] CHECK CONSTRAINT [FK_LichSuThue_KhachHang]
GO
ALTER TABLE [dbo].[LichSuThue]  WITH CHECK ADD  CONSTRAINT [FK_LichSuThue_Nha] FOREIGN KEY([MaNha])
REFERENCES [dbo].[Nha] ([MaNha])
GO
ALTER TABLE [dbo].[LichSuThue] CHECK CONSTRAINT [FK_LichSuThue_Nha]
GO
ALTER TABLE [dbo].[Nha]  WITH CHECK ADD  CONSTRAINT [FK_Nha_ChiNhanh] FOREIGN KEY([MaChiNhanh])
REFERENCES [dbo].[ChiNhanh] ([MaChiNhanh])
GO
ALTER TABLE [dbo].[Nha] CHECK CONSTRAINT [FK_Nha_ChiNhanh]
GO
ALTER TABLE [dbo].[Nha]  WITH CHECK ADD  CONSTRAINT [FK_Nha_ChuNha] FOREIGN KEY([MaChuNha])
REFERENCES [dbo].[ChuNha] ([MaChuNha])
GO
ALTER TABLE [dbo].[Nha] CHECK CONSTRAINT [FK_Nha_ChuNha]
GO
ALTER TABLE [dbo].[Nha]  WITH CHECK ADD  CONSTRAINT [FK_Nha_LoaiNha] FOREIGN KEY([MaLoaiNha])
REFERENCES [dbo].[LoaiNha] ([MaLoaiNha])
GO
ALTER TABLE [dbo].[Nha] CHECK CONSTRAINT [FK_Nha_LoaiNha]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_ChiNhanh] FOREIGN KEY([MaChiNhanh])
REFERENCES [dbo].[ChiNhanh] ([MaChiNhanh])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NhanVien_ChiNhanh]
GO
ALTER TABLE [dbo].[Xem]  WITH CHECK ADD  CONSTRAINT [FK_Xem_KhachHang] FOREIGN KEY([MaKhachHang])
REFERENCES [dbo].[KhachHang] ([MaKhachHang])
GO
ALTER TABLE [dbo].[Xem] CHECK CONSTRAINT [FK_Xem_KhachHang]
GO
ALTER TABLE [dbo].[Xem]  WITH CHECK ADD  CONSTRAINT [FK_Xem_Nha] FOREIGN KEY([MaNha])
REFERENCES [dbo].[Nha] ([MaNha])
GO
ALTER TABLE [dbo].[Xem] CHECK CONSTRAINT [FK_Xem_Nha]
GO
ALTER TABLE [dbo].[ChuNha]  WITH CHECK ADD  CONSTRAINT [CK_ChuNha_daXoa] CHECK  (([daXoa]=(0) OR [daXoa]=(1)))
GO
ALTER TABLE [dbo].[ChuNha] CHECK CONSTRAINT [CK_ChuNha_daXoa]
GO
ALTER TABLE [dbo].[HopDong]  WITH CHECK ADD  CONSTRAINT [CK_HopDong_NgayLap] CHECK  ((datediff(day,getdate(),[NgayLap])<=(0)))
GO
ALTER TABLE [dbo].[HopDong] CHECK CONSTRAINT [CK_HopDong_NgayLap]
GO
ALTER TABLE [dbo].[HopDong]  WITH CHECK ADD  CONSTRAINT [CK_HopDong_ThoiHan] CHECK  (([ThoiHan]>=(0)))
GO
ALTER TABLE [dbo].[HopDong] CHECK CONSTRAINT [CK_HopDong_ThoiHan]
GO
ALTER TABLE [dbo].[HopDong]  WITH CHECK ADD  CONSTRAINT [CK_HopDong_TrangThaiHieuLuc] CHECK  (([TrangThaiHieuLuc]=(0) OR [TrangThaiHieuLuc]=(1)))
GO
ALTER TABLE [dbo].[HopDong] CHECK CONSTRAINT [CK_HopDong_TrangThaiHieuLuc]
GO
ALTER TABLE [dbo].[KhachHang]  WITH CHECK ADD  CONSTRAINT [CK_KhachHang_daXoa] CHECK  (([daXoa]=(0) OR [daXoa]=(1)))
GO
ALTER TABLE [dbo].[KhachHang] CHECK CONSTRAINT [CK_KhachHang_daXoa]
GO
ALTER TABLE [dbo].[Nha]  WITH CHECK ADD  CONSTRAINT [CK_Nha_daXoa] CHECK  (([daXoa]=(0) OR [daXoa]=(1)))
GO
ALTER TABLE [dbo].[Nha] CHECK CONSTRAINT [CK_Nha_daXoa]
GO
ALTER TABLE [dbo].[Nha]  WITH CHECK ADD  CONSTRAINT [CK_Nha_GiaBan] CHECK  (([GiaBan]>(0)))
GO
ALTER TABLE [dbo].[Nha] CHECK CONSTRAINT [CK_Nha_GiaBan]
GO
ALTER TABLE [dbo].[Nha]  WITH CHECK ADD  CONSTRAINT [CK_Nha_GiaChoThueMotThang] CHECK  (([GiaChoThueMotThang]>(0)))
GO
ALTER TABLE [dbo].[Nha] CHECK CONSTRAINT [CK_Nha_GiaChoThueMotThang]
GO
ALTER TABLE [dbo].[Nha]  WITH CHECK ADD  CONSTRAINT [CK_Nha_SoLuotXem] CHECK  (([SoLuotXem]>=(0)))
GO
ALTER TABLE [dbo].[Nha] CHECK CONSTRAINT [CK_Nha_SoLuotXem]
GO
ALTER TABLE [dbo].[Nha]  WITH CHECK ADD  CONSTRAINT [CK_Nha_SoPhong] CHECK  (([SoPhong]>(0)))
GO
ALTER TABLE [dbo].[Nha] CHECK CONSTRAINT [CK_Nha_SoPhong]
GO
ALTER TABLE [dbo].[Nha]  WITH CHECK ADD  CONSTRAINT [CK_Nha_TinhTrang] CHECK  (([TinhTrang]=(1) OR [TinhTrang]=(2) OR [TinhTrang]=(3) OR [TinhTrang]=(4)))
GO
ALTER TABLE [dbo].[Nha] CHECK CONSTRAINT [CK_Nha_TinhTrang]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [CK_NhanVien_daXoa] CHECK  (([daXoa]=(0) OR [daXoa]=(1)))
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [CK_NhanVien_daXoa]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [CK_NhanVien_GioiTinh] CHECK  (([GioiTinh]=N'Nam' OR [GioiTinh]=N'Nữ'))
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [CK_NhanVien_GioiTinh]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [CK_NhanVien_NamSinh] CHECK  (((datepart(year,getdate())-datepart(year,[NgaySinh]))>=(18)))
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [CK_NhanVien_NamSinh]
GO
/****** Object:  StoredProcedure [dbo].[addBD]    Script Date: 4/2/2021 8:39:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[addBD]
(
     @add1 nchar(10), --tu tren xuong nhu db Diagrams
	 @add2 nvarchar(30),
	 @add3 nvarchar(30),
	 @add4 nvarchar(30),
	 @add5 nvarchar(30),
	 @add6 int,
	 @add7 int,
	 @add8 int,
	 @add9 datetime,
	 @add10 datetime,
	 @add11 int,
	 @add12 int,
	 @add13 nchar(10),
	 @add14 nchar(10),
	 @add15 nchar(10),
	 @add16 int
)
AS
BEGIN
	SET NOCOUNT ON;
    BEGIN TRANSACTION T1;
		BEGIN TRY
			INSERT INTO dbo.Nha (MaNha, Duong, Quan, KhuVuc, ThanhPho, SoLuotXem, TinhTrang,SoPhong, NgayDang, NgayHetHan, GiaChoThueMotThang, GiaBan, MaChiNhanh, MaChuNha,MaLoaiNha, daXoa)
			VALUES (@add1, @add2, @add3, @add4, @add5, @add6, @add7, @add8, @add9, @add10, @add11, @add12, @add13, @add14, @add15, @add16);
		COMMIT TRANSACTION T1
	END TRY
       BEGIN CATCH
              -- if error, roll back any chanegs done by any of the sql statements
              ROLLBACK TRANSACTION T1
       END CATCH
END

GO
/****** Object:  StoredProcedure [dbo].[addHD]    Script Date: 4/2/2021 8:39:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[addHD]
(
	@add1 nchar(10),
	@add2 nchar(10),
	@add3 nchar(10),
	@add4 nchar(10),
	@add5 nchar(10),
	@add6 datetime,
	@add7 int,
	@add8 int
)
AS
BEGIN
	SET NOCOUNT ON;
    BEGIN TRANSACTION T3;
		BEGIN TRY
			INSERT INTO dbo.HopDong(MaHopDong, MaNhanVien, MaNha, MaChuNha,MaKhachHang, NgayLap, ThoiHan, TrangThaiHieuLuc) 
			VALUES (@add1, @add2, @add3, @add4, @add5, @add6, @add7, @add8)
			
			UPDATE Nha
			SET TinhTrang = 2
			WHERE MaNha = @add3;
		COMMIT TRANSACTION T3
	END TRY
       BEGIN CATCH
              -- if error, roll back any chanegs done by any of the sql statements
              ROLLBACK TRANSACTION T3
       END CATCH
END

GO
/****** Object:  StoredProcedure [dbo].[insertLichSuThue]    Script Date: 4/2/2021 8:39:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[insertLichSuThue]
(
		@malichsu nchar(10),
		@makhachhang nchar(10),
		@manha nchar(10),
		@ngaythue datetime
)
as
begin
	begin transaction t1;
		--begin try
			insert into LichSuThue(MaLichSuThue, MaKhachHang, MaNha, NgayThue) values (@malichsu, @makhachhang, @manha, @ngaythue);
		--end try
		--begin catch
			--rollback t1
		--end catch
	commit transaction t1;
end

GO
/****** Object:  StoredProcedure [dbo].[sp_addkh]    Script Date: 4/2/2021 8:39:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_addkh]
(
	@add1 nchar(10), --ten truong tuong ung voi trong bang add1 - MaNhanVien, add2 - TenNhanVien
	@add2 nvarchar(30),
	@add3 nvarchar(30),
	@add4 nvarchar(30),
	@add5 nvarchar(30),
	@add6 nvarchar(30),
	@add7 nchar(10),
	@add8 nvarchar(30),
	@add9 nvarchar(30),
	@add10 nchar(10),
	@add11 nchar(10),
	@add12 int
)
AS
BEGIN
	BEGIN TRAN T1;
	INSERT INTO dbo.KhachHang(MaKhachHang, TenKhachHang, Duong, Quan, ThanhPho, KhuVuc, SoDienThoai, ThongTinNhaYeuCau, TieuChi, MaChiNhanh, MaNhanVien, daXoa) 
	VALUES (@add1, @add2, @add3, @add4, @add5, @add6, @add7, @add8, @add9, @add10, @add11, @add12) 
	COMMIT TRAN T1;
END
GO
/****** Object:  StoredProcedure [dbo].[sp_addnv]    Script Date: 4/2/2021 8:39:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_addnv]
(
	@add1 nchar(10), --ten truong tuong ung voi trong bang add1 - MaNhanVien, add2 - TenNhanVien
	@add2 nvarchar(30),
	@add3 date,
	@add4 nvarchar(10),
	@add5 nvarchar(30),
	@add6 nvarchar(30),
	@add7 nvarchar(30),
	@add8 nvarchar(30),
	@add9 nchar(10),
	@add10 nchar(10),
	@add11 int
)
AS
BEGIN
	BEGIN TRAN T1;
	INSERT INTO dbo.NhanVien(MaNhanVien, TenNhanVien, NgaySinh, GioiTinh, Duong, Quan, ThanhPho, KhuVuc, SoDienThoai, MaChiNhanh, daXoa) 
	VALUES (@add1, @add2, @add3, @add4, @add5, @add6, @add7, @add8, @add9, @add10, @add11) 
	COMMIT TRAN T1;
END
GO
/****** Object:  StoredProcedure [dbo].[sp_deleteNhanXet]    Script Date: 4/2/2021 8:39:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_deleteNhanXet]
		@manx nchar(10),
		@manha nchar(10)
as
begin
	begin transaction t1
		begin try
			if exists(Select * from Nha where MaNha = @manha and daXoa = 1)
			begin
				delete from ChiTietNhanXet where MaNhanXet = @manx
			end
		end try
		begin catch
			rollback transaction t1
		end catch
	commit transaction t1
end

GO
/****** Object:  StoredProcedure [dbo].[sp_dirtyRead]    Script Date: 4/2/2021 8:39:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_dirtyRead] 
AS
BEGIN
Begin try
	begin Tran t1
		Update Nha set TinhTrang = 2 where MaNha = '1'
		waitfor delay '00:00:30'
		rollback tran t1
end try
begin catch
	print N'Lỗi'
end catch

set transaction isolation level read uncommitted
begin tran t2
	select * from Nha where MaNha = '1'
commit tran t2
END
GO
/****** Object:  StoredProcedure [dbo].[sp_dirtyRead_trangThai]    Script Date: 4/2/2021 8:39:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_dirtyRead_trangThai]
AS
BEGIN
Begin try
	begin Tran t1
		Update Nha set TinhTrang = 4 where MaNha = '1'
		waitfor delay '00:00:05'
		begin tran t2
			select * from Nha where MaNha = '1'
		commit tran t2
		rollback tran t1
end try
begin catch
	print N'Lỗi'
end catch

--set transaction isolation level read uncommitted

END
GO
/****** Object:  StoredProcedure [dbo].[sp_insertChuNha]    Script Date: 4/2/2021 8:39:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/* 1.2.6 */
create procedure [dbo].[sp_insertChuNha]
		@machunha nchar(10),
		@tenchunha nvarchar(30),
		@sdt nchar(10),
		@duong nvarchar(30),
		@quan nvarchar(30),
		@tp nvarchar(30),
		@khuvuc nvarchar(30),
		@daxoa int
as
begin
	begin transaction t1
		begin try
			insert into ChuNha values(@machunha, @tenchunha, @sdt, @duong, @quan, @tp, @khuvuc, @daxoa)
		end try
		begin catch
			rollback transaction t1
		end catch
	commit transaction t1
end

GO
/****** Object:  StoredProcedure [dbo].[sp_insertLichSuBan]    Script Date: 4/2/2021 8:39:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_insertLichSuBan]
		@malichsu nchar(10),
		@makhachhang nchar(10),
		@manha nchar(10),
		@ngayban datetime
as
begin
	begin transaction t1
		begin try
			insert into LichSuBan values(@malichsu, @makhachhang, @manha, @ngayban)
		end try
		begin catch
			rollback transaction t1
		end catch
	commit transaction t1
end

GO
/****** Object:  StoredProcedure [dbo].[sp_insertLichSuThue]    Script Date: 4/2/2021 8:39:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/* 1.2.3 */
create procedure [dbo].[sp_insertLichSuThue]
(
		@malichsu nchar(10),
		@makhachhang nchar(10),
		@manha nchar(10),
		@ngaythue datetime
)
as
begin
	begin transaction t1;
		begin try
			insert into LichSuThue values (@malichsu, @makhachhang, @manha, @ngaythue);
		end try
		begin catch
			rollback transaction t1;
		end catch
	commit transaction t1;
end

GO
/****** Object:  StoredProcedure [dbo].[sp_insertLichSuXem]    Script Date: 4/2/2021 8:39:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/* 1.2.5 */
create procedure [dbo].[sp_insertLichSuXem]
		@malichsu nchar(10),
		@makhachhang nchar(10),
		@manha nchar(10),
		@ngayxem datetime
as
begin
	begin transaction t1
		begin try
			insert into Xem values(@malichsu, @makhachhang, @manha, @ngayxem)
		end try
		begin catch
			rollback transaction t1
		end catch
	commit transaction t1
end

GO
/****** Object:  StoredProcedure [dbo].[sp_insertNhanXet]    Script Date: 4/2/2021 8:39:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/* 1.2.4 */
create procedure [dbo].[sp_insertNhanXet]
		@manx nchar(10),
		@manha nchar(10),
		@makhachhang nchar(10),
		@noidung nvarchar(255)
as
begin
	begin transaction t1
		begin try
			insert into ChiTietNhanXet values(@manx, @manha, @makhachhang, @noidung)
		end try
		begin catch
			rollback transaction t1
		end catch
	commit transaction t1
end

GO
/****** Object:  StoredProcedure [dbo].[sp_lostUpdate_nhanXet]    Script Date: 4/2/2021 8:39:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_lostUpdate_nhanXet]
AS
BEGIN
Begin try
	begin Tran t1
		--select * from ChiTietNhanXet where MaNha = '1'
		--waitfor delay '00:00:05'
		begin tran t2
			--select * from ChiTietNhanXet where MaNhanXet = '1'
			update ChiTietNhanXet set NoiDung = 'Update final' where MaNhanXet = '1'
			waitfor delay '00:00:05'
			update ChiTietNhanXet set NoiDung = 'Update 2' where MaNhanXet = '1'
			commit tran t1
			select * from ChiTietNhanXet where MaNhanXet = '1'

			waitfor delay '00:00:01'
		commit tran t2
		
end try

begin catch
	print N'Lỗi'
end catch


END
GO
/****** Object:  StoredProcedure [dbo].[sp_phantom_nhanXet]    Script Date: 4/2/2021 8:39:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_phantom_nhanXet]
AS
BEGIN
Begin try
	begin Tran t1
		select * from ChiTietNhanXet where MaNha = '1'
		begin tran t2
			select * from ChiTietNhanXet where MaNha = '1'
			insert into ChiTietNhanXet values('3', '1', '1', 'Nhan xet 2')
		commit tran t2
		waitfor delay '00:00:05'
		select * from ChiTietNhanXet where MaNha = '1'
end try
begin catch
	print N'Lỗi'
end catch

END
GO
/****** Object:  StoredProcedure [dbo].[sp_unrepeatableRead_sdt]    Script Date: 4/2/2021 8:39:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_unrepeatableRead_sdt]
AS
BEGIN
Begin try
	begin Tran t1
		select * from ChuNha where MaChuNha = '1'
		begin tran t2
			update ChuNha set SoDienThoai = '002' where MaChuNha = '1'
		commit tran t2
		waitfor delay '00:00:10'
		select * from ChuNha where MaChuNha = '1'

end try
begin catch
	print N'Lỗi'
end catch
END
GO
/****** Object:  StoredProcedure [dbo].[sp_updateChuNha]    Script Date: 4/2/2021 8:39:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_updateChuNha]
		@machunha nchar(10),
		@tenchunha nvarchar(30),
		@sdt nchar(10),
		@duong nvarchar(30),
		@quan nvarchar(30),
		@tp nvarchar(30),
		@khuvuc nvarchar(30),
		@daxoa int
as
begin
	begin transaction t1
		begin try
			if exists (select * from ChuNha where MaChuNha = @machunha)
			begin
				update ChuNha set TenChuNha = @tenchunha, SoDienThoai = @sdt, Duong = @duong, Quan = @quan, ThanhPho = @tp, KhuVuc = @khuvuc, daXoa = @daxoa
							  where MaChuNha = @machunha
			end
		end try
		begin catch
			rollback transaction t1
		end catch
	commit transaction t1
end
GO
/****** Object:  StoredProcedure [dbo].[sp_updatekh]    Script Date: 4/2/2021 8:39:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_updatekh]
(
	@add1 nchar(10), --ten truong tuong ung voi trong bang add1 - MaNhanVien, add2 - TenNhanVien
	@add2 nvarchar(30),
	@add3 nvarchar(30),
	@add4 nvarchar(30),
	@add5 nvarchar(30),
	@add6 nvarchar(30),
	@add7 nchar(10),
	@add8 nvarchar(30),
	@add9 nvarchar(30),
	@add10 nchar(10),
	@add11 nchar(10),
	@add12 int
)
AS
BEGIN
	BEGIN TRAN T1;
	UPDATE KhachHang
	SET TenKhachHang = @add2, Duong = @add3, Quan = @add4, ThanhPho = @add5, KhuVuc = @add6, SoDienThoai = @add7, ThongTinNhaYeuCau = @add8, TieuChi = @add9, MaChiNhanh = @add10, MaNhanVien = @add11, daXoa = @add12 
	WHERE MaKhachHang = @add1;
	COMMIT TRAN T1;
END
GO
/****** Object:  StoredProcedure [dbo].[sp_updateLichSuBan]    Script Date: 4/2/2021 8:39:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_updateLichSuBan]
		@malichsu nchar(10),
		@makhachhang nchar(10),
		@manha nchar(10),
		@ngayban datetime
as
begin
	begin transaction t1
		begin try
			if exists(Select MaLichSuBan from LichSuBan where MaLichSuBan = @malichsu)
			begin
				update LichSuThue set MaKhachHang = @makhachhang, MaNha = @manha, NgayThue = @ngayban
							  where MaLichSuThue = @malichsu
			end
		end try
		begin catch
			rollback transaction t1
		end catch
	commit transaction t1
end

GO
/****** Object:  StoredProcedure [dbo].[sp_updateLichSuThue]    Script Date: 4/2/2021 8:39:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_updateLichSuThue]
		@malichsu nchar(10),
		@makhachhang nchar(10),
		@manha nchar(10),
		@ngaythue datetime
as
begin
	begin transaction t1
		begin try
			if exists(Select MaLichSuThue from LichSuThue where MaLichSuThue = @malichsu)
			begin
				update LichSuThue set MaKhachHang = @makhachhang, MaNha = @manha, NgayThue = @ngaythue
							  where MaLichSuThue = @malichsu
			end
		end try
		begin catch
			rollback transaction t1
		end catch
	commit transaction t1
end

GO
/****** Object:  StoredProcedure [dbo].[sp_updateLichSuXem]    Script Date: 4/2/2021 8:39:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_updateLichSuXem]
		@malichsu nchar(10),
		@makhachhang nchar(10),
		@manha nchar(10),
		@ngayxem datetime
as
begin
	begin transaction t1
		begin try
			if exists(Select MaXem from Xem where MaXem = @malichsu)
			begin
				update Xem set MaKhachHang = @makhachhang, MaNha = @manha, NgayXem = @ngayxem
							  where MaXem = @malichsu
			end
		end try
		begin catch
			rollback transaction t1
		end catch
	commit transaction t1
end

GO
/****** Object:  StoredProcedure [dbo].[sp_updateNhanXet]    Script Date: 4/2/2021 8:39:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_updateNhanXet]
		@manx nchar(10),
		@manha nchar(10),
		@makhachhang nchar(10),
		@noidung nvarchar(255)
as
begin
	begin transaction t1
		begin try
			if exists(Select MaNhanXet from ChiTietNhanXet where MaNhanXet = @manx)
			begin
				update ChiTietNhanXet set MaKhachHang = @makhachhang, MaNha = @manha, NoiDung = @noidung
							  where MaNhanXet = @manx
			end
		end try
		begin catch
			rollback transaction t1
		end catch
	commit transaction t1
end

GO
/****** Object:  StoredProcedure [dbo].[sp_updatenv]    Script Date: 4/2/2021 8:39:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_updatenv]
(
	@add1 nchar(10), --ten truong tuong ung voi trong bang add1 - MaNhanVien, add2 - TenNhanVien
	@add2 nvarchar(30),
	@add3 date,
	@add4 nvarchar(10),
	@add5 nvarchar(30),
	@add6 nvarchar(30),
	@add7 nvarchar(30),
	@add8 nvarchar(30),
	@add9 nchar(10),
	@add10 nchar(10),
	@add11 int
)
AS
BEGIN
	BEGIN TRAN T1;
	UPDATE NhanVien
	SET TenNhanVien = @add2, NgaySinh = @add3, GioiTinh = @add4, Duong = @add5, Quan = @add6, ThanhPho = @add7, KhuVuc = @add8, SoDienThoai = @add9, MaChiNhanh = @add10, daXoa = @add11 
	WHERE MaNhanVien = @add1;
	COMMIT TRAN T1;
END
GO
/****** Object:  StoredProcedure [dbo].[sp_xemcn]    Script Date: 4/2/2021 8:39:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_xemcn]
AS
BEGIN
	BEGIN TRAN T1;
	SELECT * FROM ChuNha
	COMMIT TRAN T1;
END
GO
/****** Object:  StoredProcedure [dbo].[sp_xemctnx]    Script Date: 4/2/2021 8:39:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_xemctnx]
AS
BEGIN
	BEGIN TRAN T1;
	SELECT * FROM ChiTietNhanXet
	COMMIT TRAN T1;
END
GO
/****** Object:  StoredProcedure [dbo].[sp_xemhd]    Script Date: 4/2/2021 8:39:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_xemhd]
AS
BEGIN
	BEGIN TRAN T1;
	SELECT * FROM HopDong
	COMMIT TRAN T1;
END
GO
/****** Object:  StoredProcedure [dbo].[sp_xemkh]    Script Date: 4/2/2021 8:39:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[sp_xemkh]
AS
BEGIN
	BEGIN TRAN T1;
	SELECT * FROM KhachHang
	COMMIT TRAN T1;
END
GO
/****** Object:  StoredProcedure [dbo].[sp_xemln]    Script Date: 4/2/2021 8:39:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_xemln]
AS
BEGIN
	BEGIN TRAN T1;
	SELECT * FROM LoaiNha
	COMMIT TRAN T1;
END
GO
/****** Object:  StoredProcedure [dbo].[sp_xemlsban]    Script Date: 4/2/2021 8:39:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_xemlsban]
AS
BEGIN
	BEGIN TRAN T1;
	SELECT * FROM LichSuBan
	COMMIT TRAN T1;
END
GO
/****** Object:  StoredProcedure [dbo].[sp_xemlsdang]    Script Date: 4/2/2021 8:39:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_xemlsdang]
AS
BEGIN
	BEGIN TRAN T1;
	SELECT * FROM LichSuDang
	COMMIT TRAN T1;
END
GO
/****** Object:  StoredProcedure [dbo].[sp_xemlsthue]    Script Date: 4/2/2021 8:39:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_xemlsthue]
AS
BEGIN
	BEGIN TRAN T1;
	SELECT * FROM LichSuThue
	COMMIT TRAN T1;
END
GO
/****** Object:  StoredProcedure [dbo].[sp_xemnha]    Script Date: 4/2/2021 8:39:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_xemnha]
AS
BEGIN
	BEGIN TRAN T1;
	SELECT * FROM Nha
	COMMIT TRAN T1;
END
GO
/****** Object:  StoredProcedure [dbo].[sp_xemnv]    Script Date: 4/2/2021 8:39:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_xemnv]
AS
BEGIN
	BEGIN TRAN T1;
	SELECT * FROM NhanVien
	COMMIT TRAN T1;
END
GO
/****** Object:  StoredProcedure [dbo].[sp_xemxn]    Script Date: 4/2/2021 8:39:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_xemxn]
AS
BEGIN
	BEGIN TRAN T1;
	SELECT * FROM Xem
	COMMIT TRAN T1;
END
GO
/****** Object:  StoredProcedure [dbo].[updateBD]    Script Date: 4/2/2021 8:39:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[updateBD]
(
	 @add1 nchar(10), --tu tren xuong nhu db Diagrams
	 @add2 nvarchar(30),
	 @add3 nvarchar(30),
	 @add4 nvarchar(30),
	 @add5 nvarchar(30),
	 @add6 int,
	 @add7 int,
	 @add8 int,
	 @add9 datetime ,
	 @add10 datetime,
	 @add11 int,
	 @add12 int,
	 @add13 nchar(10),
	 @add14 nchar(10),
	 @add15 nchar(10),
	 @add16 int
)
AS
BEGIN
	SET NOCOUNT ON;
    BEGIN TRANSACTION T2;
		BEGIN TRY
			UPDATE dbo.Nha 
			SET Duong = @add2, 
				Quan = @add3,
				KhuVuc = @add4, 
				ThanhPho = @add5,
				SoLuotXem = @add6, 
				TinhTrang = @add7,
				SoPhong = @add8, 
				NgayDang = @add9, 
				NgayHetHan = @add10, 
				GiaChoThueMotThang = @add11, 
				GiaBan = @add12, 
				MaChiNhanh = @add13, 
				MaChuNha = @add14,
				MaLoaiNha = @add15, 
				daXoa = @add16
			WHERE MaNha = @add1; 
		COMMIT TRANSACTION T2
	END TRY
       BEGIN CATCH
              -- if error, roll back any chanegs done by any of the sql statements
              ROLLBACK TRANSACTION T2
       END CATCH
END

GO
/****** Object:  StoredProcedure [dbo].[updateHD]    Script Date: 4/2/2021 8:39:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[updateHD]
(
	@add1 nchar(10),
	@add2 nchar(10),
	@add3 nchar(10),
	@add4 nchar(10),
	@add5 nchar(10),
	@add6 datetime,
	@add7 int,
	@add8 int
)
AS
BEGIN
	SET NOCOUNT ON;
    BEGIN TRANSACTION T4;
		BEGIN TRY
			UPDATE dbo.HopDong
			SET MaNhanVien = @add2,
				MaNha = @add3,
				MaChuNha = @add4,
				MaKhachHang = @add5,
				NgayLap = @add6,
				ThoiHan = @add7,
				TrangThaiHieuLuc = @add8
			WHERE MaHopDong = @add1;
			
		COMMIT TRANSACTION T4
	END TRY
       BEGIN CATCH
              -- if error, roll back any chanegs done by any of the sql statements
              ROLLBACK TRANSACTION T4
       END CATCH
END

/*
CREATE Role nvien
GRANT create table, create view TO nvien;

ALTER LOGIN nvien
WITH PASSWORD = 'nvien123';
*/
/*
CREATE LOGIN cnhanh
WITH PASSWORD = 'cnhanh' MUST_CHANGE, 
DEFAULT_DATABASE = qlnd,
CHECK_EXPIRATION = ON;


ALTER LOGIN cnhanh;
WITH PASSWORD = 'cnhanh';
*/
GO
USE [master]
GO
ALTER DATABASE [qlnd] SET  READ_WRITE 
GO
