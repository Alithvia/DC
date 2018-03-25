USE [SoS_Build]
GO

/****** Object:  Table [dbo].[luProvinces]    Script Date: 3/25/2018 9:03:36 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[luProvinces](
	[ProvinceCode] [nvarchar](2) NOT NULL,
	[ProvinceName] [nvarchar](25) NOT NULL,
	[CountryCode] [nvarchar](2) NOT NULL,
 CONSTRAINT [PK_luProvinces] PRIMARY KEY CLUSTERED 
(
	[ProvinceCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[luProvinces]  WITH CHECK ADD  CONSTRAINT [FK_luProvinces_luCountries] FOREIGN KEY([CountryCode])
REFERENCES [dbo].[luCountries] ([CountryCode])
ON UPDATE CASCADE
GO

ALTER TABLE [dbo].[luProvinces] CHECK CONSTRAINT [FK_luProvinces_luCountries]
GO

