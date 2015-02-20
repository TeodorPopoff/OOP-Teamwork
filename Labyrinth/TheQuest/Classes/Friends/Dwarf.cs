using System;

namespace TheQuest
{
    public class Dwarf : Character, IFriend, IMove
    {
        private bool isAlive;
        private int battleStrength;
        private char symbol = 'D';

        public Dwarf(string name, string description, Location position)
            : base(name, description, position)
        {
            this.battleStrength = 100;
        }

        public override bool IsAlive
        {
            get
            {
                return this.isAlive;
            }
        }

        public override char Symbol
        {
            get
            {
                return this.symbol;
            }
        }

        public int BattleStrength
        {
            get
            {
                return this.battleStrength;
            }

            set
            {
                this.battleStrength = value;
                if (this.battleStrength <= 0)
                {
                    this.isAlive = false;
                }
            }
        }

    }
}