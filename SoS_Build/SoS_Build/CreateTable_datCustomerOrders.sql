USE [BootCamp1]
GO

/****** Object:  Table [dbo].[datCustomerOrders]    Script Date: 3/12/2018 3:28:06 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[datCustomerOrders](
	[OrderNumber] [int] NOT NULL,
	[ClientID] [int] NOT NULL,
	[DatePlaced] [datetime] NOT NULL,
	[TotalCost] [money] NOT NULL,
 CONSTRAINT [PK_datCustomerOrders] PRIMARY KEY CLUSTERED 
(
	[OrderNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

