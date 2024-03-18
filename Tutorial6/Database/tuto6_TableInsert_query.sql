USE [staffData]
GO

/****** Object:  Table [dbo].[staffTable]    Script Date: 3/19/2024 2:28:09 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[staffTable](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[staff_no] [varchar](100) NOT NULL,
	[staff_name] [nvarchar](100) NOT NULL,
	[join_from] [date] NOT NULL,
	[dob] [date] NOT NULL,
	[staff_type] [smallint] NOT NULL,
	[nrc_number] [nvarchar](100) NOT NULL,
	[gender] [smallint] NOT NULL,
	[phone_no_1] [nvarchar](50) NOT NULL,
	[phone_no_2] [nvarchar](50) NULL,
	[photo] [nvarchar](200) NULL,
	[address] [nvarchar](500) NULL,
	[is_deleted] [smallint] NOT NULL,
 CONSTRAINT [PK_staffTable] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


