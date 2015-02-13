using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheQuest
{
    public class Tauriel : Elve, IFriend
    {
        public Tauriel(string name, string description, Location position)
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