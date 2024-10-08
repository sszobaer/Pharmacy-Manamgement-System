USE [Pharmacy Management System]
GO
/****** Object:  Table [dbo].[AdminTable]    Script Date: 13/09/2024 01:39:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AdminTable](
	[name] [varchar](50) NULL,
	[username] [varchar](50) NOT NULL,
	[email] [varchar](50) NULL,
	[contactno] [int] NULL,
	[pass] [varchar](50) NULL,
	[dateofbirth] [date] NULL,
	[gender] [varchar](50) NULL,
	[address] [varchar](50) NULL,
 CONSTRAINT [PK_AdminTable] PRIMARY KEY CLUSTERED 
(
	[username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
