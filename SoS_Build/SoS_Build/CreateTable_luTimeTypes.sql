USE [SoS_Build]
GO

/****** Object:  Table [dbo].[luTimeTypes]    Script Date: 4/2/2018 1:42:36 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[luTimeTypes](
	[TimeTypeID] [int] IDENTITY(1,1) NOT NULL,
	[TimeType] [nvarchar](20) NULL,
	[IngredientType] [int] NOT NULL,
 CONSTRAINT [PK_luTimeTypes] PRIMARY KEY CLUSTERED 
(
	[TimeTypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[luTimeTypes]  WITH CHECK ADD  CONSTRAINT [FK_luTimeTypes_luAssemblyTypes] FOREIGN KEY([IngredientType])
REFERENCES [dbo].[luAssemblyTypes] ([AssemblyTypeID])
ON UPDATE CASCADE
GO

ALTER TABLE [dbo].[luTimeTypes] CHECK CONSTRAINT [FK_luTimeTypes_luAssemblyTypes]
GO

ALTER TABLE [dbo].[luTimeTypes]  WITH CHECK ADD  CONSTRAINT [FK_luTimeTypes_luIngredients] FOREIGN KEY([IngredientType])
REFERENCES [dbo].[luIngredients] ([IngredientID])
ON UPDATE CASCADE
GO

ALTER TABLE [dbo].[luTimeTypes] CHECK CONSTRAINT [FK_luTimeTypes_luIngredients]
GO


