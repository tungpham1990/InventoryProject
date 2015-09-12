CREATE DATABASE  IF NOT EXISTS `inventory` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `inventory`;
-- MySQL dump 10.13  Distrib 5.6.13, for Win32 (x86)
--
-- Host: localhost    Database: inventory
-- ------------------------------------------------------
-- Server version	5.6.16

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `categoryitem`
--

DROP TABLE IF EXISTS `categoryitem`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `categoryitem` (
  `CategoryItemId` bigint(20) NOT NULL AUTO_INCREMENT,
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
  `UpdateUser` varchar(32) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`CategoryItemId`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `categoryitem`
--

LOCK TABLES `categoryitem` WRITE;
/*!40000 ALTER TABLE `categoryitem` DISABLE KEYS */;
INSERT INTO `categoryitem` VALUES (1,'DIENTHOAI','Điện thoại',NULL,NULL,NULL,NULL,1,NULL,'2015-08-26 15:37:00','Admin','2015-08-26 15:37:00','Admin'),(2,'APPLE','APPLE',NULL,NULL,NULL,NULL,1,NULL,'2015-08-26 15:37:00','Admin','2015-08-26 15:37:00','Admin'),(3,'TABLET','TABLET',NULL,NULL,NULL,NULL,1,'TABLET','2015-08-26 15:38:34','Admin','2015-08-26 15:38:34','Admin'),(4,'LAPTOP','LAPTOP','LAPTOP',NULL,NULL,NULL,1,NULL,'2015-08-26 15:38:34','Admin','2015-08-26 15:38:34','Admin'),(5,'iPhone','iPhone','iPhone','iPhone',NULL,2,1,'iPhone','2015-08-26 15:40:28','Admin','2015-08-26 15:40:28','Admin'),(6,'iPad','iPad','iPad','iPad',NULL,2,1,'iPad','2015-08-26 15:40:28','Admin','2015-08-26 15:40:28','Admin'),(7,'iPod','iPod','iPod','iPod',NULL,2,1,'iPod','2015-08-26 15:41:46','Admin','2015-08-26 15:41:46','Admin'),(8,'Macbook','Macbook','Macbook','Macbook',NULL,2,1,'Macbook','2015-08-26 15:41:46','Admin','2015-08-26 15:41:46','Admin'),(9,'iMac','iMac','iMac','iMac',NULL,2,1,'iMac','2015-08-26 15:43:17','Admin','2015-08-26 15:43:17','Admin'),(10,'Phụ kiện apple','Phụ kiện apple','Phụ kiện apple','Phụ kiện apple',NULL,2,1,'Admin','2015-08-26 15:43:17','Admin','2015-08-26 15:43:17','Admin'),(11,'iPhone 6','iPhone 6','Màn hình: Retina HD, 4.7\", 750 x 1334 pixels\r\nCPU: 64-bit, chip A8, M8\r\nHệ điều hành: iOs 8.0\r\nCamera chính: 8.0 MP, Quay phim FullHD\r\nCamera phụ: 1.2 MP, 720p\r\nDung lượng: 16 GB/64 GB/128 GB \r\nCó 3 màu: Silver/Gold/Space Gray','Màn hình: Retina HD, 4.7\", 750 x 1334 pixels\r\nCPU: 64-bit, chip A8, M8\r\nHệ điều hành: iOs 8.0\r\nCamera chính: 8.0 MP, Quay phim FullHD\r\nCamera phụ: 1.2 MP, 720p\r\nDung lượng: 16 GB/64 GB/128 GB \r\nCó 3 màu: Silver/Gold/Space Gray',10,5,1,NULL,'2015-08-26 15:46:05','Admin','2015-08-26 15:46:05','Admin'),(12,'iPhone 6 plus','iPhone 6 plus','Màn hình: Retina HD, 5.5\", 1080 x 1920 pixels\r\nCPU: 64-bit, chip A8, M8\r\nHệ điều hành: iOS 8.0\r\nCamera chính: 8.0 MP, Quay phim FullHD \r\nCamera phụ : 1.2 MP, 720p\r\nDung lượng: 16 GB/64 GB/128 GB\r\nCó 3 màu: Silver/Gold/Space Gray','Màn hình: Retina HD, 5.5\", 1080 x 1920 pixels\r\nCPU: 64-bit, chip A8, M8\r\nHệ điều hành: iOS 8.0\r\nCamera chính: 8.0 MP, Quay phim FullHD \r\nCamera phụ : 1.2 MP, 720p\r\nDung lượng: 16 GB/64 GB/128 GB\r\nCó 3 màu: Silver/Gold/Space Gray',10,5,1,NULL,'2015-08-26 15:46:05','Admin','2015-08-26 15:46:05','Admin');
/*!40000 ALTER TABLE `categoryitem` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `company`
--

DROP TABLE IF EXISTS `company`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `company` (
  `CompanyId` bigint(20) NOT NULL AUTO_INCREMENT,
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
  `UpdateUser` varchar(32) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`CompanyId`),
  UNIQUE KEY `CompanyCode` (`CompanyCode`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `company`
--

LOCK TABLES `company` WRITE;
/*!40000 ALTER TABLE `company` DISABLE KEYS */;
INSERT INTO `company` VALUES (1,'FPT','FPT','FPT IS',NULL,NULL,1,'FPT IS','2015-08-26 15:22:07','Admin','2015-08-26 15:22:07','Admin'),(2,'Primelabo','Primelabo','Primelabo',NULL,NULL,1,'Primelabo','2015-08-26 15:22:07','Admin','2015-08-26 15:22:07','Admin'),(3,'PHCM','Primelabo HCM','Chi nhánh Primelabo HCM',2,1,1,'Chi nhánh Primelabo HCM','2015-08-26 15:26:21','Admin','2015-08-26 15:26:21','Admin');
/*!40000 ALTER TABLE `company` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `customer`
--

DROP TABLE IF EXISTS `customer`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `customer` (
  `CustomerId` bigint(20) NOT NULL AUTO_INCREMENT,
  `CustomerCode` varchar(32) COLLATE utf8mb4_unicode_ci NOT NULL,
  `CustomerShortName` varchar(64) COLLATE utf8mb4_unicode_ci NOT NULL,
  `CustomerName` varchar(128) COLLATE utf8mb4_unicode_ci NOT NULL,
  `IsPersonal` tinyint(1) DEFAULT NULL,
  `Enabled` tinyint(1) DEFAULT NULL,
  `Description` varchar(128) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `CreatedDate` datetime DEFAULT CURRENT_TIMESTAMP,
  `CreateUser` varchar(32) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `UpdateDate` datetime DEFAULT CURRENT_TIMESTAMP,
  `UpdateUser` varchar(32) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`CustomerId`),
  UNIQUE KEY `CustomerCode` (`CustomerCode`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `customer`
--

LOCK TABLES `customer` WRITE;
/*!40000 ALTER TABLE `customer` DISABLE KEYS */;
INSERT INTO `customer` VALUES (1,'Lavie','Lavie','Lavie',NULL,1,'Lavie','2015-08-26 15:27:39','Admin','2015-08-26 15:27:39','Admin'),(2,'A.Huy','A.Huy','A.Huy',1,1,'A.Huy','2015-08-26 15:27:39','Admin','2015-08-26 15:27:39','Admin');
/*!40000 ALTER TABLE `customer` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `item`
--

DROP TABLE IF EXISTS `item`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `item` (
  `ItemId` bigint(20) NOT NULL AUTO_INCREMENT,
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
  `UpdateUser` varchar(32) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`ItemId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `item`
--

LOCK TABLES `item` WRITE;
/*!40000 ALTER TABLE `item` DISABLE KEYS */;
/*!40000 ALTER TABLE `item` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `supplier`
--

DROP TABLE IF EXISTS `supplier`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `supplier` (
  `SupplierId` bigint(20) NOT NULL AUTO_INCREMENT,
  `SupplierCode` varchar(32) COLLATE utf8mb4_unicode_ci NOT NULL,
  `SupplierShortName` varchar(64) COLLATE utf8mb4_unicode_ci NOT NULL,
  `SupplierName` varchar(128) COLLATE utf8mb4_unicode_ci NOT NULL,
  `Enabled` tinyint(1) DEFAULT NULL,
  `Description` varchar(128) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `CreatedDate` datetime DEFAULT CURRENT_TIMESTAMP,
  `CreateUser` varchar(32) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `UpdateDate` datetime DEFAULT CURRENT_TIMESTAMP,
  `UpdateUser` varchar(32) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`SupplierId`),
  UNIQUE KEY `SupplierCode` (`SupplierCode`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `supplier`
--

LOCK TABLES `supplier` WRITE;
/*!40000 ALTER TABLE `supplier` DISABLE KEYS */;
INSERT INTO `supplier` VALUES (1,'PTSC MARINE','PTSC MARINE','PTSC MARINE',1,'PTSC MARINE','2015-08-26 15:28:44','Admin','2015-08-26 15:28:44','Admin'),(2,'FPT','FPT','FPT',1,'FPT','2015-08-26 15:28:44','Admin','2015-08-26 15:28:44','Admin');
/*!40000 ALTER TABLE `supplier` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `transactiondetail`
--

DROP TABLE IF EXISTS `transactiondetail`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `transactiondetail` (
  `TransactionDetailId` bigint(20) NOT NULL AUTO_INCREMENT,
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
  `UpdateUser` varchar(32) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`TransactionDetailId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `transactiondetail`
--

LOCK TABLES `transactiondetail` WRITE;
/*!40000 ALTER TABLE `transactiondetail` DISABLE KEYS */;
/*!40000 ALTER TABLE `transactiondetail` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `transactionmaster`
--

DROP TABLE IF EXISTS `transactionmaster`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `transactionmaster` (
  `TransactionMasterId` bigint(20) NOT NULL AUTO_INCREMENT,
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
  `UpdateUser` varchar(32) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`TransactionMasterId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `transactionmaster`
--

LOCK TABLES `transactionmaster` WRITE;
/*!40000 ALTER TABLE `transactionmaster` DISABLE KEYS */;
/*!40000 ALTER TABLE `transactionmaster` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `transactiontype`
--

DROP TABLE IF EXISTS `transactiontype`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `transactiontype` (
  `TransactionTypeId` bigint(20) NOT NULL AUTO_INCREMENT,
  `TransactionTypeCode` varchar(32) COLLATE utf8mb4_unicode_ci NOT NULL,
  `Enabled` tinyint(1) DEFAULT NULL,
  `Description` varchar(128) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `CreatedDate` datetime DEFAULT CURRENT_TIMESTAMP,
  `CreateUser` varchar(32) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `UpdateDate` datetime DEFAULT CURRENT_TIMESTAMP,
  `UpdateUser` varchar(32) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`TransactionTypeId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `transactiontype`
--

LOCK TABLES `transactiontype` WRITE;
/*!40000 ALTER TABLE `transactiontype` DISABLE KEYS */;
/*!40000 ALTER TABLE `transactiontype` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `unit`
--

DROP TABLE IF EXISTS `unit`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `unit` (
  `UnitId` bigint(20) NOT NULL AUTO_INCREMENT,
  `UnitCode` varchar(32) COLLATE utf8mb4_unicode_ci NOT NULL,
  `UnitName` varchar(64) COLLATE utf8mb4_unicode_ci NOT NULL,
  `Enabled` tinyint(1) DEFAULT NULL,
  `Description` varchar(128) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `CreatedDate` datetime DEFAULT CURRENT_TIMESTAMP,
  `CreateUser` varchar(32) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `UpdateDate` datetime DEFAULT CURRENT_TIMESTAMP,
  `UpdateUser` varchar(32) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`UnitId`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `unit`
--

LOCK TABLES `unit` WRITE;
/*!40000 ALTER TABLE `unit` DISABLE KEYS */;
INSERT INTO `unit` VALUES (1,'CAI','Cái',1,'Cái','2015-08-26 14:59:50','Admin','2015-08-26 14:59:50','Admin'),(2,'MET','Mét',1,'Đơn vị đo chiều dài','2015-08-26 15:00:39','Admin','2015-08-26 15:00:39','Admin'),(3,'BO','Bộ',1,'Một bộ','2015-08-26 15:04:28','Admin','2015-08-26 15:04:28','Admin'),(4,'CUON','Cuộn',1,'Cuộn dây','2015-08-26 15:04:28','Admin','2015-08-26 15:04:28','Admin'),(5,'HOP','Hộp',1,'Hộp','2015-08-26 15:06:01','Admin','2015-08-26 15:06:01','Admin'),(6,'CON','Con',1,'Con','2015-08-26 15:06:01','Admin','2015-08-26 15:06:01','Admin'),(7,'QUYEN','Quyển',1,'Quyển','2015-08-26 15:09:08','Admin','2015-08-26 15:09:08','Admin'),(8,'KG','Kg',1,'Kg','2015-08-26 15:09:08','Admin','2015-08-26 15:09:08','Admin'),(9,'CAY','Cây',1,'Cây','2015-08-26 15:10:41','Admin','2015-08-26 15:10:41','Admin'),(10,'MAY','Máy',1,'Admin','2015-08-26 15:10:41','Admin','2015-08-26 15:10:41','Admin');
/*!40000 ALTER TABLE `unit` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `user`
--

DROP TABLE IF EXISTS `user`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `user` (
  `UserId` bigint(20) NOT NULL AUTO_INCREMENT,
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
  `UpdateUser` varchar(32) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`UserId`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `user`
--

LOCK TABLES `user` WRITE;
/*!40000 ALTER TABLE `user` DISABLE KEYS */;
INSERT INTO `user` VALUES (1,'KietNM','Nguyễn Minh Kiệt','999988887777','090.888.8888','KietNM2505@gmail.com','Admin',1,'Admin','2015-08-26 15:14:55','Admin','2015-08-26 15:14:55','Admin'),(2,'TungPT','Phạm Thanh Tùng','111100001111','098.777.7777','tungpt@gmail.com','Nhập liệu',1,'Nhập liệu','2015-08-26 15:14:55','Admin','2015-08-26 15:14:55','Admin'),(3,'Tuan','Tuấn','666655554444','097.888.11111','tuan@gmail.com','Bán hàng',1,'Bán hàng','2015-08-26 15:17:05','Admin','2015-08-26 15:17:05','Admin'),(4,'Admin','Admin','212233338888','0914.888.666','admin@inventory.com.vn','admin',1,'Admin','2015-08-26 15:17:05','Admin','2015-08-26 15:17:05','Admin');
/*!40000 ALTER TABLE `user` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `warehouse`
--

DROP TABLE IF EXISTS `warehouse`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `warehouse` (
  `WarehouseId` bigint(20) NOT NULL AUTO_INCREMENT,
  `WarehouseCode` varchar(32) COLLATE utf8mb4_unicode_ci NOT NULL,
  `WarehouseName` varchar(128) COLLATE utf8mb4_unicode_ci NOT NULL,
  `WarehouseParentId` bigint(20) DEFAULT NULL,
  `Enabled` tinyint(1) DEFAULT NULL,
  `Description` varchar(128) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `CreatedDate` datetime DEFAULT CURRENT_TIMESTAMP,
  `CreateUser` varchar(32) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `UpdateDate` datetime DEFAULT CURRENT_TIMESTAMP,
  `UpdateUser` varchar(32) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`WarehouseId`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `warehouse`
--

LOCK TABLES `warehouse` WRITE;
/*!40000 ALTER TABLE `warehouse` DISABLE KEYS */;
INSERT INTO `warehouse` VALUES (1,'KHOTONG','KHOTONG',NULL,1,'KHOTONG','2015-08-26 15:30:36','Admin','2015-08-26 15:30:36','Admin'),(2,'KHOCN1','KHOCN1',1,1,'KHOCN1','2015-08-26 15:30:36','Admin','2015-08-26 15:30:36','Admin'),(3,'KHOCN2','KHOCN2',1,1,'KHOCN2','2015-08-26 15:32:20','Admin','2015-08-26 15:32:20','Admin'),(4,'KHOPATNER','KHOPATNER',1,1,'KHOPATNER','2015-08-26 15:32:20','Admin','2015-08-26 15:32:20','Admin');
/*!40000 ALTER TABLE `warehouse` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2015-08-26 21:32:26
