-- Harjoitteita Northwind-databasen sisällöllä

-- Valitse asiakkaat Suomesta
SELECT * FROM Customers
WHERE Country='Finland'

-- Valitse yrityksen Que Delícia tilaukset
SELECT * FROM Orders, Customers
WHERE Orders.CustomerID = Customers.CustomerID AND
Customers.CompanyID = 'Que Delícia'

--Valitse työntekijät Lontoosta
SELECT * FROM Employees
WHERE City='London'

-- Asiakkaiden määrä
SELECT COUNT(CustomerID) AS 'Asiakkaiden lukumäärä'
FROM Customers

-- Varaston arvo
SELECT SUM(UnitPrice*UnitsInStock) AS 'Varaston arvo'
FROM Products

-- Tofun myynti (ProductID=14)
SELECT SUM(UnitPrice*Quantity) AS 'Myyty summa'
FROM [Order Details]
WHERE ProductID=14