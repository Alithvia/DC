USE [SoS_Build]
GO

/****** Object:  Table [dbo].[datClientOrders]    Script Date: 3/25/2018 8:55:39 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[datClientOrders](
	[OrderNumber] [int] IDENTITY(1,1) NOT NULL,
	[ClientID] [int] NOT NULL,
 CONSTRAINT [PK_datCustomerOrders] PRIMARY KEY CLUSTERED 
(
	[OrderNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[datClientOrders]  WITH CHECK ADD  CONSTRAINT [FK_datClientOrders_datClients] FOREIGN KEY([ClientID])
REFERENCES [dbo].[datClients] ([ClientID])
ON UPDATE CASCADE
GO

ALTER TABLE [dbo].[datClientOrders] CHECK CONSTRAINT [FK_datClientOrders_datClients]
GO

