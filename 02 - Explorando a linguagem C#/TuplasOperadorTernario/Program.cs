using System;
using TuplasOperadorTernario.Models;
using static System.Console;

namespace TuplasOperadorTernario
{
    class Program
    {
        static void Main(string[] args)
        {
            //tupla
            ValueTuple<int, string, string, decimal> outraTupla = (1, "Majulha", "Carvalho", 1.57m);
            
            WriteLine(outraTupla);
            WriteLine(outraTupla.Item1);
            WriteLine(outraTupla.Item2);
            WriteLine(outraTupla.Item3);
            
            //outra sintaxe para tuplas
            (int Id, string Nome, string Sobrenome) tupla = (32, "Maria Júlia", "Carvalho");
            WriteLine(tupla.Id);
            WriteLine(tupla.Nome);
            WriteLine(tupla.Sobrenome);
            
            //tuplas em métodos
            //testando método com tuplas

            LeituraArquivos arquivo = new LeituraArquivos();
            var (sucesso, linhasArquivo, quantidadeLinhas) = arquivo.LerArquivo(@"C:\Users\majul\Documents\CSharp-Dio\02 - Explorando a linguagem C#\ExcessoesEcolecoes\Arquivos\leitura.txt\");

            if (sucesso)
            {
                foreach (var linha in linhasArquivo)
                {
                    WriteLine($"Quantidade linhas arquivo: {quantidadeLinhas}");
                    WriteLine(linha);
                }
            }
            else
            {
                WriteLine("Não foi possível lero arquivo");
            }
            
            //descarte de informações
            var (sucesso1, linhasArquivo2, _) = arquivo.LerArquivo(@"C:\Users\majul\Documents\CSharp-Dio\02 - Explorando a linguagem C#\ExcessoesEcolecoes\Arquivos\leitura.txt\");
            //basta substituir os dados que não serão usados por "_"
            
            //desconstrutor
            //if ternário

            int numero = 20;
            
            if (numero % 2 == 0)
            {
                WriteLine("Par");
            }
            else
            {
                WriteLine("Impar");
            }

            string resposta = numero % 2 == 0 ? "Par" : "Impar";


        }
    }
}
