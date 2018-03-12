USE [BootCamp1]
GO

/****** Object:  Table [dbo].[datVehicleTypes]    Script Date: 3/12/2018 3:31:08 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[datVehicleTypes](
	[TypeID] [int] NOT NULL,
	[Description] [varchar](30) NOT NULL,
 CONSTRAINT [PK_dboVehicleTypes] PRIMARY KEY CLUSTERED 
(
	[TypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

