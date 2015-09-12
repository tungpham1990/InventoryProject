USE [Inventory]
GO

/****** Object:  Table [dbo].[transaction_type]    Script Date: 9/12/2015 10:16:26 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[transaction_type](
	[transaction_type_id] [bigint] IDENTITY(1,1) NOT NULL,
	[transaction_type_code] [nvarchar](50) NULL,
	[enabled] [bit] NULL,
	[description] [nvarchar](128) NULL,
	[created_date] [datetime] NULL,
	[create_user] [nvarchar](50) NULL,
	[update_date] [datetime] NULL,
	[update_user] [nvarchar](50) NULL,
 CONSTRAINT [PK_TransactionType] PRIMARY KEY CLUSTERED 
(
	[transaction_type_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[transaction_type] ADD  CONSTRAINT [DF_TransactionType_CreatedDate]  DEFAULT (getdate()) FOR [created_date]
GO

ALTER TABLE [dbo].[transaction_type] ADD  CONSTRAINT [DF_TransactionType_UpdateDate]  DEFAULT (getdate()) FOR [update_date]
GO

