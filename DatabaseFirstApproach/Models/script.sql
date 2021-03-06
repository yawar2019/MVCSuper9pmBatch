USE [master]
GO
/****** Object:  Database [AmithDb]    Script Date: 02/03/2021 22:10:11 ******/
CREATE DATABASE [AmithDb]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'AmithDb', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\AmithDb.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'AmithDb_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\AmithDb_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [AmithDb] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [AmithDb].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [AmithDb] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [AmithDb] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [AmithDb] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [AmithDb] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [AmithDb] SET ARITHABORT OFF 
GO
ALTER DATABASE [AmithDb] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [AmithDb] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [AmithDb] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [AmithDb] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [AmithDb] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [AmithDb] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [AmithDb] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [AmithDb] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [AmithDb] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [AmithDb] SET  DISABLE_BROKER 
GO
ALTER DATABASE [AmithDb] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [AmithDb] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [AmithDb] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [AmithDb] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [AmithDb] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [AmithDb] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [AmithDb] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [AmithDb] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [AmithDb] SET  MULTI_USER 
GO
ALTER DATABASE [AmithDb] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [AmithDb] SET DB_CHAINING OFF 
GO
ALTER DATABASE [AmithDb] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [AmithDb] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [AmithDb] SET DELAYED_DURABILITY = DISABLED 
GO
USE [AmithDb]
GO
/****** Object:  Table [dbo].[Country]    Script Date: 02/03/2021 22:10:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Country](
	[Id] [int] NOT NULL,
	[Name] [nvarchar](50) NULL,
 CONSTRAINT [PK_Country] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Department]    Script Date: 02/03/2021 22:10:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Department](
	[DeptId] [int] IDENTITY(1,1) NOT NULL,
	[DeptName] [varchar](50) NULL,
 CONSTRAINT [PK_Department] PRIMARY KEY CLUSTERED 
(
	[DeptId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 02/03/2021 22:10:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Employee](
	[EmpId] [int] IDENTITY(1,1) NOT NULL,
	[EmpName] [varchar](50) NULL,
	[EmpSalary] [int] NULL,
	[Designation] [varchar](50) NULL,
	[DeptId] [int] NULL,
 CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED 
(
	[EmpId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Staffs]    Script Date: 02/03/2021 22:10:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Staffs](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[StaffName] [nvarchar](max) NOT NULL,
	[Description] [nvarchar](max) NOT NULL,
	[Department] [varchar](50) NULL,
 CONSTRAINT [PK_Staffs] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Country] ([Id], [Name]) VALUES (1, N'India')
INSERT [dbo].[Country] ([Id], [Name]) VALUES (2, N'Japan')
INSERT [dbo].[Country] ([Id], [Name]) VALUES (3, N'Bangladesh')
INSERT [dbo].[Country] ([Id], [Name]) VALUES (4, N'China')
SET IDENTITY_INSERT [dbo].[Department] ON 

INSERT [dbo].[Department] ([DeptId], [DeptName]) VALUES (1, N'IT')
INSERT [dbo].[Department] ([DeptId], [DeptName]) VALUES (2, N'Accounts')
SET IDENTITY_INSERT [dbo].[Department] OFF
SET IDENTITY_INSERT [dbo].[Employee] ON 

INSERT [dbo].[Employee] ([EmpId], [EmpName], [EmpSalary], [Designation], [DeptId]) VALUES (1, N'Raveeja', 73838, N'account', 1)
INSERT [dbo].[Employee] ([EmpId], [EmpName], [EmpSalary], [Designation], [DeptId]) VALUES (2, N'Vinod', 83843, N'nw', 2)
INSERT [dbo].[Employee] ([EmpId], [EmpName], [EmpSalary], [Designation], [DeptId]) VALUES (3, N'Amith', 78999, N'ac', 2)
INSERT [dbo].[Employee] ([EmpId], [EmpName], [EmpSalary], [Designation], [DeptId]) VALUES (4, N'Sai', 72320, N'it', NULL)
SET IDENTITY_INSERT [dbo].[Employee] OFF
/****** Object:  StoredProcedure [dbo].[sp_DeleteEmployee]    Script Date: 02/03/2021 22:10:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_DeleteEmployee]
@EmpId int
 
As
BEGIN
Delete from Employee  where EmpId=@EmpId
END
GO
/****** Object:  StoredProcedure [dbo].[sp_getEmployee]    Script Date: 02/03/2021 22:10:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_getEmployee]
As
BEGIN
SELECT * FROM Employee
END
GO
/****** Object:  StoredProcedure [dbo].[sp_getEmployee_id]    Script Date: 02/03/2021 22:10:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_getEmployee_id]
@EmpId int
As
BEGIN
SELECT * FROM Employee where EmpId=@EmpId
END
GO
/****** Object:  StoredProcedure [dbo].[sp_insertEmployee]    Script Date: 02/03/2021 22:10:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[sp_insertEmployee]
@EmpName varchar(50),
@EmpSalary int
As
BEGIN
Insert into Employee(EmpName,EmpSalary) values(@EmpName,@EmpSalary)
END
GO
/****** Object:  StoredProcedure [dbo].[sp_updateEmployee]    Script Date: 02/03/2021 22:10:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_updateEmployee]
@EmpId int,
@EmpName varchar(60),
@EmpSalary int
As
BEGIN
Update Employee set EmpName=@EmpName,EmpSalary=@EmpSalary where EmpId=@EmpId
END
GO
USE [master]
GO
ALTER DATABASE [AmithDb] SET  READ_WRITE 
GO
