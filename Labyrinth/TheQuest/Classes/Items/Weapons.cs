﻿using System;

namespace TheQuest
{
    public class Weapons : Item, IWeapon
    {
        public Weapons(string name, string description, Location position)
            : base(name, description, position)
        {
            
        }

        public override char Symbol
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        int IWeapon.StrengthEffect
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }
    }
}