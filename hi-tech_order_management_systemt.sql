USE [master]
GO
/****** Object:  Database [Hi-Tech_Order_Management_System]    Script Date: 2019-11-14 4:48:19 PM ******/
CREATE DATABASE [Hi-Tech_Order_Management_System]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Hi-Tech_Order_Management_System', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\Hi-Tech_Order_Management_System.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Hi-Tech_Order_Management_System_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\Hi-Tech_Order_Management_System_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [Hi-Tech_Order_Management_System] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Hi-Tech_Order_Management_System].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Hi-Tech_Order_Management_System] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Hi-Tech_Order_Management_System] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Hi-Tech_Order_Management_System] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Hi-Tech_Order_Management_System] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Hi-Tech_Order_Management_System] SET ARITHABORT OFF 
GO
ALTER DATABASE [Hi-Tech_Order_Management_System] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Hi-Tech_Order_Management_System] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Hi-Tech_Order_Management_System] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Hi-Tech_Order_Management_System] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Hi-Tech_Order_Management_System] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Hi-Tech_Order_Management_System] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Hi-Tech_Order_Management_System] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Hi-Tech_Order_Management_System] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Hi-Tech_Order_Management_System] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Hi-Tech_Order_Management_System] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Hi-Tech_Order_Management_System] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Hi-Tech_Order_Management_System] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Hi-Tech_Order_Management_System] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Hi-Tech_Order_Management_System] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Hi-Tech_Order_Management_System] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Hi-Tech_Order_Management_System] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Hi-Tech_Order_Management_System] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Hi-Tech_Order_Management_System] SET RECOVERY FULL 
GO
ALTER DATABASE [Hi-Tech_Order_Management_System] SET  MULTI_USER 
GO
ALTER DATABASE [Hi-Tech_Order_Management_System] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Hi-Tech_Order_Management_System] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Hi-Tech_Order_Management_System] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Hi-Tech_Order_Management_System] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Hi-Tech_Order_Management_System] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'Hi-Tech_Order_Management_System', N'ON'
GO
ALTER DATABASE [Hi-Tech_Order_Management_System] SET QUERY_STORE = OFF
GO
USE [Hi-Tech_Order_Management_System]
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 2019-11-14 4:48:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee](
	[EmployeeId] [int] NOT NULL,
	[FirstName] [varchar](50) NOT NULL,
	[LastName] [varchar](50) NOT NULL,
	[JobTitle] [varchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Login]    Script Date: 2019-11-14 4:48:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Login](
	[username] [nchar](30) NULL,
	[password] [nchar](10) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 2019-11-14 4:48:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[UserId] [int] NOT NULL,
	[FirstName] [varchar](50) NOT NULL,
	[LastName] [varchar](50) NOT NULL,
	[JobTitle] [varchar](50) NOT NULL
) ON [PRIMARY]
GO
INSERT [dbo].[Employee] ([EmployeeId], [FirstName], [LastName], [JobTitle]) VALUES (1003, N'Davinder', N'Sharma', N'Designer')
INSERT [dbo].[Employee] ([EmployeeId], [FirstName], [LastName], [JobTitle]) VALUES (1001, N'Gavanpreet', N'Kaur', N'Manager')
INSERT [dbo].[Employee] ([EmployeeId], [FirstName], [LastName], [JobTitle]) VALUES (1005, N'Davinder', N'Sharma', N'developer')
INSERT [dbo].[Employee] ([EmployeeId], [FirstName], [LastName], [JobTitle]) VALUES (1006, N'Mandeep', N'Kaur', N'Developer')
INSERT [dbo].[Employee] ([EmployeeId], [FirstName], [LastName], [JobTitle]) VALUES (1000, N'Kanwarpal', N'Singh', N'Manager')
INSERT [dbo].[Employee] ([EmployeeId], [FirstName], [LastName], [JobTitle]) VALUES (1004, N'Mehak', N'Gill', N'Manager')
INSERT [dbo].[Login] ([username], [password]) VALUES (N'Henry Brown                   ', N'1234      ')
INSERT [dbo].[User] ([UserId], [FirstName], [LastName], [JobTitle]) VALUES (2001, N'zigual', N'michel', N'developer')
INSERT [dbo].[User] ([UserId], [FirstName], [LastName], [JobTitle]) VALUES (2002, N'eric', N'gary', N'programmer')
INSERT [dbo].[User] ([UserId], [FirstName], [LastName], [JobTitle]) VALUES (2003, N'patrick', N'michel', N'programmer')
USE [master]
GO
ALTER DATABASE [Hi-Tech_Order_Management_System] SET  READ_WRITE 
GO
