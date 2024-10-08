USE [Pharmacy Management System]
GO
/****** Object:  Table [dbo].[SalaryTable]    Script Date: 13/09/2024 01:39:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SalaryTable](
	[salaryCode] [int] IDENTITY(1,1) NOT NULL,
	[employee] [int] NOT NULL,
	[attendence] [int] NOT NULL,
	[period] [varchar](50) NOT NULL,
	[amount] [int] NOT NULL,
	[payDate] [date] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[salaryCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[SalaryTable]  WITH CHECK ADD  CONSTRAINT [FK2] FOREIGN KEY([employee])
REFERENCES [dbo].[EmployeeTable] ([empID])
GO
ALTER TABLE [dbo].[SalaryTable] CHECK CONSTRAINT [FK2]
GO
