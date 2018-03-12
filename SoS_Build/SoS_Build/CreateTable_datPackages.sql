USE [BootCamp1]
GO

/****** Object:  Table [dbo].[datPackages]    Script Date: 3/12/2018 3:28:58 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[datPackages](
	[PackageID] [int] NOT NULL,
	[Package Number] [varchar](30) NOT NULL,
	[TrayID] [int] NOT NULL,
 CONSTRAINT [PK_dboPackages] PRIMARY KEY CLUSTERED 
(
	[PackageID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[datPackages]  WITH CHECK ADD  CONSTRAINT [FK_datPackages_datTrays] FOREIGN KEY([TrayID])
REFERENCES [dbo].[datTrays] ([TrayID])
GO

ALTER TABLE [dbo].[datPackages] CHECK CONSTRAINT [FK_datPackages_datTrays]
GO

