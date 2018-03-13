USE [SoS_Build]
GO

/****** Object:  Table [dbo].[datAddresses]    Script Date: 3/13/2018 6:03:40 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[datAddresses](
	[AddressID] [int] IDENTITY(1,1) NOT NULL,
	[Address] [nvarchar](50) NOT NULL,
	[City] [nvarchar](30) NOT NULL,
	[Province] [nvarchar](2) NULL,
	[Country] [nvarchar](2) NULL,
 CONSTRAINT [PK_datAddresses] PRIMARY KEY CLUSTERED 
(
	[AddressID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


