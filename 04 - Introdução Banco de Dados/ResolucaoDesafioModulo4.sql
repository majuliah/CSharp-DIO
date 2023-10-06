use DesafioDio;

select * from filmes;

--1 Selecione o nome e o ano dos filmes
select Nome, Ano from filmes;

--2 Buscar o nome e ano dos filmes, ordenados por ordem crescente pelo ano
select Nome, Ano from filmes ORDER BY Ano;

--3 Buscar pelo filme de volta para o futuro, trazendo o nome, ano e a duração
select Nome, Ano, Duracao from filmes where Nome = 'De volta para o Futuro';

--4  Buscar os filmes lançados em 1997
select * from filmes where Ano = 1997;

--5 - Buscar os filmes lançados APÓS o ano 2000
select * from filmes where Ano > 2000;

--5.1 - Buscar os filmes lançados APÓS o ano 2000 em ordem crescente
select * from filmes where Ano > 2000 ORDER BY Ano;

--6 - Buscar os filmes com a duracao maior que 100 e menor que 150, ordenando pela duracao em ordem crescente
select * from Filmes WHERE Duracao > 100 AND Duracao < 150 ORDER BY Duracao;

--7 - Buscar a quantidade de filmes lançadas no ano, agrupando por ano, ordenando pela duracao em ordem decrescente


-- 8 - Buscar os Atores do gênero masculino, retornando o PrimeiroNome, UltimoNome
Select * from Atores;
select PrimeiroNome, UltimoNome, Genero from Atores WHERE Genero = 'M';

--9 - Buscar os Atores do gênero feminino, retornando o PrimeiroNome, UltimoNome, e ordenando pelo PrimeiroNome
select PrimeiroNome, UltimoNome, Genero from Atores WHERE Genero = 'F' ORDER BY PrimeiroNome;

--10 - Buscar o nome do filme e o gênero
select * from filmes;

--11 - Buscar o nome do filme e o gênero do tipo "Mistério"


--12 - Buscar o nome do filme e os atores, trazendo o PrimeiroNome, UltimoNome e seu Papel