using static System.Console;
namespace ClassesAbstraraseInterfaces.Models
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public Pessoa() {}
        public Pessoa(string nome)
        {
            Nome = nome;
        }

        public virtual void Apresentar()
        {
            WriteLine($"Meu nome é {Nome}");
        }
    }
}