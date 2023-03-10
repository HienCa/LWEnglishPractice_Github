USE [master]
GO
/****** Object:  Database [ListenAndWrite]    Script Date: 3/10/2023 11:26:43 AM ******/
CREATE DATABASE [ListenAndWrite]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ListenAndWrite', FILENAME = N'D:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\ListenAndWrite.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ListenAndWrite_log', FILENAME = N'D:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\ListenAndWrite_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [ListenAndWrite] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ListenAndWrite].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ListenAndWrite] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ListenAndWrite] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ListenAndWrite] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ListenAndWrite] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ListenAndWrite] SET ARITHABORT OFF 
GO
ALTER DATABASE [ListenAndWrite] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ListenAndWrite] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ListenAndWrite] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ListenAndWrite] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ListenAndWrite] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ListenAndWrite] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ListenAndWrite] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ListenAndWrite] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ListenAndWrite] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ListenAndWrite] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ListenAndWrite] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ListenAndWrite] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ListenAndWrite] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ListenAndWrite] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ListenAndWrite] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ListenAndWrite] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ListenAndWrite] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ListenAndWrite] SET RECOVERY FULL 
GO
ALTER DATABASE [ListenAndWrite] SET  MULTI_USER 
GO
ALTER DATABASE [ListenAndWrite] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ListenAndWrite] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ListenAndWrite] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ListenAndWrite] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ListenAndWrite] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ListenAndWrite] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'ListenAndWrite', N'ON'
GO
ALTER DATABASE [ListenAndWrite] SET QUERY_STORE = OFF
GO
USE [ListenAndWrite]
GO
/****** Object:  Table [dbo].[HISTORY]    Script Date: 3/10/2023 11:26:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HISTORY](
	[IDHISTORY] [int] IDENTITY(1,1) NOT NULL,
	[SCORE] [int] NULL,
	[FINISHTIME] [int] NULL,
	[FINISHDATE] [datetime] NULL,
	[IDLEARNER] [int] NOT NULL,
	[IDLESSON] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IDHISTORY] ASC,
	[IDLEARNER] ASC,
	[IDLESSON] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LEARNER]    Script Date: 3/10/2023 11:26:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LEARNER](
	[IDLEARNER] [int] IDENTITY(1,1) NOT NULL,
	[FULLNAME] [nvarchar](255) NOT NULL,
	[EMAIL] [nvarchar](255) NOT NULL,
	[PASSWORD] [nvarchar](255) NOT NULL,
	[IMAGE] [nvarchar](255) NULL,
	[JOINDATE] [datetime] NOT NULL,
	[DATEOFBIRTH] [datetime] NULL,
	[SEX] [nvarchar](255) NULL,
	[ACTIVE] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IDLEARNER] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LESSON]    Script Date: 3/10/2023 11:26:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LESSON](
	[IDLESSON] [int] IDENTITY(1,1) NOT NULL,
	[LESSONANME] [nvarchar](255) NOT NULL,
	[DATECREATE] [datetime] NOT NULL,
	[DESCRIBE] [nvarchar](4000) NULL,
	[ACTIVE] [int] NOT NULL,
	[IDLEVEL] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IDLESSON] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LEVEL]    Script Date: 3/10/2023 11:26:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LEVEL](
	[IDLEVEL] [int] IDENTITY(1,1) NOT NULL,
	[LEVEL] [int] NULL,
	[LEVELNAME] [nvarchar](255) NULL,
	[ACTIVE] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IDLEVEL] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TRACK]    Script Date: 3/10/2023 11:26:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TRACK](
	[IDTRACK] [int] IDENTITY(1,1) NOT NULL,
	[TRACKNAME] [nvarchar](255) NULL,
	[SOURCE] [nvarchar](255) NOT NULL,
	[DATEUPLOAD] [datetime] NOT NULL,
	[DURATION] [int] NULL,
	[DESCRIBE] [nvarchar](4000) NOT NULL,
	[ACTIVE] [int] NOT NULL,
	[IDLESSON] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IDTRACK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[HISTORY] ON 

INSERT [dbo].[HISTORY] ([IDHISTORY], [SCORE], [FINISHTIME], [FINISHDATE], [IDLEARNER], [IDLESSON]) VALUES (1, 109, 5, CAST(N'2023-02-27T09:32:07.603' AS DateTime), 2, 9)
INSERT [dbo].[HISTORY] ([IDHISTORY], [SCORE], [FINISHTIME], [FINISHDATE], [IDLEARNER], [IDLESSON]) VALUES (2, 109, 4, CAST(N'2023-02-27T09:34:49.847' AS DateTime), 2, 9)
INSERT [dbo].[HISTORY] ([IDHISTORY], [SCORE], [FINISHTIME], [FINISHDATE], [IDLEARNER], [IDLESSON]) VALUES (3, 100, 5, CAST(N'2023-03-08T21:57:11.200' AS DateTime), 2, 19)
INSERT [dbo].[HISTORY] ([IDHISTORY], [SCORE], [FINISHTIME], [FINISHDATE], [IDLEARNER], [IDLESSON]) VALUES (4, 96, 7, CAST(N'2023-03-08T22:09:53.793' AS DateTime), 4, 19)
INSERT [dbo].[HISTORY] ([IDHISTORY], [SCORE], [FINISHTIME], [FINISHDATE], [IDLEARNER], [IDLESSON]) VALUES (5, 98, 6, CAST(N'2023-03-08T22:12:16.740' AS DateTime), 3, 19)
INSERT [dbo].[HISTORY] ([IDHISTORY], [SCORE], [FINISHTIME], [FINISHDATE], [IDLEARNER], [IDLESSON]) VALUES (6, 80, 12, CAST(N'2023-03-08T22:19:33.053' AS DateTime), 3, 21)
INSERT [dbo].[HISTORY] ([IDHISTORY], [SCORE], [FINISHTIME], [FINISHDATE], [IDLEARNER], [IDLESSON]) VALUES (9, 72, 19, CAST(N'2023-03-10T11:17:40.093' AS DateTime), 8, 19)
SET IDENTITY_INSERT [dbo].[HISTORY] OFF
GO
SET IDENTITY_INSERT [dbo].[LEARNER] ON 

INSERT [dbo].[LEARNER] ([IDLEARNER], [FULLNAME], [EMAIL], [PASSWORD], [IMAGE], [JOINDATE], [DATEOFBIRTH], [SEX], [ACTIVE]) VALUES (2, N'Nguyễn Văn Hiền', N'nguyenvanhien050601@gmail.com', N'vanhien0', N'ae856fc0-36a9-4f75-9ac7-5e243d1864ae_anhthe8.jpg', CAST(N'2023-02-16T00:00:00.000' AS DateTime), CAST(N'1990-07-12T00:00:00.000' AS DateTime), N'Name', 1)
INSERT [dbo].[LEARNER] ([IDLEARNER], [FULLNAME], [EMAIL], [PASSWORD], [IMAGE], [JOINDATE], [DATEOFBIRTH], [SEX], [ACTIVE]) VALUES (3, N'Nguyễn Tuấn Bảo', N'tuanbao.1005@gmail.com', N'tnmt12345', N'cf9619de-adbd-46c5-a2bc-d9b58002310d_anhthe7.jpg', CAST(N'2023-02-25T17:27:27.903' AS DateTime), CAST(N'2001-01-11T00:00:00.000' AS DateTime), N'Nam', 1)
INSERT [dbo].[LEARNER] ([IDLEARNER], [FULLNAME], [EMAIL], [PASSWORD], [IMAGE], [JOINDATE], [DATEOFBIRTH], [SEX], [ACTIVE]) VALUES (4, N'Đặng Thị Như Ý', N'vanhiena4@gmail.com', N'vanhien0', N'760acf9a-2ab5-4c03-9c2e-45d4e1f66722_anhthe19.png', CAST(N'2023-02-27T00:00:00.000' AS DateTime), CAST(N'2001-05-06T00:00:00.000' AS DateTime), N'Nữ', 1)
INSERT [dbo].[LEARNER] ([IDLEARNER], [FULLNAME], [EMAIL], [PASSWORD], [IMAGE], [JOINDATE], [DATEOFBIRTH], [SEX], [ACTIVE]) VALUES (8, N'long than', N'nguyenlongthan0@gmail.com', N'123455678', N'fc2a9c6e-fd4a-41ef-9e56-f59e3091c9f3_anhthe9.jpg', CAST(N'2023-03-10T11:04:02.000' AS DateTime), CAST(N'2002-02-11T00:00:00.000' AS DateTime), N'Name', 1)
SET IDENTITY_INSERT [dbo].[LEARNER] OFF
GO
SET IDENTITY_INSERT [dbo].[LESSON] ON 

INSERT [dbo].[LESSON] ([IDLESSON], [LESSONANME], [DATECREATE], [DESCRIBE], [ACTIVE], [IDLEVEL]) VALUES (9, N'How are you?', CAST(N'2023-03-04T00:00:00.000' AS DateTime), N'abcd', 0, 1)
INSERT [dbo].[LESSON] ([IDLESSON], [LESSONANME], [DATECREATE], [DESCRIBE], [ACTIVE], [IDLEVEL]) VALUES (17, N'What is your name?', CAST(N'2023-02-25T00:00:00.000' AS DateTime), N'abc', 1, 2)
INSERT [dbo].[LESSON] ([IDLESSON], [LESSONANME], [DATECREATE], [DESCRIBE], [ACTIVE], [IDLEVEL]) VALUES (18, N'Where are you from?', CAST(N'2023-02-25T00:00:00.000' AS DateTime), N'gigi', 1, 3)
INSERT [dbo].[LESSON] ([IDLESSON], [LESSONANME], [DATECREATE], [DESCRIBE], [ACTIVE], [IDLEVEL]) VALUES (19, N'Names of countries 1?', CAST(N'2023-03-08T00:00:00.000' AS DateTime), N'Luyện nghe và viết tên các quốc gia 1', 1, 1)
INSERT [dbo].[LESSON] ([IDLESSON], [LESSONANME], [DATECREATE], [DESCRIBE], [ACTIVE], [IDLEVEL]) VALUES (20, N'Names of countries 2?', CAST(N'2023-03-08T00:00:00.000' AS DateTime), N'Luyện nghe và viết tên các quốc gia 2', 1, 1)
INSERT [dbo].[LESSON] ([IDLESSON], [LESSONANME], [DATECREATE], [DESCRIBE], [ACTIVE], [IDLEVEL]) VALUES (21, N'Names of countries 3?', CAST(N'2023-03-08T00:00:00.000' AS DateTime), N'Luyện nghe và viết tên các quốc gia 3', 1, 1)
INSERT [dbo].[LESSON] ([IDLESSON], [LESSONANME], [DATECREATE], [DESCRIBE], [ACTIVE], [IDLEVEL]) VALUES (22, N'Names of countries 4?', CAST(N'2023-03-09T00:00:00.000' AS DateTime), N'Luyện nghe và viết tên các quốc gia 4', 1, 1)
INSERT [dbo].[LESSON] ([IDLESSON], [LESSONANME], [DATECREATE], [DESCRIBE], [ACTIVE], [IDLEVEL]) VALUES (23, N'Names of countries 5?', CAST(N'2023-03-09T00:00:00.000' AS DateTime), N'Luyện nghe và viết tên các quốc gia 5', 1, 1)
INSERT [dbo].[LESSON] ([IDLESSON], [LESSONANME], [DATECREATE], [DESCRIBE], [ACTIVE], [IDLEVEL]) VALUES (24, N'What is your name 1?', CAST(N'2023-03-10T00:00:00.000' AS DateTime), N'Luyện nghe và viết tên riêng 1', 1, 1)
INSERT [dbo].[LESSON] ([IDLESSON], [LESSONANME], [DATECREATE], [DESCRIBE], [ACTIVE], [IDLEVEL]) VALUES (25, N'What is your name 2?', CAST(N'2023-03-10T00:00:00.000' AS DateTime), N'Luyện nghe và viết tên riêng 2', 1, 1)
INSERT [dbo].[LESSON] ([IDLESSON], [LESSONANME], [DATECREATE], [DESCRIBE], [ACTIVE], [IDLEVEL]) VALUES (26, N'What is your name 3?', CAST(N'2023-03-10T00:00:00.000' AS DateTime), N'Luyện nghe và viết tên riêng 3', 1, 1)
INSERT [dbo].[LESSON] ([IDLESSON], [LESSONANME], [DATECREATE], [DESCRIBE], [ACTIVE], [IDLEVEL]) VALUES (27, N'What is your name 4?', CAST(N'2023-03-10T09:29:51.030' AS DateTime), N'write name', 1, 1)
INSERT [dbo].[LESSON] ([IDLESSON], [LESSONANME], [DATECREATE], [DESCRIBE], [ACTIVE], [IDLEVEL]) VALUES (28, N'Infomation', CAST(N'2023-03-10T10:44:32.630' AS DateTime), N'aa', 1, 3)
INSERT [dbo].[LESSON] ([IDLESSON], [LESSONANME], [DATECREATE], [DESCRIBE], [ACTIVE], [IDLEVEL]) VALUES (29, N'Introduce yourself', CAST(N'2023-03-10T10:49:07.830' AS DateTime), N'introduce', 1, 3)
SET IDENTITY_INSERT [dbo].[LESSON] OFF
GO
SET IDENTITY_INSERT [dbo].[LEVEL] ON 

INSERT [dbo].[LEVEL] ([IDLEVEL], [LEVEL], [LEVELNAME], [ACTIVE]) VALUES (1, 1, N'Level 1', 1)
INSERT [dbo].[LEVEL] ([IDLEVEL], [LEVEL], [LEVELNAME], [ACTIVE]) VALUES (2, 2, N'Level 2', 1)
INSERT [dbo].[LEVEL] ([IDLEVEL], [LEVEL], [LEVELNAME], [ACTIVE]) VALUES (3, 3, N'Level 3', 1)
SET IDENTITY_INSERT [dbo].[LEVEL] OFF
GO
SET IDENTITY_INSERT [dbo].[TRACK] ON 

INSERT [dbo].[TRACK] ([IDTRACK], [TRACKNAME], [SOURCE], [DATEUPLOAD], [DURATION], [DESCRIBE], [ACTIVE], [IDLESSON]) VALUES (13, N'1', N'eb2d381b-bed2-4e5e-8d92-714e17c78178_04_1.mp3', CAST(N'2023-03-03T16:09:37.320' AS DateTime), 8, N'and what is your last name again? it is Miller. it is spelled M I L L E R.', 1, 9)
INSERT [dbo].[TRACK] ([IDTRACK], [TRACKNAME], [SOURCE], [DATEUPLOAD], [DURATION], [DESCRIBE], [ACTIVE], [IDLESSON]) VALUES (14, N'2', N'638c600a-62d6-4620-b06a-5112b6b1969e_04_2.mp3', CAST(N'2023-03-03T16:13:46.057' AS DateTime), 4, N'what is your name again? ok, my first name is Maria.', 1, 9)
INSERT [dbo].[TRACK] ([IDTRACK], [TRACKNAME], [SOURCE], [DATEUPLOAD], [DURATION], [DESCRIBE], [ACTIVE], [IDLESSON]) VALUES (15, N'3', N'efd7030f-e417-4c4a-bb12-2a27186fa901_04_2_3.mp3', CAST(N'2023-03-03T16:15:34.707' AS DateTime), 5, N'my last name is spelled T A N A K A', 1, 9)
INSERT [dbo].[TRACK] ([IDTRACK], [TRACKNAME], [SOURCE], [DATEUPLOAD], [DURATION], [DESCRIBE], [ACTIVE], [IDLESSON]) VALUES (16, N'1', N'dab7e4d3-f106-4ba9-b6ec-eae60f8252a8_06_1.mp3', CAST(N'2023-03-03T16:22:06.167' AS DateTime), 11, N'i am Elizabeth Sheen from Finland. you can call me Liz, it is spelled L I Z, easy to remember. i am studying computer science.', 1, 17)
INSERT [dbo].[TRACK] ([IDTRACK], [TRACKNAME], [SOURCE], [DATEUPLOAD], [DURATION], [DESCRIBE], [ACTIVE], [IDLESSON]) VALUES (17, N'2', N'c4854289-1c83-4307-a79b-33f66a3f2bca_06_2.mp3', CAST(N'2023-03-03T16:24:03.513' AS DateTime), 9, N'hi, i am Chris, C H R I S, from the United States. i am studying engineering', 1, 17)
INSERT [dbo].[TRACK] ([IDTRACK], [TRACKNAME], [SOURCE], [DATEUPLOAD], [DURATION], [DESCRIBE], [ACTIVE], [IDLESSON]) VALUES (18, N'3', N'24a7cf92-1296-45bd-a8e8-ffb234094997_06_3.mp3', CAST(N'2023-03-03T16:24:58.987' AS DateTime), 7, N'my name is Paulo White and i come from Japan, and i am studying English', 1, 17)
INSERT [dbo].[TRACK] ([IDTRACK], [TRACKNAME], [SOURCE], [DATEUPLOAD], [DURATION], [DESCRIBE], [ACTIVE], [IDLESSON]) VALUES (19, N'1', N'50d83dc6-bd3a-44e1-a74e-9070ccad9b08_09_1.mp3', CAST(N'2023-03-03T16:32:13.637' AS DateTime), 23, N'Linda, this is Marti. he is from Canada. nice to meet you. i am Linda Mandel. i come from Brazil. oh, hello. and what is your last name, again? Mandel, M A N D E L. what do you study here, Linda? i study Business.', 1, 18)
INSERT [dbo].[TRACK] ([IDTRACK], [TRACKNAME], [SOURCE], [DATEUPLOAD], [DURATION], [DESCRIBE], [ACTIVE], [IDLESSON]) VALUES (20, N'2', N'b2262dc1-d041-4b8c-9cbf-accb38517239_09_2.mp3', CAST(N'2023-03-03T16:35:19.990' AS DateTime), 20, N'hi, i am Joseph Block from Finland. please call me Joe. hello Joe. what is your last name again? it is Block, B L O C K. what are you studying now? Engineering. oh Engineering. that sounds interesting.', 0, 18)
INSERT [dbo].[TRACK] ([IDTRACK], [TRACKNAME], [SOURCE], [DATEUPLOAD], [DURATION], [DESCRIBE], [ACTIVE], [IDLESSON]) VALUES (21, N'3', N'22f68148-0e03-4799-91e6-266ed85830d9_09_3.mp3', CAST(N'2023-03-03T16:41:01.060' AS DateTime), 35, N'ok, Ms. Maclain. let me just check this information. it is your first name spelled E L L E N? no. my first name is Elena. it is spelled E L E N A. ok, thanks. and you are from Brazil, correct? no, i am not from Brazil. i am from Mexico. oh, sorry. Mexico. but you are studying English, right? yes, that is right.', 0, 18)
INSERT [dbo].[TRACK] ([IDTRACK], [TRACKNAME], [SOURCE], [DATEUPLOAD], [DURATION], [DESCRIBE], [ACTIVE], [IDLESSON]) VALUES (22, N'1', N'c7dc3cca-c47b-4e6b-940f-62d57060083d_VietNam.mp3', CAST(N'2023-03-08T20:57:15.500' AS DateTime), 2, N'Vietnam', 1, 19)
INSERT [dbo].[TRACK] ([IDTRACK], [TRACKNAME], [SOURCE], [DATEUPLOAD], [DURATION], [DESCRIBE], [ACTIVE], [IDLESSON]) VALUES (23, N'2', N'40133157-ead1-4bf9-ac91-67d2543bdcc4_Cambodia.mp3', CAST(N'2023-03-08T20:57:43.107' AS DateTime), 2, N'Cambodia', 1, 19)
INSERT [dbo].[TRACK] ([IDTRACK], [TRACKNAME], [SOURCE], [DATEUPLOAD], [DURATION], [DESCRIBE], [ACTIVE], [IDLESSON]) VALUES (24, N'3', N'c065a6a1-4026-457e-b3c0-35f78d4bfe3c_China.mp3', CAST(N'2023-03-08T20:58:06.430' AS DateTime), 1, N'China', 1, 19)
INSERT [dbo].[TRACK] ([IDTRACK], [TRACKNAME], [SOURCE], [DATEUPLOAD], [DURATION], [DESCRIBE], [ACTIVE], [IDLESSON]) VALUES (25, N'1', N'afd99b35-2dde-4032-8c39-90c1aaa4322d_Timor-Leste.mp3', CAST(N'2023-03-08T21:00:13.553' AS DateTime), 2, N'Timor-Leste', 1, 20)
INSERT [dbo].[TRACK] ([IDTRACK], [TRACKNAME], [SOURCE], [DATEUPLOAD], [DURATION], [DESCRIBE], [ACTIVE], [IDLESSON]) VALUES (26, N'2', N'd2651408-0254-4efa-abd8-0c15881ddc7c_Japan.mp3', CAST(N'2023-03-08T21:00:49.003' AS DateTime), 1, N'Japan', 1, 20)
INSERT [dbo].[TRACK] ([IDTRACK], [TRACKNAME], [SOURCE], [DATEUPLOAD], [DURATION], [DESCRIBE], [ACTIVE], [IDLESSON]) VALUES (27, N'3', N'9dc46c8b-fd17-44a9-a0ff-3f2c05413f7d_SouthKorea.mp3', CAST(N'2023-03-08T21:01:33.267' AS DateTime), 2, N'South Korea', 1, 20)
INSERT [dbo].[TRACK] ([IDTRACK], [TRACKNAME], [SOURCE], [DATEUPLOAD], [DURATION], [DESCRIBE], [ACTIVE], [IDLESSON]) VALUES (28, N'4', N'3d10bb4f-1a75-4b2a-a163-3b7f32467e5f_NorthKorea.mp3', CAST(N'2023-03-08T21:02:20.767' AS DateTime), 1, N'North Korea', 1, 20)
INSERT [dbo].[TRACK] ([IDTRACK], [TRACKNAME], [SOURCE], [DATEUPLOAD], [DURATION], [DESCRIBE], [ACTIVE], [IDLESSON]) VALUES (29, N'1', N'c4706d02-b81b-45a4-b860-4c3f4d3b1ed4_Singapore.mp3', CAST(N'2023-03-08T21:03:19.250' AS DateTime), 2, N'Singapore', 1, 21)
INSERT [dbo].[TRACK] ([IDTRACK], [TRACKNAME], [SOURCE], [DATEUPLOAD], [DURATION], [DESCRIBE], [ACTIVE], [IDLESSON]) VALUES (30, N'2', N'd13870f2-814d-4414-97b6-2d1fdb991d02_Philipines.mp3', CAST(N'2023-03-08T21:03:45.143' AS DateTime), 2, N'Philippines', 1, 21)
INSERT [dbo].[TRACK] ([IDTRACK], [TRACKNAME], [SOURCE], [DATEUPLOAD], [DURATION], [DESCRIBE], [ACTIVE], [IDLESSON]) VALUES (31, N'3', N'8a3920bd-1ea5-406b-b7cd-882a6d16c582_Bangladesh.mp3', CAST(N'2023-03-08T21:04:06.013' AS DateTime), 3, N'Bangladesh', 0, 9)
INSERT [dbo].[TRACK] ([IDTRACK], [TRACKNAME], [SOURCE], [DATEUPLOAD], [DURATION], [DESCRIBE], [ACTIVE], [IDLESSON]) VALUES (32, N'4', N'bb4556d1-0bad-4cf1-91a7-4396c5c0b8dd_Mongolia.mp3', CAST(N'2023-03-08T21:04:33.627' AS DateTime), 1, N'Mongolia', 0, 9)
INSERT [dbo].[TRACK] ([IDTRACK], [TRACKNAME], [SOURCE], [DATEUPLOAD], [DURATION], [DESCRIBE], [ACTIVE], [IDLESSON]) VALUES (33, N'3', N'3c486cfb-aab6-4106-8ee4-e2672174decf_Bangladesh.mp3', CAST(N'2023-03-09T19:06:22.323' AS DateTime), 3, N'Bangladesh', 1, 21)
INSERT [dbo].[TRACK] ([IDTRACK], [TRACKNAME], [SOURCE], [DATEUPLOAD], [DURATION], [DESCRIBE], [ACTIVE], [IDLESSON]) VALUES (34, N'4', N'ab938532-b3b5-4af3-9968-62f8e32043e2_Mongolia.mp3', CAST(N'2023-03-09T19:06:42.800' AS DateTime), 1, N'Mongolia', 1, 21)
INSERT [dbo].[TRACK] ([IDTRACK], [TRACKNAME], [SOURCE], [DATEUPLOAD], [DURATION], [DESCRIBE], [ACTIVE], [IDLESSON]) VALUES (35, N'1', N'5b007fcd-3f14-40c3-9da4-da9899ec45b3_Philipines.mp3', CAST(N'2023-03-09T21:56:55.260' AS DateTime), 2, N'Philippines', 1, 22)
INSERT [dbo].[TRACK] ([IDTRACK], [TRACKNAME], [SOURCE], [DATEUPLOAD], [DURATION], [DESCRIBE], [ACTIVE], [IDLESSON]) VALUES (36, N'2', N'71cdf667-2e43-4a5f-837f-48ab35f248b8_Cambodia.mp3', CAST(N'2023-03-09T21:57:17.663' AS DateTime), 2, N'Cambodia', 1, 22)
INSERT [dbo].[TRACK] ([IDTRACK], [TRACKNAME], [SOURCE], [DATEUPLOAD], [DURATION], [DESCRIBE], [ACTIVE], [IDLESSON]) VALUES (37, N'3', N'e5f50848-617a-4bc6-b9a1-5d0738195a3b_Mongolia.mp3', CAST(N'2023-03-09T21:57:38.483' AS DateTime), 1, N'Mongolia', 1, 22)
INSERT [dbo].[TRACK] ([IDTRACK], [TRACKNAME], [SOURCE], [DATEUPLOAD], [DURATION], [DESCRIBE], [ACTIVE], [IDLESSON]) VALUES (38, N'4', N'354bdb9a-ea60-41fd-bb83-8797b68398f0_Bangladesh.mp3', CAST(N'2023-03-09T21:57:56.267' AS DateTime), 3, N'Bangladesh', 1, 22)
INSERT [dbo].[TRACK] ([IDTRACK], [TRACKNAME], [SOURCE], [DATEUPLOAD], [DURATION], [DESCRIBE], [ACTIVE], [IDLESSON]) VALUES (39, N'1', N'c294a4f4-c022-4794-ba70-7c521ade6ba9_Japan.mp3', CAST(N'2023-03-09T21:58:48.000' AS DateTime), 1, N'Japan', 1, 23)
INSERT [dbo].[TRACK] ([IDTRACK], [TRACKNAME], [SOURCE], [DATEUPLOAD], [DURATION], [DESCRIBE], [ACTIVE], [IDLESSON]) VALUES (40, N'2', N'2af07fb7-5971-4174-9347-2ec3e2a819f0_Timor-Leste.mp3', CAST(N'2023-03-09T21:59:07.390' AS DateTime), 2, N'Timor-Leste', 1, 23)
INSERT [dbo].[TRACK] ([IDTRACK], [TRACKNAME], [SOURCE], [DATEUPLOAD], [DURATION], [DESCRIBE], [ACTIVE], [IDLESSON]) VALUES (41, N'3', N'6772c992-9fbc-4117-9895-ea66cfe41337_SouthKorea.mp3', CAST(N'2023-03-09T21:59:37.807' AS DateTime), 2, N'South Korea', 1, 23)
INSERT [dbo].[TRACK] ([IDTRACK], [TRACKNAME], [SOURCE], [DATEUPLOAD], [DURATION], [DESCRIBE], [ACTIVE], [IDLESSON]) VALUES (42, N'1', N'97ba2d43-a58d-403c-8573-a6552b732b12_05_1.mp3', CAST(N'2023-03-10T09:22:44.707' AS DateTime), 4, N'my name is Kevin Smith. K E V I N.', 1, 24)
INSERT [dbo].[TRACK] ([IDTRACK], [TRACKNAME], [SOURCE], [DATEUPLOAD], [DURATION], [DESCRIBE], [ACTIVE], [IDLESSON]) VALUES (43, N'2', N'b521e266-21b6-4684-8b7b-b39d60e034cb_05_2.mp3', CAST(N'2023-03-10T09:23:10.103' AS DateTime), 5, N'my name is Sue Jenkins. S U E, Sue.', 1, 24)
INSERT [dbo].[TRACK] ([IDTRACK], [TRACKNAME], [SOURCE], [DATEUPLOAD], [DURATION], [DESCRIBE], [ACTIVE], [IDLESSON]) VALUES (44, N'3', N'933ea661-a9ff-4206-b46c-ab94ed452520_05_3.mp3', CAST(N'2023-03-10T09:23:41.887' AS DateTime), 5, N'i am Peter White. P E T E R, Peter.', 0, 17)
INSERT [dbo].[TRACK] ([IDTRACK], [TRACKNAME], [SOURCE], [DATEUPLOAD], [DURATION], [DESCRIBE], [ACTIVE], [IDLESSON]) VALUES (45, N'1', N'cb426f90-f752-4af5-9641-d00bf31ba6e6_05_4.mp3', CAST(N'2023-03-10T09:25:42.700' AS DateTime), 5, N'i am Sally Green. S A L L Y, Sally.', 1, 25)
INSERT [dbo].[TRACK] ([IDTRACK], [TRACKNAME], [SOURCE], [DATEUPLOAD], [DURATION], [DESCRIBE], [ACTIVE], [IDLESSON]) VALUES (46, N'2', N'c7685eb2-eab6-4bdc-9ddb-52dbd4f1a001_05_6.mp3', CAST(N'2023-03-10T09:26:08.793' AS DateTime), 5, N'i am Mary Snow. M A R Y, Mary.', 1, 17)
INSERT [dbo].[TRACK] ([IDTRACK], [TRACKNAME], [SOURCE], [DATEUPLOAD], [DURATION], [DESCRIBE], [ACTIVE], [IDLESSON]) VALUES (47, N'3', N'b9716cd9-8030-4080-a37f-0843036d2762_05_7.mp3', CAST(N'2023-03-10T09:26:29.247' AS DateTime), 5, N'i am Steve Hansen. S T E V E, Steve.', 0, 25)
INSERT [dbo].[TRACK] ([IDTRACK], [TRACKNAME], [SOURCE], [DATEUPLOAD], [DURATION], [DESCRIBE], [ACTIVE], [IDLESSON]) VALUES (48, N'1', N'8fb4256e-286c-4889-89b9-e7774d8e4da3_05_8.mp3', CAST(N'2023-03-10T09:27:40.463' AS DateTime), 5, N'i am James Smith. J A M E S, James.', 1, 26)
INSERT [dbo].[TRACK] ([IDTRACK], [TRACKNAME], [SOURCE], [DATEUPLOAD], [DURATION], [DESCRIBE], [ACTIVE], [IDLESSON]) VALUES (49, N'2', N'91af244d-4f20-474e-80d8-5db51e2e9e03_05_9.mp3', CAST(N'2023-03-10T09:28:21.263' AS DateTime), 2, N'this is my friend Linda.', 1, 26)
INSERT [dbo].[TRACK] ([IDTRACK], [TRACKNAME], [SOURCE], [DATEUPLOAD], [DURATION], [DESCRIBE], [ACTIVE], [IDLESSON]) VALUES (50, N'1', N'1df2ecaf-358f-4b10-9110-161bb6916e7f_05_3.mp3', CAST(N'2023-03-10T09:30:15.250' AS DateTime), 5, N'i am Peter White. P E T E R, Peter.', 1, 27)
INSERT [dbo].[TRACK] ([IDTRACK], [TRACKNAME], [SOURCE], [DATEUPLOAD], [DURATION], [DESCRIBE], [ACTIVE], [IDLESSON]) VALUES (51, N'2', N'8655f18f-7f03-4487-83c2-c289ddc4967b_05_7.mp3', CAST(N'2023-03-10T09:30:41.913' AS DateTime), 5, N'i am Steve Hansen. S T E V E, Steve.', 0, 17)
INSERT [dbo].[TRACK] ([IDTRACK], [TRACKNAME], [SOURCE], [DATEUPLOAD], [DURATION], [DESCRIBE], [ACTIVE], [IDLESSON]) VALUES (52, N'2', N'4e103c85-01b6-40f2-a13f-df1fc957135c_05_7.mp3', CAST(N'2023-03-10T09:31:52.617' AS DateTime), 5, N'i am Steve Hansen. S T E V E, Steve.', 1, 27)
INSERT [dbo].[TRACK] ([IDTRACK], [TRACKNAME], [SOURCE], [DATEUPLOAD], [DURATION], [DESCRIBE], [ACTIVE], [IDLESSON]) VALUES (53, N'1', N'ccd3aa86-359c-4a26-93ff-e7c105e2974b_09_3.mp3', CAST(N'2023-03-10T10:45:45.280' AS DateTime), 35, N'ok, Ms. Maclain. let me just check this information. it is your first name spelled E L L E N? no. my first name is Elena. it is spelled E L E N A. ok, thanks. and you are from Brazil, correct? no, i am not from Brazil. i am from Mexico. oh, sorry. Mexico. but you are studying English, right? yes, that is right.', 1, 28)
INSERT [dbo].[TRACK] ([IDTRACK], [TRACKNAME], [SOURCE], [DATEUPLOAD], [DURATION], [DESCRIBE], [ACTIVE], [IDLESSON]) VALUES (54, N'1', N'7b46462f-15d7-42d2-932f-ac4a5531be65_09_2.mp3', CAST(N'2023-03-10T10:49:28.087' AS DateTime), 20, N'hi, i am Joseph Block from Finland. please call me Joe. hello Joe. what is your last name again? it is Block, B L O C K. what are you studying now? Engineering. oh Engineering. that sounds interesting.', 1, 17)
SET IDENTITY_INSERT [dbo].[TRACK] OFF
GO
ALTER TABLE [dbo].[LEARNER] ADD  DEFAULT ((1)) FOR [ACTIVE]
GO
ALTER TABLE [dbo].[LESSON] ADD  DEFAULT ((1)) FOR [ACTIVE]
GO
ALTER TABLE [dbo].[LEVEL] ADD  DEFAULT ((1)) FOR [ACTIVE]
GO
ALTER TABLE [dbo].[TRACK] ADD  DEFAULT ((1)) FOR [ACTIVE]
GO
ALTER TABLE [dbo].[HISTORY]  WITH CHECK ADD  CONSTRAINT [FKHISTORY104111] FOREIGN KEY([IDLEARNER])
REFERENCES [dbo].[LEARNER] ([IDLEARNER])
GO
ALTER TABLE [dbo].[HISTORY] CHECK CONSTRAINT [FKHISTORY104111]
GO
ALTER TABLE [dbo].[HISTORY]  WITH CHECK ADD  CONSTRAINT [FKHISTORY918407] FOREIGN KEY([IDLESSON])
REFERENCES [dbo].[LESSON] ([IDLESSON])
GO
ALTER TABLE [dbo].[HISTORY] CHECK CONSTRAINT [FKHISTORY918407]
GO
ALTER TABLE [dbo].[LESSON]  WITH CHECK ADD  CONSTRAINT [FKLESSON775544] FOREIGN KEY([IDLEVEL])
REFERENCES [dbo].[LEVEL] ([IDLEVEL])
GO
ALTER TABLE [dbo].[LESSON] CHECK CONSTRAINT [FKLESSON775544]
GO
ALTER TABLE [dbo].[TRACK]  WITH CHECK ADD  CONSTRAINT [FKTRACK916765] FOREIGN KEY([IDLESSON])
REFERENCES [dbo].[LESSON] ([IDLESSON])
GO
ALTER TABLE [dbo].[TRACK] CHECK CONSTRAINT [FKTRACK916765]
GO
USE [master]
GO
ALTER DATABASE [ListenAndWrite] SET  READ_WRITE 
GO
