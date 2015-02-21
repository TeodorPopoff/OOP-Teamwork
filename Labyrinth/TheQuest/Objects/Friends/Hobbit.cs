using System;

namespace TheQuest
{
    public abstract class Hobbit : Character, IFriend
    {
        private int battleStrength = 50;
        private bool isAlive = true;

        protected Hobbit(string name, Location position)
            : base(name, position)
        {
            base.symbol = "U+AB58";
            base.description = "A small creature, not trained for combat. But good companion nonethless for it is intelligent and capable of brightenning the mood of the whole company.";
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

        public override string Symbol
        {
            get
            {
                return base.symbol;
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