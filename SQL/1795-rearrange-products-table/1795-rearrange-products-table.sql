/* Write your T-SQL query statement below */



/************** using UNpivot ***********/



select product_id , store  , price  

from products 
unpivot(
    price for store in (store1,store2,store3)
)
as T






/************** using UNION ***********/
-- select product_id ,'store1' as store  ,store1 as price  from products   where store1 is not null
-- union 
-- select product_id ,'store2' as store  ,store2 as price  from products  where store2 is not null
-- union
-- select product_id ,'store3' as store  ,store3 as price  from products where store3 is not null
-- order by 1,2,3