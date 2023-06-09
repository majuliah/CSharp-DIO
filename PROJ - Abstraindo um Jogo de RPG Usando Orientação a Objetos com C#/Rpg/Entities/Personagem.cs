using Rpg.Enums;

namespace Rpg
{
    public abstract class Personagem
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public HeroArmour Armour { get; set; }

        public Personagem(){}
        public Personagem(string name, int level, HeroArmour armour)
        {
            Name = name;
            Level = level;
            Armour = armour;
        }

        public abstract string Ataque();
        
        public override string ToString()
        {
            return $"Nome: {Name}, Nível: {Level}";
        }
    }
}