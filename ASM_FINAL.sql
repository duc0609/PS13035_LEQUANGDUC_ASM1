USE [master]
GO
/****** Object:  Database [ASM1]    Script Date: 22/06/2021 02:50:15 ******/
CREATE DATABASE [ASM1]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ASM1', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\ASM1.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ASM1_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\ASM1_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [ASM1] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ASM1].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ASM1] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ASM1] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ASM1] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ASM1] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ASM1] SET ARITHABORT OFF 
GO
ALTER DATABASE [ASM1] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [ASM1] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ASM1] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ASM1] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ASM1] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ASM1] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ASM1] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ASM1] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ASM1] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ASM1] SET  ENABLE_BROKER 
GO
ALTER DATABASE [ASM1] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ASM1] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ASM1] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ASM1] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ASM1] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ASM1] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [ASM1] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ASM1] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ASM1] SET  MULTI_USER 
GO
ALTER DATABASE [ASM1] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ASM1] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ASM1] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ASM1] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ASM1] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ASM1] SET QUERY_STORE = OFF
GO
USE [ASM1]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
USE [ASM1]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 22/06/2021 02:50:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DonhangChitiets]    Script Date: 22/06/2021 02:50:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DonhangChitiets](
	[ChitietID] [int] IDENTITY(1,1) NOT NULL,
	[DonhangID] [int] NOT NULL,
	[MonAnID] [int] NOT NULL,
	[Soluong] [float] NOT NULL,
	[Thanhtien] [float] NOT NULL,
	[Ghichu] [nvarchar](250) NULL,
 CONSTRAINT [PK_DonhangChitiets] PRIMARY KEY CLUSTERED 
(
	[ChitietID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Donhangs]    Script Date: 22/06/2021 02:50:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Donhangs](
	[DonhangID] [int] IDENTITY(1,1) NOT NULL,
	[KhachhangID] [int] NOT NULL,
	[Ngaydat] [datetime2](7) NOT NULL,
	[Tongtien] [float] NOT NULL,
	[trangThaiDonHang] [int] NOT NULL,
	[Ghichu] [nvarchar](250) NULL,
 CONSTRAINT [PK_Donhangs] PRIMARY KEY CLUSTERED 
(
	[DonhangID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Khachhangs]    Script Date: 22/06/2021 02:50:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Khachhangs](
	[KhachhangID] [int] IDENTITY(1,1) NOT NULL,
	[FullName] [nvarchar](100) NOT NULL,
	[NgaySinh] [datetime2](7) NOT NULL,
	[PhoneNumber] [varchar](15) NOT NULL,
	[Password] [varchar](50) NOT NULL,
	[ConfirmPassword] [varchar](50) NOT NULL,
	[Mota] [nvarchar](250) NULL,
	[Address] [nvarchar](100) NOT NULL,
	[Email] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Khachhangs] PRIMARY KEY CLUSTERED 
(
	[KhachhangID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MonAns]    Script Date: 22/06/2021 02:50:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MonAns](
	[MonanID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](250) NOT NULL,
	[Gia] [float] NOT NULL,
	[Phanloai] [int] NOT NULL,
	[Hinh] [nvarchar](100) NULL,
	[Mota] [nvarchar](250) NULL,
	[Trangthai] [bit] NOT NULL,
 CONSTRAINT [PK_MonAns] PRIMARY KEY CLUSTERED 
(
	[MonanID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Nguoidungs]    Script Date: 22/06/2021 02:50:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Nguoidungs](
	[NguoidungID] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](100) NOT NULL,
	[FullName] [nvarchar](100) NOT NULL,
	[Email] [nvarchar](max) NOT NULL,
	[Title] [nvarchar](100) NULL,
	[DOB] [datetime2](7) NULL,
	[Admin] [bit] NOT NULL,
	[Locked] [bit] NOT NULL,
	[Password] [varchar](50) NULL,
 CONSTRAINT [PK_Nguoidungs] PRIMARY KEY CLUSTERED 
(
	[NguoidungID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210607044048_ASM1', N'3.1.10')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210607054717_ASM11', N'3.1.10')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210615165807_asm111', N'3.1.10')
GO
SET IDENTITY_INSERT [dbo].[DonhangChitiets] ON 

INSERT [dbo].[DonhangChitiets] ([ChitietID], [DonhangID], [MonAnID], [Soluong], [Thanhtien], [Ghichu]) VALUES (1, 2, 2, 1, 99999, N'')
INSERT [dbo].[DonhangChitiets] ([ChitietID], [DonhangID], [MonAnID], [Soluong], [Thanhtien], [Ghichu]) VALUES (2, 3, 3, 2, 20000, N'')
INSERT [dbo].[DonhangChitiets] ([ChitietID], [DonhangID], [MonAnID], [Soluong], [Thanhtien], [Ghichu]) VALUES (3, 4, 2, 7, 699993, N'')
INSERT [dbo].[DonhangChitiets] ([ChitietID], [DonhangID], [MonAnID], [Soluong], [Thanhtien], [Ghichu]) VALUES (4, 4, 3, 1, 10000, N'')
INSERT [dbo].[DonhangChitiets] ([ChitietID], [DonhangID], [MonAnID], [Soluong], [Thanhtien], [Ghichu]) VALUES (5, 5, 3, 9, 90000, N'')
INSERT [dbo].[DonhangChitiets] ([ChitietID], [DonhangID], [MonAnID], [Soluong], [Thanhtien], [Ghichu]) VALUES (6, 6, 5, 8, 200000, N'')
INSERT [dbo].[DonhangChitiets] ([ChitietID], [DonhangID], [MonAnID], [Soluong], [Thanhtien], [Ghichu]) VALUES (7, 7, 5, 11, 275000, N'')
SET IDENTITY_INSERT [dbo].[DonhangChitiets] OFF
GO
SET IDENTITY_INSERT [dbo].[Donhangs] ON 

INSERT [dbo].[Donhangs] ([DonhangID], [KhachhangID], [Ngaydat], [Tongtien], [trangThaiDonHang], [Ghichu]) VALUES (1, 1, CAST(N'2021-06-16T10:16:24.1843148' AS DateTime2), 34444055556, 1, N'')
INSERT [dbo].[Donhangs] ([DonhangID], [KhachhangID], [Ngaydat], [Tongtien], [trangThaiDonHang], [Ghichu]) VALUES (2, 1, CAST(N'2021-06-16T10:20:25.0983532' AS DateTime2), 99999, 1, N'')
INSERT [dbo].[Donhangs] ([DonhangID], [KhachhangID], [Ngaydat], [Tongtien], [trangThaiDonHang], [Ghichu]) VALUES (3, 1, CAST(N'2021-06-16T10:31:52.4596314' AS DateTime2), 20000, 1, N'')
INSERT [dbo].[Donhangs] ([DonhangID], [KhachhangID], [Ngaydat], [Tongtien], [trangThaiDonHang], [Ghichu]) VALUES (4, 2, CAST(N'2021-06-16T20:58:38.1812174' AS DateTime2), 709993, 1, N'')
INSERT [dbo].[Donhangs] ([DonhangID], [KhachhangID], [Ngaydat], [Tongtien], [trangThaiDonHang], [Ghichu]) VALUES (5, 2, CAST(N'2021-06-16T20:59:07.6214209' AS DateTime2), 90000, 1, N'')
INSERT [dbo].[Donhangs] ([DonhangID], [KhachhangID], [Ngaydat], [Tongtien], [trangThaiDonHang], [Ghichu]) VALUES (6, 2, CAST(N'2021-06-22T00:16:01.4828519' AS DateTime2), 200000, 1, N'')
INSERT [dbo].[Donhangs] ([DonhangID], [KhachhangID], [Ngaydat], [Tongtien], [trangThaiDonHang], [Ghichu]) VALUES (7, 2, CAST(N'2021-06-22T02:43:56.3279471' AS DateTime2), 275000, 1, N'')
SET IDENTITY_INSERT [dbo].[Donhangs] OFF
GO
SET IDENTITY_INSERT [dbo].[Khachhangs] ON 

INSERT [dbo].[Khachhangs] ([KhachhangID], [FullName], [NgaySinh], [PhoneNumber], [Password], [ConfirmPassword], [Mota], [Address], [Email]) VALUES (1, N'leduc', CAST(N'2021-06-16T01:37:00.0000000' AS DateTime2), N'0989856141', N'C4CA4238A0B923820DCC509A6F75849B', N'C4CA4238A0B923820DCC509A6F75849B', N'grgrgrgrg', N'tp', N'longvu0935@gmail.com')
INSERT [dbo].[Khachhangs] ([KhachhangID], [FullName], [NgaySinh], [PhoneNumber], [Password], [ConfirmPassword], [Mota], [Address], [Email]) VALUES (2, N'Thanh Phương', CAST(N'2021-06-16T20:57:00.0000000' AS DateTime2), N'0935639744', N'C4CA4238A0B923820DCC509A6F75849B', N'C4CA4238A0B923820DCC509A6F75849B', N'Thầy Giáo ', N'HCM', N'chinhchu@gmail.com')
INSERT [dbo].[Khachhangs] ([KhachhangID], [FullName], [NgaySinh], [PhoneNumber], [Password], [ConfirmPassword], [Mota], [Address], [Email]) VALUES (3, N'Thanh Phương', CAST(N'2021-06-21T16:28:00.0000000' AS DateTime2), N'0935639744', N'C4CA4238A0B923820DCC509A6F75849B', N'C4CA4238A0B923820DCC509A6F75849B', N'Giảng Viên ', N'HCM', N'longvu0935@gmail.com')
SET IDENTITY_INSERT [dbo].[Khachhangs] OFF
GO
SET IDENTITY_INSERT [dbo].[MonAns] ON 

INSERT [dbo].[MonAns] ([MonanID], [Name], [Gia], [Phanloai], [Hinh], [Mota], [Trangthai]) VALUES (2, N'Hamburger', 99999, 1, N'BANH.jfif', N'Ngon', 1)
INSERT [dbo].[MonAns] ([MonanID], [Name], [Gia], [Phanloai], [Hinh], [Mota], [Trangthai]) VALUES (3, N'Bò húc', 10000, 3, N'th.jfif', N'Tăng lực thái lan ', 1)
INSERT [dbo].[MonAns] ([MonanID], [Name], [Gia], [Phanloai], [Hinh], [Mota], [Trangthai]) VALUES (5, N'pizza', 25000, 1, N'tffff.jfif', N'pizza', 1)
INSERT [dbo].[MonAns] ([MonanID], [Name], [Gia], [Phanloai], [Hinh], [Mota], [Trangthai]) VALUES (6, N'Gà Rán', 30000, 1, N'garan (1).jfif', N'Gà Rán', 1)
INSERT [dbo].[MonAns] ([MonanID], [Name], [Gia], [Phanloai], [Hinh], [Mota], [Trangthai]) VALUES (10, N'Cafe Sữa', 25000, 3, N'pic8.jpg', N'Ngon', 1)
INSERT [dbo].[MonAns] ([MonanID], [Name], [Gia], [Phanloai], [Hinh], [Mota], [Trangthai]) VALUES (11, N'Thịt Luộc', 30000, 1, N'pic16.jpg', N'Ngon', 1)
INSERT [dbo].[MonAns] ([MonanID], [Name], [Gia], [Phanloai], [Hinh], [Mota], [Trangthai]) VALUES (12, N'Tôm ', 50000, 1, N'pic14.jpg', N'Ngon', 1)
INSERT [dbo].[MonAns] ([MonanID], [Name], [Gia], [Phanloai], [Hinh], [Mota], [Trangthai]) VALUES (13, N'Bánh kem ', 70000, 1, N'pic7.jpg', N'Ngon', 1)
INSERT [dbo].[MonAns] ([MonanID], [Name], [Gia], [Phanloai], [Hinh], [Mota], [Trangthai]) VALUES (14, N'Bún Bò Huế ', 25000, 1, N'Bun-Bo-Hue-Wide.jpg', N'Ngon', 1)
INSERT [dbo].[MonAns] ([MonanID], [Name], [Gia], [Phanloai], [Hinh], [Mota], [Trangthai]) VALUES (15, N'Lẩu Thái ', 120000, 1, N'38070-lau-de-1.jpg', NULL, 1)
SET IDENTITY_INSERT [dbo].[MonAns] OFF
GO
SET IDENTITY_INSERT [dbo].[Nguoidungs] ON 

INSERT [dbo].[Nguoidungs] ([NguoidungID], [UserName], [FullName], [Email], [Title], [DOB], [Admin], [Locked], [Password]) VALUES (1, N'phuongdung', N'Thanh Phương', N'lequangduc@gmail.com', N'Giảng Viên', CAST(N'2021-06-06T21:44:00.0000000' AS DateTime2), 1, 1, N'C4CA4238A0B923820DCC509A6F75849B')
SET IDENTITY_INSERT [dbo].[Nguoidungs] OFF
GO
/****** Object:  Index [IX_DonhangChitiets_DonhangID]    Script Date: 22/06/2021 02:50:18 ******/
CREATE NONCLUSTERED INDEX [IX_DonhangChitiets_DonhangID] ON [dbo].[DonhangChitiets]
(
	[DonhangID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_DonhangChitiets_MonAnID]    Script Date: 22/06/2021 02:50:18 ******/
CREATE NONCLUSTERED INDEX [IX_DonhangChitiets_MonAnID] ON [dbo].[DonhangChitiets]
(
	[MonAnID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Donhangs_KhachhangID]    Script Date: 22/06/2021 02:50:18 ******/
CREATE NONCLUSTERED INDEX [IX_Donhangs_KhachhangID] ON [dbo].[Donhangs]
(
	[KhachhangID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Khachhangs] ADD  DEFAULT (N'') FOR [Address]
GO
ALTER TABLE [dbo].[Khachhangs] ADD  DEFAULT (N'') FOR [Email]
GO
ALTER TABLE [dbo].[DonhangChitiets]  WITH CHECK ADD  CONSTRAINT [FK_DonhangChitiets_Donhangs_DonhangID] FOREIGN KEY([DonhangID])
REFERENCES [dbo].[Donhangs] ([DonhangID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[DonhangChitiets] CHECK CONSTRAINT [FK_DonhangChitiets_Donhangs_DonhangID]
GO
ALTER TABLE [dbo].[DonhangChitiets]  WITH CHECK ADD  CONSTRAINT [FK_DonhangChitiets_MonAns_MonAnID] FOREIGN KEY([MonAnID])
REFERENCES [dbo].[MonAns] ([MonanID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[DonhangChitiets] CHECK CONSTRAINT [FK_DonhangChitiets_MonAns_MonAnID]
GO
ALTER TABLE [dbo].[Donhangs]  WITH CHECK ADD  CONSTRAINT [FK_Donhangs_Khachhangs_KhachhangID] FOREIGN KEY([KhachhangID])
REFERENCES [dbo].[Khachhangs] ([KhachhangID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Donhangs] CHECK CONSTRAINT [FK_Donhangs_Khachhangs_KhachhangID]
GO
USE [master]
GO
ALTER DATABASE [ASM1] SET  READ_WRITE 
GO
