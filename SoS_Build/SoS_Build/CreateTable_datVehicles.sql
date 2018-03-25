USE [SoS_Build]
GO

/****** Object:  Table [dbo].[datVehicles]    Script Date: 3/25/2018 8:59:06 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[datVehicles](
	[VehicleID] [int] IDENTITY(1,1) NOT NULL,
	[LicensePlate] [nvarchar](8) NOT NULL,
	[TypeID] [int] NOT NULL,
	[DatePurchased] [date] NOT NULL,
 CONSTRAINT [PK_dboVehicles] PRIMARY KEY CLUSTERED 
(
	[VehicleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[datVehicles]  WITH CHECK ADD  CONSTRAINT [FK_datVehicles_luVehicleTypes] FOREIGN KEY([TypeID])
REFERENCES [dbo].[luVehicleTypes] ([TypeID])
ON UPDATE CASCADE
GO

ALTER TABLE [dbo].[datVehicles] CHECK CONSTRAINT [FK_datVehicles_luVehicleTypes]
GO

