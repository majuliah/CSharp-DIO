using Rpg.Enums;

namespace Rpg
{
    public class Knight : Personagem
    {
        public Knight(){}
        public Knight(string name, int level, HeroArmour armour)
        {
            Name = name;
            Level = level;
            Armour = armour;
        }
        public override string Ataque()
        {
            return $"{Name} atacou com espada!";
        }
        
        public string Ataque(int bonus)
        {
            if (bonus > 6)
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