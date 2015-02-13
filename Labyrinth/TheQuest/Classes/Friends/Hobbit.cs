using System;

namespace TheQuest
{
    public abstract class Hobbit : Character, IFriend
    {
        public Hobbit(string name, string description, Location position)
            : base(name, description, position)
        {
            
        }

        int IFriend.BattleStrength
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