using Rpg.Enums;

namespace Rpg
{
    public class Ninja : Personagem
    {
        public Ninja(){}
        public Ninja(string name, int level, HeroArmour armour)
        {
            Name = name;
            Level = level;
            Armour = armour;
        }
        public override string Ataque()
        {
            return $"{Name} atacou coms katana!";
        }
        
        public string Ataque(int bonus)
        {
            if (bonus > 5)
            {
                return $"{Name} lançou um ataque SUPER EFETIVO com {bonus} de bônus com a {Armour}.";
            }
            else
            {
                return $"{Name} lançou um ataque fraco com {bonus} de bônus.";
            }
        }
    }
}