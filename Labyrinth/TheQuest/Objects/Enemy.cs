namespace TheQuest
{
    public class Enemy : Character, IEnemy
    {
        private double battleStrength;

        public Enemy(string name, Location position)
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
