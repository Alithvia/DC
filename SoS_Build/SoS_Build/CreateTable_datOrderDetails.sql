USE [SoS_Build]
GO

/****** Object:  Table [dbo].[datOrderDetails]    Script Date: 3/25/2018 8:56:41 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[datOrderDetails](
	[DetailsID] [int] IDENTITY(1,1) NOT NULL,
	[OrderNumber] [int] NOT NULL,
	[Quantity] [int] NOT NULL,
	[SamosaTypeID] [int] NOT NULL,
	[DateTime] [datetime] NOT NULL,
	[TotalCost] [money] NOT NULL,
 CONSTRAINT [PK_datOrderDetails] PRIMARY KEY CLUSTERED 
(
	[DetailsID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[datOrderDetails]  WITH CHECK ADD  CONSTRAINT [FK_datOrderDetails_datCustomerOrders] FOREIGN KEY([OrderNumber])
REFERENCES [dbo].[datClientOrders] ([OrderNumber])
ON UPDATE CASCADE
GO

ALTER TABLE [dbo].[datOrderDetails] CHECK CONSTRAINT [FK_datOrderDetails_datCustomerOrders]
GO

