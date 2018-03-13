USE [SoS_Build]
GO

/****** Object:  Table [dbo].[jncEmployeeContacts]    Script Date: 3/13/2018 6:02:45 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[jncEmployeeContacts](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[EmployeeID] [int] NOT NULL,
	[ContactID] [int] NOT NULL,
	[Type] [int] NOT NULL,
 CONSTRAINT [PK_jncEmployeeContacts] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[jncEmployeeContacts]  WITH CHECK ADD  CONSTRAINT [FK_jncEmployeeContacts_datContacts] FOREIGN KEY([ContactID])
REFERENCES [dbo].[datContacts] ([ContactID])
GO

ALTER TABLE [dbo].[jncEmployeeContacts] CHECK CONSTRAINT [FK_jncEmployeeContacts_datContacts]
GO

ALTER TABLE [dbo].[jncEmployeeContacts]  WITH CHECK ADD  CONSTRAINT [FK_jncEmployeeContacts_datEmployees] FOREIGN KEY([EmployeeID])
REFERENCES [dbo].[datEmployees] ([EmployeeID])
GO

ALTER TABLE [dbo].[jncEmployeeContacts] CHECK CONSTRAINT [FK_jncEmployeeContacts_datEmployees]
GO


