--CREATE DATABASE Store;
--GO
--USE Store;
--GO
--CREATE SCHEMA Sales;
--GO
--CREATE TABLE Store.Sales.Customers(id INT IDENTITY Primary Key, firstname TEXT, lastname TEXT, address TEXT, city TEXT, state TEXT, pin varchar(6), phone varchar(10));
--GO
--CREATE TABLE Store.Sales.Orders(orderid INT IDENTITY Primary Key, customerid INT, orderdate DATE, Shippeddate DATE, FOREIGN KEY (customerid) REFERENCES Sales.Customers(id));
--GO
--CREATE SCHEMA Production;
--GO
--CREATE TABLE Store.Production.items(itemid INT IDENTITY Primary Key, title TEXT, price MONEY);
--GO
--CREATE TABLE Store.Production.Orderdetails(orderid INT IDENTITY Primary Key, itemid INT, quantity INT, FOREIGN KEY (itemid) REFERENCES Production.items(itemid));



--GO
--INSERT INTO Store.Sales.Customers (firstname, lastname, address, city, state, pin, phone) VALUES ('Apps', 'Team', 'TransAsia', 'Kochi', 'Kerala', '494995', '7898765456' );
--GO
--INSERT INTO Store.Sales.Orders (customerid, orderdate, shippeddate) VALUES (1, '2022-11-24', '2022-11-25' );
--GO
--INSERT INTO Store.Production.items (title, price) VALUES ('itemno1', '24' );
--GO
--INSERT INTO Store.Production.Orderdetails (itemid, quantity) VALUES (1, 12 );
--GO



--ALTER TABLE Store.Production.Orderdetails ADD  location VARCHAR(20) NULL;
--TRUNCATE TABLE Store.Sales.Orders;
--UPDATE Store.Sales.Customers SET lastname='lastname' WHERE id=5;
--DELETE FROM Store.Production.Orderdetails WHERE itemid=4;
--SELECT FIRStname FROM Store.Sales.Customers INNER JOIN Store.Sales.Orders ON Orders.orderid=Customers.id;
--SELECT * from Store.Sales.Customers WHERE id=1;
--SELECT * from Store.Sales.Customers WHERE id=1 OR id=2;
--SELECT * from Store.Sales.Customers WHERE firstname LIKE 'Apps' AND lastname LIKE 'Team';
--SELECT * from Store.Sales.Customers WHERE NOT id=1;
--SELECT * from Store.Sales.Customers WHERE id BETWEEN 5 AND 6;
--SELECT firstname from Store.Sales.Customers WHERE EXISTS (SELECT * from Store.Sales.Orders WHERE orderid=1);
--SELECT firstname from Store.Sales.Customers WHERE id = ANY (SELECT id from Store.Sales.Customers WHERE id=1);
--SELECT * from Store.Sales.Customers WHERE Store.Sales.Customers.id IN (5,6);
--ALTER TABLE  Store.Production.c ADD CONSTRAINT new_constraint PRIMARY KEY (itemid);
--SELECT AVG(price) from Store.Production.items;
--SELECT MAX(price) from Store.Production.items;
--SELECT MIN(price) from Store.Production.items;
--SELECT COUNT(price) from Store.Production.items;
--SELECT SUM(price) from Store.Production.items;
--ALTER TABLE Sales.Customers ADD UNIQUE (id);


--SELECT orderid, ISNULL(location, 'Infopark') AS WorkLocation FROM Store.Production.Orderdetails;
--SELECT orderid, COALESCE(location, 'Infopark') AS WorkLocation FROM Store.Production.Orderdetails;
--SELECT itemid, CASE WHEN location IS NULL THEN 'London' ELSE location END AS location FROM Store.Production.Orderdetails;


--CREATE FUNCTION TBF ( @name TEXT ) RETURNS TABLE AS RETURN SELECT id FROM Store.Sales.Customers WHERE lastname LIKE @name;
--SELECT * FROM TBF('Team');

--CREATE FUNCTION SVF ( @amount INT ) RETURNS INT AS BEGIN RETURN (@amount+2); END;
--SELECT dbo.SVF(12) Discounted;

--SELECT itemid, SUM(quantity) Stock FROM Store.Production.Orderdetails GROUP BY itemid ORDER BY Stock;
--SELECT itemid, SUM(quantity) AS Stock FROM Store.Production.Orderdetails GROUP BY itemid HAVING SUM(quantity) = 12;

--CREATE VIEW Cusview AS SELECT firstname, lastname FROM Store.Sales.Customers WHERE city LIKE 'Kochi';
--SELECT * FROM Cusview;

--CREATE TRIGGER Sales.hum ON  Sales.Customers AFTER INSERT AS BEGIN INSERT INTO Store.Sales.hey (data) VALUES ('Change');END

--CREATE PROCEDURE customerlist AS BEGIN SELECT lastname FROM Sales.Customers ORDER BY id;END;
--EXEC customerlist;

GO
select * from Store.Sales.Customers;
GO
select * from Store.Sales.Orders;
GO
select * from Store.Production.items;
GO
select * from Store.Production.Orderdetails;
GO
