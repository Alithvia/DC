USE [SoS_Build]
GO

/****** Object:  Table [dbo].[luProvinces]    Script Date: 2/19/2018 10:27:35 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[luProvinces](
	[ProvinceCode] [nvarchar](2) NOT NULL,
	[ProvinceName] [nvarchar](25) NOT NULL,
 CONSTRAINT [PK_luProvinces] PRIMARY KEY CLUSTERED 
(
	[ProvinceCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


