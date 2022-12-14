use QuanLyDuLich
GO
ALTER DATABASE [QuanLyDuLich] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QuanLyDuLich] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QuanLyDuLich] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QuanLyDuLich] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QuanLyDuLich] SET ARITHABORT OFF 
GO
ALTER DATABASE [QuanLyDuLich] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QuanLyDuLich] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QuanLyDuLich] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLyDuLich] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QuanLyDuLich] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QuanLyDuLich] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QuanLyDuLich] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QuanLyDuLich] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QuanLyDuLich] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QuanLyDuLich] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QuanLyDuLich] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QuanLyDuLich] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QuanLyDuLich] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QuanLyDuLich] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QuanLyDuLich] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QuanLyDuLich] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QuanLyDuLich] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QuanLyDuLich] SET RECOVERY FULL 
GO
ALTER DATABASE [QuanLyDuLich] SET  MULTI_USER 
GO
ALTER DATABASE [QuanLyDuLich] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QuanLyDuLich] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QuanLyDuLich] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QuanLyDuLich] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
EXEC sys.sp_db_vardecimal_storage_format N'QuanLyDuLich', N'ON'
GO
USE [QuanLyDuLich]
GO
/****** Object:  Table [dbo].[Comment]    Script Date: 9/11/2022 9:38:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Comment](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[NoiDung] [nvarchar](max) NOT NULL,
	[TinTucID] [int] NOT NULL,
	[UserID] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DonDatTour]    Script Date: 9/11/2022 9:38:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DonDatTour](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[DonGia] [money] NOT NULL,
	[SoLuong] [int] NOT NULL,
	[TongTien] [money] NOT NULL,
	[TourID] [int] NOT NULL,
	[UserID] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LichTrinh]    Script Date: 9/11/2022 9:38:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LichTrinh](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[TieuDe] [nvarchar](50) NOT NULL,
	[NoiDung] [nvarchar](max) NOT NULL,
	[TourID] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TinTuc]    Script Date: 9/11/2022 9:38:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TinTuc](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[ChuDe] [nvarchar](255) NOT NULL,
	[NoiDung] [nvarchar](max) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tour]    Script Date: 9/11/2022 9:38:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tour](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[TenTour] [nvarchar](255) NOT NULL,
	[DonGia] [money] NULL,
	[LoaiTour] [nvarchar](255) NOT NULL,
	[NgayKhoiHanh] [datetime] NULL,
	[NgayKetThuc] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 9/11/2022 9:38:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[UserName] [nvarchar](50) NOT NULL,
	[Pass] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[PhoneNumber] [nvarchar](50) NULL,
	[IsActive] [bit] NULL,
	[Role] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Comment] ON 

INSERT [dbo].[Comment] ([id], [NoiDung], [TinTucID], [UserID]) VALUES (1, N'Rất bổ ích', 3, 3)
INSERT [dbo].[Comment] ([id], [NoiDung], [TinTucID], [UserID]) VALUES (2, N'Kiến thức thú vị', 4, 2)
INSERT [dbo].[Comment] ([id], [NoiDung], [TinTucID], [UserID]) VALUES (3, N'Wow', 2, 3)
INSERT [dbo].[Comment] ([id], [NoiDung], [TinTucID], [UserID]) VALUES (4, N'Let''s go', 5, 3)
INSERT [dbo].[Comment] ([id], [NoiDung], [TinTucID], [UserID]) VALUES (5, N'Phải làm một chuyến thôi', 5, 2)
SET IDENTITY_INSERT [dbo].[Comment] OFF
GO
SET IDENTITY_INSERT [dbo].[DonDatTour] ON 

INSERT [dbo].[DonDatTour] ([id], [DonGia], [SoLuong], [TongTien], [TourID], [UserID]) VALUES (1, 1200000.0000, 2, 2400000.0000, 2, 3)
INSERT [dbo].[DonDatTour] ([id], [DonGia], [SoLuong], [TongTien], [TourID], [UserID]) VALUES (2, 2100000.0000, 3, 6300000.0000, 1, 2)
INSERT [dbo].[DonDatTour] ([id], [DonGia], [SoLuong], [TongTien], [TourID], [UserID]) VALUES (3, 18000000.0000, 1, 18000000.0000, 3, 1)
INSERT [dbo].[DonDatTour] ([id], [DonGia], [SoLuong], [TongTien], [TourID], [UserID]) VALUES (4, 1200000.0000, 4, 4800000.0000, 2, 3)
INSERT [dbo].[DonDatTour] ([id], [DonGia], [SoLuong], [TongTien], [TourID], [UserID]) VALUES (5, 4500000.0000, 5, 22500000.0000, 5, 3)
SET IDENTITY_INSERT [dbo].[DonDatTour] OFF
GO
SET IDENTITY_INSERT [dbo].[LichTrinh] ON 

INSERT [dbo].[LichTrinh] ([id], [TieuDe], [NoiDung], [TourID]) VALUES (1, N'Ngày 1 Phú Quốc', N'Ngày 1 - Du thuyền, ăn trưa, dạo phố', 1)
INSERT [dbo].[LichTrinh] ([id], [TieuDe], [NoiDung], [TourID]) VALUES (2, N'Ngày 2 Phú Quốc', N'Ngày 2 - PHÚ QUỐC - HÒN THƠM - TRẢI NGHIỆM CÁP TREO VƯỢT BIỂN (Ăn 3 bữa: sáng, trưa, chiều)', 1)
INSERT [dbo].[LichTrinh] ([id], [TieuDe], [NoiDung], [TourID]) VALUES (3, N'Ngày 1 Maldives', N'Trưởng đoàn AlexanderThinhTourist đón Quý khách tại cổng hẹn ở sân bay Tân Sơn Nhất làm thủ tục đáp chuyến bay tới Male – thủ đô Maldives (quá cảnh Singapore). Tới Male, nhân viên của resort sẽ đón và đưa Quý khách về nhận phòng tại resort tiêu chuẩn 4*.', 3)
INSERT [dbo].[LichTrinh] ([id], [TieuDe], [NoiDung], [TourID]) VALUES (4, N'Ngày 2 Maldives', N'Ăn sáng trong khu resort. Quý khách bắt đầu hành trình khám phá Maldives - vùng đất được mệnh danh là thiên đường, nơi ánh mặt trời ấm áp, cát trắng, biển, nước xanh ngắt luôn bao quanh. Quý khách có thể đi tham quan các hòn đảo lân cận gần khu resort, tìm hiểu đời sống, cách sinh hoạt của người dân Maldivians trên đảo (chi phí tự túc).', 3)
INSERT [dbo].[LichTrinh] ([id], [TieuDe], [NoiDung], [TourID]) VALUES (6, N'Ngày 1 Đà Lạt', N'Fairytale Land & hầm rượu vang Vĩnh Tiến: đến đây du khách như lạc vào khu vườn cổ tích của những chú lùn Hobbiton, điểm xuyến trong khu vườn là những ngôi nhà độc đáo và đầy sắc màu, Ga Đà Lạt: nhà ga cổ kính nhất Việt Nam và Đông Dương, có phong cách kiến trúc độc đáo với ba mái hình chóp cách điệu như ba đỉnh núi Langbiang và nhà rông Tây Nguyên.', 2)
INSERT [dbo].[LichTrinh] ([id], [TieuDe], [NoiDung], [TourID]) VALUES (7, N'Ngày 2 Đà Lạt', N'Mê Linh Coffee: được thiết kế với không gian mở có một tầm nhìn trọn vẹn 360 độ hướng rẫy cà phê bạt ngàn... Đặc biệt, thưởng thức một ly cà phê chồn nguyên chất với hương vị đậm đà đặc trưng của chất xạ hương (chi phí tự túc), Pupp Farm: du khách thỏa thích tạo dáng cùng những chú cún siêu dễ thương hay chọn cho mình những góc chụp đẹp bên đồi hoa ngoài trời rực rỡ, vườn dâu công nghệ cao, bí khổng lồ, dưa pepino, cà chua bi,… (theo mùa).', 2)
SET IDENTITY_INSERT [dbo].[LichTrinh] OFF
GO
SET IDENTITY_INSERT [dbo].[TinTuc] ON 

INSERT [dbo].[TinTuc] ([id], [ChuDe], [NoiDung]) VALUES (2, N'Cung điện Hải Vương, địa điểm vui chơi mới ở VinWonders Phú Quốc ', N'Cung điện Hải Vương – nơi tái hiện cuộc sống đáy biển sâu của hàng trăm nghìn sinh vật biển là địa điểm du lịch Phú Quốc mới 2022 ở VinWonders đang thu hút du khách thập phương đến chiêm ngưỡng nhất hiện nay. Vậy cung điện này có gì, cùng nhau khám phá nhé! Sẽ không quá lời khi nói không gian trong thủy cung thực sự như “mỹ cảnh”. Mang trong mình 5 thế giới đại dương vô cùng kỳ thú, cung điện Hải Vương Phú Quốc tái hiện sinh động thế giới ở dưới đại dương xanh với 255.000 sinh vật biển quý hiếm đủ kích cở và màu sắc đang tự do bơi lượn. ')
INSERT [dbo].[TinTuc] ([id], [ChuDe], [NoiDung]) VALUES (3, N'Du lịch lễ 30-4 xịn xò, giá siêu tiết kiệm', N'Có thể thấy xu hướng du lịch tự túc hiện là sự lựa chọn phổ biến của nhiều bạn trẻ bởi tính năng động, thoải mái hơn và linh hoạt hành trình, Tuy nhiên, bạn cần phải lên kế hoạch tài chính sớm từ nhiều tháng trước khi khởi hành để “săn” được vé máy bay/tàu/xe giá rẻ hoặc giữ phòng khách sạn giá tốt. Do đó có thể thấy, du lịch trọn gói (du lịch theo tour) chính là lựa chọn hàng đầu trong những dịp Lễ như thế này.')
INSERT [dbo].[TinTuc] ([id], [ChuDe], [NoiDung]) VALUES (4, N'Trải nghiệm trực thăng cực chill ngắm Sài Gòn từ trên cao', N'Tour trực thăng ngắm TP.HCM từ trên cao là sản phẩm du lịch mới nhất được ngành du lịch thành phố đưa vào khai thác dịp Lễ 30/4 năm nay với giá bay ưu đãi trong chuyến đầu là 4,08 triệu đồng/khách với thời gian 40 phút.  Không chỉ là một đô thị sống động TP.HCM còn có rừng, có núi, có biển và hệ thống sông ngòi dày đặc sẽ mang đến cho bạn những phút giây chill thật chill cùng trải nghiệm khác biệt khi tham gia tour trực thăng bởi ở tầm nhìn đặc trưng. Điểm nhấn của hành trình này chính là ngắm trung tâm thành phố với những kiến trúc cổ kính, hiện đại gắn liền cùng lịch sử hình thành và phát triển của thành phố qua các địa điểm du lịch Sài Gòn nổi tiếng như Cầu Phú Mỹ - Bến cảng Nhà Rồng - Cầu Thủ Thiêm - Tòa tháp Landmark 81.')
INSERT [dbo].[TinTuc] ([id], [ChuDe], [NoiDung]) VALUES (5, N'Hành trình hùng vĩ Tây Nguyên tại Buôn Ma Thuột', N'Được tạp chí Wanderlust mệnh danh là Thủ Phủ Cà Phê, Buôn Ma Thuột đang là một trong những địa điểm du lịch mới hấp dẫn hiện nay. Vậy, vùng đất này có những điều thú vị gì? Hãy cùng khám phá đôi nét về Buôn Ma Thuột trong bài viết dưới đây nhé.')
INSERT [dbo].[TinTuc] ([id], [ChuDe], [NoiDung]) VALUES (6, N'Khám phá thiên đường vui chơi giải trí cho giới trẻ tại Phú Quốc', N'Phú Quốc được nhiều du khách ca tụng và ưu ái gọi dưới cái tên “thiên đường đảo ngọc”. Tuy nhiên bên cạnh vẻ đẹp thiên nhiên mơ mộng, hòn đảo này cũng sở hữu nhiều địa điểm giải trí hấp dẫn cho giới trẻ. Hãy cùng điểm qua những tụ điểm vui chơi, tham quan không thể bỏ qua tại Phú Quốc ngay sau đây.')
SET IDENTITY_INSERT [dbo].[TinTuc] OFF
GO
SET IDENTITY_INSERT [dbo].[Tour] ON 

INSERT [dbo].[Tour] ([id], [TenTour], [DonGia], [LoaiTour], [NgayKhoiHanh], [NgayKetThuc]) VALUES (1, N'Tour Phú Quốc', 2100000.0000, N'Tour trong nước', NULL, NULL)
INSERT [dbo].[Tour] ([id], [TenTour], [DonGia], [LoaiTour], [NgayKhoiHanh], [NgayKetThuc]) VALUES (2, N'Tour Đà Lạt', 1200000.0000, N'Tour trong nước', NULL, NULL)
INSERT [dbo].[Tour] ([id], [TenTour], [DonGia], [LoaiTour], [NgayKhoiHanh], [NgayKetThuc]) VALUES (3, N'Tour Maldives', 18000000.0000, N'Tour quốc tế', NULL, NULL)
INSERT [dbo].[Tour] ([id], [TenTour], [DonGia], [LoaiTour], [NgayKhoiHanh], [NgayKetThuc]) VALUES (4, N'Tour Đà Nẵng', 3000000.0000, N'Tour trong nước', NULL, NULL)
INSERT [dbo].[Tour] ([id], [TenTour], [DonGia], [LoaiTour], [NgayKhoiHanh], [NgayKetThuc]) VALUES (5, N'Tour Thái Lan', 4500000.0000, N'Tour quốc tế', NULL, NULL)
SET IDENTITY_INSERT [dbo].[Tour] OFF
GO
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([id], [FirstName], [LastName], [UserName], [Pass], [Email], [PhoneNumber], [IsActive], [Role]) VALUES (1, N'Thịnh', N'Alexander', N'AlexanderThinh', N'123', N'alexanderthinh@gmail.com', NULL, 1, N'admin')
INSERT [dbo].[Users] ([id], [FirstName], [LastName], [UserName], [Pass], [Email], [PhoneNumber], [IsActive], [Role]) VALUES (2, N'Thu', N'Nguyễn', N'NguyenVanThu', N'123', N'vanthu@gmail.com', NULL, 1, N'user')
INSERT [dbo].[Users] ([id], [FirstName], [LastName], [UserName], [Pass], [Email], [PhoneNumber], [IsActive], [Role]) VALUES (3, N'Hiếu', N'Nguyễn', N'NguyenNgocHieu', N'123', N'ngochieu@gmail.com', NULL, 1, N'user')
INSERT [dbo].[Users] ([id], [FirstName], [LastName], [UserName], [Pass], [Email], [PhoneNumber], [IsActive], [Role]) VALUES (4, N'Trung', N'Quang', N'QuangTrung', N'123', N'quangtrung@gmail.com', NULL, 1, N'staff')
INSERT [dbo].[Users] ([id], [FirstName], [LastName], [UserName], [Pass], [Email], [PhoneNumber], [IsActive], [Role]) VALUES (5, N'Tuấn', N'Bùi', N'BuiTuan', N'123', N'buituan@gmail.com', NULL, 1, N'staff')
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
ALTER TABLE [dbo].[Comment]  WITH CHECK ADD FOREIGN KEY([TinTucID])
REFERENCES [dbo].[TinTuc] ([id])
GO
ALTER TABLE [dbo].[Comment]  WITH CHECK ADD FOREIGN KEY([UserID])
REFERENCES [dbo].[Users] ([id])
GO
ALTER TABLE [dbo].[DonDatTour]  WITH CHECK ADD FOREIGN KEY([TourID])
REFERENCES [dbo].[Tour] ([id])
GO
ALTER TABLE [dbo].[DonDatTour]  WITH CHECK ADD FOREIGN KEY([UserID])
REFERENCES [dbo].[Users] ([id])
GO
ALTER TABLE [dbo].[LichTrinh]  WITH CHECK ADD FOREIGN KEY([TourID])
REFERENCES [dbo].[Tour] ([id])
GO
USE [master]
GO
ALTER DATABASE [QuanLyDuLich] SET  READ_WRITE 
GO
