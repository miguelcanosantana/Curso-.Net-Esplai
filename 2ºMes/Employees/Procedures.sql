USE MiguelCanoEmployees
GO


ALTER PROCEDURE IncreaseSalary(@quantity INT)
AS
BEGIN
	--Increment the salary
	UPDATE employees SET salary = salary + (salary / @quantity) FROM employees
	SELECT first_name, salary FROM employees
END

GO

EXEC IncreaseSalary @quantity = 10