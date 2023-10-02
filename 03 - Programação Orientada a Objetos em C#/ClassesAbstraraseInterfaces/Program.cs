using System;
using static System.Console;
using ClassesAbstraraseInterfaces.Models;

namespace ClassesAbstraraseInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Classes abstratas: não podem ser instanciadas. são apenas moldes e devem ser alteradas no momento da herança
             *
             * Classe e método selada: a classe não pode ser herdada de maneira alguma
             *
             * Classe object -> mãe de todas as classes. É o topo da hierarquia das classes que criamos, provêm serviços de baixo nível das classes filhas.
             *
             * interface: muito parecida com classe abstrata. Mas a interface é um contrato que a classe se propõe a cumprir.
             * Não possuem implementação, só nas classes que as implementarem. supre a necessidade de herança múltipla que não pode ser realizada. classes podem implementar diversas interfaces
             * 
             * 
             */
            
            //tentando instanciar classe abstrata:
            //Conta conta = new Conta(); //não serve para ser instanciada
            
            Corrente conta1 = new Corrente();
            conta1.Creditar(500);
            conta1.ExibirSaldo();

            Computador comp = new Computador();
            WriteLine(comp);

            Calculadora calcula = new Calculadora();
            calcula.Somar(1, 2);
        }
    }
}