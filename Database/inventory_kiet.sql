-- phpMyAdmin SQL Dump
-- version 4.3.11
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Aug 26, 2015 at 12:37 PM
-- Server version: 5.6.24
-- PHP Version: 5.5.24

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `inventory`
--

-- --------------------------------------------------------

--
-- Table structure for table `categoryitem`
--

CREATE TABLE IF NOT EXISTS `categoryitem` (
  `CategoryItemId` bigint(20) NOT NULL,
  `CategoryItemCode` varchar(32) COLLATE utf8mb4_unicode_ci NOT NULL,
  `CategoryItemName` varchar(128) COLLATE utf8mb4_unicode_ci NOT NULL,
  `Features` varchar(512) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `Specifications` varchar(512) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `UnitId` bigint(20) DEFAULT NULL,
  `CategoryItemParentId` bigint(20) DEFAULT NULL,
  `Enabled` tinyint(1) DEFAULT NULL,
  `Description` varchar(128) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `CreatedDate` datetime DEFAULT CURRENT_TIMESTAMP,
  `CreateUser` varchar(32) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `UpdateDate` datetime DEFAULT CURRENT_TIMESTAMP,
  `UpdateUser` varchar(32) COLLATE utf8mb4_unicode_ci DEFAULT NULL
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Dumping data for table `categoryitem`
--

INSERT INTO `categoryitem` (`CategoryItemId`, `CategoryItemCode`, `CategoryItemName`, `Features`, `Specifications`, `UnitId`, `CategoryItemParentId`, `Enabled`, `Description`, `CreatedDate`, `CreateUser`, `UpdateDate`, `UpdateUser`) VALUES
(1, 'DIENTHOAI', 'Điện thoại', NULL, NULL, NULL, NULL, 1, NULL, '2015-08-26 15:37:00', 'Admin', '2015-08-26 15:37:00', 'Admin'),
(2, 'APPLE', 'APPLE', NULL, NULL, NULL, NULL, 1, NULL, '2015-08-26 15:37:00', 'Admin', '2015-08-26 15:37:00', 'Admin'),
(3, 'TABLET', 'TABLET', NULL, NULL, NULL, NULL, 1, 'TABLET', '2015-08-26 15:38:34', 'Admin', '2015-08-26 15:38:34', 'Admin'),
(4, 'LAPTOP', 'LAPTOP', 'LAPTOP', NULL, NULL, NULL, 1, NULL, '2015-08-26 15:38:34', 'Admin', '2015-08-26 15:38:34', 'Admin'),
(5, 'iPhone', 'iPhone', 'iPhone', 'iPhone', NULL, 2, 1, 'iPhone', '2015-08-26 15:40:28', 'Admin', '2015-08-26 15:40:28', 'Admin'),
(6, 'iPad', 'iPad', 'iPad', 'iPad', NULL, 2, 1, 'iPad', '2015-08-26 15:40:28', 'Admin', '2015-08-26 15:40:28', 'Admin'),
(7, 'iPod', 'iPod', 'iPod', 'iPod', NULL, 2, 1, 'iPod', '2015-08-26 15:41:46', 'Admin', '2015-08-26 15:41:46', 'Admin'),
(8, 'Macbook', 'Macbook', 'Macbook', 'Macbook', NULL, 2, 1, 'Macbook', '2015-08-26 15:41:46', 'Admin', '2015-08-26 15:41:46', 'Admin'),
(9, 'iMac', 'iMac', 'iMac', 'iMac', NULL, 2, 1, 'iMac', '2015-08-26 15:43:17', 'Admin', '2015-08-26 15:43:17', 'Admin'),
(10, 'Phụ kiện apple', 'Phụ kiện apple', 'Phụ kiện apple', 'Phụ kiện apple', NULL, 2, 1, 'Admin', '2015-08-26 15:43:17', 'Admin', '2015-08-26 15:43:17', 'Admin'),
(11, 'iPhone 6', 'iPhone 6', 'Màn hình: Retina HD, 4.7", 750 x 1334 pixels\r\nCPU: 64-bit, chip A8, M8\r\nHệ điều hành: iOs 8.0\r\nCamera chính: 8.0 MP, Quay phim FullHD\r\nCamera phụ: 1.2 MP, 720p\r\nDung lượng: 16 GB/64 GB/128 GB \r\nCó 3 màu: Silver/Gold/Space Gray', 'Màn hình: Retina HD, 4.7", 750 x 1334 pixels\r\nCPU: 64-bit, chip A8, M8\r\nHệ điều hành: iOs 8.0\r\nCamera chính: 8.0 MP, Quay phim FullHD\r\nCamera phụ: 1.2 MP, 720p\r\nDung lượng: 16 GB/64 GB/128 GB \r\nCó 3 màu: Silver/Gold/Space Gray', 10, 5, 1, NULL, '2015-08-26 15:46:05', 'Admin', '2015-08-26 15:46:05', 'Admin'),
(12, 'iPhone 6 plus', 'iPhone 6 plus', 'Màn hình: Retina HD, 5.5", 1080 x 1920 pixels\r\nCPU: 64-bit, chip A8, M8\r\nHệ điều hành: iOS 8.0\r\nCamera chính: 8.0 MP, Quay phim FullHD \r\nCamera phụ : 1.2 MP, 720p\r\nDung lượng: 16 GB/64 GB/128 GB\r\nCó 3 màu: Silver/Gold/Space Gray', 'Màn hình: Retina HD, 5.5", 1080 x 1920 pixels\r\nCPU: 64-bit, chip A8, M8\r\nHệ điều hành: iOS 8.0\r\nCamera chính: 8.0 MP, Quay phim FullHD \r\nCamera phụ : 1.2 MP, 720p\r\nDung lượng: 16 GB/64 GB/128 GB\r\nCó 3 màu: Silver/Gold/Space Gray', 10, 5, 1, NULL, '2015-08-26 15:46:05', 'Admin', '2015-08-26 15:46:05', 'Admin');

-- --------------------------------------------------------

--
-- Table structure for table `company`
--

CREATE TABLE IF NOT EXISTS `company` (
  `CompanyId` bigint(20) NOT NULL,
  `CompanyCode` varchar(32) COLLATE utf8mb4_unicode_ci NOT NULL,
  `CompanyShortName` varchar(64) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `CompanyName` varchar(128) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `CompanyParentId` bigint(20) DEFAULT NULL,
  `IsBranch` tinyint(1) DEFAULT NULL,
  `Enabled` tinyint(1) DEFAULT NULL,
  `Description` varchar(128) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `CreatedDate` datetime DEFAULT CURRENT_TIMESTAMP,
  `CreateUser` varchar(32) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `UpdateDate` datetime DEFAULT CURRENT_TIMESTAMP,
  `UpdateUser` varchar(32) COLLATE utf8mb4_unicode_ci DEFAULT NULL
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Dumping data for table `company`
--

INSERT INTO `company` (`CompanyId`, `CompanyCode`, `CompanyShortName`, `CompanyName`, `CompanyParentId`, `IsBranch`, `Enabled`, `Description`, `CreatedDate`, `CreateUser`, `UpdateDate`, `UpdateUser`) VALUES
(1, 'FPT', 'FPT', 'FPT IS', NULL, NULL, 1, 'FPT IS', '2015-08-26 15:22:07', 'Admin', '2015-08-26 15:22:07', 'Admin'),
(2, 'Primelabo', 'Primelabo', 'Primelabo', NULL, NULL, 1, 'Primelabo', '2015-08-26 15:22:07', 'Admin', '2015-08-26 15:22:07', 'Admin'),
(3, 'PHCM', 'Primelabo HCM', 'Chi nhánh Primelabo HCM', 2, 1, 1, 'Chi nhánh Primelabo HCM', '2015-08-26 15:26:21', 'Admin', '2015-08-26 15:26:21', 'Admin');

-- --------------------------------------------------------

--
-- Table structure for table `customer`
--

CREATE TABLE IF NOT EXISTS `customer` (
  `CustomerId` bigint(20) NOT NULL,
  `CustomerCode` varchar(32) COLLATE utf8mb4_unicode_ci NOT NULL,
  `CustomerShortName` varchar(64) COLLATE utf8mb4_unicode_ci NOT NULL,
  `CustomerName` varchar(128) COLLATE utf8mb4_unicode_ci NOT NULL,
  `IsPersonal` tinyint(1) DEFAULT NULL,
  `Enabled` tinyint(1) DEFAULT NULL,
  `Description` varchar(128) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `CreatedDate` datetime DEFAULT CURRENT_TIMESTAMP,
  `CreateUser` varchar(32) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `UpdateDate` datetime DEFAULT CURRENT_TIMESTAMP,
  `UpdateUser` varchar(32) COLLATE utf8mb4_unicode_ci DEFAULT NULL
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Dumping data for table `customer`
--

INSERT INTO `customer` (`CustomerId`, `CustomerCode`, `CustomerShortName`, `CustomerName`, `IsPersonal`, `Enabled`, `Description`, `CreatedDate`, `CreateUser`, `UpdateDate`, `UpdateUser`) VALUES
(1, 'Lavie', 'Lavie', 'Lavie', NULL, 1, 'Lavie', '2015-08-26 15:27:39', 'Admin', '2015-08-26 15:27:39', 'Admin'),
(2, 'A.Huy', 'A.Huy', 'A.Huy', 1, 1, 'A.Huy', '2015-08-26 15:27:39', 'Admin', '2015-08-26 15:27:39', 'Admin');

-- --------------------------------------------------------

--
-- Table structure for table `item`
--

CREATE TABLE IF NOT EXISTS `item` (
  `ItemId` bigint(20) NOT NULL,
  `ItemCode` varchar(32) COLLATE utf8mb4_unicode_ci NOT NULL,
  `ItemName` varchar(128) COLLATE utf8mb4_unicode_ci NOT NULL,
  `Features` varchar(512) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `Specifications` varchar(512) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `UnitId` bigint(20) DEFAULT NULL,
  `CategoryItemsId` bigint(20) DEFAULT NULL,
  `Enabled` tinyint(1) DEFAULT NULL,
  `Description` varchar(128) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `CreatedDate` datetime DEFAULT CURRENT_TIMESTAMP,
  `CreateUser` varchar(32) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `UpdateDate` datetime DEFAULT CURRENT_TIMESTAMP,
  `UpdateUser` varchar(32) COLLATE utf8mb4_unicode_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Table structure for table `supplier`
--

CREATE TABLE IF NOT EXISTS `supplier` (
  `SupplierId` bigint(20) NOT NULL,
  `SupplierCode` varchar(32) COLLATE utf8mb4_unicode_ci NOT NULL,
  `SupplierShortName` varchar(64) COLLATE utf8mb4_unicode_ci NOT NULL,
  `SupplierName` varchar(128) COLLATE utf8mb4_unicode_ci NOT NULL,
  `Enabled` tinyint(1) DEFAULT NULL,
  `Description` varchar(128) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `CreatedDate` datetime DEFAULT CURRENT_TIMESTAMP,
  `CreateUser` varchar(32) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `UpdateDate` datetime DEFAULT CURRENT_TIMESTAMP,
  `UpdateUser` varchar(32) COLLATE utf8mb4_unicode_ci DEFAULT NULL
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Dumping data for table `supplier`
--

INSERT INTO `supplier` (`SupplierId`, `SupplierCode`, `SupplierShortName`, `SupplierName`, `Enabled`, `Description`, `CreatedDate`, `CreateUser`, `UpdateDate`, `UpdateUser`) VALUES
(1, 'PTSC MARINE', 'PTSC MARINE', 'PTSC MARINE', 1, 'PTSC MARINE', '2015-08-26 15:28:44', 'Admin', '2015-08-26 15:28:44', 'Admin'),
(2, 'FPT', 'FPT', 'FPT', 1, 'FPT', '2015-08-26 15:28:44', 'Admin', '2015-08-26 15:28:44', 'Admin');

-- --------------------------------------------------------

--
-- Table structure for table `transactiondetail`
--

CREATE TABLE IF NOT EXISTS `transactiondetail` (
  `TransactionDetailId` bigint(20) NOT NULL,
  `TransactionMasterId` bigint(20) NOT NULL,
  `CategoryItemId` bigint(20) DEFAULT NULL,
  `ItemId` bigint(20) NOT NULL,
  `Price` decimal(10,0) DEFAULT NULL,
  `UnitId` bigint(20) DEFAULT NULL,
  `Quantity` decimal(10,0) DEFAULT NULL,
  `TotalPrice` decimal(10,0) DEFAULT NULL,
  `PercentCharges` decimal(10,0) DEFAULT NULL,
  `TotalCharges` decimal(10,0) DEFAULT NULL,
  `TotalAmount` decimal(10,0) DEFAULT NULL,
  `Description` varchar(128) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `CreatedDate` datetime DEFAULT CURRENT_TIMESTAMP,
  `CreateUser` varchar(32) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `UpdateDate` datetime DEFAULT CURRENT_TIMESTAMP,
  `UpdateUser` varchar(32) COLLATE utf8mb4_unicode_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Table structure for table `transactionmaster`
--

CREATE TABLE IF NOT EXISTS `transactionmaster` (
  `TransactionMasterId` bigint(20) NOT NULL,
  `TransactionCode` varchar(32) COLLATE utf8mb4_unicode_ci NOT NULL,
  `TransactionTypeId` bigint(20) NOT NULL,
  `TransactionDate` datetime NOT NULL,
  `ReceivedWarehouseId` bigint(20) DEFAULT NULL,
  `DeliveredWarehosuseId` bigint(20) DEFAULT NULL,
  `Receiver` varchar(128) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `Deliver` varchar(128) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `CustomerId` bigint(20) DEFAULT NULL,
  `SupplierId` bigint(20) DEFAULT NULL,
  `TotalPrice` decimal(10,0) DEFAULT NULL,
  `PercentCharges` decimal(10,0) DEFAULT NULL,
  `TotalCharges` decimal(10,0) DEFAULT NULL,
  `TotalAmount` decimal(10,0) DEFAULT NULL,
  `CreatedDate` datetime DEFAULT CURRENT_TIMESTAMP,
  `CreateUser` varchar(32) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `UpdateDate` datetime DEFAULT CURRENT_TIMESTAMP,
  `UpdateUser` varchar(32) COLLATE utf8mb4_unicode_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Table structure for table `transactiontype`
--

CREATE TABLE IF NOT EXISTS `transactiontype` (
  `TransactionTypeId` bigint(20) NOT NULL,
  `TransactionTypeCode` varchar(32) COLLATE utf8mb4_unicode_ci NOT NULL,
  `Enabled` tinyint(1) DEFAULT NULL,
  `Description` varchar(128) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `CreatedDate` datetime DEFAULT CURRENT_TIMESTAMP,
  `CreateUser` varchar(32) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `UpdateDate` datetime DEFAULT CURRENT_TIMESTAMP,
  `UpdateUser` varchar(32) COLLATE utf8mb4_unicode_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Table structure for table `unit`
--

CREATE TABLE IF NOT EXISTS `unit` (
  `UnitId` bigint(20) NOT NULL,
  `UnitCode` varchar(32) COLLATE utf8mb4_unicode_ci NOT NULL,
  `UnitName` varchar(64) COLLATE utf8mb4_unicode_ci NOT NULL,
  `Enabled` tinyint(1) DEFAULT NULL,
  `Description` varchar(128) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `CreatedDate` datetime DEFAULT CURRENT_TIMESTAMP,
  `CreateUser` varchar(32) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `UpdateDate` datetime DEFAULT CURRENT_TIMESTAMP,
  `UpdateUser` varchar(32) COLLATE utf8mb4_unicode_ci DEFAULT NULL
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Dumping data for table `unit`
--

INSERT INTO `unit` (`UnitId`, `UnitCode`, `UnitName`, `Enabled`, `Description`, `CreatedDate`, `CreateUser`, `UpdateDate`, `UpdateUser`) VALUES
(1, 'CAI', 'Cái', 1, 'Cái', '2015-08-26 14:59:50', 'Admin', '2015-08-26 14:59:50', 'Admin'),
(2, 'MET', 'Mét', 1, 'Đơn vị đo chiều dài', '2015-08-26 15:00:39', 'Admin', '2015-08-26 15:00:39', 'Admin'),
(3, 'BO', 'Bộ', 1, 'Một bộ', '2015-08-26 15:04:28', 'Admin', '2015-08-26 15:04:28', 'Admin'),
(4, 'CUON', 'Cuộn', 1, 'Cuộn dây', '2015-08-26 15:04:28', 'Admin', '2015-08-26 15:04:28', 'Admin'),
(5, 'HOP', 'Hộp', 1, 'Hộp', '2015-08-26 15:06:01', 'Admin', '2015-08-26 15:06:01', 'Admin'),
(6, 'CON', 'Con', 1, 'Con', '2015-08-26 15:06:01', 'Admin', '2015-08-26 15:06:01', 'Admin'),
(7, 'QUYEN', 'Quyển', 1, 'Quyển', '2015-08-26 15:09:08', 'Admin', '2015-08-26 15:09:08', 'Admin'),
(8, 'KG', 'Kg', 1, 'Kg', '2015-08-26 15:09:08', 'Admin', '2015-08-26 15:09:08', 'Admin'),
(9, 'CAY', 'Cây', 1, 'Cây', '2015-08-26 15:10:41', 'Admin', '2015-08-26 15:10:41', 'Admin'),
(10, 'MAY', 'Máy', 1, 'Admin', '2015-08-26 15:10:41', 'Admin', '2015-08-26 15:10:41', 'Admin');

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE IF NOT EXISTS `user` (
  `UserId` bigint(20) NOT NULL,
  `UserCode` varchar(32) COLLATE utf8mb4_unicode_ci NOT NULL,
  `UserName` varchar(128) COLLATE utf8mb4_unicode_ci NOT NULL,
  `CMND` varchar(32) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `Phone` varchar(32) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `Email` varchar(64) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `RoleDescription` varchar(128) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `Enabled` tinyint(1) DEFAULT NULL,
  `Description` varchar(128) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `CreatedDate` datetime DEFAULT CURRENT_TIMESTAMP,
  `CreateUser` varchar(32) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `UpdateDate` datetime DEFAULT CURRENT_TIMESTAMP,
  `UpdateUser` varchar(32) COLLATE utf8mb4_unicode_ci DEFAULT NULL
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Dumping data for table `user`
--

INSERT INTO `user` (`UserId`, `UserCode`, `UserName`, `CMND`, `Phone`, `Email`, `RoleDescription`, `Enabled`, `Description`, `CreatedDate`, `CreateUser`, `UpdateDate`, `UpdateUser`) VALUES
(1, 'KietNM', 'Nguyễn Minh Kiệt', '999988887777', '090.888.8888', 'KietNM2505@gmail.com', 'Admin', 1, 'Admin', '2015-08-26 15:14:55', 'Admin', '2015-08-26 15:14:55', 'Admin'),
(2, 'TungPT', 'Phạm Thanh Tùng', '111100001111', '098.777.7777', 'tungpt@gmail.com', 'Nhập liệu', 1, 'Nhập liệu', '2015-08-26 15:14:55', 'Admin', '2015-08-26 15:14:55', 'Admin'),
(3, 'Tuan', 'Tuấn', '666655554444', '097.888.11111', 'tuan@gmail.com', 'Bán hàng', 1, 'Bán hàng', '2015-08-26 15:17:05', 'Admin', '2015-08-26 15:17:05', 'Admin'),
(4, 'Admin', 'Admin', '212233338888', '0914.888.666', 'admin@inventory.com.vn', 'admin', 1, 'Admin', '2015-08-26 15:17:05', 'Admin', '2015-08-26 15:17:05', 'Admin');

-- --------------------------------------------------------

--
-- Table structure for table `warehouse`
--

CREATE TABLE IF NOT EXISTS `warehouse` (
  `WarehouseId` bigint(20) NOT NULL,
  `WarehouseCode` varchar(32) COLLATE utf8mb4_unicode_ci NOT NULL,
  `WarehouseName` varchar(128) COLLATE utf8mb4_unicode_ci NOT NULL,
  `WarehouseParentId` bigint(20) DEFAULT NULL,
  `Enabled` tinyint(1) DEFAULT NULL,
  `Description` varchar(128) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `CreatedDate` datetime DEFAULT CURRENT_TIMESTAMP,
  `CreateUser` varchar(32) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `UpdateDate` datetime DEFAULT CURRENT_TIMESTAMP,
  `UpdateUser` varchar(32) COLLATE utf8mb4_unicode_ci DEFAULT NULL
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Dumping data for table `warehouse`
--

INSERT INTO `warehouse` (`WarehouseId`, `WarehouseCode`, `WarehouseName`, `WarehouseParentId`, `Enabled`, `Description`, `CreatedDate`, `CreateUser`, `UpdateDate`, `UpdateUser`) VALUES
(1, 'KHOTONG', 'KHOTONG', NULL, 1, 'KHOTONG', '2015-08-26 15:30:36', 'Admin', '2015-08-26 15:30:36', 'Admin'),
(2, 'KHOCN1', 'KHOCN1', 1, 1, 'KHOCN1', '2015-08-26 15:30:36', 'Admin', '2015-08-26 15:30:36', 'Admin'),
(3, 'KHOCN2', 'KHOCN2', 1, 1, 'KHOCN2', '2015-08-26 15:32:20', 'Admin', '2015-08-26 15:32:20', 'Admin'),
(4, 'KHOPATNER', 'KHOPATNER', 1, 1, 'KHOPATNER', '2015-08-26 15:32:20', 'Admin', '2015-08-26 15:32:20', 'Admin');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `categoryitem`
--
ALTER TABLE `categoryitem`
  ADD PRIMARY KEY (`CategoryItemId`);

--
-- Indexes for table `company`
--
ALTER TABLE `company`
  ADD PRIMARY KEY (`CompanyId`), ADD UNIQUE KEY `CompanyCode` (`CompanyCode`);

--
-- Indexes for table `customer`
--
ALTER TABLE `customer`
  ADD PRIMARY KEY (`CustomerId`), ADD UNIQUE KEY `CustomerCode` (`CustomerCode`);

--
-- Indexes for table `item`
--
ALTER TABLE `item`
  ADD PRIMARY KEY (`ItemId`);

--
-- Indexes for table `supplier`
--
ALTER TABLE `supplier`
  ADD PRIMARY KEY (`SupplierId`), ADD UNIQUE KEY `SupplierCode` (`SupplierCode`);

--
-- Indexes for table `transactiondetail`
--
ALTER TABLE `transactiondetail`
  ADD PRIMARY KEY (`TransactionDetailId`);

--
-- Indexes for table `transactionmaster`
--
ALTER TABLE `transactionmaster`
  ADD PRIMARY KEY (`TransactionMasterId`);

--
-- Indexes for table `transactiontype`
--
ALTER TABLE `transactiontype`
  ADD PRIMARY KEY (`TransactionTypeId`);

--
-- Indexes for table `unit`
--
ALTER TABLE `unit`
  ADD PRIMARY KEY (`UnitId`);

--
-- Indexes for table `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`UserId`);

--
-- Indexes for table `warehouse`
--
ALTER TABLE `warehouse`
  ADD PRIMARY KEY (`WarehouseId`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `categoryitem`
--
ALTER TABLE `categoryitem`
  MODIFY `CategoryItemId` bigint(20) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=13;
--
-- AUTO_INCREMENT for table `company`
--
ALTER TABLE `company`
  MODIFY `CompanyId` bigint(20) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=4;
--
-- AUTO_INCREMENT for table `customer`
--
ALTER TABLE `customer`
  MODIFY `CustomerId` bigint(20) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT for table `item`
--
ALTER TABLE `item`
  MODIFY `ItemId` bigint(20) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `supplier`
--
ALTER TABLE `supplier`
  MODIFY `SupplierId` bigint(20) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT for table `transactiondetail`
--
ALTER TABLE `transactiondetail`
  MODIFY `TransactionDetailId` bigint(20) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `transactionmaster`
--
ALTER TABLE `transactionmaster`
  MODIFY `TransactionMasterId` bigint(20) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `transactiontype`
--
ALTER TABLE `transactiontype`
  MODIFY `TransactionTypeId` bigint(20) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `unit`
--
ALTER TABLE `unit`
  MODIFY `UnitId` bigint(20) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=11;
--
-- AUTO_INCREMENT for table `user`
--
ALTER TABLE `user`
  MODIFY `UserId` bigint(20) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=5;
--
-- AUTO_INCREMENT for table `warehouse`
--
ALTER TABLE `warehouse`
  MODIFY `WarehouseId` bigint(20) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=5;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
