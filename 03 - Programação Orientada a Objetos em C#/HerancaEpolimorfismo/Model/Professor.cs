using static System.Console;
namespace HerancaEpolimorfismo.Model
{
    public class Professor : Pessoa
    {
        public double Salario { get; set; }

        public override void Apresentar()
        {
            WriteLine($"Olá, sou o(a) professor(a) {Nome}");
        }
    }
}