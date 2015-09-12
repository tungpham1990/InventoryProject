USE [Inventory]
GO

/****** Object:  Table [dbo].[transaction_master]    Script Date: 9/12/2015 10:15:24 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[transaction_master](
	[transaction_master_id] [bigint] IDENTITY(1,1) NOT NULL,
	[transaction_code] [nvarchar](50) NOT NULL,
	[transaction_type_id] [bigint] NOT NULL,
	[transaction_date] [datetime] NOT NULL,
	[received_warehouse_id] [bigint] NULL,
	[delivered_warehosuse_id] [bigint] NULL,
	[receiver] [nvarchar](128) NULL,
	[deliver] [nvarchar](128) NULL,
	[customer_id] [bigint] NULL,
	[supplier_id] [bigint] NULL,
	[total_price] [decimal](18, 3) NULL,
	[percent_charges] [decimal](18, 3) NULL,
	[total_charges] [decimal](18, 3) NULL,
	[total_amount] [decimal](18, 3) NULL,
	[enabled] [bit] NULL,
	[Description] [nvarchar](128) NULL,
	[created_date] [datetime] NULL,
	[create_user] [nvarchar](50) NULL,
	[update_date] [datetime] NULL,
	[update_user] [nvarchar](50) NULL,
 CONSTRAINT [PK_TransactionMaster] PRIMARY KEY CLUSTERED 
(
	[transaction_master_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[transaction_master] ADD  CONSTRAINT [DF_TransactionMaster_CreatedDate]  DEFAULT (getdate()) FOR [created_date]
GO

ALTER TABLE [dbo].[transaction_master] ADD  CONSTRAINT [DF_TransactionMaster_UpdateDate]  DEFAULT (getdate()) FOR [update_date]
GO

ALTER TABLE [dbo].[transaction_master]  WITH CHECK ADD  CONSTRAINT [FK_transaction_master_supplier] FOREIGN KEY([supplier_id])
REFERENCES [dbo].[supplier] ([supplier_id])
GO

ALTER TABLE [dbo].[transaction_master] CHECK CONSTRAINT [FK_transaction_master_supplier]
GO

ALTER TABLE [dbo].[transaction_master]  WITH CHECK ADD  CONSTRAINT [FK_transaction_master_transaction_master] FOREIGN KEY([customer_id])
REFERENCES [dbo].[customer] ([customer_id])
GO

ALTER TABLE [dbo].[transaction_master] CHECK CONSTRAINT [FK_transaction_master_transaction_master]
GO

ALTER TABLE [dbo].[transaction_master]  WITH CHECK ADD  CONSTRAINT [FK_transaction_master_warehouse] FOREIGN KEY([delivered_warehosuse_id])
REFERENCES [dbo].[warehouse] ([warehouse_id])
GO

ALTER TABLE [dbo].[transaction_master] CHECK CONSTRAINT [FK_transaction_master_warehouse]
GO

ALTER TABLE [dbo].[transaction_master]  WITH CHECK ADD  CONSTRAINT [FK_transaction_master_warehouse1] FOREIGN KEY([received_warehouse_id])
REFERENCES [dbo].[warehouse] ([warehouse_id])
GO

ALTER TABLE [dbo].[transaction_master] CHECK CONSTRAINT [FK_transaction_master_warehouse1]
GO

