USE [SoS_Build]
GO

/****** Object:  Table [dbo].[luCities]    Script Date: 3/25/2018 9:02:19 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[luCities](
	[CityID] [int] IDENTITY(1,1) NOT NULL,
	[City] [nvarchar](35) NOT NULL,
	[ProvinceCode] [nvarchar](2) NOT NULL,
 CONSTRAINT [PK_luCities] PRIMARY KEY CLUSTERED 
(
	[CityID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[luCities]  WITH CHECK ADD  CONSTRAINT [FK_luCities_luProvinces] FOREIGN KEY([ProvinceCode])
REFERENCES [dbo].[luProvinces] ([ProvinceCode])
ON UPDATE CASCADE
GO

ALTER TABLE [dbo].[luCities] CHECK CONSTRAINT [FK_luCities_luProvinces]
GO

