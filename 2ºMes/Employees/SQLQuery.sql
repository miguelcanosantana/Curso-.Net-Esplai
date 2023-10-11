USE MiguelCanoEmployees
GO


--Empleados de marketing con un salario minimo a X
SELECT first_name, last_name, salary FROM employees
WHERE department_id = (SELECT department_id FROM departments
WHERE department_name = 'Marketing') AND salary >=10000


--Empleados que no tienen jefe
SELECT first_name, last_name FROM employees
WHERE manager_id IS NULL


--Sacar empleados de un departamento sin tener su ID (Meter una subconsulta dentro de otra)
SELECT first_name, last_name FROM employees
WHERE department_id = (SELECT department_id FROM departments
WHERE department_name = 'Marketing')


--Averiguar el ID del departamento de Marketing
SELECT department_id FROM departments
WHERE department_name = 'Marketing'


--Hacer algo y Ordenar empleados
SELECT first_name, last_name FROM employees
WHERE salary >= 11000
ORDER BY first_name, last_name


--Listar empleados que empiezan por S y tengán salario superior a X
SELECT first_name, last_name FROM employees
WHERE first_name LIKE 'S%' AND salary >= 10000


--Listar empleados cuyo nombre acaba por S
SELECT first_name, last_name FROM employees
WHERE first_name LIKE '%S'


--Listar empleados cuyo nombre tiene S con 4 caracteres detrás
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

