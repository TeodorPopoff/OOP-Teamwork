using System;

namespace TheQuest
{
    public class Necromancer : Enemy, IMagician
    {
        private int battleStrength = 200;
        private int presence;
        private double spellPower = 0.7;

        public Necromancer(string name, Location position)
            : base(name, position)
        {
            Random rnd = new Random();
            this.presence = rnd.Next(1, 4);
            base.symbol = "U+1F440";
            base.description = "The evil master of Dol Goldur. ";
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