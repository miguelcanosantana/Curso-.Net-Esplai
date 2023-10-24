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