-- phpMyAdmin SQL Dump
-- version 2.10.3
-- http://www.phpmyadmin.net
-- 
-- Host: localhost
-- Generation Time: Mar 26, 2022 at 05:26 PM
-- Server version: 5.0.51
-- PHP Version: 5.2.6

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";

-- 
-- Database: `thansuda`
-- 
CREATE DATABASE `thansuda` DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci;
USE `thansuda`;

-- --------------------------------------------------------

-- 
-- Table structure for table `customer`
-- 

CREATE TABLE `customer` (
  `id` int(11) NOT NULL auto_increment,
  `firstname` varchar(255) NOT NULL,
  `lastname` varchar(255) NOT NULL,
  `email` varchar(255) NOT NULL,
  `phonenumber` varchar(255) NOT NULL,
  `status` varchar(255) NOT NULL,
  `address` varchar(255) NOT NULL,
  `zipcode` varchar(255) NOT NULL,
  PRIMARY KEY  (`id`)
) ENGINE=MyISAM  DEFAULT CHARSET=utf8 AUTO_INCREMENT=12 ;

-- 
-- Dumping data for table `customer`
-- 

INSERT INTO `customer` VALUES (1, 'Iris', 'Watson', 'watson_ir99@gmail.com', '(372) 587-2335', 'membership', ' 8562 Fusce Rd. Frederick Nebraska ', '20620');
INSERT INTO `customer` VALUES (2, 'Hiroko', 'Potter', 'hiro_p55@gmail.com', '(314) 244-6306', 'membership', '2508 Dolor. Av. Muskegon KY ', '12482');
INSERT INTO `customer` VALUES (3, 'Melvin', 'Porter', 'melvin_p@gmail.com', '(959) 119-8364', 'non-membership', '1599 Curabitur Rd. Bandera South Dakota ', '45149');
INSERT INTO `customer` VALUES (4, 'Colby', 'Bernard', 'bernard_c123@gmail.com', '(302) 259-2375', 'Membership', '7193 Ullamcorper Avenue Amesbury HI ', '93373');
INSERT INTO `customer` VALUES (5, 'Noelle', 'Adams', 'noellea.5578@gmail.com', '(559) 104-5475', 'non-membership', '6351 Fringilla Avenue Gardena Colorado', ' 37547');
INSERT INTO `customer` VALUES (6, 'Rebecca', 'Chambers', 'rebeccham04@gmail.com', '(455) 430-0989', 'membership', '5982 Sit Ave Liberal Vermont ', '51324');
INSERT INTO `customer` VALUES (7, 'Castor', 'Richardson', 'richard_c@gmail.com', '(268) 442-2428', 'non-membership', '3472 Ullamcorper Street Lynchburg DC ', '29738');
INSERT INTO `customer` VALUES (8, 'Raymond', 'Levy', 'levi_nraymond@gmail.com', '(715) 912-6931', 'membership', '7006 Risus St. Beaumont New Mexico  ', '73585');
INSERT INTO `customer` VALUES (9, 'Judith', 'Floyd', 'floyd-floyd@gmail.com', '(774) 914-2510', 'non-membership', '7936 Feugiat St. Williston Nevada  ', '58521');
INSERT INTO `customer` VALUES (10, 'Zephania', 'Sanders', 'zepp_san@gmail.com', '(539) 567-3573', 'non-membership', '3714 Nascetur St. Hawthorne Louisiana ', '10626 ');

-- --------------------------------------------------------

-- 
-- Table structure for table `discount`
-- 

CREATE TABLE `discount` (
  `dcode` varchar(255) NOT NULL,
  `percentAmount` double NOT NULL,
  PRIMARY KEY  (`dcode`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- 
-- Dumping data for table `discount`
-- 

INSERT INTO `discount` VALUES ('FOM-999', 0.15);
INSERT INTO `discount` VALUES ('Hot-Item', 0.25);
INSERT INTO `discount` VALUES ('FreeShipping', 120);

-- --------------------------------------------------------

-- 
-- Table structure for table `member`
-- 

CREATE TABLE `member` (
  `number` int(11) NOT NULL auto_increment,
  `username` varchar(255) NOT NULL,
  `password` varchar(255) NOT NULL,
  `firstname` varchar(255) NOT NULL,
  `lastname` varchar(255) NOT NULL,
  `role` varchar(255) NOT NULL,
  PRIMARY KEY  (`number`)
) ENGINE=MyISAM  DEFAULT CHARSET=utf8 AUTO_INCREMENT=9 ;

-- 
-- Dumping data for table `member`
-- 

INSERT INTO `member` VALUES (1, 'jamesmith', '1234', 'James', 'Smith', 'manager');
INSERT INTO `member` VALUES (2, 'lawrence_m', '9999', 'Lawrence', 'Moreno', 'manager');
INSERT INTO `member` VALUES (3, 'harry-potter', 'thunderspear', 'Forrest', 'Ray', 'staff');
INSERT INTO `member` VALUES (4, 'pillowcas_e', 'sleepatnight', 'Emma', 'Greene', 'staff');
INSERT INTO `member` VALUES (5, 'aot_ss4', 'erenjeager', 'Patrick', 'Holmes', 'staff');
INSERT INTO `member` VALUES (6, 'iris', 'iris', 'Iris', 'Watson', 'customer');
INSERT INTO `member` VALUES (7, 'rbc_chb', 'rbcc', 'Rebecca', 'Chambers', 'customer');
INSERT INTO `member` VALUES (8, 'noelle_a', 'n1234', 'Noelle', 'Adams', 'customer');

-- --------------------------------------------------------

-- 
-- Table structure for table `orderdetail`
-- 

CREATE TABLE `orderdetail` (
  `number` int(11) NOT NULL auto_increment,
  `billNo` int(11) NOT NULL,
  `date` date NOT NULL,
  `productCode` int(11) NOT NULL,
  `productName` varchar(255) NOT NULL,
  `category` varchar(255) NOT NULL,
  `price` int(11) NOT NULL,
  `qty` int(11) NOT NULL,
  `discountCode` varchar(255) NOT NULL,
  `percentAmount` double NOT NULL,
  `shippingFee` int(11) NOT NULL,
  PRIMARY KEY  (`number`)
) ENGINE=MyISAM  DEFAULT CHARSET=utf8 AUTO_INCREMENT=446 ;

-- 
-- Dumping data for table `orderdetail`
-- 

INSERT INTO `orderdetail` VALUES (221, 1, '2022-01-03', 1, 'Tengen Uzui - Demon Slayer', 'Noru', 500, 1, '0', 0, 120);
INSERT INTO `orderdetail` VALUES (222, 2, '2022-01-03', 1, 'Tengen Uzui - Demon Slayer', 'Noru', 500, 5, 'FreeShipping', 120, 120);
INSERT INTO `orderdetail` VALUES (223, 3, '2022-01-03', 11, 'Kyojuto rengoju - Demon Slayer', 'Noru', 500, 1, '0', 0, 120);
INSERT INTO `orderdetail` VALUES (224, 4, '2022-01-03', 2, 'Hinata Shoyo - Haikyuu', 'Noru', 500, 3, '0', 0, 120);
INSERT INTO `orderdetail` VALUES (225, 5, '2022-01-03', 2, 'Hinata Shoyo - Haikyuu', 'Noru', 500, 1, '0', 0, 120);
INSERT INTO `orderdetail` VALUES (226, 6, '2022-01-03', 10, 'Toru Oikawa-Haikyuu', 'Noru', 500, 3, 'FreeShipping', 120, 120);
INSERT INTO `orderdetail` VALUES (227, 7, '2022-01-04', 21, 'Ryunosuke Tanake - Haikyuu', 'Noru', 500, 1, '0', 0, 120);
INSERT INTO `orderdetail` VALUES (228, 8, '2022-01-04', 10, 'Toru Oikawa-Haikyuu', 'Noru', 500, 1, '0', 0, 120);
INSERT INTO `orderdetail` VALUES (229, 9, '2022-01-04', 2, 'Hinata Shoyo - Haikyuu', 'Noru', 500, 1, '0', 0, 120);
INSERT INTO `orderdetail` VALUES (230, 10, '2022-01-04', 1, 'Tengen Uzui - Demon Slayer', 'Noru', 500, 1, '0', 0, 120);
INSERT INTO `orderdetail` VALUES (231, 11, '2022-01-04', 2, 'Hinata Shoyo - Haikyuu', 'Noru', 500, 1, '0', 0, 120);
INSERT INTO `orderdetail` VALUES (232, 12, '2022-01-04', 21, 'Ryunosuke Tanake - Haikyuu', 'Noru', 500, 1, '0', 0, 120);
INSERT INTO `orderdetail` VALUES (233, 13, '2022-01-04', 2, 'Hinata Shoyo - Haikyuu', 'Noru', 500, 1, '0', 0, 120);
INSERT INTO `orderdetail` VALUES (234, 14, '2022-01-04', 11, 'Kyojuto rengoju - Demon Slayer', 'Noru', 500, 2, '0', 0, 120);
INSERT INTO `orderdetail` VALUES (235, 15, '2022-01-04', 2, 'Hinata Shoyo - Haikyuu', 'Noru', 500, 2, '0', 0, 120);
INSERT INTO `orderdetail` VALUES (236, 16, '2022-01-07', 1, 'Tengen Uzui - Demon Slayer', 'Noru', 500, 1, '0', 0, 120);
INSERT INTO `orderdetail` VALUES (237, 17, '2022-01-07', 10, 'Toru Oikawa-Haikyuu', 'Noru', 500, 1, '0', 0, 120);
INSERT INTO `orderdetail` VALUES (238, 18, '2022-01-07', 10, 'Toru Oikawa-Haikyuu', 'Noru', 500, 1, '0', 0, 120);
INSERT INTO `orderdetail` VALUES (239, 19, '2022-01-09', 10, 'Toru Oikawa-Haikyuu', 'Noru', 500, 1, '0', 0, 120);
INSERT INTO `orderdetail` VALUES (240, 20, '2022-01-09', 11, 'Kyojuto rengoju - Demon Slayer', 'Noru', 500, 1, '0', 0, 120);
INSERT INTO `orderdetail` VALUES (241, 21, '2022-01-09', 1, 'Tengen Uzui - Demon Slayer', 'Noru', 500, 1, '0', 0, 120);
INSERT INTO `orderdetail` VALUES (242, 22, '2022-01-09', 21, 'Ryunosuke Tanake - Haikyuu', 'Noru', 500, 2, '0', 0, 120);
INSERT INTO `orderdetail` VALUES (243, 23, '2022-01-10', 10, 'Toru Oikawa-Haikyuu', 'Noru', 500, 4, 'FreeShipping', 120, 120);
INSERT INTO `orderdetail` VALUES (244, 24, '2022-01-10', 11, 'Kyojuto rengoju - Demon Slayer', 'Noru', 500, 2, '0', 0, 120);
INSERT INTO `orderdetail` VALUES (245, 25, '2022-01-10', 1, 'Tengen Uzui - Demon Slayer', 'Noru', 500, 1, '0', 0, 120);
INSERT INTO `orderdetail` VALUES (246, 26, '2022-01-10', 22, 'Daiji Sawamura - Haikyuu', 'Noru', 500, 1, '0', 0, 120);
INSERT INTO `orderdetail` VALUES (247, 27, '2022-01-10', 10, 'Toru Oikawa-Haikyuu', 'Noru', 500, 2, 'FreeShipping', 120, 120);
INSERT INTO `orderdetail` VALUES (248, 28, '2022-01-01', 3, 'Nanami Kento - Jujustu Kaisen', 'Nendoroid', 1800, 1, '0', 0, 120);
INSERT INTO `orderdetail` VALUES (249, 29, '2022-01-01', 3, 'Nanami Kento - Jujustu Kaisen', 'Nendoroid', 1800, 1, '0', 0, 120);
INSERT INTO `orderdetail` VALUES (250, 30, '2022-01-01', 12, 'Levi Ackerman - Attack on Titan', 'Nendoroid', 2400, 1, '0', 0, 120);
INSERT INTO `orderdetail` VALUES (251, 31, '2022-01-01', 24, 'Zenitsu Agatsuma - Demon Slayer', 'Nendoroid', 2300, 1, '0', 0, 120);
INSERT INTO `orderdetail` VALUES (252, 32, '2022-01-01', 3, 'Nanami Kento - Jujustu Kaisen', 'Nendoroid', 1800, 1, '0', 0, 120);
INSERT INTO `orderdetail` VALUES (253, 33, '2022-01-01', 24, 'Zenitsu Agatsuma - Demon Slayer', 'Nendoroid', 2300, 1, '0', 0, 120);
INSERT INTO `orderdetail` VALUES (254, 34, '2022-01-04', 12, 'Levi Ackerman - Attack on Titan', 'Nendoroid', 2400, 2, '0', 0, 120);
INSERT INTO `orderdetail` VALUES (255, 35, '2022-01-05', 6, 'Yoichi Isagi - Blue Lock', 'Standy', 550, 1, '0', 0, 120);
INSERT INTO `orderdetail` VALUES (256, 36, '2022-01-05', 12, 'Levi Ackerman - Attack on Titan', 'Nendoroid', 2400, 1, '0', 0, 120);
INSERT INTO `orderdetail` VALUES (257, 37, '2022-01-05', 17, 'Toge Inumaki - Jujutsu Kaizen', 'Nendoroid', 2350, 2, '0', 0, 120);
INSERT INTO `orderdetail` VALUES (258, 38, '2022-01-06', 38, 'Ichigo Kurosaki - Bleach', 'Standy', 2000, 2, '0', 0, 120);
INSERT INTO `orderdetail` VALUES (259, 39, '2022-01-06', 6, 'Yoichi Isagi - Blue Lock', 'Standy', 550, 6, 'FreeShipping', 120, 120);
INSERT INTO `orderdetail` VALUES (260, 40, '2022-01-06', 12, 'Levi Ackerman - Attack on Titan', 'Nendoroid', 2400, 1, '0', 0, 120);
INSERT INTO `orderdetail` VALUES (261, 41, '2022-01-01', 3, 'Nanami Kento - Jujustu Kaisen', 'Nendoroid', 1800, 1, '0', 0, 120);
INSERT INTO `orderdetail` VALUES (262, 42, '2022-01-10', 24, 'Zenitsu Agatsuma - Demon Slayer', 'Nendoroid', 2300, 2, '0', 0, 120);
INSERT INTO `orderdetail` VALUES (263, 43, '2022-01-10', 4, 'Katsuki Bakugo - My Hero Academia', 'Figure', 3500, 1, 'Hot-Item', 0.25, 120);
INSERT INTO `orderdetail` VALUES (264, 44, '2022-01-10', 35, 'Edogawa Conan - Detective Conan', 'Standy', 1340, 3, 'FreeShipping', 120, 120);
INSERT INTO `orderdetail` VALUES (265, 45, '2022-01-10', 29, 'Hatake Kakashi - Naruto', 'Nendoroid', 3300, 1, '0', 0, 120);
INSERT INTO `orderdetail` VALUES (266, 46, '2022-01-12', 3, 'Nanami Kento - Jujustu Kaisen', 'Nendoroid', 1800, 3, '0', 0, 120);
INSERT INTO `orderdetail` VALUES (267, 47, '2022-01-14', 28, 'Ujiha Itaji - Naruto', 'Figure', 9800, 1, 'Hot-Item', 0.25, 120);
INSERT INTO `orderdetail` VALUES (268, 48, '2022-01-14', 4, 'Katsuki Bakugo - My Hero Academia', 'Figure', 3500, 1, '0', 0, 120);
INSERT INTO `orderdetail` VALUES (269, 49, '2022-01-14', 29, 'Hatake Kakashi - Naruto', 'Nendoroid', 3300, 1, '0', 0, 120);
INSERT INTO `orderdetail` VALUES (270, 50, '2022-01-15', 3, 'Nanami Kento - Jujustu Kaisen', 'Nendoroid', 1800, 1, '0', 0, 120);
INSERT INTO `orderdetail` VALUES (271, 51, '2022-01-15', 27, 'Sukuna - Jujutsu Kaien', 'Figure', 2500, 1, '0', 0, 120);
INSERT INTO `orderdetail` VALUES (272, 52, '2022-01-15', 35, 'Edogawa Conan - Detective Conan', 'Standy', 1340, 1, '0', 0, 120);
INSERT INTO `orderdetail` VALUES (273, 53, '2022-01-15', 28, 'Ujiha Itaji - Naruto', 'Figure', 9800, 1, '0', 0, 120);
INSERT INTO `orderdetail` VALUES (274, 54, '2022-01-15', 3, 'Nanami Kento - Jujustu Kaisen', 'Nendoroid', 1800, 1, '0', 0, 120);
INSERT INTO `orderdetail` VALUES (275, 55, '2022-01-15', 24, 'Zenitsu Agatsuma - Demon Slayer', 'Nendoroid', 2300, 2, '0', 0, 120);
INSERT INTO `orderdetail` VALUES (276, 56, '2022-01-15', 24, 'Zenitsu Agatsuma - Demon Slayer', 'Nendoroid', 2300, 1, '0', 0, 120);
INSERT INTO `orderdetail` VALUES (277, 57, '2022-01-15', 3, 'Nanami Kento - Jujustu Kaisen', 'Nendoroid', 1800, 1, '0', 0, 120);
INSERT INTO `orderdetail` VALUES (278, 58, '2022-01-15', 35, 'Edogawa Conan - Detective Conan', 'Standy', 1340, 1, '0', 0, 120);
INSERT INTO `orderdetail` VALUES (279, 59, '2022-01-16', 27, 'Sukuna - Jujutsu Kaien', 'Figure', 2500, 1, '0', 0, 120);
INSERT INTO `orderdetail` VALUES (280, 60, '2022-01-16', 3, 'Nanami Kento - Jujustu Kaisen', 'Nendoroid', 1800, 1, '0', 0, 120);
INSERT INTO `orderdetail` VALUES (281, 61, '2022-01-16', 24, 'Zenitsu Agatsuma - Demon Slayer', 'Nendoroid', 2300, 1, '0', 0, 120);
INSERT INTO `orderdetail` VALUES (282, 62, '2022-01-18', 38, 'Ichigo Kurosaki - Bleach', 'Standy', 2000, 1, '0', 0, 120);
INSERT INTO `orderdetail` VALUES (283, 63, '2022-01-18', 3, 'Nanami Kento - Jujustu Kaisen', 'Nendoroid', 1800, 3, '0', 0, 120);
INSERT INTO `orderdetail` VALUES (284, 64, '2022-01-20', 28, 'Ujiha Itaji - Naruto', 'Figure', 9800, 1, '0', 0, 120);
INSERT INTO `orderdetail` VALUES (285, 65, '2022-01-20', 29, 'Hatake Kakashi - Naruto', 'Nendoroid', 3300, 1, '0', 0, 120);
INSERT INTO `orderdetail` VALUES (286, 66, '2022-01-20', 23, 'Minato Namikaze -Naruto', 'Figure', 7500, 1, 'FreeShipping', 120, 120);
INSERT INTO `orderdetail` VALUES (287, 67, '2022-01-22', 27, 'Sukuna - Jujutsu Kaien', 'Figure', 2500, 1, '0', 0, 120);
INSERT INTO `orderdetail` VALUES (288, 68, '2022-01-23', 28, 'Ujiha Itaji - Naruto', 'Figure', 9800, 1, 'Hot-Item', 0.25, 120);
INSERT INTO `orderdetail` VALUES (289, 69, '2022-01-23', 29, 'Hatake Kakashi - Naruto', 'Nendoroid', 3300, 1, '0', 0, 120);
INSERT INTO `orderdetail` VALUES (290, 70, '2022-01-23', 3, 'Nanami Kento - Jujustu Kaisen', 'Nendoroid', 1800, 1, '0', 0, 120);
INSERT INTO `orderdetail` VALUES (291, 71, '2022-01-23', 3, 'Nanami Kento - Jujustu Kaisen', 'Nendoroid', 1800, 1, '0', 0, 120);
INSERT INTO `orderdetail` VALUES (292, 72, '2022-01-27', 29, 'Hatake Kakashi - Naruto', 'Nendoroid', 3300, 1, '0', 0, 120);
INSERT INTO `orderdetail` VALUES (293, 73, '2022-01-27', 3, 'Nanami Kento - Jujustu Kaisen', 'Nendoroid', 1800, 1, '0', 0, 120);
INSERT INTO `orderdetail` VALUES (294, 74, '2022-01-24', 27, 'Sukuna - Jujutsu Kaien', 'Figure', 2500, 1, '0', 0, 120);
INSERT INTO `orderdetail` VALUES (295, 75, '2022-01-24', 25, 'Suguru Geto - Jujutsu Kaizen', 'Figure', 3900, 2, '0', 0, 120);
INSERT INTO `orderdetail` VALUES (296, 76, '2022-01-25', 4, 'Katsuki Bakugo - My Hero Academia', 'Figure', 3500, 1, '0', 0, 120);
INSERT INTO `orderdetail` VALUES (297, 77, '2022-01-26', 32, 'Yuta Okkotsu - Jujutsu Kaizen', 'Nendoroid', 3500, 1, '0', 0, 120);
INSERT INTO `orderdetail` VALUES (298, 78, '2022-01-26', 30, 'Armin - attrack on Titan', 'Nendoroid', 3500, 1, '0', 0, 120);
INSERT INTO `orderdetail` VALUES (299, 79, '2022-01-26', 3, 'Nanami Kento - Jujustu Kaisen', 'Nendoroid', 1800, 1, '0', 0, 120);
INSERT INTO `orderdetail` VALUES (300, 80, '2022-01-29', 25, 'Suguru Geto - Jujutsu Kaizen', 'Figure', 3900, 1, '0', 0, 120);
INSERT INTO `orderdetail` VALUES (301, 81, '2022-01-29', 4, 'Katsuki Bakugo - My Hero Academia', 'Figure', 3500, 1, '0', 0, 120);
INSERT INTO `orderdetail` VALUES (302, 82, '2022-01-29', 3, 'Nanami Kento - Jujustu Kaisen', 'Nendoroid', 1800, 1, '0', 0, 120);
INSERT INTO `orderdetail` VALUES (303, 83, '2022-01-29', 30, 'Armin - attrack on Titan', 'Nendoroid', 3500, 1, '0', 0, 120);
INSERT INTO `orderdetail` VALUES (304, 84, '2022-01-29', 24, 'Zenitsu Agatsuma - Demon Slayer', 'Nendoroid', 2300, 1, '0', 0, 120);
INSERT INTO `orderdetail` VALUES (305, 85, '2022-01-20', 35, 'Edogawa Conan - Detective Conan', 'Standy', 1340, 3, '0', 0, 120);
INSERT INTO `orderdetail` VALUES (306, 86, '2022-01-30', 3, 'Nanami Kento - Jujustu Kaisen', 'Nendoroid', 1800, 1, '0', 0, 120);
INSERT INTO `orderdetail` VALUES (307, 87, '2022-01-30', 30, 'Armin - attrack on Titan', 'Nendoroid', 3500, 1, '0', 0, 120);
INSERT INTO `orderdetail` VALUES (308, 88, '2022-01-30', 38, 'Ichigo Kurosaki - Bleach', 'Standy', 2000, 2, '0', 0, 120);
INSERT INTO `orderdetail` VALUES (309, 89, '2022-01-30', 24, 'Zenitsu Agatsuma - Demon Slayer', 'Nendoroid', 2300, 1, '0', 0, 120);
INSERT INTO `orderdetail` VALUES (310, 90, '2022-01-31', 32, 'Yuta Okkotsu - Jujutsu Kaizen', 'Nendoroid', 3500, 1, '0', 0, 120);
INSERT INTO `orderdetail` VALUES (311, 91, '2022-01-31', 32, 'Yuta Okkotsu - Jujutsu Kaizen', 'Nendoroid', 3500, 1, '0', 0, 120);
INSERT INTO `orderdetail` VALUES (312, 92, '2022-01-31', 3, 'Nanami Kento - Jujustu Kaisen', 'Nendoroid', 1800, 1, '0', 0, 120);
INSERT INTO `orderdetail` VALUES (313, 93, '2022-01-31', 6, 'Yoichi Isagi - Blue Lock', 'Standy', 550, 1, '0', 0, 120);
INSERT INTO `orderdetail` VALUES (314, 94, '2022-01-31', 25, 'Suguru Geto - Jujutsu Kaizen', 'Figure', 1800, 1, '0', 0, 120);
INSERT INTO `orderdetail` VALUES (315, 95, '2022-01-31', 3, 'Nanami Kento - Jujustu Kaisen', 'Nendoroid', 1800, 1, '0', 0, 120);
INSERT INTO `orderdetail` VALUES (316, 96, '2022-01-31', 28, 'Ujiha Itaji - Naruto', 'Figure', 9800, 1, 'Hot-Item', 0.25, 120);
INSERT INTO `orderdetail` VALUES (317, 97, '2022-01-31', 35, 'Edogawa Conan - Detective Conan', 'Standy', 1340, 3, 'FOM-999', 0.15, 120);
INSERT INTO `orderdetail` VALUES (318, 98, '2022-01-31', 6, 'Yoichi Isagi - Blue Lock', 'Standy', 990, 1, '0', 0, 120);
INSERT INTO `orderdetail` VALUES (319, 99, '2022-01-31', 25, 'Suguru Geto - Jujutsu Kaizen', 'Figure', 3900, 1, 'Hot-Item', 0.25, 120);
INSERT INTO `orderdetail` VALUES (320, 100, '2022-01-31', 31, 'Maruko - Maruko chan', 'Nendoroid', 2250, 1, '0', 0, 120);
INSERT INTO `orderdetail` VALUES (321, 101, '2022-01-31', 31, 'Maruko - Maruko chan', 'Nendoroid', 2250, 1, '0', 0, 120);
INSERT INTO `orderdetail` VALUES (322, 102, '2022-01-31', 3, 'Nanami Kento - Jujustu Kaisen', 'Nendoroid', 1800, 1, '0', 0, 120);
INSERT INTO `orderdetail` VALUES (323, 103, '2022-01-31', 35, 'Edogawa Conan - Detective Conan', 'Standy', 1340, 1, '0', 0, 120);
INSERT INTO `orderdetail` VALUES (324, 104, '2022-01-31', 28, 'Ujiha Itaji - Naruto', 'Figure', 9800, 1, 'FOM-999', 0.15, 120);
INSERT INTO `orderdetail` VALUES (325, 105, '2022-01-31', 35, 'Edogawa Conan - Detective Conan', 'Standy', 1340, 1, 'FreeShipping', 120, 120);
INSERT INTO `orderdetail` VALUES (326, 106, '2022-01-31', 25, 'Suguru Geto - Jujutsu Kaizen', 'Figure', 3900, 2, 'FOM-999', 0.15, 120);
INSERT INTO `orderdetail` VALUES (327, 107, '2022-01-31', 18, 'Inosuke Hashibira - Demon Slayer', 'Figure', 4090, 1, 'Hot-Item', 0.25, 120);
INSERT INTO `orderdetail` VALUES (328, 108, '2022-01-31', 3, 'Nanami Kento - Jujustu Kaisen', 'Nendoroid', 1800, 1, '0', 0, 120);
INSERT INTO `orderdetail` VALUES (329, 109, '2022-01-31', 17, 'Toge Inumaki - Jujutsu Kaizen', 'Nendoroid', 2350, 1, '0', 0, 120);
INSERT INTO `orderdetail` VALUES (330, 110, '2022-01-31', 23, 'Minato Namikaze -Naruto', 'Figure', 7500, 1, 'FOM-999', 0.15, 120);
INSERT INTO `orderdetail` VALUES (331, 111, '2022-01-31', 17, 'Toge Inumaki - Jujutsu Kaizen', 'Nendoroid', 2350, 1, 'Hot-Item', 0.25, 120);
INSERT INTO `orderdetail` VALUES (332, 112, '2022-01-31', 3, 'Nanami Kento - Jujustu Kaisen', 'Nendoroid', 1800, 1, '0', 0, 120);
INSERT INTO `orderdetail` VALUES (333, 113, '2022-01-31', 25, 'Suguru Geto - Jujutsu Kaizen', 'Figure', 3900, 1, '0', 0, 120);
INSERT INTO `orderdetail` VALUES (334, 114, '2022-02-01', 6, 'Yoichi Isagi - Blue Lock', 'Figure', 990, 3, '0', 0, 120);
INSERT INTO `orderdetail` VALUES (335, 115, '2022-02-01', 23, 'Minato Namikaze -Naruto', 'Figure', 7500, 1, 'Hot-Item', 0.25, 120);
INSERT INTO `orderdetail` VALUES (336, 116, '2022-02-01', 29, 'Hatake Kakashi - Naruto', 'Nendoroid', 3300, 2, 'FOM-999', 0.15, 120);
INSERT INTO `orderdetail` VALUES (337, 117, '2022-02-01', 29, 'Hatake Kakashi - Naruto', 'Nendoroid', 3300, 1, 'FreeShipping', 120, 120);
INSERT INTO `orderdetail` VALUES (338, 118, '2022-02-01', 25, 'Suguru Geto - Jujutsu Kaizen', 'Figure', 3900, 1, 'FreeShipping', 120, 120);
INSERT INTO `orderdetail` VALUES (339, 119, '2022-02-01', 3, 'Nanami Kento - Jujustu Kaisen', 'Nendoroid', 1800, 1, '0', 0, 120);
INSERT INTO `orderdetail` VALUES (340, 120, '2022-02-02', 29, 'Hatake Kakashi - Naruto', 'Nendoroid', 3300, 1, '0', 0, 120);
INSERT INTO `orderdetail` VALUES (341, 121, '2022-02-02', 27, 'Sukuna - Jujutsu Kaien', 'Figure', 2500, 1, '0', 0, 120);
INSERT INTO `orderdetail` VALUES (342, 122, '2022-02-02', 3, 'Nanami Kento - Jujustu Kaisen', 'Nendoroid', 1800, 1, '0', 0, 120);
INSERT INTO `orderdetail` VALUES (343, 123, '2022-02-02', 24, 'Zenitsu Agatsuma - Demon Slayer', 'Nendoroid', 2300, 1, 'Hot-Item', 0.25, 120);
INSERT INTO `orderdetail` VALUES (344, 124, '2022-02-01', 6, 'Yoichi Isagi - Blue Lock', 'Standy', 990, 1, '0', 0, 120);
INSERT INTO `orderdetail` VALUES (345, 125, '2022-02-05', 36, 'Shiki Ichinose - Tougen Anki', 'Standy', 990, 3, 'FreeShipping', 120, 120);
INSERT INTO `orderdetail` VALUES (346, 126, '2022-02-05', 28, 'Ujiha Itaji - Naruto', 'Figure', 9800, 3, '0', 0, 120);
INSERT INTO `orderdetail` VALUES (347, 127, '2022-02-06', 12, 'Levi Ackerman - Attack on Titan', 'Nendoroid', 2400, 1, '0', 0, 120);
INSERT INTO `orderdetail` VALUES (348, 128, '2022-02-07', 38, 'Ichigo Kurosaki - Bleach', 'Standy', 2000, 1, '0', 0, 120);
INSERT INTO `orderdetail` VALUES (349, 129, '2022-02-03', 27, 'Sukuna - Jujutsu Kaien', 'Figure', 2500, 2, '0', 0, 120);
INSERT INTO `orderdetail` VALUES (350, 130, '2022-02-03', 36, 'Shiki Ichinose - Tougen Anki', 'Standy', 990, 1, '0', 0, 120);
INSERT INTO `orderdetail` VALUES (351, 131, '2022-02-08', 6, 'Yoichi Isagi - Blue Lock', 'Standy', 550, 1, '0', 0, 120);
INSERT INTO `orderdetail` VALUES (352, 132, '2022-02-08', 6, 'Yoichi Isagi - Blue Lock', 'Standy', 550, 1, '0', 0, 120);
INSERT INTO `orderdetail` VALUES (353, 133, '2022-02-08', 32, 'Yuta Okkotsu - Jujutsu Kaizen', 'Nendoroid', 3500, 1, '0', 0, 120);
INSERT INTO `orderdetail` VALUES (354, 134, '2022-02-10', 3, 'Nanami Kento - Jujustu Kaisen', 'Nendoroid', 1800, 4, 'Hot-Item', 0.25, 120);
INSERT INTO `orderdetail` VALUES (355, 135, '2022-02-10', 38, 'Ichigo Kurosaki - Bleach', 'Standy', 2000, 3, '0', 0, 120);
INSERT INTO `orderdetail` VALUES (356, 136, '2022-02-11', 38, 'Ichigo Kurosaki - Bleach', 'Standy', 2000, 1, '0', 0, 120);
INSERT INTO `orderdetail` VALUES (357, 137, '2022-02-11', 6, 'Yoichi Isagi - Blue Lock', 'Standy', 990, 1, '0', 0, 120);
INSERT INTO `orderdetail` VALUES (358, 138, '2022-02-14', 32, 'Yuta Okkotsu - Jujutsu Kaizen', 'Nendoroid', 3500, 1, '0', 0, 120);
INSERT INTO `orderdetail` VALUES (359, 139, '2022-02-14', 32, 'Yuta Okkotsu - Jujutsu Kaizen', 'Nendoroid', 3500, 2, '0', 0, 120);
INSERT INTO `orderdetail` VALUES (360, 140, '2022-02-16', 32, 'Yuta Okkotsu - Jujutsu Kaizen', 'Nendoroid', 3500, 1, '0', 0, 120);
INSERT INTO `orderdetail` VALUES (361, 141, '2022-02-13', 34, 'Meguru Bachira - Blue Lock', 'Standy', 1220, 1, '0', 0, 120);
INSERT INTO `orderdetail` VALUES (362, 142, '2022-02-13', 3, 'Nanami Kento - Jujustu Kaisen', 'Nendoroid', 1800, 1, '0', 0, 120);
INSERT INTO `orderdetail` VALUES (363, 143, '2022-02-16', 32, 'Yuta Okkotsu - Jujutsu Kaizen', 'Nendoroid', 3500, 1, '0', 0, 120);
INSERT INTO `orderdetail` VALUES (364, 144, '2022-02-17', 4, 'Katsuki Bakugo - My Hero Academia', 'Figure', 3500, 1, '0', 0, 120);
INSERT INTO `orderdetail` VALUES (365, 145, '2022-02-17', 28, 'Ujiha Itaji - Naruto', 'Figure', 9800, 1, '0', 0, 120);
INSERT INTO `orderdetail` VALUES (366, 146, '2022-02-17', 18, 'Inosuke Hashibira - Demon Slayer', 'Figure', 4090, 3, '0', 0, 120);
INSERT INTO `orderdetail` VALUES (367, 147, '2022-02-17', 31, 'Maruko - Maruko chan', 'Nendoroid', 2250, 1, '0', 0, 120);
INSERT INTO `orderdetail` VALUES (368, 148, '2022-02-20', 6, 'Yoichi Isagi - Blue Lock', 'Standy', 990, 1, '0', 0, 120);
INSERT INTO `orderdetail` VALUES (369, 149, '2022-02-20', 17, 'Toge Inumaki - Jujutsu Kaizen', 'Nendoroid', 2350, 1, '0', 0, 120);
INSERT INTO `orderdetail` VALUES (370, 150, '2022-02-20', 23, 'Minato Namikaze -Naruto', 'Figure', 7500, 2, '0', 0, 120);
INSERT INTO `orderdetail` VALUES (371, 151, '2022-02-22', 32, 'Yuta Okkotsu - Jujutsu Kaizen', 'Nendoroid', 3500, 1, '0', 0, 120);
INSERT INTO `orderdetail` VALUES (372, 152, '2022-02-22', 3, 'Nanami Kento - Jujustu Kaisen', 'Nendoroid', 1800, 1, '0', 0, 120);
INSERT INTO `orderdetail` VALUES (373, 153, '2022-02-21', 34, 'Meguru Bachira - Blue Lock', 'Standy', 1220, 2, '0', 0, 120);
INSERT INTO `orderdetail` VALUES (374, 154, '2022-02-21', 18, 'Inosuke Hashibira - Demon Slayer', 'Figure', 4090, 1, '0', 0, 120);
INSERT INTO `orderdetail` VALUES (375, 155, '2022-02-21', 34, 'Meguru Bachira - Blue Lock', 'Standy', 1220, 1, '0', 0, 120);
INSERT INTO `orderdetail` VALUES (376, 156, '2022-02-21', 23, 'Minato Namikaze -Naruto', 'Figure', 7500, 1, '0', 0, 120);
INSERT INTO `orderdetail` VALUES (377, 157, '2022-02-24', 12, 'Levi Ackerman - Attack on Titan', 'Nendoroid', 2400, 1, '0', 0, 120);
INSERT INTO `orderdetail` VALUES (378, 158, '2022-02-24', 3, 'Nanami Kento - Jujustu Kaisen', 'Nendoroid', 1800, 1, '0', 0, 120);
INSERT INTO `orderdetail` VALUES (379, 159, '2022-02-24', 36, 'Shiki Ichinose - Tougen Anki', 'Standy', 990, 1, '0', 0, 120);
INSERT INTO `orderdetail` VALUES (380, 160, '2022-02-12', 18, 'Inosuke Hashibira - Demon Slayer', 'Figure', 4090, 1, 'Hot-Item', 0.25, 120);
INSERT INTO `orderdetail` VALUES (381, 161, '2022-02-23', 12, 'Levi Ackerman - Attack on Titan', 'Nendoroid', 2400, 1, 'Hot-Item', 0.25, 120);
INSERT INTO `orderdetail` VALUES (382, 162, '2022-02-23', 32, 'Yuta Okkotsu - Jujutsu Kaizen', 'Nendoroid', 3300, 1, '0', 0, 120);
INSERT INTO `orderdetail` VALUES (383, 163, '2022-02-08', 17, 'Toge Inumaki - Jujutsu Kaizen', 'Nendoroid', 2350, 1, '0', 0, 120);
INSERT INTO `orderdetail` VALUES (384, 164, '2022-02-19', 36, 'Shiki Ichinose - Tougen Anki', 'Standy', 990, 1, '0', 0, 120);
INSERT INTO `orderdetail` VALUES (385, 165, '2022-02-19', 24, 'Zenitsu Agatsuma - Demon Slayer', 'Nendoroid', 2300, 2, '0', 0, 120);
INSERT INTO `orderdetail` VALUES (386, 166, '2022-02-25', 23, 'Minato Namikaze -Naruto', 'Figure', 7500, 1, '0', 0, 120);
INSERT INTO `orderdetail` VALUES (387, 167, '2022-02-25', 36, 'Shiki Ichinose - Tougen Anki', 'Nendoroid', 1800, 1, '0', 0, 120);
INSERT INTO `orderdetail` VALUES (388, 168, '2022-02-26', 32, 'Yuta Okkotsu - Jujutsu Kaizen', 'Nendoroid', 3500, 1, '0', 0, 120);
INSERT INTO `orderdetail` VALUES (389, 169, '2022-02-26', 29, 'Hatake Kakashi - Naruto', 'Nendoroid', 3300, 2, '0', 0, 120);
INSERT INTO `orderdetail` VALUES (390, 170, '2022-02-28', 24, 'Zenitsu Agatsuma - Demon Slayer', 'Nendoroid', 2300, 1, '0', 0, 120);
INSERT INTO `orderdetail` VALUES (391, 171, '2022-02-28', 4, 'Katsuki Bakugo - My Hero Academia', 'Figure', 3500, 1, 'FreeShipping', 120, 120);
INSERT INTO `orderdetail` VALUES (392, 172, '2022-02-28', 17, 'Toge Inumaki - Jujutsu Kaizen', 'Nendoroid', 2350, 2, '0', 0, 120);
INSERT INTO `orderdetail` VALUES (393, 173, '2022-02-28', 32, 'Yuta Okkotsu - Jujutsu Kaizen', 'Nendoroid', 3500, 1, '0', 0, 120);
INSERT INTO `orderdetail` VALUES (394, 174, '2022-02-18', 5, 'Izuku Midoriya - My Hero Academia', 'Figure', 3000, 2, 'Hot-Item', 0.25, 120);
INSERT INTO `orderdetail` VALUES (395, 175, '2022-02-24', 5, 'Izuku Midoriya - My Hero Academia', 'Figure', 3000, 1, '0', 0, 120);
INSERT INTO `orderdetail` VALUES (396, 176, '2022-03-23', 36, 'Shiki Ichinose - Tougen Anki', 'Standy', 1495, 1, 'Hot-Item', 0.25, 120);
INSERT INTO `orderdetail` VALUES (397, 177, '2022-03-02', 46, 'Law - One Piece', 'Lookup', 1450, 1, '', 0, 120);
INSERT INTO `orderdetail` VALUES (398, 178, '2022-03-02', 46, 'Law - One Piece', 'Lookup', 1450, 1, '', 0, 120);
INSERT INTO `orderdetail` VALUES (399, 179, '2022-03-02', 41, 'Itadori Yuji - Jujustu Kaizen', 'Lookup', 1450, 1, '', 0, 120);
INSERT INTO `orderdetail` VALUES (400, 180, '2022-03-03', 44, 'Hinata Hyuga - Naruto', 'Lookup', 1450, 1, '', 0, 120);
INSERT INTO `orderdetail` VALUES (401, 181, '2022-03-03', 40, 'Megumi Fushiguro - Jujustu Kaisen', 'Lookup', 1450, 1, '', 0, 120);
INSERT INTO `orderdetail` VALUES (402, 182, '2022-03-05', 46, 'Law - One Piece', 'Lookup', 1450, 1, '', 0, 120);
INSERT INTO `orderdetail` VALUES (403, 183, '2022-03-06', 47, 'Mitsuri Kanroji - Demon Salyer', 'Lookup', 1450, 1, '', 0, 120);
INSERT INTO `orderdetail` VALUES (404, 184, '2022-03-07', 40, 'Megumi Fushiguro - Jujustu Kaisen', 'Lookup', 1450, 1, '', 0, 120);
INSERT INTO `orderdetail` VALUES (405, 185, '2022-03-09', 46, 'Law - One Piece', 'Lookup', 1450, 1, '', 0, 120);
INSERT INTO `orderdetail` VALUES (406, 186, '2022-03-09', 44, 'Hinata Hyuga - Naruto', 'Lookup', 1450, 1, '', 0, 120);
INSERT INTO `orderdetail` VALUES (407, 187, '2022-03-09', 46, 'Law - One Piece', 'Lookup', 1450, 1, '', 0, 120);
INSERT INTO `orderdetail` VALUES (408, 188, '2022-03-12', 47, 'Mitsuri Kanroji - Demon Salyer', 'Lookup', 1450, 1, '', 0, 120);
INSERT INTO `orderdetail` VALUES (409, 189, '2022-03-12', 42, 'Uzumaki Naruto - Naruto', 'Lookup', 1450, 1, '', 0, 120);
INSERT INTO `orderdetail` VALUES (410, 190, '2022-03-14', 46, 'Law - One Piece', 'Lookup', 1450, 1, '', 0, 120);
INSERT INTO `orderdetail` VALUES (411, 191, '2022-03-14', 44, 'Hinata Hyuga - Naruto', 'Lookup', 1450, 1, '', 0, 120);
INSERT INTO `orderdetail` VALUES (412, 192, '2022-03-15', 44, 'Hinata Hyuga - Naruto', 'Lookup', 1450, 1, '', 0, 120);
INSERT INTO `orderdetail` VALUES (413, 193, '2022-03-16', 42, 'Uzumaki Naruto - Naruto', 'Lookup', 1450, 1, '', 0, 120);
INSERT INTO `orderdetail` VALUES (414, 194, '2022-03-17', 47, 'Mitsuri Kanroji - Demon Salyer', 'Lookup', 1450, 1, '', 0, 120);
INSERT INTO `orderdetail` VALUES (415, 195, '2022-03-18', 47, 'Mitsuri Kanroji - Demon Salyer', 'Lookup', 1450, 1, '', 0, 120);
INSERT INTO `orderdetail` VALUES (416, 196, '2022-03-19', 46, 'Law - One Piece', 'Lookup', 1450, 1, '', 0, 120);
INSERT INTO `orderdetail` VALUES (425, 223, '2022-03-26', 1, 'Tengen Uzui - Demon Slayer', 'Noru', 500, 1, '', 0, 120);
INSERT INTO `orderdetail` VALUES (426, 223, '2022-03-26', 2, 'Hinata Shoyo - Haikyuu', 'Noru', 500, 1, '', 0, 120);
INSERT INTO `orderdetail` VALUES (423, 222, '2022-03-26', 1, 'Tengen Uzui - Demon Slayer', 'Noru', 500, 1, '', 0, 120);
INSERT INTO `orderdetail` VALUES (424, 222, '2022-03-26', 2, 'Hinata Shoyo - Haikyuu', 'Noru', 500, 1, '', 0, 120);
INSERT INTO `orderdetail` VALUES (427, 224, '2022-03-26', 41, 'Itadori Yuji - Jujustu Kaizen', 'Lookup', 1450, 1, 'Hot-Item', 0.25, 120);
INSERT INTO `orderdetail` VALUES (428, 224, '2022-03-26', 40, 'Megumi Fushiguro - Jujustu Kaisen', 'Lookup', 1450, 1, 'Hot-Item', 0.25, 120);
INSERT INTO `orderdetail` VALUES (429, 225, '2022-03-26', 40, 'Megumi Fushiguro - Jujustu Kaisen', 'Lookup', 1450, 1, '', 0, 120);
INSERT INTO `orderdetail` VALUES (430, 225, '2022-03-26', 41, 'Itadori Yuji - Jujustu Kaizen', 'Lookup', 1450, 1, '', 0, 120);
INSERT INTO `orderdetail` VALUES (431, 226, '2022-03-26', 6, 'Yoichi Isagi - Blue Lock', 'Standy', 550, 1, '', 0, 120);
INSERT INTO `orderdetail` VALUES (432, 226, '2022-03-26', 33, 'Shouei Barou - Blue Lock', 'Standy', 1230, 1, '', 0, 120);
INSERT INTO `orderdetail` VALUES (433, 227, '2022-03-26', 2, 'Hinata Shoyo - Haikyuu', 'Noru', 500, 2, 'Hot-Item', 0.25, 120);
INSERT INTO `orderdetail` VALUES (434, 227, '2022-03-26', 1, 'Tengen Uzui - Demon Slayer', 'Noru', 500, 1, 'Hot-Item', 0.25, 120);
INSERT INTO `orderdetail` VALUES (435, 228, '2022-03-26', 1, 'Tengen Uzui - Demon Slayer', 'Noru', 500, 3, '', 0, 120);
INSERT INTO `orderdetail` VALUES (436, 228, '2022-03-26', 2, 'Hinata Shoyo - Haikyuu', 'Noru', 500, 1, '', 0, 120);
INSERT INTO `orderdetail` VALUES (437, 229, '2022-03-26', 2, 'Hinata Shoyo - Haikyuu', 'Noru', 500, 2, '', 0, 120);
INSERT INTO `orderdetail` VALUES (438, 229, '2022-03-26', 1, 'Tengen Uzui - Demon Slayer', 'Noru', 500, 1, '', 0, 120);
INSERT INTO `orderdetail` VALUES (439, 230, '2022-03-26', 29, 'Hatake Kakashi - Naruto', 'Nendoroid', 3300, 1, 'Hot-Item', 0.25, 120);
INSERT INTO `orderdetail` VALUES (440, 230, '2022-03-26', 24, 'Zenitsu Agatsuma - Demon Slayer', 'Nendoroid', 2300, 1, 'Hot-Item', 0.25, 120);
INSERT INTO `orderdetail` VALUES (441, 231, '2022-03-26', 12, 'Levi Ackerman - Attack on Titan', 'Nendoroid', 2400, 2, '', 0, 120);
INSERT INTO `orderdetail` VALUES (442, 231, '2022-03-26', 3, 'Nanami Kento - Jujustu Kaisen', 'Nendoroid', 1800, 1, '', 0, 120);
INSERT INTO `orderdetail` VALUES (443, 232, '2022-03-26', 6, 'Yoichi Isagi - Blue Lock', 'Standy', 550, 1, 'Freeshipping', 120, 120);
INSERT INTO `orderdetail` VALUES (444, 232, '2022-03-26', 40, 'Megumi Fushiguro - Jujustu Kaisen', 'Lookup', 1450, 1, 'Freeshipping', 120, 120);
INSERT INTO `orderdetail` VALUES (445, 232, '2022-03-26', 4, 'Katsuki Bakugo - My Hero Academia', 'Figure', 3500, 1, 'Freeshipping', 120, 120);

-- --------------------------------------------------------

-- 
-- Table structure for table `orderform`
-- 

CREATE TABLE `orderform` (
  `billNo` int(11) NOT NULL auto_increment,
  `orderDate` date NOT NULL,
  `customerId` int(11) NOT NULL,
  `customerName` varchar(255) NOT NULL,
  `shippingAddress` varchar(255) NOT NULL,
  `employeeId` varchar(255) NOT NULL,
  `orderStatus` varchar(255) NOT NULL,
  `shipmentMethod` varchar(255) NOT NULL,
  `paymentMethod` varchar(255) NOT NULL,
  PRIMARY KEY  (`billNo`)
) ENGINE=MyISAM  DEFAULT CHARSET=utf8 AUTO_INCREMENT=233 ;

-- 
-- Dumping data for table `orderform`
-- 

INSERT INTO `orderform` VALUES (1, '2022-01-03', 2, 'Hiroko Potter', '2508 Dolor. Av. Muskegon KY 12482', 'EMP-0187', 'Shipped', 'registered', 'Bank');
INSERT INTO `orderform` VALUES (2, '2022-01-03', 4, 'Colby Bernard', '7193 Ullamcorper Avenue Amesbury HI  93373', 'EMP-0290', 'Shipped', 'registered', 'Bank');
INSERT INTO `orderform` VALUES (3, '2022-01-03', 6, 'Rebecca Chambers', '5982 Sit Ave Liberal Vermont  51324', 'EMP-0187', 'Shipped', 'registered', 'Bank');
INSERT INTO `orderform` VALUES (4, '2022-01-03', 1, 'Iris Watson', '8562 Fusce Rd. Frederick Nebraska 20620', 'EMP-0290', 'Shipped', 'registered', 'Paypal');
INSERT INTO `orderform` VALUES (5, '2022-01-03', 5, 'Noelle Adams', '6351 Fringilla Avenue Gardena Colorado 37547', 'EMP-0290', 'Shipped', 'EMS', 'Bank');
INSERT INTO `orderform` VALUES (6, '2022-01-03', 7, 'Castor Richardson', '3472 Ullamcorper Street Lynchburg DC 29738', 'EMP-0199', 'Shipped', 'registered', 'Master card');
INSERT INTO `orderform` VALUES (7, '2022-01-04', 5, 'Noelle Adams', '6351 Fringilla Avenue Gardena Colorado 37547', 'EMP-0290', 'Shipped', 'EMS', 'Bank');
INSERT INTO `orderform` VALUES (8, '2022-01-04', 4, 'Colby Bernard', '7193 Ullamcorper Avenue Amesbury HI  93373', 'EMP-0199', 'Shipped', 'registered', 'Master card');
INSERT INTO `orderform` VALUES (9, '2022-01-04', 7, 'Castor Richardson', '3472 Ullamcorper Street Lynchburg DC 29738', 'EMP-0322', 'Shipped', 'EMS', 'Bank');
INSERT INTO `orderform` VALUES (10, '2022-01-04', 6, 'Rebecca Chambers', '5982 Sit Ave Liberal Vermont  51324', 'EMP-0290', 'Shipped', 'EMS', 'Bank');
INSERT INTO `orderform` VALUES (11, '2022-01-04', 13, 'Jordan Calderon', '430-985 Eleifend St. Duluth Washington 92611', 'EMP-0199', 'Shipped', 'registered', 'Bank');
INSERT INTO `orderform` VALUES (12, '2022-01-04', 11, 'Jasper Carney', '1195 Lobortis Rd. New Orleans New Hampshire 71983', 'EMP-0199', 'Shipped', 'EMS', 'Bank');
INSERT INTO `orderform` VALUES (13, '2022-01-04', 9, 'Judith Floyd', '7936 Feugiat St. Williston Nevada 58521', 'EMP-0199', 'Shipped', 'EMS', 'Paypal');
INSERT INTO `orderform` VALUES (14, '2022-01-04', 3, 'Melvin Porter', '1599 Curabitur Rd. Bandera South Dakota 45149', 'EMP-0290', 'Shipped', 'EMS', 'Paypal');
INSERT INTO `orderform` VALUES (15, '2022-01-04', 2, 'Hiroko Potter', '2508 Dolor. Av. Muskegon KY 12482', 'EMP-0290', 'Shipped', 'EMS', 'Paypal');
INSERT INTO `orderform` VALUES (16, '2022-01-07', 4, 'Colby Bernard', '7193 Ullamcorper Avenue Amesbury HI  93373', 'EMP-0290', 'Shipped', 'EMS', 'Paypal');
INSERT INTO `orderform` VALUES (17, '2022-01-07', 7, 'Castor Richardson', '3472 Ullamcorper Street Lynchburg DC 29738', 'EMP-0290', 'Shipped', 'EMS', 'Bank');
INSERT INTO `orderform` VALUES (18, '2022-01-07', 5, 'Noelle Adams', '6351 Fringilla Avenue Gardena Colorado 37547', 'EMP-0199', 'Shipped', 'EMS', 'Master card');
INSERT INTO `orderform` VALUES (19, '2022-01-09', 7, 'Castor Richardson', '3472 Ullamcorper Street Lynchburg DC 29738', 'EMP-0199', 'Shipped', 'registered', 'Master card');
INSERT INTO `orderform` VALUES (20, '2022-01-09', 5, 'Noelle Adams', '6351 Fringilla Avenue Gardena Colorado 37547', 'EMP-0290', 'Shipped', 'registered', 'Bank');
INSERT INTO `orderform` VALUES (21, '2022-01-09', 13, 'Jordan Calderon', '430-985 Eleifend St. Duluth Washington 92611', 'EMP-0290', 'Shipped', 'EMS', 'Bank');
INSERT INTO `orderform` VALUES (22, '2022-01-09', 2, 'Hiroko Potter', '2508 Dolor. Av. Muskegon KY 12482', 'EMP-0290', 'Shipped', 'registered', 'Master card');
INSERT INTO `orderform` VALUES (23, '2022-01-10', 5, 'Noelle Adams', '6351 Fringilla Avenue Gardena Colorado 37547', 'EMP-0322', 'Shipped', 'EMS', 'Master card');
INSERT INTO `orderform` VALUES (24, '2022-01-10', 3, 'Melvin Porter', '1599 Curabitur Rd. Bandera South Dakota 45149', 'EMP-0290', 'Shipped', 'registered', 'Bank');
INSERT INTO `orderform` VALUES (25, '2022-01-10', 11, 'Jasper Carney', '1195 Lobortis Rd. New Orleans New Hampshire 71983', 'EMP-0290', 'Shipped', 'registered', 'Bank');
INSERT INTO `orderform` VALUES (26, '2022-01-10', 7, 'Castor Richardson', '3472 Ullamcorper Street Lynchburg DC 29738', 'EMP-0322', 'Shipped', 'registered', 'Master card');
INSERT INTO `orderform` VALUES (27, '2022-01-10', 9, 'Judith Floyd', '7936 Feugiat St. Williston Nevada 58521', 'EMP-0290', 'Shipped', 'registered', 'Master card');
INSERT INTO `orderform` VALUES (28, '2022-01-01', 13, 'Jordan Calderon', '430-985 Eleifend St. Duluth Washington 92611', 'EMP-0290', 'Shipped', 'EMS', 'Master card');
INSERT INTO `orderform` VALUES (29, '2022-01-01', 3, 'Melvin Porter', '1599 Curabitur Rd. Bandera South Dakota 45149', 'EMP-0290', 'Shipped', 'EMS', 'Master card');
INSERT INTO `orderform` VALUES (30, '2022-01-01', 5, 'Noelle Adams', '6351 Fringilla Avenue Gardena Colorado 37547', 'EMP-0290', 'Shipped', 'registered', 'Bank');
INSERT INTO `orderform` VALUES (31, '2022-01-01', 7, 'Castor Richardson', '3472 Ullamcorper Street Lynchburg DC 29738', 'EMP-0322', 'Shipped', 'EMS', 'Paypal');
INSERT INTO `orderform` VALUES (32, '2022-01-01', 5, 'Noelle Adams', '6351 Fringilla Avenue Gardena Colorado 37547', 'EMP-0322', 'Shipped', 'EMS', 'Bank');
INSERT INTO `orderform` VALUES (33, '2022-01-01', 4, 'Colby Bernard', '7193 Ullamcorper Avenue Amesbury HI  93373', 'EMP-0322', 'Shipped', 'EMS', 'Master card');
INSERT INTO `orderform` VALUES (34, '2022-01-04', 6, 'Rebecca Chambers', '5982 Sit Ave Liberal Vermont  51324', 'EMP-0290', 'Shipped', 'registered', 'Bank');
INSERT INTO `orderform` VALUES (35, '2022-01-05', 3, 'Melvin Porter', '1599 Curabitur Rd. Bandera South Dakota 45149', 'EMP-0199', 'Shipped', 'registered', 'Paypal');
INSERT INTO `orderform` VALUES (36, '2022-01-05', 1, 'Iris Watson', '8562 Fusce Rd. Frederick Nebraska 20620', 'EMP-0199', 'Shipped', 'EMS', 'Master card');
INSERT INTO `orderform` VALUES (37, '2022-01-05', 11, 'Jasper Carney', '1195 Lobortis Rd. New Orleans New Hampshire 71983', 'EMP-0290', 'Shipped', 'EMS', 'Bank');
INSERT INTO `orderform` VALUES (38, '2022-01-06', 3, 'Melvin Porter', '1599 Curabitur Rd. Bandera South Dakota 45149', 'EMP-0199', 'Shipped', 'registered', 'Master card');
INSERT INTO `orderform` VALUES (39, '2022-01-06', 5, 'Noelle Adams', '6351 Fringilla Avenue Gardena Colorado 37547', 'EMP-0290', 'Shipped', 'EMS', 'Master card');
INSERT INTO `orderform` VALUES (40, '2022-01-06', 13, 'Jordan Calderon', '430-985 Eleifend St. Duluth Washington 92611', 'EMP-0290', 'Shipped', 'EMS', 'Paypal');
INSERT INTO `orderform` VALUES (41, '2022-01-01', 5, 'Noelle Adams', '6351 Fringilla Avenue Gardena Colorado 37547', 'EMP-0199', 'Shipped', 'registered', 'Bank');
INSERT INTO `orderform` VALUES (42, '2022-01-10', 3, 'Melvin Porter', '1599 Curabitur Rd. Bandera South Dakota 45149', 'EMP-0290', 'Shipped', 'EMS', 'Paypal');
INSERT INTO `orderform` VALUES (43, '2022-01-10', 1, 'Iris Watson', '8562 Fusce Rd. Frederick Nebraska 20620', 'EMP-0322', 'Shipped', 'EMS', 'Paypal');
INSERT INTO `orderform` VALUES (44, '2022-01-10', 2, 'Hiroko Potter', '2508 Dolor. Av. Muskegon KY 12482', 'EMP-0322', 'Shipped', 'EMS', 'Master card');
INSERT INTO `orderform` VALUES (45, '2022-01-10', 2, 'Hiroko Potter', '2508 Dolor. Av. Muskegon KY 12482', 'EMP-0290', 'Shipped', 'EMS', 'Bank');
INSERT INTO `orderform` VALUES (46, '2022-01-12', 4, 'Colby Bernard', '7193 Ullamcorper Avenue Amesbury HI  93373', 'EMP-0322', 'Shipped', 'EMS', 'Paypal');
INSERT INTO `orderform` VALUES (47, '2022-01-14', 11, 'Jasper Carney', '1195 Lobortis Rd. New Orleans New Hampshire 71983', 'EMP-0290', 'Shipped', 'registered', 'Bank');
INSERT INTO `orderform` VALUES (48, '2022-01-14', 5, 'Noelle Adams', '6351 Fringilla Avenue Gardena Colorado 37547', 'EMP-0290', 'Shipped', 'registered', 'Master card');
INSERT INTO `orderform` VALUES (49, '2022-01-14', 7, 'Castor Richardson', '3472 Ullamcorper Street Lynchburg DC 29738', 'EMP-0322', 'Shipped', 'EMS', 'Bank');
INSERT INTO `orderform` VALUES (50, '2022-01-15', 5, 'Noelle Adams', '6351 Fringilla Avenue Gardena Colorado 37547', 'EMP-0322', 'Shipped', 'EMS', 'Master card');
INSERT INTO `orderform` VALUES (51, '2022-01-15', 12, 'Wilma Pace', 'Ap #676-6532 Odio Rd. Darlington CO 06963', 'EMP-0290', 'Shipped', 'EMS', 'Master card');
INSERT INTO `orderform` VALUES (52, '2022-01-15', 11, 'Jasper Carney', '1195 Lobortis Rd. New Orleans New Hampshire 71983', 'EMP-0199', 'Shipped', 'EMS', 'Bank');
INSERT INTO `orderform` VALUES (53, '2022-01-15', 4, 'Colby Bernard', '7193 Ullamcorper Avenue Amesbury HI  93373', 'EMP-0199', 'Shipped', 'registered', 'Master card');
INSERT INTO `orderform` VALUES (54, '2022-01-15', 13, 'Jordan Calderon', '430-985 Eleifend St. Duluth Washington 92611', 'EMP-0199', 'Shipped', 'registered', 'Bank');
INSERT INTO `orderform` VALUES (55, '2022-01-15', 2, 'Hiroko Potter', '2508 Dolor. Av. Muskegon KY 12482', 'EMP-0199', 'Shipped', 'EMS', 'Bank');
INSERT INTO `orderform` VALUES (56, '2022-01-15', 1, 'Iris Watson', '8562 Fusce Rd. Frederick Nebraska 20620', 'EMP-0322', 'Shippep', 'EMS', 'Paypal');
INSERT INTO `orderform` VALUES (57, '2022-01-15', 15, 'Tamara Howe', '3415 Lobortis. Avenue Rocky Mount WA  48580', 'EMP-0290', 'Shipped', 'EMS', 'Master card');
INSERT INTO `orderform` VALUES (58, '2022-01-15', 9, 'Judith Floyd', '7936 Feugiat St. Williston Nevada 58521', 'EMP-0290', 'Shipped', 'EMS', 'Master card');
INSERT INTO `orderform` VALUES (59, '2022-01-16', 5, 'Noelle Adams', '6351 Fringilla Avenue Gardena Colorado 37547', 'EMP-0199', 'Shipped', 'registered', 'Master card');
INSERT INTO `orderform` VALUES (60, '2022-01-16', 2, 'Hiroko Potter', '2508 Dolor. Av. Muskegon KY 12482', 'EMP-0290', 'Shipped', 'EMS', 'Master card');
INSERT INTO `orderform` VALUES (61, '2022-01-16', 7, 'Castor Richardson', '3472 Ullamcorper Street Lynchburg DC 29738', 'EMP-0199', 'Shipped', 'registered', 'Paypal');
INSERT INTO `orderform` VALUES (62, '2022-01-18', 2, 'Hiroko Potter', '2508 Dolor. Av. Muskegon KY 12482', 'EMP-0199', 'Shipped', 'EMS', 'Bank');
INSERT INTO `orderform` VALUES (63, '2022-01-18', 14, 'Ivor Delgado', 'Ap #310-1678 Ut Av. Santa Barbara MT 88317', 'EMP-0290', 'Shipped', 'EMS', 'Bank');
INSERT INTO `orderform` VALUES (64, '2022-01-20', 5, 'Noelle Adams', '6351 Fringilla Avenue Gardena Colorado 37547', 'EMP-0290', 'Shipped', 'registered', 'Bank');
INSERT INTO `orderform` VALUES (65, '2022-01-20', 1, 'Iris Watson', '8562 Fusce Rd. Frederick Nebraska 20620', 'EMP-0290', 'Shipped', 'registered', 'Master card');
INSERT INTO `orderform` VALUES (66, '2022-01-20', 12, 'Wilma Pace', 'Ap #676-6532 Odio Rd. Darlington CO 06963', 'EMP-0322', 'Shipped', 'EMS', 'Bank');
INSERT INTO `orderform` VALUES (67, '2022-01-22', 5, 'Noelle Adams', '6351 Fringilla Avenue Gardena Colorado 37547', 'EMP-0290', 'Shipped', 'registered', 'Master card');
INSERT INTO `orderform` VALUES (68, '2022-01-23', 6, 'Rebecca Chambers', '5982 Sit Ave Liberal Vermont  51324', 'EMP-0290', 'Shipped', 'EMS', 'Master card');
INSERT INTO `orderform` VALUES (69, '2022-01-23', 1, 'Iris Watson', '8562 Fusce Rd. Frederick Nebraska 20620', 'EMP-0322', 'Shipped', 'EMS', 'Master card');
INSERT INTO `orderform` VALUES (70, '2022-01-23', 5, 'Noelle Adams', '6351 Fringilla Avenue Gardena Colorado 37547', 'EMP-0322', 'Shipped', 'EMS', 'VISA');
INSERT INTO `orderform` VALUES (71, '2022-01-23', 9, 'Judith Floyd', '7936 Feugiat St. Williston Nevada 58521', 'EMP-0322', 'Shipped', 'EMS', 'VISA');
INSERT INTO `orderform` VALUES (72, '2022-01-27', 7, 'Castor Richardson', '3472 Ullamcorper Street Lynchburg DC 29738', 'EMP-0290', 'Shipped', 'EMS', 'Bank');
INSERT INTO `orderform` VALUES (73, '2022-01-27', 12, 'Wilma Pace', 'Ap #676-6532 Odio Rd. Darlington CO 06963', 'EMP-0199', 'Shipped', 'EMS', 'VISA');
INSERT INTO `orderform` VALUES (74, '2022-01-24', 4, 'Colby Bernard', '7193 Ullamcorper Avenue Amesbury HI  93373', 'EMP-0290', 'Shipped', 'registered', 'Bank');
INSERT INTO `orderform` VALUES (75, '2022-01-24', 5, 'Noelle Adams', '6351 Fringilla Avenue Gardena Colorado 37547', 'EMP-0199', 'Shipped', 'EMS', 'Bank');
INSERT INTO `orderform` VALUES (76, '2022-01-25', 6, 'Rebecca Chambers', '5982 Sit Ave Liberal Vermont  51324', 'EMP-0322', 'Shipped', 'EMS', 'Paypal');
INSERT INTO `orderform` VALUES (77, '2022-01-26', 1, 'Iris Watson', '8562 Fusce Rd. Frederick Nebraska 20620', 'EMP-0199', 'Shipped', 'EMS', 'Bank');
INSERT INTO `orderform` VALUES (78, '2022-01-26', 13, 'Jordan Calderon', '430-985 Eleifend St. Duluth Washington 92611', 'EMP-0290', 'Shipped', 'registered', 'Bank');
INSERT INTO `orderform` VALUES (79, '2022-01-26', 5, 'Noelle Adams', '6351 Fringilla Avenue Gardena Colorado 37547', 'EMP-0290', 'Shipped', 'EMS', 'Bank');
INSERT INTO `orderform` VALUES (80, '2022-01-29', 4, 'Colby Bernard', '7193 Ullamcorper Avenue Amesbury HI  93373', 'EMP-0290', 'Shipped', 'EMS', 'Paypal');
INSERT INTO `orderform` VALUES (81, '2022-01-29', 1, 'Iris Watson', '8562 Fusce Rd. Frederick Nebraska 20620', 'EMP-0290', 'Shipped', 'registered', 'VISA');
INSERT INTO `orderform` VALUES (82, '2022-01-29', 6, 'Rebecca Chambers', '5982 Sit Ave Liberal Vermont  51324', 'EMP-0322', 'Shipped', 'registered', 'Bank');
INSERT INTO `orderform` VALUES (83, '2022-01-29', 12, 'Wilma Pace', 'Ap #676-6532 Odio Rd. Darlington CO 06963', 'EMP-0290', 'Shipped', 'EMS', 'Paypal');
INSERT INTO `orderform` VALUES (84, '2022-01-29', 15, 'Tamara Howe', '3415 Lobortis. Avenue Rocky Mount WA  48580', 'EMP-0322', 'Shipped', 'EMS', 'Bank');
INSERT INTO `orderform` VALUES (85, '2022-01-20', 2, 'Hiroko Potter', '2508 Dolor. Av. Muskegon KY 12482', 'EMP-0290', 'Shipped', 'EMS', 'Bank');
INSERT INTO `orderform` VALUES (86, '2022-01-30', 10, 'Zephania Sanders', '3714 Nascetur St. Hawthorne Louisiana 10626', 'EMP-0322', 'Shipped', 'EMS', 'Paypal');
INSERT INTO `orderform` VALUES (87, '2022-01-30', 4, 'Colby Bernard', '7193 Ullamcorper Avenue Amesbury HI  93373', 'EMP-0322', 'Shipped', 'EMS', 'VISA');
INSERT INTO `orderform` VALUES (88, '2022-01-30', 9, 'Judith Floyd', '7936 Feugiat St. Williston Nevada 58521', 'EMP-0290', 'Shipped', 'EMS', 'VISA');
INSERT INTO `orderform` VALUES (89, '2022-01-30', 5, 'Noelle Adams', '6351 Fringilla Avenue Gardena Colorado 37547', 'EMP-0290', 'Shipped', 'registered', 'VISA');
INSERT INTO `orderform` VALUES (90, '2022-01-31', 7, 'Castor Richardson', '3472 Ullamcorper Street Lynchburg DC 29738', 'EMP-0290', 'Shipped', 'EMS', 'VISA');
INSERT INTO `orderform` VALUES (91, '2022-01-31', 5, 'Noelle Adams', '6351 Fringilla Avenue Gardena Colorado 37547', 'EMP-0322', 'Shipped', 'registered', 'Master card');
INSERT INTO `orderform` VALUES (92, '2022-01-31', 13, 'Jordan Calderon', '430-985 Eleifend St. Duluth Washington 92611', 'EMP-0322', 'Shipped', 'EMS', 'Paypal');
INSERT INTO `orderform` VALUES (93, '2022-01-31', 3, 'Melvin Porter', '1599 Curabitur Rd. Bandera South Dakota 45149', 'EMP-0290', 'Shipped', 'EMS', 'Paypal');
INSERT INTO `orderform` VALUES (94, '2022-01-31', 11, 'Jasper Carney', '1195 Lobortis Rd. New Orleans New Hampshire 71983', 'EMP-0322', 'Shipped', 'EMS', 'Paypal');
INSERT INTO `orderform` VALUES (95, '2022-01-31', 4, 'Colby Bernard', '7193 Ullamcorper Avenue Amesbury HI  93373', 'EMP-0290', 'Shipped', 'EMS', 'Bank');
INSERT INTO `orderform` VALUES (96, '2022-01-31', 10, 'Zephania Sanders', '3714 Nascetur St. Hawthorne Louisiana 10626', 'EMP-0290', 'Shipped', 'EMS', 'Bank');
INSERT INTO `orderform` VALUES (97, '2022-01-31', 3, 'Melvin Porter', '1599 Curabitur Rd. Bandera South Dakota 45149', 'EMP-0199', 'Shipped', 'EMS', 'Bank');
INSERT INTO `orderform` VALUES (98, '2022-01-31', 6, 'Rebecca Chambers', '5982 Sit Ave Liberal Vermont  51324', 'EMP-0199', 'Shipped', 'EMS', 'Bank');
INSERT INTO `orderform` VALUES (99, '2022-01-31', 2, 'Hiroko Potter', '2508 Dolor. Av. Muskegon KY 12482', 'EMP-0199', 'Shipped', 'EMS', 'Paypal');
INSERT INTO `orderform` VALUES (100, '2022-01-31', 5, 'Noelle Adams', '6351 Fringilla Avenue Gardena Colorado 37547', 'EMP-0199', 'Shipped', 'EMS', 'Bank');
INSERT INTO `orderform` VALUES (101, '2022-01-31', 4, 'Colby Bernard', '7193 Ullamcorper Avenue Amesbury HI  93373', 'EMP-0199', 'Shipped', 'EMS', 'VISA');
INSERT INTO `orderform` VALUES (102, '2022-01-31', 12, 'Wilma Pace', 'Ap #676-6532 Odio Rd. Darlington CO 06963', 'EMP-0290', 'Shipped', 'registered', 'Paypal');
INSERT INTO `orderform` VALUES (103, '2022-01-31', 15, 'Tamara Howe', '3415 Lobortis. Avenue Rocky Mount WA  48580', 'EMP-0322', 'Shipped', 'EMS', 'Paypal');
INSERT INTO `orderform` VALUES (104, '2022-01-31', 2, 'Hiroko Potter', '2508 Dolor. Av. Muskegon KY 12482', 'EMP-0290', 'Shipped', 'registered', 'Bank');
INSERT INTO `orderform` VALUES (105, '2022-01-31', 15, 'Tamara Howe', '3415 Lobortis. Avenue Rocky Mount WA  48580', 'EMP-0290', 'Shipped', 'EMS', 'Bank');
INSERT INTO `orderform` VALUES (106, '2022-01-31', 1, 'Iris Watson', '8562 Fusce Rd. Frederick Nebraska 20620', 'EMP-0199', 'Shipped', 'EMS', 'Bank');
INSERT INTO `orderform` VALUES (107, '2022-01-31', 9, 'Judith Floyd', '7936 Feugiat St. Williston Nevada 58521', 'EMP-0322', 'Shipped', 'registered', 'VISA');
INSERT INTO `orderform` VALUES (108, '2022-01-31', 12, 'Wilma Pace', 'Ap #676-6532 Odio Rd. Darlington CO 06963', 'EMP-0322', 'Shipped', 'EMS', 'VISA');
INSERT INTO `orderform` VALUES (109, '2022-01-31', 7, 'Castor Richardson', '3472 Ullamcorper Street Lynchburg DC 29738', 'EMP-0290', 'Shipped', 'registered', 'Paypal');
INSERT INTO `orderform` VALUES (110, '2022-01-31', 6, 'Rebecca Chambers', '5982 Sit Ave Liberal Vermont  51324', 'EMP-0322', 'Shipped', 'EMS', 'Paypal');
INSERT INTO `orderform` VALUES (111, '2022-01-31', 9, 'Judith Floyd', '7936 Feugiat St. Williston Nevada 58521', 'EMP-0322', 'Shipped', 'EMS', 'Bank');
INSERT INTO `orderform` VALUES (112, '2022-01-31', 5, 'Noelle Adams', '6351 Fringilla Avenue Gardena Colorado 37547', 'EMP-0290', 'Shipped', 'EMS', 'VISA');
INSERT INTO `orderform` VALUES (113, '2022-01-31', 4, 'Colby Bernard', '7193 Ullamcorper Avenue Amesbury HI  93373', 'EMP-0199', 'Shipped', 'EMS', 'VISA');
INSERT INTO `orderform` VALUES (114, '2022-02-01', 13, 'Jordan Calderon', '430-985 Eleifend St. Duluth Washington 92611', 'EMP-0290', 'Shipped', 'EMS', 'Bank');
INSERT INTO `orderform` VALUES (115, '2022-02-01', 6, 'Rebecca Chambers', '5982 Sit Ave Liberal Vermont  51324', 'EMP-0199', 'Shipped', 'EMS', 'VISA');
INSERT INTO `orderform` VALUES (116, '2022-02-01', 4, 'Colby Bernard', '7193 Ullamcorper Avenue Amesbury HI  93373', 'EMP-0322', 'Shipped', 'EMS', 'Bank');
INSERT INTO `orderform` VALUES (117, '2022-02-01', 7, 'Castor Richardson', '3472 Ullamcorper Street Lynchburg DC 29738', 'EMP-0199', 'Shipped', 'EMS', 'VISA');
INSERT INTO `orderform` VALUES (118, '2022-02-01', 5, 'Noelle Adams', '6351 Fringilla Avenue Gardena Colorado 37547', 'EMP-0290', 'Shipped', 'registered', 'VISA');
INSERT INTO `orderform` VALUES (119, '2022-02-01', 3, 'Melvin Porter', '1599 Curabitur Rd. Bandera South Dakota 45149', 'EMP-0290', 'Shipped', 'EMS', 'Bank');
INSERT INTO `orderform` VALUES (120, '2022-02-02', 11, 'Jasper Carney', '1195 Lobortis Rd. New Orleans New Hampshire 71983', 'EMP-0290', 'Shipped', 'registered', 'VISA');
INSERT INTO `orderform` VALUES (121, '2022-02-02', 4, 'Colby Bernard', '7193 Ullamcorper Avenue Amesbury HI  93373', 'EMP-0290', 'Shipped', 'registered', 'VISA');
INSERT INTO `orderform` VALUES (122, '2022-02-02', 6, 'Rebecca Chambers', '5982 Sit Ave Liberal Vermont  51324', 'EMP-0290', 'Shipped', 'EMS', 'Bank');
INSERT INTO `orderform` VALUES (123, '2022-02-02', 11, 'Jasper Carney', '1195 Lobortis Rd. New Orleans New Hampshire 71983', 'EMP-0322', 'Shipped', 'EMS', 'VISA');
INSERT INTO `orderform` VALUES (124, '2022-02-01', 3, 'Melvin Porter', '1599 Curabitur Rd. Bandera South Dakota 45149', 'EMP-0290', 'Shipped', 'EMS', 'Bank');
INSERT INTO `orderform` VALUES (125, '2022-02-05', 9, 'Judith Floyd', '7936 Feugiat St. Williston Nevada 58521', 'EMP-0322', 'Shipped', 'EMS', 'Bank');
INSERT INTO `orderform` VALUES (126, '2022-02-05', 10, 'Zephania Sanders', '3714 Nascetur St. Hawthorne Louisiana 10626', 'EMP-0290', 'Shipped', 'EMS', 'Master card');
INSERT INTO `orderform` VALUES (127, '2022-02-06', 9, 'Judith Floyd', '7936 Feugiat St. Williston Nevada 58521', 'EMP-0290', 'Shipped', 'EMS', 'Master card');
INSERT INTO `orderform` VALUES (128, '2022-02-07', 4, 'Colby Bernard', '7193 Ullamcorper Avenue Amesbury HI  93373', 'EMP-0199', 'Shipped', 'registered', 'Bank');
INSERT INTO `orderform` VALUES (129, '2022-02-03', 4, 'Colby Bernard', '7193 Ullamcorper Avenue Amesbury HI  93373', 'EMP-0199', 'Shipped', 'EMS', 'Master card');
INSERT INTO `orderform` VALUES (130, '2022-02-03', 6, 'Rebecca Chambers', '5982 Sit Ave Liberal Vermont  51324', 'EMP-0290', 'Shipped', 'registered', 'Master card');
INSERT INTO `orderform` VALUES (131, '2022-02-08', 5, 'Noelle Adams', '6351 Fringilla Avenue Gardena Colorado 37547', 'EMP-0290', 'Shipped', 'EMS', 'VISA');
INSERT INTO `orderform` VALUES (132, '2022-02-08', 4, 'Colby Bernard', '7193 Ullamcorper Avenue Amesbury HI  93373', 'EMP-0290', 'Shipped', 'EMS', 'VISA');
INSERT INTO `orderform` VALUES (133, '2022-02-08', 15, 'Tamara Howe', '3415 Lobortis. Avenue Rocky Mount WA  48580', 'EMP-0199', 'Shipped', 'EMS', 'Master card');
INSERT INTO `orderform` VALUES (134, '2022-02-10', 6, 'Rebecca Chambers', '5982 Sit Ave Liberal Vermont  51324', 'EMP-0322', 'Shipped', 'EMS', 'Bank');
INSERT INTO `orderform` VALUES (135, '2022-02-10', 5, 'Noelle Adams', '6351 Fringilla Avenue Gardena Colorado 37547', 'EMP-0322', 'Shipped', 'EMS', 'VISA');
INSERT INTO `orderform` VALUES (136, '2022-02-11', 4, 'Colby Bernard', '7193 Ullamcorper Avenue Amesbury HI  93373', 'EMP-0290', 'Shipped', 'EMS', 'Bank');
INSERT INTO `orderform` VALUES (137, '2022-02-11', 3, 'Melvin Porter', '1599 Curabitur Rd. Bandera South Dakota 45149', 'EMP-0322', 'Shipped', 'registered', 'Master card');
INSERT INTO `orderform` VALUES (138, '2022-02-14', 12, 'Wilma Pace', 'Ap #676-6532 Odio Rd. Darlington CO 06963', 'EMP-0322', 'Shipped', 'EMS', 'Master card');
INSERT INTO `orderform` VALUES (139, '2022-02-14', 5, 'Noelle Adams', '6351 Fringilla Avenue Gardena Colorado 37547', 'EMP-0290', 'Shipped', 'registered', 'Bank');
INSERT INTO `orderform` VALUES (140, '2022-02-16', 3, 'Melvin Porter', '1599 Curabitur Rd. Bandera South Dakota 45149', 'EMP-0290', 'Shipped', 'EMS', 'Bank');
INSERT INTO `orderform` VALUES (141, '2022-02-13', 2, 'Hiroko Potter', '2508 Dolor. Av. Muskegon KY 12482', 'EMP-0322', 'Shipped', 'EMS', 'VISA');
INSERT INTO `orderform` VALUES (142, '2022-02-13', 3, 'Melvin Porter', '1599 Curabitur Rd. Bandera South Dakota 45149', 'EMP-0290', 'Shipped', 'EMS', 'VISA');
INSERT INTO `orderform` VALUES (143, '2022-02-16', 2, 'Hiroko Potter', '2508 Dolor. Av. Muskegon KY 12482', 'EMP-0290', 'Shipped', 'registered', 'VISA');
INSERT INTO `orderform` VALUES (144, '2022-02-17', 4, 'Colby Bernard', '7193 Ullamcorper Avenue Amesbury HI  93373', 'EMP-0322', 'Shipped', 'EMS', 'VISA');
INSERT INTO `orderform` VALUES (145, '2022-02-17', 9, 'Judith Floyd', '7936 Feugiat St. Williston Nevada 58521', 'EMP-0290', 'Shipped', 'EMS', 'Master card');
INSERT INTO `orderform` VALUES (146, '2022-02-17', 13, 'Jordan Calderon', '430-985 Eleifend St. Duluth Washington 92611', 'EMP-0322', 'Shipped', 'EMS', 'VISA');
INSERT INTO `orderform` VALUES (147, '2022-02-17', 5, 'Noelle Adams', '6351 Fringilla Avenue Gardena Colorado 37547', 'EMP-0322', 'Shipped', 'registered', 'Master card');
INSERT INTO `orderform` VALUES (148, '2022-02-20', 3, 'Melvin Porter', '1599 Curabitur Rd. Bandera South Dakota 45149', 'EMP-0322', 'Shipped', 'EMS', 'Master card');
INSERT INTO `orderform` VALUES (149, '2022-02-20', 6, 'Rebecca Chambers', '5982 Sit Ave Liberal Vermont  51324', 'EMP-0290', 'Shipped', 'EMS', 'VISA');
INSERT INTO `orderform` VALUES (150, '2022-02-20', 15, 'Tamara Howe', '3415 Lobortis. Avenue Rocky Mount WA  48580', 'EMP-0290', 'Shipped', 'EMS', 'Paypal');
INSERT INTO `orderform` VALUES (151, '2022-02-22', 3, 'Melvin Porter', '1599 Curabitur Rd. Bandera South Dakota 45149', 'EMP-0199', 'Shipped', 'EMS', 'Bank');
INSERT INTO `orderform` VALUES (152, '2022-02-22', 4, 'Colby Bernard', '7193 Ullamcorper Avenue Amesbury HI  93373', 'EMP-0199', 'Shipped', 'EMS', 'Paypal');
INSERT INTO `orderform` VALUES (153, '2022-02-21', 9, 'Judith Floyd', '7936 Feugiat St. Williston Nevada 58521', 'EMP-0290', 'Shipped', 'EMS', 'Paypal');
INSERT INTO `orderform` VALUES (154, '2022-02-21', 12, 'Wilma Pace', 'Ap #676-6532 Odio Rd. Darlington CO 06963', 'EMP-0290', 'Shipped', 'EMS', 'Paypal');
INSERT INTO `orderform` VALUES (155, '2022-02-21', 3, 'Melvin Porter', '1599 Curabitur Rd. Bandera South Dakota 45149', 'EMP-0290', 'Shipped', 'EMS', 'Bank');
INSERT INTO `orderform` VALUES (156, '2022-02-21', 7, 'Castor Richardson', '3472 Ullamcorper Street Lynchburg DC 29738', 'EMP-0199', 'Shipped', 'registered', 'Paypal');
INSERT INTO `orderform` VALUES (157, '2022-02-24', 4, 'Colby Bernard', '7193 Ullamcorper Avenue Amesbury HI  93373', 'EMP-0290', 'Shipped', 'EMS', 'Paypal');
INSERT INTO `orderform` VALUES (158, '2022-02-24', 6, 'Rebecca Chambers', '5982 Sit Ave Liberal Vermont  51324', 'EMP-0322', 'Shipped', 'registered', 'Bank');
INSERT INTO `orderform` VALUES (159, '2022-02-24', 5, 'Noelle Adams', '6351 Fringilla Avenue Gardena Colorado 37547', 'EMP-0290', 'Shipped', 'EMS', 'VISA');
INSERT INTO `orderform` VALUES (160, '2022-02-12', 1, 'Iris Watson', '8562 Fusce Rd. Frederick Nebraska 20620', 'EMP-0290', 'Shipped', 'EMS', 'Bank');
INSERT INTO `orderform` VALUES (161, '2022-02-23', 12, 'Wilma Pace', 'Ap #676-6532 Odio Rd. Darlington CO 06963', 'EMP-0290', 'Shipped', 'EMS', 'Master card');
INSERT INTO `orderform` VALUES (162, '2022-02-23', 4, 'Colby Bernard', '7193 Ullamcorper Avenue Amesbury HI  93373', 'EMP-0199', 'Shipped', 'EMS', 'Master card');
INSERT INTO `orderform` VALUES (163, '2022-02-08', 12, 'Wilma Pace', 'Ap #676-6532 Odio Rd. Darlington CO 06963', 'EMP-0290', 'Shipped', 'registered', 'VISA');
INSERT INTO `orderform` VALUES (164, '2022-02-19', 3, 'Melvin Porter', '1599 Curabitur Rd. Bandera South Dakota 45149', 'EMP-0322', 'Shipped', 'EMS', 'Bank');
INSERT INTO `orderform` VALUES (165, '2022-02-19', 4, 'Colby Bernard', '7193 Ullamcorper Avenue Amesbury HI  93373', 'EMP-0290', 'Shipped', 'EMS', 'Bank');
INSERT INTO `orderform` VALUES (166, '2022-02-25', 4, 'Colby Bernard', '7193 Ullamcorper Avenue Amesbury HI  93373', 'EMP-0290', 'Shipped', 'registered', 'Bank');
INSERT INTO `orderform` VALUES (167, '2022-02-25', 6, 'Rebecca Chambers', '5982 Sit Ave Liberal Vermont  51324', 'EMP-0290', 'Shipped', 'EMS', 'Bank');
INSERT INTO `orderform` VALUES (168, '2022-02-26', 1, 'Iris Watson', '8562 Fusce Rd. Frederick Nebraska 20620', 'EMP-0199', 'Shipped', 'registered', 'Bank');
INSERT INTO `orderform` VALUES (169, '2022-02-26', 5, 'Noelle Adams', '6351 Fringilla Avenue Gardena Colorado 37547', 'EMP-0290', 'Shipped', 'registered', 'VISA');
INSERT INTO `orderform` VALUES (170, '2022-02-28', 3, 'Melvin Porter', '1599 Curabitur Rd. Bandera South Dakota 45149', 'EMP-0290', 'Shipped', 'EMS', 'Paypal');
INSERT INTO `orderform` VALUES (171, '2022-02-28', 4, 'Colby Bernard', '7193 Ullamcorper Avenue Amesbury HI  93373', 'EMP-0290', 'Shipped', 'EMS', 'Bank');
INSERT INTO `orderform` VALUES (172, '2022-02-28', 6, 'Rebecca Chambers', '5982 Sit Ave Liberal Vermont  51324', 'EMP-0290', 'Shipped', 'EMS', 'VISA');
INSERT INTO `orderform` VALUES (173, '2022-02-28', 1, 'Iris Watson', '8562 Fusce Rd. Frederick Nebraska 20620', 'EMP-0322', 'Shipped', 'EMS', 'Paypal');
INSERT INTO `orderform` VALUES (174, '2022-02-18', 15, 'Tamara Howe', '3415 Lobortis. Avenue Rocky Mount WA  48580', 'EMP-0322', 'Shipped', 'registered', 'Paypal');
INSERT INTO `orderform` VALUES (175, '2022-02-24', 1, 'Iris Watson', '8562 Fusce Rd. Frederick Nebraska 20620', 'EMP-0143', 'Shipped', 'EMS', 'VISA');
INSERT INTO `orderform` VALUES (176, '2022-03-23', 6, 'Rebecca Chambers', '5982 Sit Ave Liberal Vermont  51324', 'EMP-0187', 'Shipped', 'Registered', 'Bank');
INSERT INTO `orderform` VALUES (177, '2022-03-02', 3, 'Melvin Porter', '1599 Curabitur Rd. Bandera South Dakota', 'EMP-0187', 'Shipped', 'Registered', 'Bank');
INSERT INTO `orderform` VALUES (178, '2022-03-02', 4, 'Colby  Bernard', '7193 Ullamcorper Avenue Amesbury HI', 'EMP-0187', 'Shipped', 'EMS', 'Bank');
INSERT INTO `orderform` VALUES (179, '2022-03-02', 5, 'Noelle Adams', '6351 Fringilla Avenue Gardena Colorado', 'EMP-0143', 'Shipped', 'EMS', 'Paypal');
INSERT INTO `orderform` VALUES (180, '2022-03-03', 6, 'Rebecca Chambers', '5982 Sit Ave Liberal Vermont', 'EMP-0143', 'Shipped', 'EMS', 'Paypal');
INSERT INTO `orderform` VALUES (181, '2022-03-03', 9, 'Judith Floyd', '7936 Feugiat St. Williston Nevada  ', 'EMP-0143', 'Shipped', 'EMS', 'VISA');
INSERT INTO `orderform` VALUES (182, '2022-03-05', 2, 'Hiroko Potter', '2508 Dolor. Av. Muskegon KY', 'EMP-0143', 'Shipped', 'Registered', 'Paypal');
INSERT INTO `orderform` VALUES (183, '2022-03-06', 8, 'Raymond	 Levy', '7006 Risus St. Beaumont New Mexico  ', 'EMP-0143', 'Shipped', 'Registered', 'Master Card');
INSERT INTO `orderform` VALUES (184, '2022-03-07', 7, 'Castor Richardson	', '3472 Ullamcorper Street Lynchburg DC', 'EMP-0143', 'Shipped', 'EMS', 'Bank');
INSERT INTO `orderform` VALUES (185, '2022-03-09', 4, 'Colby Bernard', '7193 Ullamcorper Avenue Amesbury HI', 'EMP-0143', 'Shipped', 'EMS', 'VISA');
INSERT INTO `orderform` VALUES (186, '2022-03-09', 1, 'Iris Watson', '8562 Fusce Rd. Frederick Nebraska', 'EMP-0143', 'Shipped', 'EMS', 'Paypal');
INSERT INTO `orderform` VALUES (187, '2022-03-09', 10, 'Zephania	Sanders', '714 Nascetur St. Hawthorne Louisiana', 'EMP-0143', 'Shipped', 'Registered', 'Bank');
INSERT INTO `orderform` VALUES (188, '2022-03-12', 5, 'Noelle Adams', '6351 Fringilla Avenue Gardena Colorado', 'EMP-0143', 'Shipped', 'EMS', 'Paypal');
INSERT INTO `orderform` VALUES (189, '2022-03-12', 1, 'Iris Watson', '8562 Fusce Rd. Frederick Nebraska', 'EMP-0143', 'Shipped', 'EMS', 'Paypal');
INSERT INTO `orderform` VALUES (190, '2022-03-14', 9, 'Judith Floyd', '7936 Feugiat St. Williston Nevada', 'EMP-0143', 'Shipped', 'EMS', 'VISA');
INSERT INTO `orderform` VALUES (191, '2022-03-14', 5, 'Noelle Adams', '6351 Fringilla Avenue Gardena Colorado', 'EMP-0143', 'Shipped', 'EMS', 'Paypal');
INSERT INTO `orderform` VALUES (192, '2022-03-15', 10, 'Zephania	Sanders', '714 Nascetur St. Hawthorne Louisiana', 'EMP-0143', 'Shipped', 'Registered', 'Paypal');
INSERT INTO `orderform` VALUES (193, '2022-03-16', 5, 'Noelle Adams', '6351 Fringilla Avenue Gardena Colorado', 'EMP-0143', 'Shipped', 'EMS', 'Paypal');
INSERT INTO `orderform` VALUES (194, '2022-03-17', 2, 'Hiroko Potter', '2508 Dolor. Av. Muskegon KY', 'EMP-0143', 'Shipped', 'EMS', 'Paypal');
INSERT INTO `orderform` VALUES (195, '2022-03-18', 8, 'Raymond	Levy', '7006 Risus St. Beaumont New Mexico', 'EMP-0143', 'Shipped', 'EMS', 'Bank');
INSERT INTO `orderform` VALUES (196, '2022-03-19', 7, 'Castor Richardson', '3472 Ullamcorper Street Lynchburg DC', 'EMP-0143', 'Shipped', 'EMS', 'Paypal');
INSERT INTO `orderform` VALUES (222, '2022-03-26', 1, 'Iris Watson', ' 8562 Fusce Rd. Frederick Nebraska ', 'EMP-0187', 'Shipped', 'Registered', 'Paypal');
INSERT INTO `orderform` VALUES (223, '2022-03-26', 1, 'Iris Watson', ' 8562 Fusce Rd. Frederick Nebraska ', 'EMP-0187', 'Shipped', 'Registered', 'Paypal');
INSERT INTO `orderform` VALUES (224, '2022-03-26', 1, 'Iris Watson', ' 8562 Fusce Rd. Frederick Nebraska ', 'EMP-0199', 'Shipped', 'Registered', 'Bank');
INSERT INTO `orderform` VALUES (225, '2022-03-26', 1, 'Iris Watson', ' 8562 Fusce Rd. Frederick Nebraska ', '', 'Not Ready', 'Registered', 'Bank');
INSERT INTO `orderform` VALUES (226, '2022-03-26', 1, 'Iris Watson', ' 8562 Fusce Rd. Frederick Nebraska ', '', 'Not Ready', 'EMS', 'Bank');
INSERT INTO `orderform` VALUES (227, '2022-03-26', 1, 'Iris Watson', ' 8562 Fusce Rd. Frederick Nebraska ', '', 'Not Ready', 'EMS', 'Bank');
INSERT INTO `orderform` VALUES (228, '2022-03-26', 1, 'Iris Watson', ' 8562 Fusce Rd. Frederick Nebraska ', 'EMP-0143', 'Shipped', 'Registered', 'Paypal');
INSERT INTO `orderform` VALUES (229, '2022-03-26', 1, 'Iris Watson', ' 8562 Fusce Rd. Frederick Nebraska ', '', 'Not Ready', 'Registered', 'Bank');
INSERT INTO `orderform` VALUES (230, '2022-03-26', 1, 'Iris Watson', ' 8562 Fusce Rd. Frederick Nebraska ', '', 'Not Ready', 'Registered', 'Bank');
INSERT INTO `orderform` VALUES (231, '2022-03-26', 1, 'Iris Watson', ' 8562 Fusce Rd. Frederick Nebraska ', '', 'Not Ready', 'EMS', 'Paypal');
INSERT INTO `orderform` VALUES (232, '2022-03-26', 1, 'Iris Watson', '1234 sodsai, thailand', 'EMP-0290', 'Shipped', 'EMS', 'Bank');

-- --------------------------------------------------------

-- 
-- Table structure for table `product`
-- 

CREATE TABLE `product` (
  `id` int(11) NOT NULL auto_increment,
  `name` varchar(255) NOT NULL,
  `category` varchar(255) NOT NULL,
  `unitCost` double NOT NULL,
  `sellingPrice` double NOT NULL,
  `numberInStock` int(11) NOT NULL,
  `picture` varchar(255) NOT NULL,
  PRIMARY KEY  (`id`)
) ENGINE=MyISAM  DEFAULT CHARSET=utf8 AUTO_INCREMENT=49 ;

-- 
-- Dumping data for table `product`
-- 

INSERT INTO `product` VALUES (1, 'Tengen Uzui - Demon Slayer', 'Noru', 300, 500, 49, 'uzui-no.png');
INSERT INTO `product` VALUES (2, 'Hinata Shoyo - Haikyuu', 'Noru', 300, 500, 50, 'hina-no.png');
INSERT INTO `product` VALUES (3, 'Nanami Kento - Jujustu Kaisen', 'Nendoroid', 1000, 1800, 49, 'nanamin-nen.jpg');
INSERT INTO `product` VALUES (4, 'Katsuki Bakugo - My Hero Academia', 'Figure', 1900, 3500, 49, 'baku-fig.jpg');
INSERT INTO `product` VALUES (5, 'Izuku Midoriya - My Hero Academia', 'Figure', 1500, 3000, 50, 'mido-fig.jpg');
INSERT INTO `product` VALUES (6, 'Yoichi Isagi - Blue Lock', 'Standy', 250, 550, 49, 'isagi-stan.png');
INSERT INTO `product` VALUES (10, 'Toru Oikawa-Haikyuu', 'Noru', 300, 500, 50, 'oii-no.png');
INSERT INTO `product` VALUES (11, 'Kyojuto rengoju - Demon Slayer', 'Noru', 300, 500, 50, 'kyojuro-no.png');
INSERT INTO `product` VALUES (12, 'Levi Ackerman - Attack on Titan', 'Nendoroid', 1900, 2400, 48, 'levi-nen.jpg');
INSERT INTO `product` VALUES (22, 'Daiji Sawamura - Haikyuu', 'Noru', 300, 500, 50, 'daiji-no.png');
INSERT INTO `product` VALUES (21, 'Ryunosuke Tanake - Haikyuu', 'Noru', 300, 500, 50, 'tanake-no.png');
INSERT INTO `product` VALUES (20, 'Tetsuto Kuroo - Haikyuu', 'Noru', 300, 450, 50, 'kuro-no.png');
INSERT INTO `product` VALUES (19, 'Kenma Kozume - Haikyuu', 'Noru', 300, 560, 50, 'kenma-no.png');
INSERT INTO `product` VALUES (17, 'Toge Inumaki - Jujutsu Kaizen', 'Nendoroid', 1900, 2350, 50, 'inu-nen.jpg');
INSERT INTO `product` VALUES (18, 'Inosuke Hashibira - Demon Slayer', 'Figure', 2300, 4090, 50, 'inosuke-fig.jpg');
INSERT INTO `product` VALUES (23, 'Minato Namikaze -Naruto', 'Figure', 3900, 7500, 50, 'minato-fig.jpg');
INSERT INTO `product` VALUES (24, 'Zenitsu Agatsuma - Demon Slayer', 'Nendoroid', 1600, 2300, 50, 'zen-nen.jpg');
INSERT INTO `product` VALUES (25, 'Suguru Geto - Jujutsu Kaizen', 'Figure', 200, 3900, 50, 'keto-fig.jpg');
INSERT INTO `product` VALUES (26, 'Panda -Jujutsu Kaizen', 'Figure', 1900, 2500, 50, 'panda-fig.jpg');
INSERT INTO `product` VALUES (27, 'Sukuna - Jujutsu Kaien', 'Figure', 1900, 2500, 50, 'sukuna-fig.jpg');
INSERT INTO `product` VALUES (28, 'Ujiha Itaji - Naruto', 'Figure', 5670, 9800, 50, 'ita-fig.jpg');
INSERT INTO `product` VALUES (29, 'Hatake Kakashi - Naruto', 'Nendoroid', 1900, 3300, 50, 'kakashi-nen.jpg');
INSERT INTO `product` VALUES (30, 'Armin - attrack on Titan', 'Nendoroid', 1900, 3500, 50, 'armin-nen.jpg');
INSERT INTO `product` VALUES (31, 'Maruko - Maruko chan', 'Nendoroid', 1900, 2250, 50, 'maruko-nen.jpg');
INSERT INTO `product` VALUES (32, 'Yuta Okkotsu - Jujutsu Kaizen', 'Nendoroid', 1900, 3500, 50, 'yuta-nen.jpg');
INSERT INTO `product` VALUES (33, 'Shouei Barou - Blue Lock', 'Standy', 990, 1230, 50, 'barou-stan.jpg');
INSERT INTO `product` VALUES (34, 'Meguru Bachira - Blue Lock', 'Standy', 900, 1220, 50, 'bajira-stan.png');
INSERT INTO `product` VALUES (35, 'Edogawa Conan - Detective Conan', 'Standy', 990, 1340, 50, 'conan-stan.jpg');
INSERT INTO `product` VALUES (36, 'Shiki Ichinose - Tougen Anki', 'Standy', 990, 1450, 50, 'shiki-stan.jpg');
INSERT INTO `product` VALUES (37, 'Naito Mudano - Tougen Anki', 'Standy', 990, 1450, 50, 'anki-stan.jpg');
INSERT INTO `product` VALUES (38, 'Ichigo Kurosaki - Bleach', 'Standy', 1200, 2000, 50, 'ichigo-stan.jpg');
INSERT INTO `product` VALUES (39, 'Byakuya Kuchiki - Bleach', 'Standy', 1200, 2200, 50, 'byakuya-stan.jpg');
INSERT INTO `product` VALUES (40, 'Megumi Fushiguro - Jujustu Kaisen', 'Lookup', 900, 1450, 49, 'furo-look.jpg');
INSERT INTO `product` VALUES (41, 'Itadori Yuji - Jujustu Kaizen', 'Lookup', 900, 1450, 50, 'ita-look.jpg');
INSERT INTO `product` VALUES (42, 'Uzumaki Naruto - Naruto', 'Lookup', 900, 1450, 50, 'naru-look.jpg');
INSERT INTO `product` VALUES (43, 'Hatake Kakashi - Naruto', 'Lookup', 900, 1450, 50, 'kaka-look.jpg');
INSERT INTO `product` VALUES (44, 'Hinata Hyuga - Naruto', 'Lookup', 900, 1450, 50, 'hinata-look.jpg');
INSERT INTO `product` VALUES (45, 'Maki Zenin - Jujustu Kaizen', 'Lookup', 900, 1450, 50, 'maki-look.jpg');
INSERT INTO `product` VALUES (46, 'Law - One Piece', 'Lookup', 900, 1450, 50, 'law-look.jpg');
INSERT INTO `product` VALUES (47, 'Mitsuri Kanroji - Demon Salyer', 'Lookup', 900, 1450, 50, 'misturi-look.jpg');
INSERT INTO `product` VALUES (48, 'Saitama - One Puch Man', 'Nendoroid', 1900, 2450, 50, 'saitama-nen.jpg');

-- --------------------------------------------------------

-- 
-- Table structure for table `profile`
-- 

CREATE TABLE `profile` (
  `empId` char(10) NOT NULL,
  `username` varchar(255) NOT NULL,
  `firstname` varchar(255) NOT NULL,
  `lastname` varchar(255) NOT NULL,
  `role` varchar(255) NOT NULL,
  `email` varchar(255) NOT NULL,
  `phonenumber` varchar(255) NOT NULL,
  `gender` varchar(255) NOT NULL,
  `address` varchar(255) NOT NULL,
  `dateOfBirth` date NOT NULL,
  `photo` varchar(255) NOT NULL,
  PRIMARY KEY  (`empId`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- 
-- Dumping data for table `profile`
-- 

INSERT INTO `profile` VALUES ('EMP-0143', 'jamesmith', 'James', 'Smith', 'manager', 'jamess0099@gmail.com', '(492) 467-3131', 'Male', '887 Lobortis Ave Cudahy Ohio 31522', '1985-03-12', 'james.jpg');
INSERT INTO `profile` VALUES ('EMP-0187', 'lawrence_m', 'Lawrence', 'Moreno', 'manager', 'lawrence.m@gmail.com', '(888) 106-8550', 'Female', '6216 Aenean Avenue Seattle Utah 81202', '1991-08-11', 'lawrence.jpg');
INSERT INTO `profile` VALUES ('EMP-0290', 'harry-potter', 'Forrest', 'Ray', 'staff', 'forrest_pha@gmail.com', '(221) 156-5026', 'Male', '981 Eget Rd. Clemson GA 04645', '1985-07-19', 'forrest.jpg');
INSERT INTO `profile` VALUES ('EMP-0199', 'pillowcas_e', 'Emma', 'Greene', 'staff', 'emmag@gmail.com', '(414) 876-0865', 'Female', '6059 Sollicitudin Road Burlingame Colorado 26278', '1997-11-22', 'emma.jpg');
INSERT INTO `profile` VALUES ('EMP-0322', 'aot_ss4', 'Patrick', 'Holmes', 'staff', 'holmes_pt4487@gmail.com', '(622) 594-1662', 'Male', '7014 Amet Street Corona Oklahoma 55246', '1990-07-07', 'patrick.jpg');
