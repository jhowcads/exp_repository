CREATE DATABASE  IF NOT EXISTS `db_contestscoremng` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `db_contestscoremng`;
-- MySQL dump 10.13  Distrib 5.5.16, for Win32 (x86)
--
-- Host: localhost    Database: db_contestscoremng
-- ------------------------------------------------------
-- Server version	5.1.48-community

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
-- Table structure for table `tbl_contestants`
--

DROP TABLE IF EXISTS `tbl_contestants`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbl_contestants` (
  `ContestantID` bigint(20) NOT NULL AUTO_INCREMENT,
  `ContestantNo` int(11) DEFAULT NULL,
  `FName` varchar(100) DEFAULT NULL,
  `LName` varchar(100) DEFAULT NULL,
  `PicturePath` text,
  `BDate` varchar(45) DEFAULT NULL,
  `Address` text,
  PRIMARY KEY (`ContestantID`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_contestants`
--

LOCK TABLES `tbl_contestants` WRITE;
/*!40000 ALTER TABLE `tbl_contestants` DISABLE KEYS */;
INSERT INTO `tbl_contestants` VALUES (1,1,'Sakura','Haruno','sakura.jpg',NULL,NULL),(2,2,'Hinata','Hyuga','Hinata.png',NULL,NULL),(3,3,'Ino','Yamanaka','Ino.png',NULL,NULL),(4,4,'Yuri','Plisetski','Yuri.jpg',NULL,NULL);
/*!40000 ALTER TABLE `tbl_contestants` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_criteria`
--

DROP TABLE IF EXISTS `tbl_criteria`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbl_criteria` (
  `CriteriaID` bigint(20) NOT NULL AUTO_INCREMENT,
  `Criteria` varchar(45) DEFAULT NULL,
  `Percentage` int(11) DEFAULT NULL,
  PRIMARY KEY (`CriteriaID`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_criteria`
--

LOCK TABLES `tbl_criteria` WRITE;
/*!40000 ALTER TABLE `tbl_criteria` DISABLE KEYS */;
INSERT INTO `tbl_criteria` VALUES (1,'Q and A',25),(2,'Gown',25),(3,'Talent',25),(4,'Beauty',25);
/*!40000 ALTER TABLE `tbl_criteria` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_judges`
--

DROP TABLE IF EXISTS `tbl_judges`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbl_judges` (
  `JudgeID` bigint(20) NOT NULL AUTO_INCREMENT,
  `FName` varchar(100) DEFAULT NULL,
  `LName` varchar(100) DEFAULT NULL,
  `Title` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`JudgeID`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_judges`
--

LOCK TABLES `tbl_judges` WRITE;
/*!40000 ALTER TABLE `tbl_judges` DISABLE KEYS */;
INSERT INTO `tbl_judges` VALUES (1,'Sanji','Vinsmoke','Pirate King\'s Cook'),(2,'Victor','Nikiforov','Best Ice Skater');
/*!40000 ALTER TABLE `tbl_judges` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_scoring`
--

DROP TABLE IF EXISTS `tbl_scoring`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbl_scoring` (
  `ScoringID` bigint(20) NOT NULL,
  `ContestantID` bigint(20) DEFAULT NULL,
  `JudgeID` bigint(20) DEFAULT NULL,
  `CriteriaID` bigint(20) DEFAULT NULL,
  `Score` decimal(4,2) DEFAULT NULL,
  PRIMARY KEY (`ScoringID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_scoring`
--

LOCK TABLES `tbl_scoring` WRITE;
/*!40000 ALTER TABLE `tbl_scoring` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_scoring` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2018-02-13 12:14:38
