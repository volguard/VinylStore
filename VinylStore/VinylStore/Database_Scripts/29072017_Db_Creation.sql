/*CREATE TABLE Customers(
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

CREATE TABLE LendVinyls(
Id Int NOT NULL PRIMARY KEY,
Name nvarchar,
Artist nvarchar,
Album nvarchar,
PublishDate datetime2,
LendDeadline datetime2,
Price float,
StorageAmount Int,
LendFrom DateTime2,
LendTo DateTime2
);
CREATE TABLE SellVinyls(
Id int PRIMARY KEY NOT NULL,
Name nvarchar,
Artist nvarchar,
Album nvarchar,
DateOfPublish DateTime2,
Price decimal,
StorageAmount int,
);*/
SELECT * FROM [D:\PROJEKTY\VINYLSTOREC#ACADEMIA\VINYLSTORE\VINYLSTORE\APP_DATA\VINYLDATABASE.MDF].dbo.Customers;
