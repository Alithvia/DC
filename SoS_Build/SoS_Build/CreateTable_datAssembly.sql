USE [SoS_Build]
GO

/****** Object:  Table [dbo].[datAssembly]    Script Date: 4/2/2018 1:31:40 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[datAssembly](
	[AssemblyID] [int] IDENTITY(1,1) NOT NULL,
	[AssemblyTypeID] [int] NOT NULL,
	[DateTime] [datetime] NOT NULL,
	[Expiry] [datetime] NOT NULL,
 CONSTRAINT [PK_datAssembly] PRIMARY KEY CLUSTERED 
(
	[AssemblyID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[datAssembly]  WITH CHECK ADD  CONSTRAINT [FK_datAssembly_luAssemblyTypes] FOREIGN KEY([AssemblyTypeID])
REFERENCES [dbo].[luAssemblyTypes] ([AssemblyTypeID])
ON UPDATE CASCADE
GO

ALTER TABLE [dbo].[datAssembly] CHECK CONSTRAINT [FK_datAssembly_luAssemblyTypes]
GO


