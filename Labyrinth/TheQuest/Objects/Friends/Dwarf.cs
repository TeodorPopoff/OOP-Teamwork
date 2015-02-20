using System;

namespace TheQuest
{
    public class Dwarf : Character, IFriend
    {
        private int battleStrength = 100;
        private bool isAlive = true;

        public Dwarf(string name, Location position)
            : base(name, position)
        {
            base.symbol = "u+26E8";
            base.description = "A strong warrior, fearsome in battle. Skilled with an axe and shield.";
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