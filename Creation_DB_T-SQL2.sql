CREATE TABLE [dbo].[User] (
	[id_user] INT IDENTITY (0, 1) NOT NULL,
    [login] NVARCHAR (20) NOT NULL,
	[password] NVARCHAR (20) NOT NULL,
	[id_type_user] INT NOT NULL,
    CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED ([id_user] ASC),
	CONSTRAINT [FK_User_Type_User] FOREIGN KEY ([id_type_user]) REFERENCES [dbo].[Type_User] ([id_type_user])
);

CREATE TABLE [dbo].[Person] (
	[id_person] INT IDENTITY (1, 1) NOT NULL,
    [name_person] NVARCHAR (30) NOT NULL,
	[first_name_person] NVARCHAR (30) NOT NULL,
	[birth_date] DATE NULL,
	[death_date] DATE NULL,
	[id_nationality] INT NULL,
	[id_cover] INT NULL,
    CONSTRAINT [PK_Person] PRIMARY KEY CLUSTERED ([id_person] ASC),
	CONSTRAINT [FK_Person_Nationality] FOREIGN KEY ([id_nationality]) REFERENCES [dbo].[Nationality] ([id_nationality]),
	CONSTRAINT [FK_Person_Cover] FOREIGN KEY ([id_cover]) REFERENCES [dbo].[Cover] ([id_cover])
);

CREATE TABLE [dbo].[Serie] (
	[id_serie] INT IDENTITY (1, 1) NOT NULL,
    [name_serie] NVARCHAR (30) NOT NULL,
	[id_cover] INT NULL,
	[id_type_media] INT NULL,
	[id_synopsis] INT NULL,
    CONSTRAINT [PK_Serie] PRIMARY KEY CLUSTERED ([id_serie] ASC),
	CONSTRAINT [FK_Serie_Cover] FOREIGN KEY ([id_cover]) REFERENCES [dbo].[Cover] ([id_cover]),
	CONSTRAINT [FK_Serie_Type_Media] FOREIGN KEY ([id_type_media]) REFERENCES [dbo].[Type_Media] ([id_type_media]),
	CONSTRAINT [FK_Serie_Synopsis] FOREIGN KEY ([id_synopsis]) REFERENCES [dbo].[Synopsis] ([id_synopsis])
);

CREATE TABLE [dbo].[Playlist] (
	[id_playlist] INT IDENTITY (1, 1) NOT NULL,
    [login] NVARCHAR (20) NOT NULL,
	[password] NVARCHAR (20) NOT NULL,
	[id_user] INT NOT NULL,
    CONSTRAINT [PK_Playlist] PRIMARY KEY CLUSTERED ([id_playlist] ASC),
	CONSTRAINT [FK_Playlist_User] FOREIGN KEY ([id_user]) REFERENCES [dbo].[User] ([id_user])
);

CREATE TABLE [dbo].[Season] (
	[id_season] INT IDENTITY (1, 1) NOT NULL,
    [name_season] NCHAR (10) NOT NULL,
	[numero_season] INT NOT NULL,
	[id_serie] INT NULL,
	[id_cover] INT NULL,
    CONSTRAINT [PK_Season] PRIMARY KEY CLUSTERED ([id_season] ASC),
	CONSTRAINT [FK_Season_Serie] FOREIGN KEY ([id_serie]) REFERENCES [dbo].[Serie] ([id_serie]),
	CONSTRAINT [FK_Season_Cover] FOREIGN KEY ([id_cover]) REFERENCES [dbo].[Cover] ([id_cover])
);

CREATE TABLE [dbo].[Serie_Genre] (
	[id_serie] INT NOT NULL,
	[id_genre] INT NOT NULL,
    CONSTRAINT [PK_Serie_Genre] PRIMARY KEY CLUSTERED ([id_serie] ASC, [id_genre] ASC)
);

CREATE TABLE [dbo].[User_Playlist] (
	[id_user_playlist] INT IDENTITY (1, 1) NOT NULL,
    [index_user_playlist] INT NOT NULL,
	[id_user] INT NOT NULL,
	[id_playlist] INT NOT NULL,
    CONSTRAINT [PK_User_Playlist] PRIMARY KEY CLUSTERED ([id_user_playlist] ASC),
	CONSTRAINT [FK_User_Playlist_User] FOREIGN KEY ([id_user]) REFERENCES [dbo].[User] ([id_user]),
	CONSTRAINT [FK_User_Playlist_Playlist] FOREIGN KEY ([id_playlist]) REFERENCES [dbo].[Playlist] ([id_playlist])
);

CREATE TABLE [dbo].[Media] (
	[id_media] INT IDENTITY (1, 1) NOT NULL,
	[title_VO] NVARCHAR (50) NOT NULL,
    [title_VF] NVARCHAR (20) NULL,
	[release_date] DATE NULL,
	[release_year] INT NULL,
	[id_cover] INT NULL,
	[id_type_media] INT NULL,
	[id_synopsis] INT NULL,
	[id_season] INT NULL,
    CONSTRAINT [PK_Media] PRIMARY KEY CLUSTERED ([id_media] ASC),
	CONSTRAINT [FK_Media_Cover] FOREIGN KEY ([id_cover]) REFERENCES [dbo].[Cover] ([id_cover]),
	CONSTRAINT [FK_Media_Type_Media] FOREIGN KEY ([id_type_media]) REFERENCES [dbo].[Type_Media] ([id_type_media]),
	CONSTRAINT [FK_Media_Synopsis] FOREIGN KEY ([id_synopsis]) REFERENCES [dbo].[Synopsis] ([id_synopsis]),
	CONSTRAINT [FK_Media_Season] FOREIGN KEY ([id_season]) REFERENCES [dbo].[Season] ([id_season])
);

CREATE TABLE [dbo].[Posseder] (
	[id_posseder] INT IDENTITY (1,1) NOT NULL,
	[id_media] INT NOT NULL,
	[id_exemplary] INT NOT NULL,
	[id_format] INT NOT NULL,
	[id_format_numeric] INT NULL,
    CONSTRAINT [PK_Posseder] PRIMARY KEY CLUSTERED ([id_posseder] ASC),
	CONSTRAINT [AK_Posseder] UNIQUE ([id_media], [id_exemplary], [id_format], [id_format_numeric])
);

CREATE TABLE [dbo].[Media_Playlist] (
	[id_media] INT NOT NULL,
	[id_playlist] INT NOT NULL,
	[index_media_playlist] INT NOT NULL,
    CONSTRAINT [PK_Media_Playlist] PRIMARY KEY CLUSTERED ([id_media] ASC, [id_playlist] ASC)
);

CREATE TABLE [dbo].[Comment] (
	[id_media] INT NOT NULL,
	[id_user] INT NOT NULL,
	[text_comment] TEXT NULL,
	[note] INT NOT NULL,
    CONSTRAINT [PK_Comment] PRIMARY KEY CLUSTERED ([id_media] ASC, [id_user] ASC)
);

CREATE TABLE [dbo].[Origin] (
	[id_media] INT NOT NULL,
	[id_nationality] INT NOT NULL,
    CONSTRAINT [PK_Origin] PRIMARY KEY CLUSTERED ([id_media] ASC, [id_nationality] ASC)
);

CREATE TABLE [dbo].[Participant] (
	[id_media] INT NOT NULL,
	[id_person] INT NOT NULL,
	[id_job] INT NOT NULL,
	[role] NVARCHAR (50) NULL,
    CONSTRAINT [PK_Participant] PRIMARY KEY CLUSTERED ([id_media] ASC, [id_person] ASC,[id_job] ASC)
);

CREATE TABLE [dbo].[Media_Genre] (
	[id_media] INT NOT NULL,
	[id_genre] INT NOT NULL,
    CONSTRAINT [PK_Media_Genre] PRIMARY KEY CLUSTERED ([id_media] ASC, [id_genre] ASC)
);
