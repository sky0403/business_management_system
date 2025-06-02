-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- 主機： 127.0.0.1:3307
-- 產生時間： 2022-07-11 21:57:06
-- 伺服器版本： 10.4.24-MariaDB
-- PHP 版本： 8.1.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- 資料庫： `betterlimited`
--

-- --------------------------------------------------------

--
-- 資料表結構 `account`
--

CREATE TABLE `account` (
  `StaffID` varchar(50) NOT NULL,
  `Password` varchar(50) NOT NULL,
  `Name` varchar(255) NOT NULL,
  `PhoneNum` int(100) NOT NULL,
  `Department` varchar(30) NOT NULL,
  `Lock` int(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- 傾印資料表的資料 `account`
--

INSERT INTO `account` (`StaffID`, `Password`, `Name`, `PhoneNum`, `Department`, `Lock`) VALUES
('S001', '123456', 'Sky', 12345678, 'CEO', 0),
('S003', '123456', 'Hello', 12345678, 'Sales', 0),
('S004', '123456', 'Sky', 12345678, 'Delivery Work Man', 0),
('S006', '123456', 'Tom', 12345678, 'Delivery Work Man', 0),
('S007', '123456', 'haha', 12345678, 'Delivery Work Man', 0);

-- --------------------------------------------------------

--
-- 資料表結構 `cart`
--

CREATE TABLE `cart` (
  `Order_ID` varchar(255) NOT NULL,
  `CartID` int(8) NOT NULL,
  `Item_ID` varchar(50) NOT NULL,
  `Qty` int(10) NOT NULL,
  `Price` double NOT NULL,
  `Availability` char(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- 資料表結構 `customer`
--

CREATE TABLE `customer` (
  `Customer_Email` varchar(50) NOT NULL,
  `Customer_Name` varchar(100) NOT NULL,
  `Phone_Number` varchar(100) DEFAULT NULL,
  `Address` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- 傾印資料表的資料 `customer`
--

INSERT INTO `customer` (`Customer_Email`, `Customer_Name`, `Phone_Number`, `Address`) VALUES
('abc1234@gmail.com', 'tom', '12345678', 'HAHA HK'),
('abc123@gmail.com', 'Tom', '12345678', 'Tuen Mun Plaza'),
('abcd1234@gmail.com', 'Tommy', '12345767', 'Stress 48 hk'),
('hfgdsh@gmail.com', 'sadsad', '12345678', 'asd'),
('sad@sad.com', 'sad', '12345678', ''),
('sam123@gmail.com', 'Sam', '10325667', ''),
('sky@gmail.com', 'sky', '12345678', '');

-- --------------------------------------------------------

--
-- 資料表結構 `defectitem`
--

CREATE TABLE `defectitem` (
  `DefectID` varchar(50) NOT NULL,
  `Order_ID` varchar(50) NOT NULL,
  `Item_ID` varchar(50) NOT NULL,
  `Customer_Email` varchar(50) NOT NULL,
  `Quantity` int(50) NOT NULL,
  `DefectDate` date NOT NULL,
  `Reason` varchar(255) NOT NULL,
  `Opened` char(1) NOT NULL,
  `Detail` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- 傾印資料表的資料 `defectitem`
--

INSERT INTO `defectitem` (`DefectID`, `Order_ID`, `Item_ID`, `Customer_Email`, `Quantity`, `DefectDate`, `Reason`, `Opened`, `Detail`) VALUES
('DE0001', 'OD000003', 'P000004', 'abc123@gmail.com', 4, '2022-06-29', 'Faulty', 'Y', 'Faulty or other details');

-- --------------------------------------------------------

--
-- 資料表結構 `delivery`
--

CREATE TABLE `delivery` (
  `Deli_ID` varchar(50) NOT NULL,
  `Order_ID` varchar(50) NOT NULL,
  `Address` varchar(255) NOT NULL,
  `Delivery_Date` date DEFAULT NULL,
  `Delivery_Session` varchar(50) DEFAULT NULL,
  `Status` varchar(20) NOT NULL,
  `Delivery_workman` varchar(10) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- 傾印資料表的資料 `delivery`
--

INSERT INTO `delivery` (`Deli_ID`, `Order_ID`, `Address`, `Delivery_Date`, `Delivery_Session`, `Status`, `Delivery_workman`) VALUES
('DL00001', 'OD000001', 'Tuen Mun Plaza', '2022-06-30', 'Evening(6:00pm – 10:00pm)', 'Finish', 'S004'),
('DL00002', 'OD000002', 'Stress 48 hk', '2022-07-06', 'Afternoon (1:00pm – 5:00pm)', 'Finish', 'S006'),
('DL00003', 'OD000003', 'Tuen Mun Plaza', '2022-06-30', 'Evening(6:00pm – 10:00pm)', 'Finish', 'S007'),
('DL00004', 'OD000004', 'Tuen Mun Plaza', '2022-07-12', 'Afternoon (1:00pm – 5:00pm)', 'Processing', 'S004'),
('DL00005', 'OD000005', 'stress 48', '2022-07-12', 'Afternoon (1:00pm – 5:00pm)', 'Finish', 'S006'),
('DL00006', 'OD000006', 'stress 48', '2022-07-12', 'Afternoon (1:00pm – 5:00pm)', 'Processing', 'S007');

-- --------------------------------------------------------

--
-- 資料表結構 `installation`
--

CREATE TABLE `installation` (
  `Install_ID` varchar(50) NOT NULL,
  `Order_ID` varchar(255) NOT NULL,
  `Address` varchar(255) NOT NULL,
  `Installation_Date` date NOT NULL,
  `Installation_Time` time DEFAULT NULL,
  `Status` varchar(20) NOT NULL,
  `Installation_Workman` varchar(10) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- 傾印資料表的資料 `installation`
--

INSERT INTO `installation` (`Install_ID`, `Order_ID`, `Address`, `Installation_Date`, `Installation_Time`, `Status`, `Installation_Workman`) VALUES
('IS00001', 'OD000001', 'Tuen Mun Plaza', '2022-07-01', '12:00:00', 'Finish', 'S005'),
('IS00002', 'OD000002', 'Stress 48 hk', '2022-07-06', '19:00:00', 'Finish', 'S005'),
('IS00003', 'OD000003', 'Tuen Mun Plaza', '2022-07-01', '12:00:00', 'Finish', 'S005'),
('IS00004', 'OD000004', 'Tuen Mun Plaza', '2022-06-30', '00:00:00', 'Finish', ''),
('IS00005', 'OD000005', '', '2022-07-14', '19:00:00', 'Processing', NULL),
('IS00006', 'OD000006', 'asd', '2022-07-13', '00:00:00', 'Awaiting', '');

-- --------------------------------------------------------

--
-- 資料表結構 `inwardsrecord`
--

CREATE TABLE `inwardsrecord` (
  `InwardsID` varchar(50) NOT NULL,
  `Item_ID` varchar(50) NOT NULL,
  `Quantity` int(11) NOT NULL,
  `InwardsDate` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- 傾印資料表的資料 `inwardsrecord`
--

INSERT INTO `inwardsrecord` (`InwardsID`, `Item_ID`, `Quantity`, `InwardsDate`) VALUES
('IW000001', 'P000003', 0, '2022-06-29'),
('IW000002', 'P000003', 20, '2022-06-29'),
('IW000003', 'P000003', 30, '2022-06-29'),
('IW000004', 'P000003', 30, '2022-06-29'),
('IW000005', 'P000003', 10, '2022-06-29'),
('IW000006', 'P000003', 20, '2022-06-29'),
('IW000007', 'P000004', 20, '2022-06-29'),
('IW000008', 'P000004', 30, '2022-06-29'),
('IW000009', 'P000004', 15, '2022-06-29'),
('IW000010', 'P000004', 50, '2022-06-29'),
('IW000011', 'P000004', 40, '2022-06-29');

-- --------------------------------------------------------

--
-- 資料表結構 `memo`
--

CREATE TABLE `memo` (
  `MemoID` varchar(5) NOT NULL,
  `Content` varchar(100) NOT NULL,
  `StaffID` varchar(50) NOT NULL,
  `MemoDate` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- 傾印資料表的資料 `memo`
--

INSERT INTO `memo` (`MemoID`, `Content`, `StaffID`, `MemoDate`) VALUES
('1', 'Hello, I am Memo', 'S001', '2022-06-26 15:28:09'),
('2', 'HaHa', 'S001', '2022-06-28 03:44:51');

-- --------------------------------------------------------

--
-- 資料表結構 `ordereditems`
--

CREATE TABLE `ordereditems` (
  `Order_ID` varchar(255) NOT NULL,
  `Item_ID` varchar(50) NOT NULL,
  `Order_Qty` int(5) NOT NULL,
  `Price` double NOT NULL,
  `Availability` char(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- 傾印資料表的資料 `ordereditems`
--

INSERT INTO `ordereditems` (`Order_ID`, `Item_ID`, `Order_Qty`, `Price`, `Availability`) VALUES
('OD000001', 'P000003', 6, 14754, 'Y'),
('OD000002', 'P000007', 10, 1500, 'Y'),
('OD000003', 'P000004', 10, 12340, 'Y'),
('OD000004', 'P000003', 3, 7377, 'Y'),
('OD000004', 'P000007', 10, 1500, 'Y'),
('OD000005', 'P000007', 15, 2250, 'Y'),
('OD000006', 'P000003', 10, 24590, 'Y');

-- --------------------------------------------------------

--
-- 資料表結構 `product`
--

CREATE TABLE `product` (
  `Item_ID` varchar(12) NOT NULL,
  `Item_Name` varchar(255) NOT NULL,
  `SupplierID` varchar(255) NOT NULL,
  `Description` varchar(100) DEFAULT NULL,
  `Price` double NOT NULL,
  `Neccessary` int(1) NOT NULL,
  `Avalibility` int(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- 傾印資料表的資料 `product`
--

INSERT INTO `product` (`Item_ID`, `Item_Name`, `SupplierID`, `Description`, `Price`, `Neccessary`, `Avalibility`) VALUES
('P000003', 'boiler', 'SP000001', '', 2459, 1, 1),
('P000004', 'sad', 'SP000001', 'sad', 1234, 1, 0),
('P000005', 'Air Con', 'SP0002', 'sad', 103, 0, 0),
('P000006', 'asdsa', 'SP000001', 'adsad', 120, 0, 0),
('P000007', 'Fans', 'SP000001', '', 150, 1, 1);

-- --------------------------------------------------------

--
-- 資料表結構 `productstock`
--

CREATE TABLE `productstock` (
  `Item_ID` varchar(12) NOT NULL,
  `StockQuantity` int(11) NOT NULL,
  `Reservation` int(11) NOT NULL,
  `ReOrderLevel` int(12) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- 傾印資料表的資料 `productstock`
--

INSERT INTO `productstock` (`Item_ID`, `StockQuantity`, `Reservation`, `ReOrderLevel`) VALUES
('P000003', 90, 0, 10),
('P000004', 29, 0, 20),
('P000005', 100, 0, 10),
('P000006', 30, 0, 3),
('P000007', 65, 0, 10);

-- --------------------------------------------------------

--
-- 資料表結構 `purchaseitem`
--

CREATE TABLE `purchaseitem` (
  `PurchaseItem_ID` varchar(50) NOT NULL,
  `PurchaseOrder_ID` varchar(50) NOT NULL,
  `Item_ID` varchar(50) NOT NULL,
  `Quantity` int(11) NOT NULL,
  `Price` double NOT NULL,
  `Total_Price` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- 傾印資料表的資料 `purchaseitem`
--

INSERT INTO `purchaseitem` (`PurchaseItem_ID`, `PurchaseOrder_ID`, `Item_ID`, `Quantity`, `Price`, `Total_Price`) VALUES
('PI000001', 'PO0001', 'P000003', 2, 2459, 4918);

-- --------------------------------------------------------

--
-- 資料表結構 `purchaseorder`
--

CREATE TABLE `purchaseorder` (
  `PurchaseOrder_ID` varchar(50) NOT NULL,
  `SupplierID` varchar(50) NOT NULL,
  `Status` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- 傾印資料表的資料 `purchaseorder`
--

INSERT INTO `purchaseorder` (`PurchaseOrder_ID`, `SupplierID`, `Status`) VALUES
('PO0001', 'SP000001', 'Awaiting Approval');

-- --------------------------------------------------------

--
-- 資料表結構 `salesorder`
--

CREATE TABLE `salesorder` (
  `Order_ID` varchar(255) NOT NULL,
  `Customer_Email` varchar(50) NOT NULL,
  `StaffID` varchar(50) NOT NULL,
  `Order_Date` datetime NOT NULL,
  `Remarks` varchar(200) DEFAULT NULL,
  `Paid_Price` double NOT NULL,
  `Total_Price` double NOT NULL,
  `Payment` varchar(20) NOT NULL,
  `Discount` int(5) DEFAULT NULL,
  `Status` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- 傾印資料表的資料 `salesorder`
--

INSERT INTO `salesorder` (`Order_ID`, `Customer_Email`, `StaffID`, `Order_Date`, `Remarks`, `Paid_Price`, `Total_Price`, `Payment`, `Discount`, `Status`) VALUES
('OD000001', 'abc123@gmail.com', 'S001', '2022-06-29 14:40:55', 'Remarks...', 13278.6, 14754, 'Cash', 10, 'Completed'),
('OD000002', 'abcd1234@gmail.com', 'S001', '2022-06-29 15:21:16', 'Remarks...', 1500, 1500, 'Cash', 0, 'Completed'),
('OD000003', 'abc123@gmail.com', 'S001', '2022-06-29 15:21:36', 'Remarks...', 11106, 12340, 'Cash', 10, 'Completed'),
('OD000004', 'abc123@gmail.com', 'S001', '2022-06-29 16:01:34', 'Remarks...', 8877, 8877, 'Credit Card', 0, 'Completed'),
('OD000005', 'sky@gmail.com', 'S001', '2022-07-12 02:02:12', 'Remarks...', 2250, 2250, 'Octopus', 0, 'Completed'),
('OD000006', 'hfgdsh@gmail.com', 'S001', '2022-07-12 02:15:05', 'Remarks...', 22131, 24590, 'Cash', 10, 'Completed');

-- --------------------------------------------------------

--
-- 資料表結構 `supplier`
--

CREATE TABLE `supplier` (
  `SupplierID` varchar(255) NOT NULL,
  `SupplierName` varchar(255) NOT NULL,
  `Description` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- 傾印資料表的資料 `supplier`
--

INSERT INTO `supplier` (`SupplierID`, `SupplierName`, `Description`) VALUES
('SP000001', 'Mitsuha', 'A eletronic creater'),
('SP0002', 'Hallo', 'Hallo'),
('SP0003', 'hahahha', 'haha');

--
-- 已傾印資料表的索引
--

--
-- 資料表索引 `account`
--
ALTER TABLE `account`
  ADD PRIMARY KEY (`StaffID`);

--
-- 資料表索引 `cart`
--
ALTER TABLE `cart`
  ADD KEY `Item_ID` (`Item_ID`);

--
-- 資料表索引 `customer`
--
ALTER TABLE `customer`
  ADD PRIMARY KEY (`Customer_Email`);

--
-- 資料表索引 `defectitem`
--
ALTER TABLE `defectitem`
  ADD PRIMARY KEY (`DefectID`);

--
-- 資料表索引 `delivery`
--
ALTER TABLE `delivery`
  ADD PRIMARY KEY (`Deli_ID`),
  ADD KEY `Order_ID` (`Order_ID`);

--
-- 資料表索引 `installation`
--
ALTER TABLE `installation`
  ADD PRIMARY KEY (`Install_ID`),
  ADD KEY `Order_ID` (`Order_ID`);

--
-- 資料表索引 `inwardsrecord`
--
ALTER TABLE `inwardsrecord`
  ADD PRIMARY KEY (`InwardsID`);

--
-- 資料表索引 `memo`
--
ALTER TABLE `memo`
  ADD PRIMARY KEY (`MemoID`),
  ADD KEY `memo_ibfk_1` (`StaffID`);

--
-- 資料表索引 `ordereditems`
--
ALTER TABLE `ordereditems`
  ADD KEY `Item_ID` (`Item_ID`);

--
-- 資料表索引 `product`
--
ALTER TABLE `product`
  ADD PRIMARY KEY (`Item_ID`),
  ADD KEY `SupplierID` (`SupplierID`);

--
-- 資料表索引 `productstock`
--
ALTER TABLE `productstock`
  ADD KEY `Item_ID` (`Item_ID`);

--
-- 資料表索引 `purchaseitem`
--
ALTER TABLE `purchaseitem`
  ADD PRIMARY KEY (`PurchaseItem_ID`),
  ADD KEY `PurchaseOrder_ID` (`PurchaseOrder_ID`),
  ADD KEY `Item_ID` (`Item_ID`);

--
-- 資料表索引 `purchaseorder`
--
ALTER TABLE `purchaseorder`
  ADD PRIMARY KEY (`PurchaseOrder_ID`),
  ADD KEY `SupplierID` (`SupplierID`);

--
-- 資料表索引 `salesorder`
--
ALTER TABLE `salesorder`
  ADD PRIMARY KEY (`Order_ID`);

--
-- 資料表索引 `supplier`
--
ALTER TABLE `supplier`
  ADD PRIMARY KEY (`SupplierID`);

--
-- 已傾印資料表的限制式
--

--
-- 資料表的限制式 `cart`
--
ALTER TABLE `cart`
  ADD CONSTRAINT `cart_ibfk_1` FOREIGN KEY (`Item_ID`) REFERENCES `product` (`Item_ID`);

--
-- 資料表的限制式 `delivery`
--
ALTER TABLE `delivery`
  ADD CONSTRAINT `delivery_ibfk_1` FOREIGN KEY (`Order_ID`) REFERENCES `salesorder` (`Order_ID`);

--
-- 資料表的限制式 `installation`
--
ALTER TABLE `installation`
  ADD CONSTRAINT `installation_ibfk_1` FOREIGN KEY (`Order_ID`) REFERENCES `salesorder` (`Order_ID`);

--
-- 資料表的限制式 `memo`
--
ALTER TABLE `memo`
  ADD CONSTRAINT `memo_ibfk_1` FOREIGN KEY (`StaffID`) REFERENCES `account` (`StaffID`);

--
-- 資料表的限制式 `product`
--
ALTER TABLE `product`
  ADD CONSTRAINT `product_ibfk_1` FOREIGN KEY (`SupplierID`) REFERENCES `supplier` (`SupplierID`);

--
-- 資料表的限制式 `productstock`
--
ALTER TABLE `productstock`
  ADD CONSTRAINT `productstock_ibfk_1` FOREIGN KEY (`Item_ID`) REFERENCES `product` (`Item_ID`);

--
-- 資料表的限制式 `purchaseitem`
--
ALTER TABLE `purchaseitem`
  ADD CONSTRAINT `purchaseitem_ibfk_2` FOREIGN KEY (`Item_ID`) REFERENCES `product` (`Item_ID`);

--
-- 資料表的限制式 `purchaseorder`
--
ALTER TABLE `purchaseorder`
  ADD CONSTRAINT `purchaseorder_ibfk_1` FOREIGN KEY (`SupplierID`) REFERENCES `supplier` (`SupplierID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
