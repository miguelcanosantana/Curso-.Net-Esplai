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


ALTER FUNCTION TodaysDayMonthOrYear
(
@selectedOption int --1 is day, 2 is month, 3 is year
)
RETURNS INT
AS
BEGIN

	DECLARE @resultado INT

	IF (@selectedOption = 1) 
		SET @resultado = DAY(GETDATE());

	ELSE IF (@selectedOption = 2) 
		SET @resultado =  MONTH(GETDATE());

	ELSE IF (@selectedOption = 3) 
		SET @resultado = YEAR(GETDATE());

	RETURN @resultado
END

GO 

--Use Function
SELECT dbo.TodaysDayMonthOrYear(3)