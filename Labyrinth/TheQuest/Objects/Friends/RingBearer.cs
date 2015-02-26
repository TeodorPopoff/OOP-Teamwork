using System;

namespace TheQuest
{
    public class RingBearer : Hobbit, ISpy
    {
        private double battleStrength = 50;
        //what range around us it will uncover if we use it.
        private int range = 5;
        //how many times it can do it.
        private int timesSpyEffect = 3;

        //Attach a delegate here that will do the actual uncovering of the battlefied:
        public Action<Location, int> UncoverBattlefield; 

        public RingBearer(Location position)
            : base("Bilbo Baggins", position)
        {
            base.BattleStrength = this.battleStrength;
            base.symbol = "B";
            base.description = "This hobbit is special. He has a secret - he has a ring that makes him invisible!";
        }

        public int Range
        {
            get
            {
                return this.range;
            }
        }

        public int Times
        {
            get
            {
                return this.timesSpyEffect;
            }
        }

        public void Spy()
        {
            this.UncoverBattlefield(this.Position, this.range);
            this.timesSpyEffect--;
        }
    }
}