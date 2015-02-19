namespace TheQuest
{
    public class Galadriel : Elve, IMagician
    {
        private bool _isAlive = true;
        private char _symbol = 'G';
        private int _presence;
        private int _spellPower;

        public Galadriel(string name, string description, Location position)
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

        public int SpellPower
        {
            get { return this._spellPower; }
        }

        public int Presence
        {
            get { return _presence; }
        }
    }
}