--Part 1
select column_name,data_type from information_schema.columns
where table_schema = 'techjobs' and table_name = 'jobs';

--Part 2
SELECT * FROM techjobs.employers
WHERE Location = "St. Louis";

--Part 3
SELECT s.name as Skill, s.Description, j.Name as Job, e.Name as Employer
FROM skills as s INNER JOIN jobskills as js
ON s.Id = js.SkillId 
INNER JOIN jobs as j 
ON js.JobId = j.Id 
INNER JOIN employers as e 
ON j.EmployerId = e.Id
ORDER BY Skill, Description, Job, Employer;

