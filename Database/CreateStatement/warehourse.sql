USE [Inventory]
GO

/****** Object:  Table [dbo].[warehouse]    Script Date: 9/12/2015 10:16:53 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[warehouse](
	[warehouse_id] [bigint] IDENTITY(1,1) NOT NULL,
	[warehouse_code] [nvarchar](50) NOT NULL,
	[warehouse_name] [nvarchar](128) NOT NULL,
	[warehouse_parent_id] [bigint] NULL,
	[enabled] [bit] NULL,
	[description] [nvarchar](128) NULL,
	[created_date] [datetime] NULL,
	[create_user] [nvarchar](50) NULL,
	[update_date] [datetime] NULL,
	[update_user] [nvarchar](50) NULL,
 CONSTRAINT [PK_Warehouse] PRIMARY KEY CLUSTERED 
(
	[warehouse_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[warehouse] ADD  CONSTRAINT [DF_Warehouse_CreatedDate]  DEFAULT (getdate()) FOR [created_date]
GO

ALTER TABLE [dbo].[warehouse] ADD  CONSTRAINT [DF_Warehouse_UpdateDate]  DEFAULT (getdate()) FOR [update_date]
GO

