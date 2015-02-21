﻿using System;

namespace TheQuest
{
    public class Horses : Item, IRide
    {
        private int ridingEffect = 3;

        public Horses(Location position)
            : base("Horses", position)
        {
            base.symbol = "U+1F40E";
            base.description = "This item gives the team a prescious ability - to ride away from its enemies.";
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

        public int RidingEffect
        {
            get
            {
                return this.ridingEffect;
            }
        }
    }
}