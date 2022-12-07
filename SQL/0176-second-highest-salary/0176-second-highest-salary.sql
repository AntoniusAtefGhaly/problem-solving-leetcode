/* Write your T-SQL query statement below */


select top 1
case when (select  count(distinct salary) from employee)<2 then null else emp.salary end

as SecondHighestSalary from 
(
      select distinct top 2 
  salary
 
    from employee order by salary desc 
) 
emp order by emp.salary asc 


