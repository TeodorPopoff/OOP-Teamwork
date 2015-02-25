using System;

namespace TheQuest
{
    public class Ork : Enemy
    {
        private double battleStrength = 60;

        public Ork(string name, Location position)
            : base(name, position)
        {
            base.BattleStrength = this.battleStrength;
            base.symbol = "O";
            base.description = "Orcs were the most commonplace villains serving the Dark Powers, a race of sentient beings bred by the evil Vala Melkor during the time of the Great Darkness. The Dark Lord Sauron, and later the wizard Saruman, also bred them and used them as soldiers and henchmen to do various evil deeds across Middle-earth.";
        }
    }


}