using System;

namespace TheQuest
{
    public class Bear : Character, IFriend
    {
        private int battleStrength = 200;
        private bool isAlive = true;

        public Bear(string name, Location position)
            : base(name, position)
        {
            base.symbol = "U+1F43E";
            base.description = "Strong and fearless animal. A good friend to have on your side.";
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