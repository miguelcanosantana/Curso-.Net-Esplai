USE MiguelCanoLibrary
GO

CREATE TABLE Socio (
	IdSocio INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	CodigoSocio CHAR(15) NOT NULL,
	DNISocio CHAR(9) NOT NULL,
	TelefonoSocio VARCHAR(15) NOT NULL,
	NombreSocio NVARCHAR(50) NOT NULL,
	ApellidosSocio NVARCHAR(100) NOT NULL
);

CREATE TABLE Autor (
	IdAutor INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	NombreAutor NVARCHAR(150) NOT NULL,
);

CREATE TABLE Editorial (
	IdEditorial INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	NombreEditorial NVARCHAR(150) NOT NULL,
);

CREATE TABLE Libro (
	IdLibro INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	FK_IdEditorialActual INT FOREIGN KEY REFERENCES Editorial(IdEditorial),
	AnoEscrituraLibro INT NOT NULL,
	AnoEdicionLibro INT NOT NULL,
	FK_IdEditorialOriginal INT FOREIGN KEY REFERENCES Editorial(IdEditorial),
	ISBNLibro CHAR(13) NOT NULL
);

CREATE TABLE Libro_Autor (
	IdLibroAutor INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	FK_IdAutor INT FOREIGN KEY REFERENCES Autor(IdAutor),
	FK_IdLibro INT FOREIGN KEY REFERENCES Libro(IdLibro),
);

CREATE TABLE VolumenFisico (
	IdVolumenFisico INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	FK_IdLibro INT FOREIGN KEY REFERENCES Libro(IdLibro),
	EstaDeterioradoVolumenFisico BIT
);

CREATE TABLE Prestamo (
	IdPrestamo INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	FK_IdLibro INT FOREIGN KEY REFERENCES Libro(IdLibro),
	FechaPrestamo DATE NOT NULL,
	FechaRealDevolucion DATE,
	--FechaMaxPrestamo DATE DATEADD('SECOND',Time,'11-05-2015 14:00:00')
);
ALTER TABLE Prestamo ADD FechaMaxPrestamo AS DATEADD(DAY, 15, Prestamo.FechaPrestamo)