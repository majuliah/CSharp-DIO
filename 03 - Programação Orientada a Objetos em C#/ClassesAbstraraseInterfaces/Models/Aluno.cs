namespace ClassesAbstraraseInterfaces.Models
{
    public sealed class Aluno : Pessoa
    {
        public Aluno(string nome) : base(nome)
        {
            //recebendo o parâmetro e passando para a classe pai, ou seja, pessoa, como se eu estivesse usando o construtor de pessoa e não de aluno
        }
    }
}