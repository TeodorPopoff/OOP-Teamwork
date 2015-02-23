using System;

namespace TheQuest
{
    public class Ork : Enemy
    {
        private int battleStrength = 60;

        public Ork(string name, Location position)
            : base(name, position)
        {
            base.BattleStrength = this.battleStrength;
            base.symbol = "U+1F47A";
            base.description = "Orcs were the most commonplace villains serving the Dark Powers, a race of sentient beings bred by the evil Vala Melkor during the time of the Great Darkness. The Dark Lord Sauron, and later the wizard Saruman, also bred them and used them as soldiers and henchmen to do various evil deeds across Middle-earth.";
        }

        public override string Description
        {
            get
            {
                return base.description;
            }
        }

        public override string Symbol
        {
            get
            {
                return base.Symbol;
            }
        }
    }


}