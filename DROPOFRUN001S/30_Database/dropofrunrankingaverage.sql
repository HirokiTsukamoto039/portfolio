-- phpMyAdmin SQL Dump
-- version 4.8.5
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: 
-- サーバのバージョン： 10.1.38-MariaDB
-- PHP Version: 7.2.16

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `techtest`
--

-- --------------------------------------------------------

--
-- テーブルの構造 `dropofrunrankingaverage`
--

CREATE TABLE `dropofrunrankingaverage` (
  `Id` int(11) NOT NULL,
  `Name` varchar(30) NOT NULL DEFAULT 'NoName',
  `Floor` int(11) DEFAULT NULL,
  `Time` int(11) DEFAULT NULL,
  `AverageTime` float DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- テーブルのデータのダンプ `dropofrunrankingaverage`
--

INSERT INTO `dropofrunrankingaverage` (`Id`, `Name`, `Floor`, `Time`, `AverageTime`) VALUES
(1, 'test01', 2, 30, 15),
(2, 'test02', 2, 40, 20),
(3, 'Test03', 3, 45, 15),
(4, 'test04', 2, 50, 25),
(5, '１２３４５６７', 4, 160, 40),
(6, '１２３４５６７８', 4, 124, 31),
(7, '１~９', 4, 100, 25),
(8, 'ああああああああ', 4, 80, 20),
(9, '太郎', 4, 40, 10),
(10, 'NoName', 2, 33, 16.5),
(11, 'NoName', 3, 15, 5),
(12, 'NoName', 4, 50, 12.5),
(13, 'WWWWWWWW', 4, 400, 100),
(14, '田田田田田田田田', 4, 240, 60),
(15, 'set', 1, 4, 4),
(16, 'aaa', 1, 49, 49),
(17, 'tes', 5, 106, 21),
(18, 'test60', 3, 52, 17),
(19, 'tesst', 5, 0, 0),
(20, 'tes', 2, 68, 34),
(21, 'etes', 2, 36, 18),
(22, 'testq', 2, 28, 14),
(23, 'testa', 2, 8, 4),
(24, 'asdhaii', 3, 28, 9),
(25, 'TestEXE1', 4, 63, 15);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `dropofrunrankingaverage`
--
ALTER TABLE `dropofrunrankingaverage`
  ADD PRIMARY KEY (`Id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `dropofrunrankingaverage`
--
ALTER TABLE `dropofrunrankingaverage`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=26;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
