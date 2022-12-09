/* Write your T-SQL query statement below */
select  name,sum(amount) as balance
from Users join  Transactions on Users.account=Transactions.account
group by Users.name having sum(amount)>10000