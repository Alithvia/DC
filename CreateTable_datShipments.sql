USE [BootCamp1]
GO

/****** Object:  Table [dbo].[datShipments]    Script Date: 3/12/2018 3:30:37 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[datShipments](
	[ShipmentID] [int] NOT NULL,
	[AddressID] [int] NOT NULL,
	[OrderNumber] [int] NOT NULL,
	[DateTime] [datetime] NOT NULL,
	[VehicleID] [int] NOT NULL,
	[PeopleID] [int] NOT NULL,
 CONSTRAINT [PK_dboShipments] PRIMARY KEY CLUSTERED 
(
	[ShipmentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[datShipments]  WITH CHECK ADD  CONSTRAINT [FK_datShipments_datCustomerOrders] FOREIGN KEY([OrderNumber])
REFERENCES [dbo].[datCustomerOrders] ([OrderNumber])
GO

ALTER TABLE [dbo].[datShipments] CHECK CONSTRAINT [FK_datShipments_datCustomerOrders]
GO

ALTER TABLE [dbo].[datShipments]  WITH CHECK ADD  CONSTRAINT [FK_datShipments_datVehicles] FOREIGN KEY([VehicleID])
REFERENCES [dbo].[datVehicles] ([VehicleID])
GO

ALTER TABLE [dbo].[datShipments] CHECK CONSTRAINT [FK_datShipments_datVehicles]
GO

