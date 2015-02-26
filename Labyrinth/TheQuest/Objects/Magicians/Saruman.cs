using System;

namespace TheQuest
{
    public class Saruman : Friend, IMagician
    {
        private int presence;
        private double spellPower = 1.4;

        public Saruman(Location position)
            : base("Saruman the White", position)
        {
            Random rnd = new Random();
            this.presence = rnd.Next(1, 4);
            base.BattleStrength = 230;
            base.symbol = "M";
            base.description = "Saruman the White they call him. Powerful wizzard with a power over the minds of others.";
        }

        public int Presence
        {
            get
            {
                return this.presence;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Presence cannot be negative.");
                }
                this.presence = value;
            }
        }

        public double SpellPower
        {
            get
            {
                return this.spellPower;
            }
        }
    }
}