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


-- 01- Lista de depts con el num. de sus emps (usandoa la función 00)
SELECT dbo.EmployeesNumberFromDepartment(department_id) FROM departments
