using System;

namespace TheQuest
{
    public class Gandalf : Friend, IMagician
    {
        private int battleStrength = 200;
        private int presence;
        private double spellPower = 1.3;

        public Gandalf(string name, Location position)
            : base(name, position)
        {
            Random rnd = new Random();
            this.presence = rnd.Next(1, 8);
            base.symbol = "Ga";
            base.description = "Gandalf the Grey they call him. A wise and good natured magicion. True protector of our team.";
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