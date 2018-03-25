USE [SoS_Build]
GO

/****** Object:  Table [dbo].[datVehicleCleaning]    Script Date: 3/25/2018 8:58:54 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[datVehicleCleaning](
	[CleaningID] [int] IDENTITY(1,1) NOT NULL,
	[VehicleID] [int] NOT NULL,
	[EmployeeID] [int] NOT NULL,
	[Date] [date] NOT NULL,
 CONSTRAINT [PK_datVehicleCleaning] PRIMARY KEY CLUSTERED 
(
	[CleaningID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[datVehicleCleaning]  WITH CHECK ADD  CONSTRAINT [FK_datVehicleCleaning_datEmployees] FOREIGN KEY([EmployeeID])
REFERENCES [dbo].[datEmployees] ([EmployeeID])
ON UPDATE CASCADE
GO

ALTER TABLE [dbo].[datVehicleCleaning] CHECK CONSTRAINT [FK_datVehicleCleaning_datEmployees]
GO

ALTER TABLE [dbo].[datVehicleCleaning]  WITH CHECK ADD  CONSTRAINT [FK_datVehicleCleaning_datVehicles] FOREIGN KEY([VehicleID])
REFERENCES [dbo].[datVehicles] ([VehicleID])
ON UPDATE CASCADE
GO

ALTER TABLE [dbo].[datVehicleCleaning] CHECK CONSTRAINT [FK_datVehicleCleaning_datVehicles]
GO

