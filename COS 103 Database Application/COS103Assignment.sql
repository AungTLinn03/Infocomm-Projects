-- MySQL dump 10.11
--
-- Host: localhost    Database: atl
-- ------------------------------------------------------
-- Server version	5.0.45-community-nt

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
-- Table structure for table `aerofly`
--

DROP TABLE IF EXISTS `aerofly`;
CREATE TABLE `aerofly` (
  `AFid` varchar(7) NOT NULL,
  `AFdate` date NOT NULL,
  `AFduration` time NOT NULL,
  `AEid` varchar(7) NOT NULL,
  `Evacuation` varchar(21) NOT NULL,
  `Approach` varchar(21) NOT NULL,
  `Duration` varchar(21) NOT NULL,
  PRIMARY KEY  (`AFid`),
  KEY `AEid` (`AEid`),
  CONSTRAINT `aerofly_ibfk_1` FOREIGN KEY (`AEid`) REFERENCES `aeroplane` (`AEid`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `aerofly`
--

LOCK TABLES `aerofly` WRITE;
/*!40000 ALTER TABLE `aerofly` DISABLE KEYS */;
INSERT INTO `aerofly` VALUES ('AF001','2019-06-08','23:55:00','Ae001','Malaysia','Vietnam','1 hour'),('AF0010','2022-12-16','21:30:00','Ae0010','Argentina','Portugal','7hrs 35minutes'),('AF002','2021-08-09','03:03:32','Ae002','USA','Thailand','38 hour'),('AF003','2017-05-06','17:00:00','Ae003','Cambodia','Lao','54 minutes'),('AF004','2018-02-23','17:00:00','Ae004','Uruguay','UAE','6hr 23minutes'),('AF005','2022-12-12','01:30:25','Ae005','Indonesia','Singapore','2hr 14minutes'),('AF006','2017-11-29','08:52:00','Ae006','Paraguay','India','5 hours'),('AF007','2021-06-07','21:30:00','Ae007','Norway','London','4 hours'),('AF008','2019-10-05','05:23:00','Ae008','Mexico','Bahamas','7 hours'),('AF009','2022-05-02','06:23:12','Ae009','Iran','France','9 hours');
/*!40000 ALTER TABLE `aerofly` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `aeroplane`
--

DROP TABLE IF EXISTS `aeroplane`;
CREATE TABLE `aeroplane` (
  `AEid` varchar(7) NOT NULL,
  `AEmodelno` varchar(7) NOT NULL,
  `AEcapacity` int(11) NOT NULL,
  `AEweight` varchar(110) NOT NULL,
  `AEdistance` double(9,3) default NULL,
  `AEtype` varchar(21) default NULL,
  PRIMARY KEY  (`AEid`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `aeroplane`
--

LOCK TABLES `aeroplane` WRITE;
/*!40000 ALTER TABLE `aeroplane` DISABLE KEYS */;
INSERT INTO `aeroplane` VALUES ('Ae001','BB737',355,'442MetricTons',387523.254,'Airbus'),('Ae0010','KJ86',425,'897MetricTons',999872.400,'Aeroplane'),('Ae002','BB747',555,'652MetricTons',789856.254,'Aeroplane'),('Ae003','LJ25',28,'115MetricTons',8956.210,'PrivateJet'),('Ae004','M205P',154,'475MetricTons',965351.200,'Airplane'),('Ae005','FujiUH',385,'875MetricTons',235681.200,'Airbus'),('Ae006','BUH1C',5,'21MetricTons',2351.200,'Helicopter'),('Ae007','Mi2US',8,'34MetricTons',54512.200,'Helicopter'),('Ae008','GG550',34,'298MetricTons',768514.200,'PrivateJet'),('Ae009','Fa900',39,'328MetricTons',957412.400,'PrivateJet');
/*!40000 ALTER TABLE `aeroplane` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `assessmentrecord`
--

DROP TABLE IF EXISTS `assessmentrecord`;
CREATE TABLE `assessmentrecord` (
  `Asid` varchar(7) NOT NULL,
  `Pid` varchar(7) NOT NULL,
  `lastreport` date NOT NULL,
  `nextreport` date NOT NULL,
  `ACid` varchar(7) NOT NULL,
  PRIMARY KEY  (`Asid`),
  KEY `Pid` (`Pid`),
  KEY `ACid` (`ACid`),
  CONSTRAINT `assessmentrecord_ibfk_1` FOREIGN KEY (`Pid`) REFERENCES `pilot` (`Pid`),
  CONSTRAINT `assessmentrecord_ibfk_2` FOREIGN KEY (`ACid`) REFERENCES `assessmenttrans` (`ACid`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `assessmentrecord`
--

LOCK TABLES `assessmentrecord` WRITE;
/*!40000 ALTER TABLE `assessmentrecord` DISABLE KEYS */;
INSERT INTO `assessmentrecord` VALUES ('Asm001','P001','2019-06-05','2022-08-09','AC001'),('Asm002','P002','2017-08-19','2019-05-21','AC002'),('Asm003','P003','2013-03-08','2018-02-07','AC003'),('Asm004','P004','2019-01-15','2021-07-03','AC004'),('Asm005','P005','2016-02-09','2020-08-05','AC005'),('Asm006','P006','2021-05-06','2022-05-23','AC006');
/*!40000 ALTER TABLE `assessmentrecord` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `assessmenttrans`
--

DROP TABLE IF EXISTS `assessmenttrans`;
CREATE TABLE `assessmenttrans` (
  `ACid` varchar(7) NOT NULL,
  `Pid` varchar(7) NOT NULL,
  `Aid` varchar(7) NOT NULL,
  `Consequences` enum('Pass','Fail') NOT NULL,
  `Adate` date NOT NULL,
  `Score` int(11) NOT NULL,
  `Description` varchar(51) NOT NULL,
  PRIMARY KEY  (`ACid`),
  KEY `Pid` (`Pid`),
  KEY `Aid` (`Aid`),
  CONSTRAINT `assessmenttrans_ibfk_1` FOREIGN KEY (`Pid`) REFERENCES `pilot` (`Pid`),
  CONSTRAINT `assessmenttrans_ibfk_2` FOREIGN KEY (`Aid`) REFERENCES `assessmenttype` (`Aid`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `assessmenttrans`
--

LOCK TABLES `assessmenttrans` WRITE;
/*!40000 ALTER TABLE `assessmenttrans` DISABLE KEYS */;
INSERT INTO `assessmenttrans` VALUES ('AC001','P001','As001','Pass','2019-03-25',65,'Hearing Test'),('AC002','P002','As002','Fail','2020-06-02',26,'Vision Test'),('AC003','P003','As003','Pass','2018-05-08',85,'Mental Test'),('AC004','P004','As004','Fail','2020-08-19',39,'Memory Test'),('AC005','P005','As005','Pass','2021-07-30',96,'Vision Test'),('AC006','P006','As006','Fail','2016-02-25',23,'Mental Test');
/*!40000 ALTER TABLE `assessmenttrans` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `assessmenttype`
--

DROP TABLE IF EXISTS `assessmenttype`;
CREATE TABLE `assessmenttype` (
  `Aid` varchar(7) NOT NULL,
  `Aname` varchar(21) NOT NULL,
  `Routine` varchar(21) NOT NULL,
  PRIMARY KEY  (`Aid`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `assessmenttype`
--

LOCK TABLES `assessmenttype` WRITE;
/*!40000 ALTER TABLE `assessmenttype` DISABLE KEYS */;
INSERT INTO `assessmenttype` VALUES ('As001','A check','635 Flighthours'),('As002','B check','adaptable'),('As003','C check','9 to 19 months'),('As004','D check','53 flighthours'),('As005','3C check','9 to 10 years'),('As006','Annual Check','6 to 13 months');
/*!40000 ALTER TABLE `assessmenttype` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `maintenance`
--

DROP TABLE IF EXISTS `maintenance`;
CREATE TABLE `maintenance` (
  `AEmaintainid` varchar(7) NOT NULL,
  `AEid` varchar(7) NOT NULL,
  `maintdate` date NOT NULL,
  `MtypeID` varchar(7) NOT NULL,
  `score` varchar(21) default NULL,
  PRIMARY KEY  (`AEmaintainid`),
  KEY `AEid` (`AEid`),
  KEY `MtypeID` (`MtypeID`),
  CONSTRAINT `maintenance_ibfk_1` FOREIGN KEY (`AEid`) REFERENCES `aeroplane` (`AEid`),
  CONSTRAINT `maintenance_ibfk_2` FOREIGN KEY (`MtypeID`) REFERENCES `mtype` (`MtypeID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `maintenance`
--

LOCK TABLES `maintenance` WRITE;
/*!40000 ALTER TABLE `maintenance` DISABLE KEYS */;
INSERT INTO `maintenance` VALUES ('Am001','Ae001','2016-08-23','Mt001','30'),('Am0010','Ae0010','2019-06-30','Mt0010','67'),('Am002','Ae002','2019-05-06','Mt002','90'),('Am003','Ae003','2016-08-25','Mt003','25'),('Am004','Ae004','2021-11-19','Mt004','78'),('Am005','Ae005','2016-08-05','Mt005','22'),('Am006','Ae006','2016-08-13','Mt006','86'),('Am007','Ae007','2016-08-19','Mt007','68'),('Am008','Ae008','2016-10-07','Mt008','98'),('Am009','Ae009','2016-08-02','Mt009','45');
/*!40000 ALTER TABLE `maintenance` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `maintenancetechnician`
--

DROP TABLE IF EXISTS `maintenancetechnician`;
CREATE TABLE `maintenancetechnician` (
  `AEmaintainid` varchar(7) NOT NULL,
  `Techid` varchar(7) NOT NULL,
  `hours` time NOT NULL,
  PRIMARY KEY  (`AEmaintainid`,`Techid`),
  KEY `Techid` (`Techid`),
  CONSTRAINT `maintenancetechnician_ibfk_1` FOREIGN KEY (`AEmaintainid`) REFERENCES `maintenance` (`AEmaintainid`),
  CONSTRAINT `maintenancetechnician_ibfk_2` FOREIGN KEY (`Techid`) REFERENCES `techniciansupport` (`Techid`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `maintenancetechnician`
--

LOCK TABLES `maintenancetechnician` WRITE;
/*!40000 ALTER TABLE `maintenancetechnician` DISABLE KEYS */;
INSERT INTO `maintenancetechnician` VALUES ('Am001','T001','12:30:34'),('Am0010','T0010','06:00:00'),('Am002','T002','01:00:20'),('Am003','T003','04:23:11'),('Am004','T004','09:12:02'),('Am005','T005','08:00:50'),('Am006','T006','02:21:00'),('Am007','T007','04:09:00'),('Am008','T008','11:02:53'),('Am009','T009','07:45:00');
/*!40000 ALTER TABLE `maintenancetechnician` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `mtype`
--

DROP TABLE IF EXISTS `mtype`;
CREATE TABLE `mtype` (
  `MtypeID` varchar(7) NOT NULL,
  `AEname` varchar(21) NOT NULL,
  `outcome` enum('Pass','Fail') NOT NULL,
  PRIMARY KEY  (`MtypeID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `mtype`
--

LOCK TABLES `mtype` WRITE;
/*!40000 ALTER TABLE `mtype` DISABLE KEYS */;
INSERT INTO `mtype` VALUES ('Mt001','KyawKhant','Fail'),('Mt0010','Rkar','Pass'),('Mt002','MinKyaw','Pass'),('Mt003','Gerard','Fail'),('Mt004','MyoMin','Pass'),('Mt005','Nicky','Fail'),('Mt006','BhoneWin','Pass'),('Mt007','KaungWai','Pass'),('Mt008','Willie','Pass'),('Mt009','Shane','Pass');
/*!40000 ALTER TABLE `mtype` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `pilot`
--

DROP TABLE IF EXISTS `pilot`;
CREATE TABLE `pilot` (
  `Pid` varchar(7) NOT NULL,
  `Pname` varchar(21) NOT NULL,
  `Prank` enum('SeniorOfficer','Captain','SeniorCaptain') NOT NULL,
  `Paddress` varchar(21) NOT NULL,
  `Pphone` int(11) NOT NULL,
  `Pplanetype` varchar(21) NOT NULL,
  `PExperience` varchar(21) NOT NULL,
  `PGender` enum('Male','Female') NOT NULL,
  PRIMARY KEY  (`Pid`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `pilot`
--

LOCK TABLES `pilot` WRITE;
/*!40000 ALTER TABLE `pilot` DISABLE KEYS */;
INSERT INTO `pilot` VALUES ('P001','Min Aung','SeniorOfficer','Malaysia',985642317,'Private Jet','6 years','Male'),('P0010','Vina','SeniorOfficer','Solvakia',87546935,'Airbus','11 Years','Female'),('P002','Su su','Captain','UAE',854297561,'Helicopter','3 Years','Female'),('P003','Kyaw Myo','SeniorCaptain','America',985467312,'Airbus','6 Years','Male'),('P004','Mae Lone','SeniorOfficer','Myanmar',567542398,'Airbus','9 Years','Male'),('P005','Khin Khin','Captain','Indonesia',895647235,'Privat Jet','5 Years','Female'),('P006','Owesea','SeniorCaptain','Sewden',52463257,'Aeroplane','4 Years','Male'),('P007','Zaltan','SeniorOfficer','Norway',86574231,'Airbus','12 Years','Male'),('P008','Depaul','SeniorCaptain','Agentina',78954321,'Helicopter','7 Years','Male'),('P009','Malkova','Captain','USSR',85624317,'Aeroplane','8 Years','Female');
/*!40000 ALTER TABLE `pilot` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `pilotaerofly`
--

DROP TABLE IF EXISTS `pilotaerofly`;
CREATE TABLE `pilotaerofly` (
  `AFid` varchar(7) NOT NULL,
  `Pid` varchar(7) NOT NULL,
  PRIMARY KEY  (`AFid`,`Pid`),
  KEY `Pid` (`Pid`),
  CONSTRAINT `pilotaerofly_ibfk_1` FOREIGN KEY (`AFid`) REFERENCES `aerofly` (`AFid`),
  CONSTRAINT `pilotaerofly_ibfk_2` FOREIGN KEY (`Pid`) REFERENCES `pilot` (`Pid`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `pilotaerofly`
--

LOCK TABLES `pilotaerofly` WRITE;
/*!40000 ALTER TABLE `pilotaerofly` DISABLE KEYS */;
INSERT INTO `pilotaerofly` VALUES ('AF001','P001'),('AF0010','P0010'),('AF002','P002'),('AF003','P003'),('AF004','P004'),('AF005','P005'),('AF006','P006'),('AF007','P007'),('AF008','P008'),('AF009','P009');
/*!40000 ALTER TABLE `pilotaerofly` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `technician`
--

DROP TABLE IF EXISTS `technician`;
CREATE TABLE `technician` (
  `Techid` varchar(21) NOT NULL,
  `Techname` varchar(21) NOT NULL,
  `Techphone` int(11) NOT NULL,
  `Techaddress` varchar(51) NOT NULL,
  `Expertplane` enum('Yes','No') NOT NULL,
  `Techniciangender` enum('Male','Female') NOT NULL,
  `TechnicianPosition` enum('Junior','Intermediate','Senior') NOT NULL,
  `TechnicianDOB` date NOT NULL,
  PRIMARY KEY  (`Techid`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `technician`
--

LOCK TABLES `technician` WRITE;
/*!40000 ALTER TABLE `technician` DISABLE KEYS */;
INSERT INTO `technician` VALUES ('T001','James',89652347,'NewYork','Yes','Male','Intermediate','1985-12-03'),('T0010','Christina',856698427,'Thailand','Yes','Female','Senior','2003-04-03'),('T002','Zelensky',56974852,'Poland','Yes','Male','Intermediate','1985-01-04'),('T003','Lewandoski',998563259,'Poland','Yes','Male','Intermediate','1979-07-25'),('T004','Dybala',876542315,'Argentina','Yes','Male','Senior','1989-12-15'),('T005','Taylor',582364217,'Germany','Yes','Female','Senior','1991-08-09'),('T006','Christine',896321474,'Russia','Yes','Female','Senior','1993-01-13'),('T007','Laura',887596324,'Estonia','Yes','Female','Intermediate','2000-02-19'),('T008','Maxey',447896521,'Uganda','Yes','Male','Junior','1997-05-05'),('T009','YuYu',875694231,'Algeria','Yes','Female','Junior','2002-07-16');
/*!40000 ALTER TABLE `technician` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `techniciansupport`
--

DROP TABLE IF EXISTS `techniciansupport`;
CREATE TABLE `techniciansupport` (
  `Techid` varchar(21) NOT NULL,
  `AEid` varchar(7) NOT NULL,
  `experttech` enum('Yes','No') NOT NULL,
  PRIMARY KEY  (`Techid`,`AEid`),
  KEY `AEid` (`AEid`),
  CONSTRAINT `techniciansupport_ibfk_1` FOREIGN KEY (`Techid`) REFERENCES `technician` (`Techid`),
  CONSTRAINT `techniciansupport_ibfk_2` FOREIGN KEY (`AEid`) REFERENCES `aeroplane` (`AEid`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `techniciansupport`
--

LOCK TABLES `techniciansupport` WRITE;
/*!40000 ALTER TABLE `techniciansupport` DISABLE KEYS */;
INSERT INTO `techniciansupport` VALUES ('T001','Ae001','Yes'),('T0010','Ae0010','Yes'),('T002','Ae002','Yes'),('T003','Ae003','Yes'),('T004','Ae004','Yes'),('T005','Ae005','Yes'),('T006','Ae006','Yes'),('T007','Ae007','Yes'),('T008','Ae008','Yes'),('T009','Ae009','Yes');
/*!40000 ALTER TABLE `techniciansupport` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-12-08 18:33:54
