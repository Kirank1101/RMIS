USE [master]
GO
/****** Object:  Database [RMIS]    Script Date: 07/12/2016 18:45:07 ******/
CREATE DATABASE [RMIS] ON  PRIMARY 
( NAME = N'RMIS', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\RMIS.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
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
/****** Object:  Table [dbo].[CustomerInfo]    Script Date: 07/12/2016 18:45:08 ******/
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
/****** Object:  Table [dbo].[MBrokenRiceType]    Script Date: 07/12/2016 18:45:08 ******/
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
INSERT [dbo].[MBrokenRiceType] ([BrokenRiceTypeID], [CustID], [BrokenRiceName], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (N'PT201606225efc7ab2111f9f', N'om', N'Half BR', N'om\test', CAST(0x0000A62D00AE3738 AS DateTime), N'N')
INSERT [dbo].[MBrokenRiceType] ([BrokenRiceTypeID], [CustID], [BrokenRiceName], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (N'PT201606229b4d4e400c959f', N'om', N'Small BR', N'om\test', CAST(0x0000A62D00AE3D14 AS DateTime), N'N')
/****** Object:  Table [dbo].[MenuInfo]    Script Date: 07/12/2016 18:45:08 ******/
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
INSERT [dbo].[MenuInfo] ([MenuID], [ParentMenuID], [Title], [Description], [URL], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (1, 0, N'All  Configuration                                ', N'All  Configuration', N'', N'System', CAST(0x0000A60A01844094 AS DateTime), N'N')
INSERT [dbo].[MenuInfo] ([MenuID], [ParentMenuID], [Title], [Description], [URL], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (3, 1, N'Add Paddy Types                                   ', N'Add Paddy Types', N'AddPaddyType.ascx', N'System', CAST(0x0000A60A0184413B AS DateTime), N'N')
INSERT [dbo].[MenuInfo] ([MenuID], [ParentMenuID], [Title], [Description], [URL], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (4, 1, N'Add Unit Types                                    ', N'Add Unit Types', N'AddUnitsType.ascx', N'System', CAST(0x0000A60A0184413B AS DateTime), N'N')
INSERT [dbo].[MenuInfo] ([MenuID], [ParentMenuID], [Title], [Description], [URL], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (5, 1, N'Add Godown Types                                  ', N'Add Godown Types', N'AddGodownDetails.ascx', N'System', CAST(0x0000A60A0184413B AS DateTime), N'N')
INSERT [dbo].[MenuInfo] ([MenuID], [ParentMenuID], [Title], [Description], [URL], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (6, 1, N'Add Lot Types                                     ', N'Add Lot Types', N'AddLotDetails.ascx', N'System', CAST(0x0000A60A0184413B AS DateTime), N'N')
INSERT [dbo].[MenuInfo] ([MenuID], [ParentMenuID], [Title], [Description], [URL], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (7, 1, N'Add Bag Types                                     ', N'Add Bag Types', N'AddBagType.ascx', N'System', CAST(0x0000A60A0184413B AS DateTime), N'N')
INSERT [dbo].[MenuInfo] ([MenuID], [ParentMenuID], [Title], [Description], [URL], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (8, 1, N'Add Rice Type                                     ', N'Add RiceType', N'AddRiceType.ascx', N'System', CAST(0x0000A60A0184413B AS DateTime), N'N')
INSERT [dbo].[MenuInfo] ([MenuID], [ParentMenuID], [Title], [Description], [URL], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (9, 1, N'Add Broken Rice Type                              ', N'Add Broken Rice', N'AddBrokenRiceType.ascx', N'System', CAST(0x0000A60A0184413B AS DateTime), N'N')
INSERT [dbo].[MenuInfo] ([MenuID], [ParentMenuID], [Title], [Description], [URL], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (10, 0, N'Purchase                                          ', N'Purchase', N'', N'System', CAST(0x0000A60A01844094 AS DateTime), N'N')
INSERT [dbo].[MenuInfo] ([MenuID], [ParentMenuID], [Title], [Description], [URL], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (11, 10, N'Add Seller Information                            ', N'Add Seller Information', N'SellerInfoDetails.ascx', N'System', CAST(0x0000A60A0184413B AS DateTime), N'N')
INSERT [dbo].[MenuInfo] ([MenuID], [ParentMenuID], [Title], [Description], [URL], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (12, 10, N'Paddy Stock                                       ', N'Paddy Stock', N'TransactionPaddyStockInfo.ascx', N'System', CAST(0x0000A60A0184413B AS DateTime), N'N')
INSERT [dbo].[MenuInfo] ([MenuID], [ParentMenuID], [Title], [Description], [URL], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (13, 10, N'Bag Stock Infomation                              ', N'Bag Stok Info', N'BagStockInfo.ascx', N'System', CAST(0x0000A60A0184413B AS DateTime), N'N')
INSERT [dbo].[MenuInfo] ([MenuID], [ParentMenuID], [Title], [Description], [URL], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (14, 0, N'Hulling Process                                   ', N'Hulling Process', N'', N'System', CAST(0x0000A60A01844094 AS DateTime), N'N')
INSERT [dbo].[MenuInfo] ([MenuID], [ParentMenuID], [Title], [Description], [URL], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (15, 14, N'Add Process                                       ', N'Add Process', N'HullingProcess.ascx', N'System', CAST(0x0000A60A0184413B AS DateTime), N'N')
INSERT [dbo].[MenuInfo] ([MenuID], [ParentMenuID], [Title], [Description], [URL], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (16, 0, N'Selling                                           ', N'Selling', N'', N'System', CAST(0x0000A60A01844094 AS DateTime), N'N')
INSERT [dbo].[MenuInfo] ([MenuID], [ParentMenuID], [Title], [Description], [URL], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (17, 16, N'Product Selling Information                       ', N'Product Selling Information  ', N'ProductSellingInfo.ascx', N'System', CAST(0x0000A60A0184413B AS DateTime), N'N')
INSERT [dbo].[MenuInfo] ([MenuID], [ParentMenuID], [Title], [Description], [URL], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (18, 16, N'Product Returned Information                      ', N'Product Returned Information', N'ProductReturnInfo.ascx', N'System', CAST(0x0000A60A0184413B AS DateTime), N'N')
INSERT [dbo].[MenuInfo] ([MenuID], [ParentMenuID], [Title], [Description], [URL], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (19, 1, N'Add Rice Brand                                    ', N'Add Rice Brand', N'AddRiceBrandType.ascx', N'System', CAST(0x0000A60A0184413B AS DateTime), N'N')
INSERT [dbo].[MenuInfo] ([MenuID], [ParentMenuID], [Title], [Description], [URL], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (20, 16, N'Add Product Selling Type                          ', N'Add Product Selling Type', N'AddProductSellingType.ascx', N'System', CAST(0x0000A60A0184413B AS DateTime), N'N')
INSERT [dbo].[MenuInfo] ([MenuID], [ParentMenuID], [Title], [Description], [URL], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (21, 0, N'Reports                                           ', N'Reports', N'', N'System', CAST(0x0000A60A01844094 AS DateTime), N'N')
INSERT [dbo].[MenuInfo] ([MenuID], [ParentMenuID], [Title], [Description], [URL], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (22, 1, N'Add Employee Designation                          ', N'Add Employee Designation', N'AddEmpDesig.ascx', N'System', CAST(0x0000A61F01044A5D AS DateTime), N'N')
INSERT [dbo].[MenuInfo] ([MenuID], [ParentMenuID], [Title], [Description], [URL], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (23, 1, N'Add Salary Type                                   ', N'Add Salary Type', N'AddSalaryType.ascx', N'System', CAST(0x0000A61F01044A5D AS DateTime), N'N')
INSERT [dbo].[MenuInfo] ([MenuID], [ParentMenuID], [Title], [Description], [URL], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (24, 1, N'Add Employee                                      ', N'Add Employee', N'EmployeeDetails.ascx', N'System', CAST(0x0000A61F01044A5D AS DateTime), N'N')
INSERT [dbo].[MenuInfo] ([MenuID], [ParentMenuID], [Title], [Description], [URL], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (25, 1, N'Add Employee Salary                               ', N'Add Employee Salary', N'EmployeeSalary.ascx', N'System', CAST(0x0000A61F01044A5D AS DateTime), N'N')
INSERT [dbo].[MenuInfo] ([MenuID], [ParentMenuID], [Title], [Description], [URL], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (26, 21, N'Paddy Stock Report                                ', N'Paddy Stock Report', N'RPT_PaddyStockReport.ascx', N'System', CAST(0x0000A61F01050E82 AS DateTime), N'N')
INSERT [dbo].[MenuInfo] ([MenuID], [ParentMenuID], [Title], [Description], [URL], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (27, 0, N'Payments                                          ', N'Payments', N'', N'System', CAST(0x0000A62000DA7A14 AS DateTime), N'N')
INSERT [dbo].[MenuInfo] ([MenuID], [ParentMenuID], [Title], [Description], [URL], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (28, 27, N'Salary Payment                                    ', N'Salary Payment', N'EmployeeSalaryPayment.ascx', N'System', CAST(0x0000A62000DAD3A1 AS DateTime), N'N')
INSERT [dbo].[MenuInfo] ([MenuID], [ParentMenuID], [Title], [Description], [URL], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (29, 16, N'Add Buyer Information                             ', N'Add Buyer Information', N'BuyerInfoDetails.ascx', N'System', CAST(0x0000A62801212D91 AS DateTime), N'N')
INSERT [dbo].[MenuInfo] ([MenuID], [ParentMenuID], [Title], [Description], [URL], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (30, 21, N'Paddy Payment Report                              ', N'Paddy Payment Report', N'RPT_PaddyPaymentInfo.ascx', N'System', CAST(0x0000A63000E65D85 AS DateTime), N'N')
INSERT [dbo].[MenuInfo] ([MenuID], [ParentMenuID], [Title], [Description], [URL], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (31, 21, N'Paddy Payment Due Report                          ', N'Paddy Payment Due Report', N'RPT_PaddyPaymentDue.ascx', N'System', CAST(0x0000A63000E65D85 AS DateTime), N'N')
INSERT [dbo].[MenuInfo] ([MenuID], [ParentMenuID], [Title], [Description], [URL], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (32, 21, N'Bag Stock Report                                  ', N'Bag Stock Report', N'RPT_BagStockReport.ascx', N'System', CAST(0x0000A630013CABDF AS DateTime), N'N')
INSERT [dbo].[MenuInfo] ([MenuID], [ParentMenuID], [Title], [Description], [URL], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (33, 21, N'Bag Payment Report                                ', N'Bag Payment Report', N'RPT_BagPaymentInfo.ascx', N'System', CAST(0x0000A635012CACFD AS DateTime), N'N')
INSERT [dbo].[MenuInfo] ([MenuID], [ParentMenuID], [Title], [Description], [URL], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (34, 21, N'Bag Payment Due Report                            ', N'Bag Payment Due Report', N'RPT_BagPaymentDue.ascx', N'System', CAST(0x0000A6350138A470 AS DateTime), N'N')
INSERT [dbo].[MenuInfo] ([MenuID], [ParentMenuID], [Title], [Description], [URL], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (35, 21, N'Product Selling                                   ', N'Product Selling', N'RPT_ProductSellingReport.ascx', N'System', CAST(0x0000A63600BB6842 AS DateTime), N'N')
INSERT [dbo].[MenuInfo] ([MenuID], [ParentMenuID], [Title], [Description], [URL], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (36, 21, N'Product Payment                                   ', N'Product Payment', N'RPT_ProductPaymentInfo.ascx', N'System', CAST(0x0000A63600F1240F AS DateTime), N'N')
INSERT [dbo].[MenuInfo] ([MenuID], [ParentMenuID], [Title], [Description], [URL], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (37, 16, N'Add Mediator Information                          ', N'Add Mediator Information', N'MediatorInfoDetails.ascx', N'System', CAST(0x0000A63900C1D782 AS DateTime), N'N')
INSERT [dbo].[MenuInfo] ([MenuID], [ParentMenuID], [Title], [Description], [URL], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (38, 1, N'Add Expense Type                                  ', N'Add Expense Type', N'AddExpenseType.ascx', N'System', CAST(0x0000A64100DE99F4 AS DateTime), N'N')
INSERT [dbo].[MenuInfo] ([MenuID], [ParentMenuID], [Title], [Description], [URL], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (39, 0, N'Others                                            ', N'Others', N'', N'System', CAST(0x0000A64100FD1ED4 AS DateTime), N'N')
INSERT [dbo].[MenuInfo] ([MenuID], [ParentMenuID], [Title], [Description], [URL], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (40, 39, N'Expense Transaction                               ', N'Expense Transaction', N'ExpenseTransaction.ascx', N'System', CAST(0x0000A64100FD6759 AS DateTime), N'N')
INSERT [dbo].[MenuInfo] ([MenuID], [ParentMenuID], [Title], [Description], [URL], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (41, 1, N'Add JobWork Type                                  ', N'Add JobWork Type', N'AddJobWork.ascx', N'System', CAST(0x0000A6410123A370 AS DateTime), N'N')
INSERT [dbo].[MenuInfo] ([MenuID], [ParentMenuID], [Title], [Description], [URL], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (42, 39, N'Rent Hulling                                      ', N'Rent Hulling', N'RentHulling.ascx', N'System', CAST(0x0000A64101344639 AS DateTime), N'N')
/****** Object:  Table [dbo].[MenuConfiguration]    Script Date: 07/12/2016 18:45:08 ******/
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
/****** Object:  Table [dbo].[MRoles]    Script Date: 07/12/2016 18:45:08 ******/
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
/****** Object:  Table [dbo].[RMUserRole]    Script Date: 07/12/2016 18:45:08 ******/
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
/****** Object:  Table [dbo].[Users]    Script Date: 07/12/2016 18:45:08 ******/
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
/****** Object:  Table [dbo].[SellerInfo]    Script Date: 07/12/2016 18:45:08 ******/
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
INSERT [dbo].[SellerInfo] ([SellerID], [CustID], [Name], [Street], [Street1], [Town], [City], [District], [State], [PinCode], [ContactNo], [MobileNo], [PhoneNo], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (N'SE201606220b3925470520d8', N'om', N'Ravi', N'a', N's3', N'c', N'bangalore', N'bangalore', N'karnataka', N'560034', N'9900990300', N'899', N'987', N'om\test', CAST(0x0000A62D00D16064 AS DateTime), N'N')
INSERT [dbo].[SellerInfo] ([SellerID], [CustID], [Name], [Street], [Street1], [Town], [City], [District], [State], [PinCode], [ContactNo], [MobileNo], [PhoneNo], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (N'SE201606220b3a84f3cd30e1', N'om', N'Babu', N'a', N's3', N'c', N'bangalore', N'bangalore', N'karnataka', N'560034', N'9900990300', N'899', N'987', N'om\test', CAST(0x0000A62D00D0E300 AS DateTime), N'N')
INSERT [dbo].[SellerInfo] ([SellerID], [CustID], [Name], [Street], [Street1], [Town], [City], [District], [State], [PinCode], [ContactNo], [MobileNo], [PhoneNo], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (N'SE201606221183000ebe5070', N'om', N'Anup', N'a', N's3', N'c', N'bangalore', N'bangalore', N'karnataka', N'560034', N'9900990300', N'899', N'987', N'om\test', CAST(0x0000A62D00D124A0 AS DateTime), N'N')
INSERT [dbo].[SellerInfo] ([SellerID], [CustID], [Name], [Street], [Street1], [Town], [City], [District], [State], [PinCode], [ContactNo], [MobileNo], [PhoneNo], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (N'SE201606221b26a4b2755447', N'om', N'Nagavardhan KJ', N'a', N's3', N'Kappanahalli', N'Shikaripura', N'Shimoga', N'karnataka', N'577427', N'9900990300', N'899', N'987', N'om\test', CAST(0x0000A62D00C8EBF0 AS DateTime), N'Y')
INSERT [dbo].[SellerInfo] ([SellerID], [CustID], [Name], [Street], [Street1], [Town], [City], [District], [State], [PinCode], [ContactNo], [MobileNo], [PhoneNo], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (N'SE201606221efe80762b8a56', N'om', N'LakshmiKantha Reddy', N'a', N's3', N'c', N'bangalore', N'bangalore', N'karnataka', N'', N'8495919999', N'899', N'987', N'om\test', CAST(0x0000A62D00D15254 AS DateTime), N'N')
INSERT [dbo].[SellerInfo] ([SellerID], [CustID], [Name], [Street], [Street1], [Town], [City], [District], [State], [PinCode], [ContactNo], [MobileNo], [PhoneNo], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (N'SE201606222f083db882c20b', N'om', N'Rajesh', N'a', N's3', N'c', N'bangalore', N'bangalore', N'karnataka', N'560034', N'9900990300', N'899', N'987', N'om\test', CAST(0x0000A62D00D16D48 AS DateTime), N'N')
INSERT [dbo].[SellerInfo] ([SellerID], [CustID], [Name], [Street], [Street1], [Town], [City], [District], [State], [PinCode], [ContactNo], [MobileNo], [PhoneNo], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (N'SE20160622335ee39f248a7e', N'om', N'Raghavendra', N'a', N's3', N'c', N'bangalore', N'bangalore', N'karnataka', N'560034', N'9900990300', N'899', N'987', N'om\test', CAST(0x0000A62D00D08D74 AS DateTime), N'N')
INSERT [dbo].[SellerInfo] ([SellerID], [CustID], [Name], [Street], [Street1], [Town], [City], [District], [State], [PinCode], [ContactNo], [MobileNo], [PhoneNo], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (N'SE201606223f7f4282c244bc', N'om', N'ChandraShekar', N'a', N's3', N'c', N'bangalore', N'bangalore', N'karnataka', N'560034', N'9900990300', N'899', N'', N'om\test', CAST(0x0000A62D00D081BC AS DateTime), N'N')
INSERT [dbo].[SellerInfo] ([SellerID], [CustID], [Name], [Street], [Street1], [Town], [City], [District], [State], [PinCode], [ContactNo], [MobileNo], [PhoneNo], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (N'SE201606224d27c9d452edf7', N'om', N'Bhanu Prakash', N'a', N's3', N'c', N'bangalore', N'bangalore', N'karnataka', N'560034', N'9900990300', N'899', N'987', N'om\test', CAST(0x0000A62D00D0C488 AS DateTime), N'N')
INSERT [dbo].[SellerInfo] ([SellerID], [CustID], [Name], [Street], [Street1], [Town], [City], [District], [State], [PinCode], [ContactNo], [MobileNo], [PhoneNo], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (N'SE20160622818a3e104bd6ae', N'om', N'Nagavardhan', N'a', N's3', N'c', N'bangalore', N'bangalore', N'karnataka', N'560034', N'9900990300', N'', N'987', N'om\test', CAST(0x0000A62D00D060EC AS DateTime), N'N')
INSERT [dbo].[SellerInfo] ([SellerID], [CustID], [Name], [Street], [Street1], [Town], [City], [District], [State], [PinCode], [ContactNo], [MobileNo], [PhoneNo], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (N'SE20160622986d94e8416164', N'om', N'Mahesh', N'a', N's3', N'c', N'bangalore', N'bangalore', N'karnataka', N'560034', N'9900990300', N'899', N'987', N'om\test', CAST(0x0000A62D00D0B8D0 AS DateTime), N'N')
INSERT [dbo].[SellerInfo] ([SellerID], [CustID], [Name], [Street], [Street1], [Town], [City], [District], [State], [PinCode], [ContactNo], [MobileNo], [PhoneNo], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (N'SE201606229a8d2daf5ee67d', N'om', N'Yogesh', N'a', N's3', N'c', N'bangalore', N'bangalore', N'karnataka', N'560034', N'9900990300', N'899', N'987', N'om\test', CAST(0x0000A62D00D18E18 AS DateTime), N'N')
INSERT [dbo].[SellerInfo] ([SellerID], [CustID], [Name], [Street], [Street1], [Town], [City], [District], [State], [PinCode], [ContactNo], [MobileNo], [PhoneNo], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (N'SE20160622b1ba4d7f21a84c', N'om', N'Chndra', N'a', N's3', N'c', N'bangalore', N'bangalore', N'karnataka', N'560034', N'9900990300', N'899', N'987', N'om\test', CAST(0x0000A62D00D10754 AS DateTime), N'N')
INSERT [dbo].[SellerInfo] ([SellerID], [CustID], [Name], [Street], [Street1], [Town], [City], [District], [State], [PinCode], [ContactNo], [MobileNo], [PhoneNo], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (N'SE20160622b87877d6f02c7a', N'om', N'Kiran', N'a', N's3', N'c', N'bangalore', N'bangalore', N'karnataka', N'560034', N'8495919999', N'899', N'987', N'om\test', CAST(0x0000A62D00D0A610 AS DateTime), N'N')
INSERT [dbo].[SellerInfo] ([SellerID], [CustID], [Name], [Street], [Street1], [Town], [City], [District], [State], [PinCode], [ContactNo], [MobileNo], [PhoneNo], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (N'SE20160622c1cb3d515c67b0', N'om', N'Harshavardhan', N'a', N's3', N'c', N'bangalore', N'bangalore', N'karnataka', N'560034', N'9900990300', N'', N'', N'om\test', CAST(0x0000A62D00D07280 AS DateTime), N'N')
INSERT [dbo].[SellerInfo] ([SellerID], [CustID], [Name], [Street], [Street1], [Town], [City], [District], [State], [PinCode], [ContactNo], [MobileNo], [PhoneNo], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (N'SE20160622c5e10cc5277fc5', N'om', N'Jagadeesh', N'a', N's3', N'c', N'bangalore', N'bangalore', N'karnataka', N'560034', N'9900990300', N'899', N'987', N'om\test', CAST(0x0000A62D00D13AE4 AS DateTime), N'N')
INSERT [dbo].[SellerInfo] ([SellerID], [CustID], [Name], [Street], [Street1], [Town], [City], [District], [State], [PinCode], [ContactNo], [MobileNo], [PhoneNo], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (N'SE20160622ccf6ea7497e897', N'om', N'Ramesh', N'a', N's3', N'c', N'bangalore', N'bangalore', N'karnataka', N'560034', N'9900990300', N'899', N'987', N'om\test', CAST(0x0000A62D00D0FA70 AS DateTime), N'N')
INSERT [dbo].[SellerInfo] ([SellerID], [CustID], [Name], [Street], [Street1], [Town], [City], [District], [State], [PinCode], [ContactNo], [MobileNo], [PhoneNo], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (N'SE20160622e69ea675fda85b', N'om', N'Nagavardhan', N'a', N's3', N'c', N'bangalore', N'bangalore', N'karnataka', N'560034', N'9900990300', N'899', N'987', N'om\test', CAST(0x0000A62D00C8B158 AS DateTime), N'Y')
INSERT [dbo].[SellerInfo] ([SellerID], [CustID], [Name], [Street], [Street1], [Town], [City], [District], [State], [PinCode], [ContactNo], [MobileNo], [PhoneNo], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (N'SE20160622fdafc534b48d96', N'om', N'GuruPrasad', N'a', N's3', N'c', N'bangalore', N'bangalore', N'karnataka', N'560034', N'9900990300', N'899', N'987', N'om\test', CAST(0x0000A62D00D0D4F0 AS DateTime), N'N')
/****** Object:  Table [dbo].[MWeightDetails]    Script Date: 07/12/2016 18:45:08 ******/
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
/****** Object:  Table [dbo].[MUnitsType]    Script Date: 07/12/2016 18:45:08 ******/
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
INSERT [dbo].[MUnitsType] ([UnitsTypeID], [CustID], [LastModifiedBy], [LastModifiedDate], [ObsInd], [UnitsType]) VALUES (N'BT201606224dcfa31d81fc00', N'om', N'om\test', CAST(0x0000A62D00AD4CD8 AS DateTime), N'N', N'100')
INSERT [dbo].[MUnitsType] ([UnitsTypeID], [CustID], [LastModifiedBy], [LastModifiedDate], [ObsInd], [UnitsType]) VALUES (N'BT2016062280517d7e42e848', N'om', N'om\test', CAST(0x0000A62D00AD46FC AS DateTime), N'N', N'75')
INSERT [dbo].[MUnitsType] ([UnitsTypeID], [CustID], [LastModifiedBy], [LastModifiedDate], [ObsInd], [UnitsType]) VALUES (N'BT2016062286029cb9006bd9', N'om', N'om\test', CAST(0x0000A62D00AD38EC AS DateTime), N'N', N'25')
INSERT [dbo].[MUnitsType] ([UnitsTypeID], [CustID], [LastModifiedBy], [LastModifiedDate], [ObsInd], [UnitsType]) VALUES (N'BT2016062293b86dbabd294f', N'om', N'om\test', CAST(0x0000A62D00AD3EC8 AS DateTime), N'N', N'50')
INSERT [dbo].[MUnitsType] ([UnitsTypeID], [CustID], [LastModifiedBy], [LastModifiedDate], [ObsInd], [UnitsType]) VALUES (N'BT2016070684ad14517306f6', N'om1', N'om1\test', CAST(0x0000A63B00FB84AC AS DateTime), N'N', N'75')
INSERT [dbo].[MUnitsType] ([UnitsTypeID], [CustID], [LastModifiedBy], [LastModifiedDate], [ObsInd], [UnitsType]) VALUES (N'BT20160706fbece36207198e', N'om1', N'om1\test', CAST(0x0000A63B00FB895C AS DateTime), N'N', N'100')
/****** Object:  Table [dbo].[MSalaryType]    Script Date: 07/12/2016 18:45:08 ******/
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
INSERT [dbo].[MSalaryType] ([MSalaryTypeID], [CustID], [Salarytype], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (N'ST2016062266ffe779482d4b', N'om', N'Monthly', N'om\test', CAST(0x0000A62D00AE99A8 AS DateTime), N'N')
INSERT [dbo].[MSalaryType] ([MSalaryTypeID], [CustID], [Salarytype], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (N'ST201606229deb58aa165b63', N'om', N'Daily', N'om\test', CAST(0x0000A62D00AE92A0 AS DateTime), N'N')
INSERT [dbo].[MSalaryType] ([MSalaryTypeID], [CustID], [Salarytype], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (N'ST20160622c4a35ab35f5f21', N'om', N'Weekly', N'om\test', CAST(0x0000A62D00AE9F84 AS DateTime), N'N')
/****** Object:  Table [dbo].[MRiceProductionType]    Script Date: 07/12/2016 18:45:08 ******/
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
INSERT [dbo].[MRiceProductionType] ([MRiceProdTypeID], [CustID], [RiceType], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (N'RP201606221b4b962a275075', N'om', N'Ankur Sona', N'om\test', CAST(0x0000A62D00AE0AB0 AS DateTime), N'N')
INSERT [dbo].[MRiceProductionType] ([MRiceProdTypeID], [CustID], [RiceType], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (N'RP2016062292aaacbca7668e', N'om', N'JJL', N'om\test', CAST(0x0000A62D00AE108C AS DateTime), N'N')
INSERT [dbo].[MRiceProductionType] ([MRiceProdTypeID], [CustID], [RiceType], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (N'RP2016062294b63a1e91a242', N'om', N'Sona', N'om\test', CAST(0x0000A62D00AE0024 AS DateTime), N'N')
INSERT [dbo].[MRiceProductionType] ([MRiceProdTypeID], [CustID], [RiceType], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (N'RP20160622c05ec2d94f9b8e', N'om', N'Jaya', N'om\test', CAST(0x0000A62D011465D0 AS DateTime), N'N')
/****** Object:  Table [dbo].[MRiceBrandDetails]    Script Date: 07/12/2016 18:45:08 ******/
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
INSERT [dbo].[MRiceBrandDetails] ([MRiceBrandID], [CustID], [Name], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (N'RB2016062203979664e4dc44', N'om', N'cristal', N'om\test', CAST(0x0000A62D00AE5100 AS DateTime), N'N')
INSERT [dbo].[MRiceBrandDetails] ([MRiceBrandID], [CustID], [Name], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (N'RB2016062245b890084762d1', N'om', N'Bullet', N'om\test', CAST(0x0000A62D00AE4674 AS DateTime), N'N')
INSERT [dbo].[MRiceBrandDetails] ([MRiceBrandID], [CustID], [Name], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (N'RB20160622a0bc906b7a75d0', N'om', N'Shine', N'om\test', CAST(0x0000A62D00AE6294 AS DateTime), N'N')
/****** Object:  Table [dbo].[MPaddyType]    Script Date: 07/12/2016 18:45:08 ******/
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
INSERT [dbo].[MPaddyType] ([PaddyTypeID], [CustID], [Name], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (N'PT20160622169200ade91e3b', N'om', N'Jaya', N'om\test', CAST(0x0000A62D00AD2F8C AS DateTime), N'N')
INSERT [dbo].[MPaddyType] ([PaddyTypeID], [CustID], [Name], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (N'PT201606225c6dce2fadc060', N'om', N'Ankur Sona', N'om\test', CAST(0x0000A62D00AD15C4 AS DateTime), N'N')
INSERT [dbo].[MPaddyType] ([PaddyTypeID], [CustID], [Name], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (N'PT20160622e2a79f4e7cac16', N'om', N'JJL', N'om\test', CAST(0x0000A62D00AD262C AS DateTime), N'N')
INSERT [dbo].[MPaddyType] ([PaddyTypeID], [CustID], [Name], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (N'PT20160622e57004fb19fc80', N'om', N'Sona', N'om\test', CAST(0x0000A62D00AD0B38 AS DateTime), N'N')
INSERT [dbo].[MPaddyType] ([PaddyTypeID], [CustID], [Name], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (N'PT20160704b089e100e87c4f', N'om', N'xyz', N'om\test', CAST(0x0000A639014197BC AS DateTime), N'Y')
INSERT [dbo].[MPaddyType] ([PaddyTypeID], [CustID], [Name], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (N'PT20160706ee3c398edde14f', N'om1', N'sona', N'om1\test', CAST(0x0000A63B00FB77C8 AS DateTime), N'N')
/****** Object:  Table [dbo].[MJobWork]    Script Date: 07/12/2016 18:45:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MJobWork](
	[JobWorkID] [nvarchar](50) NOT NULL,
	[CustID] [nvarchar](50) NOT NULL,
	[JobWorkType] [nvarchar](200) NOT NULL,
	[LastModifiedBy] [nvarchar](50) NOT NULL,
	[LastModifiedDate] [datetime] NOT NULL,
	[ObsInd] [char](1) NOT NULL,
 CONSTRAINT [PK_MJobWork] PRIMARY KEY CLUSTERED 
(
	[JobWorkID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[MJobWork] ([JobWorkID], [CustID], [JobWorkType], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (N'JW201607120695fd7e5cd426', N'om', N'Steam', N'om\test', CAST(0x0000A6410123EBA4 AS DateTime), N'N')
INSERT [dbo].[MJobWork] ([JobWorkID], [CustID], [JobWorkType], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (N'JW201607122006f623a6cfff', N'om', N'Double Dry', N'om\test', CAST(0x0000A64101240698 AS DateTime), N'N')
INSERT [dbo].[MJobWork] ([JobWorkID], [CustID], [JobWorkType], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (N'JW2016071254e2790cf5b6ff', N'om', N'Single Dry', N'om\test', CAST(0x0000A6410123FD38 AS DateTime), N'N')
INSERT [dbo].[MJobWork] ([JobWorkID], [CustID], [JobWorkType], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (N'JW201607125cd24efc534cf0', N'om', N'Raw', N'om\test', CAST(0x0000A6410123C87C AS DateTime), N'N')
/****** Object:  Table [dbo].[MGodownDetails]    Script Date: 07/12/2016 18:45:08 ******/
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
INSERT [dbo].[MGodownDetails] ([MGodownID], [CustID], [Place], [LastModifiedBy], [LastModifiedDate], [ObsInd], [Name]) VALUES (N'GD201606222ab20bc53f6828', N'om', NULL, N'om\test', CAST(0x0000A62D00AD7F3C AS DateTime), N'N', N'Godown2')
INSERT [dbo].[MGodownDetails] ([MGodownID], [CustID], [Place], [LastModifiedBy], [LastModifiedDate], [ObsInd], [Name]) VALUES (N'GD2016062238d905b1abc0ed', N'om', NULL, N'om\test', CAST(0x0000A62D00AD7960 AS DateTime), N'N', N'Godown1')
INSERT [dbo].[MGodownDetails] ([MGodownID], [CustID], [Place], [LastModifiedBy], [LastModifiedDate], [ObsInd], [Name]) VALUES (N'GD201607066c7e9e984467f6', N'om1', NULL, N'om1\test', CAST(0x0000A63B00FB9190 AS DateTime), N'N', N'G1')
INSERT [dbo].[MGodownDetails] ([MGodownID], [CustID], [Place], [LastModifiedBy], [LastModifiedDate], [ObsInd], [Name]) VALUES (N'GD2016070804cbde9df991f4', N'om', NULL, N'om\test', CAST(0x0000A63D0124D604 AS DateTime), N'N', N'G3')
/****** Object:  Table [dbo].[MExpenseType]    Script Date: 07/12/2016 18:45:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MExpenseType](
	[ExpenseID] [nvarchar](50) NOT NULL,
	[CustID] [nvarchar](50) NOT NULL,
	[ExpenseType] [nvarchar](50) NOT NULL,
	[LastModifiedBy] [nvarchar](50) NOT NULL,
	[LastModifiedDate] [datetime] NOT NULL,
	[ObsInd] [char](1) NOT NULL,
 CONSTRAINT [PK_MExpenseType] PRIMARY KEY CLUSTERED 
(
	[ExpenseID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[MExpenseType] ([ExpenseID], [CustID], [ExpenseType], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (N'ET201607121d482a9bd62156', N'om', N'Transport Expenses', N'om\test', CAST(0x0000A64100E4A278 AS DateTime), N'N')
INSERT [dbo].[MExpenseType] ([ExpenseID], [CustID], [ExpenseType], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (N'ET20160712382fd54a41a573', N'om', N'Paddy Comissions', N'om\test', CAST(0x0000A64100E42FA0 AS DateTime), N'Y')
INSERT [dbo].[MExpenseType] ([ExpenseID], [CustID], [ExpenseType], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (N'ET201607123df300c8474243', N'om', N'Other Expenses', N'om\test', CAST(0x0000A64100E4AAAC AS DateTime), N'N')
INSERT [dbo].[MExpenseType] ([ExpenseID], [CustID], [ExpenseType], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (N'ET201607125959aa88402865', N'om', N'Rice Comission', N'om\test', CAST(0x0000A64100E481A8 AS DateTime), N'N')
INSERT [dbo].[MExpenseType] ([ExpenseID], [CustID], [ExpenseType], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (N'ET2016071276da7d7aa87f09', N'om', N'Paddy Comission', N'om\test', CAST(0x0000A64100E436A8 AS DateTime), N'N')
INSERT [dbo].[MExpenseType] ([ExpenseID], [CustID], [ExpenseType], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (N'ET201607129910a3af28be46', N'om', N'Paddy Comissions', N'om\test', CAST(0x0000A64100E46330 AS DateTime), N'Y')
/****** Object:  Table [dbo].[MessageInfo]    Script Date: 07/12/2016 18:45:08 ******/
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
/****** Object:  Table [dbo].[MEmployeeDesignation]    Script Date: 07/12/2016 18:45:08 ******/
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
INSERT [dbo].[MEmployeeDesignation] ([MEmpDsgID], [CustID], [DesignationType], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (N'EI201606221e80816e08a0c6', N'om', N'Fitter', N'om\test', CAST(0x0000A62D00AE70A4 AS DateTime), N'N')
INSERT [dbo].[MEmployeeDesignation] ([MEmpDsgID], [CustID], [DesignationType], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (N'EI20160622337f83d4f24820', N'om', N'Gumastha', N'om\test', CAST(0x0000A62D00AE8A6C AS DateTime), N'N')
INSERT [dbo].[MEmployeeDesignation] ([MEmpDsgID], [CustID], [DesignationType], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (N'EI20160622b6e2a2446b261b', N'om', N'Labour', N'om\test', CAST(0x0000A62D00AE77AC AS DateTime), N'N')
INSERT [dbo].[MEmployeeDesignation] ([MEmpDsgID], [CustID], [DesignationType], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (N'EI20160622ee8d3511bb8d37', N'om', N'Hamali', N'om\test', CAST(0x0000A62D00AE810C AS DateTime), N'N')
/****** Object:  Table [dbo].[MediatorInfo]    Script Date: 07/12/2016 18:45:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MediatorInfo](
	[MediatorID] [nvarchar](50) NOT NULL,
	[CustID] [nvarchar](50) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Street] [nvarchar](30) NULL,
	[Street1] [nvarchar](30) NULL,
	[Town] [nvarchar](50) NOT NULL,
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
 CONSTRAINT [PK_MediatorInfo] PRIMARY KEY CLUSTERED 
(
	[MediatorID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[MediatorInfo] ([MediatorID], [CustID], [Name], [Street], [Street1], [Town], [City], [District], [State], [PinCode], [ContactNo], [MobileNo], [PhoneNo], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (N'BI201606231ddde313f3a96c', N'om', N'Rudresh', N'a', N's3', N'c', N'Gangavathi', N'Gangavathi', N'karnataka', N'560085', N'9923459988', N'899', N'987', N'om\test', CAST(0x0000A63900E55399 AS DateTime), N'N')
INSERT [dbo].[MediatorInfo] ([MediatorID], [CustID], [Name], [Street], [Street1], [Town], [City], [District], [State], [PinCode], [ContactNo], [MobileNo], [PhoneNo], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (N'BI201607048d5a570e9b919e', N'om', N'Mahesh', N'', N'', N'Kappanahalli', N'Shikaripura', N'Shimoga', N'Karnataka', N'', N'9987556311', N'9878987657', N'', N'om\test', CAST(0x0000A6390169D484 AS DateTime), N'N')
/****** Object:  Table [dbo].[MDrierTypeDetails]    Script Date: 07/12/2016 18:45:08 ******/
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
/****** Object:  Table [dbo].[MBagType]    Script Date: 07/12/2016 18:45:08 ******/
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
INSERT [dbo].[MBagType] ([BagTypeID], [BagType], [LastModifiedBy], [LastModifiedDate], [ObsInd], [CustID]) VALUES (N'BT201606221390df0a938bdd', N'BrokenRice', N'om\test', CAST(0x0000A62D00ADE080 AS DateTime), N'N', N'om')
INSERT [dbo].[MBagType] ([BagTypeID], [BagType], [LastModifiedBy], [LastModifiedDate], [ObsInd], [CustID]) VALUES (N'BT201606228950a49a406302', N'Dust', N'om\test', CAST(0x0000A62D00ADEC38 AS DateTime), N'N', N'om')
INSERT [dbo].[MBagType] ([BagTypeID], [BagType], [LastModifiedBy], [LastModifiedDate], [ObsInd], [CustID]) VALUES (N'BT20160622a36f281153e577', N'Rice', N'om\test', CAST(0x0000A62D00ADD39C AS DateTime), N'N', N'om')
INSERT [dbo].[MBagType] ([BagTypeID], [BagType], [LastModifiedBy], [LastModifiedDate], [ObsInd], [CustID]) VALUES (N'BT20160622bd4d93b0e04f0f', N'Paddy', N'om\test', CAST(0x0000A62D00ADBC2C AS DateTime), N'N', N'om')
INSERT [dbo].[MBagType] ([BagTypeID], [BagType], [LastModifiedBy], [LastModifiedDate], [ObsInd], [CustID]) VALUES (N'BT20160708af90df0984bc3d', N'gunnybags', N'om\test', CAST(0x0000A63D00DD2548 AS DateTime), N'N', N'om')
/****** Object:  Table [dbo].[CustTrailUsage]    Script Date: 07/12/2016 18:45:08 ******/
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
/****** Object:  Table [dbo].[CustomerPayment]    Script Date: 07/12/2016 18:45:08 ******/
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
/****** Object:  Table [dbo].[CustomerPartPayDetails]    Script Date: 07/12/2016 18:45:08 ******/
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
/****** Object:  Table [dbo].[BuyerInfo]    Script Date: 07/12/2016 18:45:08 ******/
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
	[Town] [nvarchar](50) NOT NULL,
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
INSERT [dbo].[BuyerInfo] ([BuyerID], [CustID], [Name], [Street], [Street1], [Town], [City], [District], [State], [PinCode], [ContactNo], [MobileNo], [PhoneNo], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (N'BI201606231ddde313f3a96c', N'om', N'Durga Agency', N'a', N's3', N'c', N'bangalore', N'bangalore', N'karnataka', N'560085', N'9900990300', N'899', N'987', N'om\test', CAST(0x0000A62E00FF8868 AS DateTime), N'N')
/****** Object:  Table [dbo].[EmployeeDetails]    Script Date: 07/12/2016 18:45:08 ******/
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
INSERT [dbo].[EmployeeDetails] ([EmployeeID], [CustID], [Name], [Street], [Street1], [Town], [City], [District], [State], [PinCode], [ContactNo], [MobileNo], [PhoneNo], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (N'EI20160622b4e1bdd7d5ca6a', N'om', N'Mahesh', N'a', N's3', NULL, N'bangalore', N'bangalore', N'karnataka', N'560034', N'9900990300', N'899', N'987', N'om\test', CAST(0x0000A62D00AECE64 AS DateTime), N'N')
/****** Object:  Table [dbo].[CustomerAddressInfo]    Script Date: 07/12/2016 18:45:08 ******/
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
/****** Object:  Table [dbo].[CustomerActivation]    Script Date: 07/12/2016 18:45:08 ******/
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
/****** Object:  Table [dbo].[BuyerSellerRating]    Script Date: 07/12/2016 18:45:08 ******/
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
/****** Object:  Table [dbo].[DustStockInfo]    Script Date: 07/12/2016 18:45:08 ******/
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
INSERT [dbo].[DustStockInfo] ([DustStockID], [CustID], [UnitsTypeID], [TotalBags], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (N'HTD201606226b6449e98aff4f', N'om', N'BT201606224dcfa31d81fc00', 4, N'om\test', CAST(0x0000A62D01194E10 AS DateTime), N'N')
INSERT [dbo].[DustStockInfo] ([DustStockID], [CustID], [UnitsTypeID], [TotalBags], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (N'HTD2016062726f4607ac50fe3', N'om', N'BT201606224dcfa31d81fc00', 2, N'om\test', CAST(0x0000A63200F9EF34 AS DateTime), N'N')
INSERT [dbo].[DustStockInfo] ([DustStockID], [CustID], [UnitsTypeID], [TotalBags], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (N'HTD20160706c949ce29003048', N'om', N'BT2016062280517d7e42e848', 4, N'om\test', CAST(0x0000A63B00A1E104 AS DateTime), N'N')
INSERT [dbo].[DustStockInfo] ([DustStockID], [CustID], [UnitsTypeID], [TotalBags], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (N'HTD20160706ed7149756a50fa', N'om', N'BT2016062280517d7e42e848', 4, N'om\test', CAST(0x0000A63B00A7DB7C AS DateTime), N'N')
INSERT [dbo].[DustStockInfo] ([DustStockID], [CustID], [UnitsTypeID], [TotalBags], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (N'HTD20160708af6513c3896acc', N'om', N'BT201606224dcfa31d81fc00', 2, N'om\test', CAST(0x0000A63D00DC02A8 AS DateTime), N'N')
INSERT [dbo].[DustStockInfo] ([DustStockID], [CustID], [UnitsTypeID], [TotalBags], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (N'HTD201607124d739efcd0eaf7', N'om', N'BT201606224dcfa31d81fc00', 2, N'om\test', CAST(0x0000A64100AC4B08 AS DateTime), N'N')
/****** Object:  Table [dbo].[BrokenRiceStockInfo]    Script Date: 07/12/2016 18:45:08 ******/
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
INSERT [dbo].[BrokenRiceStockInfo] ([BrokenRiceStockID], [BrokenRiceTypeID], [CustID], [UnitsTypeID], [TotalBags], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (N'HTBR20160622138a2494bce843', N'PT201606229b4d4e400c959f', N'om', N'BT2016062293b86dbabd294f', 4, N'om\test', CAST(0x0000A62D01194E10 AS DateTime), N'N')
INSERT [dbo].[BrokenRiceStockInfo] ([BrokenRiceStockID], [BrokenRiceTypeID], [CustID], [UnitsTypeID], [TotalBags], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (N'HTBR20160622d467a498bc8341', N'PT201606225efc7ab2111f9f', N'om', N'BT2016062293b86dbabd294f', 4, N'om\test', CAST(0x0000A62D01194E10 AS DateTime), N'N')
INSERT [dbo].[BrokenRiceStockInfo] ([BrokenRiceStockID], [BrokenRiceTypeID], [CustID], [UnitsTypeID], [TotalBags], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (N'HTBR20160627768f226d533d28', N'PT201606225efc7ab2111f9f', N'om', N'BT201606224dcfa31d81fc00', 4, N'om\test', CAST(0x0000A63200F9EF34 AS DateTime), N'N')
INSERT [dbo].[BrokenRiceStockInfo] ([BrokenRiceStockID], [BrokenRiceTypeID], [CustID], [UnitsTypeID], [TotalBags], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (N'HTBR20160706dbce0d19aae398', N'PT201606225efc7ab2111f9f', N'om', N'BT2016062280517d7e42e848', 4, N'om\test', CAST(0x0000A63B00A7D0F0 AS DateTime), N'N')
INSERT [dbo].[BrokenRiceStockInfo] ([BrokenRiceStockID], [BrokenRiceTypeID], [CustID], [UnitsTypeID], [TotalBags], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (N'HTBR20160706fc547bd2592c19', N'PT201606225efc7ab2111f9f', N'om', N'BT2016062280517d7e42e848', 4, N'om\test', CAST(0x0000A63B00A1E104 AS DateTime), N'N')
INSERT [dbo].[BrokenRiceStockInfo] ([BrokenRiceStockID], [BrokenRiceTypeID], [CustID], [UnitsTypeID], [TotalBags], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (N'HTBR2016070821d928448787a3', N'PT201606229b4d4e400c959f', N'om', N'BT2016062286029cb9006bd9', 50, N'om\test', CAST(0x0000A63D00DC02A8 AS DateTime), N'N')
INSERT [dbo].[BrokenRiceStockInfo] ([BrokenRiceStockID], [BrokenRiceTypeID], [CustID], [UnitsTypeID], [TotalBags], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (N'HTBR201607087ddfc22e263b43', N'PT201606225efc7ab2111f9f', N'om', N'BT2016062286029cb9006bd9', 150, N'om\test', CAST(0x0000A63D00DC02A8 AS DateTime), N'N')
INSERT [dbo].[BrokenRiceStockInfo] ([BrokenRiceStockID], [BrokenRiceTypeID], [CustID], [UnitsTypeID], [TotalBags], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (N'HTBR201607120405a66869f748', N'PT201606225efc7ab2111f9f', N'om', N'BT2016062280517d7e42e848', 4, N'om\test', CAST(0x0000A64100AC407C AS DateTime), N'N')
/****** Object:  Table [dbo].[BagStockInfo]    Script Date: 07/12/2016 18:45:08 ******/
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
	[MRiceBrandID] [nvarchar](50) NOT NULL,
	[TotalBags] [int] NOT NULL,
 CONSTRAINT [PK_BagStockInfo] PRIMARY KEY CLUSTERED 
(
	[BagStockID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[BagStockInfo] ([BagStockID], [SellerID], [CustID], [VehicalNo], [PurchaseDate], [LastModifiedBy], [LastModifiedDate], [ObsInd], [DriverName], [Price], [UnitsTypeID], [MRiceBrandID], [TotalBags]) VALUES (N'BS201606220502f2657b1e54', N'SE20160622c1cb3d515c67b0', N'om', N'KA 41 E1720', CAST(0x0000A62D00000000 AS DateTime), N'om\test', CAST(0x0000A62D011A77B8 AS DateTime), N'N', N'MAHESH', 20.0000, N'BT2016062293b86dbabd294f', N'RB2016062245b890084762d1', 100)
INSERT [dbo].[BagStockInfo] ([BagStockID], [SellerID], [CustID], [VehicalNo], [PurchaseDate], [LastModifiedBy], [LastModifiedDate], [ObsInd], [DriverName], [Price], [UnitsTypeID], [MRiceBrandID], [TotalBags]) VALUES (N'BS20160622354b0f0e20d32b', N'SE201606222f083db882c20b', N'om', N'KA 41 E1720', CAST(0x0000A62D00000000 AS DateTime), N'om\test', CAST(0x0000A62D011A141C AS DateTime), N'N', N'ganga', 20.0000, N'BT2016062293b86dbabd294f', N'RB2016062203979664e4dc44', 2000)
INSERT [dbo].[BagStockInfo] ([BagStockID], [SellerID], [CustID], [VehicalNo], [PurchaseDate], [LastModifiedBy], [LastModifiedDate], [ObsInd], [DriverName], [Price], [UnitsTypeID], [MRiceBrandID], [TotalBags]) VALUES (N'BS20160622f3dc0f67d20b65', N'SE201606220b3a84f3cd30e1', N'om', N'KA 41 E1720', CAST(0x0000A62D00000000 AS DateTime), N'om\test', CAST(0x0000A62D0119BE90 AS DateTime), N'N', N'MAHESH', 10.0000, N'BT2016062286029cb9006bd9', N'RB2016062245b890084762d1', 5000)
/****** Object:  Table [dbo].[BagPaymentInfo]    Script Date: 07/12/2016 18:45:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[BagPaymentInfo](
	[BagPaymentID] [nvarchar](50) NOT NULL,
	[CustID] [nvarchar](50) NOT NULL,
	[SellerID] [nvarchar](50) NOT NULL,
	[AmountPaid] [money] NOT NULL,
	[PaidDate] [datetime] NOT NULL,
	[HandoverTo] [nvarchar](50) NULL,
	[NextPaymentDate] [datetime] NOT NULL,
	[PaymentMode] [nvarchar](20) NOT NULL,
	[ChequeNo] [nvarchar](50) NULL,
	[BankName] [nvarchar](50) NULL,
	[LastModifiedBy] [nvarchar](50) NOT NULL,
	[LastModifiedDate] [datetime] NOT NULL,
	[ObsInd] [char](1) NOT NULL,
 CONSTRAINT [PK_BagPaymentInfo] PRIMARY KEY CLUSTERED 
(
	[BagPaymentID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[BagPaymentInfo] ([BagPaymentID], [CustID], [SellerID], [AmountPaid], [PaidDate], [HandoverTo], [NextPaymentDate], [PaymentMode], [ChequeNo], [BankName], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (N'BP201606239be6524c22341a', N'om', N'SE201606220b3a84f3cd30e1', 20000.0000, CAST(0x0000A62E00E58BAC AS DateTime), N'Hari', CAST(0x0000A62E00E58BAC AS DateTime), N'Cash', N'', N'', N'om\test', CAST(0x0000A62E00E6139C AS DateTime), N'N')
/****** Object:  Table [dbo].[ExpenseTransaction]    Script Date: 07/12/2016 18:45:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ExpenseTransaction](
	[ExpenseTransID] [nvarchar](50) NOT NULL,
	[CustID] [nvarchar](50) NOT NULL,
	[ExpenseID] [nvarchar](50) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Amount] [money] NOT NULL,
	[Reason] [nvarchar](400) NULL,
	[LastModifiedBy] [nvarchar](50) NOT NULL,
	[LastModifiedDate] [datetime] NOT NULL,
	[ObsInd] [char](1) NOT NULL,
	[PayDate] [datetime] NOT NULL,
 CONSTRAINT [PK_ExpenseTransaction] PRIMARY KEY CLUSTERED 
(
	[ExpenseTransID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[ExpenseTransaction] ([ExpenseTransID], [CustID], [ExpenseID], [Name], [Amount], [Reason], [LastModifiedBy], [LastModifiedDate], [ObsInd], [PayDate]) VALUES (N'ExT20160712357ee7343aef35', N'om', N'ET201607121d482a9bd62156', N'Nagavardhan', 2000.0000, N'nothing', N'om\test', CAST(0x0000A6410112BA14 AS DateTime), N'N', CAST(0x0000A6D501129B9C AS DateTime))
/****** Object:  Table [dbo].[EmployeeSalary]    Script Date: 07/12/2016 18:45:08 ******/
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
INSERT [dbo].[EmployeeSalary] ([EmpSalaryID], [CustID], [EmployeeID], [MSalaryTypeID], [MEmpDsgID], [Salary], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (N'ES20160622ad153f04245a10', N'om', N'EI20160622b4e1bdd7d5ca6a', N'ST2016062266ffe779482d4b', N'EI201606221e80816e08a0c6', 10000.0000, N'om\test', CAST(0x0000A62D00AF0578 AS DateTime), N'N')
/****** Object:  Table [dbo].[MoneyTransaction]    Script Date: 07/12/2016 18:45:08 ******/
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
/****** Object:  Table [dbo].[MLotDetails]    Script Date: 07/12/2016 18:45:08 ******/
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
INSERT [dbo].[MLotDetails] ([MLotID], [CustID], [LotName], [LastModifiedBy], [LastModifiedDate], [ObsInd], [MGodownID]) VALUES (N'LT2016062211490792a69a92', N'om', N'G1L2', N'om\test', CAST(0x0000A62D00ADA714 AS DateTime), N'N', N'GD2016062238d905b1abc0ed')
INSERT [dbo].[MLotDetails] ([MLotID], [CustID], [LotName], [LastModifiedBy], [LastModifiedDate], [ObsInd], [MGodownID]) VALUES (N'LT201606221748367b1277f8', N'om', N'G1L1', N'om\test', CAST(0x0000A62D00ADA264 AS DateTime), N'N', N'GD2016062238d905b1abc0ed')
INSERT [dbo].[MLotDetails] ([MLotID], [CustID], [LotName], [LastModifiedBy], [LastModifiedDate], [ObsInd], [MGodownID]) VALUES (N'LT2016062281b3c563673d43', N'om', N'G2L2', N'om\test', CAST(0x0000A62D00ADAF48 AS DateTime), N'N', N'GD201606222ab20bc53f6828')
INSERT [dbo].[MLotDetails] ([MLotID], [CustID], [LotName], [LastModifiedBy], [LastModifiedDate], [ObsInd], [MGodownID]) VALUES (N'LT20160622a54885e9583ceb', N'om', N'G2L1', N'om\test', CAST(0x0000A62D00ADB3F8 AS DateTime), N'N', N'GD201606222ab20bc53f6828')
INSERT [dbo].[MLotDetails] ([MLotID], [CustID], [LotName], [LastModifiedBy], [LastModifiedDate], [ObsInd], [MGodownID]) VALUES (N'LT20160706447203c2746604', N'om1', N'G1L2', N'om1\test', CAST(0x0000A63B00FBADB0 AS DateTime), N'N', N'GD201607066c7e9e984467f6')
INSERT [dbo].[MLotDetails] ([MLotID], [CustID], [LotName], [LastModifiedBy], [LastModifiedDate], [ObsInd], [MGodownID]) VALUES (N'LT201607067bb7ceec9d5f11', N'om1', N'G1L1', N'om1\test', CAST(0x0000A63B00FBB968 AS DateTime), N'N', N'GD201607066c7e9e984467f6')
INSERT [dbo].[MLotDetails] ([MLotID], [CustID], [LotName], [LastModifiedBy], [LastModifiedDate], [ObsInd], [MGodownID]) VALUES (N'LT20160708d9720a41d74d17', N'om', N'G3L3', N'om\test', CAST(0x0000A63D0124E414 AS DateTime), N'N', N'GD2016070804cbde9df991f4')
/****** Object:  Table [dbo].[ProductPaymentInfo]    Script Date: 07/12/2016 18:45:08 ******/
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
	[BuyerID] [nvarchar](50) NOT NULL,
	[MediatorID] [nvarchar](50) NULL,
 CONSTRAINT [PK_ProductPaymentInfo] PRIMARY KEY CLUSTERED 
(
	[ProductPaymentID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[ProductPaymentInfo] ([ProductPaymentID], [CustID], [TotalAmount], [Status], [LastModifiedBy], [LastModifiedDate], [ObsInd], [BuyerID], [MediatorID]) VALUES (N'PP20160623c02094b5b3f01a', N'om', 240000.0000, N'P', N'om\test', CAST(0x0000A62E0101F1FC AS DateTime), N'N', N'BI201606231ddde313f3a96c', N'BI201606231ddde313f3a96c')
INSERT [dbo].[ProductPaymentInfo] ([ProductPaymentID], [CustID], [TotalAmount], [Status], [LastModifiedBy], [LastModifiedDate], [ObsInd], [BuyerID], [MediatorID]) VALUES (N'PP201607049e73908144e5e2', N'om', 170000.0000, N'P', N'om\test', CAST(0x0000A639016EBDF0 AS DateTime), N'N', N'BI201606231ddde313f3a96c', N'BI201607048d5a570e9b919e')
INSERT [dbo].[ProductPaymentInfo] ([ProductPaymentID], [CustID], [TotalAmount], [Status], [LastModifiedBy], [LastModifiedDate], [ObsInd], [BuyerID], [MediatorID]) VALUES (N'PP2016070833eb2e646c93d1', N'om', 1800000.0000, N'P', N'om\test', CAST(0x0000A63D00DEA800 AS DateTime), N'N', N'BI201606231ddde313f3a96c', N'BI201606231ddde313f3a96c')
/****** Object:  Table [dbo].[RiceStockInfo]    Script Date: 07/12/2016 18:45:08 ******/
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
INSERT [dbo].[RiceStockInfo] ([RiceStockID], [MRiceProdTypeID], [MRiceBrandID], [CustID], [UnitsTypeID], [TotalBags], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (N'HTR2016062298f5822356e6e6', N'RP20160622c05ec2d94f9b8e', N'RB2016062245b890084762d1', N'om', N'BT2016062286029cb9006bd9', 320, N'om\test', CAST(0x0000A62D01194E10 AS DateTime), N'N')
INSERT [dbo].[RiceStockInfo] ([RiceStockID], [MRiceProdTypeID], [MRiceBrandID], [CustID], [UnitsTypeID], [TotalBags], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (N'HTR20160622b323ea4dfe984f', N'RP20160622c05ec2d94f9b8e', N'RB2016062203979664e4dc44', N'om', N'BT2016062286029cb9006bd9', 320, N'om\test', CAST(0x0000A62D01194E10 AS DateTime), N'N')
INSERT [dbo].[RiceStockInfo] ([RiceStockID], [MRiceProdTypeID], [MRiceBrandID], [CustID], [UnitsTypeID], [TotalBags], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (N'HTR20160627ef92bf4be49265', N'RP2016062294b63a1e91a242', N'RB2016062245b890084762d1', N'om', N'BT2016062286029cb9006bd9', 620, N'om\test', CAST(0x0000A63200F9EF34 AS DateTime), N'N')
INSERT [dbo].[RiceStockInfo] ([RiceStockID], [MRiceProdTypeID], [MRiceBrandID], [CustID], [UnitsTypeID], [TotalBags], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (N'HTR201607060777f7a3a70fb7', N'RP2016062294b63a1e91a242', N'RB2016062245b890084762d1', N'om', N'BT2016062286029cb9006bd9', 550, N'om\test', CAST(0x0000A63B00A1CBEC AS DateTime), N'N')
INSERT [dbo].[RiceStockInfo] ([RiceStockID], [MRiceProdTypeID], [MRiceBrandID], [CustID], [UnitsTypeID], [TotalBags], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (N'HTR20160706ed7a64cc1398d9', N'RP2016062294b63a1e91a242', N'RB2016062245b890084762d1', N'om', N'BT2016062286029cb9006bd9', 550, N'om\test', CAST(0x0000A63B00A7C790 AS DateTime), N'N')
INSERT [dbo].[RiceStockInfo] ([RiceStockID], [MRiceProdTypeID], [MRiceBrandID], [CustID], [UnitsTypeID], [TotalBags], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (N'HTR2016070829a33e76759728', N'RP2016062294b63a1e91a242', N'RB2016062245b890084762d1', N'om', N'BT2016062286029cb9006bd9', 400, N'om\test', CAST(0x0000A63D00DC02A8 AS DateTime), N'N')
INSERT [dbo].[RiceStockInfo] ([RiceStockID], [MRiceProdTypeID], [MRiceBrandID], [CustID], [UnitsTypeID], [TotalBags], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (N'HTR2016071263072dd21ded4a', N'RP2016062294b63a1e91a242', N'RB2016062245b890084762d1', N'om', N'BT2016062286029cb9006bd9', 550, N'om\test', CAST(0x0000A64100ABB508 AS DateTime), N'N')
/****** Object:  Table [dbo].[RentalHulling]    Script Date: 07/12/2016 18:45:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[RentalHulling](
	[RentalHulingID] [nvarchar](50) NOT NULL,
	[CustID] [nvarchar](50) NOT NULL,
	[JobWorkID] [nvarchar](50) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[PaddyType] [nvarchar](30) NOT NULL,
	[TotalBags] [int] NOT NULL,
	[Price] [money] NOT NULL,
	[ProcessedDate] [datetime] NOT NULL,
	[LastModifiedBy] [nvarchar](50) NOT NULL,
	[LastModifiedDate] [datetime] NOT NULL,
	[ObsInd] [char](1) NOT NULL,
 CONSTRAINT [PK_RentalHulling] PRIMARY KEY CLUSTERED 
(
	[RentalHulingID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[RentalHulling] ([RentalHulingID], [CustID], [JobWorkID], [Name], [PaddyType], [TotalBags], [Price], [ProcessedDate], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (N'RH20160712888ed49f6b6824', N'om', N'JW201607120695fd7e5cd426', N'Nagavardhan', N'Sona', 200, 12000.0000, CAST(0x0000A6D501345BD8 AS DateTime), N'om\test', CAST(0x0000A6410134B290 AS DateTime), N'N')
/****** Object:  Table [dbo].[HullingProcess]    Script Date: 07/12/2016 18:45:08 ******/
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
INSERT [dbo].[HullingProcess] ([HullingProcessID], [PaddyTypeID], [CustID], [UnitsTypeID], [TotalBags], [ProcessDate], [ProcessedBy], [LastModifiedBy], [LastModifiedDate], [ObsInd], [Status], [MGodownID], [MLotID], [Price]) VALUES (N'HP20160622040b6470594e33', N'PT20160622169200ade91e3b', N'om', N'BT2016062280517d7e42e848', 260, CAST(0x0000A63100000000 AS DateTime), N'Nagavardhan', N'om\test', CAST(0x0000A62D01194E10 AS DateTime), N'N', N'A', N'GD2016062238d905b1abc0ed', N'LT201606221748367b1277f8', 1200.0000)
INSERT [dbo].[HullingProcess] ([HullingProcessID], [PaddyTypeID], [CustID], [UnitsTypeID], [TotalBags], [ProcessDate], [ProcessedBy], [LastModifiedBy], [LastModifiedDate], [ObsInd], [Status], [MGodownID], [MLotID], [Price]) VALUES (N'HP20160622ebc21610148f65', N'PT20160622e57004fb19fc80', N'om', N'BT2016062280517d7e42e848', 260, CAST(0x0000A3A300000000 AS DateTime), N'Harshavardhan', N'om\test', CAST(0x0000A63200F9EF34 AS DateTime), N'N', N'A', N'GD201606222ab20bc53f6828', N'LT2016062281b3c563673d43', 1200.0000)
INSERT [dbo].[HullingProcess] ([HullingProcessID], [PaddyTypeID], [CustID], [UnitsTypeID], [TotalBags], [ProcessDate], [ProcessedBy], [LastModifiedBy], [LastModifiedDate], [ObsInd], [Status], [MGodownID], [MLotID], [Price]) VALUES (N'HP20160628a576d61d86e8e2', N'PT201606225c6dce2fadc060', N'om', N'BT2016062280517d7e42e848', 260, CAST(0x0000A63300A79658 AS DateTime), N'Harish Kumar', N'om\test', CAST(0x0000A63B00A7E02C AS DateTime), N'N', N'A', N'GD2016062238d905b1abc0ed', N'LT201606221748367b1277f8', 1200.0000)
INSERT [dbo].[HullingProcess] ([HullingProcessID], [PaddyTypeID], [CustID], [UnitsTypeID], [TotalBags], [ProcessDate], [ProcessedBy], [LastModifiedBy], [LastModifiedDate], [ObsInd], [Status], [MGodownID], [MLotID], [Price]) VALUES (N'HP20160708edcec591a3d15b', N'PT20160622e57004fb19fc80', N'om', N'BT2016062280517d7e42e848', 260, CAST(0x0000A65B00000000 AS DateTime), N'Nagesh', N'om\test', CAST(0x0000A63D00DC02A8 AS DateTime), N'N', N'A', N'GD201606222ab20bc53f6828', N'LT2016062281b3c563673d43', 2400.0000)
INSERT [dbo].[HullingProcess] ([HullingProcessID], [PaddyTypeID], [CustID], [UnitsTypeID], [TotalBags], [ProcessDate], [ProcessedBy], [LastModifiedBy], [LastModifiedDate], [ObsInd], [Status], [MGodownID], [MLotID], [Price]) VALUES (N'HP20160712d3ff9b16a0b722', N'PT20160622e57004fb19fc80', N'om', N'BT2016062280517d7e42e848', 260, CAST(0x0000A6D500A79658 AS DateTime), N'Hari', N'om\test', CAST(0x0000A64100AC4B08 AS DateTime), N'N', N'A', N'GD201606222ab20bc53f6828', N'LT2016062281b3c563673d43', 1200.0000)
/****** Object:  Table [dbo].[ProductSellingInfo]    Script Date: 07/12/2016 18:45:08 ******/
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
	[MediatorID] [nvarchar](50) NULL,
 CONSTRAINT [PK_ProductSellingInfo] PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[ProductSellingInfo] ([ProductID], [BuyerID], [MRiceProdTypeID], [MRiceBrandID], [BrokenRiceTypeID], [CustID], [UnitsTypeID], [ProductPaymentID], [SellingDate], [Price], [SellingProductType], [LastModifiedBy], [LastModifiedDate], [ObsInd], [TotalBags], [MediatorID]) VALUES (N'PI20160623d4d44ef2373ee9', N'BI201606231ddde313f3a96c', N'RP20160622c05ec2d94f9b8e', N'RB2016062245b890084762d1', NULL, N'om', N'BT2016062286029cb9006bd9', N'PP20160623c02094b5b3f01a', CAST(0x0000A6BB00000000 AS DateTime), 1200.0000, NULL, N'om\test', CAST(0x0000A62E0101F580 AS DateTime), N'N', 200, N'BI201606231ddde313f3a96c')
INSERT [dbo].[ProductSellingInfo] ([ProductID], [BuyerID], [MRiceProdTypeID], [MRiceBrandID], [BrokenRiceTypeID], [CustID], [UnitsTypeID], [ProductPaymentID], [SellingDate], [Price], [SellingProductType], [LastModifiedBy], [LastModifiedDate], [ObsInd], [TotalBags], [MediatorID]) VALUES (N'PI20160704d3facb59676512', N'BI201606231ddde313f3a96c', N'RP2016062294b63a1e91a242', N'RB2016062245b890084762d1', NULL, N'om', N'BT2016062286029cb9006bd9', N'PP201607049e73908144e5e2', CAST(0x0000A5E1016E903C AS DateTime), 850.0000, NULL, N'om\test', CAST(0x0000A639016EBDF0 AS DateTime), N'N', 200, N'BI201607048d5a570e9b919e')
INSERT [dbo].[ProductSellingInfo] ([ProductID], [BuyerID], [MRiceProdTypeID], [MRiceBrandID], [BrokenRiceTypeID], [CustID], [UnitsTypeID], [ProductPaymentID], [SellingDate], [Price], [SellingProductType], [LastModifiedBy], [LastModifiedDate], [ObsInd], [TotalBags], [MediatorID]) VALUES (N'PI20160708c6b75fd28522c7', N'BI201606231ddde313f3a96c', N'RP2016062294b63a1e91a242', N'RB2016062245b890084762d1', NULL, N'om', N'BT2016062286029cb9006bd9', N'PP2016070833eb2e646c93d1', CAST(0x0000A65B00DE03F0 AS DateTime), 2000.0000, NULL, N'om\test', CAST(0x0000A63D00DEA800 AS DateTime), N'N', 900, N'BI201606231ddde313f3a96c')
/****** Object:  Table [dbo].[ProductPaymentTransaction]    Script Date: 07/12/2016 18:45:08 ******/
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
	[ReceivedAmount] [money] NOT NULL,
	[PaymentDueDate] [datetime] NULL,
	[LastModifiedBy] [nvarchar](50) NOT NULL,
	[LastModifiedDate] [datetime] NOT NULL,
	[ObsInd] [char](1) NOT NULL,
	[BuyerID] [nvarchar](50) NOT NULL,
	[MediatorID] [nvarchar](50) NULL,
 CONSTRAINT [PK_ProductPaymentTransaction] PRIMARY KEY CLUSTERED 
(
	[ProductPaymentTranID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[ProductPaymentTransaction] ([ProductPaymentTranID], [ProductPaymentID], [CustID], [Paymentmode], [ChequeNo], [DDNo], [BankName], [ReceivedAmount], [PaymentDueDate], [LastModifiedBy], [LastModifiedDate], [ObsInd], [BuyerID], [MediatorID]) VALUES (N'PP201606233b7c1c1aed575f', N'PP20160623c02094b5b3f01a', N'om', N'Cash', N'', N'', N'', 120000.0000, CAST(0x0000A6DA00000000 AS DateTime), N'om\test', CAST(0x0000A62E01053C90 AS DateTime), N'N', N'BI201606231ddde313f3a96c', N'BI201606231ddde313f3a96c')
INSERT [dbo].[ProductPaymentTransaction] ([ProductPaymentTranID], [ProductPaymentID], [CustID], [Paymentmode], [ChequeNo], [DDNo], [BankName], [ReceivedAmount], [PaymentDueDate], [LastModifiedBy], [LastModifiedDate], [ObsInd], [BuyerID], [MediatorID]) VALUES (N'PP20160623470350af5e1b9f', N'PP20160623c02094b5b3f01a', N'om', N'Cash', N'', N'', N'', 60000.0000, CAST(0x0000A6BB00000000 AS DateTime), N'om\test', CAST(0x0000A62E01061EBC AS DateTime), N'N', N'BI201606231ddde313f3a96c', N'BI201606231ddde313f3a96c')
INSERT [dbo].[ProductPaymentTransaction] ([ProductPaymentTranID], [ProductPaymentID], [CustID], [Paymentmode], [ChequeNo], [DDNo], [BankName], [ReceivedAmount], [PaymentDueDate], [LastModifiedBy], [LastModifiedDate], [ObsInd], [BuyerID], [MediatorID]) VALUES (N'PP2016062752b6ed9b680e7d', N'PP20160623c02094b5b3f01a', N'om', N'Cash', N'', N'', N'', 50000.0000, CAST(0x0000A63200FF5604 AS DateTime), N'om\test', CAST(0x0000A63200FFA5B4 AS DateTime), N'N', N'BI201606231ddde313f3a96c', N'BI201606231ddde313f3a96c')
INSERT [dbo].[ProductPaymentTransaction] ([ProductPaymentTranID], [ProductPaymentID], [CustID], [Paymentmode], [ChequeNo], [DDNo], [BankName], [ReceivedAmount], [PaymentDueDate], [LastModifiedBy], [LastModifiedDate], [ObsInd], [BuyerID], [MediatorID]) VALUES (N'PP20160704a95ac288960073', N'PP201607049e73908144e5e2', N'om', N'Cash', N'', N'', N'', 90000.0000, CAST(0x0000A5E101707A14 AS DateTime), N'om\test', CAST(0x0000A63901709AE4 AS DateTime), N'N', N'BI201606231ddde313f3a96c', N'BI201607048d5a570e9b919e')
/****** Object:  Table [dbo].[PaddyStockInfo]    Script Date: 07/12/2016 18:45:08 ******/
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
	[VehicalNo] [nvarchar](20) NOT NULL,
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
INSERT [dbo].[PaddyStockInfo] ([PaddyStockID], [SellerID], [PaddyTypeID], [CustID], [MGodownID], [MLotID], [VehicalNo], [PurchaseDate], [LastModifiedBy], [LastModifiedDate], [ObsInd], [DriverName], [Price], [UnitsTypeID], [TotalBags]) VALUES (N'PS2016062202756160bc7582', N'SE201606223f7f4282c244bc', N'PT20160622169200ade91e3b', N'om', N'GD2016062238d905b1abc0ed', N'LT201606221748367b1277f8', N'ka01d2342', CAST(0x0000A62D01103B68 AS DateTime), N'om\test', CAST(0x0000A62D01108D70 AS DateTime), N'N', N'Bhasha', 1000.0000, N'BT2016062280517d7e42e848', 900)
INSERT [dbo].[PaddyStockInfo] ([PaddyStockID], [SellerID], [PaddyTypeID], [CustID], [MGodownID], [MLotID], [VehicalNo], [PurchaseDate], [LastModifiedBy], [LastModifiedDate], [ObsInd], [DriverName], [Price], [UnitsTypeID], [TotalBags]) VALUES (N'PS201606220a9d273a56eed1', N'SE201606220b3925470520d8', N'PT20160622e2a79f4e7cac16', N'om', N'GD2016062238d905b1abc0ed', N'LT201606221748367b1277f8', N'ka10h2342', CAST(0x0000A62D00B85894 AS DateTime), N'om\test', CAST(0x0000A62D0110BEA8 AS DateTime), N'N', N'Mahesh', 1000.0000, N'BT2016062280517d7e42e848', 900)
INSERT [dbo].[PaddyStockInfo] ([PaddyStockID], [SellerID], [PaddyTypeID], [CustID], [MGodownID], [MLotID], [VehicalNo], [PurchaseDate], [LastModifiedBy], [LastModifiedDate], [ObsInd], [DriverName], [Price], [UnitsTypeID], [TotalBags]) VALUES (N'PS20160622178293e1262a22', N'SE201606221183000ebe5070', N'PT20160622169200ade91e3b', N'om', N'GD2016062238d905b1abc0ed', N'LT201606221748367b1277f8', N'ka01d2342', CAST(0x0000A62D010E7134 AS DateTime), N'om\test', CAST(0x0000A62D010EE2E0 AS DateTime), N'N', N'Bhasha', 1200.0000, N'BT2016062280517d7e42e848', 200)
INSERT [dbo].[PaddyStockInfo] ([PaddyStockID], [SellerID], [PaddyTypeID], [CustID], [MGodownID], [MLotID], [VehicalNo], [PurchaseDate], [LastModifiedBy], [LastModifiedDate], [ObsInd], [DriverName], [Price], [UnitsTypeID], [TotalBags]) VALUES (N'PS201606224902085f026abb', N'SE20160622b1ba4d7f21a84c', N'PT20160622169200ade91e3b', N'om', N'GD2016062238d905b1abc0ed', N'LT201606221748367b1277f8', N'KA41E1720', CAST(0x0000A62D00B80FEC AS DateTime), N'om\test', CAST(0x0000A62D01131C84 AS DateTime), N'N', N'Mahesh', 1111.0000, N'BT2016062280517d7e42e848', 100)
INSERT [dbo].[PaddyStockInfo] ([PaddyStockID], [SellerID], [PaddyTypeID], [CustID], [MGodownID], [MLotID], [VehicalNo], [PurchaseDate], [LastModifiedBy], [LastModifiedDate], [ObsInd], [DriverName], [Price], [UnitsTypeID], [TotalBags]) VALUES (N'PS201606225b84399ff5b5b5', N'SE20160622b1ba4d7f21a84c', N'PT201606225c6dce2fadc060', N'om', N'GD2016062238d905b1abc0ed', N'LT2016062211490792a69a92', N'ka01d2342', CAST(0x0000A62D0111CE88 AS DateTime), N'om\test', CAST(0x0000A62D0111FC3C AS DateTime), N'N', N'Bhasha', 1000.0000, N'BT2016062280517d7e42e848', 100)
INSERT [dbo].[PaddyStockInfo] ([PaddyStockID], [SellerID], [PaddyTypeID], [CustID], [MGodownID], [MLotID], [VehicalNo], [PurchaseDate], [LastModifiedBy], [LastModifiedDate], [ObsInd], [DriverName], [Price], [UnitsTypeID], [TotalBags]) VALUES (N'PS201606226523c13acf3f5d', N'SE201606224d27c9d452edf7', N'PT201606225c6dce2fadc060', N'om', N'GD201606222ab20bc53f6828', N'LT20160622a54885e9583ceb', N'ka34s1235', CAST(0x0000A62D00B85894 AS DateTime), N'om\test', CAST(0x0000A62D010F629C AS DateTime), N'N', N'Muthu', 1100.0000, N'BT2016062280517d7e42e848', 200)
INSERT [dbo].[PaddyStockInfo] ([PaddyStockID], [SellerID], [PaddyTypeID], [CustID], [MGodownID], [MLotID], [VehicalNo], [PurchaseDate], [LastModifiedBy], [LastModifiedDate], [ObsInd], [DriverName], [Price], [UnitsTypeID], [TotalBags]) VALUES (N'PS20160622786f954c1e67a3', N'SE201606223f7f4282c244bc', N'PT20160622e2a79f4e7cac16', N'om', N'GD2016062238d905b1abc0ed', N'LT201606221748367b1277f8', N'ka16w1235', CAST(0x0000A62D00B55324 AS DateTime), N'om\test', CAST(0x0000A62D010F9E60 AS DateTime), N'N', N'Muthu', 1400.0000, N'BT2016062280517d7e42e848', 200)
INSERT [dbo].[PaddyStockInfo] ([PaddyStockID], [SellerID], [PaddyTypeID], [CustID], [MGodownID], [MLotID], [VehicalNo], [PurchaseDate], [LastModifiedBy], [LastModifiedDate], [ObsInd], [DriverName], [Price], [UnitsTypeID], [TotalBags]) VALUES (N'PS20160622b5ad2151646470', N'SE201606220b3a84f3cd30e1', N'PT20160622169200ade91e3b', N'om', N'GD2016062238d905b1abc0ed', N'LT2016062211490792a69a92', N'ka34s1235', CAST(0x0000A62D00A79658 AS DateTime), N'om\test', CAST(0x0000A62D010F3290 AS DateTime), N'N', N'Mahesh', 1320.0000, N'BT2016062280517d7e42e848', 200)
INSERT [dbo].[PaddyStockInfo] ([PaddyStockID], [SellerID], [PaddyTypeID], [CustID], [MGodownID], [MLotID], [VehicalNo], [PurchaseDate], [LastModifiedBy], [LastModifiedDate], [ObsInd], [DriverName], [Price], [UnitsTypeID], [TotalBags]) VALUES (N'PS20160622b5df1648a26763', N'SE20160622fdafc534b48d96', N'PT20160622e2a79f4e7cac16', N'om', N'GD201606222ab20bc53f6828', N'LT2016062281b3c563673d43', N'ka01d2342', CAST(0x0000A62D00B85894 AS DateTime), N'om\test', CAST(0x0000A62D01100328 AS DateTime), N'N', N'qeqweqe', 1111.0000, N'BT2016062280517d7e42e848', 200)
INSERT [dbo].[PaddyStockInfo] ([PaddyStockID], [SellerID], [PaddyTypeID], [CustID], [MGodownID], [MLotID], [VehicalNo], [PurchaseDate], [LastModifiedBy], [LastModifiedDate], [ObsInd], [DriverName], [Price], [UnitsTypeID], [TotalBags]) VALUES (N'PS20160622caebecd729d17d', N'SE201606220b3a84f3cd30e1', N'PT20160622e57004fb19fc80', N'om', N'GD201606222ab20bc53f6828', N'LT2016062281b3c563673d43', N'ka03e4432', CAST(0x0000A62D01118838 AS DateTime), N'om\test', CAST(0x0000A62D0111A584 AS DateTime), N'N', N'Raju', 1000.0000, N'BT2016062280517d7e42e848', 900)
INSERT [dbo].[PaddyStockInfo] ([PaddyStockID], [SellerID], [PaddyTypeID], [CustID], [MGodownID], [MLotID], [VehicalNo], [PurchaseDate], [LastModifiedBy], [LastModifiedDate], [ObsInd], [DriverName], [Price], [UnitsTypeID], [TotalBags]) VALUES (N'PS20160622e5ae9bd71df594', N'SE201606223f7f4282c244bc', N'PT201606225c6dce2fadc060', N'om', N'GD2016062238d905b1abc0ed', N'LT201606221748367b1277f8', N'ka16w1235', CAST(0x0000A62D01114314 AS DateTime), N'om\test', CAST(0x0000A62D01117320 AS DateTime), N'N', N'Muthu', 1000.0000, N'BT2016062280517d7e42e848', 900)
INSERT [dbo].[PaddyStockInfo] ([PaddyStockID], [SellerID], [PaddyTypeID], [CustID], [MGodownID], [MLotID], [VehicalNo], [PurchaseDate], [LastModifiedBy], [LastModifiedDate], [ObsInd], [DriverName], [Price], [UnitsTypeID], [TotalBags]) VALUES (N'PS20160622e77372f566353a', N'SE20160622b1ba4d7f21a84c', N'PT20160622169200ade91e3b', N'om', N'GD201606222ab20bc53f6828', N'LT20160622a54885e9583ceb', N'ka16w1235', CAST(0x0000A62D00000000 AS DateTime), N'om\test', CAST(0x0000A62D0112A4FC AS DateTime), N'N', N'Mahesh', 1000.0000, N'BT2016062280517d7e42e848', 100)
INSERT [dbo].[PaddyStockInfo] ([PaddyStockID], [SellerID], [PaddyTypeID], [CustID], [MGodownID], [MLotID], [VehicalNo], [PurchaseDate], [LastModifiedBy], [LastModifiedDate], [ObsInd], [DriverName], [Price], [UnitsTypeID], [TotalBags]) VALUES (N'PS20160622e7b372f21d8937', N'SE201606220b3925470520d8', N'PT20160622e2a79f4e7cac16', N'om', N'GD2016062238d905b1abc0ed', N'LT2016062211490792a69a92', N'ka34s1235', CAST(0x0000A62D00B85894 AS DateTime), N'om\test', CAST(0x0000A62D0110FA6C AS DateTime), N'N', N'Bhasha', 1000.0000, N'BT2016062280517d7e42e848', 100)
INSERT [dbo].[PaddyStockInfo] ([PaddyStockID], [SellerID], [PaddyTypeID], [CustID], [MGodownID], [MLotID], [VehicalNo], [PurchaseDate], [LastModifiedBy], [LastModifiedDate], [ObsInd], [DriverName], [Price], [UnitsTypeID], [TotalBags]) VALUES (N'PS20160622f02e8ffbc39683', N'SE20160622b1ba4d7f21a84c', N'PT201606225c6dce2fadc060', N'om', N'GD201606222ab20bc53f6828', N'LT2016062281b3c563673d43', N'21313', CAST(0x0000A62D00B85894 AS DateTime), N'om\test', CAST(0x0000A62D01123800 AS DateTime), N'N', N'Mahesh', 1100.0000, N'BT2016062280517d7e42e848', 100)
INSERT [dbo].[PaddyStockInfo] ([PaddyStockID], [SellerID], [PaddyTypeID], [CustID], [MGodownID], [MLotID], [VehicalNo], [PurchaseDate], [LastModifiedBy], [LastModifiedDate], [ObsInd], [DriverName], [Price], [UnitsTypeID], [TotalBags]) VALUES (N'PS20160622f8408a1517ab0d', N'SE20160622b1ba4d7f21a84c', N'PT20160622e57004fb19fc80', N'om', N'GD201606222ab20bc53f6828', N'LT2016062281b3c563673d43', N'ka16w1235', CAST(0x0000A62D00B85894 AS DateTime), N'om\test', CAST(0x0000A62D010FD574 AS DateTime), N'N', N'Raju', 1211.0000, N'BT2016062280517d7e42e848', 200)
INSERT [dbo].[PaddyStockInfo] ([PaddyStockID], [SellerID], [PaddyTypeID], [CustID], [MGodownID], [MLotID], [VehicalNo], [PurchaseDate], [LastModifiedBy], [LastModifiedDate], [ObsInd], [DriverName], [Price], [UnitsTypeID], [TotalBags]) VALUES (N'PS20160623d92104ad20e956', N'SE20160622818a3e104bd6ae', N'PT20160622169200ade91e3b', N'om', N'GD201606222ab20bc53f6828', N'LT20160622a54885e9583ceb', N'ka16w1235', CAST(0x0000A62E00AFDAC0 AS DateTime), N'om\test', CAST(0x0000A62E00B1FBAC AS DateTime), N'N', N'raghu', 1200.0000, N'BT2016062280517d7e42e848', 200)
INSERT [dbo].[PaddyStockInfo] ([PaddyStockID], [SellerID], [PaddyTypeID], [CustID], [MGodownID], [MLotID], [VehicalNo], [PurchaseDate], [LastModifiedBy], [LastModifiedDate], [ObsInd], [DriverName], [Price], [UnitsTypeID], [TotalBags]) VALUES (N'PS20160623e1b386a52d16e4', N'SE20160622c5e10cc5277fc5', N'PT20160622169200ade91e3b', N'om', N'GD201606222ab20bc53f6828', N'LT2016062281b3c563673d43', N'ka34s1235', CAST(0x0000A62E00A4CB80 AS DateTime), N'om\test', CAST(0x0000A62E00B59CF8 AS DateTime), N'N', N'Bhasha', 1100.0000, N'BT2016062280517d7e42e848', 200)
INSERT [dbo].[PaddyStockInfo] ([PaddyStockID], [SellerID], [PaddyTypeID], [CustID], [MGodownID], [MLotID], [VehicalNo], [PurchaseDate], [LastModifiedBy], [LastModifiedDate], [ObsInd], [DriverName], [Price], [UnitsTypeID], [TotalBags]) VALUES (N'PS20160623fb2ba57ea37000', N'SE20160622c5e10cc5277fc5', N'PT20160622169200ade91e3b', N'om', N'GD201606222ab20bc53f6828', N'LT20160622a54885e9583ceb', N'ka03e4432', CAST(0x0000A62E00B41590 AS DateTime), N'om\test', CAST(0x0000A62E00B54C1C AS DateTime), N'N', N'Mahesh', 1111.0000, N'BT2016062280517d7e42e848', 200)
INSERT [dbo].[PaddyStockInfo] ([PaddyStockID], [SellerID], [PaddyTypeID], [CustID], [MGodownID], [MLotID], [VehicalNo], [PurchaseDate], [LastModifiedBy], [LastModifiedDate], [ObsInd], [DriverName], [Price], [UnitsTypeID], [TotalBags]) VALUES (N'PS2016070567af9f4bd00cad', N'SE20160622818a3e104bd6ae', N'PT20160622e57004fb19fc80', N'om', N'GD2016062238d905b1abc0ed', N'LT201606221748367b1277f8', N'KA 03 MS 4430', CAST(0x0000A5FF010988F4 AS DateTime), N'om\test', CAST(0x0000A63A010A7480 AS DateTime), N'N', N'Hari', 1000.0000, N'BT2016062280517d7e42e848', 200)
INSERT [dbo].[PaddyStockInfo] ([PaddyStockID], [SellerID], [PaddyTypeID], [CustID], [MGodownID], [MLotID], [VehicalNo], [PurchaseDate], [LastModifiedBy], [LastModifiedDate], [ObsInd], [DriverName], [Price], [UnitsTypeID], [TotalBags]) VALUES (N'PS20160712387741f5895c4c', N'SE201606220b3a84f3cd30e1', N'PT20160622169200ade91e3b', N'om', N'GD2016070804cbde9df991f4', N'LT20160708d9720a41d74d17', N'KA 03 MS 4430', CAST(0x0000A6D500A8D770 AS DateTime), N'om\test', CAST(0x0000A64100A91910 AS DateTime), N'N', N'Hari', 750.0000, N'BT2016062280517d7e42e848', 200)
INSERT [dbo].[PaddyStockInfo] ([PaddyStockID], [SellerID], [PaddyTypeID], [CustID], [MGodownID], [MLotID], [VehicalNo], [PurchaseDate], [LastModifiedBy], [LastModifiedDate], [ObsInd], [DriverName], [Price], [UnitsTypeID], [TotalBags]) VALUES (N'PS201607126d29a37541a15a', N'SE201606220b3a84f3cd30e1', N'PT20160622e57004fb19fc80', N'om', N'GD2016070804cbde9df991f4', N'LT20160708d9720a41d74d17', N'KA 03 MS 4430', CAST(0x0000A6D500A1DD80 AS DateTime), N'om\test', CAST(0x0000A64100A20FE4 AS DateTime), N'N', N'mahesh', 150000.0000, N'BT2016062280517d7e42e848', 200)
/****** Object:  Table [dbo].[PaddyPaymentDetails]    Script Date: 07/12/2016 18:45:08 ******/
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
INSERT [dbo].[PaddyPaymentDetails] ([PaddyPaymentID], [SellerID], [CustID], [AmountPaid], [PaidDate], [HandoverTo], [NextPaymentDate], [LastModifiedBy], [LastModifiedDate], [ObsInd], [PaddyStockID], [PaymentMode], [ChequeNo], [BankName]) VALUES (N'PP201606250c65b4b9064561', N'SE201606223f7f4282c244bc', N'om', 100000.0000, CAST(0x0000A63000F2D21C AS DateTime), N'', CAST(0x0000A63F01709B8E AS DateTime), N'om\test', CAST(0x0000A63000F2F79C AS DateTime), N'N', NULL, N'', N'', N'')
INSERT [dbo].[PaddyPaymentDetails] ([PaddyPaymentID], [SellerID], [CustID], [AmountPaid], [PaidDate], [HandoverTo], [NextPaymentDate], [LastModifiedBy], [LastModifiedDate], [ObsInd], [PaddyStockID], [PaymentMode], [ChequeNo], [BankName]) VALUES (N'PP20160625f9e5e437512c99', N'SE201606223f7f4282c244bc', N'om', 100000.0000, CAST(0x0000A63000F32C58 AS DateTime), N'', CAST(0x0000A64901709B8F AS DateTime), N'om\test', CAST(0x0000A63000F344F4 AS DateTime), N'N', NULL, N'Cash', N'', N'')
INSERT [dbo].[PaddyPaymentDetails] ([PaddyPaymentID], [SellerID], [CustID], [AmountPaid], [PaidDate], [HandoverTo], [NextPaymentDate], [LastModifiedBy], [LastModifiedDate], [ObsInd], [PaddyStockID], [PaymentMode], [ChequeNo], [BankName]) VALUES (N'PP2016070830f532d5976800', N'SE20160622818a3e104bd6ae', N'om', 25000.0000, CAST(0x0000A65B00DA62A4 AS DateTime), N'ramesh', CAST(0x0000A65B00DA62A4 AS DateTime), N'om\test', CAST(0x0000A63D00DAB254 AS DateTime), N'N', NULL, N'Cash', N'', N'')
/****** Object:  Table [dbo].[HullingTransaction]    Script Date: 07/12/2016 18:45:08 ******/
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
INSERT [dbo].[HullingTransaction] ([HullingTransID], [HullingProcessID], [MRiceProdTypeID], [BrokenRiceTypeID], [CustID], [UnitsTypeID], [TotalBags], [Price], [LastModifiedBy], [LastModifiedDate], [ObsInd], [MRiceBrandID]) VALUES (N'HTBR20160622138a2494bce843', N'HP20160622040b6470594e33', NULL, N'PT201606229b4d4e400c959f', N'om', N'BT2016062293b86dbabd294f', 4, 1000.0000, N'om\test', CAST(0x0000A62D01194E10 AS DateTime), N'N', NULL)
INSERT [dbo].[HullingTransaction] ([HullingTransID], [HullingProcessID], [MRiceProdTypeID], [BrokenRiceTypeID], [CustID], [UnitsTypeID], [TotalBags], [Price], [LastModifiedBy], [LastModifiedDate], [ObsInd], [MRiceBrandID]) VALUES (N'HTBR20160622d467a498bc8341', N'HP20160622040b6470594e33', NULL, N'PT201606225efc7ab2111f9f', N'om', N'BT2016062293b86dbabd294f', 4, 2344.0000, N'om\test', CAST(0x0000A62D01194E10 AS DateTime), N'N', NULL)
INSERT [dbo].[HullingTransaction] ([HullingTransID], [HullingProcessID], [MRiceProdTypeID], [BrokenRiceTypeID], [CustID], [UnitsTypeID], [TotalBags], [Price], [LastModifiedBy], [LastModifiedDate], [ObsInd], [MRiceBrandID]) VALUES (N'HTBR20160627768f226d533d28', N'HP20160622ebc21610148f65', NULL, N'PT201606225efc7ab2111f9f', N'om', N'BT201606224dcfa31d81fc00', 4, 2500.0000, N'om\test', CAST(0x0000A63200F9EF34 AS DateTime), N'N', NULL)
INSERT [dbo].[HullingTransaction] ([HullingTransID], [HullingProcessID], [MRiceProdTypeID], [BrokenRiceTypeID], [CustID], [UnitsTypeID], [TotalBags], [Price], [LastModifiedBy], [LastModifiedDate], [ObsInd], [MRiceBrandID]) VALUES (N'HTBR20160706dbce0d19aae398', N'HP20160628a576d61d86e8e2', NULL, N'PT201606225efc7ab2111f9f', N'om', N'BT2016062280517d7e42e848', 4, 1000.0000, N'om\test', CAST(0x0000A63B00A7CE98 AS DateTime), N'N', NULL)
INSERT [dbo].[HullingTransaction] ([HullingTransID], [HullingProcessID], [MRiceProdTypeID], [BrokenRiceTypeID], [CustID], [UnitsTypeID], [TotalBags], [Price], [LastModifiedBy], [LastModifiedDate], [ObsInd], [MRiceBrandID]) VALUES (N'HTBR201607120405a66869f748', N'HP20160712d3ff9b16a0b722', NULL, N'PT201606225efc7ab2111f9f', N'om', N'BT2016062280517d7e42e848', 4, 1500.0000, N'om\test', CAST(0x0000A64100AC3BCC AS DateTime), N'N', NULL)
INSERT [dbo].[HullingTransaction] ([HullingTransID], [HullingProcessID], [MRiceProdTypeID], [BrokenRiceTypeID], [CustID], [UnitsTypeID], [TotalBags], [Price], [LastModifiedBy], [LastModifiedDate], [ObsInd], [MRiceBrandID]) VALUES (N'HTD201606226b6449e98aff4f', N'HP20160622040b6470594e33', NULL, NULL, N'om', N'BT201606224dcfa31d81fc00', 4, 1000.0000, N'om\test', CAST(0x0000A62D01194E10 AS DateTime), N'N', NULL)
INSERT [dbo].[HullingTransaction] ([HullingTransID], [HullingProcessID], [MRiceProdTypeID], [BrokenRiceTypeID], [CustID], [UnitsTypeID], [TotalBags], [Price], [LastModifiedBy], [LastModifiedDate], [ObsInd], [MRiceBrandID]) VALUES (N'HTD2016062726f4607ac50fe3', N'HP20160622ebc21610148f65', NULL, NULL, N'om', N'BT201606224dcfa31d81fc00', 2, 2000.0000, N'om\test', CAST(0x0000A63200F9EF34 AS DateTime), N'N', NULL)
INSERT [dbo].[HullingTransaction] ([HullingTransID], [HullingProcessID], [MRiceProdTypeID], [BrokenRiceTypeID], [CustID], [UnitsTypeID], [TotalBags], [Price], [LastModifiedBy], [LastModifiedDate], [ObsInd], [MRiceBrandID]) VALUES (N'HTD20160706ed7149756a50fa', N'HP20160628a576d61d86e8e2', NULL, NULL, N'om', N'BT2016062280517d7e42e848', 4, 1000.0000, N'om\test', CAST(0x0000A63B00A7D7F8 AS DateTime), N'N', NULL)
INSERT [dbo].[HullingTransaction] ([HullingTransID], [HullingProcessID], [MRiceProdTypeID], [BrokenRiceTypeID], [CustID], [UnitsTypeID], [TotalBags], [Price], [LastModifiedBy], [LastModifiedDate], [ObsInd], [MRiceBrandID]) VALUES (N'HTD201607124d739efcd0eaf7', N'HP20160712d3ff9b16a0b722', NULL, NULL, N'om', N'BT201606224dcfa31d81fc00', 2, 2000.0000, N'om\test', CAST(0x0000A64100AC4B08 AS DateTime), N'N', NULL)
INSERT [dbo].[HullingTransaction] ([HullingTransID], [HullingProcessID], [MRiceProdTypeID], [BrokenRiceTypeID], [CustID], [UnitsTypeID], [TotalBags], [Price], [LastModifiedBy], [LastModifiedDate], [ObsInd], [MRiceBrandID]) VALUES (N'HTR2016062298f5822356e6e6', N'HP20160622040b6470594e33', N'RP20160622c05ec2d94f9b8e', NULL, N'om', N'BT2016062286029cb9006bd9', 320, 0.0000, N'om\test', CAST(0x0000A62D01194E10 AS DateTime), N'N', N'RB2016062245b890084762d1')
INSERT [dbo].[HullingTransaction] ([HullingTransID], [HullingProcessID], [MRiceProdTypeID], [BrokenRiceTypeID], [CustID], [UnitsTypeID], [TotalBags], [Price], [LastModifiedBy], [LastModifiedDate], [ObsInd], [MRiceBrandID]) VALUES (N'HTR20160622b323ea4dfe984f', N'HP20160622040b6470594e33', N'RP20160622c05ec2d94f9b8e', NULL, N'om', N'BT2016062286029cb9006bd9', 320, 0.0000, N'om\test', CAST(0x0000A62D01194E10 AS DateTime), N'N', N'RB2016062203979664e4dc44')
INSERT [dbo].[HullingTransaction] ([HullingTransID], [HullingProcessID], [MRiceProdTypeID], [BrokenRiceTypeID], [CustID], [UnitsTypeID], [TotalBags], [Price], [LastModifiedBy], [LastModifiedDate], [ObsInd], [MRiceBrandID]) VALUES (N'HTR20160627ef92bf4be49265', N'HP20160622ebc21610148f65', N'RP2016062294b63a1e91a242', NULL, N'om', N'BT2016062286029cb9006bd9', 620, 0.0000, N'om\test', CAST(0x0000A63200F9EF34 AS DateTime), N'N', N'RB2016062245b890084762d1')
INSERT [dbo].[HullingTransaction] ([HullingTransID], [HullingProcessID], [MRiceProdTypeID], [BrokenRiceTypeID], [CustID], [UnitsTypeID], [TotalBags], [Price], [LastModifiedBy], [LastModifiedDate], [ObsInd], [MRiceBrandID]) VALUES (N'HTR20160706ed7a64cc1398d9', N'HP20160628a576d61d86e8e2', N'RP2016062294b63a1e91a242', NULL, N'om', N'BT2016062286029cb9006bd9', 550, 0.0000, N'om\test', CAST(0x0000A63B00A7C40C AS DateTime), N'N', N'RB2016062245b890084762d1')
INSERT [dbo].[HullingTransaction] ([HullingTransID], [HullingProcessID], [MRiceProdTypeID], [BrokenRiceTypeID], [CustID], [UnitsTypeID], [TotalBags], [Price], [LastModifiedBy], [LastModifiedDate], [ObsInd], [MRiceBrandID]) VALUES (N'HTR2016071263072dd21ded4a', N'HP20160712d3ff9b16a0b722', N'RP2016062294b63a1e91a242', NULL, N'om', N'BT2016062286029cb9006bd9', 550, 0.0000, N'om\test', CAST(0x0000A64100ABB508 AS DateTime), N'N', N'RB2016062245b890084762d1')
/****** Object:  Table [dbo].[HullingProcessExpenses]    Script Date: 07/12/2016 18:45:08 ******/
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
INSERT [dbo].[HullingProcessExpenses] ([HullingProcessExpenID], [HullingProcessID], [PowerExpenses], [LabourExpenses], [OtherExpenses], [LastModifiedBy], [LastModifiedDate], [ObsInd], [CustID]) VALUES (N'HPE201606220e9fc91fedca49', N'HP20160622040b6470594e33', 1000.0000, 1000.0000, 1000.0000, N'om\test', CAST(0x0000A62D01194E10 AS DateTime), N'N', N'om')
INSERT [dbo].[HullingProcessExpenses] ([HullingProcessExpenID], [HullingProcessID], [PowerExpenses], [LabourExpenses], [OtherExpenses], [LastModifiedBy], [LastModifiedDate], [ObsInd], [CustID]) VALUES (N'HPE20160627043e56051da0df', N'HP20160622ebc21610148f65', 1000.0000, 1000.0000, 1000.0000, N'om\test', CAST(0x0000A63200F9EF34 AS DateTime), N'N', N'om')
INSERT [dbo].[HullingProcessExpenses] ([HullingProcessExpenID], [HullingProcessID], [PowerExpenses], [LabourExpenses], [OtherExpenses], [LastModifiedBy], [LastModifiedDate], [ObsInd], [CustID]) VALUES (N'HPE2016070675a41929c6cd47', N'HP20160628a576d61d86e8e2', 1000.0000, 1000.0000, 1000.0000, N'om\test', CAST(0x0000A63B00A7DF00 AS DateTime), N'N', N'om')
INSERT [dbo].[HullingProcessExpenses] ([HullingProcessExpenID], [HullingProcessID], [PowerExpenses], [LabourExpenses], [OtherExpenses], [LastModifiedBy], [LastModifiedDate], [ObsInd], [CustID]) VALUES (N'HPE20160708d47dfd9af49000', N'HP20160708edcec591a3d15b', 15000.0000, 0.0000, 0.0000, N'om\test', CAST(0x0000A63D00DC02A8 AS DateTime), N'N', N'om')
INSERT [dbo].[HullingProcessExpenses] ([HullingProcessExpenID], [HullingProcessID], [PowerExpenses], [LabourExpenses], [OtherExpenses], [LastModifiedBy], [LastModifiedDate], [ObsInd], [CustID]) VALUES (N'HPE201607129d22cb35a41fb4', N'HP20160712d3ff9b16a0b722', 1000.0000, 1000.0000, 1000.0000, N'om\test', CAST(0x0000A64100AC4B08 AS DateTime), N'N', N'om')
/****** Object:  ForeignKey [FK_Users_CustomerInfo]    Script Date: 07/12/2016 18:45:08 ******/
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_CustomerInfo] FOREIGN KEY([CustID])
REFERENCES [dbo].[CustomerInfo] ([CustID])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_CustomerInfo]
GO
/****** Object:  ForeignKey [FK_SellerInfo_CustomerInfo]    Script Date: 07/12/2016 18:45:08 ******/
ALTER TABLE [dbo].[SellerInfo]  WITH CHECK ADD  CONSTRAINT [FK_SellerInfo_CustomerInfo] FOREIGN KEY([CustID])
REFERENCES [dbo].[CustomerInfo] ([CustID])
GO
ALTER TABLE [dbo].[SellerInfo] CHECK CONSTRAINT [FK_SellerInfo_CustomerInfo]
GO
/****** Object:  ForeignKey [FK_MWeightDetails_CustomerInfo]    Script Date: 07/12/2016 18:45:08 ******/
ALTER TABLE [dbo].[MWeightDetails]  WITH CHECK ADD  CONSTRAINT [FK_MWeightDetails_CustomerInfo] FOREIGN KEY([CustID])
REFERENCES [dbo].[CustomerInfo] ([CustID])
GO
ALTER TABLE [dbo].[MWeightDetails] CHECK CONSTRAINT [FK_MWeightDetails_CustomerInfo]
GO
/****** Object:  ForeignKey [FK_MUnitsType_CustomerInfo]    Script Date: 07/12/2016 18:45:08 ******/
ALTER TABLE [dbo].[MUnitsType]  WITH CHECK ADD  CONSTRAINT [FK_MUnitsType_CustomerInfo] FOREIGN KEY([CustID])
REFERENCES [dbo].[CustomerInfo] ([CustID])
GO
ALTER TABLE [dbo].[MUnitsType] CHECK CONSTRAINT [FK_MUnitsType_CustomerInfo]
GO
/****** Object:  ForeignKey [FK_MSalaryType_CustomerInfo]    Script Date: 07/12/2016 18:45:08 ******/
ALTER TABLE [dbo].[MSalaryType]  WITH CHECK ADD  CONSTRAINT [FK_MSalaryType_CustomerInfo] FOREIGN KEY([CustID])
REFERENCES [dbo].[CustomerInfo] ([CustID])
GO
ALTER TABLE [dbo].[MSalaryType] CHECK CONSTRAINT [FK_MSalaryType_CustomerInfo]
GO
/****** Object:  ForeignKey [FK_MRiceProductionType_CustomerInfo]    Script Date: 07/12/2016 18:45:08 ******/
ALTER TABLE [dbo].[MRiceProductionType]  WITH CHECK ADD  CONSTRAINT [FK_MRiceProductionType_CustomerInfo] FOREIGN KEY([CustID])
REFERENCES [dbo].[CustomerInfo] ([CustID])
GO
ALTER TABLE [dbo].[MRiceProductionType] CHECK CONSTRAINT [FK_MRiceProductionType_CustomerInfo]
GO
/****** Object:  ForeignKey [FK_MRiceBrandDetails_CustomerInfo]    Script Date: 07/12/2016 18:45:08 ******/
ALTER TABLE [dbo].[MRiceBrandDetails]  WITH CHECK ADD  CONSTRAINT [FK_MRiceBrandDetails_CustomerInfo] FOREIGN KEY([CustID])
REFERENCES [dbo].[CustomerInfo] ([CustID])
GO
ALTER TABLE [dbo].[MRiceBrandDetails] CHECK CONSTRAINT [FK_MRiceBrandDetails_CustomerInfo]
GO
/****** Object:  ForeignKey [FK_MPaddyType_CustomerInfo]    Script Date: 07/12/2016 18:45:08 ******/
ALTER TABLE [dbo].[MPaddyType]  WITH CHECK ADD  CONSTRAINT [FK_MPaddyType_CustomerInfo] FOREIGN KEY([CustID])
REFERENCES [dbo].[CustomerInfo] ([CustID])
GO
ALTER TABLE [dbo].[MPaddyType] CHECK CONSTRAINT [FK_MPaddyType_CustomerInfo]
GO
/****** Object:  ForeignKey [FK_MJobWork_CustomerInfo]    Script Date: 07/12/2016 18:45:08 ******/
ALTER TABLE [dbo].[MJobWork]  WITH CHECK ADD  CONSTRAINT [FK_MJobWork_CustomerInfo] FOREIGN KEY([CustID])
REFERENCES [dbo].[CustomerInfo] ([CustID])
GO
ALTER TABLE [dbo].[MJobWork] CHECK CONSTRAINT [FK_MJobWork_CustomerInfo]
GO
/****** Object:  ForeignKey [FK_MGodownDetails_CustomerInfo]    Script Date: 07/12/2016 18:45:08 ******/
ALTER TABLE [dbo].[MGodownDetails]  WITH CHECK ADD  CONSTRAINT [FK_MGodownDetails_CustomerInfo] FOREIGN KEY([CustID])
REFERENCES [dbo].[CustomerInfo] ([CustID])
GO
ALTER TABLE [dbo].[MGodownDetails] CHECK CONSTRAINT [FK_MGodownDetails_CustomerInfo]
GO
/****** Object:  ForeignKey [FK_MExpenseType_CustomerInfo]    Script Date: 07/12/2016 18:45:08 ******/
ALTER TABLE [dbo].[MExpenseType]  WITH CHECK ADD  CONSTRAINT [FK_MExpenseType_CustomerInfo] FOREIGN KEY([CustID])
REFERENCES [dbo].[CustomerInfo] ([CustID])
GO
ALTER TABLE [dbo].[MExpenseType] CHECK CONSTRAINT [FK_MExpenseType_CustomerInfo]
GO
/****** Object:  ForeignKey [FK_MessageInfo_CustomerInfo1]    Script Date: 07/12/2016 18:45:08 ******/
ALTER TABLE [dbo].[MessageInfo]  WITH CHECK ADD  CONSTRAINT [FK_MessageInfo_CustomerInfo1] FOREIGN KEY([CustID])
REFERENCES [dbo].[CustomerInfo] ([CustID])
GO
ALTER TABLE [dbo].[MessageInfo] CHECK CONSTRAINT [FK_MessageInfo_CustomerInfo1]
GO
/****** Object:  ForeignKey [FK_MEmployeeDesignation_CustomerInfo]    Script Date: 07/12/2016 18:45:08 ******/
ALTER TABLE [dbo].[MEmployeeDesignation]  WITH CHECK ADD  CONSTRAINT [FK_MEmployeeDesignation_CustomerInfo] FOREIGN KEY([CustID])
REFERENCES [dbo].[CustomerInfo] ([CustID])
GO
ALTER TABLE [dbo].[MEmployeeDesignation] CHECK CONSTRAINT [FK_MEmployeeDesignation_CustomerInfo]
GO
/****** Object:  ForeignKey [FK_MediatorInfo_CustomerInfo]    Script Date: 07/12/2016 18:45:08 ******/
ALTER TABLE [dbo].[MediatorInfo]  WITH CHECK ADD  CONSTRAINT [FK_MediatorInfo_CustomerInfo] FOREIGN KEY([CustID])
REFERENCES [dbo].[CustomerInfo] ([CustID])
GO
ALTER TABLE [dbo].[MediatorInfo] CHECK CONSTRAINT [FK_MediatorInfo_CustomerInfo]
GO
/****** Object:  ForeignKey [FK_MDrierTypeDetails_CustomerInfo]    Script Date: 07/12/2016 18:45:08 ******/
ALTER TABLE [dbo].[MDrierTypeDetails]  WITH CHECK ADD  CONSTRAINT [FK_MDrierTypeDetails_CustomerInfo] FOREIGN KEY([CustID])
REFERENCES [dbo].[CustomerInfo] ([CustID])
GO
ALTER TABLE [dbo].[MDrierTypeDetails] CHECK CONSTRAINT [FK_MDrierTypeDetails_CustomerInfo]
GO
/****** Object:  ForeignKey [FK_MBagType_CustomerInfo]    Script Date: 07/12/2016 18:45:08 ******/
ALTER TABLE [dbo].[MBagType]  WITH CHECK ADD  CONSTRAINT [FK_MBagType_CustomerInfo] FOREIGN KEY([CustID])
REFERENCES [dbo].[CustomerInfo] ([CustID])
GO
ALTER TABLE [dbo].[MBagType] CHECK CONSTRAINT [FK_MBagType_CustomerInfo]
GO
/****** Object:  ForeignKey [FK_CustTrailUsage_CustomerInfo]    Script Date: 07/12/2016 18:45:08 ******/
ALTER TABLE [dbo].[CustTrailUsage]  WITH CHECK ADD  CONSTRAINT [FK_CustTrailUsage_CustomerInfo] FOREIGN KEY([CustID])
REFERENCES [dbo].[CustomerInfo] ([CustID])
GO
ALTER TABLE [dbo].[CustTrailUsage] CHECK CONSTRAINT [FK_CustTrailUsage_CustomerInfo]
GO
/****** Object:  ForeignKey [FK_CustomerPayment_CustomerInfo]    Script Date: 07/12/2016 18:45:08 ******/
ALTER TABLE [dbo].[CustomerPayment]  WITH CHECK ADD  CONSTRAINT [FK_CustomerPayment_CustomerInfo] FOREIGN KEY([CustID])
REFERENCES [dbo].[CustomerInfo] ([CustID])
GO
ALTER TABLE [dbo].[CustomerPayment] CHECK CONSTRAINT [FK_CustomerPayment_CustomerInfo]
GO
/****** Object:  ForeignKey [FK_CustomerPartPayDetails_CustomerInfo]    Script Date: 07/12/2016 18:45:08 ******/
ALTER TABLE [dbo].[CustomerPartPayDetails]  WITH CHECK ADD  CONSTRAINT [FK_CustomerPartPayDetails_CustomerInfo] FOREIGN KEY([CustID])
REFERENCES [dbo].[CustomerInfo] ([CustID])
GO
ALTER TABLE [dbo].[CustomerPartPayDetails] CHECK CONSTRAINT [FK_CustomerPartPayDetails_CustomerInfo]
GO
/****** Object:  ForeignKey [FK_BuyerInfo_CustomerInfo]    Script Date: 07/12/2016 18:45:08 ******/
ALTER TABLE [dbo].[BuyerInfo]  WITH CHECK ADD  CONSTRAINT [FK_BuyerInfo_CustomerInfo] FOREIGN KEY([CustID])
REFERENCES [dbo].[CustomerInfo] ([CustID])
GO
ALTER TABLE [dbo].[BuyerInfo] CHECK CONSTRAINT [FK_BuyerInfo_CustomerInfo]
GO
/****** Object:  ForeignKey [FK_EmployeeDetails_CustomerInfo]    Script Date: 07/12/2016 18:45:08 ******/
ALTER TABLE [dbo].[EmployeeDetails]  WITH CHECK ADD  CONSTRAINT [FK_EmployeeDetails_CustomerInfo] FOREIGN KEY([CustID])
REFERENCES [dbo].[CustomerInfo] ([CustID])
GO
ALTER TABLE [dbo].[EmployeeDetails] CHECK CONSTRAINT [FK_EmployeeDetails_CustomerInfo]
GO
/****** Object:  ForeignKey [FK_CustomerAddressInfo_CustomerAddressInfo]    Script Date: 07/12/2016 18:45:08 ******/
ALTER TABLE [dbo].[CustomerAddressInfo]  WITH NOCHECK ADD  CONSTRAINT [FK_CustomerAddressInfo_CustomerAddressInfo] FOREIGN KEY([CustID])
REFERENCES [dbo].[CustomerInfo] ([CustID])
NOT FOR REPLICATION
GO
ALTER TABLE [dbo].[CustomerAddressInfo] NOCHECK CONSTRAINT [FK_CustomerAddressInfo_CustomerAddressInfo]
GO
/****** Object:  ForeignKey [FK_CustomerActivation_CustomerInfo]    Script Date: 07/12/2016 18:45:08 ******/
ALTER TABLE [dbo].[CustomerActivation]  WITH CHECK ADD  CONSTRAINT [FK_CustomerActivation_CustomerInfo] FOREIGN KEY([CustID])
REFERENCES [dbo].[CustomerInfo] ([CustID])
GO
ALTER TABLE [dbo].[CustomerActivation] CHECK CONSTRAINT [FK_CustomerActivation_CustomerInfo]
GO
/****** Object:  ForeignKey [FK_ByuerSellerRating_CustomerInfo]    Script Date: 07/12/2016 18:45:08 ******/
ALTER TABLE [dbo].[BuyerSellerRating]  WITH CHECK ADD  CONSTRAINT [FK_ByuerSellerRating_CustomerInfo] FOREIGN KEY([CustID])
REFERENCES [dbo].[CustomerInfo] ([CustID])
GO
ALTER TABLE [dbo].[BuyerSellerRating] CHECK CONSTRAINT [FK_ByuerSellerRating_CustomerInfo]
GO
/****** Object:  ForeignKey [FK_ByuerSellerRating_SellerInfo]    Script Date: 07/12/2016 18:45:08 ******/
ALTER TABLE [dbo].[BuyerSellerRating]  WITH CHECK ADD  CONSTRAINT [FK_ByuerSellerRating_SellerInfo] FOREIGN KEY([SellerID])
REFERENCES [dbo].[SellerInfo] ([SellerID])
GO
ALTER TABLE [dbo].[BuyerSellerRating] CHECK CONSTRAINT [FK_ByuerSellerRating_SellerInfo]
GO
/****** Object:  ForeignKey [FK_DustStockInfo_CustomerInfo]    Script Date: 07/12/2016 18:45:08 ******/
ALTER TABLE [dbo].[DustStockInfo]  WITH CHECK ADD  CONSTRAINT [FK_DustStockInfo_CustomerInfo] FOREIGN KEY([CustID])
REFERENCES [dbo].[CustomerInfo] ([CustID])
GO
ALTER TABLE [dbo].[DustStockInfo] CHECK CONSTRAINT [FK_DustStockInfo_CustomerInfo]
GO
/****** Object:  ForeignKey [FK_DustStockInfo_MUnitsType]    Script Date: 07/12/2016 18:45:08 ******/
ALTER TABLE [dbo].[DustStockInfo]  WITH CHECK ADD  CONSTRAINT [FK_DustStockInfo_MUnitsType] FOREIGN KEY([UnitsTypeID])
REFERENCES [dbo].[MUnitsType] ([UnitsTypeID])
GO
ALTER TABLE [dbo].[DustStockInfo] CHECK CONSTRAINT [FK_DustStockInfo_MUnitsType]
GO
/****** Object:  ForeignKey [FK_BrokenRiceStockInfo_CustomerInfo]    Script Date: 07/12/2016 18:45:08 ******/
ALTER TABLE [dbo].[BrokenRiceStockInfo]  WITH CHECK ADD  CONSTRAINT [FK_BrokenRiceStockInfo_CustomerInfo] FOREIGN KEY([CustID])
REFERENCES [dbo].[CustomerInfo] ([CustID])
GO
ALTER TABLE [dbo].[BrokenRiceStockInfo] CHECK CONSTRAINT [FK_BrokenRiceStockInfo_CustomerInfo]
GO
/****** Object:  ForeignKey [FK_BrokenRiceStockInfo_MBrokenRiceType]    Script Date: 07/12/2016 18:45:08 ******/
ALTER TABLE [dbo].[BrokenRiceStockInfo]  WITH CHECK ADD  CONSTRAINT [FK_BrokenRiceStockInfo_MBrokenRiceType] FOREIGN KEY([BrokenRiceTypeID])
REFERENCES [dbo].[MBrokenRiceType] ([BrokenRiceTypeID])
GO
ALTER TABLE [dbo].[BrokenRiceStockInfo] CHECK CONSTRAINT [FK_BrokenRiceStockInfo_MBrokenRiceType]
GO
/****** Object:  ForeignKey [FK_BrokenRiceStockInfo_MUnitsType]    Script Date: 07/12/2016 18:45:08 ******/
ALTER TABLE [dbo].[BrokenRiceStockInfo]  WITH CHECK ADD  CONSTRAINT [FK_BrokenRiceStockInfo_MUnitsType] FOREIGN KEY([UnitsTypeID])
REFERENCES [dbo].[MUnitsType] ([UnitsTypeID])
GO
ALTER TABLE [dbo].[BrokenRiceStockInfo] CHECK CONSTRAINT [FK_BrokenRiceStockInfo_MUnitsType]
GO
/****** Object:  ForeignKey [FK_BagStockInfo_CustomerInfo]    Script Date: 07/12/2016 18:45:08 ******/
ALTER TABLE [dbo].[BagStockInfo]  WITH CHECK ADD  CONSTRAINT [FK_BagStockInfo_CustomerInfo] FOREIGN KEY([CustID])
REFERENCES [dbo].[CustomerInfo] ([CustID])
GO
ALTER TABLE [dbo].[BagStockInfo] CHECK CONSTRAINT [FK_BagStockInfo_CustomerInfo]
GO
/****** Object:  ForeignKey [FK_BagStockInfo_SellerInfo]    Script Date: 07/12/2016 18:45:08 ******/
ALTER TABLE [dbo].[BagStockInfo]  WITH CHECK ADD  CONSTRAINT [FK_BagStockInfo_SellerInfo] FOREIGN KEY([SellerID])
REFERENCES [dbo].[SellerInfo] ([SellerID])
GO
ALTER TABLE [dbo].[BagStockInfo] CHECK CONSTRAINT [FK_BagStockInfo_SellerInfo]
GO
/****** Object:  ForeignKey [fkBagStockInfo_MRiceBrandID]    Script Date: 07/12/2016 18:45:08 ******/
ALTER TABLE [dbo].[BagStockInfo]  WITH CHECK ADD  CONSTRAINT [fkBagStockInfo_MRiceBrandID] FOREIGN KEY([MRiceBrandID])
REFERENCES [dbo].[MRiceBrandDetails] ([MRiceBrandID])
GO
ALTER TABLE [dbo].[BagStockInfo] CHECK CONSTRAINT [fkBagStockInfo_MRiceBrandID]
GO
/****** Object:  ForeignKey [fkBagStockInfo_UnitsTypeID]    Script Date: 07/12/2016 18:45:08 ******/
ALTER TABLE [dbo].[BagStockInfo]  WITH CHECK ADD  CONSTRAINT [fkBagStockInfo_UnitsTypeID] FOREIGN KEY([UnitsTypeID])
REFERENCES [dbo].[MUnitsType] ([UnitsTypeID])
GO
ALTER TABLE [dbo].[BagStockInfo] CHECK CONSTRAINT [fkBagStockInfo_UnitsTypeID]
GO
/****** Object:  ForeignKey [FK_BagPaymentInfo_CustomerInfo]    Script Date: 07/12/2016 18:45:08 ******/
ALTER TABLE [dbo].[BagPaymentInfo]  WITH CHECK ADD  CONSTRAINT [FK_BagPaymentInfo_CustomerInfo] FOREIGN KEY([CustID])
REFERENCES [dbo].[CustomerInfo] ([CustID])
GO
ALTER TABLE [dbo].[BagPaymentInfo] CHECK CONSTRAINT [FK_BagPaymentInfo_CustomerInfo]
GO
/****** Object:  ForeignKey [FK_BagPaymentInfo_SellerInfo]    Script Date: 07/12/2016 18:45:08 ******/
ALTER TABLE [dbo].[BagPaymentInfo]  WITH CHECK ADD  CONSTRAINT [FK_BagPaymentInfo_SellerInfo] FOREIGN KEY([SellerID])
REFERENCES [dbo].[SellerInfo] ([SellerID])
GO
ALTER TABLE [dbo].[BagPaymentInfo] CHECK CONSTRAINT [FK_BagPaymentInfo_SellerInfo]
GO
/****** Object:  ForeignKey [FK_ExpenseTransaction_CustomerInfo]    Script Date: 07/12/2016 18:45:08 ******/
ALTER TABLE [dbo].[ExpenseTransaction]  WITH CHECK ADD  CONSTRAINT [FK_ExpenseTransaction_CustomerInfo] FOREIGN KEY([CustID])
REFERENCES [dbo].[CustomerInfo] ([CustID])
GO
ALTER TABLE [dbo].[ExpenseTransaction] CHECK CONSTRAINT [FK_ExpenseTransaction_CustomerInfo]
GO
/****** Object:  ForeignKey [FK_ExpenseTransaction_MExpenseType]    Script Date: 07/12/2016 18:45:08 ******/
ALTER TABLE [dbo].[ExpenseTransaction]  WITH CHECK ADD  CONSTRAINT [FK_ExpenseTransaction_MExpenseType] FOREIGN KEY([ExpenseID])
REFERENCES [dbo].[MExpenseType] ([ExpenseID])
GO
ALTER TABLE [dbo].[ExpenseTransaction] CHECK CONSTRAINT [FK_ExpenseTransaction_MExpenseType]
GO
/****** Object:  ForeignKey [FK_EmployeeSalary_CustomerInfo]    Script Date: 07/12/2016 18:45:08 ******/
ALTER TABLE [dbo].[EmployeeSalary]  WITH CHECK ADD  CONSTRAINT [FK_EmployeeSalary_CustomerInfo] FOREIGN KEY([CustID])
REFERENCES [dbo].[CustomerInfo] ([CustID])
GO
ALTER TABLE [dbo].[EmployeeSalary] CHECK CONSTRAINT [FK_EmployeeSalary_CustomerInfo]
GO
/****** Object:  ForeignKey [FK_EmployeeSalary_EmployeeDetails]    Script Date: 07/12/2016 18:45:08 ******/
ALTER TABLE [dbo].[EmployeeSalary]  WITH CHECK ADD  CONSTRAINT [FK_EmployeeSalary_EmployeeDetails] FOREIGN KEY([EmployeeID])
REFERENCES [dbo].[EmployeeDetails] ([EmployeeID])
GO
ALTER TABLE [dbo].[EmployeeSalary] CHECK CONSTRAINT [FK_EmployeeSalary_EmployeeDetails]
GO
/****** Object:  ForeignKey [FK_EmployeeSalary_MEmployeeDesignation]    Script Date: 07/12/2016 18:45:08 ******/
ALTER TABLE [dbo].[EmployeeSalary]  WITH CHECK ADD  CONSTRAINT [FK_EmployeeSalary_MEmployeeDesignation] FOREIGN KEY([MEmpDsgID])
REFERENCES [dbo].[MEmployeeDesignation] ([MEmpDsgID])
GO
ALTER TABLE [dbo].[EmployeeSalary] CHECK CONSTRAINT [FK_EmployeeSalary_MEmployeeDesignation]
GO
/****** Object:  ForeignKey [FK_EmployeeSalary_MSalaryType]    Script Date: 07/12/2016 18:45:08 ******/
ALTER TABLE [dbo].[EmployeeSalary]  WITH CHECK ADD  CONSTRAINT [FK_EmployeeSalary_MSalaryType] FOREIGN KEY([MSalaryTypeID])
REFERENCES [dbo].[MSalaryType] ([MSalaryTypeID])
GO
ALTER TABLE [dbo].[EmployeeSalary] CHECK CONSTRAINT [FK_EmployeeSalary_MSalaryType]
GO
/****** Object:  ForeignKey [fk_MEmpDsgID]    Script Date: 07/12/2016 18:45:08 ******/
ALTER TABLE [dbo].[MoneyTransaction]  WITH CHECK ADD  CONSTRAINT [fk_MEmpDsgID] FOREIGN KEY([MEmpDsgID])
REFERENCES [dbo].[MEmployeeDesignation] ([MEmpDsgID])
GO
ALTER TABLE [dbo].[MoneyTransaction] CHECK CONSTRAINT [fk_MEmpDsgID]
GO
/****** Object:  ForeignKey [FK_MoneyTransaction_CustomerInfo]    Script Date: 07/12/2016 18:45:08 ******/
ALTER TABLE [dbo].[MoneyTransaction]  WITH CHECK ADD  CONSTRAINT [FK_MoneyTransaction_CustomerInfo] FOREIGN KEY([CustID])
REFERENCES [dbo].[CustomerInfo] ([CustID])
GO
ALTER TABLE [dbo].[MoneyTransaction] CHECK CONSTRAINT [FK_MoneyTransaction_CustomerInfo]
GO
/****** Object:  ForeignKey [FK_MoneyTransaction_EmployeeDetails]    Script Date: 07/12/2016 18:45:08 ******/
ALTER TABLE [dbo].[MoneyTransaction]  WITH CHECK ADD  CONSTRAINT [FK_MoneyTransaction_EmployeeDetails] FOREIGN KEY([EmployeeID])
REFERENCES [dbo].[EmployeeDetails] ([EmployeeID])
GO
ALTER TABLE [dbo].[MoneyTransaction] CHECK CONSTRAINT [FK_MoneyTransaction_EmployeeDetails]
GO
/****** Object:  ForeignKey [fk_MonySalaryTypeID]    Script Date: 07/12/2016 18:45:08 ******/
ALTER TABLE [dbo].[MoneyTransaction]  WITH CHECK ADD  CONSTRAINT [fk_MonySalaryTypeID] FOREIGN KEY([MSalaryTypeID])
REFERENCES [dbo].[MSalaryType] ([MSalaryTypeID])
GO
ALTER TABLE [dbo].[MoneyTransaction] CHECK CONSTRAINT [fk_MonySalaryTypeID]
GO
/****** Object:  ForeignKey [FK_MLotDetails_CustomerInfo]    Script Date: 07/12/2016 18:45:08 ******/
ALTER TABLE [dbo].[MLotDetails]  WITH CHECK ADD  CONSTRAINT [FK_MLotDetails_CustomerInfo] FOREIGN KEY([CustID])
REFERENCES [dbo].[CustomerInfo] ([CustID])
GO
ALTER TABLE [dbo].[MLotDetails] CHECK CONSTRAINT [FK_MLotDetails_CustomerInfo]
GO
/****** Object:  ForeignKey [FK_MLotDetails_MGodownDetails]    Script Date: 07/12/2016 18:45:08 ******/
ALTER TABLE [dbo].[MLotDetails]  WITH CHECK ADD  CONSTRAINT [FK_MLotDetails_MGodownDetails] FOREIGN KEY([MGodownID])
REFERENCES [dbo].[MGodownDetails] ([MGodownID])
GO
ALTER TABLE [dbo].[MLotDetails] CHECK CONSTRAINT [FK_MLotDetails_MGodownDetails]
GO
/****** Object:  ForeignKey [fk_BuyerID]    Script Date: 07/12/2016 18:45:08 ******/
ALTER TABLE [dbo].[ProductPaymentInfo]  WITH CHECK ADD  CONSTRAINT [fk_BuyerID] FOREIGN KEY([BuyerID])
REFERENCES [dbo].[BuyerInfo] ([BuyerID])
GO
ALTER TABLE [dbo].[ProductPaymentInfo] CHECK CONSTRAINT [fk_BuyerID]
GO
/****** Object:  ForeignKey [FK_ProductPaymentInfo_CustomerInfo]    Script Date: 07/12/2016 18:45:08 ******/
ALTER TABLE [dbo].[ProductPaymentInfo]  WITH CHECK ADD  CONSTRAINT [FK_ProductPaymentInfo_CustomerInfo] FOREIGN KEY([CustID])
REFERENCES [dbo].[CustomerInfo] ([CustID])
GO
ALTER TABLE [dbo].[ProductPaymentInfo] CHECK CONSTRAINT [FK_ProductPaymentInfo_CustomerInfo]
GO
/****** Object:  ForeignKey [fk_ProPayMediatorID]    Script Date: 07/12/2016 18:45:08 ******/
ALTER TABLE [dbo].[ProductPaymentInfo]  WITH CHECK ADD  CONSTRAINT [fk_ProPayMediatorID] FOREIGN KEY([MediatorID])
REFERENCES [dbo].[MediatorInfo] ([MediatorID])
GO
ALTER TABLE [dbo].[ProductPaymentInfo] CHECK CONSTRAINT [fk_ProPayMediatorID]
GO
/****** Object:  ForeignKey [FK_RiceStockInfo_CustomerInfo]    Script Date: 07/12/2016 18:45:08 ******/
ALTER TABLE [dbo].[RiceStockInfo]  WITH CHECK ADD  CONSTRAINT [FK_RiceStockInfo_CustomerInfo] FOREIGN KEY([CustID])
REFERENCES [dbo].[CustomerInfo] ([CustID])
GO
ALTER TABLE [dbo].[RiceStockInfo] CHECK CONSTRAINT [FK_RiceStockInfo_CustomerInfo]
GO
/****** Object:  ForeignKey [FK_RiceStockInfo_MRiceBrandDetails]    Script Date: 07/12/2016 18:45:08 ******/
ALTER TABLE [dbo].[RiceStockInfo]  WITH CHECK ADD  CONSTRAINT [FK_RiceStockInfo_MRiceBrandDetails] FOREIGN KEY([MRiceBrandID])
REFERENCES [dbo].[MRiceBrandDetails] ([MRiceBrandID])
GO
ALTER TABLE [dbo].[RiceStockInfo] CHECK CONSTRAINT [FK_RiceStockInfo_MRiceBrandDetails]
GO
/****** Object:  ForeignKey [FK_RiceStockInfo_MUnitsType]    Script Date: 07/12/2016 18:45:08 ******/
ALTER TABLE [dbo].[RiceStockInfo]  WITH CHECK ADD  CONSTRAINT [FK_RiceStockInfo_MUnitsType] FOREIGN KEY([UnitsTypeID])
REFERENCES [dbo].[MUnitsType] ([UnitsTypeID])
GO
ALTER TABLE [dbo].[RiceStockInfo] CHECK CONSTRAINT [FK_RiceStockInfo_MUnitsType]
GO
/****** Object:  ForeignKey [FK_RiceStockInfo_RiceStockInfo]    Script Date: 07/12/2016 18:45:08 ******/
ALTER TABLE [dbo].[RiceStockInfo]  WITH CHECK ADD  CONSTRAINT [FK_RiceStockInfo_RiceStockInfo] FOREIGN KEY([MRiceProdTypeID])
REFERENCES [dbo].[MRiceProductionType] ([MRiceProdTypeID])
GO
ALTER TABLE [dbo].[RiceStockInfo] CHECK CONSTRAINT [FK_RiceStockInfo_RiceStockInfo]
GO
/****** Object:  ForeignKey [FK_RentalHulling_CustomerInfo]    Script Date: 07/12/2016 18:45:08 ******/
ALTER TABLE [dbo].[RentalHulling]  WITH CHECK ADD  CONSTRAINT [FK_RentalHulling_CustomerInfo] FOREIGN KEY([CustID])
REFERENCES [dbo].[CustomerInfo] ([CustID])
GO
ALTER TABLE [dbo].[RentalHulling] CHECK CONSTRAINT [FK_RentalHulling_CustomerInfo]
GO
/****** Object:  ForeignKey [FK_RentalHulling_MJobWork]    Script Date: 07/12/2016 18:45:08 ******/
ALTER TABLE [dbo].[RentalHulling]  WITH CHECK ADD  CONSTRAINT [FK_RentalHulling_MJobWork] FOREIGN KEY([JobWorkID])
REFERENCES [dbo].[MJobWork] ([JobWorkID])
GO
ALTER TABLE [dbo].[RentalHulling] CHECK CONSTRAINT [FK_RentalHulling_MJobWork]
GO
/****** Object:  ForeignKey [FK_HullingProcess_CustomerInfo]    Script Date: 07/12/2016 18:45:08 ******/
ALTER TABLE [dbo].[HullingProcess]  WITH CHECK ADD  CONSTRAINT [FK_HullingProcess_CustomerInfo] FOREIGN KEY([CustID])
REFERENCES [dbo].[CustomerInfo] ([CustID])
GO
ALTER TABLE [dbo].[HullingProcess] CHECK CONSTRAINT [FK_HullingProcess_CustomerInfo]
GO
/****** Object:  ForeignKey [FK_HullingProcess_MPaddyType]    Script Date: 07/12/2016 18:45:08 ******/
ALTER TABLE [dbo].[HullingProcess]  WITH CHECK ADD  CONSTRAINT [FK_HullingProcess_MPaddyType] FOREIGN KEY([PaddyTypeID])
REFERENCES [dbo].[MPaddyType] ([PaddyTypeID])
GO
ALTER TABLE [dbo].[HullingProcess] CHECK CONSTRAINT [FK_HullingProcess_MPaddyType]
GO
/****** Object:  ForeignKey [FK_HullingProcess_MUnitsType]    Script Date: 07/12/2016 18:45:08 ******/
ALTER TABLE [dbo].[HullingProcess]  WITH CHECK ADD  CONSTRAINT [FK_HullingProcess_MUnitsType] FOREIGN KEY([UnitsTypeID])
REFERENCES [dbo].[MUnitsType] ([UnitsTypeID])
GO
ALTER TABLE [dbo].[HullingProcess] CHECK CONSTRAINT [FK_HullingProcess_MUnitsType]
GO
/****** Object:  ForeignKey [fk_MGodownID]    Script Date: 07/12/2016 18:45:08 ******/
ALTER TABLE [dbo].[HullingProcess]  WITH CHECK ADD  CONSTRAINT [fk_MGodownID] FOREIGN KEY([MGodownID])
REFERENCES [dbo].[MGodownDetails] ([MGodownID])
GO
ALTER TABLE [dbo].[HullingProcess] CHECK CONSTRAINT [fk_MGodownID]
GO
/****** Object:  ForeignKey [fk_MLotID]    Script Date: 07/12/2016 18:45:08 ******/
ALTER TABLE [dbo].[HullingProcess]  WITH CHECK ADD  CONSTRAINT [fk_MLotID] FOREIGN KEY([MLotID])
REFERENCES [dbo].[MLotDetails] ([MLotID])
GO
ALTER TABLE [dbo].[HullingProcess] CHECK CONSTRAINT [fk_MLotID]
GO
/****** Object:  ForeignKey [fk_MediatorID]    Script Date: 07/12/2016 18:45:08 ******/
ALTER TABLE [dbo].[ProductSellingInfo]  WITH CHECK ADD  CONSTRAINT [fk_MediatorID] FOREIGN KEY([MediatorID])
REFERENCES [dbo].[MediatorInfo] ([MediatorID])
GO
ALTER TABLE [dbo].[ProductSellingInfo] CHECK CONSTRAINT [fk_MediatorID]
GO
/****** Object:  ForeignKey [FK_ProductSellingInfo_BuyerInfo]    Script Date: 07/12/2016 18:45:08 ******/
ALTER TABLE [dbo].[ProductSellingInfo]  WITH CHECK ADD  CONSTRAINT [FK_ProductSellingInfo_BuyerInfo] FOREIGN KEY([BuyerID])
REFERENCES [dbo].[BuyerInfo] ([BuyerID])
GO
ALTER TABLE [dbo].[ProductSellingInfo] CHECK CONSTRAINT [FK_ProductSellingInfo_BuyerInfo]
GO
/****** Object:  ForeignKey [FK_ProductSellingInfo_CustomerInfo]    Script Date: 07/12/2016 18:45:08 ******/
ALTER TABLE [dbo].[ProductSellingInfo]  WITH CHECK ADD  CONSTRAINT [FK_ProductSellingInfo_CustomerInfo] FOREIGN KEY([CustID])
REFERENCES [dbo].[CustomerInfo] ([CustID])
GO
ALTER TABLE [dbo].[ProductSellingInfo] CHECK CONSTRAINT [FK_ProductSellingInfo_CustomerInfo]
GO
/****** Object:  ForeignKey [FK_ProductSellingInfo_MBrokenRiceType]    Script Date: 07/12/2016 18:45:08 ******/
ALTER TABLE [dbo].[ProductSellingInfo]  WITH CHECK ADD  CONSTRAINT [FK_ProductSellingInfo_MBrokenRiceType] FOREIGN KEY([BrokenRiceTypeID])
REFERENCES [dbo].[MBrokenRiceType] ([BrokenRiceTypeID])
GO
ALTER TABLE [dbo].[ProductSellingInfo] CHECK CONSTRAINT [FK_ProductSellingInfo_MBrokenRiceType]
GO
/****** Object:  ForeignKey [FK_ProductSellingInfo_MRiceBrandDetails]    Script Date: 07/12/2016 18:45:08 ******/
ALTER TABLE [dbo].[ProductSellingInfo]  WITH CHECK ADD  CONSTRAINT [FK_ProductSellingInfo_MRiceBrandDetails] FOREIGN KEY([MRiceBrandID])
REFERENCES [dbo].[MRiceBrandDetails] ([MRiceBrandID])
GO
ALTER TABLE [dbo].[ProductSellingInfo] CHECK CONSTRAINT [FK_ProductSellingInfo_MRiceBrandDetails]
GO
/****** Object:  ForeignKey [FK_ProductSellingInfo_MRiceProductionType]    Script Date: 07/12/2016 18:45:08 ******/
ALTER TABLE [dbo].[ProductSellingInfo]  WITH CHECK ADD  CONSTRAINT [FK_ProductSellingInfo_MRiceProductionType] FOREIGN KEY([MRiceProdTypeID])
REFERENCES [dbo].[MRiceProductionType] ([MRiceProdTypeID])
GO
ALTER TABLE [dbo].[ProductSellingInfo] CHECK CONSTRAINT [FK_ProductSellingInfo_MRiceProductionType]
GO
/****** Object:  ForeignKey [FK_ProductSellingInfo_MUnitsType]    Script Date: 07/12/2016 18:45:08 ******/
ALTER TABLE [dbo].[ProductSellingInfo]  WITH CHECK ADD  CONSTRAINT [FK_ProductSellingInfo_MUnitsType] FOREIGN KEY([UnitsTypeID])
REFERENCES [dbo].[MUnitsType] ([UnitsTypeID])
GO
ALTER TABLE [dbo].[ProductSellingInfo] CHECK CONSTRAINT [FK_ProductSellingInfo_MUnitsType]
GO
/****** Object:  ForeignKey [FK_ProductSellingInfo_ProductPaymentInfo]    Script Date: 07/12/2016 18:45:08 ******/
ALTER TABLE [dbo].[ProductSellingInfo]  WITH CHECK ADD  CONSTRAINT [FK_ProductSellingInfo_ProductPaymentInfo] FOREIGN KEY([ProductPaymentID])
REFERENCES [dbo].[ProductPaymentInfo] ([ProductPaymentID])
GO
ALTER TABLE [dbo].[ProductSellingInfo] CHECK CONSTRAINT [FK_ProductSellingInfo_ProductPaymentInfo]
GO
/****** Object:  ForeignKey [fk_ProductPaymentTransaction_BuyerID]    Script Date: 07/12/2016 18:45:08 ******/
ALTER TABLE [dbo].[ProductPaymentTransaction]  WITH CHECK ADD  CONSTRAINT [fk_ProductPaymentTransaction_BuyerID] FOREIGN KEY([BuyerID])
REFERENCES [dbo].[BuyerInfo] ([BuyerID])
GO
ALTER TABLE [dbo].[ProductPaymentTransaction] CHECK CONSTRAINT [fk_ProductPaymentTransaction_BuyerID]
GO
/****** Object:  ForeignKey [FK_ProductPaymentTransaction_CustomerInfo]    Script Date: 07/12/2016 18:45:08 ******/
ALTER TABLE [dbo].[ProductPaymentTransaction]  WITH CHECK ADD  CONSTRAINT [FK_ProductPaymentTransaction_CustomerInfo] FOREIGN KEY([CustID])
REFERENCES [dbo].[CustomerInfo] ([CustID])
GO
ALTER TABLE [dbo].[ProductPaymentTransaction] CHECK CONSTRAINT [FK_ProductPaymentTransaction_CustomerInfo]
GO
/****** Object:  ForeignKey [FK_ProductPaymentTransaction_ProductPaymentInfo]    Script Date: 07/12/2016 18:45:08 ******/
ALTER TABLE [dbo].[ProductPaymentTransaction]  WITH CHECK ADD  CONSTRAINT [FK_ProductPaymentTransaction_ProductPaymentInfo] FOREIGN KEY([ProductPaymentID])
REFERENCES [dbo].[ProductPaymentInfo] ([ProductPaymentID])
GO
ALTER TABLE [dbo].[ProductPaymentTransaction] CHECK CONSTRAINT [FK_ProductPaymentTransaction_ProductPaymentInfo]
GO
/****** Object:  ForeignKey [fk_ProPayTranMediatorID]    Script Date: 07/12/2016 18:45:08 ******/
ALTER TABLE [dbo].[ProductPaymentTransaction]  WITH CHECK ADD  CONSTRAINT [fk_ProPayTranMediatorID] FOREIGN KEY([MediatorID])
REFERENCES [dbo].[MediatorInfo] ([MediatorID])
GO
ALTER TABLE [dbo].[ProductPaymentTransaction] CHECK CONSTRAINT [fk_ProPayTranMediatorID]
GO
/****** Object:  ForeignKey [FK_PaddyStockInfo_CustomerInfo]    Script Date: 07/12/2016 18:45:08 ******/
ALTER TABLE [dbo].[PaddyStockInfo]  WITH CHECK ADD  CONSTRAINT [FK_PaddyStockInfo_CustomerInfo] FOREIGN KEY([CustID])
REFERENCES [dbo].[CustomerInfo] ([CustID])
GO
ALTER TABLE [dbo].[PaddyStockInfo] CHECK CONSTRAINT [FK_PaddyStockInfo_CustomerInfo]
GO
/****** Object:  ForeignKey [FK_PaddyStockInfo_MGodownDetails]    Script Date: 07/12/2016 18:45:08 ******/
ALTER TABLE [dbo].[PaddyStockInfo]  WITH CHECK ADD  CONSTRAINT [FK_PaddyStockInfo_MGodownDetails] FOREIGN KEY([MGodownID])
REFERENCES [dbo].[MGodownDetails] ([MGodownID])
GO
ALTER TABLE [dbo].[PaddyStockInfo] CHECK CONSTRAINT [FK_PaddyStockInfo_MGodownDetails]
GO
/****** Object:  ForeignKey [FK_PaddyStockInfo_MLotDetails]    Script Date: 07/12/2016 18:45:08 ******/
ALTER TABLE [dbo].[PaddyStockInfo]  WITH CHECK ADD  CONSTRAINT [FK_PaddyStockInfo_MLotDetails] FOREIGN KEY([MLotID])
REFERENCES [dbo].[MLotDetails] ([MLotID])
GO
ALTER TABLE [dbo].[PaddyStockInfo] CHECK CONSTRAINT [FK_PaddyStockInfo_MLotDetails]
GO
/****** Object:  ForeignKey [FK_PaddyStockInfo_MPaddyType]    Script Date: 07/12/2016 18:45:08 ******/
ALTER TABLE [dbo].[PaddyStockInfo]  WITH CHECK ADD  CONSTRAINT [FK_PaddyStockInfo_MPaddyType] FOREIGN KEY([PaddyTypeID])
REFERENCES [dbo].[MPaddyType] ([PaddyTypeID])
GO
ALTER TABLE [dbo].[PaddyStockInfo] CHECK CONSTRAINT [FK_PaddyStockInfo_MPaddyType]
GO
/****** Object:  ForeignKey [FK_PaddyStockInfo_SellerInfo]    Script Date: 07/12/2016 18:45:08 ******/
ALTER TABLE [dbo].[PaddyStockInfo]  WITH CHECK ADD  CONSTRAINT [FK_PaddyStockInfo_SellerInfo] FOREIGN KEY([SellerID])
REFERENCES [dbo].[SellerInfo] ([SellerID])
GO
ALTER TABLE [dbo].[PaddyStockInfo] CHECK CONSTRAINT [FK_PaddyStockInfo_SellerInfo]
GO
/****** Object:  ForeignKey [fk_UnitsTypeID]    Script Date: 07/12/2016 18:45:08 ******/
ALTER TABLE [dbo].[PaddyStockInfo]  WITH CHECK ADD  CONSTRAINT [fk_UnitsTypeID] FOREIGN KEY([UnitsTypeID])
REFERENCES [dbo].[MUnitsType] ([UnitsTypeID])
GO
ALTER TABLE [dbo].[PaddyStockInfo] CHECK CONSTRAINT [fk_UnitsTypeID]
GO
/****** Object:  ForeignKey [FK_PaddyPaymentDetails_CustomerInfo]    Script Date: 07/12/2016 18:45:08 ******/
ALTER TABLE [dbo].[PaddyPaymentDetails]  WITH CHECK ADD  CONSTRAINT [FK_PaddyPaymentDetails_CustomerInfo] FOREIGN KEY([CustID])
REFERENCES [dbo].[CustomerInfo] ([CustID])
GO
ALTER TABLE [dbo].[PaddyPaymentDetails] CHECK CONSTRAINT [FK_PaddyPaymentDetails_CustomerInfo]
GO
/****** Object:  ForeignKey [FK_PaddyPaymentDetails_SellerInfo]    Script Date: 07/12/2016 18:45:08 ******/
ALTER TABLE [dbo].[PaddyPaymentDetails]  WITH CHECK ADD  CONSTRAINT [FK_PaddyPaymentDetails_SellerInfo] FOREIGN KEY([SellerID])
REFERENCES [dbo].[SellerInfo] ([SellerID])
GO
ALTER TABLE [dbo].[PaddyPaymentDetails] CHECK CONSTRAINT [FK_PaddyPaymentDetails_SellerInfo]
GO
/****** Object:  ForeignKey [fk_PaddyStockID]    Script Date: 07/12/2016 18:45:08 ******/
ALTER TABLE [dbo].[PaddyPaymentDetails]  WITH CHECK ADD  CONSTRAINT [fk_PaddyStockID] FOREIGN KEY([PaddyStockID])
REFERENCES [dbo].[PaddyStockInfo] ([PaddyStockID])
GO
ALTER TABLE [dbo].[PaddyPaymentDetails] CHECK CONSTRAINT [fk_PaddyStockID]
GO
/****** Object:  ForeignKey [FK_HullingTransaction_CustomerInfo]    Script Date: 07/12/2016 18:45:08 ******/
ALTER TABLE [dbo].[HullingTransaction]  WITH CHECK ADD  CONSTRAINT [FK_HullingTransaction_CustomerInfo] FOREIGN KEY([CustID])
REFERENCES [dbo].[CustomerInfo] ([CustID])
GO
ALTER TABLE [dbo].[HullingTransaction] CHECK CONSTRAINT [FK_HullingTransaction_CustomerInfo]
GO
/****** Object:  ForeignKey [FK_HullingTransaction_HullingProcess]    Script Date: 07/12/2016 18:45:08 ******/
ALTER TABLE [dbo].[HullingTransaction]  WITH CHECK ADD  CONSTRAINT [FK_HullingTransaction_HullingProcess] FOREIGN KEY([HullingProcessID])
REFERENCES [dbo].[HullingProcess] ([HullingProcessID])
GO
ALTER TABLE [dbo].[HullingTransaction] CHECK CONSTRAINT [FK_HullingTransaction_HullingProcess]
GO
/****** Object:  ForeignKey [FK_HullingTransaction_MBrokenRiceType]    Script Date: 07/12/2016 18:45:08 ******/
ALTER TABLE [dbo].[HullingTransaction]  WITH CHECK ADD  CONSTRAINT [FK_HullingTransaction_MBrokenRiceType] FOREIGN KEY([BrokenRiceTypeID])
REFERENCES [dbo].[MBrokenRiceType] ([BrokenRiceTypeID])
GO
ALTER TABLE [dbo].[HullingTransaction] CHECK CONSTRAINT [FK_HullingTransaction_MBrokenRiceType]
GO
/****** Object:  ForeignKey [FK_HullingTransaction_MRiceProductionType]    Script Date: 07/12/2016 18:45:08 ******/
ALTER TABLE [dbo].[HullingTransaction]  WITH CHECK ADD  CONSTRAINT [FK_HullingTransaction_MRiceProductionType] FOREIGN KEY([MRiceProdTypeID])
REFERENCES [dbo].[MRiceProductionType] ([MRiceProdTypeID])
GO
ALTER TABLE [dbo].[HullingTransaction] CHECK CONSTRAINT [FK_HullingTransaction_MRiceProductionType]
GO
/****** Object:  ForeignKey [FK_HullingTransaction_MUnitsType]    Script Date: 07/12/2016 18:45:08 ******/
ALTER TABLE [dbo].[HullingTransaction]  WITH CHECK ADD  CONSTRAINT [FK_HullingTransaction_MUnitsType] FOREIGN KEY([UnitsTypeID])
REFERENCES [dbo].[MUnitsType] ([UnitsTypeID])
GO
ALTER TABLE [dbo].[HullingTransaction] CHECK CONSTRAINT [FK_HullingTransaction_MUnitsType]
GO
/****** Object:  ForeignKey [fk_MRiceBrandID]    Script Date: 07/12/2016 18:45:08 ******/
ALTER TABLE [dbo].[HullingTransaction]  WITH CHECK ADD  CONSTRAINT [fk_MRiceBrandID] FOREIGN KEY([MRiceBrandID])
REFERENCES [dbo].[MRiceBrandDetails] ([MRiceBrandID])
GO
ALTER TABLE [dbo].[HullingTransaction] CHECK CONSTRAINT [fk_MRiceBrandID]
GO
/****** Object:  ForeignKey [fk_CustID]    Script Date: 07/12/2016 18:45:08 ******/
ALTER TABLE [dbo].[HullingProcessExpenses]  WITH CHECK ADD  CONSTRAINT [fk_CustID] FOREIGN KEY([CustID])
REFERENCES [dbo].[CustomerInfo] ([CustID])
GO
ALTER TABLE [dbo].[HullingProcessExpenses] CHECK CONSTRAINT [fk_CustID]
GO
/****** Object:  ForeignKey [FK_HullingProcessExpenses_HullingProcess]    Script Date: 07/12/2016 18:45:08 ******/
ALTER TABLE [dbo].[HullingProcessExpenses]  WITH CHECK ADD  CONSTRAINT [FK_HullingProcessExpenses_HullingProcess] FOREIGN KEY([HullingProcessID])
REFERENCES [dbo].[HullingProcess] ([HullingProcessID])
GO
ALTER TABLE [dbo].[HullingProcessExpenses] CHECK CONSTRAINT [FK_HullingProcessExpenses_HullingProcess]
GO
