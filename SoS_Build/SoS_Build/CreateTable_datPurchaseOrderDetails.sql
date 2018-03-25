USE [SoS_Build]
GO

/****** Object:  Table [dbo].[datPurchaseOrderDetails]    Script Date: 3/25/2018 8:57:57 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[datPurchaseOrderDetails](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[PurchaseOrderID] [int] NOT NULL,
	[Date] [date] NOT NULL,
	[Quantity] [int] NOT NULL,
	[Cost] [money] NOT NULL,
 CONSTRAINT [PK_datPurchaseOrderDetails] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[datPurchaseOrderDetails]  WITH CHECK ADD  CONSTRAINT [FK_datPurchaseOrderDetails_jncPurchaseOrders] FOREIGN KEY([PurchaseOrderID])
REFERENCES [dbo].[jncPurchaseOrders] ([PurchaseOrderID])
ON UPDATE CASCADE
GO

ALTER TABLE [dbo].[datPurchaseOrderDetails] CHECK CONSTRAINT [FK_datPurchaseOrderDetails_jncPurchaseOrders]
GO

