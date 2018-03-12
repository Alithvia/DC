USE [BootCamp1]
GO

/****** Object:  Table [dbo].[datVehicles]    Script Date: 3/12/2018 3:30:54 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[datVehicles](
	[VehicleID] [int] NOT NULL,
	[LicensePlate] [varchar](8) NOT NULL,
	[TypeID] [int] NOT NULL,
	[DatePurchased] [datetime] NOT NULL,
 CONSTRAINT [PK_dboVehicles] PRIMARY KEY CLUSTERED 
(
	[VehicleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[datVehicles]  WITH CHECK ADD  CONSTRAINT [FK_datVehicles_datVehicleTypes] FOREIGN KEY([TypeID])
REFERENCES [dbo].[datVehicleTypes] ([TypeID])
GO

ALTER TABLE [dbo].[datVehicles] CHECK CONSTRAINT [FK_datVehicles_datVehicleTypes]
GO

