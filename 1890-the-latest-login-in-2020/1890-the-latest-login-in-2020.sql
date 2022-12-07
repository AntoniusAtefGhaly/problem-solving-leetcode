/* Write your T-SQL query statement below */

select user_id,max(time_stamp ) as last_stamp  
 from Logins 
 where year(time_stamp) =2020
group by user_id   


-- select distinct user_id,(select top 1 time_stamp from Logins l
--  where time_stamp between  '2020-01-01' and '2020-12-31'  and l.user_id=Logins.user_id order by l.time_stamp desc) as last_stamp 
--  from Logins 
--  where time_stamp between  '2020-01-01' and '2020-12-31'   

