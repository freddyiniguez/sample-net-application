USE [BIOS_TESTING]
GO

/****** Object:  Table [dbo].[Tb_BIOS_Candidates]    Script Date: 7/2/2019 9:46:49 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Tb_BIOS_Candidates](
	[IdCandidate] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](100) NOT NULL,
	[SecondName] [varchar](100) NULL,
	[LastName] [varchar](100) NOT NULL,
	[SecondLastName] [varchar](100) NULL,
	[ShortName] [varchar](100) NOT NULL,
	[BirthDate] [date] NOT NULL,
	[Email] [varchar](100) NOT NULL,
	[Phone] [varchar](10) NOT NULL,
	[Cellphone] [varchar](10) NOT NULL,
	[FOJ] [int] NULL,
	[Location] [int] NULL,
	[Site] [int] NULL,
	[Market] [int] NULL,
	[Hashtag] [varchar](max) NULL,
	[Active] [bit] NOT NULL,
 CONSTRAINT [PK_Tb_BIOS_Candidates] PRIMARY KEY CLUSTERED 
(
	[IdCandidate] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

