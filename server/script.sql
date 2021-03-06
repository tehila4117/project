USE [master]
GO
/****** Object:  Database [StudentPlacement]    Script Date: 02/05/2022 11:45:54 ******/
CREATE DATABASE [StudentPlacement]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'StudentPlacement', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\StudentPlacement.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'StudentPlacement_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\StudentPlacement_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [StudentPlacement] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [StudentPlacement].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [StudentPlacement] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [StudentPlacement] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [StudentPlacement] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [StudentPlacement] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [StudentPlacement] SET ARITHABORT OFF 
GO
ALTER DATABASE [StudentPlacement] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [StudentPlacement] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [StudentPlacement] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [StudentPlacement] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [StudentPlacement] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [StudentPlacement] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [StudentPlacement] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [StudentPlacement] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [StudentPlacement] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [StudentPlacement] SET  DISABLE_BROKER 
GO
ALTER DATABASE [StudentPlacement] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [StudentPlacement] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [StudentPlacement] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [StudentPlacement] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [StudentPlacement] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [StudentPlacement] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [StudentPlacement] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [StudentPlacement] SET RECOVERY FULL 
GO
ALTER DATABASE [StudentPlacement] SET  MULTI_USER 
GO
ALTER DATABASE [StudentPlacement] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [StudentPlacement] SET DB_CHAINING OFF 
GO
ALTER DATABASE [StudentPlacement] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [StudentPlacement] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [StudentPlacement] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [StudentPlacement] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'StudentPlacement', N'ON'
GO
ALTER DATABASE [StudentPlacement] SET QUERY_STORE = OFF
GO
USE [StudentPlacement]
GO
/****** Object:  Table [dbo].[AreasInCity]    Script Date: 02/05/2022 11:45:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AreasInCity](
	[AreaCityCode] [bigint] NOT NULL,
	[NameAreaCity] [nvarchar](50) NULL,
	[CityCode] [bigint] NULL,
 CONSTRAINT [PK_AreasInCity] PRIMARY KEY CLUSTERED 
(
	[AreaCityCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cities]    Script Date: 02/05/2022 11:45:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cities](
	[CityCode] [bigint] NOT NULL,
	[CityName] [nvarchar](50) NULL,
 CONSTRAINT [PK_Cities] PRIMARY KEY CLUSTERED 
(
	[CityCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EducationalInstitutions]    Script Date: 02/05/2022 11:45:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EducationalInstitutions](
	[EducationalInstitutionCode] [bigint] NOT NULL,
	[InstitutionName] [nvarchar](50) NULL,
 CONSTRAINT [PK_educationalInstitutions] PRIMARY KEY CLUSTERED 
(
	[EducationalInstitutionCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Inlays]    Script Date: 02/05/2022 11:45:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Inlays](
	[InlayCode] [bigint] NOT NULL,
	[InlayName] [nvarchar](50) NULL,
	[InlayDate] [date] NULL,
	[InstitutionCode] [bigint] NULL,
 CONSTRAINT [PK_Inlays] PRIMARY KEY CLUSTERED 
(
	[InlayCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[InlaySlot]    Script Date: 02/05/2022 11:45:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[InlaySlot](
	[SlotCode] [bigint] NOT NULL,
	[InlayCode] [bigint] NULL,
	[StudentCode] [bigint] NULL,
	[NumOfClass] [int] NULL,
 CONSTRAINT [PK_InlaySlot] PRIMARY KEY CLUSTERED 
(
	[SlotCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[School]    Script Date: 02/05/2022 11:45:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[School](
	[InstitutionCode] [bigint] NOT NULL,
	[userName] [nvarchar](50) NULL,
	[Password] [int] NULL,
	[NumberOfChildrenInClass] [int] NULL,
 CONSTRAINT [PK_School] PRIMARY KEY CLUSTERED 
(
	[InstitutionCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Students]    Script Date: 02/05/2022 11:45:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Students](
	[StudentCode] [bigint] NOT NULL,
	[StudentName] [nvarchar](50) NULL,
	[AreaCityCode] [bigint] NULL,
	[GradePointAverage] [float] NULL,
	[SocialInvolvement] [int] NULL,
	[PreviousSchoolCode] [bigint] NULL,
	[InstitutionCode] [bigint] NULL,
 CONSTRAINT [PK_Students] PRIMARY KEY CLUSTERED 
(
	[StudentCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[AreasInCity]  WITH CHECK ADD  CONSTRAINT [FK_AreasInCity_Cities] FOREIGN KEY([CityCode])
REFERENCES [dbo].[Cities] ([CityCode])
GO
ALTER TABLE [dbo].[AreasInCity] CHECK CONSTRAINT [FK_AreasInCity_Cities]
GO
ALTER TABLE [dbo].[Inlays]  WITH CHECK ADD  CONSTRAINT [FK_Inlays_School] FOREIGN KEY([InstitutionCode])
REFERENCES [dbo].[School] ([InstitutionCode])
GO
ALTER TABLE [dbo].[Inlays] CHECK CONSTRAINT [FK_Inlays_School]
GO
ALTER TABLE [dbo].[InlaySlot]  WITH CHECK ADD  CONSTRAINT [FK_InlaySlot_Inlays] FOREIGN KEY([InlayCode])
REFERENCES [dbo].[Inlays] ([InlayCode])
GO
ALTER TABLE [dbo].[InlaySlot] CHECK CONSTRAINT [FK_InlaySlot_Inlays]
GO
ALTER TABLE [dbo].[Students]  WITH CHECK ADD  CONSTRAINT [FK_Students_AreasInCity] FOREIGN KEY([AreaCityCode])
REFERENCES [dbo].[AreasInCity] ([AreaCityCode])
GO
ALTER TABLE [dbo].[Students] CHECK CONSTRAINT [FK_Students_AreasInCity]
GO
ALTER TABLE [dbo].[Students]  WITH CHECK ADD  CONSTRAINT [FK_Students_EducationalInstitutions] FOREIGN KEY([PreviousSchoolCode])
REFERENCES [dbo].[EducationalInstitutions] ([EducationalInstitutionCode])
GO
ALTER TABLE [dbo].[Students] CHECK CONSTRAINT [FK_Students_EducationalInstitutions]
GO
ALTER TABLE [dbo].[Students]  WITH CHECK ADD  CONSTRAINT [FK_Students_School] FOREIGN KEY([InstitutionCode])
REFERENCES [dbo].[School] ([InstitutionCode])
GO
ALTER TABLE [dbo].[Students] CHECK CONSTRAINT [FK_Students_School]
GO
USE [master]
GO
ALTER DATABASE [StudentPlacement] SET  READ_WRITE 
GO
