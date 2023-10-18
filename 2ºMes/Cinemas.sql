USE MiguelCanoCinemas


--Mostrar nombre película
SELECT Nombre FROM PELICULAS

--Mostrar edades películas
SELECT DISTINCT CalificacionEdad FROM PELICULAS

--Mostrar películas sin calificación
SELECT * FROM PELICULAS
WHERE CalificacionEdad IS NULL

--MOSTRAR SALAS QUE NO PROYECTAN PELÍCULAS
SELECT * FROM SALAS
WHERE Pelicula IS NULL

--MOSTRAR SALAS Y PELICULAS PROYECTADAS EN ELLAS
SELECT * FROM SALAS
LEFT JOIN PELICULAS
ON SALAS.Pelicula = PELICULAS.Codigo

--MOSTRAR PELICULAS Y SALAS SI SE PROYECTAN EN ELLAS
SELECT * FROM PELICULAS
LEFT JOIN SALAS
ON SALAS.Pelicula = PELICULAS.Codigo

--MOSTRAR NOMBRE PELICULAS NO PROYECTADAS EN NINGUNA SALA
SELECT DISTINCT PELICULAS.Nombre FROM PELICULAS
WHERE 0 =
    (SELECT COUNT(SALAS.Pelicula) FROM SALAS
     WHERE SALAS.Pelicula = PELICULAS.Codigo)

--WHERE EXISTS
--    (SELECT * FROM SALAS
--     WHERE SALAS.Pelicula IS NULL)

--INNER JOIN SALAS
--ON SALAS.Pelicula IS NULL