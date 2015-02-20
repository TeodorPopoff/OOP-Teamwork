using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheQuest
{
    public class Eagles : Item, IFly
    {
        public Eagles(char symbol, string name, Location position)
            : base(symbol, name, position)
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