CREATE PROCEDURE EliminaImpiegato
	 @IdImpiegato int
AS
BEGIN
	Delete from Impiegato 
	where IdImpiegato=@IdImpiegato
END
GO
