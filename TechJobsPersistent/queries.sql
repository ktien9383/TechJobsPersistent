--Part 1
select column_name,data_type from information_schema.columns
where table_schema = 'techjobs' and table_name = 'jobs';

--Part 2
SELECT * FROM techjobs.employers
WHERE Location = "St. Louis";

--Part 3

