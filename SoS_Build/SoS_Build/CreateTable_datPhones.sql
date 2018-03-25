USE [SoS_Build]
GO

/****** Object:  Table [dbo].[datPhones]    Script Date: 3/25/2018 8:57:40 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[datPhones](
	[PhoneID] [int] IDENTITY(1,1) NOT NULL,
	[PhoneNumber] [nvarchar](11) NOT NULL,
	[Ext] [nvarchar](6) NULL,
	[PhoneTypeID] [tinyint] NOT NULL,
 CONSTRAINT [PK_datPhones] PRIMARY KEY CLUSTERED 
(
	[PhoneID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[datPhones]  WITH CHECK ADD  CONSTRAINT [FK_datPhones_luPhoneTypes] FOREIGN KEY([PhoneTypeID])
REFERENCES [dbo].[luPhoneTypes] ([PhoneTypeID])
ON UPDATE CASCADE
GO

ALTER TABLE [dbo].[datPhones] CHECK CONSTRAINT [FK_datPhones_luPhoneTypes]
GO

