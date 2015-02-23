using System;

namespace TheQuest
{
    public class Bear : Friend
    {
        private int battleStrength = 200;

        public Bear(string name, Location position)
            : base(name, position)
        {
            base.BattleStrength = this.battleStrength;
            base.symbol = "B";
            base.description = "Strong and fearless animal. A good friend to have on your side.";
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