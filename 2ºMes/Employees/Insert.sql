USE MiguelCanoEmployees
GO

INSERT INTO dependents (first_name, last_name, relationship, employee_id) VALUES
	('Paco', 
	'Pepon', 
	'Child',
	(SELECT employees.employee_id FROM employees
	 WHERE employee_id = 126
	))

SELECT * FROM dependents
WHERE employee_id = 126


--Increment a 10% of IT salary
UPDATE employees SET salary = salary + (salary / 10) FROM employees
	INNER JOIN departments
	ON departments.department_id = employees.department_id
WHERE department_name = 'IT'

SELECT salary FROM employees
	INNER JOIN departments
	ON departments.department_id = employees.department_id
WHERE department_name = 'IT'
