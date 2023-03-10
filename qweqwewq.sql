USE [Reg]
GO
/****** Object:  Table [dbo].[AnalyzeNames]    Script Date: 10.03.2023 19:10:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AnalyzeNames](
	[id] [int] NOT NULL,
	[name] [nvarchar](100) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 10.03.2023 19:10:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[id] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PersonRooms]    Script Date: 10.03.2023 19:10:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PersonRooms](
	[id] [int] NOT NULL,
	[personId] [nvarchar](50) NULL,
	[roomId] [int] NULL,
 CONSTRAINT [PK_PersonRooms] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Persons]    Script Date: 10.03.2023 19:10:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Persons](
	[snils] [nvarchar](50) NOT NULL,
	[fio] [nvarchar](50) NULL,
	[sex] [bit] NULL,
	[dob] [date] NULL,
	[address] [nvarchar](500) NULL,
	[number] [nvarchar](50) NULL,
 CONSTRAINT [PK_Persons] PRIMARY KEY CLUSTERED 
(
	[snils] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PersonSpecializations]    Script Date: 10.03.2023 19:10:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PersonSpecializations](
	[id] [int] NOT NULL,
	[specId] [int] NULL,
	[personId] [nvarchar](50) NULL,
 CONSTRAINT [PK_PersonSpecializations] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProcedureNames]    Script Date: 10.03.2023 19:10:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProcedureNames](
	[id] [int] NOT NULL,
	[name] [nvarchar](500) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Roles]    Script Date: 10.03.2023 19:10:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Roles](
	[id] [int] NOT NULL,
	[name] [nvarchar](50) NULL,
 CONSTRAINT [PK_Roles] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rooms]    Script Date: 10.03.2023 19:10:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rooms](
	[id] [int] NOT NULL,
	[number] [int] NULL,
 CONSTRAINT [PK_Rooms] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Schedule]    Script Date: 10.03.2023 19:10:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Schedule](
	[id] [int] NOT NULL,
	[snils] [nvarchar](50) NULL,
	[date] [date] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Specializations]    Script Date: 10.03.2023 19:10:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Specializations](
	[id] [int] NOT NULL,
	[name] [nvarchar](150) NULL,
 CONSTRAINT [PK_Specializations] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 10.03.2023 19:10:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[id] [int] NOT NULL,
	[login] [nvarchar](50) NULL,
	[password] [nvarchar](50) NULL,
	[roleId] [int] NOT NULL,
	[personId] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[PersonRooms]  WITH CHECK ADD  CONSTRAINT [FK_PersonRooms_Persons] FOREIGN KEY([personId])
REFERENCES [dbo].[Persons] ([snils])
GO
ALTER TABLE [dbo].[PersonRooms] CHECK CONSTRAINT [FK_PersonRooms_Persons]
GO
ALTER TABLE [dbo].[PersonRooms]  WITH CHECK ADD  CONSTRAINT [FK_PersonRooms_Rooms] FOREIGN KEY([roomId])
REFERENCES [dbo].[Rooms] ([id])
GO
ALTER TABLE [dbo].[PersonRooms] CHECK CONSTRAINT [FK_PersonRooms_Rooms]
GO
ALTER TABLE [dbo].[PersonSpecializations]  WITH CHECK ADD  CONSTRAINT [FK_PersonSpecializations_Persons] FOREIGN KEY([personId])
REFERENCES [dbo].[Persons] ([snils])
GO
ALTER TABLE [dbo].[PersonSpecializations] CHECK CONSTRAINT [FK_PersonSpecializations_Persons]
GO
ALTER TABLE [dbo].[PersonSpecializations]  WITH CHECK ADD  CONSTRAINT [FK_PersonSpecializations_Specializations] FOREIGN KEY([specId])
REFERENCES [dbo].[Specializations] ([id])
GO
ALTER TABLE [dbo].[PersonSpecializations] CHECK CONSTRAINT [FK_PersonSpecializations_Specializations]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_Roles] FOREIGN KEY([personId])
REFERENCES [dbo].[Persons] ([snils])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_Roles]
GO
