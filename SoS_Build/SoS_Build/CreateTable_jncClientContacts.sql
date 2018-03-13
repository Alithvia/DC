USE [SoS_Build]
GO

/****** Object:  Table [dbo].[jncClientContacts]    Script Date: 3/13/2018 6:02:52 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[jncClientContacts](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ClientID] [int] NOT NULL,
	[ContactID] [int] NOT NULL,
	[Type] [int] NOT NULL,
 CONSTRAINT [PK_jncClientContacts] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[jncClientContacts]  WITH CHECK ADD  CONSTRAINT [FK_jncClientContacts_datClients] FOREIGN KEY([ClientID])
REFERENCES [dbo].[datClients] ([ClientID])
GO

ALTER TABLE [dbo].[jncClientContacts] CHECK CONSTRAINT [FK_jncClientContacts_datClients]
GO

ALTER TABLE [dbo].[jncClientContacts]  WITH CHECK ADD  CONSTRAINT [FK_jncClientContacts_datContacts] FOREIGN KEY([ContactID])
REFERENCES [dbo].[datContacts] ([ContactID])
GO

ALTER TABLE [dbo].[jncClientContacts] CHECK CONSTRAINT [FK_jncClientContacts_datContacts]
GO


