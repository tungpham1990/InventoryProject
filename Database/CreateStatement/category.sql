USE [Inventory]
GO

/****** Object:  Table [dbo].[category_item]    Script Date: 9/12/2015 10:14:53 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[category_item](
	[category_item_id] [bigint] IDENTITY(1,1) NOT NULL,
	[category_item_code] [nvarchar](50) NOT NULL,
	[category_item_name] [nvarchar](128) NOT NULL,
	[features] [nvarchar](512) NULL,
	[specifications] [nvarchar](512) NULL,
	[unit_id] [bigint] NULL,
	[category_item_parent_id] [bigint] NULL,
	[node_level] [int] NULL,
	[enabled] [bit] NULL,
	[description] [nvarchar](128) NULL,
	[created_date] [datetime] NULL,
	[create_user] [nvarchar](50) NULL,
	[update_date] [datetime] NULL,
	[update_user] [nvarchar](50) NULL,
 CONSTRAINT [PK_CategoryItem] PRIMARY KEY CLUSTERED 
(
	[category_item_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[category_item] ADD  CONSTRAINT [DF_CategoryItem_CreatedDate]  DEFAULT (getdate()) FOR [created_date]
GO

ALTER TABLE [dbo].[category_item] ADD  CONSTRAINT [DF_CategoryItem_UpdateDate]  DEFAULT (getdate()) FOR [update_date]
GO

