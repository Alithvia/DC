USE [BootCamp1]
GO

/****** Object:  Table [dbo].[datVehicleCleaning]    Script Date: 3/12/2018 3:31:27 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[datVehicleCleaning](
	[CleaningID] [int] NOT NULL,
	[VehicleID] [int] NOT NULL,
	[PeopleID] [int] NOT NULL,
	[Date] [date] NOT NULL,
 CONSTRAINT [PK_datVehicleCleaning] PRIMARY KEY CLUSTERED 
(
	[CleaningID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[datVehicleCleaning]  WITH CHECK ADD  CONSTRAINT [FK_datVehicleCleaning_datVehicles] FOREIGN KEY([VehicleID])
REFERENCES [dbo].[datVehicles] ([VehicleID])
GO

ALTER TABLE [dbo].[datVehicleCleaning] CHECK CONSTRAINT [FK_datVehicleCleaning_datVehicles]
GO

