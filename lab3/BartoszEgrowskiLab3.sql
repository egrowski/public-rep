USE [master]
GO
/****** Object:  Database [BartoszEgrowskiSchoolDatabase]    Script Date: 2016-04-30 04:44:55 ******/
CREATE DATABASE [BartoszEgrowskiSchoolDatabase]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SchoolDatabase', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\SchoolDatabase.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'SchoolDatabase_log', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\SchoolDatabase_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [BartoszEgrowskiSchoolDatabase] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BartoszEgrowskiSchoolDatabase].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BartoszEgrowskiSchoolDatabase] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BartoszEgrowskiSchoolDatabase] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BartoszEgrowskiSchoolDatabase] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BartoszEgrowskiSchoolDatabase] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BartoszEgrowskiSchoolDatabase] SET ARITHABORT OFF 
GO
ALTER DATABASE [BartoszEgrowskiSchoolDatabase] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [BartoszEgrowskiSchoolDatabase] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [BartoszEgrowskiSchoolDatabase] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BartoszEgrowskiSchoolDatabase] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BartoszEgrowskiSchoolDatabase] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BartoszEgrowskiSchoolDatabase] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BartoszEgrowskiSchoolDatabase] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BartoszEgrowskiSchoolDatabase] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BartoszEgrowskiSchoolDatabase] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BartoszEgrowskiSchoolDatabase] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BartoszEgrowskiSchoolDatabase] SET  DISABLE_BROKER 
GO
ALTER DATABASE [BartoszEgrowskiSchoolDatabase] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BartoszEgrowskiSchoolDatabase] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BartoszEgrowskiSchoolDatabase] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BartoszEgrowskiSchoolDatabase] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BartoszEgrowskiSchoolDatabase] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BartoszEgrowskiSchoolDatabase] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [BartoszEgrowskiSchoolDatabase] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BartoszEgrowskiSchoolDatabase] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [BartoszEgrowskiSchoolDatabase] SET  MULTI_USER 
GO
ALTER DATABASE [BartoszEgrowskiSchoolDatabase] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BartoszEgrowskiSchoolDatabase] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BartoszEgrowskiSchoolDatabase] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BartoszEgrowskiSchoolDatabase] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [BartoszEgrowskiSchoolDatabase]
GO
/****** Object:  Table [dbo].[Address]    Script Date: 2016-04-30 04:44:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Address](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[StreetAndNumber] [nvarchar](50) NOT NULL,
	[City] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Address] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Grades]    Script Date: 2016-04-30 04:44:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Grades](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Grade] [float] NOT NULL,
	[GradeWord] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Grades] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Homeworks]    Script Date: 2016-04-30 04:44:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Homeworks](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](50) NOT NULL,
	[Date] [date] NOT NULL,
 CONSTRAINT [PK_Homeworks] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Parents]    Script Date: 2016-04-30 04:44:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Parents](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Surname] [nvarchar](50) NOT NULL,
	[AddressID] [int] NOT NULL,
 CONSTRAINT [PK_Parents] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Schools]    Script Date: 2016-04-30 04:44:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Schools](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[AddressID] [int] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Principal] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Schools] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[StudentGrades]    Script Date: 2016-04-30 04:44:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StudentGrades](
	[StudentID] [int] NOT NULL,
	[HomeworkID] [int] NULL,
	[SubjectID] [int] NOT NULL,
	[GradeID] [int] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[StudentHomeworks]    Script Date: 2016-04-30 04:44:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StudentHomeworks](
	[StudentID] [int] NOT NULL,
	[HomeworkID] [int] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[StudentParents]    Script Date: 2016-04-30 04:44:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StudentParents](
	[StudentID] [int] NOT NULL,
	[ParentID] [int] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Students]    Script Date: 2016-04-30 04:44:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Students](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Surname] [nvarchar](50) NOT NULL,
	[AddressID] [int] NOT NULL,
	[SchoolID] [int] NOT NULL,
 CONSTRAINT [PK_Students] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[StudentSubjects]    Script Date: 2016-04-30 04:44:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StudentSubjects](
	[StudentID] [int] NOT NULL,
	[SubjectID] [int] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Subjects]    Script Date: 2016-04-30 04:44:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Subjects](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Subjects] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Teachers]    Script Date: 2016-04-30 04:44:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Teachers](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Surname] [nvarchar](50) NOT NULL,
	[SchoolID] [int] NOT NULL,
	[AddressID] [int] NOT NULL,
	[SubjectID] [int] NOT NULL,
 CONSTRAINT [PK_Teachers] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Address] ON 

INSERT [dbo].[Address] ([ID], [StreetAndNumber], [City]) VALUES (1, N'Cabaja 15', N'Wrocław')
INSERT [dbo].[Address] ([ID], [StreetAndNumber], [City]) VALUES (2, N'Mińska 4', N'Wrocław')
INSERT [dbo].[Address] ([ID], [StreetAndNumber], [City]) VALUES (3, N'Szewska 25', N'Wrocław')
INSERT [dbo].[Address] ([ID], [StreetAndNumber], [City]) VALUES (4, N'Wrocławska', N'Bielany Wrocławskie')
INSERT [dbo].[Address] ([ID], [StreetAndNumber], [City]) VALUES (6, N'Jana Pawła II 6', N'Opole')
INSERT [dbo].[Address] ([ID], [StreetAndNumber], [City]) VALUES (7, N'Szkocka 15', N'Wrocław')
INSERT [dbo].[Address] ([ID], [StreetAndNumber], [City]) VALUES (8, N'Pl. Orląt Lwowskich 3', N'Wrocław')
INSERT [dbo].[Address] ([ID], [StreetAndNumber], [City]) VALUES (9, N'Cieślikowskiego 5', N'Wrocław')
INSERT [dbo].[Address] ([ID], [StreetAndNumber], [City]) VALUES (10, N'Widok 5', N'Wrocław')
INSERT [dbo].[Address] ([ID], [StreetAndNumber], [City]) VALUES (11, N'Grunwaldzka 23', N'Wrocław')
INSERT [dbo].[Address] ([ID], [StreetAndNumber], [City]) VALUES (12, N'Ceglana 3', N'Wrocław')
SET IDENTITY_INSERT [dbo].[Address] OFF
SET IDENTITY_INSERT [dbo].[Grades] ON 

INSERT [dbo].[Grades] ([ID], [Grade], [GradeWord]) VALUES (1, 1, N'Niedostateczny')
INSERT [dbo].[Grades] ([ID], [Grade], [GradeWord]) VALUES (2, 2, N'Mierny')
INSERT [dbo].[Grades] ([ID], [Grade], [GradeWord]) VALUES (3, 2.5, N'Mierny plus')
INSERT [dbo].[Grades] ([ID], [Grade], [GradeWord]) VALUES (4, 3, N'Dostateczny')
INSERT [dbo].[Grades] ([ID], [Grade], [GradeWord]) VALUES (5, 3.5, N'Dostateczny plus')
INSERT [dbo].[Grades] ([ID], [Grade], [GradeWord]) VALUES (6, 4, N'Dobry')
INSERT [dbo].[Grades] ([ID], [Grade], [GradeWord]) VALUES (7, 4.5, N'Dobry plus')
INSERT [dbo].[Grades] ([ID], [Grade], [GradeWord]) VALUES (8, 5, N'Bardzo dobry')
INSERT [dbo].[Grades] ([ID], [Grade], [GradeWord]) VALUES (9, 5.5, N'Bardzo dobry plus')
INSERT [dbo].[Grades] ([ID], [Grade], [GradeWord]) VALUES (10, 6, N'Celujący')
SET IDENTITY_INSERT [dbo].[Grades] OFF
SET IDENTITY_INSERT [dbo].[Homeworks] ON 

INSERT [dbo].[Homeworks] ([ID], [Title], [Date]) VALUES (1, N'Analiza Wiersza', CAST(0xFD3A0B00 AS Date))
INSERT [dbo].[Homeworks] ([ID], [Title], [Date]) VALUES (2, N'Zad 1-3, str 203', CAST(0x1A3B0B00 AS Date))
INSERT [dbo].[Homeworks] ([ID], [Title], [Date]) VALUES (4, N'Doświadczenie', CAST(0x943B0B00 AS Date))
INSERT [dbo].[Homeworks] ([ID], [Title], [Date]) VALUES (5, N'Zadanie z chemii', CAST(0x3A3B0B00 AS Date))
INSERT [dbo].[Homeworks] ([ID], [Title], [Date]) VALUES (6, N'Referat z historii', CAST(0x583B0B00 AS Date))
SET IDENTITY_INSERT [dbo].[Homeworks] OFF
SET IDENTITY_INSERT [dbo].[Parents] ON 

INSERT [dbo].[Parents] ([ID], [Name], [Surname], [AddressID]) VALUES (1, N'Maria', N'Kamińska', 4)
INSERT [dbo].[Parents] ([ID], [Name], [Surname], [AddressID]) VALUES (2, N'Wojciech', N'Kamiński', 4)
INSERT [dbo].[Parents] ([ID], [Name], [Surname], [AddressID]) VALUES (3, N'Aneta', N'Nowak', 1)
INSERT [dbo].[Parents] ([ID], [Name], [Surname], [AddressID]) VALUES (4, N'Andrzej', N'Nowak', 1)
INSERT [dbo].[Parents] ([ID], [Name], [Surname], [AddressID]) VALUES (5, N'Zbigniew', N'Kowalski', 3)
INSERT [dbo].[Parents] ([ID], [Name], [Surname], [AddressID]) VALUES (6, N'Urszula', N'Kowalska', 3)
INSERT [dbo].[Parents] ([ID], [Name], [Surname], [AddressID]) VALUES (7, N'Stanisław', N'Wróbel', 2)
INSERT [dbo].[Parents] ([ID], [Name], [Surname], [AddressID]) VALUES (8, N'Żaneta', N'Wróbel', 2)
INSERT [dbo].[Parents] ([ID], [Name], [Surname], [AddressID]) VALUES (9, N'Zbigniew', N'Majewski', 6)
INSERT [dbo].[Parents] ([ID], [Name], [Surname], [AddressID]) VALUES (10, N'Justyna', N'Majewska', 6)
SET IDENTITY_INSERT [dbo].[Parents] OFF
SET IDENTITY_INSERT [dbo].[Schools] ON 

INSERT [dbo].[Schools] ([ID], [AddressID], [Name], [Principal]) VALUES (1, 7, N'Gimnazjum nr 5', N'Okoń')
INSERT [dbo].[Schools] ([ID], [AddressID], [Name], [Principal]) VALUES (2, 8, N'LO XII', N'Alicja Bukowska')
SET IDENTITY_INSERT [dbo].[Schools] OFF
INSERT [dbo].[StudentGrades] ([StudentID], [HomeworkID], [SubjectID], [GradeID]) VALUES (1, 6, 1, 5)
INSERT [dbo].[StudentGrades] ([StudentID], [HomeworkID], [SubjectID], [GradeID]) VALUES (1, 1, 2, 7)
INSERT [dbo].[StudentGrades] ([StudentID], [HomeworkID], [SubjectID], [GradeID]) VALUES (1, 2, 4, 7)
INSERT [dbo].[StudentGrades] ([StudentID], [HomeworkID], [SubjectID], [GradeID]) VALUES (2, 4, 3, 9)
INSERT [dbo].[StudentGrades] ([StudentID], [HomeworkID], [SubjectID], [GradeID]) VALUES (3, 5, 3, 10)
INSERT [dbo].[StudentGrades] ([StudentID], [HomeworkID], [SubjectID], [GradeID]) VALUES (3, 6, 1, 10)
INSERT [dbo].[StudentGrades] ([StudentID], [HomeworkID], [SubjectID], [GradeID]) VALUES (4, 1, 2, 3)
INSERT [dbo].[StudentGrades] ([StudentID], [HomeworkID], [SubjectID], [GradeID]) VALUES (5, 2, 4, 4)
INSERT [dbo].[StudentGrades] ([StudentID], [HomeworkID], [SubjectID], [GradeID]) VALUES (5, 4, 3, 8)
INSERT [dbo].[StudentGrades] ([StudentID], [HomeworkID], [SubjectID], [GradeID]) VALUES (7, 1, 2, 10)
INSERT [dbo].[StudentGrades] ([StudentID], [HomeworkID], [SubjectID], [GradeID]) VALUES (7, 6, 1, 10)
INSERT [dbo].[StudentGrades] ([StudentID], [HomeworkID], [SubjectID], [GradeID]) VALUES (7, 2, 4, 10)
INSERT [dbo].[StudentHomeworks] ([StudentID], [HomeworkID]) VALUES (1, 1)
INSERT [dbo].[StudentHomeworks] ([StudentID], [HomeworkID]) VALUES (1, 2)
INSERT [dbo].[StudentHomeworks] ([StudentID], [HomeworkID]) VALUES (1, 4)
INSERT [dbo].[StudentHomeworks] ([StudentID], [HomeworkID]) VALUES (2, 1)
INSERT [dbo].[StudentHomeworks] ([StudentID], [HomeworkID]) VALUES (2, 4)
INSERT [dbo].[StudentHomeworks] ([StudentID], [HomeworkID]) VALUES (3, 1)
INSERT [dbo].[StudentHomeworks] ([StudentID], [HomeworkID]) VALUES (3, 5)
INSERT [dbo].[StudentHomeworks] ([StudentID], [HomeworkID]) VALUES (4, 5)
INSERT [dbo].[StudentHomeworks] ([StudentID], [HomeworkID]) VALUES (5, 6)
INSERT [dbo].[StudentHomeworks] ([StudentID], [HomeworkID]) VALUES (7, 6)
INSERT [dbo].[StudentHomeworks] ([StudentID], [HomeworkID]) VALUES (7, 1)
INSERT [dbo].[StudentParents] ([StudentID], [ParentID]) VALUES (5, 1)
INSERT [dbo].[StudentParents] ([StudentID], [ParentID]) VALUES (5, 2)
INSERT [dbo].[StudentParents] ([StudentID], [ParentID]) VALUES (7, 1)
INSERT [dbo].[StudentParents] ([StudentID], [ParentID]) VALUES (7, 2)
INSERT [dbo].[StudentParents] ([StudentID], [ParentID]) VALUES (4, 9)
INSERT [dbo].[StudentParents] ([StudentID], [ParentID]) VALUES (4, 10)
INSERT [dbo].[StudentParents] ([StudentID], [ParentID]) VALUES (3, 7)
INSERT [dbo].[StudentParents] ([StudentID], [ParentID]) VALUES (3, 8)
INSERT [dbo].[StudentParents] ([StudentID], [ParentID]) VALUES (2, 5)
INSERT [dbo].[StudentParents] ([StudentID], [ParentID]) VALUES (2, 6)
INSERT [dbo].[StudentParents] ([StudentID], [ParentID]) VALUES (1, 3)
INSERT [dbo].[StudentParents] ([StudentID], [ParentID]) VALUES (1, 4)
SET IDENTITY_INSERT [dbo].[Students] ON 

INSERT [dbo].[Students] ([ID], [Name], [Surname], [AddressID], [SchoolID]) VALUES (1, N'Michał', N'Nowak', 1, 1)
INSERT [dbo].[Students] ([ID], [Name], [Surname], [AddressID], [SchoolID]) VALUES (2, N'Wojciech', N'Kowalski', 3, 1)
INSERT [dbo].[Students] ([ID], [Name], [Surname], [AddressID], [SchoolID]) VALUES (3, N'Marcin', N'Wróbel', 2, 1)
INSERT [dbo].[Students] ([ID], [Name], [Surname], [AddressID], [SchoolID]) VALUES (4, N'Artur', N'Majewski', 6, 2)
INSERT [dbo].[Students] ([ID], [Name], [Surname], [AddressID], [SchoolID]) VALUES (5, N'Rafał', N'Kamiński', 4, 2)
INSERT [dbo].[Students] ([ID], [Name], [Surname], [AddressID], [SchoolID]) VALUES (7, N'Andrzej', N'Kamiński', 4, 2)
SET IDENTITY_INSERT [dbo].[Students] OFF
INSERT [dbo].[StudentSubjects] ([StudentID], [SubjectID]) VALUES (1, 1)
INSERT [dbo].[StudentSubjects] ([StudentID], [SubjectID]) VALUES (1, 2)
INSERT [dbo].[StudentSubjects] ([StudentID], [SubjectID]) VALUES (1, 3)
INSERT [dbo].[StudentSubjects] ([StudentID], [SubjectID]) VALUES (2, 1)
INSERT [dbo].[StudentSubjects] ([StudentID], [SubjectID]) VALUES (2, 3)
INSERT [dbo].[StudentSubjects] ([StudentID], [SubjectID]) VALUES (2, 4)
INSERT [dbo].[StudentSubjects] ([StudentID], [SubjectID]) VALUES (3, 1)
INSERT [dbo].[StudentSubjects] ([StudentID], [SubjectID]) VALUES (3, 2)
INSERT [dbo].[StudentSubjects] ([StudentID], [SubjectID]) VALUES (4, 4)
INSERT [dbo].[StudentSubjects] ([StudentID], [SubjectID]) VALUES (5, 1)
INSERT [dbo].[StudentSubjects] ([StudentID], [SubjectID]) VALUES (5, 2)
INSERT [dbo].[StudentSubjects] ([StudentID], [SubjectID]) VALUES (7, 3)
INSERT [dbo].[StudentSubjects] ([StudentID], [SubjectID]) VALUES (7, 4)
SET IDENTITY_INSERT [dbo].[Subjects] ON 

INSERT [dbo].[Subjects] ([ID], [Name]) VALUES (1, N'Historia')
INSERT [dbo].[Subjects] ([ID], [Name]) VALUES (2, N'Język Polski')
INSERT [dbo].[Subjects] ([ID], [Name]) VALUES (3, N'Chemia')
INSERT [dbo].[Subjects] ([ID], [Name]) VALUES (4, N'Matematyka')
SET IDENTITY_INSERT [dbo].[Subjects] OFF
SET IDENTITY_INSERT [dbo].[Teachers] ON 

INSERT [dbo].[Teachers] ([ID], [Name], [Surname], [SchoolID], [AddressID], [SubjectID]) VALUES (1, N'Piotr', N'Mally', 1, 9, 1)
INSERT [dbo].[Teachers] ([ID], [Name], [Surname], [SchoolID], [AddressID], [SubjectID]) VALUES (2, N'Anna', N'Cebulska', 1, 10, 2)
INSERT [dbo].[Teachers] ([ID], [Name], [Surname], [SchoolID], [AddressID], [SubjectID]) VALUES (3, N'Michalina', N'Grządziel', 2, 11, 3)
INSERT [dbo].[Teachers] ([ID], [Name], [Surname], [SchoolID], [AddressID], [SubjectID]) VALUES (4, N'Ewa', N'Wolny', 2, 12, 4)
SET IDENTITY_INSERT [dbo].[Teachers] OFF
ALTER TABLE [dbo].[Parents]  WITH CHECK ADD  CONSTRAINT [FK_Parents_Address] FOREIGN KEY([AddressID])
REFERENCES [dbo].[Address] ([ID])
GO
ALTER TABLE [dbo].[Parents] CHECK CONSTRAINT [FK_Parents_Address]
GO
ALTER TABLE [dbo].[Schools]  WITH CHECK ADD  CONSTRAINT [FK_Schools_Address] FOREIGN KEY([AddressID])
REFERENCES [dbo].[Address] ([ID])
GO
ALTER TABLE [dbo].[Schools] CHECK CONSTRAINT [FK_Schools_Address]
GO
ALTER TABLE [dbo].[StudentGrades]  WITH CHECK ADD  CONSTRAINT [FK_StudentGrades_Grades] FOREIGN KEY([GradeID])
REFERENCES [dbo].[Grades] ([ID])
GO
ALTER TABLE [dbo].[StudentGrades] CHECK CONSTRAINT [FK_StudentGrades_Grades]
GO
ALTER TABLE [dbo].[StudentGrades]  WITH CHECK ADD  CONSTRAINT [FK_StudentGrades_Students] FOREIGN KEY([StudentID])
REFERENCES [dbo].[Students] ([ID])
GO
ALTER TABLE [dbo].[StudentGrades] CHECK CONSTRAINT [FK_StudentGrades_Students]
GO
ALTER TABLE [dbo].[StudentHomeworks]  WITH CHECK ADD  CONSTRAINT [FK_StudentHomeworks_Homeworks] FOREIGN KEY([HomeworkID])
REFERENCES [dbo].[Homeworks] ([ID])
GO
ALTER TABLE [dbo].[StudentHomeworks] CHECK CONSTRAINT [FK_StudentHomeworks_Homeworks]
GO
ALTER TABLE [dbo].[StudentHomeworks]  WITH CHECK ADD  CONSTRAINT [FK_StudentHomeworks_Students] FOREIGN KEY([StudentID])
REFERENCES [dbo].[Students] ([ID])
GO
ALTER TABLE [dbo].[StudentHomeworks] CHECK CONSTRAINT [FK_StudentHomeworks_Students]
GO
ALTER TABLE [dbo].[StudentParents]  WITH CHECK ADD  CONSTRAINT [FK_StudentParents_Parents] FOREIGN KEY([ParentID])
REFERENCES [dbo].[Parents] ([ID])
GO
ALTER TABLE [dbo].[StudentParents] CHECK CONSTRAINT [FK_StudentParents_Parents]
GO
ALTER TABLE [dbo].[StudentParents]  WITH CHECK ADD  CONSTRAINT [FK_StudentParents_Students] FOREIGN KEY([StudentID])
REFERENCES [dbo].[Students] ([ID])
GO
ALTER TABLE [dbo].[StudentParents] CHECK CONSTRAINT [FK_StudentParents_Students]
GO
ALTER TABLE [dbo].[Students]  WITH CHECK ADD  CONSTRAINT [FK_Students_Address] FOREIGN KEY([AddressID])
REFERENCES [dbo].[Address] ([ID])
GO
ALTER TABLE [dbo].[Students] CHECK CONSTRAINT [FK_Students_Address]
GO
ALTER TABLE [dbo].[Students]  WITH CHECK ADD  CONSTRAINT [FK_Students_Schools] FOREIGN KEY([SchoolID])
REFERENCES [dbo].[Schools] ([ID])
GO
ALTER TABLE [dbo].[Students] CHECK CONSTRAINT [FK_Students_Schools]
GO
ALTER TABLE [dbo].[StudentSubjects]  WITH CHECK ADD  CONSTRAINT [FK_StudentSubjects_Students] FOREIGN KEY([StudentID])
REFERENCES [dbo].[Students] ([ID])
GO
ALTER TABLE [dbo].[StudentSubjects] CHECK CONSTRAINT [FK_StudentSubjects_Students]
GO
ALTER TABLE [dbo].[StudentSubjects]  WITH CHECK ADD  CONSTRAINT [FK_StudentSubjects_Subjects] FOREIGN KEY([SubjectID])
REFERENCES [dbo].[Subjects] ([ID])
GO
ALTER TABLE [dbo].[StudentSubjects] CHECK CONSTRAINT [FK_StudentSubjects_Subjects]
GO
ALTER TABLE [dbo].[Teachers]  WITH CHECK ADD  CONSTRAINT [FK_Teachers_Address] FOREIGN KEY([AddressID])
REFERENCES [dbo].[Address] ([ID])
GO
ALTER TABLE [dbo].[Teachers] CHECK CONSTRAINT [FK_Teachers_Address]
GO
ALTER TABLE [dbo].[Teachers]  WITH CHECK ADD  CONSTRAINT [FK_Teachers_Schools] FOREIGN KEY([SchoolID])
REFERENCES [dbo].[Schools] ([ID])
GO
ALTER TABLE [dbo].[Teachers] CHECK CONSTRAINT [FK_Teachers_Schools]
GO
ALTER TABLE [dbo].[Teachers]  WITH CHECK ADD  CONSTRAINT [FK_Teachers_Subjects] FOREIGN KEY([SubjectID])
REFERENCES [dbo].[Subjects] ([ID])
GO
ALTER TABLE [dbo].[Teachers] CHECK CONSTRAINT [FK_Teachers_Subjects]
GO
USE [master]
GO
ALTER DATABASE [BartoszEgrowskiSchoolDatabase] SET  READ_WRITE 
GO
