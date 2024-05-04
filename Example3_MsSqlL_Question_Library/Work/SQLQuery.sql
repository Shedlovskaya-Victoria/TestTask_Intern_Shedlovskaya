select DISTINCT prod.Name [�������� ��� ���������], 
product.Name as [��� ��������], category.Name as [��� ���������]
from Product product 
left join CrossProductCategory crossProductCategory ON product.Id = crossProductCategory.IdProduct  
inner join Category category on category.Id = crossProductCategory.IdCategory 
INNER JOIN  Product  prod on prod.Id <> crossProductCategory.IdProduct  