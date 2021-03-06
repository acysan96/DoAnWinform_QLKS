USE [master]
GO
/****** Object:  Database [DATABASE_QLKS]    Script Date: 12/14/2021 7:57:06 PM ******/
CREATE DATABASE [DATABASE_QLKS]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DATABASE_QLKS', FILENAME = N'D:\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\DATABASE_QLKS.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'DATABASE_QLKS_log', FILENAME = N'D:\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\DATABASE_QLKS_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [DATABASE_QLKS] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DATABASE_QLKS].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DATABASE_QLKS] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DATABASE_QLKS] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DATABASE_QLKS] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DATABASE_QLKS] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DATABASE_QLKS] SET ARITHABORT OFF 
GO
ALTER DATABASE [DATABASE_QLKS] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [DATABASE_QLKS] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DATABASE_QLKS] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DATABASE_QLKS] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DATABASE_QLKS] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DATABASE_QLKS] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DATABASE_QLKS] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DATABASE_QLKS] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DATABASE_QLKS] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DATABASE_QLKS] SET  ENABLE_BROKER 
GO
ALTER DATABASE [DATABASE_QLKS] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DATABASE_QLKS] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DATABASE_QLKS] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DATABASE_QLKS] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DATABASE_QLKS] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DATABASE_QLKS] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DATABASE_QLKS] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DATABASE_QLKS] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [DATABASE_QLKS] SET  MULTI_USER 
GO
ALTER DATABASE [DATABASE_QLKS] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DATABASE_QLKS] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DATABASE_QLKS] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DATABASE_QLKS] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [DATABASE_QLKS] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [DATABASE_QLKS] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [DATABASE_QLKS] SET QUERY_STORE = OFF
GO
USE [DATABASE_QLKS]
GO
/****** Object:  Table [dbo].[ChiTietHoaDon]    Script Date: 12/14/2021 7:57:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietHoaDon](
	[Id_bill] [char](10) NULL,
	[Id_service] [char](10) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DichVu]    Script Date: 12/14/2021 7:57:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DichVu](
	[Id] [char](10) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Price] [float] NULL,
 CONSTRAINT [PK_Id_Service] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HangHoa]    Script Date: 12/14/2021 7:57:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HangHoa](
	[Id] [char](10) NOT NULL,
	[Id_sup] [char](10) NULL,
	[Name] [nvarchar](50) NULL,
	[Type] [nvarchar](50) NULL,
	[Price] [float] NULL,
	[Unit] [char](10) NULL,
 CONSTRAINT [PK_Id_Good] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 12/14/2021 7:57:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[Id] [char](10) NOT NULL,
	[Id_user] [char](10) NULL,
	[Id_room] [char](10) NULL,
	[Id_guest] [char](10) NULL,
	[Date_checkin] [date] NULL,
	[Date_checkout] [date] NULL,
	[Payment_method] [nvarchar](50) NULL,
	[Total_price] [float] NULL,
 CONSTRAINT [PK_Id_Bill] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 12/14/2021 7:57:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[Id] [char](10) NOT NULL,
	[Full_name] [nvarchar](50) NULL,
	[Rank] [nvarchar](10) NULL,
	[Phone] [char](10) NULL,
 CONSTRAINT [PK_Id_Guest] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiPhong]    Script Date: 12/14/2021 7:57:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiPhong](
	[Id] [char](3) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Room_for_rent] [int] NULL,
	[Room_ready] [int] NULL,
 CONSTRAINT [PK_Id_RoomType] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhaCungCap]    Script Date: 12/14/2021 7:57:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhaCungCap](
	[Id] [char](10) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Phone] [char](10) NULL,
	[Address] [nvarchar](50) NULL,
 CONSTRAINT [PK_Id_Supplier] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhieuChi]    Script Date: 12/14/2021 7:57:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuChi](
	[Id] [char](10) NOT NULL,
	[Id_goods] [char](10) NULL,
	[Id_user] [char](10) NULL,
	[Total_price] [float] NULL,
	[Date_create] [date] NULL,
	[Date_received] [date] NULL,
 CONSTRAINT [PK_Id_Payment] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Phong]    Script Date: 12/14/2021 7:57:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Phong](
	[Id] [char](10) NOT NULL,
	[Num_of_beds] [int] NULL,
	[Price_per_night] [float] NULL,
	[Status] [nvarchar](10) NULL,
 CONSTRAINT [PK_Id_Room] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 12/14/2021 7:57:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[Id] [char](10) NOT NULL,
	[Permission] [char](20) NULL,
	[Full_name] [nvarchar](50) NULL,
	[Gender] [nvarchar](5) NULL,
	[Birthday] [date] NULL,
	[Address] [nvarchar](50) NULL,
	[Phone] [char](10) NULL,
	[User_name] [char](20) NULL,
	[Password] [char](50) NULL,
 CONSTRAINT [PK_Id_User] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[DichVu] ([Id], [Name], [Price]) VALUES (N'SV001     ', N'Giặt ủi quần áo', 50000)
INSERT [dbo].[DichVu] ([Id], [Name], [Price]) VALUES (N'SV002     ', N'Xe đưa đón sân bay', 800000)
INSERT [dbo].[DichVu] ([Id], [Name], [Price]) VALUES (N'SV003     ', N'Hội họp', 500000)
INSERT [dbo].[DichVu] ([Id], [Name], [Price]) VALUES (N'SV004     ', N'Quầy bar', 300000)
INSERT [dbo].[DichVu] ([Id], [Name], [Price]) VALUES (N'SV005     ', N'Spa', 700000)
INSERT [dbo].[DichVu] ([Id], [Name], [Price]) VALUES (N'SV006     ', N'Sân golf và sân tennis', 800000)
INSERT [dbo].[DichVu] ([Id], [Name], [Price]) VALUES (N'SV007     ', N'Nhà hàng', 100000)
INSERT [dbo].[DichVu] ([Id], [Name], [Price]) VALUES (N'SV008     ', N'Fitness center', 150000)
INSERT [dbo].[DichVu] ([Id], [Name], [Price]) VALUES (N'SV009     ', N'Casino', 100000)
INSERT [dbo].[DichVu] ([Id], [Name], [Price]) VALUES (N'SV010     ', N'Cho thuê xe máy tự lái', 3000000)
GO
INSERT [dbo].[HangHoa] ([Id], [Id_sup], [Name], [Type], [Price], [Unit]) VALUES (N'G00001    ', N'SP010     ', N'Điều hòa Nhật bản', N'Đồ Điện Tử', 8000000, N'VND       ')
INSERT [dbo].[HangHoa] ([Id], [Id_sup], [Name], [Type], [Price], [Unit]) VALUES (N'G00002    ', N'SP008     ', N'Dưa hấu', N'Trái Cây', 25000, N'VND       ')
INSERT [dbo].[HangHoa] ([Id], [Id_sup], [Name], [Type], [Price], [Unit]) VALUES (N'G00003    ', N'SP004     ', N'Rượu Volka', N'Thức Uống', 1000000, N'VND       ')
INSERT [dbo].[HangHoa] ([Id], [Id_sup], [Name], [Type], [Price], [Unit]) VALUES (N'G00004    ', N'SP001     ', N'Cua hoàng đế', N'Thực Phẩm', 2000000, N'VND       ')
INSERT [dbo].[HangHoa] ([Id], [Id_sup], [Name], [Type], [Price], [Unit]) VALUES (N'G00005    ', N'SP003     ', N'Sữa chua TH TrueMilk', N'Thực Phẩm', 50000, N'VND       ')
INSERT [dbo].[HangHoa] ([Id], [Id_sup], [Name], [Type], [Price], [Unit]) VALUES (N'G00006    ', N'SP009     ', N'Giường gỗ', N'Đồ Nội Thất', 15000000, N'VND       ')
GO
INSERT [dbo].[HoaDon] ([Id], [Id_user], [Id_room], [Id_guest], [Date_checkin], [Date_checkout], [Payment_method], [Total_price]) VALUES (N'HD068513  ', N'NV006     ', N'SUT302    ', N'KH0008    ', CAST(N'2021-12-13' AS Date), CAST(N'2021-12-18' AS Date), N'Zalo Pay', 200000)
INSERT [dbo].[HoaDon] ([Id], [Id_user], [Id_room], [Id_guest], [Date_checkin], [Date_checkout], [Payment_method], [Total_price]) VALUES (N'HD071978  ', N'NV004     ', N'STD102    ', N'KH0004    ', CAST(N'2021-12-13' AS Date), CAST(N'2021-12-14' AS Date), N'Momo', 150000)
INSERT [dbo].[HoaDon] ([Id], [Id_user], [Id_room], [Id_guest], [Date_checkin], [Date_checkout], [Payment_method], [Total_price]) VALUES (N'HD082991  ', N'QNS001    ', N'SUT202    ', N'KH0005    ', CAST(N'2021-12-13' AS Date), CAST(N'2021-12-17' AS Date), N'Momo', 90000)
INSERT [dbo].[HoaDon] ([Id], [Id_user], [Id_room], [Id_guest], [Date_checkin], [Date_checkout], [Payment_method], [Total_price]) VALUES (N'HD094365  ', N'NV007     ', N'STD102    ', N'KH0007    ', CAST(N'2021-12-14' AS Date), CAST(N'2021-12-25' AS Date), N'Momo', 250000)
INSERT [dbo].[HoaDon] ([Id], [Id_user], [Id_room], [Id_guest], [Date_checkin], [Date_checkout], [Payment_method], [Total_price]) VALUES (N'HD099126  ', N'NV005     ', N'CNT301    ', N'KH0004    ', CAST(N'2021-12-13' AS Date), CAST(N'2021-12-14' AS Date), N'Momo', 150000)
GO
INSERT [dbo].[KhachHang] ([Id], [Full_name], [Rank], [Phone]) VALUES (N'KH0001    ', N'Minh Công Đáng', N'Bạc', N'0968487125')
INSERT [dbo].[KhachHang] ([Id], [Full_name], [Rank], [Phone]) VALUES (N'KH0002    ', N'Trần Khắc Đẳng', N'Bạch Kim', N'0976967867')
INSERT [dbo].[KhachHang] ([Id], [Full_name], [Rank], [Phone]) VALUES (N'KH0003    ', N'Lê Tuyết Mai', N'Vàng', N'0905678465')
INSERT [dbo].[KhachHang] ([Id], [Full_name], [Rank], [Phone]) VALUES (N'KH0004    ', N'Đặng Khải Hoàn', N'Bạc', N'0960462756')
INSERT [dbo].[KhachHang] ([Id], [Full_name], [Rank], [Phone]) VALUES (N'KH0005    ', N'Tố Như Quỳnh', N'Bạc', N'0987045673')
INSERT [dbo].[KhachHang] ([Id], [Full_name], [Rank], [Phone]) VALUES (N'KH0006    ', N'Hà Xuân Mai', N'Kim Cương', N'0923535967')
INSERT [dbo].[KhachHang] ([Id], [Full_name], [Rank], [Phone]) VALUES (N'KH0007    ', N'Nguyễn Minh Mẫn', N'Vàng', N'0906843635')
INSERT [dbo].[KhachHang] ([Id], [Full_name], [Rank], [Phone]) VALUES (N'KH0008    ', N'Cao Thanh Lâm', N'Bạc', N'0925845607')
INSERT [dbo].[KhachHang] ([Id], [Full_name], [Rank], [Phone]) VALUES (N'KH0009    ', N'Trần Văn Long', N'Bạc', N'0903653800')
INSERT [dbo].[KhachHang] ([Id], [Full_name], [Rank], [Phone]) VALUES (N'KH0010    ', N'Đàm Đức Công', N'Bạch Kim', N'0935439303')
INSERT [dbo].[KhachHang] ([Id], [Full_name], [Rank], [Phone]) VALUES (N'KH0011    ', N'Nguyễn Công Minh', N'Bạc', N'0930936586')
GO
INSERT [dbo].[LoaiPhong] ([Id], [Name], [Room_for_rent], [Room_ready]) VALUES (N'CNT', N'Connecting room', 0, 6)
INSERT [dbo].[LoaiPhong] ([Id], [Name], [Room_for_rent], [Room_ready]) VALUES (N'DLX', N'Deluxe Room', 0, 6)
INSERT [dbo].[LoaiPhong] ([Id], [Name], [Room_for_rent], [Room_ready]) VALUES (N'STD', N'Standard Room', 0, 6)
INSERT [dbo].[LoaiPhong] ([Id], [Name], [Room_for_rent], [Room_ready]) VALUES (N'SUP', N'Superior Room', 0, 6)
INSERT [dbo].[LoaiPhong] ([Id], [Name], [Room_for_rent], [Room_ready]) VALUES (N'SUT', N'Suite Room', 0, 6)
GO
INSERT [dbo].[NhaCungCap] ([Id], [Name], [Phone], [Address]) VALUES (N'SP001     ', N'Hải sản Tuấn Anh', N'0896520000', N'1059 - Hải Phòng')
INSERT [dbo].[NhaCungCap] ([Id], [Name], [Phone], [Address]) VALUES (N'SP002     ', N'Thịt bò sạch Thắng Duy', N'0832020203', N'56 - Bình Thuận')
INSERT [dbo].[NhaCungCap] ([Id], [Name], [Phone], [Address]) VALUES (N'SP003     ', N'Sữa chua Tuấn', N'0563541265', N'86 - Bình Thuận')
INSERT [dbo].[NhaCungCap] ([Id], [Name], [Phone], [Address]) VALUES (N'SP004     ', N'Rượu kinh đô', N'0896520500', N'TP. Hồ Chí Minh')
INSERT [dbo].[NhaCungCap] ([Id], [Name], [Phone], [Address]) VALUES (N'SP005     ', N'Bàn ghế cao cấp Chợ Lớn', N'0123202223', N'TP. Hồ Chí Minh')
INSERT [dbo].[NhaCungCap] ([Id], [Name], [Phone], [Address]) VALUES (N'SP006     ', N'Bóng tennis Cao Cấp', N'0230456950', N'162 - Hà Nội')
INSERT [dbo].[NhaCungCap] ([Id], [Name], [Phone], [Address]) VALUES (N'SP007     ', N'Ly rượu ABC', N'0896541254', N'165 - Cần Thơ')
INSERT [dbo].[NhaCungCap] ([Id], [Name], [Phone], [Address]) VALUES (N'SP008     ', N'Trái cây miền tây KFA', N'0665542126', N'584 - Cà Mau')
INSERT [dbo].[NhaCungCap] ([Id], [Name], [Phone], [Address]) VALUES (N'SP009     ', N'Nội thất kiểu Pháp', N'1235050320', N'55 - Hà Nội')
INSERT [dbo].[NhaCungCap] ([Id], [Name], [Phone], [Address]) VALUES (N'SP010     ', N'Điện máy xanh', N'0654525211', N'TP. Hồ Chí Minh')
INSERT [dbo].[NhaCungCap] ([Id], [Name], [Phone], [Address]) VALUES (N'SP011     ', N'Nhà sản xuất COCACOLA', N'0863245145', N'TP. Hồ Chí Minh')
INSERT [dbo].[NhaCungCap] ([Id], [Name], [Phone], [Address]) VALUES (N'SP012     ', N'Honda Tuấn Linh', N'0832022239', N'TP. Hồ Chí Minh')
GO
INSERT [dbo].[Phong] ([Id], [Num_of_beds], [Price_per_night], [Status]) VALUES (N'CNT101    ', 1, 400000, N'Hired')
INSERT [dbo].[Phong] ([Id], [Num_of_beds], [Price_per_night], [Status]) VALUES (N'CNT102    ', 2, 600000, N'Ready')
INSERT [dbo].[Phong] ([Id], [Num_of_beds], [Price_per_night], [Status]) VALUES (N'CNT201    ', 1, 400000, N'Ready')
INSERT [dbo].[Phong] ([Id], [Num_of_beds], [Price_per_night], [Status]) VALUES (N'CNT202    ', 2, 600000, N'Ready')
INSERT [dbo].[Phong] ([Id], [Num_of_beds], [Price_per_night], [Status]) VALUES (N'CNT301    ', 1, 400000, N'Ready')
INSERT [dbo].[Phong] ([Id], [Num_of_beds], [Price_per_night], [Status]) VALUES (N'CNT302    ', 2, 600000, N'Hired')
INSERT [dbo].[Phong] ([Id], [Num_of_beds], [Price_per_night], [Status]) VALUES (N'DLX101    ', 1, 400000, N'Ready')
INSERT [dbo].[Phong] ([Id], [Num_of_beds], [Price_per_night], [Status]) VALUES (N'DLX102    ', 2, 600000, N'Ready')
INSERT [dbo].[Phong] ([Id], [Num_of_beds], [Price_per_night], [Status]) VALUES (N'DLX201    ', 1, 400000, N'Hired')
INSERT [dbo].[Phong] ([Id], [Num_of_beds], [Price_per_night], [Status]) VALUES (N'DLX202    ', 2, 600000, N'Ready')
INSERT [dbo].[Phong] ([Id], [Num_of_beds], [Price_per_night], [Status]) VALUES (N'DLX301    ', 1, 400000, N'Hired')
INSERT [dbo].[Phong] ([Id], [Num_of_beds], [Price_per_night], [Status]) VALUES (N'DLX302    ', 2, 600000, N'Ready')
INSERT [dbo].[Phong] ([Id], [Num_of_beds], [Price_per_night], [Status]) VALUES (N'STD101    ', 1, 400000, N'Ready')
INSERT [dbo].[Phong] ([Id], [Num_of_beds], [Price_per_night], [Status]) VALUES (N'STD102    ', 2, 600000, N'Ready')
INSERT [dbo].[Phong] ([Id], [Num_of_beds], [Price_per_night], [Status]) VALUES (N'STD201    ', 1, 400000, N'Ready')
INSERT [dbo].[Phong] ([Id], [Num_of_beds], [Price_per_night], [Status]) VALUES (N'STD202    ', 2, 600000, N'Ready')
INSERT [dbo].[Phong] ([Id], [Num_of_beds], [Price_per_night], [Status]) VALUES (N'STD301    ', 1, 400000, N'Ready')
INSERT [dbo].[Phong] ([Id], [Num_of_beds], [Price_per_night], [Status]) VALUES (N'STD302    ', 2, 600000, N'Ready')
INSERT [dbo].[Phong] ([Id], [Num_of_beds], [Price_per_night], [Status]) VALUES (N'SUP101    ', 1, 400000, N'Hired')
INSERT [dbo].[Phong] ([Id], [Num_of_beds], [Price_per_night], [Status]) VALUES (N'SUP102    ', 2, 600000, N'Ready')
INSERT [dbo].[Phong] ([Id], [Num_of_beds], [Price_per_night], [Status]) VALUES (N'SUP201    ', 1, 400000, N'Ready')
INSERT [dbo].[Phong] ([Id], [Num_of_beds], [Price_per_night], [Status]) VALUES (N'SUP202    ', 2, 600000, N'Ready')
INSERT [dbo].[Phong] ([Id], [Num_of_beds], [Price_per_night], [Status]) VALUES (N'SUP301    ', 1, 400000, N'Ready')
INSERT [dbo].[Phong] ([Id], [Num_of_beds], [Price_per_night], [Status]) VALUES (N'SUP302    ', 2, 600000, N'Hired')
INSERT [dbo].[Phong] ([Id], [Num_of_beds], [Price_per_night], [Status]) VALUES (N'SUT101    ', 1, 400000, N'Ready')
INSERT [dbo].[Phong] ([Id], [Num_of_beds], [Price_per_night], [Status]) VALUES (N'SUT102    ', 2, 600000, N'Ready')
INSERT [dbo].[Phong] ([Id], [Num_of_beds], [Price_per_night], [Status]) VALUES (N'SUT201    ', 1, 400000, N'Ready')
INSERT [dbo].[Phong] ([Id], [Num_of_beds], [Price_per_night], [Status]) VALUES (N'SUT202    ', 2, 600000, N'Ready')
INSERT [dbo].[Phong] ([Id], [Num_of_beds], [Price_per_night], [Status]) VALUES (N'SUT301    ', 1, 400000, N'Ready')
INSERT [dbo].[Phong] ([Id], [Num_of_beds], [Price_per_night], [Status]) VALUES (N'SUT302    ', 2, 600000, N'Hired')
GO
INSERT [dbo].[Users] ([Id], [Permission], [Full_name], [Gender], [Birthday], [Address], [Phone], [User_name], [Password]) VALUES (N'NV001     ', N'DoNotGrantPermission', N'Nguyễn Trung Trực', N'Nam', CAST(N'1989-01-02' AS Date), N'14/2 Đường Trương Dương Q.Mai Thành TP.Vũng Tàu', N'0904574500', N'                    ', N'                                                  ')
INSERT [dbo].[Users] ([Id], [Permission], [Full_name], [Gender], [Birthday], [Address], [Phone], [User_name], [Password]) VALUES (N'NV002     ', N'DoNotGrantPermission', N'Đoàn Mỹ Linh', N'Nữ', CAST(N'1988-09-02' AS Date), N'76/22 Đường Võ Đinh P.Mai Linh Trung TP.Nha Trang', N'0903464500', N'                    ', N'                                                  ')
INSERT [dbo].[Users] ([Id], [Permission], [Full_name], [Gender], [Birthday], [Address], [Phone], [User_name], [Password]) VALUES (N'NV003     ', N'DoNotGrantPermission', N'Nguyễn Thành Công', N'Nam', CAST(N'2000-02-02' AS Date), N'17/9 Đường Hữu Lý Q.Thủ Đức TP.Hồ Chí Minh', N'0904568450', N'                    ', N'                                                  ')
INSERT [dbo].[Users] ([Id], [Permission], [Full_name], [Gender], [Birthday], [Address], [Phone], [User_name], [Password]) VALUES (N'NV004     ', N'DoNotGrantPermission', N'Trần Trung Hiếu', N'Nam', CAST(N'2002-10-02' AS Date), N'865/22 Đường Khoa Hải Châu Q.Mỹ Lệ TP.Đà Lạt', N'0965487157', N'                    ', N'                                                  ')
INSERT [dbo].[Users] ([Id], [Permission], [Full_name], [Gender], [Birthday], [Address], [Phone], [User_name], [Password]) VALUES (N'NV005     ', N'DoNotGrantPermission', N'Trinh Thị Tuyết Mai', N'Nữ', CAST(N'2002-11-02' AS Date), N'575 Đường Ái Mỹ Q.Khải Hoa TP.Phan Thiết', N'0965487157', N'                    ', N'                                                  ')
INSERT [dbo].[Users] ([Id], [Permission], [Full_name], [Gender], [Birthday], [Address], [Phone], [User_name], [Password]) VALUES (N'NV006     ', N'Employee            ', N'Hoàng Mai Ngân', N'Nữ', CAST(N'1998-08-02' AS Date), N'51/5/22 Đường Khải Minh P.Mai Châu TP.Lâm Đồng', N'0965686587', N'LT001               ', N'D0970714757783E6CF17B26FB8E2298F                  ')
INSERT [dbo].[Users] ([Id], [Permission], [Full_name], [Gender], [Birthday], [Address], [Phone], [User_name], [Password]) VALUES (N'NV007     ', N'Employee            ', N'Mai Thị Tuyết Nhung', N'Nữ', CAST(N'1998-05-02' AS Date), N'25/202 Đường Võ Châu Minh P.Sao Mai TP.Gia Lai', N'0965695677', N'LT0002              ', N'D0970714757783E6CF17B26FB8E2298F                  ')
INSERT [dbo].[Users] ([Id], [Permission], [Full_name], [Gender], [Birthday], [Address], [Phone], [User_name], [Password]) VALUES (N'NV008     ', N'DoNotGrantPermission', N'Trịnh Minh Trọng', N'Nam', CAST(N'1999-04-25' AS Date), N'24 Đường Lê Thường Kiệt P.Hồ Khởi TP.Biên Hòa', N'0967967067', N'                    ', N'                                                  ')
INSERT [dbo].[Users] ([Id], [Permission], [Full_name], [Gender], [Birthday], [Address], [Phone], [User_name], [Password]) VALUES (N'NV009     ', N'DoNotGrantPermission', N'Mai Minh Anh', N'Nữ', CAST(N'1997-03-10' AS Date), N'984/87 Đường Đức Toản P.Minh Khai TP.Lai Châu', N'0922365680', N'                    ', N'                                                  ')
INSERT [dbo].[Users] ([Id], [Permission], [Full_name], [Gender], [Birthday], [Address], [Phone], [User_name], [Password]) VALUES (N'NV010     ', N'DoNotGrantPermission', N'Trần Thị Linh', N'Nữ', CAST(N'1996-11-12' AS Date), N'75/45 Đường Tinh Hứa P.Trung Trực TP.Điện Biên', N'0934233480', N'                    ', N'                                                  ')
INSERT [dbo].[Users] ([Id], [Permission], [Full_name], [Gender], [Birthday], [Address], [Phone], [User_name], [Password]) VALUES (N'NV011     ', N'DoNotGrantPermission', N'Hoàng Trần Đức Tuấn', N'Nam', CAST(N'1999-01-27' AS Date), N'157 Đường Lai Châu Q.1 TP.Hồ Chí Minh', N'0925695990', N'                    ', N'                                                  ')
INSERT [dbo].[Users] ([Id], [Permission], [Full_name], [Gender], [Birthday], [Address], [Phone], [User_name], [Password]) VALUES (N'NV012     ', N'DoNotGrantPermission', N'Trần Khắc Việt', N'Nam', CAST(N'1997-10-07' AS Date), N'14 Đường 114 P.Rạch Giá TP.KonTum', N'0933235680', N'                    ', N'                                                  ')
INSERT [dbo].[Users] ([Id], [Permission], [Full_name], [Gender], [Birthday], [Address], [Phone], [User_name], [Password]) VALUES (N'NV013     ', N'DoNotGrantPermission', N'Lê Gia Tùng', N'Nam', CAST(N'1993-08-03' AS Date), N'98/87 Đường Đại Nghĩa Q.Gò Vấp TP.Hồ Chí Minh', N'0922365680', N'                    ', N'                                                  ')
INSERT [dbo].[Users] ([Id], [Permission], [Full_name], [Gender], [Birthday], [Address], [Phone], [User_name], [Password]) VALUES (N'NV014     ', N'DoNotGrantPermission', N'Mai Thảo Duyên', N'Nữ', CAST(N'1997-01-02' AS Date), N'48/45/2 Đường Võ Hữu Cảnh Q.5 TP.Hồ Chí Minh', N'0925680686', N'                    ', N'                                                  ')
INSERT [dbo].[Users] ([Id], [Permission], [Full_name], [Gender], [Birthday], [Address], [Phone], [User_name], [Password]) VALUES (N'NV015     ', N'DoNotGrantPermission', N'Mai Thảo Duyên', N'Nữ', CAST(N'1995-10-07' AS Date), N'48/45/2 Đường Số 10 Q.2 TP.Hồ Chí Minh', N'0925680686', N'                    ', N'                                                  ')
INSERT [dbo].[Users] ([Id], [Permission], [Full_name], [Gender], [Birthday], [Address], [Phone], [User_name], [Password]) VALUES (N'NV016     ', N'DoNotGrantPermission', N'Trần Minh Tân', N'Nam', CAST(N'1996-12-07' AS Date), N'45/2 Đường Võ Minh Châu Q.10 TP.Hồ Chí Minh', N'0923625487', N'                    ', N'                                                  ')
INSERT [dbo].[Users] ([Id], [Permission], [Full_name], [Gender], [Birthday], [Address], [Phone], [User_name], [Password]) VALUES (N'NV017     ', N'DoNotGrantPermission', N'Đặng Hoài Tâm', N'Nam', CAST(N'1997-01-20' AS Date), N'48 Đường Trần Quang Nghĩa Q.9 TP.Hồ Chí Minh', N'0925696514', N'                    ', N'                                                  ')
INSERT [dbo].[Users] ([Id], [Permission], [Full_name], [Gender], [Birthday], [Address], [Phone], [User_name], [Password]) VALUES (N'PGD001    ', N'Admin               ', N'Lê Mỹ Anh', N'Nữ', CAST(N'1998-11-08' AS Date), N'99 Đường Võ Thường Kiệt Q.11 TP.Hồ Chí Minh', N'0923423423', N'PGD001              ', N'21232F297A57A5A743894A0E4A801FC3                  ')
INSERT [dbo].[Users] ([Id], [Permission], [Full_name], [Gender], [Birthday], [Address], [Phone], [User_name], [Password]) VALUES (N'PGD002    ', N'Admin               ', N'Nguyễn Minh Toản', N'Nam', CAST(N'1995-01-22' AS Date), N'18/3 Đường Võ Chí Tôn Q.9 TP.Hồ Chí Minh', N'0262343342', N'PGD002              ', N'21232F297A57A5A743894A0E4A801FC3                  ')
INSERT [dbo].[Users] ([Id], [Permission], [Full_name], [Gender], [Birthday], [Address], [Phone], [User_name], [Password]) VALUES (N'QLB001    ', N'DoNotGrantPermission', N'Đàm Đức Trung', N'Nam', CAST(N'1988-05-26' AS Date), N'145 Đường Minh Khai P.Rạch Dừa TP.Vũng Tàu', N'0946704565', N'                    ', N'                                                  ')
INSERT [dbo].[Users] ([Id], [Permission], [Full_name], [Gender], [Birthday], [Address], [Phone], [User_name], [Password]) VALUES (N'QLK001    ', N'Employee            ', N'Đinh Thanh Trung Trực', N'Nam', CAST(N'1990-10-27' AS Date), N'75 Đường Hoàng Diệu 1 Q.Hải Sơn TP.Quảng Ngãi', N'0978492342', N'QLK001              ', N'D0970714757783E6CF17B26FB8E2298F                  ')
INSERT [dbo].[Users] ([Id], [Permission], [Full_name], [Gender], [Birthday], [Address], [Phone], [User_name], [Password]) VALUES (N'QLT001    ', N'DoNotGrantPermission', N'Trần Trung Hiếu', N'Nam', CAST(N'1987-02-28' AS Date), N'141/56 Đường Công Minh Q.Ba Đình TP.Hà Nội', N'0972365627', N'                    ', N'                                                  ')
INSERT [dbo].[Users] ([Id], [Permission], [Full_name], [Gender], [Birthday], [Address], [Phone], [User_name], [Password]) VALUES (N'QMK001    ', N'DoNotGrantPermission', N'Trần Thị Hoa', N'Nữ', CAST(N'1992-12-23' AS Date), N'174/33 Đường Đinh Bộ Lĩnh Q.Minh Khai TP.Lâm Đồng', N'0938735685', N'                    ', N'                                                  ')
INSERT [dbo].[Users] ([Id], [Permission], [Full_name], [Gender], [Birthday], [Address], [Phone], [User_name], [Password]) VALUES (N'QNS001    ', N'Employee            ', N'Đàm Đức Trung', N'Nam', CAST(N'1998-02-02' AS Date), N'145 Đường Trương Công Định Q.Cầu Giấy TP.Hải Phòng', N'0922352342', N'QNS001              ', N'D0970714757783E6CF17B26FB8E2298F                  ')
INSERT [dbo].[Users] ([Id], [Permission], [Full_name], [Gender], [Birthday], [Address], [Phone], [User_name], [Password]) VALUES (N'TGD001    ', N'Admin               ', N'Đinh Tiên Hoàng', N'Nam', CAST(N'1988-12-02' AS Date), N'24 Đường Lê Lai Q.Hải Dương TP.Biên Hòa', N'0976541487', N'TGD001              ', N'21232F297A57A5A743894A0E4A801FC3                  ')
GO
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD  CONSTRAINT [FK_Id_Bill] FOREIGN KEY([Id_bill])
REFERENCES [dbo].[HoaDon] ([Id])
GO
ALTER TABLE [dbo].[ChiTietHoaDon] CHECK CONSTRAINT [FK_Id_Bill]
GO
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD  CONSTRAINT [FK_Id_Service] FOREIGN KEY([Id_service])
REFERENCES [dbo].[DichVu] ([Id])
GO
ALTER TABLE [dbo].[ChiTietHoaDon] CHECK CONSTRAINT [FK_Id_Service]
GO
ALTER TABLE [dbo].[HangHoa]  WITH CHECK ADD  CONSTRAINT [FK_Id_Sup] FOREIGN KEY([Id_sup])
REFERENCES [dbo].[NhaCungCap] ([Id])
GO
ALTER TABLE [dbo].[HangHoa] CHECK CONSTRAINT [FK_Id_Sup]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_Id_Guest] FOREIGN KEY([Id_guest])
REFERENCES [dbo].[KhachHang] ([Id])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_Id_Guest]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_Id_Room] FOREIGN KEY([Id_room])
REFERENCES [dbo].[Phong] ([Id])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_Id_Room]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_Id_User] FOREIGN KEY([Id_user])
REFERENCES [dbo].[Users] ([Id])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_Id_User]
GO
ALTER TABLE [dbo].[PhieuChi]  WITH CHECK ADD  CONSTRAINT [FK_Id_Goods] FOREIGN KEY([Id_goods])
REFERENCES [dbo].[HangHoa] ([Id])
GO
ALTER TABLE [dbo].[PhieuChi] CHECK CONSTRAINT [FK_Id_Goods]
GO
ALTER TABLE [dbo].[PhieuChi]  WITH CHECK ADD  CONSTRAINT [FK_Id_User_Payment] FOREIGN KEY([Id_user])
REFERENCES [dbo].[Users] ([Id])
GO
ALTER TABLE [dbo].[PhieuChi] CHECK CONSTRAINT [FK_Id_User_Payment]
GO
/****** Object:  StoredProcedure [dbo].[InDanhSachHoaDon]    Script Date: 12/14/2021 7:57:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[InDanhSachHoaDon]
as begin
select KhachHang.Full_name, HoaDon.Id, HoaDon.Id_user, HoaDon.Id_room, HoaDon.Id_guest, HoaDon.Date_checkin, HoaDon.Date_checkout, HoaDon.Payment_method, HoaDon.Total_price
from KhachHang, HoaDon where KhachHang.Id=HoaDon.Id_guest
end;

-- In hóa đơn
GO
/****** Object:  StoredProcedure [dbo].[InHoaDon]    Script Date: 12/14/2021 7:57:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[InHoaDon]
@Id char(10)
as begin
select KhachHang.Full_name, HoaDon.Id, HoaDon.Id_user, HoaDon.Id_room, HoaDon.Id_guest, HoaDon.Date_checkin, HoaDon.Date_checkout, HoaDon.Payment_method, HoaDon.Total_price
from KhachHang, HoaDon where HoaDon.Id=@Id and KhachHang.Id=HoaDon.Id_guest
end;
GO
/****** Object:  StoredProcedure [dbo].[LayMotDichVu]    Script Date: 12/14/2021 7:57:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[LayMotDichVu]
@Id char(10)
as begin
select * from DichVu where Id=@Id
end;

-- SP thêm dịch vụ
GO
/****** Object:  StoredProcedure [dbo].[LayMotHangHoa]    Script Date: 12/14/2021 7:57:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[LayMotHangHoa]
@Id char(10)
as begin
select * from HangHoa where Id=@Id
end;

-- SP thêm hàng hóa
GO
/****** Object:  StoredProcedure [dbo].[LayMotHoaDon]    Script Date: 12/14/2021 7:57:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[LayMotHoaDon]
@Id char(10)
as begin 
select * from HoaDon where Id=@Id
end;

-- SP thêm hóa đơn
GO
/****** Object:  StoredProcedure [dbo].[LayMotKhachHang]    Script Date: 12/14/2021 7:57:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[LayMotKhachHang]
@Id char(10)
as begin
select * from KhachHang where Id=@Id
end;

-- SP thêm khách hàng
GO
/****** Object:  StoredProcedure [dbo].[LayMotLoaiPhong]    Script Date: 12/14/2021 7:57:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[LayMotLoaiPhong]
@Id char(10)
as begin
select * from LoaiPhong where Id=@Id
end;

-- SP thêm loại phòng
GO
/****** Object:  StoredProcedure [dbo].[LayMotNhaCungCap]    Script Date: 12/14/2021 7:57:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[LayMotNhaCungCap]
@Id char(10)
as begin
select * from NhaCungCap where Id=@Id
end;

--SP thêm nhà cung cấp
GO
/****** Object:  StoredProcedure [dbo].[LayMotPhieuChi]    Script Date: 12/14/2021 7:57:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[LayMotPhieuChi]
@Id char(10)
as begin 
select * from PhieuChi where Id=@Id
end;

-- SP thêm phiếu chi
GO
/****** Object:  StoredProcedure [dbo].[LayMotPhong]    Script Date: 12/14/2021 7:57:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[LayMotPhong]
@Id char(10)
as begin
select * from Phong where Id=@Id
end;

-- SP thêm phòng
GO
/****** Object:  StoredProcedure [dbo].[LayMotUser]    Script Date: 12/14/2021 7:57:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[LayMotUser]
@Id char(10)
as begin
select * from Users where Id=@Id
end;

-- SP Thêm 1 User
GO
/****** Object:  StoredProcedure [dbo].[LayToanBoDichVu]    Script Date: 12/14/2021 7:57:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[LayToanBoDichVu]
as begin 
select * from DichVu
end;

-- SP lấy 1 dịch vụ
GO
/****** Object:  StoredProcedure [dbo].[LayToanBoHangHoa]    Script Date: 12/14/2021 7:57:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[LayToanBoHangHoa]
as begin
select * from HangHoa
end;

-- SP lấy 1 hàng hóa
GO
/****** Object:  StoredProcedure [dbo].[LayToanBoHoaDon]    Script Date: 12/14/2021 7:57:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[LayToanBoHoaDon]
as begin 
select * from HoaDon
end;

-- SP lấy 1 hóa đơn
GO
/****** Object:  StoredProcedure [dbo].[LayToanBoKhachHang]    Script Date: 12/14/2021 7:57:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[LayToanBoKhachHang]
as begin
select * from KhachHang
end;

-- SP lấy 1 khách hàng
GO
/****** Object:  StoredProcedure [dbo].[LayToanBoLoaiPhong]    Script Date: 12/14/2021 7:57:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[LayToanBoLoaiPhong]
as begin
select * from LoaiPhong
end;

-- SP lấy 1 loại phòng
GO
/****** Object:  StoredProcedure [dbo].[LayToanBoNhaCungCap]    Script Date: 12/14/2021 7:57:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[LayToanBoNhaCungCap]
as begin
select * from NhaCungCap
end;

-- SP lấy 1 nhà cung cấp
GO
/****** Object:  StoredProcedure [dbo].[LayToanBoPhieuChi]    Script Date: 12/14/2021 7:57:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[LayToanBoPhieuChi]
as begin 
select * from PhieuChi
end;

-- SP lấy 1 phiếu chi
GO
/****** Object:  StoredProcedure [dbo].[LayToanBoPhong]    Script Date: 12/14/2021 7:57:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[LayToanBoPhong]
as begin
select * from Phong
end;

-- SP lấy 1 phòng
GO
/****** Object:  StoredProcedure [dbo].[LayToanBoUsers]    Script Date: 12/14/2021 7:57:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[LayToanBoUsers]
as begin
select * from Users
end;

-- SP lấy 1 User
GO
/****** Object:  StoredProcedure [dbo].[SP_Login]    Script Date: 12/14/2021 7:57:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SP_Login]
@User_name char(20),
@Password char(50)
as begin
select * from Users where User_name=@User_name and Password=@Password
end;

GO
/****** Object:  StoredProcedure [dbo].[SuaDichVu]    Script Date: 12/14/2021 7:57:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SuaDichVu]
@Id char(10), -- Mã dịch vụ
@Name nvarchar(50), -- Tên dịch vụ
@Price float -- Giá dịch vụ
as begin
update DichVu set Name=@Name, Price=@Price where Id=@Id
end;

-- SP xóa dịch vụ
GO
/****** Object:  StoredProcedure [dbo].[SuaHangHoa]    Script Date: 12/14/2021 7:57:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SuaHangHoa]
@Id char(10), -- Mã hàng hóa
@Id_sup char(10), -- Mã nhà cung cấp
@Name nvarchar(50), -- Tên hàng hóa
@Type nvarchar(50), -- Loại hàng hóa
@Price float, -- Giá
@Unit char(10) -- Đơn vị tính
as begin
update HangHoa set Id_sup=@Id_sup, Name=@Name, Type=@Type, Price=@Price, Unit=@Unit where Id=@Id
end;

-- SP xóa hàng hóa
GO
/****** Object:  StoredProcedure [dbo].[SuaHoaDon]    Script Date: 12/14/2021 7:57:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SuaHoaDon]
@Id char(10), -- Mã hóa đơn
@Id_user char(10), -- Mã nhân viên ghi hóa đơn
@Id_room char(10), -- Mã phòng
@Id_guest char(10), -- Mã khách hàng
@Date_checkin date, -- Ngày nhận phòng
@Date_checkout date, -- Ngày trả phòng
@Payment_method nvarchar(50), -- Phương thức thanh toán
@Total_price float -- Tổng giá hóa đơn
as begin
update HoaDon set Id_user=@Id_user, Id_room=@Id_room, Id_guest=@Id_guest, Date_checkin=@Date_checkin, Date_checkout=@Date_checkout, Payment_method=@Payment_method, Total_price=@Total_price where Id=@Id
end;

-- SP xóa hóa đơn
GO
/****** Object:  StoredProcedure [dbo].[SuaKhachHang]    Script Date: 12/14/2021 7:57:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SuaKhachHang]
@Id char(10), -- Mã khách hàng
@Full_name nvarchar(50), -- Họ tên
@Rank nvarchar(10), -- Xếp hạng
@Phone char(10) -- Số điện thoại
as begin
update KhachHang set Full_name=@Full_name, Rank=@Rank, Phone=@Phone where Id=@Id
end;

-- SP xóa khách hàng
GO
/****** Object:  StoredProcedure [dbo].[SuaLoaiPhong]    Script Date: 12/14/2021 7:57:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SuaLoaiPhong]
@Id char(3), -- Mã loại phòng (Lấy 3 kí tự đầu của mã phòng)
@Name nvarchar(50), -- Tên loại phòng
@Room_for_rent int, -- Số lượng phòng đã có khách thuê
@Room_ready int -- Số lượng phòng còn trống
as begin
update LoaiPhong set Name=@Name, Room_for_rent=@Room_for_rent, Room_ready=@Room_ready where Id=@Id
end;

-- SP xóa loại phòng
GO
/****** Object:  StoredProcedure [dbo].[SuaNhaCungCap]    Script Date: 12/14/2021 7:57:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SuaNhaCungCap]
@Id char(10), -- Mã nhà cung cấp
@Name nvarchar(50), -- Tên nhà cung cấp
@Phone char(10), -- Số điện thoại
@Address nvarchar(50) -- Địa chỉ
as begin
update NhaCungCap set Name=@Name, Phone=@Phone, Address=@Address where Id=@Id
end;

-- SP xóa nhà cung cấp
GO
/****** Object:  StoredProcedure [dbo].[SuaPhieuChi]    Script Date: 12/14/2021 7:57:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SuaPhieuChi]
@Id char(10), -- Mã phiếu
@Id_goods char(10), -- Mã hàng
@Id_user char(10), -- Mã user
@Total_price float, -- Tổng giá
@Date_create date, -- Ngày tạo phiếu
@Date_received date -- Ngày nhận hàng
as begin 
update PhieuChi set Id_goods=@Id_goods, Id_user=@Id_user, Total_price=@Total_price, Date_create=@Date_create, Date_received=@Date_received where Id=@Id
end;

-- Xóa phiếu chi
GO
/****** Object:  StoredProcedure [dbo].[SuaPhong]    Script Date: 12/14/2021 7:57:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SuaPhong]
@Id char(10), -- Mã phòng
@Num_of_beds int, -- Số lượng giường
@Price_per_night float, -- Giá 1 đêm
@Status nvarchar(10) -- Tình trạng phòng
as begin 
update Phong set Num_of_beds=@Num_of_beds, Price_per_night=@Price_per_night, Status=@Status where Id=@Id
end;

-- SP xóa phòng
GO
/****** Object:  StoredProcedure [dbo].[SuaUser]    Script Date: 12/14/2021 7:57:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SuaUser]
@Id char(10), -- Mã user
@Permission char(20), -- Phân quyền
@Full_name nvarchar(50), -- Họ tên
@Gender nvarchar(5), -- Giới tính
@Birthday date, -- Ngày sinh
@Address nvarchar(50), -- Địa chỉ
@Phone char(10), -- Số điện thoại
@User_name char(20), -- Tài khoản
@Password char(50) -- Mật khẩu
as begin 
update Users set Permission=@Permission, Full_name=@Full_name, Gender=@Gender, Birthday=@Birthday, Address=@Address, Phone=@Phone, User_name=@User_name, Password=@Password where Id=@Id
end;
GO
/****** Object:  StoredProcedure [dbo].[ThemDichVu]    Script Date: 12/14/2021 7:57:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ThemDichVu]
@Id char(10), -- Mã dịch vụ
@Name nvarchar(50), -- Tên dịch vụ
@Price float -- Giá dịch vụ
as begin
insert into DichVu(Id, Name, Price) values (@Id, @Name, @Price)
end;

-- SP sửa dịch vụ
GO
/****** Object:  StoredProcedure [dbo].[ThemHangHoa]    Script Date: 12/14/2021 7:57:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ThemHangHoa]
@Id char(10), -- Mã hàng hóa
@Id_sup char(10), -- Mã nhà cung cấp
@Name nvarchar(50), -- Tên hàng hóa
@Type nvarchar(50), -- Loại hàng hóa
@Price float, -- Giá
@Unit char(10) -- Đơn vị tính
as begin
insert into HangHoa(Id, Id_sup, Name, Type, Price, Unit) values (@Id, @Id_sup, @Name, @Type, @Price, @Unit)
end;

-- SP sửa hàng hóa
GO
/****** Object:  StoredProcedure [dbo].[ThemHoaDon]    Script Date: 12/14/2021 7:57:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ThemHoaDon]
@Id char(10), -- Mã hóa đơn
@Id_user char(10), -- Mã nhân viên ghi hóa đơn
@Id_room char(10), -- Mã phòng
@Id_guest char(10), -- Mã khách hàng
@Date_checkin date, -- Ngày nhận phòng
@Date_checkout date, -- Ngày trả phòng
@Payment_method nvarchar(50), -- Phương thức thanh toán
@Total_price float -- Tổng giá hóa đơn
as begin
insert into HoaDon(Id, Id_user, Id_room, Id_guest, Date_checkin, Date_checkout, Payment_method, Total_price) values (@Id, @Id_user, @Id_room, @Id_guest, @Date_checkin, @Date_checkout, @Payment_method, @Total_price)
end;

-- SP sửa hóa đơn
GO
/****** Object:  StoredProcedure [dbo].[ThemKhachHang]    Script Date: 12/14/2021 7:57:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ThemKhachHang]
@Id char(10), -- Mã khách hàng
@Full_name nvarchar(50), -- Họ tên
@Rank nvarchar(10), -- Xếp hạng
@Phone char(10) -- Số điện thoại
as begin
insert into KhachHang(Id, Full_name, Rank, Phone) values (@Id, @Full_name, @Rank, @Phone)
end;

-- SP sửa khách hàng
GO
/****** Object:  StoredProcedure [dbo].[ThemLoaiPhong]    Script Date: 12/14/2021 7:57:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ThemLoaiPhong]
@Id char(3), -- Mã loại phòng (Lấy 3 kí tự đầu của mã phòng)
@Name nvarchar(50), -- Tên loại phòng
@Room_for_rent int, -- Số lượng phòng đã có khách thuê
@Room_ready int -- Số lượng phòng còn trống
as begin
insert into LoaiPhong(Id, Name, Room_for_rent, Room_ready) values (@Id, @Name, @Room_for_rent, @Room_ready)
end;

-- SP sửa loại phòng
GO
/****** Object:  StoredProcedure [dbo].[ThemNhaCungCap]    Script Date: 12/14/2021 7:57:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ThemNhaCungCap]
@Id char(10), -- Mã nhà cung cấp
@Name nvarchar(50), -- Tên nhà cung cấp
@Phone char(10), -- Số điện thoại
@Address nvarchar(50) -- Địa chỉ
as begin
insert into NhaCungCap(Id, Name, Phone, Address) values (@Id, @Name, @Phone, @Address)
end;

-- SP sửa nhà cung cấp
GO
/****** Object:  StoredProcedure [dbo].[ThemPhieuChi]    Script Date: 12/14/2021 7:57:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ThemPhieuChi]
@Id char(10), -- Mã phiếu
@Id_goods char(10), -- Mã hàng
@Id_user char(10), -- Mã user
@Total_price float, -- Tổng giá
@Date_create date, -- Ngày tạo phiếu
@Date_received date -- Ngày nhận hàng
as begin 
insert into PhieuChi(Id, Id_goods, Id_user, Total_price, Date_create, Date_received) values (@Id, @Id_goods, @Id_user, @Total_price, @Date_create, @Date_received)
end;

-- SP sửa phiếu chi
GO
/****** Object:  StoredProcedure [dbo].[ThemPhong]    Script Date: 12/14/2021 7:57:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ThemPhong]
@Id char(10), -- Mã phòng
@Num_of_beds int, -- Số lượng giường
@Price_per_night float, -- Giá 1 đêm
@Status nvarchar(10) -- Tình trạng phòng
as begin
insert into Phong(Id, Num_of_beds, Price_per_night, Status) values (@Id, @Num_of_beds, @Price_per_night, @Status)
end;

-- SP sửa phòng
GO
/****** Object:  StoredProcedure [dbo].[ThemUser]    Script Date: 12/14/2021 7:57:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ThemUser]
@Id char(10), -- Mã user
@Permission char(20), -- Phân quyền
@Full_name nvarchar(50), -- Họ tên
@Gender nvarchar(5), -- Giới tính
@Birthday date, -- Ngày sinh
@Address nvarchar(50), -- Địa chỉ
@Phone char(10), -- Số điện thoại
@User_name char(20), -- Tài khoản
@Password char(50) -- Mật khẩu
as begin 
insert into Users(Id, Permission, Full_name, Gender, Birthday, Address, Phone, User_name, Password) values (@Id, @Permission, @Full_name, @Gender, @Birthday, @Address, @Phone, @User_name, @Password)
end;

-- SP Sửa 1 User
GO
/****** Object:  StoredProcedure [dbo].[XoaDichVu]    Script Date: 12/14/2021 7:57:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[XoaDichVu]
@Id char(10)
as begin
delete from DichVu where Id=@Id
end;

----------------------- Loại phòng ---------------------------------------
-- SP lấy toàn bộ loại phòng
GO
/****** Object:  StoredProcedure [dbo].[XoaHangHoa]    Script Date: 12/14/2021 7:57:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[XoaHangHoa]
@Id char(10)
as begin 
delete from HangHoa where Id=@Id
end;

----------------------- Phiếu chi ---------------------------------------
-- SP lấy toàn bộ phiếu chi
GO
/****** Object:  StoredProcedure [dbo].[XoaHoaDon]    Script Date: 12/14/2021 7:57:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[XoaHoaDon]
@Id char(10)
as begin
delete from HoaDon where Id=@Id
end;

----------------------- Nhà cung cấp ---------------------------------------
-- SP lấy toàn bộ nhà cung cấp
GO
/****** Object:  StoredProcedure [dbo].[XoaKhachHang]    Script Date: 12/14/2021 7:57:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[XoaKhachHang]
@Id char(10)
as begin
delete from KhachHang where Id=@Id
end;

----------------------- Phòng ---------------------------------------
-- SP lấy toàn bộ phòng
GO
/****** Object:  StoredProcedure [dbo].[XoaLoaiPhong]    Script Date: 12/14/2021 7:57:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[XoaLoaiPhong]
@Id char(10)
as begin
delete from LoaiPhong where Id=@Id
end;

----------------------- Hóa đơn ---------------------------------------
-- SP lấy toàn bộ hóa đơn
GO
/****** Object:  StoredProcedure [dbo].[XoaNhaCungCap]    Script Date: 12/14/2021 7:57:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[XoaNhaCungCap]
@Id char(10)
as begin
delete from NhaCungCap where Id=@Id
end;

----------------------- Hàng hóa ---------------------------------------
-- SP lấy toàn bộ hàng hóa
GO
/****** Object:  StoredProcedure [dbo].[XoaPhieuChi]    Script Date: 12/14/2021 7:57:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[XoaPhieuChi]
@Id char(10)
as begin
delete from PhieuChi where Id=@Id
end;

-- In danh sách hóa đơn
GO
/****** Object:  StoredProcedure [dbo].[XoaPhong]    Script Date: 12/14/2021 7:57:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[XoaPhong]
@Id char(10)
as begin
delete from Phong where Id=@Id
end;

----------------------- Dịch vụ ---------------------------------------
-- SP lấy toàn bộ dịch vụ
GO
/****** Object:  StoredProcedure [dbo].[XoaUser]    Script Date: 12/14/2021 7:57:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[XoaUser]
@Id char(10)
as begin
delete from Users where Id=@Id
end;

----------------------- Khách hàng ---------------------------------------
-- SP lấy bảng Khách hàng
GO
USE [master]
GO
ALTER DATABASE [DATABASE_QLKS] SET  READ_WRITE 
GO
