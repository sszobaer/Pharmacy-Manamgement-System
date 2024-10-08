USE [Pharmacy Management System]
GO
/****** Object:  Table [dbo].[ProductTable]    Script Date: 13/09/2024 01:39:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductTable](
	[pID] [varchar](50) NOT NULL,
	[pName] [varchar](50) NULL,
	[price] [float] NULL,
	[pStatus] [varchar](50) NULL,
	[username] [varchar](50) NULL,
 CONSTRAINT [PK_ProductTable] PRIMARY KEY CLUSTERED 
(
	[pID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
