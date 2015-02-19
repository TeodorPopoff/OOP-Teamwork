namespace TheQuest
{
    public abstract class Elve : Character, IFriend
    {
        private int _battleStrength;

        public Elve(string name, string description, Location position)
            : base(name, description, position)
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