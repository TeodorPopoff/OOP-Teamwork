using System;

namespace TheQuest
{
    public class Sauron : Magician, IEnemy
    {
        public Sauron(char symbol, string name, string description, Location position)
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