/* Write your T-SQL query statement below */

select stock_name   , sum(case when  operation ='Buy'then-1 else 1 end * price  ) as capital_gain_loss  from 
Stocks  group by stock_name    