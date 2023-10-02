using System;
using HerancaEpolimorfismo.Model;
using static System.Console;

namespace HerancaEpolimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Herança -> Reaproveitamento de código, possibilita incremento de infomações nas classes herdadas
             * O que tem em comum agrupamos em uma única classe, e depois extendemos em outras classes herdadas atributos somente da classe específica (? eu entendi isso kk)
             * 
             * Polimorfismo -> Alteração feita na classe que herda para que ela se adeque a seu contexto, é a sobrescrita de métodos, deixando -os com comportamentos diferentes em cada classe que for implementado.
             * 
             */

            Aluno pedro = new Aluno();
            pedro.Nome = "Pedro Castro";
            pedro.Idade = 20;
            pedro.EmailInstitucuional = "emailinstitucional@email.com";
            pedro.NotaUm = 7.4;

            Professor geraldo = new Professor();
            geraldo.Nome = "Geraldo ANtunes";
            geraldo.Salario = 6400.0;
            
            
        }
    }
}