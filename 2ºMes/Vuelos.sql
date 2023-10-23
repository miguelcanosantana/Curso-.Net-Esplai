USE GerardMiguelVuelos
GO

-- Lista de vuelos con nombre de piloto, ordenados por fecha - Verificar
SELECT V.IdentificadorVuelo as 'Vuelo', P.NombrePiloto as 'Piloto', V.FechaVuelo
FROM Vuelo V INNER JOIN Piloto P
	ON V.FK_IdPiloto = P.IdPiloto
ORDER BY V.FechaVuelo


-- Num. de pasajero en cada vuelo (o en un vuelo concreto) - Verificar
SELECT V.IdentificadorVuelo as 'Vuelo', COUNT(P.IdPasajero) as 'Num pasajeros'
FROM PASAJERO P INNER JOIN VUELO V
	ON P.FK_IdVuelo = V.IdVuelo
ORDER BY V.IdentificadorVuelo


-- Lista de pilotos que hacen Intercontinental
SELECT *
FROM Piloto
WHERE HaceInterContinentalPiloto = 1


-- Total de asientos ocupados en cada clase para un vuelo - ESTE NO

-- Lista de pilotos que no vuelan
SELECT *
FROM Piloto P
WHERE 0 = (SELECT COUNT(FK_IdPiloto) FROM Vuelo WHERE FK_IdPiloto = P.IdPiloto)


-- Lista de pilotos con todos los servicios en false
SELECT *
FROM Piloto
WHERE HaceContinentalPiloto = 0 AND
	HaceInterContinentalPiloto = 0 AND
	HaceNacionalPiloto = 0


-- Nombres de pilotos que hayan volado a Madrid
SELECT P.NombrePiloto FROM Piloto P
	INNER JOIN Vuelo
	ON IdPiloto = Vuelo.FK_IdPiloto
	INNER JOIN Aeropuerto
	ON Vuelo.FK_IdAeropuertoDestinoAvion = Aeropuerto.IdAeropuerto
	WHERE Aeropuerto.NombreAeropuerto LIKE 'Madrid'


-- Nombres de pilotos que no hayan volado a BCN
SELECT P.NombrePiloto FROM Piloto P
	INNER JOIN Vuelo
	ON IdPiloto = Vuelo.FK_IdPiloto
	INNER JOIN Aeropuerto
	ON Vuelo.FK_IdAeropuertoDestinoAvion = Aeropuerto.IdAeropuerto
	WHERE Aeropuerto.NombreAeropuerto NOT LIKE 'Barcelona'

-- Num. de vuelos pilotados por pilotos intercontinentales
SELECT COUNT(*) AS 'Número de vuelos pilotados intercontinentales' FROM Vuelo
	INNER JOIN Piloto
	ON IdPiloto = FK_IdPiloto
	WHERE Piloto.HaceInterContinentalPiloto = 1

-- Num. de vuelos con destino a BCN
SELECT COUNT(*) AS 'Número de vuelos Destino = Barcelona' FROM Vuelo
	INNER JOIN Aeropuerto
	ON FK_IdAeropuertoDestinoAvion = Aeropuerto.IdAeropuerto
	WHERE Aeropuerto.NombreAeropuerto LIKE 'BARCELONA'