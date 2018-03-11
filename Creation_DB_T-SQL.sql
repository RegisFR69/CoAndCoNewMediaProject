CREATE TABLE [dbo].[Format] (
	[id_format] INT IDENTITY (1, 1) NOT NULL,
    [name_format] NVARCHAR (20) NOT NULL,
    CONSTRAINT [PK_Format] PRIMARY KEY CLUSTERED ([id_format] ASC)
);
SET IDENTITY_INSERT [dbo].[Format] ON
INSERT INTO [dbo].[Format] ([id_format], [name_format]) VALUES (1, N'DVD')
INSERT INTO [dbo].[Format] ([id_format], [name_format]) VALUES (2, N'CD')
INSERT INTO [dbo].[Format] ([id_format], [name_format]) VALUES (3, N'Blu ray')
INSERT INTO [dbo].[Format] ([id_format], [name_format]) VALUES (4, N'Blu ray 4k')
INSERT INTO [dbo].[Format] ([id_format], [name_format]) VALUES (5, N'Blu ray 3D')
INSERT INTO [dbo].[Format] ([id_format], [name_format]) VALUES (6, N'Numérique')
INSERT INTO [dbo].[Format] ([id_format], [name_format]) VALUES (7, N'Poche')
INSERT INTO [dbo].[Format] ([id_format], [name_format]) VALUES (8, N'Roman')
INSERT INTO [dbo].[Format] ([id_format], [name_format]) VALUES (9, N'Mangas')
INSERT INTO [dbo].[Format] ([id_format], [name_format]) VALUES (10, N'Comics')
INSERT INTO [dbo].[Format] ([id_format], [name_format]) VALUES (11, N'Grand format')
INSERT INTO [dbo].[Format] ([id_format], [name_format]) VALUES (12, N'Numérique')
INSERT INTO [dbo].[Format] ([id_format], [name_format]) VALUES (13, N'14cm x 22cm')
SET IDENTITY_INSERT [dbo].[Format] OFF

CREATE TABLE [dbo].[Type_User] (
    [id_type_user] INT IDENTITY (0, 1) NOT NULL,
    [label_type_user] NVARCHAR (10) NOT NULL,
    CONSTRAINT [PK_Type_User] PRIMARY KEY CLUSTERED ([id_type_user] ASC)
);
SET IDENTITY_INSERT [dbo].[Type_User] ON
INSERT INTO [dbo].[Type_User] ([id_type_user], [label_type_user]) VALUES (0, N'user')
INSERT INTO [dbo].[Type_User] ([id_type_user], [label_type_user]) VALUES (1, N'member')
INSERT INTO [dbo].[Type_User] ([id_type_user], [label_type_user]) VALUES (2, N'admin')
INSERT INTO [dbo].[Type_User] ([id_type_user], [label_type_user]) VALUES (3, N'superAdmin')
SET IDENTITY_INSERT [dbo].[Type_User] OFF

CREATE TABLE [dbo].[Job] (
    [id_job] INT IDENTITY (1, 1) NOT NULL,
    [label_job] NVARCHAR (20) NOT NULL,
    CONSTRAINT [PK_Job] PRIMARY KEY CLUSTERED ([id_job] ASC)
);

SET IDENTITY_INSERT [dbo].[Job] ON
INSERT INTO [dbo].[Job] ([id_job], [label_job]) VALUES (1, N'Acteur')
INSERT INTO [dbo].[Job] ([id_job], [label_job]) VALUES (2, N'Scénariste')
INSERT INTO [dbo].[Job] ([id_job], [label_job]) VALUES (3, N'Réalisateur')
INSERT INTO [dbo].[Job] ([id_job], [label_job]) VALUES (4, N'Compositeur')
INSERT INTO [dbo].[Job] ([id_job], [label_job]) VALUES (5, N'Producteur')
INSERT INTO [dbo].[Job] ([id_job], [label_job]) VALUES (6, N'Auteur')
INSERT INTO [dbo].[Job] ([id_job], [label_job]) VALUES (7, N'Illustrateur')
INSERT INTO [dbo].[Job] ([id_job], [label_job]) VALUES (8, N'Interprète')
SET IDENTITY_INSERT [dbo].[Job] OFF

CREATE TABLE [dbo].[Genre] (
    [id_genre] INT IDENTITY (1, 1) NOT NULL,
    [name_genre] NCHAR (20) NOT NULL,
    CONSTRAINT [PK_Genre] PRIMARY KEY CLUSTERED ([id_genre] ASC)
);

SET IDENTITY_INSERT [dbo].[Genre] ON
INSERT INTO [dbo].[Genre] ([id_genre], [name_genre]) VALUES (1, N'Drame')
INSERT INTO [dbo].[Genre] ([id_genre], [name_genre]) VALUES (2, N'Animation')
INSERT INTO [dbo].[Genre] ([id_genre], [name_genre]) VALUES (3, N'Fantastique')
INSERT INTO [dbo].[Genre] ([id_genre], [name_genre]) VALUES (4, N'Comédie dramatique')
INSERT INTO [dbo].[Genre] ([id_genre], [name_genre]) VALUES (5, N'Romance')
INSERT INTO [dbo].[Genre] ([id_genre], [name_genre]) VALUES (6, N'Policier')
INSERT INTO [dbo].[Genre] ([id_genre], [name_genre]) VALUES (7, N'Western')
INSERT INTO [dbo].[Genre] ([id_genre], [name_genre]) VALUES (8, N'Musical')
INSERT INTO [dbo].[Genre] ([id_genre], [name_genre]) VALUES (9, N'Historic')
INSERT INTO [dbo].[Genre] ([id_genre], [name_genre]) VALUES (10, N'Biopic')
INSERT INTO [dbo].[Genre] ([id_genre], [name_genre]) VALUES (11, N'Guerre')
INSERT INTO [dbo].[Genre] ([id_genre], [name_genre]) VALUES (12, N'Thriller')
INSERT INTO [dbo].[Genre] ([id_genre], [name_genre]) VALUES (13, N'Aventure')
INSERT INTO [dbo].[Genre] ([id_genre], [name_genre]) VALUES (14, N'Science fiction')
SET IDENTITY_INSERT [dbo].[Genre] OFF

CREATE TABLE [dbo].[Type_Media] (
    [id_type_media] INT IDENTITY (1, 1) NOT NULL,
    [label_type_media] NCHAR (5) NOT NULL,
    CONSTRAINT [PK_Type_Media] PRIMARY KEY CLUSTERED ([id_type_media] ASC)
);
SET IDENTITY_INSERT [dbo].[Type_Media] ON
INSERT INTO [dbo].[Type_Media] ([id_type_media], [label_type_media]) VALUES (1, N'Film')
INSERT INTO [dbo].[Type_Media] ([id_type_media], [label_type_media]) VALUES (2, N'Serie')
INSERT INTO [dbo].[Type_Media] ([id_type_media], [label_type_media]) VALUES (3, N'BD')
INSERT INTO [dbo].[Type_Media] ([id_type_media], [label_type_media]) VALUES (4, N'Livre')
INSERT INTO [dbo].[Type_Media] ([id_type_media], [label_type_media]) VALUES (5, N'Audio')
SET IDENTITY_INSERT [dbo].[Type_Media] OFF

CREATE TABLE [dbo].[Format_Numeric] (
    [id_format_numeric] INT IDENTITY (1, 1) NOT NULL,
    [label_format_numeric] NCHAR (4) NOT NULL,
    CONSTRAINT [PK_Format_Numeric] PRIMARY KEY CLUSTERED ([id_format_numeric] ASC)
);
SET IDENTITY_INSERT [dbo].[Format_Numeric] ON
INSERT INTO [dbo].[Format_Numeric] ([id_format_numeric], [label_format_numeric]) VALUES (1, N'avi')
INSERT INTO [dbo].[Format_Numeric] ([id_format_numeric], [label_format_numeric]) VALUES (2, N'jpg')
INSERT INTO [dbo].[Format_Numeric] ([id_format_numeric], [label_format_numeric]) VALUES (3, N'pdf')
INSERT INTO [dbo].[Format_Numeric] ([id_format_numeric], [label_format_numeric]) VALUES (4, N'mkv')
INSERT INTO [dbo].[Format_Numeric] ([id_format_numeric], [label_format_numeric]) VALUES (5, N'mp4')
INSERT INTO [dbo].[Format_Numeric] ([id_format_numeric], [label_format_numeric]) VALUES (6, N'mp3')
INSERT INTO [dbo].[Format_Numeric] ([id_format_numeric], [label_format_numeric]) VALUES (7, N'ogg')
INSERT INTO [dbo].[Format_Numeric] ([id_format_numeric], [label_format_numeric]) VALUES (8, N'wmv')
INSERT INTO [dbo].[Format_Numeric] ([id_format_numeric], [label_format_numeric]) VALUES (9, N'wma')
INSERT INTO [dbo].[Format_Numeric] ([id_format_numeric], [label_format_numeric]) VALUES (10, N'jpeg')
SET IDENTITY_INSERT [dbo].[Format_Numeric] OFF

CREATE TABLE [dbo].[Nationality] (
    [id_nationality] INT IDENTITY (1, 1) NOT NULL,
    [label_nationality] NVARCHAR (20) NOT NULL,
	[code_nationality_ISO_3166-1] NCHAR (2) NOT NULL,
    CONSTRAINT [PK_Nationality] PRIMARY KEY CLUSTERED ([id_nationality] ASC)
);
SET IDENTITY_INSERT [dbo].[Nationality] ON
INSERT INTO [dbo].[Nationality] ([id_nationality], [label_nationality], [code_nationality_ISO_3166-1]) VALUES (1, N'Français', N'FR')
INSERT INTO [dbo].[Nationality] ([id_nationality], [label_nationality], [code_nationality_ISO_3166-1]) VALUES (2, N'Américain', N'US')
INSERT INTO [dbo].[Nationality] ([id_nationality], [label_nationality], [code_nationality_ISO_3166-1]) VALUES (3, N'Allemand', N'DE')
INSERT INTO [dbo].[Nationality] ([id_nationality], [label_nationality], [code_nationality_ISO_3166-1]) VALUES (4, N'Britannique', N'GB')
INSERT INTO [dbo].[Nationality] ([id_nationality], [label_nationality], [code_nationality_ISO_3166-1]) VALUES (5, N'Australien', N'AU')
INSERT INTO [dbo].[Nationality] ([id_nationality], [label_nationality], [code_nationality_ISO_3166-1]) VALUES (6, N'Italien', N'IT')
INSERT INTO [dbo].[Nationality] ([id_nationality], [label_nationality], [code_nationality_ISO_3166-1]) VALUES (7, N'Polonais', N'PL')
INSERT INTO [dbo].[Nationality] ([id_nationality], [label_nationality], [code_nationality_ISO_3166-1]) VALUES (8, N'Belge', N'BE')
INSERT INTO [dbo].[Nationality] ([id_nationality], [label_nationality], [code_nationality_ISO_3166-1]) VALUES (9, N'Espagnol', N'ES')
INSERT INTO [dbo].[Nationality] ([id_nationality], [label_nationality], [code_nationality_ISO_3166-1]) VALUES (10, N'Indien', N'IN')
SET IDENTITY_INSERT [dbo].[Nationality] OFF

CREATE TABLE [dbo].[Cover] (
	[id_cover]  INT IDENTITY (1, 1) NOT NULL,
    [path_cover] NCHAR (100) NOT NULL,
    CONSTRAINT [PK_Cover] PRIMARY KEY CLUSTERED ([id_cover] ASC)
);
CREATE TABLE [dbo].[Synopsis] (
	[id_synopsis]  INT IDENTITY (1, 1) NOT NULL,
    [text_synopsis] TEXT NOT NULL,
    CONSTRAINT [PK_Synopsis] PRIMARY KEY CLUSTERED ([id_synopsis] ASC)
);
CREATE TABLE [dbo].[Exemplary] (
	[id_exemplary]  INT IDENTITY (1, 1) NOT NULL,
    [name_exemplary] NCHAR (50) NOT NULL,
	[path_exemplary] NCHAR (100) NOT NULL,
    CONSTRAINT [PK_Exemplary] PRIMARY KEY CLUSTERED ([id_exemplary] ASC)
);


