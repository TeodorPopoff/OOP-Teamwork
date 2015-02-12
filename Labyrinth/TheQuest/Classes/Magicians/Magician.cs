using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheQuest
{
    public abstract class Magician : Character, IMagician, IMovable
    {
        public void MoveToNewRandomLocation()
        {
            throw new System.NotImplementedException();
        }
    }
}