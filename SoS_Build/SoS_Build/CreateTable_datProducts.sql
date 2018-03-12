USE [BootCamp1]
GO

/****** Object:  Table [dbo].[datProducts]    Script Date: 3/12/2018 3:33:04 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[datProducts](
	[ProductID] [int] NOT NULL,
	[ProductName] [varchar](30) NOT NULL,
 CONSTRAINT [PK_datProducts] PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

