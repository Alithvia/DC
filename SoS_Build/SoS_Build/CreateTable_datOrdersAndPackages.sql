USE [BootCamp1]
GO

/****** Object:  Table [dbo].[datOrdersAndPackages]    Script Date: 3/12/2018 3:28:41 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[datOrdersAndPackages](
	[OrdersAndPackagesID] [int] NOT NULL,
	[OrderNumber] [int] NOT NULL,
	[PackageID] [int] NOT NULL,
 CONSTRAINT [PK_dboFilledOrders] PRIMARY KEY CLUSTERED 
(
	[OrdersAndPackagesID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[datOrdersAndPackages]  WITH CHECK ADD  CONSTRAINT [FK_datOrdersAndPackages_datCustomerOrders] FOREIGN KEY([OrderNumber])
REFERENCES [dbo].[datCustomerOrders] ([OrderNumber])
GO

ALTER TABLE [dbo].[datOrdersAndPackages] CHECK CONSTRAINT [FK_datOrdersAndPackages_datCustomerOrders]
GO

ALTER TABLE [dbo].[datOrdersAndPackages]  WITH CHECK ADD  CONSTRAINT [FK_dboFilledOrders_dboPackages] FOREIGN KEY([PackageID])
REFERENCES [dbo].[datPackages] ([PackageID])
GO

ALTER TABLE [dbo].[datOrdersAndPackages] CHECK CONSTRAINT [FK_dboFilledOrders_dboPackages]
GO

