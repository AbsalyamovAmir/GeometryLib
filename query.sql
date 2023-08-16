SELECT 
    Products.name, 
    ISNULL(Category.name, 'Без категории') AS name
FROM Products 
LEFT JOIN 
    ProductCategories ON Products.Id = ProductCategories.Id
LEFT JOIN 
    Categories ON ProductCategories.CategoryId = Categories.Id
ORDER BY Products.name;
