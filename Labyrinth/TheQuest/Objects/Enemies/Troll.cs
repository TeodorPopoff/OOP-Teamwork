using System;

namespace TheQuest
{
    public class Troll : Enemy
    {
        private int battleStrength = 40;

        public Troll(string name, Location position)
            : base(name, position)
        {
            base.BattleStrength = this.battleStrength;
            base.symbol = "u+0047";
            base.description = "Trolls are a very large and monstrous (ranging from between 8 to 10 feet tall), and for the most part unintelligent (references are made about more cunning trolls[1]) humanoid race inhabiting Middle-earth.";
        }

        public override string Description
        {
            get
            {
                return base.description;
            }
        }

        public override string Symbol
        {
            get
            {
                return base.Symbol;
            }
        }
    }
}