using System;

namespace TheQuest
{
    public class Food : Item, IFood
    {
        private int strengthEffect = 300;

        public Food(Location position)
            : base("Food", position)
        {
            base.symbol = "Fo";
            base.description = "This item increases the strength of our team.";
        }

        public override string Description
        {
            get
            {
                return base.description;
            }
        }


        public int StrengthEffect
        {
            get
            {
                return this.strengthEffect;
            }
        }
    }
}