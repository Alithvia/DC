USE [SoS_Build]
GO

/****** Object:  Table [dbo].[datBoxes]    Script Date: 4/2/2018 1:55:07 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[datBoxes](
	[BoxID] [int] IDENTITY(1,1) NOT NULL,
	[AssemblyID] [int] NOT NULL,
 CONSTRAINT [PK_datBoxes] PRIMARY KEY CLUSTERED 
(
	[BoxID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[datBoxes]  WITH CHECK ADD  CONSTRAINT [FK_datBoxes_datAssembly] FOREIGN KEY([AssemblyID])
REFERENCES [dbo].[datAssembly] ([AssemblyID])
ON UPDATE CASCADE
GO

ALTER TABLE [dbo].[datBoxes] CHECK CONSTRAINT [FK_datBoxes_datAssembly]
GO


