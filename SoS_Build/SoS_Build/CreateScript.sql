USE [SoS_Script_Test]
GO

/****** Object:  Table [dbo].[luCountries]    Script Date: 3/25/2018 9:02:45 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[luCountries](
	[CountryCode] [nvarchar](2) NOT NULL,
	[CountryName] [nvarchar](13) NOT NULL,
 CONSTRAINT [PK_luCountries] PRIMARY KEY CLUSTERED 
(
	[CountryCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

USE [SoS_Script_Test]
GO

/****** Object:  Table [dbo].[luProvinces]    Script Date: 3/25/2018 9:03:36 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[luProvinces](
	[ProvinceCode] [nvarchar](2) NOT NULL,
	[ProvinceName] [nvarchar](25) NOT NULL,
	[CountryCode] [nvarchar](2) NOT NULL,
 CONSTRAINT [PK_luProvinces] PRIMARY KEY CLUSTERED 
(
	[ProvinceCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[luProvinces]  WITH CHECK ADD  CONSTRAINT [FK_luProvinces_luCountries] FOREIGN KEY([CountryCode])
REFERENCES [dbo].[luCountries] ([CountryCode])
ON UPDATE CASCADE
GO

ALTER TABLE [dbo].[luProvinces] CHECK CONSTRAINT [FK_luProvinces_luCountries]
GO

USE [SoS_Script_Test]
GO

/****** Object:  Table [dbo].[luCities]    Script Date: 3/25/2018 9:02:19 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[luCities](
	[CityID] [int] IDENTITY(1,1) NOT NULL,
	[City] [nvarchar](35) NOT NULL,
	[ProvinceCode] [nvarchar](2) NOT NULL,
 CONSTRAINT [PK_luCities] PRIMARY KEY CLUSTERED 
(
	[CityID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[luCities]  WITH CHECK ADD  CONSTRAINT [FK_luCities_luProvinces] FOREIGN KEY([ProvinceCode])
REFERENCES [dbo].[luProvinces] ([ProvinceCode])
ON UPDATE CASCADE
GO

ALTER TABLE [dbo].[luCities] CHECK CONSTRAINT [FK_luCities_luProvinces]
GO

USE [SoS_Script_Test]
GO

/****** Object:  Table [dbo].[datVendors]    Script Date: 3/13/2018 6:03:00 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[datVendors](
	[VendorID] [int] IDENTITY(1,1) NOT NULL,
	[VendorName] [nvarchar](30) NOT NULL,
 CONSTRAINT [PK_datVendors] PRIMARY KEY CLUSTERED 
(
	[VendorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


USE [SoS_Script_Test]
GO

/****** Object:  Table [dbo].[datAddresses]    Script Date: 3/25/2018 8:55:19 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[datAddresses](
	[AddressID] [int] IDENTITY(1,1) NOT NULL,
	[Address] [nvarchar](50) NOT NULL,
	[CityID] [int] NOT NULL,
 CONSTRAINT [PK_datAddresses] PRIMARY KEY CLUSTERED 
(
	[AddressID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[datAddresses]  WITH CHECK ADD  CONSTRAINT [FK_datAddresses_luCities] FOREIGN KEY([CityID])
REFERENCES [dbo].[luCities] ([CityID])
ON UPDATE CASCADE
GO

ALTER TABLE [dbo].[datAddresses] CHECK CONSTRAINT [FK_datAddresses_luCities]
GO

USE [SoS_Script_Test]
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


USE [SoS_Script_Test]
GO

/****** Object:  Table [dbo].[luPositions]    Script Date: 3/25/2018 9:03:09 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[luPositions](
	[PositionID] [int] IDENTITY(1,1) NOT NULL,
	[Position] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_Table_1] PRIMARY KEY CLUSTERED 
(
	[PositionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

USE [SoS_Script_Test]
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

USE [SoS_Script_Test]
GO

/****** Object:  Table [dbo].[luPhoneTypes]    Script Date: 3/25/2018 9:02:58 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[luPhoneTypes](
	[PhoneTypeID] [tinyint] IDENTITY(1,1) NOT NULL,
	[PhoneType] [nvarchar](10) NOT NULL,
 CONSTRAINT [PK_luPhoneTypes] PRIMARY KEY CLUSTERED 
(
	[PhoneTypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

USE [SoS_Script_Test]
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

USE [SoS_Script_Test]
GO

/****** Object:  Table [dbo].[datPeople]    Script Date: 3/25/2018 8:57:27 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[datPeople](
	[PeopleID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](25) NOT NULL,
	[Notes] [nvarchar](50) NULL,
	[Email] [nvarchar](30) NULL,
 CONSTRAINT [PK_datPeople] PRIMARY KEY CLUSTERED 
(
	[PeopleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

USE [SoS_Script_Test]
GO

/****** Object:  Table [dbo].[luContactType]    Script Date: 3/25/2018 9:02:30 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[luContactType](
	[ContactTypeID] [tinyint] IDENTITY(1,1) NOT NULL,
	[ContactType] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_datContactType] PRIMARY KEY CLUSTERED 
(
	[ContactTypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

USE [SoS_Script_Test]
GO

/****** Object:  Table [dbo].[datContacts]    Script Date: 3/25/2018 8:56:08 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[datContacts](
	[ContactID] [int] IDENTITY(1,1) NOT NULL,
	[PeopleID] [int] NOT NULL,
	[PhoneID] [int] NOT NULL,
	[ContactTypeID] [tinyint] NOT NULL,
 CONSTRAINT [PK_datContacts] PRIMARY KEY CLUSTERED 
(
	[ContactID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[datContacts]  WITH CHECK ADD  CONSTRAINT [FK_datContacts_datPeople] FOREIGN KEY([PeopleID])
REFERENCES [dbo].[datPeople] ([PeopleID])
ON UPDATE CASCADE
GO

ALTER TABLE [dbo].[datContacts] CHECK CONSTRAINT [FK_datContacts_datPeople]
GO

ALTER TABLE [dbo].[datContacts]  WITH CHECK ADD  CONSTRAINT [FK_datContacts_datPhones] FOREIGN KEY([PhoneID])
REFERENCES [dbo].[datPhones] ([PhoneID])
ON UPDATE CASCADE
GO

ALTER TABLE [dbo].[datContacts] CHECK CONSTRAINT [FK_datContacts_datPhones]
GO

ALTER TABLE [dbo].[datContacts]  WITH CHECK ADD  CONSTRAINT [FK_datContacts_luContactType1] FOREIGN KEY([ContactTypeID])
REFERENCES [dbo].[luContactType] ([ContactTypeID])
ON UPDATE CASCADE
GO

ALTER TABLE [dbo].[datContacts] CHECK CONSTRAINT [FK_datContacts_luContactType1]
GO

USE [SoS_Script_Test]
GO

/****** Object:  Table [dbo].[jncEmployeeContacts]    Script Date: 3/25/2018 9:00:33 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[jncEmployeeContacts](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[EmployeeID] [int] NOT NULL,
	[ContactID] [int] NOT NULL,
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
ON UPDATE CASCADE
GO

ALTER TABLE [dbo].[jncEmployeeContacts] CHECK CONSTRAINT [FK_jncEmployeeContacts_datEmployees]
GO

USE [SoS_Script_Test]
GO

/****** Object:  Table [dbo].[datClients]    Script Date: 3/25/2018 8:55:52 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[datClients](
	[ClientID] [int] IDENTITY(1,1) NOT NULL,
	[ClientName] [nvarchar](30) NOT NULL,
 CONSTRAINT [PK_datClients] PRIMARY KEY CLUSTERED 
(
	[ClientID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

USE [SoS_Script_Test]
GO

/****** Object:  Table [dbo].[jncClientAddresses]    Script Date: 3/25/2018 8:59:49 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[jncClientAddresses](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ClientID] [int] NOT NULL,
	[AddressID] [int] NOT NULL,
	[AddressType] [int] NOT NULL,
	[Notes] [nvarchar](50) NULL,
 CONSTRAINT [PK_jncClientAddresses] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[jncClientAddresses]  WITH CHECK ADD  CONSTRAINT [FK_jncClientAddresses_datAddresses] FOREIGN KEY([AddressID])
REFERENCES [dbo].[datAddresses] ([AddressID])
ON UPDATE CASCADE
GO

ALTER TABLE [dbo].[jncClientAddresses] CHECK CONSTRAINT [FK_jncClientAddresses_datAddresses]
GO

ALTER TABLE [dbo].[jncClientAddresses]  WITH CHECK ADD  CONSTRAINT [FK_jncClientAddresses_datClients] FOREIGN KEY([ClientID])
REFERENCES [dbo].[datClients] ([ClientID])
ON UPDATE CASCADE
GO

ALTER TABLE [dbo].[jncClientAddresses] CHECK CONSTRAINT [FK_jncClientAddresses_datClients]
GO

USE [SoS_Script_Test]
GO

/****** Object:  Table [dbo].[jncClientContacts]    Script Date: 3/25/2018 9:00:05 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[jncClientContacts](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ClientID] [int] NOT NULL,
	[ContactID] [int] NOT NULL,
 CONSTRAINT [PK_jncClientContacts] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[jncClientContacts]  WITH CHECK ADD  CONSTRAINT [FK_jncClientContacts_datClients] FOREIGN KEY([ClientID])
REFERENCES [dbo].[datClients] ([ClientID])
ON UPDATE CASCADE
GO

ALTER TABLE [dbo].[jncClientContacts] CHECK CONSTRAINT [FK_jncClientContacts_datClients]
GO

ALTER TABLE [dbo].[jncClientContacts]  WITH CHECK ADD  CONSTRAINT [FK_jncClientContacts_datContacts] FOREIGN KEY([ContactID])
REFERENCES [dbo].[datContacts] ([ContactID])
ON UPDATE CASCADE
GO

ALTER TABLE [dbo].[jncClientContacts] CHECK CONSTRAINT [FK_jncClientContacts_datContacts]
GO

USE [SoS_Script_Test]
GO

/****** Object:  Table [dbo].[datClientOrders]    Script Date: 3/25/2018 8:55:39 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[datClientOrders](
	[OrderNumber] [int] IDENTITY(1,1) NOT NULL,
	[ClientID] [int] NOT NULL,
 CONSTRAINT [PK_datCustomerOrders] PRIMARY KEY CLUSTERED 
(
	[OrderNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[datClientOrders]  WITH CHECK ADD  CONSTRAINT [FK_datClientOrders_datClients] FOREIGN KEY([ClientID])
REFERENCES [dbo].[datClients] ([ClientID])
ON UPDATE CASCADE
GO

ALTER TABLE [dbo].[datClientOrders] CHECK CONSTRAINT [FK_datClientOrders_datClients]
GO

USE [SoS_Script_Test]
GO

/****** Object:  Table [dbo].[datTrays]    Script Date: 3/25/2018 8:58:40 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[datTrays](
	[TrayID] [int] IDENTITY(1,1) NOT NULL,
	[WorkStationID] [int] NOT NULL,
 CONSTRAINT [PK_datTrays] PRIMARY KEY CLUSTERED 
(
	[TrayID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

USE [SoS_Script_Test]
GO

/****** Object:  Table [dbo].[datPackages]    Script Date: 3/25/2018 8:57:15 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[datPackages](
	[PackageID] [int] IDENTITY(1,1) NOT NULL,
	[PackageNumber] [nvarchar](50) NOT NULL,
	[TrayID] [int] NOT NULL,
 CONSTRAINT [PK_dboPackages] PRIMARY KEY CLUSTERED 
(
	[PackageID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[datPackages]  WITH CHECK ADD  CONSTRAINT [FK_datPackages_datTrays] FOREIGN KEY([TrayID])
REFERENCES [dbo].[datTrays] ([TrayID])
ON UPDATE CASCADE
GO

ALTER TABLE [dbo].[datPackages] CHECK CONSTRAINT [FK_datPackages_datTrays]
GO

USE [SoS_Script_Test]
GO

/****** Object:  Table [dbo].[jncOrdersAndPackages]    Script Date: 3/25/2018 9:00:51 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[jncOrdersAndPackages](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[OrderNumber] [int] NOT NULL,
	[PackageID] [int] NOT NULL,
 CONSTRAINT [PK_dboFilledOrders] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[jncOrdersAndPackages]  WITH CHECK ADD  CONSTRAINT [FK_datOrdersAndPackages_datCustomerOrders] FOREIGN KEY([OrderNumber])
REFERENCES [dbo].[datClientOrders] ([OrderNumber])
GO

ALTER TABLE [dbo].[jncOrdersAndPackages] CHECK CONSTRAINT [FK_datOrdersAndPackages_datCustomerOrders]
GO

ALTER TABLE [dbo].[jncOrdersAndPackages]  WITH CHECK ADD  CONSTRAINT [FK_jncOrdersAndPackages_datPackages] FOREIGN KEY([PackageID])
REFERENCES [dbo].[datPackages] ([PackageID])
ON UPDATE CASCADE
GO

ALTER TABLE [dbo].[jncOrdersAndPackages] CHECK CONSTRAINT [FK_jncOrdersAndPackages_datPackages]
GO

USE [SoS_Script_Test]
GO

/****** Object:  Table [dbo].[luVehicleTypes]    Script Date: 3/25/2018 9:03:48 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[luVehicleTypes](
	[TypeID] [int] IDENTITY(1,1) NOT NULL,
	[Description] [nvarchar](30) NOT NULL,
 CONSTRAINT [PK_dboVehicleTypes] PRIMARY KEY CLUSTERED 
(
	[TypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

USE [SoS_Script_Test]
GO

/****** Object:  Table [dbo].[datVehicles]    Script Date: 3/25/2018 8:59:06 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[datVehicles](
	[VehicleID] [int] IDENTITY(1,1) NOT NULL,
	[LicensePlate] [nvarchar](8) NOT NULL,
	[TypeID] [int] NOT NULL,
	[DatePurchased] [date] NOT NULL,
 CONSTRAINT [PK_dboVehicles] PRIMARY KEY CLUSTERED 
(
	[VehicleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[datVehicles]  WITH CHECK ADD  CONSTRAINT [FK_datVehicles_luVehicleTypes] FOREIGN KEY([TypeID])
REFERENCES [dbo].[luVehicleTypes] ([TypeID])
ON UPDATE CASCADE
GO

ALTER TABLE [dbo].[datVehicles] CHECK CONSTRAINT [FK_datVehicles_luVehicleTypes]
GO

USE [SoS_Script_Test]
GO

/****** Object:  Table [dbo].[datVehicleCleaning]    Script Date: 3/25/2018 8:58:54 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[datVehicleCleaning](
	[CleaningID] [int] IDENTITY(1,1) NOT NULL,
	[VehicleID] [int] NOT NULL,
	[EmployeeID] [int] NOT NULL,
	[Date] [date] NOT NULL,
 CONSTRAINT [PK_datVehicleCleaning] PRIMARY KEY CLUSTERED 
(
	[CleaningID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[datVehicleCleaning]  WITH CHECK ADD  CONSTRAINT [FK_datVehicleCleaning_datEmployees] FOREIGN KEY([EmployeeID])
REFERENCES [dbo].[datEmployees] ([EmployeeID])
ON UPDATE CASCADE
GO

ALTER TABLE [dbo].[datVehicleCleaning] CHECK CONSTRAINT [FK_datVehicleCleaning_datEmployees]
GO

ALTER TABLE [dbo].[datVehicleCleaning]  WITH CHECK ADD  CONSTRAINT [FK_datVehicleCleaning_datVehicles] FOREIGN KEY([VehicleID])
REFERENCES [dbo].[datVehicles] ([VehicleID])
ON UPDATE CASCADE
GO

ALTER TABLE [dbo].[datVehicleCleaning] CHECK CONSTRAINT [FK_datVehicleCleaning_datVehicles]
GO

USE [SoS_Script_Test]
GO

/****** Object:  Table [dbo].[datShipments]    Script Date: 3/25/2018 8:58:09 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[datShipments](
	[ShipmentID] [int] IDENTITY(1,1) NOT NULL,
	[AddressID] [int] NOT NULL,
	[OrderNumber] [int] NOT NULL,
	[VehicleID] [int] NOT NULL,
 CONSTRAINT [PK_dboShipments] PRIMARY KEY CLUSTERED 
(
	[ShipmentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[datShipments]  WITH CHECK ADD  CONSTRAINT [FK_datShipments_datAddresses] FOREIGN KEY([AddressID])
REFERENCES [dbo].[datAddresses] ([AddressID])
ON UPDATE CASCADE
GO

ALTER TABLE [dbo].[datShipments] CHECK CONSTRAINT [FK_datShipments_datAddresses]
GO

ALTER TABLE [dbo].[datShipments]  WITH CHECK ADD  CONSTRAINT [FK_datShipments_datCustomerOrders] FOREIGN KEY([OrderNumber])
REFERENCES [dbo].[datClientOrders] ([OrderNumber])
ON UPDATE CASCADE
GO

ALTER TABLE [dbo].[datShipments] CHECK CONSTRAINT [FK_datShipments_datCustomerOrders]
GO

ALTER TABLE [dbo].[datShipments]  WITH CHECK ADD  CONSTRAINT [FK_datShipments_datVehicles] FOREIGN KEY([VehicleID])
REFERENCES [dbo].[datVehicles] ([VehicleID])
ON UPDATE CASCADE
GO

ALTER TABLE [dbo].[datShipments] CHECK CONSTRAINT [FK_datShipments_datVehicles]
GO

USE [SoS_Script_Test]
GO

/****** Object:  Table [dbo].[datPurchaseOrders]    Script Date: 4/2/2018 1:35:47 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[datPurchaseOrders](
	[PurchaseID] [int] IDENTITY(1,1) NOT NULL,
	[PONumber] [int] NOT NULL,
	[VendorID] [int] NOT NULL,
	[Date] [datetime] NOT NULL,
 CONSTRAINT [PK_datPurchaseOrders] PRIMARY KEY CLUSTERED 
(
	[PurchaseID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[datPurchaseOrders]  WITH CHECK ADD  CONSTRAINT [FK_datPurchaseOrders_datVendors] FOREIGN KEY([VendorID])
REFERENCES [dbo].[datVendors] ([VendorID])
ON UPDATE CASCADE
GO

ALTER TABLE [dbo].[datPurchaseOrders] CHECK CONSTRAINT [FK_datPurchaseOrders_datVendors]
GO


USE [SoS_Script_Test]
GO

/****** Object:  Table [dbo].[luUnits]    Script Date: 4/2/2018 1:48:20 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[luUnits](
	[UnitsID] [int] IDENTITY(1,1) NOT NULL,
	[Units] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_luUnits] PRIMARY KEY CLUSTERED 
(
	[UnitsID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


USE [SoS_Script_Test]
GO

/****** Object:  Table [dbo].[luIngredients]    Script Date: 4/2/2018 1:42:03 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[luIngredients](
	[IngredientID] [int] IDENTITY(1,1) NOT NULL,
	[Ingredient] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_luIngredients] PRIMARY KEY CLUSTERED 
(
	[IngredientID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


USE [SoS_Script_Test]
GO

/****** Object:  Table [dbo].[datIngredientInventory]    Script Date: 4/2/2018 1:33:19 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[datIngredientInventory](
	[IngInvID] [int] IDENTITY(1,1) NOT NULL,
	[PurchaseID] [int] NOT NULL,
	[IngredientID] [int] NOT NULL,
	[Amount] [float] NOT NULL,
	[UnitsID] [int] NOT NULL,
	[ExpDate] [date] NOT NULL,
 CONSTRAINT [PK_datIngredientInventory] PRIMARY KEY CLUSTERED 
(
	[IngInvID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[datIngredientInventory]  WITH CHECK ADD  CONSTRAINT [FK_datIngredientInventory_datPurchaseOrders] FOREIGN KEY([PurchaseID])
REFERENCES [dbo].[datPurchaseOrders] ([PurchaseID])
ON UPDATE CASCADE
GO

ALTER TABLE [dbo].[datIngredientInventory] CHECK CONSTRAINT [FK_datIngredientInventory_datPurchaseOrders]
GO

ALTER TABLE [dbo].[datIngredientInventory]  WITH CHECK ADD  CONSTRAINT [FK_datIngredientInventory_luIngredients] FOREIGN KEY([IngredientID])
REFERENCES [dbo].[luIngredients] ([IngredientID])
ON UPDATE CASCADE
GO

ALTER TABLE [dbo].[datIngredientInventory] CHECK CONSTRAINT [FK_datIngredientInventory_luIngredients]
GO

ALTER TABLE [dbo].[datIngredientInventory]  WITH CHECK ADD  CONSTRAINT [FK_datIngredientInventory_luUnits] FOREIGN KEY([UnitsID])
REFERENCES [dbo].[luUnits] ([UnitsID])
ON UPDATE CASCADE
GO

ALTER TABLE [dbo].[datIngredientInventory] CHECK CONSTRAINT [FK_datIngredientInventory_luUnits]
GO


USE [SoS_Script_Test]
GO

/****** Object:  Table [dbo].[luAssemblyTypes]    Script Date: 4/2/2018 1:40:46 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[luAssemblyTypes](
	[AssemblyTypeID] [int] IDENTITY(1,1) NOT NULL,
	[AssemblyType] [nchar](20) NOT NULL,
 CONSTRAINT [PK_luAssemblyTypes] PRIMARY KEY CLUSTERED 
(
	[AssemblyTypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


USE [SoS_Script_Test]
GO

/****** Object:  Table [dbo].[datAssembly]    Script Date: 4/2/2018 1:31:40 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[datAssembly](
	[AssemblyID] [int] IDENTITY(1,1) NOT NULL,
	[AssemblyTypeID] [int] NOT NULL,
	[DateTime] [datetime] NOT NULL,
	[Expiry] [datetime] NOT NULL,
 CONSTRAINT [PK_datAssembly] PRIMARY KEY CLUSTERED 
(
	[AssemblyID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[datAssembly]  WITH CHECK ADD  CONSTRAINT [FK_datAssembly_luAssemblyTypes] FOREIGN KEY([AssemblyTypeID])
REFERENCES [dbo].[luAssemblyTypes] ([AssemblyTypeID])
ON UPDATE CASCADE
GO

ALTER TABLE [dbo].[datAssembly] CHECK CONSTRAINT [FK_datAssembly_luAssemblyTypes]
GO


USE [SoS_Script_Test]
GO

/****** Object:  Table [dbo].[jncAssembly]    Script Date: 4/2/2018 1:38:46 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[jncAssembly](
	[IngredientAssemblyID] [int] IDENTITY(1,1) NOT NULL,
	[AssemblyID] [int] NULL,
	[Quantity] [float] NOT NULL,
	[UnitsID] [int] NOT NULL,
	[IngInvID] [int] NOT NULL,
 CONSTRAINT [PK_jncAssembly] PRIMARY KEY CLUSTERED 
(
	[IngredientAssemblyID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[jncAssembly]  WITH NOCHECK ADD  CONSTRAINT [FK_jncAssembly_datAssembly] FOREIGN KEY([IngInvID])
REFERENCES [dbo].[datAssembly] ([AssemblyID])
GO

ALTER TABLE [dbo].[jncAssembly] CHECK CONSTRAINT [FK_jncAssembly_datAssembly]
GO

ALTER TABLE [dbo].[jncAssembly]  WITH NOCHECK ADD  CONSTRAINT [FK_jncAssembly_datIngredientInventory] FOREIGN KEY([IngInvID])
REFERENCES [dbo].[datIngredientInventory] ([IngInvID])
ON UPDATE CASCADE
GO

ALTER TABLE [dbo].[jncAssembly] CHECK CONSTRAINT [FK_jncAssembly_datIngredientInventory]
GO

ALTER TABLE [dbo].[jncAssembly]  WITH CHECK ADD  CONSTRAINT [FK_jncAssembly_luUnits] FOREIGN KEY([UnitsID])
REFERENCES [dbo].[luUnits] ([UnitsID])
GO

ALTER TABLE [dbo].[jncAssembly] CHECK CONSTRAINT [FK_jncAssembly_luUnits]
GO


USE [SoS_Script_Test]
GO

/****** Object:  Table [dbo].[datBoxes]    Script Date: 4/2/2018 1:55:07 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[datBoxes](
	[BoxID] [int] IDENTITY(1,1) NOT NULL,
	[AssemblyID] [int] NOT NULL,
 CONSTRAINT [PK_datBoxes] PRIMARY KEY CLUSTERED 
(
	[BoxID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[datBoxes]  WITH CHECK ADD  CONSTRAINT [FK_datBoxes_datAssembly] FOREIGN KEY([AssemblyID])
REFERENCES [dbo].[datAssembly] ([AssemblyID])
ON UPDATE CASCADE
GO

ALTER TABLE [dbo].[datBoxes] CHECK CONSTRAINT [FK_datBoxes_datAssembly]
GO


USE [SoS_Script_Test]
GO

/****** Object:  Table [dbo].[luTimeTypes]    Script Date: 4/2/2018 1:42:36 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[luTimeTypes](
	[TimeTypeID] [int] IDENTITY(1,1) NOT NULL,
	[TimeType] [nvarchar](20) NULL,
	[IngredientType] [int] NOT NULL,
 CONSTRAINT [PK_luTimeTypes] PRIMARY KEY CLUSTERED 
(
	[TimeTypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[luTimeTypes]  WITH CHECK ADD  CONSTRAINT [FK_luTimeTypes_luAssemblyTypes] FOREIGN KEY([IngredientType])
REFERENCES [dbo].[luAssemblyTypes] ([AssemblyTypeID])
ON UPDATE CASCADE
GO

ALTER TABLE [dbo].[luTimeTypes] CHECK CONSTRAINT [FK_luTimeTypes_luAssemblyTypes]
GO

ALTER TABLE [dbo].[luTimeTypes]  WITH CHECK ADD  CONSTRAINT [FK_luTimeTypes_luIngredients] FOREIGN KEY([IngredientType])
REFERENCES [dbo].[luIngredients] ([IngredientID])
ON UPDATE CASCADE
GO

ALTER TABLE [dbo].[luTimeTypes] CHECK CONSTRAINT [FK_luTimeTypes_luIngredients]
GO


USE [SoS_Script_Test]
GO

/****** Object:  Table [dbo].[HACCPTimes]    Script Date: 4/2/2018 1:38:06 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[HACCPTimes](
	[TimeID] [int] IDENTITY(1,1) NOT NULL,
	[ParentID] [int] NOT NULL,
	[DateTime] [datetime] NOT NULL,
	[TimeTypeID] [int] NOT NULL,
	[EmployeeID] [int] NOT NULL,
 CONSTRAINT [PK_HACCPTimes] PRIMARY KEY CLUSTERED 
(
	[TimeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[HACCPTimes]  WITH CHECK ADD  CONSTRAINT [FK_HACCPTimes_luTimeTypes] FOREIGN KEY([TimeTypeID])
REFERENCES [dbo].[luTimeTypes] ([TimeTypeID])
ON UPDATE CASCADE
GO

ALTER TABLE [dbo].[HACCPTimes] CHECK CONSTRAINT [FK_HACCPTimes_luTimeTypes]
GO


USE [SoS_Script_Test]
GO

/****** Object:  Table [dbo].[HACCPTemps]    Script Date: 4/2/2018 1:37:33 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[HACCPTemps](
	[TempID] [int] IDENTITY(1,1) NOT NULL,
	[ParentID] [int] NOT NULL,
	[Temp] [float] NOT NULL,
	[DateTime] [datetime] NOT NULL,
 CONSTRAINT [PK_HACCPTemps] PRIMARY KEY CLUSTERED 
(
	[TempID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


USE [SoS_Script_Test]
GO

/****** Object:  Table [dbo].[datMeasurements]    Script Date: 4/2/2018 1:34:28 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[datMeasurements](
	[MeasurementID] [int] IDENTITY(1,1) NOT NULL,
	[ParentID] [int] NOT NULL,
	[DateTime] [datetime] NOT NULL,
	[Thickness] [float] NOT NULL,
	[Weight] [float] NOT NULL,
	[Length] [float] NOT NULL,
	[Width] [float] NOT NULL,
	[Employee] [int] NOT NULL,
 CONSTRAINT [PK_datMeasurements] PRIMARY KEY CLUSTERED 
(
	[MeasurementID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


