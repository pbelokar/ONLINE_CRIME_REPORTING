USE [master]
GO
/****** Object:  Database [CriminalRecordManagement]    Script Date: 04-08-2019 00:30:31 ******/
CREATE DATABASE [CriminalRecordManagement]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'CriminalRecordManagement', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\CriminalRecordManagement.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'CriminalRecordManagement_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\CriminalRecordManagement_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [CriminalRecordManagement] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [CriminalRecordManagement].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [CriminalRecordManagement] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [CriminalRecordManagement] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [CriminalRecordManagement] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [CriminalRecordManagement] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [CriminalRecordManagement] SET ARITHABORT OFF 
GO
ALTER DATABASE [CriminalRecordManagement] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [CriminalRecordManagement] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [CriminalRecordManagement] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [CriminalRecordManagement] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [CriminalRecordManagement] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [CriminalRecordManagement] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [CriminalRecordManagement] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [CriminalRecordManagement] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [CriminalRecordManagement] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [CriminalRecordManagement] SET  DISABLE_BROKER 
GO
ALTER DATABASE [CriminalRecordManagement] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [CriminalRecordManagement] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [CriminalRecordManagement] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [CriminalRecordManagement] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [CriminalRecordManagement] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [CriminalRecordManagement] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [CriminalRecordManagement] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [CriminalRecordManagement] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [CriminalRecordManagement] SET  MULTI_USER 
GO
ALTER DATABASE [CriminalRecordManagement] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [CriminalRecordManagement] SET DB_CHAINING OFF 
GO
ALTER DATABASE [CriminalRecordManagement] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [CriminalRecordManagement] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [CriminalRecordManagement] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [CriminalRecordManagement] SET QUERY_STORE = OFF
GO
USE [CriminalRecordManagement]
GO
/****** Object:  Table [dbo].[tblChargeSheet]    Script Date: 04-08-2019 00:30:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblChargeSheet](
	[ChargeSheetNo] [int] NOT NULL IDENTITY    PRIMARY KEY,
	[csNameofPoliceStation] [varchar](100) NULL,
	[csDate] [date] NULL,
	[csFIRNo] [varchar](50) NOT NULL,
	[csDistrict] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblComplaintRegister]    Script Date: 04-08-2019 00:30:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblComplaintRegister](
	[ComplaintNo] [int] NOT NULL IDENTITY    PRIMARY KEY,
	[cmpName] [varchar](100) NULL,
	[cmpOccupation] [varchar](100) NULL,
	[cmpDetailsofSuspect] [varchar](100) NULL,
	[cmpAge] [int] NULL,
	[cmpSex] [varchar](50) NULL,
	[cmpFatherHusbandName] [varchar](100) NULL,
	[cmpDate] [date] NULL,
	[cmdNationality] [varchar](100) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblCriminalRegister]    Script Date: 04-08-2019 00:30:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblCriminalRegister](
	[CriminalID] [int] NOT NULL IDENTITY    PRIMARY KEY,
	[CrName] [varchar](100) NULL,
	[CrNickName] [varchar](50) NULL,
	[crAge] [int] NULL,
	[crOccupation] [varchar](100) NULL,
	[crCrimeType] [varchar](50) NULL,
	[crAddress] [varchar](100) NULL,
	[CrMostWanted] [bit] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblFIRRegister]    Script Date: 04-08-2019 00:30:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblFIRRegister](
	[FIRNo] [int] NOT NULL IDENTITY    PRIMARY KEY,
	[FIRConplaintNo] [int] NULL,
	[FIRDate] [date] NULL,
	[FIRTypeofInformation] [varchar](100) NULL,
	[FIRPlaceofOccurance] [varchar](100) NULL,
	[FIRForeignLocal] [varchar](10) NULL,
	[FIRAct] [varchar](100) NULL,
	[FIRDistrict] [varchar](100) NULL,
	[FIRInformationAddress] [varchar](100) NULL,
	[FIRPassportNo] [varchar](100) NULL,
	[FIRPoliceOfficer] [varchar](100) NULL,
	[FIRReceivedTime] [datetime] NULL,
	[FIRInformationReceived] [varchar](100) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblMostWanted]    Script Date: 04-08-2019 00:30:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblMostWanted](
	[mwID] [int] NOT NULL,
	[mwName] [varchar](100) NULL,
	[mwAge] [int] NULL,
	[mwSex] [varchar](10) NULL,
	[mwDescription] [varchar](100) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblPostMortem]    Script Date: 04-08-2019 00:30:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblPostMortem](
	[pmId] [int] NOT NULL IDENTITY    PRIMARY KEY,
	[pmFIRNo] [varchar](50) NULL,
	[pmResultofPostMortem] [varchar](100) NULL,
	[pmSex] [varchar](10) NULL,
	[pmDateofDeath] [datetime] NULL,
	[pmDescriptionofCase] [varchar](100) NULL,
	[pmHouseName] [varchar](100) NULL,
	[pmDrName] [varchar](100) NULL,
	[pmPoliceStation] [varchar](100) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblPrisonerRegister]    Script Date: 04-08-2019 00:30:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblPrisonerRegister](
	[PrisonerID] [int] NOT NULL IDENTITY    PRIMARY KEY,
	[PrChargeSheetNo] [int] NULL,
	[PrNickName] [varchar](100) NULL,
	[PrTypeofCrime] [varchar](100) NULL,
	[PrFamilyMembers] [varchar](100) NULL,
	[PrIdentificationMark] [varchar](100) NULL,
	[PrHeight] [varchar](100) NULL,
	[prWeight] [int] NULL,
	[PrColor] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblRoleMaster]    Script Date: 04-08-2019 00:30:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblRoleMaster](
	[RoleId] [int] NULL,
	[RoleName] [nchar](10) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblUsers]    Script Date: 04-08-2019 00:30:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblUsers](
	[UserId] [int] NOT NULL    IDENTITY    PRIMARY KEY,
	[UserName] [varchar](50) NULL,
	[Password] [varchar](50) NULL,
	[FirstName] [varchar](50) NULL,
	[LastName] [varchar](50) NULL,
	[RoleId] [int] NULL
) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [CriminalRecordManagement] SET  READ_WRITE 
GO
