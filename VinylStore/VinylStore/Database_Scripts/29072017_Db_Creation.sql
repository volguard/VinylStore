CREATE TABLE Customers(
Id Int NOT NULL PRIMARY KEY,
FirstName varchar(12),
LastName varchar(20),
FullName varchar(32),
AmountOfBorrowedVinyls Int
);

CREATE TABLE Employees(
Id Int NOT NULL PRIMARY KEY,
FirstName varchar(12),
LastName varchar(20),
FullName varchar(32),
StartSalary float(50),
CurrentSalary float(50),
WorkingMonday bit NOT NULL,
WorkingTuesday bit NOT NULL,
WorkingWednesday bit NOT NULL,
WorkingThursday bit NOT NULL,
WorkingFriday bit NOT NULL,
WorkingSaturday bit NOT NULL,
WorkingSunday bit NOT NULL
);

CREATE TABLE SellVinyls(
Id int PRIMARY KEY NOT NULL,
Name nvarchar,
Artist nvarchar,
Album nvarchar,
DateOfPublish DateTime2,
Price decimal,
StorageAmount int,
);

CREATE TABLE lendVinyls(
Id Int NOT NULL PRIMARY KEY,
Name nvarchar,
Artist nvarchar,
Album nvarchar,
PublishDate datetime2,
CustomerId int NULL, 
CustomerFullName nvarchar(32), 
LendFrom DateTime2, 
LendTo DateTime2
);
/*SELECT * FROM lendVinyls;*/