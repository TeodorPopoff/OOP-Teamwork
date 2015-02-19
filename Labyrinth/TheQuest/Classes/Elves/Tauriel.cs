namespace TheQuest
{
    public class Tauriel : Elve
    {
        private bool _isAlive = true;
        private char _symbol = 'T';

        public Tauriel(string name, string description, Location position)
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