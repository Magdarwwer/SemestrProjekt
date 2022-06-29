
CREATE TABLE Atlas
(
[nazwa] VARCHAR(20) PRIMARY KEY NOT NULL,
[stanowisko] NVARCHAR(50) NOT NULL,
[podlewanie] NVARCHAR(50) NOT NULL,
[domowa] BIT NOT NULL,	
[ogrodowa] BIT NOT NULL,
[nawozenie] VARCHAR(30) NOT NULL,
[choroby] VARCHAR(100) NOT NULL,
)
GO

--Tabela MOJE_ROSLINY

CREATE TABLE Moje_rosliny(
[imie] VARCHAR(25) NOT NULL PRIMARY KEY,
[nazwa] VARCHAR(20) NOT NULL UNIQUE,
[ostatnie_podlewanie] date DEFAULT GetDate() CHECK(ostatnie_podlewanie<= GetDate()) ,
[ostatnie_nawozenie] date DEFAULT GetDate() CHECK(ostatnie_nawozenie <= GetDate()) ,
[przebyte_choroby] VARCHAR(50),
FOREIGN KEY (nazwa) REFERENCES Atlas(nazwa) ON DELETE NO ACTION ON update cascade, 
)
GO

--tabela PODLEWANIE

CREATE TABLE Podlewanie(
[id] INT NOT NULL PRIMARY KEY IDENTITY,
[imie] VARCHAR(25) NOT NULL,
[nazwa] VARCHAR(20) NOT NULL,
[data_pierwszego_podlania] DATE DEFAULT GetDate() CHECK(data_pierwszego_podlania<= GetDate()),
FOREIGN KEY (nazwa) REFERENCES Atlas(nazwa) ON DELETE NO ACTION ON update NO ACTION,
FOREIGN KEY (imie) REFERENCES Moje_rosliny(imie) ON DELETE NO ACTION ON update NO ACTION,
)
GO

--Tabela nawozenie

CREATE TABLE Nawozenie(
[id] INT NOT NULL PRIMARY KEY IDENTITY,
[imie] VARCHAR(25) NOT NULL,
[nazwa] VARCHAR(20) NOT NULL,
[data_pierwszego_nawozenia] DATE DEFAULT GetDate() CHECK(data_pierwszego_nawozenia<= GetDate()),
FOREIGN KEY (nazwa) REFERENCES Atlas(nazwa) ON DELETE NO ACTION ON update NO ACTION,
FOREIGN KEY (imie) REFERENCES Moje_rosliny(imie) ON DELETE NO ACTION ON update NO ACTION,
)
GO

--Tabela uslugi

CREATE TABLE Choroby(
[id] INT  NOT NULL PRIMARY KEY,
[nazwa_choroby] VARCHAR(30) NOT NULL,
[leczenie] VARCHAR(110) NOT NULL,
[skutki_choroby] VARCHAR(110) NOT NULL,
[jakich_roslin_dotyczy] VARCHAR(20) NOT NULL,
FOREIGN KEY (jakich_roslin_dotyczy) REFERENCES Moje_rosliny(nazwa) ON DELETE NO ACTION ON update cascade,
)
GO


