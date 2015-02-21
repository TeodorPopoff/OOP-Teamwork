using System;

namespace TheQuest
{
    public class Troll : Character, IEnemy
    {
        private int battleStrength = 40;
        private bool isAlive = true;

        public Troll(string name, Location position)
            : base(name, position)
        {
            base.symbol = "u+0047";
            base.description = "Trolls are a very large and monstrous (ranging from between 8 to 10 feet tall), and for the most part unintelligent (references are made about more cunning trolls[1]) humanoid race inhabiting Middle-earth.";
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