namespace TheQuest
{
    public class Friend : Character, IFriend
    {
        private double battleStrength;

        public Friend(string name, Location position)
            :base(name, position)
        {

        }

        public virtual double BattleStrength
        {
            get
            {
                return this.battleStrength;
            }

            set
            {
                if (value <= 0)
                {
                    this.IsAlive = false;
                }
                this.battleStrength = value;
            }
        }
    }
}
