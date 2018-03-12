USE [BootCamp1]
GO

/****** Object:  Table [dbo].[datPurchaseOrders]    Script Date: 3/12/2018 3:33:19 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[datPurchaseOrders](
	[PurchaseOrderID] [int] NOT NULL,
	[SupplierPriceID] [int] NOT NULL,
	[Quantity] [int] NULL,
	[Date] [datetime] NOT NULL,
 CONSTRAINT [PK_datPurchaseOrders] PRIMARY KEY CLUSTERED 
(
	[PurchaseOrderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[datPurchaseOrders]  WITH CHECK ADD  CONSTRAINT [FK_datPurchaseOrders_datSupplierPrices] FOREIGN KEY([SupplierPriceID])
REFERENCES [dbo].[datSupplierPrices] ([SupplierPriceID])
GO

ALTER TABLE [dbo].[datPurchaseOrders] CHECK CONSTRAINT [FK_datPurchaseOrders_datSupplierPrices]
GO

