USE [master]
GO
/****** Object:  Database [TasksDB]    Script Date: 16.08.2021 00:35:11 ******/
CREATE DATABASE [TasksDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'TasksDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.PATRYKSQL\MSSQL\DATA\TasksDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'TasksDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.PATRYKSQL\MSSQL\DATA\TasksDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [TasksDB] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TasksDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [TasksDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [TasksDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [TasksDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [TasksDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [TasksDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [TasksDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [TasksDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [TasksDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [TasksDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [TasksDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [TasksDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [TasksDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [TasksDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [TasksDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [TasksDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [TasksDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [TasksDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [TasksDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [TasksDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [TasksDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [TasksDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [TasksDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [TasksDB] SET RECOVERY FULL 
GO
ALTER DATABASE [TasksDB] SET  MULTI_USER 
GO
ALTER DATABASE [TasksDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [TasksDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [TasksDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [TasksDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [TasksDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [TasksDB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'TasksDB', N'ON'
GO
ALTER DATABASE [TasksDB] SET QUERY_STORE = OFF
GO
USE [TasksDB]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 16.08.2021 00:35:12 ******/
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
/****** Object:  Table [dbo].[TaskViewModels]    Script Date: 16.08.2021 00:35:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaskViewModels](
	[TaskId] [int] IDENTITY(1,1) NOT NULL,
	[ApplicationName] [nvarchar](50) NOT NULL,
	[Title] [nvarchar](50) NOT NULL,
	[Priority] [nvarchar](max) NULL,
	[Description] [nvarchar](2000) NOT NULL,
	[Done] [bit] NOT NULL,
	[timeCreation] [datetime2](7) NOT NULL,
	[timeEdition] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_TaskViewModels] PRIMARY KEY CLUSTERED 
(
	[TaskId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210815121152_initial-migration', N'5.0.9')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210815122014_Second-migration', N'5.0.9')
GO
SET IDENTITY_INSERT [dbo].[TaskViewModels] ON 

INSERT [dbo].[TaskViewModels] ([TaskId], [ApplicationName], [Title], [Priority], [Description], [Done], [timeCreation], [timeEdition]) VALUES (13, N'Visual Studio', N'Problem z debugowaniem', N'Średni', N'Kompilator wyświetla błąd - Error', 1, CAST(N'2021-08-15T21:49:00.0948363' AS DateTime2), CAST(N'2021-08-15T21:49:00.0952669' AS DateTime2))
INSERT [dbo].[TaskViewModels] ([TaskId], [ApplicationName], [Title], [Priority], [Description], [Done], [timeCreation], [timeEdition]) VALUES (15, N'Visual Studio', N'Problem z debugowaniem', N'Średni', N'Wyświetlenie komunikatu z błędem przy naciśnięciu opcji Debug', 0, CAST(N'2021-08-16T00:01:05.7719612' AS DateTime2), CAST(N'2021-08-16T00:01:05.7723975' AS DateTime2))
INSERT [dbo].[TaskViewModels] ([TaskId], [ApplicationName], [Title], [Priority], [Description], [Done], [timeCreation], [timeEdition]) VALUES (16, N'TeamSpeak', N'Problem z mikrofonem i dźwiękiem', N'Wysoki', N'Brak dźwięku podczas rozmowy', 0, CAST(N'2021-08-16T00:03:51.3528351' AS DateTime2), CAST(N'2021-08-16T00:03:51.3528471' AS DateTime2))
INSERT [dbo].[TaskViewModels] ([TaskId], [ApplicationName], [Title], [Priority], [Description], [Done], [timeCreation], [timeEdition]) VALUES (17, N'Outlook', N'Zwiększenie pojemności skrzynki pocztowej', N'Niski', N'Zwiększenie pojemności skrzynki pocztowej z 2 GB do 98 GB', 0, CAST(N'2021-08-16T00:04:50.1209408' AS DateTime2), CAST(N'2021-08-16T00:11:33.4345347' AS DateTime2))
INSERT [dbo].[TaskViewModels] ([TaskId], [ApplicationName], [Title], [Priority], [Description], [Done], [timeCreation], [timeEdition]) VALUES (18, N'Discord', N'Opcja nagrywania jest nieaktywna', N'Niski', N'Opcja nagrywanie jest nieaktywna', 0, CAST(N'2021-08-16T00:09:31.1484824' AS DateTime2), CAST(N'2021-08-16T00:14:58.1413931' AS DateTime2))
SET IDENTITY_INSERT [dbo].[TaskViewModels] OFF
GO
ALTER TABLE [dbo].[TaskViewModels] ADD  DEFAULT ('0001-01-01T00:00:00.0000000') FOR [timeCreation]
GO
ALTER TABLE [dbo].[TaskViewModels] ADD  DEFAULT ('0001-01-01T00:00:00.0000000') FOR [timeEdition]
GO
USE [master]
GO
ALTER DATABASE [TasksDB] SET  READ_WRITE 
GO
