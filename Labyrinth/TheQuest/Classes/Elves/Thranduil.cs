using System;

namespace TheQuest
{
    public class Thranduil : Elve, IFriend
    {
        public Thranduil(string name, string description, Location position)
            : base(name, description, position)
        {
            
        }

        public override bool IsAlive
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override char Symbol
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}