 -- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Anamakine: 127.0.0.1
-- Üretim Zamanı: 02 May 2024, 19:52:49
-- Sunucu sürümü: 10.4.27-MariaDB
-- PHP Sürümü: 7.4.33

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Veritabanı: `etic`
--

DELIMITER $$
--
-- Yordamlar
--
CREATE DEFINER=`root`@`localhost` PROCEDURE `getcat` (IN `cid` INT)   SELECT * FROM categories WHERE cat_id=cid$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `admin_info`
--

CREATE TABLE `admin_info` (
  `admin_id` int(10) NOT NULL,
  `admin_name` varchar(100) NOT NULL,
  `admin_email` varchar(300) NOT NULL,
  `admin_password` varchar(300) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Tablo döküm verisi `admin_info`
--

INSERT INTO `admin_info` (`admin_id`, `admin_name`, `admin_email`, `admin_password`) VALUES
(1, 'admin', 'admin@gmail.com', '25f9e794323b453885f5181f1b624d0b');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `cart`
--

CREATE TABLE `cart` (
  `id` int(10) NOT NULL,
  `p_id` int(10) NOT NULL,
  `ip_add` varchar(250) NOT NULL,
  `user_id` int(10) DEFAULT NULL,
  `qty` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Tablo döküm verisi `cart`
--

INSERT INTO `cart` (`id`, `p_id`, `ip_add`, `user_id`, `qty`) VALUES
(6, 26, '::1', 4, 1),
(9, 10, '::1', 7, 1),
(11, 45, '::1', 7, 1),
(48, 72, '::1', 3, 0),
(49, 60, '::1', 8, 1),
(50, 61, '::1', 8, 1),
(51, 1, '::1', 8, 1),
(56, 1, '::1', 9, 1),
(71, 61, '127.0.0.1', -1, 1);

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `categories`
--

CREATE TABLE `categories` (
  `cat_id` int(100) NOT NULL,
  `cat_title` mediumtext NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Tablo döküm verisi `categories`
--

INSERT INTO `categories` (`cat_id`, `cat_title`) VALUES
(1, 'Sweatshirt'),
(2, 'Esofman'),
(3, 'Tisört'),
(4, 'Mont'),
(5, 'Ayakkabi'),
(6, 'Kemer');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `email_info`
--

CREATE TABLE `email_info` (
  `email_id` int(100) NOT NULL,
  `email` mediumtext NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Tablo döküm verisi `email_info`
--

INSERT INTO `email_info` (`email_id`, `email`) VALUES
(3, 'admin@gmail.com'),
(4, 'puneethreddy951@gmail.com'),
(5, 'puneethreddy@gmail.com');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `logs`
--

CREATE TABLE `logs` (
  `id` int(11) NOT NULL,
  `user_id` varchar(50) NOT NULL,
  `action` varchar(50) NOT NULL,
  `date` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `orders`
--

CREATE TABLE `orders` (
  `order_id` int(11) NOT NULL,
  `user_id` int(11) NOT NULL,
  `product_id` int(11) NOT NULL,
  `qty` int(11) NOT NULL,
  `trx_id` varchar(255) NOT NULL,
  `p_status` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Tablo döküm verisi `orders`
--

INSERT INTO `orders` (`order_id`, `user_id`, `product_id`, `qty`, `trx_id`, `p_status`) VALUES
(5, 3, 1, 1, 'ere3434', 'Completed');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `orders_info`
--

CREATE TABLE `orders_info` (
  `order_id` int(10) NOT NULL,
  `user_id` int(11) NOT NULL,
  `f_name` varchar(255) NOT NULL,
  `email` varchar(255) NOT NULL,
  `address` varchar(255) NOT NULL,
  `city` varchar(255) NOT NULL,
  `state` varchar(255) NOT NULL,
  `zip` int(10) NOT NULL,
  `cardname` varchar(255) NOT NULL,
  `cardnumber` varchar(20) NOT NULL,
  `expdate` varchar(255) NOT NULL,
  `prod_count` int(15) DEFAULT NULL,
  `total_amt` int(15) DEFAULT NULL,
  `cvv` int(5) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Tablo döküm verisi `orders_info`
--

INSERT INTO `orders_info` (`order_id`, `user_id`, `f_name`, `email`, `address`, `city`, `state`, `zip`, `cardname`, `cardnumber`, `expdate`, `prod_count`, `total_amt`, `cvv`) VALUES
(1, 12, 'Puneeth', 'puneethreddy951@gmail.com', 'Bangalore, Kumbalagodu, Karnataka', 'Bangalore', 'Karnataka', 560074, 'pokjhgfcxc', '4321 2345 6788 7654', '12/90', 3, 77000, 1234),
(2, 26, 'Nissim', 'somepuco@mailinator.com', 'Molestiae quia quibu', 'Dolore quo aut est d', 'Quasi ea facilis qua', 18070, 'Colt Cook', '783', '11/29', 1, 5000, 123),
(3, 26, 'Aladdin', 'qipevibiso@mailinator.com', 'Sed nobis minima cul', 'Eum quis a dolor aut', 'Non fugit nihil qui', 69272, 'Jerome Owens', '845', '12/27', 1, 600, 12),
(4, 0, 'Paula', 'ficupymi@mailinator.com', 'Consequatur Sint d', 'Qui recusandae Beat', 'Et dolor sunt dolor', 92479, 'Fulton Reynolds', '115', '12/22', 3, 87000, 232),
(5, 0, 'Kitra', 'cihekani@mailinator.com', 'Est optio ipsa lab', 'Fuga Repudiandae qu', 'Adipisci minim aut i', 56717, 'Shelly Burnett', '219', '12/25', 3, 3700, 333),
(6, 0, 'Hayden', 'delafocy@mailinator.com', 'Reprehenderit volupt', 'Distinctio Amet co', 'Laborum numquam illo', 56685, 'Amir Fernandez', '908', '12/25', 2, 55000, 123),
(7, 0, 'Edward', 'zixunov@mailinator.com', 'Quasi eius dolorem a', 'Officiis occaecat pr', 'Et eos optio aut la', 14522, 'Marvin Moran', '566', '12/24', 2, 1440, 222),
(8, 0, 'Benjamin', 'xuvuquz@mailinator.com', 'Molestias voluptas e', 'Consequatur Labore ', 'Impedit dolores nih', 83747, 'Beau Mack', '530', '12/25', 1, 10000, 222),
(9, 0, 'Miranda', 'qysyvu@mailinator.com', 'Soluta enim itaque e', 'Sint nihil delectus', 'Voluptate voluptatem', 60880, 'Joel Conway', '154', '12/25', 1, 555, 222),
(10, 0, 'Hadley', 'lycizopop@mailinator.com', 'Esse ipsa culpa se', 'Ducimus ad aliquip ', 'Voluptate commodi qu', 52775, 'Evelyn Strickland', '201', '12/24', 1, 250, 111),
(11, 0, 'Kay', 'lymidycyl@mailinator.com', 'Consequuntur officia', 'Est optio iste cupi', 'Iste ad possimus si', 54825, 'Carly Lee', '737', '12/25', 1, 50000, 222),
(12, 0, 'Darius', 'nigavefu@mailinator.com', 'Eu neque dolorum har', 'Autem dolore amet v', 'Saepe perspiciatis ', 96214, 'Rhonda Edwards', '437', '12/26', 2, 2055, 222),
(13, 0, 'Ocean', 'cabuqat@mailinator.com', 'Non nobis illum dol', 'Asperiores voluptas ', 'Perferendis aute ut ', 72233, 'Lacy Padilla', '59', '12/25', 1, 55, 111),
(14, 0, 'Rhona', 'gafukefag@mailinator.com', 'Aut qui aliquip fuga', 'Deleniti quis non ve', 'Consequatur ab saepe', 31998, 'Sage Hubbard', '818', '12/25', 1, 5000, 222),
(15, 0, 'Montana', 'tyrotacu@mailinator.com', 'Magnam ipsum totam ', 'Ut necessitatibus it', 'Officia qui molestia', 78600, 'MacKenzie Lott', '971', '12/55', 1, 31, 222),
(16, 0, 'Hayley', 'tykuzala@mailinator.com', 'Ea sit tempore rer', 'Doloremque qui qui e', 'Irure molestiae inci', 66548, 'Yoshi Reilly', '451', '12/55', 1, 31, 555),
(17, 0, 'Leslie', 'ciwol@mailinator.com', 'Totam dolorem beatae', 'Exercitationem aperi', 'Excepturi adipisci o', 94764, 'Richard Pope', '473', '12/55', 1, 31, 555),
(18, 0, 'Tana', 'fuceg@mailinator.com', 'Eum perspiciatis na', 'Pariatur Deleniti m', 'Vel aliquid sunt la', 19596, 'Jacob Ward', '260', '12/31', 1, 31, 333),
(19, 27, 'Sawyer', 'sofojej@mailinator.com', 'Doloribus dolores eo', 'In veniam laudantiu', 'Sunt occaecat solut', 59395, 'Tyler Morris', '138', '12/34', 1, 250, 121),
(20, 27, 'Jorden', 'zudymese@mailinator.com', 'Totam magna dolorum ', 'Vero sunt beatae mol', 'Provident eligendi ', 68818, 'Kato Levy', '738', '12/35', 1, 31, 888),
(21, 27, 'Rhonda', 'ruvony@mailinator.com', 'Laboriosam qui lore', 'Est quidem nobis sae', 'Accusamus ipsa impe', 28543, 'Vance Gutierrez', '997', '12/29', 1, 1, 111),
(22, 28, 'Kaye', 'wipajoriro@mailinator.com', 'Sed quidem et non iu', 'Quibusdam praesentiu', 'Quis nobis aut imped', 87459, 'Alana Walls', '954', '12/32', 1, 31, 999);

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `order_products`
--

CREATE TABLE `order_products` (
  `order_pro_id` int(10) NOT NULL,
  `order_id` int(11) NOT NULL,
  `product_id` int(11) NOT NULL,
  `qty` int(15) DEFAULT NULL,
  `amt` int(15) DEFAULT NULL,
  `create_date` datetime NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Tablo döküm verisi `order_products`
--

INSERT INTO `order_products` (`order_pro_id`, `order_id`, `product_id`, `qty`, `amt`, `create_date`) VALUES
(73, 1, 1, 1, 5000, '2024-03-28 22:54:18'),
(74, 1, 4, 2, 64000, '2024-03-28 22:54:18'),
(75, 1, 8, 1, 40000, '2024-03-28 22:54:18'),
(91, 2, 1, 1, 5000, '2024-03-28 22:54:18'),
(92, 3, 16, 1, 600, '2024-03-28 22:54:18'),
(93, 4, 2, 1, 25000, '2024-03-28 22:54:18'),
(94, 4, 3, 1, 30000, '2024-03-28 22:54:18'),
(95, 4, 4, 1, 32000, '2024-03-28 22:54:18'),
(96, 5, 11, 1, 1200, '2024-03-28 22:54:18'),
(97, 5, 10, 1, 1000, '2024-03-28 22:54:18'),
(98, 5, 12, 1, 1500, '2024-03-28 22:54:18'),
(99, 6, 2, 1, 25000, '2024-03-28 22:54:35'),
(100, 6, 3, 1, 30000, '2024-03-28 22:54:35'),
(101, 7, 15, 1, 690, '2024-03-28 23:19:57'),
(102, 7, 25, 1, 750, '2024-03-28 23:19:57'),
(103, 8, 45, 1, 10000, '2024-03-28 23:20:25'),
(104, 9, 86, 1, 555, '2024-03-29 00:39:28'),
(105, 10, 48, 1, 250, '2024-04-01 02:12:38'),
(106, 11, 1, 1, 50000, '2024-04-01 02:14:32'),
(107, 12, 86, 1, 555, '2024-04-13 14:26:51'),
(108, 12, 15, 1, 1500, '2024-04-13 14:26:51'),
(109, 13, 88, 1, 55, '2024-04-13 14:28:41'),
(110, 14, 71, 1, 5000, '2024-04-13 14:33:12'),
(111, 15, 89, 1, 31, '2024-04-13 14:38:03'),
(112, 16, 89, 1, 0, '2024-04-13 14:49:05'),
(113, 17, 89, 1, 0, '2024-04-13 14:56:11'),
(114, 18, 89, 1, 0, '2024-04-13 15:44:16'),
(115, 19, 48, 1, 0, '2024-04-13 15:54:55'),
(116, 20, 89, 1, 0, '2024-04-13 15:56:30'),
(118, 22, 89, 1, 0, '2024-04-14 01:12:07');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `products`
--

CREATE TABLE `products` (
  `product_id` int(100) NOT NULL,
  `product_cat` int(100) NOT NULL,
  `product_stock` int(11) NOT NULL DEFAULT 0,
  `product_title` varchar(255) NOT NULL,
  `product_price` int(100) NOT NULL,
  `product_desc` mediumtext NOT NULL,
  `product_image` mediumtext NOT NULL,
  `product_keywords` mediumtext NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Tablo döküm verisi `products`
--

INSERT INTO `products` (`product_id`, `product_cat`, `product_stock`, `product_title`, `product_price`, `product_desc`, `product_image`, `product_keywords`) VALUES
(1, 1, 5, 'Samsung galaxy s7 edge', 50000, 'deneme', 'default.png', 'samsung mobile electronics'),
(2, 1, 5, 'iPhone 5s', 25000, 'iphone 5s', 'default.png', 'mobile iphone apple'),
(3, 1, 5, 'iPad air 2', 30000, 'ipad apple brand', 'da4371ffa192a115f922b1c0dff88193.png', 'apple ipad tablet'),
(4, 1, 0, 'iPhone 6s', 32000, 'Apple iPhone ', 'http___pluspng.com_img-png_iphone-6s-png-iphone-6s-gold-64gb-1000.png', 'iphone apple mobile'),
(5, 1, 0, 'iPad 2', 10000, 'samsung ipad', 'iPad-air.png', 'ipad tablet samsung'),
(6, 1, 0, 'samsung Laptop r series', 35000, 'samsung Black combination Laptop', 'laptop_PNG5939.png', 'samsung laptop '),
(7, 1, 0, 'Laptop Pavillion', 50000, 'Laptop Hp Pavillion', 'laptop_PNG5930.png', 'Laptop Hp Pavillion'),
(8, 1, 0, 'Sony', 40000, 'Sony Mobile', '530201353846AM_635_sony_xperia_z.png', 'sony mobile'),
(9, 1, 0, 'iPhone New', 12000, 'iphone', 'iphone-hd-png-iphone-apple-png-file-550.png', 'iphone apple mobile'),
(10, 2, 0, 'Red Ladies dress', 1000, 'red dress for girls', 'red dress.jpg', 'red dress '),
(11, 2, 0, 'Blue Heave dress', 1200, 'Blue dress', 'images.jpg', 'blue dress cloths'),
(12, 2, 0, 'Ladies Casual Cloths', 1500, 'ladies casual summer two colors pleted', '7475-ladies-casual-dresses-summer-two-colors-pleated.jpg', 'girl dress cloths casual'),
(13, 2, 0, 'SpringAutumnDress', 1200, 'girls dress', 'Spring-Autumn-Winter-Young-Ladies-Casual-Wool-Dress-Women-s-One-Piece-Dresse-Dating-Clothes-Medium.jpg_640x640.jpg', 'girl dress'),
(14, 2, 0, 'Casual Dress', 1400, 'girl dress', 'download.jpg', 'ladies cloths girl'),
(15, 2, 5, 'Formal Look', 1500, 'girl dress', 'shutterstock_203611819.jpg', 'ladies wears dress girl'),
(16, 3, 0, 'Sweter for men', 600, '2012-Winter-Sweater-for-Men-for-better-outlook', '2012-Winter-Sweater-for-Men-for-better-outlook.jpg', 'black sweter cloth winter'),
(17, 3, 0, 'Gents formal', 1000, 'gents formal look', 'gents-formal-250x250.jpg', 'gents wear cloths'),
(19, 3, 0, 'Formal Coat', 3000, 'ad', 'images (1).jpg', 'coat blazer gents'),
(20, 3, 0, 'Mens Sweeter', 1600, 'jg', 'Winter-fashion-men-burst-sweater.png', 'sweeter gents '),
(21, 3, 0, 'T shirt', 800, 'ssds', 'IN-Mens-Apparel-Voodoo-Tiles-09._V333872612_.jpg', 'formal t shirt black'),
(22, 4, 0, 'Yellow T shirt ', 1300, 'yello t shirt with pant', '1.0x0.jpg', 'kids yellow t shirt'),
(23, 4, 0, 'Girls cloths', 1900, 'sadsf', 'GirlsClothing_Widgets.jpg', 'formal kids wear dress'),
(24, 4, 0, 'Blue T shirt', 700, 'g', 'images.jpg', 'kids dress'),
(25, 4, 0, 'Yellow girls dress', 750, 'as', 'images (3).jpg', 'yellow kids dress'),
(27, 4, 0, 'Formal look', 690, 'sd', 'image28.jpg', 'formal kids dress'),
(32, 5, 0, 'Book Shelf', 2500, 'book shelf', 'furniture-book-shelf-250x250.jpg', 'book shelf furniture'),
(33, 6, 0, 'Refrigerator', 35000, 'Refrigerator', 'CT_WM_BTS-BTC-AppliancesHome_20150723.jpg', 'refrigerator samsung'),
(34, 6, 0, 'Emergency Light', 1000, 'Emergency Light', 'emergency light.JPG', 'emergency light'),
(35, 6, 0, 'Vaccum Cleaner', 6000, 'Vaccum Cleaner', 'images (2).jpg', 'Vaccum Cleaner'),
(36, 6, 0, 'Iron', 1500, 'gj', 'iron.JPG', 'iron'),
(37, 6, 0, 'LED TV', 20000, 'LED TV', 'images (4).jpg', 'led tv lg'),
(38, 6, 0, 'Microwave Oven', 3500, 'Microwave Oven', 'images.jpg', 'Microwave Oven'),
(39, 6, 0, 'Mixer Grinder', 2500, 'Mixer Grinder', 'singer-mixer-grinder-mg-46-medium_4bfa018096c25dec7ba0af40662856ef.jpg', 'Mixer Grinder'),
(40, 2, 0, 'Formal girls dress', 3000, 'Formal girls dress', 'girl-walking.jpg', 'ladies'),
(45, 1, 0, 'Samsung Galaxy Note 3', 10000, '0', 'samsung_galaxy_note3_note3neo.JPG', 'samsung galaxy Note 3 neo'),
(46, 1, 0, 'Samsung Galaxy Note 3', 10000, '', 'samsung_galaxy_note3_note3neo.JPG', 'samsung galxaxy note 3 neo'),
(47, 4, 0, 'Laptop', 650, 'nbk', 'product01.png', 'Dell Laptop'),
(48, 1, 0, 'Headphones', 250, 'Headphones', 'product05.png', 'Headphones Sony'),
(49, 1, 1, 'Headphones', 250, 'Headphones', 'product05.png', 'Headphones Sony'),
(50, 3, 0, 'boys shirts', 350, 'shirts', 'pm1.JPG', 'suit boys shirts'),
(51, 3, 0, 'boys shirts', 270, 'shirts', 'pm2.JPG', 'suit boys shirts'),
(52, 3, 0, 'boys shirts', 453, 'shirts', 'pm3.JPG', 'suit boys shirts'),
(53, 3, 0, 'boys shirts', 220, 'shirts', 'ms1.JPG', 'suit boys shirts'),
(54, 3, 0, 'boys shirts', 290, 'shirts', 'ms2.JPG', 'suit boys shirts'),
(55, 3, 0, 'boys shirts', 259, 'shirts', 'ms3.JPG', 'suit boys shirts'),
(56, 3, 0, 'boys shirts', 299, 'shirts', 'pm7.JPG', 'suit boys shirts'),
(57, 3, 0, 'boys shirts', 260, 'shirts', 'i3.JPG', 'suit boys shirts'),
(58, 3, 0, 'boys shirts', 350, 'shirts', 'pm9.JPG', 'suit boys shirts'),
(59, 3, 0, 'boys shirts', 855, 'shirts', 'a2.JPG', 'suit boys shirts'),
(60, 3, 0, 'boys shirts', 150, 'shirts', 'pm11.JPG', 'suit boys shirts'),
(61, 3, 0, 'boys shirts', 215, 'shirts', 'pm12.JPG', 'suit boys shirts'),
(62, 3, 0, 'boys shirts', 299, 'shirts', 'pm13.JPG', 'suit boys shirts'),
(63, 3, 0, 'boys Jeans Pant', 550, 'Pants', 'pt1.JPG', 'boys Jeans Pant'),
(64, 3, 0, 'boys Jeans Pant', 460, 'pants', 'pt2.JPG', 'boys Jeans Pant'),
(65, 3, 0, 'boys Jeans Pant', 470, 'pants', 'pt3.JPG', 'boys Jeans Pant'),
(66, 3, 0, 'boys Jeans Pant', 480, 'pants', 'pt4.JPG', 'boys Jeans Pant'),
(67, 3, 0, 'boys Jeans Pant', 360, 'pants', 'pt5.JPG', 'boys Jeans Pant'),
(68, 3, 0, 'boys Jeans Pant', 550, 'pants', 'pt6.JPG', 'boys Jeans Pant'),
(69, 3, 0, 'boys Jeans Pant', 390, 'pants', 'pt7.JPG', 'boys Jeans Pant'),
(70, 3, 0, 'boys Jeans Pant', 399, 'pants', 'pt8.JPG', 'boys Jeans Pant'),
(71, 1, 0, 'Samsung galaxy s7', 5000, 'Samsung galaxy s7', 'product07.png', 'samsung mobile electronics'),


-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `user_info`
--

CREATE TABLE `user_info` (
  `user_id` int(10) NOT NULL,
  `first_name` varchar(100) NOT NULL,
  `last_name` varchar(100) NOT NULL,
  `email` varchar(300) NOT NULL,
  `password` varchar(300) NOT NULL,
  `mobile` varchar(10) NOT NULL,
  `address1` varchar(300) NOT NULL,
  `address2` varchar(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Tablo döküm verisi `user_info`
--

INSERT INTO `user_info` (`user_id`, `first_name`, `last_name`, `email`, `password`, `mobile`, `address1`, `address2`) VALUES
(12, 'puneeth', 'Reddy', 'puneethreddy951@gmail.com', 'puneeth', '9448121558', '123456789', 'sdcjns,djc'),
(15, 'hemu', 'ajhgdg', 'puneethreddy951@gmail.com', '346778', '536487276', ',mdnbca', 'asdmhmhvbv'),
(16, 'venky', 'vs', 'venkey@gmail.com', '1234534', '9877654334', 'snhdgvajfehyfygv', 'asdjbhfkeur'),
(19, 'abhishek', 'bs', 'abhishekbs@gmail.com', 'asdcsdcc', '9871236534', 'bangalore', 'hassan'),
(21, 'prajval', 'mcta', 'prajvalmcta@gmail.com', '1234545662', '202-555-01', 'bangalore', 'kumbalagodu'),
(22, 'puneeth', 'v', 'hemu@gmail.com', '1234534', '9877654334', 'snhdgvajfehyfygv', 'asdjbhfkeur'),
(23, 'hemanth', 'reddy', 'hemanth@gmail.com', 'Puneeth@123', '9876543234', 'Bangalore', 'Kumbalagodu'),
(24, 'newuser', 'user', 'newuser@gmail.com', 'puneeth@123', '9535688928', 'Bangalore', 'Kumbalagodu'),
(25, 'otheruser', 'user', 'otheruser@gmail.com', 'puneeth@123', '9535688928', 'Bangalore', 'Kumbalagodu'),
(26, 'admin', 'admin', 'admin@admin.com', 'admin123.', '1234567890', 'asd', 'asd'),
(27, 'Stephen Rosa', 'Ahmed Peck', 'xoxecygike@mailinator.com', 'Pa$$w0rd!', '0555555555', '606 White Second Parkway', 'Molestiae r'),
(28, 'Kaitlin Carlson', 'Cullen Romero', 'maxem@mailinator.com', 'Pa$$w0rd!', '0123456789', '273 Clarendon Parkway', 'Reprehender');

--
-- Tetikleyiciler `user_info`
--
DELIMITER $$
CREATE TRIGGER `after_user_info_insert` AFTER INSERT ON `user_info` FOR EACH ROW BEGIN 
INSERT INTO user_info_backup VALUES(new.user_id,new.first_name,new.last_name,new.email,new.password,new.mobile,new.address1,new.address2);
END
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `user_info_backup`
--

CREATE TABLE `user_info_backup` (
  `user_id` int(10) NOT NULL,
  `first_name` varchar(100) NOT NULL,
  `last_name` varchar(100) NOT NULL,
  `email` varchar(300) NOT NULL,
  `password` varchar(300) NOT NULL,
  `mobile` varchar(10) NOT NULL,
  `address1` varchar(300) NOT NULL,
  `address2` varchar(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Tablo döküm verisi `user_info_backup`
--

INSERT INTO `user_info_backup` (`user_id`, `first_name`, `last_name`, `email`, `password`, `mobile`, `address1`, `address2`) VALUES
(23, 'hemanth', 'reddy', 'hemanth@gmail.com', 'Puneeth@123', '9876543234', 'Bangalore', 'Kumbalagodu'),
(24, 'newuser', 'user', 'newuser@gmail.com', 'puneeth@123', '9535688928', 'Bangalore', 'Kumbalagodu'),
(25, 'otheruser', 'user', 'otheruser@gmail.com', 'puneeth@123', '9535688928', 'Bangalore', 'Kumbalagodu'),
(26, 'admin', 'admin', 'admin@admin.com', 'admin123.', '1234567890', 'asd', 'asd'),
(27, 'Stephen Rosa', 'Ahmed Peck', 'xoxecygike@mailinator.com', 'Pa$$w0rd!', '0555555555', '606 White Second Parkway', 'Molestiae r'),
(28, 'Kaitlin Carlson', 'Cullen Romero', 'maxem@mailinator.com', 'Pa$$w0rd!', '0123456789', '273 Clarendon Parkway', 'Reprehender');

--
-- Dökümü yapılmış tablolar için indeksler
--

--
-- Tablo için indeksler `admin_info`
--
ALTER TABLE `admin_info`
  ADD PRIMARY KEY (`admin_id`);

--
-- Tablo için indeksler `cart`
--
ALTER TABLE `cart`
  ADD PRIMARY KEY (`id`);

--
-- Tablo için indeksler `categories`
--
ALTER TABLE `categories`
  ADD PRIMARY KEY (`cat_id`);

--
-- Tablo için indeksler `email_info`
--
ALTER TABLE `email_info`
  ADD PRIMARY KEY (`email_id`);

--
-- Tablo için indeksler `logs`
--
ALTER TABLE `logs`
  ADD PRIMARY KEY (`id`);

--
-- Tablo için indeksler `orders`
--
ALTER TABLE `orders`
  ADD PRIMARY KEY (`order_id`);

--
-- Tablo için indeksler `orders_info`
--
ALTER TABLE `orders_info`
  ADD PRIMARY KEY (`order_id`),
  ADD KEY `user_id` (`user_id`);

--
-- Tablo için indeksler `order_products`
--
ALTER TABLE `order_products`
  ADD PRIMARY KEY (`order_pro_id`),
  ADD KEY `order_products` (`order_id`),
  ADD KEY `product_id` (`product_id`);

--
-- Tablo için indeksler `products`
--
ALTER TABLE `products`
  ADD PRIMARY KEY (`product_id`);

--
-- Tablo için indeksler `user_info`
--
ALTER TABLE `user_info`
  ADD PRIMARY KEY (`user_id`);

--
-- Tablo için indeksler `user_info_backup`
--
ALTER TABLE `user_info_backup`
  ADD PRIMARY KEY (`user_id`);

--
-- Dökümü yapılmış tablolar için AUTO_INCREMENT değeri
--

--
-- Tablo için AUTO_INCREMENT değeri `admin_info`
--
ALTER TABLE `admin_info`
  MODIFY `admin_id` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- Tablo için AUTO_INCREMENT değeri `cart`
--
ALTER TABLE `cart`
  MODIFY `id` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=94;

--
-- Tablo için AUTO_INCREMENT değeri `categories`
--
ALTER TABLE `categories`
  MODIFY `cat_id` int(100) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- Tablo için AUTO_INCREMENT değeri `email_info`
--
ALTER TABLE `email_info`
  MODIFY `email_id` int(100) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- Tablo için AUTO_INCREMENT değeri `logs`
--
ALTER TABLE `logs`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- Tablo için AUTO_INCREMENT değeri `orders`
--
ALTER TABLE `orders`
  MODIFY `order_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- Tablo için AUTO_INCREMENT değeri `orders_info`
--
ALTER TABLE `orders_info`
  MODIFY `order_id` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=23;

--
-- Tablo için AUTO_INCREMENT değeri `order_products`
--
ALTER TABLE `order_products`
  MODIFY `order_pro_id` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=119;

--
-- Tablo için AUTO_INCREMENT değeri `products`
--
ALTER TABLE `products`
  MODIFY `product_id` int(100) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=92;

--
-- Tablo için AUTO_INCREMENT değeri `user_info`
--
ALTER TABLE `user_info`
  MODIFY `user_id` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=29;

--
-- Tablo için AUTO_INCREMENT değeri `user_info_backup`
--
ALTER TABLE `user_info_backup`
  MODIFY `user_id` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=29;

--
-- Dökümü yapılmış tablolar için kısıtlamalar
--

--
-- Tablo kısıtlamaları `order_products`
--
ALTER TABLE `order_products`
  ADD CONSTRAINT `order_products` FOREIGN KEY (`order_id`) REFERENCES `orders_info` (`order_id`) ON DELETE NO ACTION ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
