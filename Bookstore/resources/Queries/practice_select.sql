-- Find customer name and all books name that customerid1 rents
SELECT b.BookTitle, p.CustomerID, c.CustomerName
FROM dim.Books b 
INNER JOIN fact.Purchases p
	ON b.BookID = p.BookID
INNER JOIN dim.Customers c
	ON p.CustomerID = c.CustomerID
WHERE p.CustomerID = 1
ORDER BY CustomerID


-- List all books that each customer rents
SELECT  c.CustomerName, 
	CASE WHEN b.BookTitle IS NULL 
			THEN '' 
		ELSE b.BookTitle 
	END AS BookTitle
FROM dim.Books b 
INNER JOIN fact.Purchases p
	ON b.BookID = p.BookID
RIGHT JOIN dim.Customers c
	ON p.CustomerID = c.CustomerID
ORDER BY c.CustomerName

-- Who rents the most number of books?
SELECT TOP 1 c.CustomerName, COUNT(1) AS NumberOfRents
FROM dim.Books b 
INNER JOIN fact.Purchases p
	ON b.BookID = p.BookID
INNER JOIN dim.Customers c
	ON p.CustomerID = c.CustomerID
GROUP BY c.CustomerName
ORDER BY COUNT(1) DESC

-- which book gets rented the most time?
SELECT TOP 1 b.BookTitle, COUNT(1) AS NumberOfRents
FROM dim.Books b 
INNER JOIN fact.Purchases p
	ON b.BookID = p.BookID
GROUP BY b.BookTitle
ORDER BY COUNT(1) DESC


WITH cte 
AS
(
	SELECT TOP 1 COUNT(1) AS MaxRental
	FROM fact.Purchases
	GROUP BY BookId 
	ORDER BY BookId DESC
)
SELECT b.BookTitle, COUNT(1) AS NumberOfRents
FROM dim.Books b 
INNER JOIN fact.Purchases p
	ON b.BookID = p.BookID
GROUP BY b.BookTitle
HAVING COUNT(1) = (SELECT MaxRental FROM cte)

-- list all books and their number of rental
SELECT b.BookTitle, COUNT(1) AS NumberOfRents
FROM dim.Books b 
INNER JOIN fact.Purchases p
	ON b.BookID = p.BookID
GROUP BY b.BookTitle

-- list all customers who don't have any rental
SELECT  c.CustomerName
FROM dim.Books b 
INNER JOIN fact.Purchases p
	ON b.BookID = p.BookID
RIGHT JOIN dim.Customers c
	ON p.CustomerID = c.CustomerID
WHERE b.BookTitle IS NULL
ORDER BY c.CustomerName

-- which store has the most book available?
SELECT B.StoreID, SUM(B.NumOfAvailability) 
FROM fact.BookPerStore B
GROUP BY B.StoreID
ORDER BY B.StoreID

-- find custom books (do on the fly)

-- address, city, state, bookname, number of avalable
SELECT s.Street, s.City, s.State,b.BookTitle, p.NumOfAvailability
FROM dim.Stores s
INNER JOIN fact.BookPerStore p
	ON s.StoreID = p.StoreID
INNER JOIN dim.Books b
	ON b.BookID = p.BookID
ORDER BY s.Street