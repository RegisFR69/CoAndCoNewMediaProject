/****** Object:  Table [dbo].[Collection]    Script Date: 23/02/2018 14:03:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Collection](
	[id_media] [int] NOT NULL,
	[number_set] [int] NULL,
	[name_set] [nchar](20) NULL,
	[format] [nchar](10) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Comment]    Script Date: 23/02/2018 14:03:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Comment](
	[id_media] [int] NULL,
	[id_user] [int] NOT NULL,
	[comment] [nchar](100) NULL,
	[note] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Exemplary]    Script Date: 23/02/2018 14:03:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Exemplary](
	[id_exemplary] [int] NOT NULL,
	[name_exemplary] [nchar](20) NULL,
	[path_exemplary] [nchar](30) NULL,
	[format_exemplary] [nchar](10) NULL,
	[id_media] [int] NOT NULL,
	[Duration] [time](7) NULL,
 CONSTRAINT [PK_Exemplary] PRIMARY KEY CLUSTERED 
(
	[id_exemplary] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Genre]    Script Date: 23/02/2018 14:03:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Genre](
	[id_genre] [int] NOT NULL,
	[nom_genre] [nchar](20) NOT NULL,
 CONSTRAINT [PK_Genre] PRIMARY KEY CLUSTERED 
(
	[id_genre] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Media]    Script Date: 23/02/2018 14:03:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Media](
	[id_media] [int] NOT NULL,
	[title] [nchar](50) NULL,
	[id_nationality] [int] NULL,
	[id_type_media] [int] NULL,
	[release_date] [date] NULL,
	[id_default_playlist] [int] NULL,
	[id_cover] [nchar](10) NULL,
	[id_genre] [int] NULL,
 CONSTRAINT [PK_Media] PRIMARY KEY CLUSTERED 
(
	[id_media] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Media_Season]    Script Date: 23/02/2018 14:03:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Media_Season](
	[id_media] [int] NOT NULL,
	[id_season] [int] NOT NULL,
	[ms_position] [int] NOT NULL,
 CONSTRAINT [PK_Media_Season] PRIMARY KEY CLUSTERED 
(
	[id_media] ASC,
	[id_season] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Nationality]    Script Date: 23/02/2018 14:03:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Nationality](
	[id_nationality] [int] NOT NULL,
	[label_nationality] [nchar](20) NULL,
 CONSTRAINT [PK_Nationality] PRIMARY KEY CLUSTERED 
(
	[id_nationality] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Parents]    Script Date: 23/02/2018 14:03:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Parents](
	[id_person_parent] [int] NULL,
	[id_person_child] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Person]    Script Date: 23/02/2018 14:03:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Person](
	[id_person] [int] NOT NULL,
	[name_persone] [nchar](20) NOT NULL,
	[firstName_person] [nchar](20) NULL,
	[birthDate_person] [date] NULL,
	[deathDate_person] [date] NULL,
	[id_nationality] [int] NULL,
	[id_cover] [nchar](10) NULL,
 CONSTRAINT [PK_Person] PRIMARY KEY CLUSTERED 
(
	[id_person] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Person_Media]    Script Date: 23/02/2018 14:03:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Person_Media](
	[id_person_media] [nchar](10) NOT NULL,
	[id_metier] [int] NOT NULL,
	[id_person] [int] NOT NULL,
	[id_media] [int] NOT NULL,
	[pm_position] [int] NULL,
 CONSTRAINT [PK_Person_Media] PRIMARY KEY CLUSTERED 
(
	[id_person_media] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Playlist]    Script Date: 23/02/2018 14:03:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Playlist](
	[id_playlist] [int] NOT NULL,
	[name_playlist] [nchar](20) NOT NULL,
 CONSTRAINT [PK_Playlist] PRIMARY KEY CLUSTERED 
(
	[id_playlist] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Playlist_Content]    Script Date: 23/02/2018 14:03:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Playlist_Content](
	[id_user] [int] NOT NULL,
	[id_media] [int] NOT NULL,
	[id_playlist] [int] NOT NULL,
	[pc_position] [int] NOT NULL,
 CONSTRAINT [PK_Playlist_Content] PRIMARY KEY CLUSTERED 
(
	[id_user] ASC,
	[id_media] ASC,
	[id_playlist] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Role]    Script Date: 23/02/2018 14:03:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Role](
	[id_role] [int] NOT NULL,
	[label_role] [nchar](10) NOT NULL,
	[id_person_media] [nchar](10) NULL,
 CONSTRAINT [PK_Role_1] PRIMARY KEY CLUSTERED 
(
	[id_role] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Season]    Script Date: 23/02/2018 14:03:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Season](
	[id_season] [int] NOT NULL,
	[name_season] [nchar](20) NULL,
 CONSTRAINT [PK_Sub_Set] PRIMARY KEY CLUSTERED 
(
	[id_season] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Set]    Script Date: 23/02/2018 14:03:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Set](
	[id_set] [int] NOT NULL,
	[name_set] [nchar](20) NULL,
 CONSTRAINT [PK_Set] PRIMARY KEY CLUSTERED 
(
	[id_set] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Type_Media]    Script Date: 23/02/2018 14:03:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Type_Media](
	[id_type_media] [int] IDENTITY(1,1) NOT NULL,
	[label_type] [nchar](20) NOT NULL,
 CONSTRAINT [PK_Type_Media] PRIMARY KEY CLUSTERED 
(
	[id_type_media] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Type_Metier]    Script Date: 23/02/2018 14:03:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Type_Metier](
	[id_metier] [int] NOT NULL,
	[name_metier] [nchar](20) NULL,
 CONSTRAINT [PK_Type_Metier] PRIMARY KEY CLUSTERED 
(
	[id_metier] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Type_User]    Script Date: 23/02/2018 14:03:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Type_User](
	[id_type_user] [int] NOT NULL,
	[label_type_user] [nchar](20) NOT NULL,
 CONSTRAINT [PK_Type_User] PRIMARY KEY CLUSTERED 
(
	[id_type_user] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 23/02/2018 14:03:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[id_user] [int] NOT NULL,
	[password] [nchar](10) NOT NULL,
	[login] [nchar](10) NOT NULL,
	[id_type_user] [int] NOT NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[id_user] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Collection]  WITH CHECK ADD  CONSTRAINT [FK_Collection_Media] FOREIGN KEY([id_media])
REFERENCES [dbo].[Media] ([id_media])
GO
ALTER TABLE [dbo].[Collection] CHECK CONSTRAINT [FK_Collection_Media]
GO
ALTER TABLE [dbo].[Comment]  WITH CHECK ADD  CONSTRAINT [FK_Comment_Media] FOREIGN KEY([id_media])
REFERENCES [dbo].[Media] ([id_media])
GO
ALTER TABLE [dbo].[Comment] CHECK CONSTRAINT [FK_Comment_Media]
GO
ALTER TABLE [dbo].[Comment]  WITH CHECK ADD  CONSTRAINT [FK_Comment_User] FOREIGN KEY([id_user])
REFERENCES [dbo].[User] ([id_user])
GO
ALTER TABLE [dbo].[Comment] CHECK CONSTRAINT [FK_Comment_User]
GO
ALTER TABLE [dbo].[Exemplary]  WITH CHECK ADD  CONSTRAINT [FK_Exemplary_Media] FOREIGN KEY([id_media])
REFERENCES [dbo].[Media] ([id_media])
GO
ALTER TABLE [dbo].[Exemplary] CHECK CONSTRAINT [FK_Exemplary_Media]
GO
ALTER TABLE [dbo].[Media]  WITH CHECK ADD  CONSTRAINT [FK_Media_Genre] FOREIGN KEY([id_genre])
REFERENCES [dbo].[Genre] ([id_genre])
GO
ALTER TABLE [dbo].[Media] CHECK CONSTRAINT [FK_Media_Genre]
GO
ALTER TABLE [dbo].[Media]  WITH CHECK ADD  CONSTRAINT [FK_Media_Nationality] FOREIGN KEY([id_nationality])
REFERENCES [dbo].[Nationality] ([id_nationality])
GO
ALTER TABLE [dbo].[Media] CHECK CONSTRAINT [FK_Media_Nationality]
GO
ALTER TABLE [dbo].[Media]  WITH CHECK ADD  CONSTRAINT [FK_Media_Playlist] FOREIGN KEY([id_default_playlist])
REFERENCES [dbo].[Playlist] ([id_playlist])
GO
ALTER TABLE [dbo].[Media] CHECK CONSTRAINT [FK_Media_Playlist]
GO
ALTER TABLE [dbo].[Media]  WITH CHECK ADD  CONSTRAINT [FK_Media_Type_Media] FOREIGN KEY([id_type_media])
REFERENCES [dbo].[Type_Media] ([id_type_media])
GO
ALTER TABLE [dbo].[Media] CHECK CONSTRAINT [FK_Media_Type_Media]
GO
ALTER TABLE [dbo].[Media_Season]  WITH CHECK ADD  CONSTRAINT [FK_Media_Season_Media] FOREIGN KEY([id_media])
REFERENCES [dbo].[Media] ([id_media])
GO
ALTER TABLE [dbo].[Media_Season] CHECK CONSTRAINT [FK_Media_Season_Media]
GO
ALTER TABLE [dbo].[Media_Season]  WITH CHECK ADD  CONSTRAINT [FK_Media_Season_Season] FOREIGN KEY([id_season])
REFERENCES [dbo].[Season] ([id_season])
GO
ALTER TABLE [dbo].[Media_Season] CHECK CONSTRAINT [FK_Media_Season_Season]
GO
ALTER TABLE [dbo].[Parents]  WITH CHECK ADD  CONSTRAINT [FK_Parents_Person] FOREIGN KEY([id_person_parent])
REFERENCES [dbo].[Person] ([id_person])
GO
ALTER TABLE [dbo].[Parents] CHECK CONSTRAINT [FK_Parents_Person]
GO
ALTER TABLE [dbo].[Parents]  WITH CHECK ADD  CONSTRAINT [FK_Parents_Person_Child] FOREIGN KEY([id_person_parent])
REFERENCES [dbo].[Person] ([id_person])
GO
ALTER TABLE [dbo].[Parents] CHECK CONSTRAINT [FK_Parents_Person_Child]
GO
ALTER TABLE [dbo].[Person]  WITH CHECK ADD  CONSTRAINT [FK_Person_Nationality] FOREIGN KEY([id_nationality])
REFERENCES [dbo].[Nationality] ([id_nationality])
GO
ALTER TABLE [dbo].[Person] CHECK CONSTRAINT [FK_Person_Nationality]
GO
ALTER TABLE [dbo].[Person_Media]  WITH CHECK ADD  CONSTRAINT [FK_Metier_Media] FOREIGN KEY([id_media])
REFERENCES [dbo].[Media] ([id_media])
GO
ALTER TABLE [dbo].[Person_Media] CHECK CONSTRAINT [FK_Metier_Media]
GO
ALTER TABLE [dbo].[Person_Media]  WITH CHECK ADD  CONSTRAINT [FK_Metier_Person] FOREIGN KEY([id_person])
REFERENCES [dbo].[Person] ([id_person])
GO
ALTER TABLE [dbo].[Person_Media] CHECK CONSTRAINT [FK_Metier_Person]
GO
ALTER TABLE [dbo].[Person_Media]  WITH CHECK ADD  CONSTRAINT [FK_Metier_Type_Metier] FOREIGN KEY([id_metier])
REFERENCES [dbo].[Type_Metier] ([id_metier])
GO
ALTER TABLE [dbo].[Person_Media] CHECK CONSTRAINT [FK_Metier_Type_Metier]
GO
ALTER TABLE [dbo].[Playlist_Content]  WITH CHECK ADD  CONSTRAINT [FK_Playlist_Content_Media] FOREIGN KEY([id_media])
REFERENCES [dbo].[Media] ([id_media])
GO
ALTER TABLE [dbo].[Playlist_Content] CHECK CONSTRAINT [FK_Playlist_Content_Media]
GO
ALTER TABLE [dbo].[Playlist_Content]  WITH CHECK ADD  CONSTRAINT [FK_Playlist_Content_Playlist] FOREIGN KEY([id_playlist])
REFERENCES [dbo].[Playlist] ([id_playlist])
GO
ALTER TABLE [dbo].[Playlist_Content] CHECK CONSTRAINT [FK_Playlist_Content_Playlist]
GO
ALTER TABLE [dbo].[Playlist_Content]  WITH CHECK ADD  CONSTRAINT [FK_Playlist_Content_User] FOREIGN KEY([id_user])
REFERENCES [dbo].[User] ([id_user])
GO
ALTER TABLE [dbo].[Playlist_Content] CHECK CONSTRAINT [FK_Playlist_Content_User]
GO
ALTER TABLE [dbo].[Role]  WITH CHECK ADD  CONSTRAINT [FK_Role_Person_Media1] FOREIGN KEY([id_person_media])
REFERENCES [dbo].[Person_Media] ([id_person_media])
GO
ALTER TABLE [dbo].[Role] CHECK CONSTRAINT [FK_Role_Person_Media1]
GO
ALTER TABLE [dbo].[User]  WITH CHECK ADD  CONSTRAINT [FK_User_Type_User] FOREIGN KEY([id_type_user])
REFERENCES [dbo].[Type_User] ([id_type_user])
GO
ALTER TABLE [dbo].[User] CHECK CONSTRAINT [FK_User_Type_User]
GO
