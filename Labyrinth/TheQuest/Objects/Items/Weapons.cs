using System;

namespace TheQuest
{
    public class Weapons : Item, IWeapon
    {
        private int strengthEffect = 500;

        public Weapons(Location position)
            : base("Weapons", position)
        {
            base.symbol = "We";
            base.description = "This item increases the might of our team in battle.";
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