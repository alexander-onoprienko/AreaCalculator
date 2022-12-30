
SELECT p.ProductName, c.CategoryName 
FROM Product AS p  
FULL OUTER JOIN Category AS c ON p.ID = c.ProductID