using System;

namespace TheQuest
{
    public sealed class Elrond : Elf, IMagician
    {
        private bool _isAlive = true;
        private int _presence;
        private double _spellPower;
        private static Location _position;
        private static Elrond hero;


        public static Elrond GetInstance(Location position)
        {
            if (Elrond.hero == null)
            {
                Elrond.hero = new Elrond(position);
                return Elrond.hero;
            }
            else
            {
                return Elrond.hero;
            }
        }

        private Elrond(Location position)
            : base("Elrond", position)
        {
            Random rnd = new Random();
            _presence = rnd.Next(1, 4);
            _spellPower = 1.3;
            base.symbol = "El";
            base.description = "Lord of Rivendell, and one of the mighty rulers in Middle-earth.";
            base.BattleStrength = 230;
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