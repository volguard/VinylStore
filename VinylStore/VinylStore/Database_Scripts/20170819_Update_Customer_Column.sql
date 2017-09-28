﻿ALTER TABLE Employees ALTER COLUMN FirstName varchar(12)NOT NULL;
ALTER TABLE Employees ALTER COLUMN LastName varchar(20)NOT NULL;
ALTER TABLE Employees ALTER COLUMN FullName varchar(33)NULL;
ALTER TABLE Employees ALTER COLUMN StartSalary float(50) NULL;
ALTER TABLE Employees ALTER COLUMN CurrentSalary float(50) NULL;
ALTER TABLE Employees ALTER COLUMN WorkingMonday bit NOT NULL;
ALTER TABLE Employees ALTER COLUMN WorkingTuesday bit NOT NULL;
ALTER TABLE Employees ALTER COLUMN WorkingWednesday bit NOT NULL;
ALTER TABLE Employees ALTER COLUMN WorkingThursday bit NOT NULL;
ALTER TABLE Employees ALTER COLUMN WorkingFriday bit NOT NULL;
ALTER TABLE Employees ALTER COLUMN WorkingSaturday bit NOT NULL;
ALTER TABLE Employees ALTER COLUMN WorkingSunday bit NOT NULL
ALTER TABLE Customers ALTER COLUMN FirstName NVARCHAR(12) NOT NULL;
ALTER TABLE Customers ALTER COLUMN LastName NVARCHAR(20) NOT NULL;
ALTER TABLE Customers ALTER COLUMN FullName NVARCHAR(33) NULL;
ALTER TABLE Customers ALTER COLUMN AmountOfBorrowedVinyls INT NULL;
ALTER TABLE LendVinyls ALTER COLUMN Name NVARCHAR(50) NOT NULL;
ALTER TABLE LendVinyls ALTER COLUMN Artist NVARCHAR(50) NULL;
ALTER TABLE LendVinyls ALTER COLUMN Album NVARCHAR(50) NULL;
ALTER TABLE LendVinyls ALTER COLUMN DateOfPublish DATETIME NULL;
ALTER TABLE LendVinyls ALTER COLUMN CustomerId INT NULL;
ALTER TABLE LendVinyls ALTER COLUMN CustomerFullName NVARCHAR(33) NULL;
ALTER TABLE LendVinyls ALTER COLUMN LendFrom DATETIME NULL;
ALTER TABLE LendVinyls ALTER COLUMN LendTo DATETIME NULL;
ALTER TABLE SellVinyls ALTER COLUMN Name nvarchar(50) NOT NULL;
ALTER TABLE SellVinyls ALTER COLUMN Artist nvarchar(50) NULL;
ALTER TABLE SellVinyls ALTER COLUMN Album nvarchar(50) NULL;
ALTER TABLE SellVinyls ALTER COLUMN DateOfPublish DateTime2 NULL;
ALTER TABLE SellVinyls ALTER COLUMN Price decimal(10,2) NULL;
ALTER TABLE SellVinyls ALTER COLUMN StorageAmount int NULL;