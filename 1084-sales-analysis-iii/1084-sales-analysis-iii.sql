/* Write your T-SQL query statement below */

select  Product.product_id , product_name
from Product join Sales on Product.product_id = Sales.product_id
and sale_date between '2019-01-01' and '2019-03-31'
group by Product.product_id,product_name 

EXCEPT
select  Product.product_id , product_name
from Product join Sales on Product.product_id = Sales.product_id
and  sale_date not between '2019-01-01' and '2019-03-31'
group by Product.product_id,product_name 

