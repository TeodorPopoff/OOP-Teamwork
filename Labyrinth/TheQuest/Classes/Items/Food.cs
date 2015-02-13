using System;

namespace TheQuest
{
    public class Food : Item, IFood
    {
        public Food(string name, string description, Location position)
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

        int IFood.StrengthEffect
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