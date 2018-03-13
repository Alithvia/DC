USE [SoS_Build]
GO

/****** Object:  Table [dbo].[datContacts]    Script Date: 3/13/2018 6:03:13 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[datContacts](
	[ContactID] [int] IDENTITY(1,1) NOT NULL,
	[PeopleID] [int] NOT NULL,
	[PhoneID] [int] NOT NULL,
 CONSTRAINT [PK_datContacts] PRIMARY KEY CLUSTERED 
(
	[ContactID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[datContacts]  WITH CHECK ADD  CONSTRAINT [FK_datContacts_datPeople] FOREIGN KEY([PeopleID])
REFERENCES [dbo].[datPeople] ([PeopleID])
GO

ALTER TABLE [dbo].[datContacts] CHECK CONSTRAINT [FK_datContacts_datPeople]
GO

ALTER TABLE [dbo].[datContacts]  WITH CHECK ADD  CONSTRAINT [FK_datContacts_datPhones] FOREIGN KEY([PhoneID])
REFERENCES [dbo].[datPhones] ([PhoneID])
GO

ALTER TABLE [dbo].[datContacts] CHECK CONSTRAINT [FK_datContacts_datPhones]
GO


