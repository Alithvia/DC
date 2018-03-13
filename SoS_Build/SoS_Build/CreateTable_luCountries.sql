USE [SoS_Build]
GO

/****** Object:  Table [dbo].[luCountries]    Script Date: 3/13/2018 6:10:27 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[luCountries](
	[CountryCode] [nvarchar](2) NOT NULL,
	[CountryName] [nvarchar](13) NOT NULL,
 CONSTRAINT [PK_luCountries] PRIMARY KEY CLUSTERED 
(
	[CountryCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


