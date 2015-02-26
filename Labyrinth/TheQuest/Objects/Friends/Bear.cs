using System;

namespace TheQuest
{
    public class Bear : Friend
    {
        private double battleStrength = 200;

        public Bear(string name, Location position)
            : base(name, position)
        {
            base.BattleStrength = this.battleStrength;
            base.symbol = "F";
            base.description = "Strong and fearless animal. A good friend to have on your side.";
        }
    }
}