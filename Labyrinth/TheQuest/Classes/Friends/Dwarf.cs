using System;

namespace TheQuest
{
    public class Dwarf : Character, IFriend
    {
        private bool _isAlive = true;
        private int _battleStrength;
        private char _symbol = 'D';
        private char p1;
        private string p2;
        private string p3;
        private Location location;

        public Dwarf(char symbol, string name, string description, Location position)
            : base(symbol, name, description, position)
        {
            this._battleStrength = 100;
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