DELETE FROM EmployeeTrainings;
DELETE FROM EmployeesComputers;
DELETE FROM Employees;
DELETE FROM OrderByProduct;
DELETE FROM Orders;
DELETE FROM Product;
DELETE FROM PaymentTypes;
DELETE FROM TrainingProgram;
DELETE FROM Customers;
DELETE FROM Computers;
DELETE FROM Departments;
DELETE FROM ProductTypes;

DROP TABLE IF EXISTS ProductTypes;
DROP TABLE IF EXISTS Departments;
DROP TABLE IF EXISTS Computers;
DROP TABLE IF EXISTS Customers;
DROP TABLE IF EXISTS TrainingProgram;
DROP TABLE IF EXISTS PaymentTypes;
DROP TABLE IF EXISTS Product;
DROP TABLE IF EXISTS Orders;
DROP TABLE IF EXISTS OrderByProduct;
DROP TABLE IF EXISTS Employees;
DROP TABLE IF EXISTS EmployeesComputers;
DROP TABLE IF EXISTS EmployeeTrainings;

CREATE TABLE `ProductTypes` (
`ProductTypeID` INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
	`ProductCategory` TEXT NOT NULL
);

CREATE TABLE `Departments` (
`DepartmentID`	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
	`DepartmentName`	TEXT NOT NULL,
	`ExpenseBudget`	INTEGER NOT NULL
);

CREATE TABLE `Computers` (
`ComputerID` INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
	`PurchaseDate` TEXT NOT NULL,
	`DecommissionedDate` TEXT NOT NULL,
	`Malfunction` INTEGER NOT NULL
);

CREATE TABLE `Customers` (
`CustomerID` INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
	`FirstName` TEXT NOT NULL,
	`LastName` TEXT NOT NULL,
	`AccountCreatedDate` TEXT NOT NULL
);

CREATE TABLE `TrainingProgram` (
`TrainingProgramID` INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
	`Title` TEXT NOT NULL,
	`StartDate` TEXT NOT NULL,
	`EndDate` TEXT NOT NULL,
	`TotalAttendees` INTEGER NOT NULL,
	`MaxAttendees` INTEGER NOT NULL
);

CREATE TABLE `PaymentTypes` (
`PaymentTypeID` INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
	`PaymentType` TEXT NOT NULL,
	`AccountNumber` INTEGER NOT NULL,
	`CustomerID` INTEGER NOT NULL,
		FOREIGN KEY('CustomerID') REFERENCES 'Customers'('CustomerID')
);

CREATE TABLE `Product` (
`ProductID` INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
	`Title` TEXT NOT NULL,
	`Description` TEXT NOT NULL,
	`Quantity` INTEGER NOT NULL,
	`Price` INTEGER NOT NULL,
	`ProductTypeID` INTEGER NOT NULL,
	`CustomerID` INTEGER NOT NULL,
		FOREIGN KEY('ProductTypeID') REFERENCES 'ProductTypes'('ProductTypeID'),
		FOREIGN KEY('CustomerID') REFERENCES 'Customers'('CustomerID')
);

CREATE TABLE `Orders` (
`OrderID` INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
	`PaymentTypeID` INTEGER NOT NULL,
	`CustomerID` INTEGER NOT NULL,
		FOREIGN KEY('PaymentTypeID') REFERENCES 'PaymentTypes'('PaymentTypeID'),
		FOREIGN KEY('CustomerID') REFERENCES 'Customers'('CustomerID')
);

CREATE TABLE `OrderByProduct` (
`OrderByProductID` INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
	`ProductID` INTEGER NOT NULL,
	`OrderID` INTEGER NOT NULL,
		FOREIGN KEY('ProductID') REFERENCES 'Product'('ProductID'),
		FOREIGN KEY('OrderID') REFERENCES 'Orders'('OrderID')
);

CREATE TABLE `Employees` (
`EmployeeID` INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
	`FirstName` TEXT NOT NULL,
	`LastName` TEXT NOT NULL,
	`Title` TEXT NOT NULL,
	`Supervisor` INTEGER NOT NULL,
	`DepartmentID` INTEGER NOT NULL,
		FOREIGN KEY('DepartmentID') REFERENCES 'Departments'('DepartmentID')
);

CREATE TABLE `EmployeesComputers` (
`EmployeesComputersID` INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
	`EndDate` TEXT NOT NULL,
	`ComputerID` INTEGER NOT NULL,
	`EmployeeID` INTEGER NOT NULL,
		FOREIGN KEY('ComputerID') REFERENCES 'Computers'('ComputerID'),
		FOREIGN KEY('EmployeeID') REFERENCES 'Employees'('EmployeeID')
);

CREATE TABLE `EmployeeTrainings` (
`EmployeeTrainingsID` INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
	`TrainingProgramID` INTEGER NOT NULL,
	`EmployeeID` INTEGER NOT NULL,
		FOREIGN KEY('TrainingProgramID') REFERENCES 'TrainingProgram'('TrainingProgramID'),
		FOREIGN KEY('EmployeeID') REFERENCES 'Employees'('EmployeeID')
);

INSERT INTO ProductTypes VALUES (null, 'Jewelry');
INSERT INTO ProductTypes VALUES (null, 'Cars');
INSERT INTO ProductTypes VALUES (null, 'Electronics');

INSERT INTO Departments VALUES (null, 'Human Resources', 50000);
INSERT INTO Departments VALUES (null, 'Operations', 230000);
INSERT INTO Departments VALUES (null, 'Accounting', 70000);

INSERT INTO Computers VALUES (null, '1/9/2017', '1/10/2017', 0);
INSERT INTO Computers VALUES (null, '2/3/2014', '10/13/2016', 1);
INSERT INTO Computers VALUES (null, '3/2/2011', '4/9/2015', 0);

INSERT INTO Customers VALUES (null, 'Ryan', 'McPherson', '4/9/2015');
INSERT INTO Customers VALUES (null, 'Bill', 'Gates', '4/9/2015');
INSERT INTO Customers VALUES (null, 'Jerry', 'Seinfeld', '4/9/2015');

INSERT INTO TrainingProgram VALUES (null, 'Scamming People: How to Get Away With It!', '5/23/2019 - 5:00PM', '5/23/2019: - 6:00PM', 0, 20);
INSERT INTO TrainingProgram VALUES (null, 'How to Smell Your Food Before You Eat It.', '3/12/2018 - 9:00PM', '3/12/2018 - 10:00PM', 0, 12);
INSERT INTO TrainingProgram VALUES (null, 'Make Money, FAST!', '9/20/2018 - 7:00PM', '9/20/2018 - 7:00PM', 0, 30);

INSERT INTO PaymentTypes
	SELECT null,
		   "Credit Card - Amex",
		   '10910932979749284',
		   CustomerID
	FROM Customers c WHERE  c.LastName = "McPherson";
	
INSERT INTO PaymentTypes
	SELECT null,
		   "Credit Card - Chase",
		   '982875398475398',
		   CustomerID
	FROM Customers c WHERE  c.LastName = "Gates";
	
INSERT INTO PaymentTypes
	SELECT null,
		   "Debit Card - Regions",
		   '845738475383984',
		   CustomerID
	FROM Customers c WHERE  c.LastName = "Seinfeld";

INSERT INTO Product
	SELECT null,
		   "Diamond Earings",
		   "These are the best earings ever!",
		   1,
		   4500,
		   ProductTypeID,
		   CustomerID
	FROM ProductTypes p, Customers c
	WHERE  p.ProductCategory = "Jewelry" AND c.LastName = "McPherson";
	
INSERT INTO Product
	SELECT null,
		   "iPod Nano 1GB",
		   "This thing is useless, I don't need it anymore...",
		   1,
		   7,
		   ProductTypeID,
		   CustomerID
	FROM ProductTypes p, Customers c
	WHERE  p.ProductCategory = "Electronics" AND c.LastName = "Seinfeld";
	
INSERT INTO Product
	SELECT null,
		   "Honda Pilot",
		   "I may be rich, but I really need to sell this car.",
		   1,
		   5000,
		   ProductTypeID,
		   CustomerID
	FROM ProductTypes p, Customers c
	WHERE  p.ProductCategory = "Cars" AND c.LastName = "Gates";

INSERT INTO Orders
	SELECT null,
		   pt.PaymentTypeID,
		   cid.CustomerID
	FROM PaymentTypes pt, Customers cid
	WHERE  pt.PaymentType = "Credit Card - Chase" AND cid.LastName = "Gates";
	
INSERT INTO Orders
	SELECT null,
		   pt.PaymentTypeID,
		   cid.CustomerID
	FROM PaymentTypes pt, Customers cid
	WHERE  pt.PaymentType = "Credit Card - Amex" AND cid.LastName = "McPherson";
	
INSERT INTO Orders
	SELECT null,
		   pt.PaymentTypeID,
		   cid.CustomerID
	FROM PaymentTypes pt, Customers cid
	WHERE  pt.PaymentType = "Debit Card - Regions" AND cid.LastName = "Seinfeld";
	
INSERT INTO OrderByProduct
	SELECT null,
		   p.ProductID,
		   oid.OrderID
	FROM Product p, Orders oid
	WHERE  p.Title = "iPod Nano 1GB" AND oid.CustomerID = "3";
	
INSERT INTO OrderByProduct
	SELECT null,
		   p.ProductID,
		   oid.OrderID
	FROM Product p, Orders oid
	WHERE  p.Title = "Diamond Earings" AND oid.CustomerID = "1";
	
INSERT INTO OrderByProduct
	SELECT null,
		   p.ProductID,
		   oid.OrderID
	FROM Product p, Orders oid
	WHERE  p.Title = "Honda Pilot" AND oid.CustomerID = "2";
	
INSERT INTO Employees
	SELECT null,
	"Jeffery",
	"Bezos",
	"CEO",
	1,
	DepartmentID
	FROM Departments d 
	WHERE d.DepartmentName = "Operations";
	
INSERT INTO Employees
	SELECT null,
	"Patty",
	"Mayonaise",
	"CHRO",
	1,
	DepartmentID
	FROM Departments d 
	WHERE d.DepartmentName = "Human Resources";
	
INSERT INTO Employees
	SELECT null,
	"Chaz",
	"Vanderbilt",
	"VP of Accounting",
	1,
	DepartmentID
	FROM Departments d 
	WHERE d.DepartmentName = "Accounting";

INSERT INTO EmployeesComputers
	SELECT null,
	"1/2/2019",
	c.ComputerID,
	e.EmployeeID
	FROM Computers c, Employees e
	WHERE  c.PurchaseDate = "1/9/2017" AND e.LastName = "Bezos";
	
INSERT INTO EmployeesComputers
	SELECT null,
	"7/5/2020",
	c.ComputerID,
	e.EmployeeID
	FROM Computers c, Employees e
	WHERE  c.PurchaseDate = "2/3/2014" AND e.LastName = "Vanderbilt";
	
INSERT INTO EmployeesComputers
	SELECT null,
	"10/20/2019",
	c.ComputerID,
	e.EmployeeID
	FROM Computers c, Employees e
	WHERE  c.PurchaseDate = "3/2/2011" AND e.LastName = "Mayonaise";
	
INSERT INTO EmployeeTrainings
	SELECT null,
	t.TrainingProgramID,
	e.EmployeeID
	FROM TrainingProgram t, Employees e
	WHERE  t.StartDate = "5/23/2019 - 5:00PM" AND e.LastName = "Mayonaise";
	
INSERT INTO EmployeeTrainings
	SELECT null,
	t.TrainingProgramID,
	e.EmployeeID
	FROM TrainingProgram t, Employees e
	WHERE  t.StartDate = "3/12/2018 - 9:00PM" AND e.LastName = "Vanderbilt";
	
INSERT INTO EmployeeTrainings
	SELECT null,
	t.TrainingProgramID,
	e.EmployeeID
	FROM TrainingProgram t, Employees e
	WHERE  t.StartDate = "9/20/2018 - 7:00PM" AND e.LastName = "Bezos";
	
SELECT * from ProductTypes;
SELECT * from Departments;
SELECT * from Computers;
SELECT * from Customers;
SELECT * from TrainingProgram;
SELECT * from PaymentTypes;
SELECT * from Product;
SELECT * from Orders;
SELECT * from OrderByProduct;
SELECT * from Employees;
SELECT * from EmployeesComputers;
SELECT * from EmployeeTrainings;