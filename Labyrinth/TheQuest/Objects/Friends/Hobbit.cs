using System;

namespace TheQuest
{
    public abstract class Hobbit : Character, IFriend
    {
        public Hobbit(char symbol, string name, Location position, int healthPoints)
            : base(symbol, name, position, healthPoints)
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