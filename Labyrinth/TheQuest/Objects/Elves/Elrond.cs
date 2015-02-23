using System;

namespace TheQuest
{
    public sealed class Elrond : Elf, IMagician
    {
        private bool _isAlive = true;
        private char _symbol = 'E';
        private int _presence;
        private int _spellPower;
        private static Location _position;
        private static readonly Lazy<Elrond> hero = new Lazy<Elrond>(() => new Elrond("Elrond", Position));

        public static Elrond Instance { get { return hero.Value; } }

        public Elrond(string name, Location position)
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