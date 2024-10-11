-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Oct 11, 2024 at 03:16 AM
-- Server version: 10.4.28-MariaDB
-- PHP Version: 8.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `voting_system`
--

DELIMITER $$
--
-- Procedures
--
CREATE DEFINER=`root`@`localhost` PROCEDURE `procLogin` (IN `p_username` VARCHAR(50), IN `p_password` VARCHAR(50))   SELECT `id`
FROM `tblusers`
WHERE `username` = `p_username`
AND `password` = `p_password`
LIMIT 1$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `procRegister` (IN `p_firstname` VARCHAR(50), IN `p_lastname` VARCHAR(50), IN `p_username` VARCHAR(50), IN `p_password` VARCHAR(50), IN `p_email` VARCHAR(50), IN `p_phone` VARCHAR(50))   INSERT INTO `tblusers`(`firstname`, `lastname`, `username`, `password`, `email`, `phone`)
VALUES(`p_firstname`, `p_lastname`, `p_username`, `p_password`, `p_email`, `p_phone`)$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `procSelectUserById` (IN `p_user_id` INT)   SELECT *
FROM `tblusers`
WHERE `id` = `p_user_id`
LIMIT 1$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `procUpdateUserById` (IN `p_user_id` INT, IN `p_firstname` VARCHAR(50), IN `p_lastname` VARCHAR(50), IN `p_username` VARCHAR(50), IN `p_email` VARCHAR(50), IN `p_phone` VARCHAR(50))   UPDATE `tblusers`
SET `firstname` = `p_firstname`,
`lastname` = `p_lastname`,
`username` = `p_username`,
`email` = `p_email`,
`phone` = `p_phone`
WHERE `id` = `p_user_id`$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `procUpdateUserPasswordById` (IN `p_user_id` INT, IN `p_username` VARCHAR(50))   UPDATE `tblusers`
SET `password` = `p_password`
WHERE `id` = `p_user_id`$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `tblcandidates`
--

CREATE TABLE `tblcandidates` (
  `id` int(11) NOT NULL,
  `user_id` int(11) NOT NULL,
  `room_id` int(11) NOT NULL,
  `role_id` int(11) NOT NULL,
  `partylist_id` int(11) NOT NULL,
  `date` timestamp NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `tbljoined_rooms`
--

CREATE TABLE `tbljoined_rooms` (
  `id` int(11) NOT NULL,
  `user_id` int(11) NOT NULL,
  `room_id` int(11) NOT NULL,
  `date` timestamp NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `tblmoderators`
--

CREATE TABLE `tblmoderators` (
  `id` int(11) NOT NULL,
  `user_id` int(11) NOT NULL,
  `room_id` int(11) NOT NULL,
  `date` timestamp NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `tblpartylists`
--

CREATE TABLE `tblpartylists` (
  `id` int(11) NOT NULL,
  `name` varchar(50) NOT NULL,
  `room_id` int(11) NOT NULL,
  `date` timestamp NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `tblroles`
--

CREATE TABLE `tblroles` (
  `id` int(11) NOT NULL,
  `title` varchar(50) NOT NULL,
  `room_id` int(11) NOT NULL,
  `date` timestamp NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `tblrooms`
--

CREATE TABLE `tblrooms` (
  `id` int(11) NOT NULL,
  `name` varchar(50) NOT NULL,
  `author` int(11) NOT NULL,
  `code` varchar(50) NOT NULL,
  `date` timestamp NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `tblusers`
--

CREATE TABLE `tblusers` (
  `id` int(11) NOT NULL,
  `firstname` varchar(50) NOT NULL,
  `lastname` varchar(50) NOT NULL,
  `username` varchar(50) NOT NULL,
  `password` varchar(50) NOT NULL,
  `email` varchar(50) NOT NULL,
  `phone` varchar(50) NOT NULL,
  `voters_id` varchar(50) DEFAULT NULL,
  `is_verified` tinyint(1) NOT NULL,
  `date` timestamp NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tblusers`
--

INSERT INTO `tblusers` (`id`, `firstname`, `lastname`, `username`, `password`, `email`, `phone`, `voters_id`, `is_verified`, `date`) VALUES
(1, 'Ionvop', 'Omadle', 'ionvop', '177013', 'ionvop@gmail.com', '09123456789', NULL, 0, '2024-10-10 15:32:51'),
(2, 'Chiyu', 'Tamade', 'chu2', '177013', 'chu2@gmail.com', '09123456789', NULL, 0, '2024-10-10 17:06:32');

-- --------------------------------------------------------

--
-- Table structure for table `tblvotes`
--

CREATE TABLE `tblvotes` (
  `id` int(11) NOT NULL,
  `user_id` int(11) NOT NULL,
  `candidate_id` int(11) NOT NULL,
  `date` timestamp NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tblcandidates`
--
ALTER TABLE `tblcandidates`
  ADD PRIMARY KEY (`id`),
  ADD KEY `partylist_id` (`partylist_id`),
  ADD KEY `role_id` (`role_id`),
  ADD KEY `room_id` (`room_id`),
  ADD KEY `user_id` (`user_id`);

--
-- Indexes for table `tbljoined_rooms`
--
ALTER TABLE `tbljoined_rooms`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `tblmoderators`
--
ALTER TABLE `tblmoderators`
  ADD PRIMARY KEY (`id`),
  ADD KEY `room_id` (`room_id`),
  ADD KEY `user_id` (`user_id`);

--
-- Indexes for table `tblpartylists`
--
ALTER TABLE `tblpartylists`
  ADD PRIMARY KEY (`id`),
  ADD KEY `partylists_ibfk_1` (`room_id`);

--
-- Indexes for table `tblroles`
--
ALTER TABLE `tblroles`
  ADD PRIMARY KEY (`id`),
  ADD KEY `room_id` (`room_id`);

--
-- Indexes for table `tblrooms`
--
ALTER TABLE `tblrooms`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `code` (`code`),
  ADD KEY `rooms_ibfk_1` (`author`);

--
-- Indexes for table `tblusers`
--
ALTER TABLE `tblusers`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `username` (`username`);

--
-- Indexes for table `tblvotes`
--
ALTER TABLE `tblvotes`
  ADD PRIMARY KEY (`id`),
  ADD KEY `candidate_id` (`candidate_id`),
  ADD KEY `user_id` (`user_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tblcandidates`
--
ALTER TABLE `tblcandidates`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `tbljoined_rooms`
--
ALTER TABLE `tbljoined_rooms`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `tblmoderators`
--
ALTER TABLE `tblmoderators`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `tblpartylists`
--
ALTER TABLE `tblpartylists`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `tblroles`
--
ALTER TABLE `tblroles`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `tblrooms`
--
ALTER TABLE `tblrooms`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `tblusers`
--
ALTER TABLE `tblusers`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `tblvotes`
--
ALTER TABLE `tblvotes`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `tblcandidates`
--
ALTER TABLE `tblcandidates`
  ADD CONSTRAINT `tblcandidates_ibfk_1` FOREIGN KEY (`partylist_id`) REFERENCES `tblpartylists` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `tblcandidates_ibfk_2` FOREIGN KEY (`role_id`) REFERENCES `tblroles` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `tblcandidates_ibfk_3` FOREIGN KEY (`room_id`) REFERENCES `tblrooms` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `tblcandidates_ibfk_4` FOREIGN KEY (`user_id`) REFERENCES `tblusers` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `tblmoderators`
--
ALTER TABLE `tblmoderators`
  ADD CONSTRAINT `tblmoderators_ibfk_1` FOREIGN KEY (`room_id`) REFERENCES `tblrooms` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `tblmoderators_ibfk_2` FOREIGN KEY (`user_id`) REFERENCES `tblusers` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `tblpartylists`
--
ALTER TABLE `tblpartylists`
  ADD CONSTRAINT `tblpartylists_ibfk_1` FOREIGN KEY (`room_id`) REFERENCES `tblrooms` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `tblroles`
--
ALTER TABLE `tblroles`
  ADD CONSTRAINT `tblroles_ibfk_1` FOREIGN KEY (`room_id`) REFERENCES `tblrooms` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `tblrooms`
--
ALTER TABLE `tblrooms`
  ADD CONSTRAINT `tblrooms_ibfk_1` FOREIGN KEY (`author`) REFERENCES `tblusers` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `tblvotes`
--
ALTER TABLE `tblvotes`
  ADD CONSTRAINT `tblvotes_ibfk_1` FOREIGN KEY (`candidate_id`) REFERENCES `tblcandidates` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `tblvotes_ibfk_2` FOREIGN KEY (`user_id`) REFERENCES `tblusers` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
