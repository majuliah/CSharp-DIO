using System;
using System.Collections.Generic;
using static System.Console;

namespace ProrpiedadesMetodosConstrutores
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Hello World!");
            Pessoa marlon = new Pessoa { Nome = "Marlon", Sobrenome = "Lagos",Idade = 12 };
            marlon.Apresentar();

            Pessoa eduardo = new Pessoa { Nome = "Eduardo", Sobrenome = "Pessoa", Idade = 20};
            eduardo.Apresentar();

            Curso ingles = new Curso{ Nome = "Ingles Intermediario", Alunos = new List<Pessoa>()};
            ingles.AdicionarAluno(marlon);
            ingles.AdicionarAluno(eduardo);
            
            ingles.ListarAlunos();
        }
    }
}