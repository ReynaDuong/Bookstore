--SET QUOTED_IDENTIFIER ON  -- Turn on text qualifier (double quote)

IF EXISTS (SELECT TOP 1 1 FROM dim.Books) TRUNCATE TABLE dim.Books
BULK INSERT dim.Books
FROM 'C:\Users\Bao\Desktop\Codes\C#\Minh\Bookstore\Bookstore\Bookstore\resources\csv\book.csv'
WITH
(
	FIELDTERMINATOR = '|',
	FIRSTROW=2,
	ROWTERMINATOR = '0x0a'
)

IF EXISTS (SELECT TOP 1 1 FROM dim.Stores) TRUNCATE TABLE dim.Stores
BULK INSERT dim.Stores
FROM 'C:\Users\Bao\Desktop\Codes\C#\Minh\Bookstore\Bookstore\Bookstore\resources\csv\store.csv'
WITH
(
	FIELDTERMINATOR = '|',
	FIRSTROW=2,
	ROWTERMINATOR = '0x0a'
)

IF EXISTS (SELECT TOP 1 1 FROM dim.Customers) TRUNCATE TABLE dim.Customers
BULK INSERT dim.Customers
FROM 'C:\Users\Bao\Desktop\Codes\C#\Minh\Bookstore\Bookstore\Bookstore\resources\csv\customer.csv'
WITH
(
    FIELDTERMINATOR = '|',
    FIRSTROW=2,
    ROWTERMINATOR = '0x0a'
)
GO

IF EXISTS (SELECT TOP 1 1 FROM dim.Purchases) TRUNCATE TABLE dim.Purchases
BULK INSERT fact.Purchases
FROM 'C:\Users\Bao\Desktop\Codes\C#\Minh\Bookstore\Bookstore\Bookstore\resources\csv\purchase.csv'
WITH
(
    FIELDTERMINATOR = '|',
    FIRSTROW=2,
    ROWTERMINATOR = '0x0a'
)
GO

IF EXISTS (SELECT TOP 1 1 FROM fact.BookPerStore) TRUNCATE TABLE fact.BookPerStore
BULK INSERT fact.BookPerStore
FROM 'C:\Users\Bao\Desktop\Codes\C#\Minh\Bookstore\Bookstore\Bookstore\resources\csv\bookNumPerStore.csv'
WITH
(
    FIELDTERMINATOR = '|',
    FIRSTROW=2,
    ROWTERMINATOR = '0x0a'
)
GO