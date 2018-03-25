USE [SoS_Build]
GO

/****** Object:  Table [dbo].[jncSupplierContacts]    Script Date: 3/25/2018 9:01:32 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[jncSupplierContacts](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ContactID] [int] NOT NULL,
	[SupplierID] [int] NOT NULL,
 CONSTRAINT [PK_datSupplierContacts] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[jncSupplierContacts]  WITH CHECK ADD  CONSTRAINT [FK_jncSupplierContacts_datContacts] FOREIGN KEY([ContactID])
REFERENCES [dbo].[datContacts] ([ContactID])
ON UPDATE CASCADE
GO

ALTER TABLE [dbo].[jncSupplierContacts] CHECK CONSTRAINT [FK_jncSupplierContacts_datContacts]
GO

ALTER TABLE [dbo].[jncSupplierContacts]  WITH CHECK ADD  CONSTRAINT [FK_jncSupplierContacts_datSuppliers] FOREIGN KEY([SupplierID])
REFERENCES [dbo].[datSuppliers] ([SupplierID])
ON UPDATE CASCADE
GO

ALTER TABLE [dbo].[jncSupplierContacts] CHECK CONSTRAINT [FK_jncSupplierContacts_datSuppliers]
GO

