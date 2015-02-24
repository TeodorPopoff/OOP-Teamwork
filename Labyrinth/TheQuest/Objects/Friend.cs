namespace TheQuest
{
    public class Friend : Character, IFriend
    {
        private int battleStrength;

        public Friend(string name, Location position)
            :base(name, position)
        {

        }

        public virtual int BattleStrength
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

        public override string Description
        {
            get
            {
                return base.Description;
            }
        }

    }
}
