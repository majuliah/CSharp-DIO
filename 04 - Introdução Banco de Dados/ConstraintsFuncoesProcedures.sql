ALTER TABLE Produtos 
ADD CONSTRAINT CHK_ColunaGenero CHECK(Genero = 'U' OR Genero = 'M' OR Genero = 'F');


ALTER TABLE Produtos
ADD DEFAULT GETDATE() FOR DataCadastro;

--apagando uma constraint
ALTER TABLE Produtos DROP CONSTRAINT CHK_ColunaGenero;

--stored procedure Insert
CREATE PROCEDURE InserirNovoProduto
@Nome VARCHAR(255),
@Cor VARCHAR(50),
@Preco decimal,
@Tamanho VARCHAR(5),
@Genero CHAR(1)
AS
INSERT INTO Produtos (Nome, Cor, Preco, Tamanho, Genero)
VALUES (@Nome, @Cor, @Preco, @Tamanho, @Genero);

--usar procedure
EXECUTE InserirNovoProduto 'NovoProd', 'Colorido', 50, 'G', 'U';
EXEC InserirNovoProduto 'NovoProd', 'Colorido', 50, 'G', 'U';

--stored procedure Select
CREATE PROCEDURE ObterProdutosPorTamanho
@TamanhoProd VARCHAR(5)

AS
SELECT * FROM Produtos WHERE Tamanho = 'M';

--usar procedure
EXECUTE ObterProdutosPorTamanho;


--Functions

SELECT 
    Nome,
    Preco,
    FORMAT(Preco - Preco / 100 * 10, 'N2' PrecoComDesconto)
FROM Produtos WHERE Tamanho = 'M';


CREATE FUNCTION CalcularDesconto(@Preco DECIMAL(13,2), @Porcentagem INT)
RETURNS DECIMAL(13,2)
BEGIN
    RETURN(@Preco - @Preco / 100 * @Porcentagem)
END;

SELECT Nome, Preco, dbo.CalcularDesconto(Preco, 10) PrecoComDesconto
FROM Produtos WHERE Tamanho = 'M';