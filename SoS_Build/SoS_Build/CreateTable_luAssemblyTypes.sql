USE [SoS_Build]
GO

/****** Object:  Table [dbo].[luAssemblyTypes]    Script Date: 4/2/2018 1:40:46 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[luAssemblyTypes](
	[AssemblyTypeID] [int] IDENTITY(1,1) NOT NULL,
	[AssemblyType] [nchar](20) NOT NULL,
 CONSTRAINT [PK_luAssemblyTypes] PRIMARY KEY CLUSTERED 
(
	[AssemblyTypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


