using System;

namespace TheQuest
{
    public abstract class Magician : Character
    {
        public Magician(char symbol, string name, string description, Location position)
            : base(symbol, name, description, position)
        {
            
        }
    }
}