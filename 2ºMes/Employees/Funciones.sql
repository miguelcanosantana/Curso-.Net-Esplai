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


-- 1- Función NombreDepartamento
-- recibe idDept, devuelve Nombre del dept
CREATE FUNCTION DepartmentName(@idDept INT) 
RETURNS VARCHAR(30)
AS
BEGIN
	DECLARE @departmentName VARCHAR(30)

	SELECT @departmentName = department_name FROM departments
	WHERE department_id = @idDept

	return @departmentName
END

GO 

--Use Function
SELECT dbo.DepartmentName(1)

 

-- 2- Función NumEmpsPosteriorA <fecha contratación>
-- recibe fechaContratación, devuelve num de emps
CREATE FUNCTION PostEmployees(@hireDate DATE) 
RETURNS INT
AS
BEGIN
	DECLARE @number INT

	SELECT @number = COUNT(*) FROM employees
	WHERE employees.hire_date > @hireDate

	return @number
END

GO 

--Use Function
SELECT dbo.PostEmployees('10-19-1995')

 

-- 3- Función NumEmpsCiudad 
-- recibe nombre ciudad, devuelve num de emps en esta ciudad
