/* Creating Database*/
CREATE DATABASE CRUD;
USE CRUD;

/* Creating Table*/
CREATE TABLE ProductList(
PID INT PRIMARY KEY IDENTITY(1,1),
ProductName NVARCHAR(MAX) NOT NULL,
ProductDescription NVARCHAR(MAX) NOT NULL,
ProductFile NVARCHAR(MAX) NOT NULL,
Quantity DECIMAL(12,2) NOT NULL,
Rate DECIMAL(12,2) NOT NULL,
);

/*Displaying Database*/
SELECT * FROM ProductList;

/*Deleting Table */
DROP TABLE ProductList;

/*Inserting Products*/