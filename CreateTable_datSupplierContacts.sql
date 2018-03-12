USE [BootCamp1]
GO

/****** Object:  Table [dbo].[datSupplierContacts]    Script Date: 3/12/2018 3:31:49 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[datSupplierContacts](
	[SupplierContactID] [int] NOT NULL,
	[ContactID] [int] NOT NULL,
	[TypeID] [int] NOT NULL,
	[Email] [varchar](50) NOT NULL,
	[PhoneID] [int] NOT NULL,
	[SupplierID] [int] NOT NULL,
 CONSTRAINT [PK_datSupplierContacts] PRIMARY KEY CLUSTERED 
(
	[SupplierContactID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[datSupplierContacts]  WITH CHECK ADD  CONSTRAINT [FK_datSupplierContacts_datContactType] FOREIGN KEY([TypeID])
REFERENCES [dbo].[datContactType] ([TypeID])
GO

ALTER TABLE [dbo].[datSupplierContacts] CHECK CONSTRAINT [FK_datSupplierContacts_datContactType]
GO

ALTER TABLE [dbo].[datSupplierContacts]  WITH CHECK ADD  CONSTRAINT [FK_datSupplierContacts_datSuppliers] FOREIGN KEY([SupplierID])
REFERENCES [dbo].[datSuppliers] ([SuppierID])
GO

ALTER TABLE [dbo].[datSupplierContacts] CHECK CONSTRAINT [FK_datSupplierContacts_datSuppliers]
GO

