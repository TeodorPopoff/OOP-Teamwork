using System;

namespace TheQuest
{
    public class Food : Item, IFood
    {
        private double strengthEffect = 300;

        public Food(Location position)
            : base("Food", position)
        {
            base.symbol = "I";
            base.description = "This item increases the strength of our team.";
        }


        public double StrengthEffect
        {
            get
            {
                return this.strengthEffect;
            }
        }
    }
}