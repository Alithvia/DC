USE [SoS_Build]
GO

/****** Object:  Table [dbo].[jncAssembly]    Script Date: 4/2/2018 1:38:46 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[jncAssembly](
	[IngredientAssemblyID] [int] IDENTITY(1,1) NOT NULL,
	[AssemblyID] [int] NULL,
	[Quantity] [float] NOT NULL,
	[UnitsID] [int] NOT NULL,
	[IngInvID] [int] NOT NULL,
 CONSTRAINT [PK_jncAssembly] PRIMARY KEY CLUSTERED 
(
	[IngredientAssemblyID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[jncAssembly]  WITH NOCHECK ADD  CONSTRAINT [FK_jncAssembly_datAssembly] FOREIGN KEY([IngInvID])
REFERENCES [dbo].[datAssembly] ([AssemblyID])
GO

ALTER TABLE [dbo].[jncAssembly] CHECK CONSTRAINT [FK_jncAssembly_datAssembly]
GO

ALTER TABLE [dbo].[jncAssembly]  WITH NOCHECK ADD  CONSTRAINT [FK_jncAssembly_datIngredientInventory] FOREIGN KEY([IngInvID])
REFERENCES [dbo].[datIngredientInventory] ([IngInvID])
ON UPDATE CASCADE
GO

ALTER TABLE [dbo].[jncAssembly] CHECK CONSTRAINT [FK_jncAssembly_datIngredientInventory]
GO

ALTER TABLE [dbo].[jncAssembly]  WITH CHECK ADD  CONSTRAINT [FK_jncAssembly_luUnits] FOREIGN KEY([UnitsID])
REFERENCES [dbo].[luUnits] ([UnitsID])
GO

ALTER TABLE [dbo].[jncAssembly] CHECK CONSTRAINT [FK_jncAssembly_luUnits]
GO


