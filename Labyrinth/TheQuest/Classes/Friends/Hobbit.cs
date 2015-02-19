using System;

namespace TheQuest
{
    public abstract class Hobbit : Character, IFriend
    {
        public Hobbit(char symbol, string name, string description, Location position)
            : base(symbol, name, description, position)
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