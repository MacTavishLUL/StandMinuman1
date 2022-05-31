/*
SQLyog Community v13.1.9 (64 bit)
MySQL - 10.4.22-MariaDB : Database - stand_minuman
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`stand_minuman` /*!40100 DEFAULT CHARACTER SET utf8mb4 */;

USE `stand_minuman`;

/*Table structure for table `category_minuman` */

DROP TABLE IF EXISTS `category_minuman`;

CREATE TABLE `category_minuman` (
  `id_category_minuman` double NOT NULL AUTO_INCREMENT,
  `nama` varchar(30) NOT NULL,
  `status` int(1) NOT NULL DEFAULT 1,
  PRIMARY KEY (`id_category_minuman`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4;

/*Data for the table `category_minuman` */

insert  into `category_minuman`(`id_category_minuman`,`nama`,`status`) values 
(1,'No Category',1),
(2,'Teh',1),
(3,'Jus',1),
(4,'Milkshake',1);

/*Table structure for table `dtrans` */

DROP TABLE IF EXISTS `dtrans`;

CREATE TABLE `dtrans` (
  `no_nota` varchar(50) NOT NULL,
  `id_minuman` double NOT NULL,
  `id_topping` double NOT NULL DEFAULT 1,
  `jumlah` double NOT NULL,
  `subtotal_minuman` double DEFAULT NULL,
  `subtotal_topping` double DEFAULT NULL,
  `subtotal` double NOT NULL,
  `status` int(1) NOT NULL DEFAULT 1,
  PRIMARY KEY (`no_nota`,`id_minuman`,`id_topping`),
  KEY `id_minuman` (`id_minuman`),
  KEY `id_topping` (`id_topping`),
  CONSTRAINT `dtrans_ibfk_1` FOREIGN KEY (`no_nota`) REFERENCES `htrans` (`no_nota`),
  CONSTRAINT `dtrans_ibfk_2` FOREIGN KEY (`id_minuman`) REFERENCES `minuman` (`id_minuman`),
  CONSTRAINT `dtrans_ibfk_3` FOREIGN KEY (`id_topping`) REFERENCES `topping` (`id_topping`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Data for the table `dtrans` */

insert  into `dtrans`(`no_nota`,`id_minuman`,`id_topping`,`jumlah`,`subtotal_minuman`,`subtotal_topping`,`subtotal`,`status`) values 
('H2205120001',1,1,2,20000,0,20000,1),
('H2205120002',2,2,1,12000,2000,14000,1),
('H2205120003',2,1,2,12000,0,24000,1),
('H2205120003',2,2,1,12000,2000,14000,1),
('H2205120003',3,3,1,15000,3000,18000,1),
('H2205230001',2,3,2,24000,6000,30000,1),
('H2205230001',3,3,1,15000,3000,18000,1),
('H2205240001',3,3,2,30000,6000,36000,1),
('H2205240001',4,1,1,16000,0,16000,1),
('H2205250001',1,1,2,20000,0,20000,1),
('H2205250001',2,4,1,12000,2500,14500,1),
('H2205250001',4,3,1,16000,3000,19000,1);

/*Table structure for table `htrans` */

DROP TABLE IF EXISTS `htrans`;

CREATE TABLE `htrans` (
  `no_nota` varchar(50) NOT NULL,
  `tanggal` datetime NOT NULL DEFAULT current_timestamp(),
  `total` double NOT NULL,
  `id_users` double NOT NULL,
  `status` int(1) NOT NULL DEFAULT 1,
  PRIMARY KEY (`no_nota`),
  KEY `id_users` (`id_users`),
  CONSTRAINT `htrans_ibfk_1` FOREIGN KEY (`id_users`) REFERENCES `users` (`id_users`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Data for the table `htrans` */

insert  into `htrans`(`no_nota`,`tanggal`,`total`,`id_users`,`status`) values 
('H2205120001','2022-05-12 14:01:58',20000,2,1),
('H2205120002','2022-05-12 14:04:45',14000,3,1),
('H2205120003','2022-05-12 14:07:27',56000,2,1),
('H2205230001','2022-05-23 15:14:19',48000,2,1),
('H2205240001','2022-05-24 11:35:53',52000,2,1),
('H2205250001','2022-05-25 21:05:50',53500,3,1);

/*Table structure for table `minuman` */

DROP TABLE IF EXISTS `minuman`;

CREATE TABLE `minuman` (
  `id_minuman` double NOT NULL AUTO_INCREMENT,
  `nama` varchar(100) NOT NULL,
  `stok` double NOT NULL,
  `harga` double NOT NULL,
  `id_category_minuman` double NOT NULL DEFAULT 1,
  `status` int(1) NOT NULL DEFAULT 1,
  PRIMARY KEY (`id_minuman`),
  KEY `id_category_minuman` (`id_category_minuman`),
  CONSTRAINT `minuman_ibfk_1` FOREIGN KEY (`id_category_minuman`) REFERENCES `category_minuman` (`id_category_minuman`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4;

/*Data for the table `minuman` */

insert  into `minuman`(`id_minuman`,`nama`,`stok`,`harga`,`id_category_minuman`,`status`) values 
(1,'Es Teh Manis',194,10000,2,1),
(2,'Jus Jeruk',4957,12000,3,1),
(3,'Milkshake',27,15000,4,1),
(4,'Chocolate Milkshake',98,16000,4,1);

/*Table structure for table `topping` */

DROP TABLE IF EXISTS `topping`;

CREATE TABLE `topping` (
  `id_topping` double NOT NULL AUTO_INCREMENT,
  `nama` varchar(100) NOT NULL,
  `harga` double NOT NULL,
  `status` int(1) NOT NULL DEFAULT 1,
  PRIMARY KEY (`id_topping`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4;

/*Data for the table `topping` */

insert  into `topping`(`id_topping`,`nama`,`harga`,`status`) values 
(1,'No Topping',0,1),
(2,'Gula',2000,1),
(3,'Chocolate Chip',3000,1),
(4,'Jeruk Nipis',2500,1);

/*Table structure for table `users` */

DROP TABLE IF EXISTS `users`;

CREATE TABLE `users` (
  `id_users` double NOT NULL AUTO_INCREMENT,
  `username` varchar(30) NOT NULL,
  `password` varchar(255) NOT NULL,
  `nama` varchar(100) NOT NULL,
  `privilege` int(1) NOT NULL DEFAULT 1,
  `status` int(1) NOT NULL DEFAULT 1,
  PRIMARY KEY (`id_users`),
  UNIQUE KEY `Username` (`username`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4;

/*Data for the table `users` */

insert  into `users`(`id_users`,`username`,`password`,`nama`,`privilege`,`status`) values 
(1,'admin','21232F297A57A5A743894A0E4A801FC3','admin',2,1),
(2,'Azhure','8875A6E498FF20B1553FF264E9B07A53','Azhure Raven',1,1),
(3,'Kevin','C1F80EDDEA77F14650A2062DDA3EB15C','Kevin Jonathan',1,1),
(4,'Rocky','DE03C6DE427184AFE57262DE14D084D7','Rocky Chandra',1,1);

/* Function  structure for function  `genNoNota` */

/*!50003 DROP FUNCTION IF EXISTS `genNoNota` */;
DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` FUNCTION `genNoNota`() RETURNS varchar(100) CHARSET utf8mb4
BEGIN
 DECLARE hasil VARCHAR(100) DEFAULT ''; 
 DECLARE counted INT; 			
 
 SELECT IFNULL(COUNT(*),0) INTO counted FROM htrans
 WHERE no_nota LIKE CONCAT('%H',DATE_FORMAT(NOW(), '%y%m%d'),'%');
 SET counted = counted + 1;
 
 SET hasil = CONCAT('H',DATE_FORMAT(NOW(),'%y%m%d'),LPAD(counted,4,'0'));
 RETURN hasil;
END */$$
DELIMITER ;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
