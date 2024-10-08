USE [Pharmacy Management System]
GO
/****** Object:  Table [dbo].[ReviewsTable]    Script Date: 13/09/2024 01:39:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ReviewsTable](
	[username] [varchar](50) NOT NULL,
	[reviews] [varchar](max) NULL,
 CONSTRAINT [PK_ReviewsTable] PRIMARY KEY CLUSTERED 
(
	[username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[ReviewsTable]  WITH CHECK ADD  CONSTRAINT [Fk4] FOREIGN KEY([username])
REFERENCES [dbo].[SignUpTable] ([username])
GO
ALTER TABLE [dbo].[ReviewsTable] CHECK CONSTRAINT [Fk4]
GO
