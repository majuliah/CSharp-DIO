using static System.Console;

namespace ClassesAbstraraseInterfaces.Models
{
    public class Professor : Pessoa
    {
        
        
        public sealed override void Apresentar()
        {
            WriteLine($"Eu sou o(A) professor(a) {Nome}");
        }
        
    }
}