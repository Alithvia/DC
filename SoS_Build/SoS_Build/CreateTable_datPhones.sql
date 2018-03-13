USE [SoS_Build]
GO

/****** Object:  Table [dbo].[datPhones]    Script Date: 3/13/2018 6:03:05 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[datPhones](
	[PhoneID] [int] IDENTITY(1,1) NOT NULL,
	[PhoneNumber] [nvarchar](10) NOT NULL,
	[Ext] [int] NOT NULL,
	[PhoneType] [int] NOT NULL,
 CONSTRAINT [PK_datPhones] PRIMARY KEY CLUSTERED 
(
	[PhoneID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[datPhones]  WITH CHECK ADD  CONSTRAINT [FK_datPhones_luPhoneTypes] FOREIGN KEY([PhoneType])
REFERENCES [dbo].[luPhoneTypes] ([PhoneTypeID])
GO

ALTER TABLE [dbo].[datPhones] CHECK CONSTRAINT [FK_datPhones_luPhoneTypes]
GO


