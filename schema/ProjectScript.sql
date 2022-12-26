USE [master]
GO
/****** Object:  Database [PROJECT]    Script Date: 12/26/2022 1:38:09 AM ******/
CREATE DATABASE [PROJECT]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'PROJECT', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\PROJECT.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'PROJECT_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\PROJECT_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [PROJECT] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [PROJECT].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [PROJECT] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [PROJECT] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [PROJECT] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [PROJECT] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [PROJECT] SET ARITHABORT OFF 
GO
ALTER DATABASE [PROJECT] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [PROJECT] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [PROJECT] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [PROJECT] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [PROJECT] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [PROJECT] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [PROJECT] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [PROJECT] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [PROJECT] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [PROJECT] SET  DISABLE_BROKER 
GO
ALTER DATABASE [PROJECT] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [PROJECT] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [PROJECT] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [PROJECT] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [PROJECT] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [PROJECT] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [PROJECT] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [PROJECT] SET RECOVERY FULL 
GO
ALTER DATABASE [PROJECT] SET  MULTI_USER 
GO
ALTER DATABASE [PROJECT] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [PROJECT] SET DB_CHAINING OFF 
GO
ALTER DATABASE [PROJECT] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [PROJECT] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [PROJECT] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [PROJECT] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'PROJECT', N'ON'
GO
ALTER DATABASE [PROJECT] SET QUERY_STORE = OFF
GO
USE [PROJECT]
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 12/26/2022 1:38:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee](
	[EmployeeSSN] [int] NOT NULL,
	[EmployeeUsrName] [varchar](50) NULL,
	[EmployeePass] [varchar](50) NULL,
	[EmployeeFname] [varchar](50) NOT NULL,
	[EmployeeMini] [varchar](50) NOT NULL,
	[EmployeeLname] [varchar](50) NOT NULL,
	[EmployeeAge] [int] NOT NULL,
	[EmployeeGender] [varchar](1) NOT NULL,
	[EmployeeAddress] [varchar](100) NULL,
	[EmployeePhone] [varchar](50) NULL,
	[EmployeeSalary] [float] NOT NULL,
	[MaritalStat] [varchar](50) NULL,
 CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED 
(
	[EmployeeSSN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Expense]    Script Date: 12/26/2022 1:38:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Expense](
	[ExpenseID] [int] NOT NULL,
	[ExpensePrice] [float] NOT NULL,
	[ExpenseDate] [date] NOT NULL,
	[ExpenseDescription] [varchar](50) NULL,
	[ManagerSSn] [int] NOT NULL,
 CONSTRAINT [PK_Expense_1] PRIMARY KEY CLUSTERED 
(
	[ExpenseID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FeedBack]    Script Date: 12/26/2022 1:38:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FeedBack](
	[GuestID] [int] NOT NULL,
	[FType] [varchar](500) NOT NULL,
	[Date] [date] NOT NULL,
	[comment] [varchar](8000) NULL,
 CONSTRAINT [PK_FeedBack_1] PRIMARY KEY CLUSTERED 
(
	[GuestID] ASC,
	[FType] ASC,
	[Date] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Guest]    Script Date: 12/26/2022 1:38:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Guest](
	[GuestId] [int] NOT NULL,
	[GuestFname] [varchar](50) NOT NULL,
	[GuestMini] [varchar](50) NOT NULL,
	[GuestLname] [varchar](50) NOT NULL,
	[GuestGender] [varchar](1) NOT NULL,
	[GuestDependantPhone] [varchar](50) NULL,
 CONSTRAINT [PK_Guest] PRIMARY KEY CLUSTERED 
(
	[GuestId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GuestAccount]    Script Date: 12/26/2022 1:38:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GuestAccount](
	[UsrName] [varchar](50) NOT NULL,
	[password] [varchar](50) NOT NULL,
	[GuestID] [int] NOT NULL,
 CONSTRAINT [PK_GuestAccount] PRIMARY KEY CLUSTERED 
(
	[UsrName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GuestPhoneNum]    Script Date: 12/26/2022 1:38:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GuestPhoneNum](
	[GuestId] [int] NOT NULL,
	[GuestPhoneNumber] [varchar](50) NOT NULL,
 CONSTRAINT [PK_GuestPhoneNum] PRIMARY KEY CLUSTERED 
(
	[GuestId] ASC,
	[GuestPhoneNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HotelProgram]    Script Date: 12/26/2022 1:38:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HotelProgram](
	[ProgramId] [int] NOT NULL,
	[ProgramDescription] [varchar](1000) NOT NULL,
	[ProgramCapacity] [int] NOT NULL,
	[ProgramType] [varchar](50) NULL,
	[ProgramLocation] [varchar](50) NOT NULL,
	[ProgramStartTime] [date] NOT NULL,
	[ProgramEndTime] [date] NOT NULL,
	[ProgramFees] [float] NULL,
	[ManagerSSN] [int] NOT NULL,
 CONSTRAINT [PK_HotelProgram] PRIMARY KEY CLUSTERED 
(
	[ProgramId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[JoinProgram]    Script Date: 12/26/2022 1:38:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[JoinProgram](
	[ProgramID] [int] NOT NULL,
	[GuestID] [int] NOT NULL,
	[Date] [date] NOT NULL,
 CONSTRAINT [PK_Join] PRIMARY KEY CLUSTERED 
(
	[ProgramID] ASC,
	[GuestID] ASC,
	[Date] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Manager]    Script Date: 12/26/2022 1:38:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Manager](
	[ManagerSSN] [int] NOT NULL,
	[StartDate] [date] NOT NULL,
 CONSTRAINT [PK_Manager] PRIMARY KEY CLUSTERED 
(
	[ManagerSSN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Payments]    Script Date: 12/26/2022 1:38:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Payments](
	[GuestID] [int] NOT NULL,
	[ReceptionistID] [int] NOT NULL,
	[Date] [date] NOT NULL,
	[Discount] [float] NOT NULL,
	[PaymentDecription] [varchar](50) NOT NULL,
	[Price] [float] NOT NULL,
 CONSTRAINT [PK_Payments] PRIMARY KEY CLUSTERED 
(
	[GuestID] ASC,
	[ReceptionistID] ASC,
	[Date] ASC,
	[PaymentDecription] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Receptionist]    Script Date: 12/26/2022 1:38:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Receptionist](
	[ReceptionistSSN] [int] NOT NULL,
	[BonusPoint] [int] NOT NULL,
	[ManagerSSN] [int] NOT NULL,
 CONSTRAINT [PK_Receptionist] PRIMARY KEY CLUSTERED 
(
	[ReceptionistSSN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Request]    Script Date: 12/26/2022 1:38:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Request](
	[GuestID] [int] NOT NULL,
	[ServiceID] [int] NOT NULL,
	[Amount] [float] NOT NULL,
	[Date] [date] NOT NULL,
 CONSTRAINT [PK_Request] PRIMARY KEY CLUSTERED 
(
	[GuestID] ASC,
	[ServiceID] ASC,
	[Amount] ASC,
	[Date] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Retrieve]    Script Date: 12/26/2022 1:38:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Retrieve](
	[Mssn] [int] NOT NULL,
	[ExpenseID] [int] NOT NULL,
 CONSTRAINT [PK_Retrieve] PRIMARY KEY CLUSTERED 
(
	[Mssn] ASC,
	[ExpenseID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Room]    Script Date: 12/26/2022 1:38:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Room](
	[RoomID] [int] NOT NULL,
	[RoomType] [varchar](50) NOT NULL,
	[RoomResevationStatus] [varchar](1) NOT NULL,
	[RoomCapacity] [int] NOT NULL,
	[RoomPrice] [float] NOT NULL,
	[GuestID] [int] NULL,
	[ReceptionistID] [int] NULL,
	[CheckIn] [date] NULL,
	[CheckOut] [date] NULL,
 CONSTRAINT [PK_Room] PRIMARY KEY CLUSTERED 
(
	[RoomID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Service]    Script Date: 12/26/2022 1:38:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Service](
	[ServiceID] [int] NOT NULL,
	[ServiceType] [varchar](100) NOT NULL,
	[ServiceAmount] [int] NOT NULL,
	[ServicePrice] [float] NULL,
	[ManagerSSN] [int] NOT NULL,
 CONSTRAINT [PK_Service] PRIMARY KEY CLUSTERED 
(
	[ServiceID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Employee] ([EmployeeSSN], [EmployeeUsrName], [EmployeePass], [EmployeeFname], [EmployeeMini], [EmployeeLname], [EmployeeAge], [EmployeeGender], [EmployeeAddress], [EmployeePhone], [EmployeeSalary], [MaritalStat]) VALUES (1, N'ADN2192', N'123', N'Abdulrahman', N'Ibrahim', N'Mohamed', 21, N'M', N'Giza', N'0012999128', 11000, N'Single')
GO
INSERT [dbo].[Employee] ([EmployeeSSN], [EmployeeUsrName], [EmployeePass], [EmployeeFname], [EmployeeMini], [EmployeeLname], [EmployeeAge], [EmployeeGender], [EmployeeAddress], [EmployeePhone], [EmployeeSalary], [MaritalStat]) VALUES (4, N'Rec281', N'2938', N'karim', N'yasser', N'ali', 21, N'M', N'Maadi', N'9218812919', 1000, N'Single')
GO
INSERT [dbo].[Employee] ([EmployeeSSN], [EmployeeUsrName], [EmployeePass], [EmployeeFname], [EmployeeMini], [EmployeeLname], [EmployeeAge], [EmployeeGender], [EmployeeAddress], [EmployeePhone], [EmployeeSalary], [MaritalStat]) VALUES (5, N'MGR591', N'2091', N'Karim', N'Ali', N'hashish', 21, N'M', N'Haram', N'0129918821', 3000, N'Divorced')
GO
INSERT [dbo].[Employee] ([EmployeeSSN], [EmployeeUsrName], [EmployeePass], [EmployeeFname], [EmployeeMini], [EmployeeLname], [EmployeeAge], [EmployeeGender], [EmployeeAddress], [EmployeePhone], [EmployeeSalary], [MaritalStat]) VALUES (78, N'm', N'm', N'Farouk', N'farouk', N'Ali', 30, N'M', N'Haram', N'012358412', 1200, N'Divorced')
GO
INSERT [dbo].[Employee] ([EmployeeSSN], [EmployeeUsrName], [EmployeePass], [EmployeeFname], [EmployeeMini], [EmployeeLname], [EmployeeAge], [EmployeeGender], [EmployeeAddress], [EmployeePhone], [EmployeeSalary], [MaritalStat]) VALUES (80, N'MGR12344', N'123446', N'ola', N'kamel', N'hamada', 40, N'F', N'Giza', N'0129912382', 4000, N'Married')
GO
INSERT [dbo].[Expense] ([ExpenseID], [ExpensePrice], [ExpenseDate], [ExpenseDescription], [ManagerSSn]) VALUES (0, 0, CAST(N'2022-12-24' AS Date), N'', 5)
GO
INSERT [dbo].[Expense] ([ExpenseID], [ExpensePrice], [ExpenseDate], [ExpenseDescription], [ManagerSSn]) VALUES (1, 100, CAST(N'2022-12-22' AS Date), N'Tax', 5)
GO
INSERT [dbo].[Expense] ([ExpenseID], [ExpensePrice], [ExpenseDate], [ExpenseDescription], [ManagerSSn]) VALUES (2, 200, CAST(N'2022-12-22' AS Date), N'Electricity', 5)
GO
INSERT [dbo].[Expense] ([ExpenseID], [ExpensePrice], [ExpenseDate], [ExpenseDescription], [ManagerSSn]) VALUES (3, 300, CAST(N'2022-11-22' AS Date), N'Tax', 5)
GO
INSERT [dbo].[Expense] ([ExpenseID], [ExpensePrice], [ExpenseDate], [ExpenseDescription], [ManagerSSn]) VALUES (4, 300, CAST(N'2022-11-22' AS Date), N'Electricity', 5)
GO
INSERT [dbo].[Expense] ([ExpenseID], [ExpensePrice], [ExpenseDate], [ExpenseDescription], [ManagerSSn]) VALUES (5, 200.5, CAST(N'2022-11-22' AS Date), N'Tax', 5)
GO
INSERT [dbo].[Expense] ([ExpenseID], [ExpensePrice], [ExpenseDate], [ExpenseDescription], [ManagerSSn]) VALUES (6, 100, CAST(N'2022-12-22' AS Date), N'Gardening', 5)
GO
INSERT [dbo].[FeedBack] ([GuestID], [FType], [Date], [comment]) VALUES (121, N'Program provided', CAST(N'2022-12-24' AS Date), N'7AGA KEMA F EL 3AFANA')
GO
INSERT [dbo].[Guest] ([GuestId], [GuestFname], [GuestMini], [GuestLname], [GuestGender], [GuestDependantPhone]) VALUES (1, N'ahmed', N'mhmd', N'ahmed', N'M', N'01024125421')
GO
INSERT [dbo].[Guest] ([GuestId], [GuestFname], [GuestMini], [GuestLname], [GuestGender], [GuestDependantPhone]) VALUES (2, N'Mai', N'ahmed', N'hamed', N'F', N'01292823771')
GO
INSERT [dbo].[Guest] ([GuestId], [GuestFname], [GuestMini], [GuestLname], [GuestGender], [GuestDependantPhone]) VALUES (3, N'John', N'mark', N'gerges', N'M', N'01928237711')
GO
INSERT [dbo].[Guest] ([GuestId], [GuestFname], [GuestMini], [GuestLname], [GuestGender], [GuestDependantPhone]) VALUES (4, N'Kaly', N'michell', N'mark', N'F', N'01293882771')
GO
INSERT [dbo].[Guest] ([GuestId], [GuestFname], [GuestMini], [GuestLname], [GuestGender], [GuestDependantPhone]) VALUES (23, N'wdwd', N'dd', N'wd', N'M', N'1212121212')
GO
INSERT [dbo].[Guest] ([GuestId], [GuestFname], [GuestMini], [GuestLname], [GuestGender], [GuestDependantPhone]) VALUES (24, N'asasasas', N'asasas', N'qwqw', N'M', N'12121991')
GO
INSERT [dbo].[Guest] ([GuestId], [GuestFname], [GuestMini], [GuestLname], [GuestGender], [GuestDependantPhone]) VALUES (90, N'hoso', N'gamel', N'gdn', N'M', N'0129928812')
GO
INSERT [dbo].[Guest] ([GuestId], [GuestFname], [GuestMini], [GuestLname], [GuestGender], [GuestDependantPhone]) VALUES (121, N'sasas', N'asas', N'QASAS', N'M', N'299238')
GO
INSERT [dbo].[GuestAccount] ([UsrName], [password], [GuestID]) VALUES (N'guest123', N'1234', 1)
GO
INSERT [dbo].[GuestAccount] ([UsrName], [password], [GuestID]) VALUES (N'guest1234', N'2372', 121)
GO
INSERT [dbo].[HotelProgram] ([ProgramId], [ProgramDescription], [ProgramCapacity], [ProgramType], [ProgramLocation], [ProgramStartTime], [ProgramEndTime], [ProgramFees], [ManagerSSN]) VALUES (1, N'Elhamdulilah kolo tmm zy el fol', 1, N'fun', N'MAADI', CAST(N'2001-01-01' AS Date), CAST(N'2002-03-03' AS Date), 1, 5)
GO
INSERT [dbo].[HotelProgram] ([ProgramId], [ProgramDescription], [ProgramCapacity], [ProgramType], [ProgramLocation], [ProgramStartTime], [ProgramEndTime], [ProgramFees], [ManagerSSN]) VALUES (2, N'Have a wondefull time at the park', 100, N'Family', N'Maadi', CAST(N'2022-01-02' AS Date), CAST(N'2022-01-02' AS Date), 100, 5)
GO
INSERT [dbo].[HotelProgram] ([ProgramId], [ProgramDescription], [ProgramCapacity], [ProgramType], [ProgramLocation], [ProgramStartTime], [ProgramEndTime], [ProgramFees], [ManagerSSN]) VALUES (3, N'Yummy food', 99, N'Food', N'Tanta', CAST(N'2022-12-06' AS Date), CAST(N'2022-12-24' AS Date), 4, 5)
GO
INSERT [dbo].[JoinProgram] ([ProgramID], [GuestID], [Date]) VALUES (1, 23, CAST(N'2022-03-03' AS Date))
GO
INSERT [dbo].[JoinProgram] ([ProgramID], [GuestID], [Date]) VALUES (3, 1, CAST(N'2022-12-20' AS Date))
GO
INSERT [dbo].[Manager] ([ManagerSSN], [StartDate]) VALUES (5, CAST(N'2002-02-02' AS Date))
GO
INSERT [dbo].[Payments] ([GuestID], [ReceptionistID], [Date], [Discount], [PaymentDecription], [Price]) VALUES (1, 4, CAST(N'2022-12-22' AS Date), 0, N'Food', 300)
GO
INSERT [dbo].[Payments] ([GuestID], [ReceptionistID], [Date], [Discount], [PaymentDecription], [Price]) VALUES (1, 4, CAST(N'2022-12-22' AS Date), 0, N'Room', 200)
GO
INSERT [dbo].[Payments] ([GuestID], [ReceptionistID], [Date], [Discount], [PaymentDecription], [Price]) VALUES (2, 4, CAST(N'2022-11-22' AS Date), 100, N'Food', 500)
GO
INSERT [dbo].[Payments] ([GuestID], [ReceptionistID], [Date], [Discount], [PaymentDecription], [Price]) VALUES (2, 4, CAST(N'2022-11-22' AS Date), 20, N'Room', 400)
GO
INSERT [dbo].[Receptionist] ([ReceptionistSSN], [BonusPoint], [ManagerSSN]) VALUES (4, 100, 5)
GO
INSERT [dbo].[Request] ([GuestID], [ServiceID], [Amount], [Date]) VALUES (1, 12, 8, CAST(N'2022-12-29' AS Date))
GO
INSERT [dbo].[Request] ([GuestID], [ServiceID], [Amount], [Date]) VALUES (1, 1212, 700, CAST(N'2022-12-29' AS Date))
GO
INSERT [dbo].[Request] ([GuestID], [ServiceID], [Amount], [Date]) VALUES (23, 1, 3, CAST(N'2022-12-24' AS Date))
GO
INSERT [dbo].[Request] ([GuestID], [ServiceID], [Amount], [Date]) VALUES (23, 1, 3, CAST(N'2022-12-25' AS Date))
GO
INSERT [dbo].[Request] ([GuestID], [ServiceID], [Amount], [Date]) VALUES (23, 1, 4, CAST(N'2022-12-26' AS Date))
GO
INSERT [dbo].[Service] ([ServiceID], [ServiceType], [ServiceAmount], [ServicePrice], [ManagerSSN]) VALUES (0, N'', 0, 0, 5)
GO
INSERT [dbo].[Service] ([ServiceID], [ServiceType], [ServiceAmount], [ServicePrice], [ManagerSSN]) VALUES (1, N'Resturant', 5, 60, 5)
GO
INSERT [dbo].[Service] ([ServiceID], [ServiceType], [ServiceAmount], [ServicePrice], [ManagerSSN]) VALUES (12, N'Massage', 0, 600, 5)
GO
INSERT [dbo].[Service] ([ServiceID], [ServiceType], [ServiceAmount], [ServicePrice], [ManagerSSN]) VALUES (30, N'Room', 100000, 100, 5)
GO
INSERT [dbo].[Service] ([ServiceID], [ServiceType], [ServiceAmount], [ServicePrice], [ManagerSSN]) VALUES (90, N'HouseKeeping', 50, 100, 5)
GO
INSERT [dbo].[Service] ([ServiceID], [ServiceType], [ServiceAmount], [ServicePrice], [ManagerSSN]) VALUES (1212, N'HOSO', 0, 700, 5)
GO
INSERT [dbo].[Service] ([ServiceID], [ServiceType], [ServiceAmount], [ServicePrice], [ManagerSSN]) VALUES (12222, N'Fast Cleaning', 49, 80, 5)
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Employee]    Script Date: 12/26/2022 1:38:10 AM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_Employee] ON [dbo].[Employee]
(
	[EmployeeUsrName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_GuestPhoneNum]    Script Date: 12/26/2022 1:38:10 AM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_GuestPhoneNum] ON [dbo].[GuestPhoneNum]
(
	[GuestPhoneNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Expense]  WITH CHECK ADD  CONSTRAINT [FK_Expense_Manager] FOREIGN KEY([ManagerSSn])
REFERENCES [dbo].[Manager] ([ManagerSSN])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Expense] CHECK CONSTRAINT [FK_Expense_Manager]
GO
ALTER TABLE [dbo].[FeedBack]  WITH CHECK ADD  CONSTRAINT [FK_FeedBack_Guest] FOREIGN KEY([GuestID])
REFERENCES [dbo].[Guest] ([GuestId])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[FeedBack] CHECK CONSTRAINT [FK_FeedBack_Guest]
GO
ALTER TABLE [dbo].[GuestAccount]  WITH CHECK ADD  CONSTRAINT [FK_GuestAccount_Guest] FOREIGN KEY([GuestID])
REFERENCES [dbo].[Guest] ([GuestId])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[GuestAccount] CHECK CONSTRAINT [FK_GuestAccount_Guest]
GO
ALTER TABLE [dbo].[GuestPhoneNum]  WITH CHECK ADD  CONSTRAINT [FK_GuestPhoneNum_Guest] FOREIGN KEY([GuestId])
REFERENCES [dbo].[Guest] ([GuestId])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[GuestPhoneNum] CHECK CONSTRAINT [FK_GuestPhoneNum_Guest]
GO
ALTER TABLE [dbo].[HotelProgram]  WITH CHECK ADD  CONSTRAINT [FK_HotelProgram_Manager] FOREIGN KEY([ManagerSSN])
REFERENCES [dbo].[Manager] ([ManagerSSN])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[HotelProgram] CHECK CONSTRAINT [FK_HotelProgram_Manager]
GO
ALTER TABLE [dbo].[JoinProgram]  WITH CHECK ADD  CONSTRAINT [FK_Join_Guest] FOREIGN KEY([GuestID])
REFERENCES [dbo].[Guest] ([GuestId])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[JoinProgram] CHECK CONSTRAINT [FK_Join_Guest]
GO
ALTER TABLE [dbo].[JoinProgram]  WITH CHECK ADD  CONSTRAINT [FK_Join_HotelProgram] FOREIGN KEY([ProgramID])
REFERENCES [dbo].[HotelProgram] ([ProgramId])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[JoinProgram] CHECK CONSTRAINT [FK_Join_HotelProgram]
GO
ALTER TABLE [dbo].[Manager]  WITH CHECK ADD  CONSTRAINT [FK_Manager_Employee1] FOREIGN KEY([ManagerSSN])
REFERENCES [dbo].[Employee] ([EmployeeSSN])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Manager] CHECK CONSTRAINT [FK_Manager_Employee1]
GO
ALTER TABLE [dbo].[Payments]  WITH CHECK ADD  CONSTRAINT [FK_Payments_Guest] FOREIGN KEY([GuestID])
REFERENCES [dbo].[Guest] ([GuestId])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Payments] CHECK CONSTRAINT [FK_Payments_Guest]
GO
ALTER TABLE [dbo].[Payments]  WITH CHECK ADD  CONSTRAINT [FK_Payments_Receptionist] FOREIGN KEY([ReceptionistID])
REFERENCES [dbo].[Receptionist] ([ReceptionistSSN])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Payments] CHECK CONSTRAINT [FK_Payments_Receptionist]
GO
ALTER TABLE [dbo].[Receptionist]  WITH CHECK ADD  CONSTRAINT [FK_Receptionist_Employee1] FOREIGN KEY([ReceptionistSSN])
REFERENCES [dbo].[Employee] ([EmployeeSSN])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Receptionist] CHECK CONSTRAINT [FK_Receptionist_Employee1]
GO
ALTER TABLE [dbo].[Receptionist]  WITH CHECK ADD  CONSTRAINT [FK_Receptionist_Manager] FOREIGN KEY([ManagerSSN])
REFERENCES [dbo].[Manager] ([ManagerSSN])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Receptionist] CHECK CONSTRAINT [FK_Receptionist_Manager]
GO
ALTER TABLE [dbo].[Request]  WITH CHECK ADD  CONSTRAINT [FK_Request_Guest] FOREIGN KEY([GuestID])
REFERENCES [dbo].[Guest] ([GuestId])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Request] CHECK CONSTRAINT [FK_Request_Guest]
GO
ALTER TABLE [dbo].[Request]  WITH CHECK ADD  CONSTRAINT [FK_Request_Service] FOREIGN KEY([ServiceID])
REFERENCES [dbo].[Service] ([ServiceID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Request] CHECK CONSTRAINT [FK_Request_Service]
GO
ALTER TABLE [dbo].[Retrieve]  WITH CHECK ADD  CONSTRAINT [FK_Retrieve_Expense1] FOREIGN KEY([ExpenseID])
REFERENCES [dbo].[Expense] ([ExpenseID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Retrieve] CHECK CONSTRAINT [FK_Retrieve_Expense1]
GO
ALTER TABLE [dbo].[Retrieve]  WITH CHECK ADD  CONSTRAINT [FK_Retrieve_Manager] FOREIGN KEY([Mssn])
REFERENCES [dbo].[Manager] ([ManagerSSN])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Retrieve] CHECK CONSTRAINT [FK_Retrieve_Manager]
GO
ALTER TABLE [dbo].[Room]  WITH CHECK ADD  CONSTRAINT [FK_Room_Guest] FOREIGN KEY([GuestID])
REFERENCES [dbo].[Guest] ([GuestId])
ON UPDATE CASCADE
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[Room] CHECK CONSTRAINT [FK_Room_Guest]
GO
ALTER TABLE [dbo].[Room]  WITH CHECK ADD  CONSTRAINT [FK_Room_Receptionist] FOREIGN KEY([ReceptionistID])
REFERENCES [dbo].[Receptionist] ([ReceptionistSSN])
ON UPDATE CASCADE
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[Room] CHECK CONSTRAINT [FK_Room_Receptionist]
GO
ALTER TABLE [dbo].[Service]  WITH CHECK ADD  CONSTRAINT [FK_Service_Manager] FOREIGN KEY([ManagerSSN])
REFERENCES [dbo].[Manager] ([ManagerSSN])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Service] CHECK CONSTRAINT [FK_Service_Manager]
GO
/****** Object:  StoredProcedure [dbo].[getAllMgrs]    Script Date: 12/26/2022 1:38:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[getAllMgrs]
AS
BEGIN
SELECT *
From Manager
END
GO
/****** Object:  StoredProcedure [dbo].[PrID]    Script Date: 12/26/2022 1:38:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[PrID]
AS
BEGIN

SELECT ProgramId FROM HotelProgram where ProgramCapacity > 0

END
GO
/****** Object:  StoredProcedure [dbo].[ProcInsertService]    Script Date: 12/26/2022 1:38:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ProcInsertService]
	@id int,
	@type varchar(50),
	@capacity int,
	@fee float,
	@ssn int

AS
BEGIN

insert into Service values (@id, @type, @capacity, @fee, @ssn)

END
GO
/****** Object:  StoredProcedure [dbo].[ProcJoinP]    Script Date: 12/26/2022 1:38:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ProcJoinP]
	@Pid int,
	@Gid int,
	@Date date

AS
BEGIN

INSERT INTO JoinProgram Values (@Pid,@Gid,@Date)

END
GO
/****** Object:  StoredProcedure [dbo].[ProcSelectEmployessWithNoLogin]    Script Date: 12/26/2022 1:38:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ProcSelectEmployessWithNoLogin]
	@ssn int
AS
BEGIN
SELECT EmployeeUsrName from Employee where ((Employee.EmployeeUsrName = 'r' and Employee.EmployeePass = 'r') or ((Employee.EmployeeUsrName = 'm' and Employee.EmployeePass = 'm'))) and (EmployeeSSN = @ssn)

END
GO
/****** Object:  StoredProcedure [dbo].[ProcSelectGuestID]    Script Date: 12/26/2022 1:38:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ProcSelectGuestID]
	@username varchar(50),
	@password varchar(50)

AS
BEGIN

SELECT Guest.GuestId from Guest, GuestAccount where GuestAccount.GuestID = Guest.GuestId and GuestAccount.UsrName = @username and GuestAccount.password = @password

END
GO
/****** Object:  StoredProcedure [dbo].[ProcSelectHotelProgram]    Script Date: 12/26/2022 1:38:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ProcSelectHotelProgram]
	@id int

AS
BEGIN

SELECT * from HotelProgram where HotelProgram.ProgramId = @id;

END
GO
/****** Object:  StoredProcedure [dbo].[selectAllRec]    Script Date: 12/26/2022 1:38:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[selectAllRec]
AS
BEGIN

SELECT * 
from Receptionist

END
GO
/****** Object:  StoredProcedure [dbo].[SelectFeedBack]    Script Date: 12/26/2022 1:38:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SelectFeedBack]
AS
BEGIN

select FeedBack.Date, FeedBack.comment from FeedBack;

END
GO
/****** Object:  StoredProcedure [dbo].[SelectManagerWssn]    Script Date: 12/26/2022 1:38:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SelectManagerWssn]
	@ssn int
AS
BEGIN
SELECT * from Manager, Employee where ManagerSSN = @ssn and ManagerSSN = EmployeeSSN;

END
GO
/****** Object:  StoredProcedure [dbo].[SelectReceptionistWssn]    Script Date: 12/26/2022 1:38:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SelectReceptionistWssn]
	@ssn int
AS
BEGIN
SELECT Receptionist.*, Employee.* from Receptionist, Employee where ReceptionistSSN = EmployeeSSN and ReceptionistSSN = @ssn;

END
GO
/****** Object:  StoredProcedure [dbo].[SrID]    Script Date: 12/26/2022 1:38:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SrID]
AS
BEGIN

SELECT ServiceID FROM Service where ServiceAmount > 0

END
GO
USE [master]
GO
ALTER DATABASE [PROJECT] SET  READ_WRITE 
GO
