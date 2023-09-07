CREATE PROCEDURE ModificaImpiegato
	@IdImpiegato int,
	@Cognome NVARCHAR(20),
    @Nome NVARCHAR(20),
    @CodiceFiscale NVARCHAR(16),
    @Eta INT,
    @RedditoMensile MONEY,
	@Detrazione BIT,
    @IdImpiego INT
AS
BEGIN
	Update Impiegato
	set Cognome=@Cognome,
	Nome=@Nome, 
	CodiceFiscale=@CodiceFiscale, 
	Eta=@Eta,
	RedditoMensile=@RedditoMensile,
	Detrazione=@Detrazione,
	IdImpiego=@IdImpiego
	where IdImpiegato=@IdImpiegato
END
GO
