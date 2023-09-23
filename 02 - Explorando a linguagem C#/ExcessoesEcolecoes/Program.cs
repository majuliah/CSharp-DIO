using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using ExcessoesEcolecoes.Models;
using static System.Console;

namespace ExcessoesEcolecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            // //Exceptions
            // //Leitura de Arquivos
            //
            // string[] linhas = File.ReadAllLines(@"C:\Users\majul\Documents\CSharp-Dio\02 - Explorando a linguagem C#\ExcessoesEcolecoes\Arquivos\leitura.txt");
            //
            // foreach (var linha in linhas)
            // {
            //     WriteLine(linha);                
            // }
            //
            // //exceptions
            // try
            // {
            //     string[] linhas2 =
            //         File.ReadAllLines(
            //             @"C:\Users\majl\Documents\CSharp-Dio\02 - Explorando a linguagem C#\ExcessoesEcolecoes\Arquivos\leitura.txt");
            //
            //     foreach (var linha in linhas2)
            //     {
            //         WriteLine(linha);
            //     }
            // }
            // catch (FileNotFoundException exception)
            // {
            //     WriteLine($"Aquivo não encontrado {exception.Message}");
            // }
            // catch (DirectoryNotFoundException exception)
            // {
            //     WriteLine($" Ocorreu um erro ao achar o diretório {exception.Message}");
            // }
            // catch (Exception exception)
            // {
            //     WriteLine($" Ocorreu uma exceção genérica {exception.Message}");
            // }
            // finally
            // {
            //     WriteLine("chegamos até aqui 😊");
            //     //executa independente de erro
            // }
            //
            // //usando o throw
            //
            // new ExemploExcecao().Metodo1();
            
            //Introdução a filas
            // Fila -> First in first out

            Queue name = new Queue();
            name.Enqueue(2);
            name.Enqueue(3);
            name.Enqueue(4);
            
            foreach (var variable in name)
            {
                WriteLine(variable);
            }
            
            name.Dequeue();
            name.Dequeue();
            name.Dequeue();
            
            foreach (var variable in name)
            {
                WriteLine(variable);
                WriteLine("finish");
            }

            Queue<int> fila = new Queue<int>();
            Queue<string> filaString = new Queue<string>();
            
            
            //introdução a pilha -> stack -> lifo
            Stack<int> pilha = new Stack<int>();
            pilha.Push(1);
            pilha.Push(10);
            pilha.Push(100);
            pilha.Push(1000);
            pilha.Push(10000);
            pilha.Push(100000);
            pilha.Push(1000000);
            pilha.Push(100000);
            pilha.Push(10000);
            pilha.Push(1000);
            pilha.Push(100);
            pilha.Push(10);
            pilha.Push(1);

            foreach (var item in pilha)
            {
                WriteLine(item);
            }
            
            pilha.Pop();
            pilha.Pop();
            pilha.Pop();
            pilha.Pop();
            pilha.Pop();
            pilha.Pop();
            pilha.Pop();
            pilha.Clear();
            
            foreach (var item in pilha)
            {
                WriteLine(item);
            }
            
            //dictionary

            Dictionary<string, string> estados = new Dictionary<string, string>();
            estados.Add("RJ","Rio de Janeiro");
            estados.Add("MG", "Minas Gerais");
            estados.Add("SP", "São Paulo");

            foreach (KeyValuePair<string, string> value in estados)
            {
                WriteLine($"Chave: {value.Key} Value: {value.Value}");
            }

            estados.Remove("BA");
            //somente deleta a chave
            
            foreach (KeyValuePair<string, string> value in estados)
            {
                WriteLine($"Chave: {value.Key} Value: {value.Value}");
            }
            
            //possível alterar o VALOR mas a chave não
            estados["RJ"] = "Volta Redonda RJ";

            foreach (var value in estados)
            {
                WriteLine($"Chave: {value.Key} Value: {value.Value}");
            }

            string chave = "BA";

            if (estados.ContainsKey(chave))
                WriteLine($"{chave} existe");
            else
                WriteLine("Não existe, tente adicionar");
            
            WriteLine(estados["MG"]); // -> retorna o valor da chave
            
        }
    }
}