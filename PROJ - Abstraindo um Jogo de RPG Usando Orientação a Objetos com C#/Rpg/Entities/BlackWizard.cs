using Rpg.Enums;

namespace Rpg
{
    public class BlackWizard : Personagem
    {
        public BlackWizard(){}
        public BlackWizard(string name, int level, HeroArmour armour)
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
            if (bonus > 10)
            {
                return $"{Name} lançou magia MASTER EFETIVAS com {bonus} de bônus com o {Armour}.";
            }
            else
            {
                return $"{Name} lançou magia fraca com {bonus} de bônus.";
            }
        }
    }
}