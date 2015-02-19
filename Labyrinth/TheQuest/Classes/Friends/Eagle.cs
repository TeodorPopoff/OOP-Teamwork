using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheQuest
{
    public class Eagles : Item, IFly
    {
        public Eagles(char symbol, string name, string description, Location position)
            : base(symbol, name, description, position)
        {
            
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