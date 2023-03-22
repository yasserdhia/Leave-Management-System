-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Mar 12, 2021 at 08:45 AM
-- Server version: 10.1.19-MariaDB
-- PHP Version: 5.6.28

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_leave`
--

-- --------------------------------------------------------

--
-- Table structure for table `employee`
--

CREATE TABLE `employee` (
  `EMPID` varchar(60) NOT NULL,
  `emp_fname` varchar(60) DEFAULT NULL,
  `emp_lname` varchar(60) DEFAULT NULL,
  `emp_mname` varchar(60) DEFAULT NULL,
  `address` varchar(100) DEFAULT NULL,
  `contact` varchar(20) DEFAULT NULL,
  `status` varchar(30) DEFAULT NULL,
  `birth_date` date DEFAULT NULL,
  `birth_place` varchar(100) DEFAULT NULL,
  `emp_sex` varchar(10) DEFAULT NULL,
  `emp_age` int(10) DEFAULT NULL,
  `emerg_contct` varchar(25) DEFAULT NULL,
  `REMAININGLEAVE` double NOT NULL,
  `DEFAULTLEAVE` double NOT NULL,
  `ONLEAVE` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `employee`
--

INSERT INTO `employee` (`EMPID`, `emp_fname`, `emp_lname`, `emp_mname`, `address`, `contact`, `status`, `birth_date`, `birth_place`, `emp_sex`, `emp_age`, `emerg_contct`, `REMAININGLEAVE`, `DEFAULTLEAVE`, `ONLEAVE`) VALUES
('000010', 'Jude', 'Suarez', 'R', 'Bacolod City', '09090990909', 'Single', '1997-03-12', 'Bacolod', 'MALE', NULL, '09090909009', 30, 30, 0),
('000011', 'Adones', 'Evangilista', 'B', 'Kabankalan City', '09099090909', 'Married', '1994-03-12', 'Kabankalan', 'MALE', NULL, '09090909090', 30, 30, 0),
('000012', 'Mark', 'Jason', 'S', 'Bacolod City', '09989898087', 'Single', '1997-10-31', 'Bacolod', 'MALE', NULL, '09878786787', 30, 30, 0);

-- --------------------------------------------------------

--
-- Table structure for table `employee_workinfo`
--

CREATE TABLE `employee_workinfo` (
  `id` int(10) NOT NULL,
  `EMPID` int(30) NOT NULL,
  `d_rate` double DEFAULT NULL,
  `p_method` varchar(60) DEFAULT NULL,
  `position` varchar(60) DEFAULT NULL,
  `w_status` varchar(60) DEFAULT NULL,
  `d_hired` date DEFAULT NULL,
  `DEPARTMENT` varchar(50) NOT NULL,
  `w_type` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `employee_workinfo`
--

INSERT INTO `employee_workinfo` (`id`, `EMPID`, `d_rate`, `p_method`, `position`, `w_status`, `d_hired`, `DEPARTMENT`, `w_type`) VALUES
(56, 10, 500, 'Monthly', 'Staff', NULL, '2021-03-12', 'Human Resource Dept.', 'Regular'),
(57, 11, 500, 'Monthly', 'Election Committee', NULL, '2021-03-12', 'Finance Dept.', 'Regular'),
(58, 12, 500, 'Monthly', 'Clerk', NULL, '2021-03-12', 'Engineering Service Dept.', 'Regular');

-- --------------------------------------------------------

--
-- Table structure for table `leave`
--

CREATE TABLE `leave` (
  `LEAVEID` int(11) NOT NULL,
  `EMPID` int(11) NOT NULL,
  `LEAVECODE` int(11) NOT NULL,
  `LEAVEFORMAT` varchar(30) NOT NULL,
  `LEAVEAPPLIED` varchar(50) NOT NULL,
  `DATEFROM` datetime NOT NULL,
  `DATETO` datetime NOT NULL,
  `LEAVEDATE` datetime NOT NULL,
  `LEAVEENDDATE` datetime NOT NULL,
  `NODAYS` double NOT NULL,
  `REASON` text NOT NULL,
  `DAYOFFSCHEDULE` datetime NOT NULL,
  `REMARKS` varchar(30) NOT NULL,
  `APPLIED` tinyint(1) NOT NULL,
  `STATUS` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `leave`
--

INSERT INTO `leave` (`LEAVEID`, `EMPID`, `LEAVECODE`, `LEAVEFORMAT`, `LEAVEAPPLIED`, `DATEFROM`, `DATETO`, `LEAVEDATE`, `LEAVEENDDATE`, `NODAYS`, `REASON`, `DAYOFFSCHEDULE`, `REMARKS`, `APPLIED`, `STATUS`) VALUES
(33, 10, 0, 'With Pay', 'Sick', '2021-03-12 01:44:09', '2021-03-12 01:44:09', '2021-03-12 01:44:09', '2021-03-20 01:44:09', -8, 'Lupot', '2021-03-12 01:44:09', 'Approved', 1, 'Approved'),
(34, 11, 0, 'With Pay', 'Sick', '2021-03-12 08:35:19', '2021-03-12 08:35:19', '2021-03-13 02:35:19', '2021-03-19 02:35:19', -6, 'Im sick', '2021-03-12 02:35:19', 'Approved', 1, 'Approved'),
(35, 12, 0, 'With Pay', 'Sick', '2021-03-12 02:41:22', '2021-03-12 02:41:22', '2021-03-13 02:41:22', '2021-03-19 02:41:22', -6, 'Sick', '2021-03-12 02:41:22', 'Approved', 1, 'Approved');

-- --------------------------------------------------------

--
-- Table structure for table `tblapproveleave`
--

CREATE TABLE `tblapproveleave` (
  `APPROVEDID` int(11) NOT NULL,
  `LEAVEID` int(11) NOT NULL,
  `LEAVECODE` varchar(30) NOT NULL,
  `EMPID` varchar(30) NOT NULL,
  `NODAYSAPPROVE` int(30) NOT NULL,
  `user_id` varchar(30) NOT NULL,
  `STATUS` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tblautonumber`
--

CREATE TABLE `tblautonumber` (
  `id` int(11) NOT NULL,
  `STRT` varchar(30) NOT NULL,
  `END` int(11) NOT NULL,
  `INCREMENT` int(11) NOT NULL,
  `DESCRIPTION` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblautonumber`
--

INSERT INTO `tblautonumber` (`id`, `STRT`, `END`, `INCREMENT`, `DESCRIPTION`) VALUES
(1, '00001', 3, 1, 'employee'),
(2, '1032', 10, 1, 'user');

-- --------------------------------------------------------

--
-- Table structure for table `tbldepartment`
--

CREATE TABLE `tbldepartment` (
  `ID` int(11) NOT NULL,
  `DEPARTMENT` varchar(90) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbldepartment`
--

INSERT INTO `tbldepartment` (`ID`, `DEPARTMENT`) VALUES
(2, 'Corporal Communication Dept.'),
(4, 'Corporate Planning Dept.'),
(5, 'Finance Dept.'),
(6, 'Engineering Service Dept.'),
(7, 'Transmission & Distribution Dept.'),
(8, 'Human Resource Depts.');

-- --------------------------------------------------------

--
-- Table structure for table `tblleaveinfo`
--

CREATE TABLE `tblleaveinfo` (
  `LEAVEID` int(11) NOT NULL,
  `EMPID` varchar(11) NOT NULL,
  `REASONS` varchar(30) NOT NULL,
  `LEAVEDAYS` int(11) NOT NULL,
  `DEFAULT` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblleaveinfo`
--

INSERT INTO `tblleaveinfo` (`LEAVEID`, `EMPID`, `REASONS`, `LEAVEDAYS`, `DEFAULT`) VALUES
(127, '000010', 'SICK', 15, 0),
(128, '000010', 'Vacation', 15, 0),
(129, '000011', 'SICK', 15, 0),
(130, '000011', 'Vacation', 15, 0),
(131, '000012', 'SICK', 15, 0),
(132, '000012', 'Vacation', 15, 0);

-- --------------------------------------------------------

--
-- Table structure for table `tblsettings`
--

CREATE TABLE `tblsettings` (
  `ID` int(11) NOT NULL,
  `DESCRIPTION` text NOT NULL,
  `FORTHE` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblsettings`
--

INSERT INTO `tblsettings` (`ID`, `DESCRIPTION`, `FORTHE`) VALUES
(2, 'Clerk', 'Position'),
(3, 'Election Committee', 'Position'),
(4, 'Audit Committee', 'Position'),
(5, 'Corporate Secretary', 'Position'),
(6, 'Medication Committee', 'Position'),
(7, 'Treasurer', 'Position'),
(8, 'Ethics Committee', 'Position'),
(9, 'Lineman', 'Position'),
(10, 'Teller', 'Position'),
(12, 'Staff', 'Position');

-- --------------------------------------------------------

--
-- Table structure for table `tbluser`
--

CREATE TABLE `tbluser` (
  `user_id` int(30) NOT NULL,
  `name` text,
  `username` varchar(60) DEFAULT NULL,
  `pass` varchar(90) DEFAULT NULL,
  `type` varchar(60) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbluser`
--

INSERT INTO `tbluser` (`user_id`, `name`, `username`, `pass`, `type`) VALUES
(12, 'Nikko Curaza', 'admin', 'd033e22ae348aeb5660fc2140aec35850c4da997', 'Administrator'),
(10328, 'Grace', 'HR', 'd033e22ae348aeb5660fc2140aec35850c4da997', 'HR Personnel'),
(10329, 'May', 'HR', 'd033e22ae348aeb5660fc2140aec35850c4da997', 'HR Personnel');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `employee`
--
ALTER TABLE `employee`
  ADD PRIMARY KEY (`EMPID`);

--
-- Indexes for table `employee_workinfo`
--
ALTER TABLE `employee_workinfo`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `leave`
--
ALTER TABLE `leave`
  ADD PRIMARY KEY (`LEAVEID`);

--
-- Indexes for table `tblapproveleave`
--
ALTER TABLE `tblapproveleave`
  ADD PRIMARY KEY (`APPROVEDID`);

--
-- Indexes for table `tblautonumber`
--
ALTER TABLE `tblautonumber`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `tbldepartment`
--
ALTER TABLE `tbldepartment`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `tblleaveinfo`
--
ALTER TABLE `tblleaveinfo`
  ADD PRIMARY KEY (`LEAVEID`);

--
-- Indexes for table `tblsettings`
--
ALTER TABLE `tblsettings`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `tbluser`
--
ALTER TABLE `tbluser`
  ADD PRIMARY KEY (`user_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `employee_workinfo`
--
ALTER TABLE `employee_workinfo`
  MODIFY `id` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=59;
--
-- AUTO_INCREMENT for table `leave`
--
ALTER TABLE `leave`
  MODIFY `LEAVEID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=36;
--
-- AUTO_INCREMENT for table `tblapproveleave`
--
ALTER TABLE `tblapproveleave`
  MODIFY `APPROVEDID` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `tblautonumber`
--
ALTER TABLE `tblautonumber`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT for table `tbldepartment`
--
ALTER TABLE `tbldepartment`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;
--
-- AUTO_INCREMENT for table `tblleaveinfo`
--
ALTER TABLE `tblleaveinfo`
  MODIFY `LEAVEID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=133;
--
-- AUTO_INCREMENT for table `tblsettings`
--
ALTER TABLE `tblsettings`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;
--
-- AUTO_INCREMENT for table `tbluser`
--
ALTER TABLE `tbluser`
  MODIFY `user_id` int(30) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10330;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
