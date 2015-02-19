namespace TheQuest
{
    public class Galadriel : Elve, IMagician
    {
        private bool _isAlive = true;
        private char _symbol = 'G';
        private int _presence;
        private int _spellPower;

        public Galadriel(char symbol, string name, string description, Location position)
            : base(symbol, name, description, position)
        {
            
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