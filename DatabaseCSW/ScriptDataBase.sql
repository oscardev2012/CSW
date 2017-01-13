USE [TestSGS]
GO
/****** Object:  Table [dbo].[Author]    Script Date: 1/12/2017 6:51:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Author](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](100) NOT NULL,
 CONSTRAINT [PK_Author] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Book]    Script Date: 1/12/2017 6:51:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Book](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](100) NOT NULL,
	[CategoryId] [int] NOT NULL,
	[AuthorId] [int] NOT NULL,
 CONSTRAINT [PK_Book] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Category]    Script Date: 1/12/2017 6:51:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Category](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](100) NOT NULL,
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Author] ON 

INSERT [dbo].[Author] ([Id], [Name]) VALUES (4, N'Gabriel Garcia MARQUEZ')
INSERT [dbo].[Author] ([Id], [Name]) VALUES (5, N'Gloria Guarnizo')
INSERT [dbo].[Author] ([Id], [Name]) VALUES (6, N'Oscar Sierra')
SET IDENTITY_INSERT [dbo].[Author] OFF
SET IDENTITY_INSERT [dbo].[Book] ON 

INSERT [dbo].[Book] ([Id], [Name], [CategoryId], [AuthorId]) VALUES (7, N'EL PAISAJE', 9, 4)
INSERT [dbo].[Book] ([Id], [Name], [CategoryId], [AuthorId]) VALUES (8, N'Los Arboles', 13, 5)
INSERT [dbo].[Book] ([Id], [Name], [CategoryId], [AuthorId]) VALUES (9, N'Padre Rico', 11, 6)
INSERT [dbo].[Book] ([Id], [Name], [CategoryId], [AuthorId]) VALUES (10, N'Gaviota', 12, 4)
SET IDENTITY_INSERT [dbo].[Book] OFF
SET IDENTITY_INSERT [dbo].[Category] ON 

INSERT [dbo].[Category] ([Id], [Name]) VALUES (9, N'Terror')
INSERT [dbo].[Category] ([Id], [Name]) VALUES (10, N'Humor')
INSERT [dbo].[Category] ([Id], [Name]) VALUES (11, N'Suspenso')
INSERT [dbo].[Category] ([Id], [Name]) VALUES (12, N'ACCION')
INSERT [dbo].[Category] ([Id], [Name]) VALUES (13, N'Chismes')
SET IDENTITY_INSERT [dbo].[Category] OFF
ALTER TABLE [dbo].[Book]  WITH CHECK ADD  CONSTRAINT [FK_Book_Author] FOREIGN KEY([AuthorId])
REFERENCES [dbo].[Author] ([Id])
GO
ALTER TABLE [dbo].[Book] CHECK CONSTRAINT [FK_Book_Author]
GO
ALTER TABLE [dbo].[Book]  WITH CHECK ADD  CONSTRAINT [FK_Book_Category] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[Category] ([Id])
GO
ALTER TABLE [dbo].[Book] CHECK CONSTRAINT [FK_Book_Category]
GO
