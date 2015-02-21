using System;

namespace TheQuest
{
    public class Ork : Character, IEnemy
    {
        private int battleStrength = 60;
        private bool isAlive = true;

        public Ork(string name, Location position)
            : base(name, position)
        {
            base.symbol = "u+0046";
            base.description = "Orcs were the most commonplace villains serving the Dark Powers, a race of sentient beings bred by the evil Vala Melkor during the time of the Great Darkness. The Dark Lord Sauron, and later the wizard Saruman, also bred them and used them as soldiers and henchmen to do various evil deeds across Middle-earth.";
        }

        public override bool IsAlive
        {
            get
            {
                return this.IsAlive;
            }
        }

        public override string Description
        {
            get
            {
                return base.description;
            }
        }

        public override int BattleStrength
        {
            get
            {
                return this.battleStrength;
            }

            set
            {
                if (value <= 0)
                {
                    this.isAlive = false;
                }
                this.battleStrength = value;
            }
        }
    }


}