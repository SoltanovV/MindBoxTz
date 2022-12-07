SELECT p.Name as ProductName, c.Name as CategoryName FROM [MindBoxTest].[dbo].[Products] AS p
LEFT JOIN [MindBoxTest].[dbo].[ProductsCategories] AS pc
ON pc.ProductId = p.Id
LEFT JOIN [MindBoxTest].[dbo].[Categories] AS c
ON c.Id = pc.CategoryId
