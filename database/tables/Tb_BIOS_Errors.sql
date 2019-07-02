USE [BIOS_TESTING]
GO

/****** Object:  Table [dbo].[Tb_BIOS_Errors]    Script Date: 7/2/2019 9:46:59 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Tb_BIOS_Errors](
	[IdError] [int] IDENTITY(1,1) NOT NULL,
	[ErrorNumber] [int] NOT NULL,
	[ErrorSeverity] [int] NOT NULL,
	[ErrorState] [int] NOT NULL,
	[ErrorProcedure] [varchar](max) NOT NULL,
	[ErrorLine] [int] NOT NULL,
	[ErrorMessage] [varchar](max) NOT NULL,
	[ErrorMessageUser] [varchar](max) NOT NULL,
	[FechaRegistro] [datetime] NULL,
 CONSTRAINT [PK_Tb_BIOS_Errors] PRIMARY KEY CLUSTERED 
(
	[IdError] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

