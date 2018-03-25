USE [SoS_Build]
GO

/****** Object:  Table [dbo].[jncPurchaseOrders]    Script Date: 3/25/2018 9:01:07 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[jncPurchaseOrders](
	[PurchaseOrderID] [int] IDENTITY(1,1) NOT NULL,
	[SupplierID] [int] NOT NULL,
	[ProductID] [int] NOT NULL,
 CONSTRAINT [PK_datPurchaseOrders] PRIMARY KEY CLUSTERED 
(
	[PurchaseOrderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[jncPurchaseOrders]  WITH CHECK ADD  CONSTRAINT [FK_jncPurchaseOrders_datSuppliers] FOREIGN KEY([SupplierID])
REFERENCES [dbo].[datSuppliers] ([SupplierID])
ON UPDATE CASCADE
GO

ALTER TABLE [dbo].[jncPurchaseOrders] CHECK CONSTRAINT [FK_jncPurchaseOrders_datSuppliers]
GO

ALTER TABLE [dbo].[jncPurchaseOrders]  WITH CHECK ADD  CONSTRAINT [FK_jncPurchaseOrders_luProducts] FOREIGN KEY([ProductID])
REFERENCES [dbo].[luProducts] ([ProductID])
ON UPDATE CASCADE
GO

ALTER TABLE [dbo].[jncPurchaseOrders] CHECK CONSTRAINT [FK_jncPurchaseOrders_luProducts]
GO

