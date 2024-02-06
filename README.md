<h2>Решение задачи по SQL</h2>
<code>
SELECT 
  p.ProductName,
  ISNULL(c.CategoryName, 'No Category') AS CategoryName
FROM 
    Products p
LEFT JOIN 
    ProductCategories pc ON p.ProductID = pc.ProductID
LEFT JOIN 
    Categories c ON pc.CategoryID = c.CategoryID;
</code>
