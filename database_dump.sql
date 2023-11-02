DROP DATABASE eventhouse;
CREATE DATABASE  IF NOT EXISTS eventhouse;/*!40100 DEFAULT CHARACTER SET utf8mb3 */ /*!80016 DEFAULT ENCRYPTION='N' */;
CREATE USER 'netuser'@'localhost' IDENTIFIED BY 'netpass';
GRANT ALL on eventhouse.* to 'netuser'@'localhost';
USE `eventhouse`;


-- MySQL dump 10.13  Distrib 8.0.33, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: eventhouse
-- ------------------------------------------------------
-- Server version	8.0.31

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
-- Table structure for table `event`
--

DROP TABLE IF EXISTS `event`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `event` (
  `eventID` int NOT NULL AUTO_INCREMENT,
  `artist` varchar(45) NOT NULL,
  `location` varchar(45) NOT NULL,
  `description` varchar(300) DEFAULT NULL,
  `date` date NOT NULL,
  PRIMARY KEY (`eventID`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `event`
--

LOCK TABLES `event` WRITE;
/*!40000 ALTER TABLE `event` DISABLE KEYS */;
INSERT INTO `event` VALUES (1,'Horsegiirl','Holzgraben 9, 60313 Frankfurt am Main','Fun night of techno, come early and stay late','2023-06-06'),(2,'Ski Aggu','Bismarckstraße 133, 64293 Darmstadt','Up and coming rapper from west berlin who raps about partying','2023-06-16'),(3,'TV Girl','Carl-Benz-Straße 21, 60386 Frankfurt am Main','A band who went viral on ticket now on their world tour. Indie-pop vibes','2023-06-19'),(4,'Berliner Naechte','Holzgraben 9, 60313 Frankfurt am Main','Over 30 djs performing on the night with over 4 dance floors to choose from','2023-07-02'),(5,'King Krule','Bismarckstraße 133, 64293 Darmstadt','King krule is currently on his European tour for his new album. Indie rock vibes','2023-07-25'),(6,'Kerri Chandler','Heiligkreuzgasse 22, 60313 Frankfurt am Main','Godfather of house music returns to Frankfurt after 7 years','2023-07-30'),(7,'Red Hot Chili Peppers','Mörfelder Landstraße 362, 60598 Frankfurt','A must-see rock band returning to Germany along with the release of their new album','2023-08-12'),(8,'Kendrick Lamar','Mörfelder Landstraße 362, 60598 Frankfurt','The king of rap who wrote the hit song Money Trees','2023-08-27'),(9,'DBBD','Heiligkreuzgasse 22, 60313 Frankfurt am Main','Booming into the scene this year with fun bouncy beats. Guaranteed night of fun','2023-08-31'),(10,'Peach Pit','Carl-Benz-Straße 21, 60386 Frankfurt am Main','Summer- bummer indie rock band comes to Germany for the first time','2023-09-06');
/*!40000 ALTER TABLE `event` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `user`
--

DROP TABLE IF EXISTS `user`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `user` (
  `userID` int NOT NULL AUTO_INCREMENT,
  `fname` varchar(45) NOT NULL,
  `lname` varchar(45) NOT NULL,
  `username` varchar(45) NOT NULL,
  `password` varchar(255) NOT NULL,
  PRIMARY KEY (`userID`),
  UNIQUE KEY `username_UNIQUE` (`username`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `user`
--

LOCK TABLES `user` WRITE;
/*!40000 ALTER TABLE `user` DISABLE KEYS */;
/*!40000 ALTER TABLE `user` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `wishlist`
--

DROP TABLE IF EXISTS `wishlist`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `wishlist` (
  `userID` int NOT NULL,
  `eventID` int DEFAULT NULL,
  PRIMARY KEY (`userID`),
  KEY `event-wishlist_idx` (`eventID`),
  CONSTRAINT `event-wishlist` FOREIGN KEY (`eventID`) REFERENCES `event` (`eventID`) ON DELETE RESTRICT ON UPDATE CASCADE,
  CONSTRAINT `user-wishlist` FOREIGN KEY (`userID`) REFERENCES `user` (`userID`) ON DELETE RESTRICT ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `wishlist`
--

LOCK TABLES `wishlist` WRITE;
/*!40000 ALTER TABLE `wishlist` DISABLE KEYS */;
/*!40000 ALTER TABLE `wishlist` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping routines for database 'eventhouse'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-05-18 11:31:58
