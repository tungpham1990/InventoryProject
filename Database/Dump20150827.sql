/*
Navicat SQL Server Data Transfer

Source Server         : local_inventory
Source Server Version : 110000
Source Host           : localhost:1433
Source Database       : inventory
Source Schema         : dbo

Target Server Type    : SQL Server
Target Server Version : 110000
File Encoding         : 65001

Date: 2015-08-27 20:24:08
*/


-- ----------------------------
-- Table structure for categoryitem
-- ----------------------------
DROP TABLE [categoryitem]
GO
CREATE TABLE [categoryitem] (
[CategoryItemId] bigint NOT NULL ,
[CategoryItemCode] nvarchar(32) NOT NULL ,
[CategoryItemName] nvarchar(128) NOT NULL ,
[Features] nvarchar(512) NULL ,
[Specifications] nvarchar(512) NULL ,
[UnitId] bigint NULL ,
[CategoryItemParentId] bigint NULL ,
[Enabled] tinyint NULL ,
[Description] nvarchar(128) NULL ,
[CreatedDate] datetime2(7) NULL ,
[CreateUser] nvarchar(32) NULL ,
[UpdateDate] datetime2(7) NULL ,
[UpdateUser] nvarchar(32) NULL 
)


GO

-- ----------------------------
-- Records of categoryitem
-- ----------------------------
BEGIN TRANSACTION
GO
INSERT INTO [categoryitem] ([CategoryItemId], [CategoryItemCode], [CategoryItemName], [Features], [Specifications], [UnitId], [CategoryItemParentId], [Enabled], [Description], [CreatedDate], [CreateUser], [UpdateDate], [UpdateUser]) VALUES (N'1', N'DIENTHOAI', N'Điện thoại', null, null, null, null, N'1', null, N'2015-08-26 15:37:00.0000000', N'Admin', N'2015-08-26 15:37:00.0000000', N'Admin'), (N'2', N'APPLE', N'APPLE', null, null, null, null, N'1', null, N'2015-08-26 15:37:00.0000000', N'Admin', N'2015-08-26 15:37:00.0000000', N'Admin'), (N'3', N'TABLET', N'TABLET', null, null, null, null, N'1', N'TABLET', N'2015-08-26 15:38:34.0000000', N'Admin', N'2015-08-26 15:38:34.0000000', N'Admin'), (N'4', N'LAPTOP', N'LAPTOP', N'LAPTOP', null, null, null, N'1', null, N'2015-08-26 15:38:34.0000000', N'Admin', N'2015-08-26 15:38:34.0000000', N'Admin'), (N'5', N'iPhone', N'iPhone', N'iPhone', N'iPhone', null, N'2', N'1', N'iPhone', N'2015-08-26 15:40:28.0000000', N'Admin', N'2015-08-26 15:40:28.0000000', N'Admin'), (N'6', N'iPad', N'iPad', N'iPad', N'iPad', null, N'2', N'1', N'iPad', N'2015-08-26 15:40:28.0000000', N'Admin', N'2015-08-26 15:40:28.0000000', N'Admin'), (N'7', N'iPod', N'iPod', N'iPod', N'iPod', null, N'2', N'1', N'iPod', N'2015-08-26 15:41:46.0000000', N'Admin', N'2015-08-26 15:41:46.0000000', N'Admin'), (N'8', N'Macbook', N'Macbook', N'Macbook', N'Macbook', null, N'2', N'1', N'Macbook', N'2015-08-26 15:41:46.0000000', N'Admin', N'2015-08-26 15:41:46.0000000', N'Admin'), (N'9', N'iMac', N'iMac', N'iMac', N'iMac', null, N'2', N'1', N'iMac', N'2015-08-26 15:43:17.0000000', N'Admin', N'2015-08-26 15:43:17.0000000', N'Admin'), (N'10', N'Phụ kiện apple', N'Phụ kiện apple', N'Phụ kiện apple', N'Phụ kiện apple', null, N'2', N'1', N'Admin', N'2015-08-26 15:43:17.0000000', N'Admin', N'2015-08-26 15:43:17.0000000', N'Admin'), (N'11', N'iPhone 6', N'iPhone 6', N'Màn hình: Retina HD, 4.7", 750 x 1334 pixels
CPU: 64-bit, chip A8, M8
Hệ điều hành: iOs 8.0
Camera chính: 8.0 MP, Quay phim FullHD
Camera phụ: 1.2 MP, 720p
Dung lượng: 16 GB/64 GB/128 GB 
Có 3 màu: Silver/Gold/Space Gray', N'Màn hình: Retina HD, 4.7", 750 x 1334 pixels
CPU: 64-bit, chip A8, M8
Hệ điều hành: iOs 8.0
Camera chính: 8.0 MP, Quay phim FullHD
Camera phụ: 1.2 MP, 720p
Dung lượng: 16 GB/64 GB/128 GB 
Có 3 màu: Silver/Gold/Space Gray', N'10', N'5', N'1', null, N'2015-08-26 15:46:05.0000000', N'Admin', N'2015-08-26 15:46:05.0000000', N'Admin'), (N'12', N'iPhone 6 plus', N'iPhone 6 plus', N'Màn hình: Retina HD, 5.5", 1080 x 1920 pixels
CPU: 64-bit, chip A8, M8
Hệ điều hành: iOS 8.0
Camera chính: 8.0 MP, Quay phim FullHD 
Camera phụ : 1.2 MP, 720p
Dung lượng: 16 GB/64 GB/128 GB
Có 3 màu: Silver/Gold/Space Gray', N'Màn hình: Retina HD, 5.5", 1080 x 1920 pixels
CPU: 64-bit, chip A8, M8
Hệ điều hành: iOS 8.0
Camera chính: 8.0 MP, Quay phim FullHD 
Camera phụ : 1.2 MP, 720p
Dung lượng: 16 GB/64 GB/128 GB
Có 3 màu: Silver/Gold/Space Gray', N'10', N'5', N'1', null, N'2015-08-26 15:46:05.0000000', N'Admin', N'2015-08-26 15:46:05.0000000', N'Admin')
GO
GO
COMMIT TRANSACTION
GO

-- ----------------------------
-- Table structure for company
-- ----------------------------
DROP TABLE [company]
GO
CREATE TABLE [company] (
[CompanyId] bigint NOT NULL ,
[CompanyCode] nvarchar(32) NOT NULL ,
[CompanyShortName] nvarchar(64) NULL ,
[CompanyName] nvarchar(128) NULL ,
[CompanyParentId] bigint NULL ,
[IsBranch] tinyint NULL ,
[Enabled] tinyint NULL ,
[Description] nvarchar(128) NULL ,
[CreatedDate] datetime2(7) NULL ,
[CreateUser] nvarchar(32) NULL ,
[UpdateDate] datetime2(7) NULL ,
[UpdateUser] nvarchar(32) NULL 
)


GO

-- ----------------------------
-- Records of company
-- ----------------------------
BEGIN TRANSACTION
GO
INSERT INTO [company] ([CompanyId], [CompanyCode], [CompanyShortName], [CompanyName], [CompanyParentId], [IsBranch], [Enabled], [Description], [CreatedDate], [CreateUser], [UpdateDate], [UpdateUser]) VALUES (N'1', N'FPT', N'FPT', N'FPT IS', null, null, N'1', N'FPT IS', N'2015-08-26 15:22:07.0000000', N'Admin', N'2015-08-26 15:22:07.0000000', N'Admin'), (N'2', N'Primelabo', N'Primelabo', N'Primelabo', null, null, N'1', N'Primelabo', N'2015-08-26 15:22:07.0000000', N'Admin', N'2015-08-26 15:22:07.0000000', N'Admin'), (N'3', N'PHCM', N'Primelabo HCM', N'Chi nhánh Primelabo HCM', N'2', N'1', N'1', N'Chi nhánh Primelabo HCM', N'2015-08-26 15:26:21.0000000', N'Admin', N'2015-08-26 15:26:21.0000000', N'Admin')
GO
GO
COMMIT TRANSACTION
GO

-- ----------------------------
-- Table structure for customer
-- ----------------------------
DROP TABLE [customer]
GO
CREATE TABLE [customer] (
[CustomerId] bigint NOT NULL ,
[CustomerCode] nvarchar(32) NOT NULL ,
[CustomerShortName] nvarchar(64) NOT NULL ,
[CustomerName] nvarchar(128) NOT NULL ,
[IsPersonal] tinyint NULL ,
[Enabled] tinyint NULL ,
[Description] nvarchar(128) NULL ,
[CreatedDate] datetime2(7) NULL ,
[CreateUser] nvarchar(32) NULL ,
[UpdateDate] datetime2(7) NULL ,
[UpdateUser] nvarchar(32) NULL 
)


GO

-- ----------------------------
-- Records of customer
-- ----------------------------
BEGIN TRANSACTION
GO
INSERT INTO [customer] ([CustomerId], [CustomerCode], [CustomerShortName], [CustomerName], [IsPersonal], [Enabled], [Description], [CreatedDate], [CreateUser], [UpdateDate], [UpdateUser]) VALUES (N'1', N'Lavie', N'Lavie', N'Lavie', null, N'1', N'Lavie', N'2015-08-26 15:27:39.0000000', N'Admin', N'2015-08-26 15:27:39.0000000', N'Admin'), (N'2', N'A.Huy', N'A.Huy', N'A.Huy', N'1', N'1', N'A.Huy', N'2015-08-26 15:27:39.0000000', N'Admin', N'2015-08-26 15:27:39.0000000', N'Admin')
GO
GO
COMMIT TRANSACTION
GO

-- ----------------------------
-- Table structure for item
-- ----------------------------
DROP TABLE [item]
GO
CREATE TABLE [item] (
[ItemId] bigint NOT NULL ,
[ItemCode] nvarchar(32) NOT NULL ,
[ItemName] nvarchar(128) NOT NULL ,
[Features] nvarchar(512) NULL ,
[Specifications] nvarchar(512) NULL ,
[UnitId] bigint NULL ,
[CategoryItemsId] bigint NULL ,
[Enabled] tinyint NULL ,
[Description] nvarchar(128) NULL ,
[CreatedDate] datetime2(7) NULL ,
[CreateUser] nvarchar(32) NULL ,
[UpdateDate] datetime2(7) NULL ,
[UpdateUser] nvarchar(32) NULL 
)


GO

-- ----------------------------
-- Records of item
-- ----------------------------
BEGIN TRANSACTION
GO
COMMIT TRANSACTION
GO

-- ----------------------------
-- Table structure for supplier
-- ----------------------------
DROP TABLE [supplier]
GO
CREATE TABLE [supplier] (
[SupplierId] bigint NOT NULL ,
[SupplierCode] nvarchar(32) NOT NULL ,
[SupplierShortName] nvarchar(64) NOT NULL ,
[SupplierName] nvarchar(128) NOT NULL ,
[Enabled] tinyint NULL ,
[Description] nvarchar(128) NULL ,
[CreatedDate] datetime2(7) NULL ,
[CreateUser] nvarchar(32) NULL ,
[UpdateDate] datetime2(7) NULL ,
[UpdateUser] nvarchar(32) NULL 
)


GO

-- ----------------------------
-- Records of supplier
-- ----------------------------
BEGIN TRANSACTION
GO
INSERT INTO [supplier] ([SupplierId], [SupplierCode], [SupplierShortName], [SupplierName], [Enabled], [Description], [CreatedDate], [CreateUser], [UpdateDate], [UpdateUser]) VALUES (N'1', N'PTSC MARINE', N'PTSC MARINE', N'PTSC MARINE', N'1', N'PTSC MARINE', N'2015-08-26 15:28:44.0000000', N'Admin', N'2015-08-26 15:28:44.0000000', N'Admin'), (N'2', N'FPT', N'FPT', N'FPT', N'1', N'FPT', N'2015-08-26 15:28:44.0000000', N'Admin', N'2015-08-26 15:28:44.0000000', N'Admin')
GO
GO
COMMIT TRANSACTION
GO

-- ----------------------------
-- Table structure for transactiondetail
-- ----------------------------
DROP TABLE [transactiondetail]
GO
CREATE TABLE [transactiondetail] (
[TransactionDetailId] bigint NOT NULL ,
[TransactionMasterId] bigint NOT NULL ,
[CategoryItemId] bigint NULL ,
[ItemId] bigint NOT NULL ,
[Price] decimal(10) NULL ,
[UnitId] bigint NULL ,
[Quantity] decimal(10) NULL ,
[TotalPrice] decimal(10) NULL ,
[PercentCharges] decimal(10) NULL ,
[TotalCharges] decimal(10) NULL ,
[TotalAmount] decimal(10) NULL ,
[Description] nvarchar(128) NULL ,
[CreatedDate] datetime2(7) NULL ,
[CreateUser] nvarchar(32) NULL ,
[UpdateDate] datetime2(7) NULL ,
[UpdateUser] nvarchar(32) NULL 
)


GO

-- ----------------------------
-- Records of transactiondetail
-- ----------------------------
BEGIN TRANSACTION
GO
COMMIT TRANSACTION
GO

-- ----------------------------
-- Table structure for transactionmaster
-- ----------------------------
DROP TABLE [transactionmaster]
GO
CREATE TABLE [transactionmaster] (
[TransactionMasterId] bigint NOT NULL ,
[TransactionCode] nvarchar(32) NOT NULL ,
[TransactionTypeId] bigint NOT NULL ,
[TransactionDate] datetime2(7) NOT NULL ,
[ReceivedWarehouseId] bigint NULL ,
[DeliveredWarehosuseId] bigint NULL ,
[Receiver] nvarchar(128) NULL ,
[Deliver] nvarchar(128) NULL ,
[CustomerId] bigint NULL ,
[SupplierId] bigint NULL ,
[TotalPrice] decimal(10) NULL ,
[PercentCharges] decimal(10) NULL ,
[TotalCharges] decimal(10) NULL ,
[TotalAmount] decimal(10) NULL ,
[CreatedDate] datetime2(7) NULL ,
[CreateUser] nvarchar(32) NULL ,
[UpdateDate] datetime2(7) NULL ,
[UpdateUser] nvarchar(32) NULL 
)


GO

-- ----------------------------
-- Records of transactionmaster
-- ----------------------------
BEGIN TRANSACTION
GO
COMMIT TRANSACTION
GO

-- ----------------------------
-- Table structure for transactiontype
-- ----------------------------
DROP TABLE [transactiontype]
GO
CREATE TABLE [transactiontype] (
[TransactionTypeId] bigint NOT NULL ,
[TransactionTypeCode] nvarchar(32) NOT NULL ,
[Enabled] tinyint NULL ,
[Description] nvarchar(128) NULL ,
[CreatedDate] datetime2(7) NULL ,
[CreateUser] nvarchar(32) NULL ,
[UpdateDate] datetime2(7) NULL ,
[UpdateUser] nvarchar(32) NULL 
)


GO

-- ----------------------------
-- Records of transactiontype
-- ----------------------------
BEGIN TRANSACTION
GO
COMMIT TRANSACTION
GO

-- ----------------------------
-- Table structure for unit
-- ----------------------------
DROP TABLE [unit]
GO
CREATE TABLE [unit] (
[UnitId] bigint NOT NULL ,
[UnitCode] nvarchar(32) NOT NULL ,
[UnitName] nvarchar(64) NOT NULL ,
[Enabled] tinyint NULL ,
[Description] nvarchar(128) NULL ,
[CreatedDate] datetime2(7) NULL ,
[CreateUser] nvarchar(32) NULL ,
[UpdateDate] datetime2(7) NULL ,
[UpdateUser] nvarchar(32) NULL 
)


GO

-- ----------------------------
-- Records of unit
-- ----------------------------
BEGIN TRANSACTION
GO
INSERT INTO [unit] ([UnitId], [UnitCode], [UnitName], [Enabled], [Description], [CreatedDate], [CreateUser], [UpdateDate], [UpdateUser]) VALUES (N'1', N'CAI', N'Cái', N'1', N'Cái', N'2015-08-26 14:59:50.0000000', N'Admin', N'2015-08-26 14:59:50.0000000', N'Admin'), (N'2', N'MET', N'Mét', N'1', N'Đơn vị đo chiều dài', N'2015-08-26 15:00:39.0000000', N'Admin', N'2015-08-26 15:00:39.0000000', N'Admin'), (N'3', N'BO', N'Bộ', N'1', N'Một bộ', N'2015-08-26 15:04:28.0000000', N'Admin', N'2015-08-26 15:04:28.0000000', N'Admin'), (N'4', N'CUON', N'Cuộn', N'1', N'Cuộn dây', N'2015-08-26 15:04:28.0000000', N'Admin', N'2015-08-26 15:04:28.0000000', N'Admin'), (N'5', N'HOP', N'Hộp', N'1', N'Hộp', N'2015-08-26 15:06:01.0000000', N'Admin', N'2015-08-26 15:06:01.0000000', N'Admin'), (N'6', N'CON', N'Con', N'1', N'Con', N'2015-08-26 15:06:01.0000000', N'Admin', N'2015-08-26 15:06:01.0000000', N'Admin'), (N'7', N'QUYEN', N'Quyển', N'1', N'Quyển', N'2015-08-26 15:09:08.0000000', N'Admin', N'2015-08-26 15:09:08.0000000', N'Admin'), (N'8', N'KG', N'Kg', N'1', N'Kg', N'2015-08-26 15:09:08.0000000', N'Admin', N'2015-08-26 15:09:08.0000000', N'Admin'), (N'9', N'CAY', N'Cây', N'1', N'Cây', N'2015-08-26 15:10:41.0000000', N'Admin', N'2015-08-26 15:10:41.0000000', N'Admin'), (N'10', N'MAY', N'Máy', N'1', N'Admin', N'2015-08-26 15:10:41.0000000', N'Admin', N'2015-08-26 15:10:41.0000000', N'Admin')
GO
GO
COMMIT TRANSACTION
GO

-- ----------------------------
-- Table structure for user
-- ----------------------------
DROP TABLE [user]
GO
CREATE TABLE [user] (
[UserId] bigint NOT NULL ,
[UserCode] nvarchar(32) NOT NULL ,
[UserName] nvarchar(128) NOT NULL ,
[CMND] nvarchar(32) NULL ,
[Phone] nvarchar(32) NULL ,
[Email] nvarchar(64) NULL ,
[RoleDescription] nvarchar(128) NULL ,
[Enabled] tinyint NULL ,
[Description] nvarchar(128) NULL ,
[CreatedDate] datetime2(7) NULL ,
[CreateUser] nvarchar(32) NULL ,
[UpdateDate] datetime2(7) NULL ,
[UpdateUser] nvarchar(32) NULL 
)


GO

-- ----------------------------
-- Records of user
-- ----------------------------
BEGIN TRANSACTION
GO
INSERT INTO [user] ([UserId], [UserCode], [UserName], [CMND], [Phone], [Email], [RoleDescription], [Enabled], [Description], [CreatedDate], [CreateUser], [UpdateDate], [UpdateUser]) VALUES (N'1', N'KietNM', N'Nguyễn Minh Kiệt', N'999988887777', N'090.888.8888', N'KietNM2505@gmail.com', N'Admin', N'1', N'Admin', N'2015-08-26 15:14:55.0000000', N'Admin', N'2015-08-26 15:14:55.0000000', N'Admin'), (N'2', N'TungPT', N'Phạm Thanh Tùng', N'111100001111', N'098.777.7777', N'tungpt@gmail.com', N'Nhập liệu', N'1', N'Nhập liệu', N'2015-08-26 15:14:55.0000000', N'Admin', N'2015-08-26 15:14:55.0000000', N'Admin'), (N'3', N'Tuan', N'Tuấn', N'666655554444', N'097.888.11111', N'tuan@gmail.com', N'Bán hàng', N'1', N'Bán hàng', N'2015-08-26 15:17:05.0000000', N'Admin', N'2015-08-26 15:17:05.0000000', N'Admin'), (N'4', N'Admin', N'Admin', N'212233338888', N'0914.888.666', N'admin@inventory.com.vn', N'admin', N'1', N'Admin', N'2015-08-26 15:17:05.0000000', N'Admin', N'2015-08-26 15:17:05.0000000', N'Admin')
GO
GO
COMMIT TRANSACTION
GO

-- ----------------------------
-- Table structure for warehouse
-- ----------------------------
DROP TABLE [warehouse]
GO
CREATE TABLE [warehouse] (
[WarehouseId] bigint NOT NULL ,
[WarehouseCode] nvarchar(32) NOT NULL ,
[WarehouseName] nvarchar(128) NOT NULL ,
[WarehouseParentId] bigint NULL ,
[Enabled] tinyint NULL ,
[Description] nvarchar(128) NULL ,
[CreatedDate] datetime2(7) NULL ,
[CreateUser] nvarchar(32) NULL ,
[UpdateDate] datetime2(7) NULL ,
[UpdateUser] nvarchar(32) NULL 
)


GO

-- ----------------------------
-- Records of warehouse
-- ----------------------------
BEGIN TRANSACTION
GO
INSERT INTO [warehouse] ([WarehouseId], [WarehouseCode], [WarehouseName], [WarehouseParentId], [Enabled], [Description], [CreatedDate], [CreateUser], [UpdateDate], [UpdateUser]) VALUES (N'1', N'KHOTONG', N'KHOTONG', null, N'1', N'KHOTONG', N'2015-08-26 15:30:36.0000000', N'Admin', N'2015-08-26 15:30:36.0000000', N'Admin'), (N'2', N'KHOCN1', N'KHOCN1', N'1', N'1', N'KHOCN1', N'2015-08-26 15:30:36.0000000', N'Admin', N'2015-08-26 15:30:36.0000000', N'Admin'), (N'3', N'KHOCN2', N'KHOCN2', N'1', N'1', N'KHOCN2', N'2015-08-26 15:32:20.0000000', N'Admin', N'2015-08-26 15:32:20.0000000', N'Admin'), (N'4', N'KHOPATNER', N'KHOPATNER', N'1', N'1', N'KHOPATNER', N'2015-08-26 15:32:20.0000000', N'Admin', N'2015-08-26 15:32:20.0000000', N'Admin')
GO
GO
COMMIT TRANSACTION
GO

-- ----------------------------
-- Indexes structure for table categoryitem
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table categoryitem
-- ----------------------------
ALTER TABLE [categoryitem] ADD PRIMARY KEY ([CategoryItemId])
GO

-- ----------------------------
-- Indexes structure for table company
-- ----------------------------
CREATE UNIQUE INDEX [CompanyCode] ON [company]
([CompanyCode] ASC) 
WITH (IGNORE_DUP_KEY = ON, STATISTICS_NORECOMPUTE = ON)
GO

-- ----------------------------
-- Primary Key structure for table company
-- ----------------------------
ALTER TABLE [company] ADD PRIMARY KEY ([CompanyId])
GO

-- ----------------------------
-- Indexes structure for table customer
-- ----------------------------
CREATE UNIQUE INDEX [CustomerCode] ON [customer]
([CustomerCode] ASC) 
WITH (IGNORE_DUP_KEY = ON, STATISTICS_NORECOMPUTE = ON)
GO

-- ----------------------------
-- Primary Key structure for table customer
-- ----------------------------
ALTER TABLE [customer] ADD PRIMARY KEY ([CustomerId])
GO

-- ----------------------------
-- Indexes structure for table item
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table item
-- ----------------------------
ALTER TABLE [item] ADD PRIMARY KEY ([ItemId])
GO

-- ----------------------------
-- Indexes structure for table supplier
-- ----------------------------
CREATE UNIQUE INDEX [SupplierCode] ON [supplier]
([SupplierCode] ASC) 
WITH (IGNORE_DUP_KEY = ON, STATISTICS_NORECOMPUTE = ON)
GO

-- ----------------------------
-- Primary Key structure for table supplier
-- ----------------------------
ALTER TABLE [supplier] ADD PRIMARY KEY ([SupplierId])
GO

-- ----------------------------
-- Indexes structure for table transactiondetail
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table transactiondetail
-- ----------------------------
ALTER TABLE [transactiondetail] ADD PRIMARY KEY ([TransactionDetailId])
GO

-- ----------------------------
-- Indexes structure for table transactionmaster
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table transactionmaster
-- ----------------------------
ALTER TABLE [transactionmaster] ADD PRIMARY KEY ([TransactionMasterId])
GO

-- ----------------------------
-- Indexes structure for table transactiontype
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table transactiontype
-- ----------------------------
ALTER TABLE [transactiontype] ADD PRIMARY KEY ([TransactionTypeId])
GO

-- ----------------------------
-- Indexes structure for table unit
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table unit
-- ----------------------------
ALTER TABLE [unit] ADD PRIMARY KEY ([UnitId])
GO

-- ----------------------------
-- Indexes structure for table user
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table user
-- ----------------------------
ALTER TABLE [user] ADD PRIMARY KEY ([UserId])
GO

-- ----------------------------
-- Indexes structure for table warehouse
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table warehouse
-- ----------------------------
ALTER TABLE [warehouse] ADD PRIMARY KEY ([WarehouseId])
GO
