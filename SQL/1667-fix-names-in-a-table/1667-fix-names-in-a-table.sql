/* Write your T-SQL query statement below */

select user_id,concat(upper(substring(name,1,1)),
                      lower(substring(name,2,LEN(name)))) 
                    --  upper(substring(name,1,1)),
                      
                      as name 
from users order by user_id