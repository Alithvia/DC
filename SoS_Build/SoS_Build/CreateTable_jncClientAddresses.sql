USE [SoS_Build]
GO

/****** Object:  Table [dbo].[jncClientAddresses]    Script Date: 3/13/2018 6:02:56 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[jncClientAddresses](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ClientID] [int] NOT NULL,
	[AddressID] [int] NOT NULL,
	[AddressType] [int] NOT NULL,
	[Notes] [text] NULL,
 CONSTRAINT [PK_jncClientAddresses] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[jncClientAddresses]  WITH CHECK ADD  CONSTRAINT [FK_jncClientAddresses_datAddresses] FOREIGN KEY([AddressID])
REFERENCES [dbo].[datAddresses] ([AddressID])
GO

ALTER TABLE [dbo].[jncClientAddresses] CHECK CONSTRAINT [FK_jncClientAddresses_datAddresses]
GO

ALTER TABLE [dbo].[jncClientAddresses]  WITH CHECK ADD  CONSTRAINT [FK_jncClientAddresses_datClients] FOREIGN KEY([ClientID])
REFERENCES [dbo].[datClients] ([ClientID])
GO

ALTER TABLE [dbo].[jncClientAddresses] CHECK CONSTRAINT [FK_jncClientAddresses_datClients]
GO


