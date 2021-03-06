USE [master]
GO
/****** Object:  Database [RMIS]    Script Date: 08/10/2016 11:42:04 ******/
CREATE DATABASE [RMIS] ON  PRIMARY 
( NAME = N'RMIS', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\RMIS.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
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
/****** Object:  Schema [Audit]    Script Date: 08/10/2016 11:42:04 ******/
CREATE SCHEMA [Audit] AUTHORIZATION [dbo]
GO
/****** Object:  Table [dbo].[MRoles]    Script Date: 08/10/2016 11:42:05 ******/
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
/****** Object:  Table [dbo].[MailQueue]    Script Date: 08/10/2016 11:42:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MailQueue](
	[MailId] [nvarchar](50) NOT NULL,
	[MessageBody] [nvarchar](max) NULL,
	[Subject] [nvarchar](50) NULL,
	[ToEmail] [nvarchar](50) NULL,
	[FromEmail] [nvarchar](50) NULL,
	[Status] [char](1) NULL,
	[LastModifiedDate] [datetime] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MenuInfo]    Script Date: 08/10/2016 11:42:05 ******/
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
INSERT [dbo].[MenuInfo] ([MenuID], [ParentMenuID], [Title], [Description], [URL], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (43, 1, N'Add Bank Balance                                  ', N'Add Bank Balance', N'BankTransaction.ascx', N'System', CAST(0x0000A6420108FF74 AS DateTime), N'N')
INSERT [dbo].[MenuInfo] ([MenuID], [ParentMenuID], [Title], [Description], [URL], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (44, 21, N'Bank Transaction Report                           ', N'Bank Transaction Report', N'RPT_BankTransactionReport.ascx', N'System', CAST(0x0000A643009D5100 AS DateTime), N'N')
INSERT [dbo].[MenuInfo] ([MenuID], [ParentMenuID], [Title], [Description], [URL], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (45, 0, N'Receipts                                          ', N'Receipts', N'', N'System', CAST(0x0000A6510112E69C AS DateTime), N'N')
INSERT [dbo].[MenuInfo] ([MenuID], [ParentMenuID], [Title], [Description], [URL], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (46, 45, N'Paddy Purchase Receipt                            ', N'Paddy Purchase Receipt', N'RPT_PaddyPurchaseReceiptReport.ascx', N'System', CAST(0x0000A65101134232 AS DateTime), N'N')
INSERT [dbo].[MenuInfo] ([MenuID], [ParentMenuID], [Title], [Description], [URL], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (47, 45, N'Paddy Payment Receipt                             ', N'Paddy Payment Receipt', N'RPT_PaddyPaymentReceiptReport.ascx', N'System', CAST(0x0000A65200DE4225 AS DateTime), N'N')
INSERT [dbo].[MenuInfo] ([MenuID], [ParentMenuID], [Title], [Description], [URL], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (48, 21, N'Product Payment Due                               ', N'Product Payment Due', N'RPT_ProductPaymentDue.ascx', N'System', CAST(0x0000A65600CD5CED AS DateTime), N'N')
INSERT [dbo].[MenuInfo] ([MenuID], [ParentMenuID], [Title], [Description], [URL], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (49, 21, N'Expense Details                                   ', N'Expense Details', N'RPT_ExpenseDetailsReport.ascx', N'System', CAST(0x0000A6560113E85D AS DateTime), N'N')
INSERT [dbo].[MenuInfo] ([MenuID], [ParentMenuID], [Title], [Description], [URL], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (50, 1, N'Add Profile Details                               ', N'Add Profile Details', N'ProfileDetails.ascx', N'System', CAST(0x0000A656017917FB AS DateTime), N'N')
INSERT [dbo].[MenuInfo] ([MenuID], [ParentMenuID], [Title], [Description], [URL], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (51, 45, N'Product Selling Invoice                           ', N'Product Selling Invoice', N'RPT_ProductSellingInvoiceReport.ascx', N'System', CAST(0x0000A65C01415169 AS DateTime), N'N')
/****** Object:  Table [dbo].[MenuConfiguration]    Script Date: 08/10/2016 11:42:05 ******/
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
/****** Object:  StoredProcedure [Audit].[pAutoAudit]    Script Date: 08/10/2016 11:42:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [Audit].[pAutoAudit] 
	(
	@SchemaName			sysname		= 'dbo',--this is the default schema name for the tables getting AutoAudit added
	@TableName			sysname,			--enter the name of the table to add AutoAudit to.
	@ColumnNames		varchar(max)= '<All>',  --columns to include when logging details (@Log...=2). Default = '<All>'. Format: '[Col1],[Col2],...'
	@StrictUserContext	bit			= 1,    -- 2.00 if 0 then permits DML setting of Created, CreatedBy, Modified, ModifiedBy
	@LogSQL				bit			= 0,	-- 0 = Don't log SQL statement in AuditHeader, 1 = log the SQL statement
	@BaseTableDDL		bit			= 0,	-- 0 = don't add audit columns to base table, 1 = add audit columns to base table
	@LogInsert			tinyint		= 2,	-- 0 = nothing, 1 = header only, 2 = header and detail
	@LogUpdate			tinyint		= 2,	-- 0 = nothing, 1 = header only, 2 = header and detail
	@LogDelete			tinyint		= 2		-- 0 = nothing, 1 = header only, 2 = header and detail
	) with recompile
AS 

-- Created for AutoAudit Version 3.30a
-- created by Paul Nielsen and John Sigouin
-- www.SQLServerBible.com
-- AutoAudit.codeplex.com
-- This SP is used to add AutoAudit to a specified table.

SET NoCount ON
 
DECLARE @SQL NVARCHAR(max),
		@SQLColumns NVARCHAR(max),
		@Version VARCHAR(5),
		@AuditSchema VARCHAR(50),
		@ViewSchema VARCHAR(50),
		@RowHistoryViewScope VARCHAR(20),
		@DeletedViewScope VARCHAR(20),
		@AddExtendedProperties VARCHAR(1),
		@CreatedColumnName sysname,
		@CreatedByColumnName sysname,
		@ModifiedColumnName sysname,
		@ModifiedByColumnName sysname,
		@RowVersionColumnName sysname,
		@CreateDeletedView bit,
		@CreateRowHistoryView bit,
		@CreateRowHistoryFunction bit,
		@CreateTableRecoveryFunction bit,
		@WithLogFlag bit,
		@DateStyle VARCHAR(3),
		@ViewPrefix varchar(10),
		@UDFPrefix varchar(10),
		@RowHistoryViewSuffix varchar(20),
		@DeletedViewSuffix varchar(20),
		@RowHistoryFunctionSuffix varchar(20),
		@TableRecoveryFunctionSuffix varchar(20)

--get the schema for the AutoAudit objects
--*********************************************************************************
Set @AuditSchema = null		--set this manually if you have more than one instance 
							--of AutoAudit objects in the database. Otherwise leave 
							--it set to null
--*********************************************************************************
If @AuditSchema is null
	Begin
		If (Select count(*) from sys.objects where name='AuditSettings' and [type] ='U') > 1
			Begin
				Raiserror ('There is more than 1 instance of AutoAudit in this db. @AuditSchema MUST be set manually in the pAutoAudit Stored Procedure.',16,0)
				Return
			End
		Else
			SELECT @AuditSchema = Schema_name(schema_id) from sys.objects where [name]='AuditSettings' and [type] ='U'
	End

--get [AuditSettings] - @Version
Select	@SQL = 'SELECT @SettingValue = [SettingValue] from ' + quotename(@AuditSchema) + '.[AuditSettings] where [SettingName] = ''Version'''
EXEC sp_executesql @SQL, N'@SettingValue varchar(100) OUTPUT', @Version OUTPUT

--get [AuditSettings] - @ViewSchema
Select	@SQL = 'SELECT @SettingValue = [SettingValue] from ' + quotename(@AuditSchema) + '.[AuditSettings] where [SettingName] = ''Schema for _RowHistory and _Deleted objects'''
EXEC sp_executesql @SQL, N'@SettingValue varchar(100) OUTPUT', @ViewSchema OUTPUT
If @ViewSchema = '<TableSchema>' Set @ViewSchema = @SchemaName

--get [AuditSettings] - @DateStyle
Select	@SQL = 'SELECT @SettingValue = [SettingValue] from ' + quotename(@AuditSchema) + '.[AuditSettings] where [SettingName] = ''DateStyle'''
EXEC sp_executesql @SQL, N'@SettingValue varchar(100) OUTPUT', @DateStyle OUTPUT
If isnull(@DateStyle,'') not in ('113','121') Set @DateStyle = '113'

--get [AuditSettings] - @RowHistoryViewScope
Select	@SQL = 'SELECT @SettingValue = isnull([SettingValue],''Active'') from ' + quotename(@AuditSchema) + '.[AuditSettings] where [SettingName] = ''RowHistory View Scope'''
EXEC sp_executesql @SQL, N'@SettingValue varchar(100) OUTPUT', @RowHistoryViewScope OUTPUT
If isnull(@RowHistoryViewScope,'') not in ('Active','Archive','All') Set @RowHistoryViewScope = 'Active'

--get [AuditSettings] - @DeletedViewScope
Select	@SQL = 'SELECT @SettingValue = isnull([SettingValue],''Active'') from ' + quotename(@AuditSchema) + '.[AuditSettings] where [SettingName] = ''Deleted View Scope'''
EXEC sp_executesql @SQL, N'@SettingValue varchar(100) OUTPUT', @DeletedViewScope OUTPUT
If isnull(@DeletedViewScope,'') not in ('Active','Archive','All') Set @DeletedViewScope = 'Active'

--get [AuditSettings] - @AddExtendedProperties
Select	@SQL = 'SELECT @SettingValue = isnull([SettingValue],''1'') from ' + quotename(@AuditSchema) + '.[AuditSettings] where [SettingName] = ''Add Extended Properties Flag'''
EXEC sp_executesql @SQL, N'@SettingValue varchar(100) OUTPUT', @AddExtendedProperties OUTPUT

--get [AuditSettings] - @CreatedColumnName
Select	@SQL = 'SELECT @SettingValue = isnull([SettingValue],''Created'') from ' + quotename(@AuditSchema) + '.[AuditSettings] where [SettingName] = ''CreatedColumnName'''
EXEC sp_executesql @SQL, N'@SettingValue varchar(100) OUTPUT', @CreatedColumnName OUTPUT

--get [AuditSettings] - @CreatedByColumnName
Select	@SQL = 'SELECT @SettingValue = isnull([SettingValue],''CreatedBy'') from ' + quotename(@AuditSchema) + '.[AuditSettings] where [SettingName] = ''CreatedByColumnName'''
EXEC sp_executesql @SQL, N'@SettingValue varchar(100) OUTPUT', @CreatedByColumnName OUTPUT

--get [AuditSettings] - @ModifiedColumnName
Select	@SQL = 'SELECT @SettingValue = isnull([SettingValue],''Modified'') from ' + quotename(@AuditSchema) + '.[AuditSettings] where [SettingName] = ''ModifiedColumnName'''
EXEC sp_executesql @SQL, N'@SettingValue varchar(100) OUTPUT', @ModifiedColumnName OUTPUT

--get [AuditSettings] - @ModifiedByColumnName
Select	@SQL = 'SELECT @SettingValue = isnull([SettingValue],''ModifiedBy'') from ' + quotename(@AuditSchema) + '.[AuditSettings] where [SettingName] = ''ModifiedByColumnName'''
EXEC sp_executesql @SQL, N'@SettingValue varchar(100) OUTPUT', @ModifiedByColumnName OUTPUT

--get [AuditSettings] - @RowVersionColumnName
Select	@SQL = 'SELECT @SettingValue = isnull([SettingValue],''RowVersion'') from ' + quotename(@AuditSchema) + '.[AuditSettings] where [SettingName] = ''RowVersionColumnName'''
EXEC sp_executesql @SQL, N'@SettingValue varchar(100) OUTPUT', @RowVersionColumnName OUTPUT

--get [AuditSettings] - @ViewPrefix
Select	@SQL = 'SELECT @SettingValue = isnull([SettingValue],''v'') from ' + quotename(@AuditSchema) + '.[AuditSettings] where [SettingName] = ''ViewPrefix'''
EXEC sp_executesql @SQL, N'@SettingValue varchar(100) OUTPUT', @ViewPrefix OUTPUT
Select @ViewPrefix = isnull(LTRIM(RTRIM(@ViewPrefix)),'')

--get [AuditSettings] - @UDFPrefix
Select	@SQL = 'SELECT @SettingValue = isnull([SettingValue],'''') from ' + quotename(@AuditSchema) + '.[AuditSettings] where [SettingName] = ''UDFPrefix'''
EXEC sp_executesql @SQL, N'@SettingValue varchar(100) OUTPUT', @UDFPrefix OUTPUT
Select @UDFPrefix = isnull(LTRIM(RTRIM(@UDFPrefix)),'')

--get [AuditSettings] - @RowHistoryViewSuffix
Select	@SQL = 'SELECT @SettingValue = isnull([SettingValue],'''') from ' + quotename(@AuditSchema) + '.[AuditSettings] where [SettingName] = ''RowHistoryViewSuffix'''
EXEC sp_executesql @SQL, N'@SettingValue varchar(100) OUTPUT', @RowHistoryViewSuffix OUTPUT
Select @RowHistoryViewSuffix = isnull(LTRIM(RTRIM(@RowHistoryViewSuffix)),'_RowHistory')

--get [AuditSettings] - @DeletedViewSuffix
Select	@SQL = 'SELECT @SettingValue = isnull([SettingValue],'''') from ' + quotename(@AuditSchema) + '.[AuditSettings] where [SettingName] = ''DeletedViewSuffix'''
EXEC sp_executesql @SQL, N'@SettingValue varchar(100) OUTPUT', @DeletedViewSuffix OUTPUT
Select @DeletedViewSuffix = isnull(LTRIM(RTRIM(@DeletedViewSuffix)),'_Deleted')

--get [AuditSettings] - @RowHistoryFunctionSuffix
Select	@SQL = 'SELECT @SettingValue = isnull([SettingValue],'''') from ' + quotename(@AuditSchema) + '.[AuditSettings] where [SettingName] = ''RowHistoryFunctionSuffix'''
EXEC sp_executesql @SQL, N'@SettingValue varchar(100) OUTPUT', @RowHistoryFunctionSuffix OUTPUT
Select @RowHistoryFunctionSuffix = isnull(LTRIM(RTRIM(@RowHistoryFunctionSuffix)),'_RowHistory')

--get [AuditSettings] - @TableRecoveryFunctionSuffix
Select	@SQL = 'SELECT @SettingValue = isnull([SettingValue],'''') from ' + quotename(@AuditSchema) + '.[AuditSettings] where [SettingName] = ''TableRecoveryFunctionSuffix'''
EXEC sp_executesql @SQL, N'@SettingValue varchar(100) OUTPUT', @TableRecoveryFunctionSuffix OUTPUT
Select @TableRecoveryFunctionSuffix = isnull(LTRIM(RTRIM(@TableRecoveryFunctionSuffix)),'_TableRecovery')

--get [AuditSettings] - @CreateDeletedView
Select	@SQL = 'SELECT @SettingValue = isnull([SettingValue],''1'') from ' + quotename(@AuditSchema) + '.[AuditSettings] where [SettingName] = ''Default _Deleted view Creation Flag'''
EXEC sp_executesql @SQL, N'@SettingValue varchar(100) OUTPUT', @CreateDeletedView OUTPUT

--get [AuditSettings] - @CreateRowHistoryView
Select	@SQL = 'SELECT @SettingValue = isnull([SettingValue],''1'') from ' + quotename(@AuditSchema) + '.[AuditSettings] where [SettingName] = ''Default _RowHistory view Creation Flag'''
EXEC sp_executesql @SQL, N'@SettingValue varchar(100) OUTPUT', @CreateRowHistoryView OUTPUT

--get [AuditSettings] - @CreateRowHistoryFunction
Select	@SQL = 'SELECT @SettingValue = isnull([SettingValue],''1'') from ' + quotename(@AuditSchema) + '.[AuditSettings] where [SettingName] = ''Default _RowHistory function Creation Flag'''
EXEC sp_executesql @SQL, N'@SettingValue varchar(100) OUTPUT', @CreateRowHistoryFunction OUTPUT

--get [AuditSettings] - @CreateTableRecoveryFunction
Select	@SQL = 'SELECT @SettingValue = isnull([SettingValue],''1'') from ' + quotename(@AuditSchema) + '.[AuditSettings] where [SettingName] = ''Default _TableRecovery function Creation Flag'''
EXEC sp_executesql @SQL, N'@SettingValue varchar(100) OUTPUT', @CreateTableRecoveryFunction OUTPUT

--get [AuditSettings] - @WithLogFlag
Select	@SQL = 'SELECT @SettingValue = isnull([SettingValue],''0'') from ' + quotename(@AuditSchema) + '.[AuditSettings] where [SettingName] = ''Raiserror to Windows Log Flag'''
EXEC sp_executesql @SQL, N'@SettingValue varchar(100) OUTPUT', @WithLogFlag OUTPUT

-- script to create autoAudit triggers
declare @PKColumnNameList varchar(1024)
declare @PKColumnNameConcatenationWithQuotename varchar(1024)
declare @PKColumnNameListIfUpdate varchar(1024)
declare @RowHistoryUDFFilter varchar(1024)
declare @PKColumnNameConcatenationWithQuotenameAndDateConvert varchar(1024)
declare @PKColumnNameListWithDateConvert varchar(1024)
declare @PKColumnsForDeletedView varchar(1024)
declare @PKColumnQty smallint

set @PKColumnNameList = ''
set @PKColumnNameConcatenationWithQuotename = ''
set @PKColumnNameListIfUpdate = ''
set @RowHistoryUDFFilter = 'WHERE		'
set @PKColumnNameConcatenationWithQuotenameAndDateConvert = ''
set @PKColumnNameListWithDateConvert = ''
set @PKColumnsForDeletedView = ''
set @PKColumnQty = 0

--get PK Columns
select		@PKColumnNameConcatenationWithQuotename = @PKColumnNameConcatenationWithQuotename + 'quotename(' + 'src.[' + c.name + ']) + '
			,@PKColumnNameList = @PKColumnNameList + '[' + c.name + '],'
			,@PKColumnNameConcatenationWithQuotenameAndDateConvert = @PKColumnNameConcatenationWithQuotenameAndDateConvert + 'quotename(' + 'convert(varchar(36),src.[' + c.name + '],' + @DateStyle + ')) + '
			,@PKColumnNameListWithDateConvert = @PKColumnNameListWithDateConvert + 'convert(varchar(36),src.[' + c.name + '],' + @DateStyle + '), '
			,@PKColumnNameListIfUpdate = @PKColumnNameListIfUpdate + 'update ([' + c.name + ']) or '
			,@RowHistoryUDFFilter = @RowHistoryUDFFilter + '[' + c.name + '] = @PK' + isnull(nullif(cast(@PKColumnQty + 1 as varchar(1)),1), '') + ' AND '
			,@PKColumnsForDeletedView = @PKColumnsForDeletedView + '		,PivotData.PrimaryKey' + isnull(nullif(cast(@PKColumnQty + 1 as varchar(1)),1), '') + ' as [' + c.name + ']' + Char(13) + Char(10)
			,@PKColumnQty = @PKColumnQty + 1
from		sys.tables t
inner join	sys.schemas s
	on		s.schema_id = t.schema_id
inner join	sys.indexes i
	on		t.object_id = i.object_id
inner join	sys.index_columns ic
	on		i.object_id = ic.object_id
	and		i.index_id = ic.index_id
inner join	sys.columns c
	on		ic.object_id = c.object_id
	and		ic.column_id = c.column_id
inner join	sys.types as ty
	on		ty.user_type_id = c.user_type_id
where		i.is_primary_key = 1 
	AND		t.name = @TableName 
	AND		s.name = @SchemaName
    AND		ty.name NOT IN ('text', 'ntext', 'image', 'geography', 'xml', 'binary', 'varbinary', 'timestamp', 'rowversion')

select @PKColumnNameConcatenationWithQuotename = reverse(substring(reverse(@PKColumnNameConcatenationWithQuotename),4,1024))
select @PKColumnNameListIfUpdate = 'if ' + reverse(substring(reverse(@PKColumnNameListIfUpdate),4,1024))
select @RowHistoryUDFFilter = reverse(substring(reverse(@RowHistoryUDFFilter),5,1024))
select @PKColumnNameConcatenationWithQuotenameAndDateConvert = reverse(substring(reverse(@PKColumnNameConcatenationWithQuotenameAndDateConvert),4,1024))
select @PKColumnNameListWithDateConvert = reverse(substring(reverse(@PKColumnNameListWithDateConvert),3,1024))
select @PKColumnsForDeletedView = reverse(substring(reverse('		'+ substring(@PKColumnsForDeletedView,4,1024)),3,1024))

-- Table no-PK Check  
  IF @PKColumnQty = 0
  BEGIN 
    PRINT '*** ' + quotename(@SchemaName) + '.' + quotename(@TableName) + ' invalid Table - no Primary Key or invalid Primary Key data type. No triggers created.' + Char(13) + Char(10) + Char(13) + Char(10)
    RETURN
  END  
   
-- Table HierarchyID-PK Check  
  IF exists (select 1
  from sys.tables t
    join sys.schemas s
      on s.schema_id = t.schema_id
    join sys.indexes i
      on t.object_id = i.object_id
    join sys.index_columns ic
  	  on i.object_id = ic.object_id
      and i.index_id = ic.index_id
    join sys.columns c
      on ic.object_id = c.object_id
      and ic.column_id = c.column_id
	join sys.types as ty
	  on ty.user_type_id = c.user_type_id
  where i.is_primary_key = 1 AND t.name = @TableName AND s.name = @SchemaName AND ty.name = 'HierarchyID')
  BEGIN 
    PRINT '*** ' + quotename(@SchemaName) + '.' + quotename(@TableName) + ' HierarchyID PK. No triggers created.' + Char(13) + Char(10)
    RETURN
  END  

IF @StrictUserContext = 0 AND @BaseTableDDL = 0 
  BEGIN 
    RAISERROR('@StrictUserContext = 0 requires  @BaseTableDDL = 1. No triggers created.' , 16,1)
    RETURN 
  END  

--set the context info to bypass ddl trigger
Set context_info 0x1;

PRINT 'Creating AutoAudit for table: ' + quotename(@SchemaName) + '.' + quotename(@TableName) 
PRINT '	Options:  @StrictUserContext=' + isnull(cast(@StrictUserContext as varchar),'<null>') +
				', @LogSQL=' + isnull(cast(@LogSQL as varchar),'<null>') +
				', @BaseTableDDL=' + isnull(cast(@BaseTableDDL as varchar),'<null>') +
				', @LogInsert=' + isnull(cast(@LogInsert as varchar),'<null>') +
				', @LogUpdate=' + isnull(cast(@LogUpdate as varchar),'<null>') +
				', @LogDelete=' + isnull(cast(@LogDelete as varchar),'<null>') +
				', @AuditSchema=''' + isnull(@AuditSchema,'<null>') + '''' +
				', @ColumnNames=''' + isnull(@ColumnNames,'<null>') + ''''
 
PRINT '	Dropping existing AutoAudit components'

--Create temp table for ViewSchema of existing objects
Create table #ViewSchema (ViewSchema sysname)

declare @DeletedViewSchema sysname
Select @DeletedViewSchema = isnull((Select ViewSchema from #ViewSchema),@ViewSchema)

-- drop existing insert trigger
SET @SQL = 'If EXISTS (Select * from sys.objects o join sys.schemas s on o.schema_id = s.schema_id  '
       + ' where s.name = ''' + @SchemaName + ''''
       + '   and o.name = ''' + @TableName + '_Audit_Insert' + ''' )'
       + ' DROP TRIGGER ' + quotename(@SchemaName) + '.' + quotename(@TableName + '_Audit_Insert')
EXEC (@SQL)

-- drop existing update trigger
SET @SQL = 'If EXISTS (Select * from sys.objects o join sys.schemas s on o.schema_id = s.schema_id  '
       + ' where s.name = ''' + @SchemaName + ''''
       + '   and o.name = ''' + @TableName + '_Audit_Update' + ''' )'
       + ' DROP TRIGGER ' + quotename(@SchemaName) + '.' + quotename(@TableName + '_Audit_Update')
EXEC (@SQL)

-- drop existing delete trigger
SET @SQL = 'If EXISTS (Select * from sys.objects o join sys.schemas s on o.schema_id = s.schema_id  '
       + ' where s.name = ''' + @SchemaName + ''''
       + '   and o.name = ''' + @TableName + '_Audit_Delete' + ''' )'
       + ' DROP TRIGGER ' + quotename(@SchemaName) + '.' + quotename(@TableName + '_Audit_Delete')
EXEC (@SQL)

-- drop existing _Deleted view for the new view schema
SET @SQL = 'If EXISTS (Select * from sys.objects o join sys.schemas s on o.schema_id = s.schema_id  '
       + ' where s.name = ''' + @DeletedViewSchema + ''''
       + '   and o.name = ''' + @ViewPrefix + @TableName + @DeletedViewSuffix + ''' )'
       + ' DROP VIEW ' + quotename(@DeletedViewSchema) + '.' + quotename(@ViewPrefix + @TableName + @DeletedViewSuffix)
EXEC (@SQL)

-- drop existing _RowHistory view for the new view schema
SET @SQL = 'If EXISTS (Select * from sys.objects o join sys.schemas s on o.schema_id = s.schema_id  '
       + ' where s.name = ''' + @DeletedViewSchema + ''''
       + '   and o.name = ''' + @ViewPrefix + @TableName + @RowHistoryViewSuffix + ''' )'
       + ' DROP VIEW ' + quotename(@DeletedViewSchema) + '.' + quotename(@ViewPrefix + @TableName + @RowHistoryViewSuffix)
EXEC (@SQL)

-- drop existing _RowHistory UDF for the new view schema
SET @SQL = 'If EXISTS (Select * from sys.objects o join sys.schemas s on o.schema_id = s.schema_id  '
       + ' where s.name = ''' + @DeletedViewSchema + ''''
       + '   and o.name = ''' + @UDFPrefix + @TableName + @RowHistoryFunctionSuffix + ''' )'
       + ' DROP FUNCTION ' + quotename(@DeletedViewSchema) + '.' + quotename(@UDFPrefix + @TableName + @RowHistoryFunctionSuffix)
EXEC (@SQL)

-- drop existing _TableRecovery UDF for the new view schema
SET @SQL = 'If EXISTS (Select * from sys.objects o join sys.schemas s on o.schema_id = s.schema_id  '
       + ' where s.name = ''' + @DeletedViewSchema + ''''
       + '   and o.name = ''' + @UDFPrefix + @TableName + @TableRecoveryFunctionSuffix + ''' )'
       + ' DROP FUNCTION ' + quotename(@DeletedViewSchema) + '.' + quotename(@UDFPrefix + @TableName + @TableRecoveryFunctionSuffix)
EXEC (@SQL)

-- drop existing _Deleted view for the old view schema
SET @SQL = 'If EXISTS (Select * from sys.objects o join sys.schemas s on o.schema_id = s.schema_id  '
       + ' where s.name = ''' + @ViewSchema + ''''
       + '   and o.name = ''' + @ViewPrefix + @TableName + @DeletedViewSuffix + ''' )'
       + ' DROP VIEW ' + quotename(@ViewSchema) + '.' + quotename(@ViewPrefix + @TableName + @DeletedViewSuffix)
EXEC (@SQL)

-- drop existing _RowHistory view for the old view schema
SET @SQL = 'If EXISTS (Select * from sys.objects o join sys.schemas s on o.schema_id = s.schema_id  '
       + ' where s.name = ''' + @ViewSchema + ''''
       + '   and o.name = ''' + @ViewPrefix + @TableName + @RowHistoryViewSuffix + ''' )'
       + ' DROP VIEW ' + quotename(@ViewSchema) + '.' + quotename(@ViewPrefix + @TableName + @RowHistoryViewSuffix)
EXEC (@SQL)

-- drop existing _RowHistory UDF for the old view schema
SET @SQL = 'If EXISTS (Select * from sys.objects o join sys.schemas s on o.schema_id = s.schema_id  '
       + ' where s.name = ''' + @ViewSchema + ''''
       + '   and o.name = ''' + @UDFPrefix + @TableName + @RowHistoryFunctionSuffix + ''' )'
       + ' DROP FUNCTION ' + quotename(@ViewSchema) + '.' + quotename(@UDFPrefix + @TableName + @RowHistoryFunctionSuffix)
EXEC (@SQL)

-- drop existing _TableRecovery UDF for the old view schema
SET @SQL = 'If EXISTS (Select * from sys.objects o join sys.schemas s on o.schema_id = s.schema_id  '
       + ' where s.name = ''' + @ViewSchema + ''''
       + '   and o.name = ''' + @UDFPrefix + @TableName + @TableRecoveryFunctionSuffix + ''' )'
       + ' DROP FUNCTION ' + quotename(@ViewSchema) + '.' + quotename(@UDFPrefix + @TableName + @TableRecoveryFunctionSuffix)
EXEC (@SQL)

IF @BaseTableDDL = 1 
  BEGIN 
	Print '	Adding Base Table DDL'
    -- add Created column 
    IF not exists (select *
			      from sys.tables t
				    join sys.schemas s
				      on s.schema_id = t.schema_id
				    join sys.columns c
				      on t.object_id = c.object_id
			      where  t.name = @TableName AND s.name = @SchemaName and c.name = @CreatedColumnName)
      BEGIN -- is this default causing an issue? 
        IF @StrictUserContext = 1                                                                                        
          SET @SQL = 'ALTER TABLE ' + quotename(@SchemaName) + '.' + quotename(@TableName) + ' ADD ' + @CreatedColumnName + ' DateTime NOT NULL Constraint ' + quotename(@TableName + '_' + @CreatedColumnName + '_df') + ' Default GetDate()' + Char(13) + Char(10)
        ELSE   
          SET @SQL = 'ALTER TABLE ' + quotename(@SchemaName) + '.' + quotename(@TableName) + ' ADD ' + @CreatedColumnName + ' DateTime NULL Constraint ' + quotename(@TableName + '_' + @CreatedColumnName + '_df') + ' Default GetDate()' + Char(13) + Char(10)
		  --add extended property
		  If @AddExtendedProperties = '1'
				SET @SQL = @SQL + 'EXEC sys.sp_addextendedproperty 
				  @level0type = N''SCHEMA'', @level0name = N''' + @SchemaName + ''',
				  @level1type = N''TABLE'',  @level1name = N''' + @TableName + ''',
				  @level2type = N''COLUMN'', @level2name = N''' + @CreatedColumnName + ''',
				  @name = N''MS_Description'', @value = N''Column added by AutoAudit'''
        EXEC (@SQL)
      END

    -- add CreatedBy column 
    IF not exists (select *
			      from sys.tables t
				    join sys.schemas s
				      on s.schema_id = t.schema_id
				    join sys.columns c
				      on t.object_id = c.object_id
			      where  t.name = @TableName AND s.name = @SchemaName and c.name = + @CreatedByColumnName)
      BEGIN 
        IF @StrictUserContext = 1                                                                                        
          SET @SQL = 'ALTER TABLE ' + quotename(@SchemaName) + '.' + quotename(@TableName) + ' ADD ' + @CreatedByColumnName + ' NVARCHAR(128) NOT NULL Constraint ' + quotename(@TableName + '_' + @CreatedByColumnName + '_df') + ' Default(Suser_SName())' + Char(13) + Char(10)
        ELSE   
          SET @SQL = 'ALTER TABLE ' + quotename(@SchemaName) + '.' + quotename(@TableName) + ' ADD ' + @CreatedByColumnName + ' NVARCHAR(128) NULL Constraint ' + quotename(@TableName + '_' + @CreatedByColumnName + '_df') + ' Default(Suser_SName())' + Char(13) + Char(10)
		  --add extended property
		  If @AddExtendedProperties = '1'
			  SET @SQL = @SQL + 'EXEC sys.sp_addextendedproperty 
				@level0type = N''SCHEMA'', @level0name = N''' + @SchemaName + ''',
				@level1type = N''TABLE'',  @level1name = N''' + @TableName + ''',
				@level2type = N''COLUMN'', @level2name = N''' + @CreatedByColumnName + ''',
				@name = N''MS_Description'', @value = N''Column added by AutoAudit'''
        EXEC (@SQL)
      END

    -- add Modified column 
    IF not exists( select *
			      from sys.tables t
				    join sys.schemas s
				      on s.schema_id = t.schema_id
				    join sys.columns c
				      on t.object_id = c.object_id
			      where  t.name = @TableName AND s.name = @SchemaName and c.name = @ModifiedColumnName)
      BEGIN                                                                                               
        IF @StrictUserContext = 1                                                                                        
          SET @SQL = 'ALTER TABLE ' + quotename(@SchemaName) + '.' + quotename(@TableName) + ' ADD ' + @ModifiedColumnName + ' DateTime NOT NULL Constraint ' + quotename(@TableName + '_' + @ModifiedColumnName + '_df') + ' Default GetDate()' + Char(13) + Char(10)
        ELSE   
          SET @SQL = 'ALTER TABLE ' + quotename(@SchemaName) + '.' + quotename(@TableName) + ' ADD ' + @ModifiedColumnName + ' DateTime NULL Constraint ' + quotename(@TableName + '_' + @ModifiedColumnName + '_df') + ' Default GetDate()' + Char(13) + Char(10)
 		  --add extended property
		  If @AddExtendedProperties = '1'
			  SET @SQL = @SQL + 'EXEC sys.sp_addextendedproperty 
				@level0type = N''SCHEMA'', @level0name = N''' + @SchemaName + ''',
				@level1type = N''TABLE'',  @level1name = N''' + @TableName + ''',
				@level2type = N''COLUMN'', @level2name = N''' + @ModifiedColumnName + ''',
				@name = N''MS_Description'', @value = N''Column added by AutoAudit'''
       EXEC (@SQL)
      END
      
    -- add ModifiedBy column 
    IF not exists (select *
			      from sys.tables t
				    join sys.schemas s
				      on s.schema_id = t.schema_id
				    join sys.columns c
				      on t.object_id = c.object_id
			      where  t.name = @TableName AND s.name = @SchemaName and c.name = @ModifiedByColumnName)
      BEGIN 
        IF @StrictUserContext = 1                                                                                        
          SET @SQL = 'ALTER TABLE ' + quotename(@SchemaName) + '.' + quotename(@TableName) + ' ADD ' + @ModifiedByColumnName + ' NVARCHAR(128) NOT NULL Constraint ' + quotename(@TableName + '_' + @ModifiedByColumnName + '_df') + ' Default(Suser_SName())' + Char(13) + Char(10)
        ELSE  
          SET @SQL = 'ALTER TABLE ' + quotename(@SchemaName) + '.' + quotename(@TableName) + ' ADD ' + @ModifiedByColumnName + ' NVARCHAR(128) NULL Constraint ' + quotename(@TableName + '_' + @ModifiedByColumnName + '_df') + ' Default(Suser_SName())' + Char(13) + Char(10)
  		  --add extended property
		  If @AddExtendedProperties = '1'
			  SET @SQL = @SQL + 'EXEC sys.sp_addextendedproperty 
				@level0type = N''SCHEMA'', @level0name = N''' + @SchemaName + ''',
				@level1type = N''TABLE'',  @level1name = N''' + @TableName + ''',
				@level2type = N''COLUMN'', @level2name = N''' + @ModifiedByColumnName + ''',
				@name = N''MS_Description'', @value = N''Column added by AutoAudit'''
       EXEC (@SQL)
      END  

    -- add RowVersion column 
    IF not exists( select *
			      from sys.tables t
				    join sys.schemas s
				      on s.schema_id = t.schema_id
				    join sys.columns c
				      on t.object_id = c.object_id
			      where  t.name = @TableName AND s.name = @SchemaName and c.name = @RowVersionColumnName)
      BEGIN   
        SET @SQL = 'ALTER TABLE ' + quotename(@SchemaName) + '.' + quotename(@TableName) + ' ADD ' + @RowVersionColumnName + ' INT NULL Constraint ' + quotename(@TableName + '_' + @RowVersionColumnName + '_df') + ' Default 1 WITH VALUES' + Char(13) + Char(10)
  		  --add extended property
		  If @AddExtendedProperties = '1'
			  SET @SQL = @SQL + 'EXEC sys.sp_addextendedproperty 
				@level0type = N''SCHEMA'', @level0name = N''' + @SchemaName + ''',
				@level1type = N''TABLE'',  @level1name = N''' + @TableName + ''',
				@level2type = N''COLUMN'', @level2name = N''' + @RowVersionColumnName + ''',
				@name = N''MS_Description'', @value = N''Column added by AutoAudit'''
        EXEC (@SQL)
      END
      
 END -- @BaseTableDDL = 1     

  
--------------------------------------------------------------------------------
--------------------------------------------------------------------------------
-- build insert trigger 
If @LogInsert > 0
BEGIN
print '	Creating Insert trigger'

SET @SQL = 'CREATE TRIGGER ' + quotename(@SchemaName) + '.' + quotename(@TableName + '_Audit_Insert') + ' ON ' + quotename(@SchemaName) + '.' + quotename(@TableName) + Char(13) + Char(10)
       + ' AFTER Insert' + Char(13) + Char(10) + ' NOT FOR REPLICATION AS' + Char(13) + Char(10)
       + ' SET NoCount On ' + Char(13) + Char(10)
       + ' SET ARITHABORT ON ' + Char(13) + Char(10)+ Char(13) + Char(10)
      
       + ' -- generated by AutoAudit Version ' + @Version + ' on ' + Convert(VARCHAR(30), GetDate(),100)  + Char(13) + Char(10)
       + ' -- created by Paul Nielsen and John Sigouin ' + Char(13) + Char(10)
       + ' -- www.SQLServerBible.com ' + Char(13) + Char(10)
       + ' -- AutoAudit.codeplex.com ' + Char(13) + Char(10) + Char(13) + Char(10)

       + ' -- Options: ' + Char(13) + Char(10)
       + ' --   StrictUserContext : ' + CAST(@StrictUserContext as CHAR(1)) + Char(13) + Char(10)
       + ' --   LogSQL            : ' + CAST(@LogSQL as CHAR(1)) + Char(13) + Char(10)
       + ' --   BaseTableDDL      : ' + CAST(@BaseTableDDL as CHAR(1)) + Char(13) + Char(10)
       + ' --   LogInsert         : ' + CAST(@LogInsert as CHAR(1)) + Char(13) + Char(10)
       + ' --   LogUpdate         : ' + CAST(@LogUpdate as CHAR(1)) + Char(13) + Char(10)
       + ' --   LogDelete         : ' + CAST(@LogDelete as CHAR(1)) + Char(13) + Char(10)
       + ' --   ColumnNames       : ' + CAST(@ColumnNames as VARCHAR(1024)) + Char(13) + Char(10) + Char(13) + Char(10)

       + 'DECLARE ' + Char(13) + Char(10)
       + '  @AuditTime DATETIME, ' + Char(13) + Char(10)
       + '  @IsDirty BIT,' + Char(13) + Char(10)
       + '  @DebugFlag BIT,' + Char(13) + Char(10)
       + '  @NestLevel TINYINT' + Char(13) + Char(10)

SELECT @SQL = @SQL 
	+ 'Select @DebugFlag = SettingValue from ' + quotename(@AuditSchema) + '.[AuditSettings] where SettingName = ''Audit Trigger Debug Flag''' + Char(13) + Char(10)
	+ 'Select @NestLevel = TRIGGER_NESTLEVEL(OBJECT_ID(''' + quotename(@SchemaName) + '.' + quotename(@TableName + '_Audit_Insert') + '''), ''AFTER'', ''DML'')' + Char(13) + Char(10) + Char(13) + Char(10)
    + 'IF @DebugFlag = 1 PRINT ''Firing Insert trigger: ' + quotename(@SchemaName) + '.' + quotename(@TableName + '_Audit_Insert') + ', nest level = '' + cast(@NestLevel as varchar)' + Char(13) + Char(10) + Char(13) + Char(10)

    + ' -- prevent recursive runs of this trigger' + Char(13) + Char(10)
    + ' IF TRIGGER_NESTLEVEL(OBJECT_ID(''' + quotename(@SchemaName) + '.' + quotename(@TableName + '_Audit_Insert')+ '''), ''AFTER'', ''DML'') > 1' + Char(13) + Char(10)
    + '   BEGIN' + Char(13) + Char(10)
    + '     IF @DebugFlag = 1 PRINT ''   TRIGGER_NESTLEVEL > 1. Exiting trigger...''' + Char(13) + Char(10)
    + ' 	   return' + Char(13) + Char(10)
    + '   END' + Char(13) + Char(10) + Char(13) + Char(10)

	+ '--get the EnabledFlag setting from the AuditBaseTables table' + Char(13) + Char(10)
	+ 'IF NOT EXISTS (SELECT 1 FROM ' + quotename(@AuditSchema) + '.[AuditBaseTables] '
	+ ' WHERE [SchemaName] = ''' + @SchemaName + ''''
	+ ' AND [TableName] = ''' + @TableName + ''''
	+ ' AND [EnabledFlag] = 1)' + Char(13) + Char(10)
    + '   BEGIN' + Char(13) + Char(10)
    + '     IF @DebugFlag = 1 PRINT ''AutoAudit EnabledFlag set to "false" for this table in the AuditBaseTables table. Exiting trigger...''' + Char(13) + Char(10)
	+ ' 	return' + Char(13) + Char(10)
    + '   END' + Char(13) + Char(10) + Char(13) + Char(10)
	
       -- keep the variable initialization separate for SQL Server 2005
       + 'SET @AuditTime = GetDate()' + Char(13) + Char(10) + Char(13) + Char(10)
       + 'SET @IsDirty = 0' + Char(13) + Char(10) + Char(13) + Char(10)
       
      + ' set context_info 0x1;' + Char(13) + Char(10)
      + ' Begin Try ' + Char(13) + Char(10)
          
   IF @LogSQL = 1 
     BEGIN  
     	 select @SQL = @SQL
         + ' -- capture SQL Statement' + Char(13) + Char(10)
         + ' DECLARE @ExecStr varchar(50), @UserSQL nvarchar(max)' + Char(13) + Char(10)
         + ' DECLARE  @inputbuffer TABLE' + Char(13) + Char(10) 
         + ' (EventType nvarchar(30), Parameters int, EventInfo nvarchar(max))' + Char(13) + Char(10)
         + ' SET @ExecStr = ''DBCC INPUTBUFFER(@@SPID) with no_infomsgs''' + Char(13) + Char(10)
         + ' INSERT INTO @inputbuffer' + Char(13) + Char(10) 
         + '   EXEC (@ExecStr)' + Char(13) + Char(10)
         + ' SELECT @UserSQL = EventInfo FROM @inputbuffer' + Char(13) + Char(10)
         + Char(13) + Char(10) 
     END

--create a temp table for mapping keys
select @SQL = @SQL
		+ 'Declare @Keys Table (AuditHeaderID BIGINT, 
		PrimaryKey VARCHAR(250), 
		NextRowVersion int default(1))' + Char(13) + Char(10) 
           
-- Insert the AuditHeader row
	select @SQL = @SQL
          + Char(13) + Char(10)
		      + '   INSERT ' + quotename(@AuditSchema) + '.AuditHeader (AuditDate, SysUser, Application, HostName, TableName, Operation, SQLStatement,' + Char(13) + Char(10) 
		      + '			PrimaryKey, PrimaryKey2, PrimaryKey3, PrimaryKey4, PrimaryKey5, RowDescription, SecondaryRow, [RowVersion])' + Char(13) + Char(10)
		      + '   OUTPUT  inserted.AuditHeaderID, quotename(inserted.PrimaryKey) + isnull(quotename(inserted.PrimaryKey2),'''') + isnull(quotename(inserted.PrimaryKey3),'''') + isnull(quotename(inserted.PrimaryKey4),'''') + isnull(quotename(inserted.PrimaryKey5),'''')' + Char(13) + Char(10)
		      + '	into @Keys (AuditHeaderID, PrimaryKey) '  + Char(13) + Char(10)
		      + '   SELECT ' 
		      
		      -- StrictUserOption
		      + CASE @StrictUserContext
		          WHEN 0 -- allow DML setting of created/modified user and datetimes
		            THEN ' COALESCE( src.' + @CreatedColumnName + ', @AuditTime), COALESCE( src.' + @CreatedByColumnName + ', Suser_SName()),'
		          ELSE -- block DML setting of user context 
		             ' @AuditTime, Suser_SName(),'
		        END 
		      
		      + ' APP_NAME(), Host_Name(), ' 
          + '''' + QUOTENAME(@SchemaName) + '.' + QUOTENAME(@TableName) + ''', ''i'',' --no quotename here
          
          -- if @LogSQL is off then the @UserSQL variable has not been declared
          + CASE @LogSQL
              WHEN 1 THEN ' @UserSQL, '
              ELSE ' NULL, ' 
           END  
          + Char(13) + Char(10)  
          + '		' + @PKColumnNameListWithDateConvert + ',' + left('null,null,null,null,',5*(5-@PKColumnQty)) + Char(13) + Char(10) 
          + '        NULL,     -- Row Description (e.g. Order Number)' + Char(13) + Char(10)   
          + '        NULL,     -- Secondary Row Value (e.g. Order Number for an Order Detail Line)' + Char(13) + Char(10)
          + '        1' + Char(13) + Char(10)      -- the RowVersion should always be 1 initially.  The RowVersion adjustment bellow sets it to the correct value
          + '          FROM  inserted as src' + Char(13) + Char(10)
          + '          WHERE  src.['+ c.name + '] is not null' + Char(13) + Char(10)+ Char(13) + Char(10)
	  from sys.tables as t
		  join sys.columns as c
		    on t.object_id = c.object_id
		  join sys.schemas as s
		    on s.schema_id = t.schema_id
		  join sys.types as ty
		    on ty.user_type_id = c.user_type_id
        where t.name = @TableName AND s.name = @SchemaName 
           AND c.column_id = 1
           AND c.is_computed = 0
           AND ty.name NOT IN ('text', 'ntext', 'image', 'geography', 'xml', 'binary', 'varbinary', 'timestamp', 'rowversion')
           AND (@ColumnNames = '<All>' or @PKColumnNameList + @ColumnNames like '%[[]' + c.name + ']%') 
	  order by c.column_id

--deal with RowVersion
	select @SQL = @SQL 
       + '-----' + Char(13) + Char(10) + Char(13) + Char(10)
       + '	--calculate next row version' + Char(13) + Char(10)
       + '	;With NextRowVersions' + Char(13) + Char(10)
       + '	as' + Char(13) + Char(10)
       + '	(Select Keys.PrimaryKey, max(AH.[RowVersion]) + 1 as NextRowVersion' + Char(13) + Char(10)
       + '	From	' + quotename(@AuditSchema) + '.AuditHeader AH' + Char(13) + Char(10)
       + '	inner join @Keys as Keys' + Char(13) + Char(10)
       + '		on		quotename(AH.PrimaryKey) + isnull(quotename(AH.PrimaryKey2),'''') + isnull(quotename(AH.PrimaryKey3),'''') + isnull(quotename(AH.PrimaryKey4),'''') + isnull(quotename(AH.PrimaryKey5),'''') = Keys.PrimaryKey' + Char(13) + Char(10)--no quotename here
       + '		and		AH.TableName = ''' + QUOTENAME(@SchemaName) + '.' + QUOTENAME(@TableName) + '''' + Char(13) + Char(10)--no quotename here
       + '	group by Keys.PrimaryKey' + Char(13) + Char(10)
       + '	having count(*) > 1' + Char(13) + Char(10)
       + '	)' + Char(13) + Char(10)
       + '   UPDATE Keys' + Char(13) + Char(10)
       + '     SET  Keys.[NextRowVersion] = NRV.NextRowVersion' + Char(13) + Char(10)
       + '     FROM @Keys as Keys' + Char(13) + Char(10)
       + '     INNER JOIN	NextRowVersions NRV' + Char(13) + Char(10)
       + '		ON		Keys.PrimaryKey = NRV.PrimaryKey;' + Char(13) + Char(10)

	--fix the RowVersion in the Audit table to match the actual data table on re-insertion
	select @SQL = @SQL 
       + '-----' + Char(13) + Char(10) + Char(13) + Char(10)
	   + ' -- fix the RowVersion in the Audit table' + Char(13) + Char(10)
       + '   UPDATE AH' + Char(13) + Char(10)
       + '     SET AH.[RowVersion] = Keys.[NextRowVersion]' + Char(13) + Char(10)
       + '     FROM ' + quotename(@AuditSchema) + '.AuditHeader AH with (nolock)' + Char(13) + Char(10)
       + '     INNER JOIN	@Keys as Keys' + Char(13) + Char(10)
       + '     ON AH.AuditHeaderID =  Keys.AuditHeaderID' + Char(13) + Char(10)
       + '-----' + Char(13) + Char(10) + Char(13) + Char(10)

--added RowVersion increment fix to continue to increment the RowVersion
--when a particular PK row is deleted then re-inserted
	IF @StrictUserContext = 1 AND @BaseTableDDL = 1
	select @SQL = @SQL 
	   + ' -- Update the Created and Modified columns' + Char(13) + Char(10)
       + '   UPDATE src ' + Char(13) + Char(10)
       + '     SET ' + @CreatedColumnName + '  = @AuditTime, ' + Char(13) + Char(10)
       + '         ' + @CreatedByColumnName + '  = Suser_SName(), ' + Char(13) + Char(10)
       + '         ' + @ModifiedColumnName + ' = @AuditTime, ' + Char(13) + Char(10)
       + '         ' + @ModifiedByColumnName + '  = Suser_SName(), ' + Char(13) + Char(10)
       + '         ' + @RowVersionColumnName + ' = Keys.[NextRowVersion]' + Char(13) + Char(10)
       + '     FROM ' + quotename(@SchemaName) + '.' + quotename(@TableName) + ' as src with (nolock) ' + Char(13) + Char(10)
       + '       JOIN  @Keys as Keys'  + Char(13) + Char(10)
       + '         ON ' + @PKColumnNameConcatenationWithQuotenameAndDateConvert + ' =  Keys.[PrimaryKey]'
       +  Char(13) + Char(10) + Char(13) + Char(10)

	IF @StrictUserContext = 0 AND @BaseTableDDL = 1
	select @SQL = @SQL 	
       + ' -- Update the Created and Modified columns' + Char(13) + Char(10)
       + '   UPDATE src' + Char(13) + Char(10)
       + '     SET ' + @CreatedColumnName + '  = COALESCE( inserted.' + @CreatedColumnName + ', @AuditTime), ' + Char(13) + Char(10)
       + '         ' + @CreatedByColumnName + '  = COALESCE( inserted.' + @CreatedByColumnName + ', Suser_SName()), ' + Char(13) + Char(10)
       + '         ' + @ModifiedColumnName + ' = COALESCE( inserted.' + @ModifiedColumnName + ',  inserted.' + @CreatedColumnName + ', @AuditTime), ' + Char(13) + Char(10)
       + '         ' + @ModifiedByColumnName + '  = COALESCE( inserted.' + @ModifiedByColumnName + ',  inserted.' + @CreatedByColumnName + ', Suser_SName()), ' + Char(13) + Char(10)
       + '         ' + @RowVersionColumnName + ' = Keys.[NextRowVersion]' + Char(13) + Char(10)
       + '     FROM ' + quotename(@SchemaName) + '.' + quotename(@TableName) + ' as src with (nolock) ' + Char(13) + Char(10)
       + '       JOIN  @Keys as Keys'  + Char(13) + Char(10)
       + '         ON ' + @PKColumnNameConcatenationWithQuotenameAndDateConvert + ' =  Keys.[PrimaryKey]'+ Char(13) + Char(10)
       + '       JOIN inserted'+ Char(13) + Char(10)
       + '         ON ' + @PKColumnNameConcatenationWithQuotenameAndDateConvert + ' = ' + replace(@PKColumnNameConcatenationWithQuotenameAndDateConvert,'src.[','inserted.[') + Char(13) + Char(10)
       +  Char(13) + Char(10) 


----------------------------------------------------------------------------------
-- Insert AuditDetail Table
----------------------------------------------------------------------------------	  
----------------------------------------------------------------------------------
-- BEGIN FOR EACH COLUMN
----------------------------------------------------------------------------------	  
IF @LogInsert = 2 -- log data to the AuditDetail table
begin
	select @SQL = @SQL 
       + '   INSERT ' + quotename(@AuditSchema) + '.AuditDetail (AuditHeaderID, ColumnName, NewValue)' + Char(13) + Char(10)
--start of unpivot query
       + '   	SELECT AuditHeaderID, ''['' + AA_ColumnName + '']'', AA_NewValue' + Char(13) + Char(10)
       + '   FROM ' + Char(13) + Char(10)
       + '      (SELECT Keys.AuditHeaderID as AuditHeaderID' + Char(13) + Char(10)

--add columns to unpivot query       
 	select @SQL = @SQL  
       + '	,convert(varchar(50),inserted.[' + c.name + '],' + @DateStyle + ') as [' + c.name + ']' + Char(13) + Char(10)
	  from sys.tables as t
		  join sys.columns as c
		    on t.object_id = c.object_id
		  join sys.schemas as s
		    on s.schema_id = t.schema_id
		  join sys.types as ty
		    on ty.user_type_id = c.user_type_id
        where t.name = @TableName AND s.name = @SchemaName 
           AND c.name NOT IN (@CreatedColumnName, @ModifiedColumnName, @CreatedByColumnName, @ModifiedByColumnName, @RowVersionColumnName)
           AND c.is_computed = 0
           AND ty.name NOT IN ('text', 'ntext', 'image', 'geography', 'xml', 'binary', 'varbinary', 'timestamp', 'rowversion')
           AND (@ColumnNames = '<All>' or @PKColumnNameList + @ColumnNames like '%[[]' + c.name + ']%') 
	  order by c.column_id      
       
 --data source for unpivot query       
	select @SQL = @SQL  
       + '	  FROM  inserted' + Char(13) + Char(10)
       + '	  JOIN	 @Keys as Keys' + Char(13) + Char(10)
       + '		ON	 ' + replace(@PKColumnNameConcatenationWithQuotenameAndDateConvert,'src.[','inserted.[') + ' = Keys.PrimaryKey' + Char(13) + Char(10)
       + ') as SourceData' + Char(13) + Char(10)
       + 'UNPIVOT' + Char(13) + Char(10)
       + '   (AA_NewValue FOR AA_ColumnName IN (' + Char(13) + Char(10)

--add filter to unpivot query       
 	select @SQL = @SQL  
       + case when c.column_id > 1 then ',' else '' end + quotename(c.name) + Char(13) + Char(10)
	  from sys.tables as t
		  join sys.columns as c
		    on t.object_id = c.object_id
		  join sys.schemas as s
		    on s.schema_id = t.schema_id
		  join sys.types as ty
		    on ty.user_type_id = c.user_type_id
        where t.name = @TableName AND s.name = @SchemaName 
           AND c.name NOT IN (@CreatedColumnName, @ModifiedColumnName, @CreatedByColumnName, @ModifiedByColumnName, @RowVersionColumnName)
           AND c.is_computed = 0
           AND ty.name NOT IN ('text', 'ntext', 'image', 'geography', 'xml', 'binary', 'varbinary', 'timestamp', 'rowversion')
           AND (@ColumnNames = '<All>' or @PKColumnNameList + @ColumnNames like '%[[]' + c.name + ']%') 
	  order by c.column_id      

  	select @SQL = @SQL  
      + '      )' + Char(13) + Char(10)
       + ')AS UNPVT' + Char(13) + Char(10)
       + '	  WHERE  AA_NewValue is not null;' + Char(13) + Char(10) + Char(13) + Char(10)

end --@LogInsert = 2
----------------------------------------------------------------------------------
-- END FOR EACH COLUMN
----------------------------------------------------------------------------------	  

	select @SQL = @SQL 
       + '  set context_info 0x0;' + Char(13) + Char(10)

       + 'IF @DebugFlag = 1 PRINT ''Ending Insert trigger normally: ' + quotename(@SchemaName) + '.' + quotename(@TableName + '_Audit_Insert') + ', nest level = '' + cast(@NestLevel as varchar)' + Char(13) + Char(10) + Char(13) + Char(10)

       + '-----' + Char(13) + Char(10) + Char(13) + Char(10)
       + ' End Try ' + Char(13) + Char(10)
       + ' Begin Catch ' + Char(13) + Char(10)
       + '   DECLARE @ErrorMessage NVARCHAR(4000), @ErrorSeverity INT, @ErrorState INT, @ErrorLine INT;' + Char(13) + Char(10) 

       + '   SET @ErrorMessage = ERROR_MESSAGE();  ' + Char(13) + Char(10)
       + '   SET @ErrorSeverity = ERROR_SEVERITY(); ' + Char(13) + Char(10) 
       + '   SET @ErrorState = ERROR_STATE();  ' + Char(13) + Char(10)
       + '   SET @ErrorLine = ERROR_LINE();  ' + Char(13) + Char(10)
       + '	 SET context_info 0x0;' + Char(13) + Char(10)
       + '   RAISERROR(@ErrorMessage,@ErrorSeverity,@ErrorState)' + case when @WithLogFlag = 1 then ' with log;' else ';' end + Char(13) + Char(10) 
       + '   PRINT ''Error Line: '' + cast(@ErrorLine as varchar);' + Char(13) + Char(10)
       + ' End Catch '

EXEC (@SQL)

SET @SQL = quotename(@SchemaName) + '.' + quotename(@TableName + '_Audit_Insert')

EXEC sp_settriggerorder 
  @triggername= @SQL, 
  @order='First', 
  @stmttype = 'INSERT';

END --if @LogInsert > 0

--------------------------------------------------------------------------------
--------------------------------------------------------------------------------
-- build update trigger 
IF NOT (@LogUpdate = 0 and @BaseTableDDL = 0)
BEGIN
print '	Creating Update trigger'

SET @SQL = 'CREATE TRIGGER ' + quotename(@SchemaName) + '.' + quotename(@TableName + '_Audit_Update') + ' ON ' + quotename(@SchemaName) + '.' + quotename(@TableName) + Char(13) + Char(10)
       + ' AFTER Update' + Char(13) + Char(10) + ' NOT FOR REPLICATION AS' + Char(13) + Char(10)
       + ' SET NoCount On ' + Char(13) + Char(10) + Char(13) + Char(10)
       
       + ' -- generated by AutoAudit Version ' + @Version + ' on ' + Convert(VARCHAR(30), GetDate(),100)  + Char(13) + Char(10)
       + ' -- created by Paul Nielsen and John Sigouin ' + Char(13) + Char(10)
       + ' -- www.SQLServerBible.com ' + Char(13) + Char(10)
       + ' -- AutoAudit.codeplex.com ' + Char(13) + Char(10) + Char(13) + Char(10)
       
       + ' -- Options: ' + Char(13) + Char(10)
       + ' --   StrictUserContext : ' + CAST(@StrictUserContext as CHAR(1)) + Char(13) + Char(10)
       + ' --   LogSQL            : ' + CAST(@LogSQL as CHAR(1)) + Char(13) + Char(10)
       + ' --   BaseTableDDL      : ' + CAST(@BaseTableDDL as CHAR(1)) + Char(13) + Char(10)
       + ' --   LogInsert         : ' + CAST(@LogInsert as CHAR(1)) + Char(13) + Char(10)
       + ' --   LogUpdate         : ' + CAST(@LogUpdate as CHAR(1)) + Char(13) + Char(10)
       + ' --   LogDelete         : ' + CAST(@LogDelete as CHAR(1)) + Char(13) + Char(10) + Char(13) + Char(10)
       + ' --   ColumnNames       : ' + CAST(@ColumnNames as VARCHAR(1024)) + Char(13) + Char(10) + Char(13) + Char(10)
       
SET @SQL = @SQL 
    + 'declare  @DebugFlag BIT,' + Char(13) + Char(10)
    + '  @NestLevel TINYINT' + Char(13) + Char(10)

	+ 'Select @DebugFlag = SettingValue from ' + quotename(@AuditSchema) + '.[AuditSettings] where SettingName = ''Audit Trigger Debug Flag''' + Char(13) + Char(10)
	+ 'Select @NestLevel = TRIGGER_NESTLEVEL(OBJECT_ID(''' + quotename(@SchemaName) + '.' + quotename(@TableName + '_Audit_Update') + '''), ''AFTER'', ''DML'')' + Char(13) + Char(10) + Char(13) + Char(10)
    + 'IF @DebugFlag = 1 PRINT ''Firing Update trigger: ' + quotename(@SchemaName) + '.' + quotename(@TableName + '_Audit_Update') + ', nest level = '' + cast(@NestLevel as varchar)' + Char(13) + Char(10) + Char(13) + Char(10)

	+ 'declare @ContextInfo varbinary(128)' + Char(13) + Char(10)
	+ 'select @ContextInfo = context_info from master.dbo.sysprocesses where spid=@@SPID;' + Char(13) + Char(10) + Char(13) + Char(10)

	+ '--prevent update trigger from firing when insert trigger is updating DDL columns' + Char(13) + Char(10)
	+ 'IF @ContextInfo = 0x1' + Char(13) + Char(10)
    + '   BEGIN' + Char(13) + Char(10)
    + '     IF @DebugFlag = 1 PRINT ''   Update trigger initiated by the Insert trigger. Exiting Update trigger immediately...''' + Char(13) + Char(10)
    + ' 	   return' + Char(13) + Char(10)
    + '   END' + Char(13) + Char(10) + Char(13) + Char(10)

    + ' -- prevent recursive runs of this trigger' + Char(13) + Char(10)
    + ' IF TRIGGER_NESTLEVEL(OBJECT_ID(''' + quotename(@SchemaName) + '.' + quotename(@TableName + '_Audit_Update')+ '''), ''AFTER'', ''DML'') > 1' + Char(13) + Char(10)
    + '   BEGIN' + Char(13) + Char(10)
    + '     IF @DebugFlag = 1 PRINT ''   TRIGGER_NESTLEVEL > 1. Exiting trigger...''' + Char(13) + Char(10)
    + ' 	   return' + Char(13) + Char(10)
    + '   END' + Char(13) + Char(10) + Char(13) + Char(10)

    + '  --get the EnabledFlag setting from the AuditBaseTables table' + Char(13) + Char(10)
	+ 'IF NOT EXISTS (SELECT 1 FROM ' + quotename(@AuditSchema) + '.[AuditBaseTables] '
	+ ' WHERE [SchemaName] = ''' + @SchemaName + ''''
	+ ' AND [TableName] = ''' + @TableName + ''''
	+ ' AND [EnabledFlag] = 1)' + Char(13) + Char(10)
    + '   BEGIN' + Char(13) + Char(10)
    + '     IF @DebugFlag = 1 PRINT ''AutoAudit EnabledFlag set to "false" for this table in the AuditBaseTables table. Exiting trigger...''' + Char(13) + Char(10)
	+ ' 	return' + Char(13) + Char(10)
    + '   END' + Char(13) + Char(10) + Char(13) + Char(10)

      + 'DECLARE ' + Char(13) + Char(10)
       + '  @AuditTime DATETIME' + Char(13) + Char(10)
       
       -- keep the variable initialization separate for SQL Server 2005
       + 'SET @AuditTime = GetDate()' + Char(13) + Char(10) + Char(13) + Char(10)

       + '  Begin Try' + Char(13) + Char(10)
  
   	        /* -------------------------------------------------------------------------------
   	        -- enable this code to force a rollback of attempt to set user context when StrictUserContext is on
   	        IF @StrictUserContext = 1
              SELECT @SQL = @SQL
                   -- StrictUserContext so always set to system user function        
                 + '    SET @CreateUserName = SUser_SName()' + Char(13) + Char(10)
                 + '    SET @ModifyUserName = SUser_SName()' + Char(13) + Char(10) + Char(13) + Char(10)
                   -- StrictUserContext so updating audit column not permitted 
                 + '    IF @@NestLevel = 1 AND (UPDATE(' + @CreatedColumnName + ') OR UPDATE(' + @CreatedByColumnName + ') OR UPDATE(' + @ModifiedColumnName + ') OR UPDATE(' + @ModifiedByColumnName + ') OR UPDATE(' + @RowVersionColumnName + '))' + Char(13) + Char(10)
                 + '      BEGIN ' + Char(13) + Char(10)
                 + '        RAISERROR(''Update of ' + @CreatedColumnName + ', ' + @CreatedByColumnName + ', ' + @ModifiedColumnName + ', ' + @ModifiedByColumnName + ', or ' + @RowVersionColumnName + ' not permitted by AutoAudit when StrictUserContext is enabled.'', 16,1)' + Char(13) + Char(10)
                 + '        ROLLBACK' + Char(13) + Char(10)
                 + '      END ' + Char(13) + Char(10)   + Char(13) + Char(10)  
             */ -------------------------------------------------------------------------------
 
IF @LogUpdate = 0
	BEGIN
		If @BaseTableDDL = 1
			BEGIN
				--no Audit record created but still update the Modified, ModifiedBy and RowVersion columns
				IF @StrictUserContext = 1
				select @SQL = @SQL 
				   + ' -- Update the Created columns' + Char(13) + Char(10)
				   + '   UPDATE src' + Char(13) + Char(10)
				   + '     SET ' + @CreatedColumnName + '  = deleted.' + @CreatedColumnName + ', ' + Char(13) + Char(10)
				   + '         ' + @CreatedByColumnName + '  = deleted.' + @CreatedByColumnName + Char(13) + Char(10)
				   + '     FROM ' + quotename(@SchemaName) + '.' + quotename(@TableName) + ' as src with (nolock) ' + Char(13) + Char(10)
				   + '       JOIN deleted'+ Char(13) + Char(10)
				   + '         ON ' + @PKColumnNameConcatenationWithQuotenameAndDateConvert  + ' = ' + replace(@PKColumnNameConcatenationWithQuotenameAndDateConvert,'src.[','deleted.[') + Char(13) + Char(10)
				   + '     where	isnull(src.' + @CreatedColumnName + ',''1/1/1'')  <> isnull(deleted.' + @CreatedColumnName + ',''1/1/1'')' + Char(13) + Char(10)
				   + '	     or		isnull(src.' + @CreatedByColumnName + ',''wasnull!'')  <> isnull(deleted.' + @CreatedByColumnName + ',''wasnull!'')' + Char(13) + Char(10)
				   + '-----' + Char(13) + Char(10) + Char(13) + Char(10)

				   + ' -- Update the Modified and RowVersion columns' + Char(13) + Char(10)
				   + '   UPDATE src' + Char(13) + Char(10)
				   + '     SET ' + @ModifiedColumnName + ' = @AuditTime, ' + Char(13) + Char(10)
				   + '         ' + @ModifiedByColumnName + '  = Suser_SName(), ' + Char(13) + Char(10)
				   + '         ' + @RowVersionColumnName + ' = isnull(src.' + @RowVersionColumnName + ',0) + 1' + Char(13) + Char(10)
				   + '     FROM ' + quotename(@SchemaName) + '.' + quotename(@TableName) + ' as src with (nolock) ' + Char(13) + Char(10)
				   + '       JOIN  inserted'  + Char(13) + Char(10)
				   + '         ON ' + @PKColumnNameConcatenationWithQuotenameAndDateConvert + ' = ' + replace(@PKColumnNameConcatenationWithQuotenameAndDateConvert,'src.[','inserted.[') + Char(13) + Char(10)
				   + '-----' + Char(13) + Char(10) + Char(13) + Char(10)

				IF @StrictUserContext = 0 
				select @SQL = @SQL 
				   + ' -- Update the Created and Modified columns' + Char(13) + Char(10)
				   + '   UPDATE src' + Char(13) + Char(10)
				   + '     SET ' + Char(13) + Char(10)
				   + '         ' + @ModifiedColumnName + ' = COALESCE( inserted.' + @ModifiedColumnName + ', @AuditTime), ' + Char(13) + Char(10)
				   + '         ' + @ModifiedByColumnName + '  = COALESCE( inserted.' + @ModifiedByColumnName + ', Suser_SName()), ' + Char(13) + Char(10)
				   + '         ' + @RowVersionColumnName + ' = isnull(src.' + @RowVersionColumnName + ',0) + 1' + Char(13) + Char(10)
				   + '     FROM ' + quotename(@SchemaName) + '.' + quotename(@TableName) + ' as src with (nolock) ' + Char(13) + Char(10)
				   + '       JOIN inserted'+ Char(13) + Char(10)
				   + '         ON ' + @PKColumnNameConcatenationWithQuotenameAndDateConvert + ' = ' + replace(@PKColumnNameConcatenationWithQuotenameAndDateConvert,'src.[','inserted.[') + Char(13) + Char(10)
				   +  Char(13) + Char(10) 
			END
	END
ELSE --IF @LogUpdate = 0
BEGIN
   IF @LogSQL = 1 
     BEGIN  
     	  -- capture SQL Statement' + Char(13) + Char(10)
		select @SQL = @SQL
         + ' DECLARE @ExecStr varchar(50), @UserSQL nvarchar(max)' + Char(13) + Char(10)
         + ' DECLARE @inputbuffer TABLE' + Char(13) + Char(10) 
         + ' (EventType nvarchar(30), Parameters int, EventInfo nvarchar(max))' + Char(13) + Char(10)
         + ' SET @ExecStr = ''DBCC INPUTBUFFER(@@SPID) with no_infomsgs''' + Char(13) + Char(10)
         + ' INSERT INTO @inputbuffer' + Char(13) + Char(10) 
         + '   EXEC (@ExecStr)' + Char(13) + Char(10)
         + ' SELECT @UserSQL = EventInfo FROM @inputbuffer' + Char(13) + Char(10)
         + Char(13) + Char(10) 
     END   

--create a temp table for mapping keys
select @SQL = @SQL
		+ 'Declare @Keys Table (AuditHeaderID BIGINT, PrimaryKey VARCHAR(250), NextRowVersion int default(0))' + Char(13) + Char(10) 
        + 'Declare @AuditDetailUpdate Table (PrimaryKey VARCHAR(250), ColumnName sysname, OldValue varchar(50), NewValue varchar(50))' + Char(13) + Char(10)
        + 'Declare @CleanRows Table (AuditHeaderID bigint)' + Char(13) + Char(10)
        + 'Declare @PrimaryKeys Table (PrimaryKey VARCHAR(250))' + Char(13) + Char(10) + Char(13) + Char(10)

	select @SQL = @SQL
		+ '--BAIL OUT NOW IF NO ROWS HAVE BEEN UPDATED' + Char(13) + Char(10)
		+ 'If (Select count(*) from deleted) = 0 ' + Char(13) + Char(10)
		+ '   Begin' + Char(13) + Char(10)
        + '     IF @DebugFlag = 1 PRINT ''   No rows affected by update statement. Exiting trigger...''' + Char(13) + Char(10)
        + '     return --nothing has changed - bail out of trigger' + Char(13) + Char(10)
		+ '   End' + Char(13) + Char(10) + Char(13) + Char(10)

		+ '	--****************************************************** ' + Char(13) + Char(10)   
		+ '	--***START - THIS SECTION IS USED WHEN THE PK IS CHANGED ' + Char(13) + Char(10)   
		+ '	--****************************************************** ' + Char(13) + Char(10)   
		+ @PKColumnNameListIfUpdate + ' --check if the PK column has been updated' + Char(13) + Char(10)
		+ '		begin	--the primary key has been changed' + Char(13) + Char(10)
		+ '		If (Select count(*) from deleted) = 1 --check if more than one PK value has been updated' + Char(13) + Char(10)
		+ '			begin	--the primary key has been changed on a single row' + Char(13) + Char(10) + Char(13) + Char(10)

----------------------------------------------------------------------------------
-- BEGIN FOR EACH COLUMN
----------------------------------------------------------------------------------	  
       + '   INSERT @AuditDetailUpdate (PrimaryKey, ColumnName, OldValue, NewValue)' + Char(13) + Char(10)
 --start of unpivot query
      + '   	SELECT PrimaryKey, ''['' + substring(AA_dColumnName ,2,128) + '']'', AA_OldValue, AA_NewValue' + Char(13) + Char(10)
       + '   FROM ' + Char(13) + Char(10)
       + '      (SELECT ' + replace(@PKColumnNameConcatenationWithQuotenameAndDateConvert,'src.[','inserted.[') + ' as PrimaryKey' + Char(13) + Char(10)
       
--add columns to unpivot query       
 	select @SQL = @SQL  
       + '	,isnull(convert(varchar(50),deleted.[' + c.name + '],' + @DateStyle + '),''<-null->'') as [d' + c.name + ']' + Char(13) + Char(10)
       + '	,isnull(convert(varchar(50),inserted.[' + c.name + '],' + @DateStyle + '),''<-null->'') as [i' + c.name + ']' + Char(13) + Char(10)
	  from sys.tables as t
		  join sys.columns as c
		    on t.object_id = c.object_id
		  join sys.schemas as s
		    on s.schema_id = t.schema_id
		  join sys.types as ty
		    on ty.user_type_id = c.user_type_id
        where t.name = @TableName AND s.name = @SchemaName 
           AND c.name NOT IN (@CreatedColumnName, @ModifiedColumnName, @CreatedByColumnName, @ModifiedByColumnName, @RowVersionColumnName)
           AND c.is_computed = 0
           AND ty.name NOT IN ('text', 'ntext', 'image', 'geography', 'xml', 'binary', 'varbinary', 'timestamp', 'rowversion')
           AND (@ColumnNames = '<All>' or @PKColumnNameList + @ColumnNames like '%[[]' + c.name + ']%') 
	  order by c.column_id      
 
 --data source for unpivot query       
	select @SQL = @SQL  
       + '	  FROM  inserted' + Char(13) + Char(10)
       + '             CROSS JOIN deleted' + Char(13) + Char(10)
      + ') as SourceData' + Char(13) + Char(10)
     + 'UNPIVOT' + Char(13) + Char(10)
       + '   (AA_OldValue FOR AA_dColumnName IN (' + Char(13) + Char(10)

--add columns to unpivot query for deleted data   
 	select @SQL = @SQL  
       + case when column_id > 1 then ',' else '' end + quotename('d' + c.name) + Char(13) + Char(10)
	  from sys.tables as t
		  join sys.columns as c
		    on t.object_id = c.object_id
		  join sys.schemas as s
		    on s.schema_id = t.schema_id
		  join sys.types as ty
		    on ty.user_type_id = c.user_type_id
        where t.name = @TableName AND s.name = @SchemaName 
           AND c.name NOT IN (@CreatedColumnName, @ModifiedColumnName, @CreatedByColumnName, @ModifiedByColumnName, @RowVersionColumnName)
           AND c.is_computed = 0
           AND ty.name NOT IN ('text', 'ntext', 'image', 'geography', 'xml', 'binary', 'varbinary', 'timestamp', 'rowversion')
           AND (@ColumnNames = '<All>' or @PKColumnNameList + @ColumnNames like '%[[]' + c.name + ']%') 
	  order by c.column_id      

  	select @SQL = @SQL  
      + '      ))AS dUNPVT' + Char(13) + Char(10)

     + 'UNPIVOT' + Char(13) + Char(10)
       + '   (AA_NewValue FOR AA_iColumnName IN (' + Char(13) + Char(10)

--add columns to unpivot query for inserted data   
 	select @SQL = @SQL  
       + case when column_id > 1 then ',' else '' end + quotename('i' + c.name) + Char(13) + Char(10)
	  from sys.tables as t
		  join sys.columns as c
		    on t.object_id = c.object_id
		  join sys.schemas as s
		    on s.schema_id = t.schema_id
		  join sys.types as ty
		    on ty.user_type_id = c.user_type_id
        where t.name = @TableName AND s.name = @SchemaName 
           AND c.name NOT IN (@CreatedColumnName, @ModifiedColumnName, @CreatedByColumnName, @ModifiedByColumnName, @RowVersionColumnName)
           AND c.is_computed = 0
           AND ty.name NOT IN ('text', 'ntext', 'image', 'geography', 'xml', 'binary', 'varbinary', 'timestamp', 'rowversion')
           AND (@ColumnNames = '<All>' or @PKColumnNameList + @ColumnNames like '%[[]' + c.name + ']%') 
	  order by c.column_id      

  	select @SQL = @SQL  
      + '      ))AS iUNPVT' + Char(13) + Char(10)
      + '	  WHERE  substring(AA_dColumnName ,2,128) = substring(AA_iColumnName ,2,128)' + Char(13) + Char(10)
      + '	  AND ISNULL(AA_OldValue,''<-null->'') <> ISNULL(AA_NewValue,''<-null->'')' + Char(13) + Char(10)  + Char(13) + Char(10)

----------------------------------------------------------------------------------
-- END FOR EACH COLUMN
----------------------------------------------------------------------------------

-- Insert the AuditHeader row for PK changes
	select @SQL = @SQL  
         + '   INSERT @PrimaryKeys select distinct PrimaryKey from @AuditDetailUpdate '  + Char(13) + Char(10)  
         + '   INSERT ' + quotename(@AuditSchema) + '.AuditHeader (AuditDate, SysUser, Application, HostName, TableName, Operation, SQLStatement, '  + Char(13) + Char(10)
         + '   PrimaryKey, PrimaryKey2, PrimaryKey3, PrimaryKey4, PrimaryKey5, RowDescription, SecondaryRow, [RowVersion]) '  + Char(13) + Char(10)  
		 + '   OUTPUT  inserted.AuditHeaderID, quotename(inserted.PrimaryKey) + isnull(quotename(inserted.PrimaryKey2),'''') + isnull(quotename(inserted.PrimaryKey3),'''') + isnull(quotename(inserted.PrimaryKey4),'''') + isnull(quotename(inserted.PrimaryKey5),''''), inserted.[RowVersion] into @Keys (AuditHeaderID, PrimaryKey, NextRowVersion)' + Char(13) + Char(10) 
         + '     SELECT '

         -- StrictUserOption
   	     + CASE 
   	         WHEN @StrictUserContext = 1 THEN ' @AuditTime, SUSER_SNAME(),'
   	         ELSE 'COALESCE( inserted.' + @ModifiedColumnName + ', @AuditTime), COALESCE( inserted.' + @ModifiedByColumnName + ', Suser_Sname()),'
           END

         + ' APP_NAME(), Host_Name(), ' 
         + '''' + QUOTENAME(@SchemaName) + '.' + QUOTENAME(@TableName) + ''', ''u'','  --no quotename here

         -- if @LogSQL is off then the @UserSQL variable has not been declared
         + CASE @LogSQL
             WHEN 1 THEN ' @UserSQL, '
             ELSE ' NULL, ' 
           END  
          + '		' + replace(@PKColumnNameListWithDateConvert,'src.[','inserted.[') + ',' + left('null,null,null,null,',5*(5-@PKColumnQty)) + Char(13) + Char(10) 
       + '        NULL,     -- Row Description (e.g. Order Number)' + Char(13) + Char(10)   
       + '        NULL,     -- Secondary Row Value (e.g. Order Number for an Order Detail Line)' + Char(13) + Char(10)
          + '1' + Char(13) + Char(10)
       + '          FROM  inserted' + Char(13) + Char(10)
       + '             CROSS JOIN deleted' + Char(13) + Char(10)     
       + '          WHERE ' + replace(@PKColumnNameConcatenationWithQuotenameAndDateConvert,'src.[','inserted.[') + ' in (Select PrimaryKey from @PrimaryKeys)' + Char(13) + Char(10)
       + '-----' + Char(13) + Char(10) + Char(13) + Char(10)
	  from sys.tables as t
		  join sys.columns as c
		    on t.object_id = c.object_id
		  join sys.schemas as s
		    on s.schema_id = t.schema_id
        where t.name = @TableName AND s.name = @SchemaName 
           AND c.column_id = 1


--deal with RowVersion
	select @SQL = @SQL 
       + '	--calculate next row version' + Char(13) + Char(10)
       + '	;With NextRowVersions' + Char(13) + Char(10)
       + '	as' + Char(13) + Char(10)
       + '	(Select Keys.PrimaryKey, max(AH.[RowVersion]) + 1 as NextRowVersion' + Char(13) + Char(10)
       + '	From	' + quotename(@AuditSchema) + '.AuditHeader AH' + Char(13) + Char(10)
       + '	inner join @Keys as Keys' + Char(13) + Char(10)
       + '		on		quotename(AH.PrimaryKey) + isnull(quotename(AH.PrimaryKey2),'''') + isnull(quotename(AH.PrimaryKey3),'''') + isnull(quotename(AH.PrimaryKey4),'''') + isnull(quotename(AH.PrimaryKey5),'''') = Keys.PrimaryKey' + Char(13) + Char(10)--no quotename here
       + '		and		AH.TableName = ''' + QUOTENAME(@SchemaName) + '.' + QUOTENAME(@TableName) + '''' + Char(13) + Char(10)--no quotename here
       + '	group by Keys.PrimaryKey' + Char(13) + Char(10)
       + '	having count(*) > 1' + Char(13) + Char(10)
       + '	)' + Char(13) + Char(10)
       + '   UPDATE Keys' + Char(13) + Char(10)
       + '     SET  Keys.[NextRowVersion] = NRV.NextRowVersion' + Char(13) + Char(10)
       + '     FROM @Keys as Keys' + Char(13) + Char(10)
       + '     INNER JOIN	NextRowVersions NRV' + Char(13) + Char(10)
       + '		ON		Keys.PrimaryKey = NRV.PrimaryKey;' + Char(13) + Char(10)
       + '-----' + Char(13) + Char(10) + Char(13) + Char(10)

	--fix the RowVersion in the Audit table to match the actual data table on re-insertion
	select @SQL = @SQL 
	   + ' -- fix the RowVersion in the Audit table' + Char(13) + Char(10)
       + '   UPDATE AH' + Char(13) + Char(10)
       + '     SET AH.[RowVersion] = Keys.[NextRowVersion]' + Char(13) + Char(10)
       + '     FROM ' + quotename(@AuditSchema) + '.AuditHeader AH with (nolock) ' + Char(13) + Char(10)
       + '     INNER JOIN	@Keys as Keys' + Char(13) + Char(10)
       + '     ON AH.AuditHeaderID =  Keys.AuditHeaderID' + Char(13) + Char(10)
       + '     WHERE Keys.[NextRowVersion] <> 1' + Char(13) + Char(10)
       + '-----' + Char(13) + Char(10) + Char(13) + Char(10)

--added RowVersion increment fix to continue to increment the RowVersion
--when a particular PK row is deleted then re-inserted
	IF @StrictUserContext = 1 AND @BaseTableDDL = 1
	select @SQL = @SQL 
	     + ' -- Update the Created and Modified columns' + Char(13) + Char(10)
       + '   UPDATE src ' + Char(13) + Char(10)
       + '     SET ' + @CreatedColumnName + '  = deleted.' + @CreatedColumnName + ', ' + Char(13) + Char(10)
       + '         ' + @CreatedByColumnName + '  = deleted.' + @CreatedByColumnName + ', ' + Char(13) + Char(10)
       + '         ' + @ModifiedColumnName + ' = @AuditTime, ' + Char(13) + Char(10)
       + '         ' + @ModifiedByColumnName + '  = Suser_SName(), ' + Char(13) + Char(10)
       + '         ' + @RowVersionColumnName + ' = Keys.[NextRowVersion]' + Char(13) + Char(10)
       + '     FROM ' + quotename(@SchemaName) + '.' + quotename(@TableName) + ' as src with (nolock) ' + Char(13) + Char(10)
       + '       JOIN  @Keys as Keys'  + Char(13) + Char(10)
       + '         ON ' + @PKColumnNameConcatenationWithQuotenameAndDateConvert + ' =  Keys.[PrimaryKey]'
       + '     CROSS JOIN  deleted'  + Char(13) + Char(10)--OK, there's only one row for PK changes
       + '-----' + Char(13) + Char(10) + Char(13) + Char(10)

	IF @StrictUserContext = 0 AND @BaseTableDDL = 1
	select @SQL = @SQL 
	
       + ' -- Update the Created and Modified columns' + Char(13) + Char(10)
       + '   UPDATE ' + quotename(@SchemaName) + '.' + quotename(@TableName) + Char(13) + Char(10)
       + '     SET ' + Char(13) + Char(10)
       + '         ' + @ModifiedColumnName + ' = COALESCE( inserted.' + @ModifiedColumnName + ', @AuditTime), ' + Char(13) + Char(10)
       + '         ' + @ModifiedByColumnName + '  = COALESCE( inserted.' + @ModifiedByColumnName + ', Suser_SName()), ' + Char(13) + Char(10)
       + '         ' + @RowVersionColumnName + ' = Keys.[NextRowVersion]' + Char(13) + Char(10)
       + '     FROM ' + quotename(@SchemaName) + '.' + quotename(@TableName) + ' as src  with (nolock) ' + Char(13) + Char(10)
       + '       JOIN  @Keys as Keys'  + Char(13) + Char(10)
       + '         ON ' + @PKColumnNameConcatenationWithQuotenameAndDateConvert + ' =  Keys.[PrimaryKey]' + Char(13) + Char(10)
       + '       JOIN inserted'+ Char(13) + Char(10)
       + '         ON ' + @PKColumnNameConcatenationWithQuotenameAndDateConvert + ' = ' + replace(@PKColumnNameConcatenationWithQuotenameAndDateConvert,'src.[','inserted.[') + Char(13) + Char(10)
       + '-----' + Char(13) + Char(10) + Char(13) + Char(10)

	SELECT @SQL = @SQL 
        + '		end	  --the primary key has been changed on a single row'+ Char(13) + Char(10) 
		+ '		end	--the primary key has been changed' + Char(13) + Char(10)

		+ '	--****************************************************** ' + Char(13) + Char(10)   
		+ '	--***END - THIS SECTION IS USED WHEN THE PK IS CHANGED ' + Char(13) + Char(10)   
		+ '	--****************************************************** ' + Char(13) + Char(10)   
        + Char(13) + Char(10) + Char(13) + Char(10)


		+ '	--********************************************************** ' + Char(13) + Char(10)   
		+ '	--***START - THIS SECTION IS USED WHEN THE PK IS NOT CHANGED ' + Char(13) + Char(10)   
		+ '	--********************************************************** ' + Char(13) + Char(10)   

		+ 'else' + Char(13) + Char(10)
		+ '		begin	--the primary key has NOT been changed' + Char(13) + Char(10)


----------------------------------------------------------------------------------
-- BEGIN FOR EACH COLUMN
----------------------------------------------------------------------------------	  
	select @SQL = @SQL  
       + '   INSERT @AuditDetailUpdate (PrimaryKey, ColumnName, OldValue, NewValue)' + Char(13) + Char(10)
 --start of unpivot query
      + '   	SELECT PrimaryKey, ''['' + substring(AA_dColumnName ,2,128) + '']'', AA_OldValue, AA_NewValue' + Char(13) + Char(10)
       + '   FROM ' + Char(13) + Char(10)
       + '      (SELECT ' + replace(@PKColumnNameConcatenationWithQuotenameAndDateConvert,'src.[','inserted.[') + ' as PrimaryKey' + Char(13) + Char(10)
       
--add columns to unpivot query       
 	select @SQL = @SQL  
       + '	,isnull(convert(varchar(50),deleted.[' + c.name + '],' + @DateStyle + '),''<-null->'') as [d' + c.name + ']' + Char(13) + Char(10)
       + '	,isnull(convert(varchar(50),inserted.[' + c.name + '],' + @DateStyle + '),''<-null->'') as [i' + c.name + ']' + Char(13) + Char(10)
	  from sys.tables as t
		  join sys.columns as c
		    on t.object_id = c.object_id
		  join sys.schemas as s
		    on s.schema_id = t.schema_id
		  join sys.types as ty
		    on ty.user_type_id = c.user_type_id
        where t.name = @TableName AND s.name = @SchemaName 
           AND c.name NOT IN (@CreatedColumnName, @ModifiedColumnName, @CreatedByColumnName, @ModifiedByColumnName, @RowVersionColumnName)
           AND c.is_computed = 0
           AND ty.name NOT IN ('text', 'ntext', 'image', 'geography', 'xml', 'binary', 'varbinary', 'timestamp', 'rowversion')
           AND (@ColumnNames = '<All>' or @PKColumnNameList + @ColumnNames like '%[[]' + c.name + ']%') 
	  order by c.column_id      
 
      
 --data source for unpivot query       
	select @SQL = @SQL  
       + '          FROM  inserted' + Char(13) + Char(10)
       + '             JOIN deleted' + Char(13) + Char(10)
       + '               ON  ' + replace(@PKColumnNameConcatenationWithQuotenameAndDateConvert,'src.[','inserted.[') + ' = ' + replace(@PKColumnNameConcatenationWithQuotenameAndDateConvert,'src.[','deleted.[') + Char(13) + Char(10)
       + ') as SourceData' + Char(13) + Char(10)
 
     + 'UNPIVOT' + Char(13) + Char(10)
       + '   (AA_OldValue FOR AA_dColumnName IN (' + Char(13) + Char(10)

--add columns to unpivot query for deleted data   
 	select @SQL = @SQL  
       + case when c.column_id > 1 then ',' else '' end + quotename('d' + c.name) + Char(13) + Char(10)
	  from sys.tables as t
		  join sys.columns as c
		    on t.object_id = c.object_id
		  join sys.schemas as s
		    on s.schema_id = t.schema_id
		  join sys.types as ty
		    on ty.user_type_id = c.user_type_id
        where t.name = @TableName AND s.name = @SchemaName 
           AND c.name NOT IN (@CreatedColumnName, @ModifiedColumnName, @CreatedByColumnName, @ModifiedByColumnName, @RowVersionColumnName)
           AND c.is_computed = 0
           AND ty.name NOT IN ('text', 'ntext', 'image', 'geography', 'xml', 'binary', 'varbinary', 'timestamp', 'rowversion')
           AND (@ColumnNames = '<All>' or @PKColumnNameList + @ColumnNames like '%[[]' + c.name + ']%') 
	  order by c.column_id      

  	select @SQL = @SQL  
      + '      ))AS dUNPVT' + Char(13) + Char(10)

     + 'UNPIVOT' + Char(13) + Char(10)
       + '   (AA_NewValue FOR AA_iColumnName IN (' + Char(13) + Char(10)

--add columns to unpivot query for inserted data   
 	select @SQL = @SQL  
       + case when c.column_id > 1 then ',' else '' end + quotename('i' + c.name) + Char(13) + Char(10)
	  from sys.tables as t
		  join sys.columns as c
		    on t.object_id = c.object_id
		  join sys.schemas as s
		    on s.schema_id = t.schema_id
		  join sys.types as ty
		    on ty.user_type_id = c.user_type_id
        where t.name = @TableName AND s.name = @SchemaName 
           AND c.name NOT IN (@CreatedColumnName, @ModifiedColumnName, @CreatedByColumnName, @ModifiedByColumnName, @RowVersionColumnName)
           AND c.is_computed = 0
           AND ty.name NOT IN ('text', 'ntext', 'image', 'geography', 'xml', 'binary', 'varbinary', 'timestamp', 'rowversion')
           AND (@ColumnNames = '<All>' or @PKColumnNameList + @ColumnNames like '%[[]' + c.name + ']%') 
	  order by c.column_id      

  	select @SQL = @SQL  
      + '      ))AS iUNPVT' + Char(13) + Char(10)
      + '	  WHERE  substring(AA_dColumnName ,2,128) = substring(AA_iColumnName ,2,128)' + Char(13) + Char(10)
      + '	  AND ISNULL(AA_OldValue,''<-null->'') <> ISNULL(AA_NewValue,''<-null->'')' + Char(13) + Char(10) + Char(13) + Char(10)
      + '-----' + Char(13) + Char(10) + Char(13) + Char(10)

----------------------------------------------------------------------------------
-- END FOR EACH COLUMN
----------------------------------------------------------------------------------	  

--  Insert the AuditHeader row for NO PK changes
	select @SQL = @SQL  
         + '   INSERT @PrimaryKeys select distinct PrimaryKey from @AuditDetailUpdate '  + Char(13) + Char(10)  
         + '   INSERT ' + quotename(@AuditSchema) + '.AuditHeader (AuditDate, SysUser, Application, HostName, TableName, Operation, SQLStatement, PrimaryKey, PrimaryKey2, PrimaryKey3, PrimaryKey4, PrimaryKey5, RowDescription, SecondaryRow, [RowVersion]) '  + Char(13) + Char(10)  
		 + '   OUTPUT  inserted.AuditHeaderID, quotename(inserted.PrimaryKey) + isnull(quotename(inserted.PrimaryKey2),'''') + isnull(quotename(inserted.PrimaryKey3),'''') + isnull(quotename(inserted.PrimaryKey4),'''') + isnull(quotename(inserted.PrimaryKey5),''''), inserted.[RowVersion] into @Keys (AuditHeaderID, PrimaryKey, NextRowVersion)' + Char(13) + Char(10) 
         + '     SELECT '

         -- StrictUserOption
   	     + CASE 
   	         WHEN @StrictUserContext = 1 THEN ' @AuditTime, SUSER_SNAME(),'
   	         ELSE 'COALESCE( inserted.' + @ModifiedColumnName + ', @AuditTime), COALESCE( inserted.' + @ModifiedByColumnName + ', Suser_Sname()),'
           END

         + ' APP_NAME(), Host_Name(), ' 
         + '''' + QUOTENAME(@SchemaName) + '.' + QUOTENAME(@TableName) + ''', ''u'','  --no quotename here

         -- if @LogSQL is off then the @UserSQL variable has not been declared
         + CASE @LogSQL
             WHEN 1 THEN ' @UserSQL, '
             ELSE ' NULL, ' 
           END  
          + '  ' + replace(@PKColumnNameListWithDateConvert,'src.[','inserted.[') + ',' + left('null,null,null,null,',5*(5-@PKColumnQty)) + Char(13) + Char(10) 
       + '        NULL,     -- Row Description (e.g. Order Number)' + Char(13) + Char(10)   
       + '        NULL,     -- Secondary Row Value (e.g. Order Number for an Order Detail Line)' + Char(13) + Char(10)
          + case @BaseTableDDL 
				when 1 then ' deleted.' + @RowVersionColumnName + ' + 1' + Char(13) + Char(10)
				ELSE 		'1' + Char(13) + Char(10)
			END
       + '          FROM  inserted' + Char(13) + Char(10)
       + '             JOIN deleted' + Char(13) + Char(10)
       + '               ON ' + replace(@PKColumnNameConcatenationWithQuotenameAndDateConvert,'src.[','inserted.[') + ' = ' + replace(@PKColumnNameConcatenationWithQuotenameAndDateConvert,'src.[','deleted.[') + Char(13) + Char(10)       
       + '          WHERE ' + replace(@PKColumnNameConcatenationWithQuotenameAndDateConvert,'src.[','inserted.[') + ' in (Select PrimaryKey from @PrimaryKeys)' + Char(13) + Char(10)
       + '-----' + Char(13) + Char(10) + Char(13) + Char(10)
	  from sys.tables as t
		  join sys.columns as c
		    on t.object_id = c.object_id
		  join sys.schemas as s
		    on s.schema_id = t.schema_id
        where t.name = @TableName AND s.name = @SchemaName 
           AND c.column_id = 1

--deal with RowVersion
	select @SQL = @SQL 
       + case when @BaseTableDDL = 0 or @LogInsert = 0 then --added @LogInsert = 0 2013-01-29
        '	--calculate next row version' + Char(13) + Char(10)
       + '	;With NextRowVersions' + Char(13) + Char(10)
       + '	as' + Char(13) + Char(10)
       + '	(Select Keys.PrimaryKey, max(AH.[RowVersion]) + 1 as NextRowVersion' + Char(13) + Char(10)
       + '	From	' + quotename(@AuditSchema) + '.AuditHeader AH' + Char(13) + Char(10)
       + '	inner join @Keys as Keys' + Char(13) + Char(10)
       + '		on		quotename(AH.PrimaryKey) + isnull(quotename(AH.PrimaryKey2),'''') + isnull(quotename(AH.PrimaryKey3),'''') + isnull(quotename(AH.PrimaryKey4),'''') + isnull(quotename(AH.PrimaryKey5),'''') = Keys.PrimaryKey' + Char(13) + Char(10)--no quotename here
       + '		and		AH.TableName = ''' + QUOTENAME(@SchemaName) + '.' + QUOTENAME(@TableName) + '''' + Char(13) + Char(10)--no quotename here
       + '	group by Keys.PrimaryKey' + Char(13) + Char(10)
       + '	having count(*) > 1' + Char(13) + Char(10)
       + '	)' + Char(13) + Char(10)
       + '   UPDATE Keys' + Char(13) + Char(10)
       + '     SET  Keys.[NextRowVersion] = NRV.NextRowVersion' + Char(13) + Char(10)
       + '     FROM @Keys as Keys' + Char(13) + Char(10)
       + '     INNER JOIN	NextRowVersions NRV' + Char(13) + Char(10)
       + '		ON		Keys.PrimaryKey = NRV.PrimaryKey;' + Char(13) + Char(10)
       + '-----' + Char(13) + Char(10) + Char(13) + Char(10)
		else '' + Char(13) + Char(10)
		END

	--fix the RowVersion in the Audit table to match the actual data table on re-insertion
	select @SQL = @SQL 
	   + ' -- fix the RowVersion in the Audit table' + Char(13) + Char(10)
       + '   UPDATE AH' + Char(13) + Char(10)
       + '     SET AH.[RowVersion] = Keys.[NextRowVersion]' + Char(13) + Char(10)
       + '     FROM ' + quotename(@AuditSchema) + '.AuditHeader AH with (nolock)' + Char(13) + Char(10)
       + '     INNER JOIN	@Keys as Keys' + Char(13) + Char(10)
       + '     ON AH.AuditHeaderID =  Keys.AuditHeaderID' + Char(13) + Char(10)
       + '-----' + Char(13) + Char(10) + Char(13) + Char(10)

--added RowVersion increment fix to continue to increment the RowVersion
--when a particular PK row is deleted then re-inserted
	IF @StrictUserContext = 1 AND @BaseTableDDL = 1
	select @SQL = @SQL 
	   + ' -- Update the Created columns' + Char(13) + Char(10)
       + '   UPDATE src ' + Char(13) + Char(10)
       + '     SET ' + @CreatedColumnName + '  = deleted.' + @CreatedColumnName + ', ' + Char(13) + Char(10)
       + '         ' + @CreatedByColumnName + '  = deleted.' + @CreatedByColumnName + ' ' + Char(13) + Char(10)
       + '     FROM ' + quotename(@SchemaName) + '.' + quotename(@TableName) + ' as src with (nolock) ' + Char(13) + Char(10)
       + '       JOIN deleted'+ Char(13) + Char(10)
       + '         ON ' + @PKColumnNameConcatenationWithQuotenameAndDateConvert + ' = ' + replace(@PKColumnNameConcatenationWithQuotenameAndDateConvert,'src.[','deleted.[') + Char(13) + Char(10)
       + '     where	isnull(src.' + @CreatedColumnName + ',''1/1/1'')  <> isnull(deleted.' + @CreatedColumnName + ',''1/1/1'')' + Char(13) + Char(10)
       + '	     or		isnull(src.' + @CreatedByColumnName + ',''wasnull!'')  <> isnull(deleted.' + @CreatedByColumnName + ',''wasnull!'')' + Char(13) + Char(10)
       + '-----' + Char(13) + Char(10) + Char(13) + Char(10)

	   + ' -- Update the Modified and RowVersion columns' + Char(13) + Char(10)
       + '   UPDATE src ' + Char(13) + Char(10)
       + '     SET ' + @ModifiedColumnName + ' = @AuditTime, ' + Char(13) + Char(10)
       + '         ' + @ModifiedByColumnName + '  = Suser_SName(), ' + Char(13) + Char(10)
       + '         ' + @RowVersionColumnName + ' = Keys.[NextRowVersion]' + Char(13) + Char(10)
       + '     FROM ' + quotename(@SchemaName) + '.' + quotename(@TableName) + ' as src with (nolock) ' + Char(13) + Char(10)
       + '       JOIN  @Keys as Keys'  + Char(13) + Char(10)
       + '         ON ' + @PKColumnNameConcatenationWithQuotenameAndDateConvert + ' =  Keys.[PrimaryKey]'
       + '-----' + Char(13) + Char(10) + Char(13) + Char(10)

	IF @StrictUserContext = 0 AND @BaseTableDDL = 1
	select @SQL = @SQL 
       + ' -- Update the Created and Modified columns' + Char(13) + Char(10)
       + '   UPDATE src '  + Char(13) + Char(10)
       + '     SET ' + Char(13) + Char(10)
       + '         ' + @ModifiedColumnName + ' = COALESCE( inserted.' + @ModifiedColumnName + ', @AuditTime), ' + Char(13) + Char(10)
       + '         ' + @ModifiedByColumnName + '  = COALESCE( inserted.' + @ModifiedByColumnName + ', Suser_SName()), ' + Char(13) + Char(10)
       + '         ' + @RowVersionColumnName + ' = Keys.[NextRowVersion]' + Char(13) + Char(10)
       + '     FROM ' + quotename(@SchemaName) + '.' + quotename(@TableName) + ' as src with (nolock) ' + Char(13) + Char(10)
       + '       JOIN  @Keys as Keys'  + Char(13) + Char(10)
       + '         ON ' + @PKColumnNameConcatenationWithQuotenameAndDateConvert + ' =  Keys.[PrimaryKey]'
       + '       JOIN inserted'+ Char(13) + Char(10)
       + '         ON ' + @PKColumnNameConcatenationWithQuotenameAndDateConvert + ' = ' + replace(@PKColumnNameConcatenationWithQuotenameAndDateConvert,'src.[','inserted.[') + Char(13) + Char(10)
       +  Char(13) + Char(10) 
	SELECT @SQL = @SQL 
	   + '		end	--the primary key has NOT been changed' + Char(13) + Char(10)

        +  Char(13) + Char(10) + Char(13) + Char(10)
		+ '	--********************************************************** ' + Char(13) + Char(10)   
		+ '	--***END - THIS SECTION IS USED WHEN THE PK IS NOT CHANGED ' + Char(13) + Char(10)   
		+ '	--********************************************************** ' + Char(13) + Char(10)   
  
        + '-----' + Char(13) + Char(10) + Char(13) + Char(10)

--insert AuditDetail table
 IF @LogUpdate = 2 -- log data to the AuditDetail table
	select @SQL = @SQL + 
       + '   INSERT ' + quotename(@AuditSchema) + '.AuditDetail (AuditHeaderID, ColumnName, OldValue, NewValue)' + Char(13) + Char(10)
       + '   Select	Keys.AuditHeaderID, ADU.ColumnName, ADU.OldValue, ADU.NewValue ' + Char(13) + Char(10) 
       + '   from @AuditDetailUpdate ADU' + Char(13) + Char(10) 
       + '   INNER JOIN @Keys as Keys' + Char(13) + Char(10)
       + '		ON	ADU.PrimaryKey = Keys.PrimaryKey;' + Char(13) + Char(10) + Char(13) + Char(10) 

END -- IF @LogUpdate = 0 (ELSE)

	select @SQL = @SQL + 
       + 'IF @DebugFlag = 1 PRINT ''Ending Update trigger normally: ' + quotename(@SchemaName) + '.' + quotename(@TableName + '_Audit_Update') + ', nest level = '' + cast(@NestLevel as varchar)' + Char(13) + Char(10) + Char(13) + Char(10)

        + '-----' + Char(13) + Char(10) + Char(13) + Char(10)

       + ' End Try ' + Char(13) + Char(10)
       + ' Begin Catch ' + Char(13) + Char(10)
       + '   DECLARE @ErrorMessage NVARCHAR(4000), @ErrorSeverity INT, @ErrorState INT, @ErrorLine INT;' + Char(13) + Char(10) 

       + '   SET @ErrorMessage = ERROR_MESSAGE();  ' + Char(13) + Char(10)
       + '   SET @ErrorSeverity = ERROR_SEVERITY(); ' + Char(13) + Char(10) 
       + '   SET @ErrorState = ERROR_STATE();  ' + Char(13) + Char(10)
       + '   SET @ErrorLine = ERROR_LINE();  ' + Char(13) + Char(10)
       + '   RAISERROR(@ErrorMessage,@ErrorSeverity,@ErrorState)' + case when @WithLogFlag = 1 then ' with log;' else ';' end + Char(13) + Char(10) 
       + '   PRINT ''Error Line: '' + cast(@ErrorLine as varchar);' + Char(13) + Char(10)

       + ' End Catch ' 

EXEC (@SQL)

SET @SQL = quotename(@SchemaName) + '.' + quotename(@TableName + '_Audit_Update')

EXEC sp_settriggerorder 
  @triggername= @SQL, 
  @order='Last', 
  @stmttype = 'UPDATE';

END --IF NOT (@LogUpdate = 0 @BaseTableDDL = 0)

--------------------------------------------------------------------------------
--------------------------------------------------------------------------------
-- build delete trigger 
If @LogDelete > 0
BEGIN
print '	Creating Delete trigger'

SET @SQL = 'CREATE TRIGGER ' + quotename(@SchemaName) + '.' + quotename(@TableName + '_Audit_Delete') + ' ON ' + quotename(@SchemaName) + '.' + quotename(@TableName) + Char(13) + Char(10)
       + ' AFTER Delete' + Char(13) + Char(10) + ' NOT FOR REPLICATION AS' + Char(13) + Char(10)
       + ' SET NoCount On ' + Char(13) + Char(10) + Char(13) + Char(10)
       + ' -- generated by AutoAudit Version ' + @Version + ' on ' + Convert(VARCHAR(30), GetDate(),100)  + Char(13) + Char(10)
       + ' -- created by Paul Nielsen and John Sigouin ' + Char(13) + Char(10)
       + ' -- www.SQLServerBible.com ' + Char(13) + Char(10)
       + ' -- AutoAudit.codeplex.com ' + Char(13) + Char(10) + Char(13) + Char(10)

       + ' -- Options: ' + Char(13) + Char(10)
       + ' --   StrictUserContext : ' + CAST(@StrictUserContext as CHAR(1)) + Char(13) + Char(10)
       + ' --   LogSQL            : ' + CAST(@LogSQL as CHAR(1)) + Char(13) + Char(10)
       + ' --   BaseTableDDL      : ' + CAST(@BaseTableDDL as CHAR(1)) + Char(13) + Char(10)
       + ' --   LogInsert         : ' + CAST(@LogInsert as CHAR(1)) + Char(13) + Char(10)
       + ' --   LogUpdate         : ' + CAST(@LogUpdate as CHAR(1)) + Char(13) + Char(10)
       + ' --   LogDelete         : ' + CAST(@LogDelete as CHAR(1)) + Char(13) + Char(10) 
       + ' --   ColumnNames       : ' + CAST(@ColumnNames as VARCHAR(1024)) + Char(13) + Char(10) + Char(13) + Char(10)
      
SELECT @SQL = @SQL 
    + 'declare  @DebugFlag BIT,' + Char(13) + Char(10)
    + '  @NestLevel TINYINT' + Char(13) + Char(10)

	+ 'Select @DebugFlag = SettingValue from ' + quotename(@AuditSchema) + '.[AuditSettings] where SettingName = ''Audit Trigger Debug Flag''' + Char(13) + Char(10)
	+ 'Select @NestLevel = TRIGGER_NESTLEVEL(OBJECT_ID(''' + quotename(@SchemaName) + '.' + quotename(@TableName + '_Audit_Delete') + '''), ''AFTER'', ''DML'')' + Char(13) + Char(10) + Char(13) + Char(10)
    + 'IF @DebugFlag = 1 PRINT ''Firing Delete trigger: ' + quotename(@SchemaName) + '.' + quotename(@TableName + '_Audit_Delete') + ', nest level = '' + cast(@NestLevel as varchar)' + Char(13) + Char(10) + Char(13) + Char(10)

    + ' -- prevent recursive runs of this trigger' + Char(13) + Char(10)
    + ' IF TRIGGER_NESTLEVEL(OBJECT_ID(''' + quotename(@SchemaName) + '.' + quotename(@TableName + '_Audit_Delete')+ '''), ''AFTER'', ''DML'') > 1' + Char(13) + Char(10)
    + '   BEGIN' + Char(13) + Char(10)
    + '     IF @DebugFlag = 1 PRINT ''   TRIGGER_NESTLEVEL > 1. Exiting trigger...''' + Char(13) + Char(10)
    + ' 	   return' + Char(13) + Char(10)
    + '   END' + Char(13) + Char(10) + Char(13) + Char(10)
       
	+ '--get the EnabledFlag setting from the AuditBaseTables table' + Char(13) + Char(10)
	+ 'IF NOT EXISTS (SELECT 1 FROM ' + quotename(@AuditSchema) + '.[AuditBaseTables] '
	+ ' WHERE [SchemaName] = ''' + @SchemaName + ''''
	+ ' AND [TableName] = ''' + @TableName + ''''
	+ ' AND [EnabledFlag] = 1)' + Char(13) + Char(10)
    + '   BEGIN' + Char(13) + Char(10)
    + '     IF @DebugFlag = 1 PRINT ''AutoAudit EnabledFlag set to "false" for this table in the AuditBaseTables table. Exiting trigger...''' + Char(13) + Char(10)
	+ ' 	return' + Char(13) + Char(10)
    + '   END' + Char(13) + Char(10) + Char(13) + Char(10)

       + 'DECLARE @AuditTime DATETIME' + Char(13) + Char(10)
       + 'SET @AuditTime = GetDate()' + Char(13) + Char(10) + Char(13) + Char(10)
       
       + ' Begin Try ' + Char(13) + Char(10)
       
   IF @LogSQL = 1 
     BEGIN  
     	 select @SQL = @SQL
         + ' -- capture SQL Statement' + Char(13) + Char(10)
         + ' DECLARE @ExecStr varchar(50), @UserSQL nvarchar(max)' + Char(13) + Char(10)
         + ' DECLARE  @inputbuffer TABLE' + Char(13) + Char(10) 
         + ' (EventType nvarchar(30), Parameters int, EventInfo nvarchar(max))' + Char(13) + Char(10)
         + ' SET @ExecStr = ''DBCC INPUTBUFFER(@@SPID) with no_infomsgs''' + Char(13) + Char(10)
         + ' INSERT INTO @inputbuffer' + Char(13) + Char(10) 
         + '   EXEC (@ExecStr)' + Char(13) + Char(10)
         + ' SELECT @UserSQL = EventInfo FROM @inputbuffer' + Char(13) + Char(10)
         + Char(13) + Char(10) 
     END   

--create a temp table for mapping keys
select @SQL = @SQL
		+ 'Declare @Keys Table (AuditHeaderID BIGINT, PrimaryKey VARCHAR(250), NextRowVersion int default(0))' + Char(13) + Char(10) 

-- Insert the AuditHeader row
	select @SQL = @SQL
          + Char(13) + Char(10)
		      + '   INSERT ' + quotename(@AuditSchema) + '.AuditHeader (AuditDate, SysUser, Application, HostName, TableName, Operation, SQLStatement, PrimaryKey, PrimaryKey2, PrimaryKey3, PrimaryKey4, PrimaryKey5, RowDescription, SecondaryRow, [RowVersion])' + Char(13) + Char(10)
		      + '   OUTPUT  inserted.AuditHeaderID,  quotename(inserted.PrimaryKey) + isnull(quotename(inserted.PrimaryKey2),'''') + isnull(quotename(inserted.PrimaryKey3),'''') + isnull(quotename(inserted.PrimaryKey4),'''') + isnull(quotename(inserted.PrimaryKey5),'''') into @Keys (AuditHeaderID,PrimaryKey) '  + Char(13) + Char(10)
		      + '   SELECT ' 
		      
		      -- StrictUserOption
		      + CASE @StrictUserContext
		          WHEN 0 -- allow DML setting of created/modified user and datetimes
		            THEN ' COALESCE( src.' + @ModifiedColumnName + ', @AuditTime), COALESCE( src.' + @ModifiedByColumnName + ', Suser_SName()),'
		          ELSE -- block DML setting of user context 
		             ' @AuditTime, Suser_SName(),'
		        END 
		      
		      + ' APP_NAME(), Host_Name(), ' 
          + '''' + QUOTENAME(@SchemaName) + '.' + QUOTENAME(@TableName) + ''', ''d'','  --no quotename here
          
          -- if @LogSQL is off then the @UserSQL variable has not been declared
          + CASE @LogSQL
              WHEN 1 THEN ' @UserSQL, '
              ELSE ' NULL, ' 
           END  
          + Char(13) + Char(10)  
          
          + '  ' + @PKColumnNameListWithDateConvert + ',' + left('null,null,null,null,',5*(5-@PKColumnQty)) + Char(13) + Char(10) 
          + '        NULL,     -- Row Description (e.g. Order Number)' + Char(13) + Char(10)   
          + '        NULL,     -- Secondary Row Value (e.g. Order Number for an Order Detail Line)' + Char(13) + Char(10)
          + '0'
          + '          FROM  deleted as src' + Char(13) + Char(10)
          + '          WHERE  src.['+ c.name + '] is not null' + Char(13) + Char(10)+ Char(13) + Char(10)
	  from sys.tables as t
		  join sys.columns as c
		    on t.object_id = c.object_id
		  join sys.schemas as s
		    on s.schema_id = t.schema_id
        where t.name = @TableName AND s.name = @SchemaName 
           AND c.column_id = 1

--deal with RowVersion
	select @SQL = @SQL 
 	   + '-----' + Char(13) + Char(10) + Char(13) + Char(10)
       + '	--calculate next row version' + Char(13) + Char(10)
       + '	;With NextRowVersions' + Char(13) + Char(10)
       + '	as' + Char(13) + Char(10)
       + '	(Select Keys.PrimaryKey, max(AH.[RowVersion]) + 1 as NextRowVersion' + Char(13) + Char(10)
       + '	From	' + quotename(@AuditSchema) + '.AuditHeader AH' + Char(13) + Char(10)
       + '	inner join @Keys as Keys' + Char(13) + Char(10)
       + '		on		quotename(AH.PrimaryKey) + isnull(quotename(AH.PrimaryKey2),'''') + isnull(quotename(AH.PrimaryKey3),'''') + isnull(quotename(AH.PrimaryKey4),'''') + isnull(quotename(AH.PrimaryKey5),'''') = Keys.PrimaryKey' + Char(13) + Char(10)--no quotename here
       + '		and		AH.TableName = ''' + QUOTENAME(@SchemaName) + '.' + QUOTENAME(@TableName) + '''' + Char(13) + Char(10)--no quotename here
       + '	group by Keys.PrimaryKey' + Char(13) + Char(10)
       + '	)' + Char(13) + Char(10)
       + '   UPDATE Keys' + Char(13) + Char(10)
       + '     SET  Keys.[NextRowVersion] = NRV.NextRowVersion' + Char(13) + Char(10)
       + '     FROM @Keys as Keys' + Char(13) + Char(10)
       + '     INNER JOIN	NextRowVersions NRV' + Char(13) + Char(10)
       + '		ON		Keys.PrimaryKey = NRV.PrimaryKey;' + Char(13) + Char(10) 
       + '-----' + Char(13) + Char(10) + Char(13) + Char(10)

	--fix the RowVersion in the Audit table to match the actual data table on re-insertion
	select @SQL = @SQL 
	   + ' -- fix the RowVersion in the Audit table' + Char(13) + Char(10)
       + '   UPDATE AH' + Char(13) + Char(10)
       + '     SET AH.[RowVersion] = Keys.[NextRowVersion]' + Char(13) + Char(10)
       + '     FROM ' + quotename(@AuditSchema) + '.AuditHeader AH with (nolock)' + Char(13) + Char(10)
       + '     INNER JOIN	@Keys as Keys' + Char(13) + Char(10)
       + '     ON AH.AuditHeaderID =  Keys.AuditHeaderID' + Char(13) + Char(10)
       + '-----' + Char(13) + Char(10) + Char(13) + Char(10)

If @LogDelete = 2
BEGIN
----------------------------------------------------------------------------------
-- Insert AuditDetail Table
----------------------------------------------------------------------------------	  
----------------------------------------------------------------------------------
-- BEGIN FOR EACH COLUMN
----------------------------------------------------------------------------------	  
	select @SQL = @SQL  
       + '   INSERT ' + quotename(@AuditSchema) + '.AuditDetail (AuditHeaderID, ColumnName, OldValue)' + Char(13) + Char(10)
--start of unpivot query
       + '   	SELECT AuditHeaderID, ''['' + AA_ColumnName + '']'', AA_OldValue' + Char(13) + Char(10)
       + '   FROM ' + Char(13) + Char(10)
       + '      (SELECT Keys.AuditHeaderID as AuditHeaderID' + Char(13) + Char(10)

--add columns to unpivot query       
 	select @SQL = @SQL  
       + '	,convert(varchar(50),deleted.[' + c.name + '],' + @DateStyle + ') as [' + c.name + ']' + Char(13) + Char(10)
	  from sys.tables as t
		  join sys.columns as c
		    on t.object_id = c.object_id
		  join sys.schemas as s
		    on s.schema_id = t.schema_id
		  join sys.types as ty
		    on ty.user_type_id = c.user_type_id
        where t.name = @TableName AND s.name = @SchemaName 
           AND c.is_computed = 0
           AND ty.name NOT IN ('text', 'ntext', 'image', 'geography', 'xml', 'binary', 'varbinary', 'timestamp', 'rowversion')
           AND (@ColumnNames = '<All>' or @PKColumnNameList + @ColumnNames like '%[[]' + c.name + ']%') 
	  order by c.column_id      
       
 --data source for unpivot query       
	select @SQL = @SQL  
       + '	  FROM  deleted' + Char(13) + Char(10)
       + '	  JOIN	 @Keys as Keys' + Char(13) + Char(10)
       + '		ON	 ' + replace(@PKColumnNameConcatenationWithQuotenameAndDateConvert,'src.[','deleted.[') + ' = Keys.PrimaryKey' + Char(13) + Char(10)
       + ') as SourceData' + Char(13) + Char(10)
       + 'UNPIVOT' + Char(13) + Char(10)
       + '   (AA_OldValue FOR AA_ColumnName IN (' + Char(13) + Char(10)

--add filter to unpivot query       
 	select @SQL = @SQL  
       + case when c.column_id > 1 then ',' else '' end + quotename(c.name) + Char(13) + Char(10)
	  from sys.tables as t
		  join sys.columns as c
		    on t.object_id = c.object_id
		  join sys.schemas as s
		    on s.schema_id = t.schema_id
		  join sys.types as ty
		    on ty.user_type_id = c.user_type_id
        where t.name = @TableName AND s.name = @SchemaName 
           AND c.is_computed = 0
           AND ty.name NOT IN ('text', 'ntext', 'image', 'geography', 'xml', 'binary', 'varbinary', 'timestamp', 'rowversion')
           AND (@ColumnNames = '<All>' or @PKColumnNameList + @ColumnNames like '%[[]' + c.name + ']%') 
	  order by c.column_id      

  	select @SQL = @SQL  
      + '      )' + Char(13) + Char(10)
       + ')AS UNPVT' + Char(13) + Char(10)
       + '	  WHERE  AA_OldValue is not null' + Char(13) + Char(10) + Char(13) + Char(10)

----------------------------------------------------------------------------------
-- END FOR EACH COLUMN
----------------------------------------------------------------------------------	  
END --If @LogDelete = 2

	select @SQL = @SQL + 

       + 'IF @DebugFlag = 1 PRINT ''Ending Delete trigger normally: ' + quotename(@SchemaName) + '.' + quotename(@TableName + '_Audit_Delete') + ', nest level = '' + cast(@NestLevel as varchar)' + Char(13) + Char(10) + Char(13) + Char(10)

       + '-----' + Char(13) + Char(10) + Char(13) + Char(10)

       + ' End Try ' + Char(13) + Char(10)
       + ' Begin Catch ' + Char(13) + Char(10)
       + '   DECLARE @ErrorMessage NVARCHAR(4000), @ErrorSeverity INT, @ErrorState INT, @ErrorLine INT;' + Char(13) + Char(10) 

       + '   SET @ErrorMessage = ERROR_MESSAGE();  ' + Char(13) + Char(10)
       + '   SET @ErrorSeverity = ERROR_SEVERITY(); ' + Char(13) + Char(10) 
       + '   SET @ErrorState = ERROR_STATE();  ' + Char(13) + Char(10)
       + '   SET @ErrorLine = ERROR_LINE();  ' + Char(13) + Char(10)
       + '   RAISERROR(@ErrorMessage,@ErrorSeverity,@ErrorState)' + case when @WithLogFlag = 1 then ' with log;' else ';' end + Char(13) + Char(10) 
       + '   PRINT ''Error Line: '' + cast(@ErrorLine as varchar);' + Char(13) + Char(10)
       + ' End Catch ' 

EXEC (@SQL)

SET @SQL = quotename(@SchemaName) + '.' + quotename(@TableName + '_Audit_Delete')

EXEC sp_settriggerorder 
  @triggername= @SQL, 
  @order='Last', 
  @stmttype = 'DELETE';

END --If @LogDelete > 0

--------------------------------------------------------------------------------------------
-- build _Deleted view
print '	Creating _Deleted view'

SET @SQL = 'CREATE VIEW ' + quotename(@ViewSchema) + '.' + quotename(@ViewPrefix + @TableName + @DeletedViewSuffix) + Char(13) + Char(10)
       + 'AS ' + Char(13) + Char(10) + Char(13) + Char(10) 
       + ' -- generated by AutoAudit Version ' + @Version + ' on ' + Convert(VARCHAR(30), GetDate(),100)  + Char(13) + Char(10)
       + ' -- created by Paul Nielsen and John Sigouin ' + Char(13) + Char(10)
       + ' -- www.SQLServerBible.com ' + Char(13) + Char(10)
       + ' -- AutoAudit.codeplex.com ' + Char(13) + Char(10)
       + ' -- This view returns details about the rows that have been deleted in the referenced table.' + Char(13) + Char(10) + Char(13) + Char(10)

SELECT @SQL = @SQL + 
'WITH	MostRecentDeletes ' + Char(13) + Char(10)
+ 'AS ' + Char(13) + Char(10)
+ '		(SELECT		PrimaryKey, PrimaryKey2, PrimaryKey3, PrimaryKey4, PrimaryKey5, ' + Char(13) + Char(10)
+ '					max([RowVersion]) AS [RowVersion] ' + Char(13) + Char(10)
+ '		FROM		' + quotename(@AuditSchema) + '.AuditHeader ' + Char(13) + Char(10)
+ '		WHERE		TableName = ''' + QUOTENAME(@SchemaName) + '.' + QUOTENAME(@TableName) + ''' ' + Char(13) + Char(10)--no quotename here
+ '			AND		Operation = ''d'' ' + Char(13) + Char(10)
+ '		GROUP BY	PrimaryKey, PrimaryKey2, PrimaryKey3, PrimaryKey4, PrimaryKey5) ' + Char(13) + Char(10)

+ 'SELECT' + Char(13) + Char(10)
----for the table's primary key column(s)
--+ '		PivotData.PrimaryKey AS ' + quotename(@PKColumnName) + Char(13) + Char(10)
+ @PKColumnsForDeletedView + Char(13) + Char(10)

--for each column
SELECT @SQL = @SQL +
--		case when c.column_id > 1 then '		,' else '		' end + 
		'		,PivotData.[' + c.name + ']'  + Char(13) + Char(10)
	  from sys.tables as t
		join sys.columns as c
		  on t.object_id = c.object_id
		join sys.schemas as s
		  on s.schema_id = t.schema_id
		join sys.types as ty
		  on ty.user_type_id = c.user_type_id

--the next two joins are to exclude PK columns
		left join	sys.indexes i
			on		t.object_id = i.object_id
			and		i.is_primary_key = 1 
		left join	sys.index_columns ic
			on		i.object_id = ic.object_id
			and		i.index_id = ic.index_id
			and		c.column_id = ic.column_id

      where t.name = @TableName AND s.name = @SchemaName 
         AND c.is_computed = 0
         AND ic.column_id is null
         AND ty.name NOT IN ('text', 'ntext', 'image', 'geography', 'xml', 'binary', 'varbinary', 'timestamp', 'rowversion')
         AND (@ColumnNames = '<All>' or @PKColumnNameList + @ColumnNames like '%[[]' + c.name + ']%') 
	  order by c.column_id

SELECT @SQL = @SQL +
+ '		,SysUser as DeletedBy ' + Char(13) + Char(10)
+ '		,CASE WHEN mrd.[RowVersion] = PivotData.HRowVersion then 1 else 0 end AS MostRecentDeleteFlag'  + Char(13) + Char(10)
+ '		,''' + ISNULL(@RowHistoryViewScope ,'Active') + ''' AS ViewScope' + Char(13) + Char(10)
+ '		,RowHistorySource' + Char(13) + Char(10)
+ 'FROM 	(SELECT		AH.AuditHeaderID, '  + Char(13) + Char(10)
+ '					AH.PrimaryKey, '  + Char(13) + Char(10)
+ '					AH.PrimaryKey2, '  + Char(13) + Char(10)
+ '					AH.PrimaryKey3, '  + Char(13) + Char(10)
+ '					AH.PrimaryKey4, '  + Char(13) + Char(10)
+ '					AH.PrimaryKey5, '  + Char(13) + Char(10)
+ '					AH.[RowVersion] AS HRowVersion, '  + Char(13) + Char(10)
+ '					AH.[SysUser] AS SysUser, '  + Char(13) + Char(10)
+ '					SUBSTRING(AD.ColumnName,2,LEN(AD.ColumnName)-2) AS ColumnName, '  + Char(13) + Char(10)
+ '					ISNULL(AD.NewValue,AD.OldValue) AS NewValue'  + Char(13) + Char(10)
+ '					,' + CASE ISNULL(@RowHistoryViewScope ,'Active') 
							WHEN 'All' THEN 'AH.[Source]'
							ELSE '''' + ISNULL(@RowHistoryViewScope ,'Active') + ''''
						END + ' AS RowHistorySource' + Char(13) + Char(10)
+ '		FROM		' + quotename(@AuditSchema) + '.' + 
			CASE ISNULL(@RowHistoryViewScope ,'Active') 
				WHEN 'All' THEN '[vAuditHeaderAll]'
				WHEN 'Active' THEN '[AuditHeader]'
				WHEN 'Archive' THEN '[AuditHeaderArchive]'
				ELSE '[AuditHeader]'
			END
+ ' AS AH'  + Char(13) + Char(10)
+ '		LEFT JOIN	' + quotename(@AuditSchema) + '.' +
			CASE @RowHistoryViewScope 
				WHEN 'All' THEN '[vAuditDetailAll]'
				WHEN 'Active' THEN '[AuditDetail]'
				WHEN 'Archive' THEN '[AuditDetailArchive]'
				ELSE '[AuditDetail]'
			END
+ ' AS AD'  + Char(13) + Char(10)
+ '			ON		AH.AuditHeaderID = AD.AuditHeaderID'  + Char(13) + Char(10)
+ '		WHERE		AH.TableName=''' + QUOTENAME(@SchemaName) + '.' + QUOTENAME(@TableName) + ''''  + Char(13) + Char(10)--no quotename here
+ '			AND		AH.Operation=''d'') AS AD'  + Char(13) + Char(10)
+ '		PIVOT		(MAX (NewValue)'  + Char(13) + Char(10)
+ '			FOR		ColumnName IN'  + Char(13) + Char(10)
+ '					('  + Char(13) + Char(10)
--for each column
SELECT @SQL = @SQL +
		'					' + case when c.column_id > 1 then ',' else '' end + '[' + c.name + ']'  + Char(13) + Char(10)
	  from sys.tables as t
		join sys.columns as c
		  on t.object_id = c.object_id
		join sys.schemas as s
		  on s.schema_id = t.schema_id
		join sys.types as ty
		  on ty.user_type_id = c.user_type_id
      where t.name = @TableName AND s.name = @SchemaName 
         AND c.is_computed = 0
         AND ty.name NOT IN ('text', 'ntext', 'image', 'geography', 'xml', 'binary', 'varbinary', 'timestamp', 'rowversion')
         AND (@ColumnNames = '<All>' or @PKColumnNameList + @ColumnNames like '%[[]' + c.name + ']%') 
	  order by c.column_id

SELECT @SQL = @SQL +
'					)'  + Char(13) + Char(10)
+ '					) AS PivotData'  + Char(13) + Char(10)
+ 'LEFT JOIN 	MostRecentDeletes mrd'  + Char(13) + Char(10)
+ '	ON 		PivotData.PrimaryKey = mrd.PrimaryKey'  + Char(13) + Char(10)
+ '	AND 	isnull(PivotData.PrimaryKey2,'''') = isnull(mrd.PrimaryKey2,'''')'  + Char(13) + Char(10)
+ '	AND 	isnull(PivotData.PrimaryKey3,'''') = isnull(mrd.PrimaryKey3,'''')'  + Char(13) + Char(10)
+ '	AND 	isnull(PivotData.PrimaryKey4,'''') = isnull(mrd.PrimaryKey4,'''')'  + Char(13) + Char(10)
+ '	AND 	isnull(PivotData.PrimaryKey5,'''') = isnull(mrd.PrimaryKey5,'''')'  + Char(13) + Char(10)
+ '	AND 	PivotData.HRowVersion = mrd.[RowVersion]'  + Char(13) + Char(10)

IF @CreateDeletedView = 1
	EXEC (@SQL)

--------------------------------------------------------------------------------------------
-- build RowHistory view
print '	Creating _RowHistory view'

SET @SQL = 'CREATE VIEW ' + quotename(@ViewSchema) + '.' + quotename(@ViewPrefix + @TableName + @RowHistoryViewSuffix) + Char(13) + Char(10)
       + 'AS ' + Char(13) + Char(10) + Char(13) + Char(10) 
       + ' -- generated by AutoAudit Version ' + @Version + ' on ' + Convert(VARCHAR(30), GetDate(),100)  + Char(13) + Char(10)
       + ' -- created by Paul Nielsen and John Sigouin ' + Char(13) + Char(10)
       + ' -- www.SQLServerBible.com ' + Char(13) + Char(10)
       + ' -- AutoAudit.codeplex.com ' + Char(13) + Char(10)
       + ' -- This view returns historical record entries for the referenced table.' + Char(13) + Char(10) + Char(13) + Char(10)


SELECT @SQL = @SQL + 
'SELECT' + Char(13) + Char(10)
--for the table's row info columns
+ '		PivotData.AuditDate'+ Char(13) + Char(10)
+ '		,PivotData.Operation'+ Char(13) + Char(10)
+ '		,PivotData.HRowVersion AS [RowVersion]' + Char(13) + Char(10)

;With ColumnInfo as (
Select top 100000 quotename(sc.name) + ' ' + 
				Char(13) + Char(10) as TheColumn
		,isnull(sik.index_column_id,2147483647) as PrimarySort
		,sc.column_id	
		, row_number() over (order by isnull(sik.index_column_id,2147483647)) PKOrder			
	from		sys.tables as t
	inner join	sys.columns sc
		on		t.object_id = sc.object_id
	inner join	sys.types as ty
		on		ty.user_type_id = sc.user_type_id
	inner join	sys.schemas as s
		on		s.schema_id = t.schema_id
	left join	sys.key_constraints as kc
		on		t.object_id = kc.parent_object_id
		and		kc.type = 'PK'
	left join	sys.index_columns sik 
		on		t.object_id = sik.object_id 
		and		kc.unique_index_id = sik.index_id
		and		sc.column_id = sik.column_id
where	t.name = @TableName AND s.name = @SchemaName 
	AND sc.is_computed = 0
	AND ty.name NOT IN ('text', 'ntext', 'image', 'geography', 'xml', 'binary', 'varbinary', 'timestamp', 'rowversion')
	AND (@PKColumnNameList like '%[[]' + sc.name + ']%')
order by	isnull(sik.index_column_id,2147483647),
			sc.column_id
	)
Select	@SQL = @SQL +	 
		'		,PivotData.' + 'PrimaryKey' + Case PKOrder when 1 then '' else cast(PKOrder as varchar(1)) end + ' AS ' + TheColumn + Char(13) + Char(10)
From		ColumnInfo
order by	column_id
	
--for each non-PK column
SELECT @SQL = @SQL +
		'		,PivotData.[' + c.name + ']'  + Char(13) + Char(10)
	  from sys.tables as t
		join sys.columns as c
		  on t.object_id = c.object_id
		join sys.schemas as s
		  on s.schema_id = t.schema_id
		join sys.types as ty
		  on ty.user_type_id = c.user_type_id
      where t.name = @TableName AND s.name = @SchemaName 
         AND c.is_computed = 0
        AND c.name NOT IN (@CreatedColumnName, @ModifiedColumnName, @CreatedByColumnName, @ModifiedByColumnName, @RowVersionColumnName)
        AND ty.name NOT IN ('text', 'ntext', 'image', 'geography', 'xml', 'binary', 'varbinary', 'timestamp', 'rowversion')
        AND (@PKColumnNameList not like '%[[]' + c.name + ']%') 
        AND (@ColumnNames = '<All>' or @ColumnNames like '%[[]' + c.name + ']%') 
	  order by c.column_id

SELECT @SQL = @SQL +
+ '		,''' + ISNULL(@RowHistoryViewScope ,'Active') + ''' AS ViewScope' + Char(13) + Char(10)
+ '		,RowHistorySource' + Char(13) + Char(10)
+ '		,[SysUser] ' + Char(13) + Char(10)
+ '		,[Application] ' + Char(13) + Char(10)
+ '		,[SQLStatement] ' + Char(13) + Char(10)
+ 'FROM 	(SELECT		AH.AuditHeaderID '  + Char(13) + Char(10)
+ '					,AH.PrimaryKey '  + Char(13) + Char(10)
+ '					,AH.PrimaryKey2 '  + Char(13) + Char(10)
+ '					,AH.PrimaryKey3 '  + Char(13) + Char(10)
+ '					,AH.PrimaryKey4 '  + Char(13) + Char(10)
+ '					,AH.PrimaryKey5 '  + Char(13) + Char(10)
+ '					,AH.AuditDate '  + Char(13) + Char(10)
+ '					,AH.Operation '  + Char(13) + Char(10)
+ '					,AH.[RowVersion] AS HRowVersion '  + Char(13) + Char(10)
+ '					,SUBSTRING(AD.ColumnName,2,LEN(AD.ColumnName)-2) AS ColumnName '  + Char(13) + Char(10)
+ '					,ISNULL(AD.NewValue,AD.OldValue) AS NewValue' + Char(13) + Char(10)
+ '					,' + CASE ISNULL(@RowHistoryViewScope ,'Active') 
							WHEN 'All' THEN 'AH.[Source]'
							ELSE '''' + ISNULL(@RowHistoryViewScope ,'Active') + ''''
						END + ' AS RowHistorySource' + Char(13) + Char(10)
+ '					,AH.[SysUser] '  + Char(13) + Char(10)
+ '					,AH.[Application] '  + Char(13) + Char(10)
+ '					,AH.[SQLStatement] '  + Char(13) + Char(10)
+ '		FROM		' + quotename(@AuditSchema) + '.' + 
			CASE ISNULL(@RowHistoryViewScope ,'Active') 
				WHEN 'All' THEN '[vAuditHeaderAll]'
				WHEN 'Active' THEN '[AuditHeader]'
				WHEN 'Archive' THEN '[AuditHeaderArchive]'
				ELSE '[AuditHeader]'
			END
+ ' AS AH'  + Char(13) + Char(10)
+ '		LEFT JOIN	' + quotename(@AuditSchema) + '.' +
			CASE @RowHistoryViewScope 
				WHEN 'All' THEN '[vAuditDetailAll]'
				WHEN 'Active' THEN '[AuditDetail]'
				WHEN 'Archive' THEN '[AuditDetailArchive]'
				ELSE '[AuditDetail]'
			END
+ ' AS AD'  + Char(13) + Char(10)
+ '			ON		AH.AuditHeaderID = AD.AuditHeaderID'  + Char(13) + Char(10)
+ '		WHERE		AH.TableName=''' + QUOTENAME(@SchemaName) + '.' + QUOTENAME(@TableName) + ''''  + Char(13) + Char(10)--no quotename here
+ '					) AS AD'  + Char(13) + Char(10)
+ '		PIVOT		(MAX (NewValue)'  + Char(13) + Char(10)
+ '			FOR		ColumnName IN'  + Char(13) + Char(10)
+ '					('  + Char(13) + Char(10)
--for each column
SELECT @SQL = @SQL +
		'					' + case when c.column_id > 1 then ',' else '' end + '[' + c.name + ']'  + Char(13) + Char(10)
	  from sys.tables as t
		join sys.columns as c
		  on t.object_id = c.object_id
		join sys.schemas as s
		  on s.schema_id = t.schema_id
		join sys.types as ty
		  on ty.user_type_id = c.user_type_id
      where t.name = @TableName AND s.name = @SchemaName 
         AND c.is_computed = 0
         AND c.name NOT IN (@CreatedColumnName, @ModifiedColumnName, @CreatedByColumnName, @ModifiedByColumnName, @RowVersionColumnName)
         AND ty.name NOT IN ('text', 'ntext', 'image', 'geography', 'xml', 'binary', 'varbinary', 'timestamp', 'rowversion')
         AND (@ColumnNames = '<All>' or @PKColumnNameList + @ColumnNames like '%[[]' + c.name + ']%') 
	  order by c.column_id

SELECT @SQL = @SQL +
'					)'  + Char(13) + Char(10)
+ '					) AS PivotData'  + Char(13) + Char(10)

IF @CreateRowHistoryView = 1
	EXEC (@SQL)

--------------------------------------------------------------------------------------------
-- build _RowHistory Table-Valued UDF

SET @SQL = 'CREATE FUNCTION ' + quotename(@ViewSchema) + '.' + quotename(@UDFPrefix + @TableName + @RowHistoryFunctionSuffix) + Char(13) + Char(10) + '			(' + Char(13) + Char(10)
SET @SQL = @SQL + '			' + substring('@PK varchar(36),@PK2 varchar(36),@PK3 varchar(36),@PK4 varchar(36),@PK5 varchar(36)',1,15 + (@PKColumnQty - 1) * 17) + Char(13) + Char(10)
SET @SQL = @SQL + '			)' + Char(13) + Char(10) + Char(13) + Char(10) 
       + ' -- generated by AutoAudit Version ' + @Version + ' on ' + Convert(VARCHAR(30), GetDate(),100)  + Char(13) + Char(10)
       + ' -- created by Paul Nielsen and John Sigouin ' + Char(13) + Char(10)
       + ' -- www.SQLServerBible.com ' + Char(13) + Char(10)
       + ' -- AutoAudit.codeplex.com ' + Char(13) + Char(10)
       + ' -- This function retrieves data from the RowHistory view for the referenced table for the record identified by the PK parameters.' + Char(13) + Char(10) + Char(13) + Char(10)


IF not (@LogInsert = 2 and @LogUpdate = 2 and @LogDelete = 2)

 SET @SQL = @SQL 
       + 'RETURNS TABLE ' + Char(13) + Char(10) + Char(13) + Char(10) 
       + 'RETURN ' + Char(13) + Char(10)
       + '( ' + Char(13) + Char(10)
       + '-- Retrieve the basic logged data through the _RowHistory view' + Char(13) + Char(10)
       + '-- Detailed data retrieval is not possible because full logging has not been configured for this table.' + Char(13) + Char(10)
       + 'SELECT		*' + Char(13) + Char(10) 
       + 'FROM		' + quotename(@ViewSchema) + '.' + quotename(@ViewPrefix + @TableName + @RowHistoryViewSuffix) + Char(13) + Char(10) 
       + @RowHistoryUDFFilter  + Char(13) + Char(10) 
       + ') ' + Char(13) + Char(10)

Else
	Begin
 SET @SQL = @SQL 
       + 'RETURNS @HistoryData Table' + Char(13) + Char(10)
       + '(' + Char(13) + Char(10) 
       + 'AuditDate datetime' + Char(13) + Char(10)
       + ',Operation varchar(1)' + Char(13) + Char(10)
       + ',[RowVersion] int' + Char(13) + Char(10)



 --add dynamic columns to table variable definition
Select	@SQL = @SQL
		+ ',' + quotename(c.name) + ty.name + 
		case	when  ty.name in ('nchar','nvarchar','char','varchar') then ' (' + isnull(nullif(cast(c.max_length as varchar(10)),'-1'),'max') + ')'
				when  ty.name in ('numeric','decimal') then ' (' + cast(c.precision as varchar(10)) + ',' + + cast(c.scale as varchar(10)) + ')'
				else ''
				end + Char(13) + Char(10)
from	sys.tables as t
join	sys.columns as c
  on	t.object_id = c.object_id
join	sys.schemas as s
  on	s.schema_id = t.schema_id
join	sys.types as ty
  on	ty.user_type_id = c.user_type_id
where	t.name = @TableName AND s.name = @SchemaName 
	AND c.is_computed = 0
	AND c.name NOT IN (@CreatedColumnName, @ModifiedColumnName, @CreatedByColumnName, @ModifiedByColumnName, @RowVersionColumnName)
	AND ty.name NOT IN ('text', 'ntext', 'image', 'geography', 'xml', 'binary', 'varbinary', 'timestamp', 'rowversion')
	AND (@ColumnNames = '<All>' or @PKColumnNameList + @ColumnNames like '%[[]' + c.name + ']%') 
order by c.column_id

SET @SQL = @SQL 
 
       + ',ViewScope varchar(10)' + Char(13) + Char(10)
       + ',RowHistorySource varchar(10)' + Char(13) + Char(10)
       + ',SysUser sysname' + Char(13) + Char(10)
       + ',[Application] varchar(128)' + Char(13) + Char(10)
       + ',SQLStatement varchar(max)' + Char(13) + Char(10)
       + ') ' + Char(13) + Char(10)
       + 'AS ' + Char(13) + Char(10)
       + 'BEGIN ' + Char(13) + Char(10) + Char(13) + Char(10)
       + '-- Detailed data retrieval is enabled for this table.' + Char(13) + Char(10)
       + 'With	AuditDataExtract --Source data query' + Char(13) + Char(10)
       + '	AS' + Char(13) + Char(10)
       + '	(' + Char(13) + Char(10)
       + '	SELECT		*' + Char(13) + Char(10)
       + '	FROM		' + quotename(@ViewSchema) + '.' + quotename(@ViewPrefix + @TableName + @RowHistoryViewSuffix) + Char(13) + Char(10) 
       + '	' + @RowHistoryUDFFilter  + Char(13) + Char(10) 
       + '	),' + Char(13) + Char(10)
       + '	CurrentRowExtract ' + Char(13) + Char(10)
       + '	AS' + Char(13) + Char(10)
       + '	(' + Char(13) + Char(10)
       + '	Select	getdate() as AuditDate' + Char(13) + Char(10)
       + '			,''c'' as Operation' + Char(13) + Char(10)
       + '			,(Select isnull(max([RowVersion]),0) + 1 from AuditDataExtract) as [RowVersion]' + Char(13) + Char(10)


	--add the pk column references
	SELECT @SQL = @SQL + '			,' + quotename(c.name) + Char(13) + Char(10)
	  from   sys.tables as t
		join sys.columns as c
		  on t.object_id = c.object_id
		join sys.schemas as s
		  on s.schema_id = t.schema_id
		join sys.types as ty
		  on ty.user_type_id = c.user_type_id
      where t.name = @TableName AND s.name = @SchemaName 
         AND c.is_computed = 0
         AND c.name NOT IN (@CreatedColumnName, @ModifiedColumnName, @CreatedByColumnName, @ModifiedByColumnName, @RowVersionColumnName)
         AND ty.name NOT IN ('text', 'ntext', 'image', 'geography', 'xml', 'binary', 'varbinary', 'timestamp', 'rowversion')
         AND (@PKColumnNameList like '%[[]' + c.name + ']%') 
	  order by c.column_id

--for each column
SELECT @SQL = @SQL +
		'			,cast([' + c.name + '] as varchar(50)) as [' + c.name + ']'  + Char(13) + Char(10)
	  from sys.tables as t
		join sys.columns as c
		  on t.object_id = c.object_id
		join sys.schemas as s
		  on s.schema_id = t.schema_id
		join sys.types as ty
		  on ty.user_type_id = c.user_type_id
      where t.name = @TableName AND s.name = @SchemaName 
         AND c.is_computed = 0
         AND c.name NOT IN (@CreatedColumnName, @ModifiedColumnName, @CreatedByColumnName, @ModifiedByColumnName, @RowVersionColumnName)
         AND ty.name NOT IN ('text', 'ntext', 'image', 'geography', 'xml', 'binary', 'varbinary', 'timestamp', 'rowversion')
         AND (@PKColumnNameList not like '%[[]' + c.name + ']%') 
         AND (@ColumnNames = '<All>' or @ColumnNames like '%[[]' + c.name + ']%') 
	  order by c.column_id


SELECT @SQL = @SQL +
         '			,null as ViewScope' + Char(13) + Char(10)
       + '			,null as RowHistorySource' + Char(13) + Char(10)
       + '			,null as SysUser' + Char(13) + Char(10)
       + '			,null as [Application]' + Char(13) + Char(10)
       + '			,null as SQLStatement' + Char(13) + Char(10)
       + '			from	[' + @SchemaName + '].[' + @TableName + ']' + Char(13) + Char(10)
       + '	' + @RowHistoryUDFFilter  + Char(13) + Char(10) 
       + '			),' + Char(13) + Char(10)
       + '			RowHistoryExtract' + Char(13) + Char(10)
       + '			AS' + Char(13) + Char(10)
       + '			(' + Char(13) + Char(10)
       + '			Select * from AuditDataExtract' + Char(13) + Char(10)
       + '			Union All' + Char(13) + Char(10)
       + '			Select * from CurrentRowExtract' + Char(13) + Char(10)
       + '			),' + Char(13) + Char(10)
       + '			RowHistory' + Char(13) + Char(10)
       + '			AS' + Char(13) + Char(10)
       + '			(' + Char(13) + Char(10)
       + '			--Anchor query for RowHistory buildup. Get the most current rowversion' + Char(13) + Char(10)
       + '			Select		top 1 *' + Char(13) + Char(10)
       + '			From		RowHistoryExtract' + Char(13) + Char(10)
       + '			order by	[RowVersion] desc' + Char(13) + Char(10) + Char(13) + Char(10)
       + '			UNION All' + Char(13) + Char(10)
       + '			--Recursive query for RowHistory buildup' + Char(13) + Char(10)
       + '			Select		NextVersion.AuditDate' + Char(13) + Char(10)
       + '						,NextVersion.Operation' + Char(13) + Char(10)
       + '						,NextVersion.[RowVersion]' + Char(13) + Char(10)

	--for each PK column
	SELECT @SQL = @SQL +
		'						,isnull(NextVersion.[' + c.name + '] , PreviousVersion.[' + c.name + '])' + Char(13) + Char(10)
	  from sys.tables as t
		join sys.columns as c
		  on t.object_id = c.object_id
		join sys.schemas as s
		  on s.schema_id = t.schema_id
		join sys.types as ty
		  on ty.user_type_id = c.user_type_id
      where t.name = @TableName AND s.name = @SchemaName 
         AND c.is_computed = 0
         AND c.name NOT IN (@CreatedColumnName, @ModifiedColumnName, @CreatedByColumnName, @ModifiedByColumnName, @RowVersionColumnName)
         AND ty.name NOT IN ('text', 'ntext', 'image', 'geography', 'xml', 'binary', 'varbinary', 'timestamp', 'rowversion')
         AND (@PKColumnNameList like '%[[]' + c.name + ']%') 
	  order by c.column_id

	--for each non-PKcolumn
	SELECT @SQL = @SQL +
		'						,isnull(NextVersion.[' + c.name + '] , PreviousVersion.[' + c.name + '])' + Char(13) + Char(10)
	  from sys.tables as t
		join sys.columns as c
		  on t.object_id = c.object_id
		join sys.schemas as s
		  on s.schema_id = t.schema_id
		join sys.types as ty
		  on ty.user_type_id = c.user_type_id
      where t.name = @TableName AND s.name = @SchemaName 
         AND c.is_computed = 0
         AND c.name NOT IN (@CreatedColumnName, @ModifiedColumnName, @CreatedByColumnName, @ModifiedByColumnName, @RowVersionColumnName)
         AND ty.name NOT IN ('text', 'ntext', 'image', 'geography', 'xml', 'binary', 'varbinary', 'timestamp', 'rowversion')
         AND (@PKColumnNameList not like '%[[]' + c.name + ']%') 
         AND (@ColumnNames = '<All>' or @ColumnNames like '%[[]' + c.name + ']%') 
	  order by c.column_id


 	SELECT @SQL = @SQL +
       + '						,NextVersion.ViewScope' + Char(13) + Char(10)
       + '						,NextVersion.RowHistorySource' + Char(13) + Char(10)
       + '						,NextVersion.SysUser' + Char(13) + Char(10)
       + '						,NextVersion.[Application]' + Char(13) + Char(10)
       + '						,NextVersion.SQLStatement' + Char(13) + Char(10)
       + '			from		RowHistoryExtract as NextVersion' + Char(13) + Char(10)
       + '			Inner join	RowHistory as PreviousVersion' + Char(13) + Char(10)
       + '				on		PreviousVersion.[RowVersion] = NextVersion.[RowVersion] + 1' + Char(13) + Char(10)


	--for each PK column
	SELECT @SQL = @SQL +
		'				and		PreviousVersion.' + '[' + c.name + '] = NextVersion.' + '[' + c.name + ']' + Char(13) + Char(10)
	  from sys.tables as t
		join sys.columns as c
		  on t.object_id = c.object_id
		join sys.schemas as s
		  on s.schema_id = t.schema_id
		join sys.types as ty
		  on ty.user_type_id = c.user_type_id
      where t.name = @TableName AND s.name = @SchemaName 
         AND c.is_computed = 0
         AND c.name NOT IN (@CreatedColumnName, @ModifiedColumnName, @CreatedByColumnName, @ModifiedByColumnName, @RowVersionColumnName)
         AND ty.name NOT IN ('text', 'ntext', 'image', 'geography', 'xml', 'binary', 'varbinary', 'timestamp', 'rowversion')
         AND (@PKColumnNameList like '%[[]' + c.name + ']%') 
	  order by c.column_id


  	SELECT @SQL = @SQL +
       + '			)' + Char(13) + Char(10)
       + '-- Statement that executes the CTE' + Char(13) + Char(10)
       + 'Insert into @HistoryData' + Char(13) + Char(10)
       + '	--Returns the function table' + Char(13) + Char(10)
       + '	Select	AuditDate' + Char(13) + Char(10)
       + '			,Operation' + Char(13) + Char(10)
       + '			,[RowVersion]' + Char(13) + Char(10)

		--add the pk column references
		;With PKs
			as
			(
			Select quotename(c.name) as PKName, c.column_id, row_number() over (order by c.column_id) PKOrder
			from	sys.tables as t
			join	sys.columns as c
			  on	t.object_id = c.object_id
			join	sys.schemas as s
			  on	s.schema_id = t.schema_id
			join	sys.types as ty
			  on	ty.user_type_id = c.user_type_id
			where	t.name = @TableName AND s.name = @SchemaName 
			 AND	c.is_computed = 0
			 AND	c.name NOT IN (@CreatedColumnName, @ModifiedColumnName, @CreatedByColumnName, @ModifiedByColumnName, @RowVersionColumnName)
			 AND	ty.name NOT IN ('text', 'ntext', 'image', 'geography', 'xml', 'binary', 'varbinary', 'timestamp', 'rowversion')
			 AND	(@PKColumnNameList like '%[[]' + c.name + ']%') 
			), PKCols
			as
			(
			SELECT '			,' + PKName as PKCol, column_id
			from	PKs
			
			),DataCols
			as
			(
			--for each column
			SELECT 
				'			, nullif(' + quotename(c.name) + ',''<-null->'')' as DataCol, c.column_id
			from	sys.tables as t
			join	sys.columns as c
			  on	t.object_id = c.object_id
			join	sys.schemas as s
			  on	s.schema_id = t.schema_id
			join	sys.types as ty
			  on	ty.user_type_id = c.user_type_id
			where	t.name = @TableName AND s.name = @SchemaName 
			 AND	c.is_computed = 0
			 AND	c.name NOT IN (@CreatedColumnName, @ModifiedColumnName, @CreatedByColumnName, @ModifiedByColumnName, @RowVersionColumnName)
			 AND	ty.name NOT IN ('text', 'ntext', 'image', 'geography', 'xml', 'binary', 'varbinary', 'timestamp', 'rowversion')
			 AND	(@PKColumnNameList not like '%[[]' + c.name + ']%') 
			 AND	(@ColumnNames = '<All>' or @ColumnNames like '%[[]' + c.name + ']%') 
				 ),MergeCols
				 as
				 (
				 Select PKCol as ColStatement, column_id as ColOrder from PKCols
				 union all
				 Select DataCol, column_id from DataCols
				 )
			SELECT	@SQL = @SQL + ColStatement + Char(13) + Char(10) 
			FROM	MergeCols
			order by ColOrder


		SELECT @SQL = @SQL +
				 '			,ViewScope' + Char(13) + Char(10)
			   + '			,RowHistorySource' + Char(13) + Char(10)
			   + '			,SysUser' + Char(13) + Char(10)
			   + '			,[Application]' + Char(13) + Char(10)
			   + '			,SQLStatement' + Char(13) + Char(10)
       + 'FROM		RowHistory' + Char(13) + Char(10)
       + 'where		Operation <> ''c''' + Char(13) + Char(10)
       + 'order by	[RowVersion],AuditDate' + Char(13) + Char(10)
       + 'option		(MAXRECURSION 10000)' + Char(13) + Char(10) + Char(13) + Char(10)
       + 'Return ' + Char(13) + Char(10)
       + 'END ' + Char(13) + Char(10)
	End
	

IF @CreateRowHistoryFunction = 1
	IF @CreateRowHistoryView = 1
		BEGIN
			print '	Creating _RowHistory UDF'
			--select (@SQL)
			EXEC (@SQL)
		END
	ELSE
		RAISERROR ('The _RowHistory view must exist to create the _RowHistory function.',16,0)

--------------------------------------------------------------------------------------------
-- build _TableRecovery Table-Valued UDF

SET @SQL = 'CREATE FUNCTION ' + quotename(@ViewSchema) + '.' + quotename(@UDFPrefix + @TableName + @TableRecoveryFunctionSuffix) + Char(13) + Char(10) + '			(' + Char(13) + Char(10)
SET @SQL = @SQL + '			@RecoveryTime datetime' + Char(13) + Char(10)
SET @SQL = @SQL + '			)' + Char(13) + Char(10) + Char(13) + Char(10) 
       + ' -- NEW generated by AutoAudit Version ' + @Version + ' on ' + Convert(VARCHAR(30), GetDate(),100)  + Char(13) + Char(10)
       + ' -- created by Paul Nielsen and John Sigouin ' + Char(13) + Char(10)
       + ' -- www.SQLServerBible.com ' + Char(13) + Char(10)
       + ' -- AutoAudit.codeplex.com ' + Char(13) + Char(10)
       + ' -- This function retrieves an image of the table as it existed at the specified point in time.' + Char(13) + Char(10) + Char(13) + Char(10)

IF not (@LogInsert = 2 and @LogUpdate = 2 and @LogDelete = 2)

 SET @SQL = @SQL 
       + 'RETURNS TABLE ' + Char(13) + Char(10) + Char(13) + Char(10) 
       + 'RETURN ' + Char(13) + Char(10)
       + '( ' + Char(13) + Char(10)
       + '-- Retrieve the basic logged data through the _RowHistory view' + Char(13) + Char(10)
       + '-- Detailed data retrieval is not possible because full logging has not been configured for this table.' + Char(13) + Char(10)
       + 'SELECT		*' + Char(13) + Char(10) 
       + 'FROM		' + quotename(@ViewSchema) + '.' + quotename(@ViewPrefix + @TableName + @RowHistoryViewSuffix) + Char(13) + Char(10) 
       + @RowHistoryUDFFilter  + Char(13) + Char(10) 
       + ') ' + Char(13) + Char(10)

Else
	Begin
	
 --build list of columns
 Set @SQLColumns = ''
 --add dynamic columns to table variable definition
Select	@SQLColumns = @SQLColumns 
		+ ',' + quotename(c.name) + ty.name + 
		case	when  ty.name in ('nchar','nvarchar','char','varchar') then ' (' + isnull(nullif(cast(c.max_length as varchar(10)),'-1'),'max') + ')'
				when  ty.name in ('numeric','decimal') then ' (' + cast(c.precision as varchar(10)) + ',' + + cast(c.scale as varchar(10)) + ')'
				else ''
				end + Char(13) + Char(10)
from	sys.tables as t
join	sys.columns as c
  on	t.object_id = c.object_id
join	sys.schemas as s
  on	s.schema_id = t.schema_id
join	sys.types as ty
  on	ty.user_type_id = c.user_type_id
where	t.name = @TableName AND s.name = @SchemaName 
	AND c.is_computed = 0
	AND c.name NOT IN (@CreatedColumnName, @ModifiedColumnName, @CreatedByColumnName, @ModifiedByColumnName, @RowVersionColumnName)
	AND ty.name NOT IN ('text', 'ntext', 'image', 'geography', 'xml', 'binary', 'varbinary', 'timestamp', 'rowversion')
	AND (@ColumnNames = '<All>' or @PKColumnNameList + @ColumnNames like '%[[]' + c.name + ']%') 
order by c.column_id
Select	@SQLColumns = SUBSTRING(@SQLColumns,2,len(@SQLColumns))

 SET @SQL = @SQL 
       + 'RETURNS @HistoryData Table' + Char(13) + Char(10)
       + '(' + Char(13) + Char(10) 

--add dynamic columns to table variable definition
Select	@SQL = @SQL + @SQLColumns

SET @SQL = @SQL 
       + ') ' + Char(13) + Char(10)
       + 'AS ' + Char(13) + Char(10)
       + 'BEGIN ' + Char(13) + Char(10) + Char(13) + Char(10)
       
 SET @SQL = @SQL 
       + '-- Create table variable to hold history records.' + Char(13) + Char(10)
       + 'Declare @AuditDataExtract table' + Char(13) + Char(10)
       + '	(' + Char(13) + Char(10) 
       + '	AuditDate datetime' + Char(13) + Char(10)
       + '	,Operation varchar(1)' + Char(13) + Char(10)
       + '	,[RowVersion] int' + Char(13) + Char(10)

--add PK columns to table variable definition
Select	@SQL = @SQL + 
		'	,[' + c.name + '] varchar(50)' + Char(13) + Char(10)
from	sys.tables as t
join	sys.columns as c
  on	t.object_id = c.object_id
join	sys.schemas as s
  on	s.schema_id = t.schema_id
join	sys.types as ty
  on	ty.user_type_id = c.user_type_id
where	t.name = @TableName AND s.name = @SchemaName 
	AND c.is_computed = 0
	AND c.name NOT IN (@CreatedColumnName, @ModifiedColumnName, @CreatedByColumnName, @ModifiedByColumnName, @RowVersionColumnName)
	AND ty.name NOT IN ('text', 'ntext', 'image', 'geography', 'xml', 'binary', 'varbinary', 'timestamp', 'rowversion')
	AND (@PKColumnNameList like '%[[]' + c.name + ']%') 
order by c.column_id

--add non-PK columns to table variable definition
Select	@SQL = @SQL + 
		'	,[' + c.name + '] varchar(50)' + Char(13) + Char(10)
from	sys.tables as t
join	sys.columns as c
  on	t.object_id = c.object_id
join	sys.schemas as s
  on	s.schema_id = t.schema_id
join	sys.types as ty
  on	ty.user_type_id = c.user_type_id
where	t.name = @TableName AND s.name = @SchemaName 
	AND c.is_computed = 0
	AND c.name NOT IN (@CreatedColumnName, @ModifiedColumnName, @CreatedByColumnName, @ModifiedByColumnName, @RowVersionColumnName)
	AND ty.name NOT IN ('text', 'ntext', 'image', 'geography', 'xml', 'binary', 'varbinary', 'timestamp', 'rowversion')
	AND (@PKColumnNameList not like '%[[]' + c.name + ']%') 
	AND (@ColumnNames = '<All>' or @ColumnNames like '%[[]' + c.name + ']%') 
order by c.column_id

 
SET @SQL = @SQL 
       + '	) ' + Char(13) + Char(10) + Char(13) + Char(10)
       
       + '-- Detailed data retrieval is enabled for this table.' + Char(13) + Char(10)
       + '--write the full history for the table into a temp table variable for performance.' + Char(13) + Char(10)
       + 'Insert @AuditDataExtract ' + Char(13) + Char(10)
       + 'Select ' + Char(13) + Char(10)
       + '			AuditDate' + Char(13) + Char(10)
       + '			,Operation' + Char(13) + Char(10)
       + '			,[RowVersion]' + Char(13) + Char(10)

--add PK columns to table variable definition
Select	@SQL = @SQL +
		'			,' + quotename(c.name) + Char(13) + Char(10)
from	sys.tables as t
join	sys.columns as c
  on	t.object_id = c.object_id
join	sys.schemas as s
  on	s.schema_id = t.schema_id
join	sys.types as ty
  on	ty.user_type_id = c.user_type_id
where	t.name = @TableName AND s.name = @SchemaName 
	AND c.is_computed = 0
	AND c.name NOT IN (@CreatedColumnName, @ModifiedColumnName, @CreatedByColumnName, @ModifiedByColumnName, @RowVersionColumnName)
	AND ty.name NOT IN ('text', 'ntext', 'image', 'geography', 'xml', 'binary', 'varbinary', 'timestamp', 'rowversion')
	AND (@PKColumnNameList like '%[[]' + c.name + ']%') 
	--AND (@ColumnNames = '<All>' or @PKColumnNameList + @ColumnNames like '%[[]' + c.name + ']%') 
order by c.column_id

--add non-PK columns to table variable definition
Select	@SQL = @SQL +
		'			,' + quotename(c.name) + Char(13) + Char(10)
from	sys.tables as t
join	sys.columns as c
  on	t.object_id = c.object_id
join	sys.schemas as s
  on	s.schema_id = t.schema_id
join	sys.types as ty
  on	ty.user_type_id = c.user_type_id
where	t.name = @TableName AND s.name = @SchemaName 
	AND c.is_computed = 0
	AND c.name NOT IN (@CreatedColumnName, @ModifiedColumnName, @CreatedByColumnName, @ModifiedByColumnName, @RowVersionColumnName)
	AND ty.name NOT IN ('text', 'ntext', 'image', 'geography', 'xml', 'binary', 'varbinary', 'timestamp', 'rowversion')
	AND (@PKColumnNameList not like '%[[]' + c.name + ']%') 
	AND (@ColumnNames = '<All>' or @ColumnNames like '%[[]' + c.name + ']%') 
order by c.column_id

 SET @SQL = @SQL 
       + 'FROM		' + quotename(@ViewSchema) + '.' + quotename(@ViewPrefix + @TableName + @RowHistoryViewSuffix) + Char(13) + Char(10)  + Char(13) + Char(10) 
       + '-- Detailed data retrieval is enabled for this table.' + Char(13) + Char(10)
       + ';With	AuditDataExtract --Source data query' + Char(13) + Char(10)
       + '	AS' + Char(13) + Char(10)
       + '	(' + Char(13) + Char(10)
       + '	SELECT		*' + Char(13) + Char(10)
       + '	FROM		@AuditDataExtract' + Char(13) + Char(10) 
       + '	),' + Char(13) + Char(10)

--Add CurrentRowExtract CTE segment
       + '	CurrentRowExtract ' + Char(13) + Char(10)
       + '	AS' + Char(13) + Char(10)
       + '	(' + Char(13) + Char(10)
       + '	Select		getdate() as AuditDate' + Char(13) + Char(10)
       + '				,''c'' as Operation' + Char(13) + Char(10)
       + '				,(Select isnull(max([RowVersion]),0) + 1 from AuditDataExtract ' + Char(13) + Char(10)
       + '				Where	1=1 ' + Char(13) + Char(10)
	
	--for each PK column
	SELECT @SQL = @SQL + '					and	AuditDataExtract.' + quotename(c.name) + ' = ' 
					+ '[' + @SchemaName + '].[' + @TableName + '].' + quotename(c.name) + Char(13) + Char(10)
	  from   sys.tables as t
		join sys.columns as c
		  on t.object_id = c.object_id
		join sys.schemas as s
		  on s.schema_id = t.schema_id
		join sys.types as ty
		  on ty.user_type_id = c.user_type_id
      where t.name = @TableName AND s.name = @SchemaName 
         AND c.is_computed = 0
         AND c.name NOT IN (@CreatedColumnName, @ModifiedColumnName, @CreatedByColumnName, @ModifiedByColumnName, @RowVersionColumnName)
         AND ty.name NOT IN ('text', 'ntext', 'image', 'geography', 'xml', 'binary', 'varbinary', 'timestamp', 'rowversion')
         AND (@PKColumnNameList like '%[[]' + c.name + ']%') 
	  order by c.column_id
	
	 SET @SQL = @SQL 
	   + '				) as [RowVersion]' + Char(13) + Char(10)
	
	--add the pk column references
	SELECT @SQL = @SQL + '				,' + quotename(c.name) + Char(13) + Char(10)
	  from   sys.tables as t
		join sys.columns as c
		  on t.object_id = c.object_id
		join sys.schemas as s
		  on s.schema_id = t.schema_id
		join sys.types as ty
		  on ty.user_type_id = c.user_type_id
      where t.name = @TableName AND s.name = @SchemaName 
         AND c.is_computed = 0
         AND c.name NOT IN (@CreatedColumnName, @ModifiedColumnName, @CreatedByColumnName, @ModifiedByColumnName, @RowVersionColumnName)
         AND ty.name NOT IN ('text', 'ntext', 'image', 'geography', 'xml', 'binary', 'varbinary', 'timestamp', 'rowversion')
         AND (@PKColumnNameList like '%[[]' + c.name + ']%') 
	  order by c.column_id

--for each column
SELECT @SQL = @SQL +
		'				,cast([' + c.name + '] as varchar(50)) as [' + c.name + ']'  + Char(13) + Char(10)
	  from sys.tables as t
		join sys.columns as c
		  on t.object_id = c.object_id
		join sys.schemas as s
		  on s.schema_id = t.schema_id
		join sys.types as ty
		  on ty.user_type_id = c.user_type_id
      where t.name = @TableName AND s.name = @SchemaName 
         AND c.is_computed = 0
         AND c.name NOT IN (@CreatedColumnName, @ModifiedColumnName, @CreatedByColumnName, @ModifiedByColumnName, @RowVersionColumnName)
         AND ty.name NOT IN ('text', 'ntext', 'image', 'geography', 'xml', 'binary', 'varbinary', 'timestamp', 'rowversion')
         AND (@PKColumnNameList not like '%[[]' + c.name + ']%') 
         AND (@ColumnNames = '<All>' or @ColumnNames like '%[[]' + c.name + ']%') 
	  order by c.column_id

SELECT @SQL = @SQL
       + '	from		[' + @SchemaName + '].[' + @TableName + ']' + Char(13) + Char(10)
       --+ '	' + @RowHistoryUDFFilter  + Char(13) + Char(10) 
       + '			),' + Char(13) + Char(10)

--Add RowHistoryExtract CTE segment
       + '			RowHistoryExtract' + Char(13) + Char(10)
       + '			AS' + Char(13) + Char(10)
       + '			(' + Char(13) + Char(10)
       + '			Select * from AuditDataExtract' + Char(13) + Char(10)
       + '			Union All' + Char(13) + Char(10)
       + '			Select * from CurrentRowExtract' + Char(13) + Char(10)
       + '			),' + Char(13) + Char(10)

--Add MostRecentRows CTE segment
       + '			MostRecentRows' + Char(13) + Char(10)
       + '			AS' + Char(13) + Char(10)
       + '			(' + Char(13) + Char(10)
       + '			--Get most recent rows' + Char(13) + Char(10)
       + '			Select ' + Char(13) + Char(10)
       + '						max([RowVersion]) as MostRecentRow' + Char(13) + Char(10)

	--add the pk column references
	SELECT @SQL = @SQL + '						,' + quotename(c.name) + Char(13) + Char(10)
	  from   sys.tables as t
		join sys.columns as c
		  on t.object_id = c.object_id
		join sys.schemas as s
		  on s.schema_id = t.schema_id
		join sys.types as ty
		  on ty.user_type_id = c.user_type_id
      where t.name = @TableName AND s.name = @SchemaName 
         AND c.is_computed = 0
         AND c.name NOT IN (@CreatedColumnName, @ModifiedColumnName, @CreatedByColumnName, @ModifiedByColumnName, @RowVersionColumnName)
         AND ty.name NOT IN ('text', 'ntext', 'image', 'geography', 'xml', 'binary', 'varbinary', 'timestamp', 'rowversion')
         AND (@PKColumnNameList like '%[[]' + c.name + ']%') 
	  order by c.column_id
	
 SET @SQL = @SQL 
       + '			from		RowHistoryExtract' + Char(13) + Char(10)
       + '			Group By	' + Char(13) + Char(10)

	--add the pk column references
	;With PKs
		as
		(
		Select quotename(c.name) as PKName, c.column_id, row_number() over (order by c.column_id) PKOrder
		from   sys.tables as t
		join	sys.columns as c
		  on	t.object_id = c.object_id
		join	sys.schemas as s
		  on	s.schema_id = t.schema_id
		join	sys.types as ty
		  on	ty.user_type_id = c.user_type_id
		where	t.name = @TableName AND s.name = @SchemaName 
		 AND	c.is_computed = 0
		 AND	c.name NOT IN (@CreatedColumnName, @ModifiedColumnName, @CreatedByColumnName, @ModifiedByColumnName, @RowVersionColumnName)
		 AND	ty.name NOT IN ('text', 'ntext', 'image', 'geography', 'xml', 'binary', 'varbinary', 'timestamp', 'rowversion')
		 AND	(@PKColumnNameList like '%[[]' + c.name + ']%') 
		)

	SELECT @SQL = @SQL + '						' + case when PKOrder > 1 then ',' else '' end + PKName + Char(13) + Char(10)
	from	PKs
	order by PKOrder

 SET @SQL = @SQL 
       + '			),' + Char(13) + Char(10)

--Add RowHistory CTE segment
       + '			RowHistory' + Char(13) + Char(10)
       + '			AS' + Char(13) + Char(10)
       + '			(' + Char(13) + Char(10)
       + '			--Anchor query for RowHistory buildup. Get the most current rowversion' + Char(13) + Char(10)
--       + '			Select		RowHistoryExtract.*' + Char(13) + Char(10)
       + '			Select		' + Char(13) + Char(10)


       + '			RowHistoryExtract.AuditDate' + Char(13) + Char(10)
       + '			,RowHistoryExtract.Operation' + Char(13) + Char(10)
       + '			,RowHistoryExtract.[RowVersion]' + Char(13) + Char(10)

--add PK columns to table variable definition
Select	@SQL = @SQL +
		'			,RowHistoryExtract.' + quotename(c.name) + Char(13) + Char(10)
from	sys.tables as t
join	sys.columns as c
  on	t.object_id = c.object_id
join	sys.schemas as s
  on	s.schema_id = t.schema_id
join	sys.types as ty
  on	ty.user_type_id = c.user_type_id
where	t.name = @TableName AND s.name = @SchemaName 
	AND c.is_computed = 0
	AND c.name NOT IN (@CreatedColumnName, @ModifiedColumnName, @CreatedByColumnName, @ModifiedByColumnName, @RowVersionColumnName)
	AND ty.name NOT IN ('text', 'ntext', 'image', 'geography', 'xml', 'binary', 'varbinary', 'timestamp', 'rowversion')
	AND (@PKColumnNameList like '%[[]' + c.name + ']%') 
order by c.column_id

--add non-PK columns to table variable definition
Select	@SQL = @SQL + 
		'			,RowHistoryExtract.' + quotename(c.name) + Char(13) + Char(10)
from	sys.tables as t
join	sys.columns as c
  on	t.object_id = c.object_id
join	sys.schemas as s
  on	s.schema_id = t.schema_id
join	sys.types as ty
  on	ty.user_type_id = c.user_type_id
where	t.name = @TableName AND s.name = @SchemaName 
	AND c.is_computed = 0
	AND c.name NOT IN (@CreatedColumnName, @ModifiedColumnName, @CreatedByColumnName, @ModifiedByColumnName, @RowVersionColumnName)
	AND ty.name NOT IN ('text', 'ntext', 'image', 'geography', 'xml', 'binary', 'varbinary', 'timestamp', 'rowversion')
	AND (@PKColumnNameList not like '%[[]' + c.name + ']%') 
	AND (@ColumnNames = '<All>' or @ColumnNames like '%[[]' + c.name + ']%') 
order by c.column_id




Select	@SQL = @SQL + 
       + '			From		RowHistoryExtract' + Char(13) + Char(10)
       + '			inner join	MostRecentRows' + Char(13) + Char(10) 
       + '				on		RowHistoryExtract.[RowVersion] = MostRecentRows.MostRecentRow' + Char(13) + Char(10)

	--for each PK column
	SELECT @SQL = @SQL +
		'				and		RowHistoryExtract.' + quotename(c.name) + ' = MostRecentRows.' + quotename(c.name) + Char(13) + Char(10)
	  from sys.tables as t
		join sys.columns as c
		  on t.object_id = c.object_id
		join sys.schemas as s
		  on s.schema_id = t.schema_id
		join sys.types as ty
		  on ty.user_type_id = c.user_type_id
      where t.name = @TableName AND s.name = @SchemaName 
         AND c.is_computed = 0
         AND c.name NOT IN (@CreatedColumnName, @ModifiedColumnName, @CreatedByColumnName, @ModifiedByColumnName, @RowVersionColumnName)
         AND ty.name NOT IN ('text', 'ntext', 'image', 'geography', 'xml', 'binary', 'varbinary', 'timestamp', 'rowversion')
         AND (@PKColumnNameList like '%[[]' + c.name + ']%') 
	  order by c.column_id
       
 SET @SQL = @SQL 
       + '			UNION All' + Char(13) + Char(10)
       + '			--Recursive query for RowHistory buildup' + Char(13) + Char(10)
       + '			Select		NextVersion.AuditDate' + Char(13) + Char(10)
       + '						,NextVersion.Operation' + Char(13) + Char(10)
       + '						,NextVersion.[RowVersion]' + Char(13) + Char(10)


	--add the pk column references
	SELECT @SQL = @SQL +
	'						,isnull(NextVersion.' + quotename(c.name) + ' , PreviousVersion.' + quotename(c.name) + ')' + Char(13) + Char(10)
	  from sys.tables as t
		join sys.columns as c
		  on t.object_id = c.object_id
		join sys.schemas as s
		  on s.schema_id = t.schema_id
		join sys.types as ty
		  on ty.user_type_id = c.user_type_id
      where t.name = @TableName AND s.name = @SchemaName 
         AND c.is_computed = 0
         AND c.name NOT IN (@CreatedColumnName, @ModifiedColumnName, @CreatedByColumnName, @ModifiedByColumnName, @RowVersionColumnName)
         AND ty.name NOT IN ('text', 'ntext', 'image', 'geography', 'xml', 'binary', 'varbinary', 'timestamp', 'rowversion')
         AND (@PKColumnNameList like '%[[]' + c.name + ']%') 
	  order by c.column_id

	--for each non-PK column
	SELECT @SQL = @SQL +
		'						,isnull(NextVersion.' + quotename(c.name) + ' , PreviousVersion.' + quotename(c.name) + ')' + Char(13) + Char(10)
	  from sys.tables as t
		join sys.columns as c
		  on t.object_id = c.object_id
		join sys.schemas as s
		  on s.schema_id = t.schema_id
		join sys.types as ty
		  on ty.user_type_id = c.user_type_id
      where t.name = @TableName AND s.name = @SchemaName 
         AND c.is_computed = 0
         AND c.name NOT IN (@CreatedColumnName, @ModifiedColumnName, @CreatedByColumnName, @ModifiedByColumnName, @RowVersionColumnName)
         AND ty.name NOT IN ('text', 'ntext', 'image', 'geography', 'xml', 'binary', 'varbinary', 'timestamp', 'rowversion')
         AND (@PKColumnNameList not like '%[[]' + c.name + ']%') 
         AND (@ColumnNames = '<All>' or @ColumnNames like '%[[]' + c.name + ']%') 
	  order by c.column_id

 	SET @SQL = @SQL
       + '			from		RowHistoryExtract as NextVersion' + Char(13) + Char(10)
       + '			Inner join	RowHistory as PreviousVersion' + Char(13) + Char(10)
       + '				on		PreviousVersion.[RowVersion] = NextVersion.[RowVersion] + 1' + Char(13) + Char(10)

	--for each PK column
	SELECT @SQL = @SQL +
		'				and		PreviousVersion.' + quotename(c.name) + ' = NextVersion.' + quotename(c.name) + Char(13) + Char(10)
	  from sys.tables as t
		join sys.columns as c
		  on t.object_id = c.object_id
		join sys.schemas as s
		  on s.schema_id = t.schema_id
		join sys.types as ty
		  on ty.user_type_id = c.user_type_id
      where t.name = @TableName AND s.name = @SchemaName 
         AND c.is_computed = 0
         AND c.name NOT IN (@CreatedColumnName, @ModifiedColumnName, @CreatedByColumnName, @ModifiedByColumnName, @RowVersionColumnName)
         AND ty.name NOT IN ('text', 'ntext', 'image', 'geography', 'xml', 'binary', 'varbinary', 'timestamp', 'rowversion')
         AND (@PKColumnNameList like '%[[]' + c.name + ']%') 
	  order by c.column_id


  	SELECT @SQL = @SQL +
       + '			),' + Char(13) + Char(10)

--Add RowsOfInterest CTE segment
       + '			RowsOfInterest' + Char(13) + Char(10)
       + '			AS' + Char(13) + Char(10)
       + '			(' + Char(13) + Char(10)
       + '			--Get Rows Of Interest' + Char(13) + Char(10)
       + '			Select		max([RowVersion]) as [RowVersion]' + Char(13) + Char(10)

--add the pk column references
	SELECT @SQL = @SQL + '						,' + quotename(c.name) + Char(13) + Char(10)
	  from sys.tables as t
		join sys.columns as c
		  on t.object_id = c.object_id
		join sys.schemas as s
		  on s.schema_id = t.schema_id
		join sys.types as ty
		  on ty.user_type_id = c.user_type_id
      where t.name = @TableName AND s.name = @SchemaName 
         AND c.is_computed = 0
         AND c.name NOT IN (@CreatedColumnName, @ModifiedColumnName, @CreatedByColumnName, @ModifiedByColumnName, @RowVersionColumnName)
         AND ty.name NOT IN ('text', 'ntext', 'image', 'geography', 'xml', 'binary', 'varbinary', 'timestamp', 'rowversion')
         AND (@PKColumnNameList like '%[[]' + c.name + ']%') 
	  order by c.column_id
	
 SET @SQL = @SQL 
       + '			from		RowHistory' + Char(13) + Char(10)
       + '			Where		[AuditDate] <= @RecoveryTime' + Char(13) + Char(10)
       + '				And		Operation <> ''c''' + Char(13) + Char(10)
       + '			Group By		' + Char(13) + Char(10)

	--add the pk column references
	;With PKs
		as
		(
		Select quotename(c.name) as PKName, c.column_id, row_number() over (order by c.column_id) PKOrder
		from   sys.tables as t
		join	sys.columns as c
		  on	t.object_id = c.object_id
		join	sys.schemas as s
		  on	s.schema_id = t.schema_id
		join	sys.types as ty
		  on	ty.user_type_id = c.user_type_id
		where	t.name = @TableName AND s.name = @SchemaName 
		 AND	c.is_computed = 0
		 AND	c.name NOT IN (@CreatedColumnName, @ModifiedColumnName, @CreatedByColumnName, @ModifiedByColumnName, @RowVersionColumnName)
		 AND	ty.name NOT IN ('text', 'ntext', 'image', 'geography', 'xml', 'binary', 'varbinary', 'timestamp', 'rowversion')
		 AND	(@PKColumnNameList like '%[[]' + c.name + ']%') 
		)

	SELECT @SQL = @SQL + '						' + case when PKOrder > 1 then ',' else '' end + PKName + Char(13) + Char(10)
	from	PKs
	order by PKOrder

 SET @SQL = @SQL 
       + '			)' + Char(13) + Char(10)

--Add Statement that executes the CTE segment
       + '-- Statement that executes the CTE' + Char(13) + Char(10)
       + 'Insert into @HistoryData' + Char(13) + Char(10)
       + '--Returns the function table' + Char(13) + Char(10)
       + 'Select ' + Char(13) + Char(10)	

		--add the pk column references
		;With PKs
			as
			(
			Select quotename(c.name) as PKName, c.column_id, row_number() over (order by c.column_id) PKOrder
			from	sys.tables as t
			join	sys.columns as c
			  on	t.object_id = c.object_id
			join	sys.schemas as s
			  on	s.schema_id = t.schema_id
			join	sys.types as ty
			  on	ty.user_type_id = c.user_type_id
			where	t.name = @TableName AND s.name = @SchemaName 
			 AND	c.is_computed = 0
			 AND	c.name NOT IN (@CreatedColumnName, @ModifiedColumnName, @CreatedByColumnName, @ModifiedByColumnName, @RowVersionColumnName)
			 AND	ty.name NOT IN ('text', 'ntext', 'image', 'geography', 'xml', 'binary', 'varbinary', 'timestamp', 'rowversion')
			 AND	(@PKColumnNameList like '%[[]' + c.name + ']%') 
			), PKCols
			as
			(
			SELECT '			' + case when column_id = 1 then '' else ',' end + 'rh.' + PKName + '' as PKCol, column_id
			from	PKs
			),DataCols
			as
			(
			--for each column
			SELECT 
				'			' + case when c.column_id = 1 then '' else ',' end + 'nullif(rh.' + quotename(c.name) + ',''<-null->'')' as DataCol, c.column_id
			from	sys.tables as t
			join	sys.columns as c
			  on	t.object_id = c.object_id
			join	sys.schemas as s
			  on	s.schema_id = t.schema_id
			join	sys.types as ty
			  on	ty.user_type_id = c.user_type_id
			where	t.name = @TableName AND s.name = @SchemaName 
			 AND	c.is_computed = 0
			 AND	c.name NOT IN (@CreatedColumnName, @ModifiedColumnName, @CreatedByColumnName, @ModifiedByColumnName, @RowVersionColumnName)
			 AND	ty.name NOT IN ('text', 'ntext', 'image', 'geography', 'xml', 'binary', 'varbinary', 'timestamp', 'rowversion')
			 AND	(@PKColumnNameList not like '%[[]' + c.name + ']%') 
			 AND	(@ColumnNames = '<All>' or @ColumnNames like '%[[]' + c.name + ']%') 
				 ),MergeCols
				 as
				 (
				 Select PKCol as ColStatement, column_id as ColOrder from PKCols
				 union all
				 Select DataCol, column_id from DataCols
				 )
			SELECT	@SQL = @SQL + ColStatement + Char(13) + Char(10) 
			FROM	MergeCols
			order by ColOrder

		SET @SQL = @SQL 
       + 'FROM		RowHistory as rh' + Char(13) + Char(10)
       + 'Inner join	RowsOfInterest as roi' + Char(13) + Char(10)
       + '	on		rh.[RowVersion] = roi.[RowVersion]' + Char(13) + Char(10)

	--for each PK column
	SELECT @SQL = @SQL +
		'	and		rh.' + '[' + c.name + '] = roi.' + '[' + c.name + ']' + Char(13) + Char(10)
	  from sys.tables as t
		join sys.columns as c
		  on t.object_id = c.object_id
		join sys.schemas as s
		  on s.schema_id = t.schema_id
		join sys.types as ty
		  on ty.user_type_id = c.user_type_id
      where t.name = @TableName AND s.name = @SchemaName 
         AND c.is_computed = 0
         AND c.name NOT IN (@CreatedColumnName, @ModifiedColumnName, @CreatedByColumnName, @ModifiedByColumnName, @RowVersionColumnName)
         AND ty.name NOT IN ('text', 'ntext', 'image', 'geography', 'xml', 'binary', 'varbinary', 'timestamp', 'rowversion')
         AND (@PKColumnNameList like '%[[]' + c.name + ']%') 
	  order by c.column_id


	SET @SQL = @SQL 
        + 'Where		Operation <> ''d''' + Char(13) + Char(10)
        + 'order by ' + Char(13) + Char(10)


	--for each PK column
	SELECT @SQL = @SQL +
		'			rh.' + '[' + c.name + '],' + Char(13) + Char(10)
	  from sys.tables as t
		join sys.columns as c
		  on t.object_id = c.object_id
		join sys.schemas as s
		  on s.schema_id = t.schema_id
		join sys.types as ty
		  on ty.user_type_id = c.user_type_id
      where t.name = @TableName AND s.name = @SchemaName 
         AND c.is_computed = 0
         AND c.name NOT IN (@CreatedColumnName, @ModifiedColumnName, @CreatedByColumnName, @ModifiedByColumnName, @RowVersionColumnName)
         AND ty.name NOT IN ('text', 'ntext', 'image', 'geography', 'xml', 'binary', 'varbinary', 'timestamp', 'rowversion')
         AND (@PKColumnNameList like '%[[]' + c.name + ']%') 
	  order by c.column_id
       
       
 	SELECT @SQL = @SQL
       + '			rh.[RowVersion],' + Char(13) + Char(10)
       + '			rh.AuditDate' + Char(13) + Char(10)
       + 'option		(MAXRECURSION 10000)' + Char(13) + Char(10) + Char(13) + Char(10)
       + 'Return ' + Char(13) + Char(10)
       + 'END ' + Char(13) + Char(10)
	End
	

IF @CreateRowHistoryFunction = 1
	IF @CreateRowHistoryView = 1
		IF (@LogInsert = 2 and @LogUpdate = 2 and @LogDelete = 2)
			BEGIN
				print '	Creating _TableRecovery UDF'
				--select (@SQL)
				EXEC (@SQL)
			END
		Else
			RAISERROR ('	Error - @LogInsert, @LogUpdate and @LogDelete MUST all = 2 to create _TableRecovery function.',0,0)
	ELSE
		RAISERROR ('	Error - The _RowHistory view must exist to create the _RowHistory function.',0,0)

--save base table AutoAudit settings to AuditBaseTables table
--a merge (upsert) query would be nice here but not compatible with sql 2005
SET @SQL = 'IF EXISTS (Select 1 from ' + quotename(@AuditSchema) + '.[AuditBaseTables] '
	+ 'WHERE	[SchemaName] = ''' + @SchemaName + ''''
	+ '	AND [TableName] = ''' + @TableName + ''')' + Char(13) + Char(10)
	+ 'UPDATE ' + quotename(@AuditSchema) + '.[AuditBaseTables] '
	+ 'SET [StrictUserContext] = ' + CAST(@StrictUserContext AS VARCHAR) + ','
	+ ' [LogSQL] = ' + CAST(@LogSQL AS VARCHAR) + ','
	+ ' [BaseTableDDL] = ' + CAST(@BaseTableDDL AS VARCHAR) + ','
	+ ' [LogInsert] = ' + CAST(@LogInsert AS VARCHAR) + ','
	+ ' [LogUpdate] = ' + CAST(@LogUpdate AS VARCHAR) + ','
	+ ' [LogDelete] = ' + CAST(@LogDelete AS VARCHAR) + ','
	+ ' [ViewSchema] = ''' + @ViewSchema + ''','
	+ ' [ColumnNames] = ''' + @ColumnNames + ''''
	+ ' OUTPUT deleted.ViewSchema into #ViewSchema '
	+ ' WHERE [SchemaName] = ''' + @SchemaName + ''''
	+ ' AND [TableName] = ''' + @TableName + '''' + Char(13) + Char(10)
	+ 'ELSE ' + Char(13) + Char(10)
	+ 'Insert ' + quotename(@AuditSchema) + '.[AuditBaseTables] '
	+ ' ([SchemaName],[TableName],[StrictUserContext],[LogSQL],[BaseTableDDL],[LogInsert],[LogUpdate],[LogDelete],[EnabledFlag],[ViewSchema],[ColumnNames]) '
	+ 'VALUES (''' + @SchemaName + ''','
	+ '''' + @TableName + ''','
	+ CAST(@StrictUserContext AS VARCHAR) + ','
	+ CAST(@LogSQL AS VARCHAR) + ','
	+ CAST(@BaseTableDDL AS VARCHAR) + ','
	+ CAST(@LogInsert AS VARCHAR) + ','
	+ CAST(@LogUpdate AS VARCHAR) + ','
	+ CAST(@LogDelete AS VARCHAR) + ','
	+ ' 1, '
	+ '''' + @ViewSchema + ''','
	+ '''' + @ColumnNames + ''')'
	
EXEC (@SQL)

Set context_info 0x0;

raiserror ('',0,0) with nowait --to flush out the print statements

RETURN -- END OF pAutoAudit SPROC
GO
/****** Object:  Table [dbo].[MBrokenRiceType]    Script Date: 08/10/2016 11:42:06 ******/
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
INSERT [dbo].[MBrokenRiceType] ([BrokenRiceTypeID], [CustID], [BrokenRiceName], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (N'PT2016071941d02916ee4073', N'om', N'Small BR', N'om\test', CAST(0x0000A64800ACFF80 AS DateTime), N'N')
INSERT [dbo].[MBrokenRiceType] ([BrokenRiceTypeID], [CustID], [BrokenRiceName], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (N'PT20160719523ece1e9b7000', N'om', N'Half BR', N'om\test', CAST(0x0000A64800ACF4F4 AS DateTime), N'N')
INSERT [dbo].[MBrokenRiceType] ([BrokenRiceTypeID], [CustID], [BrokenRiceName], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (N'PT20160719985d83a75b7627', N'om', N'Husk', N'om\test', CAST(0x0000A64800ACE93C AS DateTime), N'N')
/****** Object:  Table [dbo].[CustomerInfo]    Script Date: 08/10/2016 11:42:06 ******/
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
	[EmailId] [varchar](100) NULL,
 CONSTRAINT [PK_CustomerInfo] PRIMARY KEY CLUSTERED 
(
	[CustID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[CustomerInfo] ([CustID], [Name], [OrganizationName], [LastModifiedBy], [LastModifiedDate], [ObsInd], [EmailId]) VALUES (N'4ec93247-64ac-4233-bec4-6a48e3f68f6f', N'Shiva 2', N'SRS', N'System', CAST(0x0000A60C00F417E4 AS DateTime), N'N', NULL)
INSERT [dbo].[CustomerInfo] ([CustID], [Name], [OrganizationName], [LastModifiedBy], [LastModifiedDate], [ObsInd], [EmailId]) VALUES (N'b63f2912-9451-4efc-bbba-064f8271a770', N'', N'', N'System', CAST(0x0000A6100002CD30 AS DateTime), N'N', NULL)
INSERT [dbo].[CustomerInfo] ([CustID], [Name], [OrganizationName], [LastModifiedBy], [LastModifiedDate], [ObsInd], [EmailId]) VALUES (N'CI2016051900171471077295893', N'Test', N'Test', N'System', CAST(0x0000A60B0004BCE4 AS DateTime), N'N', NULL)
INSERT [dbo].[CustomerInfo] ([CustID], [Name], [OrganizationName], [LastModifiedBy], [LastModifiedDate], [ObsInd], [EmailId]) VALUES (N'CI2016051900292260106367486', N'ddddddd', N'ddddd', N'System', CAST(0x0000A60B000810D8 AS DateTime), N'N', NULL)
INSERT [dbo].[CustomerInfo] ([CustID], [Name], [OrganizationName], [LastModifiedBy], [LastModifiedDate], [ObsInd], [EmailId]) VALUES (N'f2a95599-6ea7-4642-9c94-0bbd870fa7dc', N'Shiva', N'SRS', N'System', CAST(0x0000A60C00F09F9C AS DateTime), N'N', NULL)
INSERT [dbo].[CustomerInfo] ([CustID], [Name], [OrganizationName], [LastModifiedBy], [LastModifiedDate], [ObsInd], [EmailId]) VALUES (N'NandhiMill', N'NandhiMill', N'NamdhiMill', N'System', CAST(0x0000A61600B9F9C4 AS DateTime), N'N', NULL)
INSERT [dbo].[CustomerInfo] ([CustID], [Name], [OrganizationName], [LastModifiedBy], [LastModifiedDate], [ObsInd], [EmailId]) VALUES (N'Om', N'Om', N'OM Rice Mills Assocaition of India', N'System', CAST(0x0000A616016696D4 AS DateTime), N'N', N'nagavardhan.kj@gmail.com')
INSERT [dbo].[CustomerInfo] ([CustID], [Name], [OrganizationName], [LastModifiedBy], [LastModifiedDate], [ObsInd], [EmailId]) VALUES (N'Om1', N'Om1', N'OM Rice Mills Assocaition of India', N'System', CAST(0x0000A616016CC734 AS DateTime), N'N', NULL)
INSERT [dbo].[CustomerInfo] ([CustID], [Name], [OrganizationName], [LastModifiedBy], [LastModifiedDate], [ObsInd], [EmailId]) VALUES (N'test1', N'test1', N'test1', N'System', CAST(0x0000A60A01844139 AS DateTime), N'N', NULL)
/****** Object:  Table [Audit].[AuditBaseTables]    Script Date: 08/10/2016 11:42:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Audit].[AuditBaseTables](
	[AuditBaseTableID] [int] IDENTITY(1,1) NOT NULL,
	[SchemaName] [sysname] NOT NULL,
	[TableName] [sysname] NOT NULL,
	[StrictUserContext] [bit] NOT NULL,
	[LogSQL] [bit] NOT NULL,
	[BaseTableDDL] [bit] NOT NULL,
	[LogInsert] [tinyint] NOT NULL,
	[LogUpdate] [tinyint] NOT NULL,
	[LogDelete] [tinyint] NOT NULL,
	[EnabledFlag] [bit] NOT NULL,
	[ViewSchema] [sysname] NOT NULL,
	[ColumnNames] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_AuditBaseTables] PRIMARY KEY CLUSTERED 
(
	[AuditBaseTableID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [IX_AuditBaseTables_SchemaAndTableName] ON [Audit].[AuditBaseTables] 
(
	[SchemaName] ASC,
	[TableName] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
SET IDENTITY_INSERT [Audit].[AuditBaseTables] ON
INSERT [Audit].[AuditBaseTables] ([AuditBaseTableID], [SchemaName], [TableName], [StrictUserContext], [LogSQL], [BaseTableDDL], [LogInsert], [LogUpdate], [LogDelete], [EnabledFlag], [ViewSchema], [ColumnNames]) VALUES (1, N'dbo', N'BagPaymentInfo', 1, 0, 0, 2, 2, 2, 1, N'dbo', N'[AmountPaid],[PaidDate],[CustID],[PaymentMode]')
INSERT [Audit].[AuditBaseTables] ([AuditBaseTableID], [SchemaName], [TableName], [StrictUserContext], [LogSQL], [BaseTableDDL], [LogInsert], [LogUpdate], [LogDelete], [EnabledFlag], [ViewSchema], [ColumnNames]) VALUES (2, N'dbo', N'BagStockInfo', 1, 0, 0, 2, 2, 2, 1, N'dbo', N'[Price],[CustID],[TotalBags]')
INSERT [Audit].[AuditBaseTables] ([AuditBaseTableID], [SchemaName], [TableName], [StrictUserContext], [LogSQL], [BaseTableDDL], [LogInsert], [LogUpdate], [LogDelete], [EnabledFlag], [ViewSchema], [ColumnNames]) VALUES (3, N'dbo', N'BankTransaction', 1, 0, 0, 2, 2, 2, 1, N'dbo', N'[CustID],[Withdraw],[Deposit],[Balance]')
INSERT [Audit].[AuditBaseTables] ([AuditBaseTableID], [SchemaName], [TableName], [StrictUserContext], [LogSQL], [BaseTableDDL], [LogInsert], [LogUpdate], [LogDelete], [EnabledFlag], [ViewSchema], [ColumnNames]) VALUES (4, N'dbo', N'EmployeeSalary', 1, 0, 0, 2, 2, 2, 1, N'dbo', N'[CustID],[Salary]')
INSERT [Audit].[AuditBaseTables] ([AuditBaseTableID], [SchemaName], [TableName], [StrictUserContext], [LogSQL], [BaseTableDDL], [LogInsert], [LogUpdate], [LogDelete], [EnabledFlag], [ViewSchema], [ColumnNames]) VALUES (5, N'dbo', N'ExpenseTransaction', 1, 0, 0, 2, 2, 2, 1, N'dbo', N'[CustID],[Amount]')
INSERT [Audit].[AuditBaseTables] ([AuditBaseTableID], [SchemaName], [TableName], [StrictUserContext], [LogSQL], [BaseTableDDL], [LogInsert], [LogUpdate], [LogDelete], [EnabledFlag], [ViewSchema], [ColumnNames]) VALUES (6, N'dbo', N'HullingProcess', 1, 0, 0, 2, 2, 2, 1, N'dbo', N'[CustID],[Price],[TotalBags]')
INSERT [Audit].[AuditBaseTables] ([AuditBaseTableID], [SchemaName], [TableName], [StrictUserContext], [LogSQL], [BaseTableDDL], [LogInsert], [LogUpdate], [LogDelete], [EnabledFlag], [ViewSchema], [ColumnNames]) VALUES (7, N'dbo', N'HullingProcessExpenses', 1, 0, 0, 2, 2, 2, 1, N'dbo', N'[CustID],[HullingExpenses]')
INSERT [Audit].[AuditBaseTables] ([AuditBaseTableID], [SchemaName], [TableName], [StrictUserContext], [LogSQL], [BaseTableDDL], [LogInsert], [LogUpdate], [LogDelete], [EnabledFlag], [ViewSchema], [ColumnNames]) VALUES (8, N'dbo', N'HullingTransaction', 1, 0, 0, 2, 2, 2, 1, N'dbo', N'[CustID],[MRiceProdTypeID],[BrokenRiceTypeID],[TotalBags],[Price]')
INSERT [Audit].[AuditBaseTables] ([AuditBaseTableID], [SchemaName], [TableName], [StrictUserContext], [LogSQL], [BaseTableDDL], [LogInsert], [LogUpdate], [LogDelete], [EnabledFlag], [ViewSchema], [ColumnNames]) VALUES (9, N'dbo', N'RentalHulling', 1, 0, 0, 2, 2, 2, 1, N'dbo', N'[CustID],[TotalBags],[Price]')
INSERT [Audit].[AuditBaseTables] ([AuditBaseTableID], [SchemaName], [TableName], [StrictUserContext], [LogSQL], [BaseTableDDL], [LogInsert], [LogUpdate], [LogDelete], [EnabledFlag], [ViewSchema], [ColumnNames]) VALUES (10, N'dbo', N'PaddyPaymentDetails', 1, 0, 0, 2, 2, 2, 1, N'dbo', N'[CustID],[AmountPaid]')
INSERT [Audit].[AuditBaseTables] ([AuditBaseTableID], [SchemaName], [TableName], [StrictUserContext], [LogSQL], [BaseTableDDL], [LogInsert], [LogUpdate], [LogDelete], [EnabledFlag], [ViewSchema], [ColumnNames]) VALUES (11, N'dbo', N'PaddyStockInfo', 1, 0, 0, 2, 2, 2, 1, N'dbo', N'[CustID],[Price],[TotalBags]')
INSERT [Audit].[AuditBaseTables] ([AuditBaseTableID], [SchemaName], [TableName], [StrictUserContext], [LogSQL], [BaseTableDDL], [LogInsert], [LogUpdate], [LogDelete], [EnabledFlag], [ViewSchema], [ColumnNames]) VALUES (12, N'dbo', N'ProductPaymentInfo', 1, 0, 0, 2, 2, 2, 1, N'dbo', N'[CustID],[TotalAmount]')
INSERT [Audit].[AuditBaseTables] ([AuditBaseTableID], [SchemaName], [TableName], [StrictUserContext], [LogSQL], [BaseTableDDL], [LogInsert], [LogUpdate], [LogDelete], [EnabledFlag], [ViewSchema], [ColumnNames]) VALUES (13, N'dbo', N'ProductPaymentTransaction', 1, 0, 0, 2, 2, 2, 1, N'dbo', N'[CustID],[ReceivedAmount]')
INSERT [Audit].[AuditBaseTables] ([AuditBaseTableID], [SchemaName], [TableName], [StrictUserContext], [LogSQL], [BaseTableDDL], [LogInsert], [LogUpdate], [LogDelete], [EnabledFlag], [ViewSchema], [ColumnNames]) VALUES (14, N'dbo', N'ProductSellingInfo', 1, 0, 0, 2, 2, 2, 1, N'dbo', N'[CustID],[Price],[TotalBags]')
SET IDENTITY_INSERT [Audit].[AuditBaseTables] OFF
/****** Object:  Table [Audit].[AuditAllExclusions]    Script Date: 08/10/2016 11:42:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [Audit].[AuditAllExclusions](
	[AuditAllExclusionID] [int] IDENTITY(1,1) NOT NULL,
	[SchemaName] [sysname] NOT NULL,
	[TableName] [sysname] NOT NULL,
	[Comment] [varchar](256) NULL,
 CONSTRAINT [PK_AuditAllExclusions] PRIMARY KEY CLUSTERED 
(
	[AuditAllExclusionID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [Audit].[AuditAllExclusions] ON
INSERT [Audit].[AuditAllExclusions] ([AuditAllExclusionID], [SchemaName], [TableName], [Comment]) VALUES (1, N'Audit', N'AuditAllExclusions', N'Added by AutoAudit Setup')
INSERT [Audit].[AuditAllExclusions] ([AuditAllExclusionID], [SchemaName], [TableName], [Comment]) VALUES (2, N'Audit', N'AuditBaseTables', N'Added by AutoAudit Setup')
INSERT [Audit].[AuditAllExclusions] ([AuditAllExclusionID], [SchemaName], [TableName], [Comment]) VALUES (3, N'Audit', N'AuditSettings', N'Added by AutoAudit Setup')
SET IDENTITY_INSERT [Audit].[AuditAllExclusions] OFF
/****** Object:  Table [Audit].[AuditSettings]    Script Date: 08/10/2016 11:42:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [Audit].[AuditSettings](
	[AuditSettingID] [int] IDENTITY(1,1) NOT NULL,
	[SettingName] [varchar](100) NOT NULL,
	[SettingValue] [varchar](100) NULL,
	[AdditionalInfo] [varchar](max) NULL,
 CONSTRAINT [PK_AuditSettings] PRIMARY KEY CLUSTERED 
(
	[AuditSettingID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
 CONSTRAINT [U_AuditSettings_SettingName] UNIQUE NONCLUSTERED 
(
	[SettingName] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [Audit].[AuditSettings] ON
INSERT [Audit].[AuditSettings] ([AuditSettingID], [SettingName], [SettingValue], [AdditionalInfo]) VALUES (1, N'AuditSchema', N'Audit', N'System setting added by AutoAudit installation SQL script.  Do not change manually in the table.')
INSERT [Audit].[AuditSettings] ([AuditSettingID], [SettingName], [SettingValue], [AdditionalInfo]) VALUES (2, N'Schema for _RowHistory and _Deleted objects', N'<TableSchema>', N'User configurable - Schema AutoAudit uses for _RowHistory, _TableRecovery and _Deleted objects. Valid entries can be an existing schema or <TableSchema>. The default is <TableSchema>.')
INSERT [Audit].[AuditSettings] ([AuditSettingID], [SettingName], [SettingValue], [AdditionalInfo]) VALUES (3, N'Version', N'3.30a', N'System setting added by AutoAudit installation SQL script. Do not change manually in the table.')
INSERT [Audit].[AuditSettings] ([AuditSettingID], [SettingName], [SettingValue], [AdditionalInfo]) VALUES (4, N'DateStyle', N'121', N'System setting added by AutoAudit installation SQL script. Do not change manually in the table. You can re-run the AutoAudit installation script to change this setting.')
INSERT [Audit].[AuditSettings] ([AuditSettingID], [SettingName], [SettingValue], [AdditionalInfo]) VALUES (5, N'CreatedColumnName', N'AutoAudit_CreatedDate', N'System setting added by AutoAudit installation SQL script. Do not change manually in the table.')
INSERT [Audit].[AuditSettings] ([AuditSettingID], [SettingName], [SettingValue], [AdditionalInfo]) VALUES (6, N'CreatedByColumnName', N'AutoAudit_CreatedBy', N'System setting added by AutoAudit installation SQL script. Do not change manually in the table.')
INSERT [Audit].[AuditSettings] ([AuditSettingID], [SettingName], [SettingValue], [AdditionalInfo]) VALUES (7, N'ModifiedColumnName', N'AutoAudit_ModifiedDate', N'System setting added by AutoAudit installation SQL script. Do not change manually in the table.')
INSERT [Audit].[AuditSettings] ([AuditSettingID], [SettingName], [SettingValue], [AdditionalInfo]) VALUES (8, N'ModifiedByColumnName', N'AutoAudit_ModifiedBy', N'System setting added by AutoAudit installation SQL script. Do not change manually in the table.')
INSERT [Audit].[AuditSettings] ([AuditSettingID], [SettingName], [SettingValue], [AdditionalInfo]) VALUES (9, N'RowVersionColumnName', N'AutoAudit_RowVersion', N'System setting added by AutoAudit installation SQL script. Do not change manually in the table.')
INSERT [Audit].[AuditSettings] ([AuditSettingID], [SettingName], [SettingValue], [AdditionalInfo]) VALUES (10, N'ViewPrefix', N'v', N'User configurable (default = "v") - Must execute pAutoAuditRebuild(All) or pAutoAudit(All) to apply change. Sets the prefix to use for the _RowHistory and _Deleted views.')
INSERT [Audit].[AuditSettings] ([AuditSettingID], [SettingName], [SettingValue], [AdditionalInfo]) VALUES (11, N'UDFPrefix', N'', N'User configurable (default = "") - Must execute pAutoAuditRebuild(All) or pAutoAudit(All) to apply change. Sets the prefix to use for the _RowHistory and _TableRecovery views.')
INSERT [Audit].[AuditSettings] ([AuditSettingID], [SettingName], [SettingValue], [AdditionalInfo]) VALUES (12, N'RowHistoryViewSuffix', N'_RowHistory', N'User configurable (default = "_RowHistory") - Must execute pAutoAuditRebuild(All) or pAutoAudit(All) to apply change. Sets the suffix to use for the _RowHistory views.')
INSERT [Audit].[AuditSettings] ([AuditSettingID], [SettingName], [SettingValue], [AdditionalInfo]) VALUES (13, N'DeletedViewSuffix', N'_Deleted', N'User configurable (default = "_Deleted") - Must execute pAutoAuditRebuild(All) or pAutoAudit(All) to apply change. Sets the suffix to use for the _Deleted views.')
INSERT [Audit].[AuditSettings] ([AuditSettingID], [SettingName], [SettingValue], [AdditionalInfo]) VALUES (14, N'RowHistoryFunctionSuffix', N'_RowHistory', N'User configurable (default = "_RowHistory") - Must execute pAutoAuditRebuild(All) or pAutoAudit(All) to apply change. Sets the suffix to use for the _RowHistory functions.')
INSERT [Audit].[AuditSettings] ([AuditSettingID], [SettingName], [SettingValue], [AdditionalInfo]) VALUES (15, N'TableRecoveryFunctionSuffix', N'_TableRecovery', N'User configurable (default = "_TableRecovery") - Must execute pAutoAuditRebuild(All) or pAutoAudit(All) to apply change. Sets the suffix to use for the _TableRecovery functions.')
INSERT [Audit].[AuditSettings] ([AuditSettingID], [SettingName], [SettingValue], [AdditionalInfo]) VALUES (16, N'SchemaAuditDDLTrigger Enabled Flag', N'1', N'User configurable - Immediate change. No action required. 0 = DDL trigger disabled, 1 = DDL trigger enabled.')
INSERT [Audit].[AuditSettings] ([AuditSettingID], [SettingName], [SettingValue], [AdditionalInfo]) VALUES (17, N'Archive Audit data older than (days)', N'30', N'User configurable - Immediate change. No action required. Audit data older than this number of days will be moved to the archive tables when the pAutoAuditArchive stored procedure is executed.')
INSERT [Audit].[AuditSettings] ([AuditSettingID], [SettingName], [SettingValue], [AdditionalInfo]) VALUES (18, N'Delete Audit data older than (days)', N'365', N'User configurable - Immediate change. No action required. Audit data older than this number of days will be deleted permanently when the pAutoAuditArchive stored procedure is executed.')
INSERT [Audit].[AuditSettings] ([AuditSettingID], [SettingName], [SettingValue], [AdditionalInfo]) VALUES (19, N'RowHistory View Scope', N'Active', N'User configurable - Must execute pAutoAuditRebuild(All) or pAutoAudit(All) to apply change. Determines source of data when _RowHistory views are created. Valid entries are: "Active", "Archive", "All".')
INSERT [Audit].[AuditSettings] ([AuditSettingID], [SettingName], [SettingValue], [AdditionalInfo]) VALUES (20, N'Deleted View Scope', N'Active', N'User configurable - Must execute pAutoAuditRebuild(All) or pAutoAudit(All) to apply change. Determines source of data when _Deleted views are created. Valid entries are: "Active", "Archive", "All".')
INSERT [Audit].[AuditSettings] ([AuditSettingID], [SettingName], [SettingValue], [AdditionalInfo]) VALUES (21, N'Default _RowHistory view Creation Flag', N'1', N'User configurable - 0 = _RowHistory view is not created, 1 = _RowHistory view is created.')
INSERT [Audit].[AuditSettings] ([AuditSettingID], [SettingName], [SettingValue], [AdditionalInfo]) VALUES (22, N'Default _RowHistory function Creation Flag', N'1', N'User configurable - 0 = _RowHistory function is not created, 1 = _RowHistory function is created.')
INSERT [Audit].[AuditSettings] ([AuditSettingID], [SettingName], [SettingValue], [AdditionalInfo]) VALUES (23, N'Default _TableRecovery function Creation Flag', N'1', N'User configurable - 0 = _TableRecovery function is not created, 1 = _TableRecovery function is created.')
INSERT [Audit].[AuditSettings] ([AuditSettingID], [SettingName], [SettingValue], [AdditionalInfo]) VALUES (24, N'Default _Deleted view Creation Flag', N'1', N'User configurable - 0 = _Deleted view is not created, 1 = _Deleted view is created.')
INSERT [Audit].[AuditSettings] ([AuditSettingID], [SettingName], [SettingValue], [AdditionalInfo]) VALUES (25, N'Launch pAutoAuditRebuild from SchemaAuditDDLTrigger Enabled Flag', N'1', N'System setting added by AutoAudit installation SQL script.  Do not change manually in the table.')
INSERT [Audit].[AuditSettings] ([AuditSettingID], [SettingName], [SettingValue], [AdditionalInfo]) VALUES (26, N'Audit Trigger Debug Flag', N'0', N'User configurable - Immediate change. No action required. - 0 = Do not return debug information, 1 = Return trigger name and nest level.')
INSERT [Audit].[AuditSettings] ([AuditSettingID], [SettingName], [SettingValue], [AdditionalInfo]) VALUES (27, N'Add Extended Properties Flag', N'1', N'User configurable - 0 = Do not save extended properties, 1 = Save extended properties for DDL columns.')
INSERT [Audit].[AuditSettings] ([AuditSettingID], [SettingName], [SettingValue], [AdditionalInfo]) VALUES (28, N'Raiserror to Windows Log Flag', N'0', N'User configurable - 0 = Do not write error to Windows Log, 1 = Write error to Windows Log.')
SET IDENTITY_INSERT [Audit].[AuditSettings] OFF
/****** Object:  Table [Audit].[AuditHeaderArchive]    Script Date: 08/10/2016 11:42:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [Audit].[AuditHeaderArchive](
	[AuditHeaderID] [bigint] NOT NULL,
	[AuditDate] [datetime] NOT NULL,
	[HostName] [sysname] NOT NULL,
	[SysUser] [nvarchar](128) NOT NULL,
	[Application] [varchar](128) NOT NULL,
	[TableName] [sysname] NOT NULL,
	[Operation] [char](1) NOT NULL,
	[SQLStatement] [varchar](max) NULL,
	[PrimaryKey] [varchar](36) NOT NULL,
	[PrimaryKey2] [varchar](36) NULL,
	[PrimaryKey3] [varchar](36) NULL,
	[PrimaryKey4] [varchar](36) NULL,
	[PrimaryKey5] [varchar](36) NULL,
	[RowDescription] [varchar](50) NULL,
	[SecondaryRow] [varchar](50) NULL,
	[RowVersion] [int] NULL,
 CONSTRAINT [pkAuditHeaderArchive] PRIMARY KEY CLUSTERED 
(
	[AuditHeaderID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
CREATE NONCLUSTERED INDEX [IX_AuditHeaderArchive_AuditDate] ON [Audit].[AuditHeaderArchive] 
(
	[AuditDate] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [IX_AuditHeaderArchive_HostName] ON [Audit].[AuditHeaderArchive] 
(
	[HostName] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [IX_AuditHeaderArchive_PrimaryKeyTableName] ON [Audit].[AuditHeaderArchive] 
(
	[PrimaryKey] ASC,
	[TableName] ASC
)
INCLUDE ( [PrimaryKey2],
[PrimaryKey3],
[PrimaryKey4],
[PrimaryKey5]) WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
/****** Object:  Table [Audit].[AuditHeader]    Script Date: 08/10/2016 11:42:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [Audit].[AuditHeader](
	[AuditHeaderID] [bigint] IDENTITY(1,1) NOT NULL,
	[AuditDate] [datetime] NOT NULL,
	[HostName] [sysname] NOT NULL,
	[SysUser] [nvarchar](128) NOT NULL,
	[Application] [varchar](128) NOT NULL,
	[TableName] [sysname] NOT NULL,
	[Operation] [char](1) NOT NULL,
	[SQLStatement] [varchar](max) NULL,
	[PrimaryKey] [varchar](36) NOT NULL,
	[PrimaryKey2] [varchar](36) NULL,
	[PrimaryKey3] [varchar](36) NULL,
	[PrimaryKey4] [varchar](36) NULL,
	[PrimaryKey5] [varchar](36) NULL,
	[RowDescription] [varchar](50) NULL,
	[SecondaryRow] [varchar](50) NULL,
	[RowVersion] [int] NULL,
 CONSTRAINT [pkAuditHeader] PRIMARY KEY CLUSTERED 
(
	[AuditHeaderID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
CREATE NONCLUSTERED INDEX [IX_AuditHeader_PrimaryKey] ON [Audit].[AuditHeader] 
(
	[PrimaryKey] ASC
)
INCLUDE ( [PrimaryKey2],
[PrimaryKey3],
[PrimaryKey4],
[PrimaryKey5],
[RowVersion]) WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
SET IDENTITY_INSERT [Audit].[AuditHeader] ON
INSERT [Audit].[AuditHeader] ([AuditHeaderID], [AuditDate], [HostName], [SysUser], [Application], [TableName], [Operation], [SQLStatement], [PrimaryKey], [PrimaryKey2], [PrimaryKey3], [PrimaryKey4], [PrimaryKey5], [RowDescription], [SecondaryRow], [RowVersion]) VALUES (1, CAST(0x0000A64900A98B9D AS DateTime), N'VARUN', N'Varun\nagavardhan', N'.Net SqlClient Data Provider', N'[dbo].[PaddyStockInfo]', N'i', NULL, N'PS20160720a158b2e2903516', NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [Audit].[AuditHeader] ([AuditHeaderID], [AuditDate], [HostName], [SysUser], [Application], [TableName], [Operation], [SQLStatement], [PrimaryKey], [PrimaryKey2], [PrimaryKey3], [PrimaryKey4], [PrimaryKey5], [RowDescription], [SecondaryRow], [RowVersion]) VALUES (2, CAST(0x0000A64900AA3583 AS DateTime), N'VARUN', N'Varun\nagavardhan', N'.Net SqlClient Data Provider', N'[dbo].[PaddyStockInfo]', N'i', NULL, N'PS20160720b8f68144d0ea78', NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [Audit].[AuditHeader] ([AuditHeaderID], [AuditDate], [HostName], [SysUser], [Application], [TableName], [Operation], [SQLStatement], [PrimaryKey], [PrimaryKey2], [PrimaryKey3], [PrimaryKey4], [PrimaryKey5], [RowDescription], [SecondaryRow], [RowVersion]) VALUES (3, CAST(0x0000A64900AB4D58 AS DateTime), N'VARUN', N'Varun\nagavardhan', N'.Net SqlClient Data Provider', N'[dbo].[PaddyStockInfo]', N'i', NULL, N'PS20160720cd327271fdb589', NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [Audit].[AuditHeader] ([AuditHeaderID], [AuditDate], [HostName], [SysUser], [Application], [TableName], [Operation], [SQLStatement], [PrimaryKey], [PrimaryKey2], [PrimaryKey3], [PrimaryKey4], [PrimaryKey5], [RowDescription], [SecondaryRow], [RowVersion]) VALUES (4, CAST(0x0000A64900AF4E66 AS DateTime), N'VARUN', N'Varun\nagavardhan', N'Microsoft SQL Server Management Studio - Query', N'[dbo].[PaddyStockInfo]', N'd', NULL, N'PS20160719acd50041a81493', NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [Audit].[AuditHeader] ([AuditHeaderID], [AuditDate], [HostName], [SysUser], [Application], [TableName], [Operation], [SQLStatement], [PrimaryKey], [PrimaryKey2], [PrimaryKey3], [PrimaryKey4], [PrimaryKey5], [RowDescription], [SecondaryRow], [RowVersion]) VALUES (5, CAST(0x0000A64900AFBD0B AS DateTime), N'VARUN', N'Varun\nagavardhan', N'Microsoft SQL Server Management Studio - Query', N'[dbo].[PaddyStockInfo]', N'u', NULL, N'PS201607190e5ad9449110e1', NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [Audit].[AuditHeader] ([AuditHeaderID], [AuditDate], [HostName], [SysUser], [Application], [TableName], [Operation], [SQLStatement], [PrimaryKey], [PrimaryKey2], [PrimaryKey3], [PrimaryKey4], [PrimaryKey5], [RowDescription], [SecondaryRow], [RowVersion]) VALUES (6, CAST(0x0000A64900B02B74 AS DateTime), N'VARUN', N'Varun\nagavardhan', N'.Net SqlClient Data Provider', N'[dbo].[PaddyStockInfo]', N'i', NULL, N'PS20160720d86e91a883b37a', NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [Audit].[AuditHeader] ([AuditHeaderID], [AuditDate], [HostName], [SysUser], [Application], [TableName], [Operation], [SQLStatement], [PrimaryKey], [PrimaryKey2], [PrimaryKey3], [PrimaryKey4], [PrimaryKey5], [RowDescription], [SecondaryRow], [RowVersion]) VALUES (7, CAST(0x0000A64900B0C586 AS DateTime), N'VARUN', N'Varun\nagavardhan', N'.Net SqlClient Data Provider', N'[dbo].[HullingProcess]', N'i', NULL, N'HP2016072005f3b781173047', NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [Audit].[AuditHeader] ([AuditHeaderID], [AuditDate], [HostName], [SysUser], [Application], [TableName], [Operation], [SQLStatement], [PrimaryKey], [PrimaryKey2], [PrimaryKey3], [PrimaryKey4], [PrimaryKey5], [RowDescription], [SecondaryRow], [RowVersion]) VALUES (8, CAST(0x0000A64900B0C591 AS DateTime), N'VARUN', N'Varun\nagavardhan', N'.Net SqlClient Data Provider', N'[dbo].[HullingProcessExpenses]', N'i', NULL, N'HPE20160720a3231453a9274f', NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [Audit].[AuditHeader] ([AuditHeaderID], [AuditDate], [HostName], [SysUser], [Application], [TableName], [Operation], [SQLStatement], [PrimaryKey], [PrimaryKey2], [PrimaryKey3], [PrimaryKey4], [PrimaryKey5], [RowDescription], [SecondaryRow], [RowVersion]) VALUES (9, CAST(0x0000A64900B53087 AS DateTime), N'VARUN', N'Varun\nagavardhan', N'Microsoft SQL Server Management Studio - Query', N'[dbo].[HullingProcessExpenses]', N'd', NULL, N'HPE20160720a3231453a9274f', NULL, NULL, NULL, NULL, NULL, NULL, 2)
INSERT [Audit].[AuditHeader] ([AuditHeaderID], [AuditDate], [HostName], [SysUser], [Application], [TableName], [Operation], [SQLStatement], [PrimaryKey], [PrimaryKey2], [PrimaryKey3], [PrimaryKey4], [PrimaryKey5], [RowDescription], [SecondaryRow], [RowVersion]) VALUES (10, CAST(0x0000A64900B54F00 AS DateTime), N'VARUN', N'Varun\nagavardhan', N'Microsoft SQL Server Management Studio - Query', N'[dbo].[HullingProcess]', N'd', NULL, N'HP2016072005f3b781173047', NULL, NULL, NULL, NULL, NULL, NULL, 2)
INSERT [Audit].[AuditHeader] ([AuditHeaderID], [AuditDate], [HostName], [SysUser], [Application], [TableName], [Operation], [SQLStatement], [PrimaryKey], [PrimaryKey2], [PrimaryKey3], [PrimaryKey4], [PrimaryKey5], [RowDescription], [SecondaryRow], [RowVersion]) VALUES (11, CAST(0x0000A64900D46458 AS DateTime), N'VARUN', N'Varun\nagavardhan', N'.Net SqlClient Data Provider', N'[dbo].[HullingProcess]', N'i', NULL, N'HP201607202cacffccf55fbb', NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [Audit].[AuditHeader] ([AuditHeaderID], [AuditDate], [HostName], [SysUser], [Application], [TableName], [Operation], [SQLStatement], [PrimaryKey], [PrimaryKey2], [PrimaryKey3], [PrimaryKey4], [PrimaryKey5], [RowDescription], [SecondaryRow], [RowVersion]) VALUES (12, CAST(0x0000A64900D4645E AS DateTime), N'VARUN', N'Varun\nagavardhan', N'.Net SqlClient Data Provider', N'[dbo].[HullingProcessExpenses]', N'i', NULL, N'HPE2016072008398cff97594f', NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [Audit].[AuditHeader] ([AuditHeaderID], [AuditDate], [HostName], [SysUser], [Application], [TableName], [Operation], [SQLStatement], [PrimaryKey], [PrimaryKey2], [PrimaryKey3], [PrimaryKey4], [PrimaryKey5], [RowDescription], [SecondaryRow], [RowVersion]) VALUES (13, CAST(0x0000A64900D4E8B6 AS DateTime), N'VARUN', N'Varun\nagavardhan', N'Microsoft SQL Server Management Studio - Query', N'[dbo].[HullingProcessExpenses]', N'd', NULL, N'HPE2016072008398cff97594f', NULL, NULL, NULL, NULL, NULL, NULL, 2)
INSERT [Audit].[AuditHeader] ([AuditHeaderID], [AuditDate], [HostName], [SysUser], [Application], [TableName], [Operation], [SQLStatement], [PrimaryKey], [PrimaryKey2], [PrimaryKey3], [PrimaryKey4], [PrimaryKey5], [RowDescription], [SecondaryRow], [RowVersion]) VALUES (14, CAST(0x0000A64900D4F2A5 AS DateTime), N'VARUN', N'Varun\nagavardhan', N'Microsoft SQL Server Management Studio - Query', N'[dbo].[HullingProcess]', N'd', NULL, N'HP201607202cacffccf55fbb', NULL, NULL, NULL, NULL, NULL, NULL, 2)
INSERT [Audit].[AuditHeader] ([AuditHeaderID], [AuditDate], [HostName], [SysUser], [Application], [TableName], [Operation], [SQLStatement], [PrimaryKey], [PrimaryKey2], [PrimaryKey3], [PrimaryKey4], [PrimaryKey5], [RowDescription], [SecondaryRow], [RowVersion]) VALUES (15, CAST(0x0000A64900D9597C AS DateTime), N'VARUN', N'Varun\nagavardhan', N'Microsoft SQL Server Management Studio - Query', N'[dbo].[PaddyStockInfo]', N'u', NULL, N'PS20160720d86e91a883b37a', NULL, NULL, NULL, NULL, NULL, NULL, 2)
INSERT [Audit].[AuditHeader] ([AuditHeaderID], [AuditDate], [HostName], [SysUser], [Application], [TableName], [Operation], [SQLStatement], [PrimaryKey], [PrimaryKey2], [PrimaryKey3], [PrimaryKey4], [PrimaryKey5], [RowDescription], [SecondaryRow], [RowVersion]) VALUES (16, CAST(0x0000A64900DA9538 AS DateTime), N'VARUN', N'Varun\nagavardhan', N'.Net SqlClient Data Provider', N'[dbo].[HullingProcess]', N'i', NULL, N'HP20160720fedbacc8b55f01', NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [Audit].[AuditHeader] ([AuditHeaderID], [AuditDate], [HostName], [SysUser], [Application], [TableName], [Operation], [SQLStatement], [PrimaryKey], [PrimaryKey2], [PrimaryKey3], [PrimaryKey4], [PrimaryKey5], [RowDescription], [SecondaryRow], [RowVersion]) VALUES (17, CAST(0x0000A64900DA953B AS DateTime), N'VARUN', N'Varun\nagavardhan', N'.Net SqlClient Data Provider', N'[dbo].[HullingProcessExpenses]', N'i', NULL, N'HPE201607209806bfb5e1aa24', NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [Audit].[AuditHeader] ([AuditHeaderID], [AuditDate], [HostName], [SysUser], [Application], [TableName], [Operation], [SQLStatement], [PrimaryKey], [PrimaryKey2], [PrimaryKey3], [PrimaryKey4], [PrimaryKey5], [RowDescription], [SecondaryRow], [RowVersion]) VALUES (18, CAST(0x0000A64900DAC57C AS DateTime), N'VARUN', N'Varun\nagavardhan', N'Microsoft SQL Server Management Studio - Query', N'[dbo].[HullingProcessExpenses]', N'd', NULL, N'HPE201607209806bfb5e1aa24', NULL, NULL, NULL, NULL, NULL, NULL, 2)
INSERT [Audit].[AuditHeader] ([AuditHeaderID], [AuditDate], [HostName], [SysUser], [Application], [TableName], [Operation], [SQLStatement], [PrimaryKey], [PrimaryKey2], [PrimaryKey3], [PrimaryKey4], [PrimaryKey5], [RowDescription], [SecondaryRow], [RowVersion]) VALUES (19, CAST(0x0000A64900DAC91E AS DateTime), N'VARUN', N'Varun\nagavardhan', N'Microsoft SQL Server Management Studio - Query', N'[dbo].[HullingProcess]', N'd', NULL, N'HP20160720fedbacc8b55f01', NULL, NULL, NULL, NULL, NULL, NULL, 2)
INSERT [Audit].[AuditHeader] ([AuditHeaderID], [AuditDate], [HostName], [SysUser], [Application], [TableName], [Operation], [SQLStatement], [PrimaryKey], [PrimaryKey2], [PrimaryKey3], [PrimaryKey4], [PrimaryKey5], [RowDescription], [SecondaryRow], [RowVersion]) VALUES (20, CAST(0x0000A64901544A96 AS DateTime), N'VARUN', N'Varun\nagavardhan', N'.Net SqlClient Data Provider', N'[dbo].[PaddyStockInfo]', N'i', NULL, N'PS201607207cf105aea86382', NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [Audit].[AuditHeader] ([AuditHeaderID], [AuditDate], [HostName], [SysUser], [Application], [TableName], [Operation], [SQLStatement], [PrimaryKey], [PrimaryKey2], [PrimaryKey3], [PrimaryKey4], [PrimaryKey5], [RowDescription], [SecondaryRow], [RowVersion]) VALUES (21, CAST(0x0000A64901552026 AS DateTime), N'VARUN', N'Varun\nagavardhan', N'Microsoft SQL Server Management Studio - Query', N'[dbo].[PaddyStockInfo]', N'u', NULL, N'PS201607207cf105aea86382', NULL, NULL, NULL, NULL, NULL, NULL, 2)
INSERT [Audit].[AuditHeader] ([AuditHeaderID], [AuditDate], [HostName], [SysUser], [Application], [TableName], [Operation], [SQLStatement], [PrimaryKey], [PrimaryKey2], [PrimaryKey3], [PrimaryKey4], [PrimaryKey5], [RowDescription], [SecondaryRow], [RowVersion]) VALUES (22, CAST(0x0000A64901555466 AS DateTime), N'VARUN', N'Varun\nagavardhan', N'Microsoft SQL Server Management Studio - Query', N'[dbo].[PaddyStockInfo]', N'u', NULL, N'PS201607207cf105aea86382', NULL, NULL, NULL, NULL, NULL, NULL, 3)
INSERT [Audit].[AuditHeader] ([AuditHeaderID], [AuditDate], [HostName], [SysUser], [Application], [TableName], [Operation], [SQLStatement], [PrimaryKey], [PrimaryKey2], [PrimaryKey3], [PrimaryKey4], [PrimaryKey5], [RowDescription], [SecondaryRow], [RowVersion]) VALUES (23, CAST(0x0000A64B011B866A AS DateTime), N'VARUN', N'Varun\nagavardhan', N'.Net SqlClient Data Provider', N'[dbo].[HullingProcess]', N'i', NULL, N'HP20160722ff5457ec350cb7', NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [Audit].[AuditHeader] ([AuditHeaderID], [AuditDate], [HostName], [SysUser], [Application], [TableName], [Operation], [SQLStatement], [PrimaryKey], [PrimaryKey2], [PrimaryKey3], [PrimaryKey4], [PrimaryKey5], [RowDescription], [SecondaryRow], [RowVersion]) VALUES (24, CAST(0x0000A64B011B866C AS DateTime), N'VARUN', N'Varun\nagavardhan', N'.Net SqlClient Data Provider', N'[dbo].[HullingProcessExpenses]', N'i', NULL, N'HPE20160722e9457e1eef5f7c', NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [Audit].[AuditHeader] ([AuditHeaderID], [AuditDate], [HostName], [SysUser], [Application], [TableName], [Operation], [SQLStatement], [PrimaryKey], [PrimaryKey2], [PrimaryKey3], [PrimaryKey4], [PrimaryKey5], [RowDescription], [SecondaryRow], [RowVersion]) VALUES (25, CAST(0x0000A64B011C6EA5 AS DateTime), N'VARUN', N'Varun\nagavardhan', N'Microsoft SQL Server Management Studio - Query', N'[dbo].[HullingProcessExpenses]', N'd', NULL, N'HPE20160722e9457e1eef5f7c', NULL, NULL, NULL, NULL, NULL, NULL, 2)
INSERT [Audit].[AuditHeader] ([AuditHeaderID], [AuditDate], [HostName], [SysUser], [Application], [TableName], [Operation], [SQLStatement], [PrimaryKey], [PrimaryKey2], [PrimaryKey3], [PrimaryKey4], [PrimaryKey5], [RowDescription], [SecondaryRow], [RowVersion]) VALUES (26, CAST(0x0000A64B011C6EA5 AS DateTime), N'VARUN', N'Varun\nagavardhan', N'Microsoft SQL Server Management Studio - Query', N'[dbo].[HullingProcess]', N'd', NULL, N'HP20160722ff5457ec350cb7', NULL, NULL, NULL, NULL, NULL, NULL, 2)
INSERT [Audit].[AuditHeader] ([AuditHeaderID], [AuditDate], [HostName], [SysUser], [Application], [TableName], [Operation], [SQLStatement], [PrimaryKey], [PrimaryKey2], [PrimaryKey3], [PrimaryKey4], [PrimaryKey5], [RowDescription], [SecondaryRow], [RowVersion]) VALUES (27, CAST(0x0000A65000E9CE06 AS DateTime), N'VARUN', N'Varun\nagavardhan', N'.Net SqlClient Data Provider', N'[dbo].[HullingProcess]', N'i', NULL, N'HP20160727fbc9c30d9c9645', NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [Audit].[AuditHeader] ([AuditHeaderID], [AuditDate], [HostName], [SysUser], [Application], [TableName], [Operation], [SQLStatement], [PrimaryKey], [PrimaryKey2], [PrimaryKey3], [PrimaryKey4], [PrimaryKey5], [RowDescription], [SecondaryRow], [RowVersion]) VALUES (28, CAST(0x0000A65000E9CE18 AS DateTime), N'VARUN', N'Varun\nagavardhan', N'.Net SqlClient Data Provider', N'[dbo].[HullingProcessExpenses]', N'i', NULL, N'HPE20160727014ac60019f149', NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [Audit].[AuditHeader] ([AuditHeaderID], [AuditDate], [HostName], [SysUser], [Application], [TableName], [Operation], [SQLStatement], [PrimaryKey], [PrimaryKey2], [PrimaryKey3], [PrimaryKey4], [PrimaryKey5], [RowDescription], [SecondaryRow], [RowVersion]) VALUES (29, CAST(0x0000A65200B79E9B AS DateTime), N'VARUN', N'Varun\nagavardhan', N'.Net SqlClient Data Provider', N'[dbo].[PaddyPaymentDetails]', N'i', NULL, N'PP201607299fb7f8b867d580', NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [Audit].[AuditHeader] ([AuditHeaderID], [AuditDate], [HostName], [SysUser], [Application], [TableName], [Operation], [SQLStatement], [PrimaryKey], [PrimaryKey2], [PrimaryKey3], [PrimaryKey4], [PrimaryKey5], [RowDescription], [SecondaryRow], [RowVersion]) VALUES (30, CAST(0x0000A65200B79EA5 AS DateTime), N'VARUN', N'Varun\nagavardhan', N'.Net SqlClient Data Provider', N'[dbo].[BankTransaction]', N'i', NULL, N'BT20160729f273149db309ce', NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [Audit].[AuditHeader] ([AuditHeaderID], [AuditDate], [HostName], [SysUser], [Application], [TableName], [Operation], [SQLStatement], [PrimaryKey], [PrimaryKey2], [PrimaryKey3], [PrimaryKey4], [PrimaryKey5], [RowDescription], [SecondaryRow], [RowVersion]) VALUES (31, CAST(0x0000A65200F16C1C AS DateTime), N'VARUN', N'Varun\nagavardhan', N'.Net SqlClient Data Provider', N'[dbo].[PaddyPaymentDetails]', N'i', NULL, N'PP20160729dc0abc9198e9c0', NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [Audit].[AuditHeader] ([AuditHeaderID], [AuditDate], [HostName], [SysUser], [Application], [TableName], [Operation], [SQLStatement], [PrimaryKey], [PrimaryKey2], [PrimaryKey3], [PrimaryKey4], [PrimaryKey5], [RowDescription], [SecondaryRow], [RowVersion]) VALUES (32, CAST(0x0000A65200F16C1E AS DateTime), N'VARUN', N'Varun\nagavardhan', N'.Net SqlClient Data Provider', N'[dbo].[BankTransaction]', N'i', NULL, N'BT201607291975a0e08ddbc7', NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [Audit].[AuditHeader] ([AuditHeaderID], [AuditDate], [HostName], [SysUser], [Application], [TableName], [Operation], [SQLStatement], [PrimaryKey], [PrimaryKey2], [PrimaryKey3], [PrimaryKey4], [PrimaryKey5], [RowDescription], [SecondaryRow], [RowVersion]) VALUES (33, CAST(0x0000A65500C7BF75 AS DateTime), N'VARUN', N'Varun\nagavardhan', N'.Net SqlClient Data Provider', N'[dbo].[ProductPaymentInfo]', N'i', NULL, N'PP201608014599a59dc25e7b', NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [Audit].[AuditHeader] ([AuditHeaderID], [AuditDate], [HostName], [SysUser], [Application], [TableName], [Operation], [SQLStatement], [PrimaryKey], [PrimaryKey2], [PrimaryKey3], [PrimaryKey4], [PrimaryKey5], [RowDescription], [SecondaryRow], [RowVersion]) VALUES (34, CAST(0x0000A65500C7BF83 AS DateTime), N'VARUN', N'Varun\nagavardhan', N'.Net SqlClient Data Provider', N'[dbo].[ProductSellingInfo]', N'i', NULL, N'PI20160801a9562158fd3a90', NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [Audit].[AuditHeader] ([AuditHeaderID], [AuditDate], [HostName], [SysUser], [Application], [TableName], [Operation], [SQLStatement], [PrimaryKey], [PrimaryKey2], [PrimaryKey3], [PrimaryKey4], [PrimaryKey5], [RowDescription], [SecondaryRow], [RowVersion]) VALUES (35, CAST(0x0000A65500C7BF89 AS DateTime), N'VARUN', N'Varun\nagavardhan', N'.Net SqlClient Data Provider', N'[dbo].[ProductSellingInfo]', N'i', NULL, N'PI20160801ddf22d2504653f', NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [Audit].[AuditHeader] ([AuditHeaderID], [AuditDate], [HostName], [SysUser], [Application], [TableName], [Operation], [SQLStatement], [PrimaryKey], [PrimaryKey2], [PrimaryKey3], [PrimaryKey4], [PrimaryKey5], [RowDescription], [SecondaryRow], [RowVersion]) VALUES (36, CAST(0x0000A65500D6AA85 AS DateTime), N'VARUN', N'Varun\nagavardhan', N'.Net SqlClient Data Provider', N'[dbo].[ProductPaymentInfo]', N'i', NULL, N'PP20160801c939712459f340', NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [Audit].[AuditHeader] ([AuditHeaderID], [AuditDate], [HostName], [SysUser], [Application], [TableName], [Operation], [SQLStatement], [PrimaryKey], [PrimaryKey2], [PrimaryKey3], [PrimaryKey4], [PrimaryKey5], [RowDescription], [SecondaryRow], [RowVersion]) VALUES (37, CAST(0x0000A65500D6AA92 AS DateTime), N'VARUN', N'Varun\nagavardhan', N'.Net SqlClient Data Provider', N'[dbo].[ProductSellingInfo]', N'i', NULL, N'PI201608010c267c72a44846', NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [Audit].[AuditHeader] ([AuditHeaderID], [AuditDate], [HostName], [SysUser], [Application], [TableName], [Operation], [SQLStatement], [PrimaryKey], [PrimaryKey2], [PrimaryKey3], [PrimaryKey4], [PrimaryKey5], [RowDescription], [SecondaryRow], [RowVersion]) VALUES (38, CAST(0x0000A65500D81D9C AS DateTime), N'VARUN', N'Varun\nagavardhan', N'.Net SqlClient Data Provider', N'[dbo].[ProductPaymentTransaction]', N'i', NULL, N'PP201608017b8e344696804b', NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [Audit].[AuditHeader] ([AuditHeaderID], [AuditDate], [HostName], [SysUser], [Application], [TableName], [Operation], [SQLStatement], [PrimaryKey], [PrimaryKey2], [PrimaryKey3], [PrimaryKey4], [PrimaryKey5], [RowDescription], [SecondaryRow], [RowVersion]) VALUES (39, CAST(0x0000A65500D81DA1 AS DateTime), N'VARUN', N'Varun\nagavardhan', N'.Net SqlClient Data Provider', N'[dbo].[BankTransaction]', N'i', NULL, N'BT20160801e76286d2bac023', NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [Audit].[AuditHeader] ([AuditHeaderID], [AuditDate], [HostName], [SysUser], [Application], [TableName], [Operation], [SQLStatement], [PrimaryKey], [PrimaryKey2], [PrimaryKey3], [PrimaryKey4], [PrimaryKey5], [RowDescription], [SecondaryRow], [RowVersion]) VALUES (40, CAST(0x0000A6550140F6C8 AS DateTime), N'VARUN', N'Varun\nagavardhan', N'.Net SqlClient Data Provider', N'[dbo].[ProductPaymentTransaction]', N'i', NULL, N'PP20160801cedecb83a527bc', NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [Audit].[AuditHeader] ([AuditHeaderID], [AuditDate], [HostName], [SysUser], [Application], [TableName], [Operation], [SQLStatement], [PrimaryKey], [PrimaryKey2], [PrimaryKey3], [PrimaryKey4], [PrimaryKey5], [RowDescription], [SecondaryRow], [RowVersion]) VALUES (41, CAST(0x0000A6550140F6CA AS DateTime), N'VARUN', N'Varun\nagavardhan', N'.Net SqlClient Data Provider', N'[dbo].[BankTransaction]', N'i', NULL, N'BT20160801cfb5dcbe59ca21', NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [Audit].[AuditHeader] ([AuditHeaderID], [AuditDate], [HostName], [SysUser], [Application], [TableName], [Operation], [SQLStatement], [PrimaryKey], [PrimaryKey2], [PrimaryKey3], [PrimaryKey4], [PrimaryKey5], [RowDescription], [SecondaryRow], [RowVersion]) VALUES (42, CAST(0x0000A655014111B0 AS DateTime), N'VARUN', N'Varun\nagavardhan', N'.Net SqlClient Data Provider', N'[dbo].[ProductPaymentTransaction]', N'i', NULL, N'PP201608017103592fe66b68', NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [Audit].[AuditHeader] ([AuditHeaderID], [AuditDate], [HostName], [SysUser], [Application], [TableName], [Operation], [SQLStatement], [PrimaryKey], [PrimaryKey2], [PrimaryKey3], [PrimaryKey4], [PrimaryKey5], [RowDescription], [SecondaryRow], [RowVersion]) VALUES (43, CAST(0x0000A655014111B1 AS DateTime), N'VARUN', N'Varun\nagavardhan', N'.Net SqlClient Data Provider', N'[dbo].[BankTransaction]', N'i', NULL, N'BT20160801d9edae63d4078f', NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [Audit].[AuditHeader] ([AuditHeaderID], [AuditDate], [HostName], [SysUser], [Application], [TableName], [Operation], [SQLStatement], [PrimaryKey], [PrimaryKey2], [PrimaryKey3], [PrimaryKey4], [PrimaryKey5], [RowDescription], [SecondaryRow], [RowVersion]) VALUES (44, CAST(0x0000A65501413703 AS DateTime), N'VARUN', N'Varun\nagavardhan', N'.Net SqlClient Data Provider', N'[dbo].[ProductPaymentTransaction]', N'i', NULL, N'PP20160801f0646f0cb58d30', NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [Audit].[AuditHeader] ([AuditHeaderID], [AuditDate], [HostName], [SysUser], [Application], [TableName], [Operation], [SQLStatement], [PrimaryKey], [PrimaryKey2], [PrimaryKey3], [PrimaryKey4], [PrimaryKey5], [RowDescription], [SecondaryRow], [RowVersion]) VALUES (45, CAST(0x0000A65501413704 AS DateTime), N'VARUN', N'Varun\nagavardhan', N'.Net SqlClient Data Provider', N'[dbo].[BankTransaction]', N'i', NULL, N'BT201608015a7d7a9f4096ed', NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [Audit].[AuditHeader] ([AuditHeaderID], [AuditDate], [HostName], [SysUser], [Application], [TableName], [Operation], [SQLStatement], [PrimaryKey], [PrimaryKey2], [PrimaryKey3], [PrimaryKey4], [PrimaryKey5], [RowDescription], [SecondaryRow], [RowVersion]) VALUES (46, CAST(0x0000A6550141521A AS DateTime), N'VARUN', N'Varun\nagavardhan', N'.Net SqlClient Data Provider', N'[dbo].[ProductPaymentTransaction]', N'i', NULL, N'PP20160801a196a59cfacdc4', NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [Audit].[AuditHeader] ([AuditHeaderID], [AuditDate], [HostName], [SysUser], [Application], [TableName], [Operation], [SQLStatement], [PrimaryKey], [PrimaryKey2], [PrimaryKey3], [PrimaryKey4], [PrimaryKey5], [RowDescription], [SecondaryRow], [RowVersion]) VALUES (47, CAST(0x0000A6550141521B AS DateTime), N'VARUN', N'Varun\nagavardhan', N'.Net SqlClient Data Provider', N'[dbo].[BankTransaction]', N'i', NULL, N'BT20160801c647f05db7b488', NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [Audit].[AuditHeader] ([AuditHeaderID], [AuditDate], [HostName], [SysUser], [Application], [TableName], [Operation], [SQLStatement], [PrimaryKey], [PrimaryKey2], [PrimaryKey3], [PrimaryKey4], [PrimaryKey5], [RowDescription], [SecondaryRow], [RowVersion]) VALUES (48, CAST(0x0000A6550178C6C7 AS DateTime), N'VARUN', N'Varun\nagavardhan', N'.Net SqlClient Data Provider', N'[dbo].[ProductPaymentInfo]', N'i', NULL, N'PP201608014176cc013af880', NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [Audit].[AuditHeader] ([AuditHeaderID], [AuditDate], [HostName], [SysUser], [Application], [TableName], [Operation], [SQLStatement], [PrimaryKey], [PrimaryKey2], [PrimaryKey3], [PrimaryKey4], [PrimaryKey5], [RowDescription], [SecondaryRow], [RowVersion]) VALUES (49, CAST(0x0000A6550178C6C8 AS DateTime), N'VARUN', N'Varun\nagavardhan', N'.Net SqlClient Data Provider', N'[dbo].[ProductSellingInfo]', N'i', NULL, N'PI2016080125ca53a6957eff', NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [Audit].[AuditHeader] ([AuditHeaderID], [AuditDate], [HostName], [SysUser], [Application], [TableName], [Operation], [SQLStatement], [PrimaryKey], [PrimaryKey2], [PrimaryKey3], [PrimaryKey4], [PrimaryKey5], [RowDescription], [SecondaryRow], [RowVersion]) VALUES (50, CAST(0x0000A6550178E3E7 AS DateTime), N'VARUN', N'Varun\nagavardhan', N'.Net SqlClient Data Provider', N'[dbo].[ProductPaymentTransaction]', N'i', NULL, N'PP20160801e55491295886e4', NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [Audit].[AuditHeader] ([AuditHeaderID], [AuditDate], [HostName], [SysUser], [Application], [TableName], [Operation], [SQLStatement], [PrimaryKey], [PrimaryKey2], [PrimaryKey3], [PrimaryKey4], [PrimaryKey5], [RowDescription], [SecondaryRow], [RowVersion]) VALUES (51, CAST(0x0000A6550178E3E9 AS DateTime), N'VARUN', N'Varun\nagavardhan', N'.Net SqlClient Data Provider', N'[dbo].[BankTransaction]', N'i', NULL, N'BT201608018575afc4c69c6a', NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [Audit].[AuditHeader] ([AuditHeaderID], [AuditDate], [HostName], [SysUser], [Application], [TableName], [Operation], [SQLStatement], [PrimaryKey], [PrimaryKey2], [PrimaryKey3], [PrimaryKey4], [PrimaryKey5], [RowDescription], [SecondaryRow], [RowVersion]) VALUES (52, CAST(0x0000A65600F8BD6D AS DateTime), N'VARUN', N'Varun\nagavardhan', N'.Net SqlClient Data Provider', N'[dbo].[PaddyPaymentDetails]', N'i', NULL, N'PP20160802928323c845729b', NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [Audit].[AuditHeader] ([AuditHeaderID], [AuditDate], [HostName], [SysUser], [Application], [TableName], [Operation], [SQLStatement], [PrimaryKey], [PrimaryKey2], [PrimaryKey3], [PrimaryKey4], [PrimaryKey5], [RowDescription], [SecondaryRow], [RowVersion]) VALUES (53, CAST(0x0000A65600F8BD6F AS DateTime), N'VARUN', N'Varun\nagavardhan', N'.Net SqlClient Data Provider', N'[dbo].[BankTransaction]', N'i', NULL, N'BT20160802d8b9e6d75e7eac', NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [Audit].[AuditHeader] ([AuditHeaderID], [AuditDate], [HostName], [SysUser], [Application], [TableName], [Operation], [SQLStatement], [PrimaryKey], [PrimaryKey2], [PrimaryKey3], [PrimaryKey4], [PrimaryKey5], [RowDescription], [SecondaryRow], [RowVersion]) VALUES (54, CAST(0x0000A65600FA1111 AS DateTime), N'VARUN', N'Varun\nagavardhan', N'.Net SqlClient Data Provider', N'[dbo].[BankTransaction]', N'i', NULL, N'BT2016080262bc89fd2a1209', NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [Audit].[AuditHeader] ([AuditHeaderID], [AuditDate], [HostName], [SysUser], [Application], [TableName], [Operation], [SQLStatement], [PrimaryKey], [PrimaryKey2], [PrimaryKey3], [PrimaryKey4], [PrimaryKey5], [RowDescription], [SecondaryRow], [RowVersion]) VALUES (55, CAST(0x0000A65600FA1118 AS DateTime), N'VARUN', N'Varun\nagavardhan', N'.Net SqlClient Data Provider', N'[dbo].[ExpenseTransaction]', N'i', NULL, N'ExT20160802ac973333ab6f54', NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [Audit].[AuditHeader] ([AuditHeaderID], [AuditDate], [HostName], [SysUser], [Application], [TableName], [Operation], [SQLStatement], [PrimaryKey], [PrimaryKey2], [PrimaryKey3], [PrimaryKey4], [PrimaryKey5], [RowDescription], [SecondaryRow], [RowVersion]) VALUES (56, CAST(0x0000A65D013BF192 AS DateTime), N'VARUN', N'Varun\nagavardhan', N'.Net SqlClient Data Provider', N'[dbo].[ProductPaymentInfo]', N'i', NULL, N'PP20160809df23783990619e', NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [Audit].[AuditHeader] ([AuditHeaderID], [AuditDate], [HostName], [SysUser], [Application], [TableName], [Operation], [SQLStatement], [PrimaryKey], [PrimaryKey2], [PrimaryKey3], [PrimaryKey4], [PrimaryKey5], [RowDescription], [SecondaryRow], [RowVersion]) VALUES (57, CAST(0x0000A65D013BF1A4 AS DateTime), N'VARUN', N'Varun\nagavardhan', N'.Net SqlClient Data Provider', N'[dbo].[ProductSellingInfo]', N'i', NULL, N'PI20160809e20190e8095c40', NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [Audit].[AuditHeader] ([AuditHeaderID], [AuditDate], [HostName], [SysUser], [Application], [TableName], [Operation], [SQLStatement], [PrimaryKey], [PrimaryKey2], [PrimaryKey3], [PrimaryKey4], [PrimaryKey5], [RowDescription], [SecondaryRow], [RowVersion]) VALUES (58, CAST(0x0000A65D0140B1A0 AS DateTime), N'VARUN', N'Varun\nagavardhan', N'.Net SqlClient Data Provider', N'[dbo].[HullingTransaction]', N'i', NULL, N'HTR20160809165e949fe31762', NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [Audit].[AuditHeader] ([AuditHeaderID], [AuditDate], [HostName], [SysUser], [Application], [TableName], [Operation], [SQLStatement], [PrimaryKey], [PrimaryKey2], [PrimaryKey3], [PrimaryKey4], [PrimaryKey5], [RowDescription], [SecondaryRow], [RowVersion]) VALUES (59, CAST(0x0000A65D0140B1A6 AS DateTime), N'VARUN', N'Varun\nagavardhan', N'.Net SqlClient Data Provider', N'[dbo].[HullingTransaction]', N'i', NULL, N'HTBR201608098bd8224ab79c3d', NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [Audit].[AuditHeader] ([AuditHeaderID], [AuditDate], [HostName], [SysUser], [Application], [TableName], [Operation], [SQLStatement], [PrimaryKey], [PrimaryKey2], [PrimaryKey3], [PrimaryKey4], [PrimaryKey5], [RowDescription], [SecondaryRow], [RowVersion]) VALUES (60, CAST(0x0000A65D0140B1A8 AS DateTime), N'VARUN', N'Varun\nagavardhan', N'.Net SqlClient Data Provider', N'[dbo].[HullingTransaction]', N'i', NULL, N'HTD2016080964411ba1e09d09', NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [Audit].[AuditHeader] ([AuditHeaderID], [AuditDate], [HostName], [SysUser], [Application], [TableName], [Operation], [SQLStatement], [PrimaryKey], [PrimaryKey2], [PrimaryKey3], [PrimaryKey4], [PrimaryKey5], [RowDescription], [SecondaryRow], [RowVersion]) VALUES (61, CAST(0x0000A65D0140D4F3 AS DateTime), N'VARUN', N'Varun\nagavardhan', N'.Net SqlClient Data Provider', N'[dbo].[ProductPaymentInfo]', N'i', NULL, N'PP201608093a6ebf50338f40', NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [Audit].[AuditHeader] ([AuditHeaderID], [AuditDate], [HostName], [SysUser], [Application], [TableName], [Operation], [SQLStatement], [PrimaryKey], [PrimaryKey2], [PrimaryKey3], [PrimaryKey4], [PrimaryKey5], [RowDescription], [SecondaryRow], [RowVersion]) VALUES (62, CAST(0x0000A65D0140D4F5 AS DateTime), N'VARUN', N'Varun\nagavardhan', N'.Net SqlClient Data Provider', N'[dbo].[ProductSellingInfo]', N'i', NULL, N'PI2016080945bc880391f189', NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [Audit].[AuditHeader] ([AuditHeaderID], [AuditDate], [HostName], [SysUser], [Application], [TableName], [Operation], [SQLStatement], [PrimaryKey], [PrimaryKey2], [PrimaryKey3], [PrimaryKey4], [PrimaryKey5], [RowDescription], [SecondaryRow], [RowVersion]) VALUES (63, CAST(0x0000A65E00B8C569 AS DateTime), N'VARUN', N'Varun\nagavardhan', N'.Net SqlClient Data Provider', N'[dbo].[ProductPaymentInfo]', N'i', NULL, N'PP20160810cbb17e547b29b3', NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [Audit].[AuditHeader] ([AuditHeaderID], [AuditDate], [HostName], [SysUser], [Application], [TableName], [Operation], [SQLStatement], [PrimaryKey], [PrimaryKey2], [PrimaryKey3], [PrimaryKey4], [PrimaryKey5], [RowDescription], [SecondaryRow], [RowVersion]) VALUES (64, CAST(0x0000A65E00B8C56B AS DateTime), N'VARUN', N'Varun\nagavardhan', N'.Net SqlClient Data Provider', N'[dbo].[ProductSellingInfo]', N'i', NULL, N'PI2016081039675b55c03ba8', NULL, NULL, NULL, NULL, NULL, NULL, 1)
SET IDENTITY_INSERT [Audit].[AuditHeader] OFF
/****** Object:  Table [Audit].[SchemaAudit]    Script Date: 08/10/2016 11:42:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [Audit].[SchemaAudit](
	[SchemaAuditID] [int] IDENTITY(1,1) NOT NULL,
	[AuditDate] [datetime] NOT NULL,
	[LoginName] [sysname] NOT NULL,
	[UserName] [sysname] NOT NULL,
	[Event] [sysname] NOT NULL,
	[Schema] [sysname] NULL,
	[Object] [sysname] NULL,
	[TSQL] [varchar](max) NOT NULL,
	[XMLEventData] [xml] NOT NULL,
 CONSTRAINT [PK_SchemaAudit] PRIMARY KEY CLUSTERED 
(
	[SchemaAuditID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[RMUserRole]    Script Date: 08/10/2016 11:42:06 ******/
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
/****** Object:  View [Audit].[vAuditHeaderAll]    Script Date: 08/10/2016 11:42:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [Audit].[vAuditHeaderAll]
AS 

 -- generated by AutoAudit Version 3.30a on Jul 20 2016 10:07AM
 -- created by Paul Nielsen and John Sigouin 
 -- www.SQLServerBible.com 
 -- AutoAudit.codeplex.com 
 -- This view returns data from the AuditHeader and AuditHeaderArchive AutoAudit tables. 

SELECT	cast('Active' as varchar(7)) as Source 
			,[AuditHeaderID]
			,[AuditDate]
			,[HostName]
			,[SysUser]
			,[Application]
			,[TableName]
			,[Operation]
			,[SQLStatement]
			,[PrimaryKey]
			,[PrimaryKey2]
			,[PrimaryKey3]
			,[PrimaryKey4]
			,[PrimaryKey5]
			,[RowDescription]
			,[SecondaryRow]
			,[RowVersion]
FROM		[Audit].[AuditHeader] AH
UNION All 
SELECT	cast('Archive' as varchar(7)) as Source 
			,[AuditHeaderID]
			,[AuditDate]
			,[HostName]
			,[SysUser]
			,[Application]
			,[TableName]
			,[Operation]
			,[SQLStatement]
			,[PrimaryKey]
			,[PrimaryKey2]
			,[PrimaryKey3]
			,[PrimaryKey4]
			,[PrimaryKey5]
			,[RowDescription]
			,[SecondaryRow]
			,[RowVersion]
FROM		[Audit].[AuditHeaderArchive] AHA;
GO
/****** Object:  StoredProcedure [Audit].[pAutoAuditAll]    Script Date: 08/10/2016 11:42:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE 
PROC [Audit].[pAutoAuditAll] (
   @StrictUserContext BIT = 1,  -- 2.00 if 0 then permits DML setting of Created, CreatedBy, Modified, ModifiedBy
   @LogSQL BIT = 0,
   @BaseTableDDL BIT = 0,	-- 0 = don't add audit columns to base table, 1 = add audit columns to base table
   @LogInsert TINYINT = 2,	-- 0 = nothing, 1 = header only, 2 = header and detail
   @LogUpdate TINYINT = 2,	-- 0 = nothing, 1 = header only, 2 = header and detail
   @LogDelete TINYINT = 2	-- 0 = nothing, 1 = header only, 2 = header and detail
) 
AS 

-- Created for AutoAudit Version 3.30a
-- created by Paul Nielsen and John Sigouin
-- www.SQLServerBible.com
-- AutoAudit.codeplex.com
-- This SP is used to create AutoAudit triggers for all tables in the current database 
-- except for system tables, AutoAudit tables and the tables listed in the AuditAllExclusions table.

SET NoCount ON 

--get [AuditSettings] 
DECLARE @AuditSchema VARCHAR(50)
SELECT @AuditSchema = [SettingValue] from [AuditSettings] where [SettingName] = 'AuditSchema'

DECLARE 
   @TableName sysname, 
   @SchemaName sysname, 
   @SQL NVARCHAR(max)
-- for each table
-- 1
DECLARE cTables CURSOR FAST_FORWARD READ_ONLY
  FOR  SELECT s.name, t.name 
			  from sys.tables t
				join sys.schemas s
				  on t.schema_id = s.schema_id
			 where t.name not in 
				('AuditHeader','AuditDetail',
				'SchemaAudit','Audit',
				'AuditHeaderArchive','AuditDetailArchive',
				'LegacyAudit_Migrated','RolePermissions','sysdiagrams')
			 and t.name not like 'aspnet_%'
		AND s.name not in
            (SELECT SchemaName
            FROM    AuditAllExclusions where TableName = '<All>')
        EXCEPT
		SELECT	SchemaName, TableName
		FROM	AuditAllExclusions

--2 
OPEN cTables
--3 
FETCH cTables INTO @SchemaName, @TableName   -- prime the cursor
WHILE @@Fetch_Status = 0 
  BEGIN
		SET @SQL = 'EXEC ' + quotename(@AuditSchema) + '.pAutoAudit ''' + @SchemaName + ''', ''' + @TableName + ''''
		SELECT @SQL = @SQL + ', @StrictUserContext = ' + isnull(cast(@StrictUserContext as varchar(10)),'null')
		SELECT @SQL = @SQL + ', @LogSQL = ' + isnull(cast(@LogSQL as varchar(10)),'null')
		SELECT @SQL = @SQL + ', @BaseTableDDL = ' + isnull(cast(@BaseTableDDL as varchar(10)),'null')
		SELECT @SQL = @SQL + ', @LogInsert = ' + isnull(cast(@LogInsert as varchar(10)),'null')
		SELECT @SQL = @SQL + ', @LogUpdate = ' + isnull(cast(@LogUpdate as varchar(10)),'null')
		SELECT @SQL = @SQL + ', @LogDelete = ' + isnull(cast(@LogDelete as varchar(10)),'null')

		EXEC (@SQL)
      FETCH cTables INTO @SchemaName, @TableName   -- fetch next
  END
-- 4  
CLOSE cTables
-- 5
DEALLOCATE cTables

RETURN
GO
/****** Object:  Table [dbo].[Users]    Script Date: 08/10/2016 11:42:07 ******/
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
	[EmailId] [nvarchar](50) NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Users] ([UserID], [CustID], [Name], [PassWord], [LastModifiedBy], [LastModifiedDate], [ObsInd], [EmailId]) VALUES (N'UI2016053011173519844255929', N'NandhiMill', N'nagu', N'A47WV84jYe+SASsqD8pMIA==', N'System', CAST(0x0000A61600BA1A94 AS DateTime), N'N', NULL)
INSERT [dbo].[Users] ([UserID], [CustID], [Name], [PassWord], [LastModifiedBy], [LastModifiedDate], [ObsInd], [EmailId]) VALUES (N'UI2016053021461063450110035', N'Om', N'Test', N'/aM5nPzVFy58l+2LTaX7jA==', N'System', CAST(0x0000A6160166BFD8 AS DateTime), N'N', NULL)
INSERT [dbo].[Users] ([UserID], [CustID], [Name], [PassWord], [LastModifiedBy], [LastModifiedDate], [ObsInd], [EmailId]) VALUES (N'UI2016053022083887472961429', N'Om1', N'Test', N'/aM5nPzVFy58l+2LTaX7jA==', N'System', CAST(0x0000A616016CEB88 AS DateTime), N'N', NULL)
INSERT [dbo].[Users] ([UserID], [CustID], [Name], [PassWord], [LastModifiedBy], [LastModifiedDate], [ObsInd], [EmailId]) VALUES (N'UI2016060816482920430349260', N'Om1', N'test1', N'/aM5nPzVFy58l+2LTaX7jA==', N'Om\test', CAST(0x0000A61F0114FCFC AS DateTime), N'N', NULL)
/****** Object:  Table [dbo].[SellerInfo]    Script Date: 08/10/2016 11:42:07 ******/
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
INSERT [dbo].[SellerInfo] ([SellerID], [CustID], [Name], [Street], [Street1], [Town], [City], [District], [State], [PinCode], [ContactNo], [MobileNo], [PhoneNo], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (N'SE2016071959f4346f09f947', N'om', N'Ramesh', N'', N'', N'Siruguppa', N'Siruguppa', N'Siruguppa', N'Karnataka', N'', N'9845033221', N'', N'', N'om\test', CAST(0x0000A64800CB9F58 AS DateTime), N'N')
INSERT [dbo].[SellerInfo] ([SellerID], [CustID], [Name], [Street], [Street1], [Town], [City], [District], [State], [PinCode], [ContactNo], [MobileNo], [PhoneNo], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (N'SE201607198883488d3bd421', N'om', N'Gangadhar', N'', N'', N'Shikaripura', N'Shikaripura', N'Shimogga', N'Karnataka', N'577427', N'9448043321', N'', N'', N'om\test', CAST(0x0000A64800ADB524 AS DateTime), N'N')
INSERT [dbo].[SellerInfo] ([SellerID], [CustID], [Name], [Street], [Street1], [Town], [City], [District], [State], [PinCode], [ContactNo], [MobileNo], [PhoneNo], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (N'SE20160719f5092a5d475a46', N'om', N'Chandrashekar', N'', N'', N'bellary', N'Bellary', N'Bellary', N'Karnataka', N'', N'9900990300', N'', N'', N'om\test', CAST(0x0000A64800CB78AC AS DateTime), N'N')
/****** Object:  Table [Audit].[AuditDetailArchive]    Script Date: 08/10/2016 11:42:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [Audit].[AuditDetailArchive](
	[AuditDetailID] [bigint] NOT NULL,
	[AuditHeaderID] [bigint] NOT NULL,
	[ColumnName] [sysname] NULL,
	[OldValue] [varchar](50) NULL,
	[NewValue] [varchar](50) NULL,
 CONSTRAINT [pkAuditDetailArchive] PRIMARY KEY CLUSTERED 
(
	[AuditDetailID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
CREATE NONCLUSTERED INDEX [IX_AuditDetailArchive_AuditHeaderID] ON [Audit].[AuditDetailArchive] 
(
	[AuditHeaderID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [IX_AuditDetailArchive_ColumnName] ON [Audit].[AuditDetailArchive] 
(
	[ColumnName] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [IX_AuditDetailArchive_NewValue] ON [Audit].[AuditDetailArchive] 
(
	[NewValue] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [IX_AuditDetailArchive_OldValue] ON [Audit].[AuditDetailArchive] 
(
	[OldValue] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
/****** Object:  Table [Audit].[AuditDetail]    Script Date: 08/10/2016 11:42:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [Audit].[AuditDetail](
	[AuditDetailID] [bigint] IDENTITY(1,1) NOT NULL,
	[AuditHeaderID] [bigint] NOT NULL,
	[ColumnName] [sysname] NULL,
	[OldValue] [varchar](50) NULL,
	[NewValue] [varchar](50) NULL,
 CONSTRAINT [pkAuditDetail] PRIMARY KEY CLUSTERED 
(
	[AuditDetailID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
CREATE NONCLUSTERED INDEX [IX_AuditDetail_AuditHeaderID] ON [Audit].[AuditDetail] 
(
	[AuditHeaderID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
SET IDENTITY_INSERT [Audit].[AuditDetail] ON
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (1, 1, N'[PaddyStockID]', NULL, N'PS20160720a158b2e2903516')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (2, 1, N'[CustID]', NULL, N'om')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (3, 1, N'[Price]', NULL, N'1,050.00')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (4, 1, N'[TotalBags]', NULL, N'200')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (5, 2, N'[PaddyStockID]', NULL, N'PS20160720b8f68144d0ea78')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (6, 2, N'[CustID]', NULL, N'om')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (7, 2, N'[Price]', NULL, N'1,200.00')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (8, 2, N'[TotalBags]', NULL, N'300')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (9, 3, N'[PaddyStockID]', NULL, N'PS20160720cd327271fdb589')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (10, 3, N'[CustID]', NULL, N'om')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (11, 3, N'[Price]', NULL, N'1,275.00')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (12, 3, N'[TotalBags]', NULL, N'200')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (13, 4, N'[PaddyStockID]', N'PS20160719acd50041a81493', NULL)
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (14, 4, N'[CustID]', N'om', NULL)
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (15, 4, N'[Price]', N'1,050.00', NULL)
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (16, 4, N'[TotalBags]', N'200', NULL)
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (17, 5, N'[TotalBags]', N'400', N'200')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (18, 6, N'[PaddyStockID]', NULL, N'PS20160720d86e91a883b37a')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (19, 6, N'[CustID]', NULL, N'om')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (20, 6, N'[Price]', NULL, N'1,275.00')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (21, 6, N'[TotalBags]', NULL, N'200')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (22, 7, N'[HullingProcessID]', NULL, N'HP2016072005f3b781173047')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (23, 7, N'[CustID]', NULL, N'om')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (24, 7, N'[TotalBags]', NULL, N'260')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (25, 7, N'[Price]', NULL, N'1,305.00')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (26, 8, N'[HullingProcessExpenID]', NULL, N'HPE20160720a3231453a9274f')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (27, 8, N'[CustID]', NULL, N'om')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (28, 8, N'[HullingExpenses]', NULL, N'26,000.00')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (29, 9, N'[HullingProcessExpenID]', N'HPE20160720a3231453a9274f', NULL)
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (30, 9, N'[CustID]', N'om', NULL)
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (31, 9, N'[HullingExpenses]', N'26,000.00', NULL)
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (32, 10, N'[HullingProcessID]', N'HP2016072005f3b781173047', NULL)
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (33, 10, N'[CustID]', N'om', NULL)
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (34, 10, N'[TotalBags]', N'260', NULL)
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (35, 10, N'[Price]', N'1,305.00', NULL)
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (36, 11, N'[HullingProcessID]', NULL, N'HP201607202cacffccf55fbb')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (37, 11, N'[CustID]', NULL, N'om')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (38, 11, N'[TotalBags]', NULL, N'200')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (39, 11, N'[Price]', NULL, N'0.00')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (40, 12, N'[HullingProcessExpenID]', NULL, N'HPE2016072008398cff97594f')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (41, 12, N'[CustID]', NULL, N'om')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (42, 12, N'[HullingExpenses]', NULL, N'0.00')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (43, 13, N'[HullingProcessExpenID]', N'HPE2016072008398cff97594f', NULL)
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (44, 13, N'[CustID]', N'om', NULL)
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (45, 13, N'[HullingExpenses]', N'0.00', NULL)
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (46, 14, N'[HullingProcessID]', N'HP201607202cacffccf55fbb', NULL)
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (47, 14, N'[CustID]', N'om', NULL)
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (48, 14, N'[TotalBags]', N'200', NULL)
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (49, 14, N'[Price]', N'0.00', NULL)
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (50, 15, N'[Price]', N'1,275.00', N'1,500.00')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (51, 16, N'[HullingProcessID]', NULL, N'HP20160720fedbacc8b55f01')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (52, 16, N'[CustID]', NULL, N'om')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (53, 16, N'[TotalBags]', NULL, N'380')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (54, 16, N'[Price]', NULL, N'1,417.50')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (55, 17, N'[HullingProcessExpenID]', NULL, N'HPE201607209806bfb5e1aa24')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (56, 17, N'[CustID]', NULL, N'om')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (57, 17, N'[HullingExpenses]', NULL, N'38,000.00')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (58, 18, N'[HullingProcessExpenID]', N'HPE201607209806bfb5e1aa24', NULL)
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (59, 18, N'[CustID]', N'om', NULL)
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (60, 18, N'[HullingExpenses]', N'38,000.00', NULL)
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (61, 19, N'[HullingProcessID]', N'HP20160720fedbacc8b55f01', NULL)
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (62, 19, N'[CustID]', N'om', NULL)
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (63, 19, N'[TotalBags]', N'380', NULL)
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (64, 19, N'[Price]', N'1,417.50', NULL)
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (65, 20, N'[PaddyStockID]', NULL, N'PS201607207cf105aea86382')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (66, 20, N'[CustID]', NULL, N'om')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (67, 20, N'[Price]', NULL, N'230.00')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (68, 20, N'[TotalBags]', NULL, N'999')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (69, 21, N'[Price]', N'230.00', N'123.00')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (70, 22, N'[Price]', N'123.00', N'343.00')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (71, 23, N'[HullingProcessID]', NULL, N'HP20160722ff5457ec350cb7')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (72, 23, N'[CustID]', NULL, N'om')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (73, 23, N'[TotalBags]', NULL, N'200')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (74, 23, N'[Price]', NULL, N'1,890.00')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (75, 24, N'[HullingProcessExpenID]', NULL, N'HPE20160722e9457e1eef5f7c')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (76, 24, N'[CustID]', NULL, N'om')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (77, 24, N'[HullingExpenses]', NULL, N'0.00')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (78, 25, N'[HullingProcessExpenID]', N'HPE20160722e9457e1eef5f7c', NULL)
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (79, 25, N'[CustID]', N'om', NULL)
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (80, 25, N'[HullingExpenses]', N'0.00', NULL)
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (81, 26, N'[HullingProcessID]', N'HP20160722ff5457ec350cb7', NULL)
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (82, 26, N'[CustID]', N'om', NULL)
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (83, 26, N'[TotalBags]', N'200', NULL)
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (84, 26, N'[Price]', N'1,890.00', NULL)
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (85, 27, N'[HullingProcessID]', NULL, N'HP20160727fbc9c30d9c9645')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (86, 27, N'[CustID]', NULL, N'om')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (87, 27, N'[TotalBags]', NULL, N'260')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (88, 27, N'[Price]', NULL, N'1,890.00')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (89, 28, N'[HullingProcessExpenID]', NULL, N'HPE20160727014ac60019f149')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (90, 28, N'[CustID]', NULL, N'om')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (91, 28, N'[HullingExpenses]', NULL, N'26,000.00')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (92, 29, N'[PaddyPaymentID]', NULL, N'PP201607299fb7f8b867d580')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (93, 29, N'[CustID]', NULL, N'om')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (94, 29, N'[AmountPaid]', NULL, N'123,456.00')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (95, 30, N'[BankTransID]', NULL, N'BT20160729f273149db309ce')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (96, 30, N'[CustID]', NULL, N'om')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (97, 30, N'[Withdraw]', NULL, N'123,456.00')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (98, 30, N'[Deposit]', NULL, N'0.00')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (99, 30, N'[Balance]', NULL, N'0.00')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (100, 31, N'[PaddyPaymentID]', NULL, N'PP20160729dc0abc9198e9c0')
GO
print 'Processed 100 total records'
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (101, 31, N'[CustID]', NULL, N'om')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (102, 31, N'[AmountPaid]', NULL, N'99,000.00')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (103, 32, N'[BankTransID]', NULL, N'BT201607291975a0e08ddbc7')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (104, 32, N'[CustID]', NULL, N'om')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (105, 32, N'[Withdraw]', NULL, N'99,000.00')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (106, 32, N'[Deposit]', NULL, N'0.00')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (107, 32, N'[Balance]', NULL, N'0.00')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (108, 33, N'[ProductPaymentID]', NULL, N'PP201608014599a59dc25e7b')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (109, 33, N'[CustID]', NULL, N'om')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (110, 33, N'[TotalAmount]', NULL, N'420,000.00')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (111, 34, N'[ProductID]', NULL, N'PI20160801a9562158fd3a90')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (112, 34, N'[CustID]', NULL, N'om')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (113, 34, N'[Price]', NULL, N'1,050.00')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (114, 34, N'[TotalBags]', NULL, N'200')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (115, 35, N'[ProductID]', NULL, N'PI20160801ddf22d2504653f')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (116, 35, N'[CustID]', NULL, N'om')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (117, 35, N'[Price]', NULL, N'1,050.00')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (118, 35, N'[TotalBags]', NULL, N'200')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (119, 36, N'[ProductPaymentID]', NULL, N'PP20160801c939712459f340')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (120, 36, N'[CustID]', NULL, N'om')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (121, 36, N'[TotalAmount]', NULL, N'125,000.00')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (122, 37, N'[ProductID]', NULL, N'PI201608010c267c72a44846')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (123, 37, N'[CustID]', NULL, N'om')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (124, 37, N'[Price]', NULL, N'1,250.00')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (125, 37, N'[TotalBags]', NULL, N'100')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (126, 38, N'[ProductPaymentTranID]', NULL, N'PP201608017b8e344696804b')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (127, 38, N'[CustID]', NULL, N'om')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (128, 38, N'[ReceivedAmount]', NULL, N'120,000.00')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (129, 39, N'[BankTransID]', NULL, N'BT20160801e76286d2bac023')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (130, 39, N'[CustID]', NULL, N'om')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (131, 39, N'[Withdraw]', NULL, N'0.00')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (132, 39, N'[Deposit]', NULL, N'120,000.00')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (133, 39, N'[Balance]', NULL, N'0.00')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (134, 40, N'[ProductPaymentTranID]', NULL, N'PP20160801cedecb83a527bc')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (135, 40, N'[CustID]', NULL, N'om')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (136, 40, N'[ReceivedAmount]', NULL, N'100,000.00')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (137, 41, N'[BankTransID]', NULL, N'BT20160801cfb5dcbe59ca21')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (138, 41, N'[CustID]', NULL, N'om')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (139, 41, N'[Withdraw]', NULL, N'0.00')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (140, 41, N'[Deposit]', NULL, N'100,000.00')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (141, 41, N'[Balance]', NULL, N'0.00')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (142, 42, N'[ProductPaymentTranID]', NULL, N'PP201608017103592fe66b68')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (143, 42, N'[CustID]', NULL, N'om')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (144, 42, N'[ReceivedAmount]', NULL, N'1,200.00')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (145, 43, N'[BankTransID]', NULL, N'BT20160801d9edae63d4078f')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (146, 43, N'[CustID]', NULL, N'om')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (147, 43, N'[Withdraw]', NULL, N'0.00')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (148, 43, N'[Deposit]', NULL, N'1,200.00')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (149, 43, N'[Balance]', NULL, N'0.00')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (150, 44, N'[ProductPaymentTranID]', NULL, N'PP20160801f0646f0cb58d30')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (151, 44, N'[CustID]', NULL, N'om')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (152, 44, N'[ReceivedAmount]', NULL, N'118,800.00')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (153, 45, N'[BankTransID]', NULL, N'BT201608015a7d7a9f4096ed')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (154, 45, N'[CustID]', NULL, N'om')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (155, 45, N'[Withdraw]', NULL, N'0.00')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (156, 45, N'[Deposit]', NULL, N'118,800.00')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (157, 45, N'[Balance]', NULL, N'0.00')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (158, 46, N'[ProductPaymentTranID]', NULL, N'PP20160801a196a59cfacdc4')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (159, 46, N'[CustID]', NULL, N'om')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (160, 46, N'[ReceivedAmount]', NULL, N'100,000.00')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (161, 47, N'[BankTransID]', NULL, N'BT20160801c647f05db7b488')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (162, 47, N'[CustID]', NULL, N'om')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (163, 47, N'[Withdraw]', NULL, N'0.00')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (164, 47, N'[Deposit]', NULL, N'100,000.00')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (165, 47, N'[Balance]', NULL, N'0.00')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (166, 48, N'[ProductPaymentID]', NULL, N'PP201608014176cc013af880')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (167, 48, N'[CustID]', NULL, N'om')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (168, 48, N'[TotalAmount]', NULL, N'225,000.00')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (169, 49, N'[ProductID]', NULL, N'PI2016080125ca53a6957eff')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (170, 49, N'[CustID]', NULL, N'om')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (171, 49, N'[Price]', NULL, N'1,125.00')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (172, 49, N'[TotalBags]', NULL, N'200')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (173, 50, N'[ProductPaymentTranID]', NULL, N'PP20160801e55491295886e4')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (174, 50, N'[CustID]', NULL, N'om')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (175, 50, N'[ReceivedAmount]', NULL, N'10,000.00')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (176, 51, N'[BankTransID]', NULL, N'BT201608018575afc4c69c6a')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (177, 51, N'[CustID]', NULL, N'om')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (178, 51, N'[Withdraw]', NULL, N'0.00')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (179, 51, N'[Deposit]', NULL, N'10,000.00')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (180, 51, N'[Balance]', NULL, N'0.00')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (181, 52, N'[PaddyPaymentID]', NULL, N'PP20160802928323c845729b')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (182, 52, N'[CustID]', NULL, N'om')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (183, 52, N'[AmountPaid]', NULL, N'261,000.00')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (184, 53, N'[BankTransID]', NULL, N'BT20160802d8b9e6d75e7eac')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (185, 53, N'[CustID]', NULL, N'om')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (186, 53, N'[Withdraw]', NULL, N'261,000.00')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (187, 53, N'[Deposit]', NULL, N'0.00')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (188, 53, N'[Balance]', NULL, N'0.00')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (189, 54, N'[BankTransID]', NULL, N'BT2016080262bc89fd2a1209')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (190, 54, N'[CustID]', NULL, N'om')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (191, 54, N'[Withdraw]', NULL, N'5,000.00')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (192, 54, N'[Deposit]', NULL, N'0.00')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (193, 54, N'[Balance]', NULL, N'0.00')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (194, 55, N'[ExpenseTransID]', NULL, N'ExT20160802ac973333ab6f54')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (195, 55, N'[CustID]', NULL, N'om')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (196, 55, N'[Amount]', NULL, N'5,000.00')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (197, 56, N'[ProductPaymentID]', NULL, N'PP20160809df23783990619e')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (198, 56, N'[CustID]', NULL, N'om')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (199, 56, N'[TotalAmount]', NULL, N'30,000.00')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (200, 57, N'[ProductID]', NULL, N'PI20160809e20190e8095c40')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (201, 57, N'[CustID]', NULL, N'om')
GO
print 'Processed 200 total records'
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (202, 57, N'[Price]', NULL, N'1,000.00')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (203, 57, N'[TotalBags]', NULL, N'30')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (204, 58, N'[HullingTransID]', NULL, N'HTR20160809165e949fe31762')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (205, 58, N'[MRiceProdTypeID]', NULL, N'RP201607196cda0aa0548d47')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (206, 58, N'[CustID]', NULL, N'om')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (207, 58, N'[TotalBags]', NULL, N'600')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (208, 58, N'[Price]', NULL, N'0.00')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (209, 59, N'[HullingTransID]', NULL, N'HTBR201608098bd8224ab79c3d')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (210, 59, N'[BrokenRiceTypeID]', NULL, N'PT20160719985d83a75b7627')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (211, 59, N'[CustID]', NULL, N'om')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (212, 59, N'[TotalBags]', NULL, N'4')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (213, 59, N'[Price]', NULL, N'4,000.00')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (214, 60, N'[HullingTransID]', NULL, N'HTD2016080964411ba1e09d09')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (215, 60, N'[CustID]', NULL, N'om')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (216, 60, N'[TotalBags]', NULL, N'2')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (217, 60, N'[Price]', NULL, N'2,000.00')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (218, 61, N'[ProductPaymentID]', NULL, N'PP201608093a6ebf50338f40')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (219, 61, N'[CustID]', NULL, N'om')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (220, 61, N'[TotalAmount]', NULL, N'100,000.00')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (221, 62, N'[ProductID]', NULL, N'PI2016080945bc880391f189')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (222, 62, N'[CustID]', NULL, N'om')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (223, 62, N'[Price]', NULL, N'1,000.00')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (224, 62, N'[TotalBags]', NULL, N'100')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (225, 63, N'[ProductPaymentID]', NULL, N'PP20160810cbb17e547b29b3')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (226, 63, N'[CustID]', NULL, N'om')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (227, 63, N'[TotalAmount]', NULL, N'200,000.00')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (228, 64, N'[ProductID]', NULL, N'PI2016081039675b55c03ba8')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (229, 64, N'[CustID]', NULL, N'om')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (230, 64, N'[Price]', NULL, N'1,000.00')
INSERT [Audit].[AuditDetail] ([AuditDetailID], [AuditHeaderID], [ColumnName], [OldValue], [NewValue]) VALUES (231, 64, N'[TotalBags]', NULL, N'200')
SET IDENTITY_INSERT [Audit].[AuditDetail] OFF
/****** Object:  Table [dbo].[BuyerInfo]    Script Date: 08/10/2016 11:42:07 ******/
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
	[TINNumber] [nvarchar](60) NULL,
 CONSTRAINT [PK_BuyerInfo] PRIMARY KEY CLUSTERED 
(
	[BuyerID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[BuyerInfo] ([BuyerID], [CustID], [Name], [Street], [Street1], [Town], [City], [District], [State], [PinCode], [ContactNo], [MobileNo], [PhoneNo], [LastModifiedBy], [LastModifiedDate], [ObsInd], [TINNumber]) VALUES (N'BI20160801221c51afedb486', N'om', N'Anil', N'', N'', N'Gangavathi', N'Gangavathi', N'Gangavathi', N'Karnataka', N'343454', N'9900990300', N'', N'', N'om\test', CAST(0x0000A65500C74F70 AS DateTime), N'N', NULL)
INSERT [dbo].[BuyerInfo] ([BuyerID], [CustID], [Name], [Street], [Street1], [Town], [City], [District], [State], [PinCode], [ContactNo], [MobileNo], [PhoneNo], [LastModifiedBy], [LastModifiedDate], [ObsInd], [TINNumber]) VALUES (N'BI2016080155275b7f285865', N'om', N'Madhu', N'', N'', N'Bly', N'Bly', N'Bly', N'Karnataka', N'', N'9900990300', N'', N'', N'om\test', CAST(0x0000A6550178A004 AS DateTime), N'N', NULL)
INSERT [dbo].[BuyerInfo] ([BuyerID], [CustID], [Name], [Street], [Street1], [Town], [City], [District], [State], [PinCode], [ContactNo], [MobileNo], [PhoneNo], [LastModifiedBy], [LastModifiedDate], [ObsInd], [TINNumber]) VALUES (N'BI20160809f897baf6347149', N'om', N'Ramesh', N'street1', N'Street2', N'Shikaripura', N'Shikaripura', N'Shimoga', N'Karnataka', N'577427', N'9900990300', N'', N'', N'om\test', CAST(0x0000A65D012F690C AS DateTime), N'N', N'0209342344')
/****** Object:  Table [dbo].[CustTrailUsage]    Script Date: 08/10/2016 11:42:07 ******/
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
/****** Object:  Table [dbo].[CustomerPayment]    Script Date: 08/10/2016 11:42:07 ******/
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
/****** Object:  Table [dbo].[CustomerPartPayDetails]    Script Date: 08/10/2016 11:42:07 ******/
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
/****** Object:  Table [dbo].[CustomerAddressInfo]    Script Date: 08/10/2016 11:42:07 ******/
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
	[PhoneNo] [nvarchar](30) NULL,
	[LastModifiedBy] [nvarchar](50) NOT NULL,
	[LastModifiedDate] [datetime] NOT NULL,
	[ObsInd] [char](1) NOT NULL,
	[TINNumber] [nvarchar](30) NOT NULL,
	[MillName] [varchar](100) NOT NULL,
 CONSTRAINT [PK_CustomerAddressInfo] PRIMARY KEY CLUSTERED 
(
	[CustAdrsID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[CustomerAddressInfo] ([CustAdrsID], [CustID], [Street1], [Street2], [Town], [City], [District], [State], [Pincode], [ContactNo], [MobileNo], [PhoneNo], [LastModifiedBy], [LastModifiedDate], [ObsInd], [TINNumber], [MillName]) VALUES (N'CSA201607280e5ad9449110e1', N'om', N'Main2', NULL, N'Bellary', N'Bellary', N'Bellary', N'Karnataka', 583101, N'7834223459', N'', N'', N'om\test', CAST(0x0000A6560179880C AS DateTime), N'N', N'234234323', N'Sai Pawan Traders')
/****** Object:  Table [dbo].[CustomerActivation]    Script Date: 08/10/2016 11:42:07 ******/
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
/****** Object:  Table [dbo].[MBagType]    Script Date: 08/10/2016 11:42:07 ******/
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
INSERT [dbo].[MBagType] ([BagTypeID], [BagType], [LastModifiedBy], [LastModifiedDate], [ObsInd], [CustID]) VALUES (N'BT201607193c111c0a32c55a', N'Rice', N'om\test', CAST(0x0000A64800ACD67C AS DateTime), N'N', N'om')
/****** Object:  StoredProcedure [Audit].[pAutoAuditSetTriggerStateAll]    Script Date: 08/10/2016 11:42:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [Audit].[pAutoAuditSetTriggerStateAll]
	(
	@InsertEnabledFlag BIT = 1,	-- State for Insert Trigger: 1 = enabled, 0 = disabled
	@UpdateEnabledFlag BIT = 1,	-- State for Update Trigger: 1 = enabled, 0 = disabled
	@DeleteEnabledFlag BIT = 1	-- State for Delete Trigger: 1 = enabled, 0 = disabled
	)
AS 

-- Created for AutoAudit Version 3.30a
-- created by Paul Nielsen and John Sigouin
-- www.SQLServerBible.com
-- AutoAudit.codeplex.com
-- This SP is used to enable/disable AutoAudit triggers at the SQL Server level for all tables that are setup with AutoAudit.

SET NoCount ON 

--get [AuditSettings] 
DECLARE @AuditSchema VARCHAR(50)
SELECT @AuditSchema = [SettingValue] from [AuditSettings] where [SettingName] = 'AuditSchema'

DECLARE 
   @TableName sysname, 
   @SchemaName sysname, 
   @SQL NVARCHAR(max)

--save the list or tables to a temp table to prevent a cursor issue
SELECT	SchemaName, TableName
INTO	#Tables
FROM	AuditBaseTables
EXCEPT
SELECT	SchemaName, TableName
FROM	AuditAllExclusions

-- for each table
-- 1
DECLARE cTables CURSOR FAST_FORWARD READ_ONLY
  FOR  SELECT SchemaName, TableName 
			  from #Tables
       INTERSECT
       SELECT Schema_Name([schema_id]), [name] as TableName
       FROM sys.objects where type = 'U'
--2 
OPEN cTables
--3 
FETCH cTables INTO @SchemaName, @TableName   -- prime the cursor
WHILE @@Fetch_Status = 0 
  BEGIN
		SET @SQL = 'EXEC ' + quotename(@AuditSchema) + '.pAutoAuditSetTriggerState ''' + @SchemaName + ''', ''' + @TableName + ''', '
			+ cast(@InsertEnabledFlag as varchar(1)) + ', '
			+ cast(@UpdateEnabledFlag as varchar(1)) + ', '
			+ cast(@DeleteEnabledFlag as varchar(1)) + ';'
		EXEC (@SQL)
      FETCH cTables INTO @SchemaName, @TableName   -- fetch next
  END
-- 4  
CLOSE cTables
-- 5
DEALLOCATE cTables

DROP TABLE #Tables

RETURN
GO
/****** Object:  StoredProcedure [Audit].[pAutoAuditSetTriggerState]    Script Date: 08/10/2016 11:42:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROC [Audit].[pAutoAuditSetTriggerState]
	(
	@SchemaName sysname = 'dbo',  --this is the default schema name for the tables getting AutoAudit added
	@TableName sysname,
	@InsertEnabledFlag BIT = 1,	-- State for Insert Trigger: 1 = enabled, 0 = disabled
	@UpdateEnabledFlag BIT = 1,	-- State for Update Trigger: 1 = enabled, 0 = disabled
	@DeleteEnabledFlag BIT = 1	-- State for Delete Trigger: 1 = enabled, 0 = disabled
	) with recompile

AS 

-- Created for AutoAudit Version 3.30a
-- created by Paul Nielsen and John Sigouin
-- www.SQLServerBible.com
-- AutoAudit.codeplex.com
-- This SP is used to enable/disable AutoAudit triggers at the SQL Server level for the specified table.

SET NoCount ON
 
DECLARE @SQL NVARCHAR(max),
		@AuditSchema VARCHAR(50),
		@AutopAutoAuditRebuildCurrentSetting varchar(100)

--get @AuditSchema 
SELECT @AuditSchema = [SettingValue] from [AuditSettings] where [SettingName] = 'AuditSchema'

--get [AuditSettings] - Launch pAutoAuditRebuild from SchemaAuditDDLTrigger Enabled Flag
Select	@SQL = 'SELECT @SettingValue = [SettingValue] from ' + quotename(@AuditSchema) + '.[AuditSettings] where [SettingName] = ''Launch pAutoAuditRebuild from SchemaAuditDDLTrigger Enabled Flag'''
EXEC sp_executesql @SQL, N'@SettingValue varchar(100) OUTPUT', @AutopAutoAuditRebuildCurrentSetting OUTPUT

--disable auto trigger rebuild on schema changes
--set [AuditSettings] = 0 - Launch pAutoAuditRebuild from SchemaAuditDDLTrigger Enabled Flag
If @AutopAutoAuditRebuildCurrentSetting = 1
	BEGIN
		Select	@SQL = 'Update ' + quotename(@AuditSchema) + '.[AuditSettings] Set [SettingValue] = 0 where [SettingName] = ''Launch pAutoAuditRebuild from SchemaAuditDDLTrigger Enabled Flag'''
		EXEC (@SQL)
	END

--Set the Insert Trigger as requested
Select	@SQL = 'ALTER TABLE ' + quotename(@SchemaName) + '.' + quotename(@TableName) 
	+ Case when @InsertEnabledFlag = 1 then ' ENABLE TRIGGER ' else ' DISABLE TRIGGER ' END
	+ '[' + @TableName + '_Audit_Insert]'
EXEC (@SQL)

--Set the Update Trigger as requested
Select	@SQL = 'ALTER TABLE ' + quotename(@SchemaName) + '.' + quotename(@TableName) 
	+ Case when @UpdateEnabledFlag = 1 then ' ENABLE TRIGGER ' else ' DISABLE TRIGGER ' END
	+ '[' + @TableName + '_Audit_Update]'
EXEC (@SQL)

--Set the Delete Trigger as requested
Select	@SQL = 'ALTER TABLE ' + quotename(@SchemaName) + '.' + quotename(@TableName) 
	+ Case when @DeleteEnabledFlag = 1 then ' ENABLE TRIGGER ' else ' DISABLE TRIGGER ' END
	+ '[' + @TableName + '_Audit_Delete]'
EXEC (@SQL)

--reset auto trigger rebuild on schema changes
--set [AuditSettings] = 1 - Launch pAutoAuditRebuild from SchemaAuditDDLTrigger Enabled Flag
If @AutopAutoAuditRebuildCurrentSetting = 1
	BEGIN
		Select	@SQL = 'Update ' + quotename(@AuditSchema) + '.[AuditSettings] Set [SettingValue] = 1 where [SettingName] = ''Launch pAutoAuditRebuild from SchemaAuditDDLTrigger Enabled Flag'''
print (@SQL)
		EXEC (@SQL)
	END
GO
/****** Object:  StoredProcedure [Audit].[pAutoAuditRebuildAll]    Script Date: 08/10/2016 11:42:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [Audit].[pAutoAuditRebuildAll]

AS 

-- Created for AutoAudit Version 3.30a
-- created by Paul Nielsen and John Sigouin
-- www.SQLServerBible.com
-- AutoAudit.codeplex.com
-- This SP is used to rebuild AutoAudit triggers for ALL tables that are currently setup with AutoAudit based on the settings saved in the AuditBaseTables table.

SET NoCount ON 

--get [AuditSettings] 
DECLARE @AuditSchema VARCHAR(50)
SELECT @AuditSchema = [SettingValue] from [AuditSettings] where [SettingName] = 'AuditSchema'

DECLARE 
   @TableName sysname, 
   @SchemaName sysname, 
   @SQL NVARCHAR(max)

--save the list or tables to a temp table to prevent a cursor issue
SELECT	SchemaName, TableName
INTO	#Tables
FROM	AuditBaseTables
EXCEPT
SELECT	SchemaName, TableName
FROM	AuditAllExclusions

-- for each table
-- 1
DECLARE cTables CURSOR FAST_FORWARD READ_ONLY
  FOR  SELECT SchemaName, TableName 
			  from #Tables
       INTERSECT
       SELECT Schema_Name([schema_id]), [name] as TableName
       FROM sys.objects where type = 'U'
       Order by 1,2
--2 
OPEN cTables
--3 
FETCH cTables INTO @SchemaName, @TableName   -- prime the cursor
WHILE @@Fetch_Status = 0 
  BEGIN
		SET @SQL = 'EXEC ' + quotename(@AuditSchema) + '.pAutoAuditRebuild ''' + @SchemaName + ''', ''' + @TableName + ''''

		EXEC (@SQL)
      FETCH cTables INTO @SchemaName, @TableName   -- fetch next
  END
-- 4  
CLOSE cTables
-- 5
DEALLOCATE cTables

DROP TABLE #Tables

RETURN
GO
/****** Object:  StoredProcedure [Audit].[pAutoAuditRebuild]    Script Date: 08/10/2016 11:42:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [Audit].[pAutoAuditRebuild] (
   @SchemaName sysname = 'dbo',  --the schema of the table to rebuild
   @TableName sysname  --the tablename to rebuild
	) 
AS 

-- Created for AutoAudit Version 3.30a
-- created by Paul Nielsen and John Sigouin
-- www.SQLServerBible.com
-- AutoAudit.codeplex.com
-- This SP is used to rebuild AutoAudit triggers for the specified table based on the settings saved in the AuditBaseTables table.

SET NoCount ON

DECLARE
   @StrictUserContext	BIT,		-- 2.00 if 0 then permits DML setting of Created, CreatedBy, Modified, ModifiedBy
   @LogSQL				BIT,
   @BaseTableDDL		BIT,		-- 0 = don't add audit columns to base table, 1 = add audit columns to base table
   @LogInsert			TINYINT,	-- 0 = nothing, 1 = header only, 2 = header and detail
   @LogUpdate			TINYINT,	-- 0 = nothing, 1 = header only, 2 = header and detail
   @LogDelete			TINYINT,	-- 0 = nothing, 1 = header only, 2 = header and detail
   @ColumnNames			NVARCHAR(max),  --columns to include when logging details (@Log...=2). Default = '<All>'. Format: '[Col1],[Col2],...'
   @SQL					NVARCHAR(max)

--get [AuditSettings] 
DECLARE @AuditSchema VARCHAR(50)
SELECT @AuditSchema = [SettingValue] from [AuditSettings] where [SettingName] = 'AuditSchema'
   
--retrieve base table AutoAudit settings from AuditBaseTables table
SELECT	@StrictUserContext = StrictUserContext,
		@LogSQL = LogSQL,
		@BaseTableDDL = BaseTableDDL,
		@LogInsert = LogInsert,
		@LogUpdate = LogUpdate,
		@LogDelete = LogDelete,
		@ColumnNames = ColumnNames
FROM	[AuditBaseTables]
WHERE	[SchemaName] = @SchemaName
	AND	[TableName] = @TableName;

IF @@rowcount = 0
	BEGIN
		--RAISERROR ('INFO - AutoAudit cannot be rebuilt for table [%s].[%s] because it''s settings don''t exist in the AuditBaseTables table.',0,0,@SchemaName,@TableName);
		RETURN
	END
ELSE
	PRINT 'Rebuilding AutoAudit for table: ' + quotename(@SchemaName) + '.' + quotename(@TableName) 
	SET @SQL = 'EXEC ' + quotename(@AuditSchema) + '.pAutoAudit' + Char(13) + Char(10)
+ '			@SchemaName = ''' + @SchemaName + ''',' + Char(13) + Char(10)
+ '			@TableName = ''' + @TableName + ''',' + Char(13) + Char(10)
+ '			@StrictUserContext = ' + cast(@StrictUserContext as varchar) + ',' + Char(13) + Char(10)
+ '			@LogSQL = ' + cast(@LogSQL as varchar) + ',' + Char(13) + Char(10)
+ '			@BaseTableDDL = ' + cast(@BaseTableDDL as varchar) + ',' + Char(13) + Char(10)
+ '			@LogInsert = ' + cast(@LogInsert as varchar) + ',' + Char(13) + Char(10)
+ '			@LogUpdate = ' + cast(@LogUpdate as varchar) + ',' + Char(13) + Char(10)
+ '			@LogDelete = ' + cast(@LogDelete as varchar) + ',' + Char(13) + Char(10)
+ '			@ColumnNames = ''' + @ColumnNames + ''';' + Char(13) + Char(10)
EXEC (@SQL)
GO
/****** Object:  StoredProcedure [Audit].[pAutoAuditDropAll]    Script Date: 08/10/2016 11:42:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [Audit].[pAutoAuditDropAll]
   (
	@DropAuditTables bit=0,				--0 = don't drop audit tables, 1 = drop audit tables
										-- if @DropAuditTables=1 then @DropAuditViews,@DropBaseTableTriggers,
										-- @DropAuditSPs and @DropAuditDDLTriggers defaults to 1
	@DropAuditViews bit=0,				--0 = don't drop audit views, 1 = drop audit views
	@DropAuditSPs bit = 0,				--0 = don't drop audit SP's, 1 = drop audit SP's
	@DropAuditDDLTriggers bit = 0,		--0 = don't drop audit database DDL trigger, 1 = drop audit database DDL trigger
	@DropBaseTableDDLColumns bit = 0,	--0 = don't drop Base Table DDL Columns, 1 = drop  Base Table DDL Columns
	@DropBaseTableTriggers bit = 0,		--0 = don't drop audit triggers on tables, 1 = drop audit triggers on tables
	@DropBaseTableViews bit=0,			--0 = don't drop BaseTable views, 1 = drop BaseTable views
	@ConfirmAllDrop varchar(10) = 'no'	--Set to 'yes' to proceed
   )
AS 

-- Created for AutoAudit Version 3.30a
-- created by Paul Nielsen and John Sigouin
-- www.SQLServerBible.com
-- AutoAudit.codeplex.com
-- This SP is used to remove AutoAudit triggers for the all tables that are setup with AutoAudit.

If	@DropAuditTables = 0 and 
	@DropAuditViews = 0 and 
	@DropAuditSPs = 0 and 
	@DropAuditDDLTriggers = 0 and 
	@DropBaseTableDDLColumns = 0 and 
	@DropBaseTableTriggers = 0 and 
	@DropBaseTableViews = 0
		Begin
			Raiserror ('You MUST set the input parameters to identify which components of AutoAudit you want to drop.
	@DropAuditTables bit=0,				0 = don''t drop audit tables, 1 = drop audit tables
										    if @DropAuditTables=1 then @DropAuditViews,@DropBaseTableTriggers,
										       @DropAuditSPs and @DropAuditDDLTriggers default to 1
	@DropAuditViews bit=0,				0 = don''t drop audit views, 1 = drop audit views
	@DropAuditSPs bit = 0,				0 = don''t drop audit SP''s, 1 = drop audit SP''s
	@DropAuditDDLTriggers bit = 0,		0 = don''t drop audit database DDL trigger, 1 = drop audit database DDL trigger
	@DropBaseTableDDLColumns bit = 0,	0 = don''t drop Base Table DDL Columns, 1 = drop  Base Table DDL Columns
	@DropBaseTableTriggers bit = 0,		0 = don''t drop audit triggers on tables, 1 = drop audit triggers on tables
	@DropBaseTableViews bit=0,			0 = don''t drop BaseTable views, 1 = drop BaseTable views
	@ConfirmAllDrop varchar(10) = ''no''	Set to ''yes'' to proceed',16,0)
			return
		End
	
If LOWER(isnull(@ConfirmAllDrop, 'no')) <> 'yes'
	begin
			Raiserror ('Executing this SP completely removes some or all AutoAudit components from this database including the AutoAudit added DDL columns from the base tables.
If you are sure you want to do this, re-run the SP with parameter @ConfirmAllDrop = ''yes''.',16,0)
			return
	end

SET NoCount ON 

--get [AuditSettings] 
DECLARE @AuditSchema VARCHAR(50)
SELECT @AuditSchema = [SettingValue] from [AuditSettings] where [SettingName] = 'AuditSchema'

DECLARE 
   @TableName sysname, 
   @SchemaName sysname, 
   @SQL NVARCHAR(max)
   
--validate flags
If @DropAuditTables = 1
	SELECT	@DropAuditViews = 1,
			@DropAuditSPs = 1,
			@DropAuditDDLTriggers = 1,
			@DropBaseTableTriggers = 1,
			@DropBaseTableViews = 1

If @DropBaseTableDDLColumns = 1
	SELECT	@DropBaseTableTriggers = 1,
			@DropBaseTableViews = 1
	
-- remove Schema DDL trigger 
IF @DropAuditDDLTriggers = 1
	BEGIN
		Print 'Dropping SchemaAuditDDLTrigger'
		IF Exists(select * from sys.triggers where name = 'SchemaAuditDDLTrigger')
		  DROP TRIGGER SchemaAuditDDLTrigger ON Database
	END

---- remove AutoAudit SP
--IF @DropAuditSPs = 1
--	BEGIN
--		Print 'Dropping Audit SP''s'

--		-- remove pAutoAudit SP
--		SET @SQL = 'IF Object_id(''' + quotename(@AuditSchema) + '.pAutoAudit'') IS NOT NULL
--		  DROP PROC ' + quotename(@AuditSchema) + '.pAutoAudit'
--		EXEC(@SQL)

--		-- remove pAutoAuditAll SP
--		SET @SQL = 'IF Object_id(''' + quotename(@AuditSchema) + '.pAutoAuditAll'') IS NOT NULL
--		  DROP PROC ' + quotename(@AuditSchema) + '.pAutoAuditAll'
--		EXEC(@SQL)

--		-- remove pAutoAuditRebuild SP
--		SET @SQL = 'IF Object_id(''' + quotename(@AuditSchema) + '.pAutoAuditRebuild'') IS NOT NULL
--		  DROP PROC ' + quotename(@AuditSchema) + '.pAutoAuditRebuild'
--		EXEC(@SQL)

--		-- remove pAutoAuditRebuildAll SP
--		SET @SQL = 'IF Object_id(''' + quotename(@AuditSchema) + '.pAutoAuditRebuildAll'') IS NOT NULL
--		  DROP PROC ' + quotename(@AuditSchema) + '.pAutoAuditRebuildAll'
--		EXEC(@SQL)

--		-- remove pAutoAuditSetTriggerState SP
--		SET @SQL = 'IF Object_id(''' + quotename(@AuditSchema) + '.pAutoAuditSetTriggerState'') IS NOT NULL
--		  DROP PROC ' + quotename(@AuditSchema) + '.pAutoAuditSetTriggerState'
--		EXEC(@SQL)

--		-- remove pAutoAuditSetTriggerStateAll SP
--		SET @SQL = 'IF Object_id(''' + quotename(@AuditSchema) + '.pAutoAuditSetTriggerStateAll'') IS NOT NULL
--		  DROP PROC ' + quotename(@AuditSchema) + '.pAutoAuditSetTriggerStateAll'
--		EXEC(@SQL)

--		-- remove pAutoAuditArchive SP
--		SET @SQL = 'IF Object_id(''' + quotename(@AuditSchema) + '.pAutoAuditArchive'') IS NOT NULL
--		  DROP PROC ' + quotename(@AuditSchema) + '.pAutoAuditArchive'
--		EXEC(@SQL)
--	END

---- remove Audit views
IF @DropAuditViews = 1
	BEGIN
		Print 'Dropping vAudit View'
		SET @SQL = 'IF Object_id(''' + quotename(@AuditSchema) + '.vAudit'') IS NOT NULL
		  DROP VIEW ' + quotename(@AuditSchema) + '.vAudit'
		EXEC(@SQL)

		Print 'Dropping vAuditAll View'
		SET @SQL = 'IF Object_id(''' + quotename(@AuditSchema) + '.vAuditAll'') IS NOT NULL
		  DROP VIEW ' + quotename(@AuditSchema) + '.vAuditAll'
		EXEC(@SQL)

		Print 'Dropping vAuditArchive View'
		SET @SQL = 'IF Object_id(''' + quotename(@AuditSchema) + '.vAuditArchive'') IS NOT NULL
		  DROP VIEW ' + quotename(@AuditSchema) + '.vAuditArchive'
		EXEC(@SQL)

		Print 'Dropping vAuditHeaderAll View'
		SET @SQL = 'IF Object_id(''' + quotename(@AuditSchema) + '.vAuditHeaderAll'') IS NOT NULL
		  DROP VIEW ' + quotename(@AuditSchema) + '.vAuditHeaderAll'
		EXEC(@SQL)

		Print 'Dropping vAuditDetailAll View'
		SET @SQL = 'IF Object_id(''' + quotename(@AuditSchema) + '.vAuditDetailAll'') IS NOT NULL
		  DROP VIEW ' + quotename(@AuditSchema) + '.vAuditDetailAll'
		EXEC(@SQL)

	END

IF @DropAuditTables = 1
	BEGIN
		Print 'Dropping Audit Tables'

		-- remove SchemaAudit Table
		SET @SQL = 'IF Object_id(''' + quotename(@AuditSchema) + '.SchemaAudit'') IS NOT NULL
		  DROP TABLE ' + quotename(@AuditSchema) + '.SchemaAudit'
		EXEC(@SQL)

		-- remove AuditDetail Table
		SET @SQL = 'IF Object_id(''' + quotename(@AuditSchema) + '.AuditDetail'') IS NOT NULL
		  DROP TABLE ' + quotename(@AuditSchema) + '.AuditDetail'
		EXEC(@SQL)

		-- remove AuditHeader Table
		SET @SQL = 'IF Object_id(''' + quotename(@AuditSchema) + '.AuditHeader'') IS NOT NULL
		  DROP TABLE ' + quotename(@AuditSchema) + '.AuditHeader'
		EXEC(@SQL)

		-- remove AuditAllExclusions Table
		SET @SQL = 'IF Object_id(''' + quotename(@AuditSchema) + '.AuditAllExclusions'') IS NOT NULL
		  DROP TABLE ' + quotename(@AuditSchema) + '.AuditAllExclusions'
		EXEC(@SQL)

		-- remove AuditDetailArchive Table
		SET @SQL = 'IF Object_id(''' + quotename(@AuditSchema) + '.AuditDetailArchive'') IS NOT NULL
		  DROP TABLE ' + quotename(@AuditSchema) + '.AuditDetailArchive'
		EXEC(@SQL)

		-- remove AuditHeaderArchive Table
		SET @SQL = 'IF Object_id(''' + quotename(@AuditSchema) + '.AuditHeaderArchive'') IS NOT NULL
		  DROP TABLE ' + quotename(@AuditSchema) + '.AuditHeaderArchive'
		EXEC(@SQL)

	END

-- for each table
DECLARE cTables CURSOR FAST_FORWARD READ_ONLY
  FOR  SELECT s.name, t.name 
			  from sys.tables t
				join sys.schemas s
				  on t.schema_id = s.schema_id
			 where t.name not in ('AuditHeader','AuditDetail','SchemaAudit'
									,'LegacyAudit_Migrated','LegacySchemaAudit_Migrated')

OPEN cTables

FETCH cTables INTO @SchemaName, @TableName   -- prime the cursor
WHILE @@Fetch_Status = 0 
  BEGIN
		SET @SQL = 'EXEC ' + quotename(@AuditSchema) + '.pAutoAuditDrop @SchemaName=''' + @SchemaName + '''' +
					', @TableName=''' + @TableName + '''' +
					', @DropBaseTableDDLColumns=' + cast(@DropBaseTableDDLColumns as varchar) + 
					', @DropBaseTableTriggers=' + cast(@DropBaseTableTriggers as varchar) + 
					', @DropBaseTableViews=' + cast(@DropBaseTableViews as varchar)

		EXEC (@SQL)
      FETCH cTables INTO @SchemaName, @TableName   -- fetch next
  END
CLOSE cTables
DEALLOCATE cTables

-- remove AutoAudit Tables
IF @DropAuditTables = 1
	BEGIN
		-- remove AuditSettings Table
		SET @SQL = 'IF Object_id(''' + quotename(@AuditSchema) + '.[AuditSettings]'') IS NOT NULL
		  DROP TABLE ' + quotename(@AuditSchema) + '.[AuditSettings]'
		EXEC(@SQL)

		-- remove AuditBaseTables Table
		SET @SQL = 'IF Object_id(''' + quotename(@AuditSchema) + '.[AuditBaseTables]'') IS NOT NULL
		  DROP TABLE ' + quotename(@AuditSchema) + '.[AuditBaseTables]'
		EXEC(@SQL)
	END

-- remove pAutoAuditDrop SP
IF @DropAuditSPs = 1
	BEGIN
		SET @SQL = 'IF Object_id(''' + quotename(@AuditSchema) + '.pAutoAuditDrop'') IS NOT NULL
		  DROP PROC ' + quotename(@AuditSchema) + '.pAutoAuditDrop'
		EXEC(@SQL)
	END

-- remove pAutoAuditDropAll SP
IF @DropAuditSPs = 1
	BEGIN
		SET @SQL = 'IF Object_id(''' + quotename(@AuditSchema) + '.pAutoAuditDropAll'') IS NOT NULL
		  DROP PROC ' + quotename(@AuditSchema) + '.pAutoAuditDropAll'
		EXEC(@SQL)
	END
GO
/****** Object:  StoredProcedure [Audit].[pAutoAuditDrop]    Script Date: 08/10/2016 11:42:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [Audit].[pAutoAuditDrop] (
	@SchemaName sysname  = 'dbo',
	@TableName sysname,
	@DropBaseTableDDLColumns bit = 1, --0 = don't drop Base Table DDL Columns, 1 = drop  Base Table DDL Columns
	@DropBaseTableTriggers bit = 1, --0 = don't drop audit triggers on tables, 1 = drop audit triggers on tables
									--if @DropBaseTableDDLColumns = 1 then @DropBaseTableTriggers and
									--@DropBaseTableViews default to 1
	@DropBaseTableViews bit=1	--0 = don't drop BaseTable views, 1 = drop BaseTable views
	) 
AS 

-- Created for AutoAudit Version 3.30a
-- created by Paul Nielsen and John Sigouin
-- www.SQLServerBible.com
-- AutoAudit.codeplex.com
-- This SP is used to remove AutoAudit triggers for the specified table.

SET NoCount ON

--get [AuditSettings] 
DECLARE @AuditSchema VARCHAR(50),
		@ViewSchema VARCHAR(50),
		@CreatedColumnName sysname,
		@CreatedByColumnName sysname,
		@ModifiedColumnName sysname,
		@ModifiedByColumnName sysname,
		@RowVersionColumnName sysname,
		@ViewPrefix varchar(10),
		@UDFPrefix varchar(10),
		@RowHistoryViewSuffix varchar(20),
		@DeletedViewSuffix varchar(20),
		@RowHistoryFunctionSuffix varchar(20),
		@TableRecoveryFunctionSuffix varchar(20)

SELECT @AuditSchema = [SettingValue] from [AuditSettings] where [SettingName] = 'AuditSchema'
SELECT @ViewSchema = [SettingValue] from [AuditSettings] where [SettingName] = 'Schema for _RowHistory and _Deleted objects'
If @ViewSchema = '<TableSchema>' Set @ViewSchema = @SchemaName

SELECT @ViewPrefix = isnull(ltrim(rtrim([SettingValue])),'v') from [AuditSettings] where [SettingName] = 'ViewPrefix'
SELECT @UDFPrefix = isnull(ltrim(rtrim([SettingValue])),'') from [AuditSettings] where [SettingName] = 'UDFPrefix'
SELECT @RowHistoryViewSuffix = isnull(ltrim(rtrim([SettingValue])),'_RowHistory') from [AuditSettings] where [SettingName] = 'RowHistoryViewSuffix'
SELECT @DeletedViewSuffix = isnull(ltrim(rtrim([SettingValue])),'_Deleted') from [AuditSettings] where [SettingName] = 'DeletedViewSuffix'
SELECT @RowHistoryFunctionSuffix = isnull(ltrim(rtrim([SettingValue])),'_RowHistory') from [AuditSettings] where [SettingName] = 'RowHistoryFunctionSuffix'
SELECT @TableRecoveryFunctionSuffix = isnull(ltrim(rtrim([SettingValue])),'_TableRecovery') from [AuditSettings] where [SettingName] = 'TableRecoveryFunctionSuffix'

SELECT @CreatedColumnName = isnull((SELECT [SettingValue] from [AuditSettings] where [SettingName] = 'CreatedColumnName'),'Created')
SELECT @CreatedByColumnName = isnull((SELECT [SettingValue] from [AuditSettings] where [SettingName] = 'CreatedByColumnName'),'CreatedBy')
SELECT @ModifiedColumnName = isnull((SELECT [SettingValue] from [AuditSettings] where [SettingName] = 'ModifiedColumnName'),'Modified')
SELECT @ModifiedByColumnName = isnull((SELECT [SettingValue] from [AuditSettings] where [SettingName] = 'ModifiedByColumnName'),'ModifiedBy')
SELECT @RowVersionColumnName = isnull((SELECT [SettingValue] from [AuditSettings] where [SettingName] = 'RowVersionColumnName'),'RowVersion')

DECLARE @SQL NVARCHAR(max)

--validate flags
If @DropBaseTableDDLColumns = 1
	Select	@DropBaseTableTriggers = 1,
			@DropBaseTableViews = 1

Print 'Dropping AutoAudit components from table: ' + quotename(@SchemaName) + '.' + quotename(@TableName)
IF @DropBaseTableDDLColumns = 1
	BEGIN
		set context_info 0x1;

		Print '	Dropping Table Audit DDL'
		-- drop default constraints
		If Exists (select * 
					 from sys.objects o 
					   join sys.schemas s on o.schema_id = s.schema_id   
					 where o.name = @TableName + '_' + @CreatedColumnName + '_df'  --no quotename here
					   and s.name = @SchemaName)
		  BEGIN 
			SET @SQL = 'ALTER TABLE ' + quotename(@SchemaName) + '.' + quotename(@TableName) + ' drop constraint ' + quotename(@TableName + '_' + @CreatedColumnName + '_df')
			EXEC (@SQL)
		  END

		If Exists (select * 
					 from sys.objects o 
					   join sys.schemas s on o.schema_id = s.schema_id   
					 where o.name = @TableName + '_' + @CreatedByColumnName + '_df'  --no quotename here
					   and s.name = @SchemaName)
		  BEGIN 
			SET @SQL = 'ALTER TABLE ' + quotename(@SchemaName) + '.' + quotename(@TableName) + ' drop constraint ' + quotename(@TableName + '_' + @CreatedByColumnName + '_df')
			EXEC (@SQL)
		  END

		If Exists (select * 
					 from sys.objects o 
					   join sys.schemas s on o.schema_id = s.schema_id   
					 where o.name = @TableName + '_' + @ModifiedColumnName + '_df' --no quotename here
					   and s.name = @SchemaName)
		  BEGIN 
			SET @SQL = 'ALTER TABLE ' + quotename(@SchemaName) + '.' + quotename(@TableName) + ' drop constraint ' + quotename(@TableName + '_' + @ModifiedColumnName + '_df')
			EXEC (@SQL)
		  END

		If Exists (select * 
					 from sys.objects o 
					   join sys.schemas s on o.schema_id = s.schema_id   
					 where o.name = @TableName + '_' + @ModifiedByColumnName + '_df'  --no quotename here
					   and s.name = @SchemaName)
		  BEGIN 
			SET @SQL = 'ALTER TABLE ' + quotename(@SchemaName) + '.' + quotename(@TableName) + ' drop constraint ' + quotename(@TableName + '_' + @ModifiedByColumnName + '_df')
			EXEC (@SQL)
		  END

		If Exists (select * 
					 from sys.objects o 
					   join sys.schemas s on o.schema_id = s.schema_id   
					 where o.name = @TableName + '_' + @RowVersionColumnName + '_df'  --no quotename here
					   and s.name = @SchemaName)
		  BEGIN 
			SET @SQL = 'ALTER TABLE ' + quotename(@SchemaName) + '.' + quotename(@TableName) + ' drop constraint ' + quotename(@TableName + '_' + @RowVersionColumnName + '_df')
			EXEC (@SQL)
		  END

		-- drop Created column 
		IF exists (select *
					  from sys.tables t
						join sys.schemas s
						  on s.schema_id = t.schema_id
						join sys.columns c
						  on t.object_id = c.object_id
					  where  t.name = @TableName AND s.name = @SchemaName and c.name = @CreatedColumnName)
		  BEGIN
			SET @SQL = 'ALTER TABLE ' + quotename(@SchemaName) + '.' + quotename(@TableName) + ' DROP COLUMN ' + @CreatedColumnName
			EXEC (@SQL)
		  END

		-- drop CreatedBy column 
		IF exists (select *
					  from sys.tables t
						join sys.schemas s
						  on s.schema_id = t.schema_id
						join sys.columns c
						  on t.object_id = c.object_id
					  where  t.name = @TableName AND s.name = @SchemaName and c.name = @CreatedByColumnName)
		  BEGIN
			SET @SQL = 'ALTER TABLE ' + quotename(@SchemaName) + '.' + quotename(@TableName) + ' DROP COLUMN ' + @CreatedByColumnName
			EXEC (@SQL)
		  END

		-- drop Modified column 
		IF exists( select *
					  from sys.tables t
						join sys.schemas s
						  on s.schema_id = t.schema_id
						join sys.columns c
						  on t.object_id = c.object_id
					  where  t.name = @TableName AND s.name = @SchemaName and c.name = @ModifiedColumnName)
		  BEGIN   
			SET @SQL = 'ALTER TABLE ' + quotename(@SchemaName) + '.' + quotename(@TableName) + ' DROP COLUMN ' + @ModifiedColumnName
			EXEC (@SQL)
		  END

		-- drop ModifiedBy column 
		IF exists( select *
					  from sys.tables t
						join sys.schemas s
						  on s.schema_id = t.schema_id
						join sys.columns c
						  on t.object_id = c.object_id
					  where  t.name = @TableName AND s.name = @SchemaName and c.name = @ModifiedByColumnName)
		  BEGIN   
			SET @SQL = 'ALTER TABLE ' + quotename(@SchemaName) + '.' + quotename(@TableName) + ' DROP COLUMN ' + @ModifiedByColumnName
			EXEC (@SQL)
		  END

		-- drop RowVersion column 
		IF exists( select *
					  from sys.tables t
						join sys.schemas s
						  on s.schema_id = t.schema_id
						join sys.columns c
						  on t.object_id = c.object_id
					  where  t.name = @TableName AND s.name = @SchemaName and c.name = @RowVersionColumnName)
		  BEGIN   
			SET @SQL = 'ALTER TABLE ' + quotename(@SchemaName) + '.' + quotename(@TableName) + ' DROP COLUMN ' + @RowVersionColumnName + ''
			EXEC (@SQL)
		  END

	--reset the context info to stop bypassing ddl trigger
	Set context_info 0x0;

	END --IF @DropBaseTableDDLColumns = 1

IF @DropBaseTableTriggers = 1
	BEGIN
		Print '	Dropping Table Audit Triggers'
		-- drop existing insert trigger
		SET @SQL = 'If EXISTS (Select * from sys.objects o join sys.schemas s on o.schema_id = s.schema_id  '
			   + ' where s.name = ''' + @SchemaName + ''''
			   + '   and o.name = ''' + @TableName + '_Audit_Insert' + ''' )'
			   + ' DROP TRIGGER ' + quotename(@SchemaName) + '.' + quotename(@TableName + '_Audit_Insert')
		EXEC (@SQL)

		-- drop existing update trigger
		SET @SQL = 'If EXISTS (Select * from sys.objects o join sys.schemas s on o.schema_id = s.schema_id  '
			   + ' where s.name = ''' + @SchemaName + ''''
			   + '   and o.name = ''' + @TableName + '_Audit_Update' + ''' )'
			   + ' DROP TRIGGER ' + quotename(@SchemaName) + '.' + quotename(@TableName + '_Audit_Update')
		EXEC (@SQL)

		-- drop existing delete trigger
		SET @SQL = 'If EXISTS (Select * from sys.objects o join sys.schemas s on o.schema_id = s.schema_id  '
			   + ' where s.name = ''' + @SchemaName + ''''
			   + '   and o.name = ''' + @TableName + '_Audit_Delete' + ''' )'
			   + ' DROP TRIGGER ' + quotename(@SchemaName) + '.' + quotename(@TableName + '_Audit_Delete')
		EXEC (@SQL)

		--Delete table's entry from the AuditBasetables table
		SET @SQL = 'DELETE from ' + quotename(@AuditSchema) + '.AuditBaseTables '
			   + ' where SchemaName = ''' + @SchemaName + ''''
			   + '   and TableName = ''' + @TableName + ''''
		EXEC (@SQL)
	END

IF @DropBaseTableViews = 1
	BEGIN
		Print '	Dropping Table Audit Views'
		-- drop existing _Deleted view
		SET @SQL = 'If EXISTS (Select * from sys.objects o join sys.schemas s on o.schema_id = s.schema_id  '
			   + ' where s.name = ''' + @ViewSchema + ''''
			   + '   and o.name = ''' + @ViewPrefix + @TableName + @DeletedViewSuffix + ''' )'
			   + ' DROP VIEW ' + quotename(@ViewSchema) + '.' + quotename(@ViewPrefix + @TableName + @DeletedViewSuffix)
		EXEC (@SQL)

		-- drop existing _RowHistory view
		SET @SQL = 'If EXISTS (Select * from sys.objects o join sys.schemas s on o.schema_id = s.schema_id  '
			   + ' where s.name = ''' + @ViewSchema + ''''
			   + '   and o.name = ''' + @ViewPrefix + @TableName + @RowHistoryViewSuffix + ''' )'
			   + ' DROP VIEW ' + quotename(@ViewSchema) + '.' + quotename(@ViewPrefix + @TableName + @RowHistoryViewSuffix)
		EXEC (@SQL)

		-- drop existing _RowHistory UDF
		SET @SQL = 'If EXISTS (Select * from sys.objects o join sys.schemas s on o.schema_id = s.schema_id  '
			   + ' where s.name = ''' + @ViewSchema + ''''
			   + '   and o.name = ''' + @UDFPrefix + @TableName + @RowHistoryFunctionSuffix + ''' )'
			   + ' DROP FUNCTION ' + quotename(@ViewSchema) + '.' + quotename(@UDFPrefix + @TableName + @RowHistoryFunctionSuffix)
		EXEC (@SQL)

		-- drop existing _TableRecovery UDF
		SET @SQL = 'If EXISTS (Select * from sys.objects o join sys.schemas s on o.schema_id = s.schema_id  '
			   + ' where s.name = ''' + @ViewSchema + ''''
			   + '   and o.name = ''' + @UDFPrefix + @TableName + @TableRecoveryFunctionSuffix + ''' )'
			   + ' DROP FUNCTION ' + quotename(@ViewSchema) + '.' + quotename(@UDFPrefix + @TableName + @TableRecoveryFunctionSuffix)
		EXEC (@SQL)
	END

print ''
GO
/****** Object:  Table [dbo].[EmployeeDetails]    Script Date: 08/10/2016 11:42:07 ******/
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
/****** Object:  Table [dbo].[MEmployeeDesignation]    Script Date: 08/10/2016 11:42:07 ******/
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
/****** Object:  Table [dbo].[MediatorInfo]    Script Date: 08/10/2016 11:42:07 ******/
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
INSERT [dbo].[MediatorInfo] ([MediatorID], [CustID], [Name], [Street], [Street1], [Town], [City], [District], [State], [PinCode], [ContactNo], [MobileNo], [PhoneNo], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (N'BI20160810c67423da75c367', N'om', N'Mediator', N'l', N'klkj', N'kkjl', N'lkjlkjl', N'ljkllj', N'kljljlj', N'123456', N'9087445523', N'3242423423', N'786238648628', N'om\test', CAST(0x0000A65E00B86DAC AS DateTime), N'N')
/****** Object:  Table [dbo].[MDrierTypeDetails]    Script Date: 08/10/2016 11:42:07 ******/
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
/****** Object:  Table [dbo].[MWeightDetails]    Script Date: 08/10/2016 11:42:07 ******/
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
/****** Object:  Table [dbo].[MUnitsType]    Script Date: 08/10/2016 11:42:07 ******/
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
INSERT [dbo].[MUnitsType] ([UnitsTypeID], [CustID], [LastModifiedBy], [LastModifiedDate], [ObsInd], [UnitsType]) VALUES (N'BT2016071938e099fbd69545', N'om', N'om\test', CAST(0x0000A64800ACBB88 AS DateTime), N'N', N'25')
INSERT [dbo].[MUnitsType] ([UnitsTypeID], [CustID], [LastModifiedBy], [LastModifiedDate], [ObsInd], [UnitsType]) VALUES (N'BT201607198b4fe854818fdc', N'om', N'om\test', CAST(0x0000A64800ACA9F4 AS DateTime), N'N', N'100')
INSERT [dbo].[MUnitsType] ([UnitsTypeID], [CustID], [LastModifiedBy], [LastModifiedDate], [ObsInd], [UnitsType]) VALUES (N'BT20160719a9261a90939b37', N'om', N'om\test', CAST(0x0000A64800ACAFD0 AS DateTime), N'N', N'75')
INSERT [dbo].[MUnitsType] ([UnitsTypeID], [CustID], [LastModifiedBy], [LastModifiedDate], [ObsInd], [UnitsType]) VALUES (N'BT20160719cb2d5a39f9f51c', N'om', N'om\test', CAST(0x0000A64800ACB354 AS DateTime), N'N', N'50')
/****** Object:  Table [dbo].[MSalaryType]    Script Date: 08/10/2016 11:42:07 ******/
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
/****** Object:  Table [dbo].[MJobWork]    Script Date: 08/10/2016 11:42:07 ******/
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
/****** Object:  Table [dbo].[MGodownDetails]    Script Date: 08/10/2016 11:42:07 ******/
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
INSERT [dbo].[MGodownDetails] ([MGodownID], [CustID], [Place], [LastModifiedBy], [LastModifiedDate], [ObsInd], [Name]) VALUES (N'GD20160719d07e9481287348', N'om', NULL, N'om\test', CAST(0x0000A64800ACC164 AS DateTime), N'N', N'G1')
INSERT [dbo].[MGodownDetails] ([MGodownID], [CustID], [Place], [LastModifiedBy], [LastModifiedDate], [ObsInd], [Name]) VALUES (N'GD201607207ef07fcc128e41', N'om', NULL, N'om\test', CAST(0x0000A64900A94214 AS DateTime), N'N', N'G2')
/****** Object:  Table [dbo].[MExpenseType]    Script Date: 08/10/2016 11:42:07 ******/
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
INSERT [dbo].[MExpenseType] ([ExpenseID], [CustID], [ExpenseType], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (N'ET201608021379a287646891', N'om', N'Rice Comission', N'om\test', CAST(0x0000A65600F9DECC AS DateTime), N'N')
INSERT [dbo].[MExpenseType] ([ExpenseID], [CustID], [ExpenseType], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (N'ET201608021a8a3a00618833', N'om', N'Other Expenses', N'om\test', CAST(0x0000A65600F9EBB0 AS DateTime), N'N')
INSERT [dbo].[MExpenseType] ([ExpenseID], [CustID], [ExpenseType], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (N'ET201608027f4b51e772ad05', N'om', N'Paddy Comission', N'om\test', CAST(0x0000A65600F9D56C AS DateTime), N'N')
INSERT [dbo].[MExpenseType] ([ExpenseID], [CustID], [ExpenseType], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (N'ET20160802827b25c7dab631', N'om', N'Transport Expenses', N'om\test', CAST(0x0000A65600F9E4A8 AS DateTime), N'N')
/****** Object:  Table [dbo].[MessageInfo]    Script Date: 08/10/2016 11:42:07 ******/
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
/****** Object:  Table [dbo].[MRiceProductionType]    Script Date: 08/10/2016 11:42:07 ******/
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
INSERT [dbo].[MRiceProductionType] ([MRiceProdTypeID], [CustID], [RiceType], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (N'RP201607196cda0aa0548d47', N'om', N'Sona', N'om\test', CAST(0x0000A64800ACDEB0 AS DateTime), N'N')
/****** Object:  Table [dbo].[MRiceBrandDetails]    Script Date: 08/10/2016 11:42:07 ******/
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
INSERT [dbo].[MRiceBrandDetails] ([MRiceBrandID], [CustID], [Name], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (N'RB20160719937050a760653c', N'om', N'Bullet', N'om\test', CAST(0x0000A64800AD08E0 AS DateTime), N'N')
/****** Object:  Table [dbo].[MPaddyType]    Script Date: 08/10/2016 11:42:07 ******/
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
INSERT [dbo].[MPaddyType] ([PaddyTypeID], [CustID], [Name], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (N'PT20160719a18cae0556486f', N'om', N'Sona', N'om\test', CAST(0x0000A64800ACA418 AS DateTime), N'N')
INSERT [dbo].[MPaddyType] ([PaddyTypeID], [CustID], [Name], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (N'PT20160720c9f964aa2f5070', N'om', N'Jaya', N'om\test', CAST(0x0000A64900A8F96C AS DateTime), N'N')
INSERT [dbo].[MPaddyType] ([PaddyTypeID], [CustID], [Name], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (N'PT201607215427c07a965920', N'om', N'xyz', N'om\test', CAST(0x0000A64A008B20CC AS DateTime), N'N')
/****** Object:  Table [dbo].[MoneyTransaction]    Script Date: 08/10/2016 11:42:07 ******/
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
/****** Object:  Table [dbo].[MLotDetails]    Script Date: 08/10/2016 11:42:07 ******/
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
INSERT [dbo].[MLotDetails] ([MLotID], [CustID], [LotName], [LastModifiedBy], [LastModifiedDate], [ObsInd], [MGodownID]) VALUES (N'LT20160719d5ae52648d08f5', N'om', N'G1L1', N'om\test', CAST(0x0000A64800ACCAC4 AS DateTime), N'N', N'GD20160719d07e9481287348')
INSERT [dbo].[MLotDetails] ([MLotID], [CustID], [LotName], [LastModifiedBy], [LastModifiedDate], [ObsInd], [MGodownID]) VALUES (N'LT201607206e53227c7842aa', N'om', N'G2L1', N'om\test', CAST(0x0000A64900A94CA0 AS DateTime), N'N', N'GD201607207ef07fcc128e41')
/****** Object:  Table [dbo].[EmployeeSalary]    Script Date: 08/10/2016 11:42:07 ******/
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
/****** Object:  Table [dbo].[DustStockInfo]    Script Date: 08/10/2016 11:42:07 ******/
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
INSERT [dbo].[DustStockInfo] ([DustStockID], [CustID], [UnitsTypeID], [TotalBags], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (N'HTD2016071921420271aea18e', N'om', N'BT201607198b4fe854818fdc', 1, N'om\test', CAST(0x0000A6480149F13C AS DateTime), N'N')
INSERT [dbo].[DustStockInfo] ([DustStockID], [CustID], [UnitsTypeID], [TotalBags], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (N'HTD2016071951c5cbdd2e03ef', N'om', N'BT201607198b4fe854818fdc', 2, N'om\test', CAST(0x0000A64800B5EB7C AS DateTime), N'N')
INSERT [dbo].[DustStockInfo] ([DustStockID], [CustID], [UnitsTypeID], [TotalBags], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (N'HTD20160719f56cb7c5c93e38', N'om', N'BT201607198b4fe854818fdc', 2, N'om\test', CAST(0x0000A64800BE1D24 AS DateTime), N'N')
INSERT [dbo].[DustStockInfo] ([DustStockID], [CustID], [UnitsTypeID], [TotalBags], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (N'HTD2016080964411ba1e09d09', N'om', N'BT201607198b4fe854818fdc', 2, N'om\test', CAST(0x0000A65D0140B0E0 AS DateTime), N'N')
/****** Object:  Table [dbo].[ExpenseTransaction]    Script Date: 08/10/2016 11:42:07 ******/
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
INSERT [dbo].[ExpenseTransaction] ([ExpenseTransID], [CustID], [ExpenseID], [Name], [Amount], [Reason], [LastModifiedBy], [LastModifiedDate], [ObsInd], [PayDate]) VALUES (N'ExT20160802ac973333ab6f54', N'om', N'ET201608021379a287646891', N'Ramesh', 5000.0000, N'other', N'om\test', CAST(0x0000A65600FA1004 AS DateTime), N'N', CAST(0x0000A5A600F9F894 AS DateTime))
/****** Object:  View [dbo].[vRentalHulling_RowHistory]    Script Date: 08/10/2016 11:42:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vRentalHulling_RowHistory]
AS 

 -- generated by AutoAudit Version 3.30a on Jul 20 2016 10:07AM
 -- created by Paul Nielsen and John Sigouin 
 -- www.SQLServerBible.com 
 -- AutoAudit.codeplex.com 
 -- This view returns historical record entries for the referenced table.

SELECT
		PivotData.AuditDate
		,PivotData.Operation
		,PivotData.HRowVersion AS [RowVersion]
		,PivotData.PrimaryKey AS [RentalHulingID] 

		,PivotData.[CustID]
		,PivotData.[TotalBags]
		,PivotData.[Price]
		,'Active' AS ViewScope
		,RowHistorySource
		,[SysUser] 
		,[Application] 
		,[SQLStatement] 
FROM 	(SELECT		AH.AuditHeaderID 
					,AH.PrimaryKey 
					,AH.PrimaryKey2 
					,AH.PrimaryKey3 
					,AH.PrimaryKey4 
					,AH.PrimaryKey5 
					,AH.AuditDate 
					,AH.Operation 
					,AH.[RowVersion] AS HRowVersion 
					,SUBSTRING(AD.ColumnName,2,LEN(AD.ColumnName)-2) AS ColumnName 
					,ISNULL(AD.NewValue,AD.OldValue) AS NewValue
					,'Active' AS RowHistorySource
					,AH.[SysUser] 
					,AH.[Application] 
					,AH.[SQLStatement] 
		FROM		[Audit].[AuditHeader] AS AH
		LEFT JOIN	[Audit].[AuditDetail] AS AD
			ON		AH.AuditHeaderID = AD.AuditHeaderID
		WHERE		AH.TableName='[dbo].[RentalHulling]'
					) AS AD
		PIVOT		(MAX (NewValue)
			FOR		ColumnName IN
					(
					[RentalHulingID]
					,[CustID]
					,[TotalBags]
					,[Price]
					)
					) AS PivotData
GO
/****** Object:  View [dbo].[vRentalHulling_Deleted]    Script Date: 08/10/2016 11:42:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vRentalHulling_Deleted]
AS 

 -- generated by AutoAudit Version 3.30a on Jul 20 2016 10:07AM
 -- created by Paul Nielsen and John Sigouin 
 -- www.SQLServerBible.com 
 -- AutoAudit.codeplex.com 
 -- This view returns details about the rows that have been deleted in the referenced table.

WITH	MostRecentDeletes 
AS 
		(SELECT		PrimaryKey, PrimaryKey2, PrimaryKey3, PrimaryKey4, PrimaryKey5, 
					max([RowVersion]) AS [RowVersion] 
		FROM		[Audit].AuditHeader 
		WHERE		TableName = '[dbo].[RentalHulling]' 
			AND		Operation = 'd' 
		GROUP BY	PrimaryKey, PrimaryKey2, PrimaryKey3, PrimaryKey4, PrimaryKey5) 
SELECT
		PivotData.PrimaryKey as [RentalHulingID]
		,PivotData.[CustID]
		,PivotData.[TotalBags]
		,PivotData.[Price]
		,SysUser as DeletedBy 
		,CASE WHEN mrd.[RowVersion] = PivotData.HRowVersion then 1 else 0 end AS MostRecentDeleteFlag
		,'Active' AS ViewScope
		,RowHistorySource
FROM 	(SELECT		AH.AuditHeaderID, 
					AH.PrimaryKey, 
					AH.PrimaryKey2, 
					AH.PrimaryKey3, 
					AH.PrimaryKey4, 
					AH.PrimaryKey5, 
					AH.[RowVersion] AS HRowVersion, 
					AH.[SysUser] AS SysUser, 
					SUBSTRING(AD.ColumnName,2,LEN(AD.ColumnName)-2) AS ColumnName, 
					ISNULL(AD.NewValue,AD.OldValue) AS NewValue
					,'Active' AS RowHistorySource
		FROM		[Audit].[AuditHeader] AS AH
		LEFT JOIN	[Audit].[AuditDetail] AS AD
			ON		AH.AuditHeaderID = AD.AuditHeaderID
		WHERE		AH.TableName='[dbo].[RentalHulling]'
			AND		AH.Operation='d') AS AD
		PIVOT		(MAX (NewValue)
			FOR		ColumnName IN
					(
					[RentalHulingID]
					,[CustID]
					,[TotalBags]
					,[Price]
					)
					) AS PivotData
LEFT JOIN 	MostRecentDeletes mrd
	ON 		PivotData.PrimaryKey = mrd.PrimaryKey
	AND 	isnull(PivotData.PrimaryKey2,'') = isnull(mrd.PrimaryKey2,'')
	AND 	isnull(PivotData.PrimaryKey3,'') = isnull(mrd.PrimaryKey3,'')
	AND 	isnull(PivotData.PrimaryKey4,'') = isnull(mrd.PrimaryKey4,'')
	AND 	isnull(PivotData.PrimaryKey5,'') = isnull(mrd.PrimaryKey5,'')
	AND 	PivotData.HRowVersion = mrd.[RowVersion]
GO
/****** Object:  View [dbo].[vProductSellingInfo_RowHistory]    Script Date: 08/10/2016 11:42:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vProductSellingInfo_RowHistory]
AS 

 -- generated by AutoAudit Version 3.30a on Jul 20 2016 10:07AM
 -- created by Paul Nielsen and John Sigouin 
 -- www.SQLServerBible.com 
 -- AutoAudit.codeplex.com 
 -- This view returns historical record entries for the referenced table.

SELECT
		PivotData.AuditDate
		,PivotData.Operation
		,PivotData.HRowVersion AS [RowVersion]
		,PivotData.PrimaryKey AS [ProductID] 

		,PivotData.[CustID]
		,PivotData.[Price]
		,PivotData.[TotalBags]
		,'Active' AS ViewScope
		,RowHistorySource
		,[SysUser] 
		,[Application] 
		,[SQLStatement] 
FROM 	(SELECT		AH.AuditHeaderID 
					,AH.PrimaryKey 
					,AH.PrimaryKey2 
					,AH.PrimaryKey3 
					,AH.PrimaryKey4 
					,AH.PrimaryKey5 
					,AH.AuditDate 
					,AH.Operation 
					,AH.[RowVersion] AS HRowVersion 
					,SUBSTRING(AD.ColumnName,2,LEN(AD.ColumnName)-2) AS ColumnName 
					,ISNULL(AD.NewValue,AD.OldValue) AS NewValue
					,'Active' AS RowHistorySource
					,AH.[SysUser] 
					,AH.[Application] 
					,AH.[SQLStatement] 
		FROM		[Audit].[AuditHeader] AS AH
		LEFT JOIN	[Audit].[AuditDetail] AS AD
			ON		AH.AuditHeaderID = AD.AuditHeaderID
		WHERE		AH.TableName='[dbo].[ProductSellingInfo]'
					) AS AD
		PIVOT		(MAX (NewValue)
			FOR		ColumnName IN
					(
					[ProductID]
					,[CustID]
					,[Price]
					,[TotalBags]
					)
					) AS PivotData
GO
/****** Object:  View [dbo].[vProductSellingInfo_Deleted]    Script Date: 08/10/2016 11:42:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vProductSellingInfo_Deleted]
AS 

 -- generated by AutoAudit Version 3.30a on Jul 20 2016 10:07AM
 -- created by Paul Nielsen and John Sigouin 
 -- www.SQLServerBible.com 
 -- AutoAudit.codeplex.com 
 -- This view returns details about the rows that have been deleted in the referenced table.

WITH	MostRecentDeletes 
AS 
		(SELECT		PrimaryKey, PrimaryKey2, PrimaryKey3, PrimaryKey4, PrimaryKey5, 
					max([RowVersion]) AS [RowVersion] 
		FROM		[Audit].AuditHeader 
		WHERE		TableName = '[dbo].[ProductSellingInfo]' 
			AND		Operation = 'd' 
		GROUP BY	PrimaryKey, PrimaryKey2, PrimaryKey3, PrimaryKey4, PrimaryKey5) 
SELECT
		PivotData.PrimaryKey as [ProductID]
		,PivotData.[CustID]
		,PivotData.[Price]
		,PivotData.[TotalBags]
		,SysUser as DeletedBy 
		,CASE WHEN mrd.[RowVersion] = PivotData.HRowVersion then 1 else 0 end AS MostRecentDeleteFlag
		,'Active' AS ViewScope
		,RowHistorySource
FROM 	(SELECT		AH.AuditHeaderID, 
					AH.PrimaryKey, 
					AH.PrimaryKey2, 
					AH.PrimaryKey3, 
					AH.PrimaryKey4, 
					AH.PrimaryKey5, 
					AH.[RowVersion] AS HRowVersion, 
					AH.[SysUser] AS SysUser, 
					SUBSTRING(AD.ColumnName,2,LEN(AD.ColumnName)-2) AS ColumnName, 
					ISNULL(AD.NewValue,AD.OldValue) AS NewValue
					,'Active' AS RowHistorySource
		FROM		[Audit].[AuditHeader] AS AH
		LEFT JOIN	[Audit].[AuditDetail] AS AD
			ON		AH.AuditHeaderID = AD.AuditHeaderID
		WHERE		AH.TableName='[dbo].[ProductSellingInfo]'
			AND		AH.Operation='d') AS AD
		PIVOT		(MAX (NewValue)
			FOR		ColumnName IN
					(
					[ProductID]
					,[CustID]
					,[Price]
					,[TotalBags]
					)
					) AS PivotData
LEFT JOIN 	MostRecentDeletes mrd
	ON 		PivotData.PrimaryKey = mrd.PrimaryKey
	AND 	isnull(PivotData.PrimaryKey2,'') = isnull(mrd.PrimaryKey2,'')
	AND 	isnull(PivotData.PrimaryKey3,'') = isnull(mrd.PrimaryKey3,'')
	AND 	isnull(PivotData.PrimaryKey4,'') = isnull(mrd.PrimaryKey4,'')
	AND 	isnull(PivotData.PrimaryKey5,'') = isnull(mrd.PrimaryKey5,'')
	AND 	PivotData.HRowVersion = mrd.[RowVersion]
GO
/****** Object:  View [dbo].[vProductPaymentTransaction_RowHistory]    Script Date: 08/10/2016 11:42:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vProductPaymentTransaction_RowHistory]
AS 

 -- generated by AutoAudit Version 3.30a on Jul 20 2016 10:07AM
 -- created by Paul Nielsen and John Sigouin 
 -- www.SQLServerBible.com 
 -- AutoAudit.codeplex.com 
 -- This view returns historical record entries for the referenced table.

SELECT
		PivotData.AuditDate
		,PivotData.Operation
		,PivotData.HRowVersion AS [RowVersion]
		,PivotData.PrimaryKey AS [ProductPaymentTranID] 

		,PivotData.[CustID]
		,PivotData.[ReceivedAmount]
		,'Active' AS ViewScope
		,RowHistorySource
		,[SysUser] 
		,[Application] 
		,[SQLStatement] 
FROM 	(SELECT		AH.AuditHeaderID 
					,AH.PrimaryKey 
					,AH.PrimaryKey2 
					,AH.PrimaryKey3 
					,AH.PrimaryKey4 
					,AH.PrimaryKey5 
					,AH.AuditDate 
					,AH.Operation 
					,AH.[RowVersion] AS HRowVersion 
					,SUBSTRING(AD.ColumnName,2,LEN(AD.ColumnName)-2) AS ColumnName 
					,ISNULL(AD.NewValue,AD.OldValue) AS NewValue
					,'Active' AS RowHistorySource
					,AH.[SysUser] 
					,AH.[Application] 
					,AH.[SQLStatement] 
		FROM		[Audit].[AuditHeader] AS AH
		LEFT JOIN	[Audit].[AuditDetail] AS AD
			ON		AH.AuditHeaderID = AD.AuditHeaderID
		WHERE		AH.TableName='[dbo].[ProductPaymentTransaction]'
					) AS AD
		PIVOT		(MAX (NewValue)
			FOR		ColumnName IN
					(
					[ProductPaymentTranID]
					,[CustID]
					,[ReceivedAmount]
					)
					) AS PivotData
GO
/****** Object:  View [dbo].[vProductPaymentTransaction_Deleted]    Script Date: 08/10/2016 11:42:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vProductPaymentTransaction_Deleted]
AS 

 -- generated by AutoAudit Version 3.30a on Jul 20 2016 10:07AM
 -- created by Paul Nielsen and John Sigouin 
 -- www.SQLServerBible.com 
 -- AutoAudit.codeplex.com 
 -- This view returns details about the rows that have been deleted in the referenced table.

WITH	MostRecentDeletes 
AS 
		(SELECT		PrimaryKey, PrimaryKey2, PrimaryKey3, PrimaryKey4, PrimaryKey5, 
					max([RowVersion]) AS [RowVersion] 
		FROM		[Audit].AuditHeader 
		WHERE		TableName = '[dbo].[ProductPaymentTransaction]' 
			AND		Operation = 'd' 
		GROUP BY	PrimaryKey, PrimaryKey2, PrimaryKey3, PrimaryKey4, PrimaryKey5) 
SELECT
		PivotData.PrimaryKey as [ProductPaymentTranID]
		,PivotData.[CustID]
		,PivotData.[ReceivedAmount]
		,SysUser as DeletedBy 
		,CASE WHEN mrd.[RowVersion] = PivotData.HRowVersion then 1 else 0 end AS MostRecentDeleteFlag
		,'Active' AS ViewScope
		,RowHistorySource
FROM 	(SELECT		AH.AuditHeaderID, 
					AH.PrimaryKey, 
					AH.PrimaryKey2, 
					AH.PrimaryKey3, 
					AH.PrimaryKey4, 
					AH.PrimaryKey5, 
					AH.[RowVersion] AS HRowVersion, 
					AH.[SysUser] AS SysUser, 
					SUBSTRING(AD.ColumnName,2,LEN(AD.ColumnName)-2) AS ColumnName, 
					ISNULL(AD.NewValue,AD.OldValue) AS NewValue
					,'Active' AS RowHistorySource
		FROM		[Audit].[AuditHeader] AS AH
		LEFT JOIN	[Audit].[AuditDetail] AS AD
			ON		AH.AuditHeaderID = AD.AuditHeaderID
		WHERE		AH.TableName='[dbo].[ProductPaymentTransaction]'
			AND		AH.Operation='d') AS AD
		PIVOT		(MAX (NewValue)
			FOR		ColumnName IN
					(
					[ProductPaymentTranID]
					,[CustID]
					,[ReceivedAmount]
					)
					) AS PivotData
LEFT JOIN 	MostRecentDeletes mrd
	ON 		PivotData.PrimaryKey = mrd.PrimaryKey
	AND 	isnull(PivotData.PrimaryKey2,'') = isnull(mrd.PrimaryKey2,'')
	AND 	isnull(PivotData.PrimaryKey3,'') = isnull(mrd.PrimaryKey3,'')
	AND 	isnull(PivotData.PrimaryKey4,'') = isnull(mrd.PrimaryKey4,'')
	AND 	isnull(PivotData.PrimaryKey5,'') = isnull(mrd.PrimaryKey5,'')
	AND 	PivotData.HRowVersion = mrd.[RowVersion]
GO
/****** Object:  View [dbo].[vProductPaymentInfo_RowHistory]    Script Date: 08/10/2016 11:42:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vProductPaymentInfo_RowHistory]
AS 

 -- generated by AutoAudit Version 3.30a on Jul 20 2016 10:07AM
 -- created by Paul Nielsen and John Sigouin 
 -- www.SQLServerBible.com 
 -- AutoAudit.codeplex.com 
 -- This view returns historical record entries for the referenced table.

SELECT
		PivotData.AuditDate
		,PivotData.Operation
		,PivotData.HRowVersion AS [RowVersion]
		,PivotData.PrimaryKey AS [ProductPaymentID] 

		,PivotData.[CustID]
		,PivotData.[TotalAmount]
		,'Active' AS ViewScope
		,RowHistorySource
		,[SysUser] 
		,[Application] 
		,[SQLStatement] 
FROM 	(SELECT		AH.AuditHeaderID 
					,AH.PrimaryKey 
					,AH.PrimaryKey2 
					,AH.PrimaryKey3 
					,AH.PrimaryKey4 
					,AH.PrimaryKey5 
					,AH.AuditDate 
					,AH.Operation 
					,AH.[RowVersion] AS HRowVersion 
					,SUBSTRING(AD.ColumnName,2,LEN(AD.ColumnName)-2) AS ColumnName 
					,ISNULL(AD.NewValue,AD.OldValue) AS NewValue
					,'Active' AS RowHistorySource
					,AH.[SysUser] 
					,AH.[Application] 
					,AH.[SQLStatement] 
		FROM		[Audit].[AuditHeader] AS AH
		LEFT JOIN	[Audit].[AuditDetail] AS AD
			ON		AH.AuditHeaderID = AD.AuditHeaderID
		WHERE		AH.TableName='[dbo].[ProductPaymentInfo]'
					) AS AD
		PIVOT		(MAX (NewValue)
			FOR		ColumnName IN
					(
					[ProductPaymentID]
					,[CustID]
					,[TotalAmount]
					)
					) AS PivotData
GO
/****** Object:  View [dbo].[vProductPaymentInfo_Deleted]    Script Date: 08/10/2016 11:42:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vProductPaymentInfo_Deleted]
AS 

 -- generated by AutoAudit Version 3.30a on Jul 20 2016 10:07AM
 -- created by Paul Nielsen and John Sigouin 
 -- www.SQLServerBible.com 
 -- AutoAudit.codeplex.com 
 -- This view returns details about the rows that have been deleted in the referenced table.

WITH	MostRecentDeletes 
AS 
		(SELECT		PrimaryKey, PrimaryKey2, PrimaryKey3, PrimaryKey4, PrimaryKey5, 
					max([RowVersion]) AS [RowVersion] 
		FROM		[Audit].AuditHeader 
		WHERE		TableName = '[dbo].[ProductPaymentInfo]' 
			AND		Operation = 'd' 
		GROUP BY	PrimaryKey, PrimaryKey2, PrimaryKey3, PrimaryKey4, PrimaryKey5) 
SELECT
		PivotData.PrimaryKey as [ProductPaymentID]
		,PivotData.[CustID]
		,PivotData.[TotalAmount]
		,SysUser as DeletedBy 
		,CASE WHEN mrd.[RowVersion] = PivotData.HRowVersion then 1 else 0 end AS MostRecentDeleteFlag
		,'Active' AS ViewScope
		,RowHistorySource
FROM 	(SELECT		AH.AuditHeaderID, 
					AH.PrimaryKey, 
					AH.PrimaryKey2, 
					AH.PrimaryKey3, 
					AH.PrimaryKey4, 
					AH.PrimaryKey5, 
					AH.[RowVersion] AS HRowVersion, 
					AH.[SysUser] AS SysUser, 
					SUBSTRING(AD.ColumnName,2,LEN(AD.ColumnName)-2) AS ColumnName, 
					ISNULL(AD.NewValue,AD.OldValue) AS NewValue
					,'Active' AS RowHistorySource
		FROM		[Audit].[AuditHeader] AS AH
		LEFT JOIN	[Audit].[AuditDetail] AS AD
			ON		AH.AuditHeaderID = AD.AuditHeaderID
		WHERE		AH.TableName='[dbo].[ProductPaymentInfo]'
			AND		AH.Operation='d') AS AD
		PIVOT		(MAX (NewValue)
			FOR		ColumnName IN
					(
					[ProductPaymentID]
					,[CustID]
					,[TotalAmount]
					)
					) AS PivotData
LEFT JOIN 	MostRecentDeletes mrd
	ON 		PivotData.PrimaryKey = mrd.PrimaryKey
	AND 	isnull(PivotData.PrimaryKey2,'') = isnull(mrd.PrimaryKey2,'')
	AND 	isnull(PivotData.PrimaryKey3,'') = isnull(mrd.PrimaryKey3,'')
	AND 	isnull(PivotData.PrimaryKey4,'') = isnull(mrd.PrimaryKey4,'')
	AND 	isnull(PivotData.PrimaryKey5,'') = isnull(mrd.PrimaryKey5,'')
	AND 	PivotData.HRowVersion = mrd.[RowVersion]
GO
/****** Object:  View [dbo].[vPaddyStockInfo_RowHistory]    Script Date: 08/10/2016 11:42:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vPaddyStockInfo_RowHistory]
AS 

 -- generated by AutoAudit Version 3.30a on Jul 20 2016 10:07AM
 -- created by Paul Nielsen and John Sigouin 
 -- www.SQLServerBible.com 
 -- AutoAudit.codeplex.com 
 -- This view returns historical record entries for the referenced table.

SELECT
		PivotData.AuditDate
		,PivotData.Operation
		,PivotData.HRowVersion AS [RowVersion]
		,PivotData.PrimaryKey AS [PaddyStockID] 

		,PivotData.[CustID]
		,PivotData.[Price]
		,PivotData.[TotalBags]
		,'Active' AS ViewScope
		,RowHistorySource
		,[SysUser] 
		,[Application] 
		,[SQLStatement] 
FROM 	(SELECT		AH.AuditHeaderID 
					,AH.PrimaryKey 
					,AH.PrimaryKey2 
					,AH.PrimaryKey3 
					,AH.PrimaryKey4 
					,AH.PrimaryKey5 
					,AH.AuditDate 
					,AH.Operation 
					,AH.[RowVersion] AS HRowVersion 
					,SUBSTRING(AD.ColumnName,2,LEN(AD.ColumnName)-2) AS ColumnName 
					,ISNULL(AD.NewValue,AD.OldValue) AS NewValue
					,'Active' AS RowHistorySource
					,AH.[SysUser] 
					,AH.[Application] 
					,AH.[SQLStatement] 
		FROM		[Audit].[AuditHeader] AS AH
		LEFT JOIN	[Audit].[AuditDetail] AS AD
			ON		AH.AuditHeaderID = AD.AuditHeaderID
		WHERE		AH.TableName='[dbo].[PaddyStockInfo]'
					) AS AD
		PIVOT		(MAX (NewValue)
			FOR		ColumnName IN
					(
					[PaddyStockID]
					,[CustID]
					,[Price]
					,[TotalBags]
					)
					) AS PivotData
GO
/****** Object:  View [dbo].[vPaddyStockInfo_Deleted]    Script Date: 08/10/2016 11:42:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vPaddyStockInfo_Deleted]
AS 

 -- generated by AutoAudit Version 3.30a on Jul 20 2016 10:07AM
 -- created by Paul Nielsen and John Sigouin 
 -- www.SQLServerBible.com 
 -- AutoAudit.codeplex.com 
 -- This view returns details about the rows that have been deleted in the referenced table.

WITH	MostRecentDeletes 
AS 
		(SELECT		PrimaryKey, PrimaryKey2, PrimaryKey3, PrimaryKey4, PrimaryKey5, 
					max([RowVersion]) AS [RowVersion] 
		FROM		[Audit].AuditHeader 
		WHERE		TableName = '[dbo].[PaddyStockInfo]' 
			AND		Operation = 'd' 
		GROUP BY	PrimaryKey, PrimaryKey2, PrimaryKey3, PrimaryKey4, PrimaryKey5) 
SELECT
		PivotData.PrimaryKey as [PaddyStockID]
		,PivotData.[CustID]
		,PivotData.[Price]
		,PivotData.[TotalBags]
		,SysUser as DeletedBy 
		,CASE WHEN mrd.[RowVersion] = PivotData.HRowVersion then 1 else 0 end AS MostRecentDeleteFlag
		,'Active' AS ViewScope
		,RowHistorySource
FROM 	(SELECT		AH.AuditHeaderID, 
					AH.PrimaryKey, 
					AH.PrimaryKey2, 
					AH.PrimaryKey3, 
					AH.PrimaryKey4, 
					AH.PrimaryKey5, 
					AH.[RowVersion] AS HRowVersion, 
					AH.[SysUser] AS SysUser, 
					SUBSTRING(AD.ColumnName,2,LEN(AD.ColumnName)-2) AS ColumnName, 
					ISNULL(AD.NewValue,AD.OldValue) AS NewValue
					,'Active' AS RowHistorySource
		FROM		[Audit].[AuditHeader] AS AH
		LEFT JOIN	[Audit].[AuditDetail] AS AD
			ON		AH.AuditHeaderID = AD.AuditHeaderID
		WHERE		AH.TableName='[dbo].[PaddyStockInfo]'
			AND		AH.Operation='d') AS AD
		PIVOT		(MAX (NewValue)
			FOR		ColumnName IN
					(
					[PaddyStockID]
					,[CustID]
					,[Price]
					,[TotalBags]
					)
					) AS PivotData
LEFT JOIN 	MostRecentDeletes mrd
	ON 		PivotData.PrimaryKey = mrd.PrimaryKey
	AND 	isnull(PivotData.PrimaryKey2,'') = isnull(mrd.PrimaryKey2,'')
	AND 	isnull(PivotData.PrimaryKey3,'') = isnull(mrd.PrimaryKey3,'')
	AND 	isnull(PivotData.PrimaryKey4,'') = isnull(mrd.PrimaryKey4,'')
	AND 	isnull(PivotData.PrimaryKey5,'') = isnull(mrd.PrimaryKey5,'')
	AND 	PivotData.HRowVersion = mrd.[RowVersion]
GO
/****** Object:  View [dbo].[vPaddyPaymentDetails_RowHistory]    Script Date: 08/10/2016 11:42:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vPaddyPaymentDetails_RowHistory]
AS 

 -- generated by AutoAudit Version 3.30a on Jul 20 2016 10:07AM
 -- created by Paul Nielsen and John Sigouin 
 -- www.SQLServerBible.com 
 -- AutoAudit.codeplex.com 
 -- This view returns historical record entries for the referenced table.

SELECT
		PivotData.AuditDate
		,PivotData.Operation
		,PivotData.HRowVersion AS [RowVersion]
		,PivotData.PrimaryKey AS [PaddyPaymentID] 

		,PivotData.[CustID]
		,PivotData.[AmountPaid]
		,'Active' AS ViewScope
		,RowHistorySource
		,[SysUser] 
		,[Application] 
		,[SQLStatement] 
FROM 	(SELECT		AH.AuditHeaderID 
					,AH.PrimaryKey 
					,AH.PrimaryKey2 
					,AH.PrimaryKey3 
					,AH.PrimaryKey4 
					,AH.PrimaryKey5 
					,AH.AuditDate 
					,AH.Operation 
					,AH.[RowVersion] AS HRowVersion 
					,SUBSTRING(AD.ColumnName,2,LEN(AD.ColumnName)-2) AS ColumnName 
					,ISNULL(AD.NewValue,AD.OldValue) AS NewValue
					,'Active' AS RowHistorySource
					,AH.[SysUser] 
					,AH.[Application] 
					,AH.[SQLStatement] 
		FROM		[Audit].[AuditHeader] AS AH
		LEFT JOIN	[Audit].[AuditDetail] AS AD
			ON		AH.AuditHeaderID = AD.AuditHeaderID
		WHERE		AH.TableName='[dbo].[PaddyPaymentDetails]'
					) AS AD
		PIVOT		(MAX (NewValue)
			FOR		ColumnName IN
					(
					[PaddyPaymentID]
					,[CustID]
					,[AmountPaid]
					)
					) AS PivotData
GO
/****** Object:  View [dbo].[vPaddyPaymentDetails_Deleted]    Script Date: 08/10/2016 11:42:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vPaddyPaymentDetails_Deleted]
AS 

 -- generated by AutoAudit Version 3.30a on Jul 20 2016 10:07AM
 -- created by Paul Nielsen and John Sigouin 
 -- www.SQLServerBible.com 
 -- AutoAudit.codeplex.com 
 -- This view returns details about the rows that have been deleted in the referenced table.

WITH	MostRecentDeletes 
AS 
		(SELECT		PrimaryKey, PrimaryKey2, PrimaryKey3, PrimaryKey4, PrimaryKey5, 
					max([RowVersion]) AS [RowVersion] 
		FROM		[Audit].AuditHeader 
		WHERE		TableName = '[dbo].[PaddyPaymentDetails]' 
			AND		Operation = 'd' 
		GROUP BY	PrimaryKey, PrimaryKey2, PrimaryKey3, PrimaryKey4, PrimaryKey5) 
SELECT
		PivotData.PrimaryKey as [PaddyPaymentID]
		,PivotData.[CustID]
		,PivotData.[AmountPaid]
		,SysUser as DeletedBy 
		,CASE WHEN mrd.[RowVersion] = PivotData.HRowVersion then 1 else 0 end AS MostRecentDeleteFlag
		,'Active' AS ViewScope
		,RowHistorySource
FROM 	(SELECT		AH.AuditHeaderID, 
					AH.PrimaryKey, 
					AH.PrimaryKey2, 
					AH.PrimaryKey3, 
					AH.PrimaryKey4, 
					AH.PrimaryKey5, 
					AH.[RowVersion] AS HRowVersion, 
					AH.[SysUser] AS SysUser, 
					SUBSTRING(AD.ColumnName,2,LEN(AD.ColumnName)-2) AS ColumnName, 
					ISNULL(AD.NewValue,AD.OldValue) AS NewValue
					,'Active' AS RowHistorySource
		FROM		[Audit].[AuditHeader] AS AH
		LEFT JOIN	[Audit].[AuditDetail] AS AD
			ON		AH.AuditHeaderID = AD.AuditHeaderID
		WHERE		AH.TableName='[dbo].[PaddyPaymentDetails]'
			AND		AH.Operation='d') AS AD
		PIVOT		(MAX (NewValue)
			FOR		ColumnName IN
					(
					[PaddyPaymentID]
					,[CustID]
					,[AmountPaid]
					)
					) AS PivotData
LEFT JOIN 	MostRecentDeletes mrd
	ON 		PivotData.PrimaryKey = mrd.PrimaryKey
	AND 	isnull(PivotData.PrimaryKey2,'') = isnull(mrd.PrimaryKey2,'')
	AND 	isnull(PivotData.PrimaryKey3,'') = isnull(mrd.PrimaryKey3,'')
	AND 	isnull(PivotData.PrimaryKey4,'') = isnull(mrd.PrimaryKey4,'')
	AND 	isnull(PivotData.PrimaryKey5,'') = isnull(mrd.PrimaryKey5,'')
	AND 	PivotData.HRowVersion = mrd.[RowVersion]
GO
/****** Object:  View [dbo].[vHullingTransaction_RowHistory]    Script Date: 08/10/2016 11:42:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vHullingTransaction_RowHistory]
AS 

 -- generated by AutoAudit Version 3.30a on Jul 20 2016 10:07AM
 -- created by Paul Nielsen and John Sigouin 
 -- www.SQLServerBible.com 
 -- AutoAudit.codeplex.com 
 -- This view returns historical record entries for the referenced table.

SELECT
		PivotData.AuditDate
		,PivotData.Operation
		,PivotData.HRowVersion AS [RowVersion]
		,PivotData.PrimaryKey AS [HullingTransID] 

		,PivotData.[MRiceProdTypeID]
		,PivotData.[BrokenRiceTypeID]
		,PivotData.[CustID]
		,PivotData.[TotalBags]
		,PivotData.[Price]
		,'Active' AS ViewScope
		,RowHistorySource
		,[SysUser] 
		,[Application] 
		,[SQLStatement] 
FROM 	(SELECT		AH.AuditHeaderID 
					,AH.PrimaryKey 
					,AH.PrimaryKey2 
					,AH.PrimaryKey3 
					,AH.PrimaryKey4 
					,AH.PrimaryKey5 
					,AH.AuditDate 
					,AH.Operation 
					,AH.[RowVersion] AS HRowVersion 
					,SUBSTRING(AD.ColumnName,2,LEN(AD.ColumnName)-2) AS ColumnName 
					,ISNULL(AD.NewValue,AD.OldValue) AS NewValue
					,'Active' AS RowHistorySource
					,AH.[SysUser] 
					,AH.[Application] 
					,AH.[SQLStatement] 
		FROM		[Audit].[AuditHeader] AS AH
		LEFT JOIN	[Audit].[AuditDetail] AS AD
			ON		AH.AuditHeaderID = AD.AuditHeaderID
		WHERE		AH.TableName='[dbo].[HullingTransaction]'
					) AS AD
		PIVOT		(MAX (NewValue)
			FOR		ColumnName IN
					(
					[HullingTransID]
					,[MRiceProdTypeID]
					,[BrokenRiceTypeID]
					,[CustID]
					,[TotalBags]
					,[Price]
					)
					) AS PivotData
GO
/****** Object:  View [dbo].[vHullingTransaction_Deleted]    Script Date: 08/10/2016 11:42:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vHullingTransaction_Deleted]
AS 

 -- generated by AutoAudit Version 3.30a on Jul 20 2016 10:07AM
 -- created by Paul Nielsen and John Sigouin 
 -- www.SQLServerBible.com 
 -- AutoAudit.codeplex.com 
 -- This view returns details about the rows that have been deleted in the referenced table.

WITH	MostRecentDeletes 
AS 
		(SELECT		PrimaryKey, PrimaryKey2, PrimaryKey3, PrimaryKey4, PrimaryKey5, 
					max([RowVersion]) AS [RowVersion] 
		FROM		[Audit].AuditHeader 
		WHERE		TableName = '[dbo].[HullingTransaction]' 
			AND		Operation = 'd' 
		GROUP BY	PrimaryKey, PrimaryKey2, PrimaryKey3, PrimaryKey4, PrimaryKey5) 
SELECT
		PivotData.PrimaryKey as [HullingTransID]
		,PivotData.[MRiceProdTypeID]
		,PivotData.[BrokenRiceTypeID]
		,PivotData.[CustID]
		,PivotData.[TotalBags]
		,PivotData.[Price]
		,SysUser as DeletedBy 
		,CASE WHEN mrd.[RowVersion] = PivotData.HRowVersion then 1 else 0 end AS MostRecentDeleteFlag
		,'Active' AS ViewScope
		,RowHistorySource
FROM 	(SELECT		AH.AuditHeaderID, 
					AH.PrimaryKey, 
					AH.PrimaryKey2, 
					AH.PrimaryKey3, 
					AH.PrimaryKey4, 
					AH.PrimaryKey5, 
					AH.[RowVersion] AS HRowVersion, 
					AH.[SysUser] AS SysUser, 
					SUBSTRING(AD.ColumnName,2,LEN(AD.ColumnName)-2) AS ColumnName, 
					ISNULL(AD.NewValue,AD.OldValue) AS NewValue
					,'Active' AS RowHistorySource
		FROM		[Audit].[AuditHeader] AS AH
		LEFT JOIN	[Audit].[AuditDetail] AS AD
			ON		AH.AuditHeaderID = AD.AuditHeaderID
		WHERE		AH.TableName='[dbo].[HullingTransaction]'
			AND		AH.Operation='d') AS AD
		PIVOT		(MAX (NewValue)
			FOR		ColumnName IN
					(
					[HullingTransID]
					,[MRiceProdTypeID]
					,[BrokenRiceTypeID]
					,[CustID]
					,[TotalBags]
					,[Price]
					)
					) AS PivotData
LEFT JOIN 	MostRecentDeletes mrd
	ON 		PivotData.PrimaryKey = mrd.PrimaryKey
	AND 	isnull(PivotData.PrimaryKey2,'') = isnull(mrd.PrimaryKey2,'')
	AND 	isnull(PivotData.PrimaryKey3,'') = isnull(mrd.PrimaryKey3,'')
	AND 	isnull(PivotData.PrimaryKey4,'') = isnull(mrd.PrimaryKey4,'')
	AND 	isnull(PivotData.PrimaryKey5,'') = isnull(mrd.PrimaryKey5,'')
	AND 	PivotData.HRowVersion = mrd.[RowVersion]
GO
/****** Object:  View [dbo].[vHullingProcessExpenses_RowHistory]    Script Date: 08/10/2016 11:42:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vHullingProcessExpenses_RowHistory]
AS 

 -- generated by AutoAudit Version 3.30a on Jul 20 2016 10:07AM
 -- created by Paul Nielsen and John Sigouin 
 -- www.SQLServerBible.com 
 -- AutoAudit.codeplex.com 
 -- This view returns historical record entries for the referenced table.

SELECT
		PivotData.AuditDate
		,PivotData.Operation
		,PivotData.HRowVersion AS [RowVersion]
		,PivotData.PrimaryKey AS [HullingProcessExpenID] 

		,PivotData.[CustID]
		,PivotData.[HullingExpenses]
		,'Active' AS ViewScope
		,RowHistorySource
		,[SysUser] 
		,[Application] 
		,[SQLStatement] 
FROM 	(SELECT		AH.AuditHeaderID 
					,AH.PrimaryKey 
					,AH.PrimaryKey2 
					,AH.PrimaryKey3 
					,AH.PrimaryKey4 
					,AH.PrimaryKey5 
					,AH.AuditDate 
					,AH.Operation 
					,AH.[RowVersion] AS HRowVersion 
					,SUBSTRING(AD.ColumnName,2,LEN(AD.ColumnName)-2) AS ColumnName 
					,ISNULL(AD.NewValue,AD.OldValue) AS NewValue
					,'Active' AS RowHistorySource
					,AH.[SysUser] 
					,AH.[Application] 
					,AH.[SQLStatement] 
		FROM		[Audit].[AuditHeader] AS AH
		LEFT JOIN	[Audit].[AuditDetail] AS AD
			ON		AH.AuditHeaderID = AD.AuditHeaderID
		WHERE		AH.TableName='[dbo].[HullingProcessExpenses]'
					) AS AD
		PIVOT		(MAX (NewValue)
			FOR		ColumnName IN
					(
					[HullingProcessExpenID]
					,[CustID]
					,[HullingExpenses]
					)
					) AS PivotData
GO
/****** Object:  View [dbo].[vHullingProcessExpenses_Deleted]    Script Date: 08/10/2016 11:42:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vHullingProcessExpenses_Deleted]
AS 

 -- generated by AutoAudit Version 3.30a on Jul 20 2016 10:07AM
 -- created by Paul Nielsen and John Sigouin 
 -- www.SQLServerBible.com 
 -- AutoAudit.codeplex.com 
 -- This view returns details about the rows that have been deleted in the referenced table.

WITH	MostRecentDeletes 
AS 
		(SELECT		PrimaryKey, PrimaryKey2, PrimaryKey3, PrimaryKey4, PrimaryKey5, 
					max([RowVersion]) AS [RowVersion] 
		FROM		[Audit].AuditHeader 
		WHERE		TableName = '[dbo].[HullingProcessExpenses]' 
			AND		Operation = 'd' 
		GROUP BY	PrimaryKey, PrimaryKey2, PrimaryKey3, PrimaryKey4, PrimaryKey5) 
SELECT
		PivotData.PrimaryKey as [HullingProcessExpenID]
		,PivotData.[CustID]
		,PivotData.[HullingExpenses]
		,SysUser as DeletedBy 
		,CASE WHEN mrd.[RowVersion] = PivotData.HRowVersion then 1 else 0 end AS MostRecentDeleteFlag
		,'Active' AS ViewScope
		,RowHistorySource
FROM 	(SELECT		AH.AuditHeaderID, 
					AH.PrimaryKey, 
					AH.PrimaryKey2, 
					AH.PrimaryKey3, 
					AH.PrimaryKey4, 
					AH.PrimaryKey5, 
					AH.[RowVersion] AS HRowVersion, 
					AH.[SysUser] AS SysUser, 
					SUBSTRING(AD.ColumnName,2,LEN(AD.ColumnName)-2) AS ColumnName, 
					ISNULL(AD.NewValue,AD.OldValue) AS NewValue
					,'Active' AS RowHistorySource
		FROM		[Audit].[AuditHeader] AS AH
		LEFT JOIN	[Audit].[AuditDetail] AS AD
			ON		AH.AuditHeaderID = AD.AuditHeaderID
		WHERE		AH.TableName='[dbo].[HullingProcessExpenses]'
			AND		AH.Operation='d') AS AD
		PIVOT		(MAX (NewValue)
			FOR		ColumnName IN
					(
					[HullingProcessExpenID]
					,[CustID]
					,[HullingExpenses]
					)
					) AS PivotData
LEFT JOIN 	MostRecentDeletes mrd
	ON 		PivotData.PrimaryKey = mrd.PrimaryKey
	AND 	isnull(PivotData.PrimaryKey2,'') = isnull(mrd.PrimaryKey2,'')
	AND 	isnull(PivotData.PrimaryKey3,'') = isnull(mrd.PrimaryKey3,'')
	AND 	isnull(PivotData.PrimaryKey4,'') = isnull(mrd.PrimaryKey4,'')
	AND 	isnull(PivotData.PrimaryKey5,'') = isnull(mrd.PrimaryKey5,'')
	AND 	PivotData.HRowVersion = mrd.[RowVersion]
GO
/****** Object:  View [dbo].[vHullingProcess_RowHistory]    Script Date: 08/10/2016 11:42:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vHullingProcess_RowHistory]
AS 

 -- generated by AutoAudit Version 3.30a on Jul 20 2016 10:07AM
 -- created by Paul Nielsen and John Sigouin 
 -- www.SQLServerBible.com 
 -- AutoAudit.codeplex.com 
 -- This view returns historical record entries for the referenced table.

SELECT
		PivotData.AuditDate
		,PivotData.Operation
		,PivotData.HRowVersion AS [RowVersion]
		,PivotData.PrimaryKey AS [HullingProcessID] 

		,PivotData.[CustID]
		,PivotData.[TotalBags]
		,PivotData.[Price]
		,'Active' AS ViewScope
		,RowHistorySource
		,[SysUser] 
		,[Application] 
		,[SQLStatement] 
FROM 	(SELECT		AH.AuditHeaderID 
					,AH.PrimaryKey 
					,AH.PrimaryKey2 
					,AH.PrimaryKey3 
					,AH.PrimaryKey4 
					,AH.PrimaryKey5 
					,AH.AuditDate 
					,AH.Operation 
					,AH.[RowVersion] AS HRowVersion 
					,SUBSTRING(AD.ColumnName,2,LEN(AD.ColumnName)-2) AS ColumnName 
					,ISNULL(AD.NewValue,AD.OldValue) AS NewValue
					,'Active' AS RowHistorySource
					,AH.[SysUser] 
					,AH.[Application] 
					,AH.[SQLStatement] 
		FROM		[Audit].[AuditHeader] AS AH
		LEFT JOIN	[Audit].[AuditDetail] AS AD
			ON		AH.AuditHeaderID = AD.AuditHeaderID
		WHERE		AH.TableName='[dbo].[HullingProcess]'
					) AS AD
		PIVOT		(MAX (NewValue)
			FOR		ColumnName IN
					(
					[HullingProcessID]
					,[CustID]
					,[TotalBags]
					,[Price]
					)
					) AS PivotData
GO
/****** Object:  View [dbo].[vHullingProcess_Deleted]    Script Date: 08/10/2016 11:42:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vHullingProcess_Deleted]
AS 

 -- generated by AutoAudit Version 3.30a on Jul 20 2016 10:07AM
 -- created by Paul Nielsen and John Sigouin 
 -- www.SQLServerBible.com 
 -- AutoAudit.codeplex.com 
 -- This view returns details about the rows that have been deleted in the referenced table.

WITH	MostRecentDeletes 
AS 
		(SELECT		PrimaryKey, PrimaryKey2, PrimaryKey3, PrimaryKey4, PrimaryKey5, 
					max([RowVersion]) AS [RowVersion] 
		FROM		[Audit].AuditHeader 
		WHERE		TableName = '[dbo].[HullingProcess]' 
			AND		Operation = 'd' 
		GROUP BY	PrimaryKey, PrimaryKey2, PrimaryKey3, PrimaryKey4, PrimaryKey5) 
SELECT
		PivotData.PrimaryKey as [HullingProcessID]
		,PivotData.[CustID]
		,PivotData.[TotalBags]
		,PivotData.[Price]
		,SysUser as DeletedBy 
		,CASE WHEN mrd.[RowVersion] = PivotData.HRowVersion then 1 else 0 end AS MostRecentDeleteFlag
		,'Active' AS ViewScope
		,RowHistorySource
FROM 	(SELECT		AH.AuditHeaderID, 
					AH.PrimaryKey, 
					AH.PrimaryKey2, 
					AH.PrimaryKey3, 
					AH.PrimaryKey4, 
					AH.PrimaryKey5, 
					AH.[RowVersion] AS HRowVersion, 
					AH.[SysUser] AS SysUser, 
					SUBSTRING(AD.ColumnName,2,LEN(AD.ColumnName)-2) AS ColumnName, 
					ISNULL(AD.NewValue,AD.OldValue) AS NewValue
					,'Active' AS RowHistorySource
		FROM		[Audit].[AuditHeader] AS AH
		LEFT JOIN	[Audit].[AuditDetail] AS AD
			ON		AH.AuditHeaderID = AD.AuditHeaderID
		WHERE		AH.TableName='[dbo].[HullingProcess]'
			AND		AH.Operation='d') AS AD
		PIVOT		(MAX (NewValue)
			FOR		ColumnName IN
					(
					[HullingProcessID]
					,[CustID]
					,[TotalBags]
					,[Price]
					)
					) AS PivotData
LEFT JOIN 	MostRecentDeletes mrd
	ON 		PivotData.PrimaryKey = mrd.PrimaryKey
	AND 	isnull(PivotData.PrimaryKey2,'') = isnull(mrd.PrimaryKey2,'')
	AND 	isnull(PivotData.PrimaryKey3,'') = isnull(mrd.PrimaryKey3,'')
	AND 	isnull(PivotData.PrimaryKey4,'') = isnull(mrd.PrimaryKey4,'')
	AND 	isnull(PivotData.PrimaryKey5,'') = isnull(mrd.PrimaryKey5,'')
	AND 	PivotData.HRowVersion = mrd.[RowVersion]
GO
/****** Object:  View [dbo].[vExpenseTransaction_RowHistory]    Script Date: 08/10/2016 11:42:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vExpenseTransaction_RowHistory]
AS 

 -- generated by AutoAudit Version 3.30a on Jul 20 2016 10:07AM
 -- created by Paul Nielsen and John Sigouin 
 -- www.SQLServerBible.com 
 -- AutoAudit.codeplex.com 
 -- This view returns historical record entries for the referenced table.

SELECT
		PivotData.AuditDate
		,PivotData.Operation
		,PivotData.HRowVersion AS [RowVersion]
		,PivotData.PrimaryKey AS [ExpenseTransID] 

		,PivotData.[CustID]
		,PivotData.[Amount]
		,'Active' AS ViewScope
		,RowHistorySource
		,[SysUser] 
		,[Application] 
		,[SQLStatement] 
FROM 	(SELECT		AH.AuditHeaderID 
					,AH.PrimaryKey 
					,AH.PrimaryKey2 
					,AH.PrimaryKey3 
					,AH.PrimaryKey4 
					,AH.PrimaryKey5 
					,AH.AuditDate 
					,AH.Operation 
					,AH.[RowVersion] AS HRowVersion 
					,SUBSTRING(AD.ColumnName,2,LEN(AD.ColumnName)-2) AS ColumnName 
					,ISNULL(AD.NewValue,AD.OldValue) AS NewValue
					,'Active' AS RowHistorySource
					,AH.[SysUser] 
					,AH.[Application] 
					,AH.[SQLStatement] 
		FROM		[Audit].[AuditHeader] AS AH
		LEFT JOIN	[Audit].[AuditDetail] AS AD
			ON		AH.AuditHeaderID = AD.AuditHeaderID
		WHERE		AH.TableName='[dbo].[ExpenseTransaction]'
					) AS AD
		PIVOT		(MAX (NewValue)
			FOR		ColumnName IN
					(
					[ExpenseTransID]
					,[CustID]
					,[Amount]
					)
					) AS PivotData
GO
/****** Object:  View [dbo].[vExpenseTransaction_Deleted]    Script Date: 08/10/2016 11:42:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vExpenseTransaction_Deleted]
AS 

 -- generated by AutoAudit Version 3.30a on Jul 20 2016 10:07AM
 -- created by Paul Nielsen and John Sigouin 
 -- www.SQLServerBible.com 
 -- AutoAudit.codeplex.com 
 -- This view returns details about the rows that have been deleted in the referenced table.

WITH	MostRecentDeletes 
AS 
		(SELECT		PrimaryKey, PrimaryKey2, PrimaryKey3, PrimaryKey4, PrimaryKey5, 
					max([RowVersion]) AS [RowVersion] 
		FROM		[Audit].AuditHeader 
		WHERE		TableName = '[dbo].[ExpenseTransaction]' 
			AND		Operation = 'd' 
		GROUP BY	PrimaryKey, PrimaryKey2, PrimaryKey3, PrimaryKey4, PrimaryKey5) 
SELECT
		PivotData.PrimaryKey as [ExpenseTransID]
		,PivotData.[CustID]
		,PivotData.[Amount]
		,SysUser as DeletedBy 
		,CASE WHEN mrd.[RowVersion] = PivotData.HRowVersion then 1 else 0 end AS MostRecentDeleteFlag
		,'Active' AS ViewScope
		,RowHistorySource
FROM 	(SELECT		AH.AuditHeaderID, 
					AH.PrimaryKey, 
					AH.PrimaryKey2, 
					AH.PrimaryKey3, 
					AH.PrimaryKey4, 
					AH.PrimaryKey5, 
					AH.[RowVersion] AS HRowVersion, 
					AH.[SysUser] AS SysUser, 
					SUBSTRING(AD.ColumnName,2,LEN(AD.ColumnName)-2) AS ColumnName, 
					ISNULL(AD.NewValue,AD.OldValue) AS NewValue
					,'Active' AS RowHistorySource
		FROM		[Audit].[AuditHeader] AS AH
		LEFT JOIN	[Audit].[AuditDetail] AS AD
			ON		AH.AuditHeaderID = AD.AuditHeaderID
		WHERE		AH.TableName='[dbo].[ExpenseTransaction]'
			AND		AH.Operation='d') AS AD
		PIVOT		(MAX (NewValue)
			FOR		ColumnName IN
					(
					[ExpenseTransID]
					,[CustID]
					,[Amount]
					)
					) AS PivotData
LEFT JOIN 	MostRecentDeletes mrd
	ON 		PivotData.PrimaryKey = mrd.PrimaryKey
	AND 	isnull(PivotData.PrimaryKey2,'') = isnull(mrd.PrimaryKey2,'')
	AND 	isnull(PivotData.PrimaryKey3,'') = isnull(mrd.PrimaryKey3,'')
	AND 	isnull(PivotData.PrimaryKey4,'') = isnull(mrd.PrimaryKey4,'')
	AND 	isnull(PivotData.PrimaryKey5,'') = isnull(mrd.PrimaryKey5,'')
	AND 	PivotData.HRowVersion = mrd.[RowVersion]
GO
/****** Object:  View [dbo].[vEmployeeSalary_RowHistory]    Script Date: 08/10/2016 11:42:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vEmployeeSalary_RowHistory]
AS 

 -- generated by AutoAudit Version 3.30a on Jul 20 2016 10:07AM
 -- created by Paul Nielsen and John Sigouin 
 -- www.SQLServerBible.com 
 -- AutoAudit.codeplex.com 
 -- This view returns historical record entries for the referenced table.

SELECT
		PivotData.AuditDate
		,PivotData.Operation
		,PivotData.HRowVersion AS [RowVersion]
		,PivotData.PrimaryKey AS [EmpSalaryID] 

		,PivotData.[CustID]
		,PivotData.[Salary]
		,'Active' AS ViewScope
		,RowHistorySource
		,[SysUser] 
		,[Application] 
		,[SQLStatement] 
FROM 	(SELECT		AH.AuditHeaderID 
					,AH.PrimaryKey 
					,AH.PrimaryKey2 
					,AH.PrimaryKey3 
					,AH.PrimaryKey4 
					,AH.PrimaryKey5 
					,AH.AuditDate 
					,AH.Operation 
					,AH.[RowVersion] AS HRowVersion 
					,SUBSTRING(AD.ColumnName,2,LEN(AD.ColumnName)-2) AS ColumnName 
					,ISNULL(AD.NewValue,AD.OldValue) AS NewValue
					,'Active' AS RowHistorySource
					,AH.[SysUser] 
					,AH.[Application] 
					,AH.[SQLStatement] 
		FROM		[Audit].[AuditHeader] AS AH
		LEFT JOIN	[Audit].[AuditDetail] AS AD
			ON		AH.AuditHeaderID = AD.AuditHeaderID
		WHERE		AH.TableName='[dbo].[EmployeeSalary]'
					) AS AD
		PIVOT		(MAX (NewValue)
			FOR		ColumnName IN
					(
					[EmpSalaryID]
					,[CustID]
					,[Salary]
					)
					) AS PivotData
GO
/****** Object:  View [dbo].[vEmployeeSalary_Deleted]    Script Date: 08/10/2016 11:42:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vEmployeeSalary_Deleted]
AS 

 -- generated by AutoAudit Version 3.30a on Jul 20 2016 10:07AM
 -- created by Paul Nielsen and John Sigouin 
 -- www.SQLServerBible.com 
 -- AutoAudit.codeplex.com 
 -- This view returns details about the rows that have been deleted in the referenced table.

WITH	MostRecentDeletes 
AS 
		(SELECT		PrimaryKey, PrimaryKey2, PrimaryKey3, PrimaryKey4, PrimaryKey5, 
					max([RowVersion]) AS [RowVersion] 
		FROM		[Audit].AuditHeader 
		WHERE		TableName = '[dbo].[EmployeeSalary]' 
			AND		Operation = 'd' 
		GROUP BY	PrimaryKey, PrimaryKey2, PrimaryKey3, PrimaryKey4, PrimaryKey5) 
SELECT
		PivotData.PrimaryKey as [EmpSalaryID]
		,PivotData.[CustID]
		,PivotData.[Salary]
		,SysUser as DeletedBy 
		,CASE WHEN mrd.[RowVersion] = PivotData.HRowVersion then 1 else 0 end AS MostRecentDeleteFlag
		,'Active' AS ViewScope
		,RowHistorySource
FROM 	(SELECT		AH.AuditHeaderID, 
					AH.PrimaryKey, 
					AH.PrimaryKey2, 
					AH.PrimaryKey3, 
					AH.PrimaryKey4, 
					AH.PrimaryKey5, 
					AH.[RowVersion] AS HRowVersion, 
					AH.[SysUser] AS SysUser, 
					SUBSTRING(AD.ColumnName,2,LEN(AD.ColumnName)-2) AS ColumnName, 
					ISNULL(AD.NewValue,AD.OldValue) AS NewValue
					,'Active' AS RowHistorySource
		FROM		[Audit].[AuditHeader] AS AH
		LEFT JOIN	[Audit].[AuditDetail] AS AD
			ON		AH.AuditHeaderID = AD.AuditHeaderID
		WHERE		AH.TableName='[dbo].[EmployeeSalary]'
			AND		AH.Operation='d') AS AD
		PIVOT		(MAX (NewValue)
			FOR		ColumnName IN
					(
					[EmpSalaryID]
					,[CustID]
					,[Salary]
					)
					) AS PivotData
LEFT JOIN 	MostRecentDeletes mrd
	ON 		PivotData.PrimaryKey = mrd.PrimaryKey
	AND 	isnull(PivotData.PrimaryKey2,'') = isnull(mrd.PrimaryKey2,'')
	AND 	isnull(PivotData.PrimaryKey3,'') = isnull(mrd.PrimaryKey3,'')
	AND 	isnull(PivotData.PrimaryKey4,'') = isnull(mrd.PrimaryKey4,'')
	AND 	isnull(PivotData.PrimaryKey5,'') = isnull(mrd.PrimaryKey5,'')
	AND 	PivotData.HRowVersion = mrd.[RowVersion]
GO
/****** Object:  View [dbo].[vBankTransaction_RowHistory]    Script Date: 08/10/2016 11:42:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vBankTransaction_RowHistory]
AS 

 -- generated by AutoAudit Version 3.30a on Jul 20 2016 10:07AM
 -- created by Paul Nielsen and John Sigouin 
 -- www.SQLServerBible.com 
 -- AutoAudit.codeplex.com 
 -- This view returns historical record entries for the referenced table.

SELECT
		PivotData.AuditDate
		,PivotData.Operation
		,PivotData.HRowVersion AS [RowVersion]
		,PivotData.PrimaryKey AS [BankTransID] 

		,PivotData.[CustID]
		,PivotData.[Withdraw]
		,PivotData.[Deposit]
		,PivotData.[Balance]
		,'Active' AS ViewScope
		,RowHistorySource
		,[SysUser] 
		,[Application] 
		,[SQLStatement] 
FROM 	(SELECT		AH.AuditHeaderID 
					,AH.PrimaryKey 
					,AH.PrimaryKey2 
					,AH.PrimaryKey3 
					,AH.PrimaryKey4 
					,AH.PrimaryKey5 
					,AH.AuditDate 
					,AH.Operation 
					,AH.[RowVersion] AS HRowVersion 
					,SUBSTRING(AD.ColumnName,2,LEN(AD.ColumnName)-2) AS ColumnName 
					,ISNULL(AD.NewValue,AD.OldValue) AS NewValue
					,'Active' AS RowHistorySource
					,AH.[SysUser] 
					,AH.[Application] 
					,AH.[SQLStatement] 
		FROM		[Audit].[AuditHeader] AS AH
		LEFT JOIN	[Audit].[AuditDetail] AS AD
			ON		AH.AuditHeaderID = AD.AuditHeaderID
		WHERE		AH.TableName='[dbo].[BankTransaction]'
					) AS AD
		PIVOT		(MAX (NewValue)
			FOR		ColumnName IN
					(
					[BankTransID]
					,[CustID]
					,[Withdraw]
					,[Deposit]
					,[Balance]
					)
					) AS PivotData
GO
/****** Object:  View [dbo].[vBankTransaction_Deleted]    Script Date: 08/10/2016 11:42:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vBankTransaction_Deleted]
AS 

 -- generated by AutoAudit Version 3.30a on Jul 20 2016 10:07AM
 -- created by Paul Nielsen and John Sigouin 
 -- www.SQLServerBible.com 
 -- AutoAudit.codeplex.com 
 -- This view returns details about the rows that have been deleted in the referenced table.

WITH	MostRecentDeletes 
AS 
		(SELECT		PrimaryKey, PrimaryKey2, PrimaryKey3, PrimaryKey4, PrimaryKey5, 
					max([RowVersion]) AS [RowVersion] 
		FROM		[Audit].AuditHeader 
		WHERE		TableName = '[dbo].[BankTransaction]' 
			AND		Operation = 'd' 
		GROUP BY	PrimaryKey, PrimaryKey2, PrimaryKey3, PrimaryKey4, PrimaryKey5) 
SELECT
		PivotData.PrimaryKey as [BankTransID]
		,PivotData.[CustID]
		,PivotData.[Withdraw]
		,PivotData.[Deposit]
		,PivotData.[Balance]
		,SysUser as DeletedBy 
		,CASE WHEN mrd.[RowVersion] = PivotData.HRowVersion then 1 else 0 end AS MostRecentDeleteFlag
		,'Active' AS ViewScope
		,RowHistorySource
FROM 	(SELECT		AH.AuditHeaderID, 
					AH.PrimaryKey, 
					AH.PrimaryKey2, 
					AH.PrimaryKey3, 
					AH.PrimaryKey4, 
					AH.PrimaryKey5, 
					AH.[RowVersion] AS HRowVersion, 
					AH.[SysUser] AS SysUser, 
					SUBSTRING(AD.ColumnName,2,LEN(AD.ColumnName)-2) AS ColumnName, 
					ISNULL(AD.NewValue,AD.OldValue) AS NewValue
					,'Active' AS RowHistorySource
		FROM		[Audit].[AuditHeader] AS AH
		LEFT JOIN	[Audit].[AuditDetail] AS AD
			ON		AH.AuditHeaderID = AD.AuditHeaderID
		WHERE		AH.TableName='[dbo].[BankTransaction]'
			AND		AH.Operation='d') AS AD
		PIVOT		(MAX (NewValue)
			FOR		ColumnName IN
					(
					[BankTransID]
					,[CustID]
					,[Withdraw]
					,[Deposit]
					,[Balance]
					)
					) AS PivotData
LEFT JOIN 	MostRecentDeletes mrd
	ON 		PivotData.PrimaryKey = mrd.PrimaryKey
	AND 	isnull(PivotData.PrimaryKey2,'') = isnull(mrd.PrimaryKey2,'')
	AND 	isnull(PivotData.PrimaryKey3,'') = isnull(mrd.PrimaryKey3,'')
	AND 	isnull(PivotData.PrimaryKey4,'') = isnull(mrd.PrimaryKey4,'')
	AND 	isnull(PivotData.PrimaryKey5,'') = isnull(mrd.PrimaryKey5,'')
	AND 	PivotData.HRowVersion = mrd.[RowVersion]
GO
/****** Object:  View [dbo].[vBagStockInfo_RowHistory]    Script Date: 08/10/2016 11:42:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vBagStockInfo_RowHistory]
AS 

 -- generated by AutoAudit Version 3.30a on Jul 20 2016 10:07AM
 -- created by Paul Nielsen and John Sigouin 
 -- www.SQLServerBible.com 
 -- AutoAudit.codeplex.com 
 -- This view returns historical record entries for the referenced table.

SELECT
		PivotData.AuditDate
		,PivotData.Operation
		,PivotData.HRowVersion AS [RowVersion]
		,PivotData.PrimaryKey AS [BagStockID] 

		,PivotData.[CustID]
		,PivotData.[Price]
		,PivotData.[TotalBags]
		,'Active' AS ViewScope
		,RowHistorySource
		,[SysUser] 
		,[Application] 
		,[SQLStatement] 
FROM 	(SELECT		AH.AuditHeaderID 
					,AH.PrimaryKey 
					,AH.PrimaryKey2 
					,AH.PrimaryKey3 
					,AH.PrimaryKey4 
					,AH.PrimaryKey5 
					,AH.AuditDate 
					,AH.Operation 
					,AH.[RowVersion] AS HRowVersion 
					,SUBSTRING(AD.ColumnName,2,LEN(AD.ColumnName)-2) AS ColumnName 
					,ISNULL(AD.NewValue,AD.OldValue) AS NewValue
					,'Active' AS RowHistorySource
					,AH.[SysUser] 
					,AH.[Application] 
					,AH.[SQLStatement] 
		FROM		[Audit].[AuditHeader] AS AH
		LEFT JOIN	[Audit].[AuditDetail] AS AD
			ON		AH.AuditHeaderID = AD.AuditHeaderID
		WHERE		AH.TableName='[dbo].[BagStockInfo]'
					) AS AD
		PIVOT		(MAX (NewValue)
			FOR		ColumnName IN
					(
					[BagStockID]
					,[CustID]
					,[Price]
					,[TotalBags]
					)
					) AS PivotData
GO
/****** Object:  View [dbo].[vBagStockInfo_Deleted]    Script Date: 08/10/2016 11:42:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vBagStockInfo_Deleted]
AS 

 -- generated by AutoAudit Version 3.30a on Jul 20 2016 10:07AM
 -- created by Paul Nielsen and John Sigouin 
 -- www.SQLServerBible.com 
 -- AutoAudit.codeplex.com 
 -- This view returns details about the rows that have been deleted in the referenced table.

WITH	MostRecentDeletes 
AS 
		(SELECT		PrimaryKey, PrimaryKey2, PrimaryKey3, PrimaryKey4, PrimaryKey5, 
					max([RowVersion]) AS [RowVersion] 
		FROM		[Audit].AuditHeader 
		WHERE		TableName = '[dbo].[BagStockInfo]' 
			AND		Operation = 'd' 
		GROUP BY	PrimaryKey, PrimaryKey2, PrimaryKey3, PrimaryKey4, PrimaryKey5) 
SELECT
		PivotData.PrimaryKey as [BagStockID]
		,PivotData.[CustID]
		,PivotData.[Price]
		,PivotData.[TotalBags]
		,SysUser as DeletedBy 
		,CASE WHEN mrd.[RowVersion] = PivotData.HRowVersion then 1 else 0 end AS MostRecentDeleteFlag
		,'Active' AS ViewScope
		,RowHistorySource
FROM 	(SELECT		AH.AuditHeaderID, 
					AH.PrimaryKey, 
					AH.PrimaryKey2, 
					AH.PrimaryKey3, 
					AH.PrimaryKey4, 
					AH.PrimaryKey5, 
					AH.[RowVersion] AS HRowVersion, 
					AH.[SysUser] AS SysUser, 
					SUBSTRING(AD.ColumnName,2,LEN(AD.ColumnName)-2) AS ColumnName, 
					ISNULL(AD.NewValue,AD.OldValue) AS NewValue
					,'Active' AS RowHistorySource
		FROM		[Audit].[AuditHeader] AS AH
		LEFT JOIN	[Audit].[AuditDetail] AS AD
			ON		AH.AuditHeaderID = AD.AuditHeaderID
		WHERE		AH.TableName='[dbo].[BagStockInfo]'
			AND		AH.Operation='d') AS AD
		PIVOT		(MAX (NewValue)
			FOR		ColumnName IN
					(
					[BagStockID]
					,[CustID]
					,[Price]
					,[TotalBags]
					)
					) AS PivotData
LEFT JOIN 	MostRecentDeletes mrd
	ON 		PivotData.PrimaryKey = mrd.PrimaryKey
	AND 	isnull(PivotData.PrimaryKey2,'') = isnull(mrd.PrimaryKey2,'')
	AND 	isnull(PivotData.PrimaryKey3,'') = isnull(mrd.PrimaryKey3,'')
	AND 	isnull(PivotData.PrimaryKey4,'') = isnull(mrd.PrimaryKey4,'')
	AND 	isnull(PivotData.PrimaryKey5,'') = isnull(mrd.PrimaryKey5,'')
	AND 	PivotData.HRowVersion = mrd.[RowVersion]
GO
/****** Object:  View [dbo].[vBagPaymentInfo_RowHistory]    Script Date: 08/10/2016 11:42:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vBagPaymentInfo_RowHistory]
AS 

 -- generated by AutoAudit Version 3.30a on Jul 20 2016 10:07AM
 -- created by Paul Nielsen and John Sigouin 
 -- www.SQLServerBible.com 
 -- AutoAudit.codeplex.com 
 -- This view returns historical record entries for the referenced table.

SELECT
		PivotData.AuditDate
		,PivotData.Operation
		,PivotData.HRowVersion AS [RowVersion]
		,PivotData.PrimaryKey AS [BagPaymentID] 

		,PivotData.[CustID]
		,PivotData.[AmountPaid]
		,PivotData.[PaidDate]
		,PivotData.[PaymentMode]
		,'Active' AS ViewScope
		,RowHistorySource
		,[SysUser] 
		,[Application] 
		,[SQLStatement] 
FROM 	(SELECT		AH.AuditHeaderID 
					,AH.PrimaryKey 
					,AH.PrimaryKey2 
					,AH.PrimaryKey3 
					,AH.PrimaryKey4 
					,AH.PrimaryKey5 
					,AH.AuditDate 
					,AH.Operation 
					,AH.[RowVersion] AS HRowVersion 
					,SUBSTRING(AD.ColumnName,2,LEN(AD.ColumnName)-2) AS ColumnName 
					,ISNULL(AD.NewValue,AD.OldValue) AS NewValue
					,'Active' AS RowHistorySource
					,AH.[SysUser] 
					,AH.[Application] 
					,AH.[SQLStatement] 
		FROM		[Audit].[AuditHeader] AS AH
		LEFT JOIN	[Audit].[AuditDetail] AS AD
			ON		AH.AuditHeaderID = AD.AuditHeaderID
		WHERE		AH.TableName='[dbo].[BagPaymentInfo]'
					) AS AD
		PIVOT		(MAX (NewValue)
			FOR		ColumnName IN
					(
					[BagPaymentID]
					,[CustID]
					,[AmountPaid]
					,[PaidDate]
					,[PaymentMode]
					)
					) AS PivotData
GO
/****** Object:  View [dbo].[vBagPaymentInfo_Deleted]    Script Date: 08/10/2016 11:42:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vBagPaymentInfo_Deleted]
AS 

 -- generated by AutoAudit Version 3.30a on Jul 20 2016 10:07AM
 -- created by Paul Nielsen and John Sigouin 
 -- www.SQLServerBible.com 
 -- AutoAudit.codeplex.com 
 -- This view returns details about the rows that have been deleted in the referenced table.

WITH	MostRecentDeletes 
AS 
		(SELECT		PrimaryKey, PrimaryKey2, PrimaryKey3, PrimaryKey4, PrimaryKey5, 
					max([RowVersion]) AS [RowVersion] 
		FROM		[Audit].AuditHeader 
		WHERE		TableName = '[dbo].[BagPaymentInfo]' 
			AND		Operation = 'd' 
		GROUP BY	PrimaryKey, PrimaryKey2, PrimaryKey3, PrimaryKey4, PrimaryKey5) 
SELECT
		PivotData.PrimaryKey as [BagPaymentID]
		,PivotData.[CustID]
		,PivotData.[AmountPaid]
		,PivotData.[PaidDate]
		,PivotData.[PaymentMode]
		,SysUser as DeletedBy 
		,CASE WHEN mrd.[RowVersion] = PivotData.HRowVersion then 1 else 0 end AS MostRecentDeleteFlag
		,'Active' AS ViewScope
		,RowHistorySource
FROM 	(SELECT		AH.AuditHeaderID, 
					AH.PrimaryKey, 
					AH.PrimaryKey2, 
					AH.PrimaryKey3, 
					AH.PrimaryKey4, 
					AH.PrimaryKey5, 
					AH.[RowVersion] AS HRowVersion, 
					AH.[SysUser] AS SysUser, 
					SUBSTRING(AD.ColumnName,2,LEN(AD.ColumnName)-2) AS ColumnName, 
					ISNULL(AD.NewValue,AD.OldValue) AS NewValue
					,'Active' AS RowHistorySource
		FROM		[Audit].[AuditHeader] AS AH
		LEFT JOIN	[Audit].[AuditDetail] AS AD
			ON		AH.AuditHeaderID = AD.AuditHeaderID
		WHERE		AH.TableName='[dbo].[BagPaymentInfo]'
			AND		AH.Operation='d') AS AD
		PIVOT		(MAX (NewValue)
			FOR		ColumnName IN
					(
					[BagPaymentID]
					,[CustID]
					,[AmountPaid]
					,[PaidDate]
					,[PaymentMode]
					)
					) AS PivotData
LEFT JOIN 	MostRecentDeletes mrd
	ON 		PivotData.PrimaryKey = mrd.PrimaryKey
	AND 	isnull(PivotData.PrimaryKey2,'') = isnull(mrd.PrimaryKey2,'')
	AND 	isnull(PivotData.PrimaryKey3,'') = isnull(mrd.PrimaryKey3,'')
	AND 	isnull(PivotData.PrimaryKey4,'') = isnull(mrd.PrimaryKey4,'')
	AND 	isnull(PivotData.PrimaryKey5,'') = isnull(mrd.PrimaryKey5,'')
	AND 	PivotData.HRowVersion = mrd.[RowVersion]
GO
/****** Object:  Table [dbo].[RentalHulling]    Script Date: 08/10/2016 11:42:07 ******/
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
/****** Object:  Table [dbo].[ProductPaymentInfo]    Script Date: 08/10/2016 11:42:07 ******/
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
	[NextPayDate] [datetime] NOT NULL,
	[Discount] [int] NULL,
	[settlementbalance] [money] NULL,
	[IsSettlement] [char](1) NULL,
 CONSTRAINT [PK_ProductPaymentInfo] PRIMARY KEY CLUSTERED 
(
	[ProductPaymentID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[ProductPaymentInfo] ([ProductPaymentID], [CustID], [TotalAmount], [Status], [LastModifiedBy], [LastModifiedDate], [ObsInd], [BuyerID], [MediatorID], [NextPayDate], [Discount], [settlementbalance], [IsSettlement]) VALUES (N'PP201608014176cc013af880', N'om', 225000.0000, N'P', N'om\test', CAST(0x0000A6550178C6B0 AS DateTime), N'N', N'BI2016080155275b7f285865', NULL, CAST(0x0000A5870178A388 AS DateTime), 0, 0.0000, NULL)
INSERT [dbo].[ProductPaymentInfo] ([ProductPaymentID], [CustID], [TotalAmount], [Status], [LastModifiedBy], [LastModifiedDate], [ObsInd], [BuyerID], [MediatorID], [NextPayDate], [Discount], [settlementbalance], [IsSettlement]) VALUES (N'PP201608014599a59dc25e7b', N'om', 420000.0000, N'P', N'om\test', CAST(0x0000A65500C7BEC4 AS DateTime), N'N', N'BI20160801221c51afedb486', NULL, CAST(0x0000A58700C75420 AS DateTime), NULL, NULL, NULL)
INSERT [dbo].[ProductPaymentInfo] ([ProductPaymentID], [CustID], [TotalAmount], [Status], [LastModifiedBy], [LastModifiedDate], [ObsInd], [BuyerID], [MediatorID], [NextPayDate], [Discount], [settlementbalance], [IsSettlement]) VALUES (N'PP20160801c939712459f340', N'om', 125000.0000, N'A', N'om\test', CAST(0x0000A65500D81530 AS DateTime), N'N', N'BI20160801221c51afedb486', NULL, CAST(0x0000A58700D671A8 AS DateTime), 3, 5000.0000, N'Y')
INSERT [dbo].[ProductPaymentInfo] ([ProductPaymentID], [CustID], [TotalAmount], [Status], [LastModifiedBy], [LastModifiedDate], [ObsInd], [BuyerID], [MediatorID], [NextPayDate], [Discount], [settlementbalance], [IsSettlement]) VALUES (N'PP201608093a6ebf50338f40', N'om', 100000.0000, N'P', N'om\test', CAST(0x0000A65D0140D408 AS DateTime), N'N', N'BI20160809f897baf6347149', NULL, CAST(0x0000A67B0140B464 AS DateTime), 0, 0.0000, NULL)
INSERT [dbo].[ProductPaymentInfo] ([ProductPaymentID], [CustID], [TotalAmount], [Status], [LastModifiedBy], [LastModifiedDate], [ObsInd], [BuyerID], [MediatorID], [NextPayDate], [Discount], [settlementbalance], [IsSettlement]) VALUES (N'PP20160809df23783990619e', N'om', 30000.0000, N'P', N'om\test', CAST(0x0000A65D013BF078 AS DateTime), N'N', N'BI20160809f897baf6347149', NULL, CAST(0x0000A67B013BA44C AS DateTime), 0, 0.0000, NULL)
INSERT [dbo].[ProductPaymentInfo] ([ProductPaymentID], [CustID], [TotalAmount], [Status], [LastModifiedBy], [LastModifiedDate], [ObsInd], [BuyerID], [MediatorID], [NextPayDate], [Discount], [settlementbalance], [IsSettlement]) VALUES (N'PP20160810cbb17e547b29b3', N'om', 200000.0000, N'P', N'om\test', CAST(0x0000A65E00B8C464 AS DateTime), N'N', N'BI20160809f897baf6347149', N'BI20160810c67423da75c367', CAST(0x0000A69900B888A0 AS DateTime), 0, 0.0000, NULL)
/****** Object:  StoredProcedure [Audit].[pAutoAuditArchive]    Script Date: 08/10/2016 11:42:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [Audit].[pAutoAuditArchive]
(
@ArchiveAfterNumberOfDays int = -1 --the number of days after which the audit data will be archived. (-1 means use setting from AuditSettings table.)
,@DeleteAfterNumberOfDays int = -1 --the number of days after which the audit data will be deleted from the archive (or active) table. (-1 means use setting from AuditSettings table.)
,@KeepLastEntry bit = 1 --The last Audit entry is not archived (even if it should based on dates) to ensure a sequential RowVersion is produced.
)
AS 

 -- generated by AutoAudit Version 3.30a on Jul 20 2016 10:07AM
 -- created by Paul Nielsen and John Sigouin 
 -- www.SQLServerBible.com 
 -- AutoAudit.codeplex.com 
 -- This SP moves Audit data from the active tables to the archive tables 
 -- and deletes Audit data older than the specified retention period. 

SET NoCount ON

 Begin Try 
	--PROCESS INPUT PARAMETERS
	--Archive Audit data older than (days)
	If 	ISNULL(@ArchiveAfterNumberOfDays,-1) <= -1
		BEGIN
			--get the setting from AuditSettings
			SELECT	@ArchiveAfterNumberOfDays = cast(SettingValue as integer)
			FROM	[Audit].[AuditSettings]
			WHERE	SettingName = 'Archive Audit data older than (days)'
		END

	--Delete Audit data older than (days)
	If 	ISNULL(@DeleteAfterNumberOfDays,-1) <= -1
		BEGIN
			--get the setting from AuditSettings
			SELECT	@DeleteAfterNumberOfDays = cast(SettingValue as integer)
			FROM	[Audit].[AuditSettings]
			WHERE	SettingName = 'Delete Audit data older than (days)'
		END

Declare @MinNumberOfDays int
SET @MinNumberOfDays = @ArchiveAfterNumberOfDays
If @DeleteAfterNumberOfDays < @ArchiveAfterNumberOfDays
	SET @MinNumberOfDays = @DeleteAfterNumberOfDays

--Start by deleting archive data as requested
Print 'Delete Archive'
DELETE	FROM	[Audit].[AuditDetailArchive]
WHERE	AuditHeaderID in (	SELECT	AuditHeaderID
							FROM	[Audit].[AuditHeaderArchive]
							WHERE	AuditDate < DATEADD(day, @DeleteAfterNumberOfDays * -1, getdate()));

--disable FK
ALTER TABLE [Audit].[AuditDetailArchive] NOCHECK CONSTRAINT fkAuditHeaderArchive

DELETE	FROM	[Audit].[AuditHeaderArchive]
WHERE	AuditDate < DATEADD(day, @DeleteAfterNumberOfDays * -1, getdate());

--enable FK
ALTER TABLE [Audit].[AuditDetailArchive] CHECK CONSTRAINT fkAuditHeaderArchive

Print 'Move to Archive'
--Don't bother archiving active if the delete period is <= to the archive period
If NOT @DeleteAfterNumberOfDays <= @ArchiveAfterNumberOfDays
	BEGIN
		--copy from  [AuditHeader] to [AuditHeaderArchive]
		INSERT [Audit].[AuditHeaderArchive]
		Select * FROM [Audit].[AuditHeader]
		WHERE	AuditDate < Dateadd(day, @ArchiveAfterNumberOfDays * -1, getdate())
		AND		AuditHeaderID not in 
		(Select max(AuditHeaderID) from [Audit].AuditHeader 
		where @KeepLastEntry = 1 
		group by TableName, PrimaryKey, PrimaryKey2, PrimaryKey3, PrimaryKey4, PrimaryKey5);

		--copy from  [AuditDetail] to [AuditDetailArchive]
		INSERT [Audit].[AuditDetailArchive]
		SELECT * FROM [Audit].[AuditDetail]
		WHERE	AuditHeaderID in (	SELECT	AuditHeaderID
							FROM	[Audit].[AuditHeader]
							WHERE	AuditDate < Dateadd(day, @ArchiveAfterNumberOfDays * -1, getdate())
							EXCEPT
							Select max(AuditHeaderID) from [Audit].[AuditHeader] 
							where @KeepLastEntry = 1 
							group by TableName, PrimaryKey, PrimaryKey2, PrimaryKey3, PrimaryKey4, PrimaryKey5);

	END

Print 'Delete Active'
--NOW delete from [AuditDetail] and [AuditHeader]
--delete Active data
DELETE	FROM	[Audit].[AuditDetail]
WHERE	AuditHeaderID in (	SELECT	AuditHeaderID
							FROM	[Audit].[AuditHeader]
							WHERE	AuditDate < DATEADD(day, @MinNumberOfDays * -1, getdate())
							EXCEPT
							Select max(AuditHeaderID) from [Audit].AuditHeader 
							where @KeepLastEntry = 1 
							group by TableName, PrimaryKey, PrimaryKey2, PrimaryKey3, PrimaryKey4, PrimaryKey5);

--disable FK
ALTER TABLE [Audit].[AuditDetail] NOCHECK CONSTRAINT fkAuditHeader

DELETE	FROM	[Audit].[AuditHeader]
WHERE	AuditDate < DATEADD(day, @MinNumberOfDays * -1, getdate())
		AND		AuditHeaderID not in 
		(Select max(AuditHeaderID) from [Audit].AuditHeader 
		where @KeepLastEntry = 1 
		group by TableName, PrimaryKey, PrimaryKey2, PrimaryKey3, PrimaryKey4, PrimaryKey5);

--disable FK
ALTER TABLE [Audit].[AuditDetail] CHECK CONSTRAINT fkAuditHeader

 End Try 
 Begin Catch 
   DECLARE @ErrorMessage NVARCHAR(4000), @ErrorSeverity INT, @ErrorState INT, @ErrorLine INT;
   SET @ErrorMessage = ERROR_MESSAGE();  
   SET @ErrorSeverity = ERROR_SEVERITY(); 
   SET @ErrorState = ERROR_STATE();  
   SET @ErrorLine = ERROR_LINE();  
   RAISERROR(@ErrorMessage,@ErrorSeverity,@ErrorState);
   PRINT 'Error Line: ' + cast(@ErrorLine as varchar);
 End Catch
GO
/****** Object:  Table [dbo].[BuyerSellerRating]    Script Date: 08/10/2016 11:42:07 ******/
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
/****** Object:  Table [dbo].[BagStockInfo]    Script Date: 08/10/2016 11:42:07 ******/
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
/****** Object:  Table [dbo].[BankTransaction]    Script Date: 08/10/2016 11:42:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[BankTransaction](
	[BankTransID] [nvarchar](50) NOT NULL,
	[CustID] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](4000) NOT NULL,
	[Withdraw] [money] NULL,
	[Deposit] [money] NULL,
	[Balance] [money] NOT NULL,
	[TransactionDate] [datetime] NOT NULL,
	[LastModifiedBy] [nvarchar](50) NOT NULL,
	[LastModifiedDate] [datetime] NOT NULL,
	[ObsInd] [char](1) NOT NULL,
 CONSTRAINT [PK_BankTransaction] PRIMARY KEY CLUSTERED 
(
	[BankTransID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[BankTransaction] ([BankTransID], [CustID], [Description], [Withdraw], [Deposit], [Balance], [TransactionDate], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (N'BT20160719c8bd713f9d224c', N'om', N'Added Bank Balance', 0.0000, 1000000.0000, 0.0000, CAST(0x0000A64800AD6448 AS DateTime), N'om\test', CAST(0x0000A64800AD6448 AS DateTime), N'N')
INSERT [dbo].[BankTransaction] ([BankTransID], [CustID], [Description], [Withdraw], [Deposit], [Balance], [TransactionDate], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (N'BT201607291975a0e08ddbc7', N'om', N'Ramesh, Paddy Payment, PaymentID:PP20160729dc0abc9198e9c0, Paid Date:7/29/2016 2:38:33 PM', 99000.0000, 0.0000, 0.0000, CAST(0x0000A65200F16B84 AS DateTime), N'om\test', CAST(0x0000A65200F16B84 AS DateTime), N'N')
INSERT [dbo].[BankTransaction] ([BankTransID], [CustID], [Description], [Withdraw], [Deposit], [Balance], [TransactionDate], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (N'BT20160729f273149db309ce', N'om', N'Chandrashekar, Paddy Payment, PaymentID:PP201607299fb7f8b867d580, Paid Date:7/29/2016 11:07:46 AM', 123456.0000, 0.0000, 0.0000, CAST(0x0000A65200B79E40 AS DateTime), N'om\test', CAST(0x0000A65200B79E40 AS DateTime), N'N')
INSERT [dbo].[BankTransaction] ([BankTransID], [CustID], [Description], [Withdraw], [Deposit], [Balance], [TransactionDate], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (N'BT201608015a7d7a9f4096ed', N'om', N'Anil, Product Payment Received, Product PaymentID:PP20160801f0646f0cb58d30, Amount Received Date:01-Aug-2016', 0.0000, 118800.0000, 0.0000, CAST(0x0000A65501413678 AS DateTime), N'om\test', CAST(0x0000A65501413678 AS DateTime), N'N')
INSERT [dbo].[BankTransaction] ([BankTransID], [CustID], [Description], [Withdraw], [Deposit], [Balance], [TransactionDate], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (N'BT201608018575afc4c69c6a', N'om', N'Madhu, Product Payment Received, Product PaymentID:PP20160801e55491295886e4, Amount Received Date:01-Aug-2016', 0.0000, 10000.0000, 0.0000, CAST(0x0000A6550178E2D0 AS DateTime), N'om\test', CAST(0x0000A6550178E2D0 AS DateTime), N'N')
INSERT [dbo].[BankTransaction] ([BankTransID], [CustID], [Description], [Withdraw], [Deposit], [Balance], [TransactionDate], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (N'BT20160801c647f05db7b488', N'om', N'Anil, Product Payment Received, Product PaymentID:PP20160801a196a59cfacdc4, Amount Received Date:01-Aug-2016', 0.0000, 100000.0000, 0.0000, CAST(0x0000A6550141516C AS DateTime), N'om\test', CAST(0x0000A6550141516C AS DateTime), N'N')
INSERT [dbo].[BankTransaction] ([BankTransID], [CustID], [Description], [Withdraw], [Deposit], [Balance], [TransactionDate], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (N'BT20160801cfb5dcbe59ca21', N'om', N'Anil, Product Payment Received, Product PaymentID:PP20160801cedecb83a527bc, Amount Received Date:01-Aug-2016', 0.0000, 100000.0000, 0.0000, CAST(0x0000A6550140F604 AS DateTime), N'om\test', CAST(0x0000A6550140F604 AS DateTime), N'N')
INSERT [dbo].[BankTransaction] ([BankTransID], [CustID], [Description], [Withdraw], [Deposit], [Balance], [TransactionDate], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (N'BT20160801d9edae63d4078f', N'om', N'Anil, Product Payment Received, Product PaymentID:PP201608017103592fe66b68, Amount Received Date:01-Aug-2016', 0.0000, 1200.0000, 0.0000, CAST(0x0000A655014110F8 AS DateTime), N'om\test', CAST(0x0000A655014110F8 AS DateTime), N'N')
INSERT [dbo].[BankTransaction] ([BankTransID], [CustID], [Description], [Withdraw], [Deposit], [Balance], [TransactionDate], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (N'BT20160801e76286d2bac023', N'om', N'Anil, Product Payment Received, Product PaymentID:PP201608017b8e344696804b, Amount Received Date:01-Aug-2016', 0.0000, 120000.0000, 0.0000, CAST(0x0000A65500D80978 AS DateTime), N'om\test', CAST(0x0000A65500D80978 AS DateTime), N'N')
INSERT [dbo].[BankTransaction] ([BankTransID], [CustID], [Description], [Withdraw], [Deposit], [Balance], [TransactionDate], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (N'BT2016080262bc89fd2a1209', N'om', N'Ramesh, Expense Amount Paid, ExpenseTransID:ExT20160802ac973333ab6f54, Amount Paid Date:02-Aug-YYYY', 5000.0000, 0.0000, 0.0000, CAST(0x0000A65600FA1004 AS DateTime), N'om\test', CAST(0x0000A65600FA1004 AS DateTime), N'N')
INSERT [dbo].[BankTransaction] ([BankTransID], [CustID], [Description], [Withdraw], [Deposit], [Balance], [TransactionDate], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (N'BT20160802d8b9e6d75e7eac', N'om', N'Ramesh, Paddy Payment, PaymentID:PP20160802928323c845729b, Paid Date:2/8/2016 3:05:07 PM', 261000.0000, 0.0000, 0.0000, CAST(0x0000A65600F8BD58 AS DateTime), N'om\test', CAST(0x0000A65600F8BD58 AS DateTime), N'N')
/****** Object:  Table [dbo].[BagPaymentInfo]    Script Date: 08/10/2016 11:42:07 ******/
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
/****** Object:  Table [dbo].[BrokenRiceStockInfo]    Script Date: 08/10/2016 11:42:07 ******/
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
INSERT [dbo].[BrokenRiceStockInfo] ([BrokenRiceStockID], [BrokenRiceTypeID], [CustID], [UnitsTypeID], [TotalBags], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (N'HTBR2016071935bc1d37dee65f', N'PT2016071941d02916ee4073', N'om', N'BT2016071938e099fbd69545', 4, N'om\test', CAST(0x0000A6480149F13C AS DateTime), N'N')
INSERT [dbo].[BrokenRiceStockInfo] ([BrokenRiceStockID], [BrokenRiceTypeID], [CustID], [UnitsTypeID], [TotalBags], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (N'HTBR20160719514672ffa42ac8', N'PT2016071941d02916ee4073', N'om', N'BT201607198b4fe854818fdc', 1, N'om\test', CAST(0x0000A64800BE1D24 AS DateTime), N'N')
INSERT [dbo].[BrokenRiceStockInfo] ([BrokenRiceStockID], [BrokenRiceTypeID], [CustID], [UnitsTypeID], [TotalBags], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (N'HTBR20160719c766262a0864bd', N'PT20160719523ece1e9b7000', N'om', N'BT201607198b4fe854818fdc', 2, N'om\test', CAST(0x0000A64800B5EB7C AS DateTime), N'N')
INSERT [dbo].[BrokenRiceStockInfo] ([BrokenRiceStockID], [BrokenRiceTypeID], [CustID], [UnitsTypeID], [TotalBags], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (N'HTBR201608098bd8224ab79c3d', N'PT20160719985d83a75b7627', N'om', N'BT201607198b4fe854818fdc', 4, N'om\test', CAST(0x0000A65D0140B0E0 AS DateTime), N'N')
/****** Object:  Table [dbo].[RiceStockInfo]    Script Date: 08/10/2016 11:42:07 ******/
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
INSERT [dbo].[RiceStockInfo] ([RiceStockID], [MRiceProdTypeID], [MRiceBrandID], [CustID], [UnitsTypeID], [TotalBags], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (N'HTR20160719167dfb800815ac', N'RP201607196cda0aa0548d47', N'RB20160719937050a760653c', N'om', N'BT2016071938e099fbd69545', 240, N'om\test', CAST(0x0000A64800B5EB7C AS DateTime), N'N')
INSERT [dbo].[RiceStockInfo] ([RiceStockID], [MRiceProdTypeID], [MRiceBrandID], [CustID], [UnitsTypeID], [TotalBags], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (N'HTR2016071991844b9b8fb46e', N'RP201607196cda0aa0548d47', N'RB20160719937050a760653c', N'om', N'BT2016071938e099fbd69545', 260, N'om\test', CAST(0x0000A6480149F13C AS DateTime), N'N')
INSERT [dbo].[RiceStockInfo] ([RiceStockID], [MRiceProdTypeID], [MRiceBrandID], [CustID], [UnitsTypeID], [TotalBags], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (N'HTR20160719e072be2181ef7e', N'RP201607196cda0aa0548d47', N'RB20160719937050a760653c', N'om', N'BT2016071938e099fbd69545', 230, N'om\test', CAST(0x0000A64800BE1D24 AS DateTime), N'N')
INSERT [dbo].[RiceStockInfo] ([RiceStockID], [MRiceProdTypeID], [MRiceBrandID], [CustID], [UnitsTypeID], [TotalBags], [LastModifiedBy], [LastModifiedDate], [ObsInd]) VALUES (N'HTR20160809165e949fe31762', N'RP201607196cda0aa0548d47', N'RB20160719937050a760653c', N'om', N'BT2016071938e099fbd69545', 600, N'om\test', CAST(0x0000A65D0140B0E0 AS DateTime), N'N')
/****** Object:  View [Audit].[vAudit]    Script Date: 08/10/2016 11:42:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [Audit].[vAudit]
AS 

 -- generated by AutoAudit Version 3.30a on Jul 20 2016 10:07AM
 -- created by Paul Nielsen and John Sigouin 
 -- www.SQLServerBible.com 
 -- AutoAudit.codeplex.com 
 -- This view returns data from the live AutoAudit tables formatted to match the AutoAudit 2.00h Audit table.

SELECT	AH.[AuditHeaderID] as AuditID
			,AH.[AuditDate]
			,AH.[HostName]
			,AH.[SysUser]
			,AH.[Application]
			,AH.[TableName]
			,AH.[Operation]
			,AH.[SQLStatement]
			,AH.[PrimaryKey]
			,AH.[PrimaryKey2]
			,AH.[PrimaryKey3]
			,AH.[PrimaryKey4]
			,AH.[PrimaryKey5]
			,AH.[RowDescription]
			,AH.[SecondaryRow]
			,AD.[ColumnName]
			,AD.[OldValue]
			,AD.[NewValue]
			,AH.[RowVersion]
FROM		[Audit].[AuditHeader] AH
LEFT JOIN [Audit].[AuditDetail] AD
	ON		AH.[AuditHeaderID] = AD.[AuditHeaderID];
GO
/****** Object:  View [Audit].[vAuditDetailAll]    Script Date: 08/10/2016 11:42:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [Audit].[vAuditDetailAll]
AS 

 -- generated by AutoAudit Version 3.30a on Jul 20 2016 10:07AM
 -- created by Paul Nielsen and John Sigouin 
 -- www.SQLServerBible.com 
 -- AutoAudit.codeplex.com 
 -- This view returns data from the AuditDetail and AuditDetailArchive AutoAudit tables. 

SELECT	cast('Active' as varchar(7)) as Source 
,[AuditDetailID]
,[AuditHeaderID]
,[ColumnName]
,[OldValue]
,[NewValue]
FROM		[Audit].[AuditDetail] AD
UNION All 
SELECT	cast('Archive' as varchar(7)) as Source 
,[AuditDetailID]
,[AuditHeaderID]
,[ColumnName]
,[OldValue]
,[NewValue]
FROM		[Audit].[AuditDetailArchive] ADA;
GO
/****** Object:  View [Audit].[vAuditArchive]    Script Date: 08/10/2016 11:42:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [Audit].[vAuditArchive]
AS 

 -- generated by AutoAudit Version 3.30a on Jul 20 2016 10:07AM
 -- created by Paul Nielsen and John Sigouin 
 -- www.SQLServerBible.com 
 -- AutoAudit.codeplex.com 
 -- This view returns data from the Archive AutoAudit tables. 

SELECT	AH.[AuditHeaderID] as AuditID
			,AH.[AuditDate]
			,AH.[HostName]
			,AH.[SysUser]
			,AH.[Application]
			,AH.[TableName]
			,AH.[Operation]
			,AH.[SQLStatement]
			,AH.[PrimaryKey]
			,AH.[PrimaryKey2]
			,AH.[PrimaryKey3]
			,AH.[PrimaryKey4]
			,AH.[PrimaryKey5]
			,AH.[RowDescription]
			,AH.[SecondaryRow]
			,AD.[ColumnName]
			,AD.[OldValue]
			,AD.[NewValue]
			,AH.[RowVersion]
FROM		[Audit].[AuditHeaderArchive] AH
LEFT JOIN [Audit].[AuditDetailArchive] AD
	ON		AH.[AuditHeaderID] = AD.[AuditHeaderID];
GO
/****** Object:  View [Audit].[vAuditAll]    Script Date: 08/10/2016 11:42:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [Audit].[vAuditAll]
AS 

 -- generated by AutoAudit Version 3.30a on Jul 20 2016 10:07AM
 -- created by Paul Nielsen and John Sigouin 
 -- www.SQLServerBible.com 
 -- AutoAudit.codeplex.com 
 -- This view returns data from the Active and Archive AutoAudit tables. 

SELECT	cast('Active' as varchar(7)) as Source, * FROM		[Audit].[vAudit] vA
UNION All 
SELECT	cast('Archive' as varchar(7)) as Source, * FROM		[Audit].[vAuditArchive] vAA;
GO
/****** Object:  UserDefinedFunction [dbo].[RentalHulling_TableRecovery]    Script Date: 08/10/2016 11:42:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[RentalHulling_TableRecovery]
			(
			@RecoveryTime datetime
			)

 -- NEW generated by AutoAudit Version 3.30a on Jul 20 2016 10:07AM
 -- created by Paul Nielsen and John Sigouin 
 -- www.SQLServerBible.com 
 -- AutoAudit.codeplex.com 
 -- This function retrieves an image of the table as it existed at the specified point in time.

RETURNS @HistoryData Table
(
[RentalHulingID]nvarchar (100)
,[CustID]nvarchar (100)
,[TotalBags]int
,[Price]money
) 
AS 
BEGIN 

-- Create table variable to hold history records.
Declare @AuditDataExtract table
	(
	AuditDate datetime
	,Operation varchar(1)
	,[RowVersion] int
	,[RentalHulingID] varchar(50)
	,[CustID] varchar(50)
	,[TotalBags] varchar(50)
	,[Price] varchar(50)
	) 

-- Detailed data retrieval is enabled for this table.
--write the full history for the table into a temp table variable for performance.
Insert @AuditDataExtract 
Select 
			AuditDate
			,Operation
			,[RowVersion]
			,[RentalHulingID]
			,[CustID]
			,[TotalBags]
			,[Price]
FROM		[dbo].[vRentalHulling_RowHistory]

-- Detailed data retrieval is enabled for this table.
;With	AuditDataExtract --Source data query
	AS
	(
	SELECT		*
	FROM		@AuditDataExtract
	),
	CurrentRowExtract 
	AS
	(
	Select		getdate() as AuditDate
				,'c' as Operation
				,(Select isnull(max([RowVersion]),0) + 1 from AuditDataExtract 
				Where	1=1 
					and	AuditDataExtract.[RentalHulingID] = [dbo].[RentalHulling].[RentalHulingID]
				) as [RowVersion]
				,[RentalHulingID]
				,cast([CustID] as varchar(50)) as [CustID]
				,cast([TotalBags] as varchar(50)) as [TotalBags]
				,cast([Price] as varchar(50)) as [Price]
	from		[dbo].[RentalHulling]
			),
			RowHistoryExtract
			AS
			(
			Select * from AuditDataExtract
			Union All
			Select * from CurrentRowExtract
			),
			MostRecentRows
			AS
			(
			--Get most recent rows
			Select 
						max([RowVersion]) as MostRecentRow
						,[RentalHulingID]
			from		RowHistoryExtract
			Group By	
						[RentalHulingID]
			),
			RowHistory
			AS
			(
			--Anchor query for RowHistory buildup. Get the most current rowversion
			Select		
			RowHistoryExtract.AuditDate
			,RowHistoryExtract.Operation
			,RowHistoryExtract.[RowVersion]
			,RowHistoryExtract.[RentalHulingID]
			,RowHistoryExtract.[CustID]
			,RowHistoryExtract.[TotalBags]
			,RowHistoryExtract.[Price]
			From		RowHistoryExtract
			inner join	MostRecentRows
				on		RowHistoryExtract.[RowVersion] = MostRecentRows.MostRecentRow
				and		RowHistoryExtract.[RentalHulingID] = MostRecentRows.[RentalHulingID]
			UNION All
			--Recursive query for RowHistory buildup
			Select		NextVersion.AuditDate
						,NextVersion.Operation
						,NextVersion.[RowVersion]
						,isnull(NextVersion.[RentalHulingID] , PreviousVersion.[RentalHulingID])
						,isnull(NextVersion.[CustID] , PreviousVersion.[CustID])
						,isnull(NextVersion.[TotalBags] , PreviousVersion.[TotalBags])
						,isnull(NextVersion.[Price] , PreviousVersion.[Price])
			from		RowHistoryExtract as NextVersion
			Inner join	RowHistory as PreviousVersion
				on		PreviousVersion.[RowVersion] = NextVersion.[RowVersion] + 1
				and		PreviousVersion.[RentalHulingID] = NextVersion.[RentalHulingID]
			),
			RowsOfInterest
			AS
			(
			--Get Rows Of Interest
			Select		max([RowVersion]) as [RowVersion]
						,[RentalHulingID]
			from		RowHistory
			Where		[AuditDate] <= @RecoveryTime
				And		Operation <> 'c'
			Group By		
						[RentalHulingID]
			)
-- Statement that executes the CTE
Insert into @HistoryData
--Returns the function table
Select 
			rh.[RentalHulingID]
			,nullif(rh.[CustID],'<-null->')
			,nullif(rh.[TotalBags],'<-null->')
			,nullif(rh.[Price],'<-null->')
FROM		RowHistory as rh
Inner join	RowsOfInterest as roi
	on		rh.[RowVersion] = roi.[RowVersion]
	and		rh.[RentalHulingID] = roi.[RentalHulingID]
Where		Operation <> 'd'
order by 
			rh.[RentalHulingID],
			rh.[RowVersion],
			rh.AuditDate
option		(MAXRECURSION 10000)

Return 
END
GO
/****** Object:  UserDefinedFunction [dbo].[RentalHulling_RowHistory]    Script Date: 08/10/2016 11:42:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[RentalHulling_RowHistory]
			(
			@PK varchar(36)
			)

 -- generated by AutoAudit Version 3.30a on Jul 20 2016 10:07AM
 -- created by Paul Nielsen and John Sigouin 
 -- www.SQLServerBible.com 
 -- AutoAudit.codeplex.com 
 -- This function retrieves data from the RowHistory view for the referenced table for the record identified by the PK parameters.

RETURNS @HistoryData Table
(
AuditDate datetime
,Operation varchar(1)
,[RowVersion] int
,[RentalHulingID]nvarchar (100)
,[CustID]nvarchar (100)
,[TotalBags]int
,[Price]money
,ViewScope varchar(10)
,RowHistorySource varchar(10)
,SysUser sysname
,[Application] varchar(128)
,SQLStatement varchar(max)
) 
AS 
BEGIN 

-- Detailed data retrieval is enabled for this table.
With	AuditDataExtract --Source data query
	AS
	(
	SELECT		*
	FROM		[dbo].[vRentalHulling_RowHistory]
	WHERE		[RentalHulingID] = @PK 
	),
	CurrentRowExtract 
	AS
	(
	Select	getdate() as AuditDate
			,'c' as Operation
			,(Select isnull(max([RowVersion]),0) + 1 from AuditDataExtract) as [RowVersion]
			,[RentalHulingID]
			,cast([CustID] as varchar(50)) as [CustID]
			,cast([TotalBags] as varchar(50)) as [TotalBags]
			,cast([Price] as varchar(50)) as [Price]
			,null as ViewScope
			,null as RowHistorySource
			,null as SysUser
			,null as [Application]
			,null as SQLStatement
			from	[dbo].[RentalHulling]
	WHERE		[RentalHulingID] = @PK 
			),
			RowHistoryExtract
			AS
			(
			Select * from AuditDataExtract
			Union All
			Select * from CurrentRowExtract
			),
			RowHistory
			AS
			(
			--Anchor query for RowHistory buildup. Get the most current rowversion
			Select		top 1 *
			From		RowHistoryExtract
			order by	[RowVersion] desc

			UNION All
			--Recursive query for RowHistory buildup
			Select		NextVersion.AuditDate
						,NextVersion.Operation
						,NextVersion.[RowVersion]
						,isnull(NextVersion.[RentalHulingID] , PreviousVersion.[RentalHulingID])
						,isnull(NextVersion.[CustID] , PreviousVersion.[CustID])
						,isnull(NextVersion.[TotalBags] , PreviousVersion.[TotalBags])
						,isnull(NextVersion.[Price] , PreviousVersion.[Price])
						,NextVersion.ViewScope
						,NextVersion.RowHistorySource
						,NextVersion.SysUser
						,NextVersion.[Application]
						,NextVersion.SQLStatement
			from		RowHistoryExtract as NextVersion
			Inner join	RowHistory as PreviousVersion
				on		PreviousVersion.[RowVersion] = NextVersion.[RowVersion] + 1
				and		PreviousVersion.[RentalHulingID] = NextVersion.[RentalHulingID]
			)
-- Statement that executes the CTE
Insert into @HistoryData
	--Returns the function table
	Select	AuditDate
			,Operation
			,[RowVersion]
			,[RentalHulingID]
			, nullif([CustID],'<-null->')
			, nullif([TotalBags],'<-null->')
			, nullif([Price],'<-null->')
			,ViewScope
			,RowHistorySource
			,SysUser
			,[Application]
			,SQLStatement
FROM		RowHistory
where		Operation <> 'c'
order by	[RowVersion],AuditDate
option		(MAXRECURSION 10000)

Return 
END
GO
/****** Object:  UserDefinedFunction [dbo].[BankTransaction_TableRecovery]    Script Date: 08/10/2016 11:42:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[BankTransaction_TableRecovery]
			(
			@RecoveryTime datetime
			)

 -- NEW generated by AutoAudit Version 3.30a on Jul 20 2016 10:07AM
 -- created by Paul Nielsen and John Sigouin 
 -- www.SQLServerBible.com 
 -- AutoAudit.codeplex.com 
 -- This function retrieves an image of the table as it existed at the specified point in time.

RETURNS @HistoryData Table
(
[BankTransID]nvarchar (100)
,[CustID]nvarchar (100)
,[Withdraw]money
,[Deposit]money
,[Balance]money
) 
AS 
BEGIN 

-- Create table variable to hold history records.
Declare @AuditDataExtract table
	(
	AuditDate datetime
	,Operation varchar(1)
	,[RowVersion] int
	,[BankTransID] varchar(50)
	,[CustID] varchar(50)
	,[Withdraw] varchar(50)
	,[Deposit] varchar(50)
	,[Balance] varchar(50)
	) 

-- Detailed data retrieval is enabled for this table.
--write the full history for the table into a temp table variable for performance.
Insert @AuditDataExtract 
Select 
			AuditDate
			,Operation
			,[RowVersion]
			,[BankTransID]
			,[CustID]
			,[Withdraw]
			,[Deposit]
			,[Balance]
FROM		[dbo].[vBankTransaction_RowHistory]

-- Detailed data retrieval is enabled for this table.
;With	AuditDataExtract --Source data query
	AS
	(
	SELECT		*
	FROM		@AuditDataExtract
	),
	CurrentRowExtract 
	AS
	(
	Select		getdate() as AuditDate
				,'c' as Operation
				,(Select isnull(max([RowVersion]),0) + 1 from AuditDataExtract 
				Where	1=1 
					and	AuditDataExtract.[BankTransID] = [dbo].[BankTransaction].[BankTransID]
				) as [RowVersion]
				,[BankTransID]
				,cast([CustID] as varchar(50)) as [CustID]
				,cast([Withdraw] as varchar(50)) as [Withdraw]
				,cast([Deposit] as varchar(50)) as [Deposit]
				,cast([Balance] as varchar(50)) as [Balance]
	from		[dbo].[BankTransaction]
			),
			RowHistoryExtract
			AS
			(
			Select * from AuditDataExtract
			Union All
			Select * from CurrentRowExtract
			),
			MostRecentRows
			AS
			(
			--Get most recent rows
			Select 
						max([RowVersion]) as MostRecentRow
						,[BankTransID]
			from		RowHistoryExtract
			Group By	
						[BankTransID]
			),
			RowHistory
			AS
			(
			--Anchor query for RowHistory buildup. Get the most current rowversion
			Select		
			RowHistoryExtract.AuditDate
			,RowHistoryExtract.Operation
			,RowHistoryExtract.[RowVersion]
			,RowHistoryExtract.[BankTransID]
			,RowHistoryExtract.[CustID]
			,RowHistoryExtract.[Withdraw]
			,RowHistoryExtract.[Deposit]
			,RowHistoryExtract.[Balance]
			From		RowHistoryExtract
			inner join	MostRecentRows
				on		RowHistoryExtract.[RowVersion] = MostRecentRows.MostRecentRow
				and		RowHistoryExtract.[BankTransID] = MostRecentRows.[BankTransID]
			UNION All
			--Recursive query for RowHistory buildup
			Select		NextVersion.AuditDate
						,NextVersion.Operation
						,NextVersion.[RowVersion]
						,isnull(NextVersion.[BankTransID] , PreviousVersion.[BankTransID])
						,isnull(NextVersion.[CustID] , PreviousVersion.[CustID])
						,isnull(NextVersion.[Withdraw] , PreviousVersion.[Withdraw])
						,isnull(NextVersion.[Deposit] , PreviousVersion.[Deposit])
						,isnull(NextVersion.[Balance] , PreviousVersion.[Balance])
			from		RowHistoryExtract as NextVersion
			Inner join	RowHistory as PreviousVersion
				on		PreviousVersion.[RowVersion] = NextVersion.[RowVersion] + 1
				and		PreviousVersion.[BankTransID] = NextVersion.[BankTransID]
			),
			RowsOfInterest
			AS
			(
			--Get Rows Of Interest
			Select		max([RowVersion]) as [RowVersion]
						,[BankTransID]
			from		RowHistory
			Where		[AuditDate] <= @RecoveryTime
				And		Operation <> 'c'
			Group By		
						[BankTransID]
			)
-- Statement that executes the CTE
Insert into @HistoryData
--Returns the function table
Select 
			rh.[BankTransID]
			,nullif(rh.[CustID],'<-null->')
			,nullif(rh.[Withdraw],'<-null->')
			,nullif(rh.[Deposit],'<-null->')
			,nullif(rh.[Balance],'<-null->')
FROM		RowHistory as rh
Inner join	RowsOfInterest as roi
	on		rh.[RowVersion] = roi.[RowVersion]
	and		rh.[BankTransID] = roi.[BankTransID]
Where		Operation <> 'd'
order by 
			rh.[BankTransID],
			rh.[RowVersion],
			rh.AuditDate
option		(MAXRECURSION 10000)

Return 
END
GO
/****** Object:  UserDefinedFunction [dbo].[BankTransaction_RowHistory]    Script Date: 08/10/2016 11:42:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[BankTransaction_RowHistory]
			(
			@PK varchar(36)
			)

 -- generated by AutoAudit Version 3.30a on Jul 20 2016 10:07AM
 -- created by Paul Nielsen and John Sigouin 
 -- www.SQLServerBible.com 
 -- AutoAudit.codeplex.com 
 -- This function retrieves data from the RowHistory view for the referenced table for the record identified by the PK parameters.

RETURNS @HistoryData Table
(
AuditDate datetime
,Operation varchar(1)
,[RowVersion] int
,[BankTransID]nvarchar (100)
,[CustID]nvarchar (100)
,[Withdraw]money
,[Deposit]money
,[Balance]money
,ViewScope varchar(10)
,RowHistorySource varchar(10)
,SysUser sysname
,[Application] varchar(128)
,SQLStatement varchar(max)
) 
AS 
BEGIN 

-- Detailed data retrieval is enabled for this table.
With	AuditDataExtract --Source data query
	AS
	(
	SELECT		*
	FROM		[dbo].[vBankTransaction_RowHistory]
	WHERE		[BankTransID] = @PK 
	),
	CurrentRowExtract 
	AS
	(
	Select	getdate() as AuditDate
			,'c' as Operation
			,(Select isnull(max([RowVersion]),0) + 1 from AuditDataExtract) as [RowVersion]
			,[BankTransID]
			,cast([CustID] as varchar(50)) as [CustID]
			,cast([Withdraw] as varchar(50)) as [Withdraw]
			,cast([Deposit] as varchar(50)) as [Deposit]
			,cast([Balance] as varchar(50)) as [Balance]
			,null as ViewScope
			,null as RowHistorySource
			,null as SysUser
			,null as [Application]
			,null as SQLStatement
			from	[dbo].[BankTransaction]
	WHERE		[BankTransID] = @PK 
			),
			RowHistoryExtract
			AS
			(
			Select * from AuditDataExtract
			Union All
			Select * from CurrentRowExtract
			),
			RowHistory
			AS
			(
			--Anchor query for RowHistory buildup. Get the most current rowversion
			Select		top 1 *
			From		RowHistoryExtract
			order by	[RowVersion] desc

			UNION All
			--Recursive query for RowHistory buildup
			Select		NextVersion.AuditDate
						,NextVersion.Operation
						,NextVersion.[RowVersion]
						,isnull(NextVersion.[BankTransID] , PreviousVersion.[BankTransID])
						,isnull(NextVersion.[CustID] , PreviousVersion.[CustID])
						,isnull(NextVersion.[Withdraw] , PreviousVersion.[Withdraw])
						,isnull(NextVersion.[Deposit] , PreviousVersion.[Deposit])
						,isnull(NextVersion.[Balance] , PreviousVersion.[Balance])
						,NextVersion.ViewScope
						,NextVersion.RowHistorySource
						,NextVersion.SysUser
						,NextVersion.[Application]
						,NextVersion.SQLStatement
			from		RowHistoryExtract as NextVersion
			Inner join	RowHistory as PreviousVersion
				on		PreviousVersion.[RowVersion] = NextVersion.[RowVersion] + 1
				and		PreviousVersion.[BankTransID] = NextVersion.[BankTransID]
			)
-- Statement that executes the CTE
Insert into @HistoryData
	--Returns the function table
	Select	AuditDate
			,Operation
			,[RowVersion]
			,[BankTransID]
			, nullif([CustID],'<-null->')
			, nullif([Withdraw],'<-null->')
			, nullif([Deposit],'<-null->')
			, nullif([Balance],'<-null->')
			,ViewScope
			,RowHistorySource
			,SysUser
			,[Application]
			,SQLStatement
FROM		RowHistory
where		Operation <> 'c'
order by	[RowVersion],AuditDate
option		(MAXRECURSION 10000)

Return 
END
GO
/****** Object:  UserDefinedFunction [dbo].[BagStockInfo_TableRecovery]    Script Date: 08/10/2016 11:42:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[BagStockInfo_TableRecovery]
			(
			@RecoveryTime datetime
			)

 -- NEW generated by AutoAudit Version 3.30a on Jul 20 2016 10:07AM
 -- created by Paul Nielsen and John Sigouin 
 -- www.SQLServerBible.com 
 -- AutoAudit.codeplex.com 
 -- This function retrieves an image of the table as it existed at the specified point in time.

RETURNS @HistoryData Table
(
[BagStockID]nvarchar (100)
,[CustID]nvarchar (100)
,[Price]money
,[TotalBags]int
) 
AS 
BEGIN 

-- Create table variable to hold history records.
Declare @AuditDataExtract table
	(
	AuditDate datetime
	,Operation varchar(1)
	,[RowVersion] int
	,[BagStockID] varchar(50)
	,[CustID] varchar(50)
	,[Price] varchar(50)
	,[TotalBags] varchar(50)
	) 

-- Detailed data retrieval is enabled for this table.
--write the full history for the table into a temp table variable for performance.
Insert @AuditDataExtract 
Select 
			AuditDate
			,Operation
			,[RowVersion]
			,[BagStockID]
			,[CustID]
			,[Price]
			,[TotalBags]
FROM		[dbo].[vBagStockInfo_RowHistory]

-- Detailed data retrieval is enabled for this table.
;With	AuditDataExtract --Source data query
	AS
	(
	SELECT		*
	FROM		@AuditDataExtract
	),
	CurrentRowExtract 
	AS
	(
	Select		getdate() as AuditDate
				,'c' as Operation
				,(Select isnull(max([RowVersion]),0) + 1 from AuditDataExtract 
				Where	1=1 
					and	AuditDataExtract.[BagStockID] = [dbo].[BagStockInfo].[BagStockID]
				) as [RowVersion]
				,[BagStockID]
				,cast([CustID] as varchar(50)) as [CustID]
				,cast([Price] as varchar(50)) as [Price]
				,cast([TotalBags] as varchar(50)) as [TotalBags]
	from		[dbo].[BagStockInfo]
			),
			RowHistoryExtract
			AS
			(
			Select * from AuditDataExtract
			Union All
			Select * from CurrentRowExtract
			),
			MostRecentRows
			AS
			(
			--Get most recent rows
			Select 
						max([RowVersion]) as MostRecentRow
						,[BagStockID]
			from		RowHistoryExtract
			Group By	
						[BagStockID]
			),
			RowHistory
			AS
			(
			--Anchor query for RowHistory buildup. Get the most current rowversion
			Select		
			RowHistoryExtract.AuditDate
			,RowHistoryExtract.Operation
			,RowHistoryExtract.[RowVersion]
			,RowHistoryExtract.[BagStockID]
			,RowHistoryExtract.[CustID]
			,RowHistoryExtract.[Price]
			,RowHistoryExtract.[TotalBags]
			From		RowHistoryExtract
			inner join	MostRecentRows
				on		RowHistoryExtract.[RowVersion] = MostRecentRows.MostRecentRow
				and		RowHistoryExtract.[BagStockID] = MostRecentRows.[BagStockID]
			UNION All
			--Recursive query for RowHistory buildup
			Select		NextVersion.AuditDate
						,NextVersion.Operation
						,NextVersion.[RowVersion]
						,isnull(NextVersion.[BagStockID] , PreviousVersion.[BagStockID])
						,isnull(NextVersion.[CustID] , PreviousVersion.[CustID])
						,isnull(NextVersion.[Price] , PreviousVersion.[Price])
						,isnull(NextVersion.[TotalBags] , PreviousVersion.[TotalBags])
			from		RowHistoryExtract as NextVersion
			Inner join	RowHistory as PreviousVersion
				on		PreviousVersion.[RowVersion] = NextVersion.[RowVersion] + 1
				and		PreviousVersion.[BagStockID] = NextVersion.[BagStockID]
			),
			RowsOfInterest
			AS
			(
			--Get Rows Of Interest
			Select		max([RowVersion]) as [RowVersion]
						,[BagStockID]
			from		RowHistory
			Where		[AuditDate] <= @RecoveryTime
				And		Operation <> 'c'
			Group By		
						[BagStockID]
			)
-- Statement that executes the CTE
Insert into @HistoryData
--Returns the function table
Select 
			rh.[BagStockID]
			,nullif(rh.[CustID],'<-null->')
			,nullif(rh.[Price],'<-null->')
			,nullif(rh.[TotalBags],'<-null->')
FROM		RowHistory as rh
Inner join	RowsOfInterest as roi
	on		rh.[RowVersion] = roi.[RowVersion]
	and		rh.[BagStockID] = roi.[BagStockID]
Where		Operation <> 'd'
order by 
			rh.[BagStockID],
			rh.[RowVersion],
			rh.AuditDate
option		(MAXRECURSION 10000)

Return 
END
GO
/****** Object:  UserDefinedFunction [dbo].[BagStockInfo_RowHistory]    Script Date: 08/10/2016 11:42:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[BagStockInfo_RowHistory]
			(
			@PK varchar(36)
			)

 -- generated by AutoAudit Version 3.30a on Jul 20 2016 10:07AM
 -- created by Paul Nielsen and John Sigouin 
 -- www.SQLServerBible.com 
 -- AutoAudit.codeplex.com 
 -- This function retrieves data from the RowHistory view for the referenced table for the record identified by the PK parameters.

RETURNS @HistoryData Table
(
AuditDate datetime
,Operation varchar(1)
,[RowVersion] int
,[BagStockID]nvarchar (100)
,[CustID]nvarchar (100)
,[Price]money
,[TotalBags]int
,ViewScope varchar(10)
,RowHistorySource varchar(10)
,SysUser sysname
,[Application] varchar(128)
,SQLStatement varchar(max)
) 
AS 
BEGIN 

-- Detailed data retrieval is enabled for this table.
With	AuditDataExtract --Source data query
	AS
	(
	SELECT		*
	FROM		[dbo].[vBagStockInfo_RowHistory]
	WHERE		[BagStockID] = @PK 
	),
	CurrentRowExtract 
	AS
	(
	Select	getdate() as AuditDate
			,'c' as Operation
			,(Select isnull(max([RowVersion]),0) + 1 from AuditDataExtract) as [RowVersion]
			,[BagStockID]
			,cast([CustID] as varchar(50)) as [CustID]
			,cast([Price] as varchar(50)) as [Price]
			,cast([TotalBags] as varchar(50)) as [TotalBags]
			,null as ViewScope
			,null as RowHistorySource
			,null as SysUser
			,null as [Application]
			,null as SQLStatement
			from	[dbo].[BagStockInfo]
	WHERE		[BagStockID] = @PK 
			),
			RowHistoryExtract
			AS
			(
			Select * from AuditDataExtract
			Union All
			Select * from CurrentRowExtract
			),
			RowHistory
			AS
			(
			--Anchor query for RowHistory buildup. Get the most current rowversion
			Select		top 1 *
			From		RowHistoryExtract
			order by	[RowVersion] desc

			UNION All
			--Recursive query for RowHistory buildup
			Select		NextVersion.AuditDate
						,NextVersion.Operation
						,NextVersion.[RowVersion]
						,isnull(NextVersion.[BagStockID] , PreviousVersion.[BagStockID])
						,isnull(NextVersion.[CustID] , PreviousVersion.[CustID])
						,isnull(NextVersion.[Price] , PreviousVersion.[Price])
						,isnull(NextVersion.[TotalBags] , PreviousVersion.[TotalBags])
						,NextVersion.ViewScope
						,NextVersion.RowHistorySource
						,NextVersion.SysUser
						,NextVersion.[Application]
						,NextVersion.SQLStatement
			from		RowHistoryExtract as NextVersion
			Inner join	RowHistory as PreviousVersion
				on		PreviousVersion.[RowVersion] = NextVersion.[RowVersion] + 1
				and		PreviousVersion.[BagStockID] = NextVersion.[BagStockID]
			)
-- Statement that executes the CTE
Insert into @HistoryData
	--Returns the function table
	Select	AuditDate
			,Operation
			,[RowVersion]
			,[BagStockID]
			, nullif([CustID],'<-null->')
			, nullif([Price],'<-null->')
			, nullif([TotalBags],'<-null->')
			,ViewScope
			,RowHistorySource
			,SysUser
			,[Application]
			,SQLStatement
FROM		RowHistory
where		Operation <> 'c'
order by	[RowVersion],AuditDate
option		(MAXRECURSION 10000)

Return 
END
GO
/****** Object:  UserDefinedFunction [dbo].[BagPaymentInfo_TableRecovery]    Script Date: 08/10/2016 11:42:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[BagPaymentInfo_TableRecovery]
			(
			@RecoveryTime datetime
			)

 -- NEW generated by AutoAudit Version 3.30a on Jul 20 2016 10:07AM
 -- created by Paul Nielsen and John Sigouin 
 -- www.SQLServerBible.com 
 -- AutoAudit.codeplex.com 
 -- This function retrieves an image of the table as it existed at the specified point in time.

RETURNS @HistoryData Table
(
[BagPaymentID]nvarchar (100)
,[CustID]nvarchar (100)
,[AmountPaid]money
,[PaidDate]datetime
,[PaymentMode]nvarchar (40)
) 
AS 
BEGIN 

-- Create table variable to hold history records.
Declare @AuditDataExtract table
	(
	AuditDate datetime
	,Operation varchar(1)
	,[RowVersion] int
	,[BagPaymentID] varchar(50)
	,[CustID] varchar(50)
	,[AmountPaid] varchar(50)
	,[PaidDate] varchar(50)
	,[PaymentMode] varchar(50)
	) 

-- Detailed data retrieval is enabled for this table.
--write the full history for the table into a temp table variable for performance.
Insert @AuditDataExtract 
Select 
			AuditDate
			,Operation
			,[RowVersion]
			,[BagPaymentID]
			,[CustID]
			,[AmountPaid]
			,[PaidDate]
			,[PaymentMode]
FROM		[dbo].[vBagPaymentInfo_RowHistory]

-- Detailed data retrieval is enabled for this table.
;With	AuditDataExtract --Source data query
	AS
	(
	SELECT		*
	FROM		@AuditDataExtract
	),
	CurrentRowExtract 
	AS
	(
	Select		getdate() as AuditDate
				,'c' as Operation
				,(Select isnull(max([RowVersion]),0) + 1 from AuditDataExtract 
				Where	1=1 
					and	AuditDataExtract.[BagPaymentID] = [dbo].[BagPaymentInfo].[BagPaymentID]
				) as [RowVersion]
				,[BagPaymentID]
				,cast([CustID] as varchar(50)) as [CustID]
				,cast([AmountPaid] as varchar(50)) as [AmountPaid]
				,cast([PaidDate] as varchar(50)) as [PaidDate]
				,cast([PaymentMode] as varchar(50)) as [PaymentMode]
	from		[dbo].[BagPaymentInfo]
			),
			RowHistoryExtract
			AS
			(
			Select * from AuditDataExtract
			Union All
			Select * from CurrentRowExtract
			),
			MostRecentRows
			AS
			(
			--Get most recent rows
			Select 
						max([RowVersion]) as MostRecentRow
						,[BagPaymentID]
			from		RowHistoryExtract
			Group By	
						[BagPaymentID]
			),
			RowHistory
			AS
			(
			--Anchor query for RowHistory buildup. Get the most current rowversion
			Select		
			RowHistoryExtract.AuditDate
			,RowHistoryExtract.Operation
			,RowHistoryExtract.[RowVersion]
			,RowHistoryExtract.[BagPaymentID]
			,RowHistoryExtract.[CustID]
			,RowHistoryExtract.[AmountPaid]
			,RowHistoryExtract.[PaidDate]
			,RowHistoryExtract.[PaymentMode]
			From		RowHistoryExtract
			inner join	MostRecentRows
				on		RowHistoryExtract.[RowVersion] = MostRecentRows.MostRecentRow
				and		RowHistoryExtract.[BagPaymentID] = MostRecentRows.[BagPaymentID]
			UNION All
			--Recursive query for RowHistory buildup
			Select		NextVersion.AuditDate
						,NextVersion.Operation
						,NextVersion.[RowVersion]
						,isnull(NextVersion.[BagPaymentID] , PreviousVersion.[BagPaymentID])
						,isnull(NextVersion.[CustID] , PreviousVersion.[CustID])
						,isnull(NextVersion.[AmountPaid] , PreviousVersion.[AmountPaid])
						,isnull(NextVersion.[PaidDate] , PreviousVersion.[PaidDate])
						,isnull(NextVersion.[PaymentMode] , PreviousVersion.[PaymentMode])
			from		RowHistoryExtract as NextVersion
			Inner join	RowHistory as PreviousVersion
				on		PreviousVersion.[RowVersion] = NextVersion.[RowVersion] + 1
				and		PreviousVersion.[BagPaymentID] = NextVersion.[BagPaymentID]
			),
			RowsOfInterest
			AS
			(
			--Get Rows Of Interest
			Select		max([RowVersion]) as [RowVersion]
						,[BagPaymentID]
			from		RowHistory
			Where		[AuditDate] <= @RecoveryTime
				And		Operation <> 'c'
			Group By		
						[BagPaymentID]
			)
-- Statement that executes the CTE
Insert into @HistoryData
--Returns the function table
Select 
			rh.[BagPaymentID]
			,nullif(rh.[CustID],'<-null->')
			,nullif(rh.[AmountPaid],'<-null->')
			,nullif(rh.[PaidDate],'<-null->')
			,nullif(rh.[PaymentMode],'<-null->')
FROM		RowHistory as rh
Inner join	RowsOfInterest as roi
	on		rh.[RowVersion] = roi.[RowVersion]
	and		rh.[BagPaymentID] = roi.[BagPaymentID]
Where		Operation <> 'd'
order by 
			rh.[BagPaymentID],
			rh.[RowVersion],
			rh.AuditDate
option		(MAXRECURSION 10000)

Return 
END
GO
/****** Object:  UserDefinedFunction [dbo].[BagPaymentInfo_RowHistory]    Script Date: 08/10/2016 11:42:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[BagPaymentInfo_RowHistory]
			(
			@PK varchar(36)
			)

 -- generated by AutoAudit Version 3.30a on Jul 20 2016 10:07AM
 -- created by Paul Nielsen and John Sigouin 
 -- www.SQLServerBible.com 
 -- AutoAudit.codeplex.com 
 -- This function retrieves data from the RowHistory view for the referenced table for the record identified by the PK parameters.

RETURNS @HistoryData Table
(
AuditDate datetime
,Operation varchar(1)
,[RowVersion] int
,[BagPaymentID]nvarchar (100)
,[CustID]nvarchar (100)
,[AmountPaid]money
,[PaidDate]datetime
,[PaymentMode]nvarchar (40)
,ViewScope varchar(10)
,RowHistorySource varchar(10)
,SysUser sysname
,[Application] varchar(128)
,SQLStatement varchar(max)
) 
AS 
BEGIN 

-- Detailed data retrieval is enabled for this table.
With	AuditDataExtract --Source data query
	AS
	(
	SELECT		*
	FROM		[dbo].[vBagPaymentInfo_RowHistory]
	WHERE		[BagPaymentID] = @PK 
	),
	CurrentRowExtract 
	AS
	(
	Select	getdate() as AuditDate
			,'c' as Operation
			,(Select isnull(max([RowVersion]),0) + 1 from AuditDataExtract) as [RowVersion]
			,[BagPaymentID]
			,cast([CustID] as varchar(50)) as [CustID]
			,cast([AmountPaid] as varchar(50)) as [AmountPaid]
			,cast([PaidDate] as varchar(50)) as [PaidDate]
			,cast([PaymentMode] as varchar(50)) as [PaymentMode]
			,null as ViewScope
			,null as RowHistorySource
			,null as SysUser
			,null as [Application]
			,null as SQLStatement
			from	[dbo].[BagPaymentInfo]
	WHERE		[BagPaymentID] = @PK 
			),
			RowHistoryExtract
			AS
			(
			Select * from AuditDataExtract
			Union All
			Select * from CurrentRowExtract
			),
			RowHistory
			AS
			(
			--Anchor query for RowHistory buildup. Get the most current rowversion
			Select		top 1 *
			From		RowHistoryExtract
			order by	[RowVersion] desc

			UNION All
			--Recursive query for RowHistory buildup
			Select		NextVersion.AuditDate
						,NextVersion.Operation
						,NextVersion.[RowVersion]
						,isnull(NextVersion.[BagPaymentID] , PreviousVersion.[BagPaymentID])
						,isnull(NextVersion.[CustID] , PreviousVersion.[CustID])
						,isnull(NextVersion.[AmountPaid] , PreviousVersion.[AmountPaid])
						,isnull(NextVersion.[PaidDate] , PreviousVersion.[PaidDate])
						,isnull(NextVersion.[PaymentMode] , PreviousVersion.[PaymentMode])
						,NextVersion.ViewScope
						,NextVersion.RowHistorySource
						,NextVersion.SysUser
						,NextVersion.[Application]
						,NextVersion.SQLStatement
			from		RowHistoryExtract as NextVersion
			Inner join	RowHistory as PreviousVersion
				on		PreviousVersion.[RowVersion] = NextVersion.[RowVersion] + 1
				and		PreviousVersion.[BagPaymentID] = NextVersion.[BagPaymentID]
			)
-- Statement that executes the CTE
Insert into @HistoryData
	--Returns the function table
	Select	AuditDate
			,Operation
			,[RowVersion]
			,[BagPaymentID]
			, nullif([CustID],'<-null->')
			, nullif([AmountPaid],'<-null->')
			, nullif([PaidDate],'<-null->')
			, nullif([PaymentMode],'<-null->')
			,ViewScope
			,RowHistorySource
			,SysUser
			,[Application]
			,SQLStatement
FROM		RowHistory
where		Operation <> 'c'
order by	[RowVersion],AuditDate
option		(MAXRECURSION 10000)

Return 
END
GO
/****** Object:  Table [dbo].[PaddyStockInfo]    Script Date: 08/10/2016 11:42:08 ******/
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
	[NextPayDate] [datetime] NOT NULL,
	[PriceAdjust] [money] NULL,
	[UsedBags] [int] NULL,
	[AllBagsUsed] [char](1) NOT NULL,
 CONSTRAINT [PK_PaddyStockInfo] PRIMARY KEY CLUSTERED 
(
	[PaddyStockID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[PaddyStockInfo] ([PaddyStockID], [SellerID], [PaddyTypeID], [CustID], [MGodownID], [MLotID], [VehicalNo], [PurchaseDate], [LastModifiedBy], [LastModifiedDate], [ObsInd], [DriverName], [Price], [UnitsTypeID], [TotalBags], [NextPayDate], [PriceAdjust], [UsedBags], [AllBagsUsed]) VALUES (N'PS201607190e5ad9449110e1', N'SE20160719f5092a5d475a46', N'PT20160719a18cae0556486f', N'om', N'GD20160719d07e9481287348', N'LT20160719d5ae52648d08f5', N'KA 03 MS 4430', CAST(0x0000A64800CBA660 AS DateTime), N'om\test', CAST(0x0000A64800CC0C54 AS DateTime), N'N', N'mahesh', 1335.0000, N'BT20160719a9261a90939b37', 200, CAST(0x0000A64800CBA660 AS DateTime), 0.0000, 200, N'Y')
INSERT [dbo].[PaddyStockInfo] ([PaddyStockID], [SellerID], [PaddyTypeID], [CustID], [MGodownID], [MLotID], [VehicalNo], [PurchaseDate], [LastModifiedBy], [LastModifiedDate], [ObsInd], [DriverName], [Price], [UnitsTypeID], [TotalBags], [NextPayDate], [PriceAdjust], [UsedBags], [AllBagsUsed]) VALUES (N'PS2016071947b33e74903e14', N'SE201607198883488d3bd421', N'PT20160719a18cae0556486f', N'om', N'GD20160719d07e9481287348', N'LT20160719d5ae52648d08f5', N'KA 03 MS 4430', CAST(0x0000A64800B4A80C AS DateTime), N'om\test', CAST(0x0000A64800B4E04C AS DateTime), N'N', N'Hari', 1200.0000, N'BT20160719a9261a90939b37', 100, CAST(0x0000A64800B4A80C AS DateTime), 0.0000, 100, N'Y')
INSERT [dbo].[PaddyStockInfo] ([PaddyStockID], [SellerID], [PaddyTypeID], [CustID], [MGodownID], [MLotID], [VehicalNo], [PurchaseDate], [LastModifiedBy], [LastModifiedDate], [ObsInd], [DriverName], [Price], [UnitsTypeID], [TotalBags], [NextPayDate], [PriceAdjust], [UsedBags], [AllBagsUsed]) VALUES (N'PS201607207cf105aea86382', N'SE20160719f5092a5d475a46', N'PT20160720c9f964aa2f5070', N'om', N'GD20160719d07e9481287348', N'LT20160719d5ae52648d08f5', N'KA 03 MS 4430', CAST(0x0000A64901541040 AS DateTime), N'om\test', CAST(0x0000A649015449AC AS DateTime), N'N', N'Kri', 343.0000, N'BT201607198b4fe854818fdc', 999, CAST(0x0000A64901541040 AS DateTime), 0.0000, 0, N'N')
INSERT [dbo].[PaddyStockInfo] ([PaddyStockID], [SellerID], [PaddyTypeID], [CustID], [MGodownID], [MLotID], [VehicalNo], [PurchaseDate], [LastModifiedBy], [LastModifiedDate], [ObsInd], [DriverName], [Price], [UnitsTypeID], [TotalBags], [NextPayDate], [PriceAdjust], [UsedBags], [AllBagsUsed]) VALUES (N'PS20160720a158b2e2903516', N'SE201607198883488d3bd421', N'PT20160720c9f964aa2f5070', N'om', N'GD201607207ef07fcc128e41', N'LT201607206e53227c7842aa', N'KA 03 MS 4430', CAST(0x0000A64900A95BDC AS DateTime), N'om\test', CAST(0x0000A64900A98ABC AS DateTime), N'N', N'Hari', 1050.0000, N'BT20160719a9261a90939b37', 200, CAST(0x0000A64900A95BDC AS DateTime), 0.0000, 0, N'N')
INSERT [dbo].[PaddyStockInfo] ([PaddyStockID], [SellerID], [PaddyTypeID], [CustID], [MGodownID], [MLotID], [VehicalNo], [PurchaseDate], [LastModifiedBy], [LastModifiedDate], [ObsInd], [DriverName], [Price], [UnitsTypeID], [TotalBags], [NextPayDate], [PriceAdjust], [UsedBags], [AllBagsUsed]) VALUES (N'PS20160720b8f68144d0ea78', N'SE2016071959f4346f09f947', N'PT20160720c9f964aa2f5070', N'om', N'GD201607207ef07fcc128e41', N'LT201607206e53227c7842aa', N'KA 03 MS 4430', CAST(0x0000A64900A79658 AS DateTime), N'om\test', CAST(0x0000A64900AA34A8 AS DateTime), N'N', N'mahesh', 1200.0000, N'BT20160719a9261a90939b37', 300, CAST(0x0000A64900A79658 AS DateTime), 0.0000, 0, N'N')
INSERT [dbo].[PaddyStockInfo] ([PaddyStockID], [SellerID], [PaddyTypeID], [CustID], [MGodownID], [MLotID], [VehicalNo], [PurchaseDate], [LastModifiedBy], [LastModifiedDate], [ObsInd], [DriverName], [Price], [UnitsTypeID], [TotalBags], [NextPayDate], [PriceAdjust], [UsedBags], [AllBagsUsed]) VALUES (N'PS20160720cd327271fdb589', N'SE201607198883488d3bd421', N'PT20160719a18cae0556486f', N'om', N'GD201607207ef07fcc128e41', N'LT201607206e53227c7842aa', N'KA 03 MS 4430', CAST(0x0000A64900AB2034 AS DateTime), N'om\test', CAST(0x0000A64900AB4CBC AS DateTime), N'N', N'mahesh', 1275.0000, N'BT20160719a9261a90939b37', 200, CAST(0x0000A64900AB2034 AS DateTime), 0.0000, 0, N'N')
INSERT [dbo].[PaddyStockInfo] ([PaddyStockID], [SellerID], [PaddyTypeID], [CustID], [MGodownID], [MLotID], [VehicalNo], [PurchaseDate], [LastModifiedBy], [LastModifiedDate], [ObsInd], [DriverName], [Price], [UnitsTypeID], [TotalBags], [NextPayDate], [PriceAdjust], [UsedBags], [AllBagsUsed]) VALUES (N'PS20160720d86e91a883b37a', N'SE201607198883488d3bd421', N'PT20160719a18cae0556486f', N'om', N'GD20160719d07e9481287348', N'LT20160719d5ae52648d08f5', N'KA 03 MS 4430', CAST(0x0000A64900AFFF14 AS DateTime), N'om\test', CAST(0x0000A64900B02A70 AS DateTime), N'N', N'mahesh', 1500.0000, N'BT20160719a9261a90939b37', 200, CAST(0x0000A64900AFFF14 AS DateTime), 0.0000, 80, N'N')
/****** Object:  Table [dbo].[ProductPaymentTransaction]    Script Date: 08/10/2016 11:42:08 ******/
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
INSERT [dbo].[ProductPaymentTransaction] ([ProductPaymentTranID], [ProductPaymentID], [CustID], [Paymentmode], [ChequeNo], [DDNo], [BankName], [ReceivedAmount], [PaymentDueDate], [LastModifiedBy], [LastModifiedDate], [ObsInd], [BuyerID], [MediatorID]) VALUES (N'PP201608017103592fe66b68', N'PP201608014599a59dc25e7b', N'om', N'Cash', N'', N'', N'', 1200.0000, CAST(0x0000A6B800000000 AS DateTime), N'om\test', CAST(0x0000A655014110F8 AS DateTime), N'N', N'BI20160801221c51afedb486', NULL)
INSERT [dbo].[ProductPaymentTransaction] ([ProductPaymentTranID], [ProductPaymentID], [CustID], [Paymentmode], [ChequeNo], [DDNo], [BankName], [ReceivedAmount], [PaymentDueDate], [LastModifiedBy], [LastModifiedDate], [ObsInd], [BuyerID], [MediatorID]) VALUES (N'PP201608017b8e344696804b', N'PP20160801c939712459f340', N'om', N'Cash', N'', N'', N'', 120000.0000, CAST(0x0000A58700D7A5DC AS DateTime), N'om\test', CAST(0x0000A65500D80978 AS DateTime), N'N', N'BI20160801221c51afedb486', NULL)
INSERT [dbo].[ProductPaymentTransaction] ([ProductPaymentTranID], [ProductPaymentID], [CustID], [Paymentmode], [ChequeNo], [DDNo], [BankName], [ReceivedAmount], [PaymentDueDate], [LastModifiedBy], [LastModifiedDate], [ObsInd], [BuyerID], [MediatorID]) VALUES (N'PP20160801a196a59cfacdc4', N'PP201608014599a59dc25e7b', N'om', N'Cash', N'', N'', N'', 100000.0000, CAST(0x0000A65500000000 AS DateTime), N'om\test', CAST(0x0000A6550141516C AS DateTime), N'N', N'BI20160801221c51afedb486', NULL)
INSERT [dbo].[ProductPaymentTransaction] ([ProductPaymentTranID], [ProductPaymentID], [CustID], [Paymentmode], [ChequeNo], [DDNo], [BankName], [ReceivedAmount], [PaymentDueDate], [LastModifiedBy], [LastModifiedDate], [ObsInd], [BuyerID], [MediatorID]) VALUES (N'PP20160801cedecb83a527bc', N'PP201608014599a59dc25e7b', N'om', N'Cash', N'', N'', N'', 100000.0000, CAST(0x0000A5C30140C148 AS DateTime), N'om\test', CAST(0x0000A6550140F604 AS DateTime), N'N', N'BI20160801221c51afedb486', NULL)
INSERT [dbo].[ProductPaymentTransaction] ([ProductPaymentTranID], [ProductPaymentID], [CustID], [Paymentmode], [ChequeNo], [DDNo], [BankName], [ReceivedAmount], [PaymentDueDate], [LastModifiedBy], [LastModifiedDate], [ObsInd], [BuyerID], [MediatorID]) VALUES (N'PP20160801e55491295886e4', N'PP201608014176cc013af880', N'om', N'Cash', N'', N'', N'', 10000.0000, CAST(0x0000A65900E0C647 AS DateTime), N'om\test', CAST(0x0000A6550178E2D0 AS DateTime), N'N', N'BI2016080155275b7f285865', NULL)
INSERT [dbo].[ProductPaymentTransaction] ([ProductPaymentTranID], [ProductPaymentID], [CustID], [Paymentmode], [ChequeNo], [DDNo], [BankName], [ReceivedAmount], [PaymentDueDate], [LastModifiedBy], [LastModifiedDate], [ObsInd], [BuyerID], [MediatorID]) VALUES (N'PP20160801f0646f0cb58d30', N'PP201608014599a59dc25e7b', N'om', N'Cash', N'', N'', N'', 118800.0000, CAST(0x0000A65500000000 AS DateTime), N'om\test', CAST(0x0000A65501413678 AS DateTime), N'N', N'BI20160801221c51afedb486', NULL)
/****** Object:  UserDefinedFunction [dbo].[ProductPaymentInfo_TableRecovery]    Script Date: 08/10/2016 11:42:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[ProductPaymentInfo_TableRecovery]
			(
			@RecoveryTime datetime
			)

 -- NEW generated by AutoAudit Version 3.30a on Jul 20 2016 10:07AM
 -- created by Paul Nielsen and John Sigouin 
 -- www.SQLServerBible.com 
 -- AutoAudit.codeplex.com 
 -- This function retrieves an image of the table as it existed at the specified point in time.

RETURNS @HistoryData Table
(
[ProductPaymentID]nvarchar (100)
,[CustID]nvarchar (100)
,[TotalAmount]money
) 
AS 
BEGIN 

-- Create table variable to hold history records.
Declare @AuditDataExtract table
	(
	AuditDate datetime
	,Operation varchar(1)
	,[RowVersion] int
	,[ProductPaymentID] varchar(50)
	,[CustID] varchar(50)
	,[TotalAmount] varchar(50)
	) 

-- Detailed data retrieval is enabled for this table.
--write the full history for the table into a temp table variable for performance.
Insert @AuditDataExtract 
Select 
			AuditDate
			,Operation
			,[RowVersion]
			,[ProductPaymentID]
			,[CustID]
			,[TotalAmount]
FROM		[dbo].[vProductPaymentInfo_RowHistory]

-- Detailed data retrieval is enabled for this table.
;With	AuditDataExtract --Source data query
	AS
	(
	SELECT		*
	FROM		@AuditDataExtract
	),
	CurrentRowExtract 
	AS
	(
	Select		getdate() as AuditDate
				,'c' as Operation
				,(Select isnull(max([RowVersion]),0) + 1 from AuditDataExtract 
				Where	1=1 
					and	AuditDataExtract.[ProductPaymentID] = [dbo].[ProductPaymentInfo].[ProductPaymentID]
				) as [RowVersion]
				,[ProductPaymentID]
				,cast([CustID] as varchar(50)) as [CustID]
				,cast([TotalAmount] as varchar(50)) as [TotalAmount]
	from		[dbo].[ProductPaymentInfo]
			),
			RowHistoryExtract
			AS
			(
			Select * from AuditDataExtract
			Union All
			Select * from CurrentRowExtract
			),
			MostRecentRows
			AS
			(
			--Get most recent rows
			Select 
						max([RowVersion]) as MostRecentRow
						,[ProductPaymentID]
			from		RowHistoryExtract
			Group By	
						[ProductPaymentID]
			),
			RowHistory
			AS
			(
			--Anchor query for RowHistory buildup. Get the most current rowversion
			Select		
			RowHistoryExtract.AuditDate
			,RowHistoryExtract.Operation
			,RowHistoryExtract.[RowVersion]
			,RowHistoryExtract.[ProductPaymentID]
			,RowHistoryExtract.[CustID]
			,RowHistoryExtract.[TotalAmount]
			From		RowHistoryExtract
			inner join	MostRecentRows
				on		RowHistoryExtract.[RowVersion] = MostRecentRows.MostRecentRow
				and		RowHistoryExtract.[ProductPaymentID] = MostRecentRows.[ProductPaymentID]
			UNION All
			--Recursive query for RowHistory buildup
			Select		NextVersion.AuditDate
						,NextVersion.Operation
						,NextVersion.[RowVersion]
						,isnull(NextVersion.[ProductPaymentID] , PreviousVersion.[ProductPaymentID])
						,isnull(NextVersion.[CustID] , PreviousVersion.[CustID])
						,isnull(NextVersion.[TotalAmount] , PreviousVersion.[TotalAmount])
			from		RowHistoryExtract as NextVersion
			Inner join	RowHistory as PreviousVersion
				on		PreviousVersion.[RowVersion] = NextVersion.[RowVersion] + 1
				and		PreviousVersion.[ProductPaymentID] = NextVersion.[ProductPaymentID]
			),
			RowsOfInterest
			AS
			(
			--Get Rows Of Interest
			Select		max([RowVersion]) as [RowVersion]
						,[ProductPaymentID]
			from		RowHistory
			Where		[AuditDate] <= @RecoveryTime
				And		Operation <> 'c'
			Group By		
						[ProductPaymentID]
			)
-- Statement that executes the CTE
Insert into @HistoryData
--Returns the function table
Select 
			rh.[ProductPaymentID]
			,nullif(rh.[CustID],'<-null->')
			,nullif(rh.[TotalAmount],'<-null->')
FROM		RowHistory as rh
Inner join	RowsOfInterest as roi
	on		rh.[RowVersion] = roi.[RowVersion]
	and		rh.[ProductPaymentID] = roi.[ProductPaymentID]
Where		Operation <> 'd'
order by 
			rh.[ProductPaymentID],
			rh.[RowVersion],
			rh.AuditDate
option		(MAXRECURSION 10000)

Return 
END
GO
/****** Object:  UserDefinedFunction [dbo].[ProductPaymentInfo_RowHistory]    Script Date: 08/10/2016 11:42:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[ProductPaymentInfo_RowHistory]
			(
			@PK varchar(36)
			)

 -- generated by AutoAudit Version 3.30a on Jul 20 2016 10:07AM
 -- created by Paul Nielsen and John Sigouin 
 -- www.SQLServerBible.com 
 -- AutoAudit.codeplex.com 
 -- This function retrieves data from the RowHistory view for the referenced table for the record identified by the PK parameters.

RETURNS @HistoryData Table
(
AuditDate datetime
,Operation varchar(1)
,[RowVersion] int
,[ProductPaymentID]nvarchar (100)
,[CustID]nvarchar (100)
,[TotalAmount]money
,ViewScope varchar(10)
,RowHistorySource varchar(10)
,SysUser sysname
,[Application] varchar(128)
,SQLStatement varchar(max)
) 
AS 
BEGIN 

-- Detailed data retrieval is enabled for this table.
With	AuditDataExtract --Source data query
	AS
	(
	SELECT		*
	FROM		[dbo].[vProductPaymentInfo_RowHistory]
	WHERE		[ProductPaymentID] = @PK 
	),
	CurrentRowExtract 
	AS
	(
	Select	getdate() as AuditDate
			,'c' as Operation
			,(Select isnull(max([RowVersion]),0) + 1 from AuditDataExtract) as [RowVersion]
			,[ProductPaymentID]
			,cast([CustID] as varchar(50)) as [CustID]
			,cast([TotalAmount] as varchar(50)) as [TotalAmount]
			,null as ViewScope
			,null as RowHistorySource
			,null as SysUser
			,null as [Application]
			,null as SQLStatement
			from	[dbo].[ProductPaymentInfo]
	WHERE		[ProductPaymentID] = @PK 
			),
			RowHistoryExtract
			AS
			(
			Select * from AuditDataExtract
			Union All
			Select * from CurrentRowExtract
			),
			RowHistory
			AS
			(
			--Anchor query for RowHistory buildup. Get the most current rowversion
			Select		top 1 *
			From		RowHistoryExtract
			order by	[RowVersion] desc

			UNION All
			--Recursive query for RowHistory buildup
			Select		NextVersion.AuditDate
						,NextVersion.Operation
						,NextVersion.[RowVersion]
						,isnull(NextVersion.[ProductPaymentID] , PreviousVersion.[ProductPaymentID])
						,isnull(NextVersion.[CustID] , PreviousVersion.[CustID])
						,isnull(NextVersion.[TotalAmount] , PreviousVersion.[TotalAmount])
						,NextVersion.ViewScope
						,NextVersion.RowHistorySource
						,NextVersion.SysUser
						,NextVersion.[Application]
						,NextVersion.SQLStatement
			from		RowHistoryExtract as NextVersion
			Inner join	RowHistory as PreviousVersion
				on		PreviousVersion.[RowVersion] = NextVersion.[RowVersion] + 1
				and		PreviousVersion.[ProductPaymentID] = NextVersion.[ProductPaymentID]
			)
-- Statement that executes the CTE
Insert into @HistoryData
	--Returns the function table
	Select	AuditDate
			,Operation
			,[RowVersion]
			,[ProductPaymentID]
			, nullif([CustID],'<-null->')
			, nullif([TotalAmount],'<-null->')
			,ViewScope
			,RowHistorySource
			,SysUser
			,[Application]
			,SQLStatement
FROM		RowHistory
where		Operation <> 'c'
order by	[RowVersion],AuditDate
option		(MAXRECURSION 10000)

Return 
END
GO
/****** Object:  Table [dbo].[ProductSellingInfo]    Script Date: 08/10/2016 11:42:08 ******/
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
	[VehicalNo] [nvarchar](40) NULL,
	[DriverName] [nvarchar](100) NULL,
 CONSTRAINT [PK_ProductSellingInfo] PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[ProductSellingInfo] ([ProductID], [BuyerID], [MRiceProdTypeID], [MRiceBrandID], [BrokenRiceTypeID], [CustID], [UnitsTypeID], [ProductPaymentID], [SellingDate], [Price], [SellingProductType], [LastModifiedBy], [LastModifiedDate], [ObsInd], [TotalBags], [MediatorID], [VehicalNo], [DriverName]) VALUES (N'PI201608010c267c72a44846', N'BI20160801221c51afedb486', N'RP201607196cda0aa0548d47', N'RB20160719937050a760653c', NULL, N'om', N'BT2016071938e099fbd69545', N'PP20160801c939712459f340', CAST(0x0000A58700D671A8 AS DateTime), 1250.0000, NULL, N'om\test', CAST(0x0000A65500D6A9E8 AS DateTime), N'N', 100, NULL, NULL, NULL)
INSERT [dbo].[ProductSellingInfo] ([ProductID], [BuyerID], [MRiceProdTypeID], [MRiceBrandID], [BrokenRiceTypeID], [CustID], [UnitsTypeID], [ProductPaymentID], [SellingDate], [Price], [SellingProductType], [LastModifiedBy], [LastModifiedDate], [ObsInd], [TotalBags], [MediatorID], [VehicalNo], [DriverName]) VALUES (N'PI2016080125ca53a6957eff', N'BI2016080155275b7f285865', N'RP201607196cda0aa0548d47', N'RB20160719937050a760653c', NULL, N'om', N'BT2016071938e099fbd69545', N'PP201608014176cc013af880', CAST(0x0000A5870178A388 AS DateTime), 1125.0000, NULL, N'om\test', CAST(0x0000A6550178C6B0 AS DateTime), N'N', 200, NULL, NULL, NULL)
INSERT [dbo].[ProductSellingInfo] ([ProductID], [BuyerID], [MRiceProdTypeID], [MRiceBrandID], [BrokenRiceTypeID], [CustID], [UnitsTypeID], [ProductPaymentID], [SellingDate], [Price], [SellingProductType], [LastModifiedBy], [LastModifiedDate], [ObsInd], [TotalBags], [MediatorID], [VehicalNo], [DriverName]) VALUES (N'PI20160801a9562158fd3a90', N'BI20160801221c51afedb486', N'RP201607196cda0aa0548d47', N'RB20160719937050a760653c', NULL, N'om', N'BT2016071938e099fbd69545', N'PP201608014599a59dc25e7b', CAST(0x0000A58700C75420 AS DateTime), 1050.0000, NULL, N'om\test', CAST(0x0000A65500C7BEC4 AS DateTime), N'N', 200, NULL, NULL, NULL)
INSERT [dbo].[ProductSellingInfo] ([ProductID], [BuyerID], [MRiceProdTypeID], [MRiceBrandID], [BrokenRiceTypeID], [CustID], [UnitsTypeID], [ProductPaymentID], [SellingDate], [Price], [SellingProductType], [LastModifiedBy], [LastModifiedDate], [ObsInd], [TotalBags], [MediatorID], [VehicalNo], [DriverName]) VALUES (N'PI20160801ddf22d2504653f', N'BI20160801221c51afedb486', N'RP201607196cda0aa0548d47', N'RB20160719937050a760653c', NULL, N'om', N'BT2016071938e099fbd69545', N'PP201608014599a59dc25e7b', CAST(0x0000A58700C75420 AS DateTime), 1050.0000, NULL, N'om\test', CAST(0x0000A65500C7BEC4 AS DateTime), N'N', 200, NULL, NULL, NULL)
INSERT [dbo].[ProductSellingInfo] ([ProductID], [BuyerID], [MRiceProdTypeID], [MRiceBrandID], [BrokenRiceTypeID], [CustID], [UnitsTypeID], [ProductPaymentID], [SellingDate], [Price], [SellingProductType], [LastModifiedBy], [LastModifiedDate], [ObsInd], [TotalBags], [MediatorID], [VehicalNo], [DriverName]) VALUES (N'PI2016080945bc880391f189', N'BI20160809f897baf6347149', N'RP201607196cda0aa0548d47', N'RB20160719937050a760653c', NULL, N'om', N'BT2016071938e099fbd69545', N'PP201608093a6ebf50338f40', CAST(0x0000A67B0140B464 AS DateTime), 1000.0000, NULL, N'om\test', CAST(0x0000A65D0140D408 AS DateTime), N'N', 100, NULL, N'KA 03 MS 3333', N'Rajesh')
INSERT [dbo].[ProductSellingInfo] ([ProductID], [BuyerID], [MRiceProdTypeID], [MRiceBrandID], [BrokenRiceTypeID], [CustID], [UnitsTypeID], [ProductPaymentID], [SellingDate], [Price], [SellingProductType], [LastModifiedBy], [LastModifiedDate], [ObsInd], [TotalBags], [MediatorID], [VehicalNo], [DriverName]) VALUES (N'PI20160809e20190e8095c40', N'BI20160809f897baf6347149', N'RP201607196cda0aa0548d47', N'RB20160719937050a760653c', NULL, N'om', N'BT2016071938e099fbd69545', N'PP20160809df23783990619e', CAST(0x0000A67B013BA44C AS DateTime), 1000.0000, NULL, N'om\test', CAST(0x0000A65D013BF078 AS DateTime), N'N', 30, NULL, NULL, NULL)
INSERT [dbo].[ProductSellingInfo] ([ProductID], [BuyerID], [MRiceProdTypeID], [MRiceBrandID], [BrokenRiceTypeID], [CustID], [UnitsTypeID], [ProductPaymentID], [SellingDate], [Price], [SellingProductType], [LastModifiedBy], [LastModifiedDate], [ObsInd], [TotalBags], [MediatorID], [VehicalNo], [DriverName]) VALUES (N'PI2016081039675b55c03ba8', N'BI20160809f897baf6347149', N'RP201607196cda0aa0548d47', N'RB20160719937050a760653c', NULL, N'om', N'BT2016071938e099fbd69545', N'PP20160810cbb17e547b29b3', CAST(0x0000A69900B888A0 AS DateTime), 1000.0000, NULL, N'om\test', CAST(0x0000A65E00B8C464 AS DateTime), N'N', 200, N'BI20160810c67423da75c367', N'KA 03 MS 1234', N'Rudresh')
/****** Object:  UserDefinedFunction [dbo].[EmployeeSalary_TableRecovery]    Script Date: 08/10/2016 11:42:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[EmployeeSalary_TableRecovery]
			(
			@RecoveryTime datetime
			)

 -- NEW generated by AutoAudit Version 3.30a on Jul 20 2016 10:07AM
 -- created by Paul Nielsen and John Sigouin 
 -- www.SQLServerBible.com 
 -- AutoAudit.codeplex.com 
 -- This function retrieves an image of the table as it existed at the specified point in time.

RETURNS @HistoryData Table
(
[EmpSalaryID]nvarchar (100)
,[CustID]nvarchar (100)
,[Salary]money
) 
AS 
BEGIN 

-- Create table variable to hold history records.
Declare @AuditDataExtract table
	(
	AuditDate datetime
	,Operation varchar(1)
	,[RowVersion] int
	,[EmpSalaryID] varchar(50)
	,[CustID] varchar(50)
	,[Salary] varchar(50)
	) 

-- Detailed data retrieval is enabled for this table.
--write the full history for the table into a temp table variable for performance.
Insert @AuditDataExtract 
Select 
			AuditDate
			,Operation
			,[RowVersion]
			,[EmpSalaryID]
			,[CustID]
			,[Salary]
FROM		[dbo].[vEmployeeSalary_RowHistory]

-- Detailed data retrieval is enabled for this table.
;With	AuditDataExtract --Source data query
	AS
	(
	SELECT		*
	FROM		@AuditDataExtract
	),
	CurrentRowExtract 
	AS
	(
	Select		getdate() as AuditDate
				,'c' as Operation
				,(Select isnull(max([RowVersion]),0) + 1 from AuditDataExtract 
				Where	1=1 
					and	AuditDataExtract.[EmpSalaryID] = [dbo].[EmployeeSalary].[EmpSalaryID]
				) as [RowVersion]
				,[EmpSalaryID]
				,cast([CustID] as varchar(50)) as [CustID]
				,cast([Salary] as varchar(50)) as [Salary]
	from		[dbo].[EmployeeSalary]
			),
			RowHistoryExtract
			AS
			(
			Select * from AuditDataExtract
			Union All
			Select * from CurrentRowExtract
			),
			MostRecentRows
			AS
			(
			--Get most recent rows
			Select 
						max([RowVersion]) as MostRecentRow
						,[EmpSalaryID]
			from		RowHistoryExtract
			Group By	
						[EmpSalaryID]
			),
			RowHistory
			AS
			(
			--Anchor query for RowHistory buildup. Get the most current rowversion
			Select		
			RowHistoryExtract.AuditDate
			,RowHistoryExtract.Operation
			,RowHistoryExtract.[RowVersion]
			,RowHistoryExtract.[EmpSalaryID]
			,RowHistoryExtract.[CustID]
			,RowHistoryExtract.[Salary]
			From		RowHistoryExtract
			inner join	MostRecentRows
				on		RowHistoryExtract.[RowVersion] = MostRecentRows.MostRecentRow
				and		RowHistoryExtract.[EmpSalaryID] = MostRecentRows.[EmpSalaryID]
			UNION All
			--Recursive query for RowHistory buildup
			Select		NextVersion.AuditDate
						,NextVersion.Operation
						,NextVersion.[RowVersion]
						,isnull(NextVersion.[EmpSalaryID] , PreviousVersion.[EmpSalaryID])
						,isnull(NextVersion.[CustID] , PreviousVersion.[CustID])
						,isnull(NextVersion.[Salary] , PreviousVersion.[Salary])
			from		RowHistoryExtract as NextVersion
			Inner join	RowHistory as PreviousVersion
				on		PreviousVersion.[RowVersion] = NextVersion.[RowVersion] + 1
				and		PreviousVersion.[EmpSalaryID] = NextVersion.[EmpSalaryID]
			),
			RowsOfInterest
			AS
			(
			--Get Rows Of Interest
			Select		max([RowVersion]) as [RowVersion]
						,[EmpSalaryID]
			from		RowHistory
			Where		[AuditDate] <= @RecoveryTime
				And		Operation <> 'c'
			Group By		
						[EmpSalaryID]
			)
-- Statement that executes the CTE
Insert into @HistoryData
--Returns the function table
Select 
			rh.[EmpSalaryID]
			,nullif(rh.[CustID],'<-null->')
			,nullif(rh.[Salary],'<-null->')
FROM		RowHistory as rh
Inner join	RowsOfInterest as roi
	on		rh.[RowVersion] = roi.[RowVersion]
	and		rh.[EmpSalaryID] = roi.[EmpSalaryID]
Where		Operation <> 'd'
order by 
			rh.[EmpSalaryID],
			rh.[RowVersion],
			rh.AuditDate
option		(MAXRECURSION 10000)

Return 
END
GO
/****** Object:  UserDefinedFunction [dbo].[EmployeeSalary_RowHistory]    Script Date: 08/10/2016 11:42:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[EmployeeSalary_RowHistory]
			(
			@PK varchar(36)
			)

 -- generated by AutoAudit Version 3.30a on Jul 20 2016 10:07AM
 -- created by Paul Nielsen and John Sigouin 
 -- www.SQLServerBible.com 
 -- AutoAudit.codeplex.com 
 -- This function retrieves data from the RowHistory view for the referenced table for the record identified by the PK parameters.

RETURNS @HistoryData Table
(
AuditDate datetime
,Operation varchar(1)
,[RowVersion] int
,[EmpSalaryID]nvarchar (100)
,[CustID]nvarchar (100)
,[Salary]money
,ViewScope varchar(10)
,RowHistorySource varchar(10)
,SysUser sysname
,[Application] varchar(128)
,SQLStatement varchar(max)
) 
AS 
BEGIN 

-- Detailed data retrieval is enabled for this table.
With	AuditDataExtract --Source data query
	AS
	(
	SELECT		*
	FROM		[dbo].[vEmployeeSalary_RowHistory]
	WHERE		[EmpSalaryID] = @PK 
	),
	CurrentRowExtract 
	AS
	(
	Select	getdate() as AuditDate
			,'c' as Operation
			,(Select isnull(max([RowVersion]),0) + 1 from AuditDataExtract) as [RowVersion]
			,[EmpSalaryID]
			,cast([CustID] as varchar(50)) as [CustID]
			,cast([Salary] as varchar(50)) as [Salary]
			,null as ViewScope
			,null as RowHistorySource
			,null as SysUser
			,null as [Application]
			,null as SQLStatement
			from	[dbo].[EmployeeSalary]
	WHERE		[EmpSalaryID] = @PK 
			),
			RowHistoryExtract
			AS
			(
			Select * from AuditDataExtract
			Union All
			Select * from CurrentRowExtract
			),
			RowHistory
			AS
			(
			--Anchor query for RowHistory buildup. Get the most current rowversion
			Select		top 1 *
			From		RowHistoryExtract
			order by	[RowVersion] desc

			UNION All
			--Recursive query for RowHistory buildup
			Select		NextVersion.AuditDate
						,NextVersion.Operation
						,NextVersion.[RowVersion]
						,isnull(NextVersion.[EmpSalaryID] , PreviousVersion.[EmpSalaryID])
						,isnull(NextVersion.[CustID] , PreviousVersion.[CustID])
						,isnull(NextVersion.[Salary] , PreviousVersion.[Salary])
						,NextVersion.ViewScope
						,NextVersion.RowHistorySource
						,NextVersion.SysUser
						,NextVersion.[Application]
						,NextVersion.SQLStatement
			from		RowHistoryExtract as NextVersion
			Inner join	RowHistory as PreviousVersion
				on		PreviousVersion.[RowVersion] = NextVersion.[RowVersion] + 1
				and		PreviousVersion.[EmpSalaryID] = NextVersion.[EmpSalaryID]
			)
-- Statement that executes the CTE
Insert into @HistoryData
	--Returns the function table
	Select	AuditDate
			,Operation
			,[RowVersion]
			,[EmpSalaryID]
			, nullif([CustID],'<-null->')
			, nullif([Salary],'<-null->')
			,ViewScope
			,RowHistorySource
			,SysUser
			,[Application]
			,SQLStatement
FROM		RowHistory
where		Operation <> 'c'
order by	[RowVersion],AuditDate
option		(MAXRECURSION 10000)

Return 
END
GO
/****** Object:  Table [dbo].[HullingProcess]    Script Date: 08/10/2016 11:42:08 ******/
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
INSERT [dbo].[HullingProcess] ([HullingProcessID], [PaddyTypeID], [CustID], [UnitsTypeID], [TotalBags], [LastModifiedBy], [LastModifiedDate], [ObsInd], [Status], [MGodownID], [MLotID], [Price]) VALUES (N'HP201607193c7cbc73f42b78', N'PT20160719a18cae0556486f', N'om', N'BT20160719a9261a90939b37', 120, N'om\test', CAST(0x0000A6480149F13C AS DateTime), N'N', N'A', N'GD20160719d07e9481287348', N'LT20160719d5ae52648d08f5', 1267.5000)
INSERT [dbo].[HullingProcess] ([HullingProcessID], [PaddyTypeID], [CustID], [UnitsTypeID], [TotalBags], [LastModifiedBy], [LastModifiedDate], [ObsInd], [Status], [MGodownID], [MLotID], [Price]) VALUES (N'HP20160727fbc9c30d9c9645', N'PT20160719a18cae0556486f', N'om', N'BT20160719a9261a90939b37', 260, N'om\test', CAST(0x0000A65D0140B0E0 AS DateTime), N'N', N'A', N'GD20160719d07e9481287348', N'LT20160719d5ae52648d08f5', 1890.0000)
/****** Object:  UserDefinedFunction [dbo].[ExpenseTransaction_TableRecovery]    Script Date: 08/10/2016 11:42:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[ExpenseTransaction_TableRecovery]
			(
			@RecoveryTime datetime
			)

 -- NEW generated by AutoAudit Version 3.30a on Jul 20 2016 10:07AM
 -- created by Paul Nielsen and John Sigouin 
 -- www.SQLServerBible.com 
 -- AutoAudit.codeplex.com 
 -- This function retrieves an image of the table as it existed at the specified point in time.

RETURNS @HistoryData Table
(
[ExpenseTransID]nvarchar (100)
,[CustID]nvarchar (100)
,[Amount]money
) 
AS 
BEGIN 

-- Create table variable to hold history records.
Declare @AuditDataExtract table
	(
	AuditDate datetime
	,Operation varchar(1)
	,[RowVersion] int
	,[ExpenseTransID] varchar(50)
	,[CustID] varchar(50)
	,[Amount] varchar(50)
	) 

-- Detailed data retrieval is enabled for this table.
--write the full history for the table into a temp table variable for performance.
Insert @AuditDataExtract 
Select 
			AuditDate
			,Operation
			,[RowVersion]
			,[ExpenseTransID]
			,[CustID]
			,[Amount]
FROM		[dbo].[vExpenseTransaction_RowHistory]

-- Detailed data retrieval is enabled for this table.
;With	AuditDataExtract --Source data query
	AS
	(
	SELECT		*
	FROM		@AuditDataExtract
	),
	CurrentRowExtract 
	AS
	(
	Select		getdate() as AuditDate
				,'c' as Operation
				,(Select isnull(max([RowVersion]),0) + 1 from AuditDataExtract 
				Where	1=1 
					and	AuditDataExtract.[ExpenseTransID] = [dbo].[ExpenseTransaction].[ExpenseTransID]
				) as [RowVersion]
				,[ExpenseTransID]
				,cast([CustID] as varchar(50)) as [CustID]
				,cast([Amount] as varchar(50)) as [Amount]
	from		[dbo].[ExpenseTransaction]
			),
			RowHistoryExtract
			AS
			(
			Select * from AuditDataExtract
			Union All
			Select * from CurrentRowExtract
			),
			MostRecentRows
			AS
			(
			--Get most recent rows
			Select 
						max([RowVersion]) as MostRecentRow
						,[ExpenseTransID]
			from		RowHistoryExtract
			Group By	
						[ExpenseTransID]
			),
			RowHistory
			AS
			(
			--Anchor query for RowHistory buildup. Get the most current rowversion
			Select		
			RowHistoryExtract.AuditDate
			,RowHistoryExtract.Operation
			,RowHistoryExtract.[RowVersion]
			,RowHistoryExtract.[ExpenseTransID]
			,RowHistoryExtract.[CustID]
			,RowHistoryExtract.[Amount]
			From		RowHistoryExtract
			inner join	MostRecentRows
				on		RowHistoryExtract.[RowVersion] = MostRecentRows.MostRecentRow
				and		RowHistoryExtract.[ExpenseTransID] = MostRecentRows.[ExpenseTransID]
			UNION All
			--Recursive query for RowHistory buildup
			Select		NextVersion.AuditDate
						,NextVersion.Operation
						,NextVersion.[RowVersion]
						,isnull(NextVersion.[ExpenseTransID] , PreviousVersion.[ExpenseTransID])
						,isnull(NextVersion.[CustID] , PreviousVersion.[CustID])
						,isnull(NextVersion.[Amount] , PreviousVersion.[Amount])
			from		RowHistoryExtract as NextVersion
			Inner join	RowHistory as PreviousVersion
				on		PreviousVersion.[RowVersion] = NextVersion.[RowVersion] + 1
				and		PreviousVersion.[ExpenseTransID] = NextVersion.[ExpenseTransID]
			),
			RowsOfInterest
			AS
			(
			--Get Rows Of Interest
			Select		max([RowVersion]) as [RowVersion]
						,[ExpenseTransID]
			from		RowHistory
			Where		[AuditDate] <= @RecoveryTime
				And		Operation <> 'c'
			Group By		
						[ExpenseTransID]
			)
-- Statement that executes the CTE
Insert into @HistoryData
--Returns the function table
Select 
			rh.[ExpenseTransID]
			,nullif(rh.[CustID],'<-null->')
			,nullif(rh.[Amount],'<-null->')
FROM		RowHistory as rh
Inner join	RowsOfInterest as roi
	on		rh.[RowVersion] = roi.[RowVersion]
	and		rh.[ExpenseTransID] = roi.[ExpenseTransID]
Where		Operation <> 'd'
order by 
			rh.[ExpenseTransID],
			rh.[RowVersion],
			rh.AuditDate
option		(MAXRECURSION 10000)

Return 
END
GO
/****** Object:  UserDefinedFunction [dbo].[ExpenseTransaction_RowHistory]    Script Date: 08/10/2016 11:42:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[ExpenseTransaction_RowHistory]
			(
			@PK varchar(36)
			)

 -- generated by AutoAudit Version 3.30a on Jul 20 2016 10:07AM
 -- created by Paul Nielsen and John Sigouin 
 -- www.SQLServerBible.com 
 -- AutoAudit.codeplex.com 
 -- This function retrieves data from the RowHistory view for the referenced table for the record identified by the PK parameters.

RETURNS @HistoryData Table
(
AuditDate datetime
,Operation varchar(1)
,[RowVersion] int
,[ExpenseTransID]nvarchar (100)
,[CustID]nvarchar (100)
,[Amount]money
,ViewScope varchar(10)
,RowHistorySource varchar(10)
,SysUser sysname
,[Application] varchar(128)
,SQLStatement varchar(max)
) 
AS 
BEGIN 

-- Detailed data retrieval is enabled for this table.
With	AuditDataExtract --Source data query
	AS
	(
	SELECT		*
	FROM		[dbo].[vExpenseTransaction_RowHistory]
	WHERE		[ExpenseTransID] = @PK 
	),
	CurrentRowExtract 
	AS
	(
	Select	getdate() as AuditDate
			,'c' as Operation
			,(Select isnull(max([RowVersion]),0) + 1 from AuditDataExtract) as [RowVersion]
			,[ExpenseTransID]
			,cast([CustID] as varchar(50)) as [CustID]
			,cast([Amount] as varchar(50)) as [Amount]
			,null as ViewScope
			,null as RowHistorySource
			,null as SysUser
			,null as [Application]
			,null as SQLStatement
			from	[dbo].[ExpenseTransaction]
	WHERE		[ExpenseTransID] = @PK 
			),
			RowHistoryExtract
			AS
			(
			Select * from AuditDataExtract
			Union All
			Select * from CurrentRowExtract
			),
			RowHistory
			AS
			(
			--Anchor query for RowHistory buildup. Get the most current rowversion
			Select		top 1 *
			From		RowHistoryExtract
			order by	[RowVersion] desc

			UNION All
			--Recursive query for RowHistory buildup
			Select		NextVersion.AuditDate
						,NextVersion.Operation
						,NextVersion.[RowVersion]
						,isnull(NextVersion.[ExpenseTransID] , PreviousVersion.[ExpenseTransID])
						,isnull(NextVersion.[CustID] , PreviousVersion.[CustID])
						,isnull(NextVersion.[Amount] , PreviousVersion.[Amount])
						,NextVersion.ViewScope
						,NextVersion.RowHistorySource
						,NextVersion.SysUser
						,NextVersion.[Application]
						,NextVersion.SQLStatement
			from		RowHistoryExtract as NextVersion
			Inner join	RowHistory as PreviousVersion
				on		PreviousVersion.[RowVersion] = NextVersion.[RowVersion] + 1
				and		PreviousVersion.[ExpenseTransID] = NextVersion.[ExpenseTransID]
			)
-- Statement that executes the CTE
Insert into @HistoryData
	--Returns the function table
	Select	AuditDate
			,Operation
			,[RowVersion]
			,[ExpenseTransID]
			, nullif([CustID],'<-null->')
			, nullif([Amount],'<-null->')
			,ViewScope
			,RowHistorySource
			,SysUser
			,[Application]
			,SQLStatement
FROM		RowHistory
where		Operation <> 'c'
order by	[RowVersion],AuditDate
option		(MAXRECURSION 10000)

Return 
END
GO
/****** Object:  Table [dbo].[HullingProcessExpenses]    Script Date: 08/10/2016 11:42:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HullingProcessExpenses](
	[HullingProcessExpenID] [nvarchar](50) NOT NULL,
	[HullingProcessID] [nvarchar](50) NOT NULL,
	[LastModifiedBy] [nvarchar](50) NOT NULL,
	[LastModifiedDate] [datetime] NOT NULL,
	[ObsInd] [char](1) NOT NULL,
	[CustID] [nvarchar](50) NOT NULL,
	[HullingExpenses] [money] NOT NULL,
 CONSTRAINT [PK_HullingProcessExpenses] PRIMARY KEY CLUSTERED 
(
	[HullingProcessExpenID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[HullingProcessExpenses] ([HullingProcessExpenID], [HullingProcessID], [LastModifiedBy], [LastModifiedDate], [ObsInd], [CustID], [HullingExpenses]) VALUES (N'HPE20160719cbfa21f5817c3b', N'HP201607193c7cbc73f42b78', N'om\test', CAST(0x0000A64801484904 AS DateTime), N'N', N'om', 12000.0000)
INSERT [dbo].[HullingProcessExpenses] ([HullingProcessExpenID], [HullingProcessID], [LastModifiedBy], [LastModifiedDate], [ObsInd], [CustID], [HullingExpenses]) VALUES (N'HPE20160727014ac60019f149', N'HP20160727fbc9c30d9c9645', N'om\test', CAST(0x0000A65000E9CC58 AS DateTime), N'N', N'om', 26000.0000)
/****** Object:  UserDefinedFunction [dbo].[HullingProcess_TableRecovery]    Script Date: 08/10/2016 11:42:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[HullingProcess_TableRecovery]
			(
			@RecoveryTime datetime
			)

 -- NEW generated by AutoAudit Version 3.30a on Jul 20 2016 10:07AM
 -- created by Paul Nielsen and John Sigouin 
 -- www.SQLServerBible.com 
 -- AutoAudit.codeplex.com 
 -- This function retrieves an image of the table as it existed at the specified point in time.

RETURNS @HistoryData Table
(
[HullingProcessID]nvarchar (100)
,[CustID]nvarchar (100)
,[TotalBags]int
,[Price]money
) 
AS 
BEGIN 

-- Create table variable to hold history records.
Declare @AuditDataExtract table
	(
	AuditDate datetime
	,Operation varchar(1)
	,[RowVersion] int
	,[HullingProcessID] varchar(50)
	,[CustID] varchar(50)
	,[TotalBags] varchar(50)
	,[Price] varchar(50)
	) 

-- Detailed data retrieval is enabled for this table.
--write the full history for the table into a temp table variable for performance.
Insert @AuditDataExtract 
Select 
			AuditDate
			,Operation
			,[RowVersion]
			,[HullingProcessID]
			,[CustID]
			,[TotalBags]
			,[Price]
FROM		[dbo].[vHullingProcess_RowHistory]

-- Detailed data retrieval is enabled for this table.
;With	AuditDataExtract --Source data query
	AS
	(
	SELECT		*
	FROM		@AuditDataExtract
	),
	CurrentRowExtract 
	AS
	(
	Select		getdate() as AuditDate
				,'c' as Operation
				,(Select isnull(max([RowVersion]),0) + 1 from AuditDataExtract 
				Where	1=1 
					and	AuditDataExtract.[HullingProcessID] = [dbo].[HullingProcess].[HullingProcessID]
				) as [RowVersion]
				,[HullingProcessID]
				,cast([CustID] as varchar(50)) as [CustID]
				,cast([TotalBags] as varchar(50)) as [TotalBags]
				,cast([Price] as varchar(50)) as [Price]
	from		[dbo].[HullingProcess]
			),
			RowHistoryExtract
			AS
			(
			Select * from AuditDataExtract
			Union All
			Select * from CurrentRowExtract
			),
			MostRecentRows
			AS
			(
			--Get most recent rows
			Select 
						max([RowVersion]) as MostRecentRow
						,[HullingProcessID]
			from		RowHistoryExtract
			Group By	
						[HullingProcessID]
			),
			RowHistory
			AS
			(
			--Anchor query for RowHistory buildup. Get the most current rowversion
			Select		
			RowHistoryExtract.AuditDate
			,RowHistoryExtract.Operation
			,RowHistoryExtract.[RowVersion]
			,RowHistoryExtract.[HullingProcessID]
			,RowHistoryExtract.[CustID]
			,RowHistoryExtract.[TotalBags]
			,RowHistoryExtract.[Price]
			From		RowHistoryExtract
			inner join	MostRecentRows
				on		RowHistoryExtract.[RowVersion] = MostRecentRows.MostRecentRow
				and		RowHistoryExtract.[HullingProcessID] = MostRecentRows.[HullingProcessID]
			UNION All
			--Recursive query for RowHistory buildup
			Select		NextVersion.AuditDate
						,NextVersion.Operation
						,NextVersion.[RowVersion]
						,isnull(NextVersion.[HullingProcessID] , PreviousVersion.[HullingProcessID])
						,isnull(NextVersion.[CustID] , PreviousVersion.[CustID])
						,isnull(NextVersion.[TotalBags] , PreviousVersion.[TotalBags])
						,isnull(NextVersion.[Price] , PreviousVersion.[Price])
			from		RowHistoryExtract as NextVersion
			Inner join	RowHistory as PreviousVersion
				on		PreviousVersion.[RowVersion] = NextVersion.[RowVersion] + 1
				and		PreviousVersion.[HullingProcessID] = NextVersion.[HullingProcessID]
			),
			RowsOfInterest
			AS
			(
			--Get Rows Of Interest
			Select		max([RowVersion]) as [RowVersion]
						,[HullingProcessID]
			from		RowHistory
			Where		[AuditDate] <= @RecoveryTime
				And		Operation <> 'c'
			Group By		
						[HullingProcessID]
			)
-- Statement that executes the CTE
Insert into @HistoryData
--Returns the function table
Select 
			rh.[HullingProcessID]
			,nullif(rh.[CustID],'<-null->')
			,nullif(rh.[TotalBags],'<-null->')
			,nullif(rh.[Price],'<-null->')
FROM		RowHistory as rh
Inner join	RowsOfInterest as roi
	on		rh.[RowVersion] = roi.[RowVersion]
	and		rh.[HullingProcessID] = roi.[HullingProcessID]
Where		Operation <> 'd'
order by 
			rh.[HullingProcessID],
			rh.[RowVersion],
			rh.AuditDate
option		(MAXRECURSION 10000)

Return 
END
GO
/****** Object:  UserDefinedFunction [dbo].[HullingProcess_RowHistory]    Script Date: 08/10/2016 11:42:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[HullingProcess_RowHistory]
			(
			@PK varchar(36)
			)

 -- generated by AutoAudit Version 3.30a on Jul 20 2016 10:07AM
 -- created by Paul Nielsen and John Sigouin 
 -- www.SQLServerBible.com 
 -- AutoAudit.codeplex.com 
 -- This function retrieves data from the RowHistory view for the referenced table for the record identified by the PK parameters.

RETURNS @HistoryData Table
(
AuditDate datetime
,Operation varchar(1)
,[RowVersion] int
,[HullingProcessID]nvarchar (100)
,[CustID]nvarchar (100)
,[TotalBags]int
,[Price]money
,ViewScope varchar(10)
,RowHistorySource varchar(10)
,SysUser sysname
,[Application] varchar(128)
,SQLStatement varchar(max)
) 
AS 
BEGIN 

-- Detailed data retrieval is enabled for this table.
With	AuditDataExtract --Source data query
	AS
	(
	SELECT		*
	FROM		[dbo].[vHullingProcess_RowHistory]
	WHERE		[HullingProcessID] = @PK 
	),
	CurrentRowExtract 
	AS
	(
	Select	getdate() as AuditDate
			,'c' as Operation
			,(Select isnull(max([RowVersion]),0) + 1 from AuditDataExtract) as [RowVersion]
			,[HullingProcessID]
			,cast([CustID] as varchar(50)) as [CustID]
			,cast([TotalBags] as varchar(50)) as [TotalBags]
			,cast([Price] as varchar(50)) as [Price]
			,null as ViewScope
			,null as RowHistorySource
			,null as SysUser
			,null as [Application]
			,null as SQLStatement
			from	[dbo].[HullingProcess]
	WHERE		[HullingProcessID] = @PK 
			),
			RowHistoryExtract
			AS
			(
			Select * from AuditDataExtract
			Union All
			Select * from CurrentRowExtract
			),
			RowHistory
			AS
			(
			--Anchor query for RowHistory buildup. Get the most current rowversion
			Select		top 1 *
			From		RowHistoryExtract
			order by	[RowVersion] desc

			UNION All
			--Recursive query for RowHistory buildup
			Select		NextVersion.AuditDate
						,NextVersion.Operation
						,NextVersion.[RowVersion]
						,isnull(NextVersion.[HullingProcessID] , PreviousVersion.[HullingProcessID])
						,isnull(NextVersion.[CustID] , PreviousVersion.[CustID])
						,isnull(NextVersion.[TotalBags] , PreviousVersion.[TotalBags])
						,isnull(NextVersion.[Price] , PreviousVersion.[Price])
						,NextVersion.ViewScope
						,NextVersion.RowHistorySource
						,NextVersion.SysUser
						,NextVersion.[Application]
						,NextVersion.SQLStatement
			from		RowHistoryExtract as NextVersion
			Inner join	RowHistory as PreviousVersion
				on		PreviousVersion.[RowVersion] = NextVersion.[RowVersion] + 1
				and		PreviousVersion.[HullingProcessID] = NextVersion.[HullingProcessID]
			)
-- Statement that executes the CTE
Insert into @HistoryData
	--Returns the function table
	Select	AuditDate
			,Operation
			,[RowVersion]
			,[HullingProcessID]
			, nullif([CustID],'<-null->')
			, nullif([TotalBags],'<-null->')
			, nullif([Price],'<-null->')
			,ViewScope
			,RowHistorySource
			,SysUser
			,[Application]
			,SQLStatement
FROM		RowHistory
where		Operation <> 'c'
order by	[RowVersion],AuditDate
option		(MAXRECURSION 10000)

Return 
END
GO
/****** Object:  Table [dbo].[HullingTransaction]    Script Date: 08/10/2016 11:42:08 ******/
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
INSERT [dbo].[HullingTransaction] ([HullingTransID], [HullingProcessID], [MRiceProdTypeID], [BrokenRiceTypeID], [CustID], [UnitsTypeID], [TotalBags], [Price], [LastModifiedBy], [LastModifiedDate], [ObsInd], [MRiceBrandID]) VALUES (N'HTBR2016071935bc1d37dee65f', N'HP201607193c7cbc73f42b78', NULL, N'PT2016071941d02916ee4073', N'om', N'BT2016071938e099fbd69545', 4, 200.0000, N'om\test', CAST(0x0000A6480149F13C AS DateTime), N'N', NULL)
INSERT [dbo].[HullingTransaction] ([HullingTransID], [HullingProcessID], [MRiceProdTypeID], [BrokenRiceTypeID], [CustID], [UnitsTypeID], [TotalBags], [Price], [LastModifiedBy], [LastModifiedDate], [ObsInd], [MRiceBrandID]) VALUES (N'HTBR201608098bd8224ab79c3d', N'HP20160727fbc9c30d9c9645', NULL, N'PT20160719985d83a75b7627', N'om', N'BT201607198b4fe854818fdc', 4, 4000.0000, N'om\test', CAST(0x0000A65D0140B0E0 AS DateTime), N'N', NULL)
INSERT [dbo].[HullingTransaction] ([HullingTransID], [HullingProcessID], [MRiceProdTypeID], [BrokenRiceTypeID], [CustID], [UnitsTypeID], [TotalBags], [Price], [LastModifiedBy], [LastModifiedDate], [ObsInd], [MRiceBrandID]) VALUES (N'HTD2016071921420271aea18e', N'HP201607193c7cbc73f42b78', NULL, NULL, N'om', N'BT201607198b4fe854818fdc', 1, 3000.0000, N'om\test', CAST(0x0000A6480149F13C AS DateTime), N'N', NULL)
INSERT [dbo].[HullingTransaction] ([HullingTransID], [HullingProcessID], [MRiceProdTypeID], [BrokenRiceTypeID], [CustID], [UnitsTypeID], [TotalBags], [Price], [LastModifiedBy], [LastModifiedDate], [ObsInd], [MRiceBrandID]) VALUES (N'HTD2016080964411ba1e09d09', N'HP20160727fbc9c30d9c9645', NULL, NULL, N'om', N'BT201607198b4fe854818fdc', 2, 2000.0000, N'om\test', CAST(0x0000A65D0140B0E0 AS DateTime), N'N', NULL)
INSERT [dbo].[HullingTransaction] ([HullingTransID], [HullingProcessID], [MRiceProdTypeID], [BrokenRiceTypeID], [CustID], [UnitsTypeID], [TotalBags], [Price], [LastModifiedBy], [LastModifiedDate], [ObsInd], [MRiceBrandID]) VALUES (N'HTR2016071991844b9b8fb46e', N'HP201607193c7cbc73f42b78', N'RP201607196cda0aa0548d47', NULL, N'om', N'BT2016071938e099fbd69545', 260, 0.0000, N'om\test', CAST(0x0000A6480149F13C AS DateTime), N'N', N'RB20160719937050a760653c')
INSERT [dbo].[HullingTransaction] ([HullingTransID], [HullingProcessID], [MRiceProdTypeID], [BrokenRiceTypeID], [CustID], [UnitsTypeID], [TotalBags], [Price], [LastModifiedBy], [LastModifiedDate], [ObsInd], [MRiceBrandID]) VALUES (N'HTR20160809165e949fe31762', N'HP20160727fbc9c30d9c9645', N'RP201607196cda0aa0548d47', NULL, N'om', N'BT2016071938e099fbd69545', 600, 0.0000, N'om\test', CAST(0x0000A65D0140B0E0 AS DateTime), N'N', N'RB20160719937050a760653c')
/****** Object:  UserDefinedFunction [dbo].[ProductSellingInfo_TableRecovery]    Script Date: 08/10/2016 11:42:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[ProductSellingInfo_TableRecovery]
			(
			@RecoveryTime datetime
			)

 -- NEW generated by AutoAudit Version 3.30a on Jul 20 2016 10:07AM
 -- created by Paul Nielsen and John Sigouin 
 -- www.SQLServerBible.com 
 -- AutoAudit.codeplex.com 
 -- This function retrieves an image of the table as it existed at the specified point in time.

RETURNS @HistoryData Table
(
[ProductID]nvarchar (100)
,[CustID]nvarchar (100)
,[Price]money
,[TotalBags]int
) 
AS 
BEGIN 

-- Create table variable to hold history records.
Declare @AuditDataExtract table
	(
	AuditDate datetime
	,Operation varchar(1)
	,[RowVersion] int
	,[ProductID] varchar(50)
	,[CustID] varchar(50)
	,[Price] varchar(50)
	,[TotalBags] varchar(50)
	) 

-- Detailed data retrieval is enabled for this table.
--write the full history for the table into a temp table variable for performance.
Insert @AuditDataExtract 
Select 
			AuditDate
			,Operation
			,[RowVersion]
			,[ProductID]
			,[CustID]
			,[Price]
			,[TotalBags]
FROM		[dbo].[vProductSellingInfo_RowHistory]

-- Detailed data retrieval is enabled for this table.
;With	AuditDataExtract --Source data query
	AS
	(
	SELECT		*
	FROM		@AuditDataExtract
	),
	CurrentRowExtract 
	AS
	(
	Select		getdate() as AuditDate
				,'c' as Operation
				,(Select isnull(max([RowVersion]),0) + 1 from AuditDataExtract 
				Where	1=1 
					and	AuditDataExtract.[ProductID] = [dbo].[ProductSellingInfo].[ProductID]
				) as [RowVersion]
				,[ProductID]
				,cast([CustID] as varchar(50)) as [CustID]
				,cast([Price] as varchar(50)) as [Price]
				,cast([TotalBags] as varchar(50)) as [TotalBags]
	from		[dbo].[ProductSellingInfo]
			),
			RowHistoryExtract
			AS
			(
			Select * from AuditDataExtract
			Union All
			Select * from CurrentRowExtract
			),
			MostRecentRows
			AS
			(
			--Get most recent rows
			Select 
						max([RowVersion]) as MostRecentRow
						,[ProductID]
			from		RowHistoryExtract
			Group By	
						[ProductID]
			),
			RowHistory
			AS
			(
			--Anchor query for RowHistory buildup. Get the most current rowversion
			Select		
			RowHistoryExtract.AuditDate
			,RowHistoryExtract.Operation
			,RowHistoryExtract.[RowVersion]
			,RowHistoryExtract.[ProductID]
			,RowHistoryExtract.[CustID]
			,RowHistoryExtract.[Price]
			,RowHistoryExtract.[TotalBags]
			From		RowHistoryExtract
			inner join	MostRecentRows
				on		RowHistoryExtract.[RowVersion] = MostRecentRows.MostRecentRow
				and		RowHistoryExtract.[ProductID] = MostRecentRows.[ProductID]
			UNION All
			--Recursive query for RowHistory buildup
			Select		NextVersion.AuditDate
						,NextVersion.Operation
						,NextVersion.[RowVersion]
						,isnull(NextVersion.[ProductID] , PreviousVersion.[ProductID])
						,isnull(NextVersion.[CustID] , PreviousVersion.[CustID])
						,isnull(NextVersion.[Price] , PreviousVersion.[Price])
						,isnull(NextVersion.[TotalBags] , PreviousVersion.[TotalBags])
			from		RowHistoryExtract as NextVersion
			Inner join	RowHistory as PreviousVersion
				on		PreviousVersion.[RowVersion] = NextVersion.[RowVersion] + 1
				and		PreviousVersion.[ProductID] = NextVersion.[ProductID]
			),
			RowsOfInterest
			AS
			(
			--Get Rows Of Interest
			Select		max([RowVersion]) as [RowVersion]
						,[ProductID]
			from		RowHistory
			Where		[AuditDate] <= @RecoveryTime
				And		Operation <> 'c'
			Group By		
						[ProductID]
			)
-- Statement that executes the CTE
Insert into @HistoryData
--Returns the function table
Select 
			rh.[ProductID]
			,nullif(rh.[CustID],'<-null->')
			,nullif(rh.[Price],'<-null->')
			,nullif(rh.[TotalBags],'<-null->')
FROM		RowHistory as rh
Inner join	RowsOfInterest as roi
	on		rh.[RowVersion] = roi.[RowVersion]
	and		rh.[ProductID] = roi.[ProductID]
Where		Operation <> 'd'
order by 
			rh.[ProductID],
			rh.[RowVersion],
			rh.AuditDate
option		(MAXRECURSION 10000)

Return 
END
GO
/****** Object:  UserDefinedFunction [dbo].[ProductSellingInfo_RowHistory]    Script Date: 08/10/2016 11:42:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[ProductSellingInfo_RowHistory]
			(
			@PK varchar(36)
			)

 -- generated by AutoAudit Version 3.30a on Jul 20 2016 10:07AM
 -- created by Paul Nielsen and John Sigouin 
 -- www.SQLServerBible.com 
 -- AutoAudit.codeplex.com 
 -- This function retrieves data from the RowHistory view for the referenced table for the record identified by the PK parameters.

RETURNS @HistoryData Table
(
AuditDate datetime
,Operation varchar(1)
,[RowVersion] int
,[ProductID]nvarchar (100)
,[CustID]nvarchar (100)
,[Price]money
,[TotalBags]int
,ViewScope varchar(10)
,RowHistorySource varchar(10)
,SysUser sysname
,[Application] varchar(128)
,SQLStatement varchar(max)
) 
AS 
BEGIN 

-- Detailed data retrieval is enabled for this table.
With	AuditDataExtract --Source data query
	AS
	(
	SELECT		*
	FROM		[dbo].[vProductSellingInfo_RowHistory]
	WHERE		[ProductID] = @PK 
	),
	CurrentRowExtract 
	AS
	(
	Select	getdate() as AuditDate
			,'c' as Operation
			,(Select isnull(max([RowVersion]),0) + 1 from AuditDataExtract) as [RowVersion]
			,[ProductID]
			,cast([CustID] as varchar(50)) as [CustID]
			,cast([Price] as varchar(50)) as [Price]
			,cast([TotalBags] as varchar(50)) as [TotalBags]
			,null as ViewScope
			,null as RowHistorySource
			,null as SysUser
			,null as [Application]
			,null as SQLStatement
			from	[dbo].[ProductSellingInfo]
	WHERE		[ProductID] = @PK 
			),
			RowHistoryExtract
			AS
			(
			Select * from AuditDataExtract
			Union All
			Select * from CurrentRowExtract
			),
			RowHistory
			AS
			(
			--Anchor query for RowHistory buildup. Get the most current rowversion
			Select		top 1 *
			From		RowHistoryExtract
			order by	[RowVersion] desc

			UNION All
			--Recursive query for RowHistory buildup
			Select		NextVersion.AuditDate
						,NextVersion.Operation
						,NextVersion.[RowVersion]
						,isnull(NextVersion.[ProductID] , PreviousVersion.[ProductID])
						,isnull(NextVersion.[CustID] , PreviousVersion.[CustID])
						,isnull(NextVersion.[Price] , PreviousVersion.[Price])
						,isnull(NextVersion.[TotalBags] , PreviousVersion.[TotalBags])
						,NextVersion.ViewScope
						,NextVersion.RowHistorySource
						,NextVersion.SysUser
						,NextVersion.[Application]
						,NextVersion.SQLStatement
			from		RowHistoryExtract as NextVersion
			Inner join	RowHistory as PreviousVersion
				on		PreviousVersion.[RowVersion] = NextVersion.[RowVersion] + 1
				and		PreviousVersion.[ProductID] = NextVersion.[ProductID]
			)
-- Statement that executes the CTE
Insert into @HistoryData
	--Returns the function table
	Select	AuditDate
			,Operation
			,[RowVersion]
			,[ProductID]
			, nullif([CustID],'<-null->')
			, nullif([Price],'<-null->')
			, nullif([TotalBags],'<-null->')
			,ViewScope
			,RowHistorySource
			,SysUser
			,[Application]
			,SQLStatement
FROM		RowHistory
where		Operation <> 'c'
order by	[RowVersion],AuditDate
option		(MAXRECURSION 10000)

Return 
END
GO
/****** Object:  UserDefinedFunction [dbo].[ProductPaymentTransaction_TableRecovery]    Script Date: 08/10/2016 11:42:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[ProductPaymentTransaction_TableRecovery]
			(
			@RecoveryTime datetime
			)

 -- NEW generated by AutoAudit Version 3.30a on Jul 20 2016 10:07AM
 -- created by Paul Nielsen and John Sigouin 
 -- www.SQLServerBible.com 
 -- AutoAudit.codeplex.com 
 -- This function retrieves an image of the table as it existed at the specified point in time.

RETURNS @HistoryData Table
(
[ProductPaymentTranID]nvarchar (100)
,[CustID]nvarchar (100)
,[ReceivedAmount]money
) 
AS 
BEGIN 

-- Create table variable to hold history records.
Declare @AuditDataExtract table
	(
	AuditDate datetime
	,Operation varchar(1)
	,[RowVersion] int
	,[ProductPaymentTranID] varchar(50)
	,[CustID] varchar(50)
	,[ReceivedAmount] varchar(50)
	) 

-- Detailed data retrieval is enabled for this table.
--write the full history for the table into a temp table variable for performance.
Insert @AuditDataExtract 
Select 
			AuditDate
			,Operation
			,[RowVersion]
			,[ProductPaymentTranID]
			,[CustID]
			,[ReceivedAmount]
FROM		[dbo].[vProductPaymentTransaction_RowHistory]

-- Detailed data retrieval is enabled for this table.
;With	AuditDataExtract --Source data query
	AS
	(
	SELECT		*
	FROM		@AuditDataExtract
	),
	CurrentRowExtract 
	AS
	(
	Select		getdate() as AuditDate
				,'c' as Operation
				,(Select isnull(max([RowVersion]),0) + 1 from AuditDataExtract 
				Where	1=1 
					and	AuditDataExtract.[ProductPaymentTranID] = [dbo].[ProductPaymentTransaction].[ProductPaymentTranID]
				) as [RowVersion]
				,[ProductPaymentTranID]
				,cast([CustID] as varchar(50)) as [CustID]
				,cast([ReceivedAmount] as varchar(50)) as [ReceivedAmount]
	from		[dbo].[ProductPaymentTransaction]
			),
			RowHistoryExtract
			AS
			(
			Select * from AuditDataExtract
			Union All
			Select * from CurrentRowExtract
			),
			MostRecentRows
			AS
			(
			--Get most recent rows
			Select 
						max([RowVersion]) as MostRecentRow
						,[ProductPaymentTranID]
			from		RowHistoryExtract
			Group By	
						[ProductPaymentTranID]
			),
			RowHistory
			AS
			(
			--Anchor query for RowHistory buildup. Get the most current rowversion
			Select		
			RowHistoryExtract.AuditDate
			,RowHistoryExtract.Operation
			,RowHistoryExtract.[RowVersion]
			,RowHistoryExtract.[ProductPaymentTranID]
			,RowHistoryExtract.[CustID]
			,RowHistoryExtract.[ReceivedAmount]
			From		RowHistoryExtract
			inner join	MostRecentRows
				on		RowHistoryExtract.[RowVersion] = MostRecentRows.MostRecentRow
				and		RowHistoryExtract.[ProductPaymentTranID] = MostRecentRows.[ProductPaymentTranID]
			UNION All
			--Recursive query for RowHistory buildup
			Select		NextVersion.AuditDate
						,NextVersion.Operation
						,NextVersion.[RowVersion]
						,isnull(NextVersion.[ProductPaymentTranID] , PreviousVersion.[ProductPaymentTranID])
						,isnull(NextVersion.[CustID] , PreviousVersion.[CustID])
						,isnull(NextVersion.[ReceivedAmount] , PreviousVersion.[ReceivedAmount])
			from		RowHistoryExtract as NextVersion
			Inner join	RowHistory as PreviousVersion
				on		PreviousVersion.[RowVersion] = NextVersion.[RowVersion] + 1
				and		PreviousVersion.[ProductPaymentTranID] = NextVersion.[ProductPaymentTranID]
			),
			RowsOfInterest
			AS
			(
			--Get Rows Of Interest
			Select		max([RowVersion]) as [RowVersion]
						,[ProductPaymentTranID]
			from		RowHistory
			Where		[AuditDate] <= @RecoveryTime
				And		Operation <> 'c'
			Group By		
						[ProductPaymentTranID]
			)
-- Statement that executes the CTE
Insert into @HistoryData
--Returns the function table
Select 
			rh.[ProductPaymentTranID]
			,nullif(rh.[CustID],'<-null->')
			,nullif(rh.[ReceivedAmount],'<-null->')
FROM		RowHistory as rh
Inner join	RowsOfInterest as roi
	on		rh.[RowVersion] = roi.[RowVersion]
	and		rh.[ProductPaymentTranID] = roi.[ProductPaymentTranID]
Where		Operation <> 'd'
order by 
			rh.[ProductPaymentTranID],
			rh.[RowVersion],
			rh.AuditDate
option		(MAXRECURSION 10000)

Return 
END
GO
/****** Object:  UserDefinedFunction [dbo].[ProductPaymentTransaction_RowHistory]    Script Date: 08/10/2016 11:42:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[ProductPaymentTransaction_RowHistory]
			(
			@PK varchar(36)
			)

 -- generated by AutoAudit Version 3.30a on Jul 20 2016 10:07AM
 -- created by Paul Nielsen and John Sigouin 
 -- www.SQLServerBible.com 
 -- AutoAudit.codeplex.com 
 -- This function retrieves data from the RowHistory view for the referenced table for the record identified by the PK parameters.

RETURNS @HistoryData Table
(
AuditDate datetime
,Operation varchar(1)
,[RowVersion] int
,[ProductPaymentTranID]nvarchar (100)
,[CustID]nvarchar (100)
,[ReceivedAmount]money
,ViewScope varchar(10)
,RowHistorySource varchar(10)
,SysUser sysname
,[Application] varchar(128)
,SQLStatement varchar(max)
) 
AS 
BEGIN 

-- Detailed data retrieval is enabled for this table.
With	AuditDataExtract --Source data query
	AS
	(
	SELECT		*
	FROM		[dbo].[vProductPaymentTransaction_RowHistory]
	WHERE		[ProductPaymentTranID] = @PK 
	),
	CurrentRowExtract 
	AS
	(
	Select	getdate() as AuditDate
			,'c' as Operation
			,(Select isnull(max([RowVersion]),0) + 1 from AuditDataExtract) as [RowVersion]
			,[ProductPaymentTranID]
			,cast([CustID] as varchar(50)) as [CustID]
			,cast([ReceivedAmount] as varchar(50)) as [ReceivedAmount]
			,null as ViewScope
			,null as RowHistorySource
			,null as SysUser
			,null as [Application]
			,null as SQLStatement
			from	[dbo].[ProductPaymentTransaction]
	WHERE		[ProductPaymentTranID] = @PK 
			),
			RowHistoryExtract
			AS
			(
			Select * from AuditDataExtract
			Union All
			Select * from CurrentRowExtract
			),
			RowHistory
			AS
			(
			--Anchor query for RowHistory buildup. Get the most current rowversion
			Select		top 1 *
			From		RowHistoryExtract
			order by	[RowVersion] desc

			UNION All
			--Recursive query for RowHistory buildup
			Select		NextVersion.AuditDate
						,NextVersion.Operation
						,NextVersion.[RowVersion]
						,isnull(NextVersion.[ProductPaymentTranID] , PreviousVersion.[ProductPaymentTranID])
						,isnull(NextVersion.[CustID] , PreviousVersion.[CustID])
						,isnull(NextVersion.[ReceivedAmount] , PreviousVersion.[ReceivedAmount])
						,NextVersion.ViewScope
						,NextVersion.RowHistorySource
						,NextVersion.SysUser
						,NextVersion.[Application]
						,NextVersion.SQLStatement
			from		RowHistoryExtract as NextVersion
			Inner join	RowHistory as PreviousVersion
				on		PreviousVersion.[RowVersion] = NextVersion.[RowVersion] + 1
				and		PreviousVersion.[ProductPaymentTranID] = NextVersion.[ProductPaymentTranID]
			)
-- Statement that executes the CTE
Insert into @HistoryData
	--Returns the function table
	Select	AuditDate
			,Operation
			,[RowVersion]
			,[ProductPaymentTranID]
			, nullif([CustID],'<-null->')
			, nullif([ReceivedAmount],'<-null->')
			,ViewScope
			,RowHistorySource
			,SysUser
			,[Application]
			,SQLStatement
FROM		RowHistory
where		Operation <> 'c'
order by	[RowVersion],AuditDate
option		(MAXRECURSION 10000)

Return 
END
GO
/****** Object:  UserDefinedFunction [dbo].[PaddyStockInfo_TableRecovery]    Script Date: 08/10/2016 11:42:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[PaddyStockInfo_TableRecovery]
			(
			@RecoveryTime datetime
			)

 -- NEW generated by AutoAudit Version 3.30a on Jul 20 2016 10:07AM
 -- created by Paul Nielsen and John Sigouin 
 -- www.SQLServerBible.com 
 -- AutoAudit.codeplex.com 
 -- This function retrieves an image of the table as it existed at the specified point in time.

RETURNS @HistoryData Table
(
[PaddyStockID]nvarchar (100)
,[CustID]nvarchar (100)
,[Price]money
,[TotalBags]int
) 
AS 
BEGIN 

-- Create table variable to hold history records.
Declare @AuditDataExtract table
	(
	AuditDate datetime
	,Operation varchar(1)
	,[RowVersion] int
	,[PaddyStockID] varchar(50)
	,[CustID] varchar(50)
	,[Price] varchar(50)
	,[TotalBags] varchar(50)
	) 

-- Detailed data retrieval is enabled for this table.
--write the full history for the table into a temp table variable for performance.
Insert @AuditDataExtract 
Select 
			AuditDate
			,Operation
			,[RowVersion]
			,[PaddyStockID]
			,[CustID]
			,[Price]
			,[TotalBags]
FROM		[dbo].[vPaddyStockInfo_RowHistory]

-- Detailed data retrieval is enabled for this table.
;With	AuditDataExtract --Source data query
	AS
	(
	SELECT		*
	FROM		@AuditDataExtract
	),
	CurrentRowExtract 
	AS
	(
	Select		getdate() as AuditDate
				,'c' as Operation
				,(Select isnull(max([RowVersion]),0) + 1 from AuditDataExtract 
				Where	1=1 
					and	AuditDataExtract.[PaddyStockID] = [dbo].[PaddyStockInfo].[PaddyStockID]
				) as [RowVersion]
				,[PaddyStockID]
				,cast([CustID] as varchar(50)) as [CustID]
				,cast([Price] as varchar(50)) as [Price]
				,cast([TotalBags] as varchar(50)) as [TotalBags]
	from		[dbo].[PaddyStockInfo]
			),
			RowHistoryExtract
			AS
			(
			Select * from AuditDataExtract
			Union All
			Select * from CurrentRowExtract
			),
			MostRecentRows
			AS
			(
			--Get most recent rows
			Select 
						max([RowVersion]) as MostRecentRow
						,[PaddyStockID]
			from		RowHistoryExtract
			Group By	
						[PaddyStockID]
			),
			RowHistory
			AS
			(
			--Anchor query for RowHistory buildup. Get the most current rowversion
			Select		
			RowHistoryExtract.AuditDate
			,RowHistoryExtract.Operation
			,RowHistoryExtract.[RowVersion]
			,RowHistoryExtract.[PaddyStockID]
			,RowHistoryExtract.[CustID]
			,RowHistoryExtract.[Price]
			,RowHistoryExtract.[TotalBags]
			From		RowHistoryExtract
			inner join	MostRecentRows
				on		RowHistoryExtract.[RowVersion] = MostRecentRows.MostRecentRow
				and		RowHistoryExtract.[PaddyStockID] = MostRecentRows.[PaddyStockID]
			UNION All
			--Recursive query for RowHistory buildup
			Select		NextVersion.AuditDate
						,NextVersion.Operation
						,NextVersion.[RowVersion]
						,isnull(NextVersion.[PaddyStockID] , PreviousVersion.[PaddyStockID])
						,isnull(NextVersion.[CustID] , PreviousVersion.[CustID])
						,isnull(NextVersion.[Price] , PreviousVersion.[Price])
						,isnull(NextVersion.[TotalBags] , PreviousVersion.[TotalBags])
			from		RowHistoryExtract as NextVersion
			Inner join	RowHistory as PreviousVersion
				on		PreviousVersion.[RowVersion] = NextVersion.[RowVersion] + 1
				and		PreviousVersion.[PaddyStockID] = NextVersion.[PaddyStockID]
			),
			RowsOfInterest
			AS
			(
			--Get Rows Of Interest
			Select		max([RowVersion]) as [RowVersion]
						,[PaddyStockID]
			from		RowHistory
			Where		[AuditDate] <= @RecoveryTime
				And		Operation <> 'c'
			Group By		
						[PaddyStockID]
			)
-- Statement that executes the CTE
Insert into @HistoryData
--Returns the function table
Select 
			rh.[PaddyStockID]
			,nullif(rh.[CustID],'<-null->')
			,nullif(rh.[Price],'<-null->')
			,nullif(rh.[TotalBags],'<-null->')
FROM		RowHistory as rh
Inner join	RowsOfInterest as roi
	on		rh.[RowVersion] = roi.[RowVersion]
	and		rh.[PaddyStockID] = roi.[PaddyStockID]
Where		Operation <> 'd'
order by 
			rh.[PaddyStockID],
			rh.[RowVersion],
			rh.AuditDate
option		(MAXRECURSION 10000)

Return 
END
GO
/****** Object:  UserDefinedFunction [dbo].[PaddyStockInfo_RowHistory]    Script Date: 08/10/2016 11:42:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[PaddyStockInfo_RowHistory]
			(
			@PK varchar(36)
			)

 -- generated by AutoAudit Version 3.30a on Jul 20 2016 10:07AM
 -- created by Paul Nielsen and John Sigouin 
 -- www.SQLServerBible.com 
 -- AutoAudit.codeplex.com 
 -- This function retrieves data from the RowHistory view for the referenced table for the record identified by the PK parameters.

RETURNS @HistoryData Table
(
AuditDate datetime
,Operation varchar(1)
,[RowVersion] int
,[PaddyStockID]nvarchar (100)
,[CustID]nvarchar (100)
,[Price]money
,[TotalBags]int
,ViewScope varchar(10)
,RowHistorySource varchar(10)
,SysUser sysname
,[Application] varchar(128)
,SQLStatement varchar(max)
) 
AS 
BEGIN 

-- Detailed data retrieval is enabled for this table.
With	AuditDataExtract --Source data query
	AS
	(
	SELECT		*
	FROM		[dbo].[vPaddyStockInfo_RowHistory]
	WHERE		[PaddyStockID] = @PK 
	),
	CurrentRowExtract 
	AS
	(
	Select	getdate() as AuditDate
			,'c' as Operation
			,(Select isnull(max([RowVersion]),0) + 1 from AuditDataExtract) as [RowVersion]
			,[PaddyStockID]
			,cast([CustID] as varchar(50)) as [CustID]
			,cast([Price] as varchar(50)) as [Price]
			,cast([TotalBags] as varchar(50)) as [TotalBags]
			,null as ViewScope
			,null as RowHistorySource
			,null as SysUser
			,null as [Application]
			,null as SQLStatement
			from	[dbo].[PaddyStockInfo]
	WHERE		[PaddyStockID] = @PK 
			),
			RowHistoryExtract
			AS
			(
			Select * from AuditDataExtract
			Union All
			Select * from CurrentRowExtract
			),
			RowHistory
			AS
			(
			--Anchor query for RowHistory buildup. Get the most current rowversion
			Select		top 1 *
			From		RowHistoryExtract
			order by	[RowVersion] desc

			UNION All
			--Recursive query for RowHistory buildup
			Select		NextVersion.AuditDate
						,NextVersion.Operation
						,NextVersion.[RowVersion]
						,isnull(NextVersion.[PaddyStockID] , PreviousVersion.[PaddyStockID])
						,isnull(NextVersion.[CustID] , PreviousVersion.[CustID])
						,isnull(NextVersion.[Price] , PreviousVersion.[Price])
						,isnull(NextVersion.[TotalBags] , PreviousVersion.[TotalBags])
						,NextVersion.ViewScope
						,NextVersion.RowHistorySource
						,NextVersion.SysUser
						,NextVersion.[Application]
						,NextVersion.SQLStatement
			from		RowHistoryExtract as NextVersion
			Inner join	RowHistory as PreviousVersion
				on		PreviousVersion.[RowVersion] = NextVersion.[RowVersion] + 1
				and		PreviousVersion.[PaddyStockID] = NextVersion.[PaddyStockID]
			)
-- Statement that executes the CTE
Insert into @HistoryData
	--Returns the function table
	Select	AuditDate
			,Operation
			,[RowVersion]
			,[PaddyStockID]
			, nullif([CustID],'<-null->')
			, nullif([Price],'<-null->')
			, nullif([TotalBags],'<-null->')
			,ViewScope
			,RowHistorySource
			,SysUser
			,[Application]
			,SQLStatement
FROM		RowHistory
where		Operation <> 'c'
order by	[RowVersion],AuditDate
option		(MAXRECURSION 10000)

Return 
END
GO
/****** Object:  Table [dbo].[PaddyPaymentDetails]    Script Date: 08/10/2016 11:42:08 ******/
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
INSERT [dbo].[PaddyPaymentDetails] ([PaddyPaymentID], [SellerID], [CustID], [AmountPaid], [PaidDate], [HandoverTo], [NextPaymentDate], [LastModifiedBy], [LastModifiedDate], [ObsInd], [PaddyStockID], [PaymentMode], [ChequeNo], [BankName]) VALUES (N'PP201607299fb7f8b867d580', N'SE20160719f5092a5d475a46', N'om', 123456.0000, CAST(0x0000A65200B76858 AS DateTime), N'', CAST(0x0000A65200B76858 AS DateTime), N'om\test', CAST(0x0000A65200B79E40 AS DateTime), N'N', NULL, N'Cash', N'', N'')
INSERT [dbo].[PaddyPaymentDetails] ([PaddyPaymentID], [SellerID], [CustID], [AmountPaid], [PaidDate], [HandoverTo], [NextPaymentDate], [LastModifiedBy], [LastModifiedDate], [ObsInd], [PaddyStockID], [PaymentMode], [ChequeNo], [BankName]) VALUES (N'PP20160729dc0abc9198e9c0', N'SE2016071959f4346f09f947', N'om', 99000.0000, CAST(0x0000A65200F14D0C AS DateTime), N'', CAST(0x0000A65200F14D0C AS DateTime), N'om\test', CAST(0x0000A65200F16B84 AS DateTime), N'N', NULL, N'Cash', N'', N'')
INSERT [dbo].[PaddyPaymentDetails] ([PaddyPaymentID], [SellerID], [CustID], [AmountPaid], [PaidDate], [HandoverTo], [NextPaymentDate], [LastModifiedBy], [LastModifiedDate], [ObsInd], [PaddyStockID], [PaymentMode], [ChequeNo], [BankName]) VALUES (N'PP20160802928323c845729b', N'SE2016071959f4346f09f947', N'om', 261000.0000, CAST(0x0000A5A600F89904 AS DateTime), N'', CAST(0x0000A5A600F89904 AS DateTime), N'om\test', CAST(0x0000A65600F8BD58 AS DateTime), N'N', NULL, N'Cash', N'', N'')
/****** Object:  UserDefinedFunction [dbo].[PaddyPaymentDetails_TableRecovery]    Script Date: 08/10/2016 11:42:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[PaddyPaymentDetails_TableRecovery]
			(
			@RecoveryTime datetime
			)

 -- NEW generated by AutoAudit Version 3.30a on Jul 20 2016 10:07AM
 -- created by Paul Nielsen and John Sigouin 
 -- www.SQLServerBible.com 
 -- AutoAudit.codeplex.com 
 -- This function retrieves an image of the table as it existed at the specified point in time.

RETURNS @HistoryData Table
(
[PaddyPaymentID]nvarchar (100)
,[CustID]nvarchar (100)
,[AmountPaid]money
) 
AS 
BEGIN 

-- Create table variable to hold history records.
Declare @AuditDataExtract table
	(
	AuditDate datetime
	,Operation varchar(1)
	,[RowVersion] int
	,[PaddyPaymentID] varchar(50)
	,[CustID] varchar(50)
	,[AmountPaid] varchar(50)
	) 

-- Detailed data retrieval is enabled for this table.
--write the full history for the table into a temp table variable for performance.
Insert @AuditDataExtract 
Select 
			AuditDate
			,Operation
			,[RowVersion]
			,[PaddyPaymentID]
			,[CustID]
			,[AmountPaid]
FROM		[dbo].[vPaddyPaymentDetails_RowHistory]

-- Detailed data retrieval is enabled for this table.
;With	AuditDataExtract --Source data query
	AS
	(
	SELECT		*
	FROM		@AuditDataExtract
	),
	CurrentRowExtract 
	AS
	(
	Select		getdate() as AuditDate
				,'c' as Operation
				,(Select isnull(max([RowVersion]),0) + 1 from AuditDataExtract 
				Where	1=1 
					and	AuditDataExtract.[PaddyPaymentID] = [dbo].[PaddyPaymentDetails].[PaddyPaymentID]
				) as [RowVersion]
				,[PaddyPaymentID]
				,cast([CustID] as varchar(50)) as [CustID]
				,cast([AmountPaid] as varchar(50)) as [AmountPaid]
	from		[dbo].[PaddyPaymentDetails]
			),
			RowHistoryExtract
			AS
			(
			Select * from AuditDataExtract
			Union All
			Select * from CurrentRowExtract
			),
			MostRecentRows
			AS
			(
			--Get most recent rows
			Select 
						max([RowVersion]) as MostRecentRow
						,[PaddyPaymentID]
			from		RowHistoryExtract
			Group By	
						[PaddyPaymentID]
			),
			RowHistory
			AS
			(
			--Anchor query for RowHistory buildup. Get the most current rowversion
			Select		
			RowHistoryExtract.AuditDate
			,RowHistoryExtract.Operation
			,RowHistoryExtract.[RowVersion]
			,RowHistoryExtract.[PaddyPaymentID]
			,RowHistoryExtract.[CustID]
			,RowHistoryExtract.[AmountPaid]
			From		RowHistoryExtract
			inner join	MostRecentRows
				on		RowHistoryExtract.[RowVersion] = MostRecentRows.MostRecentRow
				and		RowHistoryExtract.[PaddyPaymentID] = MostRecentRows.[PaddyPaymentID]
			UNION All
			--Recursive query for RowHistory buildup
			Select		NextVersion.AuditDate
						,NextVersion.Operation
						,NextVersion.[RowVersion]
						,isnull(NextVersion.[PaddyPaymentID] , PreviousVersion.[PaddyPaymentID])
						,isnull(NextVersion.[CustID] , PreviousVersion.[CustID])
						,isnull(NextVersion.[AmountPaid] , PreviousVersion.[AmountPaid])
			from		RowHistoryExtract as NextVersion
			Inner join	RowHistory as PreviousVersion
				on		PreviousVersion.[RowVersion] = NextVersion.[RowVersion] + 1
				and		PreviousVersion.[PaddyPaymentID] = NextVersion.[PaddyPaymentID]
			),
			RowsOfInterest
			AS
			(
			--Get Rows Of Interest
			Select		max([RowVersion]) as [RowVersion]
						,[PaddyPaymentID]
			from		RowHistory
			Where		[AuditDate] <= @RecoveryTime
				And		Operation <> 'c'
			Group By		
						[PaddyPaymentID]
			)
-- Statement that executes the CTE
Insert into @HistoryData
--Returns the function table
Select 
			rh.[PaddyPaymentID]
			,nullif(rh.[CustID],'<-null->')
			,nullif(rh.[AmountPaid],'<-null->')
FROM		RowHistory as rh
Inner join	RowsOfInterest as roi
	on		rh.[RowVersion] = roi.[RowVersion]
	and		rh.[PaddyPaymentID] = roi.[PaddyPaymentID]
Where		Operation <> 'd'
order by 
			rh.[PaddyPaymentID],
			rh.[RowVersion],
			rh.AuditDate
option		(MAXRECURSION 10000)

Return 
END
GO
/****** Object:  UserDefinedFunction [dbo].[PaddyPaymentDetails_RowHistory]    Script Date: 08/10/2016 11:42:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[PaddyPaymentDetails_RowHistory]
			(
			@PK varchar(36)
			)

 -- generated by AutoAudit Version 3.30a on Jul 20 2016 10:07AM
 -- created by Paul Nielsen and John Sigouin 
 -- www.SQLServerBible.com 
 -- AutoAudit.codeplex.com 
 -- This function retrieves data from the RowHistory view for the referenced table for the record identified by the PK parameters.

RETURNS @HistoryData Table
(
AuditDate datetime
,Operation varchar(1)
,[RowVersion] int
,[PaddyPaymentID]nvarchar (100)
,[CustID]nvarchar (100)
,[AmountPaid]money
,ViewScope varchar(10)
,RowHistorySource varchar(10)
,SysUser sysname
,[Application] varchar(128)
,SQLStatement varchar(max)
) 
AS 
BEGIN 

-- Detailed data retrieval is enabled for this table.
With	AuditDataExtract --Source data query
	AS
	(
	SELECT		*
	FROM		[dbo].[vPaddyPaymentDetails_RowHistory]
	WHERE		[PaddyPaymentID] = @PK 
	),
	CurrentRowExtract 
	AS
	(
	Select	getdate() as AuditDate
			,'c' as Operation
			,(Select isnull(max([RowVersion]),0) + 1 from AuditDataExtract) as [RowVersion]
			,[PaddyPaymentID]
			,cast([CustID] as varchar(50)) as [CustID]
			,cast([AmountPaid] as varchar(50)) as [AmountPaid]
			,null as ViewScope
			,null as RowHistorySource
			,null as SysUser
			,null as [Application]
			,null as SQLStatement
			from	[dbo].[PaddyPaymentDetails]
	WHERE		[PaddyPaymentID] = @PK 
			),
			RowHistoryExtract
			AS
			(
			Select * from AuditDataExtract
			Union All
			Select * from CurrentRowExtract
			),
			RowHistory
			AS
			(
			--Anchor query for RowHistory buildup. Get the most current rowversion
			Select		top 1 *
			From		RowHistoryExtract
			order by	[RowVersion] desc

			UNION All
			--Recursive query for RowHistory buildup
			Select		NextVersion.AuditDate
						,NextVersion.Operation
						,NextVersion.[RowVersion]
						,isnull(NextVersion.[PaddyPaymentID] , PreviousVersion.[PaddyPaymentID])
						,isnull(NextVersion.[CustID] , PreviousVersion.[CustID])
						,isnull(NextVersion.[AmountPaid] , PreviousVersion.[AmountPaid])
						,NextVersion.ViewScope
						,NextVersion.RowHistorySource
						,NextVersion.SysUser
						,NextVersion.[Application]
						,NextVersion.SQLStatement
			from		RowHistoryExtract as NextVersion
			Inner join	RowHistory as PreviousVersion
				on		PreviousVersion.[RowVersion] = NextVersion.[RowVersion] + 1
				and		PreviousVersion.[PaddyPaymentID] = NextVersion.[PaddyPaymentID]
			)
-- Statement that executes the CTE
Insert into @HistoryData
	--Returns the function table
	Select	AuditDate
			,Operation
			,[RowVersion]
			,[PaddyPaymentID]
			, nullif([CustID],'<-null->')
			, nullif([AmountPaid],'<-null->')
			,ViewScope
			,RowHistorySource
			,SysUser
			,[Application]
			,SQLStatement
FROM		RowHistory
where		Operation <> 'c'
order by	[RowVersion],AuditDate
option		(MAXRECURSION 10000)

Return 
END
GO
/****** Object:  UserDefinedFunction [dbo].[HullingTransaction_TableRecovery]    Script Date: 08/10/2016 11:42:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[HullingTransaction_TableRecovery]
			(
			@RecoveryTime datetime
			)

 -- NEW generated by AutoAudit Version 3.30a on Jul 20 2016 10:07AM
 -- created by Paul Nielsen and John Sigouin 
 -- www.SQLServerBible.com 
 -- AutoAudit.codeplex.com 
 -- This function retrieves an image of the table as it existed at the specified point in time.

RETURNS @HistoryData Table
(
[HullingTransID]nvarchar (100)
,[MRiceProdTypeID]nvarchar (100)
,[BrokenRiceTypeID]nvarchar (100)
,[CustID]nvarchar (100)
,[TotalBags]int
,[Price]money
) 
AS 
BEGIN 

-- Create table variable to hold history records.
Declare @AuditDataExtract table
	(
	AuditDate datetime
	,Operation varchar(1)
	,[RowVersion] int
	,[HullingTransID] varchar(50)
	,[MRiceProdTypeID] varchar(50)
	,[BrokenRiceTypeID] varchar(50)
	,[CustID] varchar(50)
	,[TotalBags] varchar(50)
	,[Price] varchar(50)
	) 

-- Detailed data retrieval is enabled for this table.
--write the full history for the table into a temp table variable for performance.
Insert @AuditDataExtract 
Select 
			AuditDate
			,Operation
			,[RowVersion]
			,[HullingTransID]
			,[MRiceProdTypeID]
			,[BrokenRiceTypeID]
			,[CustID]
			,[TotalBags]
			,[Price]
FROM		[dbo].[vHullingTransaction_RowHistory]

-- Detailed data retrieval is enabled for this table.
;With	AuditDataExtract --Source data query
	AS
	(
	SELECT		*
	FROM		@AuditDataExtract
	),
	CurrentRowExtract 
	AS
	(
	Select		getdate() as AuditDate
				,'c' as Operation
				,(Select isnull(max([RowVersion]),0) + 1 from AuditDataExtract 
				Where	1=1 
					and	AuditDataExtract.[HullingTransID] = [dbo].[HullingTransaction].[HullingTransID]
				) as [RowVersion]
				,[HullingTransID]
				,cast([MRiceProdTypeID] as varchar(50)) as [MRiceProdTypeID]
				,cast([BrokenRiceTypeID] as varchar(50)) as [BrokenRiceTypeID]
				,cast([CustID] as varchar(50)) as [CustID]
				,cast([TotalBags] as varchar(50)) as [TotalBags]
				,cast([Price] as varchar(50)) as [Price]
	from		[dbo].[HullingTransaction]
			),
			RowHistoryExtract
			AS
			(
			Select * from AuditDataExtract
			Union All
			Select * from CurrentRowExtract
			),
			MostRecentRows
			AS
			(
			--Get most recent rows
			Select 
						max([RowVersion]) as MostRecentRow
						,[HullingTransID]
			from		RowHistoryExtract
			Group By	
						[HullingTransID]
			),
			RowHistory
			AS
			(
			--Anchor query for RowHistory buildup. Get the most current rowversion
			Select		
			RowHistoryExtract.AuditDate
			,RowHistoryExtract.Operation
			,RowHistoryExtract.[RowVersion]
			,RowHistoryExtract.[HullingTransID]
			,RowHistoryExtract.[MRiceProdTypeID]
			,RowHistoryExtract.[BrokenRiceTypeID]
			,RowHistoryExtract.[CustID]
			,RowHistoryExtract.[TotalBags]
			,RowHistoryExtract.[Price]
			From		RowHistoryExtract
			inner join	MostRecentRows
				on		RowHistoryExtract.[RowVersion] = MostRecentRows.MostRecentRow
				and		RowHistoryExtract.[HullingTransID] = MostRecentRows.[HullingTransID]
			UNION All
			--Recursive query for RowHistory buildup
			Select		NextVersion.AuditDate
						,NextVersion.Operation
						,NextVersion.[RowVersion]
						,isnull(NextVersion.[HullingTransID] , PreviousVersion.[HullingTransID])
						,isnull(NextVersion.[MRiceProdTypeID] , PreviousVersion.[MRiceProdTypeID])
						,isnull(NextVersion.[BrokenRiceTypeID] , PreviousVersion.[BrokenRiceTypeID])
						,isnull(NextVersion.[CustID] , PreviousVersion.[CustID])
						,isnull(NextVersion.[TotalBags] , PreviousVersion.[TotalBags])
						,isnull(NextVersion.[Price] , PreviousVersion.[Price])
			from		RowHistoryExtract as NextVersion
			Inner join	RowHistory as PreviousVersion
				on		PreviousVersion.[RowVersion] = NextVersion.[RowVersion] + 1
				and		PreviousVersion.[HullingTransID] = NextVersion.[HullingTransID]
			),
			RowsOfInterest
			AS
			(
			--Get Rows Of Interest
			Select		max([RowVersion]) as [RowVersion]
						,[HullingTransID]
			from		RowHistory
			Where		[AuditDate] <= @RecoveryTime
				And		Operation <> 'c'
			Group By		
						[HullingTransID]
			)
-- Statement that executes the CTE
Insert into @HistoryData
--Returns the function table
Select 
			rh.[HullingTransID]
			,nullif(rh.[MRiceProdTypeID],'<-null->')
			,nullif(rh.[BrokenRiceTypeID],'<-null->')
			,nullif(rh.[CustID],'<-null->')
			,nullif(rh.[TotalBags],'<-null->')
			,nullif(rh.[Price],'<-null->')
FROM		RowHistory as rh
Inner join	RowsOfInterest as roi
	on		rh.[RowVersion] = roi.[RowVersion]
	and		rh.[HullingTransID] = roi.[HullingTransID]
Where		Operation <> 'd'
order by 
			rh.[HullingTransID],
			rh.[RowVersion],
			rh.AuditDate
option		(MAXRECURSION 10000)

Return 
END
GO
/****** Object:  UserDefinedFunction [dbo].[HullingTransaction_RowHistory]    Script Date: 08/10/2016 11:42:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[HullingTransaction_RowHistory]
			(
			@PK varchar(36)
			)

 -- generated by AutoAudit Version 3.30a on Jul 20 2016 10:07AM
 -- created by Paul Nielsen and John Sigouin 
 -- www.SQLServerBible.com 
 -- AutoAudit.codeplex.com 
 -- This function retrieves data from the RowHistory view for the referenced table for the record identified by the PK parameters.

RETURNS @HistoryData Table
(
AuditDate datetime
,Operation varchar(1)
,[RowVersion] int
,[HullingTransID]nvarchar (100)
,[MRiceProdTypeID]nvarchar (100)
,[BrokenRiceTypeID]nvarchar (100)
,[CustID]nvarchar (100)
,[TotalBags]int
,[Price]money
,ViewScope varchar(10)
,RowHistorySource varchar(10)
,SysUser sysname
,[Application] varchar(128)
,SQLStatement varchar(max)
) 
AS 
BEGIN 

-- Detailed data retrieval is enabled for this table.
With	AuditDataExtract --Source data query
	AS
	(
	SELECT		*
	FROM		[dbo].[vHullingTransaction_RowHistory]
	WHERE		[HullingTransID] = @PK 
	),
	CurrentRowExtract 
	AS
	(
	Select	getdate() as AuditDate
			,'c' as Operation
			,(Select isnull(max([RowVersion]),0) + 1 from AuditDataExtract) as [RowVersion]
			,[HullingTransID]
			,cast([MRiceProdTypeID] as varchar(50)) as [MRiceProdTypeID]
			,cast([BrokenRiceTypeID] as varchar(50)) as [BrokenRiceTypeID]
			,cast([CustID] as varchar(50)) as [CustID]
			,cast([TotalBags] as varchar(50)) as [TotalBags]
			,cast([Price] as varchar(50)) as [Price]
			,null as ViewScope
			,null as RowHistorySource
			,null as SysUser
			,null as [Application]
			,null as SQLStatement
			from	[dbo].[HullingTransaction]
	WHERE		[HullingTransID] = @PK 
			),
			RowHistoryExtract
			AS
			(
			Select * from AuditDataExtract
			Union All
			Select * from CurrentRowExtract
			),
			RowHistory
			AS
			(
			--Anchor query for RowHistory buildup. Get the most current rowversion
			Select		top 1 *
			From		RowHistoryExtract
			order by	[RowVersion] desc

			UNION All
			--Recursive query for RowHistory buildup
			Select		NextVersion.AuditDate
						,NextVersion.Operation
						,NextVersion.[RowVersion]
						,isnull(NextVersion.[HullingTransID] , PreviousVersion.[HullingTransID])
						,isnull(NextVersion.[MRiceProdTypeID] , PreviousVersion.[MRiceProdTypeID])
						,isnull(NextVersion.[BrokenRiceTypeID] , PreviousVersion.[BrokenRiceTypeID])
						,isnull(NextVersion.[CustID] , PreviousVersion.[CustID])
						,isnull(NextVersion.[TotalBags] , PreviousVersion.[TotalBags])
						,isnull(NextVersion.[Price] , PreviousVersion.[Price])
						,NextVersion.ViewScope
						,NextVersion.RowHistorySource
						,NextVersion.SysUser
						,NextVersion.[Application]
						,NextVersion.SQLStatement
			from		RowHistoryExtract as NextVersion
			Inner join	RowHistory as PreviousVersion
				on		PreviousVersion.[RowVersion] = NextVersion.[RowVersion] + 1
				and		PreviousVersion.[HullingTransID] = NextVersion.[HullingTransID]
			)
-- Statement that executes the CTE
Insert into @HistoryData
	--Returns the function table
	Select	AuditDate
			,Operation
			,[RowVersion]
			,[HullingTransID]
			, nullif([MRiceProdTypeID],'<-null->')
			, nullif([BrokenRiceTypeID],'<-null->')
			, nullif([CustID],'<-null->')
			, nullif([TotalBags],'<-null->')
			, nullif([Price],'<-null->')
			,ViewScope
			,RowHistorySource
			,SysUser
			,[Application]
			,SQLStatement
FROM		RowHistory
where		Operation <> 'c'
order by	[RowVersion],AuditDate
option		(MAXRECURSION 10000)

Return 
END
GO
/****** Object:  UserDefinedFunction [dbo].[HullingProcessExpenses_TableRecovery]    Script Date: 08/10/2016 11:42:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[HullingProcessExpenses_TableRecovery]
			(
			@RecoveryTime datetime
			)

 -- NEW generated by AutoAudit Version 3.30a on Jul 20 2016 10:07AM
 -- created by Paul Nielsen and John Sigouin 
 -- www.SQLServerBible.com 
 -- AutoAudit.codeplex.com 
 -- This function retrieves an image of the table as it existed at the specified point in time.

RETURNS @HistoryData Table
(
[HullingProcessExpenID]nvarchar (100)
,[CustID]nvarchar (100)
,[HullingExpenses]money
) 
AS 
BEGIN 

-- Create table variable to hold history records.
Declare @AuditDataExtract table
	(
	AuditDate datetime
	,Operation varchar(1)
	,[RowVersion] int
	,[HullingProcessExpenID] varchar(50)
	,[CustID] varchar(50)
	,[HullingExpenses] varchar(50)
	) 

-- Detailed data retrieval is enabled for this table.
--write the full history for the table into a temp table variable for performance.
Insert @AuditDataExtract 
Select 
			AuditDate
			,Operation
			,[RowVersion]
			,[HullingProcessExpenID]
			,[CustID]
			,[HullingExpenses]
FROM		[dbo].[vHullingProcessExpenses_RowHistory]

-- Detailed data retrieval is enabled for this table.
;With	AuditDataExtract --Source data query
	AS
	(
	SELECT		*
	FROM		@AuditDataExtract
	),
	CurrentRowExtract 
	AS
	(
	Select		getdate() as AuditDate
				,'c' as Operation
				,(Select isnull(max([RowVersion]),0) + 1 from AuditDataExtract 
				Where	1=1 
					and	AuditDataExtract.[HullingProcessExpenID] = [dbo].[HullingProcessExpenses].[HullingProcessExpenID]
				) as [RowVersion]
				,[HullingProcessExpenID]
				,cast([CustID] as varchar(50)) as [CustID]
				,cast([HullingExpenses] as varchar(50)) as [HullingExpenses]
	from		[dbo].[HullingProcessExpenses]
			),
			RowHistoryExtract
			AS
			(
			Select * from AuditDataExtract
			Union All
			Select * from CurrentRowExtract
			),
			MostRecentRows
			AS
			(
			--Get most recent rows
			Select 
						max([RowVersion]) as MostRecentRow
						,[HullingProcessExpenID]
			from		RowHistoryExtract
			Group By	
						[HullingProcessExpenID]
			),
			RowHistory
			AS
			(
			--Anchor query for RowHistory buildup. Get the most current rowversion
			Select		
			RowHistoryExtract.AuditDate
			,RowHistoryExtract.Operation
			,RowHistoryExtract.[RowVersion]
			,RowHistoryExtract.[HullingProcessExpenID]
			,RowHistoryExtract.[CustID]
			,RowHistoryExtract.[HullingExpenses]
			From		RowHistoryExtract
			inner join	MostRecentRows
				on		RowHistoryExtract.[RowVersion] = MostRecentRows.MostRecentRow
				and		RowHistoryExtract.[HullingProcessExpenID] = MostRecentRows.[HullingProcessExpenID]
			UNION All
			--Recursive query for RowHistory buildup
			Select		NextVersion.AuditDate
						,NextVersion.Operation
						,NextVersion.[RowVersion]
						,isnull(NextVersion.[HullingProcessExpenID] , PreviousVersion.[HullingProcessExpenID])
						,isnull(NextVersion.[CustID] , PreviousVersion.[CustID])
						,isnull(NextVersion.[HullingExpenses] , PreviousVersion.[HullingExpenses])
			from		RowHistoryExtract as NextVersion
			Inner join	RowHistory as PreviousVersion
				on		PreviousVersion.[RowVersion] = NextVersion.[RowVersion] + 1
				and		PreviousVersion.[HullingProcessExpenID] = NextVersion.[HullingProcessExpenID]
			),
			RowsOfInterest
			AS
			(
			--Get Rows Of Interest
			Select		max([RowVersion]) as [RowVersion]
						,[HullingProcessExpenID]
			from		RowHistory
			Where		[AuditDate] <= @RecoveryTime
				And		Operation <> 'c'
			Group By		
						[HullingProcessExpenID]
			)
-- Statement that executes the CTE
Insert into @HistoryData
--Returns the function table
Select 
			rh.[HullingProcessExpenID]
			,nullif(rh.[CustID],'<-null->')
			,nullif(rh.[HullingExpenses],'<-null->')
FROM		RowHistory as rh
Inner join	RowsOfInterest as roi
	on		rh.[RowVersion] = roi.[RowVersion]
	and		rh.[HullingProcessExpenID] = roi.[HullingProcessExpenID]
Where		Operation <> 'd'
order by 
			rh.[HullingProcessExpenID],
			rh.[RowVersion],
			rh.AuditDate
option		(MAXRECURSION 10000)

Return 
END
GO
/****** Object:  UserDefinedFunction [dbo].[HullingProcessExpenses_RowHistory]    Script Date: 08/10/2016 11:42:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[HullingProcessExpenses_RowHistory]
			(
			@PK varchar(36)
			)

 -- generated by AutoAudit Version 3.30a on Jul 20 2016 10:07AM
 -- created by Paul Nielsen and John Sigouin 
 -- www.SQLServerBible.com 
 -- AutoAudit.codeplex.com 
 -- This function retrieves data from the RowHistory view for the referenced table for the record identified by the PK parameters.

RETURNS @HistoryData Table
(
AuditDate datetime
,Operation varchar(1)
,[RowVersion] int
,[HullingProcessExpenID]nvarchar (100)
,[CustID]nvarchar (100)
,[HullingExpenses]money
,ViewScope varchar(10)
,RowHistorySource varchar(10)
,SysUser sysname
,[Application] varchar(128)
,SQLStatement varchar(max)
) 
AS 
BEGIN 

-- Detailed data retrieval is enabled for this table.
With	AuditDataExtract --Source data query
	AS
	(
	SELECT		*
	FROM		[dbo].[vHullingProcessExpenses_RowHistory]
	WHERE		[HullingProcessExpenID] = @PK 
	),
	CurrentRowExtract 
	AS
	(
	Select	getdate() as AuditDate
			,'c' as Operation
			,(Select isnull(max([RowVersion]),0) + 1 from AuditDataExtract) as [RowVersion]
			,[HullingProcessExpenID]
			,cast([CustID] as varchar(50)) as [CustID]
			,cast([HullingExpenses] as varchar(50)) as [HullingExpenses]
			,null as ViewScope
			,null as RowHistorySource
			,null as SysUser
			,null as [Application]
			,null as SQLStatement
			from	[dbo].[HullingProcessExpenses]
	WHERE		[HullingProcessExpenID] = @PK 
			),
			RowHistoryExtract
			AS
			(
			Select * from AuditDataExtract
			Union All
			Select * from CurrentRowExtract
			),
			RowHistory
			AS
			(
			--Anchor query for RowHistory buildup. Get the most current rowversion
			Select		top 1 *
			From		RowHistoryExtract
			order by	[RowVersion] desc

			UNION All
			--Recursive query for RowHistory buildup
			Select		NextVersion.AuditDate
						,NextVersion.Operation
						,NextVersion.[RowVersion]
						,isnull(NextVersion.[HullingProcessExpenID] , PreviousVersion.[HullingProcessExpenID])
						,isnull(NextVersion.[CustID] , PreviousVersion.[CustID])
						,isnull(NextVersion.[HullingExpenses] , PreviousVersion.[HullingExpenses])
						,NextVersion.ViewScope
						,NextVersion.RowHistorySource
						,NextVersion.SysUser
						,NextVersion.[Application]
						,NextVersion.SQLStatement
			from		RowHistoryExtract as NextVersion
			Inner join	RowHistory as PreviousVersion
				on		PreviousVersion.[RowVersion] = NextVersion.[RowVersion] + 1
				and		PreviousVersion.[HullingProcessExpenID] = NextVersion.[HullingProcessExpenID]
			)
-- Statement that executes the CTE
Insert into @HistoryData
	--Returns the function table
	Select	AuditDate
			,Operation
			,[RowVersion]
			,[HullingProcessExpenID]
			, nullif([CustID],'<-null->')
			, nullif([HullingExpenses],'<-null->')
			,ViewScope
			,RowHistorySource
			,SysUser
			,[Application]
			,SQLStatement
FROM		RowHistory
where		Operation <> 'c'
order by	[RowVersion],AuditDate
option		(MAXRECURSION 10000)

Return 
END
GO
/****** Object:  Default [DF__AuditBase__Colum__3864608B]    Script Date: 08/10/2016 11:42:06 ******/
ALTER TABLE [Audit].[AuditBaseTables] ADD  DEFAULT ('<All>') FOR [ColumnNames]
GO
/****** Object:  ForeignKey [FK_Users_CustomerInfo]    Script Date: 08/10/2016 11:42:07 ******/
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_CustomerInfo] FOREIGN KEY([CustID])
REFERENCES [dbo].[CustomerInfo] ([CustID])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_CustomerInfo]
GO
/****** Object:  ForeignKey [FK_SellerInfo_CustomerInfo]    Script Date: 08/10/2016 11:42:07 ******/
ALTER TABLE [dbo].[SellerInfo]  WITH CHECK ADD  CONSTRAINT [FK_SellerInfo_CustomerInfo] FOREIGN KEY([CustID])
REFERENCES [dbo].[CustomerInfo] ([CustID])
GO
ALTER TABLE [dbo].[SellerInfo] CHECK CONSTRAINT [FK_SellerInfo_CustomerInfo]
GO
/****** Object:  ForeignKey [fkAuditHeaderArchive]    Script Date: 08/10/2016 11:42:07 ******/
ALTER TABLE [Audit].[AuditDetailArchive]  WITH CHECK ADD  CONSTRAINT [fkAuditHeaderArchive] FOREIGN KEY([AuditHeaderID])
REFERENCES [Audit].[AuditHeaderArchive] ([AuditHeaderID])
GO
ALTER TABLE [Audit].[AuditDetailArchive] CHECK CONSTRAINT [fkAuditHeaderArchive]
GO
/****** Object:  ForeignKey [fkAuditHeader]    Script Date: 08/10/2016 11:42:07 ******/
ALTER TABLE [Audit].[AuditDetail]  WITH CHECK ADD  CONSTRAINT [fkAuditHeader] FOREIGN KEY([AuditHeaderID])
REFERENCES [Audit].[AuditHeader] ([AuditHeaderID])
GO
ALTER TABLE [Audit].[AuditDetail] CHECK CONSTRAINT [fkAuditHeader]
GO
/****** Object:  ForeignKey [FK_BuyerInfo_CustomerInfo]    Script Date: 08/10/2016 11:42:07 ******/
ALTER TABLE [dbo].[BuyerInfo]  WITH CHECK ADD  CONSTRAINT [FK_BuyerInfo_CustomerInfo] FOREIGN KEY([CustID])
REFERENCES [dbo].[CustomerInfo] ([CustID])
GO
ALTER TABLE [dbo].[BuyerInfo] CHECK CONSTRAINT [FK_BuyerInfo_CustomerInfo]
GO
/****** Object:  ForeignKey [FK_CustTrailUsage_CustomerInfo]    Script Date: 08/10/2016 11:42:07 ******/
ALTER TABLE [dbo].[CustTrailUsage]  WITH CHECK ADD  CONSTRAINT [FK_CustTrailUsage_CustomerInfo] FOREIGN KEY([CustID])
REFERENCES [dbo].[CustomerInfo] ([CustID])
GO
ALTER TABLE [dbo].[CustTrailUsage] CHECK CONSTRAINT [FK_CustTrailUsage_CustomerInfo]
GO
/****** Object:  ForeignKey [FK_CustomerPayment_CustomerInfo]    Script Date: 08/10/2016 11:42:07 ******/
ALTER TABLE [dbo].[CustomerPayment]  WITH CHECK ADD  CONSTRAINT [FK_CustomerPayment_CustomerInfo] FOREIGN KEY([CustID])
REFERENCES [dbo].[CustomerInfo] ([CustID])
GO
ALTER TABLE [dbo].[CustomerPayment] CHECK CONSTRAINT [FK_CustomerPayment_CustomerInfo]
GO
/****** Object:  ForeignKey [FK_CustomerPartPayDetails_CustomerInfo]    Script Date: 08/10/2016 11:42:07 ******/
ALTER TABLE [dbo].[CustomerPartPayDetails]  WITH CHECK ADD  CONSTRAINT [FK_CustomerPartPayDetails_CustomerInfo] FOREIGN KEY([CustID])
REFERENCES [dbo].[CustomerInfo] ([CustID])
GO
ALTER TABLE [dbo].[CustomerPartPayDetails] CHECK CONSTRAINT [FK_CustomerPartPayDetails_CustomerInfo]
GO
/****** Object:  ForeignKey [FK_CustomerAddressInfo_CustomerAddressInfo]    Script Date: 08/10/2016 11:42:07 ******/
ALTER TABLE [dbo].[CustomerAddressInfo]  WITH NOCHECK ADD  CONSTRAINT [FK_CustomerAddressInfo_CustomerAddressInfo] FOREIGN KEY([CustID])
REFERENCES [dbo].[CustomerInfo] ([CustID])
NOT FOR REPLICATION
GO
ALTER TABLE [dbo].[CustomerAddressInfo] NOCHECK CONSTRAINT [FK_CustomerAddressInfo_CustomerAddressInfo]
GO
/****** Object:  ForeignKey [FK_CustomerActivation_CustomerInfo]    Script Date: 08/10/2016 11:42:07 ******/
ALTER TABLE [dbo].[CustomerActivation]  WITH CHECK ADD  CONSTRAINT [FK_CustomerActivation_CustomerInfo] FOREIGN KEY([CustID])
REFERENCES [dbo].[CustomerInfo] ([CustID])
GO
ALTER TABLE [dbo].[CustomerActivation] CHECK CONSTRAINT [FK_CustomerActivation_CustomerInfo]
GO
/****** Object:  ForeignKey [FK_MBagType_CustomerInfo]    Script Date: 08/10/2016 11:42:07 ******/
ALTER TABLE [dbo].[MBagType]  WITH CHECK ADD  CONSTRAINT [FK_MBagType_CustomerInfo] FOREIGN KEY([CustID])
REFERENCES [dbo].[CustomerInfo] ([CustID])
GO
ALTER TABLE [dbo].[MBagType] CHECK CONSTRAINT [FK_MBagType_CustomerInfo]
GO
/****** Object:  ForeignKey [FK_EmployeeDetails_CustomerInfo]    Script Date: 08/10/2016 11:42:07 ******/
ALTER TABLE [dbo].[EmployeeDetails]  WITH CHECK ADD  CONSTRAINT [FK_EmployeeDetails_CustomerInfo] FOREIGN KEY([CustID])
REFERENCES [dbo].[CustomerInfo] ([CustID])
GO
ALTER TABLE [dbo].[EmployeeDetails] CHECK CONSTRAINT [FK_EmployeeDetails_CustomerInfo]
GO
/****** Object:  ForeignKey [FK_MEmployeeDesignation_CustomerInfo]    Script Date: 08/10/2016 11:42:07 ******/
ALTER TABLE [dbo].[MEmployeeDesignation]  WITH CHECK ADD  CONSTRAINT [FK_MEmployeeDesignation_CustomerInfo] FOREIGN KEY([CustID])
REFERENCES [dbo].[CustomerInfo] ([CustID])
GO
ALTER TABLE [dbo].[MEmployeeDesignation] CHECK CONSTRAINT [FK_MEmployeeDesignation_CustomerInfo]
GO
/****** Object:  ForeignKey [FK_MediatorInfo_CustomerInfo]    Script Date: 08/10/2016 11:42:07 ******/
ALTER TABLE [dbo].[MediatorInfo]  WITH CHECK ADD  CONSTRAINT [FK_MediatorInfo_CustomerInfo] FOREIGN KEY([CustID])
REFERENCES [dbo].[CustomerInfo] ([CustID])
GO
ALTER TABLE [dbo].[MediatorInfo] CHECK CONSTRAINT [FK_MediatorInfo_CustomerInfo]
GO
/****** Object:  ForeignKey [FK_MDrierTypeDetails_CustomerInfo]    Script Date: 08/10/2016 11:42:07 ******/
ALTER TABLE [dbo].[MDrierTypeDetails]  WITH CHECK ADD  CONSTRAINT [FK_MDrierTypeDetails_CustomerInfo] FOREIGN KEY([CustID])
REFERENCES [dbo].[CustomerInfo] ([CustID])
GO
ALTER TABLE [dbo].[MDrierTypeDetails] CHECK CONSTRAINT [FK_MDrierTypeDetails_CustomerInfo]
GO
/****** Object:  ForeignKey [FK_MWeightDetails_CustomerInfo]    Script Date: 08/10/2016 11:42:07 ******/
ALTER TABLE [dbo].[MWeightDetails]  WITH CHECK ADD  CONSTRAINT [FK_MWeightDetails_CustomerInfo] FOREIGN KEY([CustID])
REFERENCES [dbo].[CustomerInfo] ([CustID])
GO
ALTER TABLE [dbo].[MWeightDetails] CHECK CONSTRAINT [FK_MWeightDetails_CustomerInfo]
GO
/****** Object:  ForeignKey [FK_MUnitsType_CustomerInfo]    Script Date: 08/10/2016 11:42:07 ******/
ALTER TABLE [dbo].[MUnitsType]  WITH CHECK ADD  CONSTRAINT [FK_MUnitsType_CustomerInfo] FOREIGN KEY([CustID])
REFERENCES [dbo].[CustomerInfo] ([CustID])
GO
ALTER TABLE [dbo].[MUnitsType] CHECK CONSTRAINT [FK_MUnitsType_CustomerInfo]
GO
/****** Object:  ForeignKey [FK_MSalaryType_CustomerInfo]    Script Date: 08/10/2016 11:42:07 ******/
ALTER TABLE [dbo].[MSalaryType]  WITH CHECK ADD  CONSTRAINT [FK_MSalaryType_CustomerInfo] FOREIGN KEY([CustID])
REFERENCES [dbo].[CustomerInfo] ([CustID])
GO
ALTER TABLE [dbo].[MSalaryType] CHECK CONSTRAINT [FK_MSalaryType_CustomerInfo]
GO
/****** Object:  ForeignKey [FK_MJobWork_CustomerInfo]    Script Date: 08/10/2016 11:42:07 ******/
ALTER TABLE [dbo].[MJobWork]  WITH CHECK ADD  CONSTRAINT [FK_MJobWork_CustomerInfo] FOREIGN KEY([CustID])
REFERENCES [dbo].[CustomerInfo] ([CustID])
GO
ALTER TABLE [dbo].[MJobWork] CHECK CONSTRAINT [FK_MJobWork_CustomerInfo]
GO
/****** Object:  ForeignKey [FK_MGodownDetails_CustomerInfo]    Script Date: 08/10/2016 11:42:07 ******/
ALTER TABLE [dbo].[MGodownDetails]  WITH CHECK ADD  CONSTRAINT [FK_MGodownDetails_CustomerInfo] FOREIGN KEY([CustID])
REFERENCES [dbo].[CustomerInfo] ([CustID])
GO
ALTER TABLE [dbo].[MGodownDetails] CHECK CONSTRAINT [FK_MGodownDetails_CustomerInfo]
GO
/****** Object:  ForeignKey [FK_MExpenseType_CustomerInfo]    Script Date: 08/10/2016 11:42:07 ******/
ALTER TABLE [dbo].[MExpenseType]  WITH CHECK ADD  CONSTRAINT [FK_MExpenseType_CustomerInfo] FOREIGN KEY([CustID])
REFERENCES [dbo].[CustomerInfo] ([CustID])
GO
ALTER TABLE [dbo].[MExpenseType] CHECK CONSTRAINT [FK_MExpenseType_CustomerInfo]
GO
/****** Object:  ForeignKey [FK_MessageInfo_CustomerInfo1]    Script Date: 08/10/2016 11:42:07 ******/
ALTER TABLE [dbo].[MessageInfo]  WITH CHECK ADD  CONSTRAINT [FK_MessageInfo_CustomerInfo1] FOREIGN KEY([CustID])
REFERENCES [dbo].[CustomerInfo] ([CustID])
GO
ALTER TABLE [dbo].[MessageInfo] CHECK CONSTRAINT [FK_MessageInfo_CustomerInfo1]
GO
/****** Object:  ForeignKey [FK_MRiceProductionType_CustomerInfo]    Script Date: 08/10/2016 11:42:07 ******/
ALTER TABLE [dbo].[MRiceProductionType]  WITH CHECK ADD  CONSTRAINT [FK_MRiceProductionType_CustomerInfo] FOREIGN KEY([CustID])
REFERENCES [dbo].[CustomerInfo] ([CustID])
GO
ALTER TABLE [dbo].[MRiceProductionType] CHECK CONSTRAINT [FK_MRiceProductionType_CustomerInfo]
GO
/****** Object:  ForeignKey [FK_MRiceBrandDetails_CustomerInfo]    Script Date: 08/10/2016 11:42:07 ******/
ALTER TABLE [dbo].[MRiceBrandDetails]  WITH CHECK ADD  CONSTRAINT [FK_MRiceBrandDetails_CustomerInfo] FOREIGN KEY([CustID])
REFERENCES [dbo].[CustomerInfo] ([CustID])
GO
ALTER TABLE [dbo].[MRiceBrandDetails] CHECK CONSTRAINT [FK_MRiceBrandDetails_CustomerInfo]
GO
/****** Object:  ForeignKey [FK_MPaddyType_CustomerInfo]    Script Date: 08/10/2016 11:42:07 ******/
ALTER TABLE [dbo].[MPaddyType]  WITH CHECK ADD  CONSTRAINT [FK_MPaddyType_CustomerInfo] FOREIGN KEY([CustID])
REFERENCES [dbo].[CustomerInfo] ([CustID])
GO
ALTER TABLE [dbo].[MPaddyType] CHECK CONSTRAINT [FK_MPaddyType_CustomerInfo]
GO
/****** Object:  ForeignKey [fk_MEmpDsgID]    Script Date: 08/10/2016 11:42:07 ******/
ALTER TABLE [dbo].[MoneyTransaction]  WITH CHECK ADD  CONSTRAINT [fk_MEmpDsgID] FOREIGN KEY([MEmpDsgID])
REFERENCES [dbo].[MEmployeeDesignation] ([MEmpDsgID])
GO
ALTER TABLE [dbo].[MoneyTransaction] CHECK CONSTRAINT [fk_MEmpDsgID]
GO
/****** Object:  ForeignKey [FK_MoneyTransaction_CustomerInfo]    Script Date: 08/10/2016 11:42:07 ******/
ALTER TABLE [dbo].[MoneyTransaction]  WITH CHECK ADD  CONSTRAINT [FK_MoneyTransaction_CustomerInfo] FOREIGN KEY([CustID])
REFERENCES [dbo].[CustomerInfo] ([CustID])
GO
ALTER TABLE [dbo].[MoneyTransaction] CHECK CONSTRAINT [FK_MoneyTransaction_CustomerInfo]
GO
/****** Object:  ForeignKey [FK_MoneyTransaction_EmployeeDetails]    Script Date: 08/10/2016 11:42:07 ******/
ALTER TABLE [dbo].[MoneyTransaction]  WITH CHECK ADD  CONSTRAINT [FK_MoneyTransaction_EmployeeDetails] FOREIGN KEY([EmployeeID])
REFERENCES [dbo].[EmployeeDetails] ([EmployeeID])
GO
ALTER TABLE [dbo].[MoneyTransaction] CHECK CONSTRAINT [FK_MoneyTransaction_EmployeeDetails]
GO
/****** Object:  ForeignKey [fk_MonySalaryTypeID]    Script Date: 08/10/2016 11:42:07 ******/
ALTER TABLE [dbo].[MoneyTransaction]  WITH CHECK ADD  CONSTRAINT [fk_MonySalaryTypeID] FOREIGN KEY([MSalaryTypeID])
REFERENCES [dbo].[MSalaryType] ([MSalaryTypeID])
GO
ALTER TABLE [dbo].[MoneyTransaction] CHECK CONSTRAINT [fk_MonySalaryTypeID]
GO
/****** Object:  ForeignKey [FK_MLotDetails_CustomerInfo]    Script Date: 08/10/2016 11:42:07 ******/
ALTER TABLE [dbo].[MLotDetails]  WITH CHECK ADD  CONSTRAINT [FK_MLotDetails_CustomerInfo] FOREIGN KEY([CustID])
REFERENCES [dbo].[CustomerInfo] ([CustID])
GO
ALTER TABLE [dbo].[MLotDetails] CHECK CONSTRAINT [FK_MLotDetails_CustomerInfo]
GO
/****** Object:  ForeignKey [FK_MLotDetails_MGodownDetails]    Script Date: 08/10/2016 11:42:07 ******/
ALTER TABLE [dbo].[MLotDetails]  WITH CHECK ADD  CONSTRAINT [FK_MLotDetails_MGodownDetails] FOREIGN KEY([MGodownID])
REFERENCES [dbo].[MGodownDetails] ([MGodownID])
GO
ALTER TABLE [dbo].[MLotDetails] CHECK CONSTRAINT [FK_MLotDetails_MGodownDetails]
GO
/****** Object:  ForeignKey [FK_EmployeeSalary_CustomerInfo]    Script Date: 08/10/2016 11:42:07 ******/
ALTER TABLE [dbo].[EmployeeSalary]  WITH CHECK ADD  CONSTRAINT [FK_EmployeeSalary_CustomerInfo] FOREIGN KEY([CustID])
REFERENCES [dbo].[CustomerInfo] ([CustID])
GO
ALTER TABLE [dbo].[EmployeeSalary] CHECK CONSTRAINT [FK_EmployeeSalary_CustomerInfo]
GO
/****** Object:  ForeignKey [FK_EmployeeSalary_EmployeeDetails]    Script Date: 08/10/2016 11:42:07 ******/
ALTER TABLE [dbo].[EmployeeSalary]  WITH CHECK ADD  CONSTRAINT [FK_EmployeeSalary_EmployeeDetails] FOREIGN KEY([EmployeeID])
REFERENCES [dbo].[EmployeeDetails] ([EmployeeID])
GO
ALTER TABLE [dbo].[EmployeeSalary] CHECK CONSTRAINT [FK_EmployeeSalary_EmployeeDetails]
GO
/****** Object:  ForeignKey [FK_EmployeeSalary_MEmployeeDesignation]    Script Date: 08/10/2016 11:42:07 ******/
ALTER TABLE [dbo].[EmployeeSalary]  WITH CHECK ADD  CONSTRAINT [FK_EmployeeSalary_MEmployeeDesignation] FOREIGN KEY([MEmpDsgID])
REFERENCES [dbo].[MEmployeeDesignation] ([MEmpDsgID])
GO
ALTER TABLE [dbo].[EmployeeSalary] CHECK CONSTRAINT [FK_EmployeeSalary_MEmployeeDesignation]
GO
/****** Object:  ForeignKey [FK_EmployeeSalary_MSalaryType]    Script Date: 08/10/2016 11:42:07 ******/
ALTER TABLE [dbo].[EmployeeSalary]  WITH CHECK ADD  CONSTRAINT [FK_EmployeeSalary_MSalaryType] FOREIGN KEY([MSalaryTypeID])
REFERENCES [dbo].[MSalaryType] ([MSalaryTypeID])
GO
ALTER TABLE [dbo].[EmployeeSalary] CHECK CONSTRAINT [FK_EmployeeSalary_MSalaryType]
GO
/****** Object:  ForeignKey [FK_DustStockInfo_CustomerInfo]    Script Date: 08/10/2016 11:42:07 ******/
ALTER TABLE [dbo].[DustStockInfo]  WITH CHECK ADD  CONSTRAINT [FK_DustStockInfo_CustomerInfo] FOREIGN KEY([CustID])
REFERENCES [dbo].[CustomerInfo] ([CustID])
GO
ALTER TABLE [dbo].[DustStockInfo] CHECK CONSTRAINT [FK_DustStockInfo_CustomerInfo]
GO
/****** Object:  ForeignKey [FK_DustStockInfo_MUnitsType]    Script Date: 08/10/2016 11:42:07 ******/
ALTER TABLE [dbo].[DustStockInfo]  WITH CHECK ADD  CONSTRAINT [FK_DustStockInfo_MUnitsType] FOREIGN KEY([UnitsTypeID])
REFERENCES [dbo].[MUnitsType] ([UnitsTypeID])
GO
ALTER TABLE [dbo].[DustStockInfo] CHECK CONSTRAINT [FK_DustStockInfo_MUnitsType]
GO
/****** Object:  ForeignKey [FK_ExpenseTransaction_CustomerInfo]    Script Date: 08/10/2016 11:42:07 ******/
ALTER TABLE [dbo].[ExpenseTransaction]  WITH CHECK ADD  CONSTRAINT [FK_ExpenseTransaction_CustomerInfo] FOREIGN KEY([CustID])
REFERENCES [dbo].[CustomerInfo] ([CustID])
GO
ALTER TABLE [dbo].[ExpenseTransaction] CHECK CONSTRAINT [FK_ExpenseTransaction_CustomerInfo]
GO
/****** Object:  ForeignKey [FK_ExpenseTransaction_MExpenseType]    Script Date: 08/10/2016 11:42:07 ******/
ALTER TABLE [dbo].[ExpenseTransaction]  WITH CHECK ADD  CONSTRAINT [FK_ExpenseTransaction_MExpenseType] FOREIGN KEY([ExpenseID])
REFERENCES [dbo].[MExpenseType] ([ExpenseID])
GO
ALTER TABLE [dbo].[ExpenseTransaction] CHECK CONSTRAINT [FK_ExpenseTransaction_MExpenseType]
GO
/****** Object:  ForeignKey [FK_RentalHulling_CustomerInfo]    Script Date: 08/10/2016 11:42:07 ******/
ALTER TABLE [dbo].[RentalHulling]  WITH CHECK ADD  CONSTRAINT [FK_RentalHulling_CustomerInfo] FOREIGN KEY([CustID])
REFERENCES [dbo].[CustomerInfo] ([CustID])
GO
ALTER TABLE [dbo].[RentalHulling] CHECK CONSTRAINT [FK_RentalHulling_CustomerInfo]
GO
/****** Object:  ForeignKey [FK_RentalHulling_MJobWork]    Script Date: 08/10/2016 11:42:07 ******/
ALTER TABLE [dbo].[RentalHulling]  WITH CHECK ADD  CONSTRAINT [FK_RentalHulling_MJobWork] FOREIGN KEY([JobWorkID])
REFERENCES [dbo].[MJobWork] ([JobWorkID])
GO
ALTER TABLE [dbo].[RentalHulling] CHECK CONSTRAINT [FK_RentalHulling_MJobWork]
GO
/****** Object:  ForeignKey [fk_BuyerID]    Script Date: 08/10/2016 11:42:07 ******/
ALTER TABLE [dbo].[ProductPaymentInfo]  WITH CHECK ADD  CONSTRAINT [fk_BuyerID] FOREIGN KEY([BuyerID])
REFERENCES [dbo].[BuyerInfo] ([BuyerID])
GO
ALTER TABLE [dbo].[ProductPaymentInfo] CHECK CONSTRAINT [fk_BuyerID]
GO
/****** Object:  ForeignKey [FK_ProductPaymentInfo_CustomerInfo]    Script Date: 08/10/2016 11:42:07 ******/
ALTER TABLE [dbo].[ProductPaymentInfo]  WITH CHECK ADD  CONSTRAINT [FK_ProductPaymentInfo_CustomerInfo] FOREIGN KEY([CustID])
REFERENCES [dbo].[CustomerInfo] ([CustID])
GO
ALTER TABLE [dbo].[ProductPaymentInfo] CHECK CONSTRAINT [FK_ProductPaymentInfo_CustomerInfo]
GO
/****** Object:  ForeignKey [fk_ProPayMediatorID]    Script Date: 08/10/2016 11:42:07 ******/
ALTER TABLE [dbo].[ProductPaymentInfo]  WITH CHECK ADD  CONSTRAINT [fk_ProPayMediatorID] FOREIGN KEY([MediatorID])
REFERENCES [dbo].[MediatorInfo] ([MediatorID])
GO
ALTER TABLE [dbo].[ProductPaymentInfo] CHECK CONSTRAINT [fk_ProPayMediatorID]
GO
/****** Object:  ForeignKey [FK_ByuerSellerRating_CustomerInfo]    Script Date: 08/10/2016 11:42:07 ******/
ALTER TABLE [dbo].[BuyerSellerRating]  WITH CHECK ADD  CONSTRAINT [FK_ByuerSellerRating_CustomerInfo] FOREIGN KEY([CustID])
REFERENCES [dbo].[CustomerInfo] ([CustID])
GO
ALTER TABLE [dbo].[BuyerSellerRating] CHECK CONSTRAINT [FK_ByuerSellerRating_CustomerInfo]
GO
/****** Object:  ForeignKey [FK_ByuerSellerRating_SellerInfo]    Script Date: 08/10/2016 11:42:07 ******/
ALTER TABLE [dbo].[BuyerSellerRating]  WITH CHECK ADD  CONSTRAINT [FK_ByuerSellerRating_SellerInfo] FOREIGN KEY([SellerID])
REFERENCES [dbo].[SellerInfo] ([SellerID])
GO
ALTER TABLE [dbo].[BuyerSellerRating] CHECK CONSTRAINT [FK_ByuerSellerRating_SellerInfo]
GO
/****** Object:  ForeignKey [FK_BagStockInfo_CustomerInfo]    Script Date: 08/10/2016 11:42:07 ******/
ALTER TABLE [dbo].[BagStockInfo]  WITH CHECK ADD  CONSTRAINT [FK_BagStockInfo_CustomerInfo] FOREIGN KEY([CustID])
REFERENCES [dbo].[CustomerInfo] ([CustID])
GO
ALTER TABLE [dbo].[BagStockInfo] CHECK CONSTRAINT [FK_BagStockInfo_CustomerInfo]
GO
/****** Object:  ForeignKey [FK_BagStockInfo_SellerInfo]    Script Date: 08/10/2016 11:42:07 ******/
ALTER TABLE [dbo].[BagStockInfo]  WITH CHECK ADD  CONSTRAINT [FK_BagStockInfo_SellerInfo] FOREIGN KEY([SellerID])
REFERENCES [dbo].[SellerInfo] ([SellerID])
GO
ALTER TABLE [dbo].[BagStockInfo] CHECK CONSTRAINT [FK_BagStockInfo_SellerInfo]
GO
/****** Object:  ForeignKey [fkBagStockInfo_MRiceBrandID]    Script Date: 08/10/2016 11:42:07 ******/
ALTER TABLE [dbo].[BagStockInfo]  WITH CHECK ADD  CONSTRAINT [fkBagStockInfo_MRiceBrandID] FOREIGN KEY([MRiceBrandID])
REFERENCES [dbo].[MRiceBrandDetails] ([MRiceBrandID])
GO
ALTER TABLE [dbo].[BagStockInfo] CHECK CONSTRAINT [fkBagStockInfo_MRiceBrandID]
GO
/****** Object:  ForeignKey [fkBagStockInfo_UnitsTypeID]    Script Date: 08/10/2016 11:42:07 ******/
ALTER TABLE [dbo].[BagStockInfo]  WITH CHECK ADD  CONSTRAINT [fkBagStockInfo_UnitsTypeID] FOREIGN KEY([UnitsTypeID])
REFERENCES [dbo].[MUnitsType] ([UnitsTypeID])
GO
ALTER TABLE [dbo].[BagStockInfo] CHECK CONSTRAINT [fkBagStockInfo_UnitsTypeID]
GO
/****** Object:  ForeignKey [FK_BankTransaction_CustomerInfo]    Script Date: 08/10/2016 11:42:07 ******/
ALTER TABLE [dbo].[BankTransaction]  WITH CHECK ADD  CONSTRAINT [FK_BankTransaction_CustomerInfo] FOREIGN KEY([CustID])
REFERENCES [dbo].[CustomerInfo] ([CustID])
GO
ALTER TABLE [dbo].[BankTransaction] CHECK CONSTRAINT [FK_BankTransaction_CustomerInfo]
GO
/****** Object:  ForeignKey [FK_BagPaymentInfo_CustomerInfo]    Script Date: 08/10/2016 11:42:07 ******/
ALTER TABLE [dbo].[BagPaymentInfo]  WITH CHECK ADD  CONSTRAINT [FK_BagPaymentInfo_CustomerInfo] FOREIGN KEY([CustID])
REFERENCES [dbo].[CustomerInfo] ([CustID])
GO
ALTER TABLE [dbo].[BagPaymentInfo] CHECK CONSTRAINT [FK_BagPaymentInfo_CustomerInfo]
GO
/****** Object:  ForeignKey [FK_BagPaymentInfo_SellerInfo]    Script Date: 08/10/2016 11:42:07 ******/
ALTER TABLE [dbo].[BagPaymentInfo]  WITH CHECK ADD  CONSTRAINT [FK_BagPaymentInfo_SellerInfo] FOREIGN KEY([SellerID])
REFERENCES [dbo].[SellerInfo] ([SellerID])
GO
ALTER TABLE [dbo].[BagPaymentInfo] CHECK CONSTRAINT [FK_BagPaymentInfo_SellerInfo]
GO
/****** Object:  ForeignKey [FK_BrokenRiceStockInfo_CustomerInfo]    Script Date: 08/10/2016 11:42:07 ******/
ALTER TABLE [dbo].[BrokenRiceStockInfo]  WITH CHECK ADD  CONSTRAINT [FK_BrokenRiceStockInfo_CustomerInfo] FOREIGN KEY([CustID])
REFERENCES [dbo].[CustomerInfo] ([CustID])
GO
ALTER TABLE [dbo].[BrokenRiceStockInfo] CHECK CONSTRAINT [FK_BrokenRiceStockInfo_CustomerInfo]
GO
/****** Object:  ForeignKey [FK_BrokenRiceStockInfo_MBrokenRiceType]    Script Date: 08/10/2016 11:42:07 ******/
ALTER TABLE [dbo].[BrokenRiceStockInfo]  WITH CHECK ADD  CONSTRAINT [FK_BrokenRiceStockInfo_MBrokenRiceType] FOREIGN KEY([BrokenRiceTypeID])
REFERENCES [dbo].[MBrokenRiceType] ([BrokenRiceTypeID])
GO
ALTER TABLE [dbo].[BrokenRiceStockInfo] CHECK CONSTRAINT [FK_BrokenRiceStockInfo_MBrokenRiceType]
GO
/****** Object:  ForeignKey [FK_BrokenRiceStockInfo_MUnitsType]    Script Date: 08/10/2016 11:42:07 ******/
ALTER TABLE [dbo].[BrokenRiceStockInfo]  WITH CHECK ADD  CONSTRAINT [FK_BrokenRiceStockInfo_MUnitsType] FOREIGN KEY([UnitsTypeID])
REFERENCES [dbo].[MUnitsType] ([UnitsTypeID])
GO
ALTER TABLE [dbo].[BrokenRiceStockInfo] CHECK CONSTRAINT [FK_BrokenRiceStockInfo_MUnitsType]
GO
/****** Object:  ForeignKey [FK_RiceStockInfo_CustomerInfo]    Script Date: 08/10/2016 11:42:07 ******/
ALTER TABLE [dbo].[RiceStockInfo]  WITH CHECK ADD  CONSTRAINT [FK_RiceStockInfo_CustomerInfo] FOREIGN KEY([CustID])
REFERENCES [dbo].[CustomerInfo] ([CustID])
GO
ALTER TABLE [dbo].[RiceStockInfo] CHECK CONSTRAINT [FK_RiceStockInfo_CustomerInfo]
GO
/****** Object:  ForeignKey [FK_RiceStockInfo_MRiceBrandDetails]    Script Date: 08/10/2016 11:42:07 ******/
ALTER TABLE [dbo].[RiceStockInfo]  WITH CHECK ADD  CONSTRAINT [FK_RiceStockInfo_MRiceBrandDetails] FOREIGN KEY([MRiceBrandID])
REFERENCES [dbo].[MRiceBrandDetails] ([MRiceBrandID])
GO
ALTER TABLE [dbo].[RiceStockInfo] CHECK CONSTRAINT [FK_RiceStockInfo_MRiceBrandDetails]
GO
/****** Object:  ForeignKey [FK_RiceStockInfo_MUnitsType]    Script Date: 08/10/2016 11:42:07 ******/
ALTER TABLE [dbo].[RiceStockInfo]  WITH CHECK ADD  CONSTRAINT [FK_RiceStockInfo_MUnitsType] FOREIGN KEY([UnitsTypeID])
REFERENCES [dbo].[MUnitsType] ([UnitsTypeID])
GO
ALTER TABLE [dbo].[RiceStockInfo] CHECK CONSTRAINT [FK_RiceStockInfo_MUnitsType]
GO
/****** Object:  ForeignKey [FK_RiceStockInfo_RiceStockInfo]    Script Date: 08/10/2016 11:42:07 ******/
ALTER TABLE [dbo].[RiceStockInfo]  WITH CHECK ADD  CONSTRAINT [FK_RiceStockInfo_RiceStockInfo] FOREIGN KEY([MRiceProdTypeID])
REFERENCES [dbo].[MRiceProductionType] ([MRiceProdTypeID])
GO
ALTER TABLE [dbo].[RiceStockInfo] CHECK CONSTRAINT [FK_RiceStockInfo_RiceStockInfo]
GO
/****** Object:  ForeignKey [FK_PaddyStockInfo_CustomerInfo]    Script Date: 08/10/2016 11:42:08 ******/
ALTER TABLE [dbo].[PaddyStockInfo]  WITH CHECK ADD  CONSTRAINT [FK_PaddyStockInfo_CustomerInfo] FOREIGN KEY([CustID])
REFERENCES [dbo].[CustomerInfo] ([CustID])
GO
ALTER TABLE [dbo].[PaddyStockInfo] CHECK CONSTRAINT [FK_PaddyStockInfo_CustomerInfo]
GO
/****** Object:  ForeignKey [FK_PaddyStockInfo_MGodownDetails]    Script Date: 08/10/2016 11:42:08 ******/
ALTER TABLE [dbo].[PaddyStockInfo]  WITH CHECK ADD  CONSTRAINT [FK_PaddyStockInfo_MGodownDetails] FOREIGN KEY([MGodownID])
REFERENCES [dbo].[MGodownDetails] ([MGodownID])
GO
ALTER TABLE [dbo].[PaddyStockInfo] CHECK CONSTRAINT [FK_PaddyStockInfo_MGodownDetails]
GO
/****** Object:  ForeignKey [FK_PaddyStockInfo_MLotDetails]    Script Date: 08/10/2016 11:42:08 ******/
ALTER TABLE [dbo].[PaddyStockInfo]  WITH CHECK ADD  CONSTRAINT [FK_PaddyStockInfo_MLotDetails] FOREIGN KEY([MLotID])
REFERENCES [dbo].[MLotDetails] ([MLotID])
GO
ALTER TABLE [dbo].[PaddyStockInfo] CHECK CONSTRAINT [FK_PaddyStockInfo_MLotDetails]
GO
/****** Object:  ForeignKey [FK_PaddyStockInfo_MPaddyType]    Script Date: 08/10/2016 11:42:08 ******/
ALTER TABLE [dbo].[PaddyStockInfo]  WITH CHECK ADD  CONSTRAINT [FK_PaddyStockInfo_MPaddyType] FOREIGN KEY([PaddyTypeID])
REFERENCES [dbo].[MPaddyType] ([PaddyTypeID])
GO
ALTER TABLE [dbo].[PaddyStockInfo] CHECK CONSTRAINT [FK_PaddyStockInfo_MPaddyType]
GO
/****** Object:  ForeignKey [FK_PaddyStockInfo_SellerInfo]    Script Date: 08/10/2016 11:42:08 ******/
ALTER TABLE [dbo].[PaddyStockInfo]  WITH CHECK ADD  CONSTRAINT [FK_PaddyStockInfo_SellerInfo] FOREIGN KEY([SellerID])
REFERENCES [dbo].[SellerInfo] ([SellerID])
GO
ALTER TABLE [dbo].[PaddyStockInfo] CHECK CONSTRAINT [FK_PaddyStockInfo_SellerInfo]
GO
/****** Object:  ForeignKey [fk_UnitsTypeID]    Script Date: 08/10/2016 11:42:08 ******/
ALTER TABLE [dbo].[PaddyStockInfo]  WITH CHECK ADD  CONSTRAINT [fk_UnitsTypeID] FOREIGN KEY([UnitsTypeID])
REFERENCES [dbo].[MUnitsType] ([UnitsTypeID])
GO
ALTER TABLE [dbo].[PaddyStockInfo] CHECK CONSTRAINT [fk_UnitsTypeID]
GO
/****** Object:  ForeignKey [fk_ProductPaymentTransaction_BuyerID]    Script Date: 08/10/2016 11:42:08 ******/
ALTER TABLE [dbo].[ProductPaymentTransaction]  WITH CHECK ADD  CONSTRAINT [fk_ProductPaymentTransaction_BuyerID] FOREIGN KEY([BuyerID])
REFERENCES [dbo].[BuyerInfo] ([BuyerID])
GO
ALTER TABLE [dbo].[ProductPaymentTransaction] CHECK CONSTRAINT [fk_ProductPaymentTransaction_BuyerID]
GO
/****** Object:  ForeignKey [FK_ProductPaymentTransaction_CustomerInfo]    Script Date: 08/10/2016 11:42:08 ******/
ALTER TABLE [dbo].[ProductPaymentTransaction]  WITH CHECK ADD  CONSTRAINT [FK_ProductPaymentTransaction_CustomerInfo] FOREIGN KEY([CustID])
REFERENCES [dbo].[CustomerInfo] ([CustID])
GO
ALTER TABLE [dbo].[ProductPaymentTransaction] CHECK CONSTRAINT [FK_ProductPaymentTransaction_CustomerInfo]
GO
/****** Object:  ForeignKey [FK_ProductPaymentTransaction_ProductPaymentInfo]    Script Date: 08/10/2016 11:42:08 ******/
ALTER TABLE [dbo].[ProductPaymentTransaction]  WITH CHECK ADD  CONSTRAINT [FK_ProductPaymentTransaction_ProductPaymentInfo] FOREIGN KEY([ProductPaymentID])
REFERENCES [dbo].[ProductPaymentInfo] ([ProductPaymentID])
GO
ALTER TABLE [dbo].[ProductPaymentTransaction] CHECK CONSTRAINT [FK_ProductPaymentTransaction_ProductPaymentInfo]
GO
/****** Object:  ForeignKey [fk_ProPayTranMediatorID]    Script Date: 08/10/2016 11:42:08 ******/
ALTER TABLE [dbo].[ProductPaymentTransaction]  WITH CHECK ADD  CONSTRAINT [fk_ProPayTranMediatorID] FOREIGN KEY([MediatorID])
REFERENCES [dbo].[MediatorInfo] ([MediatorID])
GO
ALTER TABLE [dbo].[ProductPaymentTransaction] CHECK CONSTRAINT [fk_ProPayTranMediatorID]
GO
/****** Object:  ForeignKey [fk_MediatorID]    Script Date: 08/10/2016 11:42:08 ******/
ALTER TABLE [dbo].[ProductSellingInfo]  WITH CHECK ADD  CONSTRAINT [fk_MediatorID] FOREIGN KEY([MediatorID])
REFERENCES [dbo].[MediatorInfo] ([MediatorID])
GO
ALTER TABLE [dbo].[ProductSellingInfo] CHECK CONSTRAINT [fk_MediatorID]
GO
/****** Object:  ForeignKey [FK_ProductSellingInfo_BuyerInfo]    Script Date: 08/10/2016 11:42:08 ******/
ALTER TABLE [dbo].[ProductSellingInfo]  WITH CHECK ADD  CONSTRAINT [FK_ProductSellingInfo_BuyerInfo] FOREIGN KEY([BuyerID])
REFERENCES [dbo].[BuyerInfo] ([BuyerID])
GO
ALTER TABLE [dbo].[ProductSellingInfo] CHECK CONSTRAINT [FK_ProductSellingInfo_BuyerInfo]
GO
/****** Object:  ForeignKey [FK_ProductSellingInfo_CustomerInfo]    Script Date: 08/10/2016 11:42:08 ******/
ALTER TABLE [dbo].[ProductSellingInfo]  WITH CHECK ADD  CONSTRAINT [FK_ProductSellingInfo_CustomerInfo] FOREIGN KEY([CustID])
REFERENCES [dbo].[CustomerInfo] ([CustID])
GO
ALTER TABLE [dbo].[ProductSellingInfo] CHECK CONSTRAINT [FK_ProductSellingInfo_CustomerInfo]
GO
/****** Object:  ForeignKey [FK_ProductSellingInfo_MBrokenRiceType]    Script Date: 08/10/2016 11:42:08 ******/
ALTER TABLE [dbo].[ProductSellingInfo]  WITH CHECK ADD  CONSTRAINT [FK_ProductSellingInfo_MBrokenRiceType] FOREIGN KEY([BrokenRiceTypeID])
REFERENCES [dbo].[MBrokenRiceType] ([BrokenRiceTypeID])
GO
ALTER TABLE [dbo].[ProductSellingInfo] CHECK CONSTRAINT [FK_ProductSellingInfo_MBrokenRiceType]
GO
/****** Object:  ForeignKey [FK_ProductSellingInfo_MRiceBrandDetails]    Script Date: 08/10/2016 11:42:08 ******/
ALTER TABLE [dbo].[ProductSellingInfo]  WITH CHECK ADD  CONSTRAINT [FK_ProductSellingInfo_MRiceBrandDetails] FOREIGN KEY([MRiceBrandID])
REFERENCES [dbo].[MRiceBrandDetails] ([MRiceBrandID])
GO
ALTER TABLE [dbo].[ProductSellingInfo] CHECK CONSTRAINT [FK_ProductSellingInfo_MRiceBrandDetails]
GO
/****** Object:  ForeignKey [FK_ProductSellingInfo_MRiceProductionType]    Script Date: 08/10/2016 11:42:08 ******/
ALTER TABLE [dbo].[ProductSellingInfo]  WITH CHECK ADD  CONSTRAINT [FK_ProductSellingInfo_MRiceProductionType] FOREIGN KEY([MRiceProdTypeID])
REFERENCES [dbo].[MRiceProductionType] ([MRiceProdTypeID])
GO
ALTER TABLE [dbo].[ProductSellingInfo] CHECK CONSTRAINT [FK_ProductSellingInfo_MRiceProductionType]
GO
/****** Object:  ForeignKey [FK_ProductSellingInfo_MUnitsType]    Script Date: 08/10/2016 11:42:08 ******/
ALTER TABLE [dbo].[ProductSellingInfo]  WITH CHECK ADD  CONSTRAINT [FK_ProductSellingInfo_MUnitsType] FOREIGN KEY([UnitsTypeID])
REFERENCES [dbo].[MUnitsType] ([UnitsTypeID])
GO
ALTER TABLE [dbo].[ProductSellingInfo] CHECK CONSTRAINT [FK_ProductSellingInfo_MUnitsType]
GO
/****** Object:  ForeignKey [FK_ProductSellingInfo_ProductPaymentInfo]    Script Date: 08/10/2016 11:42:08 ******/
ALTER TABLE [dbo].[ProductSellingInfo]  WITH CHECK ADD  CONSTRAINT [FK_ProductSellingInfo_ProductPaymentInfo] FOREIGN KEY([ProductPaymentID])
REFERENCES [dbo].[ProductPaymentInfo] ([ProductPaymentID])
GO
ALTER TABLE [dbo].[ProductSellingInfo] CHECK CONSTRAINT [FK_ProductSellingInfo_ProductPaymentInfo]
GO
/****** Object:  ForeignKey [FK_HullingProcess_CustomerInfo]    Script Date: 08/10/2016 11:42:08 ******/
ALTER TABLE [dbo].[HullingProcess]  WITH CHECK ADD  CONSTRAINT [FK_HullingProcess_CustomerInfo] FOREIGN KEY([CustID])
REFERENCES [dbo].[CustomerInfo] ([CustID])
GO
ALTER TABLE [dbo].[HullingProcess] CHECK CONSTRAINT [FK_HullingProcess_CustomerInfo]
GO
/****** Object:  ForeignKey [FK_HullingProcess_MPaddyType]    Script Date: 08/10/2016 11:42:08 ******/
ALTER TABLE [dbo].[HullingProcess]  WITH CHECK ADD  CONSTRAINT [FK_HullingProcess_MPaddyType] FOREIGN KEY([PaddyTypeID])
REFERENCES [dbo].[MPaddyType] ([PaddyTypeID])
GO
ALTER TABLE [dbo].[HullingProcess] CHECK CONSTRAINT [FK_HullingProcess_MPaddyType]
GO
/****** Object:  ForeignKey [FK_HullingProcess_MUnitsType]    Script Date: 08/10/2016 11:42:08 ******/
ALTER TABLE [dbo].[HullingProcess]  WITH CHECK ADD  CONSTRAINT [FK_HullingProcess_MUnitsType] FOREIGN KEY([UnitsTypeID])
REFERENCES [dbo].[MUnitsType] ([UnitsTypeID])
GO
ALTER TABLE [dbo].[HullingProcess] CHECK CONSTRAINT [FK_HullingProcess_MUnitsType]
GO
/****** Object:  ForeignKey [fk_MGodownID]    Script Date: 08/10/2016 11:42:08 ******/
ALTER TABLE [dbo].[HullingProcess]  WITH CHECK ADD  CONSTRAINT [fk_MGodownID] FOREIGN KEY([MGodownID])
REFERENCES [dbo].[MGodownDetails] ([MGodownID])
GO
ALTER TABLE [dbo].[HullingProcess] CHECK CONSTRAINT [fk_MGodownID]
GO
/****** Object:  ForeignKey [fk_MLotID]    Script Date: 08/10/2016 11:42:08 ******/
ALTER TABLE [dbo].[HullingProcess]  WITH CHECK ADD  CONSTRAINT [fk_MLotID] FOREIGN KEY([MLotID])
REFERENCES [dbo].[MLotDetails] ([MLotID])
GO
ALTER TABLE [dbo].[HullingProcess] CHECK CONSTRAINT [fk_MLotID]
GO
/****** Object:  ForeignKey [fk_CustID]    Script Date: 08/10/2016 11:42:08 ******/
ALTER TABLE [dbo].[HullingProcessExpenses]  WITH CHECK ADD  CONSTRAINT [fk_CustID] FOREIGN KEY([CustID])
REFERENCES [dbo].[CustomerInfo] ([CustID])
GO
ALTER TABLE [dbo].[HullingProcessExpenses] CHECK CONSTRAINT [fk_CustID]
GO
/****** Object:  ForeignKey [FK_HullingProcessExpenses_HullingProcess]    Script Date: 08/10/2016 11:42:08 ******/
ALTER TABLE [dbo].[HullingProcessExpenses]  WITH CHECK ADD  CONSTRAINT [FK_HullingProcessExpenses_HullingProcess] FOREIGN KEY([HullingProcessID])
REFERENCES [dbo].[HullingProcess] ([HullingProcessID])
GO
ALTER TABLE [dbo].[HullingProcessExpenses] CHECK CONSTRAINT [FK_HullingProcessExpenses_HullingProcess]
GO
/****** Object:  ForeignKey [FK_HullingTransaction_CustomerInfo]    Script Date: 08/10/2016 11:42:08 ******/
ALTER TABLE [dbo].[HullingTransaction]  WITH CHECK ADD  CONSTRAINT [FK_HullingTransaction_CustomerInfo] FOREIGN KEY([CustID])
REFERENCES [dbo].[CustomerInfo] ([CustID])
GO
ALTER TABLE [dbo].[HullingTransaction] CHECK CONSTRAINT [FK_HullingTransaction_CustomerInfo]
GO
/****** Object:  ForeignKey [FK_HullingTransaction_HullingProcess]    Script Date: 08/10/2016 11:42:08 ******/
ALTER TABLE [dbo].[HullingTransaction]  WITH CHECK ADD  CONSTRAINT [FK_HullingTransaction_HullingProcess] FOREIGN KEY([HullingProcessID])
REFERENCES [dbo].[HullingProcess] ([HullingProcessID])
GO
ALTER TABLE [dbo].[HullingTransaction] CHECK CONSTRAINT [FK_HullingTransaction_HullingProcess]
GO
/****** Object:  ForeignKey [FK_HullingTransaction_MBrokenRiceType]    Script Date: 08/10/2016 11:42:08 ******/
ALTER TABLE [dbo].[HullingTransaction]  WITH CHECK ADD  CONSTRAINT [FK_HullingTransaction_MBrokenRiceType] FOREIGN KEY([BrokenRiceTypeID])
REFERENCES [dbo].[MBrokenRiceType] ([BrokenRiceTypeID])
GO
ALTER TABLE [dbo].[HullingTransaction] CHECK CONSTRAINT [FK_HullingTransaction_MBrokenRiceType]
GO
/****** Object:  ForeignKey [FK_HullingTransaction_MRiceProductionType]    Script Date: 08/10/2016 11:42:08 ******/
ALTER TABLE [dbo].[HullingTransaction]  WITH CHECK ADD  CONSTRAINT [FK_HullingTransaction_MRiceProductionType] FOREIGN KEY([MRiceProdTypeID])
REFERENCES [dbo].[MRiceProductionType] ([MRiceProdTypeID])
GO
ALTER TABLE [dbo].[HullingTransaction] CHECK CONSTRAINT [FK_HullingTransaction_MRiceProductionType]
GO
/****** Object:  ForeignKey [FK_HullingTransaction_MUnitsType]    Script Date: 08/10/2016 11:42:08 ******/
ALTER TABLE [dbo].[HullingTransaction]  WITH CHECK ADD  CONSTRAINT [FK_HullingTransaction_MUnitsType] FOREIGN KEY([UnitsTypeID])
REFERENCES [dbo].[MUnitsType] ([UnitsTypeID])
GO
ALTER TABLE [dbo].[HullingTransaction] CHECK CONSTRAINT [FK_HullingTransaction_MUnitsType]
GO
/****** Object:  ForeignKey [fk_MRiceBrandID]    Script Date: 08/10/2016 11:42:08 ******/
ALTER TABLE [dbo].[HullingTransaction]  WITH CHECK ADD  CONSTRAINT [fk_MRiceBrandID] FOREIGN KEY([MRiceBrandID])
REFERENCES [dbo].[MRiceBrandDetails] ([MRiceBrandID])
GO
ALTER TABLE [dbo].[HullingTransaction] CHECK CONSTRAINT [fk_MRiceBrandID]
GO
/****** Object:  ForeignKey [FK_PaddyPaymentDetails_CustomerInfo]    Script Date: 08/10/2016 11:42:08 ******/
ALTER TABLE [dbo].[PaddyPaymentDetails]  WITH CHECK ADD  CONSTRAINT [FK_PaddyPaymentDetails_CustomerInfo] FOREIGN KEY([CustID])
REFERENCES [dbo].[CustomerInfo] ([CustID])
GO
ALTER TABLE [dbo].[PaddyPaymentDetails] CHECK CONSTRAINT [FK_PaddyPaymentDetails_CustomerInfo]
GO
/****** Object:  ForeignKey [FK_PaddyPaymentDetails_SellerInfo]    Script Date: 08/10/2016 11:42:08 ******/
ALTER TABLE [dbo].[PaddyPaymentDetails]  WITH CHECK ADD  CONSTRAINT [FK_PaddyPaymentDetails_SellerInfo] FOREIGN KEY([SellerID])
REFERENCES [dbo].[SellerInfo] ([SellerID])
GO
ALTER TABLE [dbo].[PaddyPaymentDetails] CHECK CONSTRAINT [FK_PaddyPaymentDetails_SellerInfo]
GO
/****** Object:  ForeignKey [fk_PaddyStockID]    Script Date: 08/10/2016 11:42:08 ******/
ALTER TABLE [dbo].[PaddyPaymentDetails]  WITH CHECK ADD  CONSTRAINT [fk_PaddyStockID] FOREIGN KEY([PaddyStockID])
REFERENCES [dbo].[PaddyStockInfo] ([PaddyStockID])
GO
ALTER TABLE [dbo].[PaddyPaymentDetails] CHECK CONSTRAINT [fk_PaddyStockID]
GO
