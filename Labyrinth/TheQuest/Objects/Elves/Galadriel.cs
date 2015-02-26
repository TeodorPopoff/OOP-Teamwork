using System;

namespace TheQuest
{
    public sealed class Galadriel : Elf, IMagician
    {
        private bool _isAlive = true;
        private int _presence;
        private double _spellPower;
        private static Location _position;
        private static Galadriel hero;

        public static Galadriel GetInstance(Location position)
        {
            if (Galadriel.hero == null)
            {
                Galadriel.hero = new Galadriel(position);
                return Galadriel.hero;
            }
            else
            {
                return Galadriel.hero;
            }
        }

        private Galadriel(Location position)
            : base("Galadriel", position)
        {
            Random rnd = new Random();
            _presence = rnd.Next(1, 5);
            _spellPower = 1.4;
            base.symbol = "E";
            base.description = "She is one of the greatest of the Eldar, surpassing nearly all others in beauty, knowledge, and power.";
            base.BattleStrength = 270;
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