/**************************************
            SELECT
 **************************************/

-- list all books in the bookstores
select * from bookstore.Book where bookstore.Book.NumberOfCopies > 0;

-- list all stores
select * from bookstore.Store;

-- list all purchases
select * from bookstore.Purchase;

-- list all customer
select * from bookstore.Customer;

-- find customer by name
select * from bookstore.Customer where CustomerName = 'Elsa Smith';
