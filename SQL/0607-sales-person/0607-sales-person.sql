/* Write your T-SQL query statement below */

select SalesPerson.name from SalesPerson 

WHERE SalesPerson.sales_id  NOT IN( 
    SELECT SalesPerson.sales_id  from SalesPerson
left join Orders on Orders.sales_id =SalesPerson.sales_id   
left join Company  on Company .com_id  =Orders.com_id 
WHERE Company.name ='RED' 
)


 
