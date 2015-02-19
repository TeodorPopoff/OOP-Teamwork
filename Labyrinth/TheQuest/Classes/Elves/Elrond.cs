namespace TheQuest
{
    public class Elrond : Elve, IMagician
    {
        private bool _isAlive = true;
        private char _symbol = 'E';
        private int _presence;
        private int _spellPower;

        public Elrond(char symbol, string name, string description, Location position)
            : base(symbol, name, description, position)
        {
            _presence = 20;
            _spellPower = 200;
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