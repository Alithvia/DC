USE [SoS_Build]
GO

/****** Object:  Table [dbo].[luCities]    Script Date: 3/13/2018 6:02:35 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[luCities](
	[CityID] [int] IDENTITY(1,1) NOT NULL,
	[City] [nvarchar](20) NOT NULL,
	[Province] [nvarchar](2) NOT NULL,
 CONSTRAINT [PK_luCities] PRIMARY KEY CLUSTERED 
(
	[CityID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[luCities]  WITH CHECK ADD  CONSTRAINT [FK_luCities_luProvinces] FOREIGN KEY([Province])
REFERENCES [dbo].[luProvinces] ([ProvinceID])
GO

ALTER TABLE [dbo].[luCities] CHECK CONSTRAINT [FK_luCities_luProvinces]
GO


