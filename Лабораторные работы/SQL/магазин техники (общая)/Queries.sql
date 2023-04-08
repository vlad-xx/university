use Electronics_store

select Brand.Brand_name, Model.Model_name, Products_in_stock.Count, Category.Category_name, Product.Price, Products_in_stock.Count*Product.Price as 'общая сумма'
from Products_in_stock
inner join Product on Product.Id_product = Products_in_stock.Id_products_in_stock
inner join Model on Model.Id_model = Products_in_stock.Id_products_in_stock
inner join Brand_categories on Brand_categories.Id_brand_categories = Model.Brand_categories_id
inner join Category on Brand_categories.Category_id = Category.Id_category
inner join Brand on Brand_categories.Brand_id = Brand.Id_brand


--insert Sale 
--values 
--(1, 1, '2022.03.29'),
--(2, 2, '2022.03.30')


--insert Products_on_sale
--values 
--(1, 39, 1, 3680),
--(1, 1, 2, 59999),
--(1, 2, 3, 72890),
--(2, 51, 2, 21990),
--(2, 4, 2, 169990),
--(2, 66, 3, 73999),
--(2, 143, 2, 17990)

/*
update Products_in_stock
set Products_in_stock.count = Products_in_stock.count - 1
where Id_products_in_stock = 39

update Products_in_stock
set Products_in_stock.count = Products_in_stock.count - 2
where Id_products_in_stock = 1

update Products_in_stock
set Products_in_stock.count = Products_in_stock.count - 3
where Id_products_in_stock = 2


update Products_in_stock
set Products_in_stock.count = Products_in_stock.count - 2
where Id_products_in_stock = 51

update Products_in_stock
set Products_in_stock.count = Products_in_stock.count - 2
where Id_products_in_stock = 4

update Products_in_stock
set Products_in_stock.count = Products_in_stock.count - 3
where Id_products_in_stock = 66

update Products_in_stock
set Products_in_stock.count = Products_in_stock.count - 2
where Id_products_in_stock = 143
*/

select Category.Category_name, sum(Products_on_sale.Count) as 'Max'
	from Product

	inner join Products_on_sale on Product.Id_product = Products_on_sale.Product_id
	inner join Model on Model.Id_model = Product.Model_id
	inner join Brand_categories on Brand_categories.Id_brand_categories = Model.Brand_categories_id
	inner join Brand on Brand_categories.Brand_id = Brand.Id_brand
	inner join Category on Brand_categories.Category_id = Category.Id_category

	group by Category.Category_name
	having sum(Products_on_sale.Count) = (
											select max(tbl.pr_count) as max_count
												from (
													select sum(Products_on_sale.Count) as pr_count
													from Product

													inner join Products_on_sale on Product.Id_product = Products_on_sale.Product_id
													inner join Model on Model.Id_model = Product.Model_id
													inner join Brand_categories on Brand_categories.Id_brand_categories = Model.Brand_categories_id
													inner join Brand on Brand_categories.Brand_id = Brand.Id_brand
													inner join Category on Brand_categories.Category_id = Category.Id_category

													group by Category.Category_name
												) as tbl
											)
	

select Brand.Brand_name
from Brand

where Brand.Brand_name not in (select Brand.Brand_name as br_name
	from Products_on_sale

	inner join Product on Product.Id_product = Products_on_sale.Product_id
	inner join Model on Model.Id_model = Product.Model_id
	inner join Brand_categories on Brand_categories.Id_brand_categories = Model.Brand_categories_id
	inner join Brand on Brand_categories.Brand_id = Brand.Id_brand
	inner join Category on Brand_categories.Category_id = Category.Id_category

	group by Brand.Brand_name)

