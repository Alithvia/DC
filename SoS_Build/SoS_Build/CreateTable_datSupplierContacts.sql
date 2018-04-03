USE [SoS_Build]
GO

/****** Object:  Table [dbo].[datVendorContacts]    Script Date: 3/12/2018 3:31:49 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[datVendorContacts](
	[VendorContactID] [int] NOT NULL,
	[ContactID] [int] NOT NULL,
	ContactTypeID [tinyint] NOT NULL,
	[Email] [varchar](50) NOT NULL,
	[PhoneID] [int] NOT NULL,
	[VendorID] [smallint] NOT NULL,
 CONSTRAINT [PK_datVendorContacts] PRIMARY KEY CLUSTERED 
(
	[VendorContactID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[datVendorContacts]  WITH CHECK ADD  CONSTRAINT [FK_datVendorContacts_luContactType] FOREIGN KEY(ContactTypeID)
REFERENCES [dbo].[luContactType] (ContactTypeID)
GO

ALTER TABLE [dbo].[datVendorContacts] CHECK CONSTRAINT [FK_datVendorContacts_luContactType]
GO

ALTER TABLE [dbo].[datVendorContacts]  WITH CHECK ADD  CONSTRAINT [FK_datVendorContacts_datVendors] FOREIGN KEY([VendorID])
REFERENCES [dbo].[datVendors] ([VendorID])
GO

ALTER TABLE [dbo].[datVendorContacts] CHECK CONSTRAINT [FK_datVendorContacts_datVendors]
GO

