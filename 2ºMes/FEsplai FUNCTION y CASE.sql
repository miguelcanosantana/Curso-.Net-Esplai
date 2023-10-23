
ALTER FUNCTION FechaDeHoy
(
)
RETURNS date
AS
BEGIN
	DECLARE @resultado date;
	SET @resultado = getdate();
	RETURN @resultado;
END
GO

SELECT dbo.FechaDeHoy()

-- devuelve el numero del dia
CREATE FUNCTION DiaDeHoy
(
)
RETURNS int
AS
BEGIN
	DECLARE @resultado int;
	SET @resultado = DAY(getdate());
	RETURN @resultado;
END

SELECT dbo.DiaDeHoy()


-- devuelve el numero del dia/mes/año, 
-- según el parametro que le pase
CREATE FUNCTION ValorDeHoy
(
	@opcion int -- 1 para dia, 2 para mes, 3 para el año
)
RETURNS int
AS
BEGIN
	DECLARE @resultado int = 0;

	if(@opcion=1)
		SET @resultado = DAY(getdate());
	else if(@opcion=2)
		SET @resultado = MONTH(getdate());
	else if(@opcion=3)
		SET @resultado = YEAR(getdate());

	if(@opcion=1)
		RETURN DAY(getdate());
	else if(@opcion=2)
		RETURN MONTH(getdate());
	else if(@opcion=3)
		RETURN YEAR(getdate());

	SET @resultado = 
		CASE @opcion
			WHEN 1 THEN DAY(getdate())
			WHEN 2 THEN MONTH(getdate())
			WHEN 3 THEN YEAR(getdate())
			ELSE 0
		END

	RETURN @resultado;
END