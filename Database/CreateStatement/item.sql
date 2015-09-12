USE [Inventory]
GO

/****** Object:  Table [dbo].[item]    Script Date: 9/12/2015 10:14:38 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[item](
	[item_id] [bigint] IDENTITY(1,1) NOT NULL,
	[item_code] [nvarchar](50) NOT NULL,
	[item_name] [nvarchar](128) NOT NULL,
	[features] [nvarchar](512) NULL,
	[specifications] [nvarchar](512) NULL,
	[unit_id] [bigint] NULL,
	[category_item_id] [bigint] NULL,
	[enabled] [bit] NULL,
	[description] [nvarchar](128) NULL,
	[created_date] [datetime] NULL,
	[create_user] [nvarchar](50) NULL,
	[update_date] [datetime] NULL,
	[update_user] [nvarchar](50) NULL,
 CONSTRAINT [PK_Item] PRIMARY KEY CLUSTERED 
(
	[item_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[item] ADD  CONSTRAINT [DF_Item_CreatedDate]  DEFAULT (getdate()) FOR [created_date]
GO

ALTER TABLE [dbo].[item] ADD  CONSTRAINT [DF_Item_UpdateDate]  DEFAULT (getdate()) FOR [update_date]
GO

ALTER TABLE [dbo].[item]  WITH CHECK ADD  CONSTRAINT [FK_item_category_item] FOREIGN KEY([category_item_id])
REFERENCES [dbo].[category_item] ([category_item_id])
GO

ALTER TABLE [dbo].[item] CHECK CONSTRAINT [FK_item_category_item]
GO

ALTER TABLE [dbo].[item]  WITH CHECK ADD  CONSTRAINT [FK_item_unit] FOREIGN KEY([unit_id])
REFERENCES [dbo].[unit] ([unit_id])
GO

ALTER TABLE [dbo].[item] CHECK CONSTRAINT [FK_item_unit]
GO

