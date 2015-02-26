using System;

namespace TheQuest
{
    public class Necromancer : Enemy, IMagician
    {
        private int presence;
        private double spellPower = 0.7;

        public Necromancer(Location position)
            : base("The Necromancer", position)
        {
            Random rnd = new Random();
            this.presence = rnd.Next(1, 4);
            base.BattleStrength = 250;
            base.symbol = "M";
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