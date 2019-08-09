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


CREATE TABLE [dbo].[tblDict](
	[DictDisplayName] [varchar](50) NOT NULL    PRIMARY KEY,
	[DictTableName] [varchar](50) NOT NULL,
	[DictUIdCol] [varchar](50) NOT NULL,
) ON [PRIMARY]
INSERT INTO [dbo].[tblDict]
([DictDisplayName],[DictTableName] ,[DictUIdCol])
VALUES
('ChargeSheet', 'dbo.tblChargeSheet', 'ChargeSheetNo');

USE [CriminalRecordManagement]
GO

/****** Object:  Table [dbo].[tblDict]    Script Date: 09-08-2019 17:59:07 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblDict](
	[DictDisplayName] [varchar](50) NOT NULL,
	[DictTableName] [varchar](50) NOT NULL,
	[DictUIdCol] [varchar](50) NOT NULL
) ON [PRIMARY]
GO

-------------------------------------------------------------------
--Stored Procs in DB
USE [CriminalRecordManagement]
GO
/****** Object:  StoredProcedure [dbo].[CriminalRecordChargeSheet]    Script Date: 09-08-2019 17:59:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Vikas>
-- Create date: <06-Aug-2019>
-- Description:	<To insert records into ChargeSheet.aspx>
-- =============================================
ALTER PROCEDURE [dbo].[CriminalRecordChargeSheet] 
	-- Add the parameters for the stored procedure here
	@csNameofPoliceStation varchar(100)
	,@csDate Date
	,@csFIRNo varchar(50)
	,@csDistrict varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO [dbo].[tblChargeSheet]
           (csNameofPoliceStation
           ,csDate
           ,csFIRNo
           ,csDistrict)
     VALUES
           (@csNameofPoliceStation
           ,@csDate
           ,@csFIRNo
           ,@csDistrict)
END


USE [CriminalRecordManagement]
GO
/****** Object:  StoredProcedure [dbo].[CriminalRecordComplaintRegister]    Script Date: 09-08-2019 18:00:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Vikas>
-- Create date: <06-Aug-2019>
-- Description:	<To insert records from ComplaintRegister.aspx>
-- =============================================
ALTER PROCEDURE [dbo].[CriminalRecordComplaintRegister]
	-- Add the parameters for the stored procedure here
	@cmpName varchar(100)
	,@cmpOccupation varchar(100)
	,@cmpDetailsofSuspect varchar(100)
	,@cmpAge int
	,@cmpSex varchar(50)
	,@cmpFatherHusbandName varchar(100)
	,@cmpDate date
	,@cmdNationality varchar(100)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO [dbo].[tblComplaintRegister]
           ([cmpName]
           ,[cmpOccupation]
           ,[cmpDetailsofSuspect]
           ,[cmpAge]
           ,[cmpSex]
           ,[cmpFatherHusbandName]
           ,[cmpDate]
           ,[cmdNationality])
     VALUES
           (@cmpName
           ,@cmpOccupation
           ,@cmpDetailsofSuspect
           ,@cmpAge
           ,@cmpSex
           ,@cmpFatherHusbandName
           ,@cmpDate
           ,@cmdNationality)
END


USE [CriminalRecordManagement]
GO
/****** Object:  StoredProcedure [dbo].[CriminalRecordCriminalRegister]    Script Date: 09-08-2019 18:00:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Vikas>
-- Create date: <06-Aug-2019>
-- Description:	<To insert records from CriminalRegister.aspx>
-- =============================================
ALTER PROCEDURE [dbo].[CriminalRecordCriminalRegister]
	-- Add the parameters for the stored procedure here
	@CrName varchar(100)
	,@CrNickName varchar(50)
	,@crAge int
	,@crOccupation varchar(100)
	,@crCrimeType varchar(50)
	,@crAddress varchar(100)
	,@CrMostWanted bit
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO [dbo].[tblCriminalRegister]
           ([CrName]
           ,[CrNickName]
           ,[crAge]
           ,[crOccupation]
           ,[crCrimeType]
           ,[crAddress]
           ,[CrMostWanted])
     VALUES
           (@CrName
           ,@CrNickName
           ,@crAge
           ,@crOccupation
           ,@crCrimeType
           ,@crAddress
           ,@CrMostWanted)
END


USE [CriminalRecordManagement]
GO
/****** Object:  StoredProcedure [dbo].[CriminalRecordFIRRegister]    Script Date: 09-08-2019 18:00:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Vikas>
-- Create date: <06-Aug-2019>
-- Description:	<To insert records from FIRRegister.aspx>
-- =============================================
ALTER PROCEDURE [dbo].[CriminalRecordFIRRegister] 
	-- Add the parameters for the stored procedure here
	@FIRComplaintNo int
	,@FIRDate date
	,@FIRTypeofInformation varchar(100)
	,@FIRPlaceofOccurance varchar(100)
	,@FIRForeignLocal varchar(10)
	,@FIRAct varchar(100)
	,@FIRDistrict varchar(100)
	,@FIRInformationAddress varchar(100)
	,@FIRPassportNo varchar(100)
	,@FIRPoliceOfficer varchar(100)
	,@FIRReceivedTime datetime
	,@FIRInformationReceived varchar(100)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO [dbo].[tblFIRRegister]
           ([FIRComplaintNo]
           ,[FIRDate]
           ,[FIRTypeofInformation]
           ,[FIRPlaceofOccurance]
           ,[FIRForeignLocal]
           ,[FIRAct]
           ,[FIRDistrict]
           ,[FIRInformationAddress]
           ,[FIRPassportNo]
           ,[FIRPoliceOfficer]
           ,[FIRReceivedTime]
           ,[FIRInformationReceived])
     VALUES
           (@FIRComplaintNo
           ,@FIRDate
           ,@FIRTypeofInformation
           ,@FIRPlaceofOccurance
           ,@FIRForeignLocal
           ,@FIRAct
           ,@FIRDistrict
           ,@FIRInformationAddress
           ,@FIRPassportNo
           ,@FIRPoliceOfficer
           ,@FIRReceivedTime
           ,@FIRInformationReceived)
END


USE [CriminalRecordManagement]
GO
/****** Object:  StoredProcedure [dbo].[CriminalRecordMostWanted]    Script Date: 09-08-2019 18:00:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Vikas>
-- Create date: <06-Aug-2019>
-- Description:	<To insert records from MostWanted.aspx>
-- =============================================
ALTER PROCEDURE [dbo].[CriminalRecordMostWanted] 
	-- Add the parameters for the stored procedure here
	@mwID int
	,@mwName varchar(100)
	,@mwNickName varchar(100)
	,@mwAge int
	,@mwSex varchar(10)
	,@mwDescription varchar(100)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO [dbo].[tblMostWanted]
           ([mwID]
           ,[mwName]
		   ,[mwNickName]
           ,[mwAge]
           ,[mwSex]
           ,[mwDescription])
     VALUES
           (@mwID
           ,@mwName
		   ,@mwNickName
           ,@mwAge
           ,@mwSex
           ,@mwDescription)
END


USE [CriminalRecordManagement]
GO
/****** Object:  StoredProcedure [dbo].[CriminalRecordPostMortem]    Script Date: 09-08-2019 18:00:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Vikas>
-- Create date: <06-Aug-2019>
-- Description:	<To insert records from PostMortem.aspx>
-- =============================================
ALTER PROCEDURE [dbo].[CriminalRecordPostMortem] 
	-- Add the parameters for the stored procedure here
	@pmFIRNo varchar(50)
	,@pmResultofPostMortem varchar(100)
	,@pmSex varchar(10)
	,@pmDateofDeath datetime
	,@pmDescriptionofCase varchar(100)
	,@pmHouseName varchar(100)
	,@pmDrName varchar(100)
	,@pmPoliceStation varchar(100)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO [dbo].[tblPostMortem]
           ([pmFIRNo]
           ,[pmResultofPostMortem]
           ,[pmSex]
           ,[pmDateofDeath]
           ,[pmDescriptionofCase]
           ,[pmHouseName]
           ,[pmDrName]
           ,[pmPoliceStation])
     VALUES
           (@pmFIRNo
           ,@pmResultofPostMortem
           ,@pmSex
           ,@pmDateofDeath
           ,@pmDescriptionofCase
           ,@pmHouseName
           ,@pmDrName
           ,@pmPoliceStation)
END


USE [CriminalRecordManagement]
GO
/****** Object:  StoredProcedure [dbo].[CriminalRecordPrisonerRegister]    Script Date: 09-08-2019 18:00:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Vikas>
-- Create date: <06-Aug-2019>
-- Description:	<To insert records from PrisonerRegister.aspx>
-- =============================================
ALTER PROCEDURE [dbo].[CriminalRecordPrisonerRegister]
	-- Add the parameters for the stored procedure here
	@PrChargeSheetNo int
	,@PrNickName varchar(100)
	,@PrTypeofCrime varchar(100)
	,@PrFamilyMembers varchar(100)
	,@PrIdentificationMark varchar(100)
	,@PrHeight varchar(100)
	,@prWeight int
	,@PrColor varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO [dbo].[tblPrisonerRegister]
           ([PrChargeSheetNo]
		   ,[PrNickName]
           ,[PrTypeofCrime]
           ,[PrFamilyMembers]
           ,[PrIdentificationMark]
           ,[PrHeight]
           ,[prWeight]
           ,[PrColor])
     VALUES
           (@PrChargeSheetNo
		   ,@PrNickName
           ,@PrTypeofCrime
           ,@PrFamilyMembers
           ,@PrIdentificationMark
           ,@PrHeight
           ,@prWeight
           ,@PrColor)
END


USE [CriminalRecordManagement]
GO
/****** Object:  StoredProcedure [dbo].[CriminalRecordRegister]    Script Date: 09-08-2019 18:00:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Vikas>
-- Create date: <06-Aug-2019>
-- Description:	<To insert records from Register.aspx>
-- =============================================
ALTER PROCEDURE [dbo].[CriminalRecordRegister] 
	-- Add the parameters for the stored procedure here
	@UserName varchar(50)
	,@Password varchar(50)
	,@FirstName varchar(50)
	,@LastName varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	insert into dbo.tblUsers (UserName,Password,FirstName,LastName,RoleId)
	values (@UserName, @Password, @FirstName, @LastName,2);
END


USE [CriminalRecordManagement]
GO
/****** Object:  StoredProcedure [dbo].[ReportGen]    Script Date: 09-08-2019 18:00:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Vikas>
-- Create date: <06-Aug-2019>
-- Description:	<To generate reports>
-- =============================================
ALTER PROCEDURE [dbo].[ReportGen] 
	-- Add the parameters for the stored procedure here
	@SearchCriteria varchar(50)
	,@SearchID int
AS

BEGIN

	Declare @tabName varchar(50);
	Declare @Idname int;
	Declare @DictTableName varchar(50);
	Declare @DictUIdCol varchar(50);
	DECLARE @sqlCommand varchar(1000)

	set @tabName = @SearchCriteria;
	set @Idname = @SearchID;
	
	
	
	 select @DictTableName = DictTableName,  @DictUIdCol  = DictUIdCol from dbo.tblDict 
	where DictDisplayName = @tabName;

	set @sqlcommand = 'select * from '+ @DictTableName+  ' where '+@DictUIdCol +'='+ @SearchID;
	
	
	return exec(@sqlcommand)
	
	--execute sp_executesql           N'select * from tab1 where col1 = @param',N'@param int',@param = 35 

END

