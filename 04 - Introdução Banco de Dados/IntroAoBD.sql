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

DROP TABLE IF EXISTS dbo.Produtos

CREATE TABLE Produtos (
	Id int IDENTITY(1,1) PRIMARY KEY NOT NULL,
	Nome varchar(255) NOT NULL,
	Cor varchar(50) NULL,
	Preco decimal(13, 2) NOT NULL,
	Tamanho varchar(5) NULL,
	Genero char(1) NULL
)

SELECT * FROM Produtos;

--usando count
SELECT COUNT(*) TotalProdutos FROM Produtos;
SELECT COUNT(*) QuantidadeM FROM Produtos WHERE Tamanho = 'M';

--usando sum
SELECT SUM(Preco) PrecoTotal FROM Produtos;
SELECT SUM(Preco) PrecoTotal FROM Produtos WHERE Tamanho = 'P';

--usando max e min
SELECT MAX(Preco) PrecoMaximo FROM Produtos;
SELECT MIN(Preco) PrecoMinimo FROM Produtos;
SELECT MAX(Preco) PrecoMinimoG FROM Produtos WHERE Tamanho = 'G';

--usando media
SELECT AVG(Preco) PrecoMinimo FROM Produtos;

--concatenando colunas
SELECT Nome, Cor FROM Produtos;
SELECT Nome + ' - ' + Cor NomeEcor FROM Produtos;
SELECT Nome + ' - ' + Cor FROM Produtos;

--upper e lower
SELECT LOWER(Nome) + ' - ' + LOWER(Cor) FROM Produtos;
SELECT UPPER(Nome) + ' - ' + UPPER(Cor) FROM Produtos;

--adicionando nova coluna
ALTER TABLE Produtos ADD DataCadastro DATETIME2;
UPDATE Produtos SET DataCadastro = GETDATE();
DROP COLUMN DataCadastro;

SELECT * FROM Produtos;

--formatando datas
SELECT UPPER(Nome) + ' - ' + UPPER(Cor), FORMAT(DataCadastro, 'dd-MM-yyyy') DataDeCadastro FROM Produtos;

--entendendo o group by
SELECT 
	Tamanho,
	COUNT(*) Quantidade 
FROM Produtos
	WHERE Tamanho <> ''
	GROUP BY Tamanho
	ORDER BY Quantidade DESC;

--Primary Key -> chave única que identifica cada registro na tabela
--Foreign Key -> Chave que identifica um registro existente em outra tabela

CREATE TABLE Enderecos (
	Id INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	IdCliente int NULL,
	Rua VARCHAR(255) NULL,
	Bairro VARCHAR(255) NULL,
	Cidade VARCHAR(255) NULL,
	Estado CHAR(2) NULL,

	CONSTRAINT FK_ENDERECOS_CLIENTES FOREIGN KEY(IdCliente)
	REFERENCES Clientes(Id)
)

INSERT INTO  Enderecos VALUES (4,'Rua teste', 'Bairro Teste', 'Cidade Teste', 'MJ');

SELECT * FROM Clientes WHERE Id = 4;
SELECT * FROM Enderecos WHERE IdCliente = 4;

--INNER JOIN
SELECT * FROM Clientes INNER JOIN Enderecos ON Clientes.Id = Enderecos.IdCliente WHERE Clientes.Id = 4;
SELECT Clientes.Nome, Clientes.Sobrenome, Clientes.Email, Enderecos.Bairro, Enderecos.Cidade, Enderecos.Rua FROM Clientes INNER JOIN Enderecos ON Clientes.Id = Enderecos.IdCliente WHERE Clientes.Id = 4;
