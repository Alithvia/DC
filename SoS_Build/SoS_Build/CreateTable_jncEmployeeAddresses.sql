USE [SoS_Build]
GO

/****** Object:  Table [dbo].[jncEmployeeAddresses]    Script Date: 3/13/2018 6:02:49 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[jncEmployeeAddresses](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[EmployeeID] [int] NOT NULL,
	[AddressID] [int] NOT NULL,
	[AddressType] [int] NOT NULL,
	[Notes] [text] NOT NULL,
 CONSTRAINT [PK_jncEmployeeAddresses] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[jncEmployeeAddresses]  WITH CHECK ADD  CONSTRAINT [FK_jncEmployeeAddresses_datAddresses] FOREIGN KEY([AddressID])
REFERENCES [dbo].[datAddresses] ([AddressID])
GO

ALTER TABLE [dbo].[jncEmployeeAddresses] CHECK CONSTRAINT [FK_jncEmployeeAddresses_datAddresses]
GO

ALTER TABLE [dbo].[jncEmployeeAddresses]  WITH CHECK ADD  CONSTRAINT [FK_jncEmployeeAddresses_datEmployees] FOREIGN KEY([EmployeeID])
REFERENCES [dbo].[datEmployees] ([EmployeeID])
GO

ALTER TABLE [dbo].[jncEmployeeAddresses] CHECK CONSTRAINT [FK_jncEmployeeAddresses_datEmployees]
GO


