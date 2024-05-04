select DISTINCT prod.Name [Продукты без категории], 
product.Name as [Имя продукта], category.Name as [Имя категории]
from Product product 
left join CrossProductCategory crossProductCategory ON product.Id = crossProductCategory.IdProduct  
inner join Category category on category.Id = crossProductCategory.IdCategory 
INNER JOIN  Product  prod on prod.Id <> crossProductCategory.IdProduct  