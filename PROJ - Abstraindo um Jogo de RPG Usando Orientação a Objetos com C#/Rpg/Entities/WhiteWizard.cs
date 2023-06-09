using Rpg.Enums;

namespace Rpg
{
    public class WhiteWizard : Personagem
    {
        public WhiteWizard(){}
        public WhiteWizard(string name, int level, HeroArmour armour)
        {
            Name = name;
            Level = level;
            Armour = armour;
        }

        public override string Ataque()
        {
            return $"{Name} lançou magia!";
        }

        public string Ataque(int bonus)
        {
            if (bonus > 6)
            {
                return $"{Name} lançou magia SUPER EFETIVAS com {bonus} de bônus com a {Armour}s.";
            }
            else
            {
                return $"{Name} lançou magia fraca com {bonus} de bônus.";
            }
        }
    }
}