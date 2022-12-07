/* Write your T-SQL query statement below */

-- select distinct isnull(Salaries.employee_id,Employees.employee_id) as employee_id from
-- Employees cross join Salaries 

select Salaries.employee_id from Salaries 
where  Salaries.employee_id not in (select employee_id from employees )
union 
select employees.employee_id from employees 
where  employees.employee_id not in (select employee_id from Salaries )
order by 1