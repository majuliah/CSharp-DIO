using Rpg.Enums;

using static System.Console;

namespace Rpg
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Abstraindo um jogo de RPG usando Orientação a Objetos");

            Knight Arus = new Knight($"Arus", 23, HeroArmour.Espada);
            WhiteWizard Jennica = new WhiteWizard($"Jennica", 23, HeroArmour.Varinha);
            Ninja Artorias = new Ninja($"Artorias", 23, HeroArmour.Katana);
            BlackWizard Darius = new BlackWizard($"Darius", 30, HeroArmour.Cajado);
            
            WriteLine(Jennica.Ataque(12));
            WriteLine(Arus.Ataque(5));
            WriteLine(Artorias.Ataque(5));
            WriteLine(Darius.Ataque(25));
        }
    }
}