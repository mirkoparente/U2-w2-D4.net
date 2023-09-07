--CREATE TABLE Impiego (
--    IdImpiego INT PRIMARY KEY IDENTITY,
--    TipoImpiego NVARCHAR(50) NOT NULL,
--    Data_Assunzione DATETIME
--);

--CREATE TABLE Impiegato (
--    IdImpiegato INT PRIMARY KEY IDENTITY,
--    Cognome NVARCHAR(20),
--    Nome NVARCHAR(20),
--    CodiceFiscale NVARCHAR(16),
--    Eta INT,
--    RedditoMensile MONEY,
--	Detrazione BIT,
--    IdImpiego INT,
--    FOREIGN KEY (IdImpiego) REFERENCES Impiego(IdImpiego)
--);

--INSERT INTO Impiego
--VALUES('Programmatore', 2023-05-12),('Help Desk', 2021-05-12),('Manager', 2018-05-12),('CyberSecuity', 2001-05-12),('Analista', 2000-05-12),('Consulente', 2023-05-12)

--INSERT INTO Impiegato 
--VALUES ('Rossi','Mario','POTNF56RTKMU67L9',50,1500,0,1),('Verdi','Gianni','GNNVRF56RTKMU67L',20,1200,0,2),('Gialli','Luca','GLLLC56RTKMU67L9',25,1500,1,4),('Pinco','Pallo','PNCNF56RTKMU67L9',50,1800,1,3),('Pippo','Pluto','PPTOF56RTKMU67L9',60,1600,0,5),('Rossi','Lucia','RSSLC56RTKMU67L9',30,1300,1,6)


SELECT * FROM Impiegato 
WHERE Eta > 29

SELECT * FROM Impiegato 
WHERE RedditoMensile >= 800

SELECT * FROM Impiegato 
WHERE Detrazione = 1

SELECT * FROM Impiegato 
WHERE Detrazione = 0

SELECT * FROM Impiegato 
WHERE Cognome like 'G%'

Select Count(*) AS TotaleImpiegati FROM Impiegato

Select SUM(RedditoMensile) AS TotaleRedditi FROM Impiegato


Select AVG(RedditoMensile) AS MediaRedditi FROM Impiegato

Select MAX(RedditoMensile) AS RedditoMaggiore FROM Impiegato

Select MIN(RedditoMensile) AS RedditoMinore FROM Impiegato

Select AVG(Eta) AS MediaEta FROM Impiegato


