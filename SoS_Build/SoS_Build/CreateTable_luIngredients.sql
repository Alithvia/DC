USE [SoS_Build]
GO

/****** Object:  Table [dbo].[luIngredients]    Script Date: 4/2/2018 1:42:03 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[luIngredients](
	[IngredientID] [int] IDENTITY(1,1) NOT NULL,
	[Ingredient] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_luIngredients] PRIMARY KEY CLUSTERED 
(
	[IngredientID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


