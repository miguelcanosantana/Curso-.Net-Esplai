USE MiguelCanoEmployees

SELECT * FROM [dbo].[employees]
WHERE first_name LIKE 'S%' AND salary >= 5000 AND salary <= 10000

--Using Year before a date to extract only the YEAR of the entire date
SELECT * FROM [dbo].[employees]
WHERE YEAR (hire_date) = 1995