USE MiguelCanoCinemas


--Mostrar nombre pel�cula
SELECT Nombre FROM PELICULAS

--Mostrar edades pel�culas
SELECT DISTINCT CalificacionEdad FROM PELICULAS

--Mostrar pel�culas sin calificaci�n
SELECT * FROM PELICULAS
WHERE CalificacionEdad IS NULL

--MOSTRAR SALAS QUE NO PROYECTAN PEL�CULAS
SELECT * FROM SALAS
WHERE Pelicula IS NULL

--MOSTRAR SALAS Y PELICULAS PROYECTADAS EN ELLAS�
SELECT * FROM SALAS
LEFT JOIN PELICULAS
ON SALAS.Pelicula = PELICULAS.Codigo