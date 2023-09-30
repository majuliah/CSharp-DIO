using System;
using static System.Console;

namespace IntroducaoAbstracaoEncapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Teoria sobre Orientação a Objetos");
            //Introdução a Orientação a objetos
            /*
             * POO é um paradigma e corresponde a uma técnica para um fim específico
             * Principais conceitos: Classes e objetos
             * Classes e objetos são moldes onde a classe é a representação de um objeto e um objeto é uma classe concretizada
             * 
             * Paradigmas existentes -> orientada a objetos, estruturada, imperativa, procedural, orientada a eventos, lógicas
             * O C# implementa diversos paradigmas não se limitando a orientação a objetos
             *
             * Abstração -> Pegar algo do mundo real e transformar em um objeto
             * Encapsulamento -> Proteger uma classe e definir limites para alterações, expõe somente o necessário
             * 
             */
            Pessoa Majulia = new Pessoa { Nome = "Maria Julia", Idade = 23 };
            
            //criação/instanciação
            Pessoa Vilgax = new Pessoa();
            Vilgax.Nome = "Vilgax Ben10";
            Vilgax.Idade = 300000;

            ContaCorrente conta1 = new ContaCorrente(123, 4000);
            conta1.Sacar(500);
            conta1.ExibirSaldo();
        }
    }

    public class Pessoa
    {
        //classe
        public string? Nome { get; set; }
        public int? Idade { get; set; }

        public string Apresentar()
        {
            return $"Olá, eu sou {Nome} e tenho {Idade} anos";
        }
        
        public Pessoa(){}
    }

    public class ContaCorrente
    {
        public ContaCorrente() { }
        public ContaCorrente( int numeroConta, decimal saldoInicial)
        {
            NumeroConta = numeroConta;
            saldo = saldoInicial;
        }
        
        public int NumeroConta { get; set; }
        private decimal saldo;

        public void Sacar(decimal valor)
        {
            if (saldo >= valor)
            {
                saldo -= valor;
                WriteLine("Saque realizado com sucesso!");
            }
            else
            {
                WriteLine("Saldo insuficiente");
            }
        }

        public void ExibirSaldo()
        {
            WriteLine($"Saldo disponível {saldo}");
        }
    }
    
}