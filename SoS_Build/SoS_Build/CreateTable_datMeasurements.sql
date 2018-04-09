USE [SoS_Build]
GO

/****** Object:  Table [dbo].[datMeasurements]    Script Date: 4/2/2018 1:34:28 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[datMeasurements](
	[MeasurementID] [int] IDENTITY(1,1) NOT NULL,
	[ParentID] [int] NOT NULL,
	[DateTime] [datetime] NOT NULL,
	[Thickness] [float] NOT NULL,
	[Weight] [float] NOT NULL,
	[Length] [float] NOT NULL,
	[Width] [float] NOT NULL,
	[Employee] [int] NOT NULL,
 CONSTRAINT [PK_datMeasurements] PRIMARY KEY CLUSTERED 
(
	[MeasurementID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


