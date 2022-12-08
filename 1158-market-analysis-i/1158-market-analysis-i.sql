/* Write your T-SQL query statement below */
select user_id    as buyer_id ,
join_date  ,count(order_id ) AS orders_in_2019 
 from Users left JOIN Orders ON Users.USER_ID=orders.buyer_id   
and year(order_date )=2019   
group by user_id  ,join_date 