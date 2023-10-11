USE MiguelCanoEmployees
GO


--Listar empleados que empiezan por S y teng�n salario superior a X
SELECT first_name, last_name FROM employees
WHERE first_name LIKE 'S%' AND salary >= 10000


--Listar empleados cuyo nombre acaba por S
SELECT first_name, last_name FROM employees
WHERE first_name LIKE '%S'


--Listar empleados cuyo nombre tiene S con 4 caracteres detr�s
SELECT first_name, last_name FROM employees
WHERE first_name LIKE 'S____'


--Listar empleados cuyo nombre empieza por S
SELECT first_name, last_name FROM employees
WHERE first_name LIKE 'S%'


--Listar empleados con sueldo igual o superior a X
SELECT first_name, last_name FROM employees
WHERE salary >= 13000

--Listar empleados del departamento de Marketing
SELECT first_name, last_name FROM employees
WHERE department_id = 2

