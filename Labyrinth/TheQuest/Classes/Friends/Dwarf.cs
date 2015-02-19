using System;

namespace TheQuest
{
    public class Dwarf : Character, IFriend
    {
        private bool _isAlive = true;
        private int _battleStrength;
        private char _symbol = 'D';

        public Dwarf(string name, string description, Location position)
            : base(name, description, position)
        {
            this._battleStrength = 100;
        }

        public override bool IsAlive
        {
            get
            {
                return this._isAlive;
            }
        }

        public override char Symbol
        {
            get
            {
                return this._symbol;
            }
        }

        public int BattleStrength
        {
            get
            {
                return this._battleStrength;
            }

            set
            {
                this._battleStrength = value;
                if (this._battleStrength <= 0)
                {
                    this._isAlive = false;
                }
            }
        }
    }
}