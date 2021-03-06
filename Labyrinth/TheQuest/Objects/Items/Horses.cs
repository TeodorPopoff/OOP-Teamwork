﻿using System;

namespace TheQuest
{
    public class Horses : Item, IRide
    {
        private int ridingEffect = 3;

        public Horses(Location position)
            : base("Horses", position)
        {
            base.symbol = "I";
            base.description = "This item gives the team a prescious ability - to ride away from its enemies.";
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