using System;

namespace TheQuest
{
    public class Goblin : Enemy
    {
        private int battleStrength = 80;

        public Goblin(string name, Location position)
            : base(name, position)
        {
            base.BattleStrength = this.battleStrength;
            base.symbol = "U+1F47A";
            base.description = " They lived deep under the Misty Mountains in many strongholds, ever since the War of Wrath in the First Age. They are big, ugly creatures, cruel, wicked, and bad-hearted.";
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