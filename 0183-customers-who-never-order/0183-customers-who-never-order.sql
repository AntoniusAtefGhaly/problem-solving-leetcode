/* Write your T-SQL query statement below */
select Customers.name as Customers from Customers 
 where  Customers.id not in (select customerId from orders)
-- select Customers.name from Customers 
-- outer left  join  orders where Customers.id=orders.customerId

