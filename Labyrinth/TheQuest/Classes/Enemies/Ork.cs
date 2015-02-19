using System;

namespace TheQuest
{
    public class Ork : Character, IEnemy
    {
        public Ork(char symbol, string name, string description, Location position)
            : base(symbol, name, description, position)
        {
            
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