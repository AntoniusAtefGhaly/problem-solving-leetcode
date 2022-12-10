/* Write your T-SQL query statement below */

select  name    ,isnull( sum(distance ) ,0) as travelled_distance  from 
Users left  join Rides on Users.id  = Rides.user_id       
group by users.id,users. name order by 2 desc, 1 asc