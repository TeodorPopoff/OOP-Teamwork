namespace TheQuest
{
    public class Galadriel : IMagician
    {
        private bool _isAlive = true;
        private char _symbol = 'G';
        private int _presence;
        private int _spellPower;



        public double SpellPower
        {
            get { return this._spellPower; }
        }

        int IMagician.Presence
        {
            get
            {
                return _presence;
            }
            set
            {
                this._presence = value;
            }
        }
    }
}