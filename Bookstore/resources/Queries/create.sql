IF OBJECT_ID('dim.Stores') IS NOT NULL DROP TABLE dim.Stores
CREATE TABLE dim.Stores(
--(StoreID,Street,City,State,ZipCode)
	[StoreID] [int] IDENTITY(1,1) NOT NULL,
	[Street] [nvarchar](100) NOT NULL,
	[City] [nvarchar](50) NOT NULL,
	[State] [nvarchar](2) NOT NULL,
	[ZipCode] int NOT NULL,
) ON [PRIMARY]
GO


CREATE TABLE dim.Books(
--(BookID|ISBN|BookTitle|AuthorName|Publisher|Price)
	[BookID] [int] IDENTITY(1,1) NOT NULL,
	[ISBN] int NOT NULL,
	[BookTitle] [nvarchar](100) NOT NULL,
	[AuthorName] [nvarchar](100),
	[Publisher] [nvarchar](100) NOT NULL,
	[Price] decimal(6,2) NOT NULL,
) ON [PRIMARY]
GO

CREATE TABLE dim.Customers(
--(CustomerID|CustomerName|DateJoined|UserName|Password)
	CustomerID int IDENTITY(1,1) NOT NULL,
	CustomerName nvarchar(100) NOT NULL,
	DateJoined datetime NOT NULL,
	UserName nvarchar(20) NOT NULL,
	Password nvarchar(20) NOT NULL,
) ON [PRIMARY]
GO

CREATE TABLE fact.BookPerStore(
	ID int IDENTITY(1,1) NOT NULL,
	NumOfAvailability int NOT NULL,
	BookID int NOT NULL,
	StoreID int NOT NULL,
) 
ON [PRIMARY]
GO

CREATE TABLE fact.Purchases(
-- CustomerID|PurchaseID|BookID|DateOfPurchase|TransactionID
	PurchaseID int IDENTITY(1,1) NOT NULL,
	BookID int NOT NULL,
	CustomerID int NOT NULL,
	DateOfPurchase datetime NOT NULL,
	TransactionID uniqueidentifier NOT NULL,
) 
ON [PRIMARY]
GO