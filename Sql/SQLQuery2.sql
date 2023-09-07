
CREATE PROCEDURE AddImpiegato
	 @Cognome NVARCHAR(20),
    @Nome NVARCHAR(20),
    @CodiceFiscale NVARCHAR(16),
    @Eta INT,
    @RedditoMensile MONEY,
	@Detrazione BIT,
    @IdImpiego INT
AS
BEGIN
	insert into Impiegato
	Values ( @Cognome,@Nome, @CodiceFiscale, @Eta,@RedditoMensile,@Detrazione,@IdImpiego)
END
GO
