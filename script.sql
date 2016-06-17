USE [master]
GO
/****** Object:  Database [RMIS]    Script Date: 06/17/2016 21:22:39 ******/
CREATE DATABASE [RMIS] ON  PRIMARY 
( NAME = N'RMIS', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\RMIS.mdf' , SIZE = 2048KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'RMIS_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\RMIS_log.ldf' , SIZE = 3072KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
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
/****** Object:  Table [dbo].[RMUserRole]    Script Date: 06/17/2016 21:22:40 ******/
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
INSERT [dbo].[RMUserRole] ([UserRoleId], [RoleId], [UserID], [CustID], [ObsInd], [LastModifiedBy], [LastModifiedDate]) VALUES (N'UR2016053021461092871124463', N'RL2016053021455286103578028', N'UI2016053021461063450110035', N'Om', N'N', N'System', CAST(0x0000A6160166BFD8 AS DateTime))
INSERT [dbo].[RMUserRole] ([UserRoleId], [RoleId], [UserID], [CustID], [ObsInd], [LastModifiedBy], [LastModifiedDate]) VALUES (N'UR2016053022083903360748573', N'RL2016053021455286103578028', N'UI2016053022083887472961429', N'Om1', N'N', N'System', CAST(0x0000A616016CECB4 AS DateTime))
INSERT [dbo].[RMUserRole] ([UserRoleId], [RoleId], [UserID], [CustID], [ObsInd], [LastModifiedBy], [LastModifiedDate]) VALUES (N'UR2016060816483132335363101', N'RL2016053021455286103578028', N'UI2016060816482920430349260', N'Om1', N'N', N'Om\test', CAST(0x0000A61F0114FF54 AS DateTime))
/****** Object:  Table [dbo].[MenuInfo]    Script Date: 06/17/2016 21:22:40 ******/
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
INSERT [dbo].[MenuInfo] ([MenuID], [ParentMenuID], [Title], [Description], [URL], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (1, NULL, N'All  Configuration                                ', N'All  Configuration', N'', N'System', CAST(0x0000A60A01844139 AS DateTime), N'N')
INSERT [dbo].[MenuInfo] ([MenuID], [ParentMenuID], [Title], [Description], [URL], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (3, 1, N'Add Paddy Types                                   ', N'Add Paddy Types', N'AddPaddyType.ascx', N'System', CAST(0x0000A60A0184413B AS DateTime), N'N')
INSERT [dbo].[MenuInfo] ([MenuID], [ParentMenuID], [Title], [Description], [URL], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (4, 1, N'Add Unit Types                                    ', N'Add Unit Types', N'AddUnitsType.ascx', N'System', CAST(0x0000A60A0184413B AS DateTime), N'N')
INSERT [dbo].[MenuInfo] ([MenuID], [ParentMenuID], [Title], [Description], [URL], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (5, 1, N'Add Godown Types                                  ', N'Add Godown Types', N'AddGodownDetails.ascx', N'System', CAST(0x0000A60A0184413B AS DateTime), N'N')
INSERT [dbo].[MenuInfo] ([MenuID], [ParentMenuID], [Title], [Description], [URL], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (6, 1, N'Add Lot Types                                     ', N'Add Lot Types', N'AddLotDetails.ascx', N'System', CAST(0x0000A60A0184413B AS DateTime), N'N')
INSERT [dbo].[MenuInfo] ([MenuID], [ParentMenuID], [Title], [Description], [URL], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (7, 1, N'Add Bag Types                                     ', N'Add Bag Types', N'AddBagType.ascx', N'System', CAST(0x0000A60A0184413B AS DateTime), N'N')
INSERT [dbo].[MenuInfo] ([MenuID], [ParentMenuID], [Title], [Description], [URL], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (8, 1, N'Add Rice Type                                     ', N'Add RiceType', N'AddRiceType.ascx', N'System', CAST(0x0000A60A0184413B AS DateTime), N'N')
INSERT [dbo].[MenuInfo] ([MenuID], [ParentMenuID], [Title], [Description], [URL], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (9, 1, N'Add Broken Rice Type                              ', N'Add Broken Rice', N'AddBrokenRiceType.ascx', N'System', CAST(0x0000A60A0184413B AS DateTime), N'N')
INSERT [dbo].[MenuInfo] ([MenuID], [ParentMenuID], [Title], [Description], [URL], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (10, NULL, N'Purchase                                          ', N'Purchase', N'', N'System', CAST(0x0000A60A0184413B AS DateTime), N'N')
INSERT [dbo].[MenuInfo] ([MenuID], [ParentMenuID], [Title], [Description], [URL], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (11, 10, N'Add Seller Information                            ', N'Add Seller Information', N'SellerInfoDetails.ascx', N'System', CAST(0x0000A60A0184413B AS DateTime), N'N')
INSERT [dbo].[MenuInfo] ([MenuID], [ParentMenuID], [Title], [Description], [URL], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (12, 10, N'Paddy Stock                                       ', N'Paddy Stock', N'TransactionPaddyStockInfo.ascx', N'System', CAST(0x0000A60A0184413B AS DateTime), N'N')
INSERT [dbo].[MenuInfo] ([MenuID], [ParentMenuID], [Title], [Description], [URL], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (13, 10, N'Bag Stock Infomation                              ', N'Bag Stok Info', N'BagStockInfo.ascx', N'System', CAST(0x0000A60A0184413B AS DateTime), N'N')
INSERT [dbo].[MenuInfo] ([MenuID], [ParentMenuID], [Title], [Description], [URL], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (14, NULL, N'Hulling Process                                   ', N'Hulling Process', N'', N'System', CAST(0x0000A60A0184413B AS DateTime), N'N')
INSERT [dbo].[MenuInfo] ([MenuID], [ParentMenuID], [Title], [Description], [URL], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (15, 14, N'Add Process                                       ', N'Add Process', N'HullingProcess.ascx', N'System', CAST(0x0000A60A0184413B AS DateTime), N'N')
INSERT [dbo].[MenuInfo] ([MenuID], [ParentMenuID], [Title], [Description], [URL], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (16, NULL, N'Selling                                           ', N'Selling', N'', N'System', CAST(0x0000A60A0184413B AS DateTime), N'N')
INSERT [dbo].[MenuInfo] ([MenuID], [ParentMenuID], [Title], [Description], [URL], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (17, 16, N'Product Selling Information                       ', N'Product Selling Information  ', N'ProductSellingInfo.ascx', N'System', CAST(0x0000A60A0184413B AS DateTime), N'N')
INSERT [dbo].[MenuInfo] ([MenuID], [ParentMenuID], [Title], [Description], [URL], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (18, 16, N'Product Returned Information                      ', N'Product Returned Information', N'ProductReturnInfo.ascx', N'System', CAST(0x0000A60A0184413B AS DateTime), N'N')
INSERT [dbo].[MenuInfo] ([MenuID], [ParentMenuID], [Title], [Description], [URL], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (19, 1, N'Add Rice Brand                                    ', N'Add Rice Brand', N'AddRiceBrandType.ascx', N'System', CAST(0x0000A60A0184413B AS DateTime), N'N')
INSERT [dbo].[MenuInfo] ([MenuID], [ParentMenuID], [Title], [Description], [URL], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (20, 16, N'Add Product Selling Type                          ', N'Add Product Selling Type', N'AddProductSellingType.ascx', N'System', CAST(0x0000A60A0184413B AS DateTime), N'N')
INSERT [dbo].[MenuInfo] ([MenuID], [ParentMenuID], [Title], [Description], [URL], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (21, NULL, N'Reports                                           ', N'Reports', N'', N'System', CAST(0x0000A60A0184413B AS DateTime), N'N')
INSERT [dbo].[MenuInfo] ([MenuID], [ParentMenuID], [Title], [Description], [URL], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (22, 1, N'Add Employee Designation                          ', N'Add Employee Designation', N'AddEmpDesig.ascx', N'System', CAST(0x0000A61F01044A5D AS DateTime), N'N')
INSERT [dbo].[MenuInfo] ([MenuID], [ParentMenuID], [Title], [Description], [URL], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (23, 1, N'Add Salary Type                                   ', N'Add Salary Type', N'AddSalaryType.ascx', N'System', CAST(0x0000A61F01044A5D AS DateTime), N'N')
INSERT [dbo].[MenuInfo] ([MenuID], [ParentMenuID], [Title], [Description], [URL], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (24, 1, N'Add Employee                                      ', N'Add Employee', N'EmployeeDetails.ascx', N'System', CAST(0x0000A61F01044A5D AS DateTime), N'N')
INSERT [dbo].[MenuInfo] ([MenuID], [ParentMenuID], [Title], [Description], [URL], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (25, 1, N'Add Employee Salary                               ', N'Add Employee Salary', N'EmployeeSalary.ascx', N'System', CAST(0x0000A61F01044A5D AS DateTime), N'N')
INSERT [dbo].[MenuInfo] ([MenuID], [ParentMenuID], [Title], [Description], [URL], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (26, 21, N'Paddy Stock Report                                ', N'Paddy Stock Report', N'RPT_PaddyStockReport.ascx', N'System', CAST(0x0000A61F01050E82 AS DateTime), N'N')
INSERT [dbo].[MenuInfo] ([MenuID], [ParentMenuID], [Title], [Description], [URL], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (27, NULL, N'Payments                                          ', N'Payments', N'', N'System', CAST(0x0000A62000DA7A39 AS DateTime), N'N')
INSERT [dbo].[MenuInfo] ([MenuID], [ParentMenuID], [Title], [Description], [URL], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (28, 27, N'Salary Payment                                    ', N'Salary Payment', N'EmployeeSalaryPayment.ascx', N'System', CAST(0x0000A62000DAD3A1 AS DateTime), N'N')
INSERT [dbo].[MenuInfo] ([MenuID], [ParentMenuID], [Title], [Description], [URL], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (29, 16, N'Add Buyer Information                             ', N'Add Buyer Information', N'BuyerInfoDetails.ascx', N'System', CAST(0x0000A62801212D91 AS DateTime), N'N')
/****** Object:  Table [dbo].[MenuConfiguration]    Script Date: 06/17/2016 21:22:40 ******/
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
/****** Object:  Table [dbo].[CustomerInfo]    Script Date: 06/17/2016 21:22:40 ******/
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
INSERT [dbo].[CustomerInfo] ([CustID], [Name], [OrganizationName], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (N'NandhiMill', N'NandhiMill', N'NamdhiMill', N'System', CAST(0x0000A61600B9F9C4 AS DateTime), N'N')
INSERT [dbo].[CustomerInfo] ([CustID], [Name], [OrganizationName], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (N'Om', N'Om', N'OM Rice Mills Assocaition of India', N'System', CAST(0x0000A616016696D4 AS DateTime), N'N')
INSERT [dbo].[CustomerInfo] ([CustID], [Name], [OrganizationName], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (N'Om1', N'Om1', N'OM Rice Mills Assocaition of India', N'System', CAST(0x0000A616016CC734 AS DateTime), N'N')
INSERT [dbo].[CustomerInfo] ([CustID], [Name], [OrganizationName], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (N'test1', N'test1', N'test1', N'System', CAST(0x0000A60A01844139 AS DateTime), N'N')
/****** Object:  Table [dbo].[MRoles]    Script Date: 06/17/2016 21:22:40 ******/
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
INSERT [dbo].[MRoles] ([RoleId], [RoleName], [Description], [ObsInd], [LastModifiedBy], [LastModifiedDate]) VALUES (N'RL2016053021455286103578028', N'Admin', N'Admin', N'N', N'System', CAST(0x0000A6160166AAC0 AS DateTime))
/****** Object:  Table [dbo].[MBrokenRiceType]    Script Date: 06/17/2016 21:22:40 ******/
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
INSERT [dbo].[MBrokenRiceType] ([BrokenRiceTypeID], [CustID], [BrokenRiceName], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (N'BR201606112341231', N'om', N'Half BR', N'om\test', CAST(0x0000A628010F5F18 AS DateTime), N'N')
/****** Object:  Table [dbo].[MBagType]    Script Date: 06/17/2016 21:22:40 ******/
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
INSERT [dbo].[MBagType] ([BagTypeID], [BagType], [LastModifiedBy], [LastModifiedDate], [ObsInd], [CustID]) VALUES (N'BT20160617172745c0a78f51477c45a38256b654c', N'Paddy', N'om\test', CAST(0x0000A628011FC5EC AS DateTime), N'N', N'om')
INSERT [dbo].[MBagType] ([BagTypeID], [BagType], [LastModifiedBy], [LastModifiedDate], [ObsInd], [CustID]) VALUES (N'BT201606171727560e83aef4411946e9819487ccb', N'Rice', N'om\test', CAST(0x0000A628011FD2D0 AS DateTime), N'N', N'om')
INSERT [dbo].[MBagType] ([BagTypeID], [BagType], [LastModifiedBy], [LastModifiedDate], [ObsInd], [CustID]) VALUES (N'BT201606171728309ac0d40814ce46dfbbee6ee2c', N'BrokenRice', N'om\test', CAST(0x0000A628011FFAA8 AS DateTime), N'N', N'om')
INSERT [dbo].[MBagType] ([BagTypeID], [BagType], [LastModifiedBy], [LastModifiedDate], [ObsInd], [CustID]) VALUES (N'BT20160617172901fe00d7cb9e3d480b8777fb70b', N'Dust', N'om\test', CAST(0x0000A62801201EFC AS DateTime), N'N', N'om')
/****** Object:  Table [dbo].[CustTrailUsage]    Script Date: 06/17/2016 21:22:40 ******/
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
/****** Object:  Table [dbo].[CustomerPayment]    Script Date: 06/17/2016 21:22:40 ******/
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
/****** Object:  Table [dbo].[CustomerPartPayDetails]    Script Date: 06/17/2016 21:22:40 ******/
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
/****** Object:  Table [dbo].[BuyerInfo]    Script Date: 06/17/2016 21:22:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[BuyerInfo](
	[BuyerID] [nvarchar](50) NOT NULL,
	[CustID] [nvarchar](50) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Street] [nvarchar](30) NULL,
	[Street1] [nvarchar](30) NULL,
	[Town] [nvarchar](50) NULL,
	[City] [nvarchar](50) NOT NULL,
	[District] [nvarchar](50) NOT NULL,
	[State] [nvarchar](50) NOT NULL,
	[PinCode] [varchar](6) NULL,
	[ContactNo] [nvarchar](14) NOT NULL,
	[MobileNo] [nvarchar](14) NULL,
	[PhoneNo] [nvarchar](14) NULL,
	[LastModifiedBy] [nvarchar](50) NOT NULL,
	[LastModifiedDate] [datetime] NOT NULL,
	[ObsInd] [char](1) NOT NULL,
 CONSTRAINT [PK_BuyerInfo] PRIMARY KEY CLUSTERED 
(
	[BuyerID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[BuyerInfo] ([BuyerID], [CustID], [Name], [Street], [Street1], [Town], [City], [District], [State], [PinCode], [ContactNo], [MobileNo], [PhoneNo], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (N'BI20160617324243', N'om', N'Shankarappa', N'a', N's3', NULL, N'bangalore', N'bangalore', N'karnataka', N'560034', N'9900990300', N'899', N'987', N'om\test', CAST(0x0000A628010E864C AS DateTime), N'N')
INSERT [dbo].[BuyerInfo] ([BuyerID], [CustID], [Name], [Street], [Street1], [Town], [City], [District], [State], [PinCode], [ContactNo], [MobileNo], [PhoneNo], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (N'BI20160617d7e3b73fe4c241', N'Om', N'Test', N't', N't', NULL, N't', N't', N't', N't', N't', N't', N't', N'Om\Test', CAST(0x0000A62801496CD0 AS DateTime), N'N')
/****** Object:  Table [dbo].[EmployeeDetails]    Script Date: 06/17/2016 21:22:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[EmployeeDetails](
	[EmployeeID] [nvarchar](50) NOT NULL,
	[CustID] [nvarchar](50) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Street] [nvarchar](50) NULL,
	[Street1] [nvarchar](30) NULL,
	[Town] [nvarchar](50) NULL,
	[City] [nvarchar](50) NOT NULL,
	[District] [nvarchar](50) NOT NULL,
	[State] [nvarchar](50) NOT NULL,
	[PinCode] [varchar](6) NULL,
	[ContactNo] [nvarchar](13) NOT NULL,
	[MobileNo] [nvarchar](13) NULL,
	[PhoneNo] [nvarchar](13) NULL,
	[LastModifiedBy] [nvarchar](50) NOT NULL,
	[LastModifiedDate] [datetime] NOT NULL,
	[ObsInd] [char](1) NOT NULL,
 CONSTRAINT [PK_EmployeeDetails] PRIMARY KEY CLUSTERED 
(
	[EmployeeID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MRiceProductionType]    Script Date: 06/17/2016 21:22:40 ******/
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
INSERT [dbo].[MRiceProductionType] ([MRiceProdTypeID], [CustID], [RiceType], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (N'BI201606111231', N'om', N'Sona', N'om\test', CAST(0x0000A628010EF21C AS DateTime), N'N')
/****** Object:  Table [dbo].[MRiceBrandDetails]    Script Date: 06/17/2016 21:22:40 ******/
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
INSERT [dbo].[MRiceBrandDetails] ([MRiceBrandID], [CustID], [Name], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (N'RB2016061718330036e47ef68793415dac1db6bce', N'om', N'Bullet', N'om\test', CAST(0x0000A6280131B1D0 AS DateTime), N'N')
INSERT [dbo].[MRiceBrandDetails] ([MRiceBrandID], [CustID], [Name], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (N'RB201606175cc1c8d2194ed1', N'Om', N'R-Bullet', N'Om\Test', CAST(0x0000A6280153B3AC AS DateTime), N'N')
INSERT [dbo].[MRiceBrandDetails] ([MRiceBrandID], [CustID], [Name], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (N'RB20160617df9705b6b6c4f0', N'Om', N'P-Bullet', N'Om\Test', CAST(0x0000A6280153BD0C AS DateTime), N'N')
/****** Object:  Table [dbo].[MPaddyType]    Script Date: 06/17/2016 21:22:40 ******/
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
INSERT [dbo].[MPaddyType] ([PaddyTypeID], [CustID], [Name], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (N'PT20160617172127ae250c256a7c439282ff1b301', N'om', N'Jaya', N'om\test', CAST(0x0000A628011E0AF4 AS DateTime), N'N')
/****** Object:  Table [dbo].[CustomerAddressInfo]    Script Date: 06/17/2016 21:22:40 ******/
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
/****** Object:  Table [dbo].[CustomerActivation]    Script Date: 06/17/2016 21:22:40 ******/
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
/****** Object:  Table [dbo].[MWeightDetails]    Script Date: 06/17/2016 21:22:40 ******/
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
/****** Object:  Table [dbo].[MUnitsType]    Script Date: 06/17/2016 21:22:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MUnitsType](
	[UnitsTypeID] [nvarchar](50) NOT NULL,
	[CustID] [nvarchar](50) NOT NULL,
	[LastModifiedBy] [nvarchar](50) NOT NULL,
	[LastModifiedDate] [datetime] NOT NULL,
	[ObsInd] [char](1) NOT NULL,
	[UnitsType] [nvarchar](10) NOT NULL,
 CONSTRAINT [PK_MUnitsType] PRIMARY KEY CLUSTERED 
(
	[UnitsTypeID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[MUnitsType] ([UnitsTypeID], [CustID], [LastModifiedBy], [LastModifiedDate], [ObsInd], [UnitsType]) VALUES (N'UT201606112341111', N'om', N'om\test', CAST(0x0000A62801105DC3 AS DateTime), N'N', N'25')
INSERT [dbo].[MUnitsType] ([UnitsTypeID], [CustID], [LastModifiedBy], [LastModifiedDate], [ObsInd], [UnitsType]) VALUES (N'UT201606112341121', N'om', N'om\test', CAST(0x0000A62801105DC4 AS DateTime), N'N', N'50')
INSERT [dbo].[MUnitsType] ([UnitsTypeID], [CustID], [LastModifiedBy], [LastModifiedDate], [ObsInd], [UnitsType]) VALUES (N'UT201606112341123', N'om', N'om\test', CAST(0x0000A62801105DC4 AS DateTime), N'N', N'75')
INSERT [dbo].[MUnitsType] ([UnitsTypeID], [CustID], [LastModifiedBy], [LastModifiedDate], [ObsInd], [UnitsType]) VALUES (N'UT201606222341124', N'om', N'om\test', CAST(0x0000A62801110512 AS DateTime), N'N', N'100')
/****** Object:  Table [dbo].[MSalaryType]    Script Date: 06/17/2016 21:22:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MSalaryType](
	[MSalaryTypeID] [nvarchar](50) NOT NULL,
	[CustID] [nvarchar](50) NOT NULL,
	[Salarytype] [nvarchar](20) NOT NULL,
	[LastModifiedBy] [nvarchar](50) NOT NULL,
	[LastModifiedDate] [datetime] NOT NULL,
	[ObsInd] [char](1) NOT NULL,
 CONSTRAINT [PK_MSalaryType] PRIMARY KEY CLUSTERED 
(
	[MSalaryTypeID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MGodownDetails]    Script Date: 06/17/2016 21:22:40 ******/
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
INSERT [dbo].[MGodownDetails] ([MGodownID], [CustID], [Place], [LastModifiedBy], [LastModifiedDate], [ObsInd], [Name]) VALUES (N'GD2016061717a1868ac76f4c', N'Om', NULL, N'Om\Test', CAST(0x0000A628014818F8 AS DateTime), N'N', N'Godown3')
INSERT [dbo].[MGodownDetails] ([MGodownID], [CustID], [Place], [LastModifiedBy], [LastModifiedDate], [ObsInd], [Name]) VALUES (N'GD20160617572108d4a68ff2', N'Om', NULL, N'Om\Test', CAST(0x0000A628014869D4 AS DateTime), N'N', N'Godown5')
INSERT [dbo].[MGodownDetails] ([MGodownID], [CustID], [Place], [LastModifiedBy], [LastModifiedDate], [ObsInd], [Name]) VALUES (N'GD20160617828b565d1e6e4c', N'Om', NULL, N'Om\Test', CAST(0x0000A62801486650 AS DateTime), N'Y', N'Godown5')
INSERT [dbo].[MGodownDetails] ([MGodownID], [CustID], [Place], [LastModifiedBy], [LastModifiedDate], [ObsInd], [Name]) VALUES (N'GD201606178cd168798d8f47', N'Om', NULL, N'Om\Test', CAST(0x0000A62801484904 AS DateTime), N'N', N'Godown4')
INSERT [dbo].[MGodownDetails] ([MGodownID], [CustID], [Place], [LastModifiedBy], [LastModifiedDate], [ObsInd], [Name]) VALUES (N'GD2016150623423', N'om', NULL, N'om\test', CAST(0x0000A62701656AE4 AS DateTime), N'N', N'Godown1')
INSERT [dbo].[MGodownDetails] ([MGodownID], [CustID], [Place], [LastModifiedBy], [LastModifiedDate], [ObsInd], [Name]) VALUES (N'GD2016150623424', N'om', NULL, N'om\test', CAST(0x0000A62701656AF5 AS DateTime), N'N', N'Godown2')
/****** Object:  Table [dbo].[MessageInfo]    Script Date: 06/17/2016 21:22:40 ******/
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
/****** Object:  Table [dbo].[MEmployeeDesignation]    Script Date: 06/17/2016 21:22:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MEmployeeDesignation](
	[MEmpDsgID] [nvarchar](50) NOT NULL,
	[CustID] [nvarchar](50) NOT NULL,
	[DesignationType] [nvarchar](100) NOT NULL,
	[LastModifiedBy] [nvarchar](50) NOT NULL,
	[LastModifiedDate] [datetime] NOT NULL,
	[ObsInd] [char](1) NOT NULL,
 CONSTRAINT [PK_MEmployeeDesignation] PRIMARY KEY CLUSTERED 
(
	[MEmpDsgID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MDrierTypeDetails]    Script Date: 06/17/2016 21:22:40 ******/
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
/****** Object:  Table [dbo].[ProductPaymentInfo]    Script Date: 06/17/2016 21:22:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ProductPaymentInfo](
	[ProductPaymentID] [nvarchar](50) NOT NULL,
	[CustID] [nvarchar](50) NOT NULL,
	[TotalAmount] [money] NOT NULL,
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
INSERT [dbo].[ProductPaymentInfo] ([ProductPaymentID], [CustID], [TotalAmount], [Status], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (N'PP7bnKHpykgU6q+ftHW4AIiQ==', N'om', 73926.0000, N'P', N'om\test', CAST(0x0000A6280114B1FC AS DateTime), N'N')
/****** Object:  Table [dbo].[Users]    Script Date: 06/17/2016 21:22:40 ******/
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
INSERT [dbo].[Users] ([UserID], [CustID], [Name], [PassWord], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (N'UI2016053011173519844255929', N'NandhiMill', N'nagu', N'A47WV84jYe+SASsqD8pMIA==', N'System', CAST(0x0000A61600BA1A94 AS DateTime), N'N')
INSERT [dbo].[Users] ([UserID], [CustID], [Name], [PassWord], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (N'UI2016053021461063450110035', N'Om', N'Test', N'/aM5nPzVFy58l+2LTaX7jA==', N'System', CAST(0x0000A6160166BFD8 AS DateTime), N'N')
INSERT [dbo].[Users] ([UserID], [CustID], [Name], [PassWord], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (N'UI2016053022083887472961429', N'Om1', N'Test', N'/aM5nPzVFy58l+2LTaX7jA==', N'System', CAST(0x0000A616016CEB88 AS DateTime), N'N')
INSERT [dbo].[Users] ([UserID], [CustID], [Name], [PassWord], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (N'UI2016060816482920430349260', N'Om1', N'test1', N'/aM5nPzVFy58l+2LTaX7jA==', N'Om\test', CAST(0x0000A61F0114FCFC AS DateTime), N'N')
/****** Object:  Table [dbo].[SellerInfo]    Script Date: 06/17/2016 21:22:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SellerInfo](
	[SellerID] [nvarchar](50) NOT NULL,
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
INSERT [dbo].[SellerInfo] ([SellerID], [CustID], [Name], [Street], [Street1], [Town], [City], [District], [State], [PinCode], [ContactNo], [MobileNo], [PhoneNo], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (N'SE20160617018850ed68b20f', N'Om', N'Kiran', N'Ki', N'k', NULL, N'k', N'kk', N'io', N'kjhj', N'1989128', N'8913891', N'819281', N'Om\Test', CAST(0x0000A6280148965C AS DateTime), N'N')
INSERT [dbo].[SellerInfo] ([SellerID], [CustID], [Name], [Street], [Street1], [Town], [City], [District], [State], [PinCode], [ContactNo], [MobileNo], [PhoneNo], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (N'SE2016061717334910dd33a2b887423bb2b393393', N'om', N'Nagavardhan KJ', N'a', N's3', NULL, N'bangalore', N'bangalore', N'karnataka', N'560034', N'9900990300', N'899', N'987', N'om\test', CAST(0x0000A6280121707C AS DateTime), N'N')
/****** Object:  Table [dbo].[EmployeeSalary]    Script Date: 06/17/2016 21:22:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[EmployeeSalary](
	[EmpSalaryID] [nvarchar](50) NOT NULL,
	[CustID] [nvarchar](50) NOT NULL,
	[EmployeeID] [nvarchar](50) NOT NULL,
	[MSalaryTypeID] [nvarchar](50) NOT NULL,
	[MEmpDsgID] [nvarchar](50) NOT NULL,
	[Salary] [money] NOT NULL,
	[LastModifiedBy] [nvarchar](50) NOT NULL,
	[LastModifiedDate] [datetime] NOT NULL,
	[ObsInd] [char](1) NOT NULL,
 CONSTRAINT [PK_EmployeeSalary] PRIMARY KEY CLUSTERED 
(
	[EmpSalaryID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[RiceStockInfo]    Script Date: 06/17/2016 21:22:40 ******/
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
	[TotalBags] [int] NOT NULL,
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
INSERT [dbo].[RiceStockInfo] ([RiceStockID], [MRiceProdTypeID], [MRiceBrandID], [CustID], [UnitsTypeID], [TotalBags], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (N'HT20160617323a647fec57af', N'BI201606111231', N'RB2016061718330036e47ef68793415dac1db6bce', N'Om', N'UT201606112341121', 9000, N'Om\Test', CAST(0x0000A62801490934 AS DateTime), N'N')
/****** Object:  Table [dbo].[ProductSellingInfo]    Script Date: 06/17/2016 21:22:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ProductSellingInfo](
	[ProductID] [nvarchar](50) NOT NULL,
	[BuyerID] [nvarchar](50) NOT NULL,
	[MRiceProdTypeID] [nvarchar](50) NULL,
	[MRiceBrandID] [nvarchar](50) NULL,
	[BrokenRiceTypeID] [nvarchar](50) NULL,
	[CustID] [nvarchar](50) NOT NULL,
	[UnitsTypeID] [nvarchar](50) NOT NULL,
	[ProductPaymentID] [nvarchar](50) NOT NULL,
	[SellingDate] [datetime] NOT NULL,
	[Price] [money] NOT NULL,
	[SellingProductType] [nvarchar](30) NULL,
	[LastModifiedBy] [nvarchar](50) NOT NULL,
	[LastModifiedDate] [datetime] NOT NULL,
	[ObsInd] [char](1) NOT NULL,
	[TotalBags] [int] NOT NULL,
 CONSTRAINT [PK_ProductSellingInfo] PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ProductPaymentTransaction]    Script Date: 06/17/2016 21:22:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ProductPaymentTransaction](
	[ProductPaymentTranID] [nvarchar](50) NOT NULL,
	[ProductPaymentID] [nvarchar](50) NOT NULL,
	[CustID] [nvarchar](50) NOT NULL,
	[Paymentmode] [nvarchar](20) NOT NULL,
	[ChequeNo] [nvarchar](20) NULL,
	[DDNo] [nvarchar](20) NULL,
	[BankName] [nvarchar](40) NULL,
	[ReceivedAmount] [money] NULL,
	[PaymentDueDate] [datetime] NOT NULL,
	[LastModifiedBy] [nvarchar](50) NOT NULL,
	[LastModifiedDate] [datetime] NOT NULL,
	[ObsInd] [char](1) NOT NULL,
	[BuyerID] [nvarchar](50) NULL,
 CONSTRAINT [PK_ProductPaymentTransaction] PRIMARY KEY CLUSTERED 
(
	[ProductPaymentTranID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[BuyerSellerRating]    Script Date: 06/17/2016 21:22:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[BuyerSellerRating](
	[BRMSID] [nvarchar](50) NOT NULL,
	[SellerID] [nvarchar](50) NOT NULL,
	[CustID] [nvarchar](50) NOT NULL,
	[Rating] [smallint] NOT NULL,
	[Remarks] [nvarchar](200) NULL,
	[LastModifiedBy] [nvarchar](50) NOT NULL,
	[LastModifiedDate] [datetime] NOT NULL,
	[ObsInd] [char](1) NOT NULL,
 CONSTRAINT [PK_ByuerSellerRating] PRIMARY KEY CLUSTERED 
(
	[BRMSID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MoneyTransaction]    Script Date: 06/17/2016 21:22:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MoneyTransaction](
	[ExpTranID] [nvarchar](50) NOT NULL,
	[CustID] [nvarchar](50) NOT NULL,
	[EmployeeID] [nvarchar](50) NULL,
	[GivenTo] [nvarchar](50) NULL,
	[Description] [nvarchar](200) NULL,
	[AmountSpent] [money] NOT NULL,
	[ExtraCharges] [money] NULL,
	[PaymentDate] [datetime] NOT NULL,
	[LastModifiedBy] [nvarchar](50) NOT NULL,
	[LastModifiedDate] [datetime] NOT NULL,
	[ObsInd] [char](1) NOT NULL,
	[MSalaryTypeID] [nvarchar](50) NULL,
	[Salary] [money] NULL,
	[MEmpDsgID] [nvarchar](50) NULL,
 CONSTRAINT [PK_MoneyTransaction] PRIMARY KEY CLUSTERED 
(
	[ExpTranID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MLotDetails]    Script Date: 06/17/2016 21:22:40 ******/
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
INSERT [dbo].[MLotDetails] ([MLotID], [CustID], [LotName], [LastModifiedBy], [LastModifiedDate], [ObsInd], [MGodownID]) VALUES (N'LTEdNAmd06cEWye0ZKuVC3TQ==', N'om', N'L1', N'om\test', CAST(0x0000A62800B195B8 AS DateTime), N'N', N'GD2016150623423')
/****** Object:  Table [dbo].[DustStockInfo]    Script Date: 06/17/2016 21:22:40 ******/
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
	[TotalBags] [int] NOT NULL,
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
INSERT [dbo].[DustStockInfo] ([DustStockID], [CustID], [UnitsTypeID], [TotalBags], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (N'HT20160617d5666a154e7221', N'Om', N'UT201606112341111', 129, N'Om\Test', CAST(0x0000A62801490934 AS DateTime), N'N')
/****** Object:  Table [dbo].[BrokenRiceStockInfo]    Script Date: 06/17/2016 21:22:40 ******/
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
	[TotalBags] [int] NOT NULL,
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
INSERT [dbo].[BrokenRiceStockInfo] ([BrokenRiceStockID], [BrokenRiceTypeID], [CustID], [UnitsTypeID], [TotalBags], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (N'HT20160617471a2cf171b0a7', N'BR201606112341231', N'Om', N'UT201606112341111', 30, N'Om\Test', CAST(0x0000A62801490934 AS DateTime), N'N')
INSERT [dbo].[BrokenRiceStockInfo] ([BrokenRiceStockID], [BrokenRiceTypeID], [CustID], [UnitsTypeID], [TotalBags], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (N'HT201606179f483ea50bd858', N'BR201606112341231', N'Om', N'UT201606112341111', 30, N'Om\Test', CAST(0x0000A62801490934 AS DateTime), N'N')
/****** Object:  Table [dbo].[BagStockInfo]    Script Date: 06/17/2016 21:22:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[BagStockInfo](
	[BagStockID] [nvarchar](50) NOT NULL,
	[SellerID] [nvarchar](50) NOT NULL,
	[CustID] [nvarchar](50) NOT NULL,
	[VehicalNo] [nvarchar](20) NOT NULL,
	[PurchaseDate] [datetime] NOT NULL,
	[LastModifiedBy] [nvarchar](50) NOT NULL,
	[LastModifiedDate] [datetime] NOT NULL,
	[ObsInd] [char](1) NOT NULL,
	[DriverName] [nvarchar](50) NULL,
	[Price] [money] NOT NULL,
	[UnitsTypeID] [nvarchar](50) NOT NULL,
	[MRiceBrandID] [nvarchar](50) NULL,
	[TotalBags] [int] NOT NULL,
 CONSTRAINT [PK_BagStockInfo] PRIMARY KEY CLUSTERED 
(
	[BagStockID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[BagStockInfo] ([BagStockID], [SellerID], [CustID], [VehicalNo], [PurchaseDate], [LastModifiedBy], [LastModifiedDate], [ObsInd], [DriverName], [Price], [UnitsTypeID], [MRiceBrandID], [TotalBags]) VALUES (N'BS20160617183434ef40fff1a41b4aca8d897cee8', N'SE2016061717334910dd33a2b887423bb2b393393', N'om', N'sdsdfsf', CAST(0x0000A62200000000 AS DateTime), N'om\test', CAST(0x0000A62801321FF8 AS DateTime), N'N', N'ganga', 10.0000, N'UT201606112341111', N'RB2016061718330036e47ef68793415dac1db6bce', 1000)
INSERT [dbo].[BagStockInfo] ([BagStockID], [SellerID], [CustID], [VehicalNo], [PurchaseDate], [LastModifiedBy], [LastModifiedDate], [ObsInd], [DriverName], [Price], [UnitsTypeID], [MRiceBrandID], [TotalBags]) VALUES (N'BS201606171846047bced75275ac49d5962d4f0af', N'SE2016061717334910dd33a2b887423bb2b393393', N'om', N'KA 41 E1720', CAST(0x0000A62200000000 AS DateTime), N'om\test', CAST(0x0000A62801354890 AS DateTime), N'N', N'MAHESH', 8.0000, N'UT201606112341123', N'RB2016061718330036e47ef68793415dac1db6bce', 10000)
INSERT [dbo].[BagStockInfo] ([BagStockID], [SellerID], [CustID], [VehicalNo], [PurchaseDate], [LastModifiedBy], [LastModifiedDate], [ObsInd], [DriverName], [Price], [UnitsTypeID], [MRiceBrandID], [TotalBags]) VALUES (N'BS201606178adc19107a0819', N'SE2016061717334910dd33a2b887423bb2b393393', N'Om', N'wqioew', CAST(0x0000A3E000000000 AS DateTime), N'Om\Test', CAST(0x0000A62801537C98 AS DateTime), N'N', N'kir', 10.0000, N'UT201606222341124', N'RB2016061718330036e47ef68793415dac1db6bce', 10000)
/****** Object:  Table [dbo].[HullingProcess]    Script Date: 06/17/2016 21:22:40 ******/
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
	[TotalBags] [int] NOT NULL,
	[ProcessDate] [datetime] NOT NULL,
	[ProcessedBy] [nvarchar](30) NULL,
	[LastModifiedBy] [nvarchar](50) NOT NULL,
	[LastModifiedDate] [datetime] NOT NULL,
	[ObsInd] [char](1) NOT NULL,
	[Status] [char](1) NULL,
	[MGodownID] [nvarchar](50) NULL,
	[MLotID] [nvarchar](50) NULL,
	[Price] [money] NOT NULL,
 CONSTRAINT [PK_HullingProcess] PRIMARY KEY CLUSTERED 
(
	[HullingProcessID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[HullingProcess] ([HullingProcessID], [PaddyTypeID], [CustID], [UnitsTypeID], [TotalBags], [ProcessDate], [ProcessedBy], [LastModifiedBy], [LastModifiedDate], [ObsInd], [Status], [MGodownID], [MLotID], [Price]) VALUES (N'HP201606178a4366e85b520c', N'PT20160617172127ae250c256a7c439282ff1b301', N'Om', N'UT201606112341123', 129, CAST(0x0000A3E000000000 AS DateTime), N'Kiran', N'Om\Test', CAST(0x0000A62801490934 AS DateTime), N'N', N'A', N'GD2016150623423', N'LTEdNAmd06cEWye0ZKuVC3TQ==', 8977.0000)
/****** Object:  Table [dbo].[PaddyStockInfo]    Script Date: 06/17/2016 21:22:40 ******/
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
	[Price] [money] NOT NULL,
	[UnitsTypeID] [nvarchar](50) NOT NULL,
	[TotalBags] [int] NOT NULL,
 CONSTRAINT [PK_PaddyStockInfo] PRIMARY KEY CLUSTERED 
(
	[PaddyStockID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[PaddyStockInfo] ([PaddyStockID], [SellerID], [PaddyTypeID], [CustID], [MGodownID], [MLotID], [VehicalNo], [PurchaseDate], [LastModifiedBy], [LastModifiedDate], [ObsInd], [DriverName], [Price], [UnitsTypeID], [TotalBags]) VALUES (N'PS20160617174626d9086e86b1d9430fba97f9a38', N'SE2016061717334910dd33a2b887423bb2b393393', N'PT20160617172127ae250c256a7c439282ff1b301', N'om', N'GD2016150623423', N'LTEdNAmd06cEWye0ZKuVC3TQ==', N'slkfjl', CAST(0x0000A3E000000000 AS DateTime), N'om\test', CAST(0x0000A6280124E798 AS DateTime), N'N', N'sldkfjl', 1000.0000, N'UT201606112341123', 500)
/****** Object:  Table [dbo].[PaddyPaymentDetails]    Script Date: 06/17/2016 21:22:40 ******/
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
	[PaddyStockID] [nvarchar](50) NULL,
	[PaymentMode] [nvarchar](20) NULL,
	[ChequeNo] [nvarchar](50) NULL,
	[BankName] [nvarchar](50) NULL,
 CONSTRAINT [PK_PaddyPaymentDetails] PRIMARY KEY CLUSTERED 
(
	[PaddyPaymentID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HullingTransaction]    Script Date: 06/17/2016 21:22:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HullingTransaction](
	[HullingTransID] [nvarchar](50) NOT NULL,
	[HullingProcessID] [nvarchar](50) NOT NULL,
	[MRiceProdTypeID] [nvarchar](50) NULL,
	[BrokenRiceTypeID] [nvarchar](50) NULL,
	[CustID] [nvarchar](50) NOT NULL,
	[UnitsTypeID] [nvarchar](50) NOT NULL,
	[TotalBags] [int] NOT NULL,
	[Price] [money] NOT NULL,
	[LastModifiedBy] [nvarchar](50) NOT NULL,
	[LastModifiedDate] [datetime] NOT NULL,
	[ObsInd] [char](1) NOT NULL,
	[MRiceBrandID] [nvarchar](50) NULL,
 CONSTRAINT [PK_HullingTransaction] PRIMARY KEY CLUSTERED 
(
	[HullingTransID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[HullingTransaction] ([HullingTransID], [HullingProcessID], [MRiceProdTypeID], [BrokenRiceTypeID], [CustID], [UnitsTypeID], [TotalBags], [Price], [LastModifiedBy], [LastModifiedDate], [ObsInd], [MRiceBrandID]) VALUES (N'HT20160617323a647fec57af', N'HP201606178a4366e85b520c', N'BI201606111231', NULL, N'Om', N'UT201606112341121', 9000, 0.0000, N'Om\Test', CAST(0x0000A62801490934 AS DateTime), N'N', N'RB2016061718330036e47ef68793415dac1db6bce')
INSERT [dbo].[HullingTransaction] ([HullingTransID], [HullingProcessID], [MRiceProdTypeID], [BrokenRiceTypeID], [CustID], [UnitsTypeID], [TotalBags], [Price], [LastModifiedBy], [LastModifiedDate], [ObsInd], [MRiceBrandID]) VALUES (N'HT20160617471a2cf171b0a7', N'HP201606178a4366e85b520c', NULL, N'BR201606112341231', N'Om', N'UT201606112341111', 30, 943.0000, N'Om\Test', CAST(0x0000A62801490934 AS DateTime), N'N', NULL)
INSERT [dbo].[HullingTransaction] ([HullingTransID], [HullingProcessID], [MRiceProdTypeID], [BrokenRiceTypeID], [CustID], [UnitsTypeID], [TotalBags], [Price], [LastModifiedBy], [LastModifiedDate], [ObsInd], [MRiceBrandID]) VALUES (N'HT201606179f483ea50bd858', N'HP201606178a4366e85b520c', NULL, N'BR201606112341231', N'Om', N'UT201606112341111', 30, 943.0000, N'Om\Test', CAST(0x0000A62801490934 AS DateTime), N'N', NULL)
INSERT [dbo].[HullingTransaction] ([HullingTransID], [HullingProcessID], [MRiceProdTypeID], [BrokenRiceTypeID], [CustID], [UnitsTypeID], [TotalBags], [Price], [LastModifiedBy], [LastModifiedDate], [ObsInd], [MRiceBrandID]) VALUES (N'HT20160617d5666a154e7221', N'HP201606178a4366e85b520c', NULL, NULL, N'Om', N'UT201606112341111', 129, 2.0000, N'Om\Test', CAST(0x0000A62801490934 AS DateTime), N'N', NULL)
/****** Object:  Table [dbo].[HullingProcessExpenses]    Script Date: 06/17/2016 21:22:40 ******/
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
	[CustID] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_HullingProcessExpenses] PRIMARY KEY CLUSTERED 
(
	[HullingProcessExpenID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[HullingProcessExpenses] ([HullingProcessExpenID], [HullingProcessID], [PowerExpenses], [LabourExpenses], [OtherExpenses], [LastModifiedBy], [LastModifiedDate], [ObsInd], [CustID]) VALUES (N'HPE2016061722dc3d044a7bfa', N'HP201606178a4366e85b520c', 10.0000, 10.0000, 10.0000, N'Om\Test', CAST(0x0000A62801490934 AS DateTime), N'N', N'Om')
/****** Object:  ForeignKey [FK_MenuInfo_MenuInfo1]    Script Date: 06/17/2016 21:22:40 ******/
ALTER TABLE [dbo].[MenuInfo]  WITH CHECK ADD  CONSTRAINT [FK_MenuInfo_MenuInfo1] FOREIGN KEY([ParentMenuID])
REFERENCES [dbo].[MenuInfo] ([MenuID])
GO
ALTER TABLE [dbo].[MenuInfo] CHECK CONSTRAINT [FK_MenuInfo_MenuInfo1]
GO
/****** Object:  ForeignKey [FK_MBagType_CustomerInfo]    Script Date: 06/17/2016 21:22:40 ******/
ALTER TABLE [dbo].[MBagType]  WITH CHECK ADD  CONSTRAINT [FK_MBagType_CustomerInfo] FOREIGN KEY([CustID])
REFERENCES [dbo].[CustomerInfo] ([CustID])
GO
ALTER TABLE [dbo].[MBagType] CHECK CONSTRAINT [FK_MBagType_CustomerInfo]
GO
/****** Object:  ForeignKey [FK_CustTrailUsage_CustomerInfo]    Script Date: 06/17/2016 21:22:40 ******/
ALTER TABLE [dbo].[CustTrailUsage]  WITH CHECK ADD  CONSTRAINT [FK_CustTrailUsage_CustomerInfo] FOREIGN KEY([CustID])
REFERENCES [dbo].[CustomerInfo] ([CustID])
GO
ALTER TABLE [dbo].[CustTrailUsage] CHECK CONSTRAINT [FK_CustTrailUsage_CustomerInfo]
GO
/****** Object:  ForeignKey [FK_CustomerPayment_CustomerInfo]    Script Date: 06/17/2016 21:22:40 ******/
ALTER TABLE [dbo].[CustomerPayment]  WITH CHECK ADD  CONSTRAINT [FK_CustomerPayment_CustomerInfo] FOREIGN KEY([CustID])
REFERENCES [dbo].[CustomerInfo] ([CustID])
GO
ALTER TABLE [dbo].[CustomerPayment] CHECK CONSTRAINT [FK_CustomerPayment_CustomerInfo]
GO
/****** Object:  ForeignKey [FK_CustomerPartPayDetails_CustomerInfo]    Script Date: 06/17/2016 21:22:40 ******/
ALTER TABLE [dbo].[CustomerPartPayDetails]  WITH CHECK ADD  CONSTRAINT [FK_CustomerPartPayDetails_CustomerInfo] FOREIGN KEY([CustID])
REFERENCES [dbo].[CustomerInfo] ([CustID])
GO
ALTER TABLE [dbo].[CustomerPartPayDetails] CHECK CONSTRAINT [FK_CustomerPartPayDetails_CustomerInfo]
GO
/****** Object:  ForeignKey [FK_BuyerInfo_CustomerInfo]    Script Date: 06/17/2016 21:22:40 ******/
ALTER TABLE [dbo].[BuyerInfo]  WITH CHECK ADD  CONSTRAINT [FK_BuyerInfo_CustomerInfo] FOREIGN KEY([CustID])
REFERENCES [dbo].[CustomerInfo] ([CustID])
GO
ALTER TABLE [dbo].[BuyerInfo] CHECK CONSTRAINT [FK_BuyerInfo_CustomerInfo]
GO
/****** Object:  ForeignKey [FK_EmployeeDetails_CustomerInfo]    Script Date: 06/17/2016 21:22:40 ******/
ALTER TABLE [dbo].[EmployeeDetails]  WITH CHECK ADD  CONSTRAINT [FK_EmployeeDetails_CustomerInfo] FOREIGN KEY([CustID])
REFERENCES [dbo].[CustomerInfo] ([CustID])
GO
ALTER TABLE [dbo].[EmployeeDetails] CHECK CONSTRAINT [FK_EmployeeDetails_CustomerInfo]
GO
/****** Object:  ForeignKey [FK_MRiceProductionType_CustomerInfo]    Script Date: 06/17/2016 21:22:40 ******/
ALTER TABLE [dbo].[MRiceProductionType]  WITH CHECK ADD  CONSTRAINT [FK_MRiceProductionType_CustomerInfo] FOREIGN KEY([CustID])
REFERENCES [dbo].[CustomerInfo] ([CustID])
GO
ALTER TABLE [dbo].[MRiceProductionType] CHECK CONSTRAINT [FK_MRiceProductionType_CustomerInfo]
GO
/****** Object:  ForeignKey [FK_MRiceBrandDetails_CustomerInfo]    Script Date: 06/17/2016 21:22:40 ******/
ALTER TABLE [dbo].[MRiceBrandDetails]  WITH CHECK ADD  CONSTRAINT [FK_MRiceBrandDetails_CustomerInfo] FOREIGN KEY([CustID])
REFERENCES [dbo].[CustomerInfo] ([CustID])
GO
ALTER TABLE [dbo].[MRiceBrandDetails] CHECK CONSTRAINT [FK_MRiceBrandDetails_CustomerInfo]
GO
/****** Object:  ForeignKey [FK_MPaddyType_CustomerInfo]    Script Date: 06/17/2016 21:22:40 ******/
ALTER TABLE [dbo].[MPaddyType]  WITH CHECK ADD  CONSTRAINT [FK_MPaddyType_CustomerInfo] FOREIGN KEY([CustID])
REFERENCES [dbo].[CustomerInfo] ([CustID])
GO
ALTER TABLE [dbo].[MPaddyType] CHECK CONSTRAINT [FK_MPaddyType_CustomerInfo]
GO
/****** Object:  ForeignKey [FK_CustomerAddressInfo_CustomerAddressInfo]    Script Date: 06/17/2016 21:22:40 ******/
ALTER TABLE [dbo].[CustomerAddressInfo]  WITH NOCHECK ADD  CONSTRAINT [FK_CustomerAddressInfo_CustomerAddressInfo] FOREIGN KEY([CustID])
REFERENCES [dbo].[CustomerInfo] ([CustID])
NOT FOR REPLICATION
GO
ALTER TABLE [dbo].[CustomerAddressInfo] NOCHECK CONSTRAINT [FK_CustomerAddressInfo_CustomerAddressInfo]
GO
/****** Object:  ForeignKey [FK_CustomerActivation_CustomerInfo]    Script Date: 06/17/2016 21:22:40 ******/
ALTER TABLE [dbo].[CustomerActivation]  WITH CHECK ADD  CONSTRAINT [FK_CustomerActivation_CustomerInfo] FOREIGN KEY([CustID])
REFERENCES [dbo].[CustomerInfo] ([CustID])
GO
ALTER TABLE [dbo].[CustomerActivation] CHECK CONSTRAINT [FK_CustomerActivation_CustomerInfo]
GO
/****** Object:  ForeignKey [FK_MWeightDetails_CustomerInfo]    Script Date: 06/17/2016 21:22:40 ******/
ALTER TABLE [dbo].[MWeightDetails]  WITH CHECK ADD  CONSTRAINT [FK_MWeightDetails_CustomerInfo] FOREIGN KEY([CustID])
REFERENCES [dbo].[CustomerInfo] ([CustID])
GO
ALTER TABLE [dbo].[MWeightDetails] CHECK CONSTRAINT [FK_MWeightDetails_CustomerInfo]
GO
/****** Object:  ForeignKey [FK_MUnitsType_CustomerInfo]    Script Date: 06/17/2016 21:22:40 ******/
ALTER TABLE [dbo].[MUnitsType]  WITH CHECK ADD  CONSTRAINT [FK_MUnitsType_CustomerInfo] FOREIGN KEY([CustID])
REFERENCES [dbo].[CustomerInfo] ([CustID])
GO
ALTER TABLE [dbo].[MUnitsType] CHECK CONSTRAINT [FK_MUnitsType_CustomerInfo]
GO
/****** Object:  ForeignKey [FK_MSalaryType_CustomerInfo]    Script Date: 06/17/2016 21:22:40 ******/
ALTER TABLE [dbo].[MSalaryType]  WITH CHECK ADD  CONSTRAINT [FK_MSalaryType_CustomerInfo] FOREIGN KEY([CustID])
REFERENCES [dbo].[CustomerInfo] ([CustID])
GO
ALTER TABLE [dbo].[MSalaryType] CHECK CONSTRAINT [FK_MSalaryType_CustomerInfo]
GO
/****** Object:  ForeignKey [FK_MGodownDetails_CustomerInfo]    Script Date: 06/17/2016 21:22:40 ******/
ALTER TABLE [dbo].[MGodownDetails]  WITH CHECK ADD  CONSTRAINT [FK_MGodownDetails_CustomerInfo] FOREIGN KEY([CustID])
REFERENCES [dbo].[CustomerInfo] ([CustID])
GO
ALTER TABLE [dbo].[MGodownDetails] CHECK CONSTRAINT [FK_MGodownDetails_CustomerInfo]
GO
/****** Object:  ForeignKey [FK_MessageInfo_CustomerInfo1]    Script Date: 06/17/2016 21:22:40 ******/
ALTER TABLE [dbo].[MessageInfo]  WITH CHECK ADD  CONSTRAINT [FK_MessageInfo_CustomerInfo1] FOREIGN KEY([CustID])
REFERENCES [dbo].[CustomerInfo] ([CustID])
GO
ALTER TABLE [dbo].[MessageInfo] CHECK CONSTRAINT [FK_MessageInfo_CustomerInfo1]
GO
/****** Object:  ForeignKey [FK_MEmployeeDesignation_CustomerInfo]    Script Date: 06/17/2016 21:22:40 ******/
ALTER TABLE [dbo].[MEmployeeDesignation]  WITH CHECK ADD  CONSTRAINT [FK_MEmployeeDesignation_CustomerInfo] FOREIGN KEY([CustID])
REFERENCES [dbo].[CustomerInfo] ([CustID])
GO
ALTER TABLE [dbo].[MEmployeeDesignation] CHECK CONSTRAINT [FK_MEmployeeDesignation_CustomerInfo]
GO
/****** Object:  ForeignKey [FK_MDrierTypeDetails_CustomerInfo]    Script Date: 06/17/2016 21:22:40 ******/
ALTER TABLE [dbo].[MDrierTypeDetails]  WITH CHECK ADD  CONSTRAINT [FK_MDrierTypeDetails_CustomerInfo] FOREIGN KEY([CustID])
REFERENCES [dbo].[CustomerInfo] ([CustID])
GO
ALTER TABLE [dbo].[MDrierTypeDetails] CHECK CONSTRAINT [FK_MDrierTypeDetails_CustomerInfo]
GO
/****** Object:  ForeignKey [FK_ProductPaymentInfo_CustomerInfo]    Script Date: 06/17/2016 21:22:40 ******/
ALTER TABLE [dbo].[ProductPaymentInfo]  WITH CHECK ADD  CONSTRAINT [FK_ProductPaymentInfo_CustomerInfo] FOREIGN KEY([CustID])
REFERENCES [dbo].[CustomerInfo] ([CustID])
GO
ALTER TABLE [dbo].[ProductPaymentInfo] CHECK CONSTRAINT [FK_ProductPaymentInfo_CustomerInfo]
GO
/****** Object:  ForeignKey [FK_Users_CustomerInfo]    Script Date: 06/17/2016 21:22:40 ******/
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_CustomerInfo] FOREIGN KEY([CustID])
REFERENCES [dbo].[CustomerInfo] ([CustID])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_CustomerInfo]
GO
/****** Object:  ForeignKey [FK_SellerInfo_CustomerInfo]    Script Date: 06/17/2016 21:22:40 ******/
ALTER TABLE [dbo].[SellerInfo]  WITH CHECK ADD  CONSTRAINT [FK_SellerInfo_CustomerInfo] FOREIGN KEY([CustID])
REFERENCES [dbo].[CustomerInfo] ([CustID])
GO
ALTER TABLE [dbo].[SellerInfo] CHECK CONSTRAINT [FK_SellerInfo_CustomerInfo]
GO
/****** Object:  ForeignKey [FK_EmployeeSalary_CustomerInfo]    Script Date: 06/17/2016 21:22:40 ******/
ALTER TABLE [dbo].[EmployeeSalary]  WITH CHECK ADD  CONSTRAINT [FK_EmployeeSalary_CustomerInfo] FOREIGN KEY([CustID])
REFERENCES [dbo].[CustomerInfo] ([CustID])
GO
ALTER TABLE [dbo].[EmployeeSalary] CHECK CONSTRAINT [FK_EmployeeSalary_CustomerInfo]
GO
/****** Object:  ForeignKey [FK_EmployeeSalary_EmployeeDetails]    Script Date: 06/17/2016 21:22:40 ******/
ALTER TABLE [dbo].[EmployeeSalary]  WITH CHECK ADD  CONSTRAINT [FK_EmployeeSalary_EmployeeDetails] FOREIGN KEY([EmployeeID])
REFERENCES [dbo].[EmployeeDetails] ([EmployeeID])
GO
ALTER TABLE [dbo].[EmployeeSalary] CHECK CONSTRAINT [FK_EmployeeSalary_EmployeeDetails]
GO
/****** Object:  ForeignKey [FK_EmployeeSalary_MEmployeeDesignation]    Script Date: 06/17/2016 21:22:40 ******/
ALTER TABLE [dbo].[EmployeeSalary]  WITH CHECK ADD  CONSTRAINT [FK_EmployeeSalary_MEmployeeDesignation] FOREIGN KEY([MEmpDsgID])
REFERENCES [dbo].[MEmployeeDesignation] ([MEmpDsgID])
GO
ALTER TABLE [dbo].[EmployeeSalary] CHECK CONSTRAINT [FK_EmployeeSalary_MEmployeeDesignation]
GO
/****** Object:  ForeignKey [FK_EmployeeSalary_MSalaryType]    Script Date: 06/17/2016 21:22:40 ******/
ALTER TABLE [dbo].[EmployeeSalary]  WITH CHECK ADD  CONSTRAINT [FK_EmployeeSalary_MSalaryType] FOREIGN KEY([MSalaryTypeID])
REFERENCES [dbo].[MSalaryType] ([MSalaryTypeID])
GO
ALTER TABLE [dbo].[EmployeeSalary] CHECK CONSTRAINT [FK_EmployeeSalary_MSalaryType]
GO
/****** Object:  ForeignKey [FK_RiceStockInfo_CustomerInfo]    Script Date: 06/17/2016 21:22:40 ******/
ALTER TABLE [dbo].[RiceStockInfo]  WITH CHECK ADD  CONSTRAINT [FK_RiceStockInfo_CustomerInfo] FOREIGN KEY([CustID])
REFERENCES [dbo].[CustomerInfo] ([CustID])
GO
ALTER TABLE [dbo].[RiceStockInfo] CHECK CONSTRAINT [FK_RiceStockInfo_CustomerInfo]
GO
/****** Object:  ForeignKey [FK_RiceStockInfo_MRiceBrandDetails]    Script Date: 06/17/2016 21:22:40 ******/
ALTER TABLE [dbo].[RiceStockInfo]  WITH CHECK ADD  CONSTRAINT [FK_RiceStockInfo_MRiceBrandDetails] FOREIGN KEY([MRiceBrandID])
REFERENCES [dbo].[MRiceBrandDetails] ([MRiceBrandID])
GO
ALTER TABLE [dbo].[RiceStockInfo] CHECK CONSTRAINT [FK_RiceStockInfo_MRiceBrandDetails]
GO
/****** Object:  ForeignKey [FK_RiceStockInfo_MUnitsType]    Script Date: 06/17/2016 21:22:40 ******/
ALTER TABLE [dbo].[RiceStockInfo]  WITH CHECK ADD  CONSTRAINT [FK_RiceStockInfo_MUnitsType] FOREIGN KEY([UnitsTypeID])
REFERENCES [dbo].[MUnitsType] ([UnitsTypeID])
GO
ALTER TABLE [dbo].[RiceStockInfo] CHECK CONSTRAINT [FK_RiceStockInfo_MUnitsType]
GO
/****** Object:  ForeignKey [FK_RiceStockInfo_RiceStockInfo]    Script Date: 06/17/2016 21:22:40 ******/
ALTER TABLE [dbo].[RiceStockInfo]  WITH CHECK ADD  CONSTRAINT [FK_RiceStockInfo_RiceStockInfo] FOREIGN KEY([MRiceProdTypeID])
REFERENCES [dbo].[MRiceProductionType] ([MRiceProdTypeID])
GO
ALTER TABLE [dbo].[RiceStockInfo] CHECK CONSTRAINT [FK_RiceStockInfo_RiceStockInfo]
GO
/****** Object:  ForeignKey [FK_ProductSellingInfo_BuyerInfo]    Script Date: 06/17/2016 21:22:40 ******/
ALTER TABLE [dbo].[ProductSellingInfo]  WITH CHECK ADD  CONSTRAINT [FK_ProductSellingInfo_BuyerInfo] FOREIGN KEY([BuyerID])
REFERENCES [dbo].[BuyerInfo] ([BuyerID])
GO
ALTER TABLE [dbo].[ProductSellingInfo] CHECK CONSTRAINT [FK_ProductSellingInfo_BuyerInfo]
GO
/****** Object:  ForeignKey [FK_ProductSellingInfo_CustomerInfo]    Script Date: 06/17/2016 21:22:40 ******/
ALTER TABLE [dbo].[ProductSellingInfo]  WITH CHECK ADD  CONSTRAINT [FK_ProductSellingInfo_CustomerInfo] FOREIGN KEY([CustID])
REFERENCES [dbo].[CustomerInfo] ([CustID])
GO
ALTER TABLE [dbo].[ProductSellingInfo] CHECK CONSTRAINT [FK_ProductSellingInfo_CustomerInfo]
GO
/****** Object:  ForeignKey [FK_ProductSellingInfo_MBrokenRiceType]    Script Date: 06/17/2016 21:22:40 ******/
ALTER TABLE [dbo].[ProductSellingInfo]  WITH CHECK ADD  CONSTRAINT [FK_ProductSellingInfo_MBrokenRiceType] FOREIGN KEY([BrokenRiceTypeID])
REFERENCES [dbo].[MBrokenRiceType] ([BrokenRiceTypeID])
GO
ALTER TABLE [dbo].[ProductSellingInfo] CHECK CONSTRAINT [FK_ProductSellingInfo_MBrokenRiceType]
GO
/****** Object:  ForeignKey [FK_ProductSellingInfo_MRiceBrandDetails]    Script Date: 06/17/2016 21:22:40 ******/
ALTER TABLE [dbo].[ProductSellingInfo]  WITH CHECK ADD  CONSTRAINT [FK_ProductSellingInfo_MRiceBrandDetails] FOREIGN KEY([MRiceBrandID])
REFERENCES [dbo].[MRiceBrandDetails] ([MRiceBrandID])
GO
ALTER TABLE [dbo].[ProductSellingInfo] CHECK CONSTRAINT [FK_ProductSellingInfo_MRiceBrandDetails]
GO
/****** Object:  ForeignKey [FK_ProductSellingInfo_MRiceProductionType]    Script Date: 06/17/2016 21:22:40 ******/
ALTER TABLE [dbo].[ProductSellingInfo]  WITH CHECK ADD  CONSTRAINT [FK_ProductSellingInfo_MRiceProductionType] FOREIGN KEY([MRiceProdTypeID])
REFERENCES [dbo].[MRiceProductionType] ([MRiceProdTypeID])
GO
ALTER TABLE [dbo].[ProductSellingInfo] CHECK CONSTRAINT [FK_ProductSellingInfo_MRiceProductionType]
GO
/****** Object:  ForeignKey [FK_ProductSellingInfo_MUnitsType]    Script Date: 06/17/2016 21:22:40 ******/
ALTER TABLE [dbo].[ProductSellingInfo]  WITH CHECK ADD  CONSTRAINT [FK_ProductSellingInfo_MUnitsType] FOREIGN KEY([UnitsTypeID])
REFERENCES [dbo].[MUnitsType] ([UnitsTypeID])
GO
ALTER TABLE [dbo].[ProductSellingInfo] CHECK CONSTRAINT [FK_ProductSellingInfo_MUnitsType]
GO
/****** Object:  ForeignKey [FK_ProductSellingInfo_ProductPaymentInfo]    Script Date: 06/17/2016 21:22:40 ******/
ALTER TABLE [dbo].[ProductSellingInfo]  WITH CHECK ADD  CONSTRAINT [FK_ProductSellingInfo_ProductPaymentInfo] FOREIGN KEY([ProductPaymentID])
REFERENCES [dbo].[ProductPaymentInfo] ([ProductPaymentID])
GO
ALTER TABLE [dbo].[ProductSellingInfo] CHECK CONSTRAINT [FK_ProductSellingInfo_ProductPaymentInfo]
GO
/****** Object:  ForeignKey [fk_ProductPaymentTransaction_BuyerID]    Script Date: 06/17/2016 21:22:40 ******/
ALTER TABLE [dbo].[ProductPaymentTransaction]  WITH CHECK ADD  CONSTRAINT [fk_ProductPaymentTransaction_BuyerID] FOREIGN KEY([BuyerID])
REFERENCES [dbo].[BuyerInfo] ([BuyerID])
GO
ALTER TABLE [dbo].[ProductPaymentTransaction] CHECK CONSTRAINT [fk_ProductPaymentTransaction_BuyerID]
GO
/****** Object:  ForeignKey [FK_ProductPaymentTransaction_CustomerInfo]    Script Date: 06/17/2016 21:22:40 ******/
ALTER TABLE [dbo].[ProductPaymentTransaction]  WITH CHECK ADD  CONSTRAINT [FK_ProductPaymentTransaction_CustomerInfo] FOREIGN KEY([CustID])
REFERENCES [dbo].[CustomerInfo] ([CustID])
GO
ALTER TABLE [dbo].[ProductPaymentTransaction] CHECK CONSTRAINT [FK_ProductPaymentTransaction_CustomerInfo]
GO
/****** Object:  ForeignKey [FK_ProductPaymentTransaction_ProductPaymentInfo]    Script Date: 06/17/2016 21:22:40 ******/
ALTER TABLE [dbo].[ProductPaymentTransaction]  WITH CHECK ADD  CONSTRAINT [FK_ProductPaymentTransaction_ProductPaymentInfo] FOREIGN KEY([ProductPaymentID])
REFERENCES [dbo].[ProductPaymentInfo] ([ProductPaymentID])
GO
ALTER TABLE [dbo].[ProductPaymentTransaction] CHECK CONSTRAINT [FK_ProductPaymentTransaction_ProductPaymentInfo]
GO
/****** Object:  ForeignKey [FK_ByuerSellerRating_CustomerInfo]    Script Date: 06/17/2016 21:22:40 ******/
ALTER TABLE [dbo].[BuyerSellerRating]  WITH CHECK ADD  CONSTRAINT [FK_ByuerSellerRating_CustomerInfo] FOREIGN KEY([CustID])
REFERENCES [dbo].[CustomerInfo] ([CustID])
GO
ALTER TABLE [dbo].[BuyerSellerRating] CHECK CONSTRAINT [FK_ByuerSellerRating_CustomerInfo]
GO
/****** Object:  ForeignKey [FK_ByuerSellerRating_SellerInfo]    Script Date: 06/17/2016 21:22:40 ******/
ALTER TABLE [dbo].[BuyerSellerRating]  WITH CHECK ADD  CONSTRAINT [FK_ByuerSellerRating_SellerInfo] FOREIGN KEY([SellerID])
REFERENCES [dbo].[SellerInfo] ([SellerID])
GO
ALTER TABLE [dbo].[BuyerSellerRating] CHECK CONSTRAINT [FK_ByuerSellerRating_SellerInfo]
GO
/****** Object:  ForeignKey [fk_MEmpDsgID]    Script Date: 06/17/2016 21:22:40 ******/
ALTER TABLE [dbo].[MoneyTransaction]  WITH CHECK ADD  CONSTRAINT [fk_MEmpDsgID] FOREIGN KEY([MEmpDsgID])
REFERENCES [dbo].[MEmployeeDesignation] ([MEmpDsgID])
GO
ALTER TABLE [dbo].[MoneyTransaction] CHECK CONSTRAINT [fk_MEmpDsgID]
GO
/****** Object:  ForeignKey [FK_MoneyTransaction_CustomerInfo]    Script Date: 06/17/2016 21:22:40 ******/
ALTER TABLE [dbo].[MoneyTransaction]  WITH CHECK ADD  CONSTRAINT [FK_MoneyTransaction_CustomerInfo] FOREIGN KEY([CustID])
REFERENCES [dbo].[CustomerInfo] ([CustID])
GO
ALTER TABLE [dbo].[MoneyTransaction] CHECK CONSTRAINT [FK_MoneyTransaction_CustomerInfo]
GO
/****** Object:  ForeignKey [FK_MoneyTransaction_EmployeeDetails]    Script Date: 06/17/2016 21:22:40 ******/
ALTER TABLE [dbo].[MoneyTransaction]  WITH CHECK ADD  CONSTRAINT [FK_MoneyTransaction_EmployeeDetails] FOREIGN KEY([EmployeeID])
REFERENCES [dbo].[EmployeeDetails] ([EmployeeID])
GO
ALTER TABLE [dbo].[MoneyTransaction] CHECK CONSTRAINT [FK_MoneyTransaction_EmployeeDetails]
GO
/****** Object:  ForeignKey [fk_MonySalaryTypeID]    Script Date: 06/17/2016 21:22:40 ******/
ALTER TABLE [dbo].[MoneyTransaction]  WITH CHECK ADD  CONSTRAINT [fk_MonySalaryTypeID] FOREIGN KEY([MSalaryTypeID])
REFERENCES [dbo].[MSalaryType] ([MSalaryTypeID])
GO
ALTER TABLE [dbo].[MoneyTransaction] CHECK CONSTRAINT [fk_MonySalaryTypeID]
GO
/****** Object:  ForeignKey [FK_MLotDetails_CustomerInfo]    Script Date: 06/17/2016 21:22:40 ******/
ALTER TABLE [dbo].[MLotDetails]  WITH CHECK ADD  CONSTRAINT [FK_MLotDetails_CustomerInfo] FOREIGN KEY([CustID])
REFERENCES [dbo].[CustomerInfo] ([CustID])
GO
ALTER TABLE [dbo].[MLotDetails] CHECK CONSTRAINT [FK_MLotDetails_CustomerInfo]
GO
/****** Object:  ForeignKey [FK_MLotDetails_MGodownDetails]    Script Date: 06/17/2016 21:22:40 ******/
ALTER TABLE [dbo].[MLotDetails]  WITH CHECK ADD  CONSTRAINT [FK_MLotDetails_MGodownDetails] FOREIGN KEY([MGodownID])
REFERENCES [dbo].[MGodownDetails] ([MGodownID])
GO
ALTER TABLE [dbo].[MLotDetails] CHECK CONSTRAINT [FK_MLotDetails_MGodownDetails]
GO
/****** Object:  ForeignKey [FK_DustStockInfo_CustomerInfo]    Script Date: 06/17/2016 21:22:40 ******/
ALTER TABLE [dbo].[DustStockInfo]  WITH CHECK ADD  CONSTRAINT [FK_DustStockInfo_CustomerInfo] FOREIGN KEY([CustID])
REFERENCES [dbo].[CustomerInfo] ([CustID])
GO
ALTER TABLE [dbo].[DustStockInfo] CHECK CONSTRAINT [FK_DustStockInfo_CustomerInfo]
GO
/****** Object:  ForeignKey [FK_DustStockInfo_MUnitsType]    Script Date: 06/17/2016 21:22:40 ******/
ALTER TABLE [dbo].[DustStockInfo]  WITH CHECK ADD  CONSTRAINT [FK_DustStockInfo_MUnitsType] FOREIGN KEY([UnitsTypeID])
REFERENCES [dbo].[MUnitsType] ([UnitsTypeID])
GO
ALTER TABLE [dbo].[DustStockInfo] CHECK CONSTRAINT [FK_DustStockInfo_MUnitsType]
GO
/****** Object:  ForeignKey [FK_BrokenRiceStockInfo_CustomerInfo]    Script Date: 06/17/2016 21:22:40 ******/
ALTER TABLE [dbo].[BrokenRiceStockInfo]  WITH CHECK ADD  CONSTRAINT [FK_BrokenRiceStockInfo_CustomerInfo] FOREIGN KEY([CustID])
REFERENCES [dbo].[CustomerInfo] ([CustID])
GO
ALTER TABLE [dbo].[BrokenRiceStockInfo] CHECK CONSTRAINT [FK_BrokenRiceStockInfo_CustomerInfo]
GO
/****** Object:  ForeignKey [FK_BrokenRiceStockInfo_MBrokenRiceType]    Script Date: 06/17/2016 21:22:40 ******/
ALTER TABLE [dbo].[BrokenRiceStockInfo]  WITH CHECK ADD  CONSTRAINT [FK_BrokenRiceStockInfo_MBrokenRiceType] FOREIGN KEY([BrokenRiceTypeID])
REFERENCES [dbo].[MBrokenRiceType] ([BrokenRiceTypeID])
GO
ALTER TABLE [dbo].[BrokenRiceStockInfo] CHECK CONSTRAINT [FK_BrokenRiceStockInfo_MBrokenRiceType]
GO
/****** Object:  ForeignKey [FK_BrokenRiceStockInfo_MUnitsType]    Script Date: 06/17/2016 21:22:40 ******/
ALTER TABLE [dbo].[BrokenRiceStockInfo]  WITH CHECK ADD  CONSTRAINT [FK_BrokenRiceStockInfo_MUnitsType] FOREIGN KEY([UnitsTypeID])
REFERENCES [dbo].[MUnitsType] ([UnitsTypeID])
GO
ALTER TABLE [dbo].[BrokenRiceStockInfo] CHECK CONSTRAINT [FK_BrokenRiceStockInfo_MUnitsType]
GO
/****** Object:  ForeignKey [FK_BagStockInfo_CustomerInfo]    Script Date: 06/17/2016 21:22:40 ******/
ALTER TABLE [dbo].[BagStockInfo]  WITH CHECK ADD  CONSTRAINT [FK_BagStockInfo_CustomerInfo] FOREIGN KEY([CustID])
REFERENCES [dbo].[CustomerInfo] ([CustID])
GO
ALTER TABLE [dbo].[BagStockInfo] CHECK CONSTRAINT [FK_BagStockInfo_CustomerInfo]
GO
/****** Object:  ForeignKey [FK_BagStockInfo_SellerInfo]    Script Date: 06/17/2016 21:22:40 ******/
ALTER TABLE [dbo].[BagStockInfo]  WITH CHECK ADD  CONSTRAINT [FK_BagStockInfo_SellerInfo] FOREIGN KEY([SellerID])
REFERENCES [dbo].[SellerInfo] ([SellerID])
GO
ALTER TABLE [dbo].[BagStockInfo] CHECK CONSTRAINT [FK_BagStockInfo_SellerInfo]
GO
/****** Object:  ForeignKey [fkBagStockInfo_MRiceBrandID]    Script Date: 06/17/2016 21:22:40 ******/
ALTER TABLE [dbo].[BagStockInfo]  WITH CHECK ADD  CONSTRAINT [fkBagStockInfo_MRiceBrandID] FOREIGN KEY([MRiceBrandID])
REFERENCES [dbo].[MRiceBrandDetails] ([MRiceBrandID])
GO
ALTER TABLE [dbo].[BagStockInfo] CHECK CONSTRAINT [fkBagStockInfo_MRiceBrandID]
GO
/****** Object:  ForeignKey [fkBagStockInfo_UnitsTypeID]    Script Date: 06/17/2016 21:22:40 ******/
ALTER TABLE [dbo].[BagStockInfo]  WITH CHECK ADD  CONSTRAINT [fkBagStockInfo_UnitsTypeID] FOREIGN KEY([UnitsTypeID])
REFERENCES [dbo].[MUnitsType] ([UnitsTypeID])
GO
ALTER TABLE [dbo].[BagStockInfo] CHECK CONSTRAINT [fkBagStockInfo_UnitsTypeID]
GO
/****** Object:  ForeignKey [FK_HullingProcess_CustomerInfo]    Script Date: 06/17/2016 21:22:40 ******/
ALTER TABLE [dbo].[HullingProcess]  WITH CHECK ADD  CONSTRAINT [FK_HullingProcess_CustomerInfo] FOREIGN KEY([CustID])
REFERENCES [dbo].[CustomerInfo] ([CustID])
GO
ALTER TABLE [dbo].[HullingProcess] CHECK CONSTRAINT [FK_HullingProcess_CustomerInfo]
GO
/****** Object:  ForeignKey [FK_HullingProcess_MPaddyType]    Script Date: 06/17/2016 21:22:40 ******/
ALTER TABLE [dbo].[HullingProcess]  WITH CHECK ADD  CONSTRAINT [FK_HullingProcess_MPaddyType] FOREIGN KEY([PaddyTypeID])
REFERENCES [dbo].[MPaddyType] ([PaddyTypeID])
GO
ALTER TABLE [dbo].[HullingProcess] CHECK CONSTRAINT [FK_HullingProcess_MPaddyType]
GO
/****** Object:  ForeignKey [FK_HullingProcess_MUnitsType]    Script Date: 06/17/2016 21:22:40 ******/
ALTER TABLE [dbo].[HullingProcess]  WITH CHECK ADD  CONSTRAINT [FK_HullingProcess_MUnitsType] FOREIGN KEY([UnitsTypeID])
REFERENCES [dbo].[MUnitsType] ([UnitsTypeID])
GO
ALTER TABLE [dbo].[HullingProcess] CHECK CONSTRAINT [FK_HullingProcess_MUnitsType]
GO
/****** Object:  ForeignKey [fk_MGodownID]    Script Date: 06/17/2016 21:22:40 ******/
ALTER TABLE [dbo].[HullingProcess]  WITH CHECK ADD  CONSTRAINT [fk_MGodownID] FOREIGN KEY([MGodownID])
REFERENCES [dbo].[MGodownDetails] ([MGodownID])
GO
ALTER TABLE [dbo].[HullingProcess] CHECK CONSTRAINT [fk_MGodownID]
GO
/****** Object:  ForeignKey [fk_MLotID]    Script Date: 06/17/2016 21:22:40 ******/
ALTER TABLE [dbo].[HullingProcess]  WITH CHECK ADD  CONSTRAINT [fk_MLotID] FOREIGN KEY([MLotID])
REFERENCES [dbo].[MLotDetails] ([MLotID])
GO
ALTER TABLE [dbo].[HullingProcess] CHECK CONSTRAINT [fk_MLotID]
GO
/****** Object:  ForeignKey [FK_PaddyStockInfo_CustomerInfo]    Script Date: 06/17/2016 21:22:40 ******/
ALTER TABLE [dbo].[PaddyStockInfo]  WITH CHECK ADD  CONSTRAINT [FK_PaddyStockInfo_CustomerInfo] FOREIGN KEY([CustID])
REFERENCES [dbo].[CustomerInfo] ([CustID])
GO
ALTER TABLE [dbo].[PaddyStockInfo] CHECK CONSTRAINT [FK_PaddyStockInfo_CustomerInfo]
GO
/****** Object:  ForeignKey [FK_PaddyStockInfo_MGodownDetails]    Script Date: 06/17/2016 21:22:40 ******/
ALTER TABLE [dbo].[PaddyStockInfo]  WITH CHECK ADD  CONSTRAINT [FK_PaddyStockInfo_MGodownDetails] FOREIGN KEY([MGodownID])
REFERENCES [dbo].[MGodownDetails] ([MGodownID])
GO
ALTER TABLE [dbo].[PaddyStockInfo] CHECK CONSTRAINT [FK_PaddyStockInfo_MGodownDetails]
GO
/****** Object:  ForeignKey [FK_PaddyStockInfo_MLotDetails]    Script Date: 06/17/2016 21:22:40 ******/
ALTER TABLE [dbo].[PaddyStockInfo]  WITH CHECK ADD  CONSTRAINT [FK_PaddyStockInfo_MLotDetails] FOREIGN KEY([MLotID])
REFERENCES [dbo].[MLotDetails] ([MLotID])
GO
ALTER TABLE [dbo].[PaddyStockInfo] CHECK CONSTRAINT [FK_PaddyStockInfo_MLotDetails]
GO
/****** Object:  ForeignKey [FK_PaddyStockInfo_MPaddyType]    Script Date: 06/17/2016 21:22:40 ******/
ALTER TABLE [dbo].[PaddyStockInfo]  WITH CHECK ADD  CONSTRAINT [FK_PaddyStockInfo_MPaddyType] FOREIGN KEY([PaddyTypeID])
REFERENCES [dbo].[MPaddyType] ([PaddyTypeID])
GO
ALTER TABLE [dbo].[PaddyStockInfo] CHECK CONSTRAINT [FK_PaddyStockInfo_MPaddyType]
GO
/****** Object:  ForeignKey [FK_PaddyStockInfo_SellerInfo]    Script Date: 06/17/2016 21:22:40 ******/
ALTER TABLE [dbo].[PaddyStockInfo]  WITH CHECK ADD  CONSTRAINT [FK_PaddyStockInfo_SellerInfo] FOREIGN KEY([SellerID])
REFERENCES [dbo].[SellerInfo] ([SellerID])
GO
ALTER TABLE [dbo].[PaddyStockInfo] CHECK CONSTRAINT [FK_PaddyStockInfo_SellerInfo]
GO
/****** Object:  ForeignKey [fk_UnitsTypeID]    Script Date: 06/17/2016 21:22:40 ******/
ALTER TABLE [dbo].[PaddyStockInfo]  WITH CHECK ADD  CONSTRAINT [fk_UnitsTypeID] FOREIGN KEY([UnitsTypeID])
REFERENCES [dbo].[MUnitsType] ([UnitsTypeID])
GO
ALTER TABLE [dbo].[PaddyStockInfo] CHECK CONSTRAINT [fk_UnitsTypeID]
GO
/****** Object:  ForeignKey [FK_PaddyPaymentDetails_CustomerInfo]    Script Date: 06/17/2016 21:22:40 ******/
ALTER TABLE [dbo].[PaddyPaymentDetails]  WITH CHECK ADD  CONSTRAINT [FK_PaddyPaymentDetails_CustomerInfo] FOREIGN KEY([CustID])
REFERENCES [dbo].[CustomerInfo] ([CustID])
GO
ALTER TABLE [dbo].[PaddyPaymentDetails] CHECK CONSTRAINT [FK_PaddyPaymentDetails_CustomerInfo]
GO
/****** Object:  ForeignKey [FK_PaddyPaymentDetails_SellerInfo]    Script Date: 06/17/2016 21:22:40 ******/
ALTER TABLE [dbo].[PaddyPaymentDetails]  WITH CHECK ADD  CONSTRAINT [FK_PaddyPaymentDetails_SellerInfo] FOREIGN KEY([SellerID])
REFERENCES [dbo].[SellerInfo] ([SellerID])
GO
ALTER TABLE [dbo].[PaddyPaymentDetails] CHECK CONSTRAINT [FK_PaddyPaymentDetails_SellerInfo]
GO
/****** Object:  ForeignKey [fk_PaddyStockID]    Script Date: 06/17/2016 21:22:40 ******/
ALTER TABLE [dbo].[PaddyPaymentDetails]  WITH CHECK ADD  CONSTRAINT [fk_PaddyStockID] FOREIGN KEY([PaddyStockID])
REFERENCES [dbo].[PaddyStockInfo] ([PaddyStockID])
GO
ALTER TABLE [dbo].[PaddyPaymentDetails] CHECK CONSTRAINT [fk_PaddyStockID]
GO
/****** Object:  ForeignKey [FK_HullingTransaction_CustomerInfo]    Script Date: 06/17/2016 21:22:40 ******/
ALTER TABLE [dbo].[HullingTransaction]  WITH CHECK ADD  CONSTRAINT [FK_HullingTransaction_CustomerInfo] FOREIGN KEY([CustID])
REFERENCES [dbo].[CustomerInfo] ([CustID])
GO
ALTER TABLE [dbo].[HullingTransaction] CHECK CONSTRAINT [FK_HullingTransaction_CustomerInfo]
GO
/****** Object:  ForeignKey [FK_HullingTransaction_HullingProcess]    Script Date: 06/17/2016 21:22:40 ******/
ALTER TABLE [dbo].[HullingTransaction]  WITH CHECK ADD  CONSTRAINT [FK_HullingTransaction_HullingProcess] FOREIGN KEY([HullingProcessID])
REFERENCES [dbo].[HullingProcess] ([HullingProcessID])
GO
ALTER TABLE [dbo].[HullingTransaction] CHECK CONSTRAINT [FK_HullingTransaction_HullingProcess]
GO
/****** Object:  ForeignKey [FK_HullingTransaction_MBrokenRiceType]    Script Date: 06/17/2016 21:22:40 ******/
ALTER TABLE [dbo].[HullingTransaction]  WITH CHECK ADD  CONSTRAINT [FK_HullingTransaction_MBrokenRiceType] FOREIGN KEY([BrokenRiceTypeID])
REFERENCES [dbo].[MBrokenRiceType] ([BrokenRiceTypeID])
GO
ALTER TABLE [dbo].[HullingTransaction] CHECK CONSTRAINT [FK_HullingTransaction_MBrokenRiceType]
GO
/****** Object:  ForeignKey [FK_HullingTransaction_MRiceProductionType]    Script Date: 06/17/2016 21:22:40 ******/
ALTER TABLE [dbo].[HullingTransaction]  WITH CHECK ADD  CONSTRAINT [FK_HullingTransaction_MRiceProductionType] FOREIGN KEY([MRiceProdTypeID])
REFERENCES [dbo].[MRiceProductionType] ([MRiceProdTypeID])
GO
ALTER TABLE [dbo].[HullingTransaction] CHECK CONSTRAINT [FK_HullingTransaction_MRiceProductionType]
GO
/****** Object:  ForeignKey [FK_HullingTransaction_MUnitsType]    Script Date: 06/17/2016 21:22:40 ******/
ALTER TABLE [dbo].[HullingTransaction]  WITH CHECK ADD  CONSTRAINT [FK_HullingTransaction_MUnitsType] FOREIGN KEY([UnitsTypeID])
REFERENCES [dbo].[MUnitsType] ([UnitsTypeID])
GO
ALTER TABLE [dbo].[HullingTransaction] CHECK CONSTRAINT [FK_HullingTransaction_MUnitsType]
GO
/****** Object:  ForeignKey [fk_MRiceBrandID]    Script Date: 06/17/2016 21:22:40 ******/
ALTER TABLE [dbo].[HullingTransaction]  WITH CHECK ADD  CONSTRAINT [fk_MRiceBrandID] FOREIGN KEY([MRiceBrandID])
REFERENCES [dbo].[MRiceBrandDetails] ([MRiceBrandID])
GO
ALTER TABLE [dbo].[HullingTransaction] CHECK CONSTRAINT [fk_MRiceBrandID]
GO
/****** Object:  ForeignKey [fk_CustID]    Script Date: 06/17/2016 21:22:40 ******/
ALTER TABLE [dbo].[HullingProcessExpenses]  WITH CHECK ADD  CONSTRAINT [fk_CustID] FOREIGN KEY([CustID])
REFERENCES [dbo].[CustomerInfo] ([CustID])
GO
ALTER TABLE [dbo].[HullingProcessExpenses] CHECK CONSTRAINT [fk_CustID]
GO
/****** Object:  ForeignKey [FK_HullingProcessExpenses_HullingProcess]    Script Date: 06/17/2016 21:22:40 ******/
ALTER TABLE [dbo].[HullingProcessExpenses]  WITH CHECK ADD  CONSTRAINT [FK_HullingProcessExpenses_HullingProcess] FOREIGN KEY([HullingProcessID])
REFERENCES [dbo].[HullingProcess] ([HullingProcessID])
GO
ALTER TABLE [dbo].[HullingProcessExpenses] CHECK CONSTRAINT [FK_HullingProcessExpenses_HullingProcess]
GO
