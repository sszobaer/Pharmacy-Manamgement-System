USE [Pharmacy Management System]
GO
/****** Object:  Table [dbo].[RequestOrderTable]    Script Date: 13/09/2024 01:39:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RequestOrderTable](
	[productname] [varchar](50) NOT NULL,
	[strength] [varchar](50) NOT NULL,
	[quantity] [int] NOT NULL,
	[receivername] [varchar](50) NOT NULL,
	[receiverphone] [varchar](50) NOT NULL,
	[region] [varchar](50) NOT NULL,
	[city] [varchar](50) NOT NULL,
	[area] [varchar](50) NOT NULL,
	[address] [varchar](50) NOT NULL,
	[receiveremail] [varchar](50) NULL
) ON [PRIMARY]
GO
