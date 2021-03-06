USE [master]
GO
/****** Object:  Database [Cinemas]    Script Date: 2017-04-18 17:01:56 ******/
CREATE DATABASE [Cinemas]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Cinemas', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\Cinemas.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Cinemas_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\Cinemas_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Cinemas] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Cinemas].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Cinemas] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Cinemas] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Cinemas] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Cinemas] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Cinemas] SET ARITHABORT OFF 
GO
ALTER DATABASE [Cinemas] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Cinemas] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Cinemas] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Cinemas] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Cinemas] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Cinemas] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Cinemas] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Cinemas] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Cinemas] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Cinemas] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Cinemas] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Cinemas] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Cinemas] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Cinemas] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Cinemas] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Cinemas] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Cinemas] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Cinemas] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Cinemas] SET  MULTI_USER 
GO
ALTER DATABASE [Cinemas] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Cinemas] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Cinemas] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Cinemas] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [Cinemas] SET DELAYED_DURABILITY = DISABLED 
GO
USE [Cinemas]
GO
/****** Object:  Table [dbo].[Cinema]    Script Date: 2017-04-18 17:01:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cinema](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[City] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Cinema] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Employy]    Script Date: 2017-04-18 17:01:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employy](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Surname] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Employy] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Film]    Script Date: 2017-04-18 17:01:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Film](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](50) NOT NULL,
	[Director] [nvarchar](50) NOT NULL,
	[Length] [int] NOT NULL,
 CONSTRAINT [PK_Film] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Hall]    Script Date: 2017-04-18 17:01:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Hall](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Number] [int] NOT NULL,
	[CountOfSeat] [int] NOT NULL,
 CONSTRAINT [PK_Hall] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HallsOfCinema]    Script Date: 2017-04-18 17:01:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HallsOfCinema](
	[CinemaID] [int] NOT NULL,
	[HallID] [int] NOT NULL,
 CONSTRAINT [PK_HallsOfCinema] PRIMARY KEY CLUSTERED 
(
	[CinemaID] ASC,
	[HallID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Programme]    Script Date: 2017-04-18 17:01:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Programme](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[FilmID] [int] NOT NULL,
	[Date] [date] NOT NULL,
	[Time] [time](7) NOT NULL,
	[HallId] [int] NOT NULL,
 CONSTRAINT [PK_Programme] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Cinema] ON 

INSERT [dbo].[Cinema] ([ID], [Name], [City]) VALUES (1, N'Korona', N'Wrocław')
INSERT [dbo].[Cinema] ([ID], [Name], [City]) VALUES (2, N'Helios', N'Wrocław')
SET IDENTITY_INSERT [dbo].[Cinema] OFF
SET IDENTITY_INSERT [dbo].[Employy] ON 

INSERT [dbo].[Employy] ([ID], [Name], [Surname]) VALUES (1, N'Michał', N'Sewerniak')
INSERT [dbo].[Employy] ([ID], [Name], [Surname]) VALUES (2, N'Milena', N'Łukasik')
INSERT [dbo].[Employy] ([ID], [Name], [Surname]) VALUES (3, N'Marta', N'Wesołowska')
INSERT [dbo].[Employy] ([ID], [Name], [Surname]) VALUES (4, N'Ewa', N'Wojtowicz')
INSERT [dbo].[Employy] ([ID], [Name], [Surname]) VALUES (5, N'Adam', N'Dombrowski')
SET IDENTITY_INSERT [dbo].[Employy] OFF
SET IDENTITY_INSERT [dbo].[Film] ON 

INSERT [dbo].[Film] ([ID], [Title], [Director], [Length]) VALUES (1, N'Star Wars ', N'George Lucas', 122)
INSERT [dbo].[Film] ([ID], [Title], [Director], [Length]) VALUES (2, N'Whiplash', N'Damien Chazelle', 105)
INSERT [dbo].[Film] ([ID], [Title], [Director], [Length]) VALUES (3, N'Leniwce', N'Adrianna Bisikiewicz', 77)
INSERT [dbo].[Film] ([ID], [Title], [Director], [Length]) VALUES (4, N'Rzeź Niemowląt', N'Milena Łukasik', 666)
INSERT [dbo].[Film] ([ID], [Title], [Director], [Length]) VALUES (5, N'Matka Chrzestna', N'Anna Radziszewska', 110)
INSERT [dbo].[Film] ([ID], [Title], [Director], [Length]) VALUES (6, N'Zemsta Mufasy', N'Simba Huovinen', 122)
INSERT [dbo].[Film] ([ID], [Title], [Director], [Length]) VALUES (7, N'Jak poznałam swojego sponsora', N'Sasha Gray', 69)
INSERT [dbo].[Film] ([ID], [Title], [Director], [Length]) VALUES (8, N'Szybcy i wściekli 234', N'Ivan Pościgowicz', 7)
INSERT [dbo].[Film] ([ID], [Title], [Director], [Length]) VALUES (9, N'Dziki żółw', N'Kim Jong-Un', 50)
INSERT [dbo].[Film] ([ID], [Title], [Director], [Length]) VALUES (11, N'Obrońca matematyki', N'Jerzy Pietraszko', 8)
SET IDENTITY_INSERT [dbo].[Film] OFF
SET IDENTITY_INSERT [dbo].[Hall] ON 

INSERT [dbo].[Hall] ([ID], [Number], [CountOfSeat]) VALUES (1, 1, 100)
INSERT [dbo].[Hall] ([ID], [Number], [CountOfSeat]) VALUES (2, 2, 77)
INSERT [dbo].[Hall] ([ID], [Number], [CountOfSeat]) VALUES (3, 3, 45)
INSERT [dbo].[Hall] ([ID], [Number], [CountOfSeat]) VALUES (4, 1, 200)
INSERT [dbo].[Hall] ([ID], [Number], [CountOfSeat]) VALUES (5, 2, 80)
INSERT [dbo].[Hall] ([ID], [Number], [CountOfSeat]) VALUES (6, 3, 150)
INSERT [dbo].[Hall] ([ID], [Number], [CountOfSeat]) VALUES (7, 4, 7)
SET IDENTITY_INSERT [dbo].[Hall] OFF
INSERT [dbo].[HallsOfCinema] ([CinemaID], [HallID]) VALUES (1, 1)
INSERT [dbo].[HallsOfCinema] ([CinemaID], [HallID]) VALUES (1, 2)
INSERT [dbo].[HallsOfCinema] ([CinemaID], [HallID]) VALUES (1, 3)
INSERT [dbo].[HallsOfCinema] ([CinemaID], [HallID]) VALUES (2, 4)
INSERT [dbo].[HallsOfCinema] ([CinemaID], [HallID]) VALUES (2, 5)
INSERT [dbo].[HallsOfCinema] ([CinemaID], [HallID]) VALUES (2, 6)
INSERT [dbo].[HallsOfCinema] ([CinemaID], [HallID]) VALUES (2, 7)
SET IDENTITY_INSERT [dbo].[Programme] ON 

INSERT [dbo].[Programme] ([ID], [FilmID], [Date], [Time], [HallId]) VALUES (1, 1, CAST(N'2017-04-12' AS Date), CAST(N'07:00:00' AS Time), 1)
INSERT [dbo].[Programme] ([ID], [FilmID], [Date], [Time], [HallId]) VALUES (2, 2, CAST(N'2017-04-12' AS Date), CAST(N'12:00:00' AS Time), 2)
INSERT [dbo].[Programme] ([ID], [FilmID], [Date], [Time], [HallId]) VALUES (4, 3, CAST(N'2017-04-12' AS Date), CAST(N'13:00:00' AS Time), 1)
INSERT [dbo].[Programme] ([ID], [FilmID], [Date], [Time], [HallId]) VALUES (5, 2, CAST(N'2017-04-12' AS Date), CAST(N'14:00:00' AS Time), 2)
INSERT [dbo].[Programme] ([ID], [FilmID], [Date], [Time], [HallId]) VALUES (6, 4, CAST(N'2017-04-12' AS Date), CAST(N'08:00:00' AS Time), 3)
INSERT [dbo].[Programme] ([ID], [FilmID], [Date], [Time], [HallId]) VALUES (7, 5, CAST(N'2017-04-13' AS Date), CAST(N'09:30:00' AS Time), 4)
INSERT [dbo].[Programme] ([ID], [FilmID], [Date], [Time], [HallId]) VALUES (8, 6, CAST(N'2017-04-13' AS Date), CAST(N'10:00:00' AS Time), 5)
INSERT [dbo].[Programme] ([ID], [FilmID], [Date], [Time], [HallId]) VALUES (9, 4, CAST(N'2017-04-13' AS Date), CAST(N'11:00:00' AS Time), 1)
INSERT [dbo].[Programme] ([ID], [FilmID], [Date], [Time], [HallId]) VALUES (10, 3, CAST(N'2017-04-13' AS Date), CAST(N'15:00:00' AS Time), 2)
SET IDENTITY_INSERT [dbo].[Programme] OFF
ALTER TABLE [dbo].[HallsOfCinema]  WITH CHECK ADD  CONSTRAINT [FK_HallsOfCinema_Cinema] FOREIGN KEY([CinemaID])
REFERENCES [dbo].[Cinema] ([ID])
GO
ALTER TABLE [dbo].[HallsOfCinema] CHECK CONSTRAINT [FK_HallsOfCinema_Cinema]
GO
ALTER TABLE [dbo].[HallsOfCinema]  WITH CHECK ADD  CONSTRAINT [FK_HallsOfCinema_Hall] FOREIGN KEY([HallID])
REFERENCES [dbo].[Hall] ([ID])
GO
ALTER TABLE [dbo].[HallsOfCinema] CHECK CONSTRAINT [FK_HallsOfCinema_Hall]
GO
ALTER TABLE [dbo].[Programme]  WITH CHECK ADD  CONSTRAINT [FK_Programme_Film] FOREIGN KEY([FilmID])
REFERENCES [dbo].[Film] ([ID])
GO
ALTER TABLE [dbo].[Programme] CHECK CONSTRAINT [FK_Programme_Film]
GO
ALTER TABLE [dbo].[Programme]  WITH CHECK ADD  CONSTRAINT [FK_Programme_Hall] FOREIGN KEY([HallId])
REFERENCES [dbo].[Hall] ([ID])
GO
ALTER TABLE [dbo].[Programme] CHECK CONSTRAINT [FK_Programme_Hall]
GO
USE [master]
GO
ALTER DATABASE [Cinemas] SET  READ_WRITE 
GO
