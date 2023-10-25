USE MiguelCanoLibrary
GO

CREATE TABLE Socio (
	IdSocio INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	CodigoSocio CHAR(15) NOT NULL,
	DNISocio CHAR(9) NOT NULL,
	TelefonoSocio VARCHAR(15) NOT NULL,
	NombreSocio VARCHAR(50) NOT NULL,
	ApellidosSocio VARCHAR(100) NOT NULL
);