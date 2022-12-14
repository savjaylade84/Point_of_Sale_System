USE [master]
GO
/****** Object:  Database [dbStudentAttendanceManagementSystem]    Script Date: 05/12/2019 10:57:26 AM ******/
CREATE DATABASE [dbStudentAttendanceManagementSystem]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'dbStudentAttendanceManagementSystem', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\dbStudentAttendanceManagementSystem.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'dbStudentAttendanceManagementSystem_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\dbStudentAttendanceManagementSystem_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [dbStudentAttendanceManagementSystem] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [dbStudentAttendanceManagementSystem].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [dbStudentAttendanceManagementSystem] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [dbStudentAttendanceManagementSystem] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [dbStudentAttendanceManagementSystem] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [dbStudentAttendanceManagementSystem] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [dbStudentAttendanceManagementSystem] SET ARITHABORT OFF 
GO
ALTER DATABASE [dbStudentAttendanceManagementSystem] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [dbStudentAttendanceManagementSystem] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [dbStudentAttendanceManagementSystem] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [dbStudentAttendanceManagementSystem] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [dbStudentAttendanceManagementSystem] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [dbStudentAttendanceManagementSystem] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [dbStudentAttendanceManagementSystem] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [dbStudentAttendanceManagementSystem] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [dbStudentAttendanceManagementSystem] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [dbStudentAttendanceManagementSystem] SET  ENABLE_BROKER 
GO
ALTER DATABASE [dbStudentAttendanceManagementSystem] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [dbStudentAttendanceManagementSystem] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [dbStudentAttendanceManagementSystem] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [dbStudentAttendanceManagementSystem] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [dbStudentAttendanceManagementSystem] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [dbStudentAttendanceManagementSystem] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [dbStudentAttendanceManagementSystem] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [dbStudentAttendanceManagementSystem] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [dbStudentAttendanceManagementSystem] SET  MULTI_USER 
GO
ALTER DATABASE [dbStudentAttendanceManagementSystem] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [dbStudentAttendanceManagementSystem] SET DB_CHAINING OFF 
GO
ALTER DATABASE [dbStudentAttendanceManagementSystem] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [dbStudentAttendanceManagementSystem] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [dbStudentAttendanceManagementSystem] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [dbStudentAttendanceManagementSystem] SET QUERY_STORE = OFF
GO
USE [dbStudentAttendanceManagementSystem]
GO
/****** Object:  Table [dbo].[tblUserAccount]    Script Date: 05/12/2019 10:57:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblUserAccount](
	[userid] [numeric](18, 0) NOT NULL,
	[username] [varchar](100) NOT NULL,
	[password] [varchar](100) NOT NULL,
	[firstname] [varchar](100) NOT NULL,
	[lastname] [varchar](100) NOT NULL,
	[email] [varchar](200) NOT NULL,
	[contact] [varchar](20) NOT NULL,
 CONSTRAINT [userAccount_PK] PRIMARY KEY CLUSTERED 
(
	[userid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[addAccount]    Script Date: 05/12/2019 10:57:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[addAccount](
@uid AS NUMERIC,
@uname AS VARCHAR(100),
@pword AS VARCHAR(100),
@fname AS VARCHAR(100),
@lname AS VARCHAR(100),
@email AS VARCHAR(200),
@contact AS VARCHAR(20) )
AS

	INSERT INTO tblUserAccount VALUES(@uid,@uname,@pword,@fname,@lname,@email,@contact)	

GO
/****** Object:  StoredProcedure [dbo].[selectAccount]    Script Date: 05/12/2019 10:57:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[selectAccount]
AS
SELECT * FROM tblUserAccount
GO
USE [master]
GO
ALTER DATABASE [dbStudentAttendanceManagementSystem] SET  READ_WRITE 
GO
