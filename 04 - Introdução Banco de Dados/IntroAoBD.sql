CREATE DATABASE exemploDio;

use exemploDio;

CREATE TABLE [dbo].[Clientes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](255) NULL,
	[Sobrenome] [varchar](255) NULL,
	[Email] [varchar](255) NULL,
	[AceitaComunicados] [bit] NULL,
	[DataCadastro] [datetime2](7) NULL
) ON [PRIMARY]
GO

-- Inserção de dados


--seleção de dados
SELECT * FROM Clientes; --seleciona os dados de uma tabela
SELECT * FROM Clientes ORDER BY Nome; --crescente
SELECT * FROM Clientes ORDER BY Nome DESC; --decrescente
SELECT * FROM Clientes ORDER BY Nome, Sobrenome;

SELECT * FROM Clientes WHERE Nome = 'Adam' AND Sobrenome = 'Reynolds' ORDER BY Nome, Sobrenome;
SELECT * FROM Clientes WHERE AceitaComunicados = 1 ORDER BY Nome, Sobrenome;
SELECT * FROM Clientes WHERE Nome LIKE 'G%'; --começa com G
SELECT * FROM Clientes WHERE Nome LIKE '%S'; --termina com S
SELECT * FROM Clientes WHERE Nome LIKE '%S%'; --possui a letra g no nome independente da posição


--inserindo dados
INSERT INTO Clientes(Nome, Sobrenome, Email, AceitaComunicados, DataCadastro) VALUES ('Majulia', 'Carvalho', 'majulia@email.com', 1, GETDATE());
INSERT INTO Clientes VALUES ('Maraju', 'Alves', 'maaraju@email.com', 0, GETDATE());

--update
SELECT * FROM Clientes WHERE Nome = 'Adam';

UPDATE Clientes SET Email = 'emailDele@email.com' WHERE Id = 352;
UPDATE Clientes SET Email = 'emailEmail@email.com', AceitaComunicados = 0 WHERE Id = 352;
--jamais fazer update sem where

BEGIN TRANSACTION
Delete Clientes
ROLLBACK

--tipos de dados
-- char, varchar, text, rchar, rvarchar, rtext, tbinary, varbinary, image(não reomendado armazenar imagens no banco)

CREATE TABLE Produtos(
    Id int IDENTITY(1,1) PRIMARY KEY NOT NULL,
    Nome VARCHAR(255) NOT NULL,
    Cor VARCHAR(50) NULL,
    Valor DECIMAL(13,2) NOT NULL,
    Tamanho VARCHAR(5) NULL
)