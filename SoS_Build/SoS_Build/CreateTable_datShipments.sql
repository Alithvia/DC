USE [SoS_Build]
GO

/****** Object:  Table [dbo].[datShipments]    Script Date: 3/25/2018 8:58:09 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[datShipments](
	[ShipmentID] [int] IDENTITY(1,1) NOT NULL,
	[AddressID] [int] NOT NULL,
	[OrderNumber] [int] NOT NULL,
	[VehicleID] [int] NOT NULL,
 CONSTRAINT [PK_dboShipments] PRIMARY KEY CLUSTERED 
(
	[ShipmentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[datShipments]  WITH CHECK ADD  CONSTRAINT [FK_datShipments_datAddresses] FOREIGN KEY([AddressID])
REFERENCES [dbo].[datAddresses] ([AddressID])
ON UPDATE CASCADE
GO

ALTER TABLE [dbo].[datShipments] CHECK CONSTRAINT [FK_datShipments_datAddresses]
GO

ALTER TABLE [dbo].[datShipments]  WITH CHECK ADD  CONSTRAINT [FK_datShipments_datCustomerOrders] FOREIGN KEY([OrderNumber])
REFERENCES [dbo].[datClientOrders] ([OrderNumber])
ON UPDATE CASCADE
GO

ALTER TABLE [dbo].[datShipments] CHECK CONSTRAINT [FK_datShipments_datCustomerOrders]
GO

ALTER TABLE [dbo].[datShipments]  WITH CHECK ADD  CONSTRAINT [FK_datShipments_datVehicles] FOREIGN KEY([VehicleID])
REFERENCES [dbo].[datVehicles] ([VehicleID])
ON UPDATE CASCADE
GO

ALTER TABLE [dbo].[datShipments] CHECK CONSTRAINT [FK_datShipments_datVehicles]
GO

