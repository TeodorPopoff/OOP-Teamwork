﻿using System;

namespace TheQuest
{
    public class Weapons : Item, IWeapon
    {
        private int strengthEffect = 500;

        public Weapons(Location position)
            : base("Weapons", position)
        {
            base.symbol = "U+2694";
            base.description = "This item increases the might of our team in battle.";
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

        public int StrengthEffect
        {
            get
            {
                return this.strengthEffect;
            }
        }
    }
}