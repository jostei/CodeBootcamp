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
SELECT DISTINCT COUNT(CustomerID) FROM Customers

-- Varaston arvo
SELECT SUM(UnitPrice*UnitsInStock) FROM Products

-- Tofun myynti
SELECT SUM(UnitPrice*Quantity) FROM [Order Details]
WHERE ProductID=14