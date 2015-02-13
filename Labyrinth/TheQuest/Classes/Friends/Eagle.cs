using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheQuest
{
    public class Eagles : Item, IFly
    {
        public Eagles(string name, string description, Location position)
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

        int IFly.FlyingEffect
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