using System;

namespace TheQuest
{
    public class Goblin : Character, IEnemy
    {
        public Goblin(string name, string description, Location position)
            : base(name, description, position)
        {
            
        }

        public int BattleStrength
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
    }
}