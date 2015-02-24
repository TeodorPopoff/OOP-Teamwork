using System;

namespace TheQuest
{
    public sealed class Tauriel : Elf, IMagician
    {
        private bool _isAlive = true;
        private char _symbol = 'T';
        private int _presence;
        private int _spellPower;
        private static Location _position;
        private static readonly Lazy<Tauriel> hero = new Lazy<Tauriel>(() => new Tauriel("Elrond", Position));

        public static Tauriel Instance { get { return hero.Value; } }

        public Tauriel(string name, Location position)
            : base(name, position)
        {
            _presence = 20;
            _spellPower = 200;
        }

        public bool IsAlive
        {
            get
            {
                return this._isAlive;
            }
        }

        public static Location Position
        {
            get { return _position; }
            set { _position = value; }
        }

        public double SpellPower
        {
            get { return this._spellPower; }
        }

        public int Presence
        {
            get { return _presence; }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Presence cannot be negative.");
                }

                _presence = value;
            }
        }
    }
}