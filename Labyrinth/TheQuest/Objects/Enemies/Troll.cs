using System;

namespace TheQuest
{
    public class Troll : Enemy
    {
        private double battleStrength = 200;

        public Troll(string name, Location position)
            : base(name, position)
        {
            base.BattleStrength = this.battleStrength;
            base.symbol = "R";
            base.description = "Trolls are a very large and monstrous (ranging from between 8 to 10 feet tall), and for the most part unintelligent (references are made about more cunning trolls[1]) humanoid race inhabiting Middle-earth.";
        }
    }
}