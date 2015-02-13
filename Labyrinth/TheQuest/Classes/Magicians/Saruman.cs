using System;

namespace TheQuest
{
    public class Saruman : Magician, IFriend
    {
        public Saruman(string name, string description, Location position)
            : base(name, description, position)
        {
            
        }

        public override bool IsAlive
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override char Symbol
        {
            get
            {
                throw new NotImplementedException();
            }
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