using System;
using static System.Console;

namespace StackHeapGarbage
{
    class Program
    {
        static void Main(string[] args)
        {
            //Introdução aos tipos de memória   
            //Stack -> variáveis de menor "peso", LIFO, também podem carregar a referência de um local da heap
            //Heap -> valores de "maior peso", tipos complexos (listas, arrays, classes ,etc)
            
            //Limpeza de memória
            //Garbage Collector -> Limpeza da heap, limpa variáveis sem referência
            
            //Tipo valor: Armazena o valor nele mesmo, mais simples, ficam na stack, tipos primitivos
            //Tipos referência: valores complexos, armazenam apenas uma referência a um objeto a memória heap
            
            //duas variáveis que apontam para o mesmo objeto, qualquer uma que for alterada, alterará o objeto também.
            //atribuidno tipo referência
            Pessoa p1 = new Pessoa {Nome = "Majulha", Sobrenome = "Carvalho"};
            Pessoa p2 = new Pessoa {Nome = "Maju", Sobrenome = "Alves"};
            
            WriteLine($"Nome p1: {p1.Nome} e nome da p2: {p2.Nome}");

            Pessoa p3 = p1;
            p3.Nome = "Pingo";
            WriteLine($"Nome p1: {p1.Nome} e nome da p3: {p3.Nome}");

            //atribuindo tipo valor
            int a = 10;
            int b = a;
            WriteLine($"Valor a: {a}, valor b {b}");

            a += 10;
            WriteLine($"Valor a: {a}, valor b {b}");


        }
    }
}