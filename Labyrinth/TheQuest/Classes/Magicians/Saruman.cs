using System;

namespace TheQuest
{
    public class Saruman : Magician, IFriend
    {
        public Saruman(char symbol, string name, string description, Location position)
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