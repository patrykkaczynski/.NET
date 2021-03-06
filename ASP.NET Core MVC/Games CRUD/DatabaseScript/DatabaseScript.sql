USE [master]
GO
/****** Object:  Database [GamesDB]    Script Date: 04.06.2021 22:37:47 ******/
CREATE DATABASE [GamesDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'GamesDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.PATRYKSQL\MSSQL\DATA\GamesDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'GamesDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.PATRYKSQL\MSSQL\DATA\GamesDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [GamesDB] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [GamesDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [GamesDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [GamesDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [GamesDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [GamesDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [GamesDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [GamesDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [GamesDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [GamesDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [GamesDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [GamesDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [GamesDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [GamesDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [GamesDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [GamesDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [GamesDB] SET  ENABLE_BROKER 
GO
ALTER DATABASE [GamesDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [GamesDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [GamesDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [GamesDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [GamesDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [GamesDB] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [GamesDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [GamesDB] SET RECOVERY FULL 
GO
ALTER DATABASE [GamesDB] SET  MULTI_USER 
GO
ALTER DATABASE [GamesDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [GamesDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [GamesDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [GamesDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [GamesDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [GamesDB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'GamesDB', N'ON'
GO
ALTER DATABASE [GamesDB] SET QUERY_STORE = OFF
GO
USE [GamesDB]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 04.06.2021 22:37:48 ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Games]    Script Date: 04.06.2021 22:37:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Games](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](50) NOT NULL,
	[YearOfRelease] [int] NOT NULL,
	[ProducerId] [int] NOT NULL,
	[GenreId] [int] NOT NULL,
	[ModeId] [int] NOT NULL,
 CONSTRAINT [PK_Games] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Genres]    Script Date: 04.06.2021 22:37:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Genres](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[GenreName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Genres] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Modes]    Script Date: 04.06.2021 22:37:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Modes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ModeName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Modes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Producers]    Script Date: 04.06.2021 22:37:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Producers](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Producers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210531072220_Initial-migration', N'5.0.6')
GO
SET IDENTITY_INSERT [dbo].[Games] ON 

INSERT [dbo].[Games] ([Id], [Title], [YearOfRelease], [ProducerId], [GenreId], [ModeId]) VALUES (17, N'Far Cry 5', 2018, 1, 3, 3)
INSERT [dbo].[Games] ([Id], [Title], [YearOfRelease], [ProducerId], [GenreId], [ModeId]) VALUES (18, N'Counter-Strike: Global Offensive', 2012, 5, 3, 2)
INSERT [dbo].[Games] ([Id], [Title], [YearOfRelease], [ProducerId], [GenreId], [ModeId]) VALUES (19, N'Watch Dogs 2', 2016, 1, 4, 3)
INSERT [dbo].[Games] ([Id], [Title], [YearOfRelease], [ProducerId], [GenreId], [ModeId]) VALUES (20, N'Grand Theft Auto V', 2015, 6, 5, 3)
INSERT [dbo].[Games] ([Id], [Title], [YearOfRelease], [ProducerId], [GenreId], [ModeId]) VALUES (21, N'Half-Life 2', 2004, 5, 3, 1)
INSERT [dbo].[Games] ([Id], [Title], [YearOfRelease], [ProducerId], [GenreId], [ModeId]) VALUES (22, N'Wiedźmin 3: Dziki Gon', 2015, 3, 2, 1)
INSERT [dbo].[Games] ([Id], [Title], [YearOfRelease], [ProducerId], [GenreId], [ModeId]) VALUES (23, N'Cyberpunk 2077', 2020, 3, 2, 1)
INSERT [dbo].[Games] ([Id], [Title], [YearOfRelease], [ProducerId], [GenreId], [ModeId]) VALUES (24, N'FIFA 21', 2021, 7, 6, 3)
INSERT [dbo].[Games] ([Id], [Title], [YearOfRelease], [ProducerId], [GenreId], [ModeId]) VALUES (25, N'Heroes of Might and Magic V', 2006, 1, 1, 3)
SET IDENTITY_INSERT [dbo].[Games] OFF
GO
SET IDENTITY_INSERT [dbo].[Genres] ON 

INSERT [dbo].[Genres] ([Id], [GenreName]) VALUES (1, N'Strategiczna gra turowa')
INSERT [dbo].[Genres] ([Id], [GenreName]) VALUES (2, N'Fabularna gra akcji')
INSERT [dbo].[Genres] ([Id], [GenreName]) VALUES (3, N'Strzelanka pierwszoosobowa')
INSERT [dbo].[Genres] ([Id], [GenreName]) VALUES (4, N'Przygodowa gra akcji')
INSERT [dbo].[Genres] ([Id], [GenreName]) VALUES (5, N'Gra akcji')
INSERT [dbo].[Genres] ([Id], [GenreName]) VALUES (6, N'Gra sportowa')
SET IDENTITY_INSERT [dbo].[Genres] OFF
GO
SET IDENTITY_INSERT [dbo].[Modes] ON 

INSERT [dbo].[Modes] ([Id], [ModeName]) VALUES (1, N'Gra jednoosobowa')
INSERT [dbo].[Modes] ([Id], [ModeName]) VALUES (2, N'Gra wieloosobowa')
INSERT [dbo].[Modes] ([Id], [ModeName]) VALUES (3, N'Gra jednoosobowa, Gra wieloosobowa')
SET IDENTITY_INSERT [dbo].[Modes] OFF
GO
SET IDENTITY_INSERT [dbo].[Producers] ON 

INSERT [dbo].[Producers] ([Id], [Name]) VALUES (1, N'Ubisoft')
INSERT [dbo].[Producers] ([Id], [Name]) VALUES (3, N'CD Projekt Red')
INSERT [dbo].[Producers] ([Id], [Name]) VALUES (5, N'Valve')
INSERT [dbo].[Producers] ([Id], [Name]) VALUES (6, N'Rockstar North')
INSERT [dbo].[Producers] ([Id], [Name]) VALUES (7, N'EA Sports')
SET IDENTITY_INSERT [dbo].[Producers] OFF
GO
/****** Object:  Index [IX_Games_GenreId]    Script Date: 04.06.2021 22:37:48 ******/
CREATE NONCLUSTERED INDEX [IX_Games_GenreId] ON [dbo].[Games]
(
	[GenreId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Games_ModeId]    Script Date: 04.06.2021 22:37:48 ******/
CREATE NONCLUSTERED INDEX [IX_Games_ModeId] ON [dbo].[Games]
(
	[ModeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Games_ProducerId]    Script Date: 04.06.2021 22:37:48 ******/
CREATE NONCLUSTERED INDEX [IX_Games_ProducerId] ON [dbo].[Games]
(
	[ProducerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Games]  WITH CHECK ADD  CONSTRAINT [FK_Games_Genres_GenreId] FOREIGN KEY([GenreId])
REFERENCES [dbo].[Genres] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Games] CHECK CONSTRAINT [FK_Games_Genres_GenreId]
GO
ALTER TABLE [dbo].[Games]  WITH CHECK ADD  CONSTRAINT [FK_Games_Modes_ModeId] FOREIGN KEY([ModeId])
REFERENCES [dbo].[Modes] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Games] CHECK CONSTRAINT [FK_Games_Modes_ModeId]
GO
ALTER TABLE [dbo].[Games]  WITH CHECK ADD  CONSTRAINT [FK_Games_Producers_ProducerId] FOREIGN KEY([ProducerId])
REFERENCES [dbo].[Producers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Games] CHECK CONSTRAINT [FK_Games_Producers_ProducerId]
GO
USE [master]
GO
ALTER DATABASE [GamesDB] SET  READ_WRITE 
GO
