USE [telBookBase]
GO
/****** Object:  Table [dbo].[Role]    Script Date: 04/28/2012 13:22:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Role](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nimetus] [nvarchar](20) NOT NULL,
	[Kirjedus] [nvarchar](50) NULL,
 CONSTRAINT [PK_Roll] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Role] ON
INSERT [dbo].[Role] ([ID], [Nimetus], [Kirjedus]) VALUES (1, N'Kasutaja', N'lohh user')
INSERT [dbo].[Role] ([ID], [Nimetus], [Kirjedus]) VALUES (2, N'Admin', N'Olen admin')
SET IDENTITY_INSERT [dbo].[Role] OFF
/****** Object:  Table [dbo].[User]    Script Date: 04/28/2012 13:22:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[User](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Username] [varchar](12) NOT NULL,
	[Password] [varchar](15) NOT NULL,
	[E-mail] [varchar](50) NOT NULL,
	[Loodud] [smalldatetime] NOT NULL,
	[Muudetud] [smalldatetime] NULL,
	[Kustutatud] [smalldatetime] NULL,
	[Role_fk] [int] NOT NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Contact]    Script Date: 04/28/2012 13:22:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Contact](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Eesnimi] [nvarchar](50) NOT NULL,
	[Perenimi] [nvarchar](50) NOT NULL,
	[Telefon] [nvarchar](50) NULL,
	[E-mail] [nvarchar](50) NULL,
	[Skype] [nvarchar](50) NULL,
	[Aadress] [nvarchar](50) NULL,
	[Loodud] [smalldatetime] NOT NULL,
	[Muudetud] [smalldatetime] NULL,
	[Kustutatud] [smalldatetime] NULL,
	[User_fk] [int] NOT NULL,
 CONSTRAINT [PK_Contact] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[JagatudContact]    Script Date: 04/28/2012 13:22:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[JagatudContact](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ContactID] [int] NOT NULL,
	[UserID] [int] NOT NULL,
	[AlgusKP] [smalldatetime] NOT NULL,
	[LoppKP] [smalldatetime] NULL,
 CONSTRAINT [PK_JagatudContact] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Default [DF_User_Role_fk]    Script Date: 04/28/2012 13:22:51 ******/
ALTER TABLE [dbo].[User] ADD  CONSTRAINT [DF_User_Role_fk]  DEFAULT ((1)) FOR [Role_fk]
GO
/****** Object:  ForeignKey [FK_Contact_User]    Script Date: 04/28/2012 13:22:51 ******/
ALTER TABLE [dbo].[Contact]  WITH CHECK ADD  CONSTRAINT [FK_Contact_User] FOREIGN KEY([User_fk])
REFERENCES [dbo].[User] ([ID])
GO
ALTER TABLE [dbo].[Contact] CHECK CONSTRAINT [FK_Contact_User]
GO
/****** Object:  ForeignKey [FK_JagatudContact_Contact]    Script Date: 04/28/2012 13:22:51 ******/
ALTER TABLE [dbo].[JagatudContact]  WITH CHECK ADD  CONSTRAINT [FK_JagatudContact_Contact] FOREIGN KEY([ContactID])
REFERENCES [dbo].[Contact] ([ID])
GO
ALTER TABLE [dbo].[JagatudContact] CHECK CONSTRAINT [FK_JagatudContact_Contact]
GO
/****** Object:  ForeignKey [FK_JagatudContact_User]    Script Date: 04/28/2012 13:22:51 ******/
ALTER TABLE [dbo].[JagatudContact]  WITH CHECK ADD  CONSTRAINT [FK_JagatudContact_User] FOREIGN KEY([UserID])
REFERENCES [dbo].[User] ([ID])
GO
ALTER TABLE [dbo].[JagatudContact] CHECK CONSTRAINT [FK_JagatudContact_User]
GO
/****** Object:  ForeignKey [FK_User_Role]    Script Date: 04/28/2012 13:22:51 ******/
ALTER TABLE [dbo].[User]  WITH CHECK ADD  CONSTRAINT [FK_User_Role] FOREIGN KEY([Role_fk])
REFERENCES [dbo].[Role] ([ID])
GO
ALTER TABLE [dbo].[User] CHECK CONSTRAINT [FK_User_Role]
GO
