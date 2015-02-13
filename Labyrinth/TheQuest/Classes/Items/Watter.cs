using System;

namespace TheQuest
{
    public class Horses : Item, IRide
    {
        public Horses(string name, string description, Location position)
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

        int IRide.RidingEffect
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