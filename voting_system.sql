-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Oct 17, 2024 at 05:26 AM
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
CREATE DEFINER=`root`@`localhost` PROCEDURE `procClearVotes` (IN `p_user_id` INT, IN `p_room_id` INT)   DELETE `tblvotes`
FROM `tblvotes`
JOIN `tblcandidates` ON `tblvotes`.`candidate_id` = `tblcandidates`.`id`
JOIN `tblroles` ON `tblcandidates`.`role_id` = `tblroles`.`id`
WHERE `tblvotes`.`user_id` = `p_user_id`
AND `tblroles`.`room_id` = `p_room_id`$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `procCreateRoom` (IN `p_name` VARCHAR(50), IN `p_author` INT, IN `p_code` VARCHAR(50))   BEGIN
    DECLARE `v_room_id` INT;

    INSERT INTO `tblrooms`(`name`, `author`, `code`)
    VALUES(`p_name`, `p_author`, `p_code`);

    SELECT LAST_INSERT_ID() INTO `v_room_id`;

	INSERT INTO `tblroles`(`title`, `room_id`)
    VALUES('President', `v_room_id`);
    
    INSERT INTO `tblpartylists`(`name`, `room_id`)
    VALUES('Independent', `v_room_id`);
    
    SELECT `v_room_id`;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `procDeleteCandidateById` (IN `p_candidate_id` INT)   DELETE FROM `tblcandidates`
WHERE `id` = `p_candidate_id`$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `procDeletePartylistById` (IN `p_partylist_id` INT)   DELETE FROM `tblpartylists`
WHERE `id` = `p_partylist_id`$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `procDeleteRoleById` (IN `p_role_id` INT)   DELETE FROM `tblroles`
WHERE `id` = `p_role_id`$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `procDeleteRoomById` (IN `p_room_id` INT)   DELETE FROM `tblrooms`
WHERE `id` = `p_room_id`$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `procFinalizeVote` (IN `p_user_id` INT, IN `p_room_id` INT)   UPDATE `tbljoined_rooms`
SET `is_done` = 1
WHERE `user_id` = `p_user_id`
AND `room_id` = `p_room_id`$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `procInsertCandidate` (IN `p_user_id` INT, IN `p_room_id` INT, IN `p_role_id` INT, IN `p_partylist_id` INT)   INSERT INTO `tblcandidates`(`user_id`, `room_id`, `role_id`, `partylist_id`)
VALUES(`p_user_id`, `p_room_id`, `p_role_id`, `p_partylist_id`)$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `procInsertPartylist` (IN `p_name` VARCHAR(50), IN `p_room_id` INT)   INSERT INTO `tblpartylists`(`name`, `room_id`)
VALUES(`p_name`, `p_room_id`)$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `procInsertRole` (IN `p_title` VARCHAR(50), IN `p_room_id` INT)   INSERT INTO `tblroles`(`title`, `room_id`)
VALUES(`p_title`, `p_room_id`)$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `procJoinRoomByCode` (IN `p_user_id` INT, IN `p_code` INT)   BEGIN
    DECLARE `v_room_id` INT;

    SELECT `id` INTO `v_room_id`
    FROM `tblrooms`
    WHERE `code` = `p_code`;

    IF `v_room_id` IS NOT NULL THEN
        INSERT INTO `tbljoined_rooms`(`user_id`, `room_id`)
        VALUES(`p_user_id`, `v_room_id`);
    END IF;
    
    SELECT `v_room_id`;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `procLeaveRoom` (IN `p_user_id` INT, IN `p_room_id` INT)   DELETE FROM `tbljoined_rooms`
WHERE `user_id` = `p_user_id`
AND `room_id` = `p_room_id`$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `procLogin` (IN `p_username` VARCHAR(50), IN `p_password` VARCHAR(50))   SELECT `id`
FROM `tblusers`
WHERE `username` = `p_username`
AND `password` = `p_password`
LIMIT 1$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `procPrintResults` (IN `p_room_id` INT)   SELECT `tblroles`.`title`
AS `role_title`,
CONCAT(`tblusers`.`firstname`, ' ', `tblusers`.`lastname`, ' (', `tblusers`.`username`, ')')
AS `candidate_user_id`,
SUM(IFNULL(`tbljoined_rooms`.`is_done`, 0))
AS `total_votes`
FROM `tblroles`
JOIN `tblcandidates`
ON `tblroles`.`id` = `tblcandidates`.`role_id`
LEFT JOIN `tblvotes`
ON `tblcandidates`.`id` = `tblvotes`.`candidate_id`
LEFT JOIN `tblusers`
ON `tblcandidates`.`user_id` = `tblusers`.`id`
LEFT JOIN `tbljoined_rooms`
ON `tbljoined_rooms`.`user_id` = `tblvotes`.`user_id`
AND `tbljoined_rooms`.`room_id` = `tblroles`.`room_id`
WHERE `tblroles`.`room_id` = `p_room_id`
GROUP BY `tblroles`.`id`, `tblroles`.`title`, `tblcandidates`.`user_id`
ORDER BY `tblroles`.`id`, `total_votes`
DESC$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `procRegister` (IN `p_firstname` VARCHAR(50), IN `p_lastname` VARCHAR(50), IN `p_username` VARCHAR(50), IN `p_password` VARCHAR(50), IN `p_email` VARCHAR(50), IN `p_phone` VARCHAR(50))   BEGIN
INSERT INTO `tblusers`(`firstname`, `lastname`, `username`, `password`, `email`, `phone`)
VALUES(`p_firstname`, `p_lastname`, `p_username`, `p_password`, `p_email`, `p_phone`);
SELECT LAST_INSERT_ID();
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `procSelectCandidateById` (IN `p_candidate_id` INT)   SELECT *
FROM `tblcandidates`
WHERE `id` = `p_candidate_id`$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `procSelectCandidatesByRoomIdRoleIdAndPartylistId` (IN `p_room_id` INT, IN `p_role_id` INT, IN `p_partylist_id` INT)   SELECT `tblcandidates`.*, `tblusers`.`firstname`, `tblusers`.`lastname`, `tblusers`.`username`
FROM `tblcandidates`
LEFT JOIN `tblusers` ON `tblcandidates`.`user_id` = `tblusers`.`id`
WHERE `room_id` = `p_room_id`
AND `role_id` = `p_role_id`
AND `partylist_id` = `p_partylist_id`$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `procSelectModeratorsByRoomId` (IN `p_room_id` INT)   SELECT `tblusers`.*
FROM `tblusers`
LEFT JOIN `tbljoined_rooms` ON `tbljoined_rooms`.`user_id` = `tblusers`.`id`
WHERE `tbljoined_rooms`.`room_id` = `p_room_id`
AND `tbljoined_rooms`.`is_moderator` = 1$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `procSelectPartylistsByRoomId` (IN `p_room_id` INT)   SELECT *
FROM `tblpartylists`
WHERE `room_id` = `p_room_id`$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `procSelectRolesByRoomId` (IN `p_room_id` INT)   SELECT *
FROM `tblroles`
WHERE `room_id` = `p_room_id`$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `procSelectRoomById` (IN `p_room_id` INT)   SELECT *
FROM `tblrooms`
WHERE `id` = `p_room_id`$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `procSelectRoomsByAuthor` (IN `p_user_id` INT)   SELECT *
FROM `tblrooms`
WHERE `author` = `p_user_id`$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `procSelectRoomsByUserId` (IN `p_user_id` INT)   BEGIN
    SELECT `tblrooms`.*
    FROM `tblrooms`
    LEFT JOIN `tbljoined_rooms` ON `tblrooms`.`id` = `tbljoined_rooms`.`room_id`
    WHERE `tbljoined_rooms`.`user_id` = `p_user_id`;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `procSelectUserById` (IN `p_user_id` INT)   SELECT *
FROM `tblusers`
WHERE `id` = `p_user_id`$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `procSelectUserCandidatesByRoomId` (IN `p_room_id` INT)   SELECT `tblcandidates`.*, `tblusers`.`firstname`, `tblusers`.`lastname`, `tblusers`.`username`
FROM `tblcandidates`
LEFT JOIN `tblusers` ON `tblcandidates`.`user_id` = `tblusers`.`id`
WHERE `tblcandidates`.`room_id` = `p_room_id`$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `procSelectUsersByRoomId` (IN `p_room_id` INT)   BEGIN
	SELECT `tblusers`.*, `tbljoined_rooms`.`is_done`
    FROM `tblusers`
    JOIN `tbljoined_rooms` ON `tblusers`.`id` = `tbljoined_rooms`.`user_id`
    WHERE `tbljoined_rooms`.`room_id` = `p_room_id`;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `procSelectUserVotes` (IN `p_user_id` INT, IN `p_room_id` INT)   SELECT 
`tblroles`.`id`,
`tblcandidates`.`user_id`
FROM `tblvotes`
JOIN `tblcandidates` ON `tblvotes`.`candidate_id` = `tblcandidates`.`id`
JOIN `tblroles` ON `tblcandidates`.`role_id` = `tblroles`.`id`
WHERE `tblvotes`.`user_id` = `p_user_id`
AND `tblroles`.`room_id` = `p_room_id`$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `procSetModerator` (IN `p_user_id` INT, IN `p_room_id` INT, IN `p_is_moderator` INT)   BEGIN

DELETE FROM `tbljoined_rooms`
WHERE `user_id` = `p_user_id`
AND `room_id` = `p_room_id`;

INSERT INTO `tbljoined_rooms`(`user_id`, `room_id`, `is_moderator`)
VALUES(`p_user_id`, `p_room_id`, `p_is_moderator`);

END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `procUpdateCandidateById` (IN `p_candidate_id` INT, IN `p_role_id` INT, IN `p_partylist_id` INT)   UPDATE `tblcandidates`
SET `role_id` = `p_role_id`,
`partylist_id` = `p_partylist_id`
WHERE `id` = `p_candidate_id`$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `procUpdateRoomById` (IN `p_room_id` INT, IN `p_name` VARCHAR(50), IN `p_code` VARCHAR(50))   UPDATE `tblrooms`
SET `name` = `p_name`,
`code` = `p_code`
WHERE `id` = `p_room_id`$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `procUpdateUserById` (IN `p_user_id` INT, IN `p_firstname` VARCHAR(50), IN `p_lastname` VARCHAR(50), IN `p_username` VARCHAR(50), IN `p_email` VARCHAR(50), IN `p_phone` VARCHAR(50), IN `p_voters_id` VARCHAR(50))   UPDATE `tblusers`
SET `firstname` = `p_firstname`,
`lastname` = `p_lastname`,
`username` = `p_username`,
`email` = `p_email`,
`phone` = `p_phone`,
`voters_id` = `p_voters_id`
WHERE `id` = `p_user_id`$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `procUpdateUserPasswordById` (IN `p_user_id` INT, IN `p_username` VARCHAR(50))   UPDATE `tblusers`
SET `password` = `p_password`
WHERE `id` = `p_user_id`$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `procVote` (IN `p_user_id` INT, IN `p_candidate_id` INT)   BEGIN
DECLARE `v_role_id` INT;
DECLARE `v_room_id` INT;

SELECT `role_id`, `room_id`
INTO `v_role_id`, `v_room_id`
FROM `tblcandidates`
WHERE `id` = `p_candidate_id`;

DELETE `tblvotes`
FROM `tblvotes`
JOIN `tblcandidates` ON `tblvotes`.`candidate_id` = `tblcandidates`.`id`
JOIN `tblroles` ON `tblcandidates`.role_id = `tblroles`.id
WHERE `tblvotes`.`user_id` = `p_user_id`
AND `tblroles`.`room_id` = `v_room_id`
AND `tblroles`.`id` = `v_role_id`;

INSERT INTO `tblvotes`(`user_id`, `candidate_id`)
VALUES(`p_user_id`, `p_candidate_id`);

END$$

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

--
-- Dumping data for table `tblcandidates`
--

INSERT INTO `tblcandidates` (`id`, `user_id`, `room_id`, `role_id`, `partylist_id`, `date`) VALUES
(5, 1, 16, 19, 17, '2024-10-16 14:43:57'),
(6, 2, 16, 19, 17, '2024-10-17 03:18:25');

-- --------------------------------------------------------

--
-- Table structure for table `tbljoined_rooms`
--

CREATE TABLE `tbljoined_rooms` (
  `id` int(11) NOT NULL,
  `user_id` int(11) NOT NULL,
  `room_id` int(11) NOT NULL,
  `is_moderator` tinyint(1) NOT NULL,
  `is_done` tinyint(1) NOT NULL,
  `date` timestamp NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbljoined_rooms`
--

INSERT INTO `tbljoined_rooms` (`id`, `user_id`, `room_id`, `is_moderator`, `is_done`, `date`) VALUES
(12, 1, 16, 0, 0, '2024-10-17 03:01:44'),
(13, 2, 16, 0, 1, '2024-10-17 03:18:08');

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

--
-- Dumping data for table `tblpartylists`
--

INSERT INTO `tblpartylists` (`id`, `name`, `room_id`, `date`) VALUES
(17, 'Independent', 16, '2024-10-16 14:43:20');

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

--
-- Dumping data for table `tblroles`
--

INSERT INTO `tblroles` (`id`, `title`, `room_id`, `date`) VALUES
(19, 'President', 16, '2024-10-16 14:43:20');

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

--
-- Dumping data for table `tblrooms`
--

INSERT INTO `tblrooms` (`id`, `name`, `author`, `code`, `date`) VALUES
(16, 'New Room', 1, '37154', '2024-10-16 14:43:20');

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
  `voters_id` varchar(50) NOT NULL,
  `is_verified` tinyint(1) NOT NULL,
  `date` timestamp NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tblusers`
--

INSERT INTO `tblusers` (`id`, `firstname`, `lastname`, `username`, `password`, `email`, `phone`, `voters_id`, `is_verified`, `date`) VALUES
(1, 'Ionvop', 'Omadle', 'ionvop', '177013', 'ionvop@gmail.com', '09123456789', '', 0, '2024-10-10 15:32:51'),
(2, 'Chiyu', 'Tamade', 'chu2', '177013', 'chu2@gmail.com', '09123456789', '', 0, '2024-10-10 17:06:32'),
(4, 'qwe', 'qwe', 'qwe', 'qwer', 'qwe', 'qwe', '', 0, '2024-10-15 07:35:01');

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
-- Dumping data for table `tblvotes`
--

INSERT INTO `tblvotes` (`id`, `user_id`, `candidate_id`, `date`) VALUES
(9, 2, 5, '2024-10-17 03:24:19'),
(10, 1, 5, '2024-10-17 03:24:54');

-- --------------------------------------------------------

--
-- Stand-in structure for view `v_all_results`
-- (See below for the actual view)
--
CREATE TABLE `v_all_results` (
`room_id` int(11)
,`role_title` varchar(50)
,`candidate_name` varchar(154)
,`total_votes` bigint(21)
);

-- --------------------------------------------------------

--
-- Structure for view `v_all_results`
--
DROP TABLE IF EXISTS `v_all_results`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `v_all_results`  AS SELECT `tblroles`.`room_id` AS `room_id`, `tblroles`.`title` AS `role_title`, concat(`tblusers`.`firstname`,' ',`tblusers`.`lastname`,' (',`tblusers`.`username`,')') AS `candidate_name`, count(`tblvotes`.`id`) AS `total_votes` FROM (((`tblroles` join `tblcandidates` on(`tblroles`.`id` = `tblcandidates`.`role_id`)) left join `tblvotes` on(`tblcandidates`.`id` = `tblvotes`.`candidate_id`)) left join `tblusers` on(`tblcandidates`.`user_id` = `tblusers`.`id`)) GROUP BY `tblroles`.`room_id`, `tblroles`.`id`, `tblroles`.`title`, `tblcandidates`.`user_id` ORDER BY `tblroles`.`room_id` ASC, `tblroles`.`id` ASC, count(`tblvotes`.`id`) DESC ;

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
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `tbljoined_rooms`
--
ALTER TABLE `tbljoined_rooms`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;

--
-- AUTO_INCREMENT for table `tblpartylists`
--
ALTER TABLE `tblpartylists`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=18;

--
-- AUTO_INCREMENT for table `tblroles`
--
ALTER TABLE `tblroles`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=20;

--
-- AUTO_INCREMENT for table `tblrooms`
--
ALTER TABLE `tblrooms`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=17;

--
-- AUTO_INCREMENT for table `tblusers`
--
ALTER TABLE `tblusers`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `tblvotes`
--
ALTER TABLE `tblvotes`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

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
-- Constraints for table `tbljoined_rooms`
--
ALTER TABLE `tbljoined_rooms`
  ADD CONSTRAINT `tbljoined_rooms_ibfk_1` FOREIGN KEY (`room_id`) REFERENCES `tblrooms` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `tbljoined_rooms_ibfk_2` FOREIGN KEY (`user_id`) REFERENCES `tblusers` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

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
