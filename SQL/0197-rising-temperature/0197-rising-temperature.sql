/* Write your T-SQL query statement below */


-- select id from Weather  where temperature  >

-- isnull(( select top 1 temperature  from Weather w  where w.recordDate <Weather.recordDate order by w.recordDate desc ),temperature)
 
 
 select id from Weather  where temperature  >

isnull(( select top 1 temperature  from Weather w  where w.recordDate =
        DATEADD(day,- 1, Weather.recordDate)),temperature)
 