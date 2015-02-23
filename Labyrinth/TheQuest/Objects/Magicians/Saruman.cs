using System;

namespace TheQuest
{
    public class Saruman : Friend, IMagician
    {
        private int battleStrength = 250;
        private int presence;
        private double spellPower = 1.4;

        public Saruman(string name, Location position)
            : base(name, position)
        {
            Random rnd = new Random();
            this.presence = rnd.Next(1, 4);
            base.symbol = "U+1F3A9";
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