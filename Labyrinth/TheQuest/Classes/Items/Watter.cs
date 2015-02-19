using System;

namespace TheQuest
{
    public class Horses : Item, IRide
    {
        public Horses(char symbol, string name, string description, Location position)
            : base(symbol, name, description, position)
        {
            
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