using System;

namespace TheQuest
{
    public class Weapons : Item, IWeapon
    {
        public Weapons(char symbol, string name, string description, Location position)
            : base(symbol, name, description, position)
        {
            
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