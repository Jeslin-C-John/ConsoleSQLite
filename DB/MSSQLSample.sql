CREATE DATABASE Store;
GO
USE Store;
GO
CREATE SCHEMA Sales;
GO
CREATE TABLE Store.Sales.Customers(id INT IDENTITY Primary Key, firstname TEXT, lastname TEXT, address TEXT, city TEXT, state TEXT, pin varchar(6), phone varchar(10));
GO
CREATE TABLE Store.Sales.Orders(orderid INT IDENTITY Primary Key, customerid INT, orderdate DATE, Shippeddate DATE, FOREIGN KEY (customerid) REFERENCES Sales.Customers(id));
GO
CREATE SCHEMA Production;
GO
CREATE TABLE Store.Production.items(itemid INT IDENTITY Primary Key, title TEXT, price MONEY);
GO
CREATE TABLE Store.Production.Orderdetails(orderid INT IDENTITY Primary Key, itemid INT, quantity INT, FOREIGN KEY (itemid) REFERENCES Production.items(itemid));
GO
INSERT INTO Store.Sales.Customers (firstname, lastname, address, city, state, pin, phone) VALUES ('Apps', 'Team', 'TransAsia', 'Kochi', 'Kerala', '494995', '7898765456' );
GO
INSERT INTO Store.Sales.Orders (customerid, orderdate, shippeddate) VALUES (1, '2022-11-24', '2022-11-25' );
GO
INSERT INTO Store.Production.items (title, price) VALUES ('itemno1', '24' );
GO
INSERT INTO Store.Production.Orderdetails (itemid, quantity) VALUES (1, 12 );
GO
select * from Store.Sales.Customers;
GO
select * from Store.Sales.Orders;
GO
select * from Store.Production.items;
GO
select * from Store.Production.Orderdetails;
GO