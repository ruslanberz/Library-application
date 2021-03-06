USE [master]
GO
/****** Object:  Database [library]    Script Date: 12/4/2018 4:06:37 PM ******/
CREATE DATABASE [library]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'library', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\library.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'library_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\library_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [library] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [library].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [library] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [library] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [library] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [library] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [library] SET ARITHABORT OFF 
GO
ALTER DATABASE [library] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [library] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [library] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [library] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [library] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [library] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [library] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [library] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [library] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [library] SET  DISABLE_BROKER 
GO
ALTER DATABASE [library] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [library] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [library] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [library] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [library] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [library] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [library] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [library] SET RECOVERY FULL 
GO
ALTER DATABASE [library] SET  MULTI_USER 
GO
ALTER DATABASE [library] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [library] SET DB_CHAINING OFF 
GO
ALTER DATABASE [library] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [library] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [library] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'library', N'ON'
GO
ALTER DATABASE [library] SET QUERY_STORE = OFF
GO
USE [library]
GO
/****** Object:  Table [dbo].[Books]    Script Date: 12/4/2018 4:06:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Books](
	[BookId] [int] IDENTITY(1,1) NOT NULL,
	[BookName] [nvarchar](50) NOT NULL,
	[Price] [money] NOT NULL,
	[ShelfID] [int] NOT NULL,
	[Row] [tinyint] NOT NULL,
	[IsAvailable] [bit] NOT NULL,
 CONSTRAINT [PK_Books] PRIMARY KEY CLUSTERED 
(
	[BookId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Floors]    Script Date: 12/4/2018 4:06:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Floors](
	[FloorId] [int] IDENTITY(1,1) NOT NULL,
	[FloorName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Floors] PRIMARY KEY CLUSTERED 
(
	[FloorId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderItems]    Script Date: 12/4/2018 4:06:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderItems](
	[OrderItemId] [int] IDENTITY(1,1) NOT NULL,
	[OrderID] [int] NOT NULL,
	[BookID] [int] NOT NULL,
	[Price] [money] NOT NULL,
 CONSTRAINT [PK_OrderItems] PRIMARY KEY CLUSTERED 
(
	[OrderItemId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 12/4/2018 4:06:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[OrderId] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [int] NOT NULL,
	[BookDate] [datetime] NOT NULL,
	[isReturned] [bit] NOT NULL,
 CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED 
(
	[OrderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Shelves]    Script Date: 12/4/2018 4:06:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Shelves](
	[ShelfId] [int] IDENTITY(1,1) NOT NULL,
	[ShelfName] [nvarchar](50) NOT NULL,
	[FloorID] [int] NOT NULL,
	[RowsCount] [tinyint] NOT NULL,
 CONSTRAINT [PK_Shelves] PRIMARY KEY CLUSTERED 
(
	[ShelfId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 12/4/2018 4:06:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[UserId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Surname] [nvarchar](50) NOT NULL,
	[Phone] [nvarchar](20) NOT NULL,
	[E-mail] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Books] ON 

INSERT [dbo].[Books] ([BookId], [BookName], [Price], [ShelfID], [Row], [IsAvailable]) VALUES (3, N'Qaralama', 10.6000, 2, 3, 0)
INSERT [dbo].[Books] ([BookId], [BookName], [Price], [ShelfID], [Row], [IsAvailable]) VALUES (4, N'Level UP', 5.0000, 3, 15, 1)
INSERT [dbo].[Books] ([BookId], [BookName], [Price], [ShelfID], [Row], [IsAvailable]) VALUES (5, N'3 Muşkityor', 3.0000, 4, 3, 0)
INSERT [dbo].[Books] ([BookId], [BookName], [Price], [ShelfID], [Row], [IsAvailable]) VALUES (6, N'Hack the system', 5.5000, 6, 100, 1)
INSERT [dbo].[Books] ([BookId], [BookName], [Price], [ShelfID], [Row], [IsAvailable]) VALUES (8, N'ASP.Net', 25.0000, 13, 5, 0)
INSERT [dbo].[Books] ([BookId], [BookName], [Price], [ShelfID], [Row], [IsAvailable]) VALUES (9, N'C# Basics', 15.0000, 12, 4, 0)
INSERT [dbo].[Books] ([BookId], [BookName], [Price], [ShelfID], [Row], [IsAvailable]) VALUES (10, N'ASP.Net MVC', 18.0000, 14, 5, 1)
INSERT [dbo].[Books] ([BookId], [BookName], [Price], [ShelfID], [Row], [IsAvailable]) VALUES (11, N'CCNA Guide', 10.0000, 18, 7, 1)
INSERT [dbo].[Books] ([BookId], [BookName], [Price], [ShelfID], [Row], [IsAvailable]) VALUES (12, N'CCNP Route Cert Guide', 20.0000, 15, 4, 1)
INSERT [dbo].[Books] ([BookId], [BookName], [Price], [ShelfID], [Row], [IsAvailable]) VALUES (13, N'CCNP Switch Cert Guide', 16.0000, 10, 8, 1)
SET IDENTITY_INSERT [dbo].[Books] OFF
SET IDENTITY_INSERT [dbo].[Floors] ON 

INSERT [dbo].[Floors] ([FloorId], [FloorName]) VALUES (1, N'Birinci mərtəbə')
INSERT [dbo].[Floors] ([FloorId], [FloorName]) VALUES (2, N'İkinci mərtəbə')
INSERT [dbo].[Floors] ([FloorId], [FloorName]) VALUES (3, N'Üçüncü mərtəbə')
SET IDENTITY_INSERT [dbo].[Floors] OFF
SET IDENTITY_INSERT [dbo].[OrderItems] ON 

INSERT [dbo].[OrderItems] ([OrderItemId], [OrderID], [BookID], [Price]) VALUES (1, 1, 5, 3.0000)
INSERT [dbo].[OrderItems] ([OrderItemId], [OrderID], [BookID], [Price]) VALUES (3, 3, 6, 5.5000)
INSERT [dbo].[OrderItems] ([OrderItemId], [OrderID], [BookID], [Price]) VALUES (4, 4, 8, 25.0000)
INSERT [dbo].[OrderItems] ([OrderItemId], [OrderID], [BookID], [Price]) VALUES (5, 5, 9, 15.0000)
INSERT [dbo].[OrderItems] ([OrderItemId], [OrderID], [BookID], [Price]) VALUES (6, 1, 11, 16.0000)
INSERT [dbo].[OrderItems] ([OrderItemId], [OrderID], [BookID], [Price]) VALUES (7, 6, 13, 16.0000)
INSERT [dbo].[OrderItems] ([OrderItemId], [OrderID], [BookID], [Price]) VALUES (8, 7, 4, 5.0000)
INSERT [dbo].[OrderItems] ([OrderItemId], [OrderID], [BookID], [Price]) VALUES (9, 7, 10, 18.0000)
INSERT [dbo].[OrderItems] ([OrderItemId], [OrderID], [BookID], [Price]) VALUES (10, 8, 5, 3.0000)
INSERT [dbo].[OrderItems] ([OrderItemId], [OrderID], [BookID], [Price]) VALUES (11, 9, 4, 5.0000)
INSERT [dbo].[OrderItems] ([OrderItemId], [OrderID], [BookID], [Price]) VALUES (12, 10, 5, 3.0000)
INSERT [dbo].[OrderItems] ([OrderItemId], [OrderID], [BookID], [Price]) VALUES (13, 11, 4, 5.0000)
INSERT [dbo].[OrderItems] ([OrderItemId], [OrderID], [BookID], [Price]) VALUES (14, 12, 4, 5.0000)
INSERT [dbo].[OrderItems] ([OrderItemId], [OrderID], [BookID], [Price]) VALUES (15, 13, 4, 5.0000)
INSERT [dbo].[OrderItems] ([OrderItemId], [OrderID], [BookID], [Price]) VALUES (16, 14, 12, 20.0000)
INSERT [dbo].[OrderItems] ([OrderItemId], [OrderID], [BookID], [Price]) VALUES (17, 15, 3, 10.6000)
INSERT [dbo].[OrderItems] ([OrderItemId], [OrderID], [BookID], [Price]) VALUES (18, 16, 5, 3.0000)
SET IDENTITY_INSERT [dbo].[OrderItems] OFF
SET IDENTITY_INSERT [dbo].[Orders] ON 

INSERT [dbo].[Orders] ([OrderId], [UserID], [BookDate], [isReturned]) VALUES (1, 3, CAST(N'2018-10-27T19:12:54.617' AS DateTime), 1)
INSERT [dbo].[Orders] ([OrderId], [UserID], [BookDate], [isReturned]) VALUES (3, 4, CAST(N'2018-10-28T16:38:59.773' AS DateTime), 1)
INSERT [dbo].[Orders] ([OrderId], [UserID], [BookDate], [isReturned]) VALUES (4, 5, CAST(N'2018-10-28T16:50:32.377' AS DateTime), 0)
INSERT [dbo].[Orders] ([OrderId], [UserID], [BookDate], [isReturned]) VALUES (5, 2, CAST(N'2018-10-28T16:52:19.620' AS DateTime), 0)
INSERT [dbo].[Orders] ([OrderId], [UserID], [BookDate], [isReturned]) VALUES (6, 3, CAST(N'2018-10-28T18:22:02.150' AS DateTime), 1)
INSERT [dbo].[Orders] ([OrderId], [UserID], [BookDate], [isReturned]) VALUES (7, 3, CAST(N'2018-10-28T20:25:21.030' AS DateTime), 1)
INSERT [dbo].[Orders] ([OrderId], [UserID], [BookDate], [isReturned]) VALUES (8, 1, CAST(N'2018-10-28T20:26:20.597' AS DateTime), 1)
INSERT [dbo].[Orders] ([OrderId], [UserID], [BookDate], [isReturned]) VALUES (9, 7, CAST(N'2018-10-28T21:32:20.397' AS DateTime), 1)
INSERT [dbo].[Orders] ([OrderId], [UserID], [BookDate], [isReturned]) VALUES (10, 6, CAST(N'2018-10-28T22:13:51.877' AS DateTime), 1)
INSERT [dbo].[Orders] ([OrderId], [UserID], [BookDate], [isReturned]) VALUES (11, 8, CAST(N'2018-10-29T10:27:50.373' AS DateTime), 1)
INSERT [dbo].[Orders] ([OrderId], [UserID], [BookDate], [isReturned]) VALUES (12, 9, CAST(N'2018-10-29T16:54:36.460' AS DateTime), 1)
INSERT [dbo].[Orders] ([OrderId], [UserID], [BookDate], [isReturned]) VALUES (13, 10, CAST(N'2018-10-29T18:29:41.887' AS DateTime), 1)
INSERT [dbo].[Orders] ([OrderId], [UserID], [BookDate], [isReturned]) VALUES (14, 7, CAST(N'2018-10-29T18:38:33.633' AS DateTime), 1)
INSERT [dbo].[Orders] ([OrderId], [UserID], [BookDate], [isReturned]) VALUES (15, 4, CAST(N'2018-10-29T18:49:33.570' AS DateTime), 0)
INSERT [dbo].[Orders] ([OrderId], [UserID], [BookDate], [isReturned]) VALUES (16, 3, CAST(N'2018-10-29T19:01:19.787' AS DateTime), 0)
SET IDENTITY_INSERT [dbo].[Orders] OFF
SET IDENTITY_INSERT [dbo].[Shelves] ON 

INSERT [dbo].[Shelves] ([ShelfId], [ShelfName], [FloorID], [RowsCount]) VALUES (2, N'Ədəbiyyat', 1, 10)
INSERT [dbo].[Shelves] ([ShelfId], [ShelfName], [FloorID], [RowsCount]) VALUES (3, N'Kimya', 1, 5)
INSERT [dbo].[Shelves] ([ShelfId], [ShelfName], [FloorID], [RowsCount]) VALUES (4, N'Fizika', 1, 7)
INSERT [dbo].[Shelves] ([ShelfId], [ShelfName], [FloorID], [RowsCount]) VALUES (6, N'Fantastika', 1, 20)
INSERT [dbo].[Shelves] ([ShelfId], [ShelfName], [FloorID], [RowsCount]) VALUES (7, N'Fentezi', 1, 15)
INSERT [dbo].[Shelves] ([ShelfId], [ShelfName], [FloorID], [RowsCount]) VALUES (8, N'LitRPG', 1, 10)
INSERT [dbo].[Shelves] ([ShelfId], [ShelfName], [FloorID], [RowsCount]) VALUES (9, N'RealRPG', 1, 20)
INSERT [dbo].[Shelves] ([ShelfId], [ShelfName], [FloorID], [RowsCount]) VALUES (10, N'Elmi fatnastika', 1, 10)
INSERT [dbo].[Shelves] ([ShelfId], [ShelfName], [FloorID], [RowsCount]) VALUES (11, N'Bədii ədəbiyyat', 2, 20)
INSERT [dbo].[Shelves] ([ShelfId], [ShelfName], [FloorID], [RowsCount]) VALUES (12, N'Nağıllar', 2, 10)
INSERT [dbo].[Shelves] ([ShelfId], [ShelfName], [FloorID], [RowsCount]) VALUES (13, N'Şərq ədəbiyyatı', 2, 12)
INSERT [dbo].[Shelves] ([ShelfId], [ShelfName], [FloorID], [RowsCount]) VALUES (14, N'Biologiya', 3, 100)
INSERT [dbo].[Shelves] ([ShelfId], [ShelfName], [FloorID], [RowsCount]) VALUES (15, N'Xalq ədəbiyyatı', 3, 10)
INSERT [dbo].[Shelves] ([ShelfId], [ShelfName], [FloorID], [RowsCount]) VALUES (16, N'Uzaq şərq ədəbiyyatı', 3, 20)
INSERT [dbo].[Shelves] ([ShelfId], [ShelfName], [FloorID], [RowsCount]) VALUES (18, N'Zimbabve dövlətin ədəbiyyatı', 3, 40)
SET IDENTITY_INSERT [dbo].[Shelves] OFF
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([UserId], [Name], [Surname], [Phone], [E-mail]) VALUES (1, N'Ruslan', N'Barzigyar', N'+994774202055', N'ruslan@gmail.com')
INSERT [dbo].[Users] ([UserId], [Name], [Surname], [Phone], [E-mail]) VALUES (2, N'Huseyn', N'Bağırlı', N'+994554001436', N'h.bagirli@gmail.com')
INSERT [dbo].[Users] ([UserId], [Name], [Surname], [Phone], [E-mail]) VALUES (3, N'Kamran', N'Mirzəyev', N'+994555625886', N'kamran@gmail.com')
INSERT [dbo].[Users] ([UserId], [Name], [Surname], [Phone], [E-mail]) VALUES (4, N'Ulvi', N'Ibrahimov', N'+994512458547', N'ulviia@code.edu.az')
INSERT [dbo].[Users] ([UserId], [Name], [Surname], [Phone], [E-mail]) VALUES (5, N'Həsən', N'Məmməd', N'+994552154752', N'hesen@gmail.com')
INSERT [dbo].[Users] ([UserId], [Name], [Surname], [Phone], [E-mail]) VALUES (6, N'User', N'Name', N'+1524585451', N'123@day..az')
INSERT [dbo].[Users] ([UserId], [Name], [Surname], [Phone], [E-mail]) VALUES (7, N'Alina', N'Berziqiyarova', N'+994774271927', N'alinatb@code.edu.az')
INSERT [dbo].[Users] ([UserId], [Name], [Surname], [Phone], [E-mail]) VALUES (8, N'Tural', N'Abdurahmanov', N'+994513490069', N'123@naa.az')
INSERT [dbo].[Users] ([UserId], [Name], [Surname], [Phone], [E-mail]) VALUES (9, N'Abdullabeyli', N'Aftandil', N'+994775404514', N'aa@gmail.com')
INSERT [dbo].[Users] ([UserId], [Name], [Surname], [Phone], [E-mail]) VALUES (10, N'Gulmemmed', N'Gullu', N'+994552101212', N'gul@face.az')
INSERT [dbo].[Users] ([UserId], [Name], [Surname], [Phone], [E-mail]) VALUES (11, N'User', N'Text', N'+9947521252', N'12lk@sd')
SET IDENTITY_INSERT [dbo].[Users] OFF
ALTER TABLE [dbo].[Books] ADD  CONSTRAINT [DF_Books_IsAvailable]  DEFAULT ((1)) FOR [IsAvailable]
GO
ALTER TABLE [dbo].[Books]  WITH CHECK ADD  CONSTRAINT [FK_Books_Shelves] FOREIGN KEY([ShelfID])
REFERENCES [dbo].[Shelves] ([ShelfId])
GO
ALTER TABLE [dbo].[Books] CHECK CONSTRAINT [FK_Books_Shelves]
GO
ALTER TABLE [dbo].[OrderItems]  WITH CHECK ADD  CONSTRAINT [FK_OrderItems_Books] FOREIGN KEY([BookID])
REFERENCES [dbo].[Books] ([BookId])
GO
ALTER TABLE [dbo].[OrderItems] CHECK CONSTRAINT [FK_OrderItems_Books]
GO
ALTER TABLE [dbo].[OrderItems]  WITH CHECK ADD  CONSTRAINT [FK_OrderItems_Orders] FOREIGN KEY([OrderID])
REFERENCES [dbo].[Orders] ([OrderId])
GO
ALTER TABLE [dbo].[OrderItems] CHECK CONSTRAINT [FK_OrderItems_Orders]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Users] FOREIGN KEY([UserID])
REFERENCES [dbo].[Users] ([UserId])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Users]
GO
ALTER TABLE [dbo].[Shelves]  WITH CHECK ADD  CONSTRAINT [FK_Shelves_Floors] FOREIGN KEY([FloorID])
REFERENCES [dbo].[Floors] ([FloorId])
GO
ALTER TABLE [dbo].[Shelves] CHECK CONSTRAINT [FK_Shelves_Floors]
GO
USE [master]
GO
ALTER DATABASE [library] SET  READ_WRITE 
GO
