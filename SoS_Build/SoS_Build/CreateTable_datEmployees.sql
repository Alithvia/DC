USE [SoS_Build]
GO

/****** Object:  Table [dbo].[datEmployees]    Script Date: 3/25/2018 8:56:24 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[datEmployees](
	[EmployeeID] [int] IDENTITY(1,1) NOT NULL,
	[PositionID] [int] NOT NULL,
 CONSTRAINT [PK_datEmployees] PRIMARY KEY CLUSTERED 
(
	[EmployeeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[datEmployees]  WITH CHECK ADD  CONSTRAINT [FK_datEmployees_luPositions] FOREIGN KEY([PositionID])
REFERENCES [dbo].[luPositions] ([PositionID])
ON UPDATE CASCADE
GO

ALTER TABLE [dbo].[datEmployees] CHECK CONSTRAINT [FK_datEmployees_luPositions]
GO

