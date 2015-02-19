namespace TheQuest
{
    public abstract class Elve : Character, IFriend
    {
        private int _battleStrength;

        public Elve(char symbol, string name, string description, Location position)
            : base(symbol, name, description, position)
        {
        }

        public int BattleStrength
        {
            get
            {
                return this._battleStrength;
            }

            set
            {
                this._battleStrength = 90;
            }
        }
    }
}