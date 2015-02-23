using System;

namespace TheQuest
{
    public abstract class Hobbit : Friend
    {
        private int battleStrength = 50;

        protected Hobbit(string name, Location position)
            : base(name, position)
        {
            base.BattleStrength = this.battleStrength;
            base.symbol = "H";
            base.description = "A small creature, not trained for combat. But good companion nonethless for it is intelligent and capable of brightenning the mood of the whole company.";
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