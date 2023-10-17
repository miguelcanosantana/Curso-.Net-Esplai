USE MiguelCanoEmployees

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
WHERE MONTH (hire_date) % 3 = 1

SELECT * FROM [dbo].[employees]
WHERE YEAR (GETDATE()) - YEAR (hire_date) >= 25