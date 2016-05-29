USE [master]
GO
/****** Object:  Database [RMIS]    Script Date: 05/28/2016 19:49:02 ******/
CREATE DATABASE [RMIS] ON  PRIMARY 
( NAME = N'RMIS', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\RMIS.mdf' , SIZE = 2048KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'RMIS_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\RMIS_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [RMIS] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [RMIS].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [RMIS] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [RMIS] SET ANSI_NULLS OFF
GO
ALTER DATABASE [RMIS] SET ANSI_PADDING OFF
GO
ALTER DATABASE [RMIS] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [RMIS] SET ARITHABORT OFF
GO
ALTER DATABASE [RMIS] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [RMIS] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [RMIS] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [RMIS] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [RMIS] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [RMIS] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [RMIS] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [RMIS] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [RMIS] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [RMIS] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [RMIS] SET  DISABLE_BROKER
GO
ALTER DATABASE [RMIS] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [RMIS] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [RMIS] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [RMIS] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [RMIS] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [RMIS] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [RMIS] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [RMIS] SET  READ_WRITE
GO
ALTER DATABASE [RMIS] SET RECOVERY FULL
GO
ALTER DATABASE [RMIS] SET  MULTI_USER
GO
ALTER DATABASE [RMIS] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [RMIS] SET DB_CHAINING OFF
GO
USE [RMIS]
GO
/****** Object:  Table [dbo].[RMUserRole]    Script Date: 05/28/2016 19:49:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[RMUserRole](
	[UserRoleId] [nvarchar](50) NOT NULL,
	[RoleId] [nvarchar](50) NOT NULL,
	[UserID] [nvarchar](50) NOT NULL,
	[CustID] [nvarchar](50) NOT NULL,
	[ObsInd] [char](1) NOT NULL,
	[LastModifiedBy] [nvarchar](50) NOT NULL,
	[LastModifiedDate] [datetime] NOT NULL,
 CONSTRAINT [PK_RMUserRole] PRIMARY KEY CLUSTERED 
(
	[UserRoleId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CustomerInfo]    Script Date: 05/28/2016 19:49:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CustomerInfo](
	[CustID] [nvarchar](50) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[OrganizationName] [nvarchar](200) NOT NULL,
	[LastModifiedBy] [nvarchar](50) NOT NULL,
	[LastModifiedDate] [datetime] NOT NULL,
	[ObsInd] [char](1) NOT NULL,
 CONSTRAINT [PK_CustomerInfo] PRIMARY KEY CLUSTERED 
(
	[CustID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[CustomerInfo] ([CustID], [Name], [OrganizationName], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (N'4ec93247-64ac-4233-bec4-6a48e3f68f6f', N'Shiva 2', N'SRS', N'System', CAST(0x0000A60C00F417E4 AS DateTime), N'N')
INSERT [dbo].[CustomerInfo] ([CustID], [Name], [OrganizationName], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (N'b63f2912-9451-4efc-bbba-064f8271a770', N'', N'', N'System', CAST(0x0000A6100002CD30 AS DateTime), N'N')
INSERT [dbo].[CustomerInfo] ([CustID], [Name], [OrganizationName], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (N'CI2016051900171471077295893', N'Test', N'Test', N'System', CAST(0x0000A60B0004BCE4 AS DateTime), N'N')
INSERT [dbo].[CustomerInfo] ([CustID], [Name], [OrganizationName], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (N'CI2016051900292260106367486', N'ddddddd', N'ddddd', N'System', CAST(0x0000A60B000810D8 AS DateTime), N'N')
INSERT [dbo].[CustomerInfo] ([CustID], [Name], [OrganizationName], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (N'f2a95599-6ea7-4642-9c94-0bbd870fa7dc', N'Shiva', N'SRS', N'System', CAST(0x0000A60C00F09F9C AS DateTime), N'N')
INSERT [dbo].[CustomerInfo] ([CustID], [Name], [OrganizationName], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (N'test1', N'test1', N'test1', N'System', CAST(0x0000A60A01844139 AS DateTime), N'N')
/****** Object:  Table [dbo].[MRoles]    Script Date: 05/28/2016 19:49:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MRoles](
	[RoleId] [nvarchar](50) NOT NULL,
	[RoleName] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](100) NULL,
	[ObsInd] [char](1) NOT NULL,
	[LastModifiedBy] [nvarchar](50) NOT NULL,
	[LastModifiedDate] [datetime] NOT NULL,
 CONSTRAINT [PK_MRoles] PRIMARY KEY CLUSTERED 
(
	[RoleId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MenuInfo]    Script Date: 05/28/2016 19:49:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MenuInfo](
	[MenuID] [int] NOT NULL,
	[ParentMenuID] [int] NULL,
	[Title] [nchar](50) NOT NULL,
	[Description] [nvarchar](100) NULL,
	[URL] [nvarchar](100) NOT NULL,
	[LastModifiedBy] [nvarchar](50) NOT NULL,
	[LastModifiedDate] [datetime] NULL,
	[ObsInd] [char](1) NOT NULL,
 CONSTRAINT [PK_MenuInfo] PRIMARY KEY CLUSTERED 
(
	[MenuID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[MenuInfo] ([MenuID], [ParentMenuID], [Title], [Description], [URL], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (1, NULL, N'Master Configuration                              ', N'Master Confi', N'', N'System', CAST(0x0000A60A01844139 AS DateTime), N'N')
INSERT [dbo].[MenuInfo] ([MenuID], [ParentMenuID], [Title], [Description], [URL], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (2, 1, N'Add Seller Types                                  ', N'Add Seller Types', N'AddSellerType.ascx', N'System', CAST(0x0000A60A0184413A AS DateTime), N'N')
INSERT [dbo].[MenuInfo] ([MenuID], [ParentMenuID], [Title], [Description], [URL], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (3, 1, N'Add Paddy Types                                   ', N'Add Paddy Types', N'AddPaddyType.ascx', N'System', CAST(0x0000A60A0184413B AS DateTime), N'N')
INSERT [dbo].[MenuInfo] ([MenuID], [ParentMenuID], [Title], [Description], [URL], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (4, 1, N'Add Unit Types                                    ', N'Add Unit Types', N'AddUnitsType.ascx', N'System', CAST(0x0000A60A0184413B AS DateTime), N'N')
INSERT [dbo].[MenuInfo] ([MenuID], [ParentMenuID], [Title], [Description], [URL], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (5, 1, N'Add Godown Types                                  ', N'Add Godown Types', N'AddGodownDetails.ascx', N'System', CAST(0x0000A60A0184413B AS DateTime), N'N')
INSERT [dbo].[MenuInfo] ([MenuID], [ParentMenuID], [Title], [Description], [URL], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (6, 1, N'Add Lot Types                                     ', N'Add Lot Types', N'AddLotDetails.ascx', N'System', CAST(0x0000A60A0184413B AS DateTime), N'N')
INSERT [dbo].[MenuInfo] ([MenuID], [ParentMenuID], [Title], [Description], [URL], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (7, 1, N'Add Rice Types                                    ', N'Add Rice Types', N'AddRiceType.ascx', N'System', CAST(0x0000A60A0184413C AS DateTime), N'N')
INSERT [dbo].[MenuInfo] ([MenuID], [ParentMenuID], [Title], [Description], [URL], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (8, NULL, N'Paddy process                                     ', N'Paddy process', N'', N'System', CAST(0x0000A60A0184413C AS DateTime), N'N')
INSERT [dbo].[MenuInfo] ([MenuID], [ParentMenuID], [Title], [Description], [URL], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (9, 8, N'Add Seller details                                ', N'Add Seller details', N'SellerInfoDetails.ascx', N'System', CAST(0x0000A60A0184413C AS DateTime), N'N')
INSERT [dbo].[MenuInfo] ([MenuID], [ParentMenuID], [Title], [Description], [URL], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (10, 8, N'Add Paddy details                                 ', N'Add Paddy details', N'PaddyStockInfo.ascx', N'System', CAST(0x0000A60A0184413C AS DateTime), N'N')
/****** Object:  Table [dbo].[MenuConfiguration]    Script Date: 05/28/2016 19:49:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MenuConfiguration](
	[MenuConfigId] [nvarchar](50) NOT NULL,
	[MenuID] [int] NOT NULL,
	[CustID] [nvarchar](50) NOT NULL,
	[RoleId] [nvarchar](50) NOT NULL,
	[ObsInd] [char](1) NOT NULL,
	[LastModifiedBy] [nvarchar](50) NOT NULL,
	[LastModifiedDate] [datetime] NOT NULL,
 CONSTRAINT [PK_MenuConfiguration] PRIMARY KEY CLUSTERED 
(
	[MenuConfigId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MBrokenRiceType]    Script Date: 05/28/2016 19:49:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MBrokenRiceType](
	[BrokenRiceTypeID] [nvarchar](50) NOT NULL,
	[CustID] [nvarchar](50) NOT NULL,
	[BrokenRiceName] [nvarchar](50) NOT NULL,
	[LastModifiedBy] [nvarchar](50) NOT NULL,
	[LastModifiedDate] [datetime] NOT NULL,
	[ObsInd] [char](1) NOT NULL,
 CONSTRAINT [PK_MBrokenRiceType] PRIMARY KEY CLUSTERED 
(
	[BrokenRiceTypeID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MBagType]    Script Date: 05/28/2016 19:49:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MBagType](
	[BagTypeID] [nvarchar](50) NOT NULL,
	[BagType] [nvarchar](30) NOT NULL,
	[LastModifiedBy] [nvarchar](50) NOT NULL,
	[LastModifiedDate] [datetime] NOT NULL,
	[ObsInd] [char](1) NOT NULL,
	[CustID] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_MBagType] PRIMARY KEY CLUSTERED 
(
	[BagTypeID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MDrierTypeDetails]    Script Date: 05/28/2016 19:49:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MDrierTypeDetails](
	[MDrierTypeID] [nvarchar](50) NOT NULL,
	[CustID] [nvarchar](50) NOT NULL,
	[DrierName] [nvarchar](30) NOT NULL,
	[LastModifiedBy] [nvarchar](50) NOT NULL,
	[LastModifiedDate] [datetime] NOT NULL,
	[ObsInd] [char](1) NOT NULL,
 CONSTRAINT [PK_MDrierTypeDetails] PRIMARY KEY CLUSTERED 
(
	[MDrierTypeID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CustTrailUsage]    Script Date: 05/28/2016 19:49:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CustTrailUsage](
	[CustTrailID] [nvarchar](50) NOT NULL,
	[CustID] [nvarchar](50) NOT NULL,
	[TrailStartDate] [datetime] NOT NULL,
	[TrailEndDate] [datetime] NOT NULL,
	[LastModifiedBy] [nvarchar](50) NOT NULL,
	[LastModifiedDate] [datetime] NOT NULL,
	[ObsInd] [char](1) NOT NULL,
 CONSTRAINT [PK_CustTrailUsage] PRIMARY KEY CLUSTERED 
(
	[CustTrailID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CustomerPayment]    Script Date: 05/28/2016 19:49:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CustomerPayment](
	[CustPaymentID] [nvarchar](50) NOT NULL,
	[CustID] [nvarchar](50) NOT NULL,
	[LastModifiedBy] [nvarchar](50) NOT NULL,
	[LastModifiedDate] [datetime] NOT NULL,
	[ObsInd] [char](1) NOT NULL,
	[OutstandingAmount] [money] NULL,
	[Status] [char](1) NULL,
 CONSTRAINT [PK_CustomerPayment] PRIMARY KEY CLUSTERED 
(
	[CustPaymentID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CustomerPartPayDetails]    Script Date: 05/28/2016 19:49:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CustomerPartPayDetails](
	[CustPartPayID] [nvarchar](50) NOT NULL,
	[CustID] [nvarchar](50) NOT NULL,
	[PaidAmount] [money] NOT NULL,
	[PaidDate] [datetime] NOT NULL,
	[NextPayDate] [datetime] NULL,
	[LastModifiedBy] [nvarchar](50) NOT NULL,
	[LastModifiedDate] [datetime] NOT NULL,
	[ObsInd] [char](1) NOT NULL,
 CONSTRAINT [PK_CustomerPartPayDetails] PRIMARY KEY CLUSTERED 
(
	[CustPartPayID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MRiceProductionType]    Script Date: 05/28/2016 19:49:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MRiceProductionType](
	[MRiceProdTypeID] [nvarchar](50) NOT NULL,
	[CustID] [nvarchar](50) NOT NULL,
	[RiceType] [nvarchar](30) NOT NULL,
	[LastModifiedBy] [nvarchar](50) NOT NULL,
	[LastModifiedDate] [datetime] NOT NULL,
	[ObsInd] [char](1) NOT NULL,
 CONSTRAINT [PK_MRiceProductionType] PRIMARY KEY CLUSTERED 
(
	[MRiceProdTypeID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MRiceBrandDetails]    Script Date: 05/28/2016 19:49:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MRiceBrandDetails](
	[MRiceBrandID] [nvarchar](50) NOT NULL,
	[CustID] [nvarchar](50) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[LastModifiedBy] [nvarchar](50) NOT NULL,
	[LastModifiedDate] [datetime] NOT NULL,
	[ObsInd] [char](1) NOT NULL,
 CONSTRAINT [PK_MRiceBrandDetails] PRIMARY KEY CLUSTERED 
(
	[MRiceBrandID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MProductSellingType]    Script Date: 05/28/2016 19:49:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MProductSellingType](
	[ProductTypeID] [nvarchar](50) NOT NULL,
	[CustID] [nvarchar](50) NOT NULL,
	[ProductType] [nvarchar](30) NOT NULL,
	[LastModifiedBy] [nvarchar](50) NOT NULL,
	[LastModifiedDate] [datetime] NOT NULL,
	[ObsInd] [char](1) NOT NULL,
 CONSTRAINT [PK_MProductSellingType] PRIMARY KEY CLUSTERED 
(
	[ProductTypeID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MPaddyType]    Script Date: 05/28/2016 19:49:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MPaddyType](
	[PaddyTypeID] [nvarchar](50) NOT NULL,
	[CustID] [nvarchar](50) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[LastModifiedBy] [nvarchar](50) NOT NULL,
	[LastModifiedDate] [datetime] NOT NULL,
	[ObsInd] [char](1) NOT NULL,
 CONSTRAINT [PK_MPaddyType] PRIMARY KEY CLUSTERED 
(
	[PaddyTypeID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CustomerAddressInfo]    Script Date: 05/28/2016 19:49:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CustomerAddressInfo](
	[CustAdrsID] [nvarchar](50) NOT NULL,
	[CustID] [nvarchar](50) NOT NULL,
	[Street1] [nvarchar](50) NULL,
	[Street2] [nvarchar](50) NULL,
	[Town] [nvarchar](50) NULL,
	[City] [nvarchar](50) NULL,
	[District] [nvarchar](50) NOT NULL,
	[State] [nvarchar](50) NOT NULL,
	[Pincode] [int] NULL,
	[ContactNo] [nvarchar](13) NOT NULL,
	[MobileNo] [nvarchar](13) NULL,
	[PhoneNo] [nchar](15) NOT NULL,
	[LastModifiedBy] [nvarchar](50) NOT NULL,
	[LastModifiedDate] [datetime] NOT NULL,
	[ObsInd] [char](1) NOT NULL,
 CONSTRAINT [PK_CustomerAddressInfo] PRIMARY KEY CLUSTERED 
(
	[CustAdrsID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CustomerActivation]    Script Date: 05/28/2016 19:49:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CustomerActivation](
	[CustActiveID] [nvarchar](50) NOT NULL,
	[CustID] [nvarchar](50) NOT NULL,
	[ApplicationStartDate] [datetime] NOT NULL,
	[ApplicationEndDate] [datetime] NOT NULL,
	[Status] [char](1) NOT NULL,
	[LastModifiedBy] [nvarchar](50) NOT NULL,
	[LastModifiedDate] [datetime] NOT NULL,
	[ObsInd] [char](1) NOT NULL,
 CONSTRAINT [PK_CustomerActivation] PRIMARY KEY CLUSTERED 
(
	[CustActiveID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Users]    Script Date: 05/28/2016 19:49:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Users](
	[UserID] [nvarchar](50) NOT NULL,
	[CustID] [nvarchar](50) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[PassWord] [nvarchar](50) NOT NULL,
	[LastModifiedBy] [nvarchar](50) NOT NULL,
	[LastModifiedDate] [datetime] NOT NULL,
	[ObsInd] [char](1) NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MWeightDetails]    Script Date: 05/28/2016 19:49:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MWeightDetails](
	[MWeightID] [nvarchar](10) NOT NULL,
	[CustID] [nvarchar](50) NOT NULL,
	[Weight] [smallint] NOT NULL,
	[LastModifiedBy] [nvarchar](50) NOT NULL,
	[LastModifiedDate] [datetime] NOT NULL,
	[ObsInd] [char](1) NOT NULL,
 CONSTRAINT [PK_MWeightDetails] PRIMARY KEY CLUSTERED 
(
	[MWeightID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MUnitsType]    Script Date: 05/28/2016 19:49:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MUnitsType](
	[UnitsTypeID] [nvarchar](50) NOT NULL,
	[CustID] [nvarchar](50) NOT NULL,
	[UnitsType] [nvarchar](30) NOT NULL,
	[LastModifiedBy] [nvarchar](50) NOT NULL,
	[LastModifiedDate] [datetime] NOT NULL,
	[ObsInd] [char](1) NOT NULL,
 CONSTRAINT [PK_MUnitsType] PRIMARY KEY CLUSTERED 
(
	[UnitsTypeID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MSellerType]    Script Date: 05/28/2016 19:49:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MSellerType](
	[SellerTypeID] [nvarchar](50) NOT NULL,
	[CustID] [nvarchar](50) NOT NULL,
	[SellerType] [nvarchar](10) NOT NULL,
	[LastModifiedBy] [nvarchar](50) NOT NULL,
	[LastModifiedDate] [datetime] NOT NULL,
	[ObsInd] [char](1) NOT NULL,
 CONSTRAINT [PK_MSellerType] PRIMARY KEY CLUSTERED 
(
	[SellerTypeID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MGodownDetails]    Script Date: 05/28/2016 19:49:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MGodownDetails](
	[MGodownID] [nvarchar](50) NOT NULL,
	[CustID] [nvarchar](50) NOT NULL,
	[Place] [nvarchar](30) NULL,
	[LastModifiedBy] [nvarchar](50) NOT NULL,
	[LastModifiedDate] [datetime] NOT NULL,
	[ObsInd] [char](1) NOT NULL,
	[Name] [varchar](10) NULL,
 CONSTRAINT [PK_MGodownDetails] PRIMARY KEY CLUSTERED 
(
	[MGodownID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MessageInfo]    Script Date: 05/28/2016 19:49:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MessageInfo](
	[MessageTypeID] [nvarchar](50) NOT NULL,
	[MessageCode] [nvarchar](50) NOT NULL,
	[CustID] [nvarchar](50) NOT NULL,
	[Message] [nvarchar](200) NOT NULL,
	[LastModifiedBy] [nvarchar](50) NOT NULL,
	[LastModifiedDate] [datetime] NOT NULL,
	[ObsInd] [char](1) NOT NULL,
 CONSTRAINT [PK_MessageInfo_1] PRIMARY KEY CLUSTERED 
(
	[MessageTypeID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[RiceStockInfo]    Script Date: 05/28/2016 19:49:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[RiceStockInfo](
	[RiceStockID] [nvarchar](50) NOT NULL,
	[MRiceProdTypeID] [nvarchar](50) NOT NULL,
	[MRiceBrandID] [nvarchar](50) NOT NULL,
	[CustID] [nvarchar](50) NOT NULL,
	[UnitsTypeID] [nvarchar](50) NOT NULL,
	[TotalBags] [smallint] NOT NULL,
	[QWeight] [smallint] NOT NULL,
	[LastModifiedBy] [nvarchar](50) NOT NULL,
	[LastModifiedDate] [datetime] NOT NULL,
	[ObsInd] [char](1) NOT NULL,
 CONSTRAINT [PK_RiceStockInfo] PRIMARY KEY CLUSTERED 
(
	[RiceStockID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SellerInfo]    Script Date: 05/28/2016 19:49:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SellerInfo](
	[SellerID] [nvarchar](50) NOT NULL,
	[SellerTypeID] [nvarchar](50) NOT NULL,
	[CustID] [nvarchar](50) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Street] [nvarchar](20) NULL,
	[Street1] [nvarchar](20) NULL,
	[Town] [nvarchar](50) NULL,
	[City] [nvarchar](50) NOT NULL,
	[District] [nvarchar](50) NOT NULL,
	[State] [nvarchar](50) NOT NULL,
	[PinCode] [varchar](6) NULL,
	[ContactNo] [nvarchar](11) NOT NULL,
	[MobileNo] [nvarchar](11) NULL,
	[PhoneNo] [nvarchar](13) NULL,
	[LastModifiedBy] [nvarchar](50) NOT NULL,
	[LastModifiedDate] [datetime] NOT NULL,
	[ObsInd] [char](1) NOT NULL,
 CONSTRAINT [PK_SellerInfo] PRIMARY KEY CLUSTERED 
(
	[SellerID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[BrokenRiceStockInfo]    Script Date: 05/28/2016 19:49:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[BrokenRiceStockInfo](
	[BrokenRiceStockID] [nvarchar](50) NOT NULL,
	[BrokenRiceTypeID] [nvarchar](50) NOT NULL,
	[CustID] [nvarchar](50) NOT NULL,
	[UnitsTypeID] [nvarchar](50) NOT NULL,
	[TotalBags] [smallint] NOT NULL,
	[QWeight] [smallint] NOT NULL,
	[LastModifiedBy] [nvarchar](50) NOT NULL,
	[LastModifiedDate] [datetime] NOT NULL,
	[ObsInd] [char](1) NOT NULL,
 CONSTRAINT [PK_BrokenRiceStockInfo] PRIMARY KEY CLUSTERED 
(
	[BrokenRiceStockID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MLotDetails]    Script Date: 05/28/2016 19:49:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MLotDetails](
	[MLotID] [nvarchar](50) NOT NULL,
	[CustID] [nvarchar](50) NOT NULL,
	[LotName] [nvarchar](30) NOT NULL,
	[LastModifiedBy] [nvarchar](50) NOT NULL,
	[LastModifiedDate] [datetime] NOT NULL,
	[ObsInd] [char](1) NOT NULL,
	[MGodownID] [nvarchar](50) NULL,
 CONSTRAINT [PK_MLotDetails] PRIMARY KEY CLUSTERED 
(
	[MLotID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HullingProcess]    Script Date: 05/28/2016 19:49:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HullingProcess](
	[HullingProcessID] [nvarchar](50) NOT NULL,
	[PaddyTypeID] [nvarchar](50) NOT NULL,
	[CustID] [nvarchar](50) NOT NULL,
	[UnitsTypeID] [nvarchar](50) NOT NULL,
	[TotalBags] [smallint] NOT NULL,
	[ProcessDate] [datetime] NOT NULL,
	[ProcessedBy] [nvarchar](30) NULL,
	[LastModifiedBy] [nvarchar](50) NOT NULL,
	[LastModifiedDate] [datetime] NOT NULL,
	[ObsInd] [char](1) NOT NULL,
	[Status] [char](1) NULL,
 CONSTRAINT [PK_HullingProcess] PRIMARY KEY CLUSTERED 
(
	[HullingProcessID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DustStockInfo]    Script Date: 05/28/2016 19:49:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DustStockInfo](
	[DustStockID] [nvarchar](50) NOT NULL,
	[CustID] [nvarchar](50) NOT NULL,
	[UnitsTypeID] [nvarchar](50) NOT NULL,
	[TotalBags] [smallint] NOT NULL,
	[QWeight] [smallint] NOT NULL,
	[LastModifiedBy] [nvarchar](50) NOT NULL,
	[LastModifiedDate] [datetime] NOT NULL,
	[ObsInd] [char](1) NOT NULL,
 CONSTRAINT [PK_DustStockInfo] PRIMARY KEY CLUSTERED 
(
	[DustStockID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DustSellingInfo]    Script Date: 05/28/2016 19:49:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DustSellingInfo](
	[DustSellingID] [nvarchar](50) NOT NULL,
	[SellerID] [nvarchar](50) NOT NULL,
	[CustID] [nvarchar](50) NOT NULL,
	[UnitsTypeID] [nvarchar](50) NOT NULL,
	[VehicalNo] [nvarchar](10) NOT NULL,
	[DriverName] [nvarchar](50) NOT NULL,
	[TotalBags] [smallint] NOT NULL,
	[QWeight] [smallint] NOT NULL,
	[QPrice] [smallint] NOT NULL,
	[SellingDate] [datetime] NOT NULL,
	[LastModifiedBy] [nvarchar](50) NOT NULL,
	[LastModifiedDate] [datetime] NOT NULL,
	[ObsInd] [char](1) NOT NULL,
 CONSTRAINT [PK_DustSellingInfo] PRIMARY KEY CLUSTERED 
(
	[DustSellingID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HullingTransaction]    Script Date: 05/28/2016 19:49:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HullingTransaction](
	[HullingTransID] [nvarchar](50) NOT NULL,
	[HullingProcessID] [nvarchar](50) NOT NULL,
	[PaddyTypeID] [nvarchar](50) NULL,
	[MRiceProdTypeID] [nvarchar](50) NULL,
	[BrokenRiceTypeID] [nvarchar](50) NULL,
	[IsDust] [char](1) NULL,
	[CustID] [nvarchar](50) NOT NULL,
	[UnitsTypeID] [nvarchar](50) NOT NULL,
	[TotalBags] [decimal](8, 2) NOT NULL,
	[Price] [money] NOT NULL,
	[LastModifiedBy] [nvarchar](50) NOT NULL,
	[LastModifiedDate] [datetime] NOT NULL,
	[ObsInd] [char](1) NOT NULL,
	[Status] [char](1) NULL,
 CONSTRAINT [PK_HullingTransaction] PRIMARY KEY CLUSTERED 
(
	[HullingTransID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HullingProcessExpenses]    Script Date: 05/28/2016 19:49:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HullingProcessExpenses](
	[HullingProcessExpenID] [nvarchar](50) NOT NULL,
	[HullingProcessID] [nvarchar](50) NOT NULL,
	[PowerExpenses] [money] NOT NULL,
	[LabourExpenses] [money] NOT NULL,
	[OtherExpenses] [money] NOT NULL,
	[LastModifiedBy] [nvarchar](50) NOT NULL,
	[LastModifiedDate] [datetime] NOT NULL,
	[ObsInd] [char](1) NOT NULL,
 CONSTRAINT [PK_HullingProcessExpenses] PRIMARY KEY CLUSTERED 
(
	[HullingProcessExpenID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[BrokenRiceSellingInfo]    Script Date: 05/28/2016 19:49:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[BrokenRiceSellingInfo](
	[BrokenRiceSellingID] [nvarchar](50) NOT NULL,
	[SellerID] [nvarchar](50) NOT NULL,
	[BrokenRiceTypeID] [nvarchar](50) NOT NULL,
	[CustID] [nvarchar](50) NOT NULL,
	[UnitsTypeID] [nvarchar](50) NOT NULL,
	[VehicalNo] [nvarchar](10) NOT NULL,
	[DriverName] [nvarchar](50) NOT NULL,
	[TotalBags] [smallint] NOT NULL,
	[QWeight] [smallint] NOT NULL,
	[QPrice] [smalldatetime] NOT NULL,
	[SellingDate] [datetime] NOT NULL,
	[LastModifiedBy] [nvarchar](50) NOT NULL,
	[LastModifiedDate] [datetime] NOT NULL,
	[ObsInd] [char](1) NOT NULL,
 CONSTRAINT [PK_BrokenRiceSellingInfo] PRIMARY KEY CLUSTERED 
(
	[BrokenRiceSellingID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[BagStockInfo]    Script Date: 05/28/2016 19:49:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[BagStockInfo](
	[BagStockID] [nvarchar](50) NOT NULL,
	[SellerID] [nvarchar](50) NOT NULL,
	[BagTypeID] [nvarchar](50) NOT NULL,
	[CustID] [nvarchar](50) NOT NULL,
	[VehicalNo] [nvarchar](10) NOT NULL,
	[TotalBags] [smallint] NOT NULL,
	[PurchaseDate] [datetime] NOT NULL,
	[LastModifiedBy] [nvarchar](50) NOT NULL,
	[LastModifiedDate] [datetime] NOT NULL,
	[ObsInd] [char](1) NOT NULL,
	[DriverName] [nvarchar](50) NULL,
	[Price] [money] NOT NULL,
 CONSTRAINT [PK_BagStockInfo] PRIMARY KEY CLUSTERED 
(
	[BagStockID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PaddyStockInfo]    Script Date: 05/28/2016 19:49:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PaddyStockInfo](
	[PaddyStockID] [nvarchar](50) NOT NULL,
	[SellerID] [nvarchar](50) NOT NULL,
	[PaddyTypeID] [nvarchar](50) NOT NULL,
	[CustID] [nvarchar](50) NOT NULL,
	[MGodownID] [nvarchar](50) NOT NULL,
	[MLotID] [nvarchar](50) NOT NULL,
	[VehicalNo] [nvarchar](10) NOT NULL,
	[PurchaseDate] [datetime] NOT NULL,
	[LastModifiedBy] [nvarchar](50) NOT NULL,
	[LastModifiedDate] [datetime] NOT NULL,
	[ObsInd] [char](1) NOT NULL,
	[DriverName] [nvarchar](50) NULL,
	[TotalBags] [decimal](7, 2) NOT NULL,
	[Price] [money] NOT NULL,
 CONSTRAINT [PK_PaddyStockInfo] PRIMARY KEY CLUSTERED 
(
	[PaddyStockID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PaddyPaymentDetails]    Script Date: 05/28/2016 19:49:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PaddyPaymentDetails](
	[PaddyPaymentID] [nvarchar](50) NOT NULL,
	[SellerID] [nvarchar](50) NOT NULL,
	[CustID] [nvarchar](50) NOT NULL,
	[AmountPaid] [money] NOT NULL,
	[PaidDate] [datetime] NOT NULL,
	[HandoverTo] [nvarchar](50) NULL,
	[NextPaymentDate] [datetime] NOT NULL,
	[LastModifiedBy] [nvarchar](50) NOT NULL,
	[LastModifiedDate] [datetime] NOT NULL,
	[ObsInd] [char](1) NOT NULL,
 CONSTRAINT [PK_PaddyPaymentDetails] PRIMARY KEY CLUSTERED 
(
	[PaddyPaymentID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[RiceSellingInfo]    Script Date: 05/28/2016 19:49:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[RiceSellingInfo](
	[RiceSellingID] [nvarchar](50) NOT NULL,
	[SellerID] [nvarchar](50) NOT NULL,
	[MRiceProdTypeID] [nvarchar](50) NOT NULL,
	[MRiceBrandID] [nvarchar](50) NOT NULL,
	[CustID] [nvarchar](50) NOT NULL,
	[UnitsTypeID] [nvarchar](50) NOT NULL,
	[VehicalNo] [nvarchar](10) NOT NULL,
	[DriverName] [nvarchar](50) NOT NULL,
	[TotalBags] [smallint] NOT NULL,
	[QWeight] [smallint] NOT NULL,
	[QPrice] [smallint] NOT NULL,
	[SellingDate] [datetime] NOT NULL,
	[LastModifiedBy] [nvarchar](50) NOT NULL,
	[LastModifiedDate] [datetime] NOT NULL,
	[ObsInd] [char](1) NOT NULL,
 CONSTRAINT [PK_RiceSellingInfo] PRIMARY KEY CLUSTERED 
(
	[RiceSellingID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ProductSellingInfo]    Script Date: 05/28/2016 19:49:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ProductSellingInfo](
	[ProductID] [nvarchar](50) NOT NULL,
	[SellerID] [nvarchar](50) NOT NULL,
	[MRiceProdTypeID] [nvarchar](50) NULL,
	[MRiceBrandID] [nvarchar](50) NULL,
	[BrokenRiceTypeID] [nvarchar](50) NULL,
	[CustID] [nvarchar](50) NOT NULL,
	[UnitsTypeID] [nvarchar](50) NOT NULL,
	[VehicalNo] [nvarchar](10) NOT NULL,
	[DriverName] [nvarchar](50) NOT NULL,
	[SellingDate] [datetime] NOT NULL,
	[LastModifiedBy] [nvarchar](50) NOT NULL,
	[LastModifiedDate] [datetime] NOT NULL,
	[ObsInd] [char](1) NOT NULL,
	[Price] [money] NOT NULL,
	[TotalBags] [decimal](7, 2) NOT NULL,
	[ProductTypeID] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_ProductSellingInfo] PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ProductPaymentInfo]    Script Date: 05/28/2016 19:49:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ProductPaymentInfo](
	[ProductPaymentID] [nvarchar](50) NOT NULL,
	[ProductID] [nvarchar](50) NOT NULL,
	[CustID] [nvarchar](50) NOT NULL,
	[TotalAmount] [money] NOT NULL,
	[PaymentMode] [nvarchar](20) NOT NULL,
	[ChequeNo] [nvarchar](50) NULL,
	[DDNo] [nvarchar](50) NULL,
	[BankName] [nvarchar](50) NULL,
	[ReceivedAmount] [money] NULL,
	[PaymentDueDate] [datetime] NULL,
	[Status] [char](1) NOT NULL,
	[LastModifiedBy] [nvarchar](50) NOT NULL,
	[LastModifiedDate] [datetime] NOT NULL,
	[ObsInd] [char](1) NOT NULL,
 CONSTRAINT [PK_ProductPaymentInfo] PRIMARY KEY CLUSTERED 
(
	[ProductPaymentID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  ForeignKey [FK_MenuInfo_MenuInfo1]    Script Date: 05/28/2016 19:49:03 ******/
ALTER TABLE [dbo].[MenuInfo]  WITH CHECK ADD  CONSTRAINT [FK_MenuInfo_MenuInfo1] FOREIGN KEY([ParentMenuID])
REFERENCES [dbo].[MenuInfo] ([MenuID])
GO
ALTER TABLE [dbo].[MenuInfo] CHECK CONSTRAINT [FK_MenuInfo_MenuInfo1]
GO
/****** Object:  ForeignKey [FK_MBagType_CustomerInfo]    Script Date: 05/28/2016 19:49:03 ******/
ALTER TABLE [dbo].[MBagType]  WITH CHECK ADD  CONSTRAINT [FK_MBagType_CustomerInfo] FOREIGN KEY([CustID])
REFERENCES [dbo].[CustomerInfo] ([CustID])
GO
ALTER TABLE [dbo].[MBagType] CHECK CONSTRAINT [FK_MBagType_CustomerInfo]
GO
/****** Object:  ForeignKey [FK_MDrierTypeDetails_CustomerInfo]    Script Date: 05/28/2016 19:49:03 ******/
ALTER TABLE [dbo].[MDrierTypeDetails]  WITH CHECK ADD  CONSTRAINT [FK_MDrierTypeDetails_CustomerInfo] FOREIGN KEY([CustID])
REFERENCES [dbo].[CustomerInfo] ([CustID])
GO
ALTER TABLE [dbo].[MDrierTypeDetails] CHECK CONSTRAINT [FK_MDrierTypeDetails_CustomerInfo]
GO
/****** Object:  ForeignKey [FK_CustTrailUsage_CustomerInfo]    Script Date: 05/28/2016 19:49:03 ******/
ALTER TABLE [dbo].[CustTrailUsage]  WITH CHECK ADD  CONSTRAINT [FK_CustTrailUsage_CustomerInfo] FOREIGN KEY([CustID])
REFERENCES [dbo].[CustomerInfo] ([CustID])
GO
ALTER TABLE [dbo].[CustTrailUsage] CHECK CONSTRAINT [FK_CustTrailUsage_CustomerInfo]
GO
/****** Object:  ForeignKey [FK_CustomerPayment_CustomerInfo]    Script Date: 05/28/2016 19:49:03 ******/
ALTER TABLE [dbo].[CustomerPayment]  WITH CHECK ADD  CONSTRAINT [FK_CustomerPayment_CustomerInfo] FOREIGN KEY([CustID])
REFERENCES [dbo].[CustomerInfo] ([CustID])
GO
ALTER TABLE [dbo].[CustomerPayment] CHECK CONSTRAINT [FK_CustomerPayment_CustomerInfo]
GO
/****** Object:  ForeignKey [FK_CustomerPartPayDetails_CustomerInfo]    Script Date: 05/28/2016 19:49:03 ******/
ALTER TABLE [dbo].[CustomerPartPayDetails]  WITH CHECK ADD  CONSTRAINT [FK_CustomerPartPayDetails_CustomerInfo] FOREIGN KEY([CustID])
REFERENCES [dbo].[CustomerInfo] ([CustID])
GO
ALTER TABLE [dbo].[CustomerPartPayDetails] CHECK CONSTRAINT [FK_CustomerPartPayDetails_CustomerInfo]
GO
/****** Object:  ForeignKey [FK_MRiceProductionType_CustomerInfo]    Script Date: 05/28/2016 19:49:03 ******/
ALTER TABLE [dbo].[MRiceProductionType]  WITH CHECK ADD  CONSTRAINT [FK_MRiceProductionType_CustomerInfo] FOREIGN KEY([CustID])
REFERENCES [dbo].[CustomerInfo] ([CustID])
GO
ALTER TABLE [dbo].[MRiceProductionType] CHECK CONSTRAINT [FK_MRiceProductionType_CustomerInfo]
GO
/****** Object:  ForeignKey [FK_MRiceBrandDetails_CustomerInfo]    Script Date: 05/28/2016 19:49:03 ******/
ALTER TABLE [dbo].[MRiceBrandDetails]  WITH CHECK ADD  CONSTRAINT [FK_MRiceBrandDetails_CustomerInfo] FOREIGN KEY([CustID])
REFERENCES [dbo].[CustomerInfo] ([CustID])
GO
ALTER TABLE [dbo].[MRiceBrandDetails] CHECK CONSTRAINT [FK_MRiceBrandDetails_CustomerInfo]
GO
/****** Object:  ForeignKey [FK_MProductSellingType_CustomerInfo]    Script Date: 05/28/2016 19:49:03 ******/
ALTER TABLE [dbo].[MProductSellingType]  WITH CHECK ADD  CONSTRAINT [FK_MProductSellingType_CustomerInfo] FOREIGN KEY([CustID])
REFERENCES [dbo].[CustomerInfo] ([CustID])
GO
ALTER TABLE [dbo].[MProductSellingType] CHECK CONSTRAINT [FK_MProductSellingType_CustomerInfo]
GO
/****** Object:  ForeignKey [FK_MPaddyType_CustomerInfo]    Script Date: 05/28/2016 19:49:03 ******/
ALTER TABLE [dbo].[MPaddyType]  WITH CHECK ADD  CONSTRAINT [FK_MPaddyType_CustomerInfo] FOREIGN KEY([CustID])
REFERENCES [dbo].[CustomerInfo] ([CustID])
GO
ALTER TABLE [dbo].[MPaddyType] CHECK CONSTRAINT [FK_MPaddyType_CustomerInfo]
GO
/****** Object:  ForeignKey [FK_CustomerAddressInfo_CustomerAddressInfo]    Script Date: 05/28/2016 19:49:03 ******/
ALTER TABLE [dbo].[CustomerAddressInfo]  WITH NOCHECK ADD  CONSTRAINT [FK_CustomerAddressInfo_CustomerAddressInfo] FOREIGN KEY([CustID])
REFERENCES [dbo].[CustomerInfo] ([CustID])
NOT FOR REPLICATION
GO
ALTER TABLE [dbo].[CustomerAddressInfo] NOCHECK CONSTRAINT [FK_CustomerAddressInfo_CustomerAddressInfo]
GO
/****** Object:  ForeignKey [FK_CustomerActivation_CustomerInfo]    Script Date: 05/28/2016 19:49:03 ******/
ALTER TABLE [dbo].[CustomerActivation]  WITH CHECK ADD  CONSTRAINT [FK_CustomerActivation_CustomerInfo] FOREIGN KEY([CustID])
REFERENCES [dbo].[CustomerInfo] ([CustID])
GO
ALTER TABLE [dbo].[CustomerActivation] CHECK CONSTRAINT [FK_CustomerActivation_CustomerInfo]
GO
/****** Object:  ForeignKey [FK_Users_CustomerInfo]    Script Date: 05/28/2016 19:49:03 ******/
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_CustomerInfo] FOREIGN KEY([CustID])
REFERENCES [dbo].[CustomerInfo] ([CustID])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_CustomerInfo]
GO
/****** Object:  ForeignKey [FK_MWeightDetails_CustomerInfo]    Script Date: 05/28/2016 19:49:03 ******/
ALTER TABLE [dbo].[MWeightDetails]  WITH CHECK ADD  CONSTRAINT [FK_MWeightDetails_CustomerInfo] FOREIGN KEY([CustID])
REFERENCES [dbo].[CustomerInfo] ([CustID])
GO
ALTER TABLE [dbo].[MWeightDetails] CHECK CONSTRAINT [FK_MWeightDetails_CustomerInfo]
GO
/****** Object:  ForeignKey [FK_MUnitsType_CustomerInfo]    Script Date: 05/28/2016 19:49:03 ******/
ALTER TABLE [dbo].[MUnitsType]  WITH CHECK ADD  CONSTRAINT [FK_MUnitsType_CustomerInfo] FOREIGN KEY([CustID])
REFERENCES [dbo].[CustomerInfo] ([CustID])
GO
ALTER TABLE [dbo].[MUnitsType] CHECK CONSTRAINT [FK_MUnitsType_CustomerInfo]
GO
/****** Object:  ForeignKey [FK_MSellerType_CustomerInfo]    Script Date: 05/28/2016 19:49:03 ******/
ALTER TABLE [dbo].[MSellerType]  WITH CHECK ADD  CONSTRAINT [FK_MSellerType_CustomerInfo] FOREIGN KEY([CustID])
REFERENCES [dbo].[CustomerInfo] ([CustID])
GO
ALTER TABLE [dbo].[MSellerType] CHECK CONSTRAINT [FK_MSellerType_CustomerInfo]
GO
/****** Object:  ForeignKey [FK_MGodownDetails_CustomerInfo]    Script Date: 05/28/2016 19:49:03 ******/
ALTER TABLE [dbo].[MGodownDetails]  WITH CHECK ADD  CONSTRAINT [FK_MGodownDetails_CustomerInfo] FOREIGN KEY([CustID])
REFERENCES [dbo].[CustomerInfo] ([CustID])
GO
ALTER TABLE [dbo].[MGodownDetails] CHECK CONSTRAINT [FK_MGodownDetails_CustomerInfo]
GO
/****** Object:  ForeignKey [FK_MessageInfo_CustomerInfo1]    Script Date: 05/28/2016 19:49:03 ******/
ALTER TABLE [dbo].[MessageInfo]  WITH CHECK ADD  CONSTRAINT [FK_MessageInfo_CustomerInfo1] FOREIGN KEY([CustID])
REFERENCES [dbo].[CustomerInfo] ([CustID])
GO
ALTER TABLE [dbo].[MessageInfo] CHECK CONSTRAINT [FK_MessageInfo_CustomerInfo1]
GO
/****** Object:  ForeignKey [FK_RiceStockInfo_CustomerInfo]    Script Date: 05/28/2016 19:49:03 ******/
ALTER TABLE [dbo].[RiceStockInfo]  WITH CHECK ADD  CONSTRAINT [FK_RiceStockInfo_CustomerInfo] FOREIGN KEY([CustID])
REFERENCES [dbo].[CustomerInfo] ([CustID])
GO
ALTER TABLE [dbo].[RiceStockInfo] CHECK CONSTRAINT [FK_RiceStockInfo_CustomerInfo]
GO
/****** Object:  ForeignKey [FK_RiceStockInfo_MRiceBrandDetails]    Script Date: 05/28/2016 19:49:03 ******/
ALTER TABLE [dbo].[RiceStockInfo]  WITH CHECK ADD  CONSTRAINT [FK_RiceStockInfo_MRiceBrandDetails] FOREIGN KEY([MRiceBrandID])
REFERENCES [dbo].[MRiceBrandDetails] ([MRiceBrandID])
GO
ALTER TABLE [dbo].[RiceStockInfo] CHECK CONSTRAINT [FK_RiceStockInfo_MRiceBrandDetails]
GO
/****** Object:  ForeignKey [FK_RiceStockInfo_MUnitsType]    Script Date: 05/28/2016 19:49:03 ******/
ALTER TABLE [dbo].[RiceStockInfo]  WITH CHECK ADD  CONSTRAINT [FK_RiceStockInfo_MUnitsType] FOREIGN KEY([UnitsTypeID])
REFERENCES [dbo].[MUnitsType] ([UnitsTypeID])
GO
ALTER TABLE [dbo].[RiceStockInfo] CHECK CONSTRAINT [FK_RiceStockInfo_MUnitsType]
GO
/****** Object:  ForeignKey [FK_RiceStockInfo_RiceStockInfo]    Script Date: 05/28/2016 19:49:03 ******/
ALTER TABLE [dbo].[RiceStockInfo]  WITH CHECK ADD  CONSTRAINT [FK_RiceStockInfo_RiceStockInfo] FOREIGN KEY([MRiceProdTypeID])
REFERENCES [dbo].[MRiceProductionType] ([MRiceProdTypeID])
GO
ALTER TABLE [dbo].[RiceStockInfo] CHECK CONSTRAINT [FK_RiceStockInfo_RiceStockInfo]
GO
/****** Object:  ForeignKey [FK_SellerInfo_CustomerInfo]    Script Date: 05/28/2016 19:49:03 ******/
ALTER TABLE [dbo].[SellerInfo]  WITH CHECK ADD  CONSTRAINT [FK_SellerInfo_CustomerInfo] FOREIGN KEY([CustID])
REFERENCES [dbo].[CustomerInfo] ([CustID])
GO
ALTER TABLE [dbo].[SellerInfo] CHECK CONSTRAINT [FK_SellerInfo_CustomerInfo]
GO
/****** Object:  ForeignKey [FK_SellerInfo_MSellerType]    Script Date: 05/28/2016 19:49:03 ******/
ALTER TABLE [dbo].[SellerInfo]  WITH CHECK ADD  CONSTRAINT [FK_SellerInfo_MSellerType] FOREIGN KEY([SellerTypeID])
REFERENCES [dbo].[MSellerType] ([SellerTypeID])
GO
ALTER TABLE [dbo].[SellerInfo] CHECK CONSTRAINT [FK_SellerInfo_MSellerType]
GO
/****** Object:  ForeignKey [FK_BrokenRiceStockInfo_CustomerInfo]    Script Date: 05/28/2016 19:49:03 ******/
ALTER TABLE [dbo].[BrokenRiceStockInfo]  WITH CHECK ADD  CONSTRAINT [FK_BrokenRiceStockInfo_CustomerInfo] FOREIGN KEY([CustID])
REFERENCES [dbo].[CustomerInfo] ([CustID])
GO
ALTER TABLE [dbo].[BrokenRiceStockInfo] CHECK CONSTRAINT [FK_BrokenRiceStockInfo_CustomerInfo]
GO
/****** Object:  ForeignKey [FK_BrokenRiceStockInfo_MBrokenRiceType]    Script Date: 05/28/2016 19:49:03 ******/
ALTER TABLE [dbo].[BrokenRiceStockInfo]  WITH CHECK ADD  CONSTRAINT [FK_BrokenRiceStockInfo_MBrokenRiceType] FOREIGN KEY([BrokenRiceTypeID])
REFERENCES [dbo].[MBrokenRiceType] ([BrokenRiceTypeID])
GO
ALTER TABLE [dbo].[BrokenRiceStockInfo] CHECK CONSTRAINT [FK_BrokenRiceStockInfo_MBrokenRiceType]
GO
/****** Object:  ForeignKey [FK_BrokenRiceStockInfo_MUnitsType]    Script Date: 05/28/2016 19:49:03 ******/
ALTER TABLE [dbo].[BrokenRiceStockInfo]  WITH CHECK ADD  CONSTRAINT [FK_BrokenRiceStockInfo_MUnitsType] FOREIGN KEY([UnitsTypeID])
REFERENCES [dbo].[MUnitsType] ([UnitsTypeID])
GO
ALTER TABLE [dbo].[BrokenRiceStockInfo] CHECK CONSTRAINT [FK_BrokenRiceStockInfo_MUnitsType]
GO
/****** Object:  ForeignKey [FK_MLotDetails_CustomerInfo]    Script Date: 05/28/2016 19:49:03 ******/
ALTER TABLE [dbo].[MLotDetails]  WITH CHECK ADD  CONSTRAINT [FK_MLotDetails_CustomerInfo] FOREIGN KEY([CustID])
REFERENCES [dbo].[CustomerInfo] ([CustID])
GO
ALTER TABLE [dbo].[MLotDetails] CHECK CONSTRAINT [FK_MLotDetails_CustomerInfo]
GO
/****** Object:  ForeignKey [FK_MLotDetails_MGodownDetails]    Script Date: 05/28/2016 19:49:03 ******/
ALTER TABLE [dbo].[MLotDetails]  WITH CHECK ADD  CONSTRAINT [FK_MLotDetails_MGodownDetails] FOREIGN KEY([MGodownID])
REFERENCES [dbo].[MGodownDetails] ([MGodownID])
GO
ALTER TABLE [dbo].[MLotDetails] CHECK CONSTRAINT [FK_MLotDetails_MGodownDetails]
GO
/****** Object:  ForeignKey [FK_HullingProcess_CustomerInfo]    Script Date: 05/28/2016 19:49:03 ******/
ALTER TABLE [dbo].[HullingProcess]  WITH CHECK ADD  CONSTRAINT [FK_HullingProcess_CustomerInfo] FOREIGN KEY([CustID])
REFERENCES [dbo].[CustomerInfo] ([CustID])
GO
ALTER TABLE [dbo].[HullingProcess] CHECK CONSTRAINT [FK_HullingProcess_CustomerInfo]
GO
/****** Object:  ForeignKey [FK_HullingProcess_MPaddyType]    Script Date: 05/28/2016 19:49:03 ******/
ALTER TABLE [dbo].[HullingProcess]  WITH CHECK ADD  CONSTRAINT [FK_HullingProcess_MPaddyType] FOREIGN KEY([PaddyTypeID])
REFERENCES [dbo].[MPaddyType] ([PaddyTypeID])
GO
ALTER TABLE [dbo].[HullingProcess] CHECK CONSTRAINT [FK_HullingProcess_MPaddyType]
GO
/****** Object:  ForeignKey [FK_HullingProcess_MUnitsType]    Script Date: 05/28/2016 19:49:03 ******/
ALTER TABLE [dbo].[HullingProcess]  WITH CHECK ADD  CONSTRAINT [FK_HullingProcess_MUnitsType] FOREIGN KEY([UnitsTypeID])
REFERENCES [dbo].[MUnitsType] ([UnitsTypeID])
GO
ALTER TABLE [dbo].[HullingProcess] CHECK CONSTRAINT [FK_HullingProcess_MUnitsType]
GO
/****** Object:  ForeignKey [FK_DustStockInfo_CustomerInfo]    Script Date: 05/28/2016 19:49:03 ******/
ALTER TABLE [dbo].[DustStockInfo]  WITH CHECK ADD  CONSTRAINT [FK_DustStockInfo_CustomerInfo] FOREIGN KEY([CustID])
REFERENCES [dbo].[CustomerInfo] ([CustID])
GO
ALTER TABLE [dbo].[DustStockInfo] CHECK CONSTRAINT [FK_DustStockInfo_CustomerInfo]
GO
/****** Object:  ForeignKey [FK_DustStockInfo_MUnitsType]    Script Date: 05/28/2016 19:49:03 ******/
ALTER TABLE [dbo].[DustStockInfo]  WITH CHECK ADD  CONSTRAINT [FK_DustStockInfo_MUnitsType] FOREIGN KEY([UnitsTypeID])
REFERENCES [dbo].[MUnitsType] ([UnitsTypeID])
GO
ALTER TABLE [dbo].[DustStockInfo] CHECK CONSTRAINT [FK_DustStockInfo_MUnitsType]
GO
/****** Object:  ForeignKey [FK_DustSellingInfo_CustomerInfo]    Script Date: 05/28/2016 19:49:03 ******/
ALTER TABLE [dbo].[DustSellingInfo]  WITH CHECK ADD  CONSTRAINT [FK_DustSellingInfo_CustomerInfo] FOREIGN KEY([CustID])
REFERENCES [dbo].[CustomerInfo] ([CustID])
GO
ALTER TABLE [dbo].[DustSellingInfo] CHECK CONSTRAINT [FK_DustSellingInfo_CustomerInfo]
GO
/****** Object:  ForeignKey [FK_DustSellingInfo_MUnitsType]    Script Date: 05/28/2016 19:49:03 ******/
ALTER TABLE [dbo].[DustSellingInfo]  WITH CHECK ADD  CONSTRAINT [FK_DustSellingInfo_MUnitsType] FOREIGN KEY([UnitsTypeID])
REFERENCES [dbo].[MUnitsType] ([UnitsTypeID])
GO
ALTER TABLE [dbo].[DustSellingInfo] CHECK CONSTRAINT [FK_DustSellingInfo_MUnitsType]
GO
/****** Object:  ForeignKey [FK_DustSellingInfo_SellerInfo]    Script Date: 05/28/2016 19:49:03 ******/
ALTER TABLE [dbo].[DustSellingInfo]  WITH CHECK ADD  CONSTRAINT [FK_DustSellingInfo_SellerInfo] FOREIGN KEY([SellerID])
REFERENCES [dbo].[SellerInfo] ([SellerID])
GO
ALTER TABLE [dbo].[DustSellingInfo] CHECK CONSTRAINT [FK_DustSellingInfo_SellerInfo]
GO
/****** Object:  ForeignKey [FK_HullingTransaction_CustomerInfo]    Script Date: 05/28/2016 19:49:03 ******/
ALTER TABLE [dbo].[HullingTransaction]  WITH CHECK ADD  CONSTRAINT [FK_HullingTransaction_CustomerInfo] FOREIGN KEY([CustID])
REFERENCES [dbo].[CustomerInfo] ([CustID])
GO
ALTER TABLE [dbo].[HullingTransaction] CHECK CONSTRAINT [FK_HullingTransaction_CustomerInfo]
GO
/****** Object:  ForeignKey [FK_HullingTransaction_HullingProcess]    Script Date: 05/28/2016 19:49:03 ******/
ALTER TABLE [dbo].[HullingTransaction]  WITH CHECK ADD  CONSTRAINT [FK_HullingTransaction_HullingProcess] FOREIGN KEY([HullingProcessID])
REFERENCES [dbo].[HullingProcess] ([HullingProcessID])
GO
ALTER TABLE [dbo].[HullingTransaction] CHECK CONSTRAINT [FK_HullingTransaction_HullingProcess]
GO
/****** Object:  ForeignKey [FK_HullingTransaction_MBrokenRiceType]    Script Date: 05/28/2016 19:49:03 ******/
ALTER TABLE [dbo].[HullingTransaction]  WITH CHECK ADD  CONSTRAINT [FK_HullingTransaction_MBrokenRiceType] FOREIGN KEY([BrokenRiceTypeID])
REFERENCES [dbo].[MBrokenRiceType] ([BrokenRiceTypeID])
GO
ALTER TABLE [dbo].[HullingTransaction] CHECK CONSTRAINT [FK_HullingTransaction_MBrokenRiceType]
GO
/****** Object:  ForeignKey [FK_HullingTransaction_MPaddyType]    Script Date: 05/28/2016 19:49:03 ******/
ALTER TABLE [dbo].[HullingTransaction]  WITH CHECK ADD  CONSTRAINT [FK_HullingTransaction_MPaddyType] FOREIGN KEY([PaddyTypeID])
REFERENCES [dbo].[MPaddyType] ([PaddyTypeID])
GO
ALTER TABLE [dbo].[HullingTransaction] CHECK CONSTRAINT [FK_HullingTransaction_MPaddyType]
GO
/****** Object:  ForeignKey [FK_HullingTransaction_MRiceProductionType]    Script Date: 05/28/2016 19:49:03 ******/
ALTER TABLE [dbo].[HullingTransaction]  WITH CHECK ADD  CONSTRAINT [FK_HullingTransaction_MRiceProductionType] FOREIGN KEY([MRiceProdTypeID])
REFERENCES [dbo].[MRiceProductionType] ([MRiceProdTypeID])
GO
ALTER TABLE [dbo].[HullingTransaction] CHECK CONSTRAINT [FK_HullingTransaction_MRiceProductionType]
GO
/****** Object:  ForeignKey [FK_HullingTransaction_MUnitsType]    Script Date: 05/28/2016 19:49:03 ******/
ALTER TABLE [dbo].[HullingTransaction]  WITH CHECK ADD  CONSTRAINT [FK_HullingTransaction_MUnitsType] FOREIGN KEY([UnitsTypeID])
REFERENCES [dbo].[MUnitsType] ([UnitsTypeID])
GO
ALTER TABLE [dbo].[HullingTransaction] CHECK CONSTRAINT [FK_HullingTransaction_MUnitsType]
GO
/****** Object:  ForeignKey [FK_HullingProcessExpenses_HullingProcess]    Script Date: 05/28/2016 19:49:03 ******/
ALTER TABLE [dbo].[HullingProcessExpenses]  WITH CHECK ADD  CONSTRAINT [FK_HullingProcessExpenses_HullingProcess] FOREIGN KEY([HullingProcessID])
REFERENCES [dbo].[HullingProcess] ([HullingProcessID])
GO
ALTER TABLE [dbo].[HullingProcessExpenses] CHECK CONSTRAINT [FK_HullingProcessExpenses_HullingProcess]
GO
/****** Object:  ForeignKey [FK_BrokenRiceSellingInfo_CustomerInfo]    Script Date: 05/28/2016 19:49:03 ******/
ALTER TABLE [dbo].[BrokenRiceSellingInfo]  WITH CHECK ADD  CONSTRAINT [FK_BrokenRiceSellingInfo_CustomerInfo] FOREIGN KEY([CustID])
REFERENCES [dbo].[CustomerInfo] ([CustID])
GO
ALTER TABLE [dbo].[BrokenRiceSellingInfo] CHECK CONSTRAINT [FK_BrokenRiceSellingInfo_CustomerInfo]
GO
/****** Object:  ForeignKey [FK_BrokenRiceSellingInfo_MBrokenRiceType]    Script Date: 05/28/2016 19:49:03 ******/
ALTER TABLE [dbo].[BrokenRiceSellingInfo]  WITH CHECK ADD  CONSTRAINT [FK_BrokenRiceSellingInfo_MBrokenRiceType] FOREIGN KEY([BrokenRiceTypeID])
REFERENCES [dbo].[MBrokenRiceType] ([BrokenRiceTypeID])
GO
ALTER TABLE [dbo].[BrokenRiceSellingInfo] CHECK CONSTRAINT [FK_BrokenRiceSellingInfo_MBrokenRiceType]
GO
/****** Object:  ForeignKey [FK_BrokenRiceSellingInfo_MUnitsType]    Script Date: 05/28/2016 19:49:03 ******/
ALTER TABLE [dbo].[BrokenRiceSellingInfo]  WITH CHECK ADD  CONSTRAINT [FK_BrokenRiceSellingInfo_MUnitsType] FOREIGN KEY([UnitsTypeID])
REFERENCES [dbo].[MUnitsType] ([UnitsTypeID])
GO
ALTER TABLE [dbo].[BrokenRiceSellingInfo] CHECK CONSTRAINT [FK_BrokenRiceSellingInfo_MUnitsType]
GO
/****** Object:  ForeignKey [FK_BrokenRiceSellingInfo_SellerInfo1]    Script Date: 05/28/2016 19:49:03 ******/
ALTER TABLE [dbo].[BrokenRiceSellingInfo]  WITH CHECK ADD  CONSTRAINT [FK_BrokenRiceSellingInfo_SellerInfo1] FOREIGN KEY([SellerID])
REFERENCES [dbo].[SellerInfo] ([SellerID])
GO
ALTER TABLE [dbo].[BrokenRiceSellingInfo] CHECK CONSTRAINT [FK_BrokenRiceSellingInfo_SellerInfo1]
GO
/****** Object:  ForeignKey [FK_BagStockInfo_CustomerInfo]    Script Date: 05/28/2016 19:49:03 ******/
ALTER TABLE [dbo].[BagStockInfo]  WITH CHECK ADD  CONSTRAINT [FK_BagStockInfo_CustomerInfo] FOREIGN KEY([CustID])
REFERENCES [dbo].[CustomerInfo] ([CustID])
GO
ALTER TABLE [dbo].[BagStockInfo] CHECK CONSTRAINT [FK_BagStockInfo_CustomerInfo]
GO
/****** Object:  ForeignKey [FK_BagStockInfo_SellerInfo]    Script Date: 05/28/2016 19:49:03 ******/
ALTER TABLE [dbo].[BagStockInfo]  WITH CHECK ADD  CONSTRAINT [FK_BagStockInfo_SellerInfo] FOREIGN KEY([SellerID])
REFERENCES [dbo].[SellerInfo] ([SellerID])
GO
ALTER TABLE [dbo].[BagStockInfo] CHECK CONSTRAINT [FK_BagStockInfo_SellerInfo]
GO
/****** Object:  ForeignKey [fk_BagType]    Script Date: 05/28/2016 19:49:03 ******/
ALTER TABLE [dbo].[BagStockInfo]  WITH CHECK ADD  CONSTRAINT [fk_BagType] FOREIGN KEY([BagTypeID])
REFERENCES [dbo].[MBagType] ([BagTypeID])
GO
ALTER TABLE [dbo].[BagStockInfo] CHECK CONSTRAINT [fk_BagType]
GO
/****** Object:  ForeignKey [FK_PaddyStockInfo_CustomerInfo]    Script Date: 05/28/2016 19:49:03 ******/
ALTER TABLE [dbo].[PaddyStockInfo]  WITH CHECK ADD  CONSTRAINT [FK_PaddyStockInfo_CustomerInfo] FOREIGN KEY([CustID])
REFERENCES [dbo].[CustomerInfo] ([CustID])
GO
ALTER TABLE [dbo].[PaddyStockInfo] CHECK CONSTRAINT [FK_PaddyStockInfo_CustomerInfo]
GO
/****** Object:  ForeignKey [FK_PaddyStockInfo_MGodownDetails]    Script Date: 05/28/2016 19:49:03 ******/
ALTER TABLE [dbo].[PaddyStockInfo]  WITH CHECK ADD  CONSTRAINT [FK_PaddyStockInfo_MGodownDetails] FOREIGN KEY([MGodownID])
REFERENCES [dbo].[MGodownDetails] ([MGodownID])
GO
ALTER TABLE [dbo].[PaddyStockInfo] CHECK CONSTRAINT [FK_PaddyStockInfo_MGodownDetails]
GO
/****** Object:  ForeignKey [FK_PaddyStockInfo_MLotDetails]    Script Date: 05/28/2016 19:49:03 ******/
ALTER TABLE [dbo].[PaddyStockInfo]  WITH CHECK ADD  CONSTRAINT [FK_PaddyStockInfo_MLotDetails] FOREIGN KEY([MLotID])
REFERENCES [dbo].[MLotDetails] ([MLotID])
GO
ALTER TABLE [dbo].[PaddyStockInfo] CHECK CONSTRAINT [FK_PaddyStockInfo_MLotDetails]
GO
/****** Object:  ForeignKey [FK_PaddyStockInfo_MPaddyType]    Script Date: 05/28/2016 19:49:03 ******/
ALTER TABLE [dbo].[PaddyStockInfo]  WITH CHECK ADD  CONSTRAINT [FK_PaddyStockInfo_MPaddyType] FOREIGN KEY([PaddyTypeID])
REFERENCES [dbo].[MPaddyType] ([PaddyTypeID])
GO
ALTER TABLE [dbo].[PaddyStockInfo] CHECK CONSTRAINT [FK_PaddyStockInfo_MPaddyType]
GO
/****** Object:  ForeignKey [FK_PaddyStockInfo_SellerInfo]    Script Date: 05/28/2016 19:49:03 ******/
ALTER TABLE [dbo].[PaddyStockInfo]  WITH CHECK ADD  CONSTRAINT [FK_PaddyStockInfo_SellerInfo] FOREIGN KEY([SellerID])
REFERENCES [dbo].[SellerInfo] ([SellerID])
GO
ALTER TABLE [dbo].[PaddyStockInfo] CHECK CONSTRAINT [FK_PaddyStockInfo_SellerInfo]
GO
/****** Object:  ForeignKey [FK_PaddyPaymentDetails_CustomerInfo]    Script Date: 05/28/2016 19:49:03 ******/
ALTER TABLE [dbo].[PaddyPaymentDetails]  WITH CHECK ADD  CONSTRAINT [FK_PaddyPaymentDetails_CustomerInfo] FOREIGN KEY([CustID])
REFERENCES [dbo].[CustomerInfo] ([CustID])
GO
ALTER TABLE [dbo].[PaddyPaymentDetails] CHECK CONSTRAINT [FK_PaddyPaymentDetails_CustomerInfo]
GO
/****** Object:  ForeignKey [FK_PaddyPaymentDetails_SellerInfo]    Script Date: 05/28/2016 19:49:03 ******/
ALTER TABLE [dbo].[PaddyPaymentDetails]  WITH CHECK ADD  CONSTRAINT [FK_PaddyPaymentDetails_SellerInfo] FOREIGN KEY([SellerID])
REFERENCES [dbo].[SellerInfo] ([SellerID])
GO
ALTER TABLE [dbo].[PaddyPaymentDetails] CHECK CONSTRAINT [FK_PaddyPaymentDetails_SellerInfo]
GO
/****** Object:  ForeignKey [FK_RiceSellingInfo_CustomerInfo]    Script Date: 05/28/2016 19:49:03 ******/
ALTER TABLE [dbo].[RiceSellingInfo]  WITH CHECK ADD  CONSTRAINT [FK_RiceSellingInfo_CustomerInfo] FOREIGN KEY([CustID])
REFERENCES [dbo].[CustomerInfo] ([CustID])
GO
ALTER TABLE [dbo].[RiceSellingInfo] CHECK CONSTRAINT [FK_RiceSellingInfo_CustomerInfo]
GO
/****** Object:  ForeignKey [FK_RiceSellingInfo_MRiceBrandDetails]    Script Date: 05/28/2016 19:49:03 ******/
ALTER TABLE [dbo].[RiceSellingInfo]  WITH CHECK ADD  CONSTRAINT [FK_RiceSellingInfo_MRiceBrandDetails] FOREIGN KEY([MRiceBrandID])
REFERENCES [dbo].[MRiceBrandDetails] ([MRiceBrandID])
GO
ALTER TABLE [dbo].[RiceSellingInfo] CHECK CONSTRAINT [FK_RiceSellingInfo_MRiceBrandDetails]
GO
/****** Object:  ForeignKey [FK_RiceSellingInfo_MRiceProductionType]    Script Date: 05/28/2016 19:49:03 ******/
ALTER TABLE [dbo].[RiceSellingInfo]  WITH CHECK ADD  CONSTRAINT [FK_RiceSellingInfo_MRiceProductionType] FOREIGN KEY([MRiceProdTypeID])
REFERENCES [dbo].[MRiceProductionType] ([MRiceProdTypeID])
GO
ALTER TABLE [dbo].[RiceSellingInfo] CHECK CONSTRAINT [FK_RiceSellingInfo_MRiceProductionType]
GO
/****** Object:  ForeignKey [FK_RiceSellingInfo_MUnitsType]    Script Date: 05/28/2016 19:49:03 ******/
ALTER TABLE [dbo].[RiceSellingInfo]  WITH CHECK ADD  CONSTRAINT [FK_RiceSellingInfo_MUnitsType] FOREIGN KEY([UnitsTypeID])
REFERENCES [dbo].[MUnitsType] ([UnitsTypeID])
GO
ALTER TABLE [dbo].[RiceSellingInfo] CHECK CONSTRAINT [FK_RiceSellingInfo_MUnitsType]
GO
/****** Object:  ForeignKey [FK_RiceSellingInfo_SellerInfo]    Script Date: 05/28/2016 19:49:03 ******/
ALTER TABLE [dbo].[RiceSellingInfo]  WITH CHECK ADD  CONSTRAINT [FK_RiceSellingInfo_SellerInfo] FOREIGN KEY([SellerID])
REFERENCES [dbo].[SellerInfo] ([SellerID])
GO
ALTER TABLE [dbo].[RiceSellingInfo] CHECK CONSTRAINT [FK_RiceSellingInfo_SellerInfo]
GO
/****** Object:  ForeignKey [fk_MProductSellingType]    Script Date: 05/28/2016 19:49:03 ******/
ALTER TABLE [dbo].[ProductSellingInfo]  WITH CHECK ADD  CONSTRAINT [fk_MProductSellingType] FOREIGN KEY([ProductTypeID])
REFERENCES [dbo].[MProductSellingType] ([ProductTypeID])
GO
ALTER TABLE [dbo].[ProductSellingInfo] CHECK CONSTRAINT [fk_MProductSellingType]
GO
/****** Object:  ForeignKey [FK_ProductSellingInfo_CustomerInfo]    Script Date: 05/28/2016 19:49:03 ******/
ALTER TABLE [dbo].[ProductSellingInfo]  WITH CHECK ADD  CONSTRAINT [FK_ProductSellingInfo_CustomerInfo] FOREIGN KEY([CustID])
REFERENCES [dbo].[CustomerInfo] ([CustID])
GO
ALTER TABLE [dbo].[ProductSellingInfo] CHECK CONSTRAINT [FK_ProductSellingInfo_CustomerInfo]
GO
/****** Object:  ForeignKey [FK_ProductSellingInfo_MBrokenRiceType]    Script Date: 05/28/2016 19:49:03 ******/
ALTER TABLE [dbo].[ProductSellingInfo]  WITH CHECK ADD  CONSTRAINT [FK_ProductSellingInfo_MBrokenRiceType] FOREIGN KEY([BrokenRiceTypeID])
REFERENCES [dbo].[MBrokenRiceType] ([BrokenRiceTypeID])
GO
ALTER TABLE [dbo].[ProductSellingInfo] CHECK CONSTRAINT [FK_ProductSellingInfo_MBrokenRiceType]
GO
/****** Object:  ForeignKey [FK_ProductSellingInfo_MRiceBrandDetails]    Script Date: 05/28/2016 19:49:03 ******/
ALTER TABLE [dbo].[ProductSellingInfo]  WITH CHECK ADD  CONSTRAINT [FK_ProductSellingInfo_MRiceBrandDetails] FOREIGN KEY([MRiceBrandID])
REFERENCES [dbo].[MRiceBrandDetails] ([MRiceBrandID])
GO
ALTER TABLE [dbo].[ProductSellingInfo] CHECK CONSTRAINT [FK_ProductSellingInfo_MRiceBrandDetails]
GO
/****** Object:  ForeignKey [FK_ProductSellingInfo_MRiceProductionType]    Script Date: 05/28/2016 19:49:03 ******/
ALTER TABLE [dbo].[ProductSellingInfo]  WITH CHECK ADD  CONSTRAINT [FK_ProductSellingInfo_MRiceProductionType] FOREIGN KEY([MRiceProdTypeID])
REFERENCES [dbo].[MRiceProductionType] ([MRiceProdTypeID])
GO
ALTER TABLE [dbo].[ProductSellingInfo] CHECK CONSTRAINT [FK_ProductSellingInfo_MRiceProductionType]
GO
/****** Object:  ForeignKey [FK_ProductSellingInfo_MUnitsType]    Script Date: 05/28/2016 19:49:03 ******/
ALTER TABLE [dbo].[ProductSellingInfo]  WITH CHECK ADD  CONSTRAINT [FK_ProductSellingInfo_MUnitsType] FOREIGN KEY([UnitsTypeID])
REFERENCES [dbo].[MUnitsType] ([UnitsTypeID])
GO
ALTER TABLE [dbo].[ProductSellingInfo] CHECK CONSTRAINT [FK_ProductSellingInfo_MUnitsType]
GO
/****** Object:  ForeignKey [FK_ProductSellingInfo_SellerInfo]    Script Date: 05/28/2016 19:49:03 ******/
ALTER TABLE [dbo].[ProductSellingInfo]  WITH CHECK ADD  CONSTRAINT [FK_ProductSellingInfo_SellerInfo] FOREIGN KEY([SellerID])
REFERENCES [dbo].[SellerInfo] ([SellerID])
GO
ALTER TABLE [dbo].[ProductSellingInfo] CHECK CONSTRAINT [FK_ProductSellingInfo_SellerInfo]
GO
/****** Object:  ForeignKey [FK_ProductPaymentInfo_CustomerInfo]    Script Date: 05/28/2016 19:49:03 ******/
ALTER TABLE [dbo].[ProductPaymentInfo]  WITH CHECK ADD  CONSTRAINT [FK_ProductPaymentInfo_CustomerInfo] FOREIGN KEY([CustID])
REFERENCES [dbo].[CustomerInfo] ([CustID])
GO
ALTER TABLE [dbo].[ProductPaymentInfo] CHECK CONSTRAINT [FK_ProductPaymentInfo_CustomerInfo]
GO
/****** Object:  ForeignKey [FK_ProductPaymentInfo_ProductSellingInfo]    Script Date: 05/28/2016 19:49:03 ******/
ALTER TABLE [dbo].[ProductPaymentInfo]  WITH CHECK ADD  CONSTRAINT [FK_ProductPaymentInfo_ProductSellingInfo] FOREIGN KEY([ProductID])
REFERENCES [dbo].[ProductSellingInfo] ([ProductID])
GO
ALTER TABLE [dbo].[ProductPaymentInfo] CHECK CONSTRAINT [FK_ProductPaymentInfo_ProductSellingInfo]
GO
