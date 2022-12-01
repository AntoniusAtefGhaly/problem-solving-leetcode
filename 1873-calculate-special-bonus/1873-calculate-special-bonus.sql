/* Write your T-SQL query statement below */
select employee_id,
/*SUBSTRING(name,1,1),*/
case when (employee_id%2=0) 
    then 0 
else
   case when(SUBSTRING(name,1,1)='M') then 0 else salary end 
end as bonus

from employees  order by employee_id

