using System;

namespace TheQuest
{
    public class Dwarf : Friend
    {
        private int battleStrength = 100;

        public Dwarf(string name, Location position)
            : base(name, position)
        {
            base.BattleStrength = this.battleStrength;
            base.symbol = "u+26E8";
            base.description = "A strong warrior, fearsome in battle. Skilled with an axe and shield.";
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
                return base.symbol;
            }
        }
    }
}