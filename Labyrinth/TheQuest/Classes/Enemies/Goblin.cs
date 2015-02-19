using System;

namespace TheQuest
{
    public class Goblin : Character, IEnemy
    {
        public Goblin(char symbol, string name, string description, Location position)
            : base(symbol, name, description, position)
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

    }
}