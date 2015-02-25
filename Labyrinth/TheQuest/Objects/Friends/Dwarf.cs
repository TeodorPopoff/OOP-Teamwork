using System;

namespace TheQuest
{
    public class Dwarf : Friend
    {
        private double battleStrength = 100;

        public Dwarf(string name, Location position)
            : base(name, position)
        {
            base.BattleStrength = this.battleStrength;
            base.symbol = "D";
            base.description = "A strong warrior, fearsome in battle. Skilled with an axe and shield.";
        }
    }
}