USE MiguelCanoLimpieza
GO


--Crear las tablas de nuevo (Insertar primero las que no tienen FK para evitar errores)
INSERT INTO Cliente
VALUES 
('99999999S','Miguel Cano','Programador'), 
('99996666S','Pepa','Dueña de una fábrica de Donuts'), 
('55555666S','Pepe','Dueña de un hospital de ballenas')
SELECT * FROM Cliente

INSERT INTO Limpiador
VALUES 
('79999999S','María','640215127', 'Calle Amargura, 13'), 
('89996666S','Curro','763364664', 'Calle Sucia, 7')
SELECT * FROM Limpiador

INSERT INTO Servicio
VALUES 
('Limpieza Tipo A',500), 
('Limpieza Tipo B',1000)
SELECT * FROM Servicio

INSERT INTO Contrato
VALUES 
(3,1,55), 
(30,2,4500), 
(15,3,6700)
SELECT * FROM Contrato

INSERT INTO Trabajo
VALUES 
('2023-10-23', 2, 1), 
('2022-10-25', 1, 2)
SELECT * FROM Trabajo

INSERT INTO Contrato_Servicio
VALUES 
(1,2), 
(2,1),
(3,2)
SELECT * FROM Contrato_Servicio


INSERT INTO Factura
VALUES 
(45,1), 
(55,2),
(65,3)
SELECT * FROM Factura





