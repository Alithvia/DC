USE [SoS_Build]
GO

/****** Object:  Table [dbo].[datPackages]    Script Date: 3/25/2018 8:57:15 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[datPackages](
	[PackageID] [int] IDENTITY(1,1) NOT NULL,
	[PackageNumber] [nvarchar](50) NOT NULL,
	[TrayID] [int] NOT NULL,
 CONSTRAINT [PK_dboPackages] PRIMARY KEY CLUSTERED 
(
	[PackageID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[datPackages]  WITH CHECK ADD  CONSTRAINT [FK_datPackages_datTrays] FOREIGN KEY([TrayID])
REFERENCES [dbo].[datTrays] ([TrayID])
ON UPDATE CASCADE
GO

ALTER TABLE [dbo].[datPackages] CHECK CONSTRAINT [FK_datPackages_datTrays]
GO

