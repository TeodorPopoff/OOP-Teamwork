namespace TheQuest
{
    public class Galadriel : IMagician
    {
        private bool _isAlive = true;
        private char _symbol = 'G';
        private int _presence;
        private int _spellPower;



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