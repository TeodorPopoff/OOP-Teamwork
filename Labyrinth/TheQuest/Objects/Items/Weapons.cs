using System;

namespace TheQuest
{
    public class Weapons : Item, IWeapon
    {
        private double strengthEffect = 500;

        public Weapons(Location position)
            : base("Weapons", position)
        {
            base.symbol = "We";
            base.description = "This item increases the might of our team in battle.";
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