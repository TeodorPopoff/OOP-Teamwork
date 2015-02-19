﻿namespace TheQuest
{
    public class Legolas : Elve
    {
        private bool _isAlive = true;
        private char _symbol = 'L';

        public Legolas(string name, string description, Location position)
            : base(name, description, position)
        {
            
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
    }
}