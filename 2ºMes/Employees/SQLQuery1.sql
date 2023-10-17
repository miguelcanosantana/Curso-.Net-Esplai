USE MiguelCanoEmployees

SELECT * FROM [dbo].[employees]
WHERE first_name LIKE 'S%' AND salary >= 5000 AND salary <= 10000

--Using Year before a date to extract only the year of the entire date
SELECT * FROM [dbo].[employees]
WHERE YEAR (hire_date) = 1995

--If the month is a multiple of 3, the module must be 0
SELECT * FROM [dbo].[employees]
WHERE MONTH (hire_date) % 3 != 0

SELECT * FROM [dbo].[employees]
WHERE YEAR (GETDATE()) - YEAR (hire_date) >= 25