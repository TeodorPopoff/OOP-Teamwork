using System;

namespace TheQuest
{
    public abstract class Magician : Character, IMagician
    {
        public Magician(string name, string description, Location position)
            : base(name, description, position)
        {
            
        }

        int IMagician.Presence
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

        int IMagician.SpellPower
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

        public void MoveToNewRandomLocation()
        {
            throw new System.NotImplementedException();
        }
    }
}