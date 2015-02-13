using System;


namespace TheQuest
{
    public class AngmarKing : Magician, IMagician, IEnemy
    {
        public AngmarKing(string name, string description, Location position)
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

        int IEnemy.BattleStrength
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