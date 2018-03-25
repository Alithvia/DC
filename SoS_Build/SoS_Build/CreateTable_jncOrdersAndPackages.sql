USE [SoS_Build]
GO

/****** Object:  Table [dbo].[jncOrdersAndPackages]    Script Date: 3/25/2018 9:00:51 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[jncOrdersAndPackages](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[OrderNumber] [int] NOT NULL,
	[PackageID] [int] NOT NULL,
 CONSTRAINT [PK_dboFilledOrders] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[jncOrdersAndPackages]  WITH CHECK ADD  CONSTRAINT [FK_datOrdersAndPackages_datCustomerOrders] FOREIGN KEY([OrderNumber])
REFERENCES [dbo].[datClientOrders] ([OrderNumber])
GO

ALTER TABLE [dbo].[jncOrdersAndPackages] CHECK CONSTRAINT [FK_datOrdersAndPackages_datCustomerOrders]
GO

ALTER TABLE [dbo].[jncOrdersAndPackages]  WITH CHECK ADD  CONSTRAINT [FK_jncOrdersAndPackages_datPackages] FOREIGN KEY([PackageID])
REFERENCES [dbo].[datPackages] ([PackageID])
ON UPDATE CASCADE
GO

ALTER TABLE [dbo].[jncOrdersAndPackages] CHECK CONSTRAINT [FK_jncOrdersAndPackages_datPackages]
GO

