USE [BootCamp1]
GO

/****** Object:  Table [dbo].[datSupplierPrices]    Script Date: 3/12/2018 3:32:45 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[datSupplierPrices](
	[SupplierPriceID] [int] NOT NULL,
	[SupplierID] [int] NOT NULL,
	[ProductID] [int] NOT NULL,
	[PricePerUnit] [money] NOT NULL,
	[Discount] [money] NULL,
 CONSTRAINT [PK_datSupplierPrices] PRIMARY KEY CLUSTERED 
(
	[SupplierPriceID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[datSupplierPrices]  WITH CHECK ADD  CONSTRAINT [FK_datSupplierPrices_datProducts] FOREIGN KEY([ProductID])
REFERENCES [dbo].[datProducts] ([ProductID])
GO

ALTER TABLE [dbo].[datSupplierPrices] CHECK CONSTRAINT [FK_datSupplierPrices_datProducts]
GO

ALTER TABLE [dbo].[datSupplierPrices]  WITH CHECK ADD  CONSTRAINT [FK_datSupplierPrices_datSuppliers] FOREIGN KEY([SupplierID])
REFERENCES [dbo].[datSuppliers] ([SuppierID])
GO

ALTER TABLE [dbo].[datSupplierPrices] CHECK CONSTRAINT [FK_datSupplierPrices_datSuppliers]
GO

