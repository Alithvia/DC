USE [SoS_Build]
GO

/****** Object:  Table [dbo].[datPurchaseOrders]    Script Date: 4/2/2018 1:35:47 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[datPurchaseOrders](
	[PurchaseID] [int] IDENTITY(1,1) NOT NULL,
	[PONumber] [int] NOT NULL,
	[VendorID] [int] NOT NULL,
	[Date] [datetime] NOT NULL,
 CONSTRAINT [PK_datPurchaseOrders] PRIMARY KEY CLUSTERED 
(
	[PurchaseID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[datPurchaseOrders]  WITH CHECK ADD  CONSTRAINT [FK_datPurchaseOrders_datVendors] FOREIGN KEY([VendorID])
REFERENCES [dbo].[datVendors] ([VendorID])
ON UPDATE CASCADE
GO

ALTER TABLE [dbo].[datPurchaseOrders] CHECK CONSTRAINT [FK_datPurchaseOrders_datVendors]
GO


