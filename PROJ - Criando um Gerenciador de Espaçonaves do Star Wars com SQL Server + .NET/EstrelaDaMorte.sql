CREATE DATABASE EstrelaDaMorte;

USE EstrelaDaMorte;

CREATE TABLE Planeta
(
    IdPlaneta INT NOT NULL,
    NomePlaneta VARCHAR(50) NOT NULL,
    Rotacao FLOAT NOT NULL,
    Orbita FLOAT NOT NULL,
    Diametro FLOAT NOT NULL,
    Clima VARCHAR(50) NOT NULL,
    Populacao INT NOT NULL
);

ALTER TABLE Planeta ADD CONSTRAINT PK_Planeta PRIMARY KEY (IdPlaneta);

CREATE TABLE Nave
(
    IdNave INT NOT NULL,
    NomeNave VARCHAR(50) NOT NULL,
    Modelo VARCHAR(60) NOT NULL,
    Passageiros INT NOT NULL,
    Carga FLOAT NOT NULL,
    Classe VARCHAR(50) NOT NULL
);

ALTER TABLE Nave ADD CONSTRAINT PK_Nave PRIMARY KEY (IdNave);

CREATE TABLE Piloto
(
    IdPiloto INT NOT NULL,
    NomePiloto VARCHAR(100) NOT NULL,
    AnoNascimento VARCHAR(10) NOT NULL,
    IdPlaneta INT NOT NULL
);

GO

ALTER TABLE Piloto ADD CONSTRAINT PK_Piloto PRIMARY KEY(IdPiloto);

GO

ALTER TABLE Piloto ADD CONSTRAINT FK_Piloto_Planeta FOREIGN KEY (IdPlaneta) REFERENCES Planeta (IdPlaneta);

CREATE TABLE PilotosNaves
(
    IdPiloto INT NOT NULL,
    IdNave INT NOT NULL,
    FlagAutorizado BIT NOT NULL
);

ALTER TABLE PilotosNaves ADD CONSTRAINT PK_PilotosNaves PRIMARY KEY (IdPiloto, IdNave)
GO
ALTER TABLE PilotosNaves ADD CONSTRAINT FK_PilotosNaves_Pilotos FOREIGN KEY (IdPiloto) REFERENCES Piloto (IdPiloto)
GO
ALTER TABLE PilotosNaves ADD CONSTRAINT FK_PilotosNaves_Naves FOREIGN KEY (IdNave) REFERENCES Nave (IdNave)
GO
ALTER TABLE PilotosNaves ADD CONSTRAINT DF_PilotosNaves_FlagAutorizado DEFAULT (1) FOR FlagAutorizado

CREATE TABLE HistoricoViagens
(
    IdPiloto INT NOT NULL,
    IdNave INT NOT NULL,
    DtSaida DATETIME NOT NULL,
    DtChegada DATETIME NULL,

    CONSTRAINT FK_HistoricoViagens_PilotosNaves FOREIGN KEY (IdPiloto, IdNave) REFERENCES PilotosNaves (IdPiloto, IdNave)    
);

ALTER TABLE HistoricoViagens CHECK CONSTRAINT FK_HistoricoViagens_PilotosNaves
