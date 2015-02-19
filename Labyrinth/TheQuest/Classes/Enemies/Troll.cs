using System;

namespace TheQuest
{
    public class Troll : Character, IEnemy
    {
        public Troll(char symbol, string name, string description, Location position)
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