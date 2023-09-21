using System.Collections.Generic;
using static System.Console;

namespace ManipulandoValores
{
    public class Curso
    {
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }

        public void AdicionarAluno(Pessoa aluno)
        {
            Alunos.Add(aluno);
        }

        public int ObterQuantidadeAlunosMatriculados()
        {
            return Alunos.Count;
        }

        public bool RemoveAluno(Pessoa aluno)
        {
            return Alunos.Remove(aluno);
        }
        
        public void ListarAlunos()
        {
            for (int i = 0; i < Alunos.Count; i++)
                WriteLine($"Nº {i+1} - {Alunos[i].NomeCompleto}");
            
        }
        
    }
}