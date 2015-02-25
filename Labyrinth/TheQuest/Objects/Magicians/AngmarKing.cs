using System;


namespace TheQuest
{
    public class AngmarKing : Enemy, IMagician
    {
        private int presence;
        private double spellPower = 0.7;

        public AngmarKing(Location position)
            : base("The witch King of Angmar", position)
        {
            Random rnd = new Random();
            this.presence = rnd.Next(1, 4);
            base.BattleStrength = 200;
            base.symbol = "A";
            base.description = "The witch king of Angmar is the leader of the Nazgul. Legend says that no man can kill him...";
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