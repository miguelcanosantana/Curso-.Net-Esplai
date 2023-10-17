USE MiguelCanoEmployees

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