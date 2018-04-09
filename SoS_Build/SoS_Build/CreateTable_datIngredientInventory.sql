USE [SoS_Build]
GO

/****** Object:  Table [dbo].[datIngredientInventory]    Script Date: 4/2/2018 1:33:19 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[datIngredientInventory](
	[IngInvID] [int] IDENTITY(1,1) NOT NULL,
	[PurchaseID] [int] NOT NULL,
	[IngredientID] [int] NOT NULL,
	[Amount] [float] NOT NULL,
	[UnitsID] [int] NOT NULL,
	[ExpDate] [date] NOT NULL,
 CONSTRAINT [PK_datIngredientInventory] PRIMARY KEY CLUSTERED 
(
	[IngInvID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[datIngredientInventory]  WITH CHECK ADD  CONSTRAINT [FK_datIngredientInventory_datPurchaseOrders] FOREIGN KEY([PurchaseID])
REFERENCES [dbo].[datPurchaseOrders] ([PurchaseID])
ON UPDATE CASCADE
GO

ALTER TABLE [dbo].[datIngredientInventory] CHECK CONSTRAINT [FK_datIngredientInventory_datPurchaseOrders]
GO

ALTER TABLE [dbo].[datIngredientInventory]  WITH CHECK ADD  CONSTRAINT [FK_datIngredientInventory_luIngredients] FOREIGN KEY([IngredientID])
REFERENCES [dbo].[luIngredients] ([IngredientID])
ON UPDATE CASCADE
GO

ALTER TABLE [dbo].[datIngredientInventory] CHECK CONSTRAINT [FK_datIngredientInventory_luIngredients]
GO

ALTER TABLE [dbo].[datIngredientInventory]  WITH CHECK ADD  CONSTRAINT [FK_datIngredientInventory_luUnits] FOREIGN KEY([UnitsID])
REFERENCES [dbo].[luUnits] ([UnitsID])
ON UPDATE CASCADE
GO

ALTER TABLE [dbo].[datIngredientInventory] CHECK CONSTRAINT [FK_datIngredientInventory_luUnits]
GO


