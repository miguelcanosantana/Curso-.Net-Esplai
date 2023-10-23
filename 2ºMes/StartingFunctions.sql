--Create / Alter function
ALTER FUNCTION TodaysDate
(
--Parameters go here
)
RETURNS DATE

AS

BEGIN
	DECLARE @resultado DATE; --Variable
	SET @resultado = GETDATE(); --Asignar valor a variable
	RETURN @resultado;
END

GO --Use go to execute the next code in a next transaction

--Use Function
SELECT dbo.TodaysDate()