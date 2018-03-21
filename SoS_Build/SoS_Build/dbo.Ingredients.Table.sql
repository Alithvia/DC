USE [SOSMock]
GO
/****** Object:  Table [dbo].[Ingredients]    Script Date: 2018-03-21 12:15:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ingredients](
	[IngredientID] [nchar](10) NOT NULL,
	[Expiry Date] [nchar](10) NULL,
	[Country of origin] [nchar](10) NULL,
	[Allergen] [nchar](10) NULL,
	[IngredientCategory] [nchar](10) NULL,
	[DietaryRestrcition] [nchar](10) NULL,
	[Category] [nchar](10) NULL,
	[StorageLocation] [nchar](10) NULL,
 CONSTRAINT [PK_Ingredients] PRIMARY KEY CLUSTERED 
(
	[IngredientID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Ingredients]  WITH CHECK ADD  CONSTRAINT [FK_Ingredients_Allergens] FOREIGN KEY([Allergen])
REFERENCES [dbo].[Allergens] ([Allergen])
GO
ALTER TABLE [dbo].[Ingredients] CHECK CONSTRAINT [FK_Ingredients_Allergens]
GO
ALTER TABLE [dbo].[Ingredients]  WITH CHECK ADD  CONSTRAINT [FK_Ingredients_DietaryRestrictions] FOREIGN KEY([DietaryRestrcition])
REFERENCES [dbo].[DietaryRestrictions] ([Restriction])
GO
ALTER TABLE [dbo].[Ingredients] CHECK CONSTRAINT [FK_Ingredients_DietaryRestrictions]
GO
ALTER TABLE [dbo].[Ingredients]  WITH CHECK ADD  CONSTRAINT [FK_Ingredients_IngredientCategories] FOREIGN KEY([Category])
REFERENCES [dbo].[IngredientCategories] ([CategoryID])
GO
ALTER TABLE [dbo].[Ingredients] CHECK CONSTRAINT [FK_Ingredients_IngredientCategories]
GO
ALTER TABLE [dbo].[Ingredients]  WITH CHECK ADD  CONSTRAINT [FK_Ingredients_StorageTypes] FOREIGN KEY([StorageLocation])
REFERENCES [dbo].[StorageTypes] ([StorageID])
GO
ALTER TABLE [dbo].[Ingredients] CHECK CONSTRAINT [FK_Ingredients_StorageTypes]
GO
