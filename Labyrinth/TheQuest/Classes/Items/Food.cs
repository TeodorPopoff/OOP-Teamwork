using System;

namespace TheQuest
{
    public class Food : Item, IFood
    {
        public Food(char symbol, string name, string description, Location position)
            : base(symbol, name, description, position)
        {
            
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