USE [Inventory]
GO

/****** Object:  Table [dbo].[transaction_detail]    Script Date: 9/12/2015 10:15:44 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[transaction_detail](
	[transaction_detail_id] [bigint] IDENTITY(1,1) NOT NULL,
	[transaction_master_id] [bigint] NOT NULL,
	[category_item_id] [bigint] NOT NULL,
	[item_id] [bigint] NOT NULL,
	[price] [decimal](18, 3) NULL,
	[unit_id] [bigint] NULL,
	[quantity] [decimal](18, 3) NULL,
	[total_price] [decimal](18, 3) NULL,
	[percent_charges] [decimal](18, 3) NULL,
	[total_charges] [decimal](18, 3) NULL,
	[total_amount] [decimal](18, 3) NULL,
	[description] [nvarchar](128) NULL,
	[created_date] [datetime] NULL,
	[create_user] [nvarchar](50) NULL,
	[update_date] [datetime] NULL,
	[update_user] [nvarchar](50) NULL,
 CONSTRAINT [PK_TransactionDetail] PRIMARY KEY CLUSTERED 
(
	[transaction_detail_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[transaction_detail] ADD  CONSTRAINT [DF_TransactionDetail_CreatedDate]  DEFAULT (getdate()) FOR [created_date]
GO

ALTER TABLE [dbo].[transaction_detail] ADD  CONSTRAINT [DF_TransactionDetail_UpdateDate]  DEFAULT (getdate()) FOR [update_date]
GO

ALTER TABLE [dbo].[transaction_detail]  WITH CHECK ADD  CONSTRAINT [FK_transaction_detail_transaction_master] FOREIGN KEY([transaction_master_id])
REFERENCES [dbo].[transaction_master] ([transaction_master_id])
GO

ALTER TABLE [dbo].[transaction_detail] CHECK CONSTRAINT [FK_transaction_detail_transaction_master]
GO

