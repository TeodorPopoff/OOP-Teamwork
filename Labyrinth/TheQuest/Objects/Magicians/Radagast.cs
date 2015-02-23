using System;

namespace TheQuest
{
    public class Radagast : Friend, IMagician
    {
        private int battleStrength = 170;
        private int presence;
        private double spellPower = 1.15;

        public Radagast(string name, Location position)
            : base(name, position)
        {
            Random rnd = new Random();
            this.presence = rnd.Next(1, 8);
            base.symbol = "U+26F8";
            base.description = "Radagast the Brown they call him. Friend of all kinds of animals and living creatures.";
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