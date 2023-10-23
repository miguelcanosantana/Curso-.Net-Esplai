USE MiguelCanoEmployees
GO

-- 00- Num. de emps de UN dept concreto (por su id)
CREATE FUNCTION EmployeesNumberFromDepartment(@selectedDepartment INT) 
RETURNS INT
AS
BEGIN

	DECLARE @number INT

	SELECT @number = COUNT(*) FROM employees
	WHERE employees.department_id = @selectedDepartment

	RETURN @number
END

GO 

--Use Function
SELECT dbo.EmployeesNumberFromDepartment(1)
