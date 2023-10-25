USE MiguelCanoLibrary
GO

DROP TABLE IF EXISTS Prestamo
DROP TABLE IF EXISTS VolumenFisico
DROP TABLE IF EXISTS Libro_Autor
DROP TABLE IF EXISTS Libro
DROP TABLE IF EXISTS Editorial
DROP TABLE IF EXISTS Autor
DROP TABLE IF EXISTS Socio


GO

CREATE TABLE Socio (
	IdSocio INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	CodigoSocio CHAR(15) NOT NULL,
	DNISocio CHAR(9) NOT NULL,
	TelefonoSocio VARCHAR(15) NOT NULL,
	NombreSocio NVARCHAR(50) NOT NULL,
	ApellidosSocio NVARCHAR(100) NOT NULL
);

GO

INSERT INTO Socio
VALUES
('744758905862648', '53831944P', '756429203', 'Miguel', 'Canoa Santacana'),
('174890984367845', '63537363L', '687583759', 'Pepa', 'Pepona'),
('123456789012345', '45678987N', '684658648', 'Pepe', 'Pepón');

CREATE TABLE Autor (
	IdAutor INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	NombreAutor NVARCHAR(150) NOT NULL,
);

GO

INSERT INTO Autor
VALUES
('Edgar Allan Poe'),
('Miguel de Cervantes'),
('Agatha Christie')

CREATE TABLE Editorial (
	IdEditorial INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	NombreEditorial NVARCHAR(150) NOT NULL,
);

GO

INSERT INTO Editorial
VALUES
('LibrosBaratosTop'),
('LibrosCarosTop'),
('LibrosParaLectoresTop')

CREATE TABLE Libro (
	IdLibro INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	NombreLibro NVARCHAR(150) NOT NULL,
	FK_IdEditorialActual INT FOREIGN KEY REFERENCES Editorial(IdEditorial),
	AnoEscrituraLibro INT NOT NULL,
	AnoEdicionLibro INT NOT NULL,
	FK_IdEditorialOriginal INT FOREIGN KEY REFERENCES Editorial(IdEditorial),
	ISBNLibro CHAR(13) NOT NULL
);

GO

INSERT INTO Libro
VALUES
('El gato blanco', 1, 1975, 2010, 2, '123-567-901-A'),
('El Quijote 3.2', 2, 1990, 1990, 3, '321-634-561-B'),
('Asesinato del Higo', 3, 1967, 2023, 2, '953-735-854-C'),
('El gato comete un asesinato al lado del higo', 2, 2000, 2022, 1, '996-667-757-D');

CREATE TABLE Libro_Autor (
	IdLibroAutor INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	FK_IdLibro INT FOREIGN KEY REFERENCES Libro(IdLibro),
	FK_IdAutor INT FOREIGN KEY REFERENCES Autor(IdAutor),
);

GO

INSERT INTO Libro_Autor
VALUES
(1, 1),
(2, 2),
(3, 3),
(2, 2),
(4, 1),
(4, 2),
(4, 3);

CREATE TABLE VolumenFisico (
	IdVolumenFisico INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	FK_IdLibro INT FOREIGN KEY REFERENCES Libro(IdLibro),
	EstaDeterioradoVolumenFisico BIT
);

GO

INSERT INTO VolumenFisico
VALUES
(1, 0),
(1, 1),
(2, 0),
(2, 1),
(3, 0),
(3, 1),
(4, 0),
(4, 1),
(4, 1);

CREATE TABLE Prestamo (
	IdPrestamo INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	FK_IdLibro INT FOREIGN KEY REFERENCES Libro(IdLibro),
	FechaPrestamo DATE NOT NULL,
	FechaMaxPrestamo AS DATEADD(DAY, 15, Prestamo.FechaPrestamo),
	FechaRealDevolucion DATE
);

GO

INSERT INTO Prestamo (FK_IdLibro, FechaPrestamo)
VALUES
(1, '10-24-2022'),
(1, '7-23-2021'),
(4, '2-12-2020'),
(3, '5-14-2005');

