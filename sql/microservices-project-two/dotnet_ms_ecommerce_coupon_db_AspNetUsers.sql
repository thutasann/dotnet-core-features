-- MySQL dump 10.13  Distrib 8.0.34, for macos13 (arm64)
--
-- Host: localhost    Database: dotnet_ms_ecommerce_coupon_db
-- ------------------------------------------------------
-- Server version	8.2.0

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `AspNetUsers`
--

DROP TABLE IF EXISTS `AspNetUsers`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `AspNetUsers` (
  `Id` varchar(255) NOT NULL,
  `UserName` varchar(256) DEFAULT NULL,
  `NormalizedUserName` varchar(256) DEFAULT NULL,
  `Email` varchar(256) DEFAULT NULL,
  `NormalizedEmail` varchar(256) DEFAULT NULL,
  `EmailConfirmed` tinyint(1) NOT NULL,
  `PasswordHash` longtext,
  `SecurityStamp` longtext,
  `ConcurrencyStamp` longtext,
  `PhoneNumber` longtext,
  `PhoneNumberConfirmed` tinyint(1) NOT NULL,
  `TwoFactorEnabled` tinyint(1) NOT NULL,
  `LockoutEnd` datetime(6) DEFAULT NULL,
  `LockoutEnabled` tinyint(1) NOT NULL,
  `AccessFailedCount` int NOT NULL,
  `Name` longtext NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `UserNameIndex` (`NormalizedUserName`),
  KEY `EmailIndex` (`NormalizedEmail`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `AspNetUsers`
--

LOCK TABLES `AspNetUsers` WRITE;
/*!40000 ALTER TABLE `AspNetUsers` DISABLE KEYS */;
INSERT INTO `AspNetUsers` VALUES ('5c8f78c5-400f-45ef-b83b-8f0fb217c71e','cus1@gmail.com','CUS1@GMAIL.COM','cus1@gmail.com','CUS1@GMAIL.COM',0,'AQAAAAIAAYagAAAAEJZQRpfa+cG7V0v3doN8Mw7tSHiC4EorKCAf6wp16ivzC/uEyHuBmxwi1deEkEnAEw==','D7VPPW2MWAALXQBRGFIOJ5I7H3V3GLXI','ebbc3dcd-b819-41a1-a90a-a36396396518','123123',0,0,NULL,1,0,'customer one'),('64fe9c34-3a38-4238-b8de-80c25965ce42','kyaw@gmail.com','KYAW@GMAIL.COM','kyaw@gmail.com','KYAW@GMAIL.COM',0,'AQAAAAIAAYagAAAAEAMdNk0nIbK7Yr9BWRSnidHdE1R1aVuY5/+FJvT2RpDyu6mH4p8fAug5cWEfUdGXIw==','OLYAK5X3UXE6MDASDDR3ILPASA2WWBES','508af099-7a44-48c6-b9b9-eb3d5e50f949','123123',0,0,NULL,1,0,'kyaw'),('a3474b3a-da0c-4aed-bb06-208bccfe0566','hsuyeywel@gmail.com','HSUYEYWEL@GMAIL.COM','hsuyeywel@gmail.com','HSUYEYWEL@GMAIL.COM',0,'AQAAAAIAAYagAAAAEHCI1riQD6RC1KrBHQKXBs3nI6NpSQmxtdnchTLHL1N79hcv1cQ4Q3hZJB7IIuVm2w==','O676IJXGIVNHNIRCAK5P2XZL4FWXLUMO','5e33a579-bdd7-4877-9536-dc30c0b3e7fc','123123123',0,0,NULL,1,0,'Hsu ye ywel'),('b84de3fb-57e9-4941-a8aa-a0cc6e5536ca','thutasann2002@gmail.com','THUTASANN2002@GMAIL.COM','thutasann2002@gmail.com','THUTASANN2002@GMAIL.COM',0,'AQAAAAIAAYagAAAAEC7yUQEVmZqx1j/CYulD2RN4M22cpSjRfIz8EqCVlspspj8Ud1L788NTH9et4m0bbg==','JWB732LTV4H3JBV5RQUPYD4O35KZWEZP','bfef3d7b-2355-43e3-8300-b91f6771d58a','+6586952624',0,0,NULL,1,0,'Thuta Sann'),('da8d1e93-267f-4b00-bc6b-84e56070821b','zaw@gmail.com','ZAW@GMAIL.COM','zaw@gmail.com','ZAW@GMAIL.COM',0,'AQAAAAIAAYagAAAAEFfjuIZPl89jl0/XHRDey5hCZZq4UoXtDepudXCm2LUf+mst/Wng5M8+BQtsTn761g==','4ADSWSSVMH5R4JJSKBTSPJZF4KJPAT23','5639914e-afd9-446c-b470-3a01c1644ceb','12312312',0,0,NULL,1,0,'zaw zaw');
/*!40000 ALTER TABLE `AspNetUsers` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-03-17 19:45:47
