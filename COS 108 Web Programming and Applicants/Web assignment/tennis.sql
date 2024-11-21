-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jul 26, 2022 at 08:59 PM
-- Server version: 10.4.24-MariaDB
-- PHP Version: 8.1.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `tennis`
--

-- --------------------------------------------------------

--
-- Table structure for table `member`
--

CREATE TABLE `member` (
  `Mid` int(11) NOT NULL,
  `Name` varchar(25) NOT NULL,
  `Sid` varchar(25) NOT NULL,
  `Contact_no` int(11) NOT NULL,
  `Email` varchar(25) NOT NULL,
  `Gender` varchar(8) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `member`
--

INSERT INTO `member` (`Mid`, `Name`, `Sid`, `Contact_no`, `Email`, `Gender`) VALUES
(1, 'Aung Tun Lin', 'S1', 966335982, 'Aung@gmail.com', 'male'),
(2, 'Min Htet', 'S5', 5698542, 'hein@gmail.com', 'Male'),
(3, 'Kyaw Min', 's45', 98545632, 'KyawMin@gmail.com', 'Male'),
(9, 'Hein Min', 'S1', 98562314, 'milk798@gmail.com', 'Female'),
(11, 'Minmaw', 's85', 978456231, 'Minmaw@gmail.com', 'Male'),
(12, 'George', 's22', 25847963, 'georgeme@gmail.com', 'Male'),
(13, 'Christine', 's23', 97562148, 'christine25@gmail.com', 'Female'),
(14, 'Jessie', 's49', 965847123, 'Mike49@gmail.com', 'Female');

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE `user` (
  `ID` int(11) NOT NULL,
  `username` varchar(20) NOT NULL,
  `password` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `user`
--

INSERT INTO `user` (`ID`, `username`, `password`) VALUES
(1, 'Min', '789456');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `member`
--
ALTER TABLE `member`
  ADD PRIMARY KEY (`Mid`);

--
-- Indexes for table `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `member`
--
ALTER TABLE `member`
  MODIFY `Mid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
