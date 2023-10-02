using static System.Console;
namespace HerancaEpolimorfismo.Model
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        
        //permite que as classes que herdam de pessoa mudem os comportamentos dos métodos
        public virtual void Apresentar()
        {
            WriteLine($"Eu sou {Nome} e tenho {Idade}");
        }
    }
}