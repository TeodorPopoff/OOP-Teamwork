using System;

namespace TheQuest
{
    public abstract class Elve : Character, IFriend, IMove
    {
        public Elve(string name, string description, Location position)
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