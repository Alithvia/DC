USE [SoS_Build]
GO

/****** Object:  Table [dbo].[jncVendorAddresses]    Script Date: 3/13/2018 6:02:42 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[jncVendorAddresses](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[VendorID] [int] NOT NULL,
	[AddressID] [int] NOT NULL,
	[AddressType] [int] NOT NULL,
	[Notes] [text] NULL,
 CONSTRAINT [PK_jncVendorAddresses] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[jncVendorAddresses]  WITH CHECK ADD  CONSTRAINT [FK_jncVendorAddresses_datAddresses] FOREIGN KEY([AddressID])
REFERENCES [dbo].[datAddresses] ([AddressID])
GO

ALTER TABLE [dbo].[jncVendorAddresses] CHECK CONSTRAINT [FK_jncVendorAddresses_datAddresses]
GO

ALTER TABLE [dbo].[jncVendorAddresses]  WITH CHECK ADD  CONSTRAINT [FK_jncVendorAddresses_datVendors] FOREIGN KEY([VendorID])
REFERENCES [dbo].[datVendors] ([VendorID])
GO

ALTER TABLE [dbo].[jncVendorAddresses] CHECK CONSTRAINT [FK_jncVendorAddresses_datVendors]
GO


