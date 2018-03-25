USE [SoS_Build]
GO

/****** Object:  Table [dbo].[datAddresses]    Script Date: 3/25/2018 8:55:19 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[datAddresses](
	[AddressID] [int] IDENTITY(1,1) NOT NULL,
	[Address] [nvarchar](50) NOT NULL,
	[CityID] [int] NOT NULL,
 CONSTRAINT [PK_datAddresses] PRIMARY KEY CLUSTERED 
(
	[AddressID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[datAddresses]  WITH CHECK ADD  CONSTRAINT [FK_datAddresses_luCities] FOREIGN KEY([CityID])
REFERENCES [dbo].[luCities] ([CityID])
ON UPDATE CASCADE
GO

ALTER TABLE [dbo].[datAddresses] CHECK CONSTRAINT [FK_datAddresses_luCities]
GO

