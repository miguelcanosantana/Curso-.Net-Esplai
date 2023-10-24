USE MiguelCanoEmployees
GO

--Name of employees with their children (dependents)
SELECT employees.first_name, dependents.first_name
FROM employees
	INNER JOIN dependents
	ON employees.employee_id = dependents.employee_id


--Name of employees with their country
SELECT employees.first_name, countries.country_name
FROM employees
	INNER JOIN departments
	ON employees.department_id = departments.department_id
	INNER JOIN locations
	ON departments.location_id = locations.location_id
	INNER JOIN countries
	ON locations.country_id = countries.country_id


--Name of employees with their department and jobs
SELECT employees.first_name, departments.department_name, jobs.job_title
FROM employees
	INNER JOIN departments
	ON employees.department_id = departments.department_id
	INNER JOIN jobs
	ON employees.job_id = jobs.job_id


--Name of employees with their department, jobs, city, country, etc...
SELECT emp.first_name, boss.first_name 'boss_name', departments.department_name, jobs.job_title, dependents.first_name, locations.city, countries.country_name, regions.region_name
FROM employees emp
	INNER JOIN departments
	ON emp.department_id = departments.department_id
	INNER JOIN locations
	ON departments.location_id = locations.location_id
	INNER JOIN countries
	ON locations.country_id = countries.country_id
	INNER JOIN regions
	ON countries.region_id = regions.region_id
	INNER JOIN jobs
	ON emp.job_id = jobs.job_id
	INNER JOIN dependents
	ON emp.employee_id = dependents.employee_id
	INNER JOIN employees boss
	ON emp.manager_id = boss.employee_id


--FULL JOIN Departments with or without employees and employees with or without departments
SELECT first_name, department_name
FROM employees
	FULL JOIN departments
	ON employees.department_id = departments.department_id


--RIGHT JOIN Departments with or without employees
SELECT first_name, department_name
FROM employees
	RIGHT JOIN departments
	ON employees.department_id = departments.department_id


--LEFT JOIN Employees with or whithout department
SELECT first_name, department_name
FROM employees
	LEFT JOIN departments
	ON employees.department_id = departments.department_id


--INNER JOIN Employees with department
SELECT first_name, department_name
FROM employees
	INNER JOIN departments
	ON employees.department_id = departments.department_id


--Employees with their boss name
--We have to use any aliases for distingishing the same table
SELECT emp.first_name AS 'Name', boss.first_name AS 'Boss Name'
FROM employees emp
	INNER JOIN employees boss
	ON emp.manager_id = boss.employee_id


--Employees with their job name and from Toronto (With Inner Join)
SELECT employees.first_name AS 'Name', jobs.job_title AS 'Job'
FROM employees 
	INNER JOIN departments 
	ON employees.department_id = departments.department_id
	INNER JOIN jobs
	ON employees.job_id = jobs.job_id 
	INNER JOIN locations
	ON departments.location_id = locations.location_id
	--AND locations.city = 'Toronto'
WHERE locations.city = 'Toronto'

----Employees with their job name (With inner Join)
----ON acts as WHERE
--SELECT employees.first_name AS 'Name', jobs.job_title AS 'Job'
--FROM employees INNER JOIN jobs
--ON employees.job_id = jobs.job_id


--Employees with their job name and from Toronto (manual JOIN, without JOIN word)
SELECT employees.first_name AS 'Name', jobs.job_title AS 'Job'
FROM employees, departments, jobs, locations
WHERE 
	employees.job_id = jobs.job_id 
	AND departments.location_id = locations.location_id
	AND locations.city = 'Toronto'


--Employees with their job name
SELECT employees.first_name AS 'Name', jobs.job_title AS 'Job'
FROM employees, jobs
WHERE employees.job_id = jobs.job_id


--Employees with their department name
--Take employees, Take departments, combine them, associate it with where (WITHOUT JOIN)
SELECT employees.first_name AS 'Name', departments.department_name AS 'Departamento'
FROM employees, departments
WHERE employees.department_id = departments.department_id


--Num of employees that work on IT
SELECT 
	COUNT(*) 'Num of employees in IT'
FROM employees
WHERE department_id = 
	(SELECT department_id
	FROM departments WHERE department_name = 'IT')


--Num of employees that don't have boss
SELECT 
	COUNT(*) 'Num of employees without Boss'
FROM employees
WHERE manager_id IS NULL


--Num of employees that don't have boss without WHERE
SELECT 
	COUNT(*) - COUNT(manager_id) 'Num of employees without Boss'
FROM employees


--All Different departments (Use DISTINCT to eliminate repeated values)
SELECT 
	COUNT(DISTINCT department_id) 'Num of departments. xxx'
FROM employees


--Employees with all agregate functions in only a select
SELECT 
	MAX(salary) 'Max salary',
	MIN(salary) 'Min salary',
	SUM(salary) 'Total salary',
	AVG(salary) 'Average salary',
	COUNT(salary) 'Num of salaries. xxx',
	COUNT(*) 'Num of rows. xxx'
FROM employees


--USING BETWEEN TO OMIT MULTIPLE CHECKS
SELECT * FROM [dbo].[employees]
--WHERE first_name LIKE 'S%' AND salary >= 5000 AND salary <= 10000
WHERE first_name LIKE 'S%' AND salary BETWEEN 5000 AND 10000

--Using Year before a date to extract only the year of the entire date
SELECT * FROM [dbo].[employees]
WHERE YEAR (hire_date) = 1995

--If the month is a multiple of 3, the module must be 0
--The module of a smaller number than it's divisor always returns the same number
SELECT * FROM [dbo].[employees]
--IN Searches a value inside a list of values
--WHERE MONTH (hire_date) IN (1,4,7,10)
WHERE MONTH (hire_date) % 3 = 1

--DATEFIFF is more precise, as it calculates the days too
SELECT * FROM [dbo].[employees]
--WHERE YEAR (GETDATE()) - YEAR (hire_date) >= 25
WHERE DATEDIFF(year, hire_date, GETDATE()) >= 25

--Entire employees name, only a field
SELECT first_name + ' ' + last_name AS FullName FROM employees

--Entire employees name + telephone, only a field
SELECT CONCAT (
	first_name + ' ', 
	last_name  + ' (', 
	ISNULL(phone_number, 'Doesnt have a phone'),
	') ') 
	AS PhoneNumber FROM employees

--Entire employees name + telephone, only a field
SELECT COALESCE (
	phone_number, 
	department_id,
	'Doesnt have anything') 
	AS PhoneNumber FROM employees

--Salary of employee without CONCAT
SELECT employees.first_name + ' ' + employees.last_name + ' ' + CAST(salary AS VARCHAR(10)) AS 'Employee & Salary' 
FROM employees

--Group By
SELECT department_id, COUNT(*) FROM employees
GROUP BY department_id

--DEPARTMENTS AND NUMBER OF EMPLOYEES PER DEPARTMENT
SELECT departments.department_name AS 'Department' , COUNT(*) AS 'Employee Count' 
FROM employees
	INNER JOIN departments
	ON departments.department_id = employees.department_id
GROUP BY departments.department_id, department_name --ORDER FIRST BY ID, LATER BY NAME (TO AVOID DUPLICATES BY NAME)

