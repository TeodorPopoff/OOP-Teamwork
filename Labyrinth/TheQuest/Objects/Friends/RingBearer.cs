using System;

namespace TheQuest
{
    public class RingBearer : Hobbit, IFriend, ISpy
    {
        private int battleStrength = 50;
        private bool isAlive = true;
        //what range around us it will uncover if we use it.
        private int range = 5;
        //how many times it can do it.
        private int timesSpyEffect = 3;

        //Attach a delegate here that will do the actual uncovering of the battlefied:
        public Action<Location, int> UncoverBattlefield; 

        public RingBearer(Location position)
            : base("Bilbo Baggins", position)
        {
            base.symbol = "U+1F48D";
            base.description = "This hobbit is special. He has a secret - he has a ring that makes him invisible!";
        }

        public override bool IsAlive
        {
            get
            {
                return this.IsAlive;
            }
        }

        public override string Description
        {
            get
            {
                return base.description;
            }
        }

        public override string Symbol
        {
            get
            {
                return base.symbol;
            }
        }

        public override int BattleStrength
        {
            get
            {
                return this.battleStrength;
            }

            set
            {
                if (value <= 0)
                {
                    this.isAlive = false;
                }
                this.battleStrength = value;
            }
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